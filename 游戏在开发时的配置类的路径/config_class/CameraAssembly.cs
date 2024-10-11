using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    /// <summary>
    /// 自动生成的配置类 CameraAssembly 用于 相机组件表,拓展请在expand_class文件下使用partial拓展
    /// </summary>
    public partial class CameraAssembly
    {
        #region 参数及初始化
        /// <summary>        
        /// 相机组件id
        /// </summary>
        public int AssemblyId { get; set; }
        /// <summary>        
        /// 组件类型
        ///0 显示帧数
        ///1 噪声编辑器
        /// </summary>
        public int Type { get; set; }
        /// <summary>        
        /// 组件参数
        /// </summary>
        public int Pparam { get; set; }
        /// <summary>        
        /// 组件位置偏移
        ///(offset_right，offset_bottom)
        /// </summary>
        public Vector2 Offset { get; set; }

        public CameraAssembly(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_CameraAssembly, id);//public const string Config_CameraAssembly = "cfg_CameraAssembly"; 
			AssemblyId = (int)dict["AssemblyId"];
			Type = (int)dict["Type"];
			Pparam = (int)dict["Pparam"];
			Offset = (Vector2)dict["Offset"];
			InitData();
        }

        
        public CameraAssembly(string cfg_id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_CameraAssembly, cfg_id);//public const string Config_CameraAssembly = "cfg_CameraAssembly"; 
			AssemblyId = (int)dict["AssemblyId"];
			Type = (int)dict["Type"];
			Pparam = (int)dict["Pparam"];
			Offset = (Vector2)dict["Offset"];
			InitData();
        }

        public CameraAssembly(Dictionary<string, object> dict)
        {
			AssemblyId = (int)dict["AssemblyId"];
			Type = (int)dict["Type"];
			Pparam = (int)dict["Pparam"];
			Offset = (Vector2)dict["Offset"];
			InitData();
        }
        #endregion
    }
}
