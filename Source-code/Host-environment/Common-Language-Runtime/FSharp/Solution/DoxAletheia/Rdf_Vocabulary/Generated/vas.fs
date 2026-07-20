namespace https.robotica.uv.es.proyectos.ASOTVAS.def.ciencia_tecnologia.vas.hash

open DoxAletheia

module vas =
    let _namespace_name =
        "https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Class Level 1 CORINE Land Cover - CLC
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Artificial_Surfaces"></see></summary>
    let Artificial_Surfaces = _prefix "Artificial_Surfaces"
    /// <summary>
    /// A soil surface devoid of any plant material.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Bare_Soils"></see></summary>
    let Bare_Soils = _prefix "Bare_Soils"
    /// <summary>
    /// Class Level 3 CORINE Land Cover - CLC
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Coniferous_Forest"></see></summary>
    let Coniferous_Forest = _prefix "Coniferous_Forest"
    /// <summary>
    /// Class Level 3 CORINE Land Cover - CLC
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Non-irrigated_arable_land"></see></summary>
    let ``Non-irrigated_arable_land`` = _prefix "Non-irrigated_arable_land"
    /// <summary>
    /// Class Level 3 CORINE Land Cover - CLC
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Permanently_irrigated_land"></see></summary>
    let Permanently_irrigated_land = _prefix "Permanently_irrigated_land"
    /// <summary>
    /// Class Level 3 CORINE Land Cover - CLC
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sclerophyllous_vegetation"></see></summary>
    let Sclerophyllous_vegetation = _prefix "Sclerophyllous_vegetation"
    /// <summary>
    /// Class Level 3 CORINE Land Cover - CLC
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vineyards"></see></summary>
    let Vineyards = _prefix "Vineyards"

    /// <summary>
    /// Class Level 3 CORINE Land Cover - CLC
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Fruit_trees_and_berry_plantations_(olive,_almond)"></see></summary>
    let ``Fruit_trees_and_berry_plantations_(olive,_almond)`` =
        _prefix "Fruit_trees_and_berry_plantations_(olive,_almond)"

    /// <summary>
    /// Measures the direction [0º-360º] and the intensity (m/s) of the wind
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer"></see></summary>
    let Anemometer = _prefix "Anemometer"
    /// <summary>
    /// Measures pressure in hPa
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer"></see></summary>
    let Barometer = _prefix "Barometer"
    /// <summary>
    /// Ground Base Sensors
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_Based_Sensing"></see></summary>
    let Ground_Based_Sensing = _prefix "Ground_Based_Sensing"
    /// <summary>
    /// Measures relative humidity in %
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer"></see></summary>
    let Hygrometer = _prefix "Hygrometer"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_next_ground"></see>
    /// </summary>
    let temperature_in_ground_next_ground = _prefix "temperature_in_ground_next_ground"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_depth_20"></see>
    /// </summary>
    let temperature_in_ground_depth_20 = _prefix "temperature_in_ground_depth_20"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#temperature_in_ground_depth_05"></see>
    /// </summary>
    let temperature_in_ground_depth_05 = _prefix "temperature_in_ground_depth_05"
    /// <summary>
    /// Measures temperature in degrees Celsius
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer"></see></summary>
    let Thermometer = _prefix "Thermometer"
    /// <summary>
    /// Sensor belongs to AEMET Station. Sensor that takes wind direction  [0º-360º]  measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_AEMET"></see></summary>
    let WindVane_AEMET = _prefix "WindVane_AEMET"
    /// <summary>
    /// A Ground Station is defined as a physical platform located on the Earth’s surface that hosts one or more sensors used to perform in-situ environmental observations.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_Station"></see></summary>
    let Ground_Station = _prefix "Ground_Station"
    /// <summary>
    /// Class that represents all Vegetation properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vegetation_Property"></see></summary>
    let Vegetation_Property = _prefix "Vegetation_Property"
    /// <summary>
    /// Sensor CRI UAV Hyperspectral hosted by UAV Hyperspectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_UAV_Hyperspectral_Sensor_1"></see></summary>
    let CRI_UAV_Hyperspectral_Sensor_1 = _prefix "CRI_UAV_Hyperspectral_Sensor_1"
    /// <summary>
    /// Sensor AGB UAV LiDAR  hosted by UAV LiDAR 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_LiDAR_Sensor_1"></see></summary>
    let AGB_UAV_LiDAR_Sensor_1 = _prefix "AGB_UAV_LiDAR_Sensor_1"
    /// <summary>
    /// Sensor AGB UAV Hyperspectral hosted by UAV Hyperspectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_Hyperspectral_Sensor_1"></see></summary>
    let AGB_UAV_Hyperspectral_Sensor_1 = _prefix "AGB_UAV_Hyperspectral_Sensor_1"
    /// <summary>
    /// AGB_SMOS_CATDS Sensor hosted by SMOS Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_SMOS_CATDS_Sensor_1"></see></summary>
    let AGB_SMOS_CATDS_Sensor_1 = _prefix "AGB_SMOS_CATDS_Sensor_1"
    /// <summary>
    /// Sensor DBH UAV LiDAR  hosted by UAV LiDAR 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_UAV_LiDAR_Sensor_1"></see></summary>
    let DBH_UAV_LiDAR_Sensor_1 = _prefix "DBH_UAV_LiDAR_Sensor_1"
    /// <summary>
    /// Roughness_SMOS_CATDS Sensor hosted by SMOS Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Roughness_SMOS_CATDS_Sensor_1"></see></summary>
    let Roughness_SMOS_CATDS_Sensor_1 = _prefix "Roughness_SMOS_CATDS_Sensor_1"
    /// <summary>
    /// OTCI_S3 Sensor hosted by Sentinel-3_OLCI Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#OTCI_S3_Sensor_1"></see></summary>
    let OTCI_S3_Sensor_1 = _prefix "OTCI_S3_Sensor_1"
    /// <summary>
    /// Sensor Chl_g hosted by Chl_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_g_Sensor_1"></see></summary>
    let Chl_g_Sensor_1 = _prefix "Chl_g_Sensor_1"
    /// <summary>
    /// Chl_S2 Sensor hosted by Sentinel-2 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_S2_Sensor_1"></see></summary>
    let Chl_S2_Sensor_1 = _prefix "Chl_S2_Sensor_1"
    /// <summary>
    /// Chl_L9 Sensor hosted by Landsat-9 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L9_Sensor_1"></see></summary>
    let Chl_L9_Sensor_1 = _prefix "Chl_L9_Sensor_1"
    /// <summary>
    /// Chl_L8 Sensor hosted by Landsat-8 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L8_Sensor_1"></see></summary>
    let Chl_L8_Sensor_1 = _prefix "Chl_L8_Sensor_1"
    /// <summary>
    /// Class that represents all Radiation properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Radiation_Property"></see></summary>
    let Radiation_Property = _prefix "Radiation_Property"
    /// <summary>
    /// I_dif_g_RAD Sensor hosted by RAD_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dif_g_RAD_Sensor_1"></see></summary>
    let I_dif_g_RAD_Sensor_1 = _prefix "I_dif_g_RAD_Sensor_1"
    /// <summary>
    /// I_dir_g_RAD Sensor hosted by RAD_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dir_g_RAD_Sensor_1"></see></summary>
    let I_dir_g_RAD_Sensor_1 = _prefix "I_dir_g_RAD_Sensor_1"
    /// <summary>
    /// DroughtIndex_SMOS_CATDS Sensor hosted by SMOS Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DroughtIndex_SMOS_CATDS_Sensor_1"></see></summary>
    let DroughtIndex_SMOS_CATDS_Sensor_1 = _prefix "DroughtIndex_SMOS_CATDS_Sensor_1"
    /// <summary>
    /// Sensor EVI UAV Multispectral hosted by UAV Multispectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_UAV_Multispectral_Sensor_1"></see></summary>
    let EVI_UAV_Multispectral_Sensor_1 = _prefix "EVI_UAV_Multispectral_Sensor_1"
    /// <summary>
    /// EVI_L9 Sensor hosted by Landsat-9 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L9_Sensor_1"></see></summary>
    let EVI_L9_Sensor_1 = _prefix "EVI_L9_Sensor_1"
    /// <summary>
    /// EVI_L8 Sensor hosted by Landsat-8 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L8_Sensor_1"></see></summary>
    let EVI_L8_Sensor_1 = _prefix "EVI_L8_Sensor_1"
    /// <summary>
    /// EVI_diary_500m_t Sensor hosted by MODIS-TerraProduct_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_diary_500m_t_Sensor_1"></see></summary>
    let EVI_diary_500m_t_Sensor_1 = _prefix "EVI_diary_500m_t_Sensor_1"
    /// <summary>
    /// EVI_S2 Sensor hosted by Sentinel-2 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_S2_Sensor_1"></see></summary>
    let EVI_S2_Sensor_1 = _prefix "EVI_S2_Sensor_1"
    /// <summary>
    /// EVI_diary_500m_a Sensor hosted by MODIS-Aqua Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_diary_500m_a_Sensor_1"></see></summary>
    let EVI_diary_500m_a_Sensor_1 = _prefix "EVI_diary_500m_a_Sensor_1"
    /// <summary>
    /// Sensor Orthophoto UAV RGB  hosted by UAV RGB 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Orthophoto_UAV_RGB_Sensor_1"></see></summary>
    let Orthophoto_UAV_RGB_Sensor_1 = _prefix "Orthophoto_UAV_RGB_Sensor_1"

    /// <summary>
    /// Sensor Diseasestatus UAV Hyperspectral hosted by UAV Hyperspectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_UAV_Hyperspectral_Sensor_1"></see></summary>
    let DiseaseStatus_UAV_Hyperspectral_Sensor_1 =
        _prefix "DiseaseStatus_UAV_Hyperspectral_Sensor_1"

    /// <summary>
    /// Sensor SAVI UAV Multispectral hosted by UAV Multispectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_UAV_Multispectral_Sensor_1"></see></summary>
    let SAVI_UAV_Multispectral_Sensor_1 = _prefix "SAVI_UAV_Multispectral_Sensor_1"
    /// <summary>
    /// SAVI_S2_Sensor hosted by Sentinel-2 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_S2_Sensor_1"></see></summary>
    let SAVI_S2_Sensor_1 = _prefix "SAVI_S2_Sensor_1"
    /// <summary>
    /// SAVI_L9 Sensor hosted by Landsat-9 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L9_Sensor_1"></see></summary>
    let SAVI_L9_Sensor_1 = _prefix "SAVI_L9_Sensor_1"
    /// <summary>
    /// SAVI_L8 Sensor hosted by Landsat-8 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L8_Sensor_1"></see></summary>
    let SAVI_L8_Sensor_1 = _prefix "SAVI_L8_Sensor_1"
    /// <summary>
    /// Sensor SM_g hosted by SM_Station_4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_4"></see></summary>
    let SM_g_Sensor_4 = _prefix "SM_g_Sensor_4"
    /// <summary>
    /// SM_NRT_SMOS_ESA Sensor hosted by SMOS Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_NRT_SMOS_ESA_Sensor_1"></see></summary>
    let SM_NRT_SMOS_ESA_Sensor_1 = _prefix "SM_NRT_SMOS_ESA_Sensor_1"
    /// <summary>
    /// SM_SMOS_BEC Sensor hosted by SMOS Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_BEC_Sensor_1"></see></summary>
    let SM_SMOS_BEC_Sensor_1 = _prefix "SM_SMOS_BEC_Sensor_1"
    /// <summary>
    /// Sensor SM UAV Microwave hosted by UAV Microwave 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_UAV_Microwave_Sensor_1"></see></summary>
    let SM_UAV_Microwave_Sensor_1 = _prefix "SM_UAV_Microwave_Sensor_1"
    /// <summary>
    /// SM_SMAP-S1_9km Sensor hosted by SMAP Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP-S1_9km_Sensor_1"></see></summary>
    let ``SM_SMAP-S1_9km_Sensor_1`` = _prefix "SM_SMAP-S1_9km_Sensor_1"
    /// <summary>
    /// Sensor SM_g hosted by SM_Station_6
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_6"></see></summary>
    let SM_g_Sensor_6 = _prefix "SM_g_Sensor_6"
    /// <summary>
    /// SM_SMAP-S1_3km Sensor hosted by SMAP Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP-S1_3km_Sensor_1"></see></summary>
    let ``SM_SMAP-S1_3km_Sensor_1`` = _prefix "SM_SMAP-S1_3km_Sensor_1"
    /// <summary>
    /// SM_SMOS-IC_CATDS Sensor hosted by SMOS Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS-IC_CATDS_Sensor_1"></see></summary>
    let ``SM_SMOS-IC_CATDS_Sensor_1`` = _prefix "SM_SMOS-IC_CATDS_Sensor_1"
    /// <summary>
    /// Sensor SM_g hosted by SM_Station_3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_3"></see></summary>
    let SM_g_Sensor_3 = _prefix "SM_g_Sensor_3"
    /// <summary>
    /// SM_S1 Sensor hosted by Sentinel-1 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_S1_Sensor_1"></see></summary>
    let SM_S1_Sensor_1 = _prefix "SM_S1_Sensor_1"
    /// <summary>
    /// Sensor SM_g hosted by SM_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_1"></see></summary>
    let SM_g_Sensor_1 = _prefix "SM_g_Sensor_1"
    /// <summary>
    /// Sensor SM_g hosted by SM_Station_2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_2"></see></summary>
    let SM_g_Sensor_2 = _prefix "SM_g_Sensor_2"
    /// <summary>
    /// Sensor SM_g hosted by SM_Station_5
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g_Sensor_5"></see></summary>
    let SM_g_Sensor_5 = _prefix "SM_g_Sensor_5"
    /// <summary>
    /// SM_SMOS_ESA Sensor hosted by SMOS Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_ESA_Sensor_1"></see></summary>
    let SM_SMOS_ESA_Sensor_1 = _prefix "SM_SMOS_ESA_Sensor_1"
    /// <summary>
    /// SM_SMAP_36km Sensor hosted by SMAP Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_36km_Sensor_1"></see></summary>
    let SM_SMAP_36km_Sensor_1 = _prefix "SM_SMAP_36km_Sensor_1"

    /// <summary>
    /// SM_freeze_and_Thaw_SMOS_ESA Sensor hosted by SMOS Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_freeze_and_Thaw_SMOS_ESA_Sensor_1"></see></summary>
    let SM_freeze_and_Thaw_SMOS_ESA_Sensor_1 =
        _prefix "SM_freeze_and_Thaw_SMOS_ESA_Sensor_1"

    /// <summary>
    /// Class that represents Sentinel-2 satellite Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Product"></see></summary>
    let ``Sentinel-2_Product`` = _prefix "Sentinel-2_Product"
    /// <summary>
    /// Sentinel-2 product properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#sentinel2ProductProperties"></see></summary>
    let sentinel2ProductProperties = _prefix "sentinel2ProductProperties"
    /// <summary>
    /// Class that represents Landsat-8 products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Product"></see></summary>
    let ``Landsat-8_Product`` = _prefix "Landsat-8_Product"
    /// <summary>
    /// Landsat 8 product properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#landsat8ProductProperties"></see></summary>
    let landsat8ProductProperties = _prefix "landsat8ProductProperties"
    /// <summary>
    /// Class that represents Sentinel-3 satellite Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_Product"></see></summary>
    let ``Sentinel-3_Product`` = _prefix "Sentinel-3_Product"
    /// <summary>
    /// Class that represents SMOS satellite Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Product"></see></summary>
    let SMOS_Product = _prefix "SMOS_Product"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#commonProductProperties"></see>
    /// </summary>
    let commonProductProperties = _prefix "commonProductProperties"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#geo_WGS84"></see>
    /// </summary>
    let geo_WGS84 = _prefix "geo_WGS84"
    /// <summary>
    /// Indicates the location of the stations.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedIn"></see></summary>
    let locatedIn = _prefix "locatedIn"
    /// <summary>
    /// Sensor Barometer_EddyCovariance hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_EddyCovariance_Sensor_1"></see></summary>
    let Barometer_EddyCovariance_Sensor_1 = _prefix "Barometer_EddyCovariance_Sensor_1"
    /// <summary>
    /// Sensor Barometer_AEMET hosted by AEMET_UTIEL_Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_AEMET_SENSOR_UTIEL"></see></summary>
    let Barometer_AEMET_SENSOR_UTIEL = _prefix "Barometer_AEMET_SENSOR_UTIEL"

    /// <summary>
    /// Thermometer_EddyCovariance Sensor hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_EddyCovariance_Sensor_1"></see></summary>
    let Thermometer_EddyCovariance_Sensor_1 =
        _prefix "Thermometer_EddyCovariance_Sensor_1"

    /// <summary>
    /// Sensor Thermometer_AEMET hosted by AEMET_UTIEL_Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_AEMET_Sensor_UTIEL"></see></summary>
    let Thermometer_AEMET_Sensor_UTIEL = _prefix "Thermometer_AEMET_Sensor_UTIEL"
    /// <summary>
    /// Class that represents all Atmosphere  properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmosphere_Property"></see></summary>
    let Atmosphere_Property = _prefix "Atmosphere_Property"
    /// <summary>
    /// Sensor Heliograph_AEMET hosted by AEMET_UTIEL_Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Heliograph_AEMET_Sensor_UTIEL"></see></summary>
    let Heliograph_AEMET_Sensor_UTIEL = _prefix "Heliograph_AEMET_Sensor_UTIEL"
    /// <summary>
    /// Sensor FAPAR UAV Multispectral hosted by UAV Multispectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_UAV_Multispectral_Sensor_1"></see></summary>
    let FAPAR_UAV_Multispectral_Sensor_1 = _prefix "FAPAR_UAV_Multispectral_Sensor_1"
    /// <summary>
    /// FAPAR_L9 Sensor hosted by Landsat-9 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L9_Sensor_1"></see></summary>
    let FAPAR_L9_Sensor_1 = _prefix "FAPAR_L9_Sensor_1"
    /// <summary>
    /// Sensor FAPAR_g hosted by FAPAR_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_1"></see></summary>
    let FAPAR_g_Sensor_1 = _prefix "FAPAR_g_Sensor_1"
    /// <summary>
    /// Sensor FAPAR_dhp hosted by DHP_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_1"></see></summary>
    let FAPAR_dhp_Sensor_1 = _prefix "FAPAR_dhp_Sensor_1"
    /// <summary>
    /// FAPAR_8days_500m_a Sensor hosted by MODIS-Aqua Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_8days_500m_a_Sensor_1"></see></summary>
    let FAPAR_8days_500m_a_Sensor_1 = _prefix "FAPAR_8days_500m_a_Sensor_1"
    /// <summary>
    /// Sensor FAPAR_g hosted by FAPAR_Station_4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_4"></see></summary>
    let FAPAR_g_Sensor_4 = _prefix "FAPAR_g_Sensor_4"
    /// <summary>
    /// GIFAPAR_S3 Sensor hosted by Sentinel-3_OLCI Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_S3_Sensor_1"></see></summary>
    let GIFAPAR_S3_Sensor_1 = _prefix "GIFAPAR_S3_Sensor_1"
    /// <summary>
    /// FAPAR_S2 Sensor hosted by Sentinel-2 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_S2_Sensor_1"></see></summary>
    let FAPAR_S2_Sensor_1 = _prefix "FAPAR_S2_Sensor_1"
    /// <summary>
    /// FAPAR_8days_500m_t Sensor hosted by MODIS-TerraProduct_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_8days_500m_t_Sensor_1"></see></summary>
    let FAPAR_8days_500m_t_Sensor_1 = _prefix "FAPAR_8days_500m_t_Sensor_1"
    /// <summary>
    /// Sensor FAPAR_g hosted by FAPAR_Station_2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_2"></see></summary>
    let FAPAR_g_Sensor_2 = _prefix "FAPAR_g_Sensor_2"
    /// <summary>
    /// FAPAR_L8 Sensor hosted by Landsat-8 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L8_Sensor_1"></see></summary>
    let FAPAR_L8_Sensor_1 = _prefix "FAPAR_L8_Sensor_1"
    /// <summary>
    /// Sensor FAPAR_g hosted by FAPAR_Station_3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Sensor_3"></see></summary>
    let FAPAR_g_Sensor_3 = _prefix "FAPAR_g_Sensor_3"
    /// <summary>
    /// Sensor FAPAR_dhp hosted by DHP_Station_3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_3"></see></summary>
    let FAPAR_dhp_Sensor_3 = _prefix "FAPAR_dhp_Sensor_3"
    /// <summary>
    /// Sensor FAPAR_dhp hosted by DHP_Station_2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Sensor_2"></see></summary>
    let FAPAR_dhp_Sensor_2 = _prefix "FAPAR_dhp_Sensor_2"
    /// <summary>
    /// LandCover_S2 Sensor hosted by Sentinel-2 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_S2_Sensor_1"></see></summary>
    let LandCover_S2_Sensor_1 = _prefix "LandCover_S2_Sensor_1"
    /// <summary>
    /// Sensor LAI_g hosted by LAI_Station_2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Sensor_2"></see></summary>
    let LAI_g_Sensor_2 = _prefix "LAI_g_Sensor_2"
    /// <summary>
    /// Sensor LAI UAV Multispectral hosted by UAV Multispectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_UAV_Multispectral_Sensor_1"></see></summary>
    let LAI_UAV_Multispectral_Sensor_1 = _prefix "LAI_UAV_Multispectral_Sensor_1"
    /// <summary>
    /// LAI_L8 Sensor hosted by Landsat-8 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L8_Sensor_1"></see></summary>
    let LAI_L8_Sensor_1 = _prefix "LAI_L8_Sensor_1"
    /// <summary>
    /// LAI_L9 Sensor hosted by Landsat-9 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L9_Sensor_1"></see></summary>
    let LAI_L9_Sensor_1 = _prefix "LAI_L9_Sensor_1"
    /// <summary>
    /// LAI_S2 Sensor hosted by Sentinel-2 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_S2_Sensor_1"></see></summary>
    let LAI_S2_Sensor_1 = _prefix "LAI_S2_Sensor_1"
    /// <summary>
    /// Sensor LAI_g hosted by LAI_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Sensor_1"></see></summary>
    let LAI_g_Sensor_1 = _prefix "LAI_g_Sensor_1"
    /// <summary>
    /// Sensor LAI_dhp hosted by LAI_Station_3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_3"></see></summary>
    let LAI_dhp_Sensor_3 = _prefix "LAI_dhp_Sensor_3"
    /// <summary>
    /// Sensor LAI_dhp hosted by LAI_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_1"></see></summary>
    let LAI_dhp_Sensor_1 = _prefix "LAI_dhp_Sensor_1"
    /// <summary>
    /// Sensor LAI_dhp hosted by LAI_Station_2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Sensor_2"></see></summary>
    let LAI_dhp_Sensor_2 = _prefix "LAI_dhp_Sensor_2"
    /// <summary>
    /// N2_g Sensor hosted by N2_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_g_Sensor_1"></see></summary>
    let N2_g_Sensor_1 = _prefix "N2_g_Sensor_1"
    /// <summary>
    /// NDVI_16days_250m_a Sensor hosted by MODIS-Aqua Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_a_Sensor_1"></see></summary>
    let NDVI_16days_250m_a_Sensor_1 = _prefix "NDVI_16days_250m_a_Sensor_1"
    /// <summary>
    /// Sensor NDVI UAV Multispectral hosted by UAV Multispectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_UAV_Multispectral_Sensor_1"></see></summary>
    let NDVI_UAV_Multispectral_Sensor_1 = _prefix "NDVI_UAV_Multispectral_Sensor_1"
    /// <summary>
    /// NDVI_16days_1km_t Sensor hosted by MODIS-TerraProduct_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_t_Sensor_1"></see></summary>
    let NDVI_16days_1km_t_Sensor_1 = _prefix "NDVI_16days_1km_t_Sensor_1"
    /// <summary>
    /// NDVI_L9 Sensor hosted by Landsat-9 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L9_Sensor_1"></see></summary>
    let NDVI_L9_Sensor_1 = _prefix "NDVI_L9_Sensor_1"
    /// <summary>
    /// NDVI_S2 Sensor hosted by Sentinel-2 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_S2_Sensor_1"></see></summary>
    let NDVI_S2_Sensor_1 = _prefix "NDVI_S2_Sensor_1"
    /// <summary>
    /// NDVI_diary_500m_t Sensor hosted by MODIS-TerraProduct_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_t_Sensor_1"></see></summary>
    let NDVI_diary_500m_t_Sensor_1 = _prefix "NDVI_diary_500m_t_Sensor_1"
    /// <summary>
    /// NDVI_L8 Sensor hosted by Landsat-8 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L8_Sensor_1"></see></summary>
    let NDVI_L8_Sensor_1 = _prefix "NDVI_L8_Sensor_1"
    /// <summary>
    /// NDVI_diary_500m_a Sensor hosted by MODIS-Aqua Product_11
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_a_Sensor_1"></see></summary>
    let NDVI_diary_500m_a_Sensor_1 = _prefix "NDVI_diary_500m_a_Sensor_1"
    /// <summary>
    /// NDVI_16days_1km_a Sensor hosted by MODIS-Aqua Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_a_Sensor_1"></see></summary>
    let NDVI_16days_1km_a_Sensor_1 = _prefix "NDVI_16days_1km_a_Sensor_1"
    /// <summary>
    /// NDVI_16days_500m_t Sensor hosted by MODIS-TerraProduct_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_t_Sensor_1"></see></summary>
    let NDVI_16days_500m_t_Sensor_1 = _prefix "NDVI_16days_500m_t_Sensor_1"
    /// <summary>
    /// NDVI_16days_250m_t Sensor hosted by MODIS-TerraProduct_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_t_Sensor_1"></see></summary>
    let NDVI_16days_250m_t_Sensor_1 = _prefix "NDVI_16days_250m_t_Sensor_1"
    /// <summary>
    /// NDVI_16days_500m_a Sensor hosted by MODIS-Aqua Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_a_Sensor_1"></see></summary>
    let NDVI_16days_500m_a_Sensor_1 = _prefix "NDVI_16days_500m_a_Sensor_1"
    /// <summary>
    /// Sensor SurfaceAlbedo_g_RAD hosted by RAD_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SurfaceAlbedo_g_RAD_Sensor_1"></see></summary>
    let SurfaceAlbedo_g_RAD_Sensor_1 = _prefix "SurfaceAlbedo_g_RAD_Sensor_1"
    /// <summary>
    /// LW_down_g_RAD Sensor hosted by RAD_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_down_g_RAD_Sensor_1"></see></summary>
    let LW_down_g_RAD_Sensor_1 = _prefix "LW_down_g_RAD_Sensor_1"
    /// <summary>
    /// SW_down_g_RAD Sensor hosted by RAD_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_down_g_RAD_Sensor_1"></see></summary>
    let SW_down_g_RAD_Sensor_1 = _prefix "SW_down_g_RAD_Sensor_1"
    /// <summary>
    /// Class that represents all Land Surface properties (Temperature, Emissivity,  Aspect , Slope, Elevation ...)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Surface_Property"></see></summary>
    let Land_Surface_Property = _prefix "Land_Surface_Property"
    /// <summary>
    /// Sensor LSE_g hosted by LSE_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_1"></see></summary>
    let LSE_g_Sensor_1 = _prefix "LSE_g_Sensor_1"
    /// <summary>
    /// Sensor LSE_g hosted by LSE_Station_4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_4"></see></summary>
    let LSE_g_Sensor_4 = _prefix "LSE_g_Sensor_4"
    /// <summary>
    /// Sensor LSE_g hosted by LSE_Station_5
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_5"></see></summary>
    let LSE_g_Sensor_5 = _prefix "LSE_g_Sensor_5"
    /// <summary>
    /// Sensor LSE_g hosted by LSE_Station_2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_2"></see></summary>
    let LSE_g_Sensor_2 = _prefix "LSE_g_Sensor_2"
    /// <summary>
    /// Sensor LSE_g hosted by LSE_Station_3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_3"></see></summary>
    let LSE_g_Sensor_3 = _prefix "LSE_g_Sensor_3"
    /// <summary>
    /// Sensor LSE_g hosted by LSE_Station_6
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g_Sensor_6"></see></summary>
    let LSE_g_Sensor_6 = _prefix "LSE_g_Sensor_6"
    /// <summary>
    /// LST_L9 Sensor hosted by Landsat-9 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L9_Sensor_1"></see></summary>
    let LST_L9_Sensor_1 = _prefix "LST_L9_Sensor_1"
    /// <summary>
    /// LST_S3 Sensor hosted by Sentinel-3_SLSTR Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_S3_Sensor_1"></see></summary>
    let LST_S3_Sensor_1 = _prefix "LST_S3_Sensor_1"
    /// <summary>
    /// LST_L8 Sensor hosted by Landsat-8 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L8_Sensor_1"></see></summary>
    let LST_L8_Sensor_1 = _prefix "LST_L8_Sensor_1"
    /// <summary>
    /// LST_8days_1km_a Sensor hosted by MODIS-Aqua Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_a_Sensor_1"></see></summary>
    let LST_8days_1km_a_Sensor_1 = _prefix "LST_8days_1km_a_Sensor_1"
    /// <summary>
    /// LST_8days_1km_t Sensor hosted by MODIS-TerraProduct_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_t_Sensor_1"></see></summary>
    let LST_8days_1km_t_Sensor_1 = _prefix "LST_8days_1km_t_Sensor_1"
    /// <summary>
    /// LST_diary_1km_t Sensor hosted by MODIS-TerraProduct_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_t_Sensor_1"></see></summary>
    let LST_diary_1km_t_Sensor_1 = _prefix "LST_diary_1km_t_Sensor_1"
    /// <summary>
    /// LST_diary_1km_a Sensor hosted by MODIS-Aqua Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_a_Sensor_1"></see></summary>
    let LST_diary_1km_a_Sensor_1 = _prefix "LST_diary_1km_a_Sensor_1"
    /// <summary>
    /// Sensor LST UAV Thermal  hosted by UAV Thermal 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_UAV_Thermal_Sensor_1"></see></summary>
    let LST_UAV_Thermal_Sensor_1 = _prefix "LST_UAV_Thermal_Sensor_1"
    /// <summary>
    /// LST_g Sensor hosted by LST_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_g_Sensor_1"></see></summary>
    let LST_g_Sensor_1 = _prefix "LST_g_Sensor_1"

    /// <summary>
    /// Class that represents all Land Atmosphere Interation properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Atmosphere_Interaction_Property"></see></summary>
    let Land_Atmosphere_Interaction_Property =
        _prefix "Land_Atmosphere_Interaction_Property"

    /// <summary>
    /// Sensor WaterVapourFlux_g_EddyCovariance hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WaterVapourFlux_g_EddyCovariance_Sensor_1"></see></summary>
    let WaterVapourFlux_g_EddyCovariance_Sensor_1 =
        _prefix "WaterVapourFlux_g_EddyCovariance_Sensor_1"

    /// <summary>
    /// Sensor Clock_AEMET hosted by AEMET_UTIEL_Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Clock_AEMET_Sensor_UTIEL"></see></summary>
    let Clock_AEMET_Sensor_UTIEL = _prefix "Clock_AEMET_Sensor_UTIEL"
    /// <summary>
    /// Sensor LE_g_EddyCovariance hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LE_g_EddyCovariance_Sensor_1"></see></summary>
    let LE_g_EddyCovariance_Sensor_1 = _prefix "LE_g_EddyCovariance_Sensor_1"
    /// <summary>
    /// LW_up_g_RAD Sensor hosted by RAD_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_up_g_RAD_Sensor_1"></see></summary>
    let LW_up_g_RAD_Sensor_1 = _prefix "LW_up_g_RAD_Sensor_1"
    /// <summary>
    /// Sensor SW_up_g_RAD hosted by RAD_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_up_g_RAD_Sensor_1"></see></summary>
    let SW_up_g_RAD_Sensor_1 = _prefix "SW_up_g_RAD_Sensor_1"
    /// <summary>
    /// Sensor FCOVER_dhp hosted by DHP_Station_3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_3"></see></summary>
    let FCOVER_dhp_Sensor_3 = _prefix "FCOVER_dhp_Sensor_3"
    /// <summary>
    /// Sensor FCOVER_dhp hosted by DHP_Station_2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_2"></see></summary>
    let FCOVER_dhp_Sensor_2 = _prefix "FCOVER_dhp_Sensor_2"
    /// <summary>
    /// Sensor FCOVER_dhp hosted by DHP_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Sensor_1"></see></summary>
    let FCOVER_dhp_Sensor_1 = _prefix "FCOVER_dhp_Sensor_1"
    /// <summary>
    /// Sensor WindVane_EddyCovariance hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_EddyCovariance_Sensor_1"></see></summary>
    let WindVane_EddyCovariance_Sensor_1 = _prefix "WindVane_EddyCovariance_Sensor_1"
    /// <summary>
    /// Sensor WindVane_AEMET hosted by AEMET_UTIEL_Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_AEMET_Sensor_UTIEL"></see></summary>
    let WindVane_AEMET_Sensor_UTIEL = _prefix "WindVane_AEMET_Sensor_UTIEL"

    /// <summary>
    /// Sensor Anemometer_EddyCovariance hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_EddyCovariance_Sensor_1"></see></summary>
    let Anemometer_EddyCovariance_Sensor_1 =
        _prefix "Anemometer_EddyCovariance_Sensor_1"

    /// <summary>
    /// Sensor Anemometer_AEMET hosted by AEMET_UTIEL_Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_AEMET_Sensor_UTIEL"></see></summary>
    let Anemometer_AEMET_Sensor_UTIEL = _prefix "Anemometer_AEMET_Sensor_UTIEL"
    /// <summary>
    /// Sensor Pluviometer_AEMET hosted by AEMET_UTIEL_Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Pluviometer_AEMET_Sensor_UTIEL"></see></summary>
    let Pluviometer_AEMET_Sensor_UTIEL = _prefix "Pluviometer_AEMET_Sensor_UTIEL"

    /// <summary>
    /// Hygrometer_EddyCovariance Sensor hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_EddyCovariance_Sensor_1"></see></summary>
    let Hygrometer_EddyCovariance_Sensor_1 =
        _prefix "Hygrometer_EddyCovariance_Sensor_1"

    /// <summary>
    /// Sensor Hygrometer_AEMET hosted by AEMET_UTIEL_Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_AEMET_Sensor_UTIEL"></see></summary>
    let Hygrometer_AEMET_Sensor_UTIEL = _prefix "Hygrometer_AEMET_Sensor_UTIEL"
    /// <summary>
    /// Hs_g_EddyCovariance Sensor hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hs_g_EddyCovariance_Sensor_1"></see></summary>
    let Hs_g_EddyCovariance_Sensor_1 = _prefix "Hs_g_EddyCovariance_Sensor_1"

    /// <summary>
    /// Sensor CarbonDioxideFlux_g_EddyCovariance hosted by EddyCovariance_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CarbonDioxideFlux_g_EddyCovariance_Sensor_1"></see></summary>
    let CarbonDioxideFlux_g_EddyCovariance_Sensor_1 =
        _prefix "CarbonDioxideFlux_g_EddyCovariance_Sensor_1"

    /// <summary>
    /// A Control Area is a spatially delimited region designated to enable consistent environmental observations, calibration activities, and cross-platform validation. It provides a reference zone where measurements can be collected under controlled or well-characterized conditions. Dimension 10 x10.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#10km_x_10km"></see></summary>
    let _10km_x_10km = _prefix "10km_x_10km"
    /// <summary>
    /// Geometry for Area 10x10
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoArea10x10"></see></summary>
    let GeoArea10x10 = _prefix "GeoArea10x10"
    /// <summary>
    /// A Control Area is a spatially delimited region designated to enable consistent environmental observations, calibration activities, and cross-platform validation. It provides a reference zone where measurements can be collected under controlled or well-characterized conditions.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#ControlArea"></see></summary>
    let ControlArea = _prefix "ControlArea"
    /// <summary>
    /// Indicates the province in which a sensor is located.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedInProvince"></see></summary>
    let locatedInProvince = _prefix "locatedInProvince"
    /// <summary>
    /// A Control Area is a spatially delimited region designated to enable consistent environmental observations, calibration activities, and cross-platform validation. It provides a reference zone where measurements can be collected under controlled or well-characterized conditions. Dimension 1 x1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#1km_x_1km"></see></summary>
    let _1km_x_1km = _prefix "1km_x_1km"
    /// <summary>
    /// Geometry for Area 1x1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoArea1x1"></see></summary>
    let GeoArea1x1 = _prefix "GeoArea1x1"
    /// <summary>
    /// Indicates the municipality in which a sensor is located.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#locatedInMunicipality"></see></summary>
    let locatedInMunicipality = _prefix "locatedInMunicipality"
    /// <summary>
    /// The meteorological station named "La Cubera" is close to the municipality of 'Utiel', at an altitude of 758 meters above sea level, and near Vereda Real, Casa de la Cubera, Camino de la Solana, Camino de Cuenca, La Solana, Caz del Soto Magro, Rambla del Colmenar, Casas de Santa Bárbara, Cañada del Campo, La Vega….
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AEMET_UTIEL_Station"></see></summary>
    let AEMET_UTIEL_Station = _prefix "AEMET_UTIEL_Station"
    /// <summary>
    /// Geometry for AEMET_UTIEL Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoAEMET_UTIEL_Station"></see></summary>
    let GeoAEMET_UTIEL_Station = _prefix "GeoAEMET_UTIEL_Station"
    /// <summary>
    /// Control Area indicates if it is 1x1 km or 10x10 km in VAS.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#controlArea"></see></summary>
    let controlArea = _prefix "controlArea"
    /// <summary>
    /// The property indicates the type of cover classes.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasTypeOfCover"></see></summary>
    let hasTypeOfCover = _prefix "hasTypeOfCover"
    /// <summary>
    /// Result that normally is obtained by AGB sensors. Unit of measure Unit of measure Mg/ha (Milligram per Hectare)..
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_Result"></see></summary>
    let AGB_Result = _prefix "AGB_Result"
    /// <summary>
    /// Represents the general sensorization of satellite SMOS. Observes AGB, DroughtIndex, Soil Moisture.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_SMOS"></see></summary>
    let RS_SMOS = _prefix "RS_SMOS"
    /// <summary>
    /// SMOS Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Product_1"></see></summary>
    let SMOS_Product_1 = _prefix "SMOS_Product_1"
    /// <summary>
    /// Represents the general sensorization of RS_UAV_Hyperspectral. Observes  NRI,  CRI, NDWI, AGB. DiseaseStatus.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Hyperspectral"></see></summary>
    let RS_UAV_Hyperspectral = _prefix "RS_UAV_Hyperspectral"
    /// <summary>
    /// UAV Hyperspectral platform.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral_1"></see></summary>
    let UAV_Hyperspectral_1 = _prefix "UAV_Hyperspectral_1"
    /// <summary>
    /// Represents the general sensorization of RS_UAV_LiDAR. Observes  CHM, DTM, DSM. DBH, AGB.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_LiDAR"></see></summary>
    let RS_UAV_LiDAR = _prefix "RS_UAV_LiDAR"
    /// <summary>
    /// UAV LiDAR platform.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR_1"></see></summary>
    let UAV_LiDAR_1 = _prefix "UAV_LiDAR_1"
    /// <summary>
    /// Class that represents observations related to AGB (Aboveground Biomass) . Unit of measure Mg/ha (Milligram per Hectare).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#AGB_UAV_Observation"></see></summary>
    let AGB_UAV_Observation = _prefix "AGB_UAV_Observation"
    /// <summary>
    /// Observation collected by dron engine.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Observation"></see></summary>
    let UAV_Observation = _prefix "UAV_Observation"
    /// <summary>
    /// Measures the intensity (m/s) of the wind
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Anemometer_EddyCovariance"></see></summary>
    let Anemometer_EddyCovariance = _prefix "Anemometer_EddyCovariance"
    /// <summary>
    /// Eddy covariance systems measure the exchange of CO2, H2O, CH4 , and energy between the earth’s surface and the atmosphere, empowering researchers to advance scientific understanding of climate and ecosystem dynamics
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EddyCovariance_Station"></see></summary>
    let EddyCovariance_Station = _prefix "EddyCovariance_Station"
    /// <summary>
    /// EddyCovariance Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EddyCovariance_Station_1"></see></summary>
    let EddyCovariance_Station_1 = _prefix "EddyCovariance_Station_1"
    /// <summary>
    /// Land Cover Classes, Level 3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Cover_Classes"></see></summary>
    let Land_Cover_Classes = _prefix "Land_Cover_Classes"
    /// <summary>
    /// Corine Land Cover (CLC) code.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#code_CLC"></see></summary>
    let code_CLC = _prefix "code_CLC"

    /// <summary>
    /// Class that represents observations related to Atmospheric humidity in AEMET Station.  Percent Relative Humidity
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_AEMET_Observation"></see></summary>
    let Atmospheric_Humidity_AEMET_Observation =
        _prefix "Atmospheric_Humidity_AEMET_Observation"

    /// <summary>
    /// Class that represents observations related to Atmospheric humidity.Unit of measure Percent Relative Humidity.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_Observation"></see></summary>
    let Atmospheric_Humidity_Observation = _prefix "Atmospheric_Humidity_Observation"

    /// <summary>
    /// Class that represents observations related to Atmospheric humidity in EddyCovariance Station (Gram Per Cubic Metre )
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_EddyCovariance_Observation"></see></summary>
    let Atmospheric_Humidity_EddyCovariance_Observation =
        _prefix "Atmospheric_Humidity_EddyCovariance_Observation"

    /// <summary>
    /// Sensor belongs to EddyCovariance Station. Measures relative humidity in %
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hygrometer_EddyCovariance"></see></summary>
    let Hygrometer_EddyCovariance = _prefix "Hygrometer_EddyCovariance"
    /// <summary>
    /// Result that is normally obtained by Hygrometer sensors. Unit of measure Percent Relative Humidity.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Humidity_Result"></see></summary>
    let Atmospheric_Humidity_Result = _prefix "Atmospheric_Humidity_Result"
    /// <summary>
    /// Observation collected in situ.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Ground_based_Observation"></see></summary>
    let Ground_based_Observation = _prefix "Ground_based_Observation"

    /// <summary>
    /// Class that represents observations related to Atmospheric pressure in AEMET Station. Unit of measure Hectopascal (hPa).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_AEMET_Observation"></see></summary>
    let Atmospheric_Pressure_AEMET_Observation =
        _prefix "Atmospheric_Pressure_AEMET_Observation"

    /// <summary>
    /// Result that is normally obtained by Barometer sensors. Unit of measure Hectopascal (hPa).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_AEMET_Result"></see></summary>
    let Atmospheric_Pressure_AEMET_Result = _prefix "Atmospheric_Pressure_AEMET_Result"
    /// <summary>
    /// Class that represents observations related to Atmospheric pressure
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_Observation"></see></summary>
    let Atmospheric_Pressure_Observation = _prefix "Atmospheric_Pressure_Observation"

    /// <summary>
    /// Class that represents observations related to Atmospheric pressure in EddyCovariance Station. Unit of measure Kilopascal (kPa).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_EddyCovariance_Observation"></see></summary>
    let Atmospheric_Pressure_EddyCovariance_Observation =
        _prefix "Atmospheric_Pressure_EddyCovariance_Observation"

    /// <summary>
    /// Result that is normally obtained by Barometer sensors. Unit of measure Kilopascal (kPa).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Atmospheric_Pressure_EddyCovariance_Result"></see></summary>
    let Atmospheric_Pressure_EddyCovariance_Result =
        _prefix "Atmospheric_Pressure_EddyCovariance_Result"

    /// <summary>
    /// Measures pressure in kPa. EddyCovariance Station.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Barometer_EddyCovariance"></see></summary>
    let Barometer_EddyCovariance = _prefix "Barometer_EddyCovariance"
    /// <summary>
    /// Result that normally is obtained by CHM sensors. Unit of measure Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_Result"></see></summary>
    let CHM_Result = _prefix "CHM_Result"
    /// <summary>
    /// Sensor CHM UAV LiDAR  hosted by UAV LiDAR 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_UAV_LiDAR_Sensor_1"></see></summary>
    let CHM_UAV_LiDAR_Sensor_1 = _prefix "CHM_UAV_LiDAR_Sensor_1"
    /// <summary>
    /// Canopy Height Model (CHM)
    /// The CHM is a derived LiDAR product that represents vegetation height above ground, computed as the difference between the DSM and the DTM:
    ///
    /// CHM = DSM − DTM
    ///
    /// It is delivered as a raster map in meters (m).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Canopy_Height_Model"></see></summary>
    let Canopy_Height_Model = _prefix "Canopy_Height_Model"
    /// <summary>
    /// Class that represents observations related to CHM (Canopy Height Model). Unit of measure Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CHM_UAV_Observation"></see></summary>
    let CHM_UAV_Observation = _prefix "CHM_UAV_Observation"
    /// <summary>
    /// Result that normally is obtained by CRI sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_Result"></see></summary>
    let CRI_Result = _prefix "CRI_Result"
    /// <summary>
    /// Class that represents observations related to CRI (Carotenoide). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CRI_UAV_Observation"></see></summary>
    let CRI_UAV_Observation = _prefix "CRI_UAV_Observation"
    /// <summary>
    /// Sensor that takes carbon dioxide flow measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CarbonDioxideFlux_g"></see></summary>
    let CarbonDioxideFlux_g = _prefix "CarbonDioxideFlux_g"
    /// <summary>
    /// Class that represents observations related to Carbon dioxide flux (mg / (m2s))
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Carbon_Dioxide_Flux_Observation"></see></summary>
    let Carbon_Dioxide_Flux_Observation = _prefix "Carbon_Dioxide_Flux_Observation"
    /// <summary>
    /// Result that is normally obtained by CarbonDioxideFlux (carbon dioxide flux) sensors. Unit of measure Milligrams per Square Metre per Second,
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Carbon_Dioxide_flux_Result"></see></summary>
    let Carbon_Dioxide_flux_Result = _prefix "Carbon_Dioxide_flux_Result"
    /// <summary>
    /// Sensor that takes Chl measurements from Landsat-8.
    /// Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L8_Observation"></see></summary>
    let Chl_L8_Observation = _prefix "Chl_L8_Observation"
    /// <summary>
    /// Represents the general sensorization of satellite Landsat-8. Observes Chl, EVI, FAPAR, LAI, LST, NDVI, ,SAVI, SR, TDVI ...
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Landsat-8"></see></summary>
    let ``RS_Landsat-8`` = _prefix "RS_Landsat-8"
    /// <summary>
    /// Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Satellite_Observation"></see></summary>
    let Chl_Satellite_Observation = _prefix "Chl_Satellite_Observation"
    /// <summary>
    /// Landsat-8 Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Product_1"></see></summary>
    let ``Landsat-8_Product_1`` = _prefix "Landsat-8_Product_1"
    /// <summary>
    /// Sensor that takes Chl measurements from Lamdsat-9.
    /// Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_L9_Observation"></see></summary>
    let Chl_L9_Observation = _prefix "Chl_L9_Observation"
    /// <summary>
    /// Represents the general sensorization of satellite Lansat-9.Observes Chl, EVI, FAPAR, LAI, LST, NDVI, ,SAVI, SR, TDVI ...
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Landsat-9"></see></summary>
    let ``RS_Landsat-9`` = _prefix "RS_Landsat-9"
    /// <summary>
    /// Landsat-9 Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Product_1"></see></summary>
    let ``Landsat-9_Product_1`` = _prefix "Landsat-9_Product_1"
    /// <summary>
    /// Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Observation"></see></summary>
    let Chl_Observation = _prefix "Chl_Observation"
    /// <summary>
    /// Result that is normally obtained by Chl (Chlorophyll content) sensors. Micromoles of chlorophyll per square metre of leaf surface.Unit of measure Micromoles per Square Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Result"></see></summary>
    let Chl_Result = _prefix "Chl_Result"
    /// <summary>
    /// Sensor that takes Chlorophyll measurements. From Chl Station.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_g"></see></summary>
    let Chl_g = _prefix "Chl_g"
    /// <summary>
    /// Sensor that takes Chlorophyll measurements from Sentinel-2.
    /// Class that represents observations related to Chlorophyll content. Micromoles of chlorophyll per square metre of leaf surface.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_S2_Observation"></see></summary>
    let Chl_S2_Observation = _prefix "Chl_S2_Observation"
    /// <summary>
    /// Represents the general sensorization of satellite Sentinel 2 or  S2. Observes Chl, EVI, FAPAR, LAI, LandCover, NDVI, SAVI, SR ...
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-2"></see></summary>
    let ``RS_Sentinel-2`` = _prefix "RS_Sentinel-2"
    /// <summary>
    /// Sentinel-2 Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Product_1"></see></summary>
    let ``Sentinel-2_Product_1`` = _prefix "Sentinel-2_Product_1"
    /// <summary>
    /// Result that is normally obtained by Chl (Chlorophyll content) sensors. Micromoles of chlorophyll per square metre of leaf surface. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Satellite_Result"></see></summary>
    let Chl_Satellite_Result = _prefix "Chl_Satellite_Result"
    /// <summary>
    /// Observation collected by satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite_Observation"></see></summary>
    let Satellite_Observation = _prefix "Satellite_Observation"
    /// <summary>
    /// Class that represents Chlorophyll content stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Station"></see></summary>
    let Chl_Station = _prefix "Chl_Station"
    /// <summary>
    /// Chl Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Chl_Station_1"></see></summary>
    let Chl_Station_1 = _prefix "Chl_Station_1"
    /// <summary>
    /// Geometry for ChlStation1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoChlStation1"></see></summary>
    let GeoChlStation1 = _prefix "GeoChlStation1"
    /// <summary>
    /// Sensor that takes CloudMask measurements from METEOSAT.
    /// Class that represents observations related to cloud mask. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_METEOSAT_Observation"></see></summary>
    let CloudMask_METEOSAT_Observation = _prefix "CloudMask_METEOSAT_Observation"
    /// <summary>
    /// Result that normally is obtained by CloudMask_METEOSAT sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_Result"></see></summary>
    let CloudMask_Result = _prefix "CloudMask_Result"
    /// <summary>
    /// A 'cloud mask' in remote sensing refers to a technique or dataset used to identify and delineate areas covered by clouds in an image captured from a satellite or other observation platform. This technique is crucial in remote sensing as clouds can obstruct visibility of the Earth's surface, making it challenging to interpret images and analyze data."
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloud_mask"></see></summary>
    let cloud_mask = _prefix "cloud_mask"
    /// <summary>
    /// Represents the general sensorization of satellite METEOSAT. Observes CloudMask, CloudType and PWC.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_METEOSAT"></see></summary>
    let RS_METEOSAT = _prefix "RS_METEOSAT"
    /// <summary>
    /// CloudMask_METEOSAT Sensor hosted by METEOSAT Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudMask_METEOSAT_Sensor_1"></see></summary>
    let CloudMask_METEOSAT_Sensor_1 = _prefix "CloudMask_METEOSAT_Sensor_1"
    /// <summary>
    /// METEOSAT Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Product_1"></see></summary>
    let METEOSAT_Product_1 = _prefix "METEOSAT_Product_1"
    /// <summary>
    /// Sensor that takes CloudType measurements from METEOSAT.
    /// Class that represents observations related to cloud mask. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_METEOSAT_Observation"></see></summary>
    let CloudType_METEOSAT_Observation = _prefix "CloudType_METEOSAT_Observation"
    /// <summary>
    /// Result that normally is obtained by by CloudType_METEOSAT sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_Result"></see></summary>
    let CloudType_Result = _prefix "CloudType_Result"
    /// <summary>
    /// "'Cloud type' in remote sensing refers to the classification or categorization of clouds based on their visual characteristics and structural features observed in satellite or aerial imagery.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloud_type"></see></summary>
    let cloud_type = _prefix "cloud_type"
    /// <summary>
    /// CloudType_METEOSAT Sensor hosted by METEOSAT Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#CloudType_METEOSAT_Sensor_1"></see></summary>
    let CloudType_METEOSAT_Sensor_1 = _prefix "CloudType_METEOSAT_Sensor_1"
    /// <summary>
    /// Result that normally is obtained by DBH sensors. Unit of measure Centimetre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_Result"></see></summary>
    let DBH_Result = _prefix "DBH_Result"
    /// <summary>
    /// Class that represents observations related to DBH (Diameter at Breast Height). Unit of measure Centimetre
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DBH_UAV_Observation"></see></summary>
    let DBH_UAV_Observation = _prefix "DBH_UAV_Observation"
    /// <summary>
    /// Class that represents Digital Hemispheric Picture (DHP) stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station"></see></summary>
    let DHP_Station = _prefix "DHP_Station"
    /// <summary>
    /// Sensor that takes fraction of surface downwelling photosynthetic radiative measurements. From Digital Hemispheric Picture (DHP) Station.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp"></see></summary>
    let FAPAR_dhp = _prefix "FAPAR_dhp"
    /// <summary>
    /// Sensor that takes vegetation area fraction measurements. From Digital Hemispheric Picture (DHP) Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp"></see></summary>
    let FCOVER_dhp = _prefix "FCOVER_dhp"
    /// <summary>
    /// Leaf Area Index Sensor from Digital Hemispheric Picture (DHP) Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp"></see></summary>
    let LAI_dhp = _prefix "LAI_dhp"
    /// <summary>
    /// DHP Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_1"></see></summary>
    let DHP_Station_1 = _prefix "DHP_Station_1"
    /// <summary>
    /// Geometry for DHPStation1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation1"></see></summary>
    let GeoDHPStation1 = _prefix "GeoDHPStation1"
    /// <summary>
    /// DHP Station number 2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_2"></see></summary>
    let DHP_Station_2 = _prefix "DHP_Station_2"
    /// <summary>
    /// Geometry for DHPStation2.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation2"></see></summary>
    let GeoDHPStation2 = _prefix "GeoDHPStation2"
    /// <summary>
    /// DHP Station number 3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DHP_Station_3"></see></summary>
    let DHP_Station_3 = _prefix "DHP_Station_3"
    /// <summary>
    /// Geometry for DHPStation3.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoDHPStation3"></see></summary>
    let GeoDHPStation3 = _prefix "GeoDHPStation3"
    /// <summary>
    /// Result that normally is obtained by DSM sensors. Unit of measure Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_Result"></see></summary>
    let DSM_Result = _prefix "DSM_Result"
    /// <summary>
    /// Sensor DSM UAV LiDAR  hosted by UAV LiDAR 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_UAV_LiDAR_Sensor_1"></see></summary>
    let DSM_UAV_LiDAR_Sensor_1 = _prefix "DSM_UAV_LiDAR_Sensor_1"
    /// <summary>
    /// Digital Surface Model (DSM).
    /// A DSM is a LiDAR-derived raster representing the elevation of the uppermost surfaces in the scene, including vegetation, buildings, and all above-ground objects. Pixel values correspond to absolute height in meters (m).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Digital_Surface_Model"></see></summary>
    let Digital_Surface_Model = _prefix "Digital_Surface_Model"
    /// <summary>
    /// Class that represents observations related to DSM (Digital Surface Model).Unit of measure Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DSM_UAV_Observation"></see></summary>
    let DSM_UAV_Observation = _prefix "DSM_UAV_Observation"
    /// <summary>
    /// Result that normally is obtained by DTM sensors.Unit of measure Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_Result"></see></summary>
    let DTM_Result = _prefix "DTM_Result"
    /// <summary>
    /// Sensor DTM UAV LiDAR  hosted by UAV LiDAR 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_UAV_LiDAR_Sensor_1"></see></summary>
    let DTM_UAV_LiDAR_Sensor_1 = _prefix "DTM_UAV_LiDAR_Sensor_1"
    /// <summary>
    /// Digital Terrain Model (DTM).
    /// A DTM is a LiDAR-derived raster representing the elevation of the bare ground surface, with vegetation and artificial structures removed. Each pixel stores the ground height expressed in meters (m).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Digital_Terrain_Model"></see></summary>
    let Digital_Terrain_Model = _prefix "Digital_Terrain_Model"
    /// <summary>
    /// Class that represents observations related to DTM (Digital Terrain Model).Unit of measure Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DTM_UAV_Observation"></see></summary>
    let DTM_UAV_Observation = _prefix "DTM_UAV_Observation"
    /// <summary>
    /// Class that represents observations related to Diffuse radiation (W/m2)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Diffuse_Irradiance_Observation"></see></summary>
    let Diffuse_Irradiance_Observation = _prefix "Diffuse_Irradiance_Observation"
    /// <summary>
    /// Result that is normally obtained by I_dif sensors. Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Diffuse_Irradiance_Result"></see></summary>
    let Diffuse_Irradiance_Result = _prefix "Diffuse_Irradiance_Result"
    /// <summary>
    /// Sensor that takes "diffuse irradiance at the surface" measurements in RAD Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dif_g"></see></summary>
    let I_dif_g = _prefix "I_dif_g"
    /// <summary>
    /// Class that represents observations related to Direct solar radiation (W/m2)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Direct_Irradiance_Observation"></see></summary>
    let Direct_Irradiance_Observation = _prefix "Direct_Irradiance_Observation"
    /// <summary>
    /// Result that is normally obtained by I_dir sensors. Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Direct_Irradiance_Result"></see></summary>
    let Direct_Irradiance_Result = _prefix "Direct_Irradiance_Result"
    /// <summary>
    /// Sensor that takes "direct irradiance at the surface" measurements in RAD Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#I_dir_g"></see></summary>
    let I_dir_g = _prefix "I_dir_g"
    /// <summary>
    /// Result that normally is obtained by DiseaseStatus sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_Result"></see></summary>
    let DiseaseStatus_Result = _prefix "DiseaseStatus_Result"
    /// <summary>
    /// Class that represents observations related to DiseaseStatus. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#DiseaseStatus_UAV_Observation"></see></summary>
    let DiseaseStatus_UAV_Observation = _prefix "DiseaseStatus_UAV_Observation"
    /// <summary>
    /// Result that is normally obtained by Heliograph sensors in AEMET Station. Unit of measure Hour.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Duration_of_Sunshine_AEMET_Result"></see></summary>
    let Duration_of_Sunshine_AEMET_Result = _prefix "Duration_of_Sunshine_AEMET_Result"
    /// <summary>
    /// Sensor that takes EVI measurements from Landsat-8.
    /// Class that represents observations related to Enhanced Vegetation Index (EVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L8_Observation"></see></summary>
    let EVI_L8_Observation = _prefix "EVI_L8_Observation"
    /// <summary>
    /// Class that represents observations related to Enhanced Vegetation Index (EVI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_Satellite_Observation"></see></summary>
    let EVI_Satellite_Observation = _prefix "EVI_Satellite_Observation"
    /// <summary>
    /// Sensor that takes EVI measurements from  Landsat-9.
    /// Class that represents observations related to Enhanced Vegetation Index (EVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_L9_Observation"></see></summary>
    let EVI_L9_Observation = _prefix "EVI_L9_Observation"
    /// <summary>
    /// Sensor that takes Enhanced Vegetation Index (EVI) measurements from MODIS-Aqua.
    /// Daily temporality, resolution 500 m, product MYD09GA_006_EVI
    /// Class that represents observations related to Enhanced Vegetation Index (EVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_MODIS-Aqua_Observation"></see></summary>
    let ``EVI_MODIS-Aqua_Observation`` = _prefix "EVI_MODIS-Aqua_Observation"
    /// <summary>
    /// Represents the general sensorization of satellite MODIS-Aqua. Observes EVI , FAPAR, LST, NDVI, ...
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_MODIS-Aqua"></see></summary>
    let ``RS_MODIS-Aqua`` = _prefix "RS_MODIS-Aqua"
    /// <summary>
    /// Sensor that takes Enhanced Vegetation Index (EVI) measurements from MODIS-Terra.
    /// Daily temporality, 500 m resolution, product MYD09GA_006_EVI
    /// Class that represents observations related to Enhanced Vegetation Index (EVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_MODIS-Terra_Observation"></see></summary>
    let ``EVI_MODIS-Terra_Observation`` = _prefix "EVI_MODIS-Terra_Observation"
    /// <summary>
    /// Represents the general sensorization of satellite MODIS-Terra. Observes EVI , FAPAR, LST, NDVI,  ...
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_MODIS-Terra"></see></summary>
    let ``RS_MODIS-Terra`` = _prefix "RS_MODIS-Terra"
    /// <summary>
    /// Result that is normally obtained by Enhanced Vegetation Index (EVI) sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_Result"></see></summary>
    let EVI_Result = _prefix "EVI_Result"
    /// <summary>
    /// Sensor that takes EVI measurements from Sentinel-2.
    /// Class that represents observations related to Enhanced Vegetation Index (EVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_S2_Observation"></see></summary>
    let EVI_S2_Observation = _prefix "EVI_S2_Observation"
    /// <summary>
    /// Represents the general sensorization of RS_UAV_Multispectral. Observes  EVI, FAPAR, LAI,  NDVI, ,SAVI y SR.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Multispectral"></see></summary>
    let RS_UAV_Multispectral = _prefix "RS_UAV_Multispectral"
    /// <summary>
    /// UAV Multispectral platform.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Multispectral_1"></see></summary>
    let UAV_Multispectral_1 = _prefix "UAV_Multispectral_1"
    /// <summary>
    /// Class that represents observations related to Enhanced Vegetation Index (EVI). DImensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#EVI_UAV_Observation"></see></summary>
    let EVI_UAV_Observation = _prefix "EVI_UAV_Observation"
    /// <summary>
    /// Modis-Aqua Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Product_1"></see></summary>
    let ``MODIS-Aqua_Product_1`` = _prefix "MODIS-Aqua_Product_1"
    /// <summary>
    /// MODIS-TerraProduct number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Product_1"></see></summary>
    let ``MODIS-Terra_Product_1`` = _prefix "MODIS-Terra_Product_1"
    /// <summary>
    /// Sensor that takes sensible heat flux measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Hs_g"></see></summary>
    let Hs_g = _prefix "Hs_g"
    /// <summary>
    /// Sensor that takes evapotranspiration measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LE_g"></see></summary>
    let LE_g = _prefix "LE_g"
    /// <summary>
    /// Sensor belongs to EddyCovariance Station. Measures temperature in degrees Celsius
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Thermometer_EddyCovariance"></see></summary>
    let Thermometer_EddyCovariance = _prefix "Thermometer_EddyCovariance"
    /// <summary>
    /// Sensor that takes water flow measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WaterVapourFlux_g"></see></summary>
    let WaterVapourFlux_g = _prefix "WaterVapourFlux_g"
    /// <summary>
    /// Geometry for EddyCovariance_Station1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoEddyCovariance_Station1"></see></summary>
    let GeoEddyCovariance_Station1 = _prefix "GeoEddyCovariance_Station1"
    /// <summary>
    /// Sensor that takes FAPAR measurements from  Landsat-8.
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L8_Observation"></see></summary>
    let FAPAR_L8_Observation = _prefix "FAPAR_L8_Observation"
    /// <summary>
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Satellite_Observation"></see></summary>
    let FAPAR_Satellite_Observation = _prefix "FAPAR_Satellite_Observation"
    /// <summary>
    /// Sensor that takes FAPAR measurements from  Landsat-9.
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_L9_Observation"></see></summary>
    let FAPAR_L9_Observation = _prefix "FAPAR_L9_Observation"
    /// <summary>
    /// Temporality 8 days, resolution 500 m, product MYD15A2H
    /// Sensor that takes FAPAR measurements from MODIS-Aqua.
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_MODIS-Aqua_Observation"></see></summary>
    let ``FAPAR_MODIS-Aqua_Observation`` = _prefix "FAPAR_MODIS-Aqua_Observation"
    /// <summary>
    /// Temporality 8 days, resolution 500 m, product MYD15A2H
    /// Sensor that takes FAPAR measurements from MODIS-Terra.
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_MODIS-Terra_Observation"></see></summary>
    let ``FAPAR_MODIS-Terra_Observation`` = _prefix "FAPAR_MODIS-Terra_Observation"
    /// <summary>
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Observation"></see></summary>
    let FAPAR_Observation = _prefix "FAPAR_Observation"
    /// <summary>
    /// Result that normally is obtained by fraction of absorved photosynthetically active radiation (FAPAR) sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Result"></see></summary>
    let FAPAR_Result = _prefix "FAPAR_Result"
    /// <summary>
    /// Sensor that takes FAPAR measurements from Sentinel-2.
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_S2_Observation"></see></summary>
    let FAPAR_S2_Observation = _prefix "FAPAR_S2_Observation"
    /// <summary>
    /// Class that represents fraction of absorved photosynthetically active radiation stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station"></see></summary>
    let FAPAR_Station = _prefix "FAPAR_Station"
    /// <summary>
    /// Sensor that takes fraction of surface downwelling photosynthetic radiative measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g"></see></summary>
    let FAPAR_g = _prefix "FAPAR_g"
    /// <summary>
    /// FAPAR Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_1"></see></summary>
    let FAPAR_Station_1 = _prefix "FAPAR_Station_1"
    /// <summary>
    /// Geometry of FPARStation1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation1"></see></summary>
    let GeoFaparStation1 = _prefix "GeoFaparStation1"
    /// <summary>
    /// FAPAR Station number 2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_2"></see></summary>
    let FAPAR_Station_2 = _prefix "FAPAR_Station_2"
    /// <summary>
    /// Geometry of FAPAR Station 2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation2"></see></summary>
    let GeoFaparStation2 = _prefix "GeoFaparStation2"
    /// <summary>
    /// FAPAR Station number 3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_3"></see></summary>
    let FAPAR_Station_3 = _prefix "FAPAR_Station_3"
    /// <summary>
    /// Geometry of FAPAR Station 2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation3"></see></summary>
    let GeoFaparStation3 = _prefix "GeoFaparStation3"
    /// <summary>
    /// FAPAR Station number 4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_Station_4"></see></summary>
    let FAPAR_Station_4 = _prefix "FAPAR_Station_4"
    /// <summary>
    /// Geometry of FAPAR Station 4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoFaparStation4"></see></summary>
    let GeoFaparStation4 = _prefix "GeoFaparStation4"
    /// <summary>
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_UAV_Observation"></see></summary>
    let FAPAR_UAV_Observation = _prefix "FAPAR_UAV_Observation"
    /// <summary>
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_dhp_Observation"></see></summary>
    let FAPAR_dhp_Observation = _prefix "FAPAR_dhp_Observation"
    /// <summary>
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FAPAR_g_Observation"></see></summary>
    let FAPAR_g_Observation = _prefix "FAPAR_g_Observation"
    /// <summary>
    /// Result that normally is obtained by FCOVER sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_Result"></see></summary>
    let FCOVER_Result = _prefix "FCOVER_Result"
    /// <summary>
    /// Class that represents observations related to FCOVER. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#FCOVER_dhp_Observation"></see></summary>
    let FCOVER_dhp_Observation = _prefix "FCOVER_dhp_Observation"
    /// <summary>
    /// Result that normally is obtained by Green Instantaneous Fraction of Absorved photosynthetically active Radiation (GIFAPAR) sensors.
    /// In this ontology by the Remote Sensing from Sentinel-3 OLCI ( RS_Sentinel-3_OLCI).
    /// Dimesionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_Result"></see></summary>
    let GIFAPAR_Result = _prefix "GIFAPAR_Result"
    /// <summary>
    /// Sensor that takes GIFAPAR measurements from Sentinel-3.
    /// Class that represents observations related to Green Instantaneous Fraction of Absorbed Photosynthetically Active Radiation (GI-FAPAR) (300 m de resolution)). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_S3_Observation"></see></summary>
    let GIFAPAR_S3_Observation = _prefix "GIFAPAR_S3_Observation"
    /// <summary>
    /// Represents the general sensorization of satellite Sentinel 3 ( S3)  OLCI. Observes FAPAR , Chl.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-3_OLCI"></see></summary>
    let ``RS_Sentinel-3_OLCI`` = _prefix "RS_Sentinel-3_OLCI"
    /// <summary>
    /// Class that represents observations related to fraction of absorved photosynthetically active radiation (FAPAR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GIFAPAR_Satellite_Observation"></see></summary>
    let GIFAPAR_Satellite_Observation = _prefix "GIFAPAR_Satellite_Observation"
    /// <summary>
    /// Sentinel-3_OLCI Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Product_1"></see></summary>
    let ``Sentinel-3_OLCI_Product_1`` = _prefix "Sentinel-3_OLCI_Product_1"
    /// <summary>
    /// Geometry of LAIStation1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLAIStation1"></see></summary>
    let GeoLAIStation1 = _prefix "GeoLAIStation1"
    /// <summary>
    /// Geometry of LAIStation2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLAIStation2"></see></summary>
    let GeoLAIStation2 = _prefix "GeoLAIStation2"
    /// <summary>
    /// Geometry of LSEStation1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation1"></see></summary>
    let GeoLSEStation1 = _prefix "GeoLSEStation1"
    /// <summary>
    /// Geometry of LSEStation2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation2"></see></summary>
    let GeoLSEStation2 = _prefix "GeoLSEStation2"
    /// <summary>
    /// Geometry of LSEStation3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation3"></see></summary>
    let GeoLSEStation3 = _prefix "GeoLSEStation3"
    /// <summary>
    /// Geometry of LSEStation4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation4"></see></summary>
    let GeoLSEStation4 = _prefix "GeoLSEStation4"
    /// <summary>
    /// Geometry of LSEStation5
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation5"></see></summary>
    let GeoLSEStation5 = _prefix "GeoLSEStation5"
    /// <summary>
    /// Geometry of LSEStation6
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSEStation6"></see></summary>
    let GeoLSEStation6 = _prefix "GeoLSEStation6"
    /// <summary>
    /// Geometry of LSTStation1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoLSTStation1"></see></summary>
    let GeoLSTStation1 = _prefix "GeoLSTStation1"
    /// <summary>
    /// Geometry of N2Station1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoN2Station1"></see></summary>
    let GeoN2Station1 = _prefix "GeoN2Station1"
    /// <summary>
    /// Geometry of RADStation1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoRADStation1"></see></summary>
    let GeoRADStation1 = _prefix "GeoRADStation1"
    /// <summary>
    /// Geometry of SMStation1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation1"></see></summary>
    let GeoSMStation1 = _prefix "GeoSMStation1"
    /// <summary>
    /// Geometry of SMStation2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation2"></see></summary>
    let GeoSMStation2 = _prefix "GeoSMStation2"
    /// <summary>
    /// Geometry of SMStation3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation3"></see></summary>
    let GeoSMStation3 = _prefix "GeoSMStation3"
    /// <summary>
    /// Geometry of SMStation4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation4"></see></summary>
    let GeoSMStation4 = _prefix "GeoSMStation4"
    /// <summary>
    /// Geometry of SMStation5
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation5"></see></summary>
    let GeoSMStation5 = _prefix "GeoSMStation5"
    /// <summary>
    /// Geometry of SMStation6
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#GeoSMStation6"></see></summary>
    let GeoSMStation6 = _prefix "GeoSMStation6"
    /// <summary>
    /// Class that represents solar radiation stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RAD_Station"></see></summary>
    let RAD_Station = _prefix "RAD_Station"
    /// <summary>
    /// RAD Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RAD_Station_1"></see></summary>
    let RAD_Station_1 = _prefix "RAD_Station_1"
    /// <summary>
    /// Image Result let us assign URIs to the image properties.  Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Image_Result"></see></summary>
    let Image_Result = _prefix "Image_Result"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URLImage"></see>
    /// </summary>
    let URLImage = _prefix "URLImage"
    /// <summary>
    /// Class that represents observations related to Heliograph (Duration of the sunshine in Hours).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Insolation_AEMET_Observation"></see></summary>
    let Insolation_AEMET_Observation = _prefix "Insolation_AEMET_Observation"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#IsProductOf"></see>
    /// </summary>
    let IsProductOf = _prefix "IsProductOf"
    /// <summary>
    /// A Satellite Product is a processed dataset generated from raw satellite measurements, typically including radiometric, geometric, and atmospheric corrections. These products provide georeferenced environmental variables (e.g., reflectance, vegetation indices, land surface temperature, soil moisture) at defined spatial, temporal, and spectral resolutions, and serve as inputs for environmental monitoring, modelling, and validation workflows.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite_Product"></see></summary>
    let Satellite_Product = _prefix "Satellite_Product"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Snapshot"></see>
    /// </summary>
    let Snapshot = _prefix "Snapshot"
    /// <summary>
    /// Someting (usually a snapshot) has product.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasProduct"></see></summary>
    let hasProduct = _prefix "hasProduct"
    /// <summary>
    /// Sensor that takes LAI measurements from Landsat-8.
    /// Class that represents observations related to Leaf Area Index (LAI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L8_Observation"></see></summary>
    let LAI_L8_Observation = _prefix "LAI_L8_Observation"
    /// <summary>
    /// Class that represents observations related to Leaf Area Index (LAI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Satellite_Observation"></see></summary>
    let LAI_Satellite_Observation = _prefix "LAI_Satellite_Observation"
    /// <summary>
    /// Sensor that takes LAI measurements from Landsat-9.
    /// Class that represents observations related to Leaf Area Index (LAI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_L9_Observation"></see></summary>
    let LAI_L9_Observation = _prefix "LAI_L9_Observation"
    /// <summary>
    /// Class that represents observations related to Leaf Area Index (LAI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Observation"></see></summary>
    let LAI_Observation = _prefix "LAI_Observation"
    /// <summary>
    /// Result that is normally obtained by Leaf Area Index (LAI) sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Result"></see></summary>
    let LAI_Result = _prefix "LAI_Result"
    /// <summary>
    /// Sensor that takes LAI measurements from Sentinel-2.
    /// Class that represents observations related to Leaf Area Index (LAI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_S2_Observation"></see></summary>
    let LAI_S2_Observation = _prefix "LAI_S2_Observation"
    /// <summary>
    /// Class that represents Leaf Aea Index (LAI) stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station"></see></summary>
    let LAI_Station = _prefix "LAI_Station"
    /// <summary>
    /// Leaf Area Index Sensor from Leaf Area Index (LAI) Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g"></see></summary>
    let LAI_g = _prefix "LAI_g"
    /// <summary>
    /// LAI Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station_1"></see></summary>
    let LAI_Station_1 = _prefix "LAI_Station_1"
    /// <summary>
    /// LAI Station number 2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_Station_2"></see></summary>
    let LAI_Station_2 = _prefix "LAI_Station_2"
    /// <summary>
    /// Class that represents observations related to Leaf Area Index (LAI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_UAV_Observation"></see></summary>
    let LAI_UAV_Observation = _prefix "LAI_UAV_Observation"
    /// <summary>
    /// Class that represents observations related to Leaf Area Index (LAI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_dhp_Observation"></see></summary>
    let LAI_dhp_Observation = _prefix "LAI_dhp_Observation"
    /// <summary>
    /// Class that represents observations related to Leaf Area Index (LAI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LAI_g_Observation"></see></summary>
    let LAI_g_Observation = _prefix "LAI_g_Observation"
    /// <summary>
    /// Class that represents observations related to Land Surface Emissivity. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Observation"></see></summary>
    let LSE_Observation = _prefix "LSE_Observation"
    /// <summary>
    /// Result that is normally obtained by Land Surface Emissivity (LSE) sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Result"></see></summary>
    let LSE_Result = _prefix "LSE_Result"
    /// <summary>
    /// Sensor that takes Land Surface Emissivity measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_g"></see></summary>
    let LSE_g = _prefix "LSE_g"
    /// <summary>
    /// Class that represents Land Surface Emissivity (LSE) stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station"></see></summary>
    let LSE_Station = _prefix "LSE_Station"
    /// <summary>
    /// LSE Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_1"></see></summary>
    let LSE_Station_1 = _prefix "LSE_Station_1"
    /// <summary>
    /// LSE Station number 2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_2"></see></summary>
    let LSE_Station_2 = _prefix "LSE_Station_2"
    /// <summary>
    /// LSE Station number 3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_3"></see></summary>
    let LSE_Station_3 = _prefix "LSE_Station_3"
    /// <summary>
    /// LSE Station number 4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_4"></see></summary>
    let LSE_Station_4 = _prefix "LSE_Station_4"
    /// <summary>
    /// LSE Station number 5
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_5"></see></summary>
    let LSE_Station_5 = _prefix "LSE_Station_5"
    /// <summary>
    /// LSE Station number 6
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LSE_Station_6"></see></summary>
    let LSE_Station_6 = _prefix "LSE_Station_6"

    /// <summary>
    /// Sensor that takes Land Surface Temperature measurements from MODIS-Aqua.
    /// 8 days temporality, 1 km resolution. Product MYD11A2.
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_MODIS-Aqua_Observation"></see></summary>
    let ``LST_8days_1km_MODIS-Aqua_Observation`` =
        _prefix "LST_8days_1km_MODIS-Aqua_Observation"

    /// <summary>
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Satellite_Observation"></see></summary>
    let LST_Satellite_Observation = _prefix "LST_Satellite_Observation"

    /// <summary>
    /// Sensor that takes Land Surface Temperature measurements from MODIS-Terra.
    /// 8 days temporality, 1 km resolution. Product MYD11A2.
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_8days_1km_MODIS-Terra_Observation"></see></summary>
    let ``LST_8days_1km_MODIS-Terra_Observation`` =
        _prefix "LST_8days_1km_MODIS-Terra_Observation"

    /// <summary>
    /// Sensor that takes LST measurements from Landset-8.
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L8_Observation"></see></summary>
    let LST_L8_Observation = _prefix "LST_L8_Observation"
    /// <summary>
    /// Sensor that takes LST measurements from Landset-9.
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_L9_Observation"></see></summary>
    let LST_L9_Observation = _prefix "LST_L9_Observation"
    /// <summary>
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Observation"></see></summary>
    let LST_Observation = _prefix "LST_Observation"
    /// <summary>
    /// Result that is normally obtained by Land Surface Temperature (LST) sensors.  Unit of measure Degree Celsius .
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Result"></see></summary>
    let LST_Result = _prefix "LST_Result"
    /// <summary>
    /// Sensor that takes Land Surface Temperature measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_g"></see></summary>
    let LST_g = _prefix "LST_g"
    /// <summary>
    /// Sensor that takes LST measurements from Sentinel-3.
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_S3_Observation"></see></summary>
    let LST_S3_Observation = _prefix "LST_S3_Observation"
    /// <summary>
    /// Represents the general sensorization of satellite Sentinel 3 ( S3)  SLSTR. Observes LST.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-3_SLSTR"></see></summary>
    let ``RS_Sentinel-3_SLSTR`` = _prefix "RS_Sentinel-3_SLSTR"
    /// <summary>
    /// Sentinel-3_SLSTR Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Product_1"></see></summary>
    let ``Sentinel-3_SLSTR_Product_1`` = _prefix "Sentinel-3_SLSTR_Product_1"
    /// <summary>
    /// Class that represents Land Surface Temperature (LST) stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Station"></see></summary>
    let LST_Station = _prefix "LST_Station"
    /// <summary>
    /// LST Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_Station_1"></see></summary>
    let LST_Station_1 = _prefix "LST_Station_1"
    /// <summary>
    /// Class that represents observations related to Land Surface Temperature (LST). Unit of measure Degree Celsius.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_UAV_Observation"></see></summary>
    let LST_UAV_Observation = _prefix "LST_UAV_Observation"
    /// <summary>
    /// Represents the general sensorization of RS_UAV_Thermal. Observes  LST.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Thermal"></see></summary>
    let RS_UAV_Thermal = _prefix "RS_UAV_Thermal"
    /// <summary>
    /// UAV Thermal platform.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Thermal_1"></see></summary>
    let UAV_Thermal_1 = _prefix "UAV_Thermal_1"

    /// <summary>
    /// Sensor that takes Land Surface Temperature measurements from MODIS-Aqua.
    /// Daily temporality,1 km resolution. Product MYD11A1
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_MODIS-Aqua_Observation"></see></summary>
    let ``LST_diary_1km_MODIS-Aqua_Observation`` =
        _prefix "LST_diary_1km_MODIS-Aqua_Observation"

    /// <summary>
    /// Sensor that takes Land Surface Temperature measurements from MODIS-Terra.
    /// Daily temporality,1 km resolution. Product MYD11A1
    /// Class that represents observations related to Land Surface Temperature (LST). Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LST_diary_1km_MODIS-Terra_Observation"></see></summary>
    let ``LST_diary_1km_MODIS-Terra_Observation`` =
        _prefix "LST_diary_1km_MODIS-Terra_Observation"

    /// <summary>
    /// Sensor that takes "surface downwelling longwave flux in air" measurements in RAD Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_down_g"></see></summary>
    let LW_down_g = _prefix "LW_down_g"
    /// <summary>
    /// Sensor that takes "upwelling longwave flux in air" measurements in RAD Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LW_up_g"></see></summary>
    let LW_up_g = _prefix "LW_up_g"
    /// <summary>
    /// Result that is normally obtained by LandCover_S2 sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_Result"></see></summary>
    let LandCover_Result = _prefix "LandCover_Result"
    /// <summary>
    /// URL for 10x10 area
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URL10x10"></see></summary>
    let URL10x10 = _prefix "URL10x10"
    /// <summary>
    /// URL for 1x1 area
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#URL1x1"></see></summary>
    let URL1x1 = _prefix "URL1x1"
    /// <summary>
    /// Sensor that takes LandCover measurements from Sentinel-2. Dimensionless.
    /// Class that represents observations related to Land Cover LCCS.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#LandCover_S2_Observation"></see></summary>
    let LandCover_S2_Observation = _prefix "LandCover_S2_Observation"
    /// <summary>
    /// Land cover is the physical material on the earth's surface. Ground covers include grass, asphalt, trees, bare ground, water, etc. Land cover is the expression used by the ecologist Frederick Edward Clements that has its closest modern equivalent to vegetation.
    /// Class that represents all Land Cover properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Land_Cover_Property"></see></summary>
    let Land_Cover_Property = _prefix "Land_Cover_Property"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8"></see>
    /// </summary>
    let ``Landsat-8`` = _prefix "Landsat-8"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Satellite"></see>
    /// </summary>
    let Satellite = _prefix "Satellite"
    /// <summary>
    /// Sensor SR_L8 hosted by Landsat-8 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L8_Sensor_1"></see></summary>
    let SR_L8_Sensor_1 = _prefix "SR_L8_Sensor_1"
    /// <summary>
    /// Landsat 8 satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-8_Satellite"></see></summary>
    let ``Landsat-8_Satellite`` = _prefix "Landsat-8_Satellite"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9"></see>
    /// </summary>
    let ``Landsat-9`` = _prefix "Landsat-9"
    /// <summary>
    /// Class that represents Landsat-9 Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Product"></see></summary>
    let ``Landsat-9_Product`` = _prefix "Landsat-9_Product"
    /// <summary>
    /// SR_L9 Sensor hosted by Landsat-9 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L9_Sensor_1"></see></summary>
    let SR_L9_Sensor_1 = _prefix "SR_L9_Sensor_1"
    /// <summary>
    /// Landsat 9 satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Landsat-9_Satellite"></see></summary>
    let ``Landsat-9_Satellite`` = _prefix "Landsat-9_Satellite"
    /// <summary>
    /// Class that represents observations related to Latent Heat Flux (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Latent_Heat_Flux_Observation"></see></summary>
    let Latent_Heat_Flux_Observation = _prefix "Latent_Heat_Flux_Observation"
    /// <summary>
    /// Result that is normally obtained by LE_g (evapotranspiration ground) sensors. Unit of measure Watt  per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Latent_Heat_Flux_Result"></see></summary>
    let Latent_Heat_Flux_Result = _prefix "Latent_Heat_Flux_Result"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT"></see>
    /// </summary>
    let METEOSAT = _prefix "METEOSAT"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Product"></see>
    /// </summary>
    let METEOSAT_Product = _prefix "METEOSAT_Product"
    /// <summary>
    /// PWC_METEOSAT Sensor hosted by METEOSAT_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_METEOSAT_Sensor_1"></see></summary>
    let PWC_METEOSAT_Sensor_1 = _prefix "PWC_METEOSAT_Sensor_1"
    /// <summary>
    /// Meteosat satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#METEOSAT_Satellite"></see></summary>
    let METEOSAT_Satellite = _prefix "METEOSAT_Satellite"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua"></see>
    /// </summary>
    let ``MODIS-Aqua`` = _prefix "MODIS-Aqua"
    /// <summary>
    /// Class that represents MODIS-Aqua Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Product"></see></summary>
    let ``MODIS-Aqua_Product`` = _prefix "MODIS-Aqua_Product"
    /// <summary>
    /// Modis Aqua satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Aqua_Satellite"></see></summary>
    let ``MODIS-Aqua_Satellite`` = _prefix "MODIS-Aqua_Satellite"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra"></see>
    /// </summary>
    let ``MODIS-Terra`` = _prefix "MODIS-Terra"
    /// <summary>
    /// Class that represents MODIS-Terra Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Product"></see></summary>
    let ``MODIS-Terra_Product`` = _prefix "MODIS-Terra_Product"
    /// <summary>
    /// Modis Terra satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#MODIS-Terra_Satellite"></see></summary>
    let ``MODIS-Terra_Satellite`` = _prefix "MODIS-Terra_Satellite"
    /// <summary>
    /// Class that represents Nitrogen concentration stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_Station"></see></summary>
    let N2_Station = _prefix "N2_Station"
    /// <summary>
    /// Sensor that takes nitrogen dioxide measurements. From N2 Station.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_g"></see></summary>
    let N2_g = _prefix "N2_g"
    /// <summary>
    /// N2 Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#N2_Station_1"></see></summary>
    let N2_Station_1 = _prefix "N2_Station_1"

    /// <summary>
    /// Sensor that takes NDVI measurements from MODIS-Aqua.
    /// 16 days temporality,  1km resolution, product MYD13A2
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_MODIS-Aqua_Observation"></see></summary>
    let ``NDVI_16days_1km_MODIS-Aqua_Observation`` =
        _prefix "NDVI_16days_1km_MODIS-Aqua_Observation"

    /// <summary>
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_Satellite_Observation"></see></summary>
    let NDVI_Satellite_Observation = _prefix "NDVI_Satellite_Observation"

    /// <summary>
    /// Sensor that takes NDVI measurements from MODIS-Terra.
    /// 16 days temporality, 1 km resolution. Producto MYD13A2
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_1km_MODIS-Terra_Observation"></see></summary>
    let ``NDVI_16days_1km_MODIS-Terra_Observation`` =
        _prefix "NDVI_16days_1km_MODIS-Terra_Observation"

    /// <summary>
    /// Sensor that takes NDVI measurements from MODIS-Aqua.
    /// 16 days temporality, 250 m resolution, product MYD13Q1
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_MODIS-Aqua_Observation"></see></summary>
    let ``NDVI_16days_250m_MODIS-Aqua_Observation`` =
        _prefix "NDVI_16days_250m_MODIS-Aqua_Observation"

    /// <summary>
    /// Sensor that takes NDVI measurements from MODIS-Terra.
    /// 16 days temporality, 250 m resolution. Producto MYD13Q1
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_250m_MODIS-Terra_Observation"></see></summary>
    let ``NDVI_16days_250m_MODIS-Terra_Observation`` =
        _prefix "NDVI_16days_250m_MODIS-Terra_Observation"

    /// <summary>
    /// Sensor that takes NDVI measurements from MODIS-Aqua.
    /// 16 days temporality, 500 m resolution, product MYD13A1
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_MODIS-Aqua_Observation"></see></summary>
    let ``NDVI_16days_500m_MODIS-Aqua_Observation`` =
        _prefix "NDVI_16days_500m_MODIS-Aqua_Observation"

    /// <summary>
    /// Sensor that takes NDVI measurements from MODIS-Terra.
    /// 16 days temporality, 500 m resolution. Product  MYD13A1
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_16days_500m_MODIS-Terra_Observation"></see></summary>
    let ``NDVI_16days_500m_MODIS-Terra_Observation`` =
        _prefix "NDVI_16days_500m_MODIS-Terra_Observation"

    /// <summary>
    /// Sensor that takes NDVI measurements from Landsat-8.
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L8_Observation"></see></summary>
    let NDVI_L8_Observation = _prefix "NDVI_L8_Observation"
    /// <summary>
    /// Sensor that takes NDVI measurements from Landsat-9.
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_L9_Observation"></see></summary>
    let NDVI_L9_Observation = _prefix "NDVI_L9_Observation"
    /// <summary>
    /// Result that is normally obtained by Normalized Difference Vegetation Index (NDVI) sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_Result"></see></summary>
    let NDVI_Result = _prefix "NDVI_Result"
    /// <summary>
    /// Sensor that takes NDVI measurements from Sentinel-2.
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_S2_Observation"></see></summary>
    let NDVI_S2_Observation = _prefix "NDVI_S2_Observation"
    /// <summary>
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).  Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_UAV_Observation"></see></summary>
    let NDVI_UAV_Observation = _prefix "NDVI_UAV_Observation"

    /// <summary>
    /// Sensor that takes NDVI measurements from MODIS-Aqua.
    /// Diary temporality, 500 m resolution, product MYD09GA_006_NDVI
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_MODIS-Aqua_Observation"></see></summary>
    let ``NDVI_diary_500m_MODIS-Aqua_Observation`` =
        _prefix "NDVI_diary_500m_MODIS-Aqua_Observation"

    /// <summary>
    /// Sensor that takes NDVI measurements from MODIS-Terra.
    /// Daily temporality, 500 m resolution.  Product MYD09GA_006_NDVI
    /// Class that represents observations related to Normalized Difference Vegetation Index (NDVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDVI_diary_500m_MODIS-Terra_Observation"></see></summary>
    let ``NDVI_diary_500m_MODIS-Terra_Observation`` =
        _prefix "NDVI_diary_500m_MODIS-Terra_Observation"

    /// <summary>
    /// Result that normally is obtained by NDWI sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_Result"></see></summary>
    let NDWI_Result = _prefix "NDWI_Result"
    /// <summary>
    /// Sensor NDWI UAV Hyperspectral hosted by UAV Hyperspectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_UAV_Hyperspectral_Sensor_1"></see></summary>
    let NDWI_UAV_Hyperspectral_Sensor_1 = _prefix "NDWI_UAV_Hyperspectral_Sensor_1"
    /// <summary>
    /// NDWI – Normalized Difference Water Index
    /// Estimates leaf water content and moisture conditions using narrowband reflectance in the NIR and SWIR (or Green–NIR). It is sensitive to vegetation water status and widely used in stress detection.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Normalized_Difference_Water_Index"></see></summary>
    let Normalized_Difference_Water_Index = _prefix "Normalized_Difference_Water_Index"
    /// <summary>
    /// Class that represents observations related to NDWI – Normalized Difference Water Index. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NDWI_UAV_Observation"></see></summary>
    let NDWI_UAV_Observation = _prefix "NDWI_UAV_Observation"
    /// <summary>
    /// Result that normally is obtained by NRI sensors.  Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_Result"></see></summary>
    let NRI_Result = _prefix "NRI_Result"
    /// <summary>
    /// Sensor NRI UAV Hyperspectral hosted by UAV Hyperspectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_UAV_Hyperspectral_Sensor_1"></see></summary>
    let NRI_UAV_Hyperspectral_Sensor_1 = _prefix "NRI_UAV_Hyperspectral_Sensor_1"
    /// <summary>
    /// The Nitrogen Reflectance Index (NRI) is a spectral index designed to estimate the nitrogen status of vegetation using reflectance measurements in the visible region. It exploits the sensitivity of chlorophyll‐related absorption features to nitrogen concentration.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Reflectance_Index"></see></summary>
    let Nitrogen_Reflectance_Index = _prefix "Nitrogen_Reflectance_Index"
    /// <summary>
    /// Class that represents observations related to NRI (Nitrogen Reflectance Index).Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#NRI_UAV_Observation"></see></summary>
    let NRI_UAV_Observation = _prefix "NRI_UAV_Observation"

    /// <summary>
    /// Class that represents observations related to Nitrogen dioxide concentration (mg/g).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Concentration_Observation"></see></summary>
    let Nitrogen_Concentration_Observation =
        _prefix "Nitrogen_Concentration_Observation"

    /// <summary>
    /// Result that is normally obtained by N2 (nitrogene dioxide) sensors. Unit of measure Milligram per Gram.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Nitrogen_Concentration_Result"></see></summary>
    let Nitrogen_Concentration_Result = _prefix "Nitrogen_Concentration_Result"
    /// <summary>
    /// Class that represents observations related to Orthophoto. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#ORTHOPHOTO_UAV_Observation"></see></summary>
    let ORTHOPHOTO_UAV_Observation = _prefix "ORTHOPHOTO_UAV_Observation"
    /// <summary>
    /// Represents the general sensorization of RS_UAV_RGB. Observes  ORTHOPHOTO
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_RGB"></see></summary>
    let RS_UAV_RGB = _prefix "RS_UAV_RGB"
    /// <summary>
    /// Sensor that takes OTCI measurements from Sentinel-3.
    /// Class that represents observations related to OLCI Terrestrial Chlorophyll Index (OTCI) (300 m de resolución)). µmol of chlorophyll per m²µ.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#OTCI_S3_Observation"></see></summary>
    let OTCI_S3_Observation = _prefix "OTCI_S3_Observation"
    /// <summary>
    /// UAV RGB  platform.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_RGB_1"></see></summary>
    let UAV_RGB_1 = _prefix "UAV_RGB_1"
    /// <summary>
    /// Sensor that takes PWC measurements from METEOSAT.
    /// Class that represents observations related to precipitable_water_content . Unit of measure Millimetre (mm)..
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_METEOSAT_Observation"></see></summary>
    let PWC_METEOSAT_Observation = _prefix "PWC_METEOSAT_Observation"
    /// <summary>
    /// Result that is normally obtained by PWC_METEOSAT sensors. Precipitable Water Content Result.  Unit of measure Millimetre (mm).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#PWC_Result"></see></summary>
    let PWC_Result = _prefix "PWC_Result"
    /// <summary>
    /// Precipitable Water Content (PWC) refers to the amount of water vapor present in a vertical column of the Earth's atmosphere. It is typically expressed in terms of thickness or depth, such as millimeters (mm) or inches (inches), and represents the total depth of liquid water that would result if all the water vapor in the column were condensed and collected.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#precipitable_water_content"></see></summary>
    let precipitable_water_content = _prefix "precipitable_water_content"
    /// <summary>
    /// Class that represents observations related to precipitation (mm).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Precipitation_AEMET_Observation"></see></summary>
    let Precipitation_AEMET_Observation = _prefix "Precipitation_AEMET_Observation"
    /// <summary>
    /// Result that is normally obtained by Pluviometer_AEMET sensors in AEMET Staion. Unit of measure Millimetre (mm).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Precipitation_AEMET_Result"></see></summary>
    let Precipitation_AEMET_Result = _prefix "Precipitation_AEMET_Result"
    /// <summary>
    /// Sensor that takes "surface net radiation" measurements in RAD Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RN_g"></see></summary>
    let RN_g = _prefix "RN_g"
    /// <summary>
    /// Sensor that takes "surface downwelling shortwave flux in air" measurements in RAD Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_down_g"></see></summary>
    let SW_down_g = _prefix "SW_down_g"
    /// <summary>
    /// Sensor that takes "upwelling shortwave flux in air" measurements in RAD Station
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SW_up_g"></see></summary>
    let SW_up_g = _prefix "SW_up_g"
    /// <summary>
    /// RN_g_RAD Sensor hosted by RAD_Station_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RN_g_RAD_Sensor_1"></see></summary>
    let RN_g_RAD_Sensor_1 = _prefix "RN_g_RAD_Sensor_1"
    /// <summary>
    /// Earth's net radiation, sometimes called net flux, is the balance between incoming and outgoing energy at the top of the atmosphere.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#surface_net_radiation"></see></summary>
    let surface_net_radiation = _prefix "surface_net_radiation"
    /// <summary>
    /// Simplest ratio-based index is called the Simple Ratio (SR) or Ratio Vegetation Index (RVI). This index is simply the reflectance in the NIR band divided by the reflectance in the red band. A larger SR value indicates healthy vegetation, while lower values indicate soil, water or ice. SR = Near Infrared / Red
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#simple_ratio"></see></summary>
    let simple_ratio = _prefix "simple_ratio"
    /// <summary>
    /// Satellite  Sensors (remote sensing).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Remote_Sensing_Satellites"></see></summary>
    let Remote_Sensing_Satellites = _prefix "Remote_Sensing_Satellites"
    /// <summary>
    /// Represents the general sensorization of SMAP. Observes Soil Moisture.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_SMAP"></see></summary>
    let RS_SMAP = _prefix "RS_SMAP"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP"></see>
    /// </summary>
    let SMAP = _prefix "SMAP"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS"></see>
    /// </summary>
    let SMOS = _prefix "SMOS"
    /// <summary>
    /// Represents the general sensorization of satellite Sentinel 1 or S1. Observes Soil Moisture.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_Sentinel-1"></see></summary>
    let ``RS_Sentinel-1`` = _prefix "RS_Sentinel-1"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1"></see>
    /// </summary>
    let ``Sentinel-1`` = _prefix "Sentinel-1"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2"></see>
    /// </summary>
    let ``Sentinel-2`` = _prefix "Sentinel-2"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI"></see>
    /// </summary>
    let ``Sentinel-3_OLCI`` = _prefix "Sentinel-3_OLCI"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR"></see>
    /// </summary>
    let ``Sentinel-3_SLSTR`` = _prefix "Sentinel-3_SLSTR"
    /// <summary>
    /// Unmanned aerial vehicle Hyperspectral
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral"></see></summary>
    let UAV_Hyperspectral = _prefix "UAV_Hyperspectral"
    /// <summary>
    /// Drone Sensors (remote sensing).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Remote_Sensing_UAVs"></see></summary>
    let Remote_Sensing_UAVs = _prefix "Remote_Sensing_UAVs"
    /// <summary>
    /// Unmanned aerial vehicle LiDAR
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR"></see></summary>
    let UAV_LiDAR = _prefix "UAV_LiDAR"
    /// <summary>
    /// Represents the general sensorization of RS_UAV_Microwave. Observes SM.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#RS_UAV_Microwave"></see></summary>
    let RS_UAV_Microwave = _prefix "RS_UAV_Microwave"
    /// <summary>
    /// Unmanned aerial vehicle Microwave
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Microwave"></see></summary>
    let UAV_Microwave = _prefix "UAV_Microwave"
    /// <summary>
    /// Unmanned aerial vehicle Multispectral
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Multispectral"></see></summary>
    let UAV_Multispectral = _prefix "UAV_Multispectral"
    /// <summary>
    /// Unmanned aerial vehicle RGB
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_RGB"></see></summary>
    let UAV_RGB = _prefix "UAV_RGB"
    /// <summary>
    /// Unmanned aerial vehicle Thermal
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Thermal"></see></summary>
    let UAV_Thermal = _prefix "UAV_Thermal"
    /// <summary>
    /// Sensor that takes SAVI measurements from Landsat-8.
    /// Class that represents observations related to Soil Adjusted Vegetation Index (SAVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L8_Observation"></see></summary>
    let SAVI_L8_Observation = _prefix "SAVI_L8_Observation"
    /// <summary>
    /// Class that represents observations related to Soil Adjusted Vegetation Index (SAVI). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_Satellite_Observation"></see></summary>
    let SAVI_Satellite_Observation = _prefix "SAVI_Satellite_Observation"
    /// <summary>
    /// Sensor that takes SAVI measurements from Landsat-9.
    /// Class that represents observations related to Soil Adjusted Vegetation Index (SAVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_L9_Observation"></see></summary>
    let SAVI_L9_Observation = _prefix "SAVI_L9_Observation"
    /// <summary>
    /// Result that is normally obtained by Soil Adjusted Vegetation Index (SAVI) sensors.  Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_Result"></see></summary>
    let SAVI_Result = _prefix "SAVI_Result"
    /// <summary>
    /// Sensor that takes SAVI measurements from Sentinel-2.
    /// Class that represents observations related to Soil Adjusted Vegetation Index (SAVI).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_S2_Observation"></see></summary>
    let SAVI_S2_Observation = _prefix "SAVI_S2_Observation"
    /// <summary>
    /// Class that represents observations related to Soil Adjusted Vegetation Index (SAVI).  Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SAVI_UAV_Observation"></see></summary>
    let SAVI_UAV_Observation = _prefix "SAVI_UAV_Observation"
    /// <summary>
    /// Class that represents SMAP satellite Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Product"></see></summary>
    let SMAP_Product = _prefix "SMAP_Product"
    /// <summary>
    /// SMAP Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Product_1"></see></summary>
    let SMAP_Product_1 = _prefix "SMAP_Product_1"
    /// <summary>
    /// SMAP satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMAP_Satellite"></see></summary>
    let SMAP_Satellite = _prefix "SMAP_Satellite"
    /// <summary>
    /// SMOS satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SMOS_Satellite"></see></summary>
    let SMOS_Satellite = _prefix "SMOS_Satellite"
    /// <summary>
    /// Class that represents observations related to Soil Moisture (SM). Unit of measure Cubic Metre per Cubic Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Observation"></see></summary>
    let SM_Observation = _prefix "SM_Observation"
    /// <summary>
    /// Result that is normally obtained by SM (Soil Moisture) sensors. Unit of measure Cubic Metre per Cubic Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Result"></see></summary>
    let SM_Result = _prefix "SM_Result"
    /// <summary>
    /// Sensor that takes Soil Moisture measurements
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_g"></see></summary>
    let SM_g = _prefix "SM_g"
    /// <summary>
    /// Sensor that takes SM measurements from S1.
    /// Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_S1_Observation"></see></summary>
    let SM_S1_Observation = _prefix "SM_S1_Observation"
    /// <summary>
    /// Class that represents observations related to Soil Moisture (SM). Unit of measure Cubic Metre per Cubic Metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Satellite_Observation"></see></summary>
    let SM_Satellite_Observation = _prefix "SM_Satellite_Observation"
    /// <summary>
    /// Sentinel-1 Product number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Product_1"></see></summary>
    let ``Sentinel-1_Product_1`` = _prefix "Sentinel-1_Product_1"
    /// <summary>
    /// Soil Moisture Sensor. Resolution of 36 km for Europe from SMAP.
    /// Daily temporality, 36 km resolution
    /// Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_36km_Observation"></see></summary>
    let SM_SMAP_36km_Observation = _prefix "SM_SMAP_36km_Observation"
    /// <summary>
    /// Soil Moisture Sensor. Resolution of 3 km for Europe from SMAP.
    /// Daily temporality, 3 km resolution
    /// Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_S1_3km_Observation"></see></summary>
    let SM_SMAP_S1_3km_Observation = _prefix "SM_SMAP_S1_3km_Observation"
    /// <summary>
    /// Soil Moisture Sensor. Resolution of 9 km for Europe from SMAP.
    /// Daily temporality, 9 km resolution
    /// Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMAP_S1_9km_Observation"></see></summary>
    let SM_SMAP_S1_9km_Observation = _prefix "SM_SMAP_S1_9km_Observation"
    /// <summary>
    /// Soil Moisture Sensor. Resolution of 25 km for Europe from SMOS.
    /// Daily temporality, resolution 25 km
    /// Class that represents observations related to Soil Moisture (SM). Dimensionless [0-1]
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_SMOS_ESA_Observation"></see></summary>
    let SM_SMOS_ESA_Observation = _prefix "SM_SMOS_ESA_Observation"
    /// <summary>
    /// Class that represents Soil Moisture stations
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station"></see></summary>
    let SM_Station = _prefix "SM_Station"
    /// <summary>
    /// SM Station number 1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_1"></see></summary>
    let SM_Station_1 = _prefix "SM_Station_1"
    /// <summary>
    /// SM Station number 2
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_2"></see></summary>
    let SM_Station_2 = _prefix "SM_Station_2"
    /// <summary>
    /// SM Station number 3
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_3"></see></summary>
    let SM_Station_3 = _prefix "SM_Station_3"
    /// <summary>
    /// SM Station number 4
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_4"></see></summary>
    let SM_Station_4 = _prefix "SM_Station_4"
    /// <summary>
    /// SM Station number 5
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_5"></see></summary>
    let SM_Station_5 = _prefix "SM_Station_5"
    /// <summary>
    /// SM Station number 6
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_Station_6"></see></summary>
    let SM_Station_6 = _prefix "SM_Station_6"
    /// <summary>
    /// UAV Microwave platform.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Microwave_1"></see></summary>
    let UAV_Microwave_1 = _prefix "UAV_Microwave_1"
    /// <summary>
    /// Class that represents observations related to Soil Moisture (SM). Unit of measure cubic metre per cubic metre.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SM_UAV_Observation"></see></summary>
    let SM_UAV_Observation = _prefix "SM_UAV_Observation"
    /// <summary>
    /// Sensor that takes SR measurements from L8.
    /// Class that represents observations related to Simple Ratio (SR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L8_Observation"></see></summary>
    let SR_L8_Observation = _prefix "SR_L8_Observation"
    /// <summary>
    /// Class that represents observations related to Simple Ratio (SR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_Satellite_Observation"></see></summary>
    let SR_Satellite_Observation = _prefix "SR_Satellite_Observation"
    /// <summary>
    /// Sensor that takes SR measurements from L9.
    /// Class that represents observations related to Simple Ratio (SR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_L9_Observation"></see></summary>
    let SR_L9_Observation = _prefix "SR_L9_Observation"
    /// <summary>
    /// Result that is normally obtained by Simple Ratio (SR) sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_Result"></see></summary>
    let SR_Result = _prefix "SR_Result"
    /// <summary>
    /// Sensor that takes SR measurements from S2.
    /// Class that represents observations related to Simple Ratio (SR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_S2_Observation"></see></summary>
    let SR_S2_Observation = _prefix "SR_S2_Observation"
    /// <summary>
    /// SR_S2 Sensor hosted by Sentinel-2 Product_1
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_S2_Sensor_1"></see></summary>
    let SR_S2_Sensor_1 = _prefix "SR_S2_Sensor_1"
    /// <summary>
    /// Sensor SR UAV Multispectral hosted by UAV Multispectral 1.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_UAV_Multispectral_Sensor_1"></see></summary>
    let SR_UAV_Multispectral_Sensor_1 = _prefix "SR_UAV_Multispectral_Sensor_1"
    /// <summary>
    /// Class that represents observations related to Simple Ratio (SR). Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#SR_UAV_Observation"></see></summary>
    let SR_UAV_Observation = _prefix "SR_UAV_Observation"
    /// <summary>
    /// The satellite products have satellite sources
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasSatelliteSource"></see></summary>
    let hasSatelliteSource = _prefix "hasSatelliteSource"
    /// <summary>
    /// Class that represents observations related to Sensible heat flux (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sensible_Heat_Flux_Observation"></see></summary>
    let Sensible_Heat_Flux_Observation = _prefix "Sensible_Heat_Flux_Observation"
    /// <summary>
    /// Result that is normally obtained by Hs (sensible heat flux) sensors. Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sensible_Heat_Flux_Result"></see></summary>
    let Sensible_Heat_Flux_Result = _prefix "Sensible_Heat_Flux_Result"
    /// <summary>
    /// Class that represents Sentinel-1 satellite Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Product"></see></summary>
    let ``Sentinel-1_Product`` = _prefix "Sentinel-1_Product"
    /// <summary>
    /// Sentinel 1 satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-1_Satellite"></see></summary>
    let ``Sentinel-1_Satellite`` = _prefix "Sentinel-1_Satellite"
    /// <summary>
    /// Sentinel 2 satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-2_Satellite"></see></summary>
    let ``Sentinel-2_Satellite`` = _prefix "Sentinel-2_Satellite"
    /// <summary>
    /// Class that represents Sentinel-3 OLCI satellite Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Product"></see></summary>
    let ``Sentinel-3_OLCI_Product`` = _prefix "Sentinel-3_OLCI_Product"
    /// <summary>
    /// Sentinel 3 OLCI satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_OLCI_Satellite"></see></summary>
    let ``Sentinel-3_OLCI_Satellite`` = _prefix "Sentinel-3_OLCI_Satellite"
    /// <summary>
    /// Class that represents Sentinel-3 SLSTR satellite Products
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Product"></see></summary>
    let ``Sentinel-3_SLSTR_Product`` = _prefix "Sentinel-3_SLSTR_Product"
    /// <summary>
    /// Sentinel 3 SLSTR satellite.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Sentinel-3_SLSTR_Satellite"></see></summary>
    let ``Sentinel-3_SLSTR_Satellite`` = _prefix "Sentinel-3_SLSTR_Satellite"
    /// <summary>
    /// Result that is normally obtained by Land Cover sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Soil_Result"></see></summary>
    let Soil_Result = _prefix "Soil_Result"
    /// <summary>
    /// Class that represents observations related to Surface albedo (dimensionless)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Albedo_Observation"></see></summary>
    let Surface_Albedo_Observation = _prefix "Surface_Albedo_Observation"
    /// <summary>
    /// Result that is normally obtained by  SurfaceAlbedo sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Albedo_Result"></see></summary>
    let Surface_Albedo_Result = _prefix "Surface_Albedo_Result"

    /// <summary>
    /// Class that represents observations related to Surface Downwelling Longwave Flux In Air (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Longwave_Flux_In_Air_Observation"></see></summary>
    let Surface_Downwelling_Longwave_Flux_In_Air_Observation =
        _prefix "Surface_Downwelling_Longwave_Flux_In_Air_Observation"

    /// <summary>
    /// Result that is normally obtained by LW_down sensors.  Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Longwave_Flux_In_Air_Result"></see></summary>
    let Surface_Downwelling_Longwave_Flux_In_Air_Result =
        _prefix "Surface_Downwelling_Longwave_Flux_In_Air_Result"

    /// <summary>
    /// Class that represents observations related to Surface Downwelling Shortwave Flux In Air (W/m2)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Shortwave_Flux_In_Air_Observation"></see></summary>
    let Surface_Downwelling_Shortwave_Flux_In_Air_Observation =
        _prefix "Surface_Downwelling_Shortwave_Flux_In_Air_Observation"

    /// <summary>
    /// Result that is normally obtained by SW_down sensors. Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Downwelling_Shortwave_Flux_In_Air_Result"></see></summary>
    let Surface_Downwelling_Shortwave_Flux_In_Air_Result =
        _prefix "Surface_Downwelling_Shortwave_Flux_In_Air_Result"

    /// <summary>
    /// Class that represents observations related to Surface net radiation (W/m2)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Net_Radiation_Observation"></see></summary>
    let Surface_Net_Radiation_Observation = _prefix "Surface_Net_Radiation_Observation"
    /// <summary>
    /// Result that is normally obtained by RN sensors. Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Surface_Net_Radiation_Result"></see></summary>
    let Surface_Net_Radiation_Result = _prefix "Surface_Net_Radiation_Result"
    /// <summary>
    /// Class that represents observations related to temperature in AEMET Station.  Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_AEMET_Observation"></see></summary>
    let Temperature_AEMET_Observation = _prefix "Temperature_AEMET_Observation"
    /// <summary>
    /// Class that represents observations related to temperature. Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_Observation"></see></summary>
    let Temperature_Observation = _prefix "Temperature_Observation"

    /// <summary>
    /// Class that represents observations related to temperature in EddyCovariance Station. Celsius Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_EddyCovariance_Observation"></see></summary>
    let Temperature_EddyCovariance_Observation =
        _prefix "Temperature_EddyCovariance_Observation"

    /// <summary>
    /// Result that is normally obtained by Termometer sensors. Unit of measure Degree Celsius.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_Result"></see></summary>
    let Temperature_Result = _prefix "Temperature_Result"

    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_air_AEMET_Observation"></see>
    /// </summary>
    let Temperature_in_air_AEMET_Observation =
        _prefix "Temperature_in_air_AEMET_Observation"

    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_AEMET_Observation"></see>
    /// </summary>
    let Temperature_in_ground_AEMET_Observation =
        _prefix "Temperature_in_ground_AEMET_Observation"

    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_depth_05_AEMET_Observation"></see>
    /// </summary>
    let Temperature_in_ground_depth_05_AEMET_Observation =
        _prefix "Temperature_in_ground_depth_05_AEMET_Observation"

    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_depth_20_AEMET_Observation"></see>
    /// </summary>
    let Temperature_in_ground_depth_20_AEMET_Observation =
        _prefix "Temperature_in_ground_depth_20_AEMET_Observation"

    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Temperature_in_ground_next_ground_AEMET_Observation"></see>
    /// </summary>
    let Temperature_in_ground_next_ground_AEMET_Observation =
        _prefix "Temperature_in_ground_next_ground_AEMET_Observation"

    /// <summary>
    /// Unmanned aerial vehicle
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV"></see></summary>
    let UAV = _prefix "UAV"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_Hyperspectral_Observation"></see>
    /// </summary>
    let UAV_Hyperspectral_Observation = _prefix "UAV_Hyperspectral_Observation"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#UAV_LiDAR_Observation"></see>
    /// </summary>
    let UAV_LiDAR_Observation = _prefix "UAV_LiDAR_Observation"

    /// <summary>
    /// Class that represents observations related to Upwelling Longwave Flux In Air  (W/m2)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Longwave_Flux_In_Air_Observation"></see></summary>
    let Upwelling_Longwave_Flux_In_Air_Observation =
        _prefix "Upwelling_Longwave_Flux_In_Air_Observation"

    /// <summary>
    /// Result that is normally obtained by LW_up sensors. Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Longwave_Flux_In_Air__Result"></see></summary>
    let Upwelling_Longwave_Flux_In_Air__Result =
        _prefix "Upwelling_Longwave_Flux_In_Air__Result"

    /// <summary>
    /// Class that represents observations related to Upwelling Shortwave Flux In Air (W/m2)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Shortwave_Flux_In_Air_Observation"></see></summary>
    let Upwelling_Shortwave_Flux_In_Air_Observation =
        _prefix "Upwelling_Shortwave_Flux_In_Air_Observation"

    /// <summary>
    /// Result that is normally obtained by SW_up sensors. Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Upwelling_Shortwave_Flux_In_Air_Result"></see></summary>
    let Upwelling_Shortwave_Flux_In_Air_Result =
        _prefix "Upwelling_Shortwave_Flux_In_Air_Result"

    /// <summary>
    /// Result that is normally obtained by Vegetation ( EVI. SAVI, TDVI ...) sensors. Dimensionless.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Vegetation_Result"></see></summary>
    let Vegetation_Result = _prefix "Vegetation_Result"
    /// <summary>
    /// Class that represents observations related to water vapour flux (W/m2)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Water_Vapour_Flux_Observation"></see></summary>
    let Water_Vapour_Flux_Observation = _prefix "Water_Vapour_Flux_Observation"
    /// <summary>
    /// Result that is normally obtained by WatervapourFlux (water vapour flux) sensors. Unit of measure Watt per Square Metre (W/m2).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Water_Vapour_Flux_Result"></see></summary>
    let Water_Vapour_Flux_Result = _prefix "Water_Vapour_Flux_Result"
    /// <summary>
    /// Sensor belongs to EddyCovariance Station.  Sensor that takes wind direction  [0º-360º]  measurements.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#WindVane_EddyCovariance"></see></summary>
    let WindVane_EddyCovariance = _prefix "WindVane_EddyCovariance"
    /// <summary>
    /// Class that represents observations related to wind direction. Angle Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_AEMET_Observation"></see></summary>
    let Wind_Direction_AEMET_Observation = _prefix "Wind_Direction_AEMET_Observation"
    /// <summary>
    /// Class that represents observations related to wind direction. Angle Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_Observation"></see></summary>
    let Wind_Direction_Observation = _prefix "Wind_Direction_Observation"

    /// <summary>
    /// Class that represents observations related to wind direction. Angle Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_EddyCovariance_Observation"></see></summary>
    let Wind_Direction_EddyCovariance_Observation =
        _prefix "Wind_Direction_EddyCovariance_Observation"

    /// <summary>
    /// Result that is normally obtained by WindVane sensors. Unit of measure Angle Degree.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Direction_Result"></see></summary>
    let Wind_Direction_Result = _prefix "Wind_Direction_Result"
    /// <summary>
    /// Class that represents observations related to wind speed in AEMET Station. (m/s)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_AEMET_Observation"></see></summary>
    let Wind_Speed_AEMET_Observation = _prefix "Wind_Speed_AEMET_Observation"
    /// <summary>
    /// Class that represents observations related to wind speed. (m/s)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_Observation"></see></summary>
    let Wind_Speed_Observation = _prefix "Wind_Speed_Observation"

    /// <summary>
    /// Class that represents observations related to wind speed in EddyCovariance Station. (m/s)
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_EddyCovariance_Observation"></see></summary>
    let Wind_Speed_EddyCovariance_Observation =
        _prefix "Wind_Speed_EddyCovariance_Observation"

    /// <summary>
    /// Result that is normally obtained by Anemometer sensors. Unit of measure Metre per Second (m/s).
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#Wind_Speed_Result"></see></summary>
    let Wind_Speed_Result = _prefix "Wind_Speed_Result"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#acquisitionPeriod"></see>
    /// </summary>
    let acquisitionPeriod = _prefix "acquisitionPeriod"
    /// <summary>
    /// Sentinel-3 product properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#sentinel3ProductProperties"></see></summary>
    let sentinel3ProductProperties = _prefix "sentinel3ProductProperties"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#cloudyPixels"></see>
    /// </summary>
    let cloudyPixels = _prefix "cloudyPixels"
    /// <summary>
    /// Indicates the coordinates in which the station is located.
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#coordinatesLocation"></see></summary>
    let coordinatesLocation = _prefix "coordinatesLocation"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#file_description"></see>
    /// </summary>
    let file_description = _prefix "file_description"
    /// <summary>
    /// SMOS product properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#smosProductsProperties"></see></summary>
    let smosProductsProperties = _prefix "smosProductsProperties"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#gridMapping"></see>
    /// </summary>
    let gridMapping = _prefix "gridMapping"
    /// <summary>
    /// SMAP product properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#smapProductProperties"></see></summary>
    let smapProductProperties = _prefix "smapProductProperties"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#groundTrackDirection"></see>
    /// </summary>
    let groundTrackDirection = _prefix "groundTrackDirection"
    /// <summary>
    /// A Snapshot has a satellite observation
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#hasObservation"></see></summary>
    let hasObservation = _prefix "hasObservation"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#isObservationOf"></see>
    /// </summary>
    let isObservationOf = _prefix "isObservationOf"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#isSatelliteSourceOf"></see>
    /// </summary>
    let isSatelliteSourceOf = _prefix "isSatelliteSourceOf"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#landPixels"></see>
    /// </summary>
    let landPixels = _prefix "landPixels"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#longName"></see>
    /// </summary>
    let longName = _prefix "longName"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#missingValue"></see>
    /// </summary>
    let missingValue = _prefix "missingValue"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#mission"></see>
    /// </summary>
    let mission = _prefix "mission"
    /// <summary>
    /// MODIS Aqua / Terra product properties
    /// <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#modisProductProperties"></see></summary>
    let modisProductProperties = _prefix "modisProductProperties"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#number"></see>
    /// </summary>
    let number = _prefix "number"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#postList"></see>
    /// </summary>
    let postList = _prefix "postList"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#productName"></see>
    /// </summary>
    let productName = _prefix "productName"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#productType"></see>
    /// </summary>
    let productType = _prefix "productType"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#relativeOrbitNumber"></see>
    /// </summary>
    let relativeOrbitNumber = _prefix "relativeOrbitNumber"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#scale_factor"></see>
    /// </summary>
    let scale_factor = _prefix "scale_factor"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#srsName"></see>
    /// </summary>
    let srsName = _prefix "srsName"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#startTime"></see>
    /// </summary>
    let startTime = _prefix "startTime"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#stopTime"></see>
    /// </summary>
    let stopTime = _prefix "stopTime"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#timeliness"></see>
    /// </summary>
    let timeliness = _prefix "timeliness"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#unit"></see>
    /// </summary>
    let unit = _prefix "unit"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#validMax"></see>
    /// </summary>
    let validMax = _prefix "validMax"
    /// <summary>
    ///   <see href="https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#validMin"></see>
    /// </summary>
    let validMin = _prefix "validMin"
