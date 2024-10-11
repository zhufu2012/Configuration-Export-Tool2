using System.Collections.Generic;
namespace Remnant_Afterglow
{    
    /// <summary>
    /// 自动生成的配置缓存代码，请不要手动修改
    /// </summary>
    public static partial class ConfigCache
    {

        /// <summary>
        /// 提前加载所有界面基础配置配置缓存
        /// </summary>
        public static void LoadOtherCache()
        {
            LoadViewBase();
            LoadUpdateLog();
            LoadAttainmentPage();
            LoadAttainmentBase();
            LoadScienceRange();
            LoadScienceBase();
            LoadScienceData();
            LoadConfigCover();
            LoadConfigCall();
            LoadGlobalConfigInt();
            LoadGlobalConfigStr();
            LoadGlobalConfigFloat();
            LoadGlobalConfigList();
            LoadFunctionTemplate();
            LoadCameraBase();
            LoadCameraAssembly();
            LoadMapBrushMonster();
            LoadMapBrushPoint();
            LoadWave();
            LoadEnemy();
            LoadTestTowerBase();
            LoadTestTowerAttr();
            Load科技树测试();
            Load材料基础模板();
            Load材料类型模板();
            LoadBulletBase();
            LoadBaseObjectShow();
            LoadObjectBottomBar();
            LoadObjectSideBar();
            LoadBuildBase();
            LoadBuildRule();
            LoadTowerBase();
            LoadAttributeBase();
            LoadAttributeData();
            LoadAttrCalculate();
            LoadAttrDependency();
            LoadGenerateBottomMap();
            LoadMapMaterial();
            LoadMapExtraDraw();
            LoadGenerateBigStruct();
            LoadMapWall();
            LoadChapterBase();
            LoadChapterCopyBase();
            LoadChapterCopyUI();
            LoadZiyuan();
            LoadCampBase();
        }

