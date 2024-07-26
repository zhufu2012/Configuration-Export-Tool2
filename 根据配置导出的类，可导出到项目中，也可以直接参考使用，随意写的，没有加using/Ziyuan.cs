namespace Remnant_Afterglow
{
    public class Ziyuan
    {
        #region 参数及初始化
        /// <summary>        
        /// 材料id
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>        
        /// 材料名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>        
        /// 材料描述
        /// </summary>
        public string ItemBaseDescribe { get; set; }
        /// <summary>        
        /// 材料图片
        /// </summary>
        public Texture2D ItemImg { get; set; }
        /// <summary>        
        /// 材料图片界面显示
        /// </summary>
        public Texture2D image { get; set; }

        public Ziyuan(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_Ziyuan, id);//public const string Config_Ziyuan = "cfg_ziyuan"; 
			ItemId = (int)dict["ItemId"];
			ItemName = (string)dict["ItemName"];
			ItemBaseDescribe = (string)dict["ItemBaseDescribe"];
			ItemImg = (Texture2D)dict["ItemImg"];
			image = (Texture2D)dict["image"];
        }

        public Ziyuan(Dictionary<string, object> dict)
        {
			ItemId = (int)dict["ItemId"];
			ItemName = (string)dict["ItemName"];
			ItemBaseDescribe = (string)dict["ItemBaseDescribe"];
			ItemImg = (Texture2D)dict["ItemImg"];
			image = (Texture2D)dict["image"];
        }
        #endregion
    }
}
