namespace http.purl.org.twc.vocab.conversion.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module conversion =
    let _namespace_iri = Namespace_Iri conversion |> NamespaceIRI
    /// <summary>
    ///   <para>conversion:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This ontology is used by the csv2rdf4lod project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/">http://purl.org/twc/vocab/conversion/</seealso>
    let _prefix_iri = Prefixed_Name(conversion, "") |> PrefixedName
    /// <summary>
    ///   <para>conversion:AbstractDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dataset with source and dataset identifiers, but not version. Before any version is materialized (captured in time), and the union of all VersionedDatasets."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Abstract Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/AbstractDataset">http://purl.org/twc/vocab/conversion/AbstractDataset</seealso>
    let AbstractDataset = Prefixed_Name(conversion, "AbstractDataset") |> PrefixedName
    /// <summary>
    ///   <para>conversion:AuxiliaryDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/AuxiliaryDataset">http://purl.org/twc/vocab/conversion/AuxiliaryDataset</seealso>
    let AuxiliaryDataset = Prefixed_Name(conversion, "AuxiliaryDataset") |> PrefixedName

    /// <summary>
    ///   <para>conversion:BooleanPromotionEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Casts raw literal values into xsd:boolean datatyped values. The default recognized lexical representations are (case insensitive): 'yes', 'no', 'true', 'false', '0', and '1'. The conversion:boolean_true and conversion:boolean_false properties may be used to add additional lexical forms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boolean promotion enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/BooleanPromotionEnhancement">http://purl.org/twc/vocab/conversion/BooleanPromotionEnhancement</seealso>
    let BooleanPromotionEnhancement =
        Prefixed_Name(conversion, "BooleanPromotionEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:BooleanSymbolInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any SymbolInterpretation that interprets to true or false is a BooleanSymbolInterpretation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/BooleanSymbolInterpretation">http://purl.org/twc/vocab/conversion/BooleanSymbolInterpretation</seealso>
    let BooleanSymbolInterpretation =
        Prefixed_Name(conversion, "BooleanSymbolInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>conversion:Bundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Property</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bundle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Bundle">http://purl.org/twc/vocab/conversion/Bundle</seealso>
    let Bundle = Prefixed_Name(conversion, "Bundle") |> PrefixedName

    /// <summary>
    ///   <para>conversion:CSV2RDF4LOD_environment_variables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A shell script that sets https://github.com/timrdf/csv2rdf4lod-automation/wiki/CSV2RDF4LOD-environment-variables to control the behavior of csv2rdf4lod-automation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CSV2RDF4LOD_environment_variables"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/CSV2RDF4LOD_environment_variables">http://purl.org/twc/vocab/conversion/CSV2RDF4LOD_environment_variables</seealso>
    let CSV2RDF4LOD_environment_variables =
        Prefixed_Name(conversion, "CSV2RDF4LOD_environment_variables") |> PrefixedName

    /// <summary>
    ///   <para>conversion:CaseInsensitiveLODLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ignore string case when attempting to match identifiers between the input table and the identifiers in the LODLinks graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/CaseInsensitiveLODLink">http://purl.org/twc/vocab/conversion/CaseInsensitiveLODLink</seealso>
    let CaseInsensitiveLODLink =
        Prefixed_Name(conversion, "CaseInsensitiveLODLink") |> PrefixedName

    /// <summary>
    ///   <para>conversion:CatalogedDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CatalogedDataset is any kind of dataset, in the most general sense and regardless of how it is encoded (RDF, Relational, Tabular, XML, SPS, etc.). If someone says to you, 'yea, NASA has a Mars imagery dataset, talk to Joe about it and visit its homepage', you just instantiated a CatalogedDataset. There are MANY CatalogedDatasets that are NOT conversion:Datasets and NOT void:Datasets, since both of these are RDF-based datasets. The purpose of CatalogedDataset is to maintain a list of 'TODO' items that could be explored, converted, and published as RDF. Once a CatalogedDataset IS investigated, named, and converted, it also becomes a conversion:Dataset (and thus a void:Datast)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/CatalogedDataset">http://purl.org/twc/vocab/conversion/CatalogedDataset</seealso>
    let CatalogedDataset = Prefixed_Name(conversion, "CatalogedDataset") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ConversionMetaDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metadata for a dataset that is created during the dataset's conversion invocation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ConversionMetaDataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ConversionMetaDataset">http://purl.org/twc/vocab/conversion/ConversionMetaDataset</seealso>
    let ConversionMetaDataset =
        Prefixed_Name(conversion, "ConversionMetaDataset") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ConversionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Superclass for different conversion processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ConversionProcess">http://purl.org/twc/vocab/conversion/ConversionProcess</seealso>
    let ConversionProcess =
        Prefixed_Name(conversion, "ConversionProcess") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ConversionTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In csv2rdf4lod-automation, the conversion trigger is a shell script situated within the conversion cockpit that initiates conversion of source data to RDF."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ConversionTrigger"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ConversionTrigger">http://purl.org/twc/vocab/conversion/ConversionTrigger</seealso>
    let ConversionTrigger =
        Prefixed_Name(conversion, "ConversionTrigger") |> PrefixedName

    /// <summary>
    ///   <para>conversion:Curl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserted by pcurl.sh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Curl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Curl">http://purl.org/twc/vocab/conversion/Curl</seealso>
    let Curl = Prefixed_Name(conversion, "Curl") |> PrefixedName
    /// <summary>
    ///   <para>conversion:DataEndRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DataEndRow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DataEndRow">http://purl.org/twc/vocab/conversion/DataEndRow</seealso>
    let DataEndRow = Prefixed_Name(conversion, "DataEndRow") |> PrefixedName
    /// <summary>
    ///   <para>conversion:DataStartRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DataStartRow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DataStartRow">http://purl.org/twc/vocab/conversion/DataStartRow</seealso>
    let DataStartRow = Prefixed_Name(conversion, "DataStartRow") |> PrefixedName
    /// <summary>
    ///   <para>conversion:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserted by the converter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Dataset">http://purl.org/twc/vocab/conversion/Dataset</seealso>
    let Dataset = Prefixed_Name(conversion, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>conversion:DatasetCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dataset that lists other datasets as its entries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dataset Catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DatasetCatalog">http://purl.org/twc/vocab/conversion/DatasetCatalog</seealso>
    let DatasetCatalog = Prefixed_Name(conversion, "DatasetCatalog") |> PrefixedName
    /// <summary>
    ///   <para>conversion:DatasetSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A potentially incomplete subset of a void:Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dataset Sample"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DatasetSample">http://purl.org/twc/vocab/conversion/DatasetSample</seealso>
    let DatasetSample = Prefixed_Name(conversion, "DatasetSample") |> PrefixedName

    /// <summary>
    ///   <para>conversion:DatatypePromotionEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Promotes the raw literal value to a datatyped literal using the datatype specified with the conversion:range property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Literal datatype promotion enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DatatypePromotionEnhancement">http://purl.org/twc/vocab/conversion/DatatypePromotionEnhancement</seealso>
    let DatatypePromotionEnhancement =
        Prefixed_Name(conversion, "DatatypePromotionEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:DatePromotionEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Casts raw literal values into W3CDTF values typed as xsd:date based on a strftime pattern specified with the conversion:date_pattern. If the property values follow different patterns, multiple conversion:date_pattern values may specified."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"For each value, all DateTimePromotionEnhancement patterns are attempted before attempting any DatePromotionEnhancement patterns specified for the same property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Date promotion enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DatePromotionEnhancement">http://purl.org/twc/vocab/conversion/DatePromotionEnhancement</seealso>
    let DatePromotionEnhancement =
        Prefixed_Name(conversion, "DatePromotionEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:DateTimePromotionEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Casts raw literal values into W3CDTF values typed as xsd:dateTime based on a strftime pattern specified with the conversion:datetime_pattern. If the property values follow different patterns, multiple conversion:datetime_pattern values may specified. The first matching pattern (of a nondeterministic ordering) will be applied. An optional conversion:datetime_timezone may be specified if no timezone information is present in the datetime pattern."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DateTime promotion enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DateTimePromotionEnhancement">http://purl.org/twc/vocab/conversion/DateTimePromotionEnhancement</seealso>
    let DateTimePromotionEnhancement =
        Prefixed_Name(conversion, "DateTimePromotionEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:Deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Deprecated">http://purl.org/twc/vocab/conversion/Deprecated</seealso>
    let Deprecated = Prefixed_Name(conversion, "Deprecated") |> PrefixedName

    /// <summary>
    ///   <para>conversion:DirectSameAsEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"For any Resource that became owl:sameAs another Resource in an external LOD bubble, use ALL external URIs instead of the local resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IndirectSameAsEnhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DirectSameAsEnhancement">http://purl.org/twc/vocab/conversion/DirectSameAsEnhancement</seealso>
    let DirectSameAsEnhancement =
        Prefixed_Name(conversion, "DirectSameAsEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:DocumentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"The state of a document at a point in time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/DocumentState">http://purl.org/twc/vocab/conversion/DocumentState</seealso>
    let DocumentState = Prefixed_Name(conversion, "DocumentState") |> PrefixedName
    /// <summary>
    ///   <para>conversion:Enhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"The superclass of all enhancements. When the enhancement is referring to a particular property, the property's local name or originating column number may be used (using conversion:property_name and ov:csvCol, respectively)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Enhancement">http://purl.org/twc/vocab/conversion/Enhancement</seealso>
    let Enhancement = Prefixed_Name(conversion, "Enhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:EnhancementProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"An enhancement of an RDF dataset that adds new RDF triples"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/EnhancementProcess">http://purl.org/twc/vocab/conversion/EnhancementProcess</seealso>
    let EnhancementProcess =
        Prefixed_Name(conversion, "EnhancementProcess") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ExampleResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cites a row that contains an exemplary resource or structure; 'highlighting' it for increased attention. e.g., Jim Hendler or Bill O'Reilly in a White House Visitor Record."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExampleResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ExampleResource">http://purl.org/twc/vocab/conversion/ExampleResource</seealso>
    let ExampleResource = Prefixed_Name(conversion, "ExampleResource") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ExistingBundleEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reasserts the property-value pair to belong to the existing resource specified by the conversion:bundled_by property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Existing bundle enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ExistingBundleEnhancement">http://purl.org/twc/vocab/conversion/ExistingBundleEnhancement</seealso>
    let ExistingBundleEnhancement =
        Prefixed_Name(conversion, "ExistingBundleEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:HTTPHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Done by pcurl.sh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/HTTPHeader">http://purl.org/twc/vocab/conversion/HTTPHeader</seealso>
    let HTTPHeader = Prefixed_Name(conversion, "HTTPHeader") |> PrefixedName
    /// <summary>
    ///   <para>conversion:HeaderRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HeaderRow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/HeaderRow">http://purl.org/twc/vocab/conversion/HeaderRow</seealso>
    let HeaderRow = Prefixed_Name(conversion, "HeaderRow") |> PrefixedName
    /// <summary>
    ///   <para>conversion:ImplicitBundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the structural template for an implicit bundle enhancement. The conversion:property_name specifies the property name by which a bundle is attached to an instance. An optional conversion:type_name may be specified for the bundle to indicate the rdf:type of the new resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Implicit Bundle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ImplicitBundle">http://purl.org/twc/vocab/conversion/ImplicitBundle</seealso>
    let ImplicitBundle = Prefixed_Name(conversion, "ImplicitBundle") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ImplicitBundleEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reasserts the property-value pair to belong to a new resource specified by the conversion:bundled_by property. An example of this enhancement would be the introduction of a geo:Point instance based on latitude and longitude properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Implicit bundle enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ImplicitBundleEnhancement">http://purl.org/twc/vocab/conversion/ImplicitBundleEnhancement</seealso>
    let ImplicitBundleEnhancement =
        Prefixed_Name(conversion, "ImplicitBundleEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:IncludesLODLinks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any enhnacment with a conversion:links_via can also be a conversion:IncludesLODLinks. When so, include the LODLinks graph in the converted output."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/IncludesLODLinks">http://purl.org/twc/vocab/conversion/IncludesLODLinks</seealso>
    let IncludesLODLinks = Prefixed_Name(conversion, "IncludesLODLinks") |> PrefixedName

    /// <summary>
    ///   <para>conversion:IndirectSameAsEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refer to a local URI, which then has a single owl:sameAs triple pointing to external LOD bubbles. Depends on owl:sameAs inference OR extra graph patterns in SPARQL queries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IndirectSameAsEnhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/IndirectSameAsEnhancement">http://purl.org/twc/vocab/conversion/IndirectSameAsEnhancement</seealso>
    let IndirectSameAsEnhancement =
        Prefixed_Name(conversion, "IndirectSameAsEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:InterpretedAsNullEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Prevents triples with objects of a certain value. Prevents values specified by rdf:value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/InterpretedAsNullEnhancement">http://purl.org/twc/vocab/conversion/InterpretedAsNullEnhancement</seealso>
    let InterpretedAsNullEnhancement =
        Prefixed_Name(conversion, "InterpretedAsNullEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:LODLinks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An RDF Graph of resources with identifiers (dcterms:identifer, etc) that is used to link to resources created during conversion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/LODLinks">http://purl.org/twc/vocab/conversion/LODLinks</seealso>
    let LODLinks = Prefixed_Name(conversion, "LODLinks") |> PrefixedName

    /// <summary>
    ///   <para>conversion:LabelRenameEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Renames an existing property in the dataset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Label Rename Enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/LabelRenameEnhancement">http://purl.org/twc/vocab/conversion/LabelRenameEnhancement</seealso>
    let LabelRenameEnhancement =
        Prefixed_Name(conversion, "LabelRenameEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:LargeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to denote that the value of a cell is 'large', where 'large' is loosely defined by the implementing system. For example, javacsv thinks 100,000 characters is Large and requires a setting to permit more than that."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LargeValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/LargeValue">http://purl.org/twc/vocab/conversion/LargeValue</seealso>
    let LargeValue = Prefixed_Name(conversion, "LargeValue") |> PrefixedName
    /// <summary>
    ///   <para>conversion:LayerDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A conversion of a VersionedDataset using a particular set of conversion parameters."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Layer Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/LayerDataset">http://purl.org/twc/vocab/conversion/LayerDataset</seealso>
    let LayerDataset = Prefixed_Name(conversion, "LayerDataset") |> PrefixedName
    /// <summary>
    ///   <para>conversion:MetaDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data about another Dataset. Can contain VoID, PML, OPM, provenance, Dublin Core, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meta Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/MetaDataset">http://purl.org/twc/vocab/conversion/MetaDataset</seealso>
    let MetaDataset = Prefixed_Name(conversion, "MetaDataset") |> PrefixedName

    /// <summary>
    ///   <para>conversion:MultiplierEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"After datatype promotion to an XSD numeric type, multiplies the value by the multiplicand specified with the conversion:multiplier property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Multiplier enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/MultiplierEnhancement">http://purl.org/twc/vocab/conversion/MultiplierEnhancement</seealso>
    let MultiplierEnhancement =
        Prefixed_Name(conversion, "MultiplierEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ObjectEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Superclass of enhancements which promote values from a plain literal to more complex terms (resources or typed literals)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An Enhancement that modifies the object of the resulting triple."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ObjectEnhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ObjectEnhancement">http://purl.org/twc/vocab/conversion/ObjectEnhancement</seealso>
    let ObjectEnhancement =
        Prefixed_Name(conversion, "ObjectEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ObjectSameAsEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserts owl:sameAs relationships between resources and external URIs based on the instances' values of a specific property and their interpretation by a mapping specified by conversion:linksVia. How this mapping is performed based on this value is unspecified, but may be based on aligning with (e.g. SKOS) labels or the edit distance between the property value and instances in a known ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object sameAs enahncements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ObjectSameAsEnhancement">http://purl.org/twc/vocab/conversion/ObjectSameAsEnhancement</seealso>
    let ObjectSameAsEnhancement =
        Prefixed_Name(conversion, "ObjectSameAsEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ObjectSameAsEnhancementViaLookup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserts owl:sameAs relationships based on the values in the mapping of the property specified by conversion:subject_of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object sameAs enahncements via Lookup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ObjectSameAsEnhancementViaLookup">http://purl.org/twc/vocab/conversion/ObjectSameAsEnhancementViaLookup</seealso>
    let ObjectSameAsEnhancementViaLookup =
        Prefixed_Name(conversion, "ObjectSameAsEnhancementViaLookup") |> PrefixedName

    /// <summary>
    ///   <para>conversion:Omitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Omit all triples from this column."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Omitted">http://purl.org/twc/vocab/conversion/Omitted</seealso>
    let Omitted = Prefixed_Name(conversion, "Omitted") |> PrefixedName
    /// <summary>
    ///   <para>conversion:Only_if_column</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Omit triple if there is no value in the cell of the given column."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Only_if_column">http://purl.org/twc/vocab/conversion/Only_if_column</seealso>
    let Only_if_column = Prefixed_Name(conversion, "Only_if_column") |> PrefixedName

    /// <summary>
    ///   <para>conversion:PredicateEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Enhancement that modifies the predicate of the resulting triple."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PredicateEnhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/PredicateEnhancement">http://purl.org/twc/vocab/conversion/PredicateEnhancement</seealso>
    let PredicateEnhancement =
        Prefixed_Name(conversion, "PredicateEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:PropertyCommentEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Uses the object of the conversion:comment property and asserts it as the value of rdfs:comment on the property definition. The value of conversion:comment typically comes from the original csv header (that was too long), or from an ancillary file accompanying the csv file."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property comment enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/PropertyCommentEnhancement">http://purl.org/twc/vocab/conversion/PropertyCommentEnhancement</seealso>
    let PropertyCommentEnhancement =
        Prefixed_Name(conversion, "PropertyCommentEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:PropertyScopedResourcePromotionEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Appends raw literal values to the dataset-property-specific value space URI. For example, the value 'AK' for property 'origin_state' would be promoted to &lt;/source/SSS/dataset/DDD/value/origin_state/AK&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property-scoped resource promotion enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/PropertyScopedResourcePromotionEnhancement">http://purl.org/twc/vocab/conversion/PropertyScopedResourcePromotionEnhancement</seealso>
    let PropertyScopedResourcePromotionEnhancement =
        Prefixed_Name(conversion, "PropertyScopedResourcePromotionEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:RawConversionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"A raw conversion process from CSV to RDF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/RawConversionProcess">http://purl.org/twc/vocab/conversion/RawConversionProcess</seealso>
    let RawConversionProcess =
        Prefixed_Name(conversion, "RawConversionProcess") |> PrefixedName

    /// <summary>
    ///   <para>conversion:Repeat_previous_if_empty_column</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Repeat value of last non-empty cell in this column for the current cell."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Repeat_previous_if_empty_column">http://purl.org/twc/vocab/conversion/Repeat_previous_if_empty_column</seealso>
    let Repeat_previous_if_empty_column =
        Prefixed_Name(conversion, "Repeat_previous_if_empty_column") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ResourceCastEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Casts raw literal values directly into a URI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource cast enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ResourceCastEnhancement">http://purl.org/twc/vocab/conversion/ResourceCastEnhancement</seealso>
    let ResourceCastEnhancement =
        Prefixed_Name(conversion, "ResourceCastEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ResourcePromotionEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Superclass of enhancements which promote values from a plain literal to a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource promotion enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ResourcePromotionEnhancement">http://purl.org/twc/vocab/conversion/ResourcePromotionEnhancement</seealso>
    let ResourcePromotionEnhancement =
        Prefixed_Name(conversion, "ResourcePromotionEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:RowEnhancement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/RowEnhancement">http://purl.org/twc/vocab/conversion/RowEnhancement</seealso>
    let RowEnhancement = Prefixed_Name(conversion, "RowEnhancement") |> PrefixedName
    /// <summary>
    ///   <para>conversion:SameAsDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SameAs Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SameAsDataset">http://purl.org/twc/vocab/conversion/SameAsDataset</seealso>
    let SameAsDataset = Prefixed_Name(conversion, "SameAsDataset") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SameAsEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Superclass for sameAs enahncements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SameAsEnhancement">http://purl.org/twc/vocab/conversion/SameAsEnhancement</seealso>
    let SameAsEnhancement =
        Prefixed_Name(conversion, "SameAsEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:ServiceEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"http://www.w3.org/TR/sparql11-service-description/ does not specify a range, but we want to refer to it"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/ServiceEndpoint">http://purl.org/twc/vocab/conversion/ServiceEndpoint</seealso>
    let ServiceEndpoint = Prefixed_Name(conversion, "ServiceEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>conversion:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person, organization, or agent from which a dataset is retrieved."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/Source">http://purl.org/twc/vocab/conversion/Source</seealso>
    let Source = Prefixed_Name(conversion, "Source") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SubClassEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserts that an existing class in the dataset, specified by name with conversion:class_name,  is a subclass of an external class specified by conversion:subclass_of. This enhancement will materialize the rdf:type entailments for all instances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subclass enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SubClassEnhancement">http://purl.org/twc/vocab/conversion/SubClassEnhancement</seealso>
    let SubClassEnhancement =
        Prefixed_Name(conversion, "SubClassEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SubPropertyEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserts that an existing property in the dataset is a subproperty of an external property specified by conversion:subproperty_of. This enhancement will materialize the subproperty entailments for all instances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subproperty enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SubPropertyEnhancement">http://purl.org/twc/vocab/conversion/SubPropertyEnhancement</seealso>
    let SubPropertyEnhancement =
        Prefixed_Name(conversion, "SubPropertyEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SubjectAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"add a predicate-object description to the subject of a triple created."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SubjectAnnotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SubjectAnnotation">http://purl.org/twc/vocab/conversion/SubjectAnnotation</seealso>
    let SubjectAnnotation =
        Prefixed_Name(conversion, "SubjectAnnotation") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SubjectEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Enhancement that modifies the subject of the resulting triple."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SubjectEnhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SubjectEnhancement">http://purl.org/twc/vocab/conversion/SubjectEnhancement</seealso>
    let SubjectEnhancement =
        Prefixed_Name(conversion, "SubjectEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SubjectSameAsEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserts owl:sameAs relationships between instances and external URIs based on the instances' values of a specific property and their interpretation by a mapping specified by conversion:linksVia. How this mapping is performed based on this value is unspecified, but may be based on aligning with (e.g. SKOS) labels or the edit distance between the property value and instances in a known ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subject sameAs enahncements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SubjectSameAsEnhancement">http://purl.org/twc/vocab/conversion/SubjectSameAsEnhancement</seealso>
    let SubjectSameAsEnhancement =
        Prefixed_Name(conversion, "SubjectSameAsEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SubjectSameAsEnhancementViaLookup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserts owl:sameAs relationships based on the values in the mapping of the property specified by conversion:subject_of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subject sameAs enahncements via Lookup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SubjectSameAsEnhancementViaLookup">http://purl.org/twc/vocab/conversion/SubjectSameAsEnhancementViaLookup</seealso>
    let SubjectSameAsEnhancementViaLookup =
        Prefixed_Name(conversion, "SubjectSameAsEnhancementViaLookup") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SubjectTypeEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asserts that the subject instance is of a specific type, specified by name with conversion:domain_name. Also asserts that the type is a owl:Class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subject type enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SubjectTypeEnhancement">http://purl.org/twc/vocab/conversion/SubjectTypeEnhancement</seealso>
    let SubjectTypeEnhancement =
        Prefixed_Name(conversion, "SubjectTypeEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:SymbolInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pairs a collection of symbols with how they should be interpreted. For example, 'S' should be interpreted as http://dbpedia.org/resource/United_States_Senate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SymbolInterpretation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/SymbolInterpretation">http://purl.org/twc/vocab/conversion/SymbolInterpretation</seealso>
    let SymbolInterpretation =
        Prefixed_Name(conversion, "SymbolInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>conversion:TemplateResourcePromotionEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Converts raw literal values into URIs by replacing in the template (specified by the conversion:template_pattern property) the substring '[value]'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Template resource promotion enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/TemplateResourcePromotionEnhancement">http://purl.org/twc/vocab/conversion/TemplateResourcePromotionEnhancement</seealso>
    let TemplateResourcePromotionEnhancement =
        Prefixed_Name(conversion, "TemplateResourcePromotionEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:TripleStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TripleStore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/TripleStore">http://purl.org/twc/vocab/conversion/TripleStore</seealso>
    let TripleStore = Prefixed_Name(conversion, "TripleStore") |> PrefixedName

    /// <summary>
    ///   <para>conversion:TypedResourcePromotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Property</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TypedResourcePromotion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/TypedResourcePromotion">http://purl.org/twc/vocab/conversion/TypedResourcePromotion</seealso>
    let TypedResourcePromotion =
        Prefixed_Name(conversion, "TypedResourcePromotion") |> PrefixedName

    /// <summary>
    ///   <para>conversion:TypedResourcePromotionEnhancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Constructs a URI from the concatenation of a dataset-specific URI, a type token specified with conversion:range_name, and the raw literal value. Additionally asserts an rdf:type for the new resource with the class named with conversion:range_name. The type name will be lowercased for use in the URI and have the first letter uppercased for use as the class name. For example, the value 'AK' with conversion:range_name 'state' would be promoted to &lt;/source/SSS/dataset/DDD/type/state/AK&gt; with an rdf:type of &lt;/source/SSS/dataset/DDD/vocab/State&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Typed resource promotion enhancement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/TypedResourcePromotionEnhancement">http://purl.org/twc/vocab/conversion/TypedResourcePromotionEnhancement</seealso>
    let TypedResourcePromotionEnhancement =
        Prefixed_Name(conversion, "TypedResourcePromotionEnhancement") |> PrefixedName

    /// <summary>
    ///   <para>conversion:UnitTestedDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"UnitTestedDatasets should cite locations for their unit tests."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An RDF dataset tested with SPARQL queries verifying the presense or absence of particular triples."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UnitTestedDatset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/UnitTestedDataset">http://purl.org/twc/vocab/conversion/UnitTestedDataset</seealso>
    let UnitTestedDataset =
        Prefixed_Name(conversion, "UnitTestedDataset") |> PrefixedName

    /// <summary>
    ///   <para>conversion:VersionControlledDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A conversion:Dataset whose data skeleton is available from a version control system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VersionControlledDataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/VersionControlledDataset">http://purl.org/twc/vocab/conversion/VersionControlledDataset</seealso>
    let VersionControlledDataset =
        Prefixed_Name(conversion, "VersionControlledDataset") |> PrefixedName

    /// <summary>
    ///   <para>conversion:VersionedDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A materialized (captured in time) dataset -- something is now on disk. Union of all LayerDatasets created by different conversion parameters."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Versioned Dataset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/VersionedDataset">http://purl.org/twc/vocab/conversion/VersionedDataset</seealso>
    let VersionedDataset = Prefixed_Name(conversion, "VersionedDataset") |> PrefixedName
    /// <summary>
    ///   <para>conversion:base_uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The base URI used in constructing identifying URIs for instances in the converted dataset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"base_uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/base_uri">http://purl.org/twc/vocab/conversion/base_uri</seealso>
    let base_uri = Prefixed_Name(conversion, "base_uri") |> PrefixedName
    /// <summary>
    ///   <para>conversion:bundled_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"bundled_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/bundled_by">http://purl.org/twc/vocab/conversion/bundled_by</seealso>
    let bundled_by = Prefixed_Name(conversion, "bundled_by") |> PrefixedName
    /// <summary>
    ///   <para>conversion:class_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/class_name">http://purl.org/twc/vocab/conversion/class_name</seealso>
    let class_name = Prefixed_Name(conversion, "class_name") |> PrefixedName
    /// <summary>
    ///   <para>conversion:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A comment (like rdfs:comment) that will be applied to the property created during conversion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/comment">http://purl.org/twc/vocab/conversion/comment</seealso>
    let comment = Prefixed_Name(conversion, "comment") |> PrefixedName
    /// <summary>
    ///   <para>conversion:conceptual_depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"A measure of conceptual depth using the URI's 'depth' within the source/dataset/version contextualization scheme used by csv2rdf4lod's data aggretation naming scheme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/conceptual_depth">http://purl.org/twc/vocab/conversion/conceptual_depth</seealso>
    let conceptual_depth = Prefixed_Name(conversion, "conceptual_depth") |> PrefixedName

    /// <summary>
    ///   <para>conversion:conversion_identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"conversion_identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/conversion_identifier">http://purl.org/twc/vocab/conversion/conversion_identifier</seealso>
    let conversion_identifier =
        Prefixed_Name(conversion, "conversion_identifier") |> PrefixedName

    /// <summary>
    ///   <para>conversion:conversion_process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A conversion process that led to the creation or modification of an RDF dataset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"conversion_process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/conversion_process">http://purl.org/twc/vocab/conversion/conversion_process</seealso>
    let conversion_process =
        Prefixed_Name(conversion, "conversion_process") |> PrefixedName

    /// <summary>
    ///   <para>conversion:dataset_file</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The URL of a dataset document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/dataset_file">http://purl.org/twc/vocab/conversion/dataset_file</seealso>
    let dataset_file = Prefixed_Name(conversion, "dataset_file") |> PrefixedName

    /// <summary>
    ///   <para>conversion:dataset_identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The identifier of the dataset being converted. Ideally provided by source_identifier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dataset_identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/dataset_identifier">http://purl.org/twc/vocab/conversion/dataset_identifier</seealso>
    let dataset_identifier =
        Prefixed_Name(conversion, "dataset_identifier") |> PrefixedName

    /// <summary>
    ///   <para>conversion:dataset_version</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"dataset_version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/dataset_version">http://purl.org/twc/vocab/conversion/dataset_version</seealso>
    let dataset_version = Prefixed_Name(conversion, "dataset_version") |> PrefixedName
    /// <summary>
    ///   <para>conversion:date_pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/date_pattern">http://purl.org/twc/vocab/conversion/date_pattern</seealso>
    let date_pattern = Prefixed_Name(conversion, "date_pattern") |> PrefixedName
    /// <summary>
    ///   <para>conversion:datetime_pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/datetime_pattern">http://purl.org/twc/vocab/conversion/datetime_pattern</seealso>
    let datetime_pattern = Prefixed_Name(conversion, "datetime_pattern") |> PrefixedName

    /// <summary>
    ///   <para>conversion:datetime_timezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/datetime_timezone">http://purl.org/twc/vocab/conversion/datetime_timezone</seealso>
    let datetime_timezone =
        Prefixed_Name(conversion, "datetime_timezone") |> PrefixedName

    /// <summary>
    ///   <para>conversion:delimits_cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The delimiter that should be used to separate cells in a row."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"delimits_cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/delimits_cell">http://purl.org/twc/vocab/conversion/delimits_cell</seealso>
    let delimits_cell = Prefixed_Name(conversion, "delimits_cell") |> PrefixedName
    /// <summary>
    ///   <para>conversion:delimits_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A regular expression specifiying how the object literal should be delimited to produce multiple object values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"delimits_object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/delimits_object">http://purl.org/twc/vocab/conversion/delimits_object</seealso>
    let delimits_object = Prefixed_Name(conversion, "delimits_object") |> PrefixedName
    /// <summary>
    ///   <para>conversion:domain_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The local type that should be asserted for the subjects of raw triples."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"domain_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/domain_name">http://purl.org/twc/vocab/conversion/domain_name</seealso>
    let domain_name = Prefixed_Name(conversion, "domain_name") |> PrefixedName
    /// <summary>
    ///   <para>conversion:domain_template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"TODO, cannot happen: :cp a conversion:EnhancementConversionProcess; conversion:enhance [ ov:csvCol 1; conversion:domain_template 'a' ], [ ov:csvCol 2; conversion:domain_template 'b' ] (col 1 and col 2 make the enhancements distinct, and an EnhancementConversionProcess can only have one domain_templated enhancement.)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Template to name the subject of the triple produced."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"domain_template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/domain_template">http://purl.org/twc/vocab/conversion/domain_template</seealso>
    let domain_template = Prefixed_Name(conversion, "domain_template") |> PrefixedName
    /// <summary>
    ///   <para>conversion:eg</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Example value from a cell in the column for this ColumnEnhancement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"eg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/eg">http://purl.org/twc/vocab/conversion/eg</seealso>
    let eg = Prefixed_Name(conversion, "eg") |> PrefixedName
    /// <summary>
    ///   <para>conversion:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The character encoding of a dataset document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/encoding">http://purl.org/twc/vocab/conversion/encoding</seealso>
    let encoding = Prefixed_Name(conversion, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>conversion:enhance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"enhance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/enhance">http://purl.org/twc/vocab/conversion/enhance</seealso>
    let enhance = Prefixed_Name(conversion, "enhance") |> PrefixedName

    /// <summary>
    ///   <para>conversion:enhancement_identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"enhancement_identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/enhancement_identifier">http://purl.org/twc/vocab/conversion/enhancement_identifier</seealso>
    let enhancement_identifier =
        Prefixed_Name(conversion, "enhancement_identifier") |> PrefixedName

    /// <summary>
    ///   <para>conversion:enhancement_layer</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"enhancement_layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/enhancement_layer">http://purl.org/twc/vocab/conversion/enhancement_layer</seealso>
    let enhancement_layer =
        Prefixed_Name(conversion, "enhancement_layer") |> PrefixedName

    /// <summary>
    ///   <para>conversion:enhances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Used to describe terms from enhanced datasets, to refer to analogous terms from less enhanced datasets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"enhances"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/enhances">http://purl.org/twc/vocab/conversion/enhances</seealso>
    let enhances = Prefixed_Name(conversion, "enhances") |> PrefixedName

    /// <summary>
    ///   <para>conversion:equivalent_property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"equivalent_property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/equivalent_property">http://purl.org/twc/vocab/conversion/equivalent_property</seealso>
    let equivalent_property =
        Prefixed_Name(conversion, "equivalent_property") |> PrefixedName

    /// <summary>
    ///   <para>conversion:interpret</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interpret"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/interpret">http://purl.org/twc/vocab/conversion/interpret</seealso>
    let interpret = Prefixed_Name(conversion, "interpret") |> PrefixedName
    /// <summary>
    ///   <para>conversion:interpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interpretation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/interpretation">http://purl.org/twc/vocab/conversion/interpretation</seealso>
    let interpretation = Prefixed_Name(conversion, "interpretation") |> PrefixedName
    /// <summary>
    ///   <para>conversion:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A human-friendly label (like rdfs:label) that will be used to create the property local name when creating the property URI. The exact value of conversion:label will also be used for the rdfs:label of the property created."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/label">http://purl.org/twc/vocab/conversion/label</seealso>
    let label = Prefixed_Name(conversion, "label") |> PrefixedName
    /// <summary>
    ///   <para>conversion:links_via</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"links_via"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/links_via">http://purl.org/twc/vocab/conversion/links_via</seealso>
    let links_via = Prefixed_Name(conversion, "links_via") |> PrefixedName
    /// <summary>
    ///   <para>conversion:multiplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/multiplier">http://purl.org/twc/vocab/conversion/multiplier</seealso>
    let multiplier = Prefixed_Name(conversion, "multiplier") |> PrefixedName
    /// <summary>
    ///   <para>conversion:name_template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"name_template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/name_template">http://purl.org/twc/vocab/conversion/name_template</seealso>
    let name_template = Prefixed_Name(conversion, "name_template") |> PrefixedName

    /// <summary>
    ///   <para>conversion:num_invocation_logs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of docs/logs/* captured by convert-aggregate.sh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number of invocation logs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/num_invocation_logs">http://purl.org/twc/vocab/conversion/num_invocation_logs</seealso>
    let num_invocation_logs =
        Prefixed_Name(conversion, "num_invocation_logs") |> PrefixedName

    /// <summary>
    ///   <para>conversion:num_triples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"num_triples"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/num_triples">http://purl.org/twc/vocab/conversion/num_triples</seealso>
    let num_triples = Prefixed_Name(conversion, "num_triples") |> PrefixedName
    /// <summary>
    ///   <para>conversion:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/object">http://purl.org/twc/vocab/conversion/object</seealso>
    let object = Prefixed_Name(conversion, "object") |> PrefixedName
    /// <summary>
    ///   <para>conversion:object_search</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"object_search"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/object_search">http://purl.org/twc/vocab/conversion/object_search</seealso>
    let object_search = Prefixed_Name(conversion, "object_search") |> PrefixedName
    /// <summary>
    ///   <para>conversion:pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/pattern">http://purl.org/twc/vocab/conversion/pattern</seealso>
    let pattern = Prefixed_Name(conversion, "pattern") |> PrefixedName
    /// <summary>
    ///   <para>conversion:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"predicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/predicate">http://purl.org/twc/vocab/conversion/predicate</seealso>
    let predicate = Prefixed_Name(conversion, "predicate") |> PrefixedName

    /// <summary>
    ///   <para>conversion:predicate_identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ov:csvCol OR conversion:property_name should be used to refer to the property being enhanced - NOT BOTH."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/predicate_identifier">http://purl.org/twc/vocab/conversion/predicate_identifier</seealso>
    let predicate_identifier =
        Prefixed_Name(conversion, "predicate_identifier") |> PrefixedName

    /// <summary>
    ///   <para>conversion:property_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property name on which an enhancement takes place."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The local name of a property within this dataset-specific namespace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/property_name">http://purl.org/twc/vocab/conversion/property_name</seealso>
    let property_name = Prefixed_Name(conversion, "property_name") |> PrefixedName
    /// <summary>
    ///   <para>conversion:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The rdfs:range of the property after enhancement. For raw conversions, it is always rdfs:Literal. More interesting things happen during enhancements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/range">http://purl.org/twc/vocab/conversion/range</seealso>
    let range = Prefixed_Name(conversion, "range") |> PrefixedName
    /// <summary>
    ///   <para>conversion:range_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The local name of an internal class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/range_name">http://purl.org/twc/vocab/conversion/range_name</seealso>
    let range_name = Prefixed_Name(conversion, "range_name") |> PrefixedName
    /// <summary>
    ///   <para>conversion:range_template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"range template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/range_template">http://purl.org/twc/vocab/conversion/range_template</seealso>
    let range_template = Prefixed_Name(conversion, "range_template") |> PrefixedName
    /// <summary>
    ///   <para>conversion:regex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"regex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/regex">http://purl.org/twc/vocab/conversion/regex</seealso>
    let regex = Prefixed_Name(conversion, "regex") |> PrefixedName
    /// <summary>
    ///   <para>conversion:source_data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The source of data for a conversion process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/source_data">http://purl.org/twc/vocab/conversion/source_data</seealso>
    let source_data = Prefixed_Name(conversion, "source_data") |> PrefixedName

    /// <summary>
    ///   <para>conversion:source_identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of the organization to which the dataset being converted belongs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source_identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/source_identifier">http://purl.org/twc/vocab/conversion/source_identifier</seealso>
    let source_identifier =
        Prefixed_Name(conversion, "source_identifier") |> PrefixedName

    /// <summary>
    ///   <para>conversion:subclass_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/subclass_of">http://purl.org/twc/vocab/conversion/subclass_of</seealso>
    let subclass_of = Prefixed_Name(conversion, "subclass_of") |> PrefixedName

    /// <summary>
    ///   <para>conversion:subject_discriminator</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"subject_discriminator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/subject_discriminator">http://purl.org/twc/vocab/conversion/subject_discriminator</seealso>
    let subject_discriminator =
        Prefixed_Name(conversion, "subject_discriminator") |> PrefixedName

    /// <summary>
    ///   <para>conversion:subject_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/subject_of">http://purl.org/twc/vocab/conversion/subject_of</seealso>
    let subject_of = Prefixed_Name(conversion, "subject_of") |> PrefixedName
    /// <summary>
    ///   <para>conversion:subproperty_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The external property that is a super property of the local property named by :property_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subproperty_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/subproperty_of">http://purl.org/twc/vocab/conversion/subproperty_of</seealso>
    let subproperty_of = Prefixed_Name(conversion, "subproperty_of") |> PrefixedName
    /// <summary>
    ///   <para>conversion:subseT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A transitive version of void:subset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subsetT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/subseT">http://purl.org/twc/vocab/conversion/subseT</seealso>
    let subseT = Prefixed_Name(conversion, "subseT") |> PrefixedName
    /// <summary>
    ///   <para>conversion:symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/symbol">http://purl.org/twc/vocab/conversion/symbol</seealso>
    let symbol = Prefixed_Name(conversion, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>conversion:template_pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"String representing a templated URI. Placeholders in the template are replaced by values of the row in the specified columns. Columns are cited by local name or column number. For example, http://some.other.org/instances/[value]. http://some.other.org/instances/[state]-[county], http://some.other.org/instances/[#4]-[#6]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/template_pattern">http://purl.org/twc/vocab/conversion/template_pattern</seealso>
    let template_pattern = Prefixed_Name(conversion, "template_pattern") |> PrefixedName
    /// <summary>
    ///   <para>conversion:testable_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/testable_by">http://purl.org/twc/vocab/conversion/testable_by</seealso>
    let testable_by = Prefixed_Name(conversion, "testable_by") |> PrefixedName
    /// <summary>
    ///   <para>conversion:todo</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"todo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/todo">http://purl.org/twc/vocab/conversion/todo</seealso>
    let todo = Prefixed_Name(conversion, "todo") |> PrefixedName

    /// <summary>
    ///   <para>conversion:triples_per_minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"triples_per_minute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/triples_per_minute">http://purl.org/twc/vocab/conversion/triples_per_minute</seealso>
    let triples_per_minute =
        Prefixed_Name(conversion, "triples_per_minute") |> PrefixedName

    /// <summary>
    ///   <para>conversion:type_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The local name of a class within this dataset-specific namespace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/type_name">http://purl.org/twc/vocab/conversion/type_name</seealso>
    let type_name = Prefixed_Name(conversion, "type_name") |> PrefixedName
    /// <summary>
    ///   <para>conversion:uses_class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"uses_class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/uses_class">http://purl.org/twc/vocab/conversion/uses_class</seealso>
    let uses_class = Prefixed_Name(conversion, "uses_class") |> PrefixedName
    /// <summary>
    ///   <para>conversion:uses_predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"uses_predicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/uses_predicate">http://purl.org/twc/vocab/conversion/uses_predicate</seealso>
    let uses_predicate = Prefixed_Name(conversion, "uses_predicate") |> PrefixedName

    /// <summary>
    ///   <para>conversion:version_identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The version of conversion being performed per dataset."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The version_identifier should only change during a 'raw' conversion when the underlying dataset has changed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version_identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/vocab/conversion/version_identifier">http://purl.org/twc/vocab/conversion/version_identifier</seealso>
    let version_identifier =
        Prefixed_Name(conversion, "version_identifier") |> PrefixedName
