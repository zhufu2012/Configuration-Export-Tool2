using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    public partial class ObjectSideBar
    {
        #region 参数及初始化
        /// <summary>        
        /// 侧边栏id
        /// </summary>
        public int SideBarId { get; set; }
        /// <summary>        
        /// 侧边栏位置偏移
        ///(X,Y)
        /// </summary>
        public Vector2 SideBarOffset { get; set; }

        public ObjectSideBar(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_ObjectSideBar, id);//public const string Config_ObjectSideBar = "cfg_ObjectSideBar"; 
			SideBarId = (int)dict["SideBarId"];
			SideBarOffset = (Vector2)dict["SideBarOffset"];
        }

        public ObjectSideBar(Dictionary<string, object> dict)
        {
			SideBarId = (int)dict["SideBarId"];
			SideBarOffset = (Vector2)dict["SideBarOffset"];
        }
        #endregion
    }
}
