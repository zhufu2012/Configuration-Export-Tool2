namespace Remnant_Afterglow
{
    public class AttrDependency
    {
        #region 参数及初始化
        /// <summary>        
        /// 属性依赖id
        /// </summary>
        public int DependencyId { get; set; }
        /// <summary>        
        /// 依赖对象id
        ///cfg_Attribute_实体基础属性表id
        /// </summary>
        public int Target { get; set; }
        /// <summary>        
        /// 依赖关系
        ///这是一个表达式，有两类属性，Base（本属性 Base，依赖对象 Target）
        ///每个属性都有这些变量（CurrentValue 当前值，MaxValue最大值,MinValue 最小值，RegenValue再生值）
        ///每个属性都有这些函数
        ///(函数:Get(Type),考虑修饰器后的属性，
        ///Value 当前值 Max 最大值
        ///Min 最小值  Regen 再生值)
        ///属性有两个，一个是本属性（Base），一个是依赖对象属性（Target）
        ///举例1:Base.CurrentValue+Target.MaxValue (本属性当前值+对象属性最大值)
        ///举例1:Target.CurrentValue  （对象属性当前值）
        /// </summary>
        public string Relation { get; set; }

        public AttrDependency(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_AttrDependency, id);//public const string Config_AttrDependency = "cfg_AttrDependency"; 
			DependencyId = (int)dict["DependencyId"];
			Target = (int)dict["Target"];
			Relation = (string)dict["Relation"];
        }

        public AttrDependency(Dictionary<string, object> dict)
        {
			DependencyId = (int)dict["DependencyId"];
			Target = (int)dict["Target"];
			Relation = (string)dict["Relation"];
        }
        #endregion
    }
}
