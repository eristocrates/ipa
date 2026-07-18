namespace http.purl.org.twc.vocab.conversion.slash

open DoxAletheia.Rdf_Vocabulary

module conversion =
    let _namespace_name = "http://purl.org/twc/vocab/conversion/"

    /// <summary>
    /// ov:csvCol OR conversion:property_name should be used to refer to the property being enhanced - NOT BOTH.
    /// <see href="http://purl.org/twc/vocab/conversion/predicate_identifier"></see></summary>
    let predicate_identifier =
        Namespaced_IRI.parse _namespace_name "predicate_identifier" |> NamespacedName

    /// <summary>
    /// Dataset with source and dataset identifiers, but not version. Before any version is materialized (captured in time), and the union of all VersionedDatasets.
    /// <see href="http://purl.org/twc/vocab/conversion/AbstractDataset"></see></summary>
    let AbstractDataset =
        Namespaced_IRI.parse _namespace_name "AbstractDataset" |> NamespacedName

    /// <summary>
    /// A materialized (captured in time) dataset -- something is now on disk. Union of all LayerDatasets created by different conversion parameters.
    /// <see href="http://purl.org/twc/vocab/conversion/VersionedDataset"></see></summary>
    let VersionedDataset =
        Namespaced_IRI.parse _namespace_name "VersionedDataset" |> NamespacedName

    /// <summary>
    /// Asserted by the converter.
    /// <see href="http://purl.org/twc/vocab/conversion/Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// A conversion of a VersionedDataset using a particular set of conversion parameters.
    /// <see href="http://purl.org/twc/vocab/conversion/LayerDataset"></see></summary>
    let LayerDataset =
        Namespaced_IRI.parse _namespace_name "LayerDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/AuxiliaryDataset"></see>
    /// </summary>
    let AuxiliaryDataset =
        Namespaced_IRI.parse _namespace_name "AuxiliaryDataset" |> NamespacedName

    /// <summary>
    /// Casts raw literal values into xsd:boolean datatyped values. The default recognized lexical representations are (case insensitive): 'yes', 'no', 'true', 'false', '0', and '1'. The conversion:boolean_true and conversion:boolean_false properties may be used to add additional lexical forms.
    /// <see href="http://purl.org/twc/vocab/conversion/BooleanPromotionEnhancement"></see></summary>
    let BooleanPromotionEnhancement =
        Namespaced_IRI.parse _namespace_name "BooleanPromotionEnhancement" |> NamespacedName

    /// <summary>
    /// Promotes the raw literal value to a datatyped literal using the datatype specified with the conversion:range property.
    /// <see href="http://purl.org/twc/vocab/conversion/DatatypePromotionEnhancement"></see></summary>
    let DatatypePromotionEnhancement =
        Namespaced_IRI.parse _namespace_name "DatatypePromotionEnhancement" |> NamespacedName

    /// <summary>
    /// The rdfs:range of the property after enhancement. For raw conversions, it is always rdfs:Literal. More interesting things happen during enhancements.
    /// <see href="http://purl.org/twc/vocab/conversion/range"></see></summary>
    let range = Namespaced_IRI.parse _namespace_name "range" |> NamespacedName

    /// <summary>
    /// Any SymbolInterpretation that interprets to true or false is a BooleanSymbolInterpretation.
    /// <see href="http://purl.org/twc/vocab/conversion/BooleanSymbolInterpretation"></see></summary>
    let BooleanSymbolInterpretation =
        Namespaced_IRI.parse _namespace_name "BooleanSymbolInterpretation" |> NamespacedName

    /// <summary>
    /// Pairs a collection of symbols with how they should be interpreted. For example, 'S' should be interpreted as http://dbpedia.org/resource/United_States_Senate.
    /// <see href="http://purl.org/twc/vocab/conversion/SymbolInterpretation"></see></summary>
    let SymbolInterpretation =
        Namespaced_IRI.parse _namespace_name "SymbolInterpretation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/interpretation"></see>
    /// </summary>
    let interpretation =
        Namespaced_IRI.parse _namespace_name "interpretation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/Bundle"></see>
    /// </summary>
    let Bundle = Namespaced_IRI.parse _namespace_name "Bundle" |> NamespacedName

    /// <summary>
    /// A shell script that sets https://github.com/timrdf/csv2rdf4lod-automation/wiki/CSV2RDF4LOD-environment-variables to control the behavior of csv2rdf4lod-automation.
    /// <see href="http://purl.org/twc/vocab/conversion/CSV2RDF4LOD_environment_variables"></see></summary>
    let CSV2RDF4LOD_environment_variables =
        Namespaced_IRI.parse _namespace_name "CSV2RDF4LOD_environment_variables" |> NamespacedName

    /// <summary>
    /// Ignore string case when attempting to match identifiers between the input table and the identifiers in the LODLinks graph
    /// <see href="http://purl.org/twc/vocab/conversion/CaseInsensitiveLODLink"></see></summary>
    let CaseInsensitiveLODLink =
        Namespaced_IRI.parse _namespace_name "CaseInsensitiveLODLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/Enhancement"></see>
    /// </summary>
    let Enhancement =
        Namespaced_IRI.parse _namespace_name "Enhancement" |> NamespacedName

    /// <summary>
    /// A CatalogedDataset is any kind of dataset, in the most general sense and regardless of how it is encoded (RDF, Relational, Tabular, XML, SPS, etc.). If someone says to you, 'yea, NASA has a Mars imagery dataset, talk to Joe about it and visit its homepage', you just instantiated a CatalogedDataset. There are MANY CatalogedDatasets that are NOT conversion:Datasets and NOT void:Datasets, since both of these are RDF-based datasets. The purpose of CatalogedDataset is to maintain a list of 'TODO' items that could be explored, converted, and published as RDF. Once a CatalogedDataset IS investigated, named, and converted, it also becomes a conversion:Dataset (and thus a void:Datast).
    /// <see href="http://purl.org/twc/vocab/conversion/CatalogedDataset"></see></summary>
    let CatalogedDataset =
        Namespaced_IRI.parse _namespace_name "CatalogedDataset" |> NamespacedName

    /// <summary>
    /// Metadata for a dataset that is created during the dataset's conversion invocation.
    /// <see href="http://purl.org/twc/vocab/conversion/ConversionMetaDataset"></see></summary>
    let ConversionMetaDataset =
        Namespaced_IRI.parse _namespace_name "ConversionMetaDataset" |> NamespacedName

    /// <summary>
    /// Data about another Dataset. Can contain VoID, PML, OPM, provenance, Dublin Core, etc.
    /// <see href="http://purl.org/twc/vocab/conversion/MetaDataset"></see></summary>
    let MetaDataset =
        Namespaced_IRI.parse _namespace_name "MetaDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/ConversionProcess"></see>
    /// </summary>
    let ConversionProcess =
        Namespaced_IRI.parse _namespace_name "ConversionProcess" |> NamespacedName

    /// <summary>
    /// In csv2rdf4lod-automation, the conversion trigger is a shell script situated within the conversion cockpit that initiates conversion of source data to RDF.
    /// <see href="http://purl.org/twc/vocab/conversion/ConversionTrigger"></see></summary>
    let ConversionTrigger =
        Namespaced_IRI.parse _namespace_name "ConversionTrigger" |> NamespacedName

    /// <summary>
    /// Asserted by pcurl.sh
    /// <see href="http://purl.org/twc/vocab/conversion/Curl"></see></summary>
    let Curl = Namespaced_IRI.parse _namespace_name "Curl" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/DataEndRow"></see>
    /// </summary>
    let DataEndRow = Namespaced_IRI.parse _namespace_name "DataEndRow" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/RowEnhancement"></see>
    /// </summary>
    let RowEnhancement =
        Namespaced_IRI.parse _namespace_name "RowEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/DataStartRow"></see>
    /// </summary>
    let DataStartRow =
        Namespaced_IRI.parse _namespace_name "DataStartRow" |> NamespacedName

    /// <summary>
    /// A person, organization, or agent from which a dataset is retrieved.
    /// <see href="http://purl.org/twc/vocab/conversion/Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName

    /// <summary>
    /// A dataset that lists other datasets as its entries.
    /// <see href="http://purl.org/twc/vocab/conversion/DatasetCatalog"></see></summary>
    let DatasetCatalog =
        Namespaced_IRI.parse _namespace_name "DatasetCatalog" |> NamespacedName

    /// <summary>
    /// A potentially incomplete subset of a void:Dataset
    /// <see href="http://purl.org/twc/vocab/conversion/DatasetSample"></see></summary>
    let DatasetSample =
        Namespaced_IRI.parse _namespace_name "DatasetSample" |> NamespacedName

    /// <summary>
    /// Superclass of enhancements which promote values from a plain literal to more complex terms (resources or typed literals).
    /// An Enhancement that modifies the object of the resulting triple.
    /// <see href="http://purl.org/twc/vocab/conversion/ObjectEnhancement"></see></summary>
    let ObjectEnhancement =
        Namespaced_IRI.parse _namespace_name "ObjectEnhancement" |> NamespacedName

    /// <summary>
    /// Superclass of enhancements which promote values from a plain literal to a resource.
    /// <see href="http://purl.org/twc/vocab/conversion/ResourcePromotionEnhancement"></see></summary>
    let ResourcePromotionEnhancement =
        Namespaced_IRI.parse _namespace_name "ResourcePromotionEnhancement" |> NamespacedName

    /// <summary>
    /// Casts raw literal values into W3CDTF values typed as xsd:date based on a strftime pattern specified with the conversion:date_pattern. If the property values follow different patterns, multiple conversion:date_pattern values may specified.
    /// For each value, all DateTimePromotionEnhancement patterns are attempted before attempting any DatePromotionEnhancement patterns specified for the same property.
    /// <see href="http://purl.org/twc/vocab/conversion/DatePromotionEnhancement"></see></summary>
    let DatePromotionEnhancement =
        Namespaced_IRI.parse _namespace_name "DatePromotionEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/date_pattern"></see>
    /// </summary>
    let date_pattern =
        Namespaced_IRI.parse _namespace_name "date_pattern" |> NamespacedName

    /// <summary>
    /// Casts raw literal values into W3CDTF values typed as xsd:dateTime based on a strftime pattern specified with the conversion:datetime_pattern. If the property values follow different patterns, multiple conversion:datetime_pattern values may specified. The first matching pattern (of a nondeterministic ordering) will be applied. An optional conversion:datetime_timezone may be specified if no timezone information is present in the datetime pattern.
    /// <see href="http://purl.org/twc/vocab/conversion/DateTimePromotionEnhancement"></see></summary>
    let DateTimePromotionEnhancement =
        Namespaced_IRI.parse _namespace_name "DateTimePromotionEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/datetime_timezone"></see>
    /// </summary>
    let datetime_timezone =
        Namespaced_IRI.parse _namespace_name "datetime_timezone" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/datetime_pattern"></see>
    /// </summary>
    let datetime_pattern =
        Namespaced_IRI.parse _namespace_name "datetime_pattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/Deprecated"></see>
    /// </summary>
    let Deprecated = Namespaced_IRI.parse _namespace_name "Deprecated" |> NamespacedName

    /// <summary>
    /// For any Resource that became owl:sameAs another Resource in an external LOD bubble, use ALL external URIs instead of the local resource.
    /// <see href="http://purl.org/twc/vocab/conversion/DirectSameAsEnhancement"></see></summary>
    let DirectSameAsEnhancement =
        Namespaced_IRI.parse _namespace_name "DirectSameAsEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/DocumentState"></see>
    /// </summary>
    let DocumentState =
        Namespaced_IRI.parse _namespace_name "DocumentState" |> NamespacedName

    /// <summary>
    /// The local name of a property within this dataset-specific namespace.
    /// The property name on which an enhancement takes place.
    /// <see href="http://purl.org/twc/vocab/conversion/property_name"></see></summary>
    let property_name =
        Namespaced_IRI.parse _namespace_name "property_name" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/EnhancementProcess"></see>
    /// </summary>
    let EnhancementProcess =
        Namespaced_IRI.parse _namespace_name "EnhancementProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/enhance"></see>
    /// </summary>
    let enhance = Namespaced_IRI.parse _namespace_name "enhance" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/enhancement_identifier"></see>
    /// </summary>
    let enhancement_identifier =
        Namespaced_IRI.parse _namespace_name "enhancement_identifier" |> NamespacedName

    /// <summary>
    /// Cites a row that contains an exemplary resource or structure; 'highlighting' it for increased attention. e.g., Jim Hendler or Bill O'Reilly in a White House Visitor Record.
    /// <see href="http://purl.org/twc/vocab/conversion/ExampleResource"></see></summary>
    let ExampleResource =
        Namespaced_IRI.parse _namespace_name "ExampleResource" |> NamespacedName

    /// <summary>
    /// Reasserts the property-value pair to belong to the existing resource specified by the conversion:bundled_by property.
    /// <see href="http://purl.org/twc/vocab/conversion/ExistingBundleEnhancement"></see></summary>
    let ExistingBundleEnhancement =
        Namespaced_IRI.parse _namespace_name "ExistingBundleEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/bundled_by"></see>
    /// </summary>
    let bundled_by = Namespaced_IRI.parse _namespace_name "bundled_by" |> NamespacedName

    /// <summary>
    /// An Enhancement that modifies the subject of the resulting triple.
    /// <see href="http://purl.org/twc/vocab/conversion/SubjectEnhancement"></see></summary>
    let SubjectEnhancement =
        Namespaced_IRI.parse _namespace_name "SubjectEnhancement" |> NamespacedName

    /// <summary>
    /// Done by pcurl.sh
    /// <see href="http://purl.org/twc/vocab/conversion/HTTPHeader"></see></summary>
    let HTTPHeader = Namespaced_IRI.parse _namespace_name "HTTPHeader" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/HeaderRow"></see>
    /// </summary>
    let HeaderRow = Namespaced_IRI.parse _namespace_name "HeaderRow" |> NamespacedName

    /// <summary>
    /// Represents the structural template for an implicit bundle enhancement. The conversion:property_name specifies the property name by which a bundle is attached to an instance. An optional conversion:type_name may be specified for the bundle to indicate the rdf:type of the new resource.
    /// <see href="http://purl.org/twc/vocab/conversion/ImplicitBundle"></see></summary>
    let ImplicitBundle =
        Namespaced_IRI.parse _namespace_name "ImplicitBundle" |> NamespacedName

    /// <summary>
    /// The local name of a class within this dataset-specific namespace.
    /// <see href="http://purl.org/twc/vocab/conversion/type_name"></see></summary>
    let type_name = Namespaced_IRI.parse _namespace_name "type_name" |> NamespacedName

    /// <summary>
    /// Reasserts the property-value pair to belong to a new resource specified by the conversion:bundled_by property. An example of this enhancement would be the introduction of a geo:Point instance based on latitude and longitude properties.
    /// <see href="http://purl.org/twc/vocab/conversion/ImplicitBundleEnhancement"></see></summary>
    let ImplicitBundleEnhancement =
        Namespaced_IRI.parse _namespace_name "ImplicitBundleEnhancement" |> NamespacedName

    /// <summary>
    /// Any enhnacment with a conversion:links_via can also be a conversion:IncludesLODLinks. When so, include the LODLinks graph in the converted output.
    /// <see href="http://purl.org/twc/vocab/conversion/IncludesLODLinks"></see></summary>
    let IncludesLODLinks =
        Namespaced_IRI.parse _namespace_name "IncludesLODLinks" |> NamespacedName

    /// <summary>
    /// An RDF Graph of resources with identifiers (dcterms:identifer, etc) that is used to link to resources created during conversion.
    /// <see href="http://purl.org/twc/vocab/conversion/LODLinks"></see></summary>
    let LODLinks = Namespaced_IRI.parse _namespace_name "LODLinks" |> NamespacedName

    /// <summary>
    /// Refer to a local URI, which then has a single owl:sameAs triple pointing to external LOD bubbles. Depends on owl:sameAs inference OR extra graph patterns in SPARQL queries.
    /// <see href="http://purl.org/twc/vocab/conversion/IndirectSameAsEnhancement"></see></summary>
    let IndirectSameAsEnhancement =
        Namespaced_IRI.parse _namespace_name "IndirectSameAsEnhancement" |> NamespacedName

    /// <summary>
    /// Prevents triples with objects of a certain value. Prevents values specified by rdf:value.
    /// <see href="http://purl.org/twc/vocab/conversion/InterpretedAsNullEnhancement"></see></summary>
    let InterpretedAsNullEnhancement =
        Namespaced_IRI.parse _namespace_name "InterpretedAsNullEnhancement" |> NamespacedName

    /// <summary>
    /// Renames an existing property in the dataset.
    /// <see href="http://purl.org/twc/vocab/conversion/LabelRenameEnhancement"></see></summary>
    let LabelRenameEnhancement =
        Namespaced_IRI.parse _namespace_name "LabelRenameEnhancement" |> NamespacedName

    /// <summary>
    /// An Enhancement that modifies the predicate of the resulting triple.
    /// <see href="http://purl.org/twc/vocab/conversion/PredicateEnhancement"></see></summary>
    let PredicateEnhancement =
        Namespaced_IRI.parse _namespace_name "PredicateEnhancement" |> NamespacedName

    /// <summary>
    /// Used to denote that the value of a cell is 'large', where 'large' is loosely defined by the implementing system. For example, javacsv thinks 100,000 characters is Large and requires a setting to permit more than that.
    /// <see href="http://purl.org/twc/vocab/conversion/LargeValue"></see></summary>
    let LargeValue = Namespaced_IRI.parse _namespace_name "LargeValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/SameAsDataset"></see>
    /// </summary>
    let SameAsDataset =
        Namespaced_IRI.parse _namespace_name "SameAsDataset" |> NamespacedName

    /// <summary>
    /// After datatype promotion to an XSD numeric type, multiplies the value by the multiplicand specified with the conversion:multiplier property.
    /// <see href="http://purl.org/twc/vocab/conversion/MultiplierEnhancement"></see></summary>
    let MultiplierEnhancement =
        Namespaced_IRI.parse _namespace_name "MultiplierEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/multiplier"></see>
    /// </summary>
    let multiplier = Namespaced_IRI.parse _namespace_name "multiplier" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/interpret"></see>
    /// </summary>
    let interpret = Namespaced_IRI.parse _namespace_name "interpret" |> NamespacedName

    /// <summary>
    /// Asserts owl:sameAs relationships between resources and external URIs based on the instances' values of a specific property and their interpretation by a mapping specified by conversion:linksVia. How this mapping is performed based on this value is unspecified, but may be based on aligning with (e.g. SKOS) labels or the edit distance between the property value and instances in a known ontology.
    /// <see href="http://purl.org/twc/vocab/conversion/ObjectSameAsEnhancement"></see></summary>
    let ObjectSameAsEnhancement =
        Namespaced_IRI.parse _namespace_name "ObjectSameAsEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/SameAsEnhancement"></see>
    /// </summary>
    let SameAsEnhancement =
        Namespaced_IRI.parse _namespace_name "SameAsEnhancement" |> NamespacedName

    /// <summary>
    /// Asserts owl:sameAs relationships based on the values in the mapping of the property specified by conversion:subject_of.
    /// <see href="http://purl.org/twc/vocab/conversion/ObjectSameAsEnhancementViaLookup"></see></summary>
    let ObjectSameAsEnhancementViaLookup =
        Namespaced_IRI.parse _namespace_name "ObjectSameAsEnhancementViaLookup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/subject_of"></see>
    /// </summary>
    let subject_of = Namespaced_IRI.parse _namespace_name "subject_of" |> NamespacedName
    /// <summary>
    /// Omit all triples from this column.
    /// <see href="http://purl.org/twc/vocab/conversion/Omitted"></see></summary>
    let Omitted = Namespaced_IRI.parse _namespace_name "Omitted" |> NamespacedName

    /// <summary>
    /// Omit triple if there is no value in the cell of the given column.
    /// <see href="http://purl.org/twc/vocab/conversion/Only_if_column"></see></summary>
    let Only_if_column =
        Namespaced_IRI.parse _namespace_name "Only_if_column" |> NamespacedName

    /// <summary>
    /// Uses the object of the conversion:comment property and asserts it as the value of rdfs:comment on the property definition. The value of conversion:comment typically comes from the original csv header (that was too long), or from an ancillary file accompanying the csv file.
    /// <see href="http://purl.org/twc/vocab/conversion/PropertyCommentEnhancement"></see></summary>
    let PropertyCommentEnhancement =
        Namespaced_IRI.parse _namespace_name "PropertyCommentEnhancement" |> NamespacedName

    /// <summary>
    /// Appends raw literal values to the dataset-property-specific value space URI. For example, the value 'AK' for property 'origin_state' would be promoted to &lt;/source/SSS/dataset/DDD/value/origin_state/AK&gt;.
    /// <see href="http://purl.org/twc/vocab/conversion/PropertyScopedResourcePromotionEnhancement"></see></summary>
    let PropertyScopedResourcePromotionEnhancement =
        Namespaced_IRI.parse _namespace_name "PropertyScopedResourcePromotionEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/RawConversionProcess"></see>
    /// </summary>
    let RawConversionProcess =
        Namespaced_IRI.parse _namespace_name "RawConversionProcess" |> NamespacedName

    /// <summary>
    /// Repeat value of last non-empty cell in this column for the current cell.
    /// <see href="http://purl.org/twc/vocab/conversion/Repeat_previous_if_empty_column"></see></summary>
    let Repeat_previous_if_empty_column =
        Namespaced_IRI.parse _namespace_name "Repeat_previous_if_empty_column" |> NamespacedName

    /// <summary>
    /// Casts raw literal values directly into a URI.
    /// <see href="http://purl.org/twc/vocab/conversion/ResourceCastEnhancement"></see></summary>
    let ResourceCastEnhancement =
        Namespaced_IRI.parse _namespace_name "ResourceCastEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/links_via"></see>
    /// </summary>
    let links_via = Namespaced_IRI.parse _namespace_name "links_via" |> NamespacedName

    /// <summary>
    /// Asserts owl:sameAs relationships between instances and external URIs based on the instances' values of a specific property and their interpretation by a mapping specified by conversion:linksVia. How this mapping is performed based on this value is unspecified, but may be based on aligning with (e.g. SKOS) labels or the edit distance between the property value and instances in a known ontology.
    /// <see href="http://purl.org/twc/vocab/conversion/SubjectSameAsEnhancement"></see></summary>
    let SubjectSameAsEnhancement =
        Namespaced_IRI.parse _namespace_name "SubjectSameAsEnhancement" |> NamespacedName

    /// <summary>
    /// http://www.w3.org/TR/sparql11-service-description/ does not specify a range, but we want to refer to it
    /// <see href="http://purl.org/twc/vocab/conversion/ServiceEndpoint"></see></summary>
    let ServiceEndpoint =
        Namespaced_IRI.parse _namespace_name "ServiceEndpoint" |> NamespacedName

    /// <summary>
    /// Asserts that an existing class in the dataset, specified by name with conversion:class_name,  is a subclass of an external class specified by conversion:subclass_of. This enhancement will materialize the rdf:type entailments for all instances.
    /// <see href="http://purl.org/twc/vocab/conversion/SubClassEnhancement"></see></summary>
    let SubClassEnhancement =
        Namespaced_IRI.parse _namespace_name "SubClassEnhancement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/subclass_of"></see>
    /// </summary>
    let subclass_of =
        Namespaced_IRI.parse _namespace_name "subclass_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/class_name"></see>
    /// </summary>
    let class_name = Namespaced_IRI.parse _namespace_name "class_name" |> NamespacedName

    /// <summary>
    /// Asserts that an existing property in the dataset is a subproperty of an external property specified by conversion:subproperty_of. This enhancement will materialize the subproperty entailments for all instances.
    /// <see href="http://purl.org/twc/vocab/conversion/SubPropertyEnhancement"></see></summary>
    let SubPropertyEnhancement =
        Namespaced_IRI.parse _namespace_name "SubPropertyEnhancement" |> NamespacedName

    /// <summary>
    /// The external property that is a super property of the local property named by :property_name
    /// <see href="http://purl.org/twc/vocab/conversion/subproperty_of"></see></summary>
    let subproperty_of =
        Namespaced_IRI.parse _namespace_name "subproperty_of" |> NamespacedName

    /// <summary>
    /// add a predicate-object description to the subject of a triple created.
    /// <see href="http://purl.org/twc/vocab/conversion/SubjectAnnotation"></see></summary>
    let SubjectAnnotation =
        Namespaced_IRI.parse _namespace_name "SubjectAnnotation" |> NamespacedName

    /// <summary>
    /// Asserts owl:sameAs relationships based on the values in the mapping of the property specified by conversion:subject_of.
    /// <see href="http://purl.org/twc/vocab/conversion/SubjectSameAsEnhancementViaLookup"></see></summary>
    let SubjectSameAsEnhancementViaLookup =
        Namespaced_IRI.parse _namespace_name "SubjectSameAsEnhancementViaLookup" |> NamespacedName

    /// <summary>
    /// Asserts that the subject instance is of a specific type, specified by name with conversion:domain_name. Also asserts that the type is a owl:Class.
    /// <see href="http://purl.org/twc/vocab/conversion/SubjectTypeEnhancement"></see></summary>
    let SubjectTypeEnhancement =
        Namespaced_IRI.parse _namespace_name "SubjectTypeEnhancement" |> NamespacedName

    /// <summary>
    /// The local type that should be asserted for the subjects of raw triples.
    /// <see href="http://purl.org/twc/vocab/conversion/domain_name"></see></summary>
    let domain_name =
        Namespaced_IRI.parse _namespace_name "domain_name" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/symbol"></see>
    /// </summary>
    let symbol = Namespaced_IRI.parse _namespace_name "symbol" |> NamespacedName

    /// <summary>
    /// Converts raw literal values into URIs by replacing in the template (specified by the conversion:template_pattern property) the substring '[value]'.
    /// <see href="http://purl.org/twc/vocab/conversion/TemplateResourcePromotionEnhancement"></see></summary>
    let TemplateResourcePromotionEnhancement =
        Namespaced_IRI.parse _namespace_name "TemplateResourcePromotionEnhancement" |> NamespacedName

    /// <summary>
    /// String representing a templated URI. Placeholders in the template are replaced by values of the row in the specified columns. Columns are cited by local name or column number. For example, http://some.other.org/instances/[value]. http://some.other.org/instances/[state]-[county], http://some.other.org/instances/[#4]-[#6]
    /// <see href="http://purl.org/twc/vocab/conversion/template_pattern"></see></summary>
    let template_pattern =
        Namespaced_IRI.parse _namespace_name "template_pattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/TripleStore"></see>
    /// </summary>
    let TripleStore =
        Namespaced_IRI.parse _namespace_name "TripleStore" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/TypedResourcePromotion"></see>
    /// </summary>
    let TypedResourcePromotion =
        Namespaced_IRI.parse _namespace_name "TypedResourcePromotion" |> NamespacedName

    /// <summary>
    /// Constructs a URI from the concatenation of a dataset-specific URI, a type token specified with conversion:range_name, and the raw literal value. Additionally asserts an rdf:type for the new resource with the class named with conversion:range_name. The type name will be lowercased for use in the URI and have the first letter uppercased for use as the class name. For example, the value 'AK' with conversion:range_name 'state' would be promoted to &lt;/source/SSS/dataset/DDD/type/state/AK&gt; with an rdf:type of &lt;/source/SSS/dataset/DDD/vocab/State&gt;.
    /// <see href="http://purl.org/twc/vocab/conversion/TypedResourcePromotionEnhancement"></see></summary>
    let TypedResourcePromotionEnhancement =
        Namespaced_IRI.parse _namespace_name "TypedResourcePromotionEnhancement" |> NamespacedName

    /// <summary>
    /// The local name of an internal class.
    /// <see href="http://purl.org/twc/vocab/conversion/range_name"></see></summary>
    let range_name = Namespaced_IRI.parse _namespace_name "range_name" |> NamespacedName

    /// <summary>
    /// UnitTestedDatasets should cite locations for their unit tests.
    /// An RDF dataset tested with SPARQL queries verifying the presense or absence of particular triples.
    /// <see href="http://purl.org/twc/vocab/conversion/UnitTestedDataset"></see></summary>
    let UnitTestedDataset =
        Namespaced_IRI.parse _namespace_name "UnitTestedDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/testable_by"></see>
    /// </summary>
    let testable_by =
        Namespaced_IRI.parse _namespace_name "testable_by" |> NamespacedName

    /// <summary>
    /// A conversion:Dataset whose data skeleton is available from a version control system.
    /// <see href="http://purl.org/twc/vocab/conversion/VersionControlledDataset"></see></summary>
    let VersionControlledDataset =
        Namespaced_IRI.parse _namespace_name "VersionControlledDataset" |> NamespacedName

    /// <summary>
    /// The base URI used in constructing identifying URIs for instances in the converted dataset.
    /// <see href="http://purl.org/twc/vocab/conversion/base_uri"></see></summary>
    let base_uri = Namespaced_IRI.parse _namespace_name "base_uri" |> NamespacedName
    /// <summary>
    /// A comment (like rdfs:comment) that will be applied to the property created during conversion.
    /// <see href="http://purl.org/twc/vocab/conversion/comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/conceptual_depth"></see>
    /// </summary>
    let conceptual_depth =
        Namespaced_IRI.parse _namespace_name "conceptual_depth" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/conversion_identifier"></see>
    /// </summary>
    let conversion_identifier =
        Namespaced_IRI.parse _namespace_name "conversion_identifier" |> NamespacedName

    /// <summary>
    /// A conversion process that led to the creation or modification of an RDF dataset.
    /// <see href="http://purl.org/twc/vocab/conversion/conversion_process"></see></summary>
    let conversion_process =
        Namespaced_IRI.parse _namespace_name "conversion_process" |> NamespacedName

    /// <summary>
    /// The URL of a dataset document.
    /// <see href="http://purl.org/twc/vocab/conversion/dataset_file"></see></summary>
    let dataset_file =
        Namespaced_IRI.parse _namespace_name "dataset_file" |> NamespacedName

    /// <summary>
    /// The identifier of the dataset being converted. Ideally provided by source_identifier.
    /// <see href="http://purl.org/twc/vocab/conversion/dataset_identifier"></see></summary>
    let dataset_identifier =
        Namespaced_IRI.parse _namespace_name "dataset_identifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/dataset_version"></see>
    /// </summary>
    let dataset_version =
        Namespaced_IRI.parse _namespace_name "dataset_version" |> NamespacedName

    /// <summary>
    /// The version_identifier should only change during a 'raw' conversion when the underlying dataset has changed.
    /// The version of conversion being performed per dataset.
    /// <see href="http://purl.org/twc/vocab/conversion/version_identifier"></see></summary>
    let version_identifier =
        Namespaced_IRI.parse _namespace_name "version_identifier" |> NamespacedName

    /// <summary>
    /// The delimiter that should be used to separate cells in a row.
    /// <see href="http://purl.org/twc/vocab/conversion/delimits_cell"></see></summary>
    let delimits_cell =
        Namespaced_IRI.parse _namespace_name "delimits_cell" |> NamespacedName

    /// <summary>
    /// A regular expression specifiying how the object literal should be delimited to produce multiple object values.
    /// <see href="http://purl.org/twc/vocab/conversion/delimits_object"></see></summary>
    let delimits_object =
        Namespaced_IRI.parse _namespace_name "delimits_object" |> NamespacedName

    /// <summary>
    /// TODO, cannot happen: :cp a conversion:EnhancementConversionProcess; conversion:enhance [ ov:csvCol 1; conversion:domain_template 'a' ], [ ov:csvCol 2; conversion:domain_template 'b' ] (col 1 and col 2 make the enhancements distinct, and an EnhancementConversionProcess can only have one domain_templated enhancement.)
    /// Template to name the subject of the triple produced.
    /// <see href="http://purl.org/twc/vocab/conversion/domain_template"></see></summary>
    let domain_template =
        Namespaced_IRI.parse _namespace_name "domain_template" |> NamespacedName

    /// <summary>
    /// Example value from a cell in the column for this ColumnEnhancement.
    /// <see href="http://purl.org/twc/vocab/conversion/eg"></see></summary>
    let eg = Namespaced_IRI.parse _namespace_name "eg" |> NamespacedName
    /// <summary>
    /// The character encoding of a dataset document.
    /// <see href="http://purl.org/twc/vocab/conversion/encoding"></see></summary>
    let encoding = Namespaced_IRI.parse _namespace_name "encoding" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/enhancement_layer"></see>
    /// </summary>
    let enhancement_layer =
        Namespaced_IRI.parse _namespace_name "enhancement_layer" |> NamespacedName

    /// <summary>
    /// Used to describe terms from enhanced datasets, to refer to analogous terms from less enhanced datasets
    /// <see href="http://purl.org/twc/vocab/conversion/enhances"></see></summary>
    let enhances = Namespaced_IRI.parse _namespace_name "enhances" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/equivalent_property"></see>
    /// </summary>
    let equivalent_property =
        Namespaced_IRI.parse _namespace_name "equivalent_property" |> NamespacedName

    /// <summary>
    /// A human-friendly label (like rdfs:label) that will be used to create the property local name when creating the property URI. The exact value of conversion:label will also be used for the rdfs:label of the property created.
    /// <see href="http://purl.org/twc/vocab/conversion/label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/name_template"></see>
    /// </summary>
    let name_template =
        Namespaced_IRI.parse _namespace_name "name_template" |> NamespacedName

    /// <summary>
    /// Number of docs/logs/* captured by convert-aggregate.sh
    /// <see href="http://purl.org/twc/vocab/conversion/num_invocation_logs"></see></summary>
    let num_invocation_logs =
        Namespaced_IRI.parse _namespace_name "num_invocation_logs" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/num_triples"></see>
    /// </summary>
    let num_triples =
        Namespaced_IRI.parse _namespace_name "num_triples" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/object"></see>
    /// </summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/predicate"></see>
    /// </summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/object_search"></see>
    /// </summary>
    let object_search =
        Namespaced_IRI.parse _namespace_name "object_search" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/pattern"></see>
    /// </summary>
    let pattern = Namespaced_IRI.parse _namespace_name "pattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/range_template"></see>
    /// </summary>
    let range_template =
        Namespaced_IRI.parse _namespace_name "range_template" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/regex"></see>
    /// </summary>
    let regex = Namespaced_IRI.parse _namespace_name "regex" |> NamespacedName

    /// <summary>
    /// The source of data for a conversion process.
    /// <see href="http://purl.org/twc/vocab/conversion/source_data"></see></summary>
    let source_data =
        Namespaced_IRI.parse _namespace_name "source_data" |> NamespacedName

    /// <summary>
    /// The name of the organization to which the dataset being converted belongs.
    /// <see href="http://purl.org/twc/vocab/conversion/source_identifier"></see></summary>
    let source_identifier =
        Namespaced_IRI.parse _namespace_name "source_identifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/subject_discriminator"></see>
    /// </summary>
    let subject_discriminator =
        Namespaced_IRI.parse _namespace_name "subject_discriminator" |> NamespacedName

    /// <summary>
    /// A transitive version of void:subset
    /// <see href="http://purl.org/twc/vocab/conversion/subseT"></see></summary>
    let subseT = Namespaced_IRI.parse _namespace_name "subseT" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/todo"></see>
    /// </summary>
    let todo = Namespaced_IRI.parse _namespace_name "todo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/triples_per_minute"></see>
    /// </summary>
    let triples_per_minute =
        Namespaced_IRI.parse _namespace_name "triples_per_minute" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/uses_class"></see>
    /// </summary>
    let uses_class = Namespaced_IRI.parse _namespace_name "uses_class" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/vocab/conversion/uses_predicate"></see>
    /// </summary>
    let uses_predicate =
        Namespaced_IRI.parse _namespace_name "uses_predicate" |> NamespacedName
