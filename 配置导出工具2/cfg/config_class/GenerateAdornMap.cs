using System.Collections.Generic;
namespace Remnant_Afterglow
{
    public partial class GenerateAdornMap
    {
        #region 参数及初始化
        /// <summary>        
        /// 其他各层生成方式id
        /// </summary>
        public int AdornMapId { get; set; }
        /// <summary>        
        /// 绘制层数
        ///地板层1 1是地板
        ///
        ///
        /// </summary>
        public int Layer { get; set; }
        /// <summary>        
        /// 生成噪声种子类型id
        ///cfg_SeedType_生成种子表 
        ///注意！是噪声的种子
        /// </summary>
        public int SeedTypeId { get; set; }
        /// <summary>        
        /// 生成地图用材料id列表(材料id,生成密度)
        ///生成通过前面种子获取一个数字，和生成密度相比，
        ///小于该数字就生成。
        /// </summary>
        public List<List<int>> MaterialIdList { get; set; }
        /// <summary>        
        /// 地图大型结构id列表
        ///这一层也可以使用
        ///多图块结构
        ///这里的大结构使用的
        ///大结构配置自身的绘制层
        ///
        /// </summary>
        public List<int> BigStructIdList { get; set; }

        public GenerateAdornMap(int id)
        {
            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_GenerateAdornMap, id);//public const string Config_GenerateAdornMap = "cfg_GenerateAdornMap"; 
			AdornMapId = (int)dict["AdornMapId"];
			Layer = (int)dict["Layer"];
			SeedTypeId = (int)dict["SeedTypeId"];
			MaterialIdList = (List<List<int>>)dict["MaterialIdList"];
			BigStructIdList = (List<int>)dict["BigStructIdList"];
        }

        public GenerateAdornMap(Dictionary<string, object> dict)
        {
			AdornMapId = (int)dict["AdornMapId"];
			Layer = (int)dict["Layer"];
			SeedTypeId = (int)dict["SeedTypeId"];
			MaterialIdList = (List<List<int>>)dict["MaterialIdList"];
			BigStructIdList = (List<int>)dict["BigStructIdList"];
        }
        #endregion
    }
}
