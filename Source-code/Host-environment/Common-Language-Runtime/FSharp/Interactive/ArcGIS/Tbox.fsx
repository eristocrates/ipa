#r "nuget: Esri.ArcGISRuntime, 300.0.0"
open System

type Arc_Gis_Map_Image_Layer =
    { full_time_extent: Esri.ArcGISRuntime.TimeExtent
      time_interval: Esri.ArcGISRuntime.TimeValue
      time_offset: Esri.ArcGISRuntime.TimeValue
      spatial_reference: Esri.ArcGISRuntime.Geometry.SpatialReference
      full_extent: Esri.ArcGISRuntime.Geometry.Envelope }
