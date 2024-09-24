using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public partial class GlobalConfigFloat
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
        public float ConfigValue { get; set; }

        public GlobalConfigFloat(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_GlobalConfigFloat, id);//public const string Config_GlobalConfigFloat = "cfg_GlobalConfigFloat"; 
			Configid = (string)dict["Configid"];
			ConfigName = (string)dict["ConfigName"];
			ConfigValue = (float)dict["ConfigValue"];
        }

        public GlobalConfigFloat(Dictionary<string, object> dict)
        {
			Configid = (string)dict["Configid"];
			ConfigName = (string)dict["ConfigName"];
			ConfigValue = (float)dict["ConfigValue"];
        }
        #endregion
    }
}
