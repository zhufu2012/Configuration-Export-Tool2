namespace Remnant_Afterglow
{
    public class CameraAssembly
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
        }

        public CameraAssembly(Dictionary<string, object> dict)
        {
			AssemblyId = (int)dict["AssemblyId"];
			Type = (int)dict["Type"];
			Pparam = (int)dict["Pparam"];
			Offset = (Vector2)dict["Offset"];
        }
        #endregion
    }
}
