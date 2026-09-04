#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module conversion =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/twc/vocab/conversion/" "conversion"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Dataset with source and dataset identifiers, but not version. Before any version is materialized (captured in time), and the union of all VersionedDatasets.^^xsd:string</para>
    ///   <para>rdfs:label : Abstract Dataset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/AbstractDataset">conversion:AbstractDataset</a>
    /// </summary>
    let AbstractDataset = _prefixId.prefix "AbstractDataset"
    let AuxiliaryDataset = _prefixId.prefix "AuxiliaryDataset"
    /// <summary>
    ///   <para>rdfs:comment : Casts raw literal values into xsd:boolean datatyped values. The default recognized lexical representations are (case insensitive): 'yes', 'no', 'true', 'false', '0', and '1'. The conversion:boolean_true and conversion:boolean_false properties may be used to add additional lexical forms.^^xsd:string</para>
    ///   <para>rdfs:label : Boolean promotion enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/BooleanPromotionEnhancement">conversion:BooleanPromotionEnhancement</a>
    /// </summary>
    let BooleanPromotionEnhancement = _prefixId.prefix "BooleanPromotionEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Any SymbolInterpretation that interprets to true or false is a BooleanSymbolInterpretation.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/BooleanSymbolInterpretation">conversion:BooleanSymbolInterpretation</a>
    /// </summary>
    let BooleanSymbolInterpretation = _prefixId.prefix "BooleanSymbolInterpretation"
    let Bundle = _prefixId.prefix "Bundle"

    /// <summary>
    ///   <para>rdfs:comment : A shell script that sets https://github.com/timrdf/csv2rdf4lod-automation/wiki/CSV2RDF4LOD-environment-variables to control the behavior of csv2rdf4lod-automation.^^xsd:string</para>
    ///   <para>rdfs:label : CSV2RDF4LOD_environment_variables^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/CSV2RDF4LOD_environment_variables">conversion:CSV2RDF4LOD_environment_variables</a>
    /// </summary>
    let CSV2RDF4LOD_environment_variables =
        _prefixId.prefix "CSV2RDF4LOD_environment_variables"

    /// <summary>
    ///   <para>rdfs:comment : Ignore string case when attempting to match identifiers between the input table and the identifiers in the LODLinks graph^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/CaseInsensitiveLODLink">conversion:CaseInsensitiveLODLink</a>
    /// </summary>
    let CaseInsensitiveLODLink = _prefixId.prefix "CaseInsensitiveLODLink"
    /// <summary>
    ///   <para>rdfs:comment : A CatalogedDataset is any kind of dataset, in the most general sense and regardless of how it is encoded (RDF, Relational, Tabular, XML, SPS, etc.). If someone says to you, 'yea, NASA has a Mars imagery dataset, talk to Joe about it and visit its homepage', you just instantiated a CatalogedDataset. There are MANY CatalogedDatasets that are NOT conversion:Datasets and NOT void:Datasets, since both of these are RDF-based datasets. The purpose of CatalogedDataset is to maintain a list of 'TODO' items that could be explored, converted, and published as RDF. Once a CatalogedDataset IS investigated, named, and converted, it also becomes a conversion:Dataset (and thus a void:Datast).^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/CatalogedDataset">conversion:CatalogedDataset</a>
    /// </summary>
    let CatalogedDataset = _prefixId.prefix "CatalogedDataset"
    /// <summary>
    ///   <para>rdfs:comment : Metadata for a dataset that is created during the dataset's conversion invocation.^^xsd:string</para>
    ///   <para>rdfs:label : ConversionMetaDataset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ConversionMetaDataset">conversion:ConversionMetaDataset</a>
    /// </summary>
    let ConversionMetaDataset = _prefixId.prefix "ConversionMetaDataset"
    /// <summary>
    ///   <para>rdfs:label : Superclass for different conversion processes.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ConversionProcess">conversion:ConversionProcess</a>
    /// </summary>
    let ConversionProcess = _prefixId.prefix "ConversionProcess"
    /// <summary>
    ///   <para>rdfs:comment : In csv2rdf4lod-automation, the conversion trigger is a shell script situated within the conversion cockpit that initiates conversion of source data to RDF.^^xsd:string</para>
    ///   <para>rdfs:label : ConversionTrigger^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ConversionTrigger">conversion:ConversionTrigger</a>
    /// </summary>
    let ConversionTrigger = _prefixId.prefix "ConversionTrigger"
    /// <summary>
    ///   <para>rdfs:comment : Asserted by pcurl.sh^^xsd:string</para>
    ///   <para>rdfs:label : Curl^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/Curl">conversion:Curl</a>
    /// </summary>
    let Curl = _prefixId.prefix "Curl"
    /// <summary>
    ///   <para>rdfs:label : DataEndRow^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DataEndRow">conversion:DataEndRow</a>
    /// </summary>
    let DataEndRow = _prefixId.prefix "DataEndRow"
    /// <summary>
    ///   <para>rdfs:label : DataStartRow^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DataStartRow">conversion:DataStartRow</a>
    /// </summary>
    let DataStartRow = _prefixId.prefix "DataStartRow"
    /// <summary>
    ///   <para>rdfs:comment : Asserted by the converter.^^xsd:string</para>
    ///   <para>rdfs:label : Dataset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/Dataset">conversion:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:comment : A dataset that lists other datasets as its entries.^^xsd:string</para>
    ///   <para>rdfs:label : Dataset Catalog^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DatasetCatalog">conversion:DatasetCatalog</a>
    /// </summary>
    let DatasetCatalog = _prefixId.prefix "DatasetCatalog"
    /// <summary>
    ///   <para>rdfs:comment : A potentially incomplete subset of a void:Dataset^^xsd:string</para>
    ///   <para>rdfs:label : Dataset Sample^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DatasetSample">conversion:DatasetSample</a>
    /// </summary>
    let DatasetSample = _prefixId.prefix "DatasetSample"
    /// <summary>
    ///   <para>rdfs:comment : Promotes the raw literal value to a datatyped literal using the datatype specified with the conversion:range property.^^xsd:string</para>
    ///   <para>rdfs:label : Literal datatype promotion enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DatatypePromotionEnhancement">conversion:DatatypePromotionEnhancement</a>
    /// </summary>
    let DatatypePromotionEnhancement = _prefixId.prefix "DatatypePromotionEnhancement"
    /// <summary>
    ///   <para>rdfs:label : Date promotion enhancement^^xsd:string</para>
    ///   <para>rdfs:comment : Casts raw literal values into W3CDTF values typed as xsd:date based on a strftime pattern specified with the conversion:date_pattern. If the property values follow different patterns, multiple conversion:date_pattern values may specified.^^xsd:stringrdfs:comment : For each value, all DateTimePromotionEnhancement patterns are attempted before attempting any DatePromotionEnhancement patterns specified for the same property.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DatePromotionEnhancement">conversion:DatePromotionEnhancement</a>
    /// </summary>
    let DatePromotionEnhancement = _prefixId.prefix "DatePromotionEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Casts raw literal values into W3CDTF values typed as xsd:dateTime based on a strftime pattern specified with the conversion:datetime_pattern. If the property values follow different patterns, multiple conversion:datetime_pattern values may specified. The first matching pattern (of a nondeterministic ordering) will be applied. An optional conversion:datetime_timezone may be specified if no timezone information is present in the datetime pattern.^^xsd:string</para>
    ///   <para>rdfs:label : DateTime promotion enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DateTimePromotionEnhancement">conversion:DateTimePromotionEnhancement</a>
    /// </summary>
    let DateTimePromotionEnhancement = _prefixId.prefix "DateTimePromotionEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/Deprecated">conversion:Deprecated</a>
    /// </summary>
    let Deprecated = _prefixId.prefix "Deprecated"
    /// <summary>
    ///   <para>rdfs:comment : For any Resource that became owl:sameAs another Resource in an external LOD bubble, use ALL external URIs instead of the local resource.^^xsd:string</para>
    ///   <para>rdfs:label : IndirectSameAsEnhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DirectSameAsEnhancement">conversion:DirectSameAsEnhancement</a>
    /// </summary>
    let DirectSameAsEnhancement = _prefixId.prefix "DirectSameAsEnhancement"
    /// <summary>
    ///   <para>rdfs:label : The state of a document at a point in time.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/DocumentState">conversion:DocumentState</a>
    /// </summary>
    let DocumentState = _prefixId.prefix "DocumentState"
    /// <summary>
    ///   <para>rdfs:label : The superclass of all enhancements. When the enhancement is referring to a particular property, the property's local name or originating column number may be used (using conversion:property_name and ov:csvCol, respectively).^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/Enhancement">conversion:Enhancement</a>
    /// </summary>
    let Enhancement = _prefixId.prefix "Enhancement"
    /// <summary>
    ///   <para>rdfs:label : An enhancement of an RDF dataset that adds new RDF triples^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/EnhancementProcess">conversion:EnhancementProcess</a>
    /// </summary>
    let EnhancementProcess = _prefixId.prefix "EnhancementProcess"
    /// <summary>
    ///   <para>rdfs:comment : Cites a row that contains an exemplary resource or structure; 'highlighting' it for increased attention. e.g., Jim Hendler or Bill O'Reilly in a White House Visitor Record.^^xsd:string</para>
    ///   <para>rdfs:label : ExampleResource^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ExampleResource">conversion:ExampleResource</a>
    /// </summary>
    let ExampleResource = _prefixId.prefix "ExampleResource"
    /// <summary>
    ///   <para>rdfs:comment : Reasserts the property-value pair to belong to the existing resource specified by the conversion:bundled_by property.^^xsd:string</para>
    ///   <para>rdfs:label : Existing bundle enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ExistingBundleEnhancement">conversion:ExistingBundleEnhancement</a>
    /// </summary>
    let ExistingBundleEnhancement = _prefixId.prefix "ExistingBundleEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Done by pcurl.sh^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/HTTPHeader">conversion:HTTPHeader</a>
    /// </summary>
    let HTTPHeader = _prefixId.prefix "HTTPHeader"
    /// <summary>
    ///   <para>rdfs:label : HeaderRow^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/HeaderRow">conversion:HeaderRow</a>
    /// </summary>
    let HeaderRow = _prefixId.prefix "HeaderRow"
    /// <summary>
    ///   <para>rdfs:comment : Represents the structural template for an implicit bundle enhancement. The conversion:property_name specifies the property name by which a bundle is attached to an instance. An optional conversion:type_name may be specified for the bundle to indicate the rdf:type of the new resource.^^xsd:string</para>
    ///   <para>rdfs:label : Implicit Bundle^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ImplicitBundle">conversion:ImplicitBundle</a>
    /// </summary>
    let ImplicitBundle = _prefixId.prefix "ImplicitBundle"
    /// <summary>
    ///   <para>rdfs:comment : Reasserts the property-value pair to belong to a new resource specified by the conversion:bundled_by property. An example of this enhancement would be the introduction of a geo:Point instance based on latitude and longitude properties.^^xsd:string</para>
    ///   <para>rdfs:label : Implicit bundle enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ImplicitBundleEnhancement">conversion:ImplicitBundleEnhancement</a>
    /// </summary>
    let ImplicitBundleEnhancement = _prefixId.prefix "ImplicitBundleEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Any enhnacment with a conversion:links_via can also be a conversion:IncludesLODLinks. When so, include the LODLinks graph in the converted output.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/IncludesLODLinks">conversion:IncludesLODLinks</a>
    /// </summary>
    let IncludesLODLinks = _prefixId.prefix "IncludesLODLinks"
    /// <summary>
    ///   <para>rdfs:comment : Refer to a local URI, which then has a single owl:sameAs triple pointing to external LOD bubbles. Depends on owl:sameAs inference OR extra graph patterns in SPARQL queries.^^xsd:string</para>
    ///   <para>rdfs:label : IndirectSameAsEnhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/IndirectSameAsEnhancement">conversion:IndirectSameAsEnhancement</a>
    /// </summary>
    let IndirectSameAsEnhancement = _prefixId.prefix "IndirectSameAsEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Prevents triples with objects of a certain value. Prevents values specified by rdf:value.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/InterpretedAsNullEnhancement">conversion:InterpretedAsNullEnhancement</a>
    /// </summary>
    let InterpretedAsNullEnhancement = _prefixId.prefix "InterpretedAsNullEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : An RDF Graph of resources with identifiers (dcterms:identifer, etc) that is used to link to resources created during conversion.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/LODLinks">conversion:LODLinks</a>
    /// </summary>
    let LODLinks = _prefixId.prefix "LODLinks"
    /// <summary>
    ///   <para>rdfs:comment : Renames an existing property in the dataset.^^xsd:string</para>
    ///   <para>rdfs:label : Label Rename Enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/LabelRenameEnhancement">conversion:LabelRenameEnhancement</a>
    /// </summary>
    let LabelRenameEnhancement = _prefixId.prefix "LabelRenameEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Used to denote that the value of a cell is 'large', where 'large' is loosely defined by the implementing system. For example, javacsv thinks 100,000 characters is Large and requires a setting to permit more than that.^^xsd:string</para>
    ///   <para>rdfs:label : LargeValue^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/LargeValue">conversion:LargeValue</a>
    /// </summary>
    let LargeValue = _prefixId.prefix "LargeValue"
    /// <summary>
    ///   <para>rdfs:comment : A conversion of a VersionedDataset using a particular set of conversion parameters.^^xsd:string</para>
    ///   <para>rdfs:label : Layer Dataset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/LayerDataset">conversion:LayerDataset</a>
    /// </summary>
    let LayerDataset = _prefixId.prefix "LayerDataset"
    /// <summary>
    ///   <para>rdfs:comment : Data about another Dataset. Can contain VoID, PML, OPM, provenance, Dublin Core, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Meta Dataset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/MetaDataset">conversion:MetaDataset</a>
    /// </summary>
    let MetaDataset = _prefixId.prefix "MetaDataset"
    /// <summary>
    ///   <para>rdfs:comment : After datatype promotion to an XSD numeric type, multiplies the value by the multiplicand specified with the conversion:multiplier property.^^xsd:string</para>
    ///   <para>rdfs:label : Multiplier enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/MultiplierEnhancement">conversion:MultiplierEnhancement</a>
    /// </summary>
    let MultiplierEnhancement = _prefixId.prefix "MultiplierEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Superclass of enhancements which promote values from a plain literal to more complex terms (resources or typed literals).^^xsd:stringrdfs:comment : An Enhancement that modifies the object of the resulting triple.^^xsd:string</para>
    ///   <para>rdfs:label : ObjectEnhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ObjectEnhancement">conversion:ObjectEnhancement</a>
    /// </summary>
    let ObjectEnhancement = _prefixId.prefix "ObjectEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Asserts owl:sameAs relationships between resources and external URIs based on the instances' values of a specific property and their interpretation by a mapping specified by conversion:linksVia. How this mapping is performed based on this value is unspecified, but may be based on aligning with (e.g. SKOS) labels or the edit distance between the property value and instances in a known ontology.^^xsd:string</para>
    ///   <para>rdfs:label : Object sameAs enahncements^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ObjectSameAsEnhancement">conversion:ObjectSameAsEnhancement</a>
    /// </summary>
    let ObjectSameAsEnhancement = _prefixId.prefix "ObjectSameAsEnhancement"

    /// <summary>
    ///   <para>rdfs:comment : Asserts owl:sameAs relationships based on the values in the mapping of the property specified by conversion:subject_of.^^xsd:string</para>
    ///   <para>rdfs:label : Object sameAs enahncements via Lookup^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ObjectSameAsEnhancementViaLookup">conversion:ObjectSameAsEnhancementViaLookup</a>
    /// </summary>
    let ObjectSameAsEnhancementViaLookup =
        _prefixId.prefix "ObjectSameAsEnhancementViaLookup"

    /// <summary>
    ///   <para>rdfs:comment : Omit all triples from this column.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/Omitted">conversion:Omitted</a>
    /// </summary>
    let Omitted = _prefixId.prefix "Omitted"
    /// <summary>
    ///   <para>rdfs:comment : Omit triple if there is no value in the cell of the given column.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/Only_if_column">conversion:Only_if_column</a>
    /// </summary>
    let Only_if_column = _prefixId.prefix "Only_if_column"
    /// <summary>
    ///   <para>rdfs:comment : An Enhancement that modifies the predicate of the resulting triple.^^xsd:string</para>
    ///   <para>rdfs:label : PredicateEnhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/PredicateEnhancement">conversion:PredicateEnhancement</a>
    /// </summary>
    let PredicateEnhancement = _prefixId.prefix "PredicateEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Uses the object of the conversion:comment property and asserts it as the value of rdfs:comment on the property definition. The value of conversion:comment typically comes from the original csv header (that was too long), or from an ancillary file accompanying the csv file.^^xsd:string</para>
    ///   <para>rdfs:label : Property comment enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/PropertyCommentEnhancement">conversion:PropertyCommentEnhancement</a>
    /// </summary>
    let PropertyCommentEnhancement = _prefixId.prefix "PropertyCommentEnhancement"

    /// <summary>
    ///   <para>rdfs:comment : Appends raw literal values to the dataset-property-specific value space URI. For example, the value 'AK' for property 'origin_state' would be promoted to &lt;/source/SSS/dataset/DDD/value/origin_state/AK&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Property-scoped resource promotion enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/PropertyScopedResourcePromotionEnhancement">conversion:PropertyScopedResourcePromotionEnhancement</a>
    /// </summary>
    let PropertyScopedResourcePromotionEnhancement =
        _prefixId.prefix "PropertyScopedResourcePromotionEnhancement"

    /// <summary>
    ///   <para>rdfs:label : A raw conversion process from CSV to RDF^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/RawConversionProcess">conversion:RawConversionProcess</a>
    /// </summary>
    let RawConversionProcess = _prefixId.prefix "RawConversionProcess"

    /// <summary>
    ///   <para>rdfs:comment : Repeat value of last non-empty cell in this column for the current cell.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/Repeat_previous_if_empty_column">conversion:Repeat_previous_if_empty_column</a>
    /// </summary>
    let Repeat_previous_if_empty_column =
        _prefixId.prefix "Repeat_previous_if_empty_column"

    /// <summary>
    ///   <para>rdfs:comment : Casts raw literal values directly into a URI.^^xsd:string</para>
    ///   <para>rdfs:label : Resource cast enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ResourceCastEnhancement">conversion:ResourceCastEnhancement</a>
    /// </summary>
    let ResourceCastEnhancement = _prefixId.prefix "ResourceCastEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Superclass of enhancements which promote values from a plain literal to a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Resource promotion enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ResourcePromotionEnhancement">conversion:ResourcePromotionEnhancement</a>
    /// </summary>
    let ResourcePromotionEnhancement = _prefixId.prefix "ResourcePromotionEnhancement"
    let RowEnhancement = _prefixId.prefix "RowEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : SameAs Dataset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SameAsDataset">conversion:SameAsDataset</a>
    /// </summary>
    let SameAsDataset = _prefixId.prefix "SameAsDataset"
    /// <summary>
    ///   <para>rdfs:label : Superclass for sameAs enahncements^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SameAsEnhancement">conversion:SameAsEnhancement</a>
    /// </summary>
    let SameAsEnhancement = _prefixId.prefix "SameAsEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : http://www.w3.org/TR/sparql11-service-description/ does not specify a range, but we want to refer to it^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/ServiceEndpoint">conversion:ServiceEndpoint</a>
    /// </summary>
    let ServiceEndpoint = _prefixId.prefix "ServiceEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : A person, organization, or agent from which a dataset is retrieved.^^xsd:string</para>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/Source">conversion:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:comment : Asserts that an existing class in the dataset, specified by name with conversion:class_name,  is a subclass of an external class specified by conversion:subclass_of. This enhancement will materialize the rdf:type entailments for all instances.^^xsd:string</para>
    ///   <para>rdfs:label : Subclass enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SubClassEnhancement">conversion:SubClassEnhancement</a>
    /// </summary>
    let SubClassEnhancement = _prefixId.prefix "SubClassEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Asserts that an existing property in the dataset is a subproperty of an external property specified by conversion:subproperty_of. This enhancement will materialize the subproperty entailments for all instances.^^xsd:string</para>
    ///   <para>rdfs:label : Subproperty enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SubPropertyEnhancement">conversion:SubPropertyEnhancement</a>
    /// </summary>
    let SubPropertyEnhancement = _prefixId.prefix "SubPropertyEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : add a predicate-object description to the subject of a triple created.^^xsd:string</para>
    ///   <para>rdfs:label : SubjectAnnotation^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SubjectAnnotation">conversion:SubjectAnnotation</a>
    /// </summary>
    let SubjectAnnotation = _prefixId.prefix "SubjectAnnotation"
    /// <summary>
    ///   <para>rdfs:comment : An Enhancement that modifies the subject of the resulting triple.^^xsd:string</para>
    ///   <para>rdfs:label : SubjectEnhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SubjectEnhancement">conversion:SubjectEnhancement</a>
    /// </summary>
    let SubjectEnhancement = _prefixId.prefix "SubjectEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Asserts owl:sameAs relationships between instances and external URIs based on the instances' values of a specific property and their interpretation by a mapping specified by conversion:linksVia. How this mapping is performed based on this value is unspecified, but may be based on aligning with (e.g. SKOS) labels or the edit distance between the property value and instances in a known ontology.^^xsd:string</para>
    ///   <para>rdfs:label : Subject sameAs enahncements^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SubjectSameAsEnhancement">conversion:SubjectSameAsEnhancement</a>
    /// </summary>
    let SubjectSameAsEnhancement = _prefixId.prefix "SubjectSameAsEnhancement"

    /// <summary>
    ///   <para>rdfs:comment : Asserts owl:sameAs relationships based on the values in the mapping of the property specified by conversion:subject_of.^^xsd:string</para>
    ///   <para>rdfs:label : Subject sameAs enahncements via Lookup^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SubjectSameAsEnhancementViaLookup">conversion:SubjectSameAsEnhancementViaLookup</a>
    /// </summary>
    let SubjectSameAsEnhancementViaLookup =
        _prefixId.prefix "SubjectSameAsEnhancementViaLookup"

    /// <summary>
    ///   <para>rdfs:comment : Asserts that the subject instance is of a specific type, specified by name with conversion:domain_name. Also asserts that the type is a owl:Class.^^xsd:string</para>
    ///   <para>rdfs:label : Subject type enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SubjectTypeEnhancement">conversion:SubjectTypeEnhancement</a>
    /// </summary>
    let SubjectTypeEnhancement = _prefixId.prefix "SubjectTypeEnhancement"
    /// <summary>
    ///   <para>rdfs:comment : Pairs a collection of symbols with how they should be interpreted. For example, 'S' should be interpreted as http://dbpedia.org/resource/United_States_Senate.^^xsd:string</para>
    ///   <para>rdfs:label : SymbolInterpretation^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/SymbolInterpretation">conversion:SymbolInterpretation</a>
    /// </summary>
    let SymbolInterpretation = _prefixId.prefix "SymbolInterpretation"

    /// <summary>
    ///   <para>rdfs:comment : Converts raw literal values into URIs by replacing in the template (specified by the conversion:template_pattern property) the substring '[value]'.^^xsd:string</para>
    ///   <para>rdfs:label : Template resource promotion enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/TemplateResourcePromotionEnhancement">conversion:TemplateResourcePromotionEnhancement</a>
    /// </summary>
    let TemplateResourcePromotionEnhancement =
        _prefixId.prefix "TemplateResourcePromotionEnhancement"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : TripleStore^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/TripleStore">conversion:TripleStore</a>
    /// </summary>
    let TripleStore = _prefixId.prefix "TripleStore"
    let TypedResourcePromotion = _prefixId.prefix "TypedResourcePromotion"

    /// <summary>
    ///   <para>rdfs:comment : Constructs a URI from the concatenation of a dataset-specific URI, a type token specified with conversion:range_name, and the raw literal value. Additionally asserts an rdf:type for the new resource with the class named with conversion:range_name. The type name will be lowercased for use in the URI and have the first letter uppercased for use as the class name. For example, the value 'AK' with conversion:range_name 'state' would be promoted to &lt;/source/SSS/dataset/DDD/type/state/AK&gt; with an rdf:type of &lt;/source/SSS/dataset/DDD/vocab/State&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Typed resource promotion enhancement^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/TypedResourcePromotionEnhancement">conversion:TypedResourcePromotionEnhancement</a>
    /// </summary>
    let TypedResourcePromotionEnhancement =
        _prefixId.prefix "TypedResourcePromotionEnhancement"

    /// <summary>
    ///   <para>rdfs:comment : UnitTestedDatasets should cite locations for their unit tests.^^xsd:stringrdfs:comment : An RDF dataset tested with SPARQL queries verifying the presense or absence of particular triples.^^xsd:string</para>
    ///   <para>rdfs:label : UnitTestedDatset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/UnitTestedDataset">conversion:UnitTestedDataset</a>
    /// </summary>
    let UnitTestedDataset = _prefixId.prefix "UnitTestedDataset"
    /// <summary>
    ///   <para>rdfs:comment : A conversion:Dataset whose data skeleton is available from a version control system.^^xsd:string</para>
    ///   <para>rdfs:label : VersionControlledDataset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/VersionControlledDataset">conversion:VersionControlledDataset</a>
    /// </summary>
    let VersionControlledDataset = _prefixId.prefix "VersionControlledDataset"
    /// <summary>
    ///   <para>rdfs:comment : A materialized (captured in time) dataset -- something is now on disk. Union of all LayerDatasets created by different conversion parameters.^^xsd:string</para>
    ///   <para>rdfs:label : Versioned Dataset^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/VersionedDataset">conversion:VersionedDataset</a>
    /// </summary>
    let VersionedDataset = _prefixId.prefix "VersionedDataset"
    /// <summary>
    ///   <para>rdfs:comment : The base URI used in constructing identifying URIs for instances in the converted dataset.^^xsd:string</para>
    ///   <para>rdfs:label : base_uri^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/base_uri">conversion:base_uri</a>
    /// </summary>
    let base_uri = _prefixId.prefix "base_uri"
    /// <summary>
    ///   <para>rdfs:label : bundled_by^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/bundled_by">conversion:bundled_by</a>
    /// </summary>
    let bundled_by = _prefixId.prefix "bundled_by"
    let class_name = _prefixId.prefix "class_name"
    /// <summary>
    ///   <para>rdfs:comment : A comment (like rdfs:comment) that will be applied to the property created during conversion.^^xsd:string</para>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/comment">conversion:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:label : A measure of conceptual depth using the URI's 'depth' within the source/dataset/version contextualization scheme used by csv2rdf4lod's data aggretation naming scheme.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/conceptual_depth">conversion:conceptual_depth</a>
    /// </summary>
    let conceptual_depth = _prefixId.prefix "conceptual_depth"
    /// <summary>
    ///   <para>rdfs:label : conversion_identifier^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/conversion_identifier">conversion:conversion_identifier</a>
    /// </summary>
    let conversion_identifier = _prefixId.prefix "conversion_identifier"
    /// <summary>
    ///   <para>rdfs:comment : A conversion process that led to the creation or modification of an RDF dataset.^^xsd:string</para>
    ///   <para>rdfs:label : conversion_process^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/conversion_process">conversion:conversion_process</a>
    /// </summary>
    let conversion_process = _prefixId.prefix "conversion_process"
    /// <summary>
    ///   <para>rdfs:comment : The URL of a dataset document.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/dataset_file">conversion:dataset_file</a>
    /// </summary>
    let dataset_file = _prefixId.prefix "dataset_file"
    /// <summary>
    ///   <para>rdfs:comment : The identifier of the dataset being converted. Ideally provided by source_identifier.^^xsd:string</para>
    ///   <para>rdfs:label : dataset_identifier^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/dataset_identifier">conversion:dataset_identifier</a>
    /// </summary>
    let dataset_identifier = _prefixId.prefix "dataset_identifier"
    let dataset_version = _prefixId.prefix "dataset_version"
    let date_pattern = _prefixId.prefix "date_pattern"
    let datetime_pattern = _prefixId.prefix "datetime_pattern"
    let datetime_timezone = _prefixId.prefix "datetime_timezone"
    /// <summary>
    ///   <para>rdfs:comment : The delimiter that should be used to separate cells in a row.^^xsd:string</para>
    ///   <para>rdfs:label : delimits_cell^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/delimits_cell">conversion:delimits_cell</a>
    /// </summary>
    let delimits_cell = _prefixId.prefix "delimits_cell"
    /// <summary>
    ///   <para>rdfs:comment : A regular expression specifiying how the object literal should be delimited to produce multiple object values.^^xsd:string</para>
    ///   <para>rdfs:label : delimits_object^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/delimits_object">conversion:delimits_object</a>
    /// </summary>
    let delimits_object = _prefixId.prefix "delimits_object"
    /// <summary>
    ///   <para>rdfs:comment : The local type that should be asserted for the subjects of raw triples.^^xsd:string</para>
    ///   <para>rdfs:label : domain_name^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/domain_name">conversion:domain_name</a>
    /// </summary>
    let domain_name = _prefixId.prefix "domain_name"
    /// <summary>
    ///   <para>rdfs:comment : TODO, cannot happen: :cp a conversion:EnhancementConversionProcess; conversion:enhance [ ov:csvCol 1; conversion:domain_template 'a' ], [ ov:csvCol 2; conversion:domain_template 'b' ] (col 1 and col 2 make the enhancements distinct, and an EnhancementConversionProcess can only have one domain_templated enhancement.)^^xsd:stringrdfs:comment : Template to name the subject of the triple produced.^^xsd:string</para>
    ///   <para>rdfs:label : domain_template^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/domain_template">conversion:domain_template</a>
    /// </summary>
    let domain_template = _prefixId.prefix "domain_template"
    /// <summary>
    ///   <para>rdfs:comment : Example value from a cell in the column for this ColumnEnhancement.^^xsd:string</para>
    ///   <para>rdfs:label : eg^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/eg">conversion:eg</a>
    /// </summary>
    let eg = _prefixId.prefix "eg"
    /// <summary>
    ///   <para>rdfs:comment : The character encoding of a dataset document.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/encoding">conversion:encoding</a>
    /// </summary>
    let encoding = _prefixId.prefix "encoding"
    /// <summary>
    ///   <para>rdfs:label : enhance^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/enhance">conversion:enhance</a>
    /// </summary>
    let enhance = _prefixId.prefix "enhance"
    /// <summary>
    ///   <para>rdfs:label : enhancement_identifier^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/enhancement_identifier">conversion:enhancement_identifier</a>
    /// </summary>
    let enhancement_identifier = _prefixId.prefix "enhancement_identifier"
    let enhancement_layer = _prefixId.prefix "enhancement_layer"
    /// <summary>
    ///   <para>rdfs:comment : Used to describe terms from enhanced datasets, to refer to analogous terms from less enhanced datasets^^xsd:string</para>
    ///   <para>rdfs:label : enhances^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/enhances">conversion:enhances</a>
    /// </summary>
    let enhances = _prefixId.prefix "enhances"
    /// <summary>
    ///   <para>rdfs:coment : The URI of a predicate that the current property should be replaced with.^^xsd:string</para>
    ///   <para>rdfs:label : equivalent_property^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/equivalent_property">conversion:equivalent_property</a>
    /// </summary>
    let equivalent_property = _prefixId.prefix "equivalent_property"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : interpret^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/interpret">conversion:interpret</a>
    /// </summary>
    let interpret = _prefixId.prefix "interpret"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : interpretation^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/interpretation">conversion:interpretation</a>
    /// </summary>
    let interpretation = _prefixId.prefix "interpretation"
    /// <summary>
    ///   <para>rdfs:comment : A human-friendly label (like rdfs:label) that will be used to create the property local name when creating the property URI. The exact value of conversion:label will also be used for the rdfs:label of the property created.^^xsd:string</para>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/label">conversion:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : links_via^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/links_via">conversion:links_via</a>
    /// </summary>
    let links_via = _prefixId.prefix "links_via"
    let multiplier = _prefixId.prefix "multiplier"
    /// <summary>
    ///   <para>rdfs:label : name_template^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/name_template">conversion:name_template</a>
    /// </summary>
    let name_template = _prefixId.prefix "name_template"
    /// <summary>
    ///   <para>rdfs:comment : Number of docs/logs/* captured by convert-aggregate.sh^^xsd:string</para>
    ///   <para>rdfs:label : Number of invocation logs^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/num_invocation_logs">conversion:num_invocation_logs</a>
    /// </summary>
    let num_invocation_logs = _prefixId.prefix "num_invocation_logs"
    /// <summary>
    ///   <para>rdfs:label : num_triples^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/num_triples">conversion:num_triples</a>
    /// </summary>
    let num_triples = _prefixId.prefix "num_triples"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : object^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/object">conversion:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:label : object_search^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/object_search">conversion:object_search</a>
    /// </summary>
    let object_search = _prefixId.prefix "object_search"
    /// <summary>
    ///   <para>rdfs:label : pattern^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/pattern">conversion:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : predicate^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/predicate">conversion:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:comment : ov:csvCol OR conversion:property_name should be used to refer to the property being enhanced - NOT BOTH.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/predicate_identifier">conversion:predicate_identifier</a>
    /// </summary>
    let predicate_identifier = _prefixId.prefix "predicate_identifier"
    /// <summary>
    ///   <para>rdfs:comment : The local name of a property within this dataset-specific namespace.^^xsd:stringrdfs:comment : The property name on which an enhancement takes place.^^xsd:string</para>
    ///   <para>rdfs:label : property_name^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/property_name">conversion:property_name</a>
    /// </summary>
    let property_name = _prefixId.prefix "property_name"
    /// <summary>
    ///   <para>rdfs:comment : The rdfs:range of the property after enhancement. For raw conversions, it is always rdfs:Literal. More interesting things happen during enhancements.^^xsd:string</para>
    ///   <para>rdfs:label : range^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/range">conversion:range</a>
    /// </summary>
    let range = _prefixId.prefix "range"
    /// <summary>
    ///   <para>rdfs:comment : The local name of an internal class.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/range_name">conversion:range_name</a>
    /// </summary>
    let range_name = _prefixId.prefix "range_name"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : range template^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/range_template">conversion:range_template</a>
    /// </summary>
    let range_template = _prefixId.prefix "range_template"
    /// <summary>
    ///   <para>rdfs:label : regex^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/regex">conversion:regex</a>
    /// </summary>
    let regex = _prefixId.prefix "regex"
    /// <summary>
    ///   <para>rdfs:comment : The source of data for a conversion process.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/source_data">conversion:source_data</a>
    /// </summary>
    let source_data = _prefixId.prefix "source_data"
    /// <summary>
    ///   <para>rdfs:comment : The name of the organization to which the dataset being converted belongs.^^xsd:string</para>
    ///   <para>rdfs:label : source_identifier^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/source_identifier">conversion:source_identifier</a>
    /// </summary>
    let source_identifier = _prefixId.prefix "source_identifier"
    let subclass_of = _prefixId.prefix "subclass_of"
    let subject_discriminator = _prefixId.prefix "subject_discriminator"
    let subject_of = _prefixId.prefix "subject_of"
    /// <summary>
    ///   <para>rdfs:comment : The external property that is a super property of the local property named by :property_name^^xsd:string</para>
    ///   <para>rdfs:label : subproperty_of^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/subproperty_of">conversion:subproperty_of</a>
    /// </summary>
    let subproperty_of = _prefixId.prefix "subproperty_of"
    /// <summary>
    ///   <para>rdfs:comment : A transitive version of void:subset^^xsd:string</para>
    ///   <para>rdfs:label : subsetT^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/subseT">conversion:subseT</a>
    /// </summary>
    let subseT = _prefixId.prefix "subseT"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : symbol^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/symbol">conversion:symbol</a>
    /// </summary>
    let symbol = _prefixId.prefix "symbol"
    /// <summary>
    ///   <para>rdfs:comment : String representing a templated URI. Placeholders in the template are replaced by values of the row in the specified columns. Columns are cited by local name or column number. For example, http://some.other.org/instances/[value]. http://some.other.org/instances/[state]-[county], http://some.other.org/instances/[#4]-[#6]^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/template_pattern">conversion:template_pattern</a>
    /// </summary>
    let template_pattern = _prefixId.prefix "template_pattern"
    let testable_by = _prefixId.prefix "testable_by"
    let todo = _prefixId.prefix "todo"
    /// <summary>
    ///   <para>rdfs:label : triples_per_minute^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/triples_per_minute">conversion:triples_per_minute</a>
    /// </summary>
    let triples_per_minute = _prefixId.prefix "triples_per_minute"
    /// <summary>
    ///   <para>rdfs:comment : The local name of a class within this dataset-specific namespace.^^xsd:string</para>
    ///   <para>rdfs:label : type_name^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/type_name">conversion:type_name</a>
    /// </summary>
    let type_name = _prefixId.prefix "type_name"
    /// <summary>
    ///   <para>rdfs:label : uses_class^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/uses_class">conversion:uses_class</a>
    /// </summary>
    let uses_class = _prefixId.prefix "uses_class"
    /// <summary>
    ///   <para>rdfs:label : uses_predicate^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/uses_predicate">conversion:uses_predicate</a>
    /// </summary>
    let uses_predicate = _prefixId.prefix "uses_predicate"
    /// <summary>
    ///   <para>rdfs:comment : The version_identifier should only change during a 'raw' conversion when the underlying dataset has changed.^^xsd:stringrdfs:comment : The version of conversion being performed per dataset.^^xsd:string</para>
    ///   <para>rdfs:label : version_identifier^^xsd:string</para>
    ///   <a href="http://purl.org/twc/vocab/conversion/version_identifier">conversion:version_identifier</a>
    /// </summary>
    let version_identifier = _prefixId.prefix "version_identifier"
