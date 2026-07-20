namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_edac.owl.hash

open DoxAletheia

module edac =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateMonthly"></see>
    /// </summary>
    let AggregateMonthly = _prefix "AggregateMonthly"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDatasetProcessing"></see>
    /// </summary>
    let PRISMDatasetProcessing = _prefix "PRISMDatasetProcessing"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateOverThirtyYears"></see>
    /// </summary>
    let AggregateOverThirtyYears = _prefix "AggregateOverThirtyYears"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateYearly"></see>
    /// </summary>
    let AggregateYearly = _prefix "AggregateYearly"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Air"></see>
    /// </summary>
    let Air = _prefix "Air"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AtmosphericFeature"></see>
    /// </summary>
    let AtmosphericFeature = _prefix "AtmosphericFeature"
    /// <summary>
    /// A characteristic that can be measured as a quantity.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Amount"></see></summary>
    let Amount = _prefix "Amount"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertASCIIToTIFF"></see>
    /// </summary>
    let ConvertASCIIToTIFF = _prefix "ConvertASCIIToTIFF"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetProcessing"></see>
    /// </summary>
    let DatasetProcessing = _prefix "DatasetProcessing"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertedDataset"></see>
    /// </summary>
    let ConvertedDataset = _prefix "ConvertedDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISPrepublishedRasterDataset"></see>
    /// </summary>
    let RGISPrepublishedRasterDataset = _prefix "RGISPrepublishedRasterDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DataBandProcessing"></see>
    /// </summary>
    let DataBandProcessing = _prefix "DataBandProcessing"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processing"></see>
    /// </summary>
    let Processing = _prefix "Processing"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetManipulationSoftware"></see>
    /// </summary>
    let DatasetManipulationSoftware = _prefix "DatasetManipulationSoftware"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processor"></see>
    /// </summary>
    let Processor = _prefix "Processor"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInput"></see>
    /// </summary>
    let hadInput = _prefix "hadInput"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasAssociatedWith"></see>
    /// </summary>
    let wasAssociatedWith = _prefix "wasAssociatedWith"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DewPointTemperature"></see>
    /// </summary>
    let DewPointTemperature = _prefix "DewPointTemperature"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Temperature"></see>
    /// </summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Download"></see>
    /// </summary>
    let Download = _prefix "Download"
    /// <summary>
    /// A MODIS dataset that has been obtained from a URL.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedMODISDataset"></see></summary>
    let DownloadedMODISDataset = _prefix "DownloadedMODISDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISDataset"></see>
    /// </summary>
    let MODISDataset = _prefix "MODISDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedPRISMDataset"></see>
    /// </summary>
    let DownloadedPRISMDataset = _prefix "DownloadedPRISMDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDataset"></see>
    /// </summary>
    let PRISMDataset = _prefix "PRISMDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#EcologicalCommunity"></see>
    /// </summary>
    let EcologicalCommunity = _prefix "EcologicalCommunity"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractAndReproject"></see>
    /// </summary>
    let ExtractAndReproject = _prefix "ExtractAndReproject"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInputBandID"></see>
    /// </summary>
    let hadInputBandID = _prefix "hadInputBandID"
    /// <summary>
    /// A raster dataset that was output by an extraction processing, such as a payload extraction.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractedDataset"></see></summary>
    let ExtractedDataset = _prefix "ExtractedDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Index"></see>
    /// </summary>
    let Index = _prefix "Index"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODIS"></see>
    /// </summary>
    let MODIS = _prefix "MODIS"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Sensor"></see>
    /// </summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISMeasurement"></see>
    /// </summary>
    let MODISMeasurement = _prefix "MODISMeasurement"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Measurement"></see>
    /// </summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Modelling"></see>
    /// </summary>
    let Modelling = _prefix "Modelling"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ModellingAgent"></see>
    /// </summary>
    let ModellingAgent = _prefix "ModellingAgent"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Mosaic"></see>
    /// </summary>
    let Mosaic = _prefix "Mosaic"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MosaicDataset"></see>
    /// </summary>
    let MosaicDataset = _prefix "MosaicDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISM"></see>
    /// </summary>
    let PRISM = _prefix "PRISM"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMModelling"></see>
    /// </summary>
    let PRISMModelling = _prefix "PRISMModelling"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Precipitation"></see>
    /// </summary>
    let Precipitation = _prefix "Precipitation"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#TerrestrialFeature"></see>
    /// </summary>
    let TerrestrialFeature = _prefix "TerrestrialFeature"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasProcessorName"></see>
    /// </summary>
    let hasProcessorName = _prefix "hasProcessorName"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Publish"></see>
    /// </summary>
    let Publish = _prefix "Publish"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedMODISDataset"></see>
    /// </summary>
    let PublishedMODISDataset = _prefix "PublishedMODISDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSDataset"></see>
    /// </summary>
    let RGISWCSDataset = _prefix "RGISWCSDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedPRISMDataset"></see>
    /// </summary>
    let PublishedPRISMDataset = _prefix "PublishedPRISMDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISDataBand"></see>
    /// </summary>
    let RGISDataBand = _prefix "RGISDataBand"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasMeasuredBy"></see>
    /// </summary>
    let wasMeasuredBy = _prefix "wasMeasuredBy"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasModelledBy"></see>
    /// </summary>
    let wasModelledBy = _prefix "wasModelledBy"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasOutputBy"></see>
    /// </summary>
    let wasOutputBy = _prefix "wasOutputBy"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSManifestation"></see>
    /// </summary>
    let RGISWCSManifestation = _prefix "RGISWCSManifestation"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasPublishedBy"></see>
    /// </summary>
    let wasPublishedBy = _prefix "wasPublishedBy"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasJSONCapabilitiesDigestURL"></see>
    /// </summary>
    let hasJSONCapabilitiesDigestURL = _prefix "hasJSONCapabilitiesDigestURL"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Reproject"></see>
    /// </summary>
    let Reproject = _prefix "Reproject"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ReprojectedDataset"></see>
    /// </summary>
    let ReprojectedDataset = _prefix "ReprojectedDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#SurfaceLayer"></see>
    /// </summary>
    let SurfaceLayer = _prefix "SurfaceLayer"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Vegetation"></see>
    /// </summary>
    let Vegetation = _prefix "Vegetation"
