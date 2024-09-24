using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public partial class AttrEvent
    {
        #region 参数及初始化
        /// <summary>        
        /// 属性事件id
        /// </summary>
        public int AttrEventId { get; set; }
        /// <summary>        
        /// 属性事件描述
        /// </summary>
        public string AttrEventDescribe { get; set; }
        /// <summary>        
        /// 事件类型 #BASEVALUE 是 0
        ///0 仅输出文字，调试用（输出事件id:触发时间戳:AttrEventDescribe字段）
        ///1 修饰器事件 为属性增加修饰器（加属性或者改属性，可永久或者临时）
        ///参数列表中填写
        ///2 触发事件的事件 触发这个表的其他事件
        ///(可以用于延时触发其他事件，别写自己的id)
        ///3 播放音效事件 播放音效
        ///4 播放动画事件 播放动画
        ///5 播放脚本动画
        /// </summary>
        public int EventType { get; set; }
        /// <summary>        
        /// 是否永久存在
        ///true 就设置延时时间为
        ///ulong.MaxValue
        ///false 就使用DelayTime作为延时时间
        /// </summary>
        public bool IsForever { get; set; }
        /// <summary>        
        /// 延时时间
        ///事件类型为2  这是从当前时间开始的时长（帧数）
        ///
        /// </summary>
        public ulong DelayTime { get; set; }
        /// <summary>        
        /// 参数1
        /// </summary>
        public float Param1 { get; set; }
        /// <summary>        
        /// 参数2
        /// </summary>
        public float Param2 { get; set; }
        /// <summary>        
        /// 参数3
        /// </summary>
        public float Param3 { get; set; }
        /// <summary>        
        /// 参数列表
        ///事件类型为1时（属性id,参数1，参数2，参数3）
        ///属性id 为-1时，表示运行该事件的属性id(只能当前实体的)
        ///参数1（0 当前值，1最小值，2最大值，3再生值）
        ///参数2是 属性加值（不需要使用写0，正负都行）
        ///参数3是 属性乘值（不需要使用写 1，正负都行，大于1相当于乘以，小于1用于除以）
        /// </summary>
        public List<List<float>> ParamList { get; set; }

        public AttrEvent(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_AttrEvent, id);//public const string Config_AttrEvent = "cfg_AttrEvent"; 
			AttrEventId = (int)dict["AttrEventId"];
			AttrEventDescribe = (string)dict["AttrEventDescribe"];
			EventType = (int)dict["EventType"];
			IsForever = (bool)dict["IsForever"];
			DelayTime = (ulong)dict["DelayTime"];
			Param1 = (float)dict["Param1"];
			Param2 = (float)dict["Param2"];
			Param3 = (float)dict["Param3"];
			ParamList = (List<List<float>>)dict["ParamList"];
        }

        public AttrEvent(Dictionary<string, object> dict)
        {
			AttrEventId = (int)dict["AttrEventId"];
			AttrEventDescribe = (string)dict["AttrEventDescribe"];
			EventType = (int)dict["EventType"];
			IsForever = (bool)dict["IsForever"];
			DelayTime = (ulong)dict["DelayTime"];
			Param1 = (float)dict["Param1"];
			Param2 = (float)dict["Param2"];
			Param3 = (float)dict["Param3"];
			ParamList = (List<List<float>>)dict["ParamList"];
        }
        #endregion
    }
}
