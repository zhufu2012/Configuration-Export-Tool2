using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public partial class MapWall
    {
        #region 参数及初始化
        /// <summary>        
        /// 墙壁生成方式id
        /// </summary>
        public int WallId { get; set; }
        /// <summary>        
        /// 墙壁描述
        /// </summary>
        public string WallDescribe { get; set; }

        public MapWall(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_MapWall, id);//public const string Config_MapWall = "cfg_MapWall"; 
			WallId = (int)dict["WallId"];
			WallDescribe = (string)dict["WallDescribe"];
        }

        public MapWall(Dictionary<string, object> dict)
        {
			WallId = (int)dict["WallId"];
			WallDescribe = (string)dict["WallDescribe"];
        }
        #endregion
    }
}
