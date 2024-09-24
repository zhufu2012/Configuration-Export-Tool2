using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    public partial class MapExtraDraw
    {
        #region 参数及初始化
        /// <summary>        
        /// 额外绘制id
        /// </summary>
        public int MapDrawId { get; set; }
        /// <summary>        
        /// 绘制类型
        ///1 直线(参数坐标1 到 参数坐标2) 参数1：绘制地图材料id
        ///参数2：绘制宽度
        /// </summary>
        public int DrawType { get; set; }
        /// <summary>        
        /// 参数1
        /// </summary>
        public float Param1 { get; set; }
        /// <summary>        
        /// 参数2
        /// </summary>
        public float Param2 { get; set; }
        /// <summary>        
        /// 参数坐标1
        /// </summary>
        public Vector2 Param3 { get; set; }
        /// <summary>        
        /// 参数坐标2
        /// </summary>
        public Vector2 Param4 { get; set; }
        /// <summary>        
        /// 参数列表
        /// </summary>
        public List<List<float>> ParamList { get; set; }

        public MapExtraDraw(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_MapExtraDraw, id);//public const string Config_MapExtraDraw = "cfg_MapExtraDraw"; 
			MapDrawId = (int)dict["MapDrawId"];
			DrawType = (int)dict["DrawType"];
			Param1 = (float)dict["Param1"];
			Param2 = (float)dict["Param2"];
			Param3 = (Vector2)dict["Param3"];
			Param4 = (Vector2)dict["Param4"];
			ParamList = (List<List<float>>)dict["ParamList"];
        }

        public MapExtraDraw(Dictionary<string, object> dict)
        {
			MapDrawId = (int)dict["MapDrawId"];
			DrawType = (int)dict["DrawType"];
			Param1 = (float)dict["Param1"];
			Param2 = (float)dict["Param2"];
			Param3 = (Vector2)dict["Param3"];
			Param4 = (Vector2)dict["Param4"];
			ParamList = (List<List<float>>)dict["ParamList"];
        }
        #endregion
    }
}
