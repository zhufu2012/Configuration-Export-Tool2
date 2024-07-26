namespace Remnant_Afterglow
{
    public class MapMaterial
    {
        #region 参数及初始化
        /// <summary>        
        /// 地图生成用材料id
        /// </summary>
        public int MaterialId { get; set; }
        /// <summary>        
        /// 地图生成用材料名称
        /// </summary>
        public string MaterialName { get; set; }
        /// <summary>        
        /// 生成概率
        ///这个概率是先满足地图生成密度之后
        ///计算的
        ///暂未使用
        /// </summary>
        public float Probability { get; set; }
        /// <summary>        
        /// 材料所用图集id
        ///地块表的cfg_MapImageSet_地图图像集id
        /// </summary>
        public int ImageSetId { get; set; }
        /// <summary>        
        /// 所在图集序号
        /// </summary>
        public int ImageSetIndex { get; set; }
        /// <summary>        
        /// 生成系数（暂未使用）
        /// </summary>
        public float Parame { get; set; }

        public MapMaterial(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_MapMaterial, id);//public const string Config_MapMaterial = "cfg_MapMaterial"; 
			MaterialId = (int)dict["MaterialId"];
			MaterialName = (string)dict["MaterialName"];
			Probability = (float)dict["Probability"];
			ImageSetId = (int)dict["ImageSetId"];
			ImageSetIndex = (int)dict["ImageSetIndex"];
			Parame = (float)dict["Parame"];
        }

        public MapMaterial(Dictionary<string, object> dict)
        {
			MaterialId = (int)dict["MaterialId"];
			MaterialName = (string)dict["MaterialName"];
			Probability = (float)dict["Probability"];
			ImageSetId = (int)dict["ImageSetId"];
			ImageSetIndex = (int)dict["ImageSetIndex"];
			Parame = (float)dict["Parame"];
        }
        #endregion
    }
}
