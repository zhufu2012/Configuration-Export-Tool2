using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public class AttributeBase
    {
        #region 参数及初始化
        /// <summary>        
        /// 属性id
        /// </summary>
        public int AttributeId { get; set; }
        /// <summary>        
        /// 显示名称
        /// </summary>
        public string ShowName { get; set; }
        /// <summary>        
        /// 依赖关系id列表
        ///cfg_AttrDependency_属性依赖表id
        ///依赖于某属性,当某属性变化时也变化
        ///变化值根据属性依赖表计算
        /// </summary>
        public List<int> DependencyIdList { get; set; }

        public AttributeBase(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_AttributeBase, id);//public const string Config_AttributeBase = "cfg_AttributeBase"; 
			AttributeId = (int)dict["AttributeId"];
			ShowName = (string)dict["ShowName"];
			DependencyIdList = (List<int>)dict["DependencyIdList"];
        }

        public AttributeBase(Dictionary<string, object> dict)
        {
			AttributeId = (int)dict["AttributeId"];
			ShowName = (string)dict["ShowName"];
			DependencyIdList = (List<int>)dict["DependencyIdList"];
        }
        #endregion
    }
}
