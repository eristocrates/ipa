namespace https.w3id.org.linkml.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module linkml =
    let _namespace_iri = Namespace_Iri linkml |> NamespaceIRI
    /// <summary>
    ///   <para>linkml:meaning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/meaning">https://w3id.org/linkml/meaning</seealso>
    let meaning = Prefixed_Name(linkml, "meaning") |> PrefixedName
    /// <summary>
    ///   <para>linkml:class_uri</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/class_uri">https://w3id.org/linkml/class_uri</seealso>
    let class_uri = Prefixed_Name(linkml, "class_uri") |> PrefixedName
    /// <summary>
    ///   <para>linkml:definition_uri</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/definition_uri">https://w3id.org/linkml/definition_uri</seealso>
    let definition_uri = Prefixed_Name(linkml, "definition_uri") |> PrefixedName
    /// <summary>
    ///   <para>linkml:description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/description">https://w3id.org/linkml/description</seealso>
    let description = Prefixed_Name(linkml, "description") |> PrefixedName
    /// <summary>
    ///   <para>linkml:slots</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/slots">https://w3id.org/linkml/slots</seealso>
    let slots = Prefixed_Name(linkml, "slots") |> PrefixedName
    /// <summary>
    ///   <para>linkml:ValidationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/ValidationResult">https://w3id.org/linkml/ValidationResult</seealso>
    let ValidationResult = Prefixed_Name(linkml, "ValidationResult") |> PrefixedName
    /// <summary>
    ///   <para>linkml:info</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/info">https://w3id.org/linkml/info</seealso>
    let info = Prefixed_Name(linkml, "info") |> PrefixedName
    /// <summary>
    ///   <para>linkml:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/object">https://w3id.org/linkml/object</seealso>
    let object = Prefixed_Name(linkml, "object") |> PrefixedName
    /// <summary>
    ///   <para>linkml:object_str</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/object_str">https://w3id.org/linkml/object_str</seealso>
    let object_str = Prefixed_Name(linkml, "object_str") |> PrefixedName
    /// <summary>
    ///   <para>linkml:WARNING</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/WARNING">https://w3id.org/linkml/WARNING</seealso>
    let WARNING = Prefixed_Name(linkml, "WARNING") |> PrefixedName
    /// <summary>
    ///   <para>linkml:imported_from</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/imported_from">https://w3id.org/linkml/imported_from</seealso>
    let imported_from = Prefixed_Name(linkml, "imported_from") |> PrefixedName
    /// <summary>
    ///   <para>linkml:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/uri">https://w3id.org/linkml/uri</seealso>
    let uri = Prefixed_Name(linkml, "uri") |> PrefixedName
    /// <summary>
    ///   <para>linkml:classes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/classes">https://w3id.org/linkml/classes</seealso>
    let classes = Prefixed_Name(linkml, "classes") |> PrefixedName
    /// <summary>
    ///   <para>linkml:default_curi_maps</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/default_curi_maps">https://w3id.org/linkml/default_curi_maps</seealso>
    let default_curi_maps = Prefixed_Name(linkml, "default_curi_maps") |> PrefixedName
    /// <summary>
    ///   <para>linkml:default_prefix</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/default_prefix">https://w3id.org/linkml/default_prefix</seealso>
    let default_prefix = Prefixed_Name(linkml, "default_prefix") |> PrefixedName
    /// <summary>
    ///   <para>linkml:emit_prefixes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/emit_prefixes">https://w3id.org/linkml/emit_prefixes</seealso>
    let emit_prefixes = Prefixed_Name(linkml, "emit_prefixes") |> PrefixedName
    /// <summary>
    ///   <para>linkml:id</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/id">https://w3id.org/linkml/id</seealso>
    let id = Prefixed_Name(linkml, "id") |> PrefixedName
    /// <summary>
    ///   <para>linkml:imports</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/imports">https://w3id.org/linkml/imports</seealso>
    let imports = Prefixed_Name(linkml, "imports") |> PrefixedName
    /// <summary>
    ///   <para>linkml:metamodel_version</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/metamodel_version">https://w3id.org/linkml/metamodel_version</seealso>
    let metamodel_version = Prefixed_Name(linkml, "metamodel_version") |> PrefixedName
    /// <summary>
    ///   <para>linkml:source_file_size</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/source_file_size">https://w3id.org/linkml/source_file_size</seealso>
    let source_file_size = Prefixed_Name(linkml, "source_file_size") |> PrefixedName
    /// <summary>
    ///   <para>linkml:types</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/types">https://w3id.org/linkml/types</seealso>
    let types = Prefixed_Name(linkml, "types") |> PrefixedName
    /// <summary>
    ///   <para>linkml:sparqlpath</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/sparqlpath">https://w3id.org/linkml/sparqlpath</seealso>
    let sparqlpath = Prefixed_Name(linkml, "sparqlpath") |> PrefixedName
    /// <summary>
    ///   <para>linkml:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/time">https://w3id.org/linkml/time</seealso>
    let time = Prefixed_Name(linkml, "time") |> PrefixedName
    /// <summary>
    ///   <para>linkml:uriorcurie</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/uriorcurie">https://w3id.org/linkml/uriorcurie</seealso>
    let uriorcurie = Prefixed_Name(linkml, "uriorcurie") |> PrefixedName
    /// <summary>
    ///   <para>linkml:multivalued</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/multivalued">https://w3id.org/linkml/multivalued</seealso>
    let multivalued = Prefixed_Name(linkml, "multivalued") |> PrefixedName
    /// <summary>
    ///   <para>linkml:FATAL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/FATAL">https://w3id.org/linkml/FATAL</seealso>
    let FATAL = Prefixed_Name(linkml, "FATAL") |> PrefixedName
    /// <summary>
    ///   <para>linkml:inlined</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/inlined">https://w3id.org/linkml/inlined</seealso>
    let inlined = Prefixed_Name(linkml, "inlined") |> PrefixedName
    /// <summary>
    ///   <para>linkml:inlined_as_list</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/inlined_as_list">https://w3id.org/linkml/inlined_as_list</seealso>
    let inlined_as_list = Prefixed_Name(linkml, "inlined_as_list") |> PrefixedName
    /// <summary>
    ///   <para>linkml:INFO</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/INFO">https://w3id.org/linkml/INFO</seealso>
    let INFO = Prefixed_Name(linkml, "INFO") |> PrefixedName
    /// <summary>
    ///   <para>linkml:ValidationReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/ClassDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/ValidationReport">https://w3id.org/linkml/ValidationReport</seealso>
    let ValidationReport = Prefixed_Name(linkml, "ValidationReport") |> PrefixedName
    /// <summary>
    ///   <para>linkml:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/subject">https://w3id.org/linkml/subject</seealso>
    let subject = Prefixed_Name(linkml, "subject") |> PrefixedName
    /// <summary>
    ///   <para>linkml:ClassDefinition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/ClassDefinition">https://w3id.org/linkml/ClassDefinition</seealso>
    let ClassDefinition = Prefixed_Name(linkml, "ClassDefinition") |> PrefixedName
    /// <summary>
    ///   <para>linkml:attributes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/attributes">https://w3id.org/linkml/attributes</seealso>
    let attributes = Prefixed_Name(linkml, "attributes") |> PrefixedName
    /// <summary>
    ///   <para>linkml:slot_usage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_usage">https://w3id.org/linkml/slot_usage</seealso>
    let slot_usage = Prefixed_Name(linkml, "slot_usage") |> PrefixedName
    /// <summary>
    ///   <para>linkml:instantiates</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/instantiates">https://w3id.org/linkml/instantiates</seealso>
    let instantiates = Prefixed_Name(linkml, "instantiates") |> PrefixedName
    /// <summary>
    ///   <para>linkml:node_source</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/node_source">https://w3id.org/linkml/node_source</seealso>
    let node_source = Prefixed_Name(linkml, "node_source") |> PrefixedName
    /// <summary>
    ///   <para>linkml:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/predicate">https://w3id.org/linkml/predicate</seealso>
    let predicate = Prefixed_Name(linkml, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>linkml:severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/severity">https://w3id.org/linkml/severity</seealso>
    let severity = Prefixed_Name(linkml, "severity") |> PrefixedName
    /// <summary>
    ///   <para>linkml:boolean</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/boolean">https://w3id.org/linkml/boolean</seealso>
    let boolean = Prefixed_Name(linkml, "boolean") |> PrefixedName
    /// <summary>
    ///   <para>linkml:TypeDefinition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/TypeDefinition">https://w3id.org/linkml/TypeDefinition</seealso>
    let TypeDefinition = Prefixed_Name(linkml, "TypeDefinition") |> PrefixedName
    /// <summary>
    ///   <para>linkml:base</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/base">https://w3id.org/linkml/base</seealso>
    let base_ = Prefixed_Name(linkml, "base") |> PrefixedName
    /// <summary>
    ///   <para>linkml:results</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/results">https://w3id.org/linkml/results</seealso>
    let results = Prefixed_Name(linkml, "results") |> PrefixedName
    /// <summary>
    ///   <para>linkml:todos</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/todos">https://w3id.org/linkml/todos</seealso>
    let todos = Prefixed_Name(linkml, "todos") |> PrefixedName
    /// <summary>
    ///   <para>linkml:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/type">https://w3id.org/linkml/type</seealso>
    let type_ = Prefixed_Name(linkml, "type") |> PrefixedName
    /// <summary>
    ///   <para>linkml:repr</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/repr">https://w3id.org/linkml/repr</seealso>
    let repr = Prefixed_Name(linkml, "repr") |> PrefixedName

    /// <summary>
    ///   <para>linkml:slot_range_violation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_range_violation">https://w3id.org/linkml/slot_range_violation</seealso>
    let slot_range_violation =
        Prefixed_Name(linkml, "slot_range_violation") |> PrefixedName

    /// <summary>
    ///   <para>linkml:default_range</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/default_range">https://w3id.org/linkml/default_range</seealso>
    let default_range = Prefixed_Name(linkml, "default_range") |> PrefixedName
    /// <summary>
    ///   <para>linkml:enums</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/enums">https://w3id.org/linkml/enums</seealso>
    let enums = Prefixed_Name(linkml, "enums") |> PrefixedName
    /// <summary>
    ///   <para>linkml:generation_date</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/generation_date">https://w3id.org/linkml/generation_date</seealso>
    let generation_date = Prefixed_Name(linkml, "generation_date") |> PrefixedName
    /// <summary>
    ///   <para>linkml:source_file</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/source_file">https://w3id.org/linkml/source_file</seealso>
    let source_file = Prefixed_Name(linkml, "source_file") |> PrefixedName
    /// <summary>
    ///   <para>linkml:curie</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/curie">https://w3id.org/linkml/curie</seealso>
    let curie = Prefixed_Name(linkml, "curie") |> PrefixedName
    /// <summary>
    ///   <para>linkml:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/date">https://w3id.org/linkml/date</seealso>
    let date = Prefixed_Name(linkml, "date") |> PrefixedName
    /// <summary>
    ///   <para>linkml:severity_options</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/severity_options">https://w3id.org/linkml/severity_options</seealso>
    let severity_options = Prefixed_Name(linkml, "severity_options") |> PrefixedName
    /// <summary>
    ///   <para>linkml:source_file_date</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/source_file_date">https://w3id.org/linkml/source_file_date</seealso>
    let source_file_date = Prefixed_Name(linkml, "source_file_date") |> PrefixedName
    /// <summary>
    ///   <para>linkml:date_or_datetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/date_or_datetime">https://w3id.org/linkml/date_or_datetime</seealso>
    let date_or_datetime = Prefixed_Name(linkml, "date_or_datetime") |> PrefixedName
    /// <summary>
    ///   <para>linkml:datetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/datetime">https://w3id.org/linkml/datetime</seealso>
    let datetime = Prefixed_Name(linkml, "datetime") |> PrefixedName
    /// <summary>
    ///   <para>linkml:decimal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/decimal">https://w3id.org/linkml/decimal</seealso>
    let decimal = Prefixed_Name(linkml, "decimal") |> PrefixedName
    /// <summary>
    ///   <para>linkml:double</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/double">https://w3id.org/linkml/double</seealso>
    let double = Prefixed_Name(linkml, "double") |> PrefixedName
    /// <summary>
    ///   <para>linkml:SlotDefinition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/SlotDefinition">https://w3id.org/linkml/SlotDefinition</seealso>
    let SlotDefinition = Prefixed_Name(linkml, "SlotDefinition") |> PrefixedName
    /// <summary>
    ///   <para>linkml:owner</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/owner">https://w3id.org/linkml/owner</seealso>
    let owner = Prefixed_Name(linkml, "owner") |> PrefixedName
    /// <summary>
    ///   <para>linkml:slot_uri</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/slot_uri">https://w3id.org/linkml/slot_uri</seealso>
    let slot_uri = Prefixed_Name(linkml, "slot_uri") |> PrefixedName
    /// <summary>
    ///   <para>linkml:integer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/integer">https://w3id.org/linkml/integer</seealso>
    let integer = Prefixed_Name(linkml, "integer") |> PrefixedName
    /// <summary>
    ///   <para>linkml:jsonpath</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/jsonpath">https://w3id.org/linkml/jsonpath</seealso>
    let jsonpath = Prefixed_Name(linkml, "jsonpath") |> PrefixedName
    /// <summary>
    ///   <para>linkml:jsonpointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/jsonpointer">https://w3id.org/linkml/jsonpointer</seealso>
    let jsonpointer = Prefixed_Name(linkml, "jsonpointer") |> PrefixedName
    /// <summary>
    ///   <para>linkml:domain_of</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/domain_of">https://w3id.org/linkml/domain_of</seealso>
    let domain_of = Prefixed_Name(linkml, "domain_of") |> PrefixedName
    /// <summary>
    ///   <para>linkml:string</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/string">https://w3id.org/linkml/string</seealso>
    let string = Prefixed_Name(linkml, "string") |> PrefixedName
    /// <summary>
    ///   <para>linkml:ncname</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/ncname">https://w3id.org/linkml/ncname</seealso>
    let ncname = Prefixed_Name(linkml, "ncname") |> PrefixedName
    /// <summary>
    ///   <para>linkml:objectidentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/objectidentifier">https://w3id.org/linkml/objectidentifier</seealso>
    let objectidentifier = Prefixed_Name(linkml, "objectidentifier") |> PrefixedName
    /// <summary>
    ///   <para>linkml:parsing_error</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/parsing_error">https://w3id.org/linkml/parsing_error</seealso>
    let parsing_error = Prefixed_Name(linkml, "parsing_error") |> PrefixedName
    /// <summary>
    ///   <para>linkml:problem_type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/problem_type">https://w3id.org/linkml/problem_type</seealso>
    let problem_type = Prefixed_Name(linkml, "problem_type") |> PrefixedName
    /// <summary>
    ///   <para>linkml:permissible_values</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/permissible_values">https://w3id.org/linkml/permissible_values</seealso>
    let permissible_values = Prefixed_Name(linkml, "permissible_values") |> PrefixedName
    /// <summary>
    ///   <para>linkml:undeclared_slot</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/undeclared_slot">https://w3id.org/linkml/undeclared_slot</seealso>
    let undeclared_slot = Prefixed_Name(linkml, "undeclared_slot") |> PrefixedName
    /// <summary>
    ///   <para>linkml:reporting</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SchemaDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/reporting">https://w3id.org/linkml/reporting</seealso>
    let reporting = Prefixed_Name(linkml, "reporting") |> PrefixedName
    /// <summary>
    ///   <para>linkml:SchemaDefinition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/SchemaDefinition">https://w3id.org/linkml/SchemaDefinition</seealso>
    let SchemaDefinition = Prefixed_Name(linkml, "SchemaDefinition") |> PrefixedName
    /// <summary>
    ///   <para>linkml:ERROR</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/ERROR">https://w3id.org/linkml/ERROR</seealso>
    let ERROR = Prefixed_Name(linkml, "ERROR") |> PrefixedName

    /// <summary>
    ///   <para>linkml:validationReport__results</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/SlotDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/validationReport__results">https://w3id.org/linkml/validationReport__results</seealso>
    let validationReport__results =
        Prefixed_Name(linkml, "validationReport__results") |> PrefixedName

    /// <summary>
    ///   <para>linkml:float</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/float">https://w3id.org/linkml/float</seealso>
    let float = Prefixed_Name(linkml, "float") |> PrefixedName
    /// <summary>
    ///   <para>linkml:inapplicable_slot</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/inapplicable_slot">https://w3id.org/linkml/inapplicable_slot</seealso>
    let inapplicable_slot = Prefixed_Name(linkml, "inapplicable_slot") |> PrefixedName
    /// <summary>
    ///   <para>linkml:range</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/range">https://w3id.org/linkml/range</seealso>
    let range = Prefixed_Name(linkml, "range") |> PrefixedName
    /// <summary>
    ///   <para>linkml:nodeidentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:linkml/TypeDefinition</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/linkml/nodeidentifier">https://w3id.org/linkml/nodeidentifier</seealso>
    let nodeidentifier = Prefixed_Name(linkml, "nodeidentifier") |> PrefixedName

    /// <summary>
    ///   <para>linkml:max_count_violation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/max_count_violation">https://w3id.org/linkml/max_count_violation</seealso>
    let max_count_violation =
        Prefixed_Name(linkml, "max_count_violation") |> PrefixedName

    /// <summary>
    ///   <para>linkml:missing_slot_value</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/linkml/missing_slot_value">https://w3id.org/linkml/missing_slot_value</seealso>
    let missing_slot_value = Prefixed_Name(linkml, "missing_slot_value") |> PrefixedName
