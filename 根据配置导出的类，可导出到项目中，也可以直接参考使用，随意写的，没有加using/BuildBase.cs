namespace Remnant_Afterglow
{
    public class BuildBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 建筑ID（每个建筑特有的记号）
        /// </summary>
        public int BuildingID { get; set; }
        /// <summary>        
        /// 建筑名称
        /// </summary>
        public string BuildingName { get; set; }
        /// <summary>        
        /// 实体id
        ///用于属性等配置
        ///(要求唯一)
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>        
        /// 建筑归属
        ///（该建筑默认属于那方阵营）
        ///导用cfg_Troops_阵营
        /// </summary>
        public int DefaultCamp { get; set; }
        /// <summary>        
        /// 建筑占地
        ///（左上角出发，按格子计算，逆时针算点）
        ///x左正，y上正，多边形，斜边所覆盖的区域计算如建筑的占地面积之中
        /// </summary>
        public string BuildingSize { get; set; }
        /// <summary>        
        /// 建造规则
        /// </summary>
        public List<int> BuildingRules { get; set; }
        /// <summary>        
        /// 建筑贴图
        /// </summary>
        public Texture2D BuildPicture { get; set; }

        public BuildBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_BuildBase, id);//public const string Config_BuildBase = "cfg_BuildBase"; 
			BuildingID = (int)dict["BuildingID"];
			BuildingName = (string)dict["BuildingName"];
			ObjectId = (int)dict["ObjectId"];
			DefaultCamp = (int)dict["DefaultCamp"];
			BuildingSize = (string)dict["BuildingSize"];
			BuildingRules = (List<int>)dict["BuildingRules"];
			BuildPicture = (Texture2D)dict["BuildPicture"];
        }

        public BuildBase(Dictionary<string, object> dict)
        {
			BuildingID = (int)dict["BuildingID"];
			BuildingName = (string)dict["BuildingName"];
			ObjectId = (int)dict["ObjectId"];
			DefaultCamp = (int)dict["DefaultCamp"];
			BuildingSize = (string)dict["BuildingSize"];
			BuildingRules = (List<int>)dict["BuildingRules"];
			BuildPicture = (Texture2D)dict["BuildPicture"];
        }
        #endregion
    }
}
