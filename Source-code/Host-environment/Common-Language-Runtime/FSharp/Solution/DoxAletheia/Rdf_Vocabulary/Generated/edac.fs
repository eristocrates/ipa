namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_edac.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module edac =
    let _namespace_iri = Namespace_Iri edac |> NamespaceIRI
    /// <summary>
    ///   <para>edac:ConvertASCIIToTIFF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>convert ASCII to TIFF</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertASCIIToTIFF">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertASCIIToTIFF</seealso>
    let ConvertASCIIToTIFF = Prefixed_Name(edac, "ConvertASCIIToTIFF") |> PrefixedName
    /// <summary>
    ///   <para>edac:hadInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>had input</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInput">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInput</seealso>
    let hadInput = Prefixed_Name(edac, "hadInput") |> PrefixedName

    /// <summary>
    ///   <para>edac:DownloadedPRISMDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>downloaded prism dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedPRISMDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedPRISMDataset</seealso>
    let DownloadedPRISMDataset =
        Prefixed_Name(edac, "DownloadedPRISMDataset") |> PrefixedName

    /// <summary>
    ///   <para>edac:hadInputBandID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>had input band id</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInputBandID">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hadInputBandID</seealso>
    let hadInputBandID = Prefixed_Name(edac, "hadInputBandID") |> PrefixedName
    /// <summary>
    ///   <para>edac:ExtractedDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A raster dataset that was output by an extraction processing, such as a payload extraction.</para>
    /// labels<para>extracted dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractedDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractedDataset</seealso>
    let ExtractedDataset = Prefixed_Name(edac, "ExtractedDataset") |> PrefixedName
    /// <summary>
    ///   <para>edac:MODIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>edac:Sensor</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODIS">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODIS</seealso>
    let MODIS = Prefixed_Name(edac, "MODIS") |> PrefixedName
    /// <summary>
    ///   <para>edac:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>measurement</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Measurement">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Measurement</seealso>
    let Measurement = Prefixed_Name(edac, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>edac:AggregateMonthly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>aggregate monthly</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateMonthly">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateMonthly</seealso>
    let AggregateMonthly = Prefixed_Name(edac, "AggregateMonthly") |> PrefixedName
    /// <summary>
    ///   <para>edac:Precipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>precipitation</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Precipitation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Precipitation</seealso>
    let Precipitation = Prefixed_Name(edac, "Precipitation") |> PrefixedName
    /// <summary>
    ///   <para>edac:hasProcessorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has processor name</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasProcessorName">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasProcessorName</seealso>
    let hasProcessorName = Prefixed_Name(edac, "hasProcessorName") |> PrefixedName
    /// <summary>
    ///   <para>edac:Publish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>publish</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Publish">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Publish</seealso>
    let Publish = Prefixed_Name(edac, "Publish") |> PrefixedName

    /// <summary>
    ///   <para>edac:AggregateOverThirtyYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>aggregate over thirty years</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateOverThirtyYears">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateOverThirtyYears</seealso>
    let AggregateOverThirtyYears =
        Prefixed_Name(edac, "AggregateOverThirtyYears") |> PrefixedName

    /// <summary>
    ///   <para>edac:AtmosphericFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>atmospheric feature</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AtmosphericFeature">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AtmosphericFeature</seealso>
    let AtmosphericFeature = Prefixed_Name(edac, "AtmosphericFeature") |> PrefixedName
    /// <summary>
    ///   <para>edac:ConvertedDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>converted dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertedDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ConvertedDataset</seealso>
    let ConvertedDataset = Prefixed_Name(edac, "ConvertedDataset") |> PrefixedName
    /// <summary>
    ///   <para>edac:Processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>processing</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processing">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processing</seealso>
    let Processing = Prefixed_Name(edac, "Processing") |> PrefixedName

    /// <summary>
    ///   <para>edac:DatasetManipulationSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>dataset manipulation software</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetManipulationSoftware">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetManipulationSoftware</seealso>
    let DatasetManipulationSoftware =
        Prefixed_Name(edac, "DatasetManipulationSoftware") |> PrefixedName

    /// <summary>
    ///   <para>edac:PRISMDatasetProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prism dataset processing</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDatasetProcessing">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDatasetProcessing</seealso>
    let PRISMDatasetProcessing =
        Prefixed_Name(edac, "PRISMDatasetProcessing") |> PrefixedName

    /// <summary>
    ///   <para>edac:Air</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>air</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Air">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Air</seealso>
    let Air = Prefixed_Name(edac, "Air") |> PrefixedName
    /// <summary>
    ///   <para>edac:Amount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A characteristic that can be measured as a quantity.</para>
    /// labels<para>amount</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Amount">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Amount</seealso>
    let Amount = Prefixed_Name(edac, "Amount") |> PrefixedName
    /// <summary>
    ///   <para>edac:DatasetProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>dataset processing</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetProcessing">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DatasetProcessing</seealso>
    let DatasetProcessing = Prefixed_Name(edac, "DatasetProcessing") |> PrefixedName
    /// <summary>
    ///   <para>edac:Processor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>processor</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processor">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Processor</seealso>
    let Processor = Prefixed_Name(edac, "Processor") |> PrefixedName
    /// <summary>
    ///   <para>edac:AggregateYearly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>aggregate yearly</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateYearly">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#AggregateYearly</seealso>
    let AggregateYearly = Prefixed_Name(edac, "AggregateYearly") |> PrefixedName

    /// <summary>
    ///   <para>edac:RGISPrepublishedRasterDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>rgis prepublished raster dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISPrepublishedRasterDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISPrepublishedRasterDataset</seealso>
    let RGISPrepublishedRasterDataset =
        Prefixed_Name(edac, "RGISPrepublishedRasterDataset") |> PrefixedName

    /// <summary>
    ///   <para>edac:wasAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>was associated with</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasAssociatedWith">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasAssociatedWith</seealso>
    let wasAssociatedWith = Prefixed_Name(edac, "wasAssociatedWith") |> PrefixedName
    /// <summary>
    ///   <para>edac:DewPointTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>dew point temperature</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DewPointTemperature">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DewPointTemperature</seealso>
    let DewPointTemperature = Prefixed_Name(edac, "DewPointTemperature") |> PrefixedName
    /// <summary>
    ///   <para>edac:Download</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>download</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Download">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Download</seealso>
    let Download = Prefixed_Name(edac, "Download") |> PrefixedName
    /// <summary>
    ///   <para>edac:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>temperature</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Temperature">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Temperature</seealso>
    let Temperature = Prefixed_Name(edac, "Temperature") |> PrefixedName

    /// <summary>
    ///   <para>edac:DownloadedMODISDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A MODIS dataset that has been obtained from a URL.</para>
    /// labels<para>downloaded modis dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedMODISDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DownloadedMODISDataset</seealso>
    let DownloadedMODISDataset =
        Prefixed_Name(edac, "DownloadedMODISDataset") |> PrefixedName

    /// <summary>
    ///   <para>edac:PRISMDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prism dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMDataset</seealso>
    let PRISMDataset = Prefixed_Name(edac, "PRISMDataset") |> PrefixedName
    /// <summary>
    ///   <para>edac:ExtractAndReproject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>extract and reproject</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractAndReproject">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ExtractAndReproject</seealso>
    let ExtractAndReproject = Prefixed_Name(edac, "ExtractAndReproject") |> PrefixedName
    /// <summary>
    ///   <para>edac:Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>index</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Index">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Index</seealso>
    let Index = Prefixed_Name(edac, "Index") |> PrefixedName
    /// <summary>
    ///   <para>edac:MODISMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>modis measurement</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISMeasurement">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISMeasurement</seealso>
    let MODISMeasurement = Prefixed_Name(edac, "MODISMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>edac:MODISDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>modis dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MODISDataset</seealso>
    let MODISDataset = Prefixed_Name(edac, "MODISDataset") |> PrefixedName
    /// <summary>
    ///   <para>edac:EcologicalCommunity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ecological community</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#EcologicalCommunity">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#EcologicalCommunity</seealso>
    let EcologicalCommunity = Prefixed_Name(edac, "EcologicalCommunity") |> PrefixedName
    /// <summary>
    ///   <para>edac:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>sensor</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Sensor">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Sensor</seealso>
    let Sensor = Prefixed_Name(edac, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>edac:Modelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>modelling</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Modelling">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Modelling</seealso>
    let Modelling = Prefixed_Name(edac, "Modelling") |> PrefixedName
    /// <summary>
    ///   <para>edac:Mosaic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>mosaic</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Mosaic">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Mosaic</seealso>
    let Mosaic = Prefixed_Name(edac, "Mosaic") |> PrefixedName
    /// <summary>
    ///   <para>edac:MosaicDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>mosaic dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MosaicDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#MosaicDataset</seealso>
    let MosaicDataset = Prefixed_Name(edac, "MosaicDataset") |> PrefixedName
    /// <summary>
    ///   <para>edac:ModellingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>modelling agent</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ModellingAgent">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ModellingAgent</seealso>
    let ModellingAgent = Prefixed_Name(edac, "ModellingAgent") |> PrefixedName
    /// <summary>
    ///   <para>edac:PRISM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISM">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISM</seealso>
    let PRISM = Prefixed_Name(edac, "PRISM") |> PrefixedName
    /// <summary>
    ///   <para>edac:PRISMModelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prism modelling</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMModelling">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PRISMModelling</seealso>
    let PRISMModelling = Prefixed_Name(edac, "PRISMModelling") |> PrefixedName
    /// <summary>
    ///   <para>edac:RGISWCSDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>rgis wcs dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSDataset</seealso>
    let RGISWCSDataset = Prefixed_Name(edac, "RGISWCSDataset") |> PrefixedName

    /// <summary>
    ///   <para>edac:PublishedPRISMDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>published prism dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedPRISMDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedPRISMDataset</seealso>
    let PublishedPRISMDataset =
        Prefixed_Name(edac, "PublishedPRISMDataset") |> PrefixedName

    /// <summary>
    ///   <para>edac:wasModelledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>was modelled by</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasModelledBy">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasModelledBy</seealso>
    let wasModelledBy = Prefixed_Name(edac, "wasModelledBy") |> PrefixedName
    /// <summary>
    ///   <para>edac:TerrestrialFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>terrestrial feature</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#TerrestrialFeature">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#TerrestrialFeature</seealso>
    let TerrestrialFeature = Prefixed_Name(edac, "TerrestrialFeature") |> PrefixedName

    /// <summary>
    ///   <para>edac:PublishedMODISDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>published modis dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedMODISDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#PublishedMODISDataset</seealso>
    let PublishedMODISDataset =
        Prefixed_Name(edac, "PublishedMODISDataset") |> PrefixedName

    /// <summary>
    ///   <para>edac:wasMeasuredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>was measured by</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasMeasuredBy">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasMeasuredBy</seealso>
    let wasMeasuredBy = Prefixed_Name(edac, "wasMeasuredBy") |> PrefixedName
    /// <summary>
    ///   <para>edac:wasPublishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>was published by</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasPublishedBy">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasPublishedBy</seealso>
    let wasPublishedBy = Prefixed_Name(edac, "wasPublishedBy") |> PrefixedName
    /// <summary>
    ///   <para>edac:Reproject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reproject</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Reproject">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Reproject</seealso>
    let Reproject = Prefixed_Name(edac, "Reproject") |> PrefixedName
    /// <summary>
    ///   <para>edac:RGISDataBand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>rgis data band</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISDataBand">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISDataBand</seealso>
    let RGISDataBand = Prefixed_Name(edac, "RGISDataBand") |> PrefixedName
    /// <summary>
    ///   <para>edac:wasOutputBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>was output by</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasOutputBy">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#wasOutputBy</seealso>
    let wasOutputBy = Prefixed_Name(edac, "wasOutputBy") |> PrefixedName

    /// <summary>
    ///   <para>edac:RGISWCSManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>rgis wcs manifestation</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSManifestation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#RGISWCSManifestation</seealso>
    let RGISWCSManifestation =
        Prefixed_Name(edac, "RGISWCSManifestation") |> PrefixedName

    /// <summary>
    ///   <para>edac:hasJSONCapabilitiesDigestURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has json capabilities digest url</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasJSONCapabilitiesDigestURL">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#hasJSONCapabilitiesDigestURL</seealso>
    let hasJSONCapabilitiesDigestURL =
        Prefixed_Name(edac, "hasJSONCapabilitiesDigestURL") |> PrefixedName

    /// <summary>
    ///   <para>edac:ReprojectedDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reprojected dataset</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ReprojectedDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#ReprojectedDataset</seealso>
    let ReprojectedDataset = Prefixed_Name(edac, "ReprojectedDataset") |> PrefixedName
    /// <summary>
    ///   <para>edac:SurfaceLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>surface layer</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#SurfaceLayer">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#SurfaceLayer</seealso>
    let SurfaceLayer = Prefixed_Name(edac, "SurfaceLayer") |> PrefixedName
    /// <summary>
    ///   <para>edac:Vegetation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>vegetation</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Vegetation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#Vegetation</seealso>
    let Vegetation = Prefixed_Name(edac, "Vegetation") |> PrefixedName
    /// <summary>
    ///   <para>edac:DataBandProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>databand processing</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DataBandProcessing">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#DataBandProcessing</seealso>
    let DataBandProcessing = Prefixed_Name(edac, "DataBandProcessing") |> PrefixedName
