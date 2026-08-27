#r "nuget: Esri.ArcGISRuntime, 300.0.0"
open Esri.ArcGISRuntime
open Esri.ArcGISRuntime.ArcGISServices
open Esri.ArcGISRuntime.Data
open Esri.ArcGISRuntime.Geometry
open System

type MapService =
    { CurrentVersion: string
      ExportTileCacheCompactV2Allowed: bool
      ExportTilesAllowed: bool
      MapName: string
      MaxExportTilesCount: int
      MaxImageHeight: int
      MaxImageWidth: int
      MaxRecordCount: int
      MaxScale: float
      MinScale: float
      ServiceDescription: string
      SupportedImageFormatTypes: string array
      SupportsDynamicLayers: bool
      ServiceSourceType: ServiceType
      SingleFusedMapCache: bool
      Source: Uri }

    static member from_clr(arcGISMapServiceInfo: ArcGISMapServiceInfo): MapService =
        { CurrentVersion = arcGISMapServiceInfo.CurrentVersion
          ExportTileCacheCompactV2Allowed = arcGISMapServiceInfo.ExportTileCacheCompactV2Allowed
          ExportTilesAllowed = arcGISMapServiceInfo.ExportTilesAllowed
          MapName = arcGISMapServiceInfo.MapName
          MaxExportTilesCount = arcGISMapServiceInfo.MaxExportTilesCount
          MaxImageHeight = arcGISMapServiceInfo.MaxImageHeight
          MaxImageWidth = arcGISMapServiceInfo.MaxImageWidth
          MaxRecordCount = arcGISMapServiceInfo.MaxRecordCount
          MaxScale = arcGISMapServiceInfo.MaxScale
          MinScale = arcGISMapServiceInfo.MinScale
          ServiceDescription = arcGISMapServiceInfo.ServiceDescription
          SupportedImageFormatTypes = arcGISMapServiceInfo.SupportedImageFormatTypes |> Seq.toArray
          SupportsDynamicLayers = arcGISMapServiceInfo.SupportsDynamicLayers
          ServiceSourceType = arcGISMapServiceInfo.ServiceSourceType
          SingleFusedMapCache = arcGISMapServiceInfo.SingleFusedMapCache
          Source = arcGISMapServiceInfo.Source }

type GroupLayer =
    { Version: string
      ServiceLayerId: int64
      ServiceLayerName: string
      SublayerType: ArcGISMapServiceSublayerType
      HasM: bool
      HasZ: bool
      MinScale: float
      MaxScale: float
      DefaultVisibility: bool
      HasAttachments: bool
      CanModifyLayer: bool
      SupportsStatistics: bool
      SupportsAdvancedQueries: bool
      HasLabels: bool
      CanScaleSymbols: bool
      IsDataVersioned: bool
      UseStandardizedQueries: bool }

    static member from_clr(arcGISMapServiceSublayerInfo: ArcGISMapServiceSublayerInfo): GroupLayer =
        { Version = arcGISMapServiceSublayerInfo.Version
          ServiceLayerId = arcGISMapServiceSublayerInfo.ServiceLayerId
          ServiceLayerName = arcGISMapServiceSublayerInfo.ServiceLayerName
          SublayerType = arcGISMapServiceSublayerInfo.SublayerType
          HasM = arcGISMapServiceSublayerInfo.HasM
          HasZ = arcGISMapServiceSublayerInfo.HasZ
          MinScale = arcGISMapServiceSublayerInfo.MinScale
          MaxScale = arcGISMapServiceSublayerInfo.MaxScale
          DefaultVisibility = arcGISMapServiceSublayerInfo.DefaultVisibility
          HasAttachments = arcGISMapServiceSublayerInfo.HasAttachments
          CanModifyLayer = arcGISMapServiceSublayerInfo.CanModifyLayer
          SupportsStatistics = arcGISMapServiceSublayerInfo.SupportsStatistics
          SupportsAdvancedQueries = arcGISMapServiceSublayerInfo.SupportsAdvancedQueries
          HasLabels = arcGISMapServiceSublayerInfo.HasLabels
          CanScaleSymbols = arcGISMapServiceSublayerInfo.CanScaleSymbols
          IsDataVersioned = arcGISMapServiceSublayerInfo.IsDataVersioned
          UseStandardizedQueries = arcGISMapServiceSublayerInfo.UseStandardizedQueries }

