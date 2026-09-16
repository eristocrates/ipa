#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cff =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ssnx/cf/cf-feature#" "cff"

    /// <summary>
    ///   <para>rdfs:label : Humidity^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Humidity">cff:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>rdfs:label : Layer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Layer">cff:Layer</a>
    /// </summary>
    let Layer = _prefixId.prefix "Layer"
    /// <summary>
    ///   <para>rdfs:label : Layer Medium^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#LayerMedium">cff:LayerMedium</a>
    /// </summary>
    let LayerMedium = _prefixId.prefix "LayerMedium"
    /// <summary>
    ///   <para>rdfs:label : Medium^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Medium">cff:Medium</a>
    /// </summary>
    let Medium = _prefixId.prefix "Medium"
    /// <summary>
    ///   <para>rdfs:label : Precipitation^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Precipitation">cff:Precipitation</a>
    /// </summary>
    let Precipitation = _prefixId.prefix "Precipitation"
    /// <summary>
    ///   <para>rdfs:label : Surface^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Surface">cff:Surface</a>
    /// </summary>
    let Surface = _prefixId.prefix "Surface"
    /// <summary>
    ///   <para>rdfs:label : Surface Layer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceLayer">cff:SurfaceLayer</a>
    /// </summary>
    let SurfaceLayer = _prefixId.prefix "SurfaceLayer"
    /// <summary>
    ///   <para>rdfs:label : Surface Medium^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMedium">cff:SurfaceMedium</a>
    /// </summary>
    let SurfaceMedium = _prefixId.prefix "SurfaceMedium"
    /// <summary>
    ///   <para>rdfs:label : Surface Medium Medium^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMediumMedium">cff:SurfaceMediumMedium</a>
    /// </summary>
    let SurfaceMediumMedium = _prefixId.prefix "SurfaceMediumMedium"
    /// <summary>
    ///   <para>rdfs:label : Surface Surface^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceSurface">cff:SurfaceSurface</a>
    /// </summary>
    let SurfaceSurface = _prefixId.prefix "SurfaceSurface"
    /// <summary>
    ///   <para>rdfs:label : Wind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Wind">cff:Wind</a>
    /// </summary>
    let Wind = _prefixId.prefix "Wind"
    let air = _prefixId.prefix "air"
    let atmosphere = _prefixId.prefix "atmosphere"
    let atmosphere_air = _prefixId.prefix "atmosphere_air"
    let atmosphere_boundary_layer = _prefixId.prefix "atmosphere_boundary_layer"
    let atmosphere_layer = _prefixId.prefix "atmosphere_layer"
    let base_of_ocean_mixed_layer = _prefixId.prefix "base_of_ocean_mixed_layer"
    let canopy = _prefixId.prefix "canopy"
    let canopy_and_surface = _prefixId.prefix "canopy_and_surface"
    let cloud_base = _prefixId.prefix "cloud_base"
    let cloud_base_air = _prefixId.prefix "cloud_base_air"
    let cloud_top = _prefixId.prefix "cloud_top"
    let cloud_top_air = _prefixId.prefix "cloud_top_air"
    let convective_cloud_base = _prefixId.prefix "convective_cloud_base"
    let convective_cloud_base_air = _prefixId.prefix "convective_cloud_base_air"
    let convective_cloud_top = _prefixId.prefix "convective_cloud_top"
    let convective_cloud_top_air = _prefixId.prefix "convective_cloud_top_air"
    let dynamic_tropopause = _prefixId.prefix "dynamic_tropopause"
    let floating_ice = _prefixId.prefix "floating_ice"
    let freezing_level = _prefixId.prefix "freezing_level"
    let freezing_level_air = _prefixId.prefix "freezing_level_air"
    let geoid_reference_ellipsoid = _prefixId.prefix "geoid_reference_ellipsoid"
    let ground = _prefixId.prefix "ground"
    let ground_level_snow = _prefixId.prefix "ground_level_snow"
    let ground_level_soil = _prefixId.prefix "ground_level_soil"
    let humidity = _prefixId.prefix "humidity"
    let land_ = _prefixId.prefix "land"
    let land_ice = _prefixId.prefix "land_ice"
    let litter = _prefixId.prefix "litter"
    let middle_atmosphere = _prefixId.prefix "middle_atmosphere"
    let ocean = _prefixId.prefix "ocean"
    let ocean_layer = _prefixId.prefix "ocean_layer"
    let ocean_mixed_layer = _prefixId.prefix "ocean_mixed_layer"
    let rainfall = _prefixId.prefix "rainfall"
    let reference_ellipsoid = _prefixId.prefix "reference_ellipsoid"
    let sea = _prefixId.prefix "sea"
    let sea_floor = _prefixId.prefix "sea_floor"
    let sea_floor_geoid = _prefixId.prefix "sea_floor_geoid"
    let sea_floor_sea_level = _prefixId.prefix "sea_floor_sea_level"
    let sea_floor_sea_surface = _prefixId.prefix "sea_floor_sea_surface"
    let sea_ice = _prefixId.prefix "sea_ice"
    let sea_ice_and_sea_water = _prefixId.prefix "sea_ice_and_sea_water"
    let sea_ice_base = _prefixId.prefix "sea_ice_base"
    let sea_level_air = _prefixId.prefix "sea_level_air"
    let sea_surface = _prefixId.prefix "sea_surface"
    let sea_surface_geoid = _prefixId.prefix "sea_surface_geoid"

    let sea_surface_reference_ellipsoid = _prefixId.prefix "sea_surface_reference_ellipsoid"

    let sea_surface_sea_level = _prefixId.prefix "sea_surface_sea_level"
    let sea_surfaceocean = _prefixId.prefix "sea_surfaceocean"
    let sea_water = _prefixId.prefix "sea_water"
    let snowfall = _prefixId.prefix "snowfall"
    let soil = _prefixId.prefix "soil"
    let soil_layer = _prefixId.prefix "soil_layer"
    let soil_moisture = _prefixId.prefix "soil_moisture"
    let soil_pores = _prefixId.prefix "soil_pores"
    let subsurface = _prefixId.prefix "subsurface"
    let surface = _prefixId.prefix "surface"
    let surface_air = _prefixId.prefix "surface_air"
    let surface_air_sea_water = _prefixId.prefix "surface_air_sea_water"
    let surface_sea_water = _prefixId.prefix "surface_sea_water"
    let surface_snow = _prefixId.prefix "surface_snow"
    let surface_snow_and_ice = _prefixId.prefix "surface_snow_and_ice"
    let toa = _prefixId.prefix "toa"

    let top_of_atmosphere_boundary_layer = _prefixId.prefix "top_of_atmosphere_boundary_layer"

    let top_of_atmosphere_model = _prefixId.prefix "top_of_atmosphere_model"
    let top_of_dry_convection = _prefixId.prefix "top_of_dry_convection"
    let tropopause = _prefixId.prefix "tropopause"
    let tropopause_air = _prefixId.prefix "tropopause_air"
    let troposphere = _prefixId.prefix "troposphere"
    let vegetation = _prefixId.prefix "vegetation"
    let water = _prefixId.prefix "water"
    let wind = _prefixId.prefix "wind"
