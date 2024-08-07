using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public class FunctionTemplate
    {
        #region 参数及初始化
        /// <summary>        
        /// 模板id
        ///也是类名
        /// </summary>
        public string TemplateId { get; set; }
        /// <summary>        
        /// 表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>        
        /// 表中主键字段名
        /// </summary>
        public string TableKey { get; set; }
        /// <summary>        
        /// 表中函数代码字段名
        /// </summary>
        public string TableField { get; set; }
        /// <summary>        
        /// 导包代码
        /// </summary>
        public string CodePack { get; set; }
        /// <summary>        
        /// 函数输入变量
        /// </summary>
        public string CodeVariable { get; set; }
        /// <summary>        
        /// 函数统一返回值
        /// </summary>
        public string CodeReturn { get; set; }
        /// <summary>        
        /// 函数变量类型
        ///最多9个参数
        ///（前面属于变量，最后一个属于返回值）
        /// </summary>
        public string VariableType { get; set; }

        public FunctionTemplate(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_FunctionTemplate, id);//public const string Config_FunctionTemplate = "cfg_FunctionTemplate"; 
			TemplateId = (string)dict["TemplateId"];
			TableName = (string)dict["TableName"];
			TableKey = (string)dict["TableKey"];
			TableField = (string)dict["TableField"];
			CodePack = (string)dict["CodePack"];
			CodeVariable = (string)dict["CodeVariable"];
			CodeReturn = (string)dict["CodeReturn"];
			VariableType = (string)dict["VariableType"];
        }

        public FunctionTemplate(Dictionary<string, object> dict)
        {
			TemplateId = (string)dict["TemplateId"];
			TableName = (string)dict["TableName"];
			TableKey = (string)dict["TableKey"];
			TableField = (string)dict["TableField"];
			CodePack = (string)dict["CodePack"];
			CodeVariable = (string)dict["CodeVariable"];
			CodeReturn = (string)dict["CodeReturn"];
			VariableType = (string)dict["VariableType"];
        }
        #endregion
    }
}
