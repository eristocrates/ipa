#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module linkml =

    let _prefix = prefix_label "linkml"


    let ABSENT = _prefix "ABSENT"



    let AClassDefinition = _prefix "AClassDefinition"



    let AliasPredicateEnum = _prefix "AliasPredicateEnum"



    let AltDescription = _prefix "AltDescription"



    let Annotatable = _prefix "Annotatable"



    let Annotation = _prefix "Annotation"



    let AnonymousClassExpression = _prefix "AnonymousClassExpression"



    let AnonymousEnumExpression = _prefix "AnonymousEnumExpression"



    let AnonymousExpression = _prefix "AnonymousExpression"



    let AnonymousSlotExpression = _prefix "AnonymousSlotExpression"



    let AnonymousTypeExpression = _prefix "AnonymousTypeExpression"



    let Any = _prefix "Any"



    let AnyValue = _prefix "AnyValue"



    let Anything = _prefix "Anything"



    let ArrayExpression = _prefix "ArrayExpression"



    let BROAD_SYNONYM = _prefix "BROAD_SYNONYM"



    let BasicSubset = _prefix "BasicSubset"



    let Boolean = _prefix "Boolean"



    let CODE = _prefix "CODE"



    let CURIE = _prefix "CURIE"



    let ClassDefinition = _prefix "ClassDefinition"



    let ClassExpression = _prefix "ClassExpression"



    let ClassLevelRule = _prefix "ClassLevelRule"



    let ClassRule = _prefix "ClassRule"



    let CommonMetadata = _prefix "CommonMetadata"



    let CounterExample = _prefix "CounterExample"



    let DISCOURAGED = _prefix "DISCOURAGED"



    let DataPackage = _prefix "DataPackage"



    let DataResource = _prefix "DataResource"



    let Datetime = _prefix "Datetime"



    let Definition = _prefix "Definition"



    let DimensionExpression = _prefix "DimensionExpression"



    let ERROR = _prefix "ERROR"



    let EXACT_SYNONYM = _prefix "EXACT_SYNONYM"



    let EXAMPLE = _prefix "EXAMPLE"



    let Element = _prefix "Element"



    let EnumBinding = _prefix "EnumBinding"



    let EnumDefinition = _prefix "EnumDefinition"



    let EnumExpression = _prefix "EnumExpression"



    let Example = _prefix "Example"



    let Expression = _prefix "Expression"



    let Extensible = _prefix "Extensible"



    let Extension = _prefix "Extension"



    let ExtraSlotsExpression = _prefix "ExtraSlotsExpression"



    let FATAL = _prefix "FATAL"



    let FHIR_CODING = _prefix "FHIR_CODING"



    let FormatDialect = _prefix "FormatDialect"



    let FormatEnum = _prefix "FormatEnum"



    let INFO = _prefix "INFO"



    let ImportExpression = _prefix "ImportExpression"



    let Information = _prefix "Information"



    let Integer = _prefix "Integer"



    let JSON = _prefix "JSON"



    let JSON_LD = _prefix "JSON-LD"



    let LABEL = _prefix "LABEL"



    let LD_Patch = _prefix "LD%20Patch"



    let LocalName = _prefix "LocalName"



    let MatchQuery = _prefix "MatchQuery"



    let MediaTypeEnum = _prefix "MediaTypeEnum"



    let Microdata = _prefix "Microdata"



    let MinimalSubset = _prefix "MinimalSubset"



    let N3 = _prefix "N3"



    let NARROW_SYNONYM = _prefix "NARROW_SYNONYM"



    let NODE = _prefix "NODE"



    let N_Quads = _prefix "N-Quads"



    let N_Triples = _prefix "N-Triples"



    let Ncname = _prefix "Ncname"



    let OBJECT = _prefix "OBJECT"



    let OPTIONAL = _prefix "OPTIONAL"



    let OTHER_ROLE = _prefix "OTHER_ROLE"



    let OWL_Functional_Syntax = _prefix "OWL%20Functional%20Syntax"



    let OWL_Manchester_Syntax = _prefix "OWL%20Manchester%20Syntax"



    let OWL_XML_Serialization = _prefix "OWL%20XML%20Serialization"



    let ObjectOrientedProfile = _prefix "ObjectOrientedProfile"



    let ObligationLevelEnum = _prefix "ObligationLevelEnum"



    let ObligationLevelEnum_DISCOURAGED = _prefix "ObligationLevelEnum#DISCOURAGED"



    let ObligationLevelEnum_EXAMPLE = _prefix "ObligationLevelEnum#EXAMPLE"



    let ObligationLevelEnum_OPTIONAL = _prefix "ObligationLevelEnum#OPTIONAL"



    let ObligationLevelEnum_RECOMMENDED = _prefix "ObligationLevelEnum#RECOMMENDED"



    let ObligationLevelEnum_REQUIRED = _prefix "ObligationLevelEnum#REQUIRED"



    let OwlProfile = _prefix "OwlProfile"



    let POWDER = _prefix "POWDER"



    let POWDER_S = _prefix "POWDER-S"



    let PREDICATE = _prefix "PREDICATE"



    let PRESENT = _prefix "PRESENT"



    let PROV_N = _prefix "PROV-N"



    let PROV_XML = _prefix "PROV-XML"



    let PathExpression = _prefix "PathExpression"



    let PatternExpression = _prefix "PatternExpression"



    let PermissibleValue = _prefix "PermissibleValue"



    let Prefix = _prefix "Prefix"



    let PresenceEnum = _prefix "PresenceEnum"



    let PresenceEnum_ABSENT = _prefix "PresenceEnum#ABSENT"



    let PresenceEnum_PRESENT = _prefix "PresenceEnum#PRESENT"



    let PresenceEnum_UNCOMMITTED = _prefix "PresenceEnum#UNCOMMITTED"



    let PvFormulaOptions = _prefix "PvFormulaOptions"



    let PvFormulaOptions_CODE = _prefix "PvFormulaOptions#CODE"



    let PvFormulaOptions_CURIE = _prefix "PvFormulaOptions#CURIE"



    let PvFormulaOptions_FHIR_CODING = _prefix "PvFormulaOptions#FHIR_CODING"



    let PvFormulaOptions_LABEL = _prefix "PvFormulaOptions#LABEL"



    let PvFormulaOptions_URI = _prefix "PvFormulaOptions#URI"



    let RDF_JSON = _prefix "RDF/JSON"



    let RDF_XML = _prefix "RDF/XML"



    let RDFa = _prefix "RDFa"



    let RECOMMENDED = _prefix "RECOMMENDED"



    let RELATED_SYNONYM = _prefix "RELATED_SYNONYM"



    let REQUIRED = _prefix "REQUIRED"



    let RIF_XML_Syntax = _prefix "RIF%20XML%20Syntax"



    let ReachabilityQuery = _prefix "ReachabilityQuery"



    let RelationalModelProfile = _prefix "RelationalModelProfile"



    let RelationalRoleEnum = _prefix "RelationalRoleEnum"



    let RelationalRoleEnum_NODE = _prefix "RelationalRoleEnum#NODE"



    let RelationalRoleEnum_OTHER_ROLE = _prefix "RelationalRoleEnum#OTHER_ROLE"



    let SPARQL_Results_in_CSV = _prefix "SPARQL%20Results%20in%20CSV"



    let SPARQL_Results_in_JSON = _prefix "SPARQL%20Results%20in%20JSON"



    let SPARQL_Results_in_TSV = _prefix "SPARQL%20Results%20in%20TSV"



    let SPARQL_Results_in_XML = _prefix "SPARQL%20Results%20in%20XML"



    let SUBJECT = _prefix "SUBJECT"



    let SchemaDefinition = _prefix "SchemaDefinition"



    let Setting = _prefix "Setting"



    let SlotDefinition = _prefix "SlotDefinition"



    let SlotExpression = _prefix "SlotExpression"



    let SpecificationSubset = _prefix "SpecificationSubset"



    let String = _prefix "String"



    let StructuredAlias = _prefix "StructuredAlias"



    let SubsetDefinition = _prefix "SubsetDefinition"



    let TestRole = _prefix "TestRole"



    let TriG = _prefix "TriG"



    let Turtle = _prefix "Turtle"



    let TypeDefinition = _prefix "TypeDefinition"



    let TypeExpression = _prefix "TypeExpression"



    let TypeMapping = _prefix "TypeMapping"



    let UNCOMMITTED = _prefix "UNCOMMITTED"



    let URI = _prefix "URI"



    let UniqueKey = _prefix "UniqueKey"



    let UnitOfMeasure = _prefix "UnitOfMeasure"



    let UnitOfMeasure_exact_mappings = _prefix "UnitOfMeasure_exact_mappings"



    let Uri = _prefix "Uri"



    let Uriorcurie = _prefix "Uriorcurie"



    let ValidationReport = _prefix "ValidationReport"



    let ValidationResult = _prefix "ValidationResult"



    let WARNING = _prefix "WARNING"



    let YAML = _prefix "YAML"



    let abbreviation = _prefix "abbreviation"



    let ``abstract`` = _prefix "abstract"



    let alias = _prefix "alias"



    let alias_contexts = _prefix "alias_contexts"



    let alias_predicate = _prefix "alias_predicate"



    let alias_predicate_enum = _prefix "alias_predicate_enum"



    let aliases = _prefix "aliases"



    let all_members = _prefix "all_members"



    let all_of = _prefix "all_of"



    let allowed = _prefix "allowed"



    let alt_description_source = _prefix "alt_description_source"



    let alt_description_text = _prefix "alt_description_text"



    let alt_descriptions = _prefix "alt_descriptions"



    let annotations = _prefix "annotations"



    let any_of = _prefix "any_of"



    let apply_to = _prefix "apply_to"



    let array = _prefix "array"



    let asymmetric = _prefix "asymmetric"



    let attributes = _prefix "attributes"



    let ``base`` = _prefix "base"



    let bidirectional = _prefix "bidirectional"



    let bindings = _prefix "bindings"



    let binds_value_of = _prefix "binds_value_of"



    let boolean = _prefix "boolean"



    let boolean_slot = _prefix "boolean_slot"



    let broad_mappings = _prefix "broad_mappings"



    let bytes = _prefix "bytes"



    let categories = _prefix "categories"



    let children_are_mutually_disjoint = _prefix "children_are_mutually_disjoint"



    let class_definition_apply_to = _prefix "class_definition_apply_to"



    let class_definition_disjoint_with = _prefix "class_definition_disjoint_with"



    let class_definition_is_a = _prefix "class_definition_is_a"



    let class_definition_mixins = _prefix "class_definition_mixins"



    let class_definition_rules = _prefix "class_definition_rules"



    let class_definition_union_of = _prefix "class_definition_union_of"



    let class_expression_all_of = _prefix "class_expression_all_of"



    let class_expression_any_of = _prefix "class_expression_any_of"



    let class_expression_exactly_one_of = _prefix "class_expression_exactly_one_of"



    let class_expression_none_of = _prefix "class_expression_none_of"



    let class_uri = _prefix "class_uri"



    let classes = _prefix "classes"



    let classification_rules = _prefix "classification_rules"



    let close_mappings = _prefix "close_mappings"



    let code_set = _prefix "code_set"



    let code_set_tag = _prefix "code_set_tag"



    let code_set_version = _prefix "code_set_version"



    let comment_prefix = _prefix "comment_prefix"



    let comments = _prefix "comments"



    let compression = _prefix "compression"



    let concepts = _prefix "concepts"



    let conforms_to = _prefix "conforms_to"



    let conforms_to_class = _prefix "conforms_to_class"



    let conforms_to_schema = _prefix "conforms_to_schema"



    let consider_nulls_inequal = _prefix "consider_nulls_inequal"



    let contributors = _prefix "contributors"



    let created_by = _prefix "created_by"



    let created_on = _prefix "created_on"



    let csv = _prefix "csv"



    let curie = _prefix "curie"



    let datasets = _prefix "datasets"



    let date = _prefix "date"



    let date_or_datetime = _prefix "date_or_datetime"



    let datetime = _prefix "datetime"



    let deactivated = _prefix "deactivated"



    let decimal = _prefix "decimal"



    let default_curi_maps = _prefix "default_curi_maps"



    let default_prefix = _prefix "default_prefix"



    let default_range = _prefix "default_range"



    let defining_slots = _prefix "defining_slots"



    let definition_uri = _prefix "definition_uri"



    let delimiter = _prefix "delimiter"



    let deprecated = _prefix "deprecated"



    let deprecated_element_has_exact_replacement =
        _prefix "deprecated_element_has_exact_replacement"



    let deprecated_element_has_possible_replacement =
        _prefix "deprecated_element_has_possible_replacement"



    let derivation = _prefix "derivation"



    let description = _prefix "description"



    let descriptive_name = _prefix "descriptive_name"



    let designates_type = _prefix "designates_type"



    let dialect = _prefix "dialect"



    let dimensions = _prefix "dimensions"



    let disjoint_with = _prefix "disjoint_with"

    module docs =
        module specificaton =
            module validation =
                let rules = _prefix "docs/specification/05validation/#rules"

            module mapping =
                let collection_forms = _prefix "docs/specification/06mapping/#collection-forms"









    let domain = _prefix "domain"



    let domain_of = _prefix "domain_of"



    let double = _prefix "double"



    let double_quote = _prefix "double_quote"



    let download_url = _prefix "download_url"



    let elseconditions = _prefix "elseconditions"



    let emit_prefixes = _prefix "emit_prefixes"



    let encoding = _prefix "encoding"



    let enum_binding_range = _prefix "enum_binding_range"



    let enum_range = _prefix "enum_range"



    let enum_uri = _prefix "enum_uri"



    let enums = _prefix "enums"



    let equals_expression = _prefix "equals_expression"



    let equals_number = _prefix "equals_number"



    let equals_number_in = _prefix "equals_number_in"



    let equals_string = _prefix "equals_string"



    let equals_string_in = _prefix "equals_string_in"



    let exact_cardinality = _prefix "exact_cardinality"



    let exact_mappings = _prefix "exact_mappings"



    let exact_number_dimensions = _prefix "exact_number_dimensions"



    let exactly_one_of = _prefix "exactly_one_of"



    let examples = _prefix "examples"



    let extension_tag = _prefix "extension_tag"



    let extension_value = _prefix "extension_value"



    let extensions = _prefix "extensions"



    let extra_slots = _prefix "extra_slots"



    let extra_slots_expression_range_expression =
        _prefix "extra_slots_expression_range_expression"



    let float = _prefix "float"



    let followed_by = _prefix "followed_by"



    let format = _prefix "format"



    let formatDialect__comment_prefix = _prefix "formatDialect__comment_prefix"



    let formatDialect__delimiter = _prefix "formatDialect__delimiter"



    let formatDialect__double_quote = _prefix "formatDialect__double_quote"



    let formatDialect__header = _prefix "formatDialect__header"



    let formatDialect__quote_char = _prefix "formatDialect__quote_char"



    let framework_key = _prefix "framework_key"



    let from_schema = _prefix "from_schema"



    let generation_date = _prefix "generation_date"



    let has_member = _prefix "has_member"



    let has_quantity_kind = _prefix "has_quantity_kind"



    let hash = _prefix "hash"



    let header = _prefix "header"



    let id = _prefix "id"



    let id_prefixes = _prefix "id_prefixes"



    let id_prefixes_are_closed = _prefix "id_prefixes_are_closed"



    let identifier = _prefix "identifier"



    let identifier_pattern = _prefix "identifier_pattern"



    let iec61360code = _prefix "iec61360code"



    let ifabsent = _prefix "ifabsent"



    let implements = _prefix "implements"



    let implicit_prefix = _prefix "implicit_prefix"



    let import_as = _prefix "import_as"



    let import_from = _prefix "import_from"



    let import_map = _prefix "import_map"



    let imported_from = _prefix "imported_from"



    let imports = _prefix "imports"



    let in_language = _prefix "in_language"



    let in_subset = _prefix "in_subset"



    let inapplicable = _prefix "inapplicable"



    let inapplicable_slot = _prefix "inapplicable_slot"



    let include = _prefix "include"



    let include_self = _prefix "include_self"



    let info = _prefix "info"



    let inherited = _prefix "inherited"



    let inherits = _prefix "inherits"



    let inlined = _prefix "inlined"



    let inlined_as_list = _prefix "inlined_as_list"



    let inlined_as_simple_dict = _prefix "inlined_as_simple_dict"



    let instantiates = _prefix "instantiates"



    let integer = _prefix "integer"



    let interpolated = _prefix "interpolated"



    let inverse = _prefix "inverse"



    let irreflexive = _prefix "irreflexive"



    let is_a = _prefix "is_a"



    let is_class_field = _prefix "is_class_field"



    let is_direct = _prefix "is_direct"



    let is_grouping_slot = _prefix "is_grouping_slot"



    let is_usage_slot = _prefix "is_usage_slot"



    let issued = _prefix "issued"



    let jsonpath = _prefix "jsonpath"



    let jsonpointer = _prefix "jsonpointer"



    let key = _prefix "key"



    let keywords = _prefix "keywords"



    let language = _prefix "language"



    let last_updated_on = _prefix "last_updated_on"



    let license = _prefix "license"



    let list_elements_ordered = _prefix "list_elements_ordered"



    let list_elements_unique = _prefix "list_elements_unique"



    let list_value_specification_constant = _prefix "list_value_specification_constant"



    let literal_form = _prefix "literal_form"



    let local_name_source = _prefix "local_name_source"



    let local_name_value = _prefix "local_name_value"



    let local_names = _prefix "local_names"



    let locally_reflexive = _prefix "locally_reflexive"



    let mapped_type = _prefix "mapped_type"



    let mappings = _prefix "mappings"



    let matches = _prefix "matches"



    let max_count_violation = _prefix "max_count_violation"



    let maximum_cardinality = _prefix "maximum_cardinality"



    let maximum_number_dimensions = _prefix "maximum_number_dimensions"



    let maximum_value = _prefix "maximum_value"



    let md5 = _prefix "md5"



    let meaning = _prefix "meaning"



    let media_type = _prefix "media_type"



    let meta = _prefix "meta"



    let metamodel_version = _prefix "metamodel_version"



    let minimum_cardinality = _prefix "minimum_cardinality"



    let minimum_number_dimensions = _prefix "minimum_number_dimensions"



    let minimum_value = _prefix "minimum_value"



    let minus = _prefix "minus"



    let missing_slot_value = _prefix "missing_slot_value"



    let mixin = _prefix "mixin"



    let mixins = _prefix "mixins"



    let modified_by = _prefix "modified_by"



    let multivalued = _prefix "multivalued"



    let name = _prefix "name"



    let narrow_mappings = _prefix "narrow_mappings"



    let ncname = _prefix "ncname"



    let node_source = _prefix "node_source"



    let nodeidentifier = _prefix "nodeidentifier"



    let none_of = _prefix "none_of"



    let notes = _prefix "notes"



    let object = _prefix "object"



    let object_str = _prefix "object_str"



    let objectidentifier = _prefix "objectidentifier"



    let obligation_level = _prefix "obligation_level"



    let obligation_level_enum = _prefix "obligation_level_enum"



    let open_world = _prefix "open_world"



    let owned_by = _prefix "owned_by"



    let owner = _prefix "owner"



    let page = _prefix "page"



    let parsing_error = _prefix "parsing_error"



    let partial_match = _prefix "partial_match"



    let path = _prefix "path"



    let path_expression_all_of = _prefix "path_expression_all_of"



    let path_expression_any_of = _prefix "path_expression_any_of"



    let path_expression_exactly_one_of = _prefix "path_expression_exactly_one_of"



    let path_expression_followed_by = _prefix "path_expression_followed_by"



    let path_expression_none_of = _prefix "path_expression_none_of"



    let path_rule = _prefix "path_rule"



    let pattern = _prefix "pattern"



    let permissible_value_is_a = _prefix "permissible_value_is_a"



    let permissible_value_mixins = _prefix "permissible_value_mixins"



    let permissible_values = _prefix "permissible_values"



    let postconditions = _prefix "postconditions"



    let preconditions = _prefix "preconditions"



    let predicate = _prefix "predicate"



    let prefix_prefix = _prefix "prefix_prefix"



    let prefix_reference = _prefix "prefix_reference"



    let prefixes = _prefix "prefixes"



    let presence_enum = _prefix "presence_enum"



    let problem_type = _prefix "problem_type"



    let profile = _prefix "profile"



    let publisher = _prefix "publisher"



    let pv_formula = _prefix "pv_formula"



    let pv_formula_options = _prefix "pv_formula_options"



    let quote_char = _prefix "quote_char"



    let range = _prefix "range"



    let range_expression = _prefix "range_expression"



    let rank = _prefix "rank"



    let rdf_xml = _prefix "rdf-xml"



    let reachable_from = _prefix "reachable_from"



    let readonly = _prefix "readonly"



    let recommended = _prefix "recommended"



    let reflexive = _prefix "reflexive"



    let reflexive_transitive_form_of = _prefix "reflexive_transitive_form_of"



    let related_mappings = _prefix "related_mappings"



    let relational_logical_characteristic = _prefix "relational_logical_characteristic"



    let relational_role = _prefix "relational_role"



    let relational_role_enum = _prefix "relational_role_enum"



    let relationship_types = _prefix "relationship_types"



    let reporting = _prefix "reporting"



    let repr = _prefix "repr"



    let represents_relationship = _prefix "represents_relationship"



    let required = _prefix "required"



    let resources = _prefix "resources"



    let results = _prefix "results"



    let reversed = _prefix "reversed"



    let role = _prefix "role"



    let rules = _prefix "rules"



    let schema_definition_name = _prefix "schema_definition_name"



    let see_also = _prefix "see_also"



    let setting_key = _prefix "setting_key"



    let setting_value = _prefix "setting_value"



    let settings = _prefix "settings"



    let severity = _prefix "severity"



    let severity_options = _prefix "severity_options"



    let sha256 = _prefix "sha256"



    let shared = _prefix "shared"



    let singular_name = _prefix "singular_name"



    let slot_conditions = _prefix "slot_conditions"



    let slot_definition_apply_to = _prefix "slot_definition_apply_to"



    let slot_definition_disjoint_with = _prefix "slot_definition_disjoint_with"



    let slot_definition_is_a = _prefix "slot_definition_is_a"



    let slot_definition_mixins = _prefix "slot_definition_mixins"



    let slot_definition_union_of = _prefix "slot_definition_union_of"



    let slot_definitions = _prefix "slot_definitions"



    let slot_expression_all_of = _prefix "slot_expression_all_of"



    let slot_expression_any_of = _prefix "slot_expression_any_of"



    let slot_expression_exactly_one_of = _prefix "slot_expression_exactly_one_of"



    let slot_expression_none_of = _prefix "slot_expression_none_of"



    let slot_group = _prefix "slot_group"



    let slot_names_unique = _prefix "slot_names_unique"



    let slot_range_violation = _prefix "slot_range_violation"



    let slot_uri = _prefix "slot_uri"



    let slot_usage = _prefix "slot_usage"



    let slots = _prefix "slots"



    let source = _prefix "source"



    let source_file = _prefix "source_file"



    let source_file_date = _prefix "source_file_date"



    let source_file_size = _prefix "source_file_size"



    let source_nodes = _prefix "source_nodes"



    let source_ontology = _prefix "source_ontology"



    let sparqlpath = _prefix "sparqlpath"



    let status = _prefix "status"



    let string = _prefix "string"



    let string_serialization = _prefix "string_serialization"



    let structured_alias_categories = _prefix "structured_alias_categories"



    let structured_aliases = _prefix "structured_aliases"



    let structured_imports = _prefix "structured_imports"



    let structured_pattern = _prefix "structured_pattern"



    let subclass_of = _prefix "subclass_of"



    let subject = _prefix "subject"



    let subproperty_of = _prefix "subproperty_of"



    let subsets = _prefix "subsets"



    let symbol = _prefix "symbol"



    let symmetric = _prefix "symmetric"



    let syntax = _prefix "syntax"



    let tag = _prefix "tag"



    let test_roles = _prefix "test_roles"



    let text = _prefix "text"



    let themes = _prefix "themes"



    let time = _prefix "time"



    let title = _prefix "title"



    let todos = _prefix "todos"



    let transitive = _prefix "transitive"



    let transitive_form_of = _prefix "transitive_form_of"



    let traverse = _prefix "traverse"



    let traverse_up = _prefix "traverse_up"



    let tree_root = _prefix "tree_root"



    let ``type`` = _prefix "type"



    let type_definition_union_of = _prefix "type_definition_union_of"



    let type_expression_all_of = _prefix "type_expression_all_of"



    let type_expression_any_of = _prefix "type_expression_any_of"



    let type_expression_exactly_one_of = _prefix "type_expression_exactly_one_of"



    let type_expression_none_of = _prefix "type_expression_none_of"



    let type_mappings = _prefix "type_mappings"



    let type_uri = _prefix "type_uri"



    let typeof = _prefix "typeof"



    let types = _prefix "types"



    let ucum_code = _prefix "ucum_code"



    let undeclared_slot = _prefix "undeclared_slot"



    let union_of = _prefix "union_of"



    let unique_key_name = _prefix "unique_key_name"



    let unique_key_slots = _prefix "unique_key_slots"



    let unique_keys = _prefix "unique_keys"



    let unit = _prefix "unit"



    let units = _prefix "units"



    let uri = _prefix "uri"



    let uriorcurie = _prefix "uriorcurie"



    let usage_slot_name = _prefix "usage_slot_name"



    let validationReport__results = _prefix "validationReport__results"



    let value = _prefix "value"



    let value_description = _prefix "value_description"



    let value_object = _prefix "value_object"



    let value_presence = _prefix "value_presence"



    let value_specification_constant = _prefix "value_specification_constant"



    let values_from = _prefix "values_from"



    let version = _prefix "version"



    let was_derived_from = _prefix "was_derived_from"
