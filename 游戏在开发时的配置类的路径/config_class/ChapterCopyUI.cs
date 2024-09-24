using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    public partial class ChapterCopyUI
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
        /// 关卡显示名称
        /// </summary>
        public string ShowName { get; set; }
        /// <summary>        
        /// 关卡节点位置坐标
        /// </summary>
        public Vector2 Pos { get; set; }
        /// <summary>        
        /// 关卡节点大小
        /// </summary>
        public Vector2 Size { get; set; }
        /// <summary>        
        /// 关卡显示图片
        /// </summary>
        public Texture2D ShowImage { get; set; }

        public ChapterCopyUI(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_ChapterCopyUI, id);//public const string Config_ChapterCopyUI = "cfg_ChapterCopyUI"; 
			ChapterId = (int)dict["ChapterId"];
			CopyId = (int)dict["CopyId"];
			ShowName = (string)dict["ShowName"];
			Pos = (Vector2)dict["Pos"];
			Size = (Vector2)dict["Size"];
			ShowImage = (Texture2D)dict["ShowImage"];
        }

        public ChapterCopyUI(Dictionary<string, object> dict)
        {
			ChapterId = (int)dict["ChapterId"];
			CopyId = (int)dict["CopyId"];
			ShowName = (string)dict["ShowName"];
			Pos = (Vector2)dict["Pos"];
			Size = (Vector2)dict["Size"];
			ShowImage = (Texture2D)dict["ShowImage"];
        }
        #endregion
    }
}
