namespace Remnant_Afterglow
{
    public class ChapterCopyBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 章节id
        /// </summary>
        public int ChapterId { get; set; }
        /// <summary>        
        /// 关卡id
        /// </summary>
        public int CopyId { get; set; }
        /// <summary>        
        /// 关卡名称
        /// </summary>
        public string CopyName { get; set; }
        /// <summary>        
        /// 关卡描述文字1
        /// </summary>
        public string Describe1 { get; set; }
        /// <summary>        
        /// 关卡描述文字2
        /// </summary>
        public string Describe2 { get; set; }
        /// <summary>        
        /// 关卡所用大地图id
        ///地图生成.xlsx表的
        ///cfg_GenerateBottomMap_随机生成地图方式表id
        /// </summary>
        public int GenerateMapId { get; set; }
        /// <summary>        
        /// 后继关卡id列表
        /// </summary>
        public List<int> CopyIdList { get; set; }

        public ChapterCopyBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_ChapterCopyBase, id);//public const string Config_ChapterCopyBase = "cfg_ChapterCopyBase"; 
			ChapterId = (int)dict["ChapterId"];
			CopyId = (int)dict["CopyId"];
			CopyName = (string)dict["CopyName"];
			Describe1 = (string)dict["Describe1"];
			Describe2 = (string)dict["Describe2"];
			GenerateMapId = (int)dict["GenerateMapId"];
			CopyIdList = (List<int>)dict["CopyIdList"];
        }

        public ChapterCopyBase(Dictionary<string, object> dict)
        {
			ChapterId = (int)dict["ChapterId"];
			CopyId = (int)dict["CopyId"];
			CopyName = (string)dict["CopyName"];
			Describe1 = (string)dict["Describe1"];
			Describe2 = (string)dict["Describe2"];
			GenerateMapId = (int)dict["GenerateMapId"];
			CopyIdList = (List<int>)dict["CopyIdList"];
        }
        #endregion
    }
}
