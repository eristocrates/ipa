namespace http.purl.oclc.org.NET.ssnx.cf.cf_feature.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cff =
    let _namespace_iri = Namespace_Iri cff |> NamespaceIRI
    /// <summary>
    ///   <para>cff:SurfaceMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Surface Medium</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMedium">http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMedium</seealso>
    let SurfaceMedium = Prefixed_Name(cff, "SurfaceMedium") |> PrefixedName
    /// <summary>
    ///   <para>cff:Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Layer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#Layer</seealso>
    let Layer = Prefixed_Name(cff, "Layer") |> PrefixedName
    /// <summary>
    ///   <para>cff:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Medium</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Medium">http://purl.oclc.org/NET/ssnx/cf/cf-feature#Medium</seealso>
    let Medium = Prefixed_Name(cff, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>cff:SurfaceLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Surface Layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceLayer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceLayer</seealso>
    let SurfaceLayer = Prefixed_Name(cff, "SurfaceLayer") |> PrefixedName
    /// <summary>
    ///   <para>cff:litter</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>litter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#litter">http://purl.oclc.org/NET/ssnx/cf/cf-feature#litter</seealso>
    let litter = Prefixed_Name(cff, "litter") |> PrefixedName
    /// <summary>
    ///   <para>cff:LayerMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Layer Medium</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#LayerMedium">http://purl.oclc.org/NET/ssnx/cf/cf-feature#LayerMedium</seealso>
    let LayerMedium = Prefixed_Name(cff, "LayerMedium") |> PrefixedName
    /// <summary>
    ///   <para>cff:Surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Surface</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Surface">http://purl.oclc.org/NET/ssnx/cf/cf-feature#Surface</seealso>
    let Surface = Prefixed_Name(cff, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>cff:Wind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Wind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Wind">http://purl.oclc.org/NET/ssnx/cf/cf-feature#Wind</seealso>
    let Wind = Prefixed_Name(cff, "Wind") |> PrefixedName
    /// <summary>
    ///   <para>cff:SurfaceSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Surface Surface</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceSurface">http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceSurface</seealso>
    let SurfaceSurface = Prefixed_Name(cff, "SurfaceSurface") |> PrefixedName
    /// <summary>
    ///   <para>cff:air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#air</seealso>
    let air = Prefixed_Name(cff, "air") |> PrefixedName
    /// <summary>
    ///   <para>cff:sea_surface_geoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceSurface</para>
    ///
    /// labels<para>sea surface geoid</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_geoid">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_geoid</seealso>
    let sea_surface_geoid = Prefixed_Name(cff, "sea_surface_geoid") |> PrefixedName
    /// <summary>
    ///   <para>cff:atmosphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>atmosphere</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere">http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere</seealso>
    let atmosphere = Prefixed_Name(cff, "atmosphere") |> PrefixedName
    /// <summary>
    ///   <para>cff:surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>surface</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface">http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface</seealso>
    let surface = Prefixed_Name(cff, "surface") |> PrefixedName
    /// <summary>
    ///   <para>cff:tropopause_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>tropopause air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#tropopause_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#tropopause_air</seealso>
    let tropopause_air = Prefixed_Name(cff, "tropopause_air") |> PrefixedName
    /// <summary>
    ///   <para>cff:troposphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>troposphere</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#troposphere">http://purl.oclc.org/NET/ssnx/cf/cf-feature#troposphere</seealso>
    let troposphere = Prefixed_Name(cff, "troposphere") |> PrefixedName

    /// <summary>
    ///   <para>cff:base_of_ocean_mixed_layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>base of ocean mixed layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#base_of_ocean_mixed_layer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#base_of_ocean_mixed_layer</seealso>
    let base_of_ocean_mixed_layer =
        Prefixed_Name(cff, "base_of_ocean_mixed_layer") |> PrefixedName

    /// <summary>
    ///   <para>cff:canopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>canopy</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#canopy">http://purl.oclc.org/NET/ssnx/cf/cf-feature#canopy</seealso>
    let canopy = Prefixed_Name(cff, "canopy") |> PrefixedName
    /// <summary>
    ///   <para>cff:humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Humidity</para>
    ///
    /// labels<para>humidity</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#humidity">http://purl.oclc.org/NET/ssnx/cf/cf-feature#humidity</seealso>
    let humidity = Prefixed_Name(cff, "humidity") |> PrefixedName
    /// <summary>
    ///   <para>cff:land</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>land</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#land">http://purl.oclc.org/NET/ssnx/cf/cf-feature#land</seealso>
    let land_ = Prefixed_Name(cff, "land") |> PrefixedName
    /// <summary>
    ///   <para>cff:land_ice</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>land ice</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#land_ice">http://purl.oclc.org/NET/ssnx/cf/cf-feature#land_ice</seealso>
    let land_ice = Prefixed_Name(cff, "land_ice") |> PrefixedName
    /// <summary>
    ///   <para>cff:ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>ocean</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean">http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean</seealso>
    let ocean = Prefixed_Name(cff, "ocean") |> PrefixedName
    /// <summary>
    ///   <para>cff:middle_atmosphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>middle atmosphere</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#middle_atmosphere">http://purl.oclc.org/NET/ssnx/cf/cf-feature#middle_atmosphere</seealso>
    let middle_atmosphere = Prefixed_Name(cff, "middle_atmosphere") |> PrefixedName

    /// <summary>
    ///   <para>cff:sea_ice_and_sea_water</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>sea ice and sea water</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice_and_sea_water">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice_and_sea_water</seealso>
    let sea_ice_and_sea_water =
        Prefixed_Name(cff, "sea_ice_and_sea_water") |> PrefixedName

    /// <summary>
    ///   <para>cff:sea_ice_base</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>sea ice base</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice_base">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice_base</seealso>
    let sea_ice_base = Prefixed_Name(cff, "sea_ice_base") |> PrefixedName
    /// <summary>
    ///   <para>cff:sea_level_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>sea level air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_level_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_level_air</seealso>
    let sea_level_air = Prefixed_Name(cff, "sea_level_air") |> PrefixedName
    /// <summary>
    ///   <para>cff:sea_surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>sea surface</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface</seealso>
    let sea_surface = Prefixed_Name(cff, "sea_surface") |> PrefixedName

    /// <summary>
    ///   <para>cff:sea_surface_reference_ellipsoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceSurface</para>
    ///
    /// labels<para>sea surface reference ellipsoid</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_reference_ellipsoid">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_reference_ellipsoid</seealso>
    let sea_surface_reference_ellipsoid =
        Prefixed_Name(cff, "sea_surface_reference_ellipsoid") |> PrefixedName

    /// <summary>
    ///   <para>cff:sea_surface_sea_level</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceSurface</para>
    ///
    /// labels<para>sea surface sea level</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_sea_level">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surface_sea_level</seealso>
    let sea_surface_sea_level =
        Prefixed_Name(cff, "sea_surface_sea_level") |> PrefixedName

    /// <summary>
    ///   <para>cff:sea_surfaceocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceLayer</para>
    ///
    /// labels<para>sea surfaceocean</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surfaceocean">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_surfaceocean</seealso>
    let sea_surfaceocean = Prefixed_Name(cff, "sea_surfaceocean") |> PrefixedName
    /// <summary>
    ///   <para>cff:sea_water</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>sea water</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_water">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_water</seealso>
    let sea_water = Prefixed_Name(cff, "sea_water") |> PrefixedName
    /// <summary>
    ///   <para>cff:snowfall</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Precipitation</para>
    ///
    /// labels<para>snowfall</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#snowfall">http://purl.oclc.org/NET/ssnx/cf/cf-feature#snowfall</seealso>
    let snowfall = Prefixed_Name(cff, "snowfall") |> PrefixedName
    /// <summary>
    ///   <para>cff:soil</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>soil</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil">http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil</seealso>
    let soil = Prefixed_Name(cff, "soil") |> PrefixedName
    /// <summary>
    ///   <para>cff:soil_layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>soil layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_layer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_layer</seealso>
    let soil_layer = Prefixed_Name(cff, "soil_layer") |> PrefixedName
    /// <summary>
    ///   <para>cff:soil_moisture</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>soil moisture</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_moisture">http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_moisture</seealso>
    let soil_moisture = Prefixed_Name(cff, "soil_moisture") |> PrefixedName
    /// <summary>
    ///   <para>cff:soil_pores</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>soil pores</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_pores">http://purl.oclc.org/NET/ssnx/cf/cf-feature#soil_pores</seealso>
    let soil_pores = Prefixed_Name(cff, "soil_pores") |> PrefixedName
    /// <summary>
    ///   <para>cff:subsurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>subsurface</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#subsurface">http://purl.oclc.org/NET/ssnx/cf/cf-feature#subsurface</seealso>
    let subsurface = Prefixed_Name(cff, "subsurface") |> PrefixedName
    /// <summary>
    ///   <para>cff:surface_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>surface air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_air</seealso>
    let surface_air = Prefixed_Name(cff, "surface_air") |> PrefixedName

    /// <summary>
    ///   <para>cff:surface_air_sea_water</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMediumMedium</para>
    ///
    /// labels<para>surface air sea water</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_air_sea_water">http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_air_sea_water</seealso>
    let surface_air_sea_water =
        Prefixed_Name(cff, "surface_air_sea_water") |> PrefixedName

    /// <summary>
    ///   <para>cff:surface_sea_water</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>surface sea water</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_sea_water">http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_sea_water</seealso>
    let surface_sea_water = Prefixed_Name(cff, "surface_sea_water") |> PrefixedName
    /// <summary>
    ///   <para>cff:surface_snow</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>surface snow</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_snow">http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_snow</seealso>
    let surface_snow = Prefixed_Name(cff, "surface_snow") |> PrefixedName

    /// <summary>
    ///   <para>cff:surface_snow_and_ice</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>surface snow and ice</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_snow_and_ice">http://purl.oclc.org/NET/ssnx/cf/cf-feature#surface_snow_and_ice</seealso>
    let surface_snow_and_ice =
        Prefixed_Name(cff, "surface_snow_and_ice") |> PrefixedName

    /// <summary>
    ///   <para>cff:toa</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>toa</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#toa">http://purl.oclc.org/NET/ssnx/cf/cf-feature#toa</seealso>
    let toa = Prefixed_Name(cff, "toa") |> PrefixedName

    /// <summary>
    ///   <para>cff:top_of_atmosphere_boundary_layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>top of atmosphere boundary layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_atmosphere_boundary_layer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_atmosphere_boundary_layer</seealso>
    let top_of_atmosphere_boundary_layer =
        Prefixed_Name(cff, "top_of_atmosphere_boundary_layer") |> PrefixedName

    /// <summary>
    ///   <para>cff:top_of_atmosphere_model</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>top of atmosphere model</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_atmosphere_model">http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_atmosphere_model</seealso>
    let top_of_atmosphere_model =
        Prefixed_Name(cff, "top_of_atmosphere_model") |> PrefixedName

    /// <summary>
    ///   <para>cff:top_of_dry_convection</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>top of dry convection</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_dry_convection">http://purl.oclc.org/NET/ssnx/cf/cf-feature#top_of_dry_convection</seealso>
    let top_of_dry_convection =
        Prefixed_Name(cff, "top_of_dry_convection") |> PrefixedName

    /// <summary>
    ///   <para>cff:tropopause</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>tropopause</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#tropopause">http://purl.oclc.org/NET/ssnx/cf/cf-feature#tropopause</seealso>
    let tropopause = Prefixed_Name(cff, "tropopause") |> PrefixedName
    /// <summary>
    ///   <para>cff:vegetation</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>vegetation</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#vegetation">http://purl.oclc.org/NET/ssnx/cf/cf-feature#vegetation</seealso>
    let vegetation = Prefixed_Name(cff, "vegetation") |> PrefixedName
    /// <summary>
    ///   <para>cff:water</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>water</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#water">http://purl.oclc.org/NET/ssnx/cf/cf-feature#water</seealso>
    let water = Prefixed_Name(cff, "water") |> PrefixedName
    /// <summary>
    ///   <para>cff:wind</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Wind</para>
    ///
    /// labels<para>wind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#wind">http://purl.oclc.org/NET/ssnx/cf/cf-feature#wind</seealso>
    let wind = Prefixed_Name(cff, "wind") |> PrefixedName
    /// <summary>
    ///   <para>cff:atmosphere_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:LayerMedium</para>
    ///
    /// labels<para>atmosphere air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_air</seealso>
    let atmosphere_air = Prefixed_Name(cff, "atmosphere_air") |> PrefixedName

    /// <summary>
    ///   <para>cff:atmosphere_boundary_layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>atmosphere boundary layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_boundary_layer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_boundary_layer</seealso>
    let atmosphere_boundary_layer =
        Prefixed_Name(cff, "atmosphere_boundary_layer") |> PrefixedName

    /// <summary>
    ///   <para>cff:atmosphere_layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>atmosphere layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_layer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#atmosphere_layer</seealso>
    let atmosphere_layer = Prefixed_Name(cff, "atmosphere_layer") |> PrefixedName
    /// <summary>
    ///   <para>cff:canopy_and_surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>canopy and surface</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#canopy_and_surface">http://purl.oclc.org/NET/ssnx/cf/cf-feature#canopy_and_surface</seealso>
    let canopy_and_surface = Prefixed_Name(cff, "canopy_and_surface") |> PrefixedName
    /// <summary>
    ///   <para>cff:cloud_base</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>cloud base</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_base">http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_base</seealso>
    let cloud_base = Prefixed_Name(cff, "cloud_base") |> PrefixedName
    /// <summary>
    ///   <para>cff:cloud_base_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>cloud base air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_base_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_base_air</seealso>
    let cloud_base_air = Prefixed_Name(cff, "cloud_base_air") |> PrefixedName
    /// <summary>
    ///   <para>cff:cloud_top</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>cloud top</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_top">http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_top</seealso>
    let cloud_top = Prefixed_Name(cff, "cloud_top") |> PrefixedName
    /// <summary>
    ///   <para>cff:cloud_top_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>cloud top air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_top_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#cloud_top_air</seealso>
    let cloud_top_air = Prefixed_Name(cff, "cloud_top_air") |> PrefixedName

    /// <summary>
    ///   <para>cff:convective_cloud_base</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>convective cloud base</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_base">http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_base</seealso>
    let convective_cloud_base =
        Prefixed_Name(cff, "convective_cloud_base") |> PrefixedName

    /// <summary>
    ///   <para>cff:convective_cloud_base_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>convective cloud base air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_base_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_base_air</seealso>
    let convective_cloud_base_air =
        Prefixed_Name(cff, "convective_cloud_base_air") |> PrefixedName

    /// <summary>
    ///   <para>cff:convective_cloud_top</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>convective cloud top</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_top">http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_top</seealso>
    let convective_cloud_top =
        Prefixed_Name(cff, "convective_cloud_top") |> PrefixedName

    /// <summary>
    ///   <para>cff:convective_cloud_top_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>convective cloud top air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_top_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#convective_cloud_top_air</seealso>
    let convective_cloud_top_air =
        Prefixed_Name(cff, "convective_cloud_top_air") |> PrefixedName

    /// <summary>
    ///   <para>cff:dynamic_tropopause</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>dynamic tropopause</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#dynamic_tropopause">http://purl.oclc.org/NET/ssnx/cf/cf-feature#dynamic_tropopause</seealso>
    let dynamic_tropopause = Prefixed_Name(cff, "dynamic_tropopause") |> PrefixedName
    /// <summary>
    ///   <para>cff:floating_ice</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>floating ice</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#floating_ice">http://purl.oclc.org/NET/ssnx/cf/cf-feature#floating_ice</seealso>
    let floating_ice = Prefixed_Name(cff, "floating_ice") |> PrefixedName
    /// <summary>
    ///   <para>cff:freezing_level</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>freezing level</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#freezing_level">http://purl.oclc.org/NET/ssnx/cf/cf-feature#freezing_level</seealso>
    let freezing_level = Prefixed_Name(cff, "freezing_level") |> PrefixedName
    /// <summary>
    ///   <para>cff:freezing_level_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>freezing level air</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#freezing_level_air">http://purl.oclc.org/NET/ssnx/cf/cf-feature#freezing_level_air</seealso>
    let freezing_level_air = Prefixed_Name(cff, "freezing_level_air") |> PrefixedName

    /// <summary>
    ///   <para>cff:geoid_reference_ellipsoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceSurface</para>
    ///
    /// labels<para>geoid reference ellipsoid</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#geoid_reference_ellipsoid">http://purl.oclc.org/NET/ssnx/cf/cf-feature#geoid_reference_ellipsoid</seealso>
    let geoid_reference_ellipsoid =
        Prefixed_Name(cff, "geoid_reference_ellipsoid") |> PrefixedName

    /// <summary>
    ///   <para>cff:ground</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>ground</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground">http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground</seealso>
    let ground = Prefixed_Name(cff, "ground") |> PrefixedName
    /// <summary>
    ///   <para>cff:ground_level_snow</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>ground level snow</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground_level_snow">http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground_level_snow</seealso>
    let ground_level_snow = Prefixed_Name(cff, "ground_level_snow") |> PrefixedName
    /// <summary>
    ///   <para>cff:ground_level_soil</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceMedium</para>
    ///
    /// labels<para>ground level soil</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground_level_soil">http://purl.oclc.org/NET/ssnx/cf/cf-feature#ground_level_soil</seealso>
    let ground_level_soil = Prefixed_Name(cff, "ground_level_soil") |> PrefixedName
    /// <summary>
    ///   <para>cff:ocean_layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>ocean layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean_layer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean_layer</seealso>
    let ocean_layer = Prefixed_Name(cff, "ocean_layer") |> PrefixedName
    /// <summary>
    ///   <para>cff:rainfall</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Precipitation</para>
    ///
    /// labels<para>rainfall</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#rainfall">http://purl.oclc.org/NET/ssnx/cf/cf-feature#rainfall</seealso>
    let rainfall = Prefixed_Name(cff, "rainfall") |> PrefixedName
    /// <summary>
    ///   <para>cff:reference_ellipsoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>reference ellipsoid</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#reference_ellipsoid">http://purl.oclc.org/NET/ssnx/cf/cf-feature#reference_ellipsoid</seealso>
    let reference_ellipsoid = Prefixed_Name(cff, "reference_ellipsoid") |> PrefixedName
    /// <summary>
    ///   <para>cff:sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>sea</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea</seealso>
    let sea = Prefixed_Name(cff, "sea") |> PrefixedName
    /// <summary>
    ///   <para>cff:sea_floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Surface</para>
    ///
    /// labels<para>sea floor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor</seealso>
    let sea_floor = Prefixed_Name(cff, "sea_floor") |> PrefixedName
    /// <summary>
    ///   <para>cff:sea_floor_geoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceSurface</para>
    ///
    /// labels<para>sea floor geoid</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_geoid">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_geoid</seealso>
    let sea_floor_geoid = Prefixed_Name(cff, "sea_floor_geoid") |> PrefixedName
    /// <summary>
    ///   <para>cff:sea_floor_sea_level</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceSurface</para>
    ///
    /// labels<para>sea floor sea level</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_sea_level">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_sea_level</seealso>
    let sea_floor_sea_level = Prefixed_Name(cff, "sea_floor_sea_level") |> PrefixedName

    /// <summary>
    ///   <para>cff:sea_floor_sea_surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:SurfaceSurface</para>
    ///
    /// labels<para>sea floor sea surface</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_sea_surface">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_floor_sea_surface</seealso>
    let sea_floor_sea_surface =
        Prefixed_Name(cff, "sea_floor_sea_surface") |> PrefixedName

    /// <summary>
    ///   <para>cff:sea_ice</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///   <para>cff:Medium</para>
    ///
    /// labels<para>sea ice</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice">http://purl.oclc.org/NET/ssnx/cf/cf-feature#sea_ice</seealso>
    let sea_ice = Prefixed_Name(cff, "sea_ice") |> PrefixedName
    /// <summary>
    ///   <para>cff:ocean_mixed_layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cff:Layer</para>
    ///
    /// labels<para>ocean mixed layer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean_mixed_layer">http://purl.oclc.org/NET/ssnx/cf/cf-feature#ocean_mixed_layer</seealso>
    let ocean_mixed_layer = Prefixed_Name(cff, "ocean_mixed_layer") |> PrefixedName
    /// <summary>
    ///   <para>cff:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Humidity</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Humidity">http://purl.oclc.org/NET/ssnx/cf/cf-feature#Humidity</seealso>
    let Humidity = Prefixed_Name(cff, "Humidity") |> PrefixedName
    /// <summary>
    ///   <para>cff:Precipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Precipitation</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#Precipitation">http://purl.oclc.org/NET/ssnx/cf/cf-feature#Precipitation</seealso>
    let Precipitation = Prefixed_Name(cff, "Precipitation") |> PrefixedName
    /// <summary>
    ///   <para>cff:SurfaceMediumMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Surface Medium Medium</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMediumMedium">http://purl.oclc.org/NET/ssnx/cf/cf-feature#SurfaceMediumMedium</seealso>
    let SurfaceMediumMedium = Prefixed_Name(cff, "SurfaceMediumMedium") |> PrefixedName
