namespace Remnant_Afterglow
{
    public class 材料类型模板
    {
        #region 参数及初始化
        /// <summary>        
        /// 材料类型id
        /// </summary>
        public int Item_Id { get; set; }
        /// <summary>        
        /// 材料类型名称
        /// </summary>
        public string Item_Name { get; set; }
        /// <summary>        
        /// 材料类型描述
        /// </summary>
        public string Item_BaseDescribe { get; set; }

        public 材料类型模板(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_材料类型模板, id);//public const string Config_材料类型模板 = "cfg_材料类型模板"; 
			Item_Id = (int)dict["Item_Id"];
			Item_Name = (string)dict["Item_Name"];
			Item_BaseDescribe = (string)dict["Item_BaseDescribe"];
        }

        public 材料类型模板(Dictionary<string, object> dict)
        {
			Item_Id = (int)dict["Item_Id"];
			Item_Name = (string)dict["Item_Name"];
			Item_BaseDescribe = (string)dict["Item_BaseDescribe"];
        }
        #endregion
    }
}
