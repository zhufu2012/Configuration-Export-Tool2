using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public partial class AttrCalculate
    {
        #region 参数及初始化
        /// <summary>        
        /// 计算id
        /// </summary>
        public int CalculateId { get; set; }
        /// <summary>        
        /// 计算类型
        ///0 不使用
        ///1 一个实体攻击另一个实体
        ///（对另一个实体属性影响，对自己属性影响）
        ///2 一个实体创建另一个实体
        ///（对创建的实体属性影响，对自己属性影响）
        /// </summary>
        public int CalculateType { get; set; }
        /// <summary>        
        /// 计算优先级
        ///优先级小的先运行
        ///同优先级下，
        ///计算id小的先运行
        ///
        /// </summary>
        public List<int> Priority { get; set; }
        /// <summary>        
        /// 属性关系
        ///(该属性可被什么属性影响以及如何被影响)
        /// (影响的属性id,影响类型
        ///（0 无影响 1目标+  2目标*  3目标/
        ///    4 自身+  5自身*  6自身除 ）
        /// </summary>
        public string Relation { get; set; }

        public AttrCalculate(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_AttrCalculate, id);//public const string Config_AttrCalculate = "cfg_AttrCalculate"; 
			CalculateId = (int)dict["CalculateId"];
			CalculateType = (int)dict["CalculateType"];
			Priority = (List<int>)dict["Priority"];
			Relation = (string)dict["Relation"];
        }

        public AttrCalculate(Dictionary<string, object> dict)
        {
			CalculateId = (int)dict["CalculateId"];
			CalculateType = (int)dict["CalculateType"];
			Priority = (List<int>)dict["Priority"];
			Relation = (string)dict["Relation"];
        }
        #endregion
    }
}
