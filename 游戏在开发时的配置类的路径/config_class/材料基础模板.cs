using System.Collections.Generic;
namespace Remnant_Afterglow
{
    /// <summary>
    /// 自动生成的配置类 材料基础模板 用于 测试,拓展请在expand_class文件下使用partial拓展
    /// </summary>
    public partial class 材料基础模板
    {
        #region 参数及初始化
        /// <summary>        
        /// 材料id
        /// </summary>
        public int Item_Id { get; set; }
        /// <summary>        
        /// 材料名称
        /// </summary>
        public string Item_Name { get; set; }
        /// <summary>        
        /// 材料基础描述
        /// </summary>
        public string Item_BaseDescribe { get; set; }
        /// <summary>        
        /// 材料具体描述
        /// </summary>
        public string Item_Describe { get; set; }
        /// <summary>        
        /// 材料类型
        /// </summary>
        public List<int> Item_Type { get; set; }
        /// <summary>        
        /// 单个材料价值
        /// </summary>
        public int Item_Value { get; set; }

        public 材料基础模板(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_材料基础模板, id);//public const string Config_材料基础模板 = "cfg_材料基础模板"; 
			Item_Id = (int)dict["Item_Id"];
			Item_Name = (string)dict["Item_Name"];
			Item_BaseDescribe = (string)dict["Item_BaseDescribe"];
			Item_Describe = (string)dict["Item_Describe"];
			Item_Type = (List<int>)dict["Item_Type"];
			Item_Value = (int)dict["Item_Value"];
			InitData();
        }

        
        public 材料基础模板(string cfg_id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_材料基础模板, cfg_id);//public const string Config_材料基础模板 = "cfg_材料基础模板"; 
			Item_Id = (int)dict["Item_Id"];
			Item_Name = (string)dict["Item_Name"];
			Item_BaseDescribe = (string)dict["Item_BaseDescribe"];
			Item_Describe = (string)dict["Item_Describe"];
			Item_Type = (List<int>)dict["Item_Type"];
			Item_Value = (int)dict["Item_Value"];
			InitData();
        }

        public 材料基础模板(Dictionary<string, object> dict)
        {
			Item_Id = (int)dict["Item_Id"];
			Item_Name = (string)dict["Item_Name"];
			Item_BaseDescribe = (string)dict["Item_BaseDescribe"];
			Item_Describe = (string)dict["Item_Describe"];
			Item_Type = (List<int>)dict["Item_Type"];
			Item_Value = (int)dict["Item_Value"];
			InitData();
        }
        #endregion
    }
}
