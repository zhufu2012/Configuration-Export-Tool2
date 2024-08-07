using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public class GlobalConfigList
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
        public List<int> ConfigValue { get; set; }

        public GlobalConfigList(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_GlobalConfigList, id);//public const string Config_GlobalConfigList = "cfg_GlobalConfigList"; 
			Configid = (string)dict["Configid"];
			ConfigName = (string)dict["ConfigName"];
			ConfigValue = (List<int>)dict["ConfigValue"];
        }

        public GlobalConfigList(Dictionary<string, object> dict)
        {
			Configid = (string)dict["Configid"];
			ConfigName = (string)dict["ConfigName"];
			ConfigValue = (List<int>)dict["ConfigValue"];
        }
        #endregion
    }
}
