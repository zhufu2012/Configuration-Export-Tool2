
using GameLog;
using Godot;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using File = System.IO.File;

namespace Remnant_Afterglow
{
    public class ConfigDict
    {
        public string file_name { get; set; }
        public string file_path { get; set; }
        public Dictionary<string, string> key_list { get; set; }
    }

    public class ConfigFiles
    {
        public List<ConfigDict> cfg_files { get; set; }
        public override string ToString()
        {
            string result = "cinfig Files:\n";
            foreach (var file in cfg_files)
            {
                result += "文件名称: " + file.file_name + ", 文件路径: " +
                file.file_path + "\n";
            }
            return result;
        }
    }

    //配置加载器-加载游戏所有配置数据
    //配置加载器
    public partial class ConfigLoadSystem : Node
    {
        //配置数据
        public static List<ConfigDict> filedata;
        //子表-联合主键id-键值对
        public static Dictionary<string, Dictionary<string, Dictionary<string, object>>> config_dict
            = new Dictionary<string, Dictionary<string, Dictionary<string, object>>>();

        public ConfigLoadSystem()
        {
            LoadConfigDataAsync();
        }


        //异步加载配置
        private async void LoadConfigDataAsync()
        {
            //await Task.Run(() =>{

            //先读全局配置表
            //再读配置特殊功能表-cfg_ConfigCover_配置覆盖关系表

            //再读配置特殊功能表-cfg_ConfigCall_配置调用关系表

            LoadBaseConfigData();//加载基础配置
                                 //Log.PrintDict(GetCfgIndex("cfg_MapImageSet", "0_1"));


            //});
        }


        //加载基础配置
        public void LoadBaseConfigData()
        {
            string jsonText = File.ReadAllText(PathConstant.CONFIG_PATH_USER);
            ConfigFiles file_data = JsonConvert.DeserializeObject<ConfigFiles>(jsonText);
            filedata = file_data.cfg_files;
            //List<ForMatStr> format_str_list = new List<ForMatStr>();
            foreach (var cfgFile in filedata)
            {
                try
                {
                    string jsonstr = File.ReadAllText(cfgFile.file_path);
                    JArray jsonArray = JArray.Parse(jsonstr);
                    if (jsonArray.Count > 0)
                    {
                        Dictionary<string, Dictionary<string, object>> innerDict = new Dictionary<string, Dictionary<string, object>>();
                        foreach (JObject obj in jsonArray)
                        {
                            string keyIndex = obj["KEY_INDEX"].Value<string>();
                            Dictionary<string, object> dataDict = new Dictionary<string, object>();
                            foreach (var key in cfgFile.key_list.Keys)
                            {
                                if (obj.TryGetValue(key, out JToken value))
                                {
                                    string type = cfgFile.key_list[key];
                                    object convertedValue = ConvertValue(value, type);
                                    dataDict[key] = convertedValue;
                                }
                            }
                            innerDict[keyIndex] = dataDict;
                        }
                        config_dict[cfgFile.file_name] = innerDict;
                    }
                    else
                    {
                        config_dict[cfgFile.file_name] = new Dictionary<string, Dictionary<string, object>>();
                    }
                }
                catch (Exception e)
                {
                    Log.Print("配置报错！");

                }
            }
        }


        /// <summary>
        /// 读取全局默认配置,不是全局配置，这个只是默认配置
        /// </summary>
        public static object GetDefineCfg(string fileName, string Key)
        {
            object value = null;
            if (config_dict.ContainsKey(fileName))
            {
                if (config_dict[fileName].ContainsKey(Key))
                {
                    string type = (string)config_dict[fileName][Key]["ConfigType"];//数据类型
                }
            }
            return value;
        }



        /// <summary>
        /// 读取某配置 所有
        /// </summary>
        /// <param name="fileName">配置名称</param>
        /// <param name="Key">键</param>
        /// <returns></returns>
        public static Dictionary<string, Dictionary<string, object>> GetCfg(string fileName)
        {
            return config_dict.ContainsKey(fileName) ?
            config_dict[fileName] : null;
        }

        /// <summary>
        /// 读取某配置 某一行的数据
        /// </summary>
        /// <param name="fileName">配置名称</param>
        /// <param name="Key">键</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetCfgIndex(string fileName, string Index)
        {
            return config_dict.ContainsKey(fileName) &&
            config_dict[fileName].ContainsKey(Index) ?
            config_dict[fileName][Index] : null;
        }