type FeatureLayer =
    { Version: string
      ServiceLayerId: int64
      ServiceLayerName: string
      SublayerType: ArcGISMapServiceSublayerType
      HasM: bool
      HasZ: bool
      MinScale: float
      MaxScale: float
      DefaultVisibility: bool
      HasAttachments: bool
      DisplayFieldName: string
      TypeIdFieldName: string option
      CanModifyLayer: bool
      SupportsStatistics: bool
      SupportsAdvancedQueries: bool
      HasLabels: bool
      CanScaleSymbols: bool
      IsDataVersioned: bool
      UseStandardizedQueries: bool
      SubtypeField: string option }

    static member from_clr(arcGISMapServiceSublayerInfo: ArcGISMapServiceSublayerInfo): FeatureLayer =
        { Version = arcGISMapServiceSublayerInfo.Version
          ServiceLayerId = arcGISMapServiceSublayerInfo.ServiceLayerId
          ServiceLayerName = arcGISMapServiceSublayerInfo.ServiceLayerName
          SublayerType = arcGISMapServiceSublayerInfo.SublayerType
          HasM = arcGISMapServiceSublayerInfo.HasM
          HasZ = arcGISMapServiceSublayerInfo.HasZ
          MinScale = arcGISMapServiceSublayerInfo.MinScale
          MaxScale = arcGISMapServiceSublayerInfo.MaxScale
          DefaultVisibility = arcGISMapServiceSublayerInfo.DefaultVisibility
          HasAttachments = arcGISMapServiceSublayerInfo.HasAttachments
          DisplayFieldName = arcGISMapServiceSublayerInfo.DisplayFieldName
          TypeIdFieldName = Some arcGISMapServiceSublayerInfo.TypeIdFieldName
          CanModifyLayer = arcGISMapServiceSublayerInfo.CanModifyLayer
          SupportsStatistics = arcGISMapServiceSublayerInfo.SupportsStatistics
          SupportsAdvancedQueries = arcGISMapServiceSublayerInfo.SupportsAdvancedQueries
          HasLabels = arcGISMapServiceSublayerInfo.HasLabels
          CanScaleSymbols = arcGISMapServiceSublayerInfo.CanScaleSymbols
          IsDataVersioned = arcGISMapServiceSublayerInfo.IsDataVersioned
          UseStandardizedQueries = arcGISMapServiceSublayerInfo.UseStandardizedQueries
          SubtypeField = Some arcGISMapServiceSublayerInfo.SubtypeField }

let Layers =
    { CurrentVersion = "10.81"
      ExportTileCacheCompactV2Allowed = false
      ExportTilesAllowed = false
      MapName = "Layers"
      MaxExportTilesCount = 0
      MaxImageHeight = 4096
      MaxImageWidth = 4096
      MaxRecordCount = 3000
      MaxScale = 0.0
      MinScale = 577790.554289
      ServiceDescription =
        "This map service layer (image layer) contains storm-water inventory for unincorporated Leon County that has been developed from a variety of sources. It contains FDOT and Leon County inventory features as well as some private connections. It falls into roughly 4 categories.\n\n1 – That which was produced by LCPW vendors.\n- Limitations with this set include bad geometry – meaning either not snapped or incorrect feature types. Table data present but not assessed.\n\n2 – Drawn in by TLCGIS staff according to as-built documents (typically areas with more complex sub-surface drainage conditions).\n- Very good geometry with somewhat less robust attribute data.\n\n3 – Drawn in by TLCGIS staff using a combination of Google Street View, 2018 DEM/Hillshade, various aerial imagery data and other data sources such as drainage easements. These reflect areas of relatively simple drainage conditions such as culverts, MES, headwalls, Spillways, etc.\n- Primary limitation being there is very little attribute data and also includes disconnected surface features that need as-builts to complete.\n\n4 – Drawn in by TLCGIS staff that represent neighborhood drainage conditions.\n- These are exclusively geometry with no real attribute data. Mostly this is mostly culverts and associated end sections where identifiable.\n\nAll data is drawn in direction of flow. Guess work has been mitigated by using Google Street View, over 10 years of various aerial imagery and DEM results to carefully place features in their actual locations. The vendor data uses GPS and is less well positioned. Any locations where unincorporated data from as-builts intersects with COTSW inventory has not been drawn in but rather connected to (snapped) to the COTSW data. *If you are a Leon County Engineer and you need access to COTSW inventory data that can be arranged. COTSW data will however not be included in the Public Works or DSEM web mapping applications.\n"
      SupportedImageFormatTypes =
        [| "PNG32"
           "PNG24"
           "PNG"
           "JPG"
           "DIB"
           "TIFF"
           "EMF"
           "PS"
           "PDF"
           "GIF"
           "SVG"
           "SVGZ"
           "BMP" |]
      SupportsDynamicLayers = true
      ServiceSourceType = ServiceType.MapService
      SingleFusedMapCache = false
      Source =
        new Uri "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer" }

let Drainage_Network =
    { Version = "10.81"
      ServiceLayerId = 0L
      ServiceLayerName = "Drainage Network"
      SublayerType = ArcGISMapServiceSublayerType.GroupLayer
      HasM = false
      HasZ = false
      MinScale = 0.0
      MaxScale = 0.0
      DefaultVisibility = true
      HasAttachments = false
      CanModifyLayer = false
      SupportsStatistics = false
      SupportsAdvancedQueries = false
      HasLabels = false
      CanScaleSymbols = false
      IsDataVersioned = false
      UseStandardizedQueries = true }

