using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public partial class Noise
    {
        #region 参数及初始化
        /// <summary>        
        /// 噪声id
        /// </summary>
        public int NoiseId { get; set; }
        /// <summary>        
        /// 噪声类型
        ///0 TYPE_SIMPLEX
        ///1 TYPE_SIMPLEX_SMOOTH
        ///2 TYPE_CELLULAR  蜂窝包括 Worley 噪声图和 Voronoi 图，它们创建了相同值的不同区域
        ///3 TYPE_PERLIN 随机渐变的一种格子。对它们的点积进行插值，以获得格子之间的值
        ///4 TYPE_VALUE_CUBIC 类似于 Value 噪声，但速度较慢。波峰和波谷的变化更大。
        ///
        ///在使用值噪声创建凹凸贴图时，可以使用三次噪声来避免某些伪影。一般来说，如果值噪声用于高度图或凹凸贴图，则应始终使用此模式。
        ///5 TYPE_VALUE 点阵被分配随机值，然后根据相邻值进行插值
        ///
        ///
        /// </summary>
        public int NoiseType { get; set; }
        /// <summary>        
        /// x
        /// </summary>
        public int NoiseX { get; set; }
        /// <summary>        
        /// y
        /// </summary>
        public int NoiseY { get; set; }
        /// <summary>        
        /// frequency
        /// </summary>
        public float Frequency { get; set; }
        /// <summary>        
        /// domain_warp_enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>        
        /// domain_warp_amplitude
        /// </summary>
        public float Amplitude { get; set; }
        /// <summary>        
        /// domain_warp
        ///_fractal_gain
        /// </summary>
        public float WarpFractalGain { get; set; }
        /// <summary>        
        /// domain_warp
        ///_fractal_type
        ///0 没有扭曲空间的分形噪声
        ///1 逐渐扭曲空间，一个八度一个八度，导致更“液化”的失真
        ///2 为每个八度音程独立扭曲空间，导致更加混乱的失真
        /// </summary>
        public int WarpFractalType { get; set; }
        /// <summary>        
        /// domain_warp
        ///_frequency
        /// </summary>
        public float WarpFrequency { get; set; }
        /// <summary>        
        /// domain_warp
        ///_fractal_octaves
        /// </summary>
        public int WarpFractalOctaves { get; set; }
        /// <summary>        
        /// domain_warp_type
        ///0 使用单纯形噪波算法扭曲该域
        ///1 使用简单噪声算法的简化版本扭曲该域
        ///2 使用简单的噪声网格(不像其他方法那样平滑，但是性能更高)
        /// </summary>
        public int WarpType { get; set; }
        /// <summary>        
        /// fractal_type
        ///0 没有分形噪声
        ///1 使用分数布朗运动将八度音阶组合成分形的方法
        ///2 将八度音阶组合成分形的方法，产生“脊状”外观,成脊状
        ///3 将八度音阶结合成具有乒乓效果的分形的方法
        /// </summary>
        public int FractalType { get; set; }
        /// <summary>        
        /// fractal_
        ///gain
        /// </summary>
        public float FractalGain { get; set; }
        /// <summary>        
        /// fractal_
        ///lacunarity
        /// </summary>
        public float FractalLacunarity { get; set; }
        /// <summary>        
        /// fractal
        ///_octaves
        /// </summary>
        public int FractalOctaves { get; set; }
        /// <summary>        
        /// fractal_ping_pong_strength
        /// </summary>
        public float FractalPingPongStrength { get; set; }
        /// <summary>        
        /// fractal_weighted_strength
        /// </summary>
        public float FractalWeightedStrength { get; set; }
        /// <summary>        
        /// cellular_distance_function
        ///0 到最近点的欧几里德距离,欧几里得
        ///1 到最近点的平方欧几里得距离,欧几里德平方
        ///2 到最近点的曼哈顿距离(出租车公制)
        /// </summary>
        public int DistanceFunction { get; set; }
        /// <summary>        
        /// cellular_
        ///jitter
        /// </summary>
        public float CellularJitter { get; set; }
        /// <summary>        
        /// cellular_return_type
        ///0 蜂窝距离函数将为内的所有点返回相同的值，一个单元格
        ///1 蜂窝距离函数将返回一个由距离确定的值
        ///到最近的点
        ///2 cellular distance函数返回到第二个最近点的距离
        ///3 到最近点的距离被加到到第二最近点的距离上
        ///4 从到第二最近点的距离中减去到最近点的距离
        ///5 到最近点的距离乘以到第二近点的距离
        ///6 到最近点的距离除以到第二近点的距离
        /// </summary>
        public int CellularReturnType { get; set; }

        public Noise(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_Noise, id);//public const string Config_Noise = "cfg_Noise"; 
			NoiseId = (int)dict["NoiseId"];
			NoiseType = (int)dict["NoiseType"];
			NoiseX = (int)dict["NoiseX"];
			NoiseY = (int)dict["NoiseY"];
			Frequency = (float)dict["Frequency"];
			Enabled = (bool)dict["Enabled"];
			Amplitude = (float)dict["Amplitude"];
			WarpFractalGain = (float)dict["WarpFractalGain"];
			WarpFractalType = (int)dict["WarpFractalType"];
			WarpFrequency = (float)dict["WarpFrequency"];
			WarpFractalOctaves = (int)dict["WarpFractalOctaves"];
			WarpType = (int)dict["WarpType"];
			FractalType = (int)dict["FractalType"];
			FractalGain = (float)dict["FractalGain"];
			FractalLacunarity = (float)dict["FractalLacunarity"];
			FractalOctaves = (int)dict["FractalOctaves"];
			FractalPingPongStrength = (float)dict["FractalPingPongStrength"];
			FractalWeightedStrength = (float)dict["FractalWeightedStrength"];
			DistanceFunction = (int)dict["DistanceFunction"];
			CellularJitter = (float)dict["CellularJitter"];
			CellularReturnType = (int)dict["CellularReturnType"];
        }

        public Noise(Dictionary<string, object> dict)
        {
			NoiseId = (int)dict["NoiseId"];
			NoiseType = (int)dict["NoiseType"];
			NoiseX = (int)dict["NoiseX"];
			NoiseY = (int)dict["NoiseY"];
			Frequency = (float)dict["Frequency"];
			Enabled = (bool)dict["Enabled"];
			Amplitude = (float)dict["Amplitude"];
			WarpFractalGain = (float)dict["WarpFractalGain"];
			WarpFractalType = (int)dict["WarpFractalType"];
			WarpFrequency = (float)dict["WarpFrequency"];
			WarpFractalOctaves = (int)dict["WarpFractalOctaves"];
			WarpType = (int)dict["WarpType"];
			FractalType = (int)dict["FractalType"];
			FractalGain = (float)dict["FractalGain"];
			FractalLacunarity = (float)dict["FractalLacunarity"];
			FractalOctaves = (int)dict["FractalOctaves"];
			FractalPingPongStrength = (float)dict["FractalPingPongStrength"];
			FractalWeightedStrength = (float)dict["FractalWeightedStrength"];
			DistanceFunction = (int)dict["DistanceFunction"];
			CellularJitter = (float)dict["CellularJitter"];
			CellularReturnType = (int)dict["CellularReturnType"];
        }
        #endregion
    }
}
