namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_edac.owl.hash

open DoxAletheia.Rdf_Vocabulary

module edac =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#"

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateMonthly"></see>
    /// </summary>
    let AggregateMonthly =
        Namespaced_IRI.parse _namespace_name "AggregateMonthly" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDatasetProcessing"></see>
    /// </summary>
    let PRISMDatasetProcessing =
        Namespaced_IRI.parse _namespace_name "PRISMDatasetProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateOverThirtyYears"></see>
    /// </summary>
    let AggregateOverThirtyYears =
        Namespaced_IRI.parse _namespace_name "AggregateOverThirtyYears" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateYearly"></see>
    /// </summary>
    let AggregateYearly =
        Namespaced_IRI.parse _namespace_name "AggregateYearly" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Air"></see>
    /// </summary>
    let Air = Namespaced_IRI.parse _namespace_name "Air" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AtmosphericFeature"></see>
    /// </summary>
    let AtmosphericFeature =
        Namespaced_IRI.parse _namespace_name "AtmosphericFeature" |> NamespacedName

    /// <summary>
    /// A characteristic that can be measured as a quantity.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Amount"></see></summary>
    let Amount = Namespaced_IRI.parse _namespace_name "Amount" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertASCIIToTIFF"></see>
    /// </summary>
    let ConvertASCIIToTIFF =
        Namespaced_IRI.parse _namespace_name "ConvertASCIIToTIFF" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetProcessing"></see>
    /// </summary>
    let DatasetProcessing =
        Namespaced_IRI.parse _namespace_name "DatasetProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertedDataset"></see>
    /// </summary>
    let ConvertedDataset =
        Namespaced_IRI.parse _namespace_name "ConvertedDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISPrepublishedRasterDataset"></see>
    /// </summary>
    let RGISPrepublishedRasterDataset =
        Namespaced_IRI.parse _namespace_name "RGISPrepublishedRasterDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DataBandProcessing"></see>
    /// </summary>
    let DataBandProcessing =
        Namespaced_IRI.parse _namespace_name "DataBandProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processing"></see>
    /// </summary>
    let Processing = Namespaced_IRI.parse _namespace_name "Processing" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetManipulationSoftware"></see>
    /// </summary>
    let DatasetManipulationSoftware =
        Namespaced_IRI.parse _namespace_name "DatasetManipulationSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processor"></see>
    /// </summary>
    let Processor = Namespaced_IRI.parse _namespace_name "Processor" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInput"></see>
    /// </summary>
    let hadInput = Namespaced_IRI.parse _namespace_name "hadInput" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasAssociatedWith"></see>
    /// </summary>
    let wasAssociatedWith =
        Namespaced_IRI.parse _namespace_name "wasAssociatedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DewPointTemperature"></see>
    /// </summary>
    let DewPointTemperature =
        Namespaced_IRI.parse _namespace_name "DewPointTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Temperature"></see>
    /// </summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Download"></see>
    /// </summary>
    let Download = Namespaced_IRI.parse _namespace_name "Download" |> NamespacedName

    /// <summary>
    /// A MODIS dataset that has been obtained from a URL.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedMODISDataset"></see></summary>
    let DownloadedMODISDataset =
        Namespaced_IRI.parse _namespace_name "DownloadedMODISDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISDataset"></see>
    /// </summary>
    let MODISDataset =
        Namespaced_IRI.parse _namespace_name "MODISDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedPRISMDataset"></see>
    /// </summary>
    let DownloadedPRISMDataset =
        Namespaced_IRI.parse _namespace_name "DownloadedPRISMDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDataset"></see>
    /// </summary>
    let PRISMDataset =
        Namespaced_IRI.parse _namespace_name "PRISMDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#EcologicalCommunity"></see>
    /// </summary>
    let EcologicalCommunity =
        Namespaced_IRI.parse _namespace_name "EcologicalCommunity" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractAndReproject"></see>
    /// </summary>
    let ExtractAndReproject =
        Namespaced_IRI.parse _namespace_name "ExtractAndReproject" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInputBandID"></see>
    /// </summary>
    let hadInputBandID =
        Namespaced_IRI.parse _namespace_name "hadInputBandID" |> NamespacedName

    /// <summary>
    /// A raster dataset that was output by an extraction processing, such as a payload extraction.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractedDataset"></see></summary>
    let ExtractedDataset =
        Namespaced_IRI.parse _namespace_name "ExtractedDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Index"></see>
    /// </summary>
    let Index = Namespaced_IRI.parse _namespace_name "Index" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODIS"></see>
    /// </summary>
    let MODIS = Namespaced_IRI.parse _namespace_name "MODIS" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Sensor"></see>
    /// </summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISMeasurement"></see>
    /// </summary>
    let MODISMeasurement =
        Namespaced_IRI.parse _namespace_name "MODISMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Measurement"></see>
    /// </summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Modelling"></see>
    /// </summary>
    let Modelling = Namespaced_IRI.parse _namespace_name "Modelling" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ModellingAgent"></see>
    /// </summary>
    let ModellingAgent =
        Namespaced_IRI.parse _namespace_name "ModellingAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Mosaic"></see>
    /// </summary>
    let Mosaic = Namespaced_IRI.parse _namespace_name "Mosaic" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MosaicDataset"></see>
    /// </summary>
    let MosaicDataset =
        Namespaced_IRI.parse _namespace_name "MosaicDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISM"></see>
    /// </summary>
    let PRISM = Namespaced_IRI.parse _namespace_name "PRISM" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMModelling"></see>
    /// </summary>
    let PRISMModelling =
        Namespaced_IRI.parse _namespace_name "PRISMModelling" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Precipitation"></see>
    /// </summary>
    let Precipitation =
        Namespaced_IRI.parse _namespace_name "Precipitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#TerrestrialFeature"></see>
    /// </summary>
    let TerrestrialFeature =
        Namespaced_IRI.parse _namespace_name "TerrestrialFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasProcessorName"></see>
    /// </summary>
    let hasProcessorName =
        Namespaced_IRI.parse _namespace_name "hasProcessorName" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Publish"></see>
    /// </summary>
    let Publish = Namespaced_IRI.parse _namespace_name "Publish" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedMODISDataset"></see>
    /// </summary>
    let PublishedMODISDataset =
        Namespaced_IRI.parse _namespace_name "PublishedMODISDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSDataset"></see>
    /// </summary>
    let RGISWCSDataset =
        Namespaced_IRI.parse _namespace_name "RGISWCSDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedPRISMDataset"></see>
    /// </summary>
    let PublishedPRISMDataset =
        Namespaced_IRI.parse _namespace_name "PublishedPRISMDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISDataBand"></see>
    /// </summary>
    let RGISDataBand =
        Namespaced_IRI.parse _namespace_name "RGISDataBand" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasMeasuredBy"></see>
    /// </summary>
    let wasMeasuredBy =
        Namespaced_IRI.parse _namespace_name "wasMeasuredBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasModelledBy"></see>
    /// </summary>
    let wasModelledBy =
        Namespaced_IRI.parse _namespace_name "wasModelledBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasOutputBy"></see>
    /// </summary>
    let wasOutputBy =
        Namespaced_IRI.parse _namespace_name "wasOutputBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSManifestation"></see>
    /// </summary>
    let RGISWCSManifestation =
        Namespaced_IRI.parse _namespace_name "RGISWCSManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasPublishedBy"></see>
    /// </summary>
    let wasPublishedBy =
        Namespaced_IRI.parse _namespace_name "wasPublishedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasJSONCapabilitiesDigestURL"></see>
    /// </summary>
    let hasJSONCapabilitiesDigestURL =
        Namespaced_IRI.parse _namespace_name "hasJSONCapabilitiesDigestURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Reproject"></see>
    /// </summary>
    let Reproject = Namespaced_IRI.parse _namespace_name "Reproject" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ReprojectedDataset"></see>
    /// </summary>
    let ReprojectedDataset =
        Namespaced_IRI.parse _namespace_name "ReprojectedDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#SurfaceLayer"></see>
    /// </summary>
    let SurfaceLayer =
        Namespaced_IRI.parse _namespace_name "SurfaceLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Vegetation"></see>
    /// </summary>
    let Vegetation = Namespaced_IRI.parse _namespace_name "Vegetation" |> NamespacedName
