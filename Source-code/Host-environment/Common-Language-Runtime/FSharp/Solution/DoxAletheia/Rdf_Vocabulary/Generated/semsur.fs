namespace http.purl.org.SemSur.slash

open DoxAletheia.Rdf_Vocabulary

module semsur =
    let _namespace_name = "http://purl.org/SemSur/"
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#p"></see>
    /// </summary>
    let ``SemSur#p`` = Namespaced_IRI.parse _namespace_name "SemSur#p" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#x"></see>
    /// </summary>
    let ``SemSur#x`` = Namespaced_IRI.parse _namespace_name "SemSur#x" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#y"></see>
    /// </summary>
    let ``SemSur#y`` = Namespaced_IRI.parse _namespace_name "SemSur#y" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#z"></see>
    /// </summary>
    let ``SemSur#z`` = Namespaced_IRI.parse _namespace_name "SemSur#z" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/SemSur/SemSur#m"></see>
    /// </summary>
    let ``SemSur#m`` = Namespaced_IRI.parse _namespace_name "SemSur#m" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/SemSur/2.0"></see>
    /// </summary>
    let ``_2.0`` = Namespaced_IRI.parse _namespace_name "2.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints"></see>
    /// </summary>
    let ``ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints`` =
        Namespaced_IRI.parse _namespace_name "ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasConclusion"></see>
    /// </summary>
    let hasConclusion =
        Namespaced_IRI.parse _namespace_name "hasConclusion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasFutureWork"></see>
    /// </summary>
    let hasFutureWork =
        Namespaced_IRI.parse _namespace_name "hasFutureWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/proposeFramework"></see>
    /// </summary>
    let proposeFramework =
        Namespaced_IRI.parse _namespace_name "proposeFramework" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/subject"></see>
    /// </summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/ANAPSID:_evaluation"></see>
    /// </summary>
    let ``ANAPSID:_evaluation`` =
        Namespaced_IRI.parse _namespace_name "ANAPSID:_evaluation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasExperimentSetup"></see>
    /// </summary>
    let hasExperimentSetup =
        Namespaced_IRI.parse _namespace_name "hasExperimentSetup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/usesInformationAsset"></see>
    /// </summary>
    let usesInformationAsset =
        Namespaced_IRI.parse _namespace_name "usesInformationAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies"></see>
    /// </summary>
    let ``AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies`` =
        Namespaced_IRI.parse _namespace_name "AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey"></see>
    /// </summary>
    let ``Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey`` =
        Namespaced_IRI.parse _namespace_name "Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey"></see>
    /// </summary>
    let ``Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey`` =
        Namespaced_IRI.parse _namespace_name "Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Connor"></see>
    /// </summary>
    let Connor = Namespaced_IRI.parse _namespace_name "Connor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases"></see>
    /// </summary>
    let ``Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases`` =
        Namespaced_IRI.parse _namespace_name "Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs"></see>
    /// </summary>
    let ``D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs`` =
        Namespaced_IRI.parse _namespace_name "D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/ICDT_Workshops"></see>
    /// </summary>
    let ICDT_Workshops =
        Namespaced_IRI.parse _namespace_name "ICDT_Workshops" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data"></see>
    /// </summary>
    let ``FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data`` =
        Namespaced_IRI.parse _namespace_name "FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Updating_Relational_Data_via_SPARQL/Update"></see>
    /// </summary>
    let ``Updating_Relational_Data_via_SPARQL/Update`` =
        Namespaced_IRI.parse _namespace_name "Updating_Relational_Data_via_SPARQL/Update" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion"></see>
    /// </summary>
    let ``KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion`` =
        Namespaced_IRI.parse _namespace_name "KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery"></see>
    /// </summary>
    let ``Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery`` =
        Namespaced_IRI.parse _namespace_name "Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/LogMap:Logic-based_and_Scalable_Ontology_Matching"></see>
    /// </summary>
    let ``LogMap:Logic-based_and_Scalable_Ontology_Matching`` =
        Namespaced_IRI.parse _namespace_name "LogMap:Logic-based_and_Scalable_Ontology_Matching" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/OWLED_Workshop_on_OWL:_Experiences_and_Directions"></see>
    /// </summary>
    let ``OWLED_Workshop_on_OWL:_Experiences_and_Directions`` =
        Namespaced_IRI.parse _namespace_name "OWLED_Workshop_on_OWL:_Experiences_and_Directions" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey"></see>
    /// </summary>
    let ``Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey`` =
        Namespaced_IRI.parse _namespace_name "Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems"></see>
    /// </summary>
    let ``RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems`` =
        Namespaced_IRI.parse _namespace_name "RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Runtime_optimization/Blocking"></see>
    /// </summary>
    let ``Runtime_optimization/Blocking`` =
        Namespaced_IRI.parse _namespace_name "Runtime_optimization/Blocking" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasSolution"></see>
    /// </summary>
    let hasSolution =
        Namespaced_IRI.parse _namespace_name "hasSolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/isSubproblem"></see>
    /// </summary>
    let isSubproblem =
        Namespaced_IRI.parse _namespace_name "isSubproblem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Runtime_optimization/Filtering"></see>
    /// </summary>
    let ``Runtime_optimization/Filtering`` =
        Namespaced_IRI.parse _namespace_name "Runtime_optimization/Filtering" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking."></see>
    /// </summary>
    let ``SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking.`` =
        Namespaced_IRI.parse _namespace_name "SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking." |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions"></see>
    /// </summary>
    let ``SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions`` =
        Namespaced_IRI.parse _namespace_name "SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/The_Semantic_Web:_Research_and_Applications"></see>
    /// </summary>
    let ``The_Semantic_Web:_Research_and_Applications`` =
        Namespaced_IRI.parse _namespace_name "The_Semantic_Web:_Research_and_Applications" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web"></see>
    /// </summary>
    let ``Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web`` =
        Namespaced_IRI.parse _namespace_name "Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/_A_Schema-Independent_Linked_Data_Interlinking_System"></see>
    /// </summary>
    let ``_A_Schema-Independent_Linked_Data_Interlinking_System`` =
        Namespaced_IRI.parse _namespace_name "_A_Schema-Independent_Linked_Data_Interlinking_System" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/_A_Survey_of_Approaches_and_Evaluation_Methods"></see>
    /// </summary>
    let _A_Survey_of_Approaches_and_Evaluation_Methods =
        Namespaced_IRI.parse _namespace_name "_A_Survey_of_Approaches_and_Evaluation_Methods" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/_Putting_the_spirit_of_the_web_back_into_semantic_web_querying"></see>
    /// </summary>
    let _Putting_the_spirit_of_the_web_back_into_semantic_web_querying =
        Namespaced_IRI.parse _namespace_name "_Putting_the_spirit_of_the_web_back_into_semantic_web_querying" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9"></see>
    /// </summary>
    let ``_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9`` =
        Namespaced_IRI.parse _namespace_name "_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/Martin_O%E2%80%99Connor"></see>
    /// </summary>
    let ``Martin_O%E2%80%99Connor`` =
        Namespaced_IRI.parse _namespace_name "Martin_O%E2%80%99Connor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/accessedAPI"></see>
    /// </summary>
    let accessedAPI =
        Namespaced_IRI.parse _namespace_name "accessedAPI" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/addressProblem"></see>
    /// </summary>
    let addressProblem =
        Namespaced_IRI.parse _namespace_name "addressProblem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/followsEvaluationMethod"></see>
    /// </summary>
    let followsEvaluationMethod =
        Namespaced_IRI.parse _namespace_name "followsEvaluationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasDescription"></see>
    /// </summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasDimension"></see>
    /// </summary>
    let hasDimension =
        Namespaced_IRI.parse _namespace_name "hasDimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasEvaluation"></see>
    /// </summary>
    let hasEvaluation =
        Namespaced_IRI.parse _namespace_name "hasEvaluation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasEvaluationDimension"></see>
    /// </summary>
    let hasEvaluationDimension =
        Namespaced_IRI.parse _namespace_name "hasEvaluationDimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasGUI"></see>
    /// </summary>
    let hasGUI = Namespaced_IRI.parse _namespace_name "hasGUI" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasImplementation"></see>
    /// </summary>
    let hasImplementation =
        Namespaced_IRI.parse _namespace_name "hasImplementation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasMotivation"></see>
    /// </summary>
    let hasMotivation =
        Namespaced_IRI.parse _namespace_name "hasMotivation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/hasResult"></see>
    /// </summary>
    let hasResult = Namespaced_IRI.parse _namespace_name "hasResult" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/implementedIn"></see>
    /// </summary>
    let implementedIn =
        Namespaced_IRI.parse _namespace_name "implementedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/inputType"></see>
    /// </summary>
    let inputType = Namespaced_IRI.parse _namespace_name "inputType" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/SemSur/isCoAuthor"></see>
    /// </summary>
    let isCoAuthor = Namespaced_IRI.parse _namespace_name "isCoAuthor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/motivatesApproach"></see>
    /// </summary>
    let motivatesApproach =
        Namespaced_IRI.parse _namespace_name "motivatesApproach" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/provideSolution"></see>
    /// </summary>
    let provideSolution =
        Namespaced_IRI.parse _namespace_name "provideSolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/supportTechnology"></see>
    /// </summary>
    let supportTechnology =
        Namespaced_IRI.parse _namespace_name "supportTechnology" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/SemSur/usesInfoAsset"></see>
    /// </summary>
    let usesInfoAsset =
        Namespaced_IRI.parse _namespace_name "usesInfoAsset" |> NamespacedName
