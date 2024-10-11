using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    /// <summary>
    /// 自动生成的配置类 CameraBase 用于 相机基本数据,拓展请在expand_class文件下使用partial拓展
    /// </summary>
    public partial class CameraBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 相机id
        /// </summary>
        public int CameraId { get; set; }
        /// <summary>        
        /// 相机组件id列表
        ///一些相机配件，如显示帧数
        ///噪声编辑器等
        /// </summary>
        public List<List<int>> AssemblyIdList { get; set; }
        /// <summary>        
        /// 相机初始位置
        ///(X,Y)
        /// </summary>
        public Vector2 StartPos { get; set; }
        /// <summary>        
        /// 能否上下左右移动
        /// </summary>
        public bool IsMove { get; set; }
        /// <summary>        
        /// 相机移动速度
        /// </summary>
        public float MoveSpeed { get; set; }
        /// <summary>        
        /// 初始缩放值
        ///（原来的多少倍）
        /// </summary>
        public float StartZoom { get; set; }
        /// <summary>        
        /// 能否放大
        /// </summary>
        public bool IsZoomIn { get; set; }
        /// <summary>        
        /// 能否缩小
        /// </summary>
        public bool IsZoomOut { get; set; }
        /// <summary>        
        /// 最大缩放值
        ///（原来的多少倍）
        /// </summary>
        public float MaxZoom { get; set; }
        /// <summary>        
        /// 最小缩放值
        ///（原来的多少倍）
        /// </summary>
        public float MinZoom { get; set; }
        /// <summary>        
        /// 缩放变化量
        /// </summary>
        public float ZoomIncrement { get; set; }
        /// <summary>        
        /// 是否使用边缘滚动操作
        /// </summary>
        public bool IsEdgeScroll { get; set; }
        /// <summary>        
        /// 边缘滚动触发区域的宽度
        ///当鼠标靠近视窗边缘至少这个距离时，开始执行边缘滚动操作
        /// </summary>
        public float EdgeScrollMargin { get; set; }
        /// <summary>        
        /// 控制边缘滚动的基础速度
        /// </summary>
        public float BaseEdgeScrollSpeed { get; set; }
        /// <summary>        
        /// 鼠标默认图标
        /// </summary>
        public Texture2D CursorPoint { get; set; }
        /// <summary>        
        /// 鼠标点击图标
        /// </summary>
        public Texture2D CursorGrab { get; set; }

        public CameraBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_CameraBase, id);//public const string Config_CameraBase = "cfg_CameraBase"; 
			CameraId = (int)dict["CameraId"];
			AssemblyIdList = (List<List<int>>)dict["AssemblyIdList"];
			StartPos = (Vector2)dict["StartPos"];
			IsMove = (bool)dict["IsMove"];
			MoveSpeed = (float)dict["MoveSpeed"];
			StartZoom = (float)dict["StartZoom"];
			IsZoomIn = (bool)dict["IsZoomIn"];
			IsZoomOut = (bool)dict["IsZoomOut"];
			MaxZoom = (float)dict["MaxZoom"];
			MinZoom = (float)dict["MinZoom"];
			ZoomIncrement = (float)dict["ZoomIncrement"];
			IsEdgeScroll = (bool)dict["IsEdgeScroll"];
			EdgeScrollMargin = (float)dict["EdgeScrollMargin"];
			BaseEdgeScrollSpeed = (float)dict["BaseEdgeScrollSpeed"];
			CursorPoint = (Texture2D)dict["CursorPoint"];
			CursorGrab = (Texture2D)dict["CursorGrab"];
			InitData();
        }

        
        public CameraBase(string cfg_id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_CameraBase, cfg_id);//public const string Config_CameraBase = "cfg_CameraBase"; 
			CameraId = (int)dict["CameraId"];
			AssemblyIdList = (List<List<int>>)dict["AssemblyIdList"];
			StartPos = (Vector2)dict["StartPos"];
			IsMove = (bool)dict["IsMove"];
			MoveSpeed = (float)dict["MoveSpeed"];
			StartZoom = (float)dict["StartZoom"];
			IsZoomIn = (bool)dict["IsZoomIn"];
			IsZoomOut = (bool)dict["IsZoomOut"];
			MaxZoom = (float)dict["MaxZoom"];
			MinZoom = (float)dict["MinZoom"];
			ZoomIncrement = (float)dict["ZoomIncrement"];
			IsEdgeScroll = (bool)dict["IsEdgeScroll"];
			EdgeScrollMargin = (float)dict["EdgeScrollMargin"];
			BaseEdgeScrollSpeed = (float)dict["BaseEdgeScrollSpeed"];
			CursorPoint = (Texture2D)dict["CursorPoint"];
			CursorGrab = (Texture2D)dict["CursorGrab"];
			InitData();
        }

        public CameraBase(Dictionary<string, object> dict)
        {
			CameraId = (int)dict["CameraId"];
			AssemblyIdList = (List<List<int>>)dict["AssemblyIdList"];
			StartPos = (Vector2)dict["StartPos"];
			IsMove = (bool)dict["IsMove"];
			MoveSpeed = (float)dict["MoveSpeed"];
			StartZoom = (float)dict["StartZoom"];
			IsZoomIn = (bool)dict["IsZoomIn"];
			IsZoomOut = (bool)dict["IsZoomOut"];
			MaxZoom = (float)dict["MaxZoom"];
			MinZoom = (float)dict["MinZoom"];
			ZoomIncrement = (float)dict["ZoomIncrement"];
			IsEdgeScroll = (bool)dict["IsEdgeScroll"];
			EdgeScrollMargin = (float)dict["EdgeScrollMargin"];
			BaseEdgeScrollSpeed = (float)dict["BaseEdgeScrollSpeed"];
			CursorPoint = (Texture2D)dict["CursorPoint"];
			CursorGrab = (Texture2D)dict["CursorGrab"];
			InitData();
        }
        #endregion
    }
}
