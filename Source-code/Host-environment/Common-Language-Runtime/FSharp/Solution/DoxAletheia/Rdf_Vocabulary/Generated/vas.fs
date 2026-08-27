namespace https.robotica.uv.es.proyectos.ASOTVAS.def.ciencia_tecnologia.vas.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vas =
    let _namespace_iri = Namespace_Iri vas |> NamespaceIRI
    /// <summary>
    ///   <para>vas:10km_x_10km</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:ControlArea</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A Control Area is a spatially delimited region designated to enable consistent environmental observations, calibration activities, and cross-platform validation. It provides a reference zone where measurements can be collected under controlled or well-characterized conditions. Dimension 10 x10."</para>
    /// labels<para>"10x10 Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#10km_x_10km">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#10km_x_10km</seealso>
    let _10km_x_10km = Prefixed_Name(vas, "10km_x_10km") |> PrefixedName
    /// <summary>
    ///   <para>vas:1km_x_1km</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:ControlArea</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A Control Area is a spatially delimited region designated to enable consistent environmental observations, calibration activities, and cross-platform validation. It provides a reference zone where measurements can be collected under controlled or well-characterized conditions. Dimension 1 x1."</para>
    /// labels<para>"1x1 Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#1km_x_1km">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#1km_x_1km</seealso>
    let _1km_x_1km = Prefixed_Name(vas, "1km_x_1km") |> PrefixedName
    /// <summary>
    ///   <para>vas:AEMET_UTIEL_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://aemet.linkeddata.es/ontology/WeatherStation&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The meteorological station named "La Cubera" is close to the municipality of 'Utiel', at an altitude of 758 meters above sea level, and near Vereda Real, Casa de la Cubera, Camino de la Solana, Camino de Cuenca, La Solana, Caz del Soto Magro, Rambla del Colmenar, Casas de Santa Bárbara, Cañada del Campo, La Vega…."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AEMET_UTIEL_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AEMET_UTIEL_Station</seealso>
    let AEMET_UTIEL_Station = Prefixed_Name(vas, "AEMET_UTIEL_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:AGB_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by AGB sensors. Unit of measure Unit of measure Mg/ha (Milligram per Hectare).."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_Result</seealso>
    let AGB_Result = Prefixed_Name(vas, "AGB_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:AGB_SMOS_CATDS_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_SMOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"AGB_SMOS_CATDS Sensor hosted by SMOS Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_SMOS_CATDS_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_SMOS_CATDS_Sensor_1</seealso>
    let AGB_SMOS_CATDS_Sensor_1 =
        Prefixed_Name(vas, "AGB_SMOS_CATDS_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:AGB_UAV_Hyperspectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Hyperspectral</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor AGB UAV Hyperspectral hosted by UAV Hyperspectral 1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_Hyperspectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_Hyperspectral_Sensor_1</seealso>
    let AGB_UAV_Hyperspectral_Sensor_1 =
        Prefixed_Name(vas, "AGB_UAV_Hyperspectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:AGB_UAV_LiDAR_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_LiDAR</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor AGB UAV LiDAR  hosted by UAV LiDAR 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_LiDAR_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_LiDAR_Sensor_1</seealso>
    let AGB_UAV_LiDAR_Sensor_1 =
        Prefixed_Name(vas, "AGB_UAV_LiDAR_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:AGB_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to AGB (Aboveground Biomass) . Unit of measure Mg/ha (Milligram per Hectare)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_Observation</seealso>
    let AGB_UAV_Observation = Prefixed_Name(vas, "AGB_UAV_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:Anemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measures the direction [0º-360º] and the intensity (m/s) of the wind"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer</seealso>
    let Anemometer = Prefixed_Name(vas, "Anemometer") |> PrefixedName

    /// <summary>
    ///   <para>vas:Anemometer_AEMET_Sensor_UTIEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://aemet.linkeddata.es/ontology/Anemometer&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor Anemometer_AEMET hosted by AEMET_UTIEL_Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_AEMET_Sensor_UTIEL">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_AEMET_Sensor_UTIEL</seealso>
    let Anemometer_AEMET_Sensor_UTIEL =
        Prefixed_Name(vas, "Anemometer_AEMET_Sensor_UTIEL") |> PrefixedName

    /// <summary>
    ///   <para>vas:Anemometer_EddyCovariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measures the intensity (m/s) of the wind"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_EddyCovariance">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_EddyCovariance</seealso>
    let Anemometer_EddyCovariance =
        Prefixed_Name(vas, "Anemometer_EddyCovariance") |> PrefixedName

    /// <summary>
    ///   <para>vas:Anemometer_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Anemometer_EddyCovariance</para>
    ///   <para>"Sensor Anemometer_EddyCovariance hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_EddyCovariance_Sensor_1</seealso>
    let Anemometer_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "Anemometer_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Artificial_Surfaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Land_Cover_Classes</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Class Level 1 CORINE Land Cover - CLC"</para>
    /// labels<para>"Artificial Surfaces"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Artificial_Surfaces">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Artificial_Surfaces</seealso>
    let Artificial_Surfaces = Prefixed_Name(vas, "Artificial_Surfaces") |> PrefixedName
    /// <summary>
    ///   <para>vas:Atmosphere_Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents all Atmosphere  properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmosphere_Property">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmosphere_Property</seealso>
    let Atmosphere_Property = Prefixed_Name(vas, "Atmosphere_Property") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Humidity_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Atmospheric humidity in AEMET Station.  Percent Relative Humidity"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_AEMET_Observation</seealso>
    let Atmospheric_Humidity_AEMET_Observation =
        Prefixed_Name(vas, "Atmospheric_Humidity_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Humidity_EddyCovariance_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Atmospheric humidity in EddyCovariance Station (Gram Per Cubic Metre )"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_EddyCovariance_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_EddyCovariance_Observation</seealso>
    let Atmospheric_Humidity_EddyCovariance_Observation =
        Prefixed_Name(vas, "Atmospheric_Humidity_EddyCovariance_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Humidity_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Atmospheric humidity.Unit of measure Percent Relative Humidity."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_Observation</seealso>
    let Atmospheric_Humidity_Observation =
        Prefixed_Name(vas, "Atmospheric_Humidity_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Humidity_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Hygrometer sensors. Unit of measure Percent Relative Humidity."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_Result</seealso>
    let Atmospheric_Humidity_Result =
        Prefixed_Name(vas, "Atmospheric_Humidity_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Pressure_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Atmospheric pressure in AEMET Station. Unit of measure Hectopascal (hPa)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_AEMET_Observation</seealso>
    let Atmospheric_Pressure_AEMET_Observation =
        Prefixed_Name(vas, "Atmospheric_Pressure_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Pressure_AEMET_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Barometer sensors. Unit of measure Hectopascal (hPa)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_AEMET_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_AEMET_Result</seealso>
    let Atmospheric_Pressure_AEMET_Result =
        Prefixed_Name(vas, "Atmospheric_Pressure_AEMET_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Pressure_EddyCovariance_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Atmospheric pressure in EddyCovariance Station. Unit of measure Kilopascal (kPa)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_EddyCovariance_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_EddyCovariance_Observation</seealso>
    let Atmospheric_Pressure_EddyCovariance_Observation =
        Prefixed_Name(vas, "Atmospheric_Pressure_EddyCovariance_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Pressure_EddyCovariance_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Barometer sensors. Unit of measure Kilopascal (kPa)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_EddyCovariance_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_EddyCovariance_Result</seealso>
    let Atmospheric_Pressure_EddyCovariance_Result =
        Prefixed_Name(vas, "Atmospheric_Pressure_EddyCovariance_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Atmospheric_Pressure_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Atmospheric pressure"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_Observation</seealso>
    let Atmospheric_Pressure_Observation =
        Prefixed_Name(vas, "Atmospheric_Pressure_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Bare_Soils</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Land_Cover_Classes</para>
    ///   <para>"A soil surface devoid of any plant material."</para>
    /// labels<para>"Bare Soils"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Bare_Soils">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Bare_Soils</seealso>
    let Bare_Soils = Prefixed_Name(vas, "Bare_Soils") |> PrefixedName
    /// <summary>
    ///   <para>vas:Barometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measures pressure in hPa"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer</seealso>
    let Barometer = Prefixed_Name(vas, "Barometer") |> PrefixedName

    /// <summary>
    ///   <para>vas:Barometer_AEMET_SENSOR_UTIEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://aemet.linkeddata.es/ontology/Barometer&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor Barometer_AEMET hosted by AEMET_UTIEL_Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_AEMET_SENSOR_UTIEL">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_AEMET_SENSOR_UTIEL</seealso>
    let Barometer_AEMET_SENSOR_UTIEL =
        Prefixed_Name(vas, "Barometer_AEMET_SENSOR_UTIEL") |> PrefixedName

    /// <summary>
    ///   <para>vas:Barometer_EddyCovariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measures pressure in kPa. EddyCovariance Station."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_EddyCovariance">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_EddyCovariance</seealso>
    let Barometer_EddyCovariance =
        Prefixed_Name(vas, "Barometer_EddyCovariance") |> PrefixedName

    /// <summary>
    ///   <para>vas:Barometer_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Barometer_EddyCovariance</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor Barometer_EddyCovariance hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_EddyCovariance_Sensor_1</seealso>
    let Barometer_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "Barometer_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:CHM_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by CHM sensors. Unit of measure Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_Result</seealso>
    let CHM_Result = Prefixed_Name(vas, "CHM_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:CHM_UAV_LiDAR_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_UAV_LiDAR</para>
    ///   <para>"Sensor CHM UAV LiDAR  hosted by UAV LiDAR 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_UAV_LiDAR_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_UAV_LiDAR_Sensor_1</seealso>
    let CHM_UAV_LiDAR_Sensor_1 =
        Prefixed_Name(vas, "CHM_UAV_LiDAR_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:CHM_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to CHM (Canopy Height Model). Unit of measure Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_UAV_Observation</seealso>
    let CHM_UAV_Observation = Prefixed_Name(vas, "CHM_UAV_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:CRI_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by CRI sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_Result</seealso>
    let CRI_Result = Prefixed_Name(vas, "CRI_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:CRI_UAV_Hyperspectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Hyperspectral</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor CRI UAV Hyperspectral hosted by UAV Hyperspectral 1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_UAV_Hyperspectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_UAV_Hyperspectral_Sensor_1</seealso>
    let CRI_UAV_Hyperspectral_Sensor_1 =
        Prefixed_Name(vas, "CRI_UAV_Hyperspectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:CRI_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to CRI (Carotenoide). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_UAV_Observation</seealso>
    let CRI_UAV_Observation = Prefixed_Name(vas, "CRI_UAV_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:Canopy_Height_Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Canopy Height Model (CHM)
    /// The CHM is a derived LiDAR product that represents vegetation height above ground, computed as the difference between the DSM and the DTM:
    ///
    /// CHM = DSM − DTM
    ///
    /// It is delivered as a raster map in meters (m)."</para>
    /// labels<para>"CHM"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Canopy_Height_Model">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Canopy_Height_Model</seealso>
    let Canopy_Height_Model = Prefixed_Name(vas, "Canopy_Height_Model") |> PrefixedName
    /// <summary>
    ///   <para>vas:CarbonDioxideFlux_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes carbon dioxide flow measurements"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CarbonDioxideFlux_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CarbonDioxideFlux_g</seealso>
    let CarbonDioxideFlux_g = Prefixed_Name(vas, "CarbonDioxideFlux_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:CarbonDioxideFlux_g_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:CarbonDioxideFlux_g</para>
    ///   <para>"Sensor CarbonDioxideFlux_g_EddyCovariance hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CarbonDioxideFlux_g_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CarbonDioxideFlux_g_EddyCovariance_Sensor_1</seealso>
    let CarbonDioxideFlux_g_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "CarbonDioxideFlux_g_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Carbon_Dioxide_Flux_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Carbon dioxide flux (mg / (m2s))"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Carbon_Dioxide_Flux_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Carbon_Dioxide_Flux_Observation</seealso>
    let Carbon_Dioxide_Flux_Observation =
        Prefixed_Name(vas, "Carbon_Dioxide_Flux_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Carbon_Dioxide_flux_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by CarbonDioxideFlux (carbon dioxide flux) sensors. Unit of measure Milligrams per Square Metre per Second,"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Carbon_Dioxide_flux_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Carbon_Dioxide_flux_Result</seealso>
    let Carbon_Dioxide_flux_Result =
        Prefixed_Name(vas, "Carbon_Dioxide_flux_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Chl_L8_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes Chl measurements from Landsat-8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L8_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L8_Observation</seealso>
    let Chl_L8_Observation = Prefixed_Name(vas, "Chl_L8_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_L8_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-8</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Chl_L8 Sensor hosted by Landsat-8 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L8_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L8_Sensor_1</seealso>
    let Chl_L8_Sensor_1 = Prefixed_Name(vas, "Chl_L8_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_L9_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes Chl measurements from Lamdsat-9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L9_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L9_Observation</seealso>
    let Chl_L9_Observation = Prefixed_Name(vas, "Chl_L9_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_L9_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-9</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Chl_L9 Sensor hosted by Landsat-9 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L9_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L9_Sensor_1</seealso>
    let Chl_L9_Sensor_1 = Prefixed_Name(vas, "Chl_L9_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Observation</seealso>
    let Chl_Observation = Prefixed_Name(vas, "Chl_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Chl (Chlorophyll content) sensors. Micromoles of chlorophyll per square metre of leaf surface.Unit of measure Micromoles per Square Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Result</seealso>
    let Chl_Result = Prefixed_Name(vas, "Chl_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_S2_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface."</para>
    ///   <para>"Sensor that takes Chlorophyll measurements from Sentinel-2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_S2_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_S2_Observation</seealso>
    let Chl_S2_Observation = Prefixed_Name(vas, "Chl_S2_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_S2_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Sentinel-2</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Chl_S2 Sensor hosted by Sentinel-2 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_S2_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_S2_Sensor_1</seealso>
    let Chl_S2_Sensor_1 = Prefixed_Name(vas, "Chl_S2_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Chl_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Satellite_Observation</seealso>
    let Chl_Satellite_Observation =
        Prefixed_Name(vas, "Chl_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Chl_Satellite_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Chl (Chlorophyll content) sensors. Micromoles of chlorophyll per square metre of leaf surface. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Satellite_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Satellite_Result</seealso>
    let Chl_Satellite_Result =
        Prefixed_Name(vas, "Chl_Satellite_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Chl_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Chlorophyll content stations"</para>
    /// labels<para>"Chl_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Station</seealso>
    let Chl_Station = Prefixed_Name(vas, "Chl_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Chl_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Chl Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Station_1</seealso>
    let Chl_Station_1 = Prefixed_Name(vas, "Chl_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes Chlorophyll measurements. From Chl Station."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_g</seealso>
    let Chl_g = Prefixed_Name(vas, "Chl_g") |> PrefixedName
    /// <summary>
    ///   <para>vas:Chl_g_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Chl_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor Chl_g hosted by Chl_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_g_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_g_Sensor_1</seealso>
    let Chl_g_Sensor_1 = Prefixed_Name(vas, "Chl_g_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Clock_AEMET_Sensor_UTIEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://aemet.linkeddata.es/ontology/Clock&gt;</para>
    ///   <para>"Sensor Clock_AEMET hosted by AEMET_UTIEL_Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Clock_AEMET_Sensor_UTIEL">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Clock_AEMET_Sensor_UTIEL</seealso>
    let Clock_AEMET_Sensor_UTIEL =
        Prefixed_Name(vas, "Clock_AEMET_Sensor_UTIEL") |> PrefixedName

    /// <summary>
    ///   <para>vas:CloudMask_METEOSAT_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes CloudMask measurements from METEOSAT."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to cloud mask. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_METEOSAT_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_METEOSAT_Observation</seealso>
    let CloudMask_METEOSAT_Observation =
        Prefixed_Name(vas, "CloudMask_METEOSAT_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:CloudMask_METEOSAT_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_METEOSAT</para>
    ///   <para>"CloudMask_METEOSAT Sensor hosted by METEOSAT Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_METEOSAT_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_METEOSAT_Sensor_1</seealso>
    let CloudMask_METEOSAT_Sensor_1 =
        Prefixed_Name(vas, "CloudMask_METEOSAT_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:CloudMask_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by CloudMask_METEOSAT sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_Result</seealso>
    let CloudMask_Result = Prefixed_Name(vas, "CloudMask_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:CloudType_METEOSAT_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to cloud mask. Dimensionless."</para>
    ///   <para>"Sensor that takes CloudType measurements from METEOSAT."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_METEOSAT_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_METEOSAT_Observation</seealso>
    let CloudType_METEOSAT_Observation =
        Prefixed_Name(vas, "CloudType_METEOSAT_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:CloudType_METEOSAT_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_METEOSAT</para>
    ///   <para>"CloudType_METEOSAT Sensor hosted by METEOSAT Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_METEOSAT_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_METEOSAT_Sensor_1</seealso>
    let CloudType_METEOSAT_Sensor_1 =
        Prefixed_Name(vas, "CloudType_METEOSAT_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:CloudType_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by by CloudType_METEOSAT sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_Result</seealso>
    let CloudType_Result = Prefixed_Name(vas, "CloudType_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:Coniferous_Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Land_Cover_Classes</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Class Level 3 CORINE Land Cover - CLC"</para>
    /// labels<para>"Coniferous Forest"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Coniferous_Forest">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Coniferous_Forest</seealso>
    let Coniferous_Forest = Prefixed_Name(vas, "Coniferous_Forest") |> PrefixedName
    /// <summary>
    ///   <para>vas:ControlArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Control Area is a spatially delimited region designated to enable consistent environmental observations, calibration activities, and cross-platform validation. It provides a reference zone where measurements can be collected under controlled or well-characterized conditions."</para>
    /// labels<para>"Control Area"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#ControlArea">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#ControlArea</seealso>
    let ControlArea = Prefixed_Name(vas, "ControlArea") |> PrefixedName
    /// <summary>
    ///   <para>vas:DBH_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by DBH sensors. Unit of measure Centimetre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_Result</seealso>
    let DBH_Result = Prefixed_Name(vas, "DBH_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:DBH_UAV_LiDAR_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_LiDAR</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor DBH UAV LiDAR  hosted by UAV LiDAR 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_UAV_LiDAR_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_UAV_LiDAR_Sensor_1</seealso>
    let DBH_UAV_LiDAR_Sensor_1 =
        Prefixed_Name(vas, "DBH_UAV_LiDAR_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:DBH_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to DBH (Diameter at Breast Height). Unit of measure Centimetre"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_UAV_Observation</seealso>
    let DBH_UAV_Observation = Prefixed_Name(vas, "DBH_UAV_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:DHP_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Digital Hemispheric Picture (DHP) stations"</para>
    /// labels<para>"DHP_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station</seealso>
    let DHP_Station = Prefixed_Name(vas, "DHP_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:DHP_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:DHP_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"DHP Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_1</seealso>
    let DHP_Station_1 = Prefixed_Name(vas, "DHP_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:DHP_Station_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:DHP_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"DHP Station number 2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_2</seealso>
    let DHP_Station_2 = Prefixed_Name(vas, "DHP_Station_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:DHP_Station_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:DHP_Station</para>
    ///   <para>"DHP Station number 3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_3</seealso>
    let DHP_Station_3 = Prefixed_Name(vas, "DHP_Station_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:DSM_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by DSM sensors. Unit of measure Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_Result</seealso>
    let DSM_Result = Prefixed_Name(vas, "DSM_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:DSM_UAV_LiDAR_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_LiDAR</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor DSM UAV LiDAR  hosted by UAV LiDAR 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_UAV_LiDAR_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_UAV_LiDAR_Sensor_1</seealso>
    let DSM_UAV_LiDAR_Sensor_1 =
        Prefixed_Name(vas, "DSM_UAV_LiDAR_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:DSM_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to DSM (Digital Surface Model).Unit of measure Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_UAV_Observation</seealso>
    let DSM_UAV_Observation = Prefixed_Name(vas, "DSM_UAV_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:DTM_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by DTM sensors.Unit of measure Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_Result</seealso>
    let DTM_Result = Prefixed_Name(vas, "DTM_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:DTM_UAV_LiDAR_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_UAV_LiDAR</para>
    ///   <para>"Sensor DTM UAV LiDAR  hosted by UAV LiDAR 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_UAV_LiDAR_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_UAV_LiDAR_Sensor_1</seealso>
    let DTM_UAV_LiDAR_Sensor_1 =
        Prefixed_Name(vas, "DTM_UAV_LiDAR_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:DTM_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to DTM (Digital Terrain Model).Unit of measure Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_UAV_Observation</seealso>
    let DTM_UAV_Observation = Prefixed_Name(vas, "DTM_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Diffuse_Irradiance_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Diffuse radiation (W/m2)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Diffuse_Irradiance_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Diffuse_Irradiance_Observation</seealso>
    let Diffuse_Irradiance_Observation =
        Prefixed_Name(vas, "Diffuse_Irradiance_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Diffuse_Irradiance_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by I_dif sensors. Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Diffuse_Irradiance_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Diffuse_Irradiance_Result</seealso>
    let Diffuse_Irradiance_Result =
        Prefixed_Name(vas, "Diffuse_Irradiance_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Digital_Surface_Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>"Digital Surface Model (DSM).
    /// A DSM is a LiDAR-derived raster representing the elevation of the uppermost surfaces in the scene, including vegetation, buildings, and all above-ground objects. Pixel values correspond to absolute height in meters (m)."</para>
    /// labels<para>"DSM"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Digital_Surface_Model">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Digital_Surface_Model</seealso>
    let Digital_Surface_Model =
        Prefixed_Name(vas, "Digital_Surface_Model") |> PrefixedName

    /// <summary>
    ///   <para>vas:Digital_Terrain_Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Digital Terrain Model (DTM).
    /// A DTM is a LiDAR-derived raster representing the elevation of the bare ground surface, with vegetation and artificial structures removed. Each pixel stores the ground height expressed in meters (m)."</para>
    /// labels<para>"DTM"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Digital_Terrain_Model">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Digital_Terrain_Model</seealso>
    let Digital_Terrain_Model =
        Prefixed_Name(vas, "Digital_Terrain_Model") |> PrefixedName

    /// <summary>
    ///   <para>vas:Direct_Irradiance_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Direct solar radiation (W/m2)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Direct_Irradiance_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Direct_Irradiance_Observation</seealso>
    let Direct_Irradiance_Observation =
        Prefixed_Name(vas, "Direct_Irradiance_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Direct_Irradiance_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by I_dir sensors. Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Direct_Irradiance_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Direct_Irradiance_Result</seealso>
    let Direct_Irradiance_Result =
        Prefixed_Name(vas, "Direct_Irradiance_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:DiseaseStatus_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by DiseaseStatus sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_Result</seealso>
    let DiseaseStatus_Result =
        Prefixed_Name(vas, "DiseaseStatus_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:DiseaseStatus_UAV_Hyperspectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_UAV_Hyperspectral</para>
    ///   <para>"Sensor Diseasestatus UAV Hyperspectral hosted by UAV Hyperspectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_UAV_Hyperspectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_UAV_Hyperspectral_Sensor_1</seealso>
    let DiseaseStatus_UAV_Hyperspectral_Sensor_1 =
        Prefixed_Name(vas, "DiseaseStatus_UAV_Hyperspectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:DiseaseStatus_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to DiseaseStatus. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_UAV_Observation</seealso>
    let DiseaseStatus_UAV_Observation =
        Prefixed_Name(vas, "DiseaseStatus_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:DroughtIndex_SMOS_CATDS_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_SMOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"DroughtIndex_SMOS_CATDS Sensor hosted by SMOS Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DroughtIndex_SMOS_CATDS_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DroughtIndex_SMOS_CATDS_Sensor_1</seealso>
    let DroughtIndex_SMOS_CATDS_Sensor_1 =
        Prefixed_Name(vas, "DroughtIndex_SMOS_CATDS_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Duration_of_Sunshine_AEMET_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Heliograph sensors in AEMET Station. Unit of measure Hour."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Duration_of_Sunshine_AEMET_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Duration_of_Sunshine_AEMET_Result</seealso>
    let Duration_of_Sunshine_AEMET_Result =
        Prefixed_Name(vas, "Duration_of_Sunshine_AEMET_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_L8_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Enhanced Vegetation Index (EVI)."</para>
    ///   <para>"Sensor that takes EVI measurements from Landsat-8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L8_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L8_Observation</seealso>
    let EVI_L8_Observation = Prefixed_Name(vas, "EVI_L8_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:EVI_L8_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-8</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"EVI_L8 Sensor hosted by Landsat-8 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L8_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L8_Sensor_1</seealso>
    let EVI_L8_Sensor_1 = Prefixed_Name(vas, "EVI_L8_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:EVI_L9_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Enhanced Vegetation Index (EVI)."</para>
    ///   <para>"Sensor that takes EVI measurements from  Landsat-9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L9_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L9_Observation</seealso>
    let EVI_L9_Observation = Prefixed_Name(vas, "EVI_L9_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:EVI_L9_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-9</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"EVI_L9 Sensor hosted by Landsat-9 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L9_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L9_Sensor_1</seealso>
    let EVI_L9_Sensor_1 = Prefixed_Name(vas, "EVI_L9_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_MODIS-Aqua_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes Enhanced Vegetation Index (EVI) measurements from MODIS-Aqua."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Daily temporality, resolution 500 m, product MYD09GA_006_EVI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Enhanced Vegetation Index (EVI)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_MODIS-Aqua_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_MODIS-Aqua_Observation</seealso>
    let EVI_MODIS_Aqua_Observation =
        Prefixed_Name(vas, "EVI_MODIS-Aqua_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_MODIS-Terra_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes Enhanced Vegetation Index (EVI) measurements from MODIS-Terra."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Daily temporality, 500 m resolution, product MYD09GA_006_EVI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Enhanced Vegetation Index (EVI)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_MODIS-Terra_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_MODIS-Terra_Observation</seealso>
    let EVI_MODIS_Terra_Observation =
        Prefixed_Name(vas, "EVI_MODIS-Terra_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Enhanced Vegetation Index (EVI) sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_Result</seealso>
    let EVI_Result = Prefixed_Name(vas, "EVI_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:EVI_S2_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes EVI measurements from Sentinel-2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Enhanced Vegetation Index (EVI)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_S2_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_S2_Observation</seealso>
    let EVI_S2_Observation = Prefixed_Name(vas, "EVI_S2_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:EVI_S2_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Sentinel-2</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"EVI_S2 Sensor hosted by Sentinel-2 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_S2_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_S2_Sensor_1</seealso>
    let EVI_S2_Sensor_1 = Prefixed_Name(vas, "EVI_S2_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Enhanced Vegetation Index (EVI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_Satellite_Observation</seealso>
    let EVI_Satellite_Observation =
        Prefixed_Name(vas, "EVI_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_UAV_Multispectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Multispectral</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor EVI UAV Multispectral hosted by UAV Multispectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_UAV_Multispectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_UAV_Multispectral_Sensor_1</seealso>
    let EVI_UAV_Multispectral_Sensor_1 =
        Prefixed_Name(vas, "EVI_UAV_Multispectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Enhanced Vegetation Index (EVI). DImensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_UAV_Observation</seealso>
    let EVI_UAV_Observation = Prefixed_Name(vas, "EVI_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_diary_500m_a_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_MODIS-Aqua</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"EVI_diary_500m_a Sensor hosted by MODIS-Aqua Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_diary_500m_a_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_diary_500m_a_Sensor_1</seealso>
    let EVI_diary_500m_a_Sensor_1 =
        Prefixed_Name(vas, "EVI_diary_500m_a_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:EVI_diary_500m_t_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Terra</para>
    ///   <para>"EVI_diary_500m_t Sensor hosted by MODIS-TerraProduct_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_diary_500m_t_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_diary_500m_t_Sensor_1</seealso>
    let EVI_diary_500m_t_Sensor_1 =
        Prefixed_Name(vas, "EVI_diary_500m_t_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:EddyCovariance_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Eddy covariance systems measure the exchange of CO2, H2O, CH4 , and energy between the earth’s surface and the atmosphere, empowering researchers to advance scientific understanding of climate and ecosystem dynamics"</para>
    /// labels<para>"EddyCovariance_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EddyCovariance_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EddyCovariance_Station</seealso>
    let EddyCovariance_Station =
        Prefixed_Name(vas, "EddyCovariance_Station") |> PrefixedName

    /// <summary>
    ///   <para>vas:EddyCovariance_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:EddyCovariance_Station</para>
    ///   <para>"EddyCovariance Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EddyCovariance_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EddyCovariance_Station_1</seealso>
    let EddyCovariance_Station_1 =
        Prefixed_Name(vas, "EddyCovariance_Station_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_8days_500m_a_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Aqua</para>
    ///   <para>"FAPAR_8days_500m_a Sensor hosted by MODIS-Aqua Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_8days_500m_a_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_8days_500m_a_Sensor_1</seealso>
    let FAPAR_8days_500m_a_Sensor_1 =
        Prefixed_Name(vas, "FAPAR_8days_500m_a_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_8days_500m_t_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_MODIS-Terra</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"FAPAR_8days_500m_t Sensor hosted by MODIS-TerraProduct_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_8days_500m_t_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_8days_500m_t_Sensor_1</seealso>
    let FAPAR_8days_500m_t_Sensor_1 =
        Prefixed_Name(vas, "FAPAR_8days_500m_t_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_L8_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    ///   <para>"Sensor that takes FAPAR measurements from  Landsat-8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L8_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L8_Observation</seealso>
    let FAPAR_L8_Observation =
        Prefixed_Name(vas, "FAPAR_L8_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_L8_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Landsat-8</para>
    ///   <para>"FAPAR_L8 Sensor hosted by Landsat-8 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L8_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L8_Sensor_1</seealso>
    let FAPAR_L8_Sensor_1 = Prefixed_Name(vas, "FAPAR_L8_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_L9_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    ///   <para>"Sensor that takes FAPAR measurements from  Landsat-9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L9_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L9_Observation</seealso>
    let FAPAR_L9_Observation =
        Prefixed_Name(vas, "FAPAR_L9_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_L9_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-9</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"FAPAR_L9 Sensor hosted by Landsat-9 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L9_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L9_Sensor_1</seealso>
    let FAPAR_L9_Sensor_1 = Prefixed_Name(vas, "FAPAR_L9_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_MODIS-Aqua_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    ///   <para>"Sensor that takes FAPAR measurements from MODIS-Aqua."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Temporality 8 days, resolution 500 m, product MYD15A2H"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_MODIS-Aqua_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_MODIS-Aqua_Observation</seealso>
    let FAPAR_MODIS_Aqua_Observation =
        Prefixed_Name(vas, "FAPAR_MODIS-Aqua_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_MODIS-Terra_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes FAPAR measurements from MODIS-Terra."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    ///   <para>"Temporality 8 days, resolution 500 m, product MYD15A2H"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_MODIS-Terra_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_MODIS-Terra_Observation</seealso>
    let FAPAR_MODIS_Terra_Observation =
        Prefixed_Name(vas, "FAPAR_MODIS-Terra_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Observation</seealso>
    let FAPAR_Observation = Prefixed_Name(vas, "FAPAR_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by fraction of absorved photosynthetically active radiation (FAPAR) sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Result</seealso>
    let FAPAR_Result = Prefixed_Name(vas, "FAPAR_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_S2_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    ///   <para>"Sensor that takes FAPAR measurements from Sentinel-2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_S2_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_S2_Observation</seealso>
    let FAPAR_S2_Observation =
        Prefixed_Name(vas, "FAPAR_S2_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_S2_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Sentinel-2</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"FAPAR_S2 Sensor hosted by Sentinel-2 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_S2_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_S2_Sensor_1</seealso>
    let FAPAR_S2_Sensor_1 = Prefixed_Name(vas, "FAPAR_S2_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Satellite_Observation</seealso>
    let FAPAR_Satellite_Observation =
        Prefixed_Name(vas, "FAPAR_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents fraction of absorved photosynthetically active radiation stations"</para>
    /// labels<para>"FAPAR_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station</seealso>
    let FAPAR_Station = Prefixed_Name(vas, "FAPAR_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_Station</para>
    ///   <para>"FAPAR Station number 1"</para>
    /// labels<para>"FAPAR_Station_1"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_1</seealso>
    let FAPAR_Station_1 = Prefixed_Name(vas, "FAPAR_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_Station_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:FAPAR_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"FAPAR Station number 2"</para>
    /// labels<para>"FAPAR_Station_2"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_2</seealso>
    let FAPAR_Station_2 = Prefixed_Name(vas, "FAPAR_Station_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_Station_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_Station</para>
    ///   <para>"FAPAR Station number 3"</para>
    /// labels<para>"FAPAR_Station_3"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_3</seealso>
    let FAPAR_Station_3 = Prefixed_Name(vas, "FAPAR_Station_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_Station_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:FAPAR_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"FAPAR Station number 4"</para>
    /// labels<para>"FAPAR_Station_4"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_4</seealso>
    let FAPAR_Station_4 = Prefixed_Name(vas, "FAPAR_Station_4") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_UAV_Multispectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Multispectral</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor FAPAR UAV Multispectral hosted by UAV Multispectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_UAV_Multispectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_UAV_Multispectral_Sensor_1</seealso>
    let FAPAR_UAV_Multispectral_Sensor_1 =
        Prefixed_Name(vas, "FAPAR_UAV_Multispectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_UAV_Observation</seealso>
    let FAPAR_UAV_Observation =
        Prefixed_Name(vas, "FAPAR_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_dhp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes fraction of surface downwelling photosynthetic radiative measurements. From Digital Hemispheric Picture (DHP) Station."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp</seealso>
    let FAPAR_dhp = Prefixed_Name(vas, "FAPAR_dhp") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_dhp_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Observation</seealso>
    let FAPAR_dhp_Observation =
        Prefixed_Name(vas, "FAPAR_dhp_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FAPAR_dhp_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_dhp</para>
    ///   <para>"Sensor FAPAR_dhp hosted by DHP_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_1</seealso>
    let FAPAR_dhp_Sensor_1 = Prefixed_Name(vas, "FAPAR_dhp_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_dhp_Sensor_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_dhp</para>
    ///   <para>"Sensor FAPAR_dhp hosted by DHP_Station_2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_2</seealso>
    let FAPAR_dhp_Sensor_2 = Prefixed_Name(vas, "FAPAR_dhp_Sensor_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_dhp_Sensor_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_dhp</para>
    ///   <para>"Sensor FAPAR_dhp hosted by DHP_Station_3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_3</seealso>
    let FAPAR_dhp_Sensor_3 = Prefixed_Name(vas, "FAPAR_dhp_Sensor_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes fraction of surface downwelling photosynthetic radiative measurements"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g</seealso>
    let FAPAR_g = Prefixed_Name(vas, "FAPAR_g") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_g_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Observation</seealso>
    let FAPAR_g_Observation = Prefixed_Name(vas, "FAPAR_g_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_g_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_g</para>
    ///   <para>"Sensor FAPAR_g hosted by FAPAR_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_1</seealso>
    let FAPAR_g_Sensor_1 = Prefixed_Name(vas, "FAPAR_g_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_g_Sensor_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_g</para>
    ///   <para>"Sensor FAPAR_g hosted by FAPAR_Station_2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_2</seealso>
    let FAPAR_g_Sensor_2 = Prefixed_Name(vas, "FAPAR_g_Sensor_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_g_Sensor_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_g</para>
    ///   <para>"Sensor FAPAR_g hosted by FAPAR_Station_3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_3</seealso>
    let FAPAR_g_Sensor_3 = Prefixed_Name(vas, "FAPAR_g_Sensor_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:FAPAR_g_Sensor_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FAPAR_g</para>
    ///   <para>"Sensor FAPAR_g hosted by FAPAR_Station_4"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_4</seealso>
    let FAPAR_g_Sensor_4 = Prefixed_Name(vas, "FAPAR_g_Sensor_4") |> PrefixedName
    /// <summary>
    ///   <para>vas:FCOVER_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by FCOVER sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_Result</seealso>
    let FCOVER_Result = Prefixed_Name(vas, "FCOVER_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:FCOVER_dhp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes vegetation area fraction measurements. From Digital Hemispheric Picture (DHP) Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp</seealso>
    let FCOVER_dhp = Prefixed_Name(vas, "FCOVER_dhp") |> PrefixedName

    /// <summary>
    ///   <para>vas:FCOVER_dhp_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to FCOVER. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Observation</seealso>
    let FCOVER_dhp_Observation =
        Prefixed_Name(vas, "FCOVER_dhp_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:FCOVER_dhp_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FCOVER_dhp</para>
    ///   <para>"Sensor FCOVER_dhp hosted by DHP_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_1</seealso>
    let FCOVER_dhp_Sensor_1 = Prefixed_Name(vas, "FCOVER_dhp_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:FCOVER_dhp_Sensor_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FCOVER_dhp</para>
    ///   <para>"Sensor FCOVER_dhp hosted by DHP_Station_2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_2</seealso>
    let FCOVER_dhp_Sensor_2 = Prefixed_Name(vas, "FCOVER_dhp_Sensor_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:FCOVER_dhp_Sensor_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:FCOVER_dhp</para>
    ///   <para>"Sensor FCOVER_dhp hosted by DHP_Station_3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_3</seealso>
    let FCOVER_dhp_Sensor_3 = Prefixed_Name(vas, "FCOVER_dhp_Sensor_3") |> PrefixedName

    /// <summary>
    ///   <para>vas:Fruit_trees_and_berry_plantations_(olive,_almond)</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Land_Cover_Classes</para>
    ///   <para>"Class Level 3 CORINE Land Cover - CLC"</para>
    /// labels<para>"Fruit trees and berry plantations (olive, almond)"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Fruit_trees_and_berry_plantations_(olive,_almond)">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Fruit_trees_and_berry_plantations_(olive,_almond)</seealso>
    let ``Fruit_trees_and_berry_plantations_(olive,_almond)`` =
        Prefixed_Name(vas, "Fruit_trees_and_berry_plantations_(olive,_almond)") |> PrefixedName

    /// <summary>
    ///   <para>vas:GIFAPAR_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by Green Instantaneous Fraction of Absorved photosynthetically active Radiation (GIFAPAR) sensors.
    /// In this ontology by the Remote Sensing from Sentinel-3 OLCI ( RS_Sentinel-3_OLCI).
    /// Dimesionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_Result</seealso>
    let GIFAPAR_Result = Prefixed_Name(vas, "GIFAPAR_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:GIFAPAR_S3_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes GIFAPAR measurements from Sentinel-3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Green Instantaneous Fraction of Absorbed Photosynthetically Active Radiation (GI-FAPAR) (300 m de resolution)). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_S3_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_S3_Observation</seealso>
    let GIFAPAR_S3_Observation =
        Prefixed_Name(vas, "GIFAPAR_S3_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:GIFAPAR_S3_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Sentinel-3_OLCI</para>
    ///   <para>"GIFAPAR_S3 Sensor hosted by Sentinel-3_OLCI Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_S3_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_S3_Sensor_1</seealso>
    let GIFAPAR_S3_Sensor_1 = Prefixed_Name(vas, "GIFAPAR_S3_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:GIFAPAR_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_Satellite_Observation</seealso>
    let GIFAPAR_Satellite_Observation =
        Prefixed_Name(vas, "GIFAPAR_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:GeoAEMET_UTIEL_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry for AEMET_UTIEL Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoAEMET_UTIEL_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoAEMET_UTIEL_Station</seealso>
    let GeoAEMET_UTIEL_Station =
        Prefixed_Name(vas, "GeoAEMET_UTIEL_Station") |> PrefixedName

    /// <summary>
    ///   <para>vas:GeoArea10x10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Polygon</para>
    ///   <para>"Geometry for Area 10x10"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoArea10x10">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoArea10x10</seealso>
    let GeoArea10x10 = Prefixed_Name(vas, "GeoArea10x10") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoArea1x1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Polygon</para>
    ///   <para>"Geometry for Area 1x1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoArea1x1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoArea1x1</seealso>
    let GeoArea1x1 = Prefixed_Name(vas, "GeoArea1x1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoChlStation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry for ChlStation1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoChlStation1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoChlStation1</seealso>
    let GeoChlStation1 = Prefixed_Name(vas, "GeoChlStation1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoDHPStation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry for DHPStation1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation1</seealso>
    let GeoDHPStation1 = Prefixed_Name(vas, "GeoDHPStation1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoDHPStation2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry for DHPStation2."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation2</seealso>
    let GeoDHPStation2 = Prefixed_Name(vas, "GeoDHPStation2") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoDHPStation3</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry for DHPStation3."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation3</seealso>
    let GeoDHPStation3 = Prefixed_Name(vas, "GeoDHPStation3") |> PrefixedName

    /// <summary>
    ///   <para>vas:GeoEddyCovariance_Station1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry for EddyCovariance_Station1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoEddyCovariance_Station1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoEddyCovariance_Station1</seealso>
    let GeoEddyCovariance_Station1 =
        Prefixed_Name(vas, "GeoEddyCovariance_Station1") |> PrefixedName

    /// <summary>
    ///   <para>vas:GeoFaparStation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of FPARStation1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation1</seealso>
    let GeoFaparStation1 = Prefixed_Name(vas, "GeoFaparStation1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoFaparStation2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of FAPAR Station 2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation2</seealso>
    let GeoFaparStation2 = Prefixed_Name(vas, "GeoFaparStation2") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoFaparStation3</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of FAPAR Station 2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation3</seealso>
    let GeoFaparStation3 = Prefixed_Name(vas, "GeoFaparStation3") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoFaparStation4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of FAPAR Station 4"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation4</seealso>
    let GeoFaparStation4 = Prefixed_Name(vas, "GeoFaparStation4") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLAIStation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of LAIStation1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLAIStation1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLAIStation1</seealso>
    let GeoLAIStation1 = Prefixed_Name(vas, "GeoLAIStation1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLAIStation2</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of LAIStation2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLAIStation2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLAIStation2</seealso>
    let GeoLAIStation2 = Prefixed_Name(vas, "GeoLAIStation2") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLSEStation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of LSEStation1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation1</seealso>
    let GeoLSEStation1 = Prefixed_Name(vas, "GeoLSEStation1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLSEStation2</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of LSEStation2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation2</seealso>
    let GeoLSEStation2 = Prefixed_Name(vas, "GeoLSEStation2") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLSEStation3</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of LSEStation3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation3</seealso>
    let GeoLSEStation3 = Prefixed_Name(vas, "GeoLSEStation3") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLSEStation4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of LSEStation4"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation4</seealso>
    let GeoLSEStation4 = Prefixed_Name(vas, "GeoLSEStation4") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLSEStation5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of LSEStation5"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation5">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation5</seealso>
    let GeoLSEStation5 = Prefixed_Name(vas, "GeoLSEStation5") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLSEStation6</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of LSEStation6"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation6">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation6</seealso>
    let GeoLSEStation6 = Prefixed_Name(vas, "GeoLSEStation6") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoLSTStation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of LSTStation1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSTStation1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSTStation1</seealso>
    let GeoLSTStation1 = Prefixed_Name(vas, "GeoLSTStation1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoN2Station1</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of N2Station1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoN2Station1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoN2Station1</seealso>
    let GeoN2Station1 = Prefixed_Name(vas, "GeoN2Station1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoRADStation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of RADStation1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoRADStation1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoRADStation1</seealso>
    let GeoRADStation1 = Prefixed_Name(vas, "GeoRADStation1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoSMStation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of SMStation1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation1</seealso>
    let GeoSMStation1 = Prefixed_Name(vas, "GeoSMStation1") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoSMStation2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of SMStation2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation2</seealso>
    let GeoSMStation2 = Prefixed_Name(vas, "GeoSMStation2") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoSMStation3</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of SMStation3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation3</seealso>
    let GeoSMStation3 = Prefixed_Name(vas, "GeoSMStation3") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoSMStation4</para>
    /// </summary>
    /// <remarks>
    ///   <para>ns349:sf#Point</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Geometry of SMStation4"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation4</seealso>
    let GeoSMStation4 = Prefixed_Name(vas, "GeoSMStation4") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoSMStation5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of SMStation5"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation5">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation5</seealso>
    let GeoSMStation5 = Prefixed_Name(vas, "GeoSMStation5") |> PrefixedName
    /// <summary>
    ///   <para>vas:GeoSMStation6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:sf#Point</para>
    ///   <para>"Geometry of SMStation6"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation6">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation6</seealso>
    let GeoSMStation6 = Prefixed_Name(vas, "GeoSMStation6") |> PrefixedName

    /// <summary>
    ///   <para>vas:Ground_Based_Sensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ground Base Sensors"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_Based_Sensing">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_Based_Sensing</seealso>
    let Ground_Based_Sensing =
        Prefixed_Name(vas, "Ground_Based_Sensing") |> PrefixedName

    /// <summary>
    ///   <para>vas:Ground_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Ground Station is defined as a physical platform located on the Earth’s surface that hosts one or more sensors used to perform in-situ environmental observations."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_Station</seealso>
    let Ground_Station = Prefixed_Name(vas, "Ground_Station") |> PrefixedName

    /// <summary>
    ///   <para>vas:Ground_based_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Observation collected in situ."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_based_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_based_Observation</seealso>
    let Ground_based_Observation =
        Prefixed_Name(vas, "Ground_based_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Heliograph_AEMET_Sensor_UTIEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://aemet.linkeddata.es/ontology/Heliograph&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor Heliograph_AEMET hosted by AEMET_UTIEL_Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Heliograph_AEMET_Sensor_UTIEL">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Heliograph_AEMET_Sensor_UTIEL</seealso>
    let Heliograph_AEMET_Sensor_UTIEL =
        Prefixed_Name(vas, "Heliograph_AEMET_Sensor_UTIEL") |> PrefixedName

    /// <summary>
    ///   <para>vas:Hs_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes sensible heat flux measurements"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hs_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hs_g</seealso>
    let Hs_g = Prefixed_Name(vas, "Hs_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:Hs_g_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Hs_g</para>
    ///   <para>"Hs_g_EddyCovariance Sensor hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hs_g_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hs_g_EddyCovariance_Sensor_1</seealso>
    let Hs_g_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "Hs_g_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Hygrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measures relative humidity in %"</para>
    /// labels<para>"Hygrometer"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer</seealso>
    let Hygrometer = Prefixed_Name(vas, "Hygrometer") |> PrefixedName

    /// <summary>
    ///   <para>vas:Hygrometer_AEMET_Sensor_UTIEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://aemet.linkeddata.es/ontology/Hygrometer&gt;</para>
    ///   <para>"Sensor Hygrometer_AEMET hosted by AEMET_UTIEL_Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_AEMET_Sensor_UTIEL">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_AEMET_Sensor_UTIEL</seealso>
    let Hygrometer_AEMET_Sensor_UTIEL =
        Prefixed_Name(vas, "Hygrometer_AEMET_Sensor_UTIEL") |> PrefixedName

    /// <summary>
    ///   <para>vas:Hygrometer_EddyCovariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor belongs to EddyCovariance Station. Measures relative humidity in %"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_EddyCovariance">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_EddyCovariance</seealso>
    let Hygrometer_EddyCovariance =
        Prefixed_Name(vas, "Hygrometer_EddyCovariance") |> PrefixedName

    /// <summary>
    ///   <para>vas:Hygrometer_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Hygrometer_EddyCovariance</para>
    ///   <para>"Hygrometer_EddyCovariance Sensor hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_EddyCovariance_Sensor_1</seealso>
    let Hygrometer_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "Hygrometer_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:I_dif_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes "diffuse irradiance at the surface" measurements in RAD Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dif_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dif_g</seealso>
    let I_dif_g = Prefixed_Name(vas, "I_dif_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:I_dif_g_RAD_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:I_dif_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"I_dif_g_RAD Sensor hosted by RAD_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dif_g_RAD_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dif_g_RAD_Sensor_1</seealso>
    let I_dif_g_RAD_Sensor_1 =
        Prefixed_Name(vas, "I_dif_g_RAD_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:I_dir_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes "direct irradiance at the surface" measurements in RAD Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dir_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dir_g</seealso>
    let I_dir_g = Prefixed_Name(vas, "I_dir_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:I_dir_g_RAD_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:I_dir_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"I_dir_g_RAD Sensor hosted by RAD_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dir_g_RAD_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dir_g_RAD_Sensor_1</seealso>
    let I_dir_g_RAD_Sensor_1 =
        Prefixed_Name(vas, "I_dir_g_RAD_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Image_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Image Result let us assign URIs to the image properties.  Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Image_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Image_Result</seealso>
    let Image_Result = Prefixed_Name(vas, "Image_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Insolation_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Heliograph (Duration of the sunshine in Hours)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Insolation_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Insolation_AEMET_Observation</seealso>
    let Insolation_AEMET_Observation =
        Prefixed_Name(vas, "Insolation_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:IsProductOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#IsProductOf">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#IsProductOf</seealso>
    let IsProductOf = Prefixed_Name(vas, "IsProductOf") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_L8_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Leaf Area Index (LAI). Dimensionless."</para>
    ///   <para>"Sensor that takes LAI measurements from Landsat-8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L8_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L8_Observation</seealso>
    let LAI_L8_Observation = Prefixed_Name(vas, "LAI_L8_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_L8_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Landsat-8</para>
    ///   <para>"LAI_L8 Sensor hosted by Landsat-8 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L8_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L8_Sensor_1</seealso>
    let LAI_L8_Sensor_1 = Prefixed_Name(vas, "LAI_L8_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_L9_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Leaf Area Index (LAI). Dimensionless."</para>
    ///   <para>"Sensor that takes LAI measurements from Landsat-9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L9_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L9_Observation</seealso>
    let LAI_L9_Observation = Prefixed_Name(vas, "LAI_L9_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_L9_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-9</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LAI_L9 Sensor hosted by Landsat-9 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L9_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L9_Sensor_1</seealso>
    let LAI_L9_Sensor_1 = Prefixed_Name(vas, "LAI_L9_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Leaf Area Index (LAI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Observation</seealso>
    let LAI_Observation = Prefixed_Name(vas, "LAI_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Leaf Area Index (LAI) sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Result</seealso>
    let LAI_Result = Prefixed_Name(vas, "LAI_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_S2_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes LAI measurements from Sentinel-2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Leaf Area Index (LAI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_S2_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_S2_Observation</seealso>
    let LAI_S2_Observation = Prefixed_Name(vas, "LAI_S2_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_S2_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Sentinel-2</para>
    ///   <para>"LAI_S2 Sensor hosted by Sentinel-2 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_S2_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_S2_Sensor_1</seealso>
    let LAI_S2_Sensor_1 = Prefixed_Name(vas, "LAI_S2_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LAI_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Leaf Area Index (LAI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Satellite_Observation</seealso>
    let LAI_Satellite_Observation =
        Prefixed_Name(vas, "LAI_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:LAI_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Leaf Aea Index (LAI) stations"</para>
    /// labels<para>"LAI_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station</seealso>
    let LAI_Station = Prefixed_Name(vas, "LAI_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LAI_Station</para>
    ///   <para>"LAI Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station_1</seealso>
    let LAI_Station_1 = Prefixed_Name(vas, "LAI_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_Station_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LAI_Station</para>
    ///   <para>"LAI Station number 2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station_2</seealso>
    let LAI_Station_2 = Prefixed_Name(vas, "LAI_Station_2") |> PrefixedName

    /// <summary>
    ///   <para>vas:LAI_UAV_Multispectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_UAV_Multispectral</para>
    ///   <para>"Sensor LAI UAV Multispectral hosted by UAV Multispectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_UAV_Multispectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_UAV_Multispectral_Sensor_1</seealso>
    let LAI_UAV_Multispectral_Sensor_1 =
        Prefixed_Name(vas, "LAI_UAV_Multispectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LAI_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Leaf Area Index (LAI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_UAV_Observation</seealso>
    let LAI_UAV_Observation = Prefixed_Name(vas, "LAI_UAV_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_dhp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Leaf Area Index Sensor from Digital Hemispheric Picture (DHP) Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp</seealso>
    let LAI_dhp = Prefixed_Name(vas, "LAI_dhp") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_dhp_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Leaf Area Index (LAI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Observation</seealso>
    let LAI_dhp_Observation = Prefixed_Name(vas, "LAI_dhp_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_dhp_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LAI_dhp</para>
    ///   <para>"Sensor LAI_dhp hosted by LAI_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_1</seealso>
    let LAI_dhp_Sensor_1 = Prefixed_Name(vas, "LAI_dhp_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_dhp_Sensor_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LAI_dhp</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor LAI_dhp hosted by LAI_Station_2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_2</seealso>
    let LAI_dhp_Sensor_2 = Prefixed_Name(vas, "LAI_dhp_Sensor_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_dhp_Sensor_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LAI_dhp</para>
    ///   <para>"Sensor LAI_dhp hosted by LAI_Station_3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_3</seealso>
    let LAI_dhp_Sensor_3 = Prefixed_Name(vas, "LAI_dhp_Sensor_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Leaf Area Index Sensor from Leaf Area Index (LAI) Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g</seealso>
    let LAI_g = Prefixed_Name(vas, "LAI_g") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_g_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Leaf Area Index (LAI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Observation</seealso>
    let LAI_g_Observation = Prefixed_Name(vas, "LAI_g_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_g_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LAI_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor LAI_g hosted by LAI_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Sensor_1</seealso>
    let LAI_g_Sensor_1 = Prefixed_Name(vas, "LAI_g_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LAI_g_Sensor_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LAI_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor LAI_g hosted by LAI_Station_2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Sensor_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Sensor_2</seealso>
    let LAI_g_Sensor_2 = Prefixed_Name(vas, "LAI_g_Sensor_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:LE_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes evapotranspiration measurements"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LE_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LE_g</seealso>
    let LE_g = Prefixed_Name(vas, "LE_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:LE_g_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LE_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor LE_g_EddyCovariance hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LE_g_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LE_g_EddyCovariance_Sensor_1</seealso>
    let LE_g_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "LE_g_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LSE_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Land Surface Emissivity. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Observation</seealso>
    let LSE_Observation = Prefixed_Name(vas, "LSE_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Land Surface Emissivity (LSE) sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Result</seealso>
    let LSE_Result = Prefixed_Name(vas, "LSE_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Land Surface Emissivity (LSE) stations"</para>
    /// labels<para>"LSE_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station</seealso>
    let LSE_Station = Prefixed_Name(vas, "LSE_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LSE_Station</para>
    ///   <para>"LSE Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_1</seealso>
    let LSE_Station_1 = Prefixed_Name(vas, "LSE_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_Station_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LSE_Station</para>
    ///   <para>"LSE Station number 2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_2</seealso>
    let LSE_Station_2 = Prefixed_Name(vas, "LSE_Station_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_Station_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LSE_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LSE Station number 3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_3</seealso>
    let LSE_Station_3 = Prefixed_Name(vas, "LSE_Station_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_Station_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LSE_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LSE Station number 4"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_4</seealso>
    let LSE_Station_4 = Prefixed_Name(vas, "LSE_Station_4") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_Station_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LSE_Station</para>
    ///   <para>"LSE Station number 5"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_5">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_5</seealso>
    let LSE_Station_5 = Prefixed_Name(vas, "LSE_Station_5") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_Station_6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LSE_Station</para>
    ///   <para>"LSE Station number 6"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_6">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_6</seealso>
    let LSE_Station_6 = Prefixed_Name(vas, "LSE_Station_6") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes Land Surface Emissivity measurements"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g</seealso>
    let LSE_g = Prefixed_Name(vas, "LSE_g") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_g_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LSE_g</para>
    ///   <para>"Sensor LSE_g hosted by LSE_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_1</seealso>
    let LSE_g_Sensor_1 = Prefixed_Name(vas, "LSE_g_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_g_Sensor_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LSE_g</para>
    ///   <para>"Sensor LSE_g hosted by LSE_Station_2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_2</seealso>
    let LSE_g_Sensor_2 = Prefixed_Name(vas, "LSE_g_Sensor_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_g_Sensor_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LSE_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor LSE_g hosted by LSE_Station_3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_3</seealso>
    let LSE_g_Sensor_3 = Prefixed_Name(vas, "LSE_g_Sensor_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_g_Sensor_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LSE_g</para>
    ///   <para>"Sensor LSE_g hosted by LSE_Station_4"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_4</seealso>
    let LSE_g_Sensor_4 = Prefixed_Name(vas, "LSE_g_Sensor_4") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_g_Sensor_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LSE_g</para>
    ///   <para>"Sensor LSE_g hosted by LSE_Station_5"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_5">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_5</seealso>
    let LSE_g_Sensor_5 = Prefixed_Name(vas, "LSE_g_Sensor_5") |> PrefixedName
    /// <summary>
    ///   <para>vas:LSE_g_Sensor_6</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LSE_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor LSE_g hosted by LSE_Station_6"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_6">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_6</seealso>
    let LSE_g_Sensor_6 = Prefixed_Name(vas, "LSE_g_Sensor_6") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_8days_1km_MODIS-Aqua_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"8 days temporality, 1 km resolution. Product MYD11A2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Sensor that takes Land Surface Temperature measurements from MODIS-Aqua."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_MODIS-Aqua_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_MODIS-Aqua_Observation</seealso>
    let LST_8days_1km_MODIS_Aqua_Observation =
        Prefixed_Name(vas, "LST_8days_1km_MODIS-Aqua_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_8days_1km_MODIS-Terra_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"8 days temporality, 1 km resolution. Product MYD11A2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Sensor that takes Land Surface Temperature measurements from MODIS-Terra."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_MODIS-Terra_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_MODIS-Terra_Observation</seealso>
    let LST_8days_1km_MODIS_Terra_Observation =
        Prefixed_Name(vas, "LST_8days_1km_MODIS-Terra_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_8days_1km_a_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_MODIS-Aqua</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LST_8days_1km_a Sensor hosted by MODIS-Aqua Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_a_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_a_Sensor_1</seealso>
    let LST_8days_1km_a_Sensor_1 =
        Prefixed_Name(vas, "LST_8days_1km_a_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_8days_1km_t_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Terra</para>
    ///   <para>"LST_8days_1km_t Sensor hosted by MODIS-TerraProduct_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_t_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_t_Sensor_1</seealso>
    let LST_8days_1km_t_Sensor_1 =
        Prefixed_Name(vas, "LST_8days_1km_t_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_L8_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    ///   <para>"Sensor that takes LST measurements from Landset-8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L8_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L8_Observation</seealso>
    let LST_L8_Observation = Prefixed_Name(vas, "LST_L8_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_L8_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-8</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LST_L8 Sensor hosted by Landsat-8 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L8_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L8_Sensor_1</seealso>
    let LST_L8_Sensor_1 = Prefixed_Name(vas, "LST_L8_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_L9_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes LST measurements from Landset-9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L9_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L9_Observation</seealso>
    let LST_L9_Observation = Prefixed_Name(vas, "LST_L9_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_L9_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Landsat-9</para>
    ///   <para>"LST_L9 Sensor hosted by Landsat-9 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L9_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L9_Sensor_1</seealso>
    let LST_L9_Sensor_1 = Prefixed_Name(vas, "LST_L9_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Observation</seealso>
    let LST_Observation = Prefixed_Name(vas, "LST_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Land Surface Temperature (LST) sensors.  Unit of measure Degree Celsius ."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Result</seealso>
    let LST_Result = Prefixed_Name(vas, "LST_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_S3_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes LST measurements from Sentinel-3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_S3_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_S3_Observation</seealso>
    let LST_S3_Observation = Prefixed_Name(vas, "LST_S3_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_S3_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Sentinel-3_SLSTR</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LST_S3 Sensor hosted by Sentinel-3_SLSTR Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_S3_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_S3_Sensor_1</seealso>
    let LST_S3_Sensor_1 = Prefixed_Name(vas, "LST_S3_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Satellite_Observation</seealso>
    let LST_Satellite_Observation =
        Prefixed_Name(vas, "LST_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Land Surface Temperature (LST) stations"</para>
    /// labels<para>"LST_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Station</seealso>
    let LST_Station = Prefixed_Name(vas, "LST_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:LST_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LST Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Station_1</seealso>
    let LST_Station_1 = Prefixed_Name(vas, "LST_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Unit of measure Degree Celsius."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_UAV_Observation</seealso>
    let LST_UAV_Observation = Prefixed_Name(vas, "LST_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_UAV_Thermal_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Thermal</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor LST UAV Thermal  hosted by UAV Thermal 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_UAV_Thermal_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_UAV_Thermal_Sensor_1</seealso>
    let LST_UAV_Thermal_Sensor_1 =
        Prefixed_Name(vas, "LST_UAV_Thermal_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_diary_1km_MODIS-Aqua_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Daily temporality,1 km resolution. Product MYD11A1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Sensor that takes Land Surface Temperature measurements from MODIS-Aqua."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_MODIS-Aqua_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_MODIS-Aqua_Observation</seealso>
    let LST_diary_1km_MODIS_Aqua_Observation =
        Prefixed_Name(vas, "LST_diary_1km_MODIS-Aqua_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_diary_1km_MODIS-Terra_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Land Surface Temperature (LST). Celsius Degree."</para>
    ///   <para>"Sensor that takes Land Surface Temperature measurements from MODIS-Terra."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Daily temporality,1 km resolution. Product MYD11A1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_MODIS-Terra_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_MODIS-Terra_Observation</seealso>
    let LST_diary_1km_MODIS_Terra_Observation =
        Prefixed_Name(vas, "LST_diary_1km_MODIS-Terra_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_diary_1km_a_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Aqua</para>
    ///   <para>"LST_diary_1km_a Sensor hosted by MODIS-Aqua Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_a_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_a_Sensor_1</seealso>
    let LST_diary_1km_a_Sensor_1 =
        Prefixed_Name(vas, "LST_diary_1km_a_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_diary_1km_t_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Terra</para>
    ///   <para>"LST_diary_1km_t Sensor hosted by MODIS-TerraProduct_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_t_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_t_Sensor_1</seealso>
    let LST_diary_1km_t_Sensor_1 =
        Prefixed_Name(vas, "LST_diary_1km_t_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LST_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes Land Surface Temperature measurements"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_g</seealso>
    let LST_g = Prefixed_Name(vas, "LST_g") |> PrefixedName
    /// <summary>
    ///   <para>vas:LST_g_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LST_g</para>
    ///   <para>"LST_g Sensor hosted by LST_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_g_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_g_Sensor_1</seealso>
    let LST_g_Sensor_1 = Prefixed_Name(vas, "LST_g_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:LW_down_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes "surface downwelling longwave flux in air" measurements in RAD Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_down_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_down_g</seealso>
    let LW_down_g = Prefixed_Name(vas, "LW_down_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:LW_down_g_RAD_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LW_down_g</para>
    ///   <para>"LW_down_g_RAD Sensor hosted by RAD_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_down_g_RAD_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_down_g_RAD_Sensor_1</seealso>
    let LW_down_g_RAD_Sensor_1 =
        Prefixed_Name(vas, "LW_down_g_RAD_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LW_up_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes "upwelling longwave flux in air" measurements in RAD Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_up_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_up_g</seealso>
    let LW_up_g = Prefixed_Name(vas, "LW_up_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:LW_up_g_RAD_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:LW_up_g</para>
    ///   <para>"LW_up_g_RAD Sensor hosted by RAD_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_up_g_RAD_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_up_g_RAD_Sensor_1</seealso>
    let LW_up_g_RAD_Sensor_1 =
        Prefixed_Name(vas, "LW_up_g_RAD_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:LandCover_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by LandCover_S2 sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_Result</seealso>
    let LandCover_Result = Prefixed_Name(vas, "LandCover_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:LandCover_S2_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Land Cover LCCS."</para>
    ///   <para>"Sensor that takes LandCover measurements from Sentinel-2. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_S2_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_S2_Observation</seealso>
    let LandCover_S2_Observation =
        Prefixed_Name(vas, "LandCover_S2_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:LandCover_S2_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Sentinel-2</para>
    ///   <para>"LandCover_S2 Sensor hosted by Sentinel-2 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_S2_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_S2_Sensor_1</seealso>
    let LandCover_S2_Sensor_1 =
        Prefixed_Name(vas, "LandCover_S2_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Land_Atmosphere_Interaction_Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents all Land Atmosphere Interation properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Atmosphere_Interaction_Property">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Atmosphere_Interaction_Property</seealso>
    let Land_Atmosphere_Interaction_Property =
        Prefixed_Name(vas, "Land_Atmosphere_Interaction_Property") |> PrefixedName

    /// <summary>
    ///   <para>vas:Land_Cover_Classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Land Cover Classes, Level 3"</para>
    /// labels<para>"Land Cover Classes"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Cover_Classes">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Cover_Classes</seealso>
    let Land_Cover_Classes = Prefixed_Name(vas, "Land_Cover_Classes") |> PrefixedName
    /// <summary>
    ///   <para>vas:Land_Cover_Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Land cover is the physical material on the earth's surface. Ground covers include grass, asphalt, trees, bare ground, water, etc. Land cover is the expression used by the ecologist Frederick Edward Clements that has its closest modern equivalent to vegetation."</para>
    ///   <para>"Class that represents all Land Cover properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Cover_Property">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Cover_Property</seealso>
    let Land_Cover_Property = Prefixed_Name(vas, "Land_Cover_Property") |> PrefixedName

    /// <summary>
    ///   <para>vas:Land_Surface_Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents all Land Surface properties (Temperature, Emissivity,  Aspect , Slope, Elevation ...)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Surface_Property">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Surface_Property</seealso>
    let Land_Surface_Property =
        Prefixed_Name(vas, "Land_Surface_Property") |> PrefixedName

    /// <summary>
    ///   <para>vas:Landsat-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Landsat-8"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8</seealso>
    let Landsat_8 = Prefixed_Name(vas, "Landsat-8") |> PrefixedName
    /// <summary>
    ///   <para>vas:Landsat-8_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Landsat-8 products"</para>
    /// labels<para>"Landsat-8_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Product</seealso>
    let Landsat_8_Product = Prefixed_Name(vas, "Landsat-8_Product") |> PrefixedName
    /// <summary>
    ///   <para>vas:Landsat-8_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Landsat-8_Product</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Landsat-8 Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Product_1</seealso>
    let Landsat_8_Product_1 = Prefixed_Name(vas, "Landsat-8_Product_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:Landsat-8_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Landsat-8</para>
    ///   <para>"Landsat 8 satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Satellite</seealso>
    let Landsat_8_Satellite = Prefixed_Name(vas, "Landsat-8_Satellite") |> PrefixedName
    /// <summary>
    ///   <para>vas:Landsat-9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Landsat-9"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9</seealso>
    let Landsat_9 = Prefixed_Name(vas, "Landsat-9") |> PrefixedName
    /// <summary>
    ///   <para>vas:Landsat-9_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Landsat-9 Products"</para>
    /// labels<para>"Landsat-8_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Product</seealso>
    let Landsat_9_Product = Prefixed_Name(vas, "Landsat-9_Product") |> PrefixedName
    /// <summary>
    ///   <para>vas:Landsat-9_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Landsat-9_Product</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Landsat-9 Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Product_1</seealso>
    let Landsat_9_Product_1 = Prefixed_Name(vas, "Landsat-9_Product_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:Landsat-9_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Landsat-9</para>
    ///   <para>"Landsat 9 satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Satellite</seealso>
    let Landsat_9_Satellite = Prefixed_Name(vas, "Landsat-9_Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:Latent_Heat_Flux_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Latent Heat Flux (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Latent_Heat_Flux_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Latent_Heat_Flux_Observation</seealso>
    let Latent_Heat_Flux_Observation =
        Prefixed_Name(vas, "Latent_Heat_Flux_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Latent_Heat_Flux_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by LE_g (evapotranspiration ground) sensors. Unit of measure Watt  per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Latent_Heat_Flux_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Latent_Heat_Flux_Result</seealso>
    let Latent_Heat_Flux_Result =
        Prefixed_Name(vas, "Latent_Heat_Flux_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:METEOSAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"METEOSAT"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT</seealso>
    let METEOSAT = Prefixed_Name(vas, "METEOSAT") |> PrefixedName
    /// <summary>
    ///   <para>vas:METEOSAT_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents METEOSAT Products"</para>
    /// labels<para>"METEOSAT_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Product</seealso>
    let METEOSAT_Product = Prefixed_Name(vas, "METEOSAT_Product") |> PrefixedName
    /// <summary>
    ///   <para>vas:METEOSAT_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:METEOSAT_Product</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"METEOSAT Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Product_1</seealso>
    let METEOSAT_Product_1 = Prefixed_Name(vas, "METEOSAT_Product_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:METEOSAT_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:METEOSAT</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Meteosat satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Satellite</seealso>
    let METEOSAT_Satellite = Prefixed_Name(vas, "METEOSAT_Satellite") |> PrefixedName
    /// <summary>
    ///   <para>vas:MODIS-Aqua</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MODIS-Aqua"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua</seealso>
    let MODIS_Aqua = Prefixed_Name(vas, "MODIS-Aqua") |> PrefixedName
    /// <summary>
    ///   <para>vas:MODIS-Aqua_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents MODIS-Aqua Products"</para>
    /// labels<para>"MODIS-Aqua_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Product</seealso>
    let MODIS_Aqua_Product = Prefixed_Name(vas, "MODIS-Aqua_Product") |> PrefixedName

    /// <summary>
    ///   <para>vas:MODIS-Aqua_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:MODIS-Aqua_Product</para>
    ///   <para>"Modis-Aqua Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Product_1</seealso>
    let MODIS_Aqua_Product_1 =
        Prefixed_Name(vas, "MODIS-Aqua_Product_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:MODIS-Aqua_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:MODIS-Aqua</para>
    ///   <para>"Modis Aqua satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Satellite</seealso>
    let MODIS_Aqua_Satellite =
        Prefixed_Name(vas, "MODIS-Aqua_Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:MODIS-Terra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MODIS-Terra"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra</seealso>
    let MODIS_Terra = Prefixed_Name(vas, "MODIS-Terra") |> PrefixedName
    /// <summary>
    ///   <para>vas:MODIS-Terra_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents MODIS-Terra Products"</para>
    /// labels<para>"MODIS-Terra_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Product</seealso>
    let MODIS_Terra_Product = Prefixed_Name(vas, "MODIS-Terra_Product") |> PrefixedName

    /// <summary>
    ///   <para>vas:MODIS-Terra_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:MODIS-Terra_Product</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"MODIS-TerraProduct number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Product_1</seealso>
    let MODIS_Terra_Product_1 =
        Prefixed_Name(vas, "MODIS-Terra_Product_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:MODIS-Terra_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:MODIS-Terra</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Modis Terra satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Satellite</seealso>
    let MODIS_Terra_Satellite =
        Prefixed_Name(vas, "MODIS-Terra_Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:N2_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Nitrogen concentration stations"</para>
    /// labels<para>"N2_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_Station</seealso>
    let N2_Station = Prefixed_Name(vas, "N2_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:N2_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:N2_Station</para>
    ///   <para>"N2 Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_Station_1</seealso>
    let N2_Station_1 = Prefixed_Name(vas, "N2_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:N2_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes nitrogen dioxide measurements. From N2 Station."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_g</seealso>
    let N2_g = Prefixed_Name(vas, "N2_g") |> PrefixedName
    /// <summary>
    ///   <para>vas:N2_g_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:N2_g</para>
    ///   <para>"N2_g Sensor hosted by N2_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_g_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_g_Sensor_1</seealso>
    let N2_g_Sensor_1 = Prefixed_Name(vas, "N2_g_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_1km_MODIS-Aqua_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes NDVI measurements from MODIS-Aqua."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"16 days temporality,  1km resolution, product MYD13A2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_MODIS-Aqua_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_MODIS-Aqua_Observation</seealso>
    let NDVI_16days_1km_MODIS_Aqua_Observation =
        Prefixed_Name(vas, "NDVI_16days_1km_MODIS-Aqua_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_1km_MODIS-Terra_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes NDVI measurements from MODIS-Terra."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    ///   <para>"16 days temporality, 1 km resolution. Producto MYD13A2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_MODIS-Terra_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_MODIS-Terra_Observation</seealso>
    let NDVI_16days_1km_MODIS_Terra_Observation =
        Prefixed_Name(vas, "NDVI_16days_1km_MODIS-Terra_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_1km_a_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_MODIS-Aqua</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"NDVI_16days_1km_a Sensor hosted by MODIS-Aqua Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_a_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_a_Sensor_1</seealso>
    let NDVI_16days_1km_a_Sensor_1 =
        Prefixed_Name(vas, "NDVI_16days_1km_a_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_1km_t_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Terra</para>
    ///   <para>"NDVI_16days_1km_t Sensor hosted by MODIS-TerraProduct_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_t_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_t_Sensor_1</seealso>
    let NDVI_16days_1km_t_Sensor_1 =
        Prefixed_Name(vas, "NDVI_16days_1km_t_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_250m_MODIS-Aqua_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes NDVI measurements from MODIS-Aqua."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    ///   <para>"16 days temporality, 250 m resolution, product MYD13Q1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_MODIS-Aqua_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_MODIS-Aqua_Observation</seealso>
    let NDVI_16days_250m_MODIS_Aqua_Observation =
        Prefixed_Name(vas, "NDVI_16days_250m_MODIS-Aqua_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_250m_MODIS-Terra_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"16 days temporality, 250 m resolution. Producto MYD13Q1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    ///   <para>"Sensor that takes NDVI measurements from MODIS-Terra."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_MODIS-Terra_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_MODIS-Terra_Observation</seealso>
    let NDVI_16days_250m_MODIS_Terra_Observation =
        Prefixed_Name(vas, "NDVI_16days_250m_MODIS-Terra_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_250m_a_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_MODIS-Aqua</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"NDVI_16days_250m_a Sensor hosted by MODIS-Aqua Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_a_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_a_Sensor_1</seealso>
    let NDVI_16days_250m_a_Sensor_1 =
        Prefixed_Name(vas, "NDVI_16days_250m_a_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_250m_t_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Terra</para>
    ///   <para>"NDVI_16days_250m_t Sensor hosted by MODIS-TerraProduct_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_t_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_t_Sensor_1</seealso>
    let NDVI_16days_250m_t_Sensor_1 =
        Prefixed_Name(vas, "NDVI_16days_250m_t_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_500m_MODIS-Aqua_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    ///   <para>"16 days temporality, 500 m resolution, product MYD13A1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Sensor that takes NDVI measurements from MODIS-Aqua."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_MODIS-Aqua_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_MODIS-Aqua_Observation</seealso>
    let NDVI_16days_500m_MODIS_Aqua_Observation =
        Prefixed_Name(vas, "NDVI_16days_500m_MODIS-Aqua_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_500m_MODIS-Terra_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"16 days temporality, 500 m resolution. Product  MYD13A1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Sensor that takes NDVI measurements from MODIS-Terra."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_MODIS-Terra_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_MODIS-Terra_Observation</seealso>
    let NDVI_16days_500m_MODIS_Terra_Observation =
        Prefixed_Name(vas, "NDVI_16days_500m_MODIS-Terra_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_500m_a_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_MODIS-Aqua</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"NDVI_16days_500m_a Sensor hosted by MODIS-Aqua Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_a_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_a_Sensor_1</seealso>
    let NDVI_16days_500m_a_Sensor_1 =
        Prefixed_Name(vas, "NDVI_16days_500m_a_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_16days_500m_t_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Terra</para>
    ///   <para>"NDVI_16days_500m_t Sensor hosted by MODIS-TerraProduct_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_t_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_t_Sensor_1</seealso>
    let NDVI_16days_500m_t_Sensor_1 =
        Prefixed_Name(vas, "NDVI_16days_500m_t_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_L8_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes NDVI measurements from Landsat-8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L8_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L8_Observation</seealso>
    let NDVI_L8_Observation = Prefixed_Name(vas, "NDVI_L8_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:NDVI_L8_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-8</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"NDVI_L8 Sensor hosted by Landsat-8 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L8_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L8_Sensor_1</seealso>
    let NDVI_L8_Sensor_1 = Prefixed_Name(vas, "NDVI_L8_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:NDVI_L9_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes NDVI measurements from Landsat-9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L9_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L9_Observation</seealso>
    let NDVI_L9_Observation = Prefixed_Name(vas, "NDVI_L9_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:NDVI_L9_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Landsat-9</para>
    ///   <para>"NDVI_L9 Sensor hosted by Landsat-9 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L9_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L9_Sensor_1</seealso>
    let NDVI_L9_Sensor_1 = Prefixed_Name(vas, "NDVI_L9_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:NDVI_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Normalized Difference Vegetation Index (NDVI) sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_Result</seealso>
    let NDVI_Result = Prefixed_Name(vas, "NDVI_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:NDVI_S2_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    ///   <para>"Sensor that takes NDVI measurements from Sentinel-2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_S2_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_S2_Observation</seealso>
    let NDVI_S2_Observation = Prefixed_Name(vas, "NDVI_S2_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:NDVI_S2_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Sentinel-2</para>
    ///   <para>"NDVI_S2 Sensor hosted by Sentinel-2 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_S2_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_S2_Sensor_1</seealso>
    let NDVI_S2_Sensor_1 = Prefixed_Name(vas, "NDVI_S2_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_Satellite_Observation</seealso>
    let NDVI_Satellite_Observation =
        Prefixed_Name(vas, "NDVI_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_UAV_Multispectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_UAV_Multispectral</para>
    ///   <para>"Sensor NDVI UAV Multispectral hosted by UAV Multispectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_UAV_Multispectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_UAV_Multispectral_Sensor_1</seealso>
    let NDVI_UAV_Multispectral_Sensor_1 =
        Prefixed_Name(vas, "NDVI_UAV_Multispectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI).  Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_UAV_Observation</seealso>
    let NDVI_UAV_Observation =
        Prefixed_Name(vas, "NDVI_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_diary_500m_MODIS-Aqua_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Diary temporality, 500 m resolution, product MYD09GA_006_NDVI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    ///   <para>"Sensor that takes NDVI measurements from MODIS-Aqua."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_MODIS-Aqua_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_MODIS-Aqua_Observation</seealso>
    let NDVI_diary_500m_MODIS_Aqua_Observation =
        Prefixed_Name(vas, "NDVI_diary_500m_MODIS-Aqua_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_diary_500m_MODIS-Terra_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Daily temporality, 500 m resolution.  Product MYD09GA_006_NDVI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Normalized Difference Vegetation Index (NDVI)."</para>
    ///   <para>"Sensor that takes NDVI measurements from MODIS-Terra."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_MODIS-Terra_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_MODIS-Terra_Observation</seealso>
    let NDVI_diary_500m_MODIS_Terra_Observation =
        Prefixed_Name(vas, "NDVI_diary_500m_MODIS-Terra_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_diary_500m_a_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_MODIS-Aqua</para>
    ///   <para>"NDVI_diary_500m_a Sensor hosted by MODIS-Aqua Product_11"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_a_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_a_Sensor_1</seealso>
    let NDVI_diary_500m_a_Sensor_1 =
        Prefixed_Name(vas, "NDVI_diary_500m_a_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDVI_diary_500m_t_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_MODIS-Terra</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"NDVI_diary_500m_t Sensor hosted by MODIS-TerraProduct_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_t_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_t_Sensor_1</seealso>
    let NDVI_diary_500m_t_Sensor_1 =
        Prefixed_Name(vas, "NDVI_diary_500m_t_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDWI_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by NDWI sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_Result</seealso>
    let NDWI_Result = Prefixed_Name(vas, "NDWI_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDWI_UAV_Hyperspectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Hyperspectral</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor NDWI UAV Hyperspectral hosted by UAV Hyperspectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_UAV_Hyperspectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_UAV_Hyperspectral_Sensor_1</seealso>
    let NDWI_UAV_Hyperspectral_Sensor_1 =
        Prefixed_Name(vas, "NDWI_UAV_Hyperspectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NDWI_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to NDWI – Normalized Difference Water Index. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_UAV_Observation</seealso>
    let NDWI_UAV_Observation =
        Prefixed_Name(vas, "NDWI_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:NRI_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that normally is obtained by NRI sensors.  Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_Result</seealso>
    let NRI_Result = Prefixed_Name(vas, "NRI_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:NRI_UAV_Hyperspectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_UAV_Hyperspectral</para>
    ///   <para>"Sensor NRI UAV Hyperspectral hosted by UAV Hyperspectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_UAV_Hyperspectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_UAV_Hyperspectral_Sensor_1</seealso>
    let NRI_UAV_Hyperspectral_Sensor_1 =
        Prefixed_Name(vas, "NRI_UAV_Hyperspectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:NRI_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to NRI (Nitrogen Reflectance Index).Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_UAV_Observation</seealso>
    let NRI_UAV_Observation = Prefixed_Name(vas, "NRI_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Nitrogen_Concentration_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Nitrogen dioxide concentration (mg/g)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Concentration_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Concentration_Observation</seealso>
    let Nitrogen_Concentration_Observation =
        Prefixed_Name(vas, "Nitrogen_Concentration_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Nitrogen_Concentration_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by N2 (nitrogene dioxide) sensors. Unit of measure Milligram per Gram."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Concentration_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Concentration_Result</seealso>
    let Nitrogen_Concentration_Result =
        Prefixed_Name(vas, "Nitrogen_Concentration_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Nitrogen_Reflectance_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Nitrogen Reflectance Index (NRI) is a spectral index designed to estimate the nitrogen status of vegetation using reflectance measurements in the visible region. It exploits the sensitivity of chlorophyll‐related absorption features to nitrogen concentration."</para>
    /// labels<para>"NRI"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Reflectance_Index">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Reflectance_Index</seealso>
    let Nitrogen_Reflectance_Index =
        Prefixed_Name(vas, "Nitrogen_Reflectance_Index") |> PrefixedName

    /// <summary>
    ///   <para>vas:Non-irrigated_arable_land</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Land_Cover_Classes</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Class Level 3 CORINE Land Cover - CLC"</para>
    /// labels<para>"Non-irrigated arable land"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Non-irrigated_arable_land">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Non-irrigated_arable_land</seealso>
    let Non_irrigated_arable_land =
        Prefixed_Name(vas, "Non-irrigated_arable_land") |> PrefixedName

    /// <summary>
    ///   <para>vas:Normalized_Difference_Water_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>"NDWI – Normalized Difference Water Index
    /// Estimates leaf water content and moisture conditions using narrowband reflectance in the NIR and SWIR (or Green–NIR). It is sensitive to vegetation water status and widely used in stress detection."</para>
    /// labels<para>"NDWI"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Normalized_Difference_Water_Index">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Normalized_Difference_Water_Index</seealso>
    let Normalized_Difference_Water_Index =
        Prefixed_Name(vas, "Normalized_Difference_Water_Index") |> PrefixedName

    /// <summary>
    ///   <para>vas:ORTHOPHOTO_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Orthophoto. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#ORTHOPHOTO_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#ORTHOPHOTO_UAV_Observation</seealso>
    let ORTHOPHOTO_UAV_Observation =
        Prefixed_Name(vas, "ORTHOPHOTO_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:OTCI_S3_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to OLCI Terrestrial Chlorophyll Index (OTCI) (300 m de resolución)). µmol of chlorophyll per m²µ."</para>
    ///   <para>"Sensor that takes OTCI measurements from Sentinel-3."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#OTCI_S3_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#OTCI_S3_Observation</seealso>
    let OTCI_S3_Observation = Prefixed_Name(vas, "OTCI_S3_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:OTCI_S3_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Sentinel-3_OLCI</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"OTCI_S3 Sensor hosted by Sentinel-3_OLCI Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#OTCI_S3_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#OTCI_S3_Sensor_1</seealso>
    let OTCI_S3_Sensor_1 = Prefixed_Name(vas, "OTCI_S3_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Orthophoto_UAV_RGB_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_UAV_RGB</para>
    ///   <para>"Sensor Orthophoto UAV RGB  hosted by UAV RGB 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Orthophoto_UAV_RGB_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Orthophoto_UAV_RGB_Sensor_1</seealso>
    let Orthophoto_UAV_RGB_Sensor_1 =
        Prefixed_Name(vas, "Orthophoto_UAV_RGB_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:PWC_METEOSAT_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes PWC measurements from METEOSAT."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to precipitable_water_content . Unit of measure Millimetre (mm).."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_METEOSAT_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_METEOSAT_Observation</seealso>
    let PWC_METEOSAT_Observation =
        Prefixed_Name(vas, "PWC_METEOSAT_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:PWC_METEOSAT_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_METEOSAT</para>
    ///   <para>"PWC_METEOSAT Sensor hosted by METEOSAT_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_METEOSAT_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_METEOSAT_Sensor_1</seealso>
    let PWC_METEOSAT_Sensor_1 =
        Prefixed_Name(vas, "PWC_METEOSAT_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:PWC_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by PWC_METEOSAT sensors. Precipitable Water Content Result.  Unit of measure Millimetre (mm)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_Result</seealso>
    let PWC_Result = Prefixed_Name(vas, "PWC_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Permanently_irrigated_land</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Land_Cover_Classes</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Class Level 3 CORINE Land Cover - CLC"</para>
    /// labels<para>"Permanently irrigated land"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Permanently_irrigated_land">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Permanently_irrigated_land</seealso>
    let Permanently_irrigated_land =
        Prefixed_Name(vas, "Permanently_irrigated_land") |> PrefixedName

    /// <summary>
    ///   <para>vas:Pluviometer_AEMET_Sensor_UTIEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://aemet.linkeddata.es/ontology/Pluviometer&gt;</para>
    ///   <para>"Sensor Pluviometer_AEMET hosted by AEMET_UTIEL_Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Pluviometer_AEMET_Sensor_UTIEL">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Pluviometer_AEMET_Sensor_UTIEL</seealso>
    let Pluviometer_AEMET_Sensor_UTIEL =
        Prefixed_Name(vas, "Pluviometer_AEMET_Sensor_UTIEL") |> PrefixedName

    /// <summary>
    ///   <para>vas:Precipitation_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to precipitation (mm)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Precipitation_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Precipitation_AEMET_Observation</seealso>
    let Precipitation_AEMET_Observation =
        Prefixed_Name(vas, "Precipitation_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Precipitation_AEMET_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Pluviometer_AEMET sensors in AEMET Staion. Unit of measure Millimetre (mm)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Precipitation_AEMET_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Precipitation_AEMET_Result</seealso>
    let Precipitation_AEMET_Result =
        Prefixed_Name(vas, "Precipitation_AEMET_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:RAD_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents solar radiation stations"</para>
    /// labels<para>"RAD_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RAD_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RAD_Station</seealso>
    let RAD_Station = Prefixed_Name(vas, "RAD_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:RAD_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RAD_Station</para>
    ///   <para>"RAD Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RAD_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RAD_Station_1</seealso>
    let RAD_Station_1 = Prefixed_Name(vas, "RAD_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:RN_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes "surface net radiation" measurements in RAD Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RN_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RN_g</seealso>
    let RN_g = Prefixed_Name(vas, "RN_g") |> PrefixedName
    /// <summary>
    ///   <para>vas:RN_g_RAD_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RN_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"RN_g_RAD Sensor hosted by RAD_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RN_g_RAD_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RN_g_RAD_Sensor_1</seealso>
    let RN_g_RAD_Sensor_1 = Prefixed_Name(vas, "RN_g_RAD_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_Landsat-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite Landsat-8. Observes Chl, EVI, FAPAR, LAI, LST, NDVI, ,SAVI, SR, TDVI ..."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Landsat-8">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Landsat-8</seealso>
    let RS_Landsat_8 = Prefixed_Name(vas, "RS_Landsat-8") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_Landsat-9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite Lansat-9.Observes Chl, EVI, FAPAR, LAI, LST, NDVI, ,SAVI, SR, TDVI ..."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Landsat-9">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Landsat-9</seealso>
    let RS_Landsat_9 = Prefixed_Name(vas, "RS_Landsat-9") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_METEOSAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite METEOSAT. Observes CloudMask, CloudType and PWC."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_METEOSAT">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_METEOSAT</seealso>
    let RS_METEOSAT = Prefixed_Name(vas, "RS_METEOSAT") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_MODIS-Aqua</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite MODIS-Aqua. Observes EVI , FAPAR, LST, NDVI, ..."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_MODIS-Aqua">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_MODIS-Aqua</seealso>
    let RS_MODIS_Aqua = Prefixed_Name(vas, "RS_MODIS-Aqua") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_MODIS-Terra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite MODIS-Terra. Observes EVI , FAPAR, LST, NDVI,  ..."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_MODIS-Terra">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_MODIS-Terra</seealso>
    let RS_MODIS_Terra = Prefixed_Name(vas, "RS_MODIS-Terra") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_SMAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of SMAP. Observes Soil Moisture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_SMAP">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_SMAP</seealso>
    let RS_SMAP = Prefixed_Name(vas, "RS_SMAP") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_SMOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite SMOS. Observes AGB, DroughtIndex, Soil Moisture."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_SMOS">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_SMOS</seealso>
    let RS_SMOS = Prefixed_Name(vas, "RS_SMOS") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_Sentinel-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite Sentinel 1 or S1. Observes Soil Moisture."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-1</seealso>
    let RS_Sentinel_1 = Prefixed_Name(vas, "RS_Sentinel-1") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_Sentinel-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite Sentinel 2 or  S2. Observes Chl, EVI, FAPAR, LAI, LandCover, NDVI, SAVI, SR ..."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-2</seealso>
    let RS_Sentinel_2 = Prefixed_Name(vas, "RS_Sentinel-2") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_Sentinel-3_OLCI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite Sentinel 3 ( S3)  OLCI. Observes FAPAR , Chl."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-3_OLCI">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-3_OLCI</seealso>
    let RS_Sentinel_3_OLCI = Prefixed_Name(vas, "RS_Sentinel-3_OLCI") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_Sentinel-3_SLSTR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of satellite Sentinel 3 ( S3)  SLSTR. Observes LST."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-3_SLSTR">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-3_SLSTR</seealso>
    let RS_Sentinel_3_SLSTR = Prefixed_Name(vas, "RS_Sentinel-3_SLSTR") |> PrefixedName

    /// <summary>
    ///   <para>vas:RS_UAV_Hyperspectral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of RS_UAV_Hyperspectral. Observes  NRI,  CRI, NDWI, AGB. DiseaseStatus."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Hyperspectral">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Hyperspectral</seealso>
    let RS_UAV_Hyperspectral =
        Prefixed_Name(vas, "RS_UAV_Hyperspectral") |> PrefixedName

    /// <summary>
    ///   <para>vas:RS_UAV_LiDAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of RS_UAV_LiDAR. Observes  CHM, DTM, DSM. DBH, AGB."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_LiDAR">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_LiDAR</seealso>
    let RS_UAV_LiDAR = Prefixed_Name(vas, "RS_UAV_LiDAR") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_UAV_Microwave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of RS_UAV_Microwave. Observes SM."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Microwave">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Microwave</seealso>
    let RS_UAV_Microwave = Prefixed_Name(vas, "RS_UAV_Microwave") |> PrefixedName

    /// <summary>
    ///   <para>vas:RS_UAV_Multispectral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of RS_UAV_Multispectral. Observes  EVI, FAPAR, LAI,  NDVI, ,SAVI y SR."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Multispectral">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Multispectral</seealso>
    let RS_UAV_Multispectral =
        Prefixed_Name(vas, "RS_UAV_Multispectral") |> PrefixedName

    /// <summary>
    ///   <para>vas:RS_UAV_RGB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of RS_UAV_RGB. Observes  ORTHOPHOTO"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_RGB">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_RGB</seealso>
    let RS_UAV_RGB = Prefixed_Name(vas, "RS_UAV_RGB") |> PrefixedName
    /// <summary>
    ///   <para>vas:RS_UAV_Thermal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the general sensorization of RS_UAV_Thermal. Observes  LST."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Thermal">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Thermal</seealso>
    let RS_UAV_Thermal = Prefixed_Name(vas, "RS_UAV_Thermal") |> PrefixedName
    /// <summary>
    ///   <para>vas:Radiation_Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents all Radiation properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Radiation_Property">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Radiation_Property</seealso>
    let Radiation_Property = Prefixed_Name(vas, "Radiation_Property") |> PrefixedName

    /// <summary>
    ///   <para>vas:Remote_Sensing_Satellites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Satellite  Sensors (remote sensing)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Remote_Sensing_Satellites">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Remote_Sensing_Satellites</seealso>
    let Remote_Sensing_Satellites =
        Prefixed_Name(vas, "Remote_Sensing_Satellites") |> PrefixedName

    /// <summary>
    ///   <para>vas:Remote_Sensing_UAVs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Drone Sensors (remote sensing)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Remote_Sensing_UAVs">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Remote_Sensing_UAVs</seealso>
    let Remote_Sensing_UAVs = Prefixed_Name(vas, "Remote_Sensing_UAVs") |> PrefixedName

    /// <summary>
    ///   <para>vas:Roughness_SMOS_CATDS_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_SMOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Roughness_SMOS_CATDS Sensor hosted by SMOS Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Roughness_SMOS_CATDS_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Roughness_SMOS_CATDS_Sensor_1</seealso>
    let Roughness_SMOS_CATDS_Sensor_1 =
        Prefixed_Name(vas, "Roughness_SMOS_CATDS_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SAVI_L8_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes SAVI measurements from Landsat-8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Soil Adjusted Vegetation Index (SAVI)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L8_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L8_Observation</seealso>
    let SAVI_L8_Observation = Prefixed_Name(vas, "SAVI_L8_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SAVI_L8_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-8</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SAVI_L8 Sensor hosted by Landsat-8 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L8_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L8_Sensor_1</seealso>
    let SAVI_L8_Sensor_1 = Prefixed_Name(vas, "SAVI_L8_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:SAVI_L9_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Soil Adjusted Vegetation Index (SAVI)."</para>
    ///   <para>"Sensor that takes SAVI measurements from Landsat-9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L9_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L9_Observation</seealso>
    let SAVI_L9_Observation = Prefixed_Name(vas, "SAVI_L9_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SAVI_L9_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-9</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SAVI_L9 Sensor hosted by Landsat-9 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L9_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L9_Sensor_1</seealso>
    let SAVI_L9_Sensor_1 = Prefixed_Name(vas, "SAVI_L9_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:SAVI_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Soil Adjusted Vegetation Index (SAVI) sensors.  Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_Result</seealso>
    let SAVI_Result = Prefixed_Name(vas, "SAVI_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:SAVI_S2_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Soil Adjusted Vegetation Index (SAVI)."</para>
    ///   <para>"Sensor that takes SAVI measurements from Sentinel-2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_S2_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_S2_Observation</seealso>
    let SAVI_S2_Observation = Prefixed_Name(vas, "SAVI_S2_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SAVI_S2_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Sentinel-2</para>
    ///   <para>"SAVI_S2_Sensor hosted by Sentinel-2 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_S2_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_S2_Sensor_1</seealso>
    let SAVI_S2_Sensor_1 = Prefixed_Name(vas, "SAVI_S2_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SAVI_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Soil Adjusted Vegetation Index (SAVI). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_Satellite_Observation</seealso>
    let SAVI_Satellite_Observation =
        Prefixed_Name(vas, "SAVI_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SAVI_UAV_Multispectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Multispectral</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor SAVI UAV Multispectral hosted by UAV Multispectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_UAV_Multispectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_UAV_Multispectral_Sensor_1</seealso>
    let SAVI_UAV_Multispectral_Sensor_1 =
        Prefixed_Name(vas, "SAVI_UAV_Multispectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SAVI_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Soil Adjusted Vegetation Index (SAVI).  Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_UAV_Observation</seealso>
    let SAVI_UAV_Observation =
        Prefixed_Name(vas, "SAVI_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SMAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SMAP"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP</seealso>
    let SMAP = Prefixed_Name(vas, "SMAP") |> PrefixedName
    /// <summary>
    ///   <para>vas:SMAP_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents SMAP satellite Products"</para>
    /// labels<para>"SMAP_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Product</seealso>
    let SMAP_Product = Prefixed_Name(vas, "SMAP_Product") |> PrefixedName
    /// <summary>
    ///   <para>vas:SMAP_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SMAP_Product</para>
    ///   <para>"SMAP Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Product_1</seealso>
    let SMAP_Product_1 = Prefixed_Name(vas, "SMAP_Product_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:SMAP_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SMAP</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SMAP satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Satellite</seealso>
    let SMAP_Satellite = Prefixed_Name(vas, "SMAP_Satellite") |> PrefixedName
    /// <summary>
    ///   <para>vas:SMOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SMOS"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS</seealso>
    let SMOS = Prefixed_Name(vas, "SMOS") |> PrefixedName
    /// <summary>
    ///   <para>vas:SMOS_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents SMOS satellite Products"</para>
    /// labels<para>"SMOS_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Product</seealso>
    let SMOS_Product = Prefixed_Name(vas, "SMOS_Product") |> PrefixedName
    /// <summary>
    ///   <para>vas:SMOS_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SMOS_Product</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SMOS Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Product_1</seealso>
    let SMOS_Product_1 = Prefixed_Name(vas, "SMOS_Product_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:SMOS_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SMOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SMOS satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Satellite</seealso>
    let SMOS_Satellite = Prefixed_Name(vas, "SMOS_Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_NRT_SMOS_ESA_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_SMOS</para>
    ///   <para>"SM_NRT_SMOS_ESA Sensor hosted by SMOS Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_NRT_SMOS_ESA_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_NRT_SMOS_ESA_Sensor_1</seealso>
    let SM_NRT_SMOS_ESA_Sensor_1 =
        Prefixed_Name(vas, "SM_NRT_SMOS_ESA_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Soil Moisture (SM). Unit of measure Cubic Metre per Cubic Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Observation</seealso>
    let SM_Observation = Prefixed_Name(vas, "SM_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by SM (Soil Moisture) sensors. Unit of measure Cubic Metre per Cubic Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Result</seealso>
    let SM_Result = Prefixed_Name(vas, "SM_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_S1_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes SM measurements from S1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_S1_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_S1_Observation</seealso>
    let SM_S1_Observation = Prefixed_Name(vas, "SM_S1_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_S1_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Sentinel-1</para>
    ///   <para>"SM_S1 Sensor hosted by Sentinel-1 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_S1_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_S1_Sensor_1</seealso>
    let SM_S1_Sensor_1 = Prefixed_Name(vas, "SM_S1_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMAP-S1_3km_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_SMAP</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SM_SMAP-S1_3km Sensor hosted by SMAP Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP-S1_3km_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP-S1_3km_Sensor_1</seealso>
    let SM_SMAP_S1_3km_Sensor_1 =
        Prefixed_Name(vas, "SM_SMAP-S1_3km_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMAP-S1_9km_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_SMAP</para>
    ///   <para>"SM_SMAP-S1_9km Sensor hosted by SMAP Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP-S1_9km_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP-S1_9km_Sensor_1</seealso>
    let SM_SMAP_S1_9km_Sensor_1 =
        Prefixed_Name(vas, "SM_SMAP-S1_9km_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMAP_36km_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soil Moisture Sensor. Resolution of 36 km for Europe from SMAP."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Daily temporality, 36 km resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_36km_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_36km_Observation</seealso>
    let SM_SMAP_36km_Observation =
        Prefixed_Name(vas, "SM_SMAP_36km_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMAP_36km_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_SMAP</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SM_SMAP_36km Sensor hosted by SMAP Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_36km_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_36km_Sensor_1</seealso>
    let SM_SMAP_36km_Sensor_1 =
        Prefixed_Name(vas, "SM_SMAP_36km_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMAP_S1_3km_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Daily temporality, 3 km resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]"</para>
    ///   <para>"Soil Moisture Sensor. Resolution of 3 km for Europe from SMAP."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_S1_3km_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_S1_3km_Observation</seealso>
    let SM_SMAP_S1_3km_Observation =
        Prefixed_Name(vas, "SM_SMAP_S1_3km_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMAP_S1_9km_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]"</para>
    ///   <para>"Daily temporality, 9 km resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Soil Moisture Sensor. Resolution of 9 km for Europe from SMAP."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_S1_9km_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_S1_9km_Observation</seealso>
    let SM_SMAP_S1_9km_Observation =
        Prefixed_Name(vas, "SM_SMAP_S1_9km_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMOS-IC_CATDS_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_SMOS</para>
    ///   <para>"SM_SMOS-IC_CATDS Sensor hosted by SMOS Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS-IC_CATDS_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS-IC_CATDS_Sensor_1</seealso>
    let SM_SMOS_IC_CATDS_Sensor_1 =
        Prefixed_Name(vas, "SM_SMOS-IC_CATDS_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMOS_BEC_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_SMOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SM_SMOS_BEC Sensor hosted by SMOS Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_BEC_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_BEC_Sensor_1</seealso>
    let SM_SMOS_BEC_Sensor_1 =
        Prefixed_Name(vas, "SM_SMOS_BEC_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMOS_ESA_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soil Moisture Sensor. Resolution of 25 km for Europe from SMOS."</para>
    ///   <para>"Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]"</para>
    ///   <para>"Daily temporality, resolution 25 km"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_ESA_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_ESA_Observation</seealso>
    let SM_SMOS_ESA_Observation =
        Prefixed_Name(vas, "SM_SMOS_ESA_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_SMOS_ESA_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_SMOS</para>
    ///   <para>"SM_SMOS_ESA Sensor hosted by SMOS Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_ESA_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_ESA_Sensor_1</seealso>
    let SM_SMOS_ESA_Sensor_1 =
        Prefixed_Name(vas, "SM_SMOS_ESA_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Soil Moisture (SM). Unit of measure Cubic Metre per Cubic Metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Satellite_Observation</seealso>
    let SM_Satellite_Observation =
        Prefixed_Name(vas, "SM_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Soil Moisture stations"</para>
    /// labels<para>"SM_Station"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station</seealso>
    let SM_Station = Prefixed_Name(vas, "SM_Station") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_Station_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SM_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SM Station number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_1</seealso>
    let SM_Station_1 = Prefixed_Name(vas, "SM_Station_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_Station_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SM_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SM Station number 2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_2</seealso>
    let SM_Station_2 = Prefixed_Name(vas, "SM_Station_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_Station_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SM_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SM Station number 3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_3</seealso>
    let SM_Station_3 = Prefixed_Name(vas, "SM_Station_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_Station_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SM_Station</para>
    ///   <para>"SM Station number 4"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_4</seealso>
    let SM_Station_4 = Prefixed_Name(vas, "SM_Station_4") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_Station_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SM_Station</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SM Station number 5"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_5">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_5</seealso>
    let SM_Station_5 = Prefixed_Name(vas, "SM_Station_5") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_Station_6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SM_Station</para>
    ///   <para>"SM Station number 6"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_6">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_6</seealso>
    let SM_Station_6 = Prefixed_Name(vas, "SM_Station_6") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_UAV_Microwave_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Microwave</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor SM UAV Microwave hosted by UAV Microwave 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_UAV_Microwave_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_UAV_Microwave_Sensor_1</seealso>
    let SM_UAV_Microwave_Sensor_1 =
        Prefixed_Name(vas, "SM_UAV_Microwave_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Soil Moisture (SM). Unit of measure cubic metre per cubic metre."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_UAV_Observation</seealso>
    let SM_UAV_Observation = Prefixed_Name(vas, "SM_UAV_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_freeze_and_Thaw_SMOS_ESA_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_SMOS</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SM_freeze_and_Thaw_SMOS_ESA Sensor hosted by SMOS Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_freeze_and_Thaw_SMOS_ESA_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_freeze_and_Thaw_SMOS_ESA_Sensor_1</seealso>
    let SM_freeze_and_Thaw_SMOS_ESA_Sensor_1 =
        Prefixed_Name(vas, "SM_freeze_and_Thaw_SMOS_ESA_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SM_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes Soil Moisture measurements"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g</seealso>
    let SM_g = Prefixed_Name(vas, "SM_g") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_g_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SM_g</para>
    ///   <para>"Sensor SM_g hosted by SM_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_1</seealso>
    let SM_g_Sensor_1 = Prefixed_Name(vas, "SM_g_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_g_Sensor_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SM_g</para>
    ///   <para>"Sensor SM_g hosted by SM_Station_2"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_2</seealso>
    let SM_g_Sensor_2 = Prefixed_Name(vas, "SM_g_Sensor_2") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_g_Sensor_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SM_g</para>
    ///   <para>"Sensor SM_g hosted by SM_Station_3"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_3">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_3</seealso>
    let SM_g_Sensor_3 = Prefixed_Name(vas, "SM_g_Sensor_3") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_g_Sensor_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SM_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor SM_g hosted by SM_Station_4"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_4">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_4</seealso>
    let SM_g_Sensor_4 = Prefixed_Name(vas, "SM_g_Sensor_4") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_g_Sensor_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SM_g</para>
    ///   <para>"Sensor SM_g hosted by SM_Station_5"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_5">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_5</seealso>
    let SM_g_Sensor_5 = Prefixed_Name(vas, "SM_g_Sensor_5") |> PrefixedName
    /// <summary>
    ///   <para>vas:SM_g_Sensor_6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SM_g</para>
    ///   <para>"Sensor SM_g hosted by SM_Station_6"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_6">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_6</seealso>
    let SM_g_Sensor_6 = Prefixed_Name(vas, "SM_g_Sensor_6") |> PrefixedName
    /// <summary>
    ///   <para>vas:SR_L8_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Simple Ratio (SR). Dimensionless."</para>
    ///   <para>"Sensor that takes SR measurements from L8."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L8_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L8_Observation</seealso>
    let SR_L8_Observation = Prefixed_Name(vas, "SR_L8_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SR_L8_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-8</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor SR_L8 hosted by Landsat-8 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L8_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L8_Sensor_1</seealso>
    let SR_L8_Sensor_1 = Prefixed_Name(vas, "SR_L8_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:SR_L9_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes SR measurements from L9."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Class that represents observations related to Simple Ratio (SR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L9_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L9_Observation</seealso>
    let SR_L9_Observation = Prefixed_Name(vas, "SR_L9_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SR_L9_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_Landsat-9</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"SR_L9 Sensor hosted by Landsat-9 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L9_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L9_Sensor_1</seealso>
    let SR_L9_Sensor_1 = Prefixed_Name(vas, "SR_L9_Sensor_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:SR_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Simple Ratio (SR) sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_Result</seealso>
    let SR_Result = Prefixed_Name(vas, "SR_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:SR_S2_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Simple Ratio (SR). Dimensionless."</para>
    ///   <para>"Sensor that takes SR measurements from S2."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_S2_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_S2_Observation</seealso>
    let SR_S2_Observation = Prefixed_Name(vas, "SR_S2_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SR_S2_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:RS_Sentinel-2</para>
    ///   <para>"SR_S2 Sensor hosted by Sentinel-2 Product_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_S2_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_S2_Sensor_1</seealso>
    let SR_S2_Sensor_1 = Prefixed_Name(vas, "SR_S2_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SR_Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Simple Ratio (SR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_Satellite_Observation</seealso>
    let SR_Satellite_Observation =
        Prefixed_Name(vas, "SR_Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:SR_UAV_Multispectral_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:RS_UAV_Multispectral</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor SR UAV Multispectral hosted by UAV Multispectral 1."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_UAV_Multispectral_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_UAV_Multispectral_Sensor_1</seealso>
    let SR_UAV_Multispectral_Sensor_1 =
        Prefixed_Name(vas, "SR_UAV_Multispectral_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SR_UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Simple Ratio (SR). Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_UAV_Observation</seealso>
    let SR_UAV_Observation = Prefixed_Name(vas, "SR_UAV_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:SW_down_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes "surface downwelling shortwave flux in air" measurements in RAD Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_down_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_down_g</seealso>
    let SW_down_g = Prefixed_Name(vas, "SW_down_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:SW_down_g_RAD_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:SW_down_g</para>
    ///   <para>"SW_down_g_RAD Sensor hosted by RAD_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_down_g_RAD_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_down_g_RAD_Sensor_1</seealso>
    let SW_down_g_RAD_Sensor_1 =
        Prefixed_Name(vas, "SW_down_g_RAD_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:SW_up_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes "upwelling shortwave flux in air" measurements in RAD Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_up_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_up_g</seealso>
    let SW_up_g = Prefixed_Name(vas, "SW_up_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:SW_up_g_RAD_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:SW_up_g</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor SW_up_g_RAD hosted by RAD_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_up_g_RAD_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_up_g_RAD_Sensor_1</seealso>
    let SW_up_g_RAD_Sensor_1 =
        Prefixed_Name(vas, "SW_up_g_RAD_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Satellite"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite</seealso>
    let Satellite = Prefixed_Name(vas, "Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:Satellite_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Observation collected by satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite_Observation</seealso>
    let Satellite_Observation =
        Prefixed_Name(vas, "Satellite_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Satellite_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Satellite Product is a processed dataset generated from raw satellite measurements, typically including radiometric, geometric, and atmospheric corrections. These products provide georeferenced environmental variables (e.g., reflectance, vegetation indices, land surface temperature, soil moisture) at defined spatial, temporal, and spectral resolutions, and serve as inputs for environmental monitoring, modelling, and validation workflows."</para>
    /// labels<para>"Satellite Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite_Product</seealso>
    let Satellite_Product = Prefixed_Name(vas, "Satellite_Product") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sclerophyllous_vegetation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Land_Cover_Classes</para>
    ///   <para>"Class Level 3 CORINE Land Cover - CLC"</para>
    /// labels<para>"Sclerophyllous vegetation"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sclerophyllous_vegetation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sclerophyllous_vegetation</seealso>
    let Sclerophyllous_vegetation =
        Prefixed_Name(vas, "Sclerophyllous_vegetation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sensible_Heat_Flux_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Sensible heat flux (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sensible_Heat_Flux_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sensible_Heat_Flux_Observation</seealso>
    let Sensible_Heat_Flux_Observation =
        Prefixed_Name(vas, "Sensible_Heat_Flux_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sensible_Heat_Flux_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Hs (sensible heat flux) sensors. Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sensible_Heat_Flux_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sensible_Heat_Flux_Result</seealso>
    let Sensible_Heat_Flux_Result =
        Prefixed_Name(vas, "Sensible_Heat_Flux_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sentinel-1"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1</seealso>
    let Sentinel_1 = Prefixed_Name(vas, "Sentinel-1") |> PrefixedName
    /// <summary>
    ///   <para>vas:Sentinel-1_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Sentinel-1 satellite Products"</para>
    /// labels<para>"Sentinel-1_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Product</seealso>
    let Sentinel_1_Product = Prefixed_Name(vas, "Sentinel-1_Product") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-1_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Sentinel-1_Product</para>
    ///   <para>"Sentinel-1 Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Product_1</seealso>
    let Sentinel_1_Product_1 =
        Prefixed_Name(vas, "Sentinel-1_Product_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-1_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Sentinel-1</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sentinel 1 satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Satellite</seealso>
    let Sentinel_1_Satellite =
        Prefixed_Name(vas, "Sentinel-1_Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sentinel-2"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2</seealso>
    let Sentinel_2 = Prefixed_Name(vas, "Sentinel-2") |> PrefixedName
    /// <summary>
    ///   <para>vas:Sentinel-2_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Sentinel-2 satellite Products"</para>
    /// labels<para>"Sentinel-2_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Product</seealso>
    let Sentinel_2_Product = Prefixed_Name(vas, "Sentinel-2_Product") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-2_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Sentinel-2_Product</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sentinel-2 Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Product_1</seealso>
    let Sentinel_2_Product_1 =
        Prefixed_Name(vas, "Sentinel-2_Product_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-2_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Sentinel-2</para>
    ///   <para>"Sentinel 2 satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Satellite</seealso>
    let Sentinel_2_Satellite =
        Prefixed_Name(vas, "Sentinel-2_Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-3_OLCI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sentinel-3_OLCI"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI</seealso>
    let Sentinel_3_OLCI = Prefixed_Name(vas, "Sentinel-3_OLCI") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-3_OLCI_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Sentinel-3 OLCI satellite Products"</para>
    /// labels<para>"Sentinel-3_OLCI_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Product</seealso>
    let Sentinel_3_OLCI_Product =
        Prefixed_Name(vas, "Sentinel-3_OLCI_Product") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-3_OLCI_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Sentinel-3_OLCI_Product</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sentinel-3_OLCI Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Product_1</seealso>
    let Sentinel_3_OLCI_Product_1 =
        Prefixed_Name(vas, "Sentinel-3_OLCI_Product_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-3_OLCI_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Sentinel-3_OLCI</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sentinel 3 OLCI satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Satellite</seealso>
    let Sentinel_3_OLCI_Satellite =
        Prefixed_Name(vas, "Sentinel-3_OLCI_Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-3_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Sentinel-3 satellite Products"</para>
    /// labels<para>"Sentinel-3_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_Product</seealso>
    let Sentinel_3_Product = Prefixed_Name(vas, "Sentinel-3_Product") |> PrefixedName
    /// <summary>
    ///   <para>vas:Sentinel-3_SLSTR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sentinel-3_SLSTR"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR</seealso>
    let Sentinel_3_SLSTR = Prefixed_Name(vas, "Sentinel-3_SLSTR") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-3_SLSTR_Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents Sentinel-3 SLSTR satellite Products"</para>
    /// labels<para>"Sentinel-3_SLSTR_Product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Product">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Product</seealso>
    let Sentinel_3_SLSTR_Product =
        Prefixed_Name(vas, "Sentinel-3_SLSTR_Product") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-3_SLSTR_Product_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Sentinel-3_SLSTR_Product</para>
    ///   <para>"Sentinel-3_SLSTR Product number 1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Product_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Product_1</seealso>
    let Sentinel_3_SLSTR_Product_1 =
        Prefixed_Name(vas, "Sentinel-3_SLSTR_Product_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Sentinel-3_SLSTR_Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Sentinel-3_SLSTR</para>
    ///   <para>"Sentinel 3 SLSTR satellite."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Satellite">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Satellite</seealso>
    let Sentinel_3_SLSTR_Satellite =
        Prefixed_Name(vas, "Sentinel-3_SLSTR_Satellite") |> PrefixedName

    /// <summary>
    ///   <para>vas:Snapshot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Snapshot"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Snapshot">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Snapshot</seealso>
    let Snapshot = Prefixed_Name(vas, "Snapshot") |> PrefixedName
    /// <summary>
    ///   <para>vas:Soil_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Land Cover sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Soil_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Soil_Result</seealso>
    let Soil_Result = Prefixed_Name(vas, "Soil_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:SurfaceAlbedo_g_RAD_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;https://www.w3.org/2005/Incubator/ssn/ssnx/meteo/aws#Albedometer&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sensor SurfaceAlbedo_g_RAD hosted by RAD_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SurfaceAlbedo_g_RAD_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SurfaceAlbedo_g_RAD_Sensor_1</seealso>
    let SurfaceAlbedo_g_RAD_Sensor_1 =
        Prefixed_Name(vas, "SurfaceAlbedo_g_RAD_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Surface_Albedo_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Surface albedo (dimensionless)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Albedo_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Albedo_Observation</seealso>
    let Surface_Albedo_Observation =
        Prefixed_Name(vas, "Surface_Albedo_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Surface_Albedo_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by  SurfaceAlbedo sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Albedo_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Albedo_Result</seealso>
    let Surface_Albedo_Result =
        Prefixed_Name(vas, "Surface_Albedo_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Surface_Downwelling_Longwave_Flux_In_Air_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Surface Downwelling Longwave Flux In Air (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Longwave_Flux_In_Air_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Longwave_Flux_In_Air_Observation</seealso>
    let Surface_Downwelling_Longwave_Flux_In_Air_Observation =
        Prefixed_Name(vas, "Surface_Downwelling_Longwave_Flux_In_Air_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Surface_Downwelling_Longwave_Flux_In_Air_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by LW_down sensors.  Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Longwave_Flux_In_Air_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Longwave_Flux_In_Air_Result</seealso>
    let Surface_Downwelling_Longwave_Flux_In_Air_Result =
        Prefixed_Name(vas, "Surface_Downwelling_Longwave_Flux_In_Air_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Surface_Downwelling_Shortwave_Flux_In_Air_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Surface Downwelling Shortwave Flux In Air (W/m2)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Shortwave_Flux_In_Air_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Shortwave_Flux_In_Air_Observation</seealso>
    let Surface_Downwelling_Shortwave_Flux_In_Air_Observation =
        Prefixed_Name(vas, "Surface_Downwelling_Shortwave_Flux_In_Air_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Surface_Downwelling_Shortwave_Flux_In_Air_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by SW_down sensors. Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Shortwave_Flux_In_Air_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Shortwave_Flux_In_Air_Result</seealso>
    let Surface_Downwelling_Shortwave_Flux_In_Air_Result =
        Prefixed_Name(vas, "Surface_Downwelling_Shortwave_Flux_In_Air_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Surface_Net_Radiation_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Surface net radiation (W/m2)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Net_Radiation_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Net_Radiation_Observation</seealso>
    let Surface_Net_Radiation_Observation =
        Prefixed_Name(vas, "Surface_Net_Radiation_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Surface_Net_Radiation_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by RN sensors. Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Net_Radiation_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Net_Radiation_Result</seealso>
    let Surface_Net_Radiation_Result =
        Prefixed_Name(vas, "Surface_Net_Radiation_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to temperature in AEMET Station.  Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_AEMET_Observation</seealso>
    let Temperature_AEMET_Observation =
        Prefixed_Name(vas, "Temperature_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_EddyCovariance_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to temperature in EddyCovariance Station. Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_EddyCovariance_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_EddyCovariance_Observation</seealso>
    let Temperature_EddyCovariance_Observation =
        Prefixed_Name(vas, "Temperature_EddyCovariance_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to temperature. Celsius Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_Observation</seealso>
    let Temperature_Observation =
        Prefixed_Name(vas, "Temperature_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Termometer sensors. Unit of measure Degree Celsius."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_Result</seealso>
    let Temperature_Result = Prefixed_Name(vas, "Temperature_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_in_air_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_air_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_air_AEMET_Observation</seealso>
    let Temperature_in_air_AEMET_Observation =
        Prefixed_Name(vas, "Temperature_in_air_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_in_ground_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_AEMET_Observation</seealso>
    let Temperature_in_ground_AEMET_Observation =
        Prefixed_Name(vas, "Temperature_in_ground_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_in_ground_depth_05_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_depth_05_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_depth_05_AEMET_Observation</seealso>
    let Temperature_in_ground_depth_05_AEMET_Observation =
        Prefixed_Name(vas, "Temperature_in_ground_depth_05_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_in_ground_depth_20_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_depth_20_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_depth_20_AEMET_Observation</seealso>
    let Temperature_in_ground_depth_20_AEMET_Observation =
        Prefixed_Name(vas, "Temperature_in_ground_depth_20_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Temperature_in_ground_next_ground_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_next_ground_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_next_ground_AEMET_Observation</seealso>
    let Temperature_in_ground_next_ground_AEMET_Observation =
        Prefixed_Name(vas, "Temperature_in_ground_next_ground_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Thermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measures temperature in degrees Celsius"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer</seealso>
    let Thermometer = Prefixed_Name(vas, "Thermometer") |> PrefixedName

    /// <summary>
    ///   <para>vas:Thermometer_AEMET_Sensor_UTIEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://aemet.linkeddata.es/ontology/Thermometer&gt;</para>
    ///   <para>"Sensor Thermometer_AEMET hosted by AEMET_UTIEL_Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_AEMET_Sensor_UTIEL">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_AEMET_Sensor_UTIEL</seealso>
    let Thermometer_AEMET_Sensor_UTIEL =
        Prefixed_Name(vas, "Thermometer_AEMET_Sensor_UTIEL") |> PrefixedName

    /// <summary>
    ///   <para>vas:Thermometer_EddyCovariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor belongs to EddyCovariance Station. Measures temperature in degrees Celsius"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_EddyCovariance">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_EddyCovariance</seealso>
    let Thermometer_EddyCovariance =
        Prefixed_Name(vas, "Thermometer_EddyCovariance") |> PrefixedName

    /// <summary>
    ///   <para>vas:Thermometer_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Thermometer_EddyCovariance</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Thermometer_EddyCovariance Sensor hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_EddyCovariance_Sensor_1</seealso>
    let Thermometer_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "Thermometer_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:UAV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unmanned aerial vehicle"</para>
    /// labels<para>"UAV"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV</seealso>
    let UAV = Prefixed_Name(vas, "UAV") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_Hyperspectral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unmanned aerial vehicle Hyperspectral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UAV_Hyperspectral"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral</seealso>
    let UAV_Hyperspectral = Prefixed_Name(vas, "UAV_Hyperspectral") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_Hyperspectral_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:UAV_Hyperspectral</para>
    ///   <para>"UAV Hyperspectral platform."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral_1</seealso>
    let UAV_Hyperspectral_1 = Prefixed_Name(vas, "UAV_Hyperspectral_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:UAV_Hyperspectral_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral_Observation</seealso>
    let UAV_Hyperspectral_Observation =
        Prefixed_Name(vas, "UAV_Hyperspectral_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:UAV_LiDAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unmanned aerial vehicle LiDAR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UAV_LiDAR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR</seealso>
    let UAV_LiDAR = Prefixed_Name(vas, "UAV_LiDAR") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_LiDAR_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:UAV_LiDAR</para>
    ///   <para>"UAV LiDAR platform."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR_1</seealso>
    let UAV_LiDAR_1 = Prefixed_Name(vas, "UAV_LiDAR_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:UAV_LiDAR_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR_Observation</seealso>
    let UAV_LiDAR_Observation =
        Prefixed_Name(vas, "UAV_LiDAR_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:UAV_Microwave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unmanned aerial vehicle Microwave"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UAV_Microwave"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Microwave">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Microwave</seealso>
    let UAV_Microwave = Prefixed_Name(vas, "UAV_Microwave") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_Microwave_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:UAV_Microwave</para>
    ///   <para>"UAV Microwave platform."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Microwave_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Microwave_1</seealso>
    let UAV_Microwave_1 = Prefixed_Name(vas, "UAV_Microwave_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_Multispectral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unmanned aerial vehicle Multispectral"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UAV_Multispectral"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Multispectral">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Multispectral</seealso>
    let UAV_Multispectral = Prefixed_Name(vas, "UAV_Multispectral") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_Multispectral_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:UAV_Multispectral</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"UAV Multispectral platform."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Multispectral_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Multispectral_1</seealso>
    let UAV_Multispectral_1 = Prefixed_Name(vas, "UAV_Multispectral_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Observation collected by dron engine."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Observation</seealso>
    let UAV_Observation = Prefixed_Name(vas, "UAV_Observation") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_RGB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unmanned aerial vehicle RGB"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UAV_RGB"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_RGB">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_RGB</seealso>
    let UAV_RGB = Prefixed_Name(vas, "UAV_RGB") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_RGB_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:UAV_RGB</para>
    ///   <para>"UAV RGB  platform."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_RGB_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_RGB_1</seealso>
    let UAV_RGB_1 = Prefixed_Name(vas, "UAV_RGB_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_Thermal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unmanned aerial vehicle Thermal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UAV_Thermal"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Thermal">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Thermal</seealso>
    let UAV_Thermal = Prefixed_Name(vas, "UAV_Thermal") |> PrefixedName
    /// <summary>
    ///   <para>vas:UAV_Thermal_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:UAV_Thermal</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"UAV Thermal platform."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Thermal_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Thermal_1</seealso>
    let UAV_Thermal_1 = Prefixed_Name(vas, "UAV_Thermal_1") |> PrefixedName
    /// <summary>
    ///   <para>vas:URL10x10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URL for 10x10 area"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URL10x10">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URL10x10</seealso>
    let URL10x10 = Prefixed_Name(vas, "URL10x10") |> PrefixedName
    /// <summary>
    ///   <para>vas:URL1x1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URL for 1x1 area"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URL1x1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URL1x1</seealso>
    let URL1x1 = Prefixed_Name(vas, "URL1x1") |> PrefixedName
    /// <summary>
    ///   <para>vas:URLImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URLImage">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URLImage</seealso>
    let URLImage = Prefixed_Name(vas, "URLImage") |> PrefixedName

    /// <summary>
    ///   <para>vas:Upwelling_Longwave_Flux_In_Air_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Upwelling Longwave Flux In Air  (W/m2)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Longwave_Flux_In_Air_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Longwave_Flux_In_Air_Observation</seealso>
    let Upwelling_Longwave_Flux_In_Air_Observation =
        Prefixed_Name(vas, "Upwelling_Longwave_Flux_In_Air_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Upwelling_Longwave_Flux_In_Air__Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by LW_up sensors. Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Longwave_Flux_In_Air__Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Longwave_Flux_In_Air__Result</seealso>
    let Upwelling_Longwave_Flux_In_Air__Result =
        Prefixed_Name(vas, "Upwelling_Longwave_Flux_In_Air__Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Upwelling_Shortwave_Flux_In_Air_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to Upwelling Shortwave Flux In Air (W/m2)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Shortwave_Flux_In_Air_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Shortwave_Flux_In_Air_Observation</seealso>
    let Upwelling_Shortwave_Flux_In_Air_Observation =
        Prefixed_Name(vas, "Upwelling_Shortwave_Flux_In_Air_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Upwelling_Shortwave_Flux_In_Air_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by SW_up sensors. Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Shortwave_Flux_In_Air_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Shortwave_Flux_In_Air_Result</seealso>
    let Upwelling_Shortwave_Flux_In_Air_Result =
        Prefixed_Name(vas, "Upwelling_Shortwave_Flux_In_Air_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Vegetation_Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents all Vegetation properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vegetation_Property">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vegetation_Property</seealso>
    let Vegetation_Property = Prefixed_Name(vas, "Vegetation_Property") |> PrefixedName
    /// <summary>
    ///   <para>vas:Vegetation_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Vegetation ( EVI. SAVI, TDVI ...) sensors. Dimensionless."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vegetation_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vegetation_Result</seealso>
    let Vegetation_Result = Prefixed_Name(vas, "Vegetation_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:Vineyards</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Land_Cover_Classes</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Class Level 3 CORINE Land Cover - CLC"</para>
    /// labels<para>"Vineyards"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vineyards">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vineyards</seealso>
    let Vineyards = Prefixed_Name(vas, "Vineyards") |> PrefixedName
    /// <summary>
    ///   <para>vas:WaterVapourFlux_g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that takes water flow measurements"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WaterVapourFlux_g">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WaterVapourFlux_g</seealso>
    let WaterVapourFlux_g = Prefixed_Name(vas, "WaterVapourFlux_g") |> PrefixedName

    /// <summary>
    ///   <para>vas:WaterVapourFlux_g_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:WaterVapourFlux_g</para>
    ///   <para>"Sensor WaterVapourFlux_g_EddyCovariance hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WaterVapourFlux_g_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WaterVapourFlux_g_EddyCovariance_Sensor_1</seealso>
    let WaterVapourFlux_g_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "WaterVapourFlux_g_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Water_Vapour_Flux_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to water vapour flux (W/m2)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Water_Vapour_Flux_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Water_Vapour_Flux_Observation</seealso>
    let Water_Vapour_Flux_Observation =
        Prefixed_Name(vas, "Water_Vapour_Flux_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Water_Vapour_Flux_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by WatervapourFlux (water vapour flux) sensors. Unit of measure Watt per Square Metre (W/m2)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Water_Vapour_Flux_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Water_Vapour_Flux_Result</seealso>
    let Water_Vapour_Flux_Result =
        Prefixed_Name(vas, "Water_Vapour_Flux_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:WindVane_AEMET</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor belongs to AEMET Station. Sensor that takes wind direction  [0º-360º]  measurements"</para>
    /// labels<para>"WindVane_AEMET"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_AEMET">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_AEMET</seealso>
    let WindVane_AEMET = Prefixed_Name(vas, "WindVane_AEMET") |> PrefixedName

    /// <summary>
    ///   <para>vas:WindVane_AEMET_Sensor_UTIEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:WindVane_AEMET</para>
    ///   <para>"Sensor WindVane_AEMET hosted by AEMET_UTIEL_Station"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_AEMET_Sensor_UTIEL">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_AEMET_Sensor_UTIEL</seealso>
    let WindVane_AEMET_Sensor_UTIEL =
        Prefixed_Name(vas, "WindVane_AEMET_Sensor_UTIEL") |> PrefixedName

    /// <summary>
    ///   <para>vas:WindVane_EddyCovariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor belongs to EddyCovariance Station.  Sensor that takes wind direction  [0º-360º]  measurements."</para>
    /// labels<para>"WindVane_EddyCovariance"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_EddyCovariance">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_EddyCovariance</seealso>
    let WindVane_EddyCovariance =
        Prefixed_Name(vas, "WindVane_EddyCovariance") |> PrefixedName

    /// <summary>
    ///   <para>vas:WindVane_EddyCovariance_Sensor_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:WindVane_EddyCovariance</para>
    ///   <para>"Sensor WindVane_EddyCovariance hosted by EddyCovariance_Station_1"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_EddyCovariance_Sensor_1">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_EddyCovariance_Sensor_1</seealso>
    let WindVane_EddyCovariance_Sensor_1 =
        Prefixed_Name(vas, "WindVane_EddyCovariance_Sensor_1") |> PrefixedName

    /// <summary>
    ///   <para>vas:Wind_Direction_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to wind direction. Angle Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_AEMET_Observation</seealso>
    let Wind_Direction_AEMET_Observation =
        Prefixed_Name(vas, "Wind_Direction_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Wind_Direction_EddyCovariance_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to wind direction. Angle Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_EddyCovariance_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_EddyCovariance_Observation</seealso>
    let Wind_Direction_EddyCovariance_Observation =
        Prefixed_Name(vas, "Wind_Direction_EddyCovariance_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Wind_Direction_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to wind direction. Angle Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_Observation</seealso>
    let Wind_Direction_Observation =
        Prefixed_Name(vas, "Wind_Direction_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Wind_Direction_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by WindVane sensors. Unit of measure Angle Degree."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_Result</seealso>
    let Wind_Direction_Result =
        Prefixed_Name(vas, "Wind_Direction_Result") |> PrefixedName

    /// <summary>
    ///   <para>vas:Wind_Speed_AEMET_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to wind speed in AEMET Station. (m/s)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_AEMET_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_AEMET_Observation</seealso>
    let Wind_Speed_AEMET_Observation =
        Prefixed_Name(vas, "Wind_Speed_AEMET_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Wind_Speed_EddyCovariance_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to wind speed in EddyCovariance Station. (m/s)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_EddyCovariance_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_EddyCovariance_Observation</seealso>
    let Wind_Speed_EddyCovariance_Observation =
        Prefixed_Name(vas, "Wind_Speed_EddyCovariance_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Wind_Speed_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents observations related to wind speed. (m/s)"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_Observation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_Observation</seealso>
    let Wind_Speed_Observation =
        Prefixed_Name(vas, "Wind_Speed_Observation") |> PrefixedName

    /// <summary>
    ///   <para>vas:Wind_Speed_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Result that is normally obtained by Anemometer sensors. Unit of measure Metre per Second (m/s)."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_Result">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_Result</seealso>
    let Wind_Speed_Result = Prefixed_Name(vas, "Wind_Speed_Result") |> PrefixedName
    /// <summary>
    ///   <para>vas:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Abbreviation"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#abbreviation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#abbreviation</seealso>
    let abbreviation = Prefixed_Name(vas, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>vas:acquisitionPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Adquisition Period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#acquisitionPeriod">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#acquisitionPeriod</seealso>
    let acquisitionPeriod = Prefixed_Name(vas, "acquisitionPeriod") |> PrefixedName
    /// <summary>
    ///   <para>vas:cloud_mask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Atmosphere_Property</para>
    ///   <para>"A 'cloud mask' in remote sensing refers to a technique or dataset used to identify and delineate areas covered by clouds in an image captured from a satellite or other observation platform. This technique is crucial in remote sensing as clouds can obstruct visibility of the Earth's surface, making it challenging to interpret images and analyze data.""</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloud_mask">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloud_mask</seealso>
    let cloud_mask = Prefixed_Name(vas, "cloud_mask") |> PrefixedName
    /// <summary>
    ///   <para>vas:cloud_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Atmosphere_Property</para>
    ///   <para>""'Cloud type' in remote sensing refers to the classification or categorization of clouds based on their visual characteristics and structural features observed in satellite or aerial imagery."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloud_type">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloud_type</seealso>
    let cloud_type = Prefixed_Name(vas, "cloud_type") |> PrefixedName
    /// <summary>
    ///   <para>vas:cloudyPixels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Cloudy pixels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloudyPixels">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloudyPixels</seealso>
    let cloudyPixels = Prefixed_Name(vas, "cloudyPixels") |> PrefixedName
    /// <summary>
    ///   <para>vas:code_CLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Corine Land Cover (CLC) code."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#code_CLC">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#code_CLC</seealso>
    let code_CLC = Prefixed_Name(vas, "code_CLC") |> PrefixedName

    /// <summary>
    ///   <para>vas:commonProductProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"CommonProperties"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#commonProductProperties">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#commonProductProperties</seealso>
    let commonProductProperties =
        Prefixed_Name(vas, "commonProductProperties") |> PrefixedName

    /// <summary>
    ///   <para>vas:controlArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Control Area indicates if it is 1x1 km or 10x10 km in VAS."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#controlArea">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#controlArea</seealso>
    let controlArea = Prefixed_Name(vas, "controlArea") |> PrefixedName
    /// <summary>
    ///   <para>vas:coordinatesLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the coordinates in which the station is located."</para>
    ///   <para>"Indica las coordinadas en las que está localizado la estación."</para>
    /// labels<para>"Coordinates location"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#coordinatesLocation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#coordinatesLocation</seealso>
    let coordinatesLocation = Prefixed_Name(vas, "coordinatesLocation") |> PrefixedName
    /// <summary>
    ///   <para>vas:file_description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"File Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#file_description">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#file_description</seealso>
    let file_description = Prefixed_Name(vas, "file_description") |> PrefixedName
    /// <summary>
    ///   <para>vas:geo_WGS84</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#geo_WGS84">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#geo_WGS84</seealso>
    let geo_WGS84 = Prefixed_Name(vas, "geo_WGS84") |> PrefixedName
    /// <summary>
    ///   <para>vas:gridMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Grid Mapping"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#gridMapping">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#gridMapping</seealso>
    let gridMapping = Prefixed_Name(vas, "gridMapping") |> PrefixedName

    /// <summary>
    ///   <para>vas:groundTrackDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Ground Track Direction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#groundTrackDirection">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#groundTrackDirection</seealso>
    let groundTrackDirection =
        Prefixed_Name(vas, "groundTrackDirection") |> PrefixedName

    /// <summary>
    ///   <para>vas:hasObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Snapshot has a satellite observation"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasObservation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasObservation</seealso>
    let hasObservation = Prefixed_Name(vas, "hasObservation") |> PrefixedName
    /// <summary>
    ///   <para>vas:hasProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Someting (usually a snapshot) has product."</para>
    /// labels<para>"has product"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasProduct">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasProduct</seealso>
    let hasProduct = Prefixed_Name(vas, "hasProduct") |> PrefixedName
    /// <summary>
    ///   <para>vas:hasSatelliteSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The satellite products have satellite sources"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasSatelliteSource">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasSatelliteSource</seealso>
    let hasSatelliteSource = Prefixed_Name(vas, "hasSatelliteSource") |> PrefixedName
    /// <summary>
    ///   <para>vas:hasTypeOfCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property indicates the type of cover classes."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasTypeOfCover">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasTypeOfCover</seealso>
    let hasTypeOfCover = Prefixed_Name(vas, "hasTypeOfCover") |> PrefixedName
    /// <summary>
    ///   <para>vas:isObservationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#isObservationOf">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#isObservationOf</seealso>
    let isObservationOf = Prefixed_Name(vas, "isObservationOf") |> PrefixedName
    /// <summary>
    ///   <para>vas:isSatelliteSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#isSatelliteSourceOf">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#isSatelliteSourceOf</seealso>
    let isSatelliteSourceOf = Prefixed_Name(vas, "isSatelliteSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>vas:landPixels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Land pixels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#landPixels">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#landPixels</seealso>
    let landPixels = Prefixed_Name(vas, "landPixels") |> PrefixedName

    /// <summary>
    ///   <para>vas:landsat8ProductProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Landsat 8 product properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#landsat8ProductProperties">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#landsat8ProductProperties</seealso>
    let landsat8ProductProperties =
        Prefixed_Name(vas, "landsat8ProductProperties") |> PrefixedName

    /// <summary>
    ///   <para>vas:locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the location of the stations."</para>
    ///   <para>"Indica la localización de las estaciones"</para>
    /// labels<para>"Located in"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedIn">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedIn</seealso>
    let locatedIn = Prefixed_Name(vas, "locatedIn") |> PrefixedName

    /// <summary>
    ///   <para>vas:locatedInMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indica el municipio en el que está localizado un sensor."</para>
    ///   <para>"Indicates the municipality in which a sensor is located."</para>
    /// labels<para>"Located in municipality"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedInMunicipality">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedInMunicipality</seealso>
    let locatedInMunicipality =
        Prefixed_Name(vas, "locatedInMunicipality") |> PrefixedName

    /// <summary>
    ///   <para>vas:locatedInProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the province in which a sensor is located."</para>
    /// labels<para>"Located in province"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedInProvince">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedInProvince</seealso>
    let locatedInProvince = Prefixed_Name(vas, "locatedInProvince") |> PrefixedName
    /// <summary>
    ///   <para>vas:longName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Longname"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#longName">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#longName</seealso>
    let longName = Prefixed_Name(vas, "longName") |> PrefixedName
    /// <summary>
    ///   <para>vas:missingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Missing Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#missingValue">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#missingValue</seealso>
    let missingValue = Prefixed_Name(vas, "missingValue") |> PrefixedName
    /// <summary>
    ///   <para>vas:mission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Mission"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#mission">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#mission</seealso>
    let mission = Prefixed_Name(vas, "mission") |> PrefixedName

    /// <summary>
    ///   <para>vas:modisProductProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"MODIS Aqua / Terra product properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#modisProductProperties">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#modisProductProperties</seealso>
    let modisProductProperties =
        Prefixed_Name(vas, "modisProductProperties") |> PrefixedName

    /// <summary>
    ///   <para>vas:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#number">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#number</seealso>
    let number = Prefixed_Name(vas, "number") |> PrefixedName
    /// <summary>
    ///   <para>vas:postList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Post List"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#postList">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#postList</seealso>
    let postList = Prefixed_Name(vas, "postList") |> PrefixedName

    /// <summary>
    ///   <para>vas:precipitable_water_content</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Atmosphere_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Land_Atmosphere_Interaction_Property</para>
    ///   <para>"Precipitable Water Content (PWC) refers to the amount of water vapor present in a vertical column of the Earth's atmosphere. It is typically expressed in terms of thickness or depth, such as millimeters (mm) or inches (inches), and represents the total depth of liquid water that would result if all the water vapor in the column were condensed and collected."</para>
    /// labels<para>"PWC"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#precipitable_water_content">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#precipitable_water_content</seealso>
    let precipitable_water_content =
        Prefixed_Name(vas, "precipitable_water_content") |> PrefixedName

    /// <summary>
    ///   <para>vas:productName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Product name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#productName">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#productName</seealso>
    let productName = Prefixed_Name(vas, "productName") |> PrefixedName
    /// <summary>
    ///   <para>vas:productType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Product type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#productType">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#productType</seealso>
    let productType = Prefixed_Name(vas, "productType") |> PrefixedName
    /// <summary>
    ///   <para>vas:relativeOrbitNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Relative Orbit Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#relativeOrbitNumber">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#relativeOrbitNumber</seealso>
    let relativeOrbitNumber = Prefixed_Name(vas, "relativeOrbitNumber") |> PrefixedName
    /// <summary>
    ///   <para>vas:scale_factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Scale Factor"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#scale_factor">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#scale_factor</seealso>
    let scale_factor = Prefixed_Name(vas, "scale_factor") |> PrefixedName

    /// <summary>
    ///   <para>vas:sentinel2ProductProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sentinel-2 product properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#sentinel2ProductProperties">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#sentinel2ProductProperties</seealso>
    let sentinel2ProductProperties =
        Prefixed_Name(vas, "sentinel2ProductProperties") |> PrefixedName

    /// <summary>
    ///   <para>vas:sentinel3ProductProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sentinel-3 product properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#sentinel3ProductProperties">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#sentinel3ProductProperties</seealso>
    let sentinel3ProductProperties =
        Prefixed_Name(vas, "sentinel3ProductProperties") |> PrefixedName

    /// <summary>
    ///   <para>vas:simple_ratio</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Simplest ratio-based index is called the Simple Ratio (SR) or Ratio Vegetation Index (RVI). This index is simply the reflectance in the NIR band divided by the reflectance in the red band. A larger SR value indicates healthy vegetation, while lower values indicate soil, water or ice. SR = Near Infrared / Red"</para>
    /// labels<para>"SR"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#simple_ratio">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#simple_ratio</seealso>
    let simple_ratio = Prefixed_Name(vas, "simple_ratio") |> PrefixedName

    /// <summary>
    ///   <para>vas:smapProductProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"SMAP product properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#smapProductProperties">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#smapProductProperties</seealso>
    let smapProductProperties =
        Prefixed_Name(vas, "smapProductProperties") |> PrefixedName

    /// <summary>
    ///   <para>vas:smosProductsProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"SMOS product properties"</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#smosProductsProperties">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#smosProductsProperties</seealso>
    let smosProductsProperties =
        Prefixed_Name(vas, "smosProductsProperties") |> PrefixedName

    /// <summary>
    ///   <para>vas:srsName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"SRS Name"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#srsName">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#srsName</seealso>
    let srsName = Prefixed_Name(vas, "srsName") |> PrefixedName
    /// <summary>
    ///   <para>vas:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Start time"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#startTime">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#startTime</seealso>
    let startTime = Prefixed_Name(vas, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>vas:stopTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Stop time"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#stopTime">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#stopTime</seealso>
    let stopTime = Prefixed_Name(vas, "stopTime") |> PrefixedName

    /// <summary>
    ///   <para>vas:surface_net_radiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Radiation_Property</para>
    ///   <para>"Earth's net radiation, sometimes called net flux, is the balance between incoming and outgoing energy at the top of the atmosphere."</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#surface_net_radiation">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#surface_net_radiation</seealso>
    let surface_net_radiation =
        Prefixed_Name(vas, "surface_net_radiation") |> PrefixedName

    /// <summary>
    ///   <para>vas:temperature_in_ground_depth_05</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_depth_05">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_depth_05</seealso>
    let temperature_in_ground_depth_05 =
        Prefixed_Name(vas, "temperature_in_ground_depth_05") |> PrefixedName

    /// <summary>
    ///   <para>vas:temperature_in_ground_depth_20</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_depth_20">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_depth_20</seealso>
    let temperature_in_ground_depth_20 =
        Prefixed_Name(vas, "temperature_in_ground_depth_20") |> PrefixedName

    /// <summary>
    ///   <para>vas:temperature_in_ground_next_ground</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_next_ground">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_next_ground</seealso>
    let temperature_in_ground_next_ground =
        Prefixed_Name(vas, "temperature_in_ground_next_ground") |> PrefixedName

    /// <summary>
    ///   <para>vas:timeliness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Timeliness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#timeliness">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#timeliness</seealso>
    let timeliness = Prefixed_Name(vas, "timeliness") |> PrefixedName
    /// <summary>
    ///   <para>vas:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Unit"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#unit">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#unit</seealso>
    let unit = Prefixed_Name(vas, "unit") |> PrefixedName
    /// <summary>
    ///   <para>vas:validMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Valid Max"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#validMax">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#validMax</seealso>
    let validMax = Prefixed_Name(vas, "validMax") |> PrefixedName
    /// <summary>
    ///   <para>vas:validMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Valid Min"</para></remarks>
    /// <seealso href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#validMin">https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#validMin</seealso>
    let validMin = Prefixed_Name(vas, "validMin") |> PrefixedName
