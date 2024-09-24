namespace Remnant_Afterglow
{    
    public partial static class ConfigConstant
    {
        #region 配置特殊功能表
        /// <summary>
        /// 配置覆盖关系表
        /// </summary>
        public const string Config_ConfigCover = "cfg_ConfigCover";
        /// <summary>
        /// 配置调用关系表
        /// </summary>
        public const string Config_ConfigCall = "cfg_ConfigCall";
        #endregion
        
        
        #region 默认配置表
        /// <summary>
        /// 全局配置Int数据
        /// </summary>
        public const string Config_GlobalConfigInt = "cfg_GlobalConfigInt";
        /// <summary>
        /// Str数据
        /// </summary>
        public const string Config_GlobalConfigStr = "cfg_GlobalConfigStr";
        /// <summary>
        /// float数据
        /// </summary>
        public const string Config_GlobalConfigFloat = "cfg_GlobalConfigFloat";
        /// <summary>
        /// List数据
        /// </summary>
        public const string Config_GlobalConfigList = "cfg_GlobalConfigList";
        #endregion
        
        
        #region 函数模板相关
        /// <summary>
        /// 函数模板
        /// </summary>
        public const string Config_FunctionTemplate = "cfg_FunctionTemplate";
        #endregion
        
        
        #region 相机相关
        /// <summary>
        /// 相机基本数据
        /// </summary>
        public const string Config_CameraBase = "cfg_CameraBase";
        /// <summary>
        /// 相机组件表
        /// </summary>
        public const string Config_CameraAssembly = "cfg_CameraAssembly";
        #endregion
        
        
        #region 种子噪声相关
        /// <summary>
        /// 种子表
        /// </summary>
        public const string Config_SeedType = "cfg_SeedType";
        /// <summary>
        /// 噪声表
        /// </summary>
        public const string Config_Noise = "cfg_Noise";
        #endregion
        
        
        #region 基础测试用_地图相关配置
        /// <summary>
        /// 
        /// </summary>
        public const string Config_MapBrushMonster = "cfg_MapBrushMonster";
        /// <summary>
        /// 
        /// </summary>
        public const string Config_MapBrushPoint = "cfg_MapBrushPoint";
        /// <summary>
        /// 
        /// </summary>
        public const string Config_Wave = "cfg_Wave";
        #endregion
        
        
        #region 基础测试用_敌人相关配置
        /// <summary>
        /// 敌人基础配置测试
        /// </summary>
        public const string Config_Enemy = "cfg_Enemy";
        #endregion
        
        
        #region 基础测试用_炮塔相关配置
        /// <summary>
        /// 炮塔基础
        /// </summary>
        public const string Config_TestTowerBase = "cfg_TestTowerBase";
        /// <summary>
        /// 炮塔属性
        /// </summary>
        public const string Config_TestTowerAttr = "cfg_TestTowerAttr";
        #endregion
        
        
        #region 基础测试配置
        /// <summary>
        /// 整体测试
        /// </summary>
        public const string Config_科技树测试 = "cfg_科技树测试";
        /// <summary>
        /// 测试
        /// </summary>
        public const string Config_材料基础模板 = "cfg_材料基础模板";
        /// <summary>
        /// 测试
        /// </summary>
        public const string Config_材料类型模板 = "cfg_材料类型模板";
        #endregion
        
        
        #region 子弹配置
        /// <summary>
        /// 子弹基础表
        /// </summary>
        public const string Config_BulletBase = "cfg_BulletBase";
        #endregion
        
        
        #region 实体显示相关配置
        /// <summary>
        /// 实体显示方式表
        /// </summary>
        public const string Config_BaseObjectShow = "cfg_BaseObjectShow";
        /// <summary>
        /// 底部栏
        /// </summary>
        public const string Config_ObjectBottomBar = "cfg_ObjectBottomBar";
        /// <summary>
        /// 侧边栏
        /// </summary>
        public const string Config_ObjectSideBar = "cfg_ObjectSideBar";
        #endregion
        
        
        #region 建筑配置
        /// <summary>
        /// 建筑建筑数据
        /// </summary>
        public const string Config_BuildBase = "cfg_BuildBase";
        /// <summary>
        /// 建造规则
        /// </summary>
        public const string Config_BuildRule = "cfg_BuildRule";
        #endregion
        
        
        #region 炮塔配置
        /// <summary>
        /// 炮塔基础表
        /// </summary>
        public const string Config_TowerBase = "cfg_TowerBase";
        #endregion
        
        
        #region 属性配置
        /// <summary>
        /// 属性表
        /// </summary>
        public const string Config_AttributeBase = "cfg_AttributeBase";
        /// <summary>
        /// 实体属性表
        /// </summary>
        public const string Config_AttributeData = "cfg_AttributeData";
        /// <summary>
        /// 属性计算表
        /// </summary>
        public const string Config_AttrCalculate = "cfg_AttrCalculate";
        /// <summary>
        /// 属性依赖表
        /// </summary>
        public const string Config_AttrDependency = "cfg_AttrDependency";
        /// <summary>
        /// 属性事件
        /// </summary>
        public const string Config_AttrEvent = "cfg_AttrEvent";
        #endregion
        
        
        #region 地图生成
        /// <summary>
        /// 随机生成地图方式
        /// </summary>
        public const string Config_GenerateBottomMap = "cfg_GenerateBottomMap";
        /// <summary>
        /// 生成地图用材料
        /// </summary>
        public const string Config_MapMaterial = "cfg_MapMaterial";
        /// <summary>
        /// 地图额外绘制表
        /// </summary>
        public const string Config_MapExtraDraw = "cfg_MapExtraDraw";
        /// <summary>
        /// 地图大型结构
        /// </summary>
        public const string Config_GenerateBigStruct = "cfg_GenerateBigStruct";
        /// <summary>
        /// 装饰绘制层
        /// </summary>
        public const string Config_GenerateAdornMap = "cfg_GenerateAdornMap";
        /// <summary>
        /// 地图墙壁表
        /// </summary>
        public const string Config_MapWall = "cfg_MapWall";
        #endregion
        
        
        #region 章节副本相关
        /// <summary>
        /// 章节基础数据
        /// </summary>
        public const string Config_ChapterBase = "cfg_ChapterBase";
        /// <summary>
        /// 章节关卡基础数据
        /// </summary>
        public const string Config_ChapterCopyBase = "cfg_ChapterCopyBase";
        /// <summary>
        /// 章节关卡UI数据
        /// </summary>
        public const string Config_ChapterCopyUI = "cfg_ChapterCopyUI";
        #endregion
        
        
        #region 资源
        /// <summary>
        /// 资源
        /// </summary>
        public const string Config_Ziyuan = "cfg_ziyuan";
        #endregion
        
        
        #region 阵营相关
        /// <summary>
        /// 阵营基础数据
        /// </summary>
        public const string Config_CampBase = "cfg_CampBase";
        #endregion
        
        
    }
}