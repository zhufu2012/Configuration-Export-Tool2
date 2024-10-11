import copy
import os
import shutil


##提取文件名
def extract_filename_without_extension(path):
    filename_with_extension = os.path.basename(path)
    # 使用 split 或者 rsplit 分割文件名和扩展名
    filename, extension = os.path.splitext(filename_with_extension)
    return filename


def get_class_name(table_name):
    return table_name[4:5].upper() + table_name[5:]


##导出配置类的静态路径类
##导出配置类的静态路径类
def export_config_constant(ConfigData, data_dict, result_dict, subtable_name_list2):
    subtable_name_list2 = copy.deepcopy(subtable_name_list2)
    # xlsx_name_list = [] ##[(xlsx_name,[table_name1,table_name2])]
    prefix_str = "namespace Remnant_Afterglow\n{    \n    //自动生成的静态类，用于管理配置的路径，请不要手动修改\n    public partial class ConfigConstant\n    {\n"
    suffix_str = "    }\n}"
    prefix_region_str = "        #region "
    suffix_region_str = "        #endregion\n"
    str = ""
    for xlsx_path in result_dict:  ##祝福注释
        table_name_list = list(result_dict[xlsx_path].keys())
        xlsx_name = extract_filename_without_extension(xlsx_path)
        region_str = xlsx_name + "\n"
        for table_name in table_name_list:
            xlsx_dec = ""
            subtable_names = ""
            for subtable_name in subtable_name_list2:
                if subtable_name.find(table_name) != -1:
                    if subtable_name.count("_") > 1:  # 存在两个以上_
                        subtable_names = subtable_name
                        xlsx_dec = subtable_name[subtable_name.rfind("_") + 1:]
                    break
            if subtable_names != "":
                subtable_name_list2.remove(subtable_names)
            region_str += f'        /// <summary>\n        /// {xlsx_dec}\n        /// </summary>\n'
            region_str += f'        public const string Config_{get_class_name(table_name)} = \"' + f'{table_name}\";\n'
        str += prefix_region_str + region_str + suffix_region_str + "        \n        \n"
    define_str = prefix_str + str + suffix_str  ##静态路径类
    dst_folder = ConfigData["ConfigConstant.cs复制到项目开发路径"]
    src_file = ConfigData["工具导出配置基础类静态路径类ConfigConstant.cs"]
    with open(src_file, 'w', encoding='utf-8') as file:
        file.write(define_str)
    shutil.copy2(src_file, dst_folder)


# 导出配置基础缓存类ConfigCache
def export_ConfigCache(ConfigData, data_dict, result_dict, subtable_name_list2):
    subtable_name_list2 = copy.deepcopy(subtable_name_list2)
    prefix_str = "using System.Collections.Generic;\nnamespace Remnant_Afterglow\n{    \n    /// <summary>\n    /// 自动生成的配置缓存代码，请不要手动修改\n    /// </summary>\n    public static partial class ConfigCache\n    {\n"
    suffix_str = "\n    }\n}"
    prefix_region_str = "        #region "
    suffix_region_str = "        #endregion\n"
    str = ""
    class_name_cache_list = []
    class_name_list = []
    for xlsx_path in result_dict:  ##祝福注释
        table_name_list = list(result_dict[xlsx_path].keys())
        xlsx_name = extract_filename_without_extension(xlsx_path)

        one_str = ""
        for table_name in table_name_list:
            if table_name in ConfigData["不自动生成基础缓存的配置表"]:
                continue
            xlsx_dec = ""
            subtable_names = ""
            for subtable_name in subtable_name_list2:
                if subtable_name.find(table_name) != -1:
                    if subtable_name.count("_") > 1:  # 存在两个以上_
                        subtable_names = subtable_name
                        xlsx_dec = subtable_name[subtable_name.rfind("_") + 1:]
                    break
            if subtable_names != "":
                subtable_name_list2.remove(subtable_names)
            class_name = get_class_name(table_name)
            class_name_cache = class_name + "_Cache"
            region_str = xlsx_dec + "配置缓存\n"
            region_str += f'        /// <summary>\n        /// {xlsx_dec}配置缓存\n        /// </summary>\n'
            region_str += f'        private static readonly Dictionary<string, {class_name}> {class_name_cache} = new Dictionary<string, {class_name}>();\n'
            # region_str += f'        /// <summary>\n        /// 清理{xlsx_dec}配置缓存\n        /// </summary>\n'
            # region_str += f'        public static void Clear{class_name}Cache()\n' + '        {\n' + f'            {class_name_cache}.Clear();\n' + '        }\n'
            region_str += f'        /// <summary>\n        /// 提前加载所有{xlsx_dec}配置缓存\n        /// </summary>\n'
            region_str += (f'        public static void Load{class_name}()\n' + '        {\n' +
                           f'            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_{class_name});\n' +
                           '            foreach (var val in cfg_dict)\n            {\n' +
                           f'                {class_name} data = new {class_name}(val.Value);\n' +
                           f'                data.InitData2();\n' +
                           f'                {class_name_cache}.Add(val.Key, data);\n' + '            }\n        }\n')
            region_str += f'        /// <summary>\n        /// 加载或获取已缓存的{xlsx_dec}基础配置缓存\n        /// </summary>\n'
            region_str += (f'        public static {class_name} Get{class_name}(string cfgId)\n' + '        {\n' +
                           f'            if (!{class_name_cache}.TryGetValue(cfgId, out var data))\n' + '            {\n' +
                           f'                data = new {class_name}(cfgId);\n' +
                           f'                data.InitData2();\n' +
                           f'                {class_name_cache}.Add(cfgId, data);\n' +
                           '            }\n            return data;\n        }\n')
            region_str += (f'        public static {class_name} Get{class_name}(int cfgId)\n' + '        {\n' +
                           f'            if (!{class_name_cache}.TryGetValue("" + cfgId, out var data))\n' + '            {\n' +
                           f'                data = new {class_name}(cfgId);\n' +
                           f'                data.InitData2();\n' +
                           f'                {class_name_cache}.Add("" + cfgId, data);\n' +
                           '            }\n            return data;\n        }\n')
            region_str += f'        /// <summary>\n        /// 获取加载的所有{xlsx_dec}数据\n        /// </summary>\n'
            region_str += (f'        public static List<{class_name}> GetAll{class_name}()\n' + '        {\n' +
                           f'            List<{class_name}> list = new List<{class_name}>();\n' +
                           f'            foreach (var val in {class_name_cache})\n' + '            {\n' +
                           '                list.Add(val.Value);\n            }\n            return list;\n        }\n')
            one_str += prefix_region_str + region_str + suffix_region_str + "        \n        \n"
            class_name_cache_list.append(class_name_cache)
            class_name_list.append(class_name)
        str += one_str
    function_str = ""
    function_str += f'        /// <summary>\n        /// 提前加载所有界面基础配置配置缓存\n        /// </summary>\n'
    function_str += '        public static void LoadOtherCache()\n        {\n'
    for class_name in class_name_list:
        function_str += f"            Load{class_name}();\n"
    function_str += '        }'

    function_str2 = ""
    function_str2 += f'        /// <summary>\n        /// 清理所有缓存数据\n        /// </summary>\n'
    function_str2 += '        public static void ClearAllCache()\n        {\n'
    for class_name_cache in class_name_cache_list:
        function_str2 += f"            {class_name_cache}.Clear();\n"
    function_str2 += '        }'
    define_str = prefix_str + "\n" + function_str + "\n\n" + str + "\n\n" + function_str2 + suffix_str  ##静态路径类
    src_file = ConfigData["工具导出配置基础缓存类ConfigCache"]
    with open(src_file, 'w', encoding='utf-8') as file:
        file.write(define_str)
    shutil.copy2(src_file, ConfigData["ConfigCache.cs复制到项目开发路径"])
