#if UNITY_EDITOR

using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

public class ftSettingsAsset : ScriptableObject
{
    // Defaults
    [SerializeField]
    public int renderSettingsBounces = 5;
    [SerializeField]
    public int renderSettingsGISamples = 16;
    [SerializeField]
    public float renderSettingsGIBackFaceWeight = 0;
    [SerializeField]
    public int renderSettingsTileSize = 512;
    [SerializeField]
    public float renderSettingsPriority = 2;
    [SerializeField]
    public float renderSettingsTexelsPerUnit = 20;
    [SerializeField]
    public bool renderSettingsForceRefresh = true;
    [SerializeField]
    public bool renderSettingsForceRebuildGeometry = true;
    [SerializeField]
    public bool renderSettingsPerformRendering = true;
    [SerializeField]
    public int renderSettingsUserRenderMode = 0;
    [SerializeField]
    public bool renderSettingsDistanceShadowmask = false;
    [SerializeField]
    public int renderSettingsSettingsMode = 0;
    [SerializeField]
    public bool renderSettingsFixSeams = true;
    [SerializeField]
    public bool renderSettingsDenoise = true;
    [SerializeField]
    public bool renderSettingsDenoise2x = false;
    [SerializeField]
    public bool renderSettingsEncode = true;
    [SerializeField]
    public int renderSettingsEncodeMode = 0;
    [SerializeField]
    public bool renderSettingsOverwriteWarning = false;
    [SerializeField]
    public bool renderSettingsAutoAtlas = true;
    [SerializeField]
    public bool renderSettingsUnwrapUVs = true;
    [SerializeField]
    public bool renderSettingsForceDisableUnwrapUVs = false;
    [SerializeField]
    public int renderSettingsMaxAutoResolution = 4096;
    [SerializeField]
    public int renderSettingsMinAutoResolution = 16;
    [SerializeField]
    public bool renderSettingsUnloadScenes = true;
    [SerializeField]
    public bool renderSettingsAdjustSamples = true;
    [SerializeField]
    public int renderSettingsGILODMode = 2;
    [SerializeField]
    public bool renderSettingsGILODModeEnabled = false;
    [SerializeField]
    public bool renderSettingsCheckOverlaps = false;
    [SerializeField]
    public bool renderSettingsSkipOutOfBoundsUVs = true;
    [SerializeField]
    public float renderSettingsHackEmissiveBoost = 1;
    [SerializeField]
    public float renderSettingsHackIndirectBoost = 1;
    [SerializeField]
    public string renderSettingsTempPath = "";
    [SerializeField]
    public string renderSettingsOutPath = "";
    [SerializeField]
    public bool renderSettingsUseScenePath = false;
    [SerializeField]
    public float renderSettingsHackAOIntensity = 0;
    [SerializeField]
    public int renderSettingsHackAOSamples = 16;
    [SerializeField]
    public float renderSettingsHackAORadius = 1;
    [SerializeField]
    public bool renderSettingsShowAOSettings = false;
    [SerializeField]
    public bool renderSettingsShowTasks = true;
    [SerializeField]
    public bool renderSettingsShowTasks2 = false;
    [SerializeField]
    public bool renderSettingsShowPaths = true;
    [SerializeField]
    public bool renderSettingsShowNet = true;
    [SerializeField]
    public bool renderSettingsShowSettingsAsset = false;
    [SerializeField]
    public bool renderSettingsOcclusionProbes = false;
    [SerializeField]
    public bool renderSettingsTexelsPerMap = false;
    [SerializeField]
    public float renderSettingsTexelsColor = 1;
    [SerializeField]
    public float renderSettingsTexelsMask = 1;
    [SerializeField]
    public float renderSettingsTexelsDir = 1;
    [SerializeField]
    public bool renderSettingsShowDirWarning = true;
    [SerializeField]
    public int renderSettingsRenderDirMode = 0;
    [SerializeField]
    public bool renderSettingsShowCheckerSettings = false;
    [SerializeField]
    public bool renderSettingsSamplesWarning = true;
    [SerializeField]
    public bool renderSettingsSuppressPopups = false;
    [SerializeField]
    public bool renderSettingsPrefabWarning = true;
    [SerializeField]
    public bool renderSettingsSplitByScene = false;
    [SerializeField]
    public bool renderSettingsSplitByTag = false;
    [SerializeField]
    public bool renderSettingsUVPaddingMax = false;
    [SerializeField]
    public bool renderSettingsUVPaddingPreserveIfExisted = false;
    [SerializeField]
    public bool renderSettingsPostPacking = true;
    [SerializeField]
    public bool renderSettingsHoleFilling = false;
    [SerializeField]
    public bool renderSettingsAlphaDithering = false;
    [SerializeField]
    public bool renderSettingsBeepOnFinish = false;
    [SerializeField]
    public bool renderSettingsExportTerrainAsHeightmap = true;
    [SerializeField]
    public bool renderSettingsRTXMode = false;
    [SerializeField]
    public int renderSettingsLightProbeMode = 1;
    [SerializeField]
    public bool renderSettingsClientMode = false;
    [SerializeField]
    public string renderSettingsServerAddress = "127.0.0.1";
    [SerializeField]
    public int renderSettingsUnwrapper = 0;
    [SerializeField]
    public int renderSettingsDenoiserType = (int)ftGlobalStorage.DenoiserType.OpenImageDenoise;
    [SerializeField]
    public bool renderSettingsExportTerrainTrees = false;
    [SerializeField]
    public bool renderSettingsShowPerf = true;
    [SerializeField]
    public int renderSettingsSampleDiv = 1;
    //[SerializeField]
    //public bool renderSettingsLegacyDenoiser = false;
    [SerializeField]
    public ftGlobalStorage.AtlasPacker renderSettingsAtlasPacker = ftGlobalStorage.AtlasPacker.Default;
    [SerializeField]
    public bool renderSettingsBatchPoints = true;
    [SerializeField]
    public bool renderSettingsCompressVolumes = false;
    [SerializeField]
    public int renderSettingsBatchAreaLightSampleLimit = 0;
    [SerializeField]
    public bool renderSettingsRTPVExport = true;
    [SerializeField]
    public bool renderSettingsRTPVSceneView = false;
    [SerializeField]
    public bool renderSettingsRTPVHDR = false;
    [SerializeField]
    public int renderSettingsRTPVWidth = 640;
    [SerializeField]
    public int renderSettingsRTPVHeight = 360;
    [SerializeField]
    public float renderSettingsRTPVExposure = 1.0f;
}

#endif