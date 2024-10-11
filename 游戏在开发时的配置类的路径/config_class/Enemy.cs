using System.Collections.Generic;
using Godot;
namespace Remnant_Afterglow
{
    /// <summary>
    /// 自动生成的配置类 Enemy 用于 敌人基础配置测试,拓展请在expand_class文件下使用partial拓展
    /// </summary>
    public partial class Enemy
    {
        #region 参数及初始化
        /// <summary>        
        /// 敌人Id
        /// </summary>
        public int Enemy_Id { get; set; }
        /// <summary>        
        /// 敌人名称
        /// </summary>
        public language_id Enemy_Name { get; set; }
        /// <summary>        
        /// 敌人描述1
        /// </summary>
        public string Enemy_Describe1 { get; set; }
        /// <summary>        
        /// 敌人描述2
        /// </summary>
        public string Enemy_Describe2 { get; set; }
        /// <summary>        
        /// 绘制帧数
        ///
        ///填#BASEVALUE 就是默认全局绘制帧数
        /// </summary>
        public int DrawFrame { get; set; }
        /// <summary>        
        /// 物理帧数 
        ///
        ///填#BASEVALUE 就是默认全局物理帧数
        /// </summary>
        public int PhysicalFrame { get; set; }
        /// <summary>        
        /// 生命
        /// </summary>
        public int Blood { get; set; }
        /// <summary>        
        /// 敌人大小
        /// </summary>
        public Vector2 Scale { get; set; }
        /// <summary>        
        /// 敌人速度
        /// </summary>
        public int Speed { get; set; }

        public Enemy(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_Enemy, id);//public const string Config_Enemy = "cfg_Enemy"; 
			Enemy_Id = (int)dict["Enemy_Id"];
			Enemy_Name = (language_id)dict["Enemy_Name"];
			Enemy_Describe1 = (string)dict["Enemy_Describe1"];
			Enemy_Describe2 = (string)dict["Enemy_Describe2"];
			DrawFrame = (int)dict["DrawFrame"];
			PhysicalFrame = (int)dict["PhysicalFrame"];
			Blood = (int)dict["Blood"];
			Scale = (Vector2)dict["Scale"];
			Speed = (int)dict["Speed"];
			InitData();
        }

        
        public Enemy(string cfg_id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_Enemy, cfg_id);//public const string Config_Enemy = "cfg_Enemy"; 
			Enemy_Id = (int)dict["Enemy_Id"];
			Enemy_Name = (language_id)dict["Enemy_Name"];
			Enemy_Describe1 = (string)dict["Enemy_Describe1"];
			Enemy_Describe2 = (string)dict["Enemy_Describe2"];
			DrawFrame = (int)dict["DrawFrame"];
			PhysicalFrame = (int)dict["PhysicalFrame"];
			Blood = (int)dict["Blood"];
			Scale = (Vector2)dict["Scale"];
			Speed = (int)dict["Speed"];
			InitData();
        }

        public Enemy(Dictionary<string, object> dict)
        {
			Enemy_Id = (int)dict["Enemy_Id"];
			Enemy_Name = (language_id)dict["Enemy_Name"];
			Enemy_Describe1 = (string)dict["Enemy_Describe1"];
			Enemy_Describe2 = (string)dict["Enemy_Describe2"];
			DrawFrame = (int)dict["DrawFrame"];
			PhysicalFrame = (int)dict["PhysicalFrame"];
			Blood = (int)dict["Blood"];
			Scale = (Vector2)dict["Scale"];
			Speed = (int)dict["Speed"];
			InitData();
        }
        #endregion
    }
}
