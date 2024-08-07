using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public class AttributeData
    {
        #region 参数及初始化
        /// <summary>        
        /// 实体类型
        /// </summary>
        public int ObjectType { get; set; }
        /// <summary>        
        /// 实体id
        ///单位或者炮塔或者建筑等
        /// </summary>
        public int ObjectId { get; set; }
        /// <summary>        
        /// 属性id
        /// </summary>
        public int AttributeId { get; set; }
        /// <summary>        
        /// 初始值
        /// </summary>
        public float StartValue { get; set; }
        /// <summary>        
        /// 最大值
        /// </summary>
        public float Max { get; set; }
        /// <summary>        
        /// 最小值
        /// </summary>
        public float Min { get; set; }
        /// <summary>        
        /// 再生值
        /// </summary>
        public float Regen { get; set; }
        /// <summary>        
        /// 再生帧数
        /// </summary>
        public float RegenFps { get; set; }
        /// <summary>        
        /// 事件触发id列表
        ///（触发类型，触发参数1，触发参数2，触发参数3，事件id）
        ///0 添加属性后直接触发
        ///1 移除属性后触发
        ///2 等于某值触发（参数1是触发值）
        ///3 大于某值触发 （参数1是触发值）
        ///4 小于某值触发 （参数1是触发值）
        ///5 大于等于某值触发 （参数1是触发值）
        ///6 小于等于某值触发 （参数1是触发值）
        ///7 周期性达到触发 （参数1是周期（帧））
        ///8 随机触发（参数1是触发值，参数2是最大随机值，随机数在1到参数2之间，小于触发值就触发）
        ///
        /// </summary>
        public List<List<int>> AttrEventIdList { get; set; }

        public AttributeData(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_AttributeData, id);//public const string Config_AttributeData = "cfg_AttributeData"; 
			ObjectType = (int)dict["ObjectType"];
			ObjectId = (int)dict["ObjectId"];
			AttributeId = (int)dict["AttributeId"];
			StartValue = (float)dict["StartValue"];
			Max = (float)dict["Max"];
			Min = (float)dict["Min"];
			Regen = (float)dict["Regen"];
			RegenFps = (float)dict["RegenFps"];
			AttrEventIdList = (List<List<int>>)dict["AttrEventIdList"];
        }

        public AttributeData(Dictionary<string, object> dict)
        {
			ObjectType = (int)dict["ObjectType"];
			ObjectId = (int)dict["ObjectId"];
			AttributeId = (int)dict["AttributeId"];
			StartValue = (float)dict["StartValue"];
			Max = (float)dict["Max"];
			Min = (float)dict["Min"];
			Regen = (float)dict["Regen"];
			RegenFps = (float)dict["RegenFps"];
			AttrEventIdList = (List<List<int>>)dict["AttrEventIdList"];
        }
        #endregion
    }
}
