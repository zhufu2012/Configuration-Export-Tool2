using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    public class ObjectBottomBar
    {
        #region 参数及初始化
        /// <summary>        
        /// 底部栏id
        /// </summary>
        public int BottomBarId { get; set; }
        /// <summary>        
        /// 底部栏位置偏移
        ///(X,Y)
        /// </summary>
        public Vector2 BottomBarOffset { get; set; }

        public ObjectBottomBar(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_ObjectBottomBar, id);//public const string Config_ObjectBottomBar = "cfg_ObjectBottomBar"; 
			BottomBarId = (int)dict["BottomBarId"];
			BottomBarOffset = (Vector2)dict["BottomBarOffset"];
        }

        public ObjectBottomBar(Dictionary<string, object> dict)
        {
			BottomBarId = (int)dict["BottomBarId"];
			BottomBarOffset = (Vector2)dict["BottomBarOffset"];
        }
        #endregion
    }
}
