namespace http.purl.oclc.org.NET.ssnx.cf.cf_feature.hash

open DoxAletheia

module cff =
    let _namespace_name = "http://purl.oclc.org/NET/ssnx/cf/cf-feature#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Humidity"></see>
    /// </summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Layer"></see>
    /// </summary>
    let Layer = _prefix "Layer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#LayerMedium"></see>
    /// </summary>
    let LayerMedium = _prefix "LayerMedium"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Medium"></see>
    /// </summary>
    let Medium = _prefix "Medium"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Precipitation"></see>
    /// </summary>
    let Precipitation = _prefix "Precipitation"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Surface"></see>
    /// </summary>
    let Surface = _prefix "Surface"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceLayer"></see>
    /// </summary>
    let SurfaceLayer = _prefix "SurfaceLayer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMedium"></see>
    /// </summary>
    let SurfaceMedium = _prefix "SurfaceMedium"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMediumMedium"></see>
    /// </summary>
    let SurfaceMediumMedium = _prefix "SurfaceMediumMedium"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceSurface"></see>
    /// </summary>
    let SurfaceSurface = _prefix "SurfaceSurface"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Wind"></see>
    /// </summary>
    let Wind = _prefix "Wind"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#air"></see>
    /// </summary>
    let air = _prefix "air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere"></see>
    /// </summary>
    let atmosphere = _prefix "atmosphere"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_air"></see>
    /// </summary>
    let atmosphere_air = _prefix "atmosphere_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_boundary_layer"></see>
    /// </summary>
    let atmosphere_boundary_layer = _prefix "atmosphere_boundary_layer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_layer"></see>
    /// </summary>
    let atmosphere_layer = _prefix "atmosphere_layer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#base_of_ocean_mixed_layer"></see>
    /// </summary>
    let base_of_ocean_mixed_layer = _prefix "base_of_ocean_mixed_layer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#canopy"></see>
    /// </summary>
    let canopy = _prefix "canopy"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#canopy_and_surface"></see>
    /// </summary>
    let canopy_and_surface = _prefix "canopy_and_surface"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_base"></see>
    /// </summary>
    let cloud_base = _prefix "cloud_base"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_base_air"></see>
    /// </summary>
    let cloud_base_air = _prefix "cloud_base_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_top"></see>
    /// </summary>
    let cloud_top = _prefix "cloud_top"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_top_air"></see>
    /// </summary>
    let cloud_top_air = _prefix "cloud_top_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_base"></see>
    /// </summary>
    let convective_cloud_base = _prefix "convective_cloud_base"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_base_air"></see>
    /// </summary>
    let convective_cloud_base_air = _prefix "convective_cloud_base_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_top"></see>
    /// </summary>
    let convective_cloud_top = _prefix "convective_cloud_top"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_top_air"></see>
    /// </summary>
    let convective_cloud_top_air = _prefix "convective_cloud_top_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#dynamic_tropopause"></see>
    /// </summary>
    let dynamic_tropopause = _prefix "dynamic_tropopause"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#floating_ice"></see>
    /// </summary>
    let floating_ice = _prefix "floating_ice"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#freezing_level"></see>
    /// </summary>
    let freezing_level = _prefix "freezing_level"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#freezing_level_air"></see>
    /// </summary>
    let freezing_level_air = _prefix "freezing_level_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#geoid_reference_ellipsoid"></see>
    /// </summary>
    let geoid_reference_ellipsoid = _prefix "geoid_reference_ellipsoid"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground"></see>
    /// </summary>
    let ground = _prefix "ground"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground_level_snow"></see>
    /// </summary>
    let ground_level_snow = _prefix "ground_level_snow"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground_level_soil"></see>
    /// </summary>
    let ground_level_soil = _prefix "ground_level_soil"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#humidity"></see>
    /// </summary>
    let humidity = _prefix "humidity"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#land"></see>
    /// </summary>
    let land_ = _prefix "land"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#land_ice"></see>
    /// </summary>
    let land_ice = _prefix "land_ice"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#litter"></see>
    /// </summary>
    let litter = _prefix "litter"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#middle_atmosphere"></see>
    /// </summary>
    let middle_atmosphere = _prefix "middle_atmosphere"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean"></see>
    /// </summary>
    let ocean = _prefix "ocean"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean_layer"></see>
    /// </summary>
    let ocean_layer = _prefix "ocean_layer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean_mixed_layer"></see>
    /// </summary>
    let ocean_mixed_layer = _prefix "ocean_mixed_layer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#rainfall"></see>
    /// </summary>
    let rainfall = _prefix "rainfall"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#reference_ellipsoid"></see>
    /// </summary>
    let reference_ellipsoid = _prefix "reference_ellipsoid"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea"></see>
    /// </summary>
    let sea = _prefix "sea"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor"></see>
    /// </summary>
    let sea_floor = _prefix "sea_floor"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_geoid"></see>
    /// </summary>
    let sea_floor_geoid = _prefix "sea_floor_geoid"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_sea_level"></see>
    /// </summary>
    let sea_floor_sea_level = _prefix "sea_floor_sea_level"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_sea_surface"></see>
    /// </summary>
    let sea_floor_sea_surface = _prefix "sea_floor_sea_surface"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice"></see>
    /// </summary>
    let sea_ice = _prefix "sea_ice"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice_and_sea_water"></see>
    /// </summary>
    let sea_ice_and_sea_water = _prefix "sea_ice_and_sea_water"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice_base"></see>
    /// </summary>
    let sea_ice_base = _prefix "sea_ice_base"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_level_air"></see>
    /// </summary>
    let sea_level_air = _prefix "sea_level_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface"></see>
    /// </summary>
    let sea_surface = _prefix "sea_surface"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_geoid"></see>
    /// </summary>
    let sea_surface_geoid = _prefix "sea_surface_geoid"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_reference_ellipsoid"></see>
    /// </summary>
    let sea_surface_reference_ellipsoid = _prefix "sea_surface_reference_ellipsoid"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_sea_level"></see>
    /// </summary>
    let sea_surface_sea_level = _prefix "sea_surface_sea_level"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surfaceocean"></see>
    /// </summary>
    let sea_surfaceocean = _prefix "sea_surfaceocean"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_water"></see>
    /// </summary>
    let sea_water = _prefix "sea_water"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#snowfall"></see>
    /// </summary>
    let snowfall = _prefix "snowfall"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil"></see>
    /// </summary>
    let soil = _prefix "soil"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_layer"></see>
    /// </summary>
    let soil_layer = _prefix "soil_layer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_moisture"></see>
    /// </summary>
    let soil_moisture = _prefix "soil_moisture"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_pores"></see>
    /// </summary>
    let soil_pores = _prefix "soil_pores"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#subsurface"></see>
    /// </summary>
    let subsurface = _prefix "subsurface"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface"></see>
    /// </summary>
    let surface = _prefix "surface"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_air"></see>
    /// </summary>
    let surface_air = _prefix "surface_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_air_sea_water"></see>
    /// </summary>
    let surface_air_sea_water = _prefix "surface_air_sea_water"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_sea_water"></see>
    /// </summary>
    let surface_sea_water = _prefix "surface_sea_water"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_snow"></see>
    /// </summary>
    let surface_snow = _prefix "surface_snow"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_snow_and_ice"></see>
    /// </summary>
    let surface_snow_and_ice = _prefix "surface_snow_and_ice"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#toa"></see>
    /// </summary>
    let toa = _prefix "toa"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_atmosphere_boundary_layer"></see>
    /// </summary>
    let top_of_atmosphere_boundary_layer = _prefix "top_of_atmosphere_boundary_layer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_atmosphere_model"></see>
    /// </summary>
    let top_of_atmosphere_model = _prefix "top_of_atmosphere_model"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_dry_convection"></see>
    /// </summary>
    let top_of_dry_convection = _prefix "top_of_dry_convection"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#tropopause"></see>
    /// </summary>
    let tropopause = _prefix "tropopause"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#tropopause_air"></see>
    /// </summary>
    let tropopause_air = _prefix "tropopause_air"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#troposphere"></see>
    /// </summary>
    let troposphere = _prefix "troposphere"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#vegetation"></see>
    /// </summary>
    let vegetation = _prefix "vegetation"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#water"></see>
    /// </summary>
    let water = _prefix "water"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#wind"></see>
    /// </summary>
    let wind = _prefix "wind"
