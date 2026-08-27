module interraster

open Esri.ArcGISRuntime
open Esri.ArcGISRuntime.ArcGISServices
open Esri.ArcGISRuntime.Geometry
open Esri.ArcGISRuntime.Mapping
open Esri.ArcGISRuntime.Portal
open System
open System.Collections.Generic

type Feature_Dataset =
    { source: Uri
      service_info: ArcGISMapServiceInfo
      image_format: MapServiceImageFormat
      sublayers: Arc_Gis_Map_Image_Sublayer array
      refresh_interval: TimeSpan
      is_time_filtering_enabled: bool
      supports_time_filtering: bool
      tables: ServiceFeatureTable array
      brightness: float
      contrast: float
      gamma: float
      load_status: LoadStatus
      max_scale: float
      min_scale: float
      spatial_reference: SpatialReference
      opacity: float
      id: string
      full_extent: Envelope
      can_change_visibility: bool
      is_visible: bool
      is_identify_enabled: bool
      name: string
      show_in_legend: bool
      sublayer_contents: ILayerContent array }
