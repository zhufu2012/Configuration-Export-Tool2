using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    /// <summary>
    /// 自动生成的配置类 MapBrushMonster 用于 ,拓展请在expand_class文件下使用partial拓展
    /// </summary>
    public partial class MapBrushMonster
    {
        #region 参数及初始化
        /// <summary>        
        /// 地图id
        /// </summary>
        public int MapBrushId { get; set; }
        /// <summary>        
        /// 地图名称
        /// </summary>
        public string MapName { get; set; }
        /// <summary>        
        /// 地图基础描述
        /// </summary>
        public string MapBaseDescribe { get; set; }
        /// <summary>        
        /// 出生点坐标(加载好地图时
        ///相机的坐标)
        /// </summary>
        public Vector2 BornPoint { get; set; }
        /// <summary>        
        /// 相机初始配置
        /// </summary>
        public List<float> CameraBaseCfg { get; set; }
        /// <summary>        
        /// 相机配置
        /// </summary>
        public List<float> CameraCfg { get; set; }
        /// <summary>        
        /// 刷新点Id列表
        ///cfg_MapBrushPoint的地图刷新点id
        /// </summary>
        public List<int> BrushId_List { get; set; }
        /// <summary>        
        /// 地图内我方属性加成id列表
        ///我方属性加成id1|我方属性加成id2
        /// </summary>
        public List<int> M_AttributeId_List { get; set; }
        /// <summary>        
        /// 地图内敌方属性加成id列表
        ///敌方属性加成id1|敌方属性加成id2
        /// </summary>
        public List<int> E_AttributeId_List { get; set; }
        /// <summary>        
        /// 地图通关条件
        /// </summary>
        public List<List<int>> Pass_Condition { get; set; }

        public MapBrushMonster(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_MapBrushMonster, id);//public const string Config_MapBrushMonster = "cfg_MapBrushMonster"; 
			MapBrushId = (int)dict["MapBrushId"];
			MapName = (string)dict["MapName"];
			MapBaseDescribe = (string)dict["MapBaseDescribe"];
			BornPoint = (Vector2)dict["BornPoint"];
			CameraBaseCfg = (List<float>)dict["CameraBaseCfg"];
			CameraCfg = (List<float>)dict["CameraCfg"];
			BrushId_List = (List<int>)dict["BrushId_List"];
			M_AttributeId_List = (List<int>)dict["M_AttributeId_List"];
			E_AttributeId_List = (List<int>)dict["E_AttributeId_List"];
			Pass_Condition = (List<List<int>>)dict["Pass_Condition"];
			InitData();
        }

        
        public MapBrushMonster(string cfg_id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_MapBrushMonster, cfg_id);//public const string Config_MapBrushMonster = "cfg_MapBrushMonster"; 
			MapBrushId = (int)dict["MapBrushId"];
			MapName = (string)dict["MapName"];
			MapBaseDescribe = (string)dict["MapBaseDescribe"];
			BornPoint = (Vector2)dict["BornPoint"];
			CameraBaseCfg = (List<float>)dict["CameraBaseCfg"];
			CameraCfg = (List<float>)dict["CameraCfg"];
			BrushId_List = (List<int>)dict["BrushId_List"];
			M_AttributeId_List = (List<int>)dict["M_AttributeId_List"];
			E_AttributeId_List = (List<int>)dict["E_AttributeId_List"];
			Pass_Condition = (List<List<int>>)dict["Pass_Condition"];
			InitData();
        }

        public MapBrushMonster(Dictionary<string, object> dict)
        {
			MapBrushId = (int)dict["MapBrushId"];
			MapName = (string)dict["MapName"];
			MapBaseDescribe = (string)dict["MapBaseDescribe"];
			BornPoint = (Vector2)dict["BornPoint"];
			CameraBaseCfg = (List<float>)dict["CameraBaseCfg"];
			CameraCfg = (List<float>)dict["CameraCfg"];
			BrushId_List = (List<int>)dict["BrushId_List"];
			M_AttributeId_List = (List<int>)dict["M_AttributeId_List"];
			E_AttributeId_List = (List<int>)dict["E_AttributeId_List"];
			Pass_Condition = (List<List<int>>)dict["Pass_Condition"];
			InitData();
        }
        #endregion
    }
}
