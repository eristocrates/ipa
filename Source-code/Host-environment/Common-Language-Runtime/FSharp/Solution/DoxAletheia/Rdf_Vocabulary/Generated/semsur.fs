namespace http.purl.org.SemSur.slash

open DoxAletheia

module semsur =
    let _namespace_name = "http://purl.org/SemSur/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#p"></see>
    /// </summary>
    let ``SemSur#p`` = _prefix "SemSur#p"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#x"></see>
    /// </summary>
    let ``SemSur#x`` = _prefix "SemSur#x"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#y"></see>
    /// </summary>
    let ``SemSur#y`` = _prefix "SemSur#y"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#z"></see>
    /// </summary>
    let ``SemSur#z`` = _prefix "SemSur#z"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#m"></see>
    /// </summary>
    let ``SemSur#m`` = _prefix "SemSur#m"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/2.0"></see>
    /// </summary>
    let ``_2.0`` = _prefix "2.0"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints"></see>
    /// </summary>
    let ``ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints`` =
        _prefix "ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasConclusion"></see>
    /// </summary>
    let hasConclusion = _prefix "hasConclusion"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasFutureWork"></see>
    /// </summary>
    let hasFutureWork = _prefix "hasFutureWork"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/proposeFramework"></see>
    /// </summary>
    let proposeFramework = _prefix "proposeFramework"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/ANAPSID:_evaluation"></see>
    /// </summary>
    let ``ANAPSID:_evaluation`` = _prefix "ANAPSID:_evaluation"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasExperimentSetup"></see>
    /// </summary>
    let hasExperimentSetup = _prefix "hasExperimentSetup"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/usesInformationAsset"></see>
    /// </summary>
    let usesInformationAsset = _prefix "usesInformationAsset"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies"></see>
    /// </summary>
    let ``AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies`` =
        _prefix "AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey"></see>
    /// </summary>
    let ``Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey`` =
        _prefix "Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey"></see>
    /// </summary>
    let ``Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey`` =
        _prefix "Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Connor"></see>
    /// </summary>
    let Connor = _prefix "Connor"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases"></see>
    /// </summary>
    let ``Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases`` =
        _prefix "Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs"></see>
    /// </summary>
    let ``D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs`` =
        _prefix "D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/ICDT_Workshops"></see>
    /// </summary>
    let ICDT_Workshops = _prefix "ICDT_Workshops"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data"></see>
    /// </summary>
    let ``FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data`` =
        _prefix "FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Updating_Relational_Data_via_SPARQL/Update"></see>
    /// </summary>
    let ``Updating_Relational_Data_via_SPARQL/Update`` =
        _prefix "Updating_Relational_Data_via_SPARQL/Update"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion"></see>
    /// </summary>
    let ``KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion`` =
        _prefix "KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery"></see>
    /// </summary>
    let ``Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery`` =
        _prefix "Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/LogMap:Logic-based_and_Scalable_Ontology_Matching"></see>
    /// </summary>
    let ``LogMap:Logic-based_and_Scalable_Ontology_Matching`` =
        _prefix "LogMap:Logic-based_and_Scalable_Ontology_Matching"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/OWLED_Workshop_on_OWL:_Experiences_and_Directions"></see>
    /// </summary>
    let ``OWLED_Workshop_on_OWL:_Experiences_and_Directions`` =
        _prefix "OWLED_Workshop_on_OWL:_Experiences_and_Directions"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey"></see>
    /// </summary>
    let ``Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey`` =
        _prefix "Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems"></see>
    /// </summary>
    let ``RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems`` =
        _prefix "RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Runtime_optimization/Blocking"></see>
    /// </summary>
    let ``Runtime_optimization/Blocking`` = _prefix "Runtime_optimization/Blocking"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasSolution"></see>
    /// </summary>
    let hasSolution = _prefix "hasSolution"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/isSubproblem"></see>
    /// </summary>
    let isSubproblem = _prefix "isSubproblem"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/Runtime_optimization/Filtering"></see>
    /// </summary>
    let ``Runtime_optimization/Filtering`` = _prefix "Runtime_optimization/Filtering"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking."></see>
    /// </summary>
    let ``SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking.`` =
        _prefix "SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking."

    /// <summary>
    ///   <see href="http://purl.org/SemSur/SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions"></see>
    /// </summary>
    let ``SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions`` =
        _prefix "SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/The_Semantic_Web:_Research_and_Applications"></see>
    /// </summary>
    let ``The_Semantic_Web:_Research_and_Applications`` =
        _prefix "The_Semantic_Web:_Research_and_Applications"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web"></see>
    /// </summary>
    let ``Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web`` =
        _prefix "Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/_A_Schema-Independent_Linked_Data_Interlinking_System"></see>
    /// </summary>
    let ``_A_Schema-Independent_Linked_Data_Interlinking_System`` =
        _prefix "_A_Schema-Independent_Linked_Data_Interlinking_System"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/_A_Survey_of_Approaches_and_Evaluation_Methods"></see>
    /// </summary>
    let _A_Survey_of_Approaches_and_Evaluation_Methods =
        _prefix "_A_Survey_of_Approaches_and_Evaluation_Methods"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/_Putting_the_spirit_of_the_web_back_into_semantic_web_querying"></see>
    /// </summary>
    let _Putting_the_spirit_of_the_web_back_into_semantic_web_querying =
        _prefix "_Putting_the_spirit_of_the_web_back_into_semantic_web_querying"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9"></see>
    /// </summary>
    let ``_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9`` =
        _prefix "_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9"

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Martin_O%E2%80%99Connor"></see>
    /// </summary>
    let ``Martin_O%E2%80%99Connor`` = _prefix "Martin_O%E2%80%99Connor"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/accessedAPI"></see>
    /// </summary>
    let accessedAPI = _prefix "accessedAPI"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/addressProblem"></see>
    /// </summary>
    let addressProblem = _prefix "addressProblem"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/followsEvaluationMethod"></see>
    /// </summary>
    let followsEvaluationMethod = _prefix "followsEvaluationMethod"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasDescription"></see>
    /// </summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasDimension"></see>
    /// </summary>
    let hasDimension = _prefix "hasDimension"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasEvaluation"></see>
    /// </summary>
    let hasEvaluation = _prefix "hasEvaluation"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasEvaluationDimension"></see>
    /// </summary>
    let hasEvaluationDimension = _prefix "hasEvaluationDimension"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasGUI"></see>
    /// </summary>
    let hasGUI = _prefix "hasGUI"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasImplementation"></see>
    /// </summary>
    let hasImplementation = _prefix "hasImplementation"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasMotivation"></see>
    /// </summary>
    let hasMotivation = _prefix "hasMotivation"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasResult"></see>
    /// </summary>
    let hasResult = _prefix "hasResult"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/implementedIn"></see>
    /// </summary>
    let implementedIn = _prefix "implementedIn"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/inputType"></see>
    /// </summary>
    let inputType = _prefix "inputType"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/isCoAuthor"></see>
    /// </summary>
    let isCoAuthor = _prefix "isCoAuthor"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/motivatesApproach"></see>
    /// </summary>
    let motivatesApproach = _prefix "motivatesApproach"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/provideSolution"></see>
    /// </summary>
    let provideSolution = _prefix "provideSolution"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/supportTechnology"></see>
    /// </summary>
    let supportTechnology = _prefix "supportTechnology"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/usesInfoAsset"></see>
    /// </summary>
    let usesInfoAsset = _prefix "usesInfoAsset"
