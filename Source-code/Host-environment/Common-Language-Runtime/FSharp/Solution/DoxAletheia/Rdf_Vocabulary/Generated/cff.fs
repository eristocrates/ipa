namespace http.purl.oclc.org.NET.ssnx.cf.cf_feature.hash

open DoxAletheia.Rdf_Vocabulary

module cff =
    let _namespace_name = "http://purl.oclc.org/NET/ssnx/cf/cf-feature#"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Humidity"></see>
    /// </summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Layer"></see>
    /// </summary>
    let Layer = Namespaced_IRI.parse _namespace_name "Layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#LayerMedium"></see>
    /// </summary>
    let LayerMedium =
        Namespaced_IRI.parse _namespace_name "LayerMedium" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Medium"></see>
    /// </summary>
    let Medium = Namespaced_IRI.parse _namespace_name "Medium" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Precipitation"></see>
    /// </summary>
    let Precipitation =
        Namespaced_IRI.parse _namespace_name "Precipitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Surface"></see>
    /// </summary>
    let Surface = Namespaced_IRI.parse _namespace_name "Surface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceLayer"></see>
    /// </summary>
    let SurfaceLayer =
        Namespaced_IRI.parse _namespace_name "SurfaceLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMedium"></see>
    /// </summary>
    let SurfaceMedium =
        Namespaced_IRI.parse _namespace_name "SurfaceMedium" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMediumMedium"></see>
    /// </summary>
    let SurfaceMediumMedium =
        Namespaced_IRI.parse _namespace_name "SurfaceMediumMedium" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceSurface"></see>
    /// </summary>
    let SurfaceSurface =
        Namespaced_IRI.parse _namespace_name "SurfaceSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Wind"></see>
    /// </summary>
    let Wind = Namespaced_IRI.parse _namespace_name "Wind" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#air"></see>
    /// </summary>
    let air = Namespaced_IRI.parse _namespace_name "air" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere"></see>
    /// </summary>
    let atmosphere = Namespaced_IRI.parse _namespace_name "atmosphere" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_air"></see>
    /// </summary>
    let atmosphere_air =
        Namespaced_IRI.parse _namespace_name "atmosphere_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_boundary_layer"></see>
    /// </summary>
    let atmosphere_boundary_layer =
        Namespaced_IRI.parse _namespace_name "atmosphere_boundary_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_layer"></see>
    /// </summary>
    let atmosphere_layer =
        Namespaced_IRI.parse _namespace_name "atmosphere_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#base_of_ocean_mixed_layer"></see>
    /// </summary>
    let base_of_ocean_mixed_layer =
        Namespaced_IRI.parse _namespace_name "base_of_ocean_mixed_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#canopy"></see>
    /// </summary>
    let canopy = Namespaced_IRI.parse _namespace_name "canopy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#canopy_and_surface"></see>
    /// </summary>
    let canopy_and_surface =
        Namespaced_IRI.parse _namespace_name "canopy_and_surface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_base"></see>
    /// </summary>
    let cloud_base = Namespaced_IRI.parse _namespace_name "cloud_base" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_base_air"></see>
    /// </summary>
    let cloud_base_air =
        Namespaced_IRI.parse _namespace_name "cloud_base_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_top"></see>
    /// </summary>
    let cloud_top = Namespaced_IRI.parse _namespace_name "cloud_top" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_top_air"></see>
    /// </summary>
    let cloud_top_air =
        Namespaced_IRI.parse _namespace_name "cloud_top_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_base"></see>
    /// </summary>
    let convective_cloud_base =
        Namespaced_IRI.parse _namespace_name "convective_cloud_base" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_base_air"></see>
    /// </summary>
    let convective_cloud_base_air =
        Namespaced_IRI.parse _namespace_name "convective_cloud_base_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_top"></see>
    /// </summary>
    let convective_cloud_top =
        Namespaced_IRI.parse _namespace_name "convective_cloud_top" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_top_air"></see>
    /// </summary>
    let convective_cloud_top_air =
        Namespaced_IRI.parse _namespace_name "convective_cloud_top_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#dynamic_tropopause"></see>
    /// </summary>
    let dynamic_tropopause =
        Namespaced_IRI.parse _namespace_name "dynamic_tropopause" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#floating_ice"></see>
    /// </summary>
    let floating_ice =
        Namespaced_IRI.parse _namespace_name "floating_ice" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#freezing_level"></see>
    /// </summary>
    let freezing_level =
        Namespaced_IRI.parse _namespace_name "freezing_level" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#freezing_level_air"></see>
    /// </summary>
    let freezing_level_air =
        Namespaced_IRI.parse _namespace_name "freezing_level_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#geoid_reference_ellipsoid"></see>
    /// </summary>
    let geoid_reference_ellipsoid =
        Namespaced_IRI.parse _namespace_name "geoid_reference_ellipsoid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground"></see>
    /// </summary>
    let ground = Namespaced_IRI.parse _namespace_name "ground" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground_level_snow"></see>
    /// </summary>
    let ground_level_snow =
        Namespaced_IRI.parse _namespace_name "ground_level_snow" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground_level_soil"></see>
    /// </summary>
    let ground_level_soil =
        Namespaced_IRI.parse _namespace_name "ground_level_soil" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#humidity"></see>
    /// </summary>
    let humidity = Namespaced_IRI.parse _namespace_name "humidity" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#land"></see>
    /// </summary>
    let land_ = Namespaced_IRI.parse _namespace_name "land" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#land_ice"></see>
    /// </summary>
    let land_ice = Namespaced_IRI.parse _namespace_name "land_ice" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#litter"></see>
    /// </summary>
    let litter = Namespaced_IRI.parse _namespace_name "litter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#middle_atmosphere"></see>
    /// </summary>
    let middle_atmosphere =
        Namespaced_IRI.parse _namespace_name "middle_atmosphere" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean"></see>
    /// </summary>
    let ocean = Namespaced_IRI.parse _namespace_name "ocean" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean_layer"></see>
    /// </summary>
    let ocean_layer =
        Namespaced_IRI.parse _namespace_name "ocean_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean_mixed_layer"></see>
    /// </summary>
    let ocean_mixed_layer =
        Namespaced_IRI.parse _namespace_name "ocean_mixed_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#rainfall"></see>
    /// </summary>
    let rainfall = Namespaced_IRI.parse _namespace_name "rainfall" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#reference_ellipsoid"></see>
    /// </summary>
    let reference_ellipsoid =
        Namespaced_IRI.parse _namespace_name "reference_ellipsoid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea"></see>
    /// </summary>
    let sea = Namespaced_IRI.parse _namespace_name "sea" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor"></see>
    /// </summary>
    let sea_floor = Namespaced_IRI.parse _namespace_name "sea_floor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_geoid"></see>
    /// </summary>
    let sea_floor_geoid =
        Namespaced_IRI.parse _namespace_name "sea_floor_geoid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_sea_level"></see>
    /// </summary>
    let sea_floor_sea_level =
        Namespaced_IRI.parse _namespace_name "sea_floor_sea_level" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_sea_surface"></see>
    /// </summary>
    let sea_floor_sea_surface =
        Namespaced_IRI.parse _namespace_name "sea_floor_sea_surface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice"></see>
    /// </summary>
    let sea_ice = Namespaced_IRI.parse _namespace_name "sea_ice" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice_and_sea_water"></see>
    /// </summary>
    let sea_ice_and_sea_water =
        Namespaced_IRI.parse _namespace_name "sea_ice_and_sea_water" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice_base"></see>
    /// </summary>
    let sea_ice_base =
        Namespaced_IRI.parse _namespace_name "sea_ice_base" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_level_air"></see>
    /// </summary>
    let sea_level_air =
        Namespaced_IRI.parse _namespace_name "sea_level_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface"></see>
    /// </summary>
    let sea_surface =
        Namespaced_IRI.parse _namespace_name "sea_surface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_geoid"></see>
    /// </summary>
    let sea_surface_geoid =
        Namespaced_IRI.parse _namespace_name "sea_surface_geoid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_reference_ellipsoid"></see>
    /// </summary>
    let sea_surface_reference_ellipsoid =
        Namespaced_IRI.parse _namespace_name "sea_surface_reference_ellipsoid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_sea_level"></see>
    /// </summary>
    let sea_surface_sea_level =
        Namespaced_IRI.parse _namespace_name "sea_surface_sea_level" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surfaceocean"></see>
    /// </summary>
    let sea_surfaceocean =
        Namespaced_IRI.parse _namespace_name "sea_surfaceocean" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_water"></see>
    /// </summary>
    let sea_water = Namespaced_IRI.parse _namespace_name "sea_water" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#snowfall"></see>
    /// </summary>
    let snowfall = Namespaced_IRI.parse _namespace_name "snowfall" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil"></see>
    /// </summary>
    let soil = Namespaced_IRI.parse _namespace_name "soil" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_layer"></see>
    /// </summary>
    let soil_layer = Namespaced_IRI.parse _namespace_name "soil_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_moisture"></see>
    /// </summary>
    let soil_moisture =
        Namespaced_IRI.parse _namespace_name "soil_moisture" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_pores"></see>
    /// </summary>
    let soil_pores = Namespaced_IRI.parse _namespace_name "soil_pores" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#subsurface"></see>
    /// </summary>
    let subsurface = Namespaced_IRI.parse _namespace_name "subsurface" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface"></see>
    /// </summary>
    let surface = Namespaced_IRI.parse _namespace_name "surface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_air"></see>
    /// </summary>
    let surface_air =
        Namespaced_IRI.parse _namespace_name "surface_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_air_sea_water"></see>
    /// </summary>
    let surface_air_sea_water =
        Namespaced_IRI.parse _namespace_name "surface_air_sea_water" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_sea_water"></see>
    /// </summary>
    let surface_sea_water =
        Namespaced_IRI.parse _namespace_name "surface_sea_water" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_snow"></see>
    /// </summary>
    let surface_snow =
        Namespaced_IRI.parse _namespace_name "surface_snow" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_snow_and_ice"></see>
    /// </summary>
    let surface_snow_and_ice =
        Namespaced_IRI.parse _namespace_name "surface_snow_and_ice" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#toa"></see>
    /// </summary>
    let toa = Namespaced_IRI.parse _namespace_name "toa" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_atmosphere_boundary_layer"></see>
    /// </summary>
    let top_of_atmosphere_boundary_layer =
        Namespaced_IRI.parse _namespace_name "top_of_atmosphere_boundary_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_atmosphere_model"></see>
    /// </summary>
    let top_of_atmosphere_model =
        Namespaced_IRI.parse _namespace_name "top_of_atmosphere_model" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_dry_convection"></see>
    /// </summary>
    let top_of_dry_convection =
        Namespaced_IRI.parse _namespace_name "top_of_dry_convection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#tropopause"></see>
    /// </summary>
    let tropopause = Namespaced_IRI.parse _namespace_name "tropopause" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#tropopause_air"></see>
    /// </summary>
    let tropopause_air =
        Namespaced_IRI.parse _namespace_name "tropopause_air" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#troposphere"></see>
    /// </summary>
    let troposphere =
        Namespaced_IRI.parse _namespace_name "troposphere" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#vegetation"></see>
    /// </summary>
    let vegetation = Namespaced_IRI.parse _namespace_name "vegetation" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#water"></see>
    /// </summary>
    let water = Namespaced_IRI.parse _namespace_name "water" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#wind"></see>
    /// </summary>
    let wind = Namespaced_IRI.parse _namespace_name "wind" |> NamespacedName
