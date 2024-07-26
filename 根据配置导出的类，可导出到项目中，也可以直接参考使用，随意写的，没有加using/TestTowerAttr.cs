namespace Remnant_Afterglow
{
    public class TestTowerAttr
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
        }

        public TestTowerAttr(Dictionary<string, object> dict)
        {
			Tower_Id = (int)dict["Tower_Id"];
			Attr_Name = (language_id)dict["Attr_Name"];
			Attr_Description = (language_id)dict["Attr_Description"];
        }
        #endregion
    }
}