let Non_Drainage_Network =
    { Version = "10.81"
      ServiceLayerId = 23L
      ServiceLayerName = "Non-Drainage Network"
      SublayerType = ArcGISMapServiceSublayerType.GroupLayer
      HasM = false
      HasZ = false
      MinScale = 0.0
      MaxScale = 0.0
      DefaultVisibility = true
      HasAttachments = false
      CanModifyLayer = false
      SupportsStatistics = false
      SupportsAdvancedQueries = false
      HasLabels = false
      CanScaleSymbols = false
      IsDataVersioned = false
      UseStandardizedQueries = true }

let Stormwater_Pond___Top_of_Bank =
    { Version = "10.81"
      ServiceLayerId = 17L
      ServiceLayerName = "Stormwater Pond - Top of Bank"
      SublayerType = ArcGISMapServiceSublayerType.FeatureLayer
      HasM = false
      HasZ = true
      MinScale = 577790.554289
      MaxScale = 0.0
      DefaultVisibility = true
      HasAttachments = false
      DisplayFieldName = "LIFECYCLE"
      TypeIdFieldName = Some "SUBTYPEFIELD"
      CanModifyLayer = true
      SupportsStatistics = true
      SupportsAdvancedQueries = true
      HasLabels = false
      CanScaleSymbols = false
      IsDataVersioned = false
      UseStandardizedQueries = true
      SubtypeField = Some "SUBTYPEFIELD" }

let Outfall_Drainage_Area_MS4 =
    { Version = "10.81"
      ServiceLayerId = 18L
      ServiceLayerName = "Outfall Drainage Area MS4"
      SublayerType = ArcGISMapServiceSublayerType.FeatureLayer
      HasM = false
      HasZ = false
      MinScale = 577790.554289
      MaxScale = 0.0
      DefaultVisibility = false
      HasAttachments = false
      DisplayFieldName = "FACILITYID"
      TypeIdFieldName = None
      CanModifyLayer = true
      SupportsStatistics = true
      SupportsAdvancedQueries = true
      HasLabels = false
      CanScaleSymbols = false
      IsDataVersioned = false
      UseStandardizedQueries = true
      SubtypeField = None }

let Outfall_Drainage_Area =
    { Version = "10.81"
      ServiceLayerId = 19L
      ServiceLayerName = "Outfall Drainage Area"
      SublayerType = ArcGISMapServiceSublayerType.FeatureLayer
      HasM = false
      HasZ = false
      MinScale = 577790.554289
      MaxScale = 0.0
      DefaultVisibility = true
      HasAttachments = false
      DisplayFieldName = "FACILITYID"
      TypeIdFieldName = None
      CanModifyLayer = true
      SupportsStatistics = true
      SupportsAdvancedQueries = true
      HasLabels = false
      CanScaleSymbols = false
      IsDataVersioned = false
      UseStandardizedQueries = true
      SubtypeField = None }

let Outfall_Drainage_Area_MOF =
    { Version = "10.81"
      ServiceLayerId = 20L
      ServiceLayerName = "Outfall Drainage Area MOF"
      SublayerType = ArcGISMapServiceSublayerType.FeatureLayer
      HasM = false
      HasZ = false
      MinScale = 577790.554289
      MaxScale = 0.0
      DefaultVisibility = false
      HasAttachments = false
      DisplayFieldName = "FACILITYID"
      TypeIdFieldName = None
      CanModifyLayer = true
      SupportsStatistics = true
      SupportsAdvancedQueries = true
      HasLabels = false
      CanScaleSymbols = false
      IsDataVersioned = false
      UseStandardizedQueries = true
      SubtypeField = None }

let Media_Points =
    { Version = "10.81"
      ServiceLayerId = 21L
      ServiceLayerName = "Media Points"
      SublayerType = ArcGISMapServiceSublayerType.FeatureLayer
      HasM = false
      HasZ = false
      MinScale = 577790.554289
      MaxScale = 0.0
      DefaultVisibility = false
      HasAttachments = false
      DisplayFieldName = "RAW_NAME"
      TypeIdFieldName = None
      CanModifyLayer = true
      SupportsStatistics = true
      SupportsAdvancedQueries = true
      HasLabels = false
      CanScaleSymbols = false
      IsDataVersioned = false
      UseStandardizedQueries = true
      SubtypeField = None }

let Damage =
    { Version = "10.81"
      ServiceLayerId = 22L
      ServiceLayerName = "Damage"
      SublayerType = ArcGISMapServiceSublayerType.FeatureLayer
      HasM = false
      HasZ = false
      MinScale = 577790.554289
      MaxScale = 0.0
      DefaultVisibility = true
      HasAttachments = false
      DisplayFieldName = "PONDID"
      TypeIdFieldName = None
      CanModifyLayer = true
      SupportsStatistics = true
      SupportsAdvancedQueries = true
      HasLabels = false
      CanScaleSymbols = false
      IsDataVersioned = false
      UseStandardizedQueries = true
      SubtypeField = None }
