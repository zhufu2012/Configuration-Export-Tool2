namespace Remnant_Afterglow
{
    public class BulletBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 子弹ID
        /// </summary>
        public int BulletId { get; set; }
        /// <summary>        
        /// 子弹名称
        /// </summary>
        public string BulletName { get; set; }
        /// <summary>        
        /// 实体id
        ///用于属性等配置(要求唯一)
        ///
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>        
        /// 子弹体积
        /// </summary>
        public int BulletSize { get; set; }
        /// <summary>        
        /// 子弹贴图
        /// </summary>
        public Texture2D BulletPng { get; set; }

        public BulletBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_BulletBase, id);//public const string Config_BulletBase = "cfg_BulletBase"; 
			BulletId = (int)dict["BulletId"];
			BulletName = (string)dict["BulletName"];
			ObjectId = (int)dict["ObjectId"];
			BulletSize = (int)dict["BulletSize"];
			BulletPng = (Texture2D)dict["BulletPng"];
        }

        public BulletBase(Dictionary<string, object> dict)
        {
			BulletId = (int)dict["BulletId"];
			BulletName = (string)dict["BulletName"];
			ObjectId = (int)dict["ObjectId"];
			BulletSize = (int)dict["BulletSize"];
			BulletPng = (Texture2D)dict["BulletPng"];
        }
        #endregion
    }
}
