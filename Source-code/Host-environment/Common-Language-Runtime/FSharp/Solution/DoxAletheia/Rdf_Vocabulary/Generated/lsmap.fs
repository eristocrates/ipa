namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_data.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lsmap =
    let _namespace_iri = Namespace_Iri lsmap |> NamespaceIRI
    /// <summary>
    ///   <para>lsmap:Band</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Band">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Band</seealso>
    let Band = Prefixed_Name(lsmap, "Band") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:BandIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#BandIdentification">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#BandIdentification</seealso>
    let BandIdentification = Prefixed_Name(lsmap, "BandIdentification") |> PrefixedName

    /// <summary>
    ///   <para>lsmap:BoxedGeographicRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#BoxedGeographicRegion">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#BoxedGeographicRegion</seealso>
    let BoxedGeographicRegion =
        Prefixed_Name(lsmap, "BoxedGeographicRegion") |> PrefixedName

    /// <summary>
    ///   <para>lsmap:Characteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Characteristic">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Characteristic</seealso>
    let Characteristic = Prefixed_Name(lsmap, "Characteristic") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:DataBand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#DataBand">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#DataBand</seealso>
    let DataBand = Prefixed_Name(lsmap, "DataBand") |> PrefixedName

    /// <summary>
    ///   <para>lsmap:DatasetManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#DatasetManifestation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#DatasetManifestation</seealso>
    let DatasetManifestation =
        Prefixed_Name(lsmap, "DatasetManifestation") |> PrefixedName

    /// <summary>
    ///   <para>lsmap:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Entity">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Entity</seealso>
    let Entity = Prefixed_Name(lsmap, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:FeatureSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#FeatureSet">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#FeatureSet</seealso>
    let FeatureSet = Prefixed_Name(lsmap, "FeatureSet") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:FileManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#FileManifestation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#FileManifestation</seealso>
    let FileManifestation = Prefixed_Name(lsmap, "FileManifestation") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Format">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Format</seealso>
    let Format = Prefixed_Name(lsmap, "Format") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:GeographicRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeographicRegion">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeographicRegion</seealso>
    let GeographicRegion = Prefixed_Name(lsmap, "GeographicRegion") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:GeospatialDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeospatialDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeospatialDataset</seealso>
    let GeospatialDataset = Prefixed_Name(lsmap, "GeospatialDataset") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Layer">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Layer</seealso>
    let Layer = Prefixed_Name(lsmap, "Layer") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Provider">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Provider</seealso>
    let Provider = Prefixed_Name(lsmap, "Provider") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:RasterDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#RasterDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#RasterDataset</seealso>
    let RasterDataset = Prefixed_Name(lsmap, "RasterDataset") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Theme">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Theme</seealso>
    let Theme = Prefixed_Name(lsmap, "Theme") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:TimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#TimePeriod">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#TimePeriod</seealso>
    let TimePeriod = Prefixed_Name(lsmap, "TimePeriod") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Unit">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Unit</seealso>
    let Unit = Prefixed_Name(lsmap, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:VectorDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#VectorDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#VectorDataset</seealso>
    let VectorDataset = Prefixed_Name(lsmap, "VectorDataset") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:WCSDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#WCSDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#WCSDataset</seealso>
    let WCSDataset = Prefixed_Name(lsmap, "WCSDataset") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:WCSManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#WCSManifestation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#WCSManifestation</seealso>
    let WCSManifestation = Prefixed_Name(lsmap, "WCSManifestation") |> PrefixedName

    /// <summary>
    ///   <para>lsmap:WCSResponseManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#WCSResponseManifestation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#WCSResponseManifestation</seealso>
    let WCSResponseManifestation =
        Prefixed_Name(lsmap, "WCSResponseManifestation") |> PrefixedName

    /// <summary>
    ///   <para>lsmap:containsFeatureSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contains feature set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#containsFeatureSet">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#containsFeatureSet</seealso>
    let containsFeatureSet = Prefixed_Name(lsmap, "containsFeatureSet") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:coversRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"covers region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#coversRegion">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#coversRegion</seealso>
    let coversRegion = Prefixed_Name(lsmap, "coversRegion") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:encodedInFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#encodedInFormat">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#encodedInFormat</seealso>
    let encodedInFormat = Prefixed_Name(lsmap, "encodedInFormat") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:hasDataBand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has data band"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasDataBand">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasDataBand</seealso>
    let hasDataBand = Prefixed_Name(lsmap, "hasDataBand") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:hasLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasLayer">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasLayer</seealso>
    let hasLayer = Prefixed_Name(lsmap, "hasLayer") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:hasManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has manifestation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasManifestation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasManifestation</seealso>
    let hasManifestation = Prefixed_Name(lsmap, "hasManifestation") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:representsEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"represents entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#representsEntity">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#representsEntity</seealso>
    let representsEntity = Prefixed_Name(lsmap, "representsEntity") |> PrefixedName
