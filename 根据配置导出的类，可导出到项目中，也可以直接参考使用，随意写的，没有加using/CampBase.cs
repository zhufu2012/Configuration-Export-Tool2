namespace Remnant_Afterglow
{
    public class CampBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 阵营id
        /// </summary>
        public int CampId { get; set; }
        /// <summary>        
        /// 阵营名称
        /// </summary>
        public string CampName { get; set; }
        /// <summary>        
        /// 阵营描述
        /// </summary>
        public string CampDes { get; set; }
        /// <summary>        
        /// 阵营标识图片
        /// </summary>
        public Texture2D CopyId { get; set; }

        public CampBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_CampBase, id);//public const string Config_CampBase = "cfg_CampBase"; 
			CampId = (int)dict["CampId"];
			CampName = (string)dict["CampName"];
			CampDes = (string)dict["CampDes"];
			CopyId = (Texture2D)dict["CopyId"];
        }

        public CampBase(Dictionary<string, object> dict)
        {
			CampId = (int)dict["CampId"];
			CampName = (string)dict["CampName"];
			CampDes = (string)dict["CampDes"];
			CopyId = (Texture2D)dict["CopyId"];
        }
        #endregion
    }
}
