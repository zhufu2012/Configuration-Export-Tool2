using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public partial class GlobalConfigInt
    {
        #region 参数及初始化
        /// <summary>        
        /// 全局配置id
        ///(在这几个表中都必须唯一)
        /// </summary>
        public string Configid { get; set; }
        /// <summary>        
        /// 全局配置名称
        /// </summary>
        public string ConfigName { get; set; }
        /// <summary>        
        /// 全局配置值
        /// </summary>
        public int ConfigValue { get; set; }

        public GlobalConfigInt(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_GlobalConfigInt, id);//public const string Config_GlobalConfigInt = "cfg_GlobalConfigInt"; 
			Configid = (string)dict["Configid"];
			ConfigName = (string)dict["ConfigName"];
			ConfigValue = (int)dict["ConfigValue"];
        }

        public GlobalConfigInt(Dictionary<string, object> dict)
        {
			Configid = (string)dict["Configid"];
			ConfigName = (string)dict["ConfigName"];
			ConfigValue = (int)dict["ConfigValue"];
        }
        #endregion
    }
}
