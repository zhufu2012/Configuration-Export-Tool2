namespace Remnant_Afterglow
{
    public class TowerBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 炮塔ID
        ///（每个建筑特有的记号）
        /// </summary>
        public int TowerId { get; set; }
        /// <summary>        
        /// 炮塔名称
        /// </summary>
        public string TowerName { get; set; }
        /// <summary>        
        /// 实体id
        ///用于属性等配置
        ///(要求唯一)
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>        
        /// 炮塔归属
        ///（该建筑默认属于那方阵营）导用cfg_Troops_阵营
        /// </summary>
        public int CampId { get; set; }
        /// <summary>        
        /// 炮塔占地(横轴，纵轴)
        ///（算直径吧，比较好算，按像素算，
        ///大多数单位都是敌人，也无所谓碰撞体精确了）
        /// </summary>
        public List<int> TowerSize { get; set; }
        /// <summary>        
        /// 炮塔底座
        /// </summary>
        public Texture2D TowerBasePng { get; set; }
        /// <summary>        
        /// 炮塔武器贴图
        /// </summary>
        public Texture2D TowerWeaponPng { get; set; }

        public TowerBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_TowerBase, id);//public const string Config_TowerBase = "cfg_TowerBase"; 
			TowerId = (int)dict["TowerId"];
			TowerName = (string)dict["TowerName"];
			ObjectId = (int)dict["ObjectId"];
			CampId = (int)dict["CampId"];
			TowerSize = (List<int>)dict["TowerSize"];
			TowerBasePng = (Texture2D)dict["TowerBasePng"];
			TowerWeaponPng = (Texture2D)dict["TowerWeaponPng"];
        }

        public TowerBase(Dictionary<string, object> dict)
        {
			TowerId = (int)dict["TowerId"];
			TowerName = (string)dict["TowerName"];
			ObjectId = (int)dict["ObjectId"];
			CampId = (int)dict["CampId"];
			TowerSize = (List<int>)dict["TowerSize"];
			TowerBasePng = (Texture2D)dict["TowerBasePng"];
			TowerWeaponPng = (Texture2D)dict["TowerWeaponPng"];
        }
        #endregion
    }
}
