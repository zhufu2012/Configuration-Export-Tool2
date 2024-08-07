using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public class TestTowerBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 炮塔Id
        /// </summary>
        public int Tower_Id { get; set; }
        /// <summary>        
        /// 显示文本
        /// </summary>
        public language_id DisplayText { get; set; }
        /// <summary>        
        /// 显示描述
        /// </summary>
        public language_id DisplayDescription { get; set; }
        /// <summary>        
        /// 标签id列表
        ///
        /// </summary>
        public List<int> TagIdList { get; set; }
        /// <summary>        
        /// 建造价格
        /// </summary>
        public List<List<int>> Price { get; set; }
        /// <summary>        
        /// 质量
        /// </summary>
        public int Mass { get; set; }
        /// <summary>        
        /// 炮塔解锁条件
        /// </summary>
        public List<List<int>> TechCondition { get; set; }
        /// <summary>        
        /// 单位半径
        /// </summary>
        public float Radius { get; set; }
        /// <summary>        
        /// 单位选择时显示圆圈
        /// </summary>
        public float DisplayRadius { get; set; }
        /// <summary>        
        /// 视野范围
        /// </summary>
        public float FogOfWarSightRange { get; set; }
        /// <summary>        
        /// 是否为建筑
        /// </summary>
        public bool IsBuilding { get; set; }
        /// <summary>        
        /// 建筑碰撞范围
        /// </summary>
        public List<List<int>> Footprint { get; set; }

        public TestTowerBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_TestTowerBase, id);//public const string Config_TestTowerBase = "cfg_TestTowerBase"; 
			Tower_Id = (int)dict["Tower_Id"];
			DisplayText = (language_id)dict["DisplayText"];
			DisplayDescription = (language_id)dict["DisplayDescription"];
			TagIdList = (List<int>)dict["TagIdList"];
			Price = (List<List<int>>)dict["Price"];
			Mass = (int)dict["Mass"];
			TechCondition = (List<List<int>>)dict["TechCondition"];
			Radius = (float)dict["Radius"];
			DisplayRadius = (float)dict["DisplayRadius"];
			FogOfWarSightRange = (float)dict["FogOfWarSightRange"];
			IsBuilding = (bool)dict["IsBuilding"];
			Footprint = (List<List<int>>)dict["Footprint"];
        }

        public TestTowerBase(Dictionary<string, object> dict)
        {
			Tower_Id = (int)dict["Tower_Id"];
			DisplayText = (language_id)dict["DisplayText"];
			DisplayDescription = (language_id)dict["DisplayDescription"];
			TagIdList = (List<int>)dict["TagIdList"];
			Price = (List<List<int>>)dict["Price"];
			Mass = (int)dict["Mass"];
			TechCondition = (List<List<int>>)dict["TechCondition"];
			Radius = (float)dict["Radius"];
			DisplayRadius = (float)dict["DisplayRadius"];
			FogOfWarSightRange = (float)dict["FogOfWarSightRange"];
			IsBuilding = (bool)dict["IsBuilding"];
			Footprint = (List<List<int>>)dict["Footprint"];
        }
        #endregion
    }
}
