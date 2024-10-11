using System.Collections.Generic;
namespace Remnant_Afterglow
{
    /// <summary>
    /// 自动生成的配置类 TestTowerAttr 用于 炮塔属性,拓展请在expand_class文件下使用partial拓展
    /// </summary>
    public partial class TestTowerAttr
    {
        #region 参数及初始化
        /// <summary>        
        /// 炮塔Id
        /// </summary>
        public int Tower_Id { get; set; }
        /// <summary>        
        /// 显示文本
        /// </summary>
        public language_id Attr_Name { get; set; }
        /// <summary>        
        /// 属性描述
        /// </summary>
        public language_id Attr_Description { get; set; }

        public TestTowerAttr(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_TestTowerAttr, id);//public const string Config_TestTowerAttr = "cfg_TestTowerAttr"; 
			Tower_Id = (int)dict["Tower_Id"];
			Attr_Name = (language_id)dict["Attr_Name"];
			Attr_Description = (language_id)dict["Attr_Description"];
			InitData();
        }

        
        public TestTowerAttr(string cfg_id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_TestTowerAttr, cfg_id);//public const string Config_TestTowerAttr = "cfg_TestTowerAttr"; 
			Tower_Id = (int)dict["Tower_Id"];
			Attr_Name = (language_id)dict["Attr_Name"];
			Attr_Description = (language_id)dict["Attr_Description"];
			InitData();
        }

        public TestTowerAttr(Dictionary<string, object> dict)
        {
			Tower_Id = (int)dict["Tower_Id"];
			Attr_Name = (language_id)dict["Attr_Name"];
			Attr_Description = (language_id)dict["Attr_Description"];
			InitData();
        }
        #endregion
    }
}
