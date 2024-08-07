using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public class 科技树测试
    {
        #region 参数及初始化
        /// <summary>        
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public string Id2 { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public string Science_Name { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public string Science_Describe { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public int Malleability { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public float Intensity { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public ulong Intensity2 { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public List<List<int>> Type { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public List<int> PoaoType { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public List<short> RGB { get; set; }
        /// <summary>        
        /// 
        /// </summary>
        public List<List<int>> Resources { get; set; }

        public 科技树测试(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_科技树测试, id);//public const string Config_科技树测试 = "cfg_科技树测试"; 
			Id = (int)dict["Id"];
			Id2 = (string)dict["Id2"];
			Science_Name = (string)dict["Science_Name"];
			Science_Describe = (string)dict["Science_Describe"];
			Malleability = (int)dict["Malleability"];
			Intensity = (float)dict["Intensity"];
			Intensity2 = (ulong)dict["Intensity2"];
			Type = (List<List<int>>)dict["Type"];
			PoaoType = (List<int>)dict["PoaoType"];
			RGB = (List<short>)dict["RGB"];
			Resources = (List<List<int>>)dict["Resources"];
        }

        public 科技树测试(Dictionary<string, object> dict)
        {
			Id = (int)dict["Id"];
			Id2 = (string)dict["Id2"];
			Science_Name = (string)dict["Science_Name"];
			Science_Describe = (string)dict["Science_Describe"];
			Malleability = (int)dict["Malleability"];
			Intensity = (float)dict["Intensity"];
			Intensity2 = (ulong)dict["Intensity2"];
			Type = (List<List<int>>)dict["Type"];
			PoaoType = (List<int>)dict["PoaoType"];
			RGB = (List<short>)dict["RGB"];
			Resources = (List<List<int>>)dict["Resources"];
        }
        #endregion
    }
}
