namespace Remnant_Afterglow
{
    public class BaseObjectShow
    {
        #region 参数及初始化
        /// <summary>        
        /// 实体显示id
        /// </summary>
        public int ObjectShow { get; set; }
        /// <summary>        
        /// 底部栏项目id
        /// </summary>
        public int ObjectBottomId { get; set; }
        /// <summary>        
        /// 左侧边栏项目id
        /// </summary>
        public int ObjectSideId { get; set; }

        public BaseObjectShow(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_BaseObjectShow, id);//public const string Config_BaseObjectShow = "cfg_BaseObjectShow"; 
			ObjectShow = (int)dict["ObjectShow"];
			ObjectBottomId = (int)dict["ObjectBottomId"];
			ObjectSideId = (int)dict["ObjectSideId"];
        }

        public BaseObjectShow(Dictionary<string, object> dict)
        {
			ObjectShow = (int)dict["ObjectShow"];
			ObjectBottomId = (int)dict["ObjectBottomId"];
			ObjectSideId = (int)dict["ObjectSideId"];
        }
        #endregion
    }
}