        /// <summary>
        /// 读取某配置 某一行的数据
        /// </summary>
        /// <param name="fileName">配置名称</param>
        /// <param name="Key">键</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetCfgIndex(string fileName, int Index)
        {
            string index = "" + Index;
            return config_dict.ContainsKey(fileName) &&
            config_dict[fileName].ContainsKey(index) ?
            config_dict[fileName][index] : null;
        }

        /// <summary>
        /// 读取某配置 某一行的某个字段
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="Key"></param>
        /// <param name="Field"></param>
        /// <returns></returns>
        public static object GetCfgValue(string fileName, string Key, string Field)
        {
            return config_dict.ContainsKey(fileName) &&
           config_dict[fileName].ContainsKey(Key) &&
           config_dict[fileName][Key].ContainsKey(Field) ?
           config_dict[fileName][Key][Field] :
           null;
        }

        /// <summary>
        /// 查询所有满足条件的行的数据
        /// </summary>
        /// <param name="fileName">表名</param>
        /// <param name="key_dict">键与值的对应关系</param>
        /// <returns>满足条件的所有行数据</returns>
        public static List<Dictionary<string, object>> QueryCfgAllLine(string fileName, Dictionary<string, object> key_dict)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            if (config_dict.ContainsKey(fileName))//存在该表
            {
                //多行-键值对
                List<Dictionary<string, object>> allRows = config_dict[fileName].Values.ToList();
                foreach (var row in allRows)
                {
                    bool match = true;
                    foreach (var (Key, Value) in key_dict)
                    {
                        if (!row.TryGetValue(Key, out var key_value) || !key_value.Equals(Value))
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                        resultList.Add(row); ;
                }
            }
            return resultList;
        }

        /// <summary>
        /// 将数据按照对应类型转换
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private object ConvertValue(JToken value, string type)
        {
            switch (type)
            {
                case "language_id":////注释//-这里是语言id-获取的语言
                    return LanguageLoad.GetText(value.Value<string>());
                case "<language_id>":////注释//-这里是语言id列表-获取的语言
                    List<string> list = value.ToObject<List<string>>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = LanguageLoad.GetText(list[i]);
                    }
                    return list;
                case "Vector2"://坐标
                    List<float> list2 = value.ToObject<List<float>>();
                    return new Vector2(list2[0], list2[1]);
                case "Vector2I"://坐标
                    List<int> list3 = value.ToObject<List<int>>();
                    return new Vector2I(list3[0], list3[1]);
                case "Texture2D"://坐标
                    if (!value.Value<string>().Equals("null"))
                    {
                        Texture2D img = GD.Load<Texture2D>(value.Value<string>());
                        return img;
                    }
                    return null;
                case "List<Vector2>"://坐标列表
                    List<List<float>> list4 = value.ToObject<List<List<float>>>();
                    List<Vector2> poslist = new List<Vector2>();
                    for (int i = 0; i < list4.Count; i++)
                    {
                        List<float> list5 = list4[i];
                        poslist.Add(new Vector2(list5[0], list5[1]));
                    }
                    return poslist;
                case "ulong":
                    return value.Value<ulong>();
                case "bool":
                    return value.Value<bool>();
                //case "byte":
                //    return value.Value<byte>();
                case "short":
                    return value.Value<short>();
                case "int":
                    return value.Value<int>();
                case "long":
                    return value.Value<long>();
                case "float":
                    return value.Value<float>();
                case "string":
                    return value.Value<string>();
                case "List<bool>":
                    return value.ToObject<List<bool>>();
                //case "List<byte>":
                //    return value.ToObject<List<byte>>();
                case "List<short>":
                    return value.ToObject<List<short>>();
                case "List<int>":
                    return value.ToObject<List<int>>();
                case "List<long>":
                    return value.ToObject<List<long>>();
                case "List<float>":
                    return value.ToObject<List<float>>();
                case "List<string>":
                    return value.ToObject<List<string>>();
                case "List<List<bool>>":
                    return value.ToObject<List<List<bool>>>();
                //case "List<List<byte>>":
                //    return value.ToObject<List<List<byte>>>();
                case "List<List<short>>":
                    return value.ToObject<List<List<short>>>();
                case "List<List<int>>":
                    return value.ToObject<List<List<int>>>();
                case "List<List<long>>":
                    return value.ToObject<List<List<long>>>();
                case "List<List<float>>":
                    return value.ToObject<List<List<float>>>();
                case "List<List<string>>":
                    return value.ToObject<List<List<string>>>();
                // Add more cases for other types as needed
                default:
                    return value;
            }
        }


    }
}