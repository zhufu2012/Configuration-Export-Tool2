using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public class SeedType
    {
        #region 参数及初始化
        /// <summary>        
        /// 生成种子方式id
        /// </summary>
        public int SeedTypeId { get; set; }
        /// <summary>        
        /// 生成种子方式名称
        /// </summary>
        public string SeedTypeName { get; set; }
        /// <summary>        
        /// 随机生成方式
        ///0 纯随机 （纯随机） 
        ///1 随机种子使用噪声（纯随机，
        ///但可以记录地形对应的种子，之后使用该来处理噪声也能得到相同的地形。
        ///游戏中，随机地图就是使用这个模式
        ///可以使用这个来不断随机地形，好的地形可以将种子记录下来）
        ///2 固定的随机数种子（地形不会变）
        ///3 使用固定种子来处理噪声（有固定种子，那么地形就不会变）
        /// </summary>
        public int SeedType { get; set; }
        /// <summary>        
        /// 固定种子id
        ///，当Type = 0时，随机生成一个，
        ///1或者2时，使用这个固定的种子
        /// </summary>
        public int Seed { get; set; }
        /// <summary>        
        /// 噪声id
        ///
        /// </summary>
        public int NoiseId { get; set; }

        public SeedType(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_SeedType, id);//public const string Config_SeedType = "cfg_SeedType"; 
			SeedTypeId = (int)dict["SeedTypeId"];
			SeedTypeName = (string)dict["SeedTypeName"];
			SeedType = (int)dict["SeedType"];
			Seed = (int)dict["Seed"];
			NoiseId = (int)dict["NoiseId"];
        }

        public SeedType(Dictionary<string, object> dict)
        {
			SeedTypeId = (int)dict["SeedTypeId"];
			SeedTypeName = (string)dict["SeedTypeName"];
			SeedType = (int)dict["SeedType"];
			Seed = (int)dict["Seed"];
			NoiseId = (int)dict["NoiseId"];
        }
        #endregion
    }
}
