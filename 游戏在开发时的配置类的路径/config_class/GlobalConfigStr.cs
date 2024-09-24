using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public partial class GlobalConfigStr
    {
        #region 参数及初始化
        /// <summary>        
        /// 全局配置id
        /// </summary>
        public string Configid { get; set; }
        /// <summary>        
        /// 全局配置名称
        /// </summary>
        public string ConfigName { get; set; }
        /// <summary>        
        /// 全局配置值
        /// </summary>
        public string ConfigValue { get; set; }

        public GlobalConfigStr(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_GlobalConfigStr, id);//public const string Config_GlobalConfigStr = "cfg_GlobalConfigStr"; 
			Configid = (string)dict["Configid"];
			ConfigName = (string)dict["ConfigName"];
			ConfigValue = (string)dict["ConfigValue"];
        }

        public GlobalConfigStr(Dictionary<string, object> dict)
        {
			Configid = (string)dict["Configid"];
			ConfigName = (string)dict["ConfigName"];
			ConfigValue = (string)dict["ConfigValue"];
        }
        #endregion
    }
}
