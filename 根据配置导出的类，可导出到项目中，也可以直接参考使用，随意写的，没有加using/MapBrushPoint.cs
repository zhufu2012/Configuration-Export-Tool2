using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    public class MapBrushPoint
    {
        #region 参数及初始化
        /// <summary>        
        /// 地图刷新点id
        /// </summary>
        public int Map_Brush_Id { get; set; }
        /// <summary>        
        /// 刷新类型名称
        /// </summary>
        public language_id Brush_Type_Name { get; set; }
        /// <summary>        
        /// 刷新类型描述
        /// </summary>
        public string Brush_Describe { get; set; }
        /// <summary>        
        /// 第一波刷新时间
        /// </summary>
        public float FirstWaveTime { get; set; }
        /// <summary>        
        /// 刷新坐标
        ///（坐标x,坐标y）
        /// </summary>
        public Vector2 BrushPos { get; set; }
        /// <summary>        
        /// 每一波id
        ///cfg_Wave表的id
        ///
        ///每一个Id都表示一波的怪
        /// </summary>
        public List<int> WaveList { get; set; }
        /// <summary>        
        /// 刷新点使用选择，
        ///0，表示全图随机刷新
        ///1，表示在一个点刷新，读取Polygon第一个坐标
        ///2，表示多边形刷新
        ///读取Polygon所有坐标相连
        ///（至少一个点）
        ///3，表示圆形刷新
        ///
        /// </summary>
        public int Shape_Select { get; set; }
        /// <summary>        
        /// 刷新点 坐标列表
        ///该点坐标
        ///是相对于刷新点的坐标
        ///多个坐标点首尾相连成为一个多边形
        /// </summary>
        public List<Vector2> Polygon { get; set; }
        /// <summary>        
        /// 刷新半径，以刷新点
        ///为圆心的半径内
        /// </summary>
        public float Radius { get; set; }

        public MapBrushPoint(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_MapBrushPoint, id);//public const string Config_MapBrushPoint = "cfg_MapBrushPoint"; 
			Map_Brush_Id = (int)dict["Map_Brush_Id"];
			Brush_Type_Name = (language_id)dict["Brush_Type_Name"];
			Brush_Describe = (string)dict["Brush_Describe"];
			FirstWaveTime = (float)dict["FirstWaveTime"];
			BrushPos = (Vector2)dict["BrushPos"];
			WaveList = (List<int>)dict["WaveList"];
			Shape_Select = (int)dict["Shape_Select"];
			Polygon = (List<Vector2>)dict["Polygon"];
			Radius = (float)dict["Radius"];
        }

        public MapBrushPoint(Dictionary<string, object> dict)
        {
			Map_Brush_Id = (int)dict["Map_Brush_Id"];
			Brush_Type_Name = (language_id)dict["Brush_Type_Name"];
			Brush_Describe = (string)dict["Brush_Describe"];
			FirstWaveTime = (float)dict["FirstWaveTime"];
			BrushPos = (Vector2)dict["BrushPos"];
			WaveList = (List<int>)dict["WaveList"];
			Shape_Select = (int)dict["Shape_Select"];
			Polygon = (List<Vector2>)dict["Polygon"];
			Radius = (float)dict["Radius"];
        }
        #endregion
    }
}
