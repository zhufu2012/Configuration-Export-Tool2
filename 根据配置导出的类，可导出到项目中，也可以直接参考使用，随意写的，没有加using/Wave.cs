using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public class Wave
    {
        #region 参数及初始化
        /// <summary>        
        /// 波次Id
        /// </summary>
        public int Wave_Id { get; set; }
        /// <summary>        
        /// 波次名称
        /// </summary>
        public string Wave_Name { get; set; }
        /// <summary>        
        /// 刷新提示
        /// </summary>
        public string Wave_Describe { get; set; }
        /// <summary>        
        /// 刷新数据列表
        ///(cfg_Enemy的敌人id，数量)
        /// </summary>
        public List<List<int>> Wave_Data { get; set; }
        /// <summary>        
        /// 刷新方式
        ///1.直接全部刷新
        ///2.带定时刷新间隔
        /// </summary>
        public int Wave_Type { get; set; }
        /// <summary>        
        /// 刷新间隔时间，单位帧
        /// </summary>
        public int Wave_Time { get; set; }
        /// <summary>        
        /// 刷新完成后 
        ///间隔时间，单位帧
        ///如果是最后一波
        ///该参数无效
        /// </summary>
        public int Wave_After_Time { get; set; }

        public Wave(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_Wave, id);//public const string Config_Wave = "cfg_Wave"; 
			Wave_Id = (int)dict["Wave_Id"];
			Wave_Name = (string)dict["Wave_Name"];
			Wave_Describe = (string)dict["Wave_Describe"];
			Wave_Data = (List<List<int>>)dict["Wave_Data"];
			Wave_Type = (int)dict["Wave_Type"];
			Wave_Time = (int)dict["Wave_Time"];
			Wave_After_Time = (int)dict["Wave_After_Time"];
        }

        public Wave(Dictionary<string, object> dict)
        {
			Wave_Id = (int)dict["Wave_Id"];
			Wave_Name = (string)dict["Wave_Name"];
			Wave_Describe = (string)dict["Wave_Describe"];
			Wave_Data = (List<List<int>>)dict["Wave_Data"];
			Wave_Type = (int)dict["Wave_Type"];
			Wave_Time = (int)dict["Wave_Time"];
			Wave_After_Time = (int)dict["Wave_After_Time"];
        }
        #endregion
    }
}
