#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module edac =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#" "edac"

    /// <summary>
    ///   <para>sio:comment : The process of aggregate values in a PRISM dataset over a month.^^xsd:string</para>
    ///   <para>rdfs:label : aggregate monthly^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateMonthly">edac:AggregateMonthly</a>
    /// </summary>
    let AggregateMonthly = _prefixId.prefix "AggregateMonthly"
    /// <summary>
    ///   <para>sio:comment : The process of aggregate values in a PRISM dataset over a thirty years.^^xsd:string</para>
    ///   <para>rdfs:label : aggregate over thirty years^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateOverThirtyYears">edac:AggregateOverThirtyYears</a>
    /// </summary>
    let AggregateOverThirtyYears = _prefixId.prefix "AggregateOverThirtyYears"
    /// <summary>
    ///   <para>sio:comment : The process of aggregate values in a PRISM dataset over a year.^^xsd:string</para>
    ///   <para>rdfs:label : aggregate yearly^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateYearly">edac:AggregateYearly</a>
    /// </summary>
    let AggregateYearly = _prefixId.prefix "AggregateYearly"
    /// <summary>
    ///   <para>sio:comment : Invisible gaseous substance surrounding the earth.^^xsd:string</para>
    ///   <para>rdfs:label : air^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Air">edac:Air</a>
    /// </summary>
    let Air = _prefixId.prefix "Air"
    /// <summary>
    ///   <para>rdfs:label : amount^^xsd:string</para>
    ///   <para>rdfs:comment : A characteristic that can be measured as a quantity.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Amount">edac:Amount</a>
    /// </summary>
    let Amount = _prefixId.prefix "Amount"
    /// <summary>
    ///   <para>sio:comment : An entity in the atmosphere that can be observed.^^xsd:string</para>
    ///   <para>rdfs:label : atmospheric feature^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AtmosphericFeature">edac:AtmosphericFeature</a>
    /// </summary>
    let AtmosphericFeature = _prefixId.prefix "AtmosphericFeature"
    /// <summary>
    ///   <para>sio:comment : A process that involves converting an ASCII file to a TIFF file.^^xsd:string</para>
    ///   <para>rdfs:label : convert ASCII to TIFF^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertASCIIToTIFF">edac:ConvertASCIIToTIFF</a>
    /// </summary>
    let ConvertASCIIToTIFF = _prefixId.prefix "ConvertASCIIToTIFF"
    /// <summary>
    ///   <para>sio:comment : A raster dataset that was output by a conversion processing.^^xsd:string</para>
    ///   <para>rdfs:label : converted dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertedDataset">edac:ConvertedDataset</a>
    /// </summary>
    let ConvertedDataset = _prefixId.prefix "ConvertedDataset"
    /// <summary>
    ///   <para>rdfs:label : databand processing^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DataBandProcessing">edac:DataBandProcessing</a>
    /// </summary>
    let DataBandProcessing = _prefixId.prefix "DataBandProcessing"
    /// <summary>
    ///   <para>sio:comment :  A piece of code used to manipulate a dataset.^^xsd:string</para>
    ///   <para>rdfs:label : dataset manipulation software^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetManipulationSoftware">edac:DatasetManipulationSoftware</a>
    /// </summary>
    let DatasetManipulationSoftware = _prefixId.prefix "DatasetManipulationSoftware"
    /// <summary>
    ///   <para>sio:comment : A process that involves the manipulation of a dataset.^^xsd:string</para>
    ///   <para>rdfs:label : dataset processing^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetProcessing">edac:DatasetProcessing</a>
    /// </summary>
    let DatasetProcessing = _prefixId.prefix "DatasetProcessing"
    /// <summary>
    ///   <para>sio:comment : Temperature at which the water vapor in the air becomes saturated and water droplets begin to form as defined in the Collings English Dictionary.^^xsd:string</para>
    ///   <para>rdfs:label : dew point temperature^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DewPointTemperature">edac:DewPointTemperature</a>
    /// </summary>
    let DewPointTemperature = _prefixId.prefix "DewPointTemperature"
    /// <summary>
    ///   <para>sio:comment : Retrieving a dataset from a specific location in the web.^^xsd:string</para>
    ///   <para>rdfs:label : download^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Download">edac:Download</a>
    /// </summary>
    let Download = _prefixId.prefix "Download"
    /// <summary>
    ///   <para>rdfs:label : downloaded modis dataset^^xsd:string</para>
    ///   <para>rdfs:comment : A MODIS dataset that has been obtained from a URL.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedMODISDataset">edac:DownloadedMODISDataset</a>
    /// </summary>
    let DownloadedMODISDataset = _prefixId.prefix "DownloadedMODISDataset"
    /// <summary>
    ///   <para>sio:comment : A PRISM dataset that has been downloaded from a specific URL.^^xsd:string</para>
    ///   <para>rdfs:label : downloaded prism dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedPRISMDataset">edac:DownloadedPRISMDataset</a>
    /// </summary>
    let DownloadedPRISMDataset = _prefixId.prefix "DownloadedPRISMDataset"
    /// <summary>
    ///   <para>sio:comment : A set of individual entities that can be observed as one entity.^^xsd:string</para>
    ///   <para>rdfs:label : ecological community^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#EcologicalCommunity">edac:EcologicalCommunity</a>
    /// </summary>
    let EcologicalCommunity = _prefixId.prefix "EcologicalCommunity"
    /// <summary>
    ///   <para>sio:comment : A dataset process involving extracting a data band and reprojecting a dataset.^^xsd:string</para>
    ///   <para>rdfs:label : extract and reproject^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractAndReproject">edac:ExtractAndReproject</a>
    /// </summary>
    let ExtractAndReproject = _prefixId.prefix "ExtractAndReproject"
    /// <summary>
    ///   <para>rdfs:label : extracted dataset^^xsd:string</para>
    ///   <para>rdfs:comment : A raster dataset that was output by an extraction processing, such as a payload extraction.^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractedDataset">edac:ExtractedDataset</a>
    /// </summary>
    let ExtractedDataset = _prefixId.prefix "ExtractedDataset"
    /// <summary>
    ///   <para>sio:example : UV index^^xsd:string</para>
    ///   <para>sio:comment : A measurement of a specific characteristic that is commonly used as an indicator.^^xsd:string</para>
    ///   <para>rdfs:label : index^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Index">edac:Index</a>
    /// </summary>
    let Index = _prefixId.prefix "Index"
    let MODIS = _prefixId.prefix "MODIS"
    /// <summary>
    ///   <para>sio:comment : A dataset that contains measurements of a MODIS instrument.^^xsd:string</para>
    ///   <para>rdfs:label : modis dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISDataset">edac:MODISDataset</a>
    /// </summary>
    let MODISDataset = _prefixId.prefix "MODISDataset"
    /// <summary>
    ///   <para>sio:comment : A measurement associated with a MODIS sensor.^^xsd:string</para>
    ///   <para>rdfs:label : modis measurement^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISMeasurement">edac:MODISMeasurement</a>
    /// </summary>
    let MODISMeasurement = _prefixId.prefix "MODISMeasurement"
    /// <summary>
    ///   <para>sio:comment : A characteristic measurement associated with a sensor.^^xsd:string</para>
    ///   <para>rdfs:label : measurement^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Measurement">edac:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>sio:comment : Creation of a model using measurements of characteristics.^^xsd:string</para>
    ///   <para>rdfs:label : modelling^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Modelling">edac:Modelling</a>
    /// </summary>
    let Modelling = _prefixId.prefix "Modelling"
    /// <summary>
    ///   <para>sio:comment : An agent that can generate a model.^^xsd:string</para>
    ///   <para>rdfs:label : modelling agent^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ModellingAgent">edac:ModellingAgent</a>
    /// </summary>
    let ModellingAgent = _prefixId.prefix "ModellingAgent"
    /// <summary>
    ///   <para>sio:comment : A dataset processing involving the creation of a mosaic of raster datasets.^^xsd:string</para>
    ///   <para>rdfs:label : mosaic^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Mosaic">edac:Mosaic</a>
    /// </summary>
    let Mosaic = _prefixId.prefix "Mosaic"
    /// <summary>
    ///   <para>sio:comment : A raster dataset that is part of a mosaic dataset.^^xsd:string</para>
    ///   <para>rdfs:label : mosaic dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MosaicDataset">edac:MosaicDataset</a>
    /// </summary>
    let MosaicDataset = _prefixId.prefix "MosaicDataset"
    let PRISM = _prefixId.prefix "PRISM"
    /// <summary>
    ///   <para>sio:comment : A dataset that provides estimates of three basic climate elements: precipitation, temperature (min and max) and dew point.^^xsd:string</para>
    ///   <para>rdfs:label : prism dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDataset">edac:PRISMDataset</a>
    /// </summary>
    let PRISMDataset = _prefixId.prefix "PRISMDataset"
    /// <summary>
    ///   <para>sio:comment : The process of manipulating a PRISM dataset.^^xsd:string</para>
    ///   <para>rdfs:label : prism dataset processing^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDatasetProcessing">edac:PRISMDatasetProcessing</a>
    /// </summary>
    let PRISMDatasetProcessing = _prefixId.prefix "PRISMDatasetProcessing"
    /// <summary>
    ///   <para>sio:comment : The process of creating a PRISM model.^^xsd:string</para>
    ///   <para>rdfs:label : prism modelling^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMModelling">edac:PRISMModelling</a>
    /// </summary>
    let PRISMModelling = _prefixId.prefix "PRISMModelling"
    /// <summary>
    ///   <para>sio:comment : rain, snow or hail that falls to the ground.^^xsd:string</para>
    ///   <para>rdfs:label : precipitation^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Precipitation">edac:Precipitation</a>
    /// </summary>
    let Precipitation = _prefixId.prefix "Precipitation"
    /// <summary>
    ///   <para>sio:comment : A set of steps to process a dataset.^^xsd:string</para>
    ///   <para>rdfs:label : processing^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processing">edac:Processing</a>
    /// </summary>
    let Processing = _prefixId.prefix "Processing"
    /// <summary>
    ///   <para>sio:comment : An agent that will execute some process over a dataset.^^xsd:string</para>
    ///   <para>rdfs:label : processor^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processor">edac:Processor</a>
    /// </summary>
    let Processor = _prefixId.prefix "Processor"
    /// <summary>
    ///   <para>sio:comment : The process of publishing a dataset over a Web service.^^xsd:string</para>
    ///   <para>rdfs:label : publish^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Publish">edac:Publish</a>
    /// </summary>
    let Publish = _prefixId.prefix "Publish"
    /// <summary>
    ///   <para>sio:comment : A MODIS dataset that is available for retrieval through a RGIS WCS service.^^xsd:string</para>
    ///   <para>rdfs:label : published modis dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedMODISDataset">edac:PublishedMODISDataset</a>
    /// </summary>
    let PublishedMODISDataset = _prefixId.prefix "PublishedMODISDataset"
    /// <summary>
    ///   <para>sio:comment : A PRISM dataset that is available for retrieval through a RGIS WCS service.^^xsd:string</para>
    ///   <para>rdfs:label : published prism dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedPRISMDataset">edac:PublishedPRISMDataset</a>
    /// </summary>
    let PublishedPRISMDataset = _prefixId.prefix "PublishedPRISMDataset"
    /// <summary>
    ///   <para>sio:comment : A databand that is contained in an RGIS dataset.^^xsd:string</para>
    ///   <para>rdfs:label : rgis data band^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISDataBand">edac:RGISDataBand</a>
    /// </summary>
    let RGISDataBand = _prefixId.prefix "RGISDataBand"
    /// <summary>
    ///   <para>sio:comment : A raster dataset that cotians an RGIS databand obtained by some dataset processing.^^xsd:string</para>
    ///   <para>rdfs:label : rgis prepublished raster dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISPrepublishedRasterDataset">edac:RGISPrepublishedRasterDataset</a>
    /// </summary>
    let RGISPrepublishedRasterDataset = _prefixId.prefix "RGISPrepublishedRasterDataset"
    /// <summary>
    ///   <para>sio:comment : A dataset that has been output from a RGIS WCS service manifestation.^^xsd:string</para>
    ///   <para>rdfs:label : rgis wcs dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSDataset">edac:RGISWCSDataset</a>
    /// </summary>
    let RGISWCSDataset = _prefixId.prefix "RGISWCSDataset"
    /// <summary>
    ///   <para>rdfs:label : rgis wcs manifestation^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSManifestation">edac:RGISWCSManifestation</a>
    /// </summary>
    let RGISWCSManifestation = _prefixId.prefix "RGISWCSManifestation"
    /// <summary>
    ///   <para>sio:comment : The process of reprojecting over a dataset.^^xsd:string</para>
    ///   <para>rdfs:label : reproject^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Reproject">edac:Reproject</a>
    /// </summary>
    let Reproject = _prefixId.prefix "Reproject"
    /// <summary>
    ///   <para>sio:comment : A dataset that has been obtained from a reprojection processing.^^xsd:string</para>
    ///   <para>rdfs:label : reprojected dataset^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ReprojectedDataset">edac:ReprojectedDataset</a>
    /// </summary>
    let ReprojectedDataset = _prefixId.prefix "ReprojectedDataset"
    /// <summary>
    ///   <para>sio:example : MODIS^^xsd:string</para>
    ///   <para>sio:comment : An agent that can capture a measurement of a characteristic of an entity.^^xsd:string</para>
    ///   <para>rdfs:label : sensor^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Sensor">edac:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : surface layer^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#SurfaceLayer">edac:SurfaceLayer</a>
    /// </summary>
    let SurfaceLayer = _prefixId.prefix "SurfaceLayer"
    /// <summary>
    ///   <para>sio:comment : A measurement of hot or cold.^^xsd:string</para>
    ///   <para>rdfs:label : temperature^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Temperature">edac:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>sio:comment : An entity that is situated the earth.^^xsd:string</para>
    ///   <para>rdfs:label : terrestrial feature^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#TerrestrialFeature">edac:TerrestrialFeature</a>
    /// </summary>
    let TerrestrialFeature = _prefixId.prefix "TerrestrialFeature"
    /// <summary>
    ///   <para>sio:comment : Group of plants observed collectively in a particulare area or habitat.^^xsd:string</para>
    ///   <para>rdfs:label : vegetation^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Vegetation">edac:Vegetation</a>
    /// </summary>
    let Vegetation = _prefixId.prefix "Vegetation"
    /// <summary>
    ///   <para>rdfs:label : had input^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInput">edac:hadInput</a>
    /// </summary>
    let hadInput = _prefixId.prefix "hadInput"
    /// <summary>
    ///   <para>rdfs:label : had input band id^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInputBandID">edac:hadInputBandID</a>
    /// </summary>
    let hadInputBandID = _prefixId.prefix "hadInputBandID"
    /// <summary>
    ///   <para>rdfs:label : has json capabilities digest url^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasJSONCapabilitiesDigestURL">edac:hasJSONCapabilitiesDigestURL</a>
    /// </summary>
    let hasJSONCapabilitiesDigestURL = _prefixId.prefix "hasJSONCapabilitiesDigestURL"
    /// <summary>
    ///   <para>rdfs:label : has processor name^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasProcessorName">edac:hasProcessorName</a>
    /// </summary>
    let hasProcessorName = _prefixId.prefix "hasProcessorName"
    /// <summary>
    ///   <para>rdfs:label : was associated with^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasAssociatedWith">edac:wasAssociatedWith</a>
    /// </summary>
    let wasAssociatedWith = _prefixId.prefix "wasAssociatedWith"
    /// <summary>
    ///   <para>rdfs:label : was measured by^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasMeasuredBy">edac:wasMeasuredBy</a>
    /// </summary>
    let wasMeasuredBy = _prefixId.prefix "wasMeasuredBy"
    /// <summary>
    ///   <para>rdfs:label : was modelled by^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasModelledBy">edac:wasModelledBy</a>
    /// </summary>
    let wasModelledBy = _prefixId.prefix "wasModelledBy"
    /// <summary>
    ///   <para>rdfs:label : was output by^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasOutputBy">edac:wasOutputBy</a>
    /// </summary>
    let wasOutputBy = _prefixId.prefix "wasOutputBy"
    /// <summary>
    ///   <para>rdfs:label : was published by^^xsd:string</para>
    ///   <a href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasPublishedBy">edac:wasPublishedBy</a>
    /// </summary>
    let wasPublishedBy = _prefixId.prefix "wasPublishedBy"
