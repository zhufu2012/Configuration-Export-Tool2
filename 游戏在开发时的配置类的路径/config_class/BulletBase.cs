using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    /// <summary>
    /// 自动生成的配置类 BulletBase 用于 子弹基础表,拓展请在expand_class文件下使用partial拓展
    /// </summary>
    public partial class BulletBase
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
			InitData();
        }

        
        public BulletBase(string cfg_id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_BulletBase, cfg_id);//public const string Config_BulletBase = "cfg_BulletBase"; 
			BulletId = (int)dict["BulletId"];
			BulletName = (string)dict["BulletName"];
			ObjectId = (int)dict["ObjectId"];
			BulletSize = (int)dict["BulletSize"];
			BulletPng = (Texture2D)dict["BulletPng"];
			InitData();
        }

        public BulletBase(Dictionary<string, object> dict)
        {
			BulletId = (int)dict["BulletId"];
			BulletName = (string)dict["BulletName"];
			ObjectId = (int)dict["ObjectId"];
			BulletSize = (int)dict["BulletSize"];
			BulletPng = (Texture2D)dict["BulletPng"];
			InitData();
        }
        #endregion
    }
}
