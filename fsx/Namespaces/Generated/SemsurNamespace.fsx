#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module semsur =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/SemSur/" "semsur"
    let _namespaceIri = _prefixId.prefix ""
    let _2'_period_'0 = _prefixId.prefix "2.0"

    let ``ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints`` = _prefixId.prefix "ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints"

    let ``ANAPSID:_evaluation`` = _prefixId.prefix "ANAPSID:_evaluation"

    let ``AgreementMaker:_Ecient_Matching_for_Large_Real_World_Schemas_and_Ontologies`` =
        _prefixId.prefix "AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies"

    let ``Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey`` = _prefixId.prefix "Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey"

    let ``Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey`` = _prefixId.prefix "Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey"

    let Connor = _prefixId.prefix "Connor"

    let ``Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases`` = _prefixId.prefix "Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases"

    let ``D2RQ_%E2%80%93_Treating_Non_RDF_Databases_as_Virtual_RDF_Graphs`` = _prefixId.prefix "D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs"

    let ``FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data`` =
        _prefixId.prefix "FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data"

    let ICDT_Workshops = _prefixId.prefix "ICDT_Workshops"

    let ``KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion`` = _prefixId.prefix "KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion"

    let ``Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery`` = _prefixId.prefix "Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery"

    let ``LogMap:Logic_based_and_Scalable_Ontology_Matching`` = _prefixId.prefix "LogMap:Logic-based_and_Scalable_Ontology_Matching"

    let ``Martin_O%E2%80%99Connor`` = _prefixId.prefix "Martin_O%E2%80%99Connor"

    let ``OWLED_Workshop_on_OWL:_Experiences_and_Directions`` = _prefixId.prefix "OWLED_Workshop_on_OWL:_Experiences_and_Directions"

    let ``Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey`` =
        _prefixId.prefix "Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey"

    let ``RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems`` =
        _prefixId.prefix "RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems"

    let ``SERIMI___Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking'_period_'`` =
        _prefixId.prefix "SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking."

    let ``SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions`` = _prefixId.prefix "SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions"

    let ``The_Semantic_Web:_Research_and_Applications`` = _prefixId.prefix "The_Semantic_Web:_Research_and_Applications"

    let ``Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web`` =
        _prefixId.prefix "Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web"

    let _A_Schema_Independent_Linked_Data_Interlinking_System = _prefixId.prefix "_A_Schema-Independent_Linked_Data_Interlinking_System"

    let _A_Survey_of_Approaches_and_Evaluation_Methods = _prefixId.prefix "_A_Survey_of_Approaches_and_Evaluation_Methods"

    let _Putting_the_spirit_of_the_web_back_into_semantic_web_querying = _prefixId.prefix "_Putting_the_spirit_of_the_web_back_into_semantic_web_querying"

    let _a_Plug_in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Protégé =
        _prefixId.prefix "_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Protégé"

    let accessedAPI = _prefixId.prefix "accessedAPI"
    let addressProblem = _prefixId.prefix "addressProblem"
    let followsEvaluationMethod = _prefixId.prefix "followsEvaluationMethod"
    let hasConclusion = _prefixId.prefix "hasConclusion"
    let hasDescription = _prefixId.prefix "hasDescription"
    let hasDimension = _prefixId.prefix "hasDimension"
    let hasEvaluation = _prefixId.prefix "hasEvaluation"
    let hasEvaluationDimension = _prefixId.prefix "hasEvaluationDimension"
    let hasExperimentSetup = _prefixId.prefix "hasExperimentSetup"
    let hasFutureWork = _prefixId.prefix "hasFutureWork"
    let hasGUI = _prefixId.prefix "hasGUI"
    let hasImplementation = _prefixId.prefix "hasImplementation"
    let hasMotivation = _prefixId.prefix "hasMotivation"
    let hasResult = _prefixId.prefix "hasResult"
    let hasSolution = _prefixId.prefix "hasSolution"
    let implementedIn = _prefixId.prefix "implementedIn"
    let inputType = _prefixId.prefix "inputType"
    let isCoAuthor = _prefixId.prefix "isCoAuthor"
    let isSubproblem = _prefixId.prefix "isSubproblem"
    let motivatesApproach = _prefixId.prefix "motivatesApproach"
    let proposeFramework = _prefixId.prefix "proposeFramework"
    let provideSolution = _prefixId.prefix "provideSolution"
    let subject = _prefixId.prefix "subject"
    let supportTechnology = _prefixId.prefix "supportTechnology"
    let usesInfoAsset = _prefixId.prefix "usesInfoAsset"
    let usesInformationAsset = _prefixId.prefix "usesInformationAsset"