        #region 界面基础配置配置缓存
        /// <summary>
        /// 界面基础配置配置缓存
        /// </summary>
        private static readonly Dictionary<string, ViewBase> ViewBase_Cache = new Dictionary<string, ViewBase>();
        /// <summary>
        /// 提前加载所有界面基础配置配置缓存
        /// </summary>
        public static void LoadViewBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ViewBase);
            foreach (var val in cfg_dict)
            {
                ViewBase data = new ViewBase(val.Value);
                data.InitData2();
                ViewBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的界面基础配置基础配置缓存
        /// </summary>
        public static ViewBase GetViewBase(string cfgId)
        {
            if (!ViewBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ViewBase(cfgId);
                data.InitData2();
                ViewBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ViewBase GetViewBase(int cfgId)
        {
            if (!ViewBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ViewBase(cfgId);
                data.InitData2();
                ViewBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有界面基础配置数据
        /// </summary>
        public static List<ViewBase> GetAllViewBase()
        {
            List<ViewBase> list = new List<ViewBase>();
            foreach (var val in ViewBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 更新日志配置缓存
        /// <summary>
        /// 更新日志配置缓存
        /// </summary>
        private static readonly Dictionary<string, UpdateLog> UpdateLog_Cache = new Dictionary<string, UpdateLog>();
        /// <summary>
        /// 提前加载所有更新日志配置缓存
        /// </summary>
        public static void LoadUpdateLog()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_UpdateLog);
            foreach (var val in cfg_dict)
            {
                UpdateLog data = new UpdateLog(val.Value);
                data.InitData2();
                UpdateLog_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的更新日志基础配置缓存
        /// </summary>
        public static UpdateLog GetUpdateLog(string cfgId)
        {
            if (!UpdateLog_Cache.TryGetValue(cfgId, out var data))
            {
                data = new UpdateLog(cfgId);
                data.InitData2();
                UpdateLog_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static UpdateLog GetUpdateLog(int cfgId)
        {
            if (!UpdateLog_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new UpdateLog(cfgId);
                data.InitData2();
                UpdateLog_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有更新日志数据
        /// </summary>
        public static List<UpdateLog> GetAllUpdateLog()
        {
            List<UpdateLog> list = new List<UpdateLog>();
            foreach (var val in UpdateLog_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 数据库成就分页配置缓存
        /// <summary>
        /// 数据库成就分页配置缓存
        /// </summary>
        private static readonly Dictionary<string, AttainmentPage> AttainmentPage_Cache = new Dictionary<string, AttainmentPage>();
        /// <summary>
        /// 提前加载所有数据库成就分页配置缓存
        /// </summary>
        public static void LoadAttainmentPage()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_AttainmentPage);
            foreach (var val in cfg_dict)
            {
                AttainmentPage data = new AttainmentPage(val.Value);
                data.InitData2();
                AttainmentPage_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的数据库成就分页基础配置缓存
        /// </summary>
        public static AttainmentPage GetAttainmentPage(string cfgId)
        {
            if (!AttainmentPage_Cache.TryGetValue(cfgId, out var data))
            {
                data = new AttainmentPage(cfgId);
                data.InitData2();
                AttainmentPage_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static AttainmentPage GetAttainmentPage(int cfgId)
        {
            if (!AttainmentPage_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new AttainmentPage(cfgId);
                data.InitData2();
                AttainmentPage_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有数据库成就分页数据
        /// </summary>
        public static List<AttainmentPage> GetAllAttainmentPage()
        {
            List<AttainmentPage> list = new List<AttainmentPage>();
            foreach (var val in AttainmentPage_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 数据库成就相关配置配置缓存
        /// <summary>
        /// 数据库成就相关配置配置缓存
        /// </summary>
        private static readonly Dictionary<string, AttainmentBase> AttainmentBase_Cache = new Dictionary<string, AttainmentBase>();
        /// <summary>
        /// 提前加载所有数据库成就相关配置配置缓存
        /// </summary>
        public static void LoadAttainmentBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_AttainmentBase);
            foreach (var val in cfg_dict)
            {
                AttainmentBase data = new AttainmentBase(val.Value);
                data.InitData2();
                AttainmentBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的数据库成就相关配置基础配置缓存
        /// </summary>
        public static AttainmentBase GetAttainmentBase(string cfgId)
        {
            if (!AttainmentBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new AttainmentBase(cfgId);
                data.InitData2();
                AttainmentBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static AttainmentBase GetAttainmentBase(int cfgId)
        {
            if (!AttainmentBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new AttainmentBase(cfgId);
                data.InitData2();
                AttainmentBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有数据库成就相关配置数据
        /// </summary>
        public static List<AttainmentBase> GetAllAttainmentBase()
        {
            List<AttainmentBase> list = new List<AttainmentBase>();
            foreach (var val in AttainmentBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 科技范围配置配置缓存
        /// <summary>
        /// 科技范围配置配置缓存
        /// </summary>
        private static readonly Dictionary<string, ScienceRange> ScienceRange_Cache = new Dictionary<string, ScienceRange>();
        /// <summary>
        /// 提前加载所有科技范围配置配置缓存
        /// </summary>
        public static void LoadScienceRange()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ScienceRange);
            foreach (var val in cfg_dict)
            {
                ScienceRange data = new ScienceRange(val.Value);
                data.InitData2();
                ScienceRange_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的科技范围配置基础配置缓存
        /// </summary>
        public static ScienceRange GetScienceRange(string cfgId)
        {
            if (!ScienceRange_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ScienceRange(cfgId);
                data.InitData2();
                ScienceRange_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ScienceRange GetScienceRange(int cfgId)
        {
            if (!ScienceRange_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ScienceRange(cfgId);
                data.InitData2();
                ScienceRange_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有科技范围配置数据
        /// </summary>
        public static List<ScienceRange> GetAllScienceRange()
        {
            List<ScienceRange> list = new List<ScienceRange>();
            foreach (var val in ScienceRange_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 科技基础显示配置配置缓存
        /// <summary>
        /// 科技基础显示配置配置缓存
        /// </summary>
        private static readonly Dictionary<string, ScienceBase> ScienceBase_Cache = new Dictionary<string, ScienceBase>();
        /// <summary>
        /// 提前加载所有科技基础显示配置配置缓存
        /// </summary>
        public static void LoadScienceBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ScienceBase);
            foreach (var val in cfg_dict)
            {
                ScienceBase data = new ScienceBase(val.Value);
                data.InitData2();
                ScienceBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的科技基础显示配置基础配置缓存
        /// </summary>
        public static ScienceBase GetScienceBase(string cfgId)
        {
            if (!ScienceBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ScienceBase(cfgId);
                data.InitData2();
                ScienceBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ScienceBase GetScienceBase(int cfgId)
        {
            if (!ScienceBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ScienceBase(cfgId);
                data.InitData2();
                ScienceBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有科技基础显示配置数据
        /// </summary>
        public static List<ScienceBase> GetAllScienceBase()
        {
            List<ScienceBase> list = new List<ScienceBase>();
            foreach (var val in ScienceBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 科技激活相关数据配置缓存
        /// <summary>
        /// 科技激活相关数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, ScienceData> ScienceData_Cache = new Dictionary<string, ScienceData>();
        /// <summary>
        /// 提前加载所有科技激活相关数据配置缓存
        /// </summary>
        public static void LoadScienceData()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ScienceData);
            foreach (var val in cfg_dict)
            {
                ScienceData data = new ScienceData(val.Value);
                data.InitData2();
                ScienceData_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的科技激活相关数据基础配置缓存
        /// </summary>
        public static ScienceData GetScienceData(string cfgId)
        {
            if (!ScienceData_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ScienceData(cfgId);
                data.InitData2();
                ScienceData_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ScienceData GetScienceData(int cfgId)
        {
            if (!ScienceData_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ScienceData(cfgId);
                data.InitData2();
                ScienceData_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有科技激活相关数据数据
        /// </summary>
        public static List<ScienceData> GetAllScienceData()
        {
            List<ScienceData> list = new List<ScienceData>();
            foreach (var val in ScienceData_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 配置覆盖关系表配置缓存
        /// <summary>
        /// 配置覆盖关系表配置缓存
        /// </summary>
        private static readonly Dictionary<string, ConfigCover> ConfigCover_Cache = new Dictionary<string, ConfigCover>();
        /// <summary>
        /// 提前加载所有配置覆盖关系表配置缓存
        /// </summary>
        public static void LoadConfigCover()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ConfigCover);
            foreach (var val in cfg_dict)
            {
                ConfigCover data = new ConfigCover(val.Value);
                data.InitData2();
                ConfigCover_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的配置覆盖关系表基础配置缓存
        /// </summary>
        public static ConfigCover GetConfigCover(string cfgId)
        {
            if (!ConfigCover_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ConfigCover(cfgId);
                data.InitData2();
                ConfigCover_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ConfigCover GetConfigCover(int cfgId)
        {
            if (!ConfigCover_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ConfigCover(cfgId);
                data.InitData2();
                ConfigCover_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有配置覆盖关系表数据
        /// </summary>
        public static List<ConfigCover> GetAllConfigCover()
        {
            List<ConfigCover> list = new List<ConfigCover>();
            foreach (var val in ConfigCover_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 配置调用关系表配置缓存
        /// <summary>
        /// 配置调用关系表配置缓存
        /// </summary>
        private static readonly Dictionary<string, ConfigCall> ConfigCall_Cache = new Dictionary<string, ConfigCall>();
        /// <summary>
        /// 提前加载所有配置调用关系表配置缓存
        /// </summary>
        public static void LoadConfigCall()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ConfigCall);
            foreach (var val in cfg_dict)
            {
                ConfigCall data = new ConfigCall(val.Value);
                data.InitData2();
                ConfigCall_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的配置调用关系表基础配置缓存
        /// </summary>
        public static ConfigCall GetConfigCall(string cfgId)
        {
            if (!ConfigCall_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ConfigCall(cfgId);
                data.InitData2();
                ConfigCall_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ConfigCall GetConfigCall(int cfgId)
        {
            if (!ConfigCall_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ConfigCall(cfgId);
                data.InitData2();
                ConfigCall_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有配置调用关系表数据
        /// </summary>
        public static List<ConfigCall> GetAllConfigCall()
        {
            List<ConfigCall> list = new List<ConfigCall>();
            foreach (var val in ConfigCall_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 全局配置Int数据配置缓存
        /// <summary>
        /// 全局配置Int数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, GlobalConfigInt> GlobalConfigInt_Cache = new Dictionary<string, GlobalConfigInt>();
        /// <summary>
        /// 提前加载所有全局配置Int数据配置缓存
        /// </summary>
        public static void LoadGlobalConfigInt()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_GlobalConfigInt);
            foreach (var val in cfg_dict)
            {
                GlobalConfigInt data = new GlobalConfigInt(val.Value);
                data.InitData2();
                GlobalConfigInt_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的全局配置Int数据基础配置缓存
        /// </summary>
        public static GlobalConfigInt GetGlobalConfigInt(string cfgId)
        {
            if (!GlobalConfigInt_Cache.TryGetValue(cfgId, out var data))
            {
                data = new GlobalConfigInt(cfgId);
                data.InitData2();
                GlobalConfigInt_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static GlobalConfigInt GetGlobalConfigInt(int cfgId)
        {
            if (!GlobalConfigInt_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new GlobalConfigInt(cfgId);
                data.InitData2();
                GlobalConfigInt_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有全局配置Int数据数据
        /// </summary>
        public static List<GlobalConfigInt> GetAllGlobalConfigInt()
        {
            List<GlobalConfigInt> list = new List<GlobalConfigInt>();
            foreach (var val in GlobalConfigInt_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region Str数据配置缓存
        /// <summary>
        /// Str数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, GlobalConfigStr> GlobalConfigStr_Cache = new Dictionary<string, GlobalConfigStr>();
        /// <summary>
        /// 提前加载所有Str数据配置缓存
        /// </summary>
        public static void LoadGlobalConfigStr()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_GlobalConfigStr);
            foreach (var val in cfg_dict)
            {
                GlobalConfigStr data = new GlobalConfigStr(val.Value);
                data.InitData2();
                GlobalConfigStr_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的Str数据基础配置缓存
        /// </summary>
        public static GlobalConfigStr GetGlobalConfigStr(string cfgId)
        {
            if (!GlobalConfigStr_Cache.TryGetValue(cfgId, out var data))
            {
                data = new GlobalConfigStr(cfgId);
                data.InitData2();
                GlobalConfigStr_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static GlobalConfigStr GetGlobalConfigStr(int cfgId)
        {
            if (!GlobalConfigStr_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new GlobalConfigStr(cfgId);
                data.InitData2();
                GlobalConfigStr_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有Str数据数据
        /// </summary>
        public static List<GlobalConfigStr> GetAllGlobalConfigStr()
        {
            List<GlobalConfigStr> list = new List<GlobalConfigStr>();
            foreach (var val in GlobalConfigStr_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region float数据配置缓存
        /// <summary>
        /// float数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, GlobalConfigFloat> GlobalConfigFloat_Cache = new Dictionary<string, GlobalConfigFloat>();
        /// <summary>
        /// 提前加载所有float数据配置缓存
        /// </summary>
        public static void LoadGlobalConfigFloat()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_GlobalConfigFloat);
            foreach (var val in cfg_dict)
            {
                GlobalConfigFloat data = new GlobalConfigFloat(val.Value);
                data.InitData2();
                GlobalConfigFloat_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的float数据基础配置缓存
        /// </summary>
        public static GlobalConfigFloat GetGlobalConfigFloat(string cfgId)
        {
            if (!GlobalConfigFloat_Cache.TryGetValue(cfgId, out var data))
            {
                data = new GlobalConfigFloat(cfgId);
                data.InitData2();
                GlobalConfigFloat_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static GlobalConfigFloat GetGlobalConfigFloat(int cfgId)
        {
            if (!GlobalConfigFloat_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new GlobalConfigFloat(cfgId);
                data.InitData2();
                GlobalConfigFloat_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有float数据数据
        /// </summary>
        public static List<GlobalConfigFloat> GetAllGlobalConfigFloat()
        {
            List<GlobalConfigFloat> list = new List<GlobalConfigFloat>();
            foreach (var val in GlobalConfigFloat_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region List数据配置缓存
        /// <summary>
        /// List数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, GlobalConfigList> GlobalConfigList_Cache = new Dictionary<string, GlobalConfigList>();
        /// <summary>
        /// 提前加载所有List数据配置缓存
        /// </summary>
        public static void LoadGlobalConfigList()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_GlobalConfigList);
            foreach (var val in cfg_dict)
            {
                GlobalConfigList data = new GlobalConfigList(val.Value);
                data.InitData2();
                GlobalConfigList_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的List数据基础配置缓存
        /// </summary>
        public static GlobalConfigList GetGlobalConfigList(string cfgId)
        {
            if (!GlobalConfigList_Cache.TryGetValue(cfgId, out var data))
            {
                data = new GlobalConfigList(cfgId);
                data.InitData2();
                GlobalConfigList_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static GlobalConfigList GetGlobalConfigList(int cfgId)
        {
            if (!GlobalConfigList_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new GlobalConfigList(cfgId);
                data.InitData2();
                GlobalConfigList_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有List数据数据
        /// </summary>
        public static List<GlobalConfigList> GetAllGlobalConfigList()
        {
            List<GlobalConfigList> list = new List<GlobalConfigList>();
            foreach (var val in GlobalConfigList_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 函数模板配置缓存
        /// <summary>
        /// 函数模板配置缓存
        /// </summary>
        private static readonly Dictionary<string, FunctionTemplate> FunctionTemplate_Cache = new Dictionary<string, FunctionTemplate>();
        /// <summary>
        /// 提前加载所有函数模板配置缓存
        /// </summary>
        public static void LoadFunctionTemplate()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_FunctionTemplate);
            foreach (var val in cfg_dict)
            {
                FunctionTemplate data = new FunctionTemplate(val.Value);
                data.InitData2();
                FunctionTemplate_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的函数模板基础配置缓存
        /// </summary>
        public static FunctionTemplate GetFunctionTemplate(string cfgId)
        {
            if (!FunctionTemplate_Cache.TryGetValue(cfgId, out var data))
            {
                data = new FunctionTemplate(cfgId);
                data.InitData2();
                FunctionTemplate_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static FunctionTemplate GetFunctionTemplate(int cfgId)
        {
            if (!FunctionTemplate_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new FunctionTemplate(cfgId);
                data.InitData2();
                FunctionTemplate_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有函数模板数据
        /// </summary>
        public static List<FunctionTemplate> GetAllFunctionTemplate()
        {
            List<FunctionTemplate> list = new List<FunctionTemplate>();
            foreach (var val in FunctionTemplate_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 相机基本数据配置缓存
        /// <summary>
        /// 相机基本数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, CameraBase> CameraBase_Cache = new Dictionary<string, CameraBase>();
        /// <summary>
        /// 提前加载所有相机基本数据配置缓存
        /// </summary>
        public static void LoadCameraBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_CameraBase);
            foreach (var val in cfg_dict)
            {
                CameraBase data = new CameraBase(val.Value);
                data.InitData2();
                CameraBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的相机基本数据基础配置缓存
        /// </summary>
        public static CameraBase GetCameraBase(string cfgId)
        {
            if (!CameraBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new CameraBase(cfgId);
                data.InitData2();
                CameraBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static CameraBase GetCameraBase(int cfgId)
        {
            if (!CameraBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new CameraBase(cfgId);
                data.InitData2();
                CameraBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有相机基本数据数据
        /// </summary>
        public static List<CameraBase> GetAllCameraBase()
        {
            List<CameraBase> list = new List<CameraBase>();
            foreach (var val in CameraBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 相机组件表配置缓存
        /// <summary>
        /// 相机组件表配置缓存
        /// </summary>
        private static readonly Dictionary<string, CameraAssembly> CameraAssembly_Cache = new Dictionary<string, CameraAssembly>();
        /// <summary>
        /// 提前加载所有相机组件表配置缓存
        /// </summary>
        public static void LoadCameraAssembly()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_CameraAssembly);
            foreach (var val in cfg_dict)
            {
                CameraAssembly data = new CameraAssembly(val.Value);
                data.InitData2();
                CameraAssembly_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的相机组件表基础配置缓存
        /// </summary>
        public static CameraAssembly GetCameraAssembly(string cfgId)
        {
            if (!CameraAssembly_Cache.TryGetValue(cfgId, out var data))
            {
                data = new CameraAssembly(cfgId);
                data.InitData2();
                CameraAssembly_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static CameraAssembly GetCameraAssembly(int cfgId)
        {
            if (!CameraAssembly_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new CameraAssembly(cfgId);
                data.InitData2();
                CameraAssembly_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有相机组件表数据
        /// </summary>
        public static List<CameraAssembly> GetAllCameraAssembly()
        {
            List<CameraAssembly> list = new List<CameraAssembly>();
            foreach (var val in CameraAssembly_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 配置缓存
        /// <summary>
        /// 配置缓存
        /// </summary>
        private static readonly Dictionary<string, MapBrushMonster> MapBrushMonster_Cache = new Dictionary<string, MapBrushMonster>();
        /// <summary>
        /// 提前加载所有配置缓存
        /// </summary>
        public static void LoadMapBrushMonster()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_MapBrushMonster);
            foreach (var val in cfg_dict)
            {
                MapBrushMonster data = new MapBrushMonster(val.Value);
                data.InitData2();
                MapBrushMonster_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的基础配置缓存
        /// </summary>
        public static MapBrushMonster GetMapBrushMonster(string cfgId)
        {
            if (!MapBrushMonster_Cache.TryGetValue(cfgId, out var data))
            {
                data = new MapBrushMonster(cfgId);
                data.InitData2();
                MapBrushMonster_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static MapBrushMonster GetMapBrushMonster(int cfgId)
        {
            if (!MapBrushMonster_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new MapBrushMonster(cfgId);
                data.InitData2();
                MapBrushMonster_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有数据
        /// </summary>
        public static List<MapBrushMonster> GetAllMapBrushMonster()
        {
            List<MapBrushMonster> list = new List<MapBrushMonster>();
            foreach (var val in MapBrushMonster_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 配置缓存
        /// <summary>
        /// 配置缓存
        /// </summary>
        private static readonly Dictionary<string, MapBrushPoint> MapBrushPoint_Cache = new Dictionary<string, MapBrushPoint>();
        /// <summary>
        /// 提前加载所有配置缓存
        /// </summary>
        public static void LoadMapBrushPoint()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_MapBrushPoint);
            foreach (var val in cfg_dict)
            {
                MapBrushPoint data = new MapBrushPoint(val.Value);
                data.InitData2();
                MapBrushPoint_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的基础配置缓存
        /// </summary>
        public static MapBrushPoint GetMapBrushPoint(string cfgId)
        {
            if (!MapBrushPoint_Cache.TryGetValue(cfgId, out var data))
            {
                data = new MapBrushPoint(cfgId);
                data.InitData2();
                MapBrushPoint_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static MapBrushPoint GetMapBrushPoint(int cfgId)
        {
            if (!MapBrushPoint_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new MapBrushPoint(cfgId);
                data.InitData2();
                MapBrushPoint_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有数据
        /// </summary>
        public static List<MapBrushPoint> GetAllMapBrushPoint()
        {
            List<MapBrushPoint> list = new List<MapBrushPoint>();
            foreach (var val in MapBrushPoint_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 配置缓存
        /// <summary>
        /// 配置缓存
        /// </summary>
        private static readonly Dictionary<string, Wave> Wave_Cache = new Dictionary<string, Wave>();
        /// <summary>
        /// 提前加载所有配置缓存
        /// </summary>
        public static void LoadWave()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_Wave);
            foreach (var val in cfg_dict)
            {
                Wave data = new Wave(val.Value);
                data.InitData2();
                Wave_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的基础配置缓存
        /// </summary>
        public static Wave GetWave(string cfgId)
        {
            if (!Wave_Cache.TryGetValue(cfgId, out var data))
            {
                data = new Wave(cfgId);
                data.InitData2();
                Wave_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static Wave GetWave(int cfgId)
        {
            if (!Wave_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new Wave(cfgId);
                data.InitData2();
                Wave_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有数据
        /// </summary>
        public static List<Wave> GetAllWave()
        {
            List<Wave> list = new List<Wave>();
            foreach (var val in Wave_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 敌人基础配置测试配置缓存
        /// <summary>
        /// 敌人基础配置测试配置缓存
        /// </summary>
        private static readonly Dictionary<string, Enemy> Enemy_Cache = new Dictionary<string, Enemy>();
        /// <summary>
        /// 提前加载所有敌人基础配置测试配置缓存
        /// </summary>
        public static void LoadEnemy()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_Enemy);
            foreach (var val in cfg_dict)
            {
                Enemy data = new Enemy(val.Value);
                data.InitData2();
                Enemy_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的敌人基础配置测试基础配置缓存
        /// </summary>
        public static Enemy GetEnemy(string cfgId)
        {
            if (!Enemy_Cache.TryGetValue(cfgId, out var data))
            {
                data = new Enemy(cfgId);
                data.InitData2();
                Enemy_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static Enemy GetEnemy(int cfgId)
        {
            if (!Enemy_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new Enemy(cfgId);
                data.InitData2();
                Enemy_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有敌人基础配置测试数据
        /// </summary>
        public static List<Enemy> GetAllEnemy()
        {
            List<Enemy> list = new List<Enemy>();
            foreach (var val in Enemy_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 炮塔基础配置缓存
        /// <summary>
        /// 炮塔基础配置缓存
        /// </summary>
        private static readonly Dictionary<string, TestTowerBase> TestTowerBase_Cache = new Dictionary<string, TestTowerBase>();
        /// <summary>
        /// 提前加载所有炮塔基础配置缓存
        /// </summary>
        public static void LoadTestTowerBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_TestTowerBase);
            foreach (var val in cfg_dict)
            {
                TestTowerBase data = new TestTowerBase(val.Value);
                data.InitData2();
                TestTowerBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的炮塔基础基础配置缓存
        /// </summary>
        public static TestTowerBase GetTestTowerBase(string cfgId)
        {
            if (!TestTowerBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new TestTowerBase(cfgId);
                data.InitData2();
                TestTowerBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static TestTowerBase GetTestTowerBase(int cfgId)
        {
            if (!TestTowerBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new TestTowerBase(cfgId);
                data.InitData2();
                TestTowerBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有炮塔基础数据
        /// </summary>
        public static List<TestTowerBase> GetAllTestTowerBase()
        {
            List<TestTowerBase> list = new List<TestTowerBase>();
            foreach (var val in TestTowerBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 炮塔属性配置缓存
        /// <summary>
        /// 炮塔属性配置缓存
        /// </summary>
        private static readonly Dictionary<string, TestTowerAttr> TestTowerAttr_Cache = new Dictionary<string, TestTowerAttr>();
        /// <summary>
        /// 提前加载所有炮塔属性配置缓存
        /// </summary>
        public static void LoadTestTowerAttr()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_TestTowerAttr);
            foreach (var val in cfg_dict)
            {
                TestTowerAttr data = new TestTowerAttr(val.Value);
                data.InitData2();
                TestTowerAttr_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的炮塔属性基础配置缓存
        /// </summary>
        public static TestTowerAttr GetTestTowerAttr(string cfgId)
        {
            if (!TestTowerAttr_Cache.TryGetValue(cfgId, out var data))
            {
                data = new TestTowerAttr(cfgId);
                data.InitData2();
                TestTowerAttr_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static TestTowerAttr GetTestTowerAttr(int cfgId)
        {
            if (!TestTowerAttr_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new TestTowerAttr(cfgId);
                data.InitData2();
                TestTowerAttr_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有炮塔属性数据
        /// </summary>
        public static List<TestTowerAttr> GetAllTestTowerAttr()
        {
            List<TestTowerAttr> list = new List<TestTowerAttr>();
            foreach (var val in TestTowerAttr_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 整体测试配置缓存
        /// <summary>
        /// 整体测试配置缓存
        /// </summary>
        private static readonly Dictionary<string, 科技树测试> 科技树测试_Cache = new Dictionary<string, 科技树测试>();
        /// <summary>
        /// 提前加载所有整体测试配置缓存
        /// </summary>
        public static void Load科技树测试()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_科技树测试);
            foreach (var val in cfg_dict)
            {
                科技树测试 data = new 科技树测试(val.Value);
                data.InitData2();
                科技树测试_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的整体测试基础配置缓存
        /// </summary>
        public static 科技树测试 Get科技树测试(string cfgId)
        {
            if (!科技树测试_Cache.TryGetValue(cfgId, out var data))
            {
                data = new 科技树测试(cfgId);
                data.InitData2();
                科技树测试_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static 科技树测试 Get科技树测试(int cfgId)
        {
            if (!科技树测试_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new 科技树测试(cfgId);
                data.InitData2();
                科技树测试_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有整体测试数据
        /// </summary>
        public static List<科技树测试> GetAll科技树测试()
        {
            List<科技树测试> list = new List<科技树测试>();
            foreach (var val in 科技树测试_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 测试配置缓存
        /// <summary>
        /// 测试配置缓存
        /// </summary>
        private static readonly Dictionary<string, 材料基础模板> 材料基础模板_Cache = new Dictionary<string, 材料基础模板>();
        /// <summary>
        /// 提前加载所有测试配置缓存
        /// </summary>
        public static void Load材料基础模板()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_材料基础模板);
            foreach (var val in cfg_dict)
            {
                材料基础模板 data = new 材料基础模板(val.Value);
                data.InitData2();
                材料基础模板_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的测试基础配置缓存
        /// </summary>
        public static 材料基础模板 Get材料基础模板(string cfgId)
        {
            if (!材料基础模板_Cache.TryGetValue(cfgId, out var data))
            {
                data = new 材料基础模板(cfgId);
                data.InitData2();
                材料基础模板_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static 材料基础模板 Get材料基础模板(int cfgId)
        {
            if (!材料基础模板_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new 材料基础模板(cfgId);
                data.InitData2();
                材料基础模板_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有测试数据
        /// </summary>
        public static List<材料基础模板> GetAll材料基础模板()
        {
            List<材料基础模板> list = new List<材料基础模板>();
            foreach (var val in 材料基础模板_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 测试配置缓存
        /// <summary>
        /// 测试配置缓存
        /// </summary>
        private static readonly Dictionary<string, 材料类型模板> 材料类型模板_Cache = new Dictionary<string, 材料类型模板>();
        /// <summary>
        /// 提前加载所有测试配置缓存
        /// </summary>
        public static void Load材料类型模板()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_材料类型模板);
            foreach (var val in cfg_dict)
            {
                材料类型模板 data = new 材料类型模板(val.Value);
                data.InitData2();
                材料类型模板_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的测试基础配置缓存
        /// </summary>
        public static 材料类型模板 Get材料类型模板(string cfgId)
        {
            if (!材料类型模板_Cache.TryGetValue(cfgId, out var data))
            {
                data = new 材料类型模板(cfgId);
                data.InitData2();
                材料类型模板_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static 材料类型模板 Get材料类型模板(int cfgId)
        {
            if (!材料类型模板_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new 材料类型模板(cfgId);
                data.InitData2();
                材料类型模板_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有测试数据
        /// </summary>
        public static List<材料类型模板> GetAll材料类型模板()
        {
            List<材料类型模板> list = new List<材料类型模板>();
            foreach (var val in 材料类型模板_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 子弹基础表配置缓存
        /// <summary>
        /// 子弹基础表配置缓存
        /// </summary>
        private static readonly Dictionary<string, BulletBase> BulletBase_Cache = new Dictionary<string, BulletBase>();
        /// <summary>
        /// 提前加载所有子弹基础表配置缓存
        /// </summary>
        public static void LoadBulletBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_BulletBase);
            foreach (var val in cfg_dict)
            {
                BulletBase data = new BulletBase(val.Value);
                data.InitData2();
                BulletBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的子弹基础表基础配置缓存
        /// </summary>
        public static BulletBase GetBulletBase(string cfgId)
        {
            if (!BulletBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new BulletBase(cfgId);
                data.InitData2();
                BulletBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static BulletBase GetBulletBase(int cfgId)
        {
            if (!BulletBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new BulletBase(cfgId);
                data.InitData2();
                BulletBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有子弹基础表数据
        /// </summary>
        public static List<BulletBase> GetAllBulletBase()
        {
            List<BulletBase> list = new List<BulletBase>();
            foreach (var val in BulletBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 实体显示方式表配置缓存
        /// <summary>
        /// 实体显示方式表配置缓存
        /// </summary>
        private static readonly Dictionary<string, BaseObjectShow> BaseObjectShow_Cache = new Dictionary<string, BaseObjectShow>();
        /// <summary>
        /// 提前加载所有实体显示方式表配置缓存
        /// </summary>
        public static void LoadBaseObjectShow()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_BaseObjectShow);
            foreach (var val in cfg_dict)
            {
                BaseObjectShow data = new BaseObjectShow(val.Value);
                data.InitData2();
                BaseObjectShow_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的实体显示方式表基础配置缓存
        /// </summary>
        public static BaseObjectShow GetBaseObjectShow(string cfgId)
        {
            if (!BaseObjectShow_Cache.TryGetValue(cfgId, out var data))
            {
                data = new BaseObjectShow(cfgId);
                data.InitData2();
                BaseObjectShow_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static BaseObjectShow GetBaseObjectShow(int cfgId)
        {
            if (!BaseObjectShow_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new BaseObjectShow(cfgId);
                data.InitData2();
                BaseObjectShow_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有实体显示方式表数据
        /// </summary>
        public static List<BaseObjectShow> GetAllBaseObjectShow()
        {
            List<BaseObjectShow> list = new List<BaseObjectShow>();
            foreach (var val in BaseObjectShow_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 底部栏配置缓存
        /// <summary>
        /// 底部栏配置缓存
        /// </summary>
        private static readonly Dictionary<string, ObjectBottomBar> ObjectBottomBar_Cache = new Dictionary<string, ObjectBottomBar>();
        /// <summary>
        /// 提前加载所有底部栏配置缓存
        /// </summary>
        public static void LoadObjectBottomBar()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ObjectBottomBar);
            foreach (var val in cfg_dict)
            {
                ObjectBottomBar data = new ObjectBottomBar(val.Value);
                data.InitData2();
                ObjectBottomBar_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的底部栏基础配置缓存
        /// </summary>
        public static ObjectBottomBar GetObjectBottomBar(string cfgId)
        {
            if (!ObjectBottomBar_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ObjectBottomBar(cfgId);
                data.InitData2();
                ObjectBottomBar_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ObjectBottomBar GetObjectBottomBar(int cfgId)
        {
            if (!ObjectBottomBar_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ObjectBottomBar(cfgId);
                data.InitData2();
                ObjectBottomBar_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有底部栏数据
        /// </summary>
        public static List<ObjectBottomBar> GetAllObjectBottomBar()
        {
            List<ObjectBottomBar> list = new List<ObjectBottomBar>();
            foreach (var val in ObjectBottomBar_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 侧边栏配置缓存
        /// <summary>
        /// 侧边栏配置缓存
        /// </summary>
        private static readonly Dictionary<string, ObjectSideBar> ObjectSideBar_Cache = new Dictionary<string, ObjectSideBar>();
        /// <summary>
        /// 提前加载所有侧边栏配置缓存
        /// </summary>
        public static void LoadObjectSideBar()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ObjectSideBar);
            foreach (var val in cfg_dict)
            {
                ObjectSideBar data = new ObjectSideBar(val.Value);
                data.InitData2();
                ObjectSideBar_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的侧边栏基础配置缓存
        /// </summary>
        public static ObjectSideBar GetObjectSideBar(string cfgId)
        {
            if (!ObjectSideBar_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ObjectSideBar(cfgId);
                data.InitData2();
                ObjectSideBar_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ObjectSideBar GetObjectSideBar(int cfgId)
        {
            if (!ObjectSideBar_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ObjectSideBar(cfgId);
                data.InitData2();
                ObjectSideBar_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有侧边栏数据
        /// </summary>
        public static List<ObjectSideBar> GetAllObjectSideBar()
        {
            List<ObjectSideBar> list = new List<ObjectSideBar>();
            foreach (var val in ObjectSideBar_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 建筑建筑数据配置缓存
        /// <summary>
        /// 建筑建筑数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, BuildBase> BuildBase_Cache = new Dictionary<string, BuildBase>();
        /// <summary>
        /// 提前加载所有建筑建筑数据配置缓存
        /// </summary>
        public static void LoadBuildBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_BuildBase);
            foreach (var val in cfg_dict)
            {
                BuildBase data = new BuildBase(val.Value);
                data.InitData2();
                BuildBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的建筑建筑数据基础配置缓存
        /// </summary>
        public static BuildBase GetBuildBase(string cfgId)
        {
            if (!BuildBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new BuildBase(cfgId);
                data.InitData2();
                BuildBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static BuildBase GetBuildBase(int cfgId)
        {
            if (!BuildBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new BuildBase(cfgId);
                data.InitData2();
                BuildBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有建筑建筑数据数据
        /// </summary>
        public static List<BuildBase> GetAllBuildBase()
        {
            List<BuildBase> list = new List<BuildBase>();
            foreach (var val in BuildBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 建造规则配置缓存
        /// <summary>
        /// 建造规则配置缓存
        /// </summary>
        private static readonly Dictionary<string, BuildRule> BuildRule_Cache = new Dictionary<string, BuildRule>();
        /// <summary>
        /// 提前加载所有建造规则配置缓存
        /// </summary>
        public static void LoadBuildRule()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_BuildRule);
            foreach (var val in cfg_dict)
            {
                BuildRule data = new BuildRule(val.Value);
                data.InitData2();
                BuildRule_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的建造规则基础配置缓存
        /// </summary>
        public static BuildRule GetBuildRule(string cfgId)
        {
            if (!BuildRule_Cache.TryGetValue(cfgId, out var data))
            {
                data = new BuildRule(cfgId);
                data.InitData2();
                BuildRule_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static BuildRule GetBuildRule(int cfgId)
        {
            if (!BuildRule_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new BuildRule(cfgId);
                data.InitData2();
                BuildRule_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有建造规则数据
        /// </summary>
        public static List<BuildRule> GetAllBuildRule()
        {
            List<BuildRule> list = new List<BuildRule>();
            foreach (var val in BuildRule_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 炮塔基础表配置缓存
        /// <summary>
        /// 炮塔基础表配置缓存
        /// </summary>
        private static readonly Dictionary<string, TowerBase> TowerBase_Cache = new Dictionary<string, TowerBase>();
        /// <summary>
        /// 提前加载所有炮塔基础表配置缓存
        /// </summary>
        public static void LoadTowerBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_TowerBase);
            foreach (var val in cfg_dict)
            {
                TowerBase data = new TowerBase(val.Value);
                data.InitData2();
                TowerBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的炮塔基础表基础配置缓存
        /// </summary>
        public static TowerBase GetTowerBase(string cfgId)
        {
            if (!TowerBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new TowerBase(cfgId);
                data.InitData2();
                TowerBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static TowerBase GetTowerBase(int cfgId)
        {
            if (!TowerBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new TowerBase(cfgId);
                data.InitData2();
                TowerBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有炮塔基础表数据
        /// </summary>
        public static List<TowerBase> GetAllTowerBase()
        {
            List<TowerBase> list = new List<TowerBase>();
            foreach (var val in TowerBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 属性表配置缓存
        /// <summary>
        /// 属性表配置缓存
        /// </summary>
        private static readonly Dictionary<string, AttributeBase> AttributeBase_Cache = new Dictionary<string, AttributeBase>();
        /// <summary>
        /// 提前加载所有属性表配置缓存
        /// </summary>
        public static void LoadAttributeBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_AttributeBase);
            foreach (var val in cfg_dict)
            {
                AttributeBase data = new AttributeBase(val.Value);
                data.InitData2();
                AttributeBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的属性表基础配置缓存
        /// </summary>
        public static AttributeBase GetAttributeBase(string cfgId)
        {
            if (!AttributeBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new AttributeBase(cfgId);
                data.InitData2();
                AttributeBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static AttributeBase GetAttributeBase(int cfgId)
        {
            if (!AttributeBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new AttributeBase(cfgId);
                data.InitData2();
                AttributeBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有属性表数据
        /// </summary>
        public static List<AttributeBase> GetAllAttributeBase()
        {
            List<AttributeBase> list = new List<AttributeBase>();
            foreach (var val in AttributeBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 实体属性表配置缓存
        /// <summary>
        /// 实体属性表配置缓存
        /// </summary>
        private static readonly Dictionary<string, AttributeData> AttributeData_Cache = new Dictionary<string, AttributeData>();
        /// <summary>
        /// 提前加载所有实体属性表配置缓存
        /// </summary>
        public static void LoadAttributeData()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_AttributeData);
            foreach (var val in cfg_dict)
            {
                AttributeData data = new AttributeData(val.Value);
                data.InitData2();
                AttributeData_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的实体属性表基础配置缓存
        /// </summary>
        public static AttributeData GetAttributeData(string cfgId)
        {
            if (!AttributeData_Cache.TryGetValue(cfgId, out var data))
            {
                data = new AttributeData(cfgId);
                data.InitData2();
                AttributeData_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static AttributeData GetAttributeData(int cfgId)
        {
            if (!AttributeData_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new AttributeData(cfgId);
                data.InitData2();
                AttributeData_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有实体属性表数据
        /// </summary>
        public static List<AttributeData> GetAllAttributeData()
        {
            List<AttributeData> list = new List<AttributeData>();
            foreach (var val in AttributeData_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 属性计算表配置缓存
        /// <summary>
        /// 属性计算表配置缓存
        /// </summary>
        private static readonly Dictionary<string, AttrCalculate> AttrCalculate_Cache = new Dictionary<string, AttrCalculate>();
        /// <summary>
        /// 提前加载所有属性计算表配置缓存
        /// </summary>
        public static void LoadAttrCalculate()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_AttrCalculate);
            foreach (var val in cfg_dict)
            {
                AttrCalculate data = new AttrCalculate(val.Value);
                data.InitData2();
                AttrCalculate_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的属性计算表基础配置缓存
        /// </summary>
        public static AttrCalculate GetAttrCalculate(string cfgId)
        {
            if (!AttrCalculate_Cache.TryGetValue(cfgId, out var data))
            {
                data = new AttrCalculate(cfgId);
                data.InitData2();
                AttrCalculate_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static AttrCalculate GetAttrCalculate(int cfgId)
        {
            if (!AttrCalculate_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new AttrCalculate(cfgId);
                data.InitData2();
                AttrCalculate_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有属性计算表数据
        /// </summary>
        public static List<AttrCalculate> GetAllAttrCalculate()
        {
            List<AttrCalculate> list = new List<AttrCalculate>();
            foreach (var val in AttrCalculate_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 属性依赖表配置缓存
        /// <summary>
        /// 属性依赖表配置缓存
        /// </summary>
        private static readonly Dictionary<string, AttrDependency> AttrDependency_Cache = new Dictionary<string, AttrDependency>();
        /// <summary>
        /// 提前加载所有属性依赖表配置缓存
        /// </summary>
        public static void LoadAttrDependency()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_AttrDependency);
            foreach (var val in cfg_dict)
            {
                AttrDependency data = new AttrDependency(val.Value);
                data.InitData2();
                AttrDependency_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的属性依赖表基础配置缓存
        /// </summary>
        public static AttrDependency GetAttrDependency(string cfgId)
        {
            if (!AttrDependency_Cache.TryGetValue(cfgId, out var data))
            {
                data = new AttrDependency(cfgId);
                data.InitData2();
                AttrDependency_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static AttrDependency GetAttrDependency(int cfgId)
        {
            if (!AttrDependency_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new AttrDependency(cfgId);
                data.InitData2();
                AttrDependency_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有属性依赖表数据
        /// </summary>
        public static List<AttrDependency> GetAllAttrDependency()
        {
            List<AttrDependency> list = new List<AttrDependency>();
            foreach (var val in AttrDependency_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 随机生成地图方式配置缓存
        /// <summary>
        /// 随机生成地图方式配置缓存
        /// </summary>
        private static readonly Dictionary<string, GenerateBottomMap> GenerateBottomMap_Cache = new Dictionary<string, GenerateBottomMap>();
        /// <summary>
        /// 提前加载所有随机生成地图方式配置缓存
        /// </summary>
        public static void LoadGenerateBottomMap()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_GenerateBottomMap);
            foreach (var val in cfg_dict)
            {
                GenerateBottomMap data = new GenerateBottomMap(val.Value);
                data.InitData2();
                GenerateBottomMap_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的随机生成地图方式基础配置缓存
        /// </summary>
        public static GenerateBottomMap GetGenerateBottomMap(string cfgId)
        {
            if (!GenerateBottomMap_Cache.TryGetValue(cfgId, out var data))
            {
                data = new GenerateBottomMap(cfgId);
                data.InitData2();
                GenerateBottomMap_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static GenerateBottomMap GetGenerateBottomMap(int cfgId)
        {
            if (!GenerateBottomMap_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new GenerateBottomMap(cfgId);
                data.InitData2();
                GenerateBottomMap_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有随机生成地图方式数据
        /// </summary>
        public static List<GenerateBottomMap> GetAllGenerateBottomMap()
        {
            List<GenerateBottomMap> list = new List<GenerateBottomMap>();
            foreach (var val in GenerateBottomMap_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 生成地图用材料配置缓存
        /// <summary>
        /// 生成地图用材料配置缓存
        /// </summary>
        private static readonly Dictionary<string, MapMaterial> MapMaterial_Cache = new Dictionary<string, MapMaterial>();
        /// <summary>
        /// 提前加载所有生成地图用材料配置缓存
        /// </summary>
        public static void LoadMapMaterial()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_MapMaterial);
            foreach (var val in cfg_dict)
            {
                MapMaterial data = new MapMaterial(val.Value);
                data.InitData2();
                MapMaterial_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的生成地图用材料基础配置缓存
        /// </summary>
        public static MapMaterial GetMapMaterial(string cfgId)
        {
            if (!MapMaterial_Cache.TryGetValue(cfgId, out var data))
            {
                data = new MapMaterial(cfgId);
                data.InitData2();
                MapMaterial_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static MapMaterial GetMapMaterial(int cfgId)
        {
            if (!MapMaterial_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new MapMaterial(cfgId);
                data.InitData2();
                MapMaterial_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有生成地图用材料数据
        /// </summary>
        public static List<MapMaterial> GetAllMapMaterial()
        {
            List<MapMaterial> list = new List<MapMaterial>();
            foreach (var val in MapMaterial_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 地图额外绘制表配置缓存
        /// <summary>
        /// 地图额外绘制表配置缓存
        /// </summary>
        private static readonly Dictionary<string, MapExtraDraw> MapExtraDraw_Cache = new Dictionary<string, MapExtraDraw>();
        /// <summary>
        /// 提前加载所有地图额外绘制表配置缓存
        /// </summary>
        public static void LoadMapExtraDraw()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_MapExtraDraw);
            foreach (var val in cfg_dict)
            {
                MapExtraDraw data = new MapExtraDraw(val.Value);
                data.InitData2();
                MapExtraDraw_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的地图额外绘制表基础配置缓存
        /// </summary>
        public static MapExtraDraw GetMapExtraDraw(string cfgId)
        {
            if (!MapExtraDraw_Cache.TryGetValue(cfgId, out var data))
            {
                data = new MapExtraDraw(cfgId);
                data.InitData2();
                MapExtraDraw_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static MapExtraDraw GetMapExtraDraw(int cfgId)
        {
            if (!MapExtraDraw_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new MapExtraDraw(cfgId);
                data.InitData2();
                MapExtraDraw_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有地图额外绘制表数据
        /// </summary>
        public static List<MapExtraDraw> GetAllMapExtraDraw()
        {
            List<MapExtraDraw> list = new List<MapExtraDraw>();
            foreach (var val in MapExtraDraw_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 地图大型结构配置缓存
        /// <summary>
        /// 地图大型结构配置缓存
        /// </summary>
        private static readonly Dictionary<string, GenerateBigStruct> GenerateBigStruct_Cache = new Dictionary<string, GenerateBigStruct>();
        /// <summary>
        /// 提前加载所有地图大型结构配置缓存
        /// </summary>
        public static void LoadGenerateBigStruct()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_GenerateBigStruct);
            foreach (var val in cfg_dict)
            {
                GenerateBigStruct data = new GenerateBigStruct(val.Value);
                data.InitData2();
                GenerateBigStruct_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的地图大型结构基础配置缓存
        /// </summary>
        public static GenerateBigStruct GetGenerateBigStruct(string cfgId)
        {
            if (!GenerateBigStruct_Cache.TryGetValue(cfgId, out var data))
            {
                data = new GenerateBigStruct(cfgId);
                data.InitData2();
                GenerateBigStruct_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static GenerateBigStruct GetGenerateBigStruct(int cfgId)
        {
            if (!GenerateBigStruct_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new GenerateBigStruct(cfgId);
                data.InitData2();
                GenerateBigStruct_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有地图大型结构数据
        /// </summary>
        public static List<GenerateBigStruct> GetAllGenerateBigStruct()
        {
            List<GenerateBigStruct> list = new List<GenerateBigStruct>();
            foreach (var val in GenerateBigStruct_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 地图墙壁表配置缓存
        /// <summary>
        /// 地图墙壁表配置缓存
        /// </summary>
        private static readonly Dictionary<string, MapWall> MapWall_Cache = new Dictionary<string, MapWall>();
        /// <summary>
        /// 提前加载所有地图墙壁表配置缓存
        /// </summary>
        public static void LoadMapWall()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_MapWall);
            foreach (var val in cfg_dict)
            {
                MapWall data = new MapWall(val.Value);
                data.InitData2();
                MapWall_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的地图墙壁表基础配置缓存
        /// </summary>
        public static MapWall GetMapWall(string cfgId)
        {
            if (!MapWall_Cache.TryGetValue(cfgId, out var data))
            {
                data = new MapWall(cfgId);
                data.InitData2();
                MapWall_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static MapWall GetMapWall(int cfgId)
        {
            if (!MapWall_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new MapWall(cfgId);
                data.InitData2();
                MapWall_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有地图墙壁表数据
        /// </summary>
        public static List<MapWall> GetAllMapWall()
        {
            List<MapWall> list = new List<MapWall>();
            foreach (var val in MapWall_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 章节基础数据配置缓存
        /// <summary>
        /// 章节基础数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, ChapterBase> ChapterBase_Cache = new Dictionary<string, ChapterBase>();
        /// <summary>
        /// 提前加载所有章节基础数据配置缓存
        /// </summary>
        public static void LoadChapterBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ChapterBase);
            foreach (var val in cfg_dict)
            {
                ChapterBase data = new ChapterBase(val.Value);
                data.InitData2();
                ChapterBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的章节基础数据基础配置缓存
        /// </summary>
        public static ChapterBase GetChapterBase(string cfgId)
        {
            if (!ChapterBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ChapterBase(cfgId);
                data.InitData2();
                ChapterBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ChapterBase GetChapterBase(int cfgId)
        {
            if (!ChapterBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ChapterBase(cfgId);
                data.InitData2();
                ChapterBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有章节基础数据数据
        /// </summary>
        public static List<ChapterBase> GetAllChapterBase()
        {
            List<ChapterBase> list = new List<ChapterBase>();
            foreach (var val in ChapterBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 章节关卡基础数据配置缓存
        /// <summary>
        /// 章节关卡基础数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, ChapterCopyBase> ChapterCopyBase_Cache = new Dictionary<string, ChapterCopyBase>();
        /// <summary>
        /// 提前加载所有章节关卡基础数据配置缓存
        /// </summary>
        public static void LoadChapterCopyBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ChapterCopyBase);
            foreach (var val in cfg_dict)
            {
                ChapterCopyBase data = new ChapterCopyBase(val.Value);
                data.InitData2();
                ChapterCopyBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的章节关卡基础数据基础配置缓存
        /// </summary>
        public static ChapterCopyBase GetChapterCopyBase(string cfgId)
        {
            if (!ChapterCopyBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ChapterCopyBase(cfgId);
                data.InitData2();
                ChapterCopyBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ChapterCopyBase GetChapterCopyBase(int cfgId)
        {
            if (!ChapterCopyBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ChapterCopyBase(cfgId);
                data.InitData2();
                ChapterCopyBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有章节关卡基础数据数据
        /// </summary>
        public static List<ChapterCopyBase> GetAllChapterCopyBase()
        {
            List<ChapterCopyBase> list = new List<ChapterCopyBase>();
            foreach (var val in ChapterCopyBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 章节关卡UI数据配置缓存
        /// <summary>
        /// 章节关卡UI数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, ChapterCopyUI> ChapterCopyUI_Cache = new Dictionary<string, ChapterCopyUI>();
        /// <summary>
        /// 提前加载所有章节关卡UI数据配置缓存
        /// </summary>
        public static void LoadChapterCopyUI()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_ChapterCopyUI);
            foreach (var val in cfg_dict)
            {
                ChapterCopyUI data = new ChapterCopyUI(val.Value);
                data.InitData2();
                ChapterCopyUI_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的章节关卡UI数据基础配置缓存
        /// </summary>
        public static ChapterCopyUI GetChapterCopyUI(string cfgId)
        {
            if (!ChapterCopyUI_Cache.TryGetValue(cfgId, out var data))
            {
                data = new ChapterCopyUI(cfgId);
                data.InitData2();
                ChapterCopyUI_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static ChapterCopyUI GetChapterCopyUI(int cfgId)
        {
            if (!ChapterCopyUI_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new ChapterCopyUI(cfgId);
                data.InitData2();
                ChapterCopyUI_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有章节关卡UI数据数据
        /// </summary>
        public static List<ChapterCopyUI> GetAllChapterCopyUI()
        {
            List<ChapterCopyUI> list = new List<ChapterCopyUI>();
            foreach (var val in ChapterCopyUI_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 资源配置缓存
        /// <summary>
        /// 资源配置缓存
        /// </summary>
        private static readonly Dictionary<string, Ziyuan> Ziyuan_Cache = new Dictionary<string, Ziyuan>();
        /// <summary>
        /// 提前加载所有资源配置缓存
        /// </summary>
        public static void LoadZiyuan()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_Ziyuan);
            foreach (var val in cfg_dict)
            {
                Ziyuan data = new Ziyuan(val.Value);
                data.InitData2();
                Ziyuan_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的资源基础配置缓存
        /// </summary>
        public static Ziyuan GetZiyuan(string cfgId)
        {
            if (!Ziyuan_Cache.TryGetValue(cfgId, out var data))
            {
                data = new Ziyuan(cfgId);
                data.InitData2();
                Ziyuan_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static Ziyuan GetZiyuan(int cfgId)
        {
            if (!Ziyuan_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new Ziyuan(cfgId);
                data.InitData2();
                Ziyuan_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有资源数据
        /// </summary>
        public static List<Ziyuan> GetAllZiyuan()
        {
            List<Ziyuan> list = new List<Ziyuan>();
            foreach (var val in Ziyuan_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        
        #region 阵营基础数据配置缓存
        /// <summary>
        /// 阵营基础数据配置缓存
        /// </summary>
        private static readonly Dictionary<string, CampBase> CampBase_Cache = new Dictionary<string, CampBase>();
        /// <summary>
        /// 提前加载所有阵营基础数据配置缓存
        /// </summary>
        public static void LoadCampBase()
        {
            Dictionary<string, Dictionary<string, object>> cfg_dict = ConfigLoadSystem.GetCfg(ConfigConstant.Config_CampBase);
            foreach (var val in cfg_dict)
            {
                CampBase data = new CampBase(val.Value);
                data.InitData2();
                CampBase_Cache.Add(val.Key, data);
            }
        }
        /// <summary>
        /// 加载或获取已缓存的阵营基础数据基础配置缓存
        /// </summary>
        public static CampBase GetCampBase(string cfgId)
        {
            if (!CampBase_Cache.TryGetValue(cfgId, out var data))
            {
                data = new CampBase(cfgId);
                data.InitData2();
                CampBase_Cache.Add(cfgId, data);
            }
            return data;
        }
        public static CampBase GetCampBase(int cfgId)
        {
            if (!CampBase_Cache.TryGetValue("" + cfgId, out var data))
            {
                data = new CampBase(cfgId);
                data.InitData2();
                CampBase_Cache.Add("" + cfgId, data);
            }
            return data;
        }
        /// <summary>
        /// 获取加载的所有阵营基础数据数据
        /// </summary>
        public static List<CampBase> GetAllCampBase()
        {
            List<CampBase> list = new List<CampBase>();
            foreach (var val in CampBase_Cache)
            {
                list.Add(val.Value);
            }
            return list;
        }
        #endregion
        
        


        /// <summary>
        /// 清理所有缓存数据
        /// </summary>
        public static void ClearAllCache()
        {
            ViewBase_Cache.Clear();
            UpdateLog_Cache.Clear();
            AttainmentPage_Cache.Clear();
            AttainmentBase_Cache.Clear();
            ScienceRange_Cache.Clear();
            ScienceBase_Cache.Clear();
            ScienceData_Cache.Clear();
            ConfigCover_Cache.Clear();
            ConfigCall_Cache.Clear();
            GlobalConfigInt_Cache.Clear();
            GlobalConfigStr_Cache.Clear();
            GlobalConfigFloat_Cache.Clear();
            GlobalConfigList_Cache.Clear();
            FunctionTemplate_Cache.Clear();
            CameraBase_Cache.Clear();
            CameraAssembly_Cache.Clear();
            MapBrushMonster_Cache.Clear();
            MapBrushPoint_Cache.Clear();
            Wave_Cache.Clear();
            Enemy_Cache.Clear();
            TestTowerBase_Cache.Clear();
            TestTowerAttr_Cache.Clear();
            科技树测试_Cache.Clear();
            材料基础模板_Cache.Clear();
            材料类型模板_Cache.Clear();
            BulletBase_Cache.Clear();
            BaseObjectShow_Cache.Clear();
            ObjectBottomBar_Cache.Clear();
            ObjectSideBar_Cache.Clear();
            BuildBase_Cache.Clear();
            BuildRule_Cache.Clear();
            TowerBase_Cache.Clear();
            AttributeBase_Cache.Clear();
            AttributeData_Cache.Clear();
            AttrCalculate_Cache.Clear();
            AttrDependency_Cache.Clear();
            GenerateBottomMap_Cache.Clear();
            MapMaterial_Cache.Clear();
            MapExtraDraw_Cache.Clear();
            GenerateBigStruct_Cache.Clear();
            MapWall_Cache.Clear();
            ChapterBase_Cache.Clear();
            ChapterCopyBase_Cache.Clear();
            ChapterCopyUI_Cache.Clear();
            Ziyuan_Cache.Clear();
            CampBase_Cache.Clear();
        }
    }
}