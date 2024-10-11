using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    /// <summary>
    /// 自动生成的配置类 ChapterBase 用于 章节基础数据,拓展请在expand_class文件下使用partial拓展
    /// </summary>
    public partial class ChapterBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 章节id
        ///按数字从1开始排序
        /// </summary>
        public int ChapterId { get; set; }
        /// <summary>        
        /// 章节名称
        /// </summary>
        public string ChapterName { get; set; }
        /// <summary>        
        /// 章节描述文字1
        /// </summary>
        public string Describe1 { get; set; }
        /// <summary>        
        /// 章节描述文字2
        /// </summary>
        public string Describe2 { get; set; }
        /// <summary>        
        /// 章节类型
        ///暂不使用
        /// </summary>
        public int ChapterType { get; set; }
        /// <summary>        
        /// 章节所用大地图id
        /// </summary>
        public int BigMapBaseId { get; set; }
        /// <summary>        
        /// 章节图片
        /// </summary>
        public Texture2D ChapterImage { get; set; }
        /// <summary>        
        /// 章节初始关卡列表
        /// </summary>
        public List<int> ChapterStartCopy { get; set; }

        public ChapterBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_ChapterBase, id);//public const string Config_ChapterBase = "cfg_ChapterBase"; 
			ChapterId = (int)dict["ChapterId"];
			ChapterName = (string)dict["ChapterName"];
			Describe1 = (string)dict["Describe1"];
			Describe2 = (string)dict["Describe2"];
			ChapterType = (int)dict["ChapterType"];
			BigMapBaseId = (int)dict["BigMapBaseId"];
			ChapterImage = (Texture2D)dict["ChapterImage"];
			ChapterStartCopy = (List<int>)dict["ChapterStartCopy"];
			InitData();
        }

        
        public ChapterBase(string cfg_id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_ChapterBase, cfg_id);//public const string Config_ChapterBase = "cfg_ChapterBase"; 
			ChapterId = (int)dict["ChapterId"];
			ChapterName = (string)dict["ChapterName"];
			Describe1 = (string)dict["Describe1"];
			Describe2 = (string)dict["Describe2"];
			ChapterType = (int)dict["ChapterType"];
			BigMapBaseId = (int)dict["BigMapBaseId"];
			ChapterImage = (Texture2D)dict["ChapterImage"];
			ChapterStartCopy = (List<int>)dict["ChapterStartCopy"];
			InitData();
        }

        public ChapterBase(Dictionary<string, object> dict)
        {
			ChapterId = (int)dict["ChapterId"];
			ChapterName = (string)dict["ChapterName"];
			Describe1 = (string)dict["Describe1"];
			Describe2 = (string)dict["Describe2"];
			ChapterType = (int)dict["ChapterType"];
			BigMapBaseId = (int)dict["BigMapBaseId"];
			ChapterImage = (Texture2D)dict["ChapterImage"];
			ChapterStartCopy = (List<int>)dict["ChapterStartCopy"];
			InitData();
        }
        #endregion
    }
}
