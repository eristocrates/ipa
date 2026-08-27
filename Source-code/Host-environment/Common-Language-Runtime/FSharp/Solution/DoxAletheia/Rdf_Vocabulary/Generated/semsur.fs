namespace http.purl.org.SemSur.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module semsur =
    let _namespace_iri = Namespace_Iri semsur |> NamespaceIRI
    /// <summary>
    ///   <para>semsur:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/">http://purl.org/SemSur/</seealso>
    let _prefix_iri = Prefixed_Name(semsur, "") |> PrefixedName
    /// <summary>
    ///   <para>semsur:2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/SemSur/2.0">http://purl.org/SemSur/2.0</seealso>
    let ``_2.0`` = Prefixed_Name(semsur, "2.0") |> PrefixedName

    /// <summary>
    ///   <para>semsur:ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Article</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints">http://purl.org/SemSur/ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints</seealso>
    let ``ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints`` =
        Prefixed_Name(semsur, "ANAPSID:_An_Adaptive_Query_Processing_Engine_for_SPARQL_Endpoints") |> PrefixedName

    /// <summary>
    ///   <para>semsur:ANAPSID:_evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>deo:Evaluation</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/ANAPSID:_evaluation">http://purl.org/SemSur/ANAPSID:_evaluation</seealso>
    let ``ANAPSID:_evaluation`` =
        Prefixed_Name(semsur, "ANAPSID:_evaluation") |> PrefixedName

    /// <summary>
    ///   <para>semsur:AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>swrc:Article</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies">http://purl.org/SemSur/AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies</seealso>
    let ``AgreementMaker:_Ecient_Matching_for_Large_Real_World_Schemas_and_Ontologies`` =
        Prefixed_Name(semsur, "AgreementMaker:_Ecient_Matching_for_Large_Real-World_Schemas_and_Ontologies") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>swrc:Article</para>
    ///   <para>swrc:Publication</para>
    ///   <para>&lt;http://purl.org/semsur/SingleAuthorPublication&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey">http://purl.org/SemSur/Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey</seealso>
    let ``Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey`` =
        Prefixed_Name(semsur, "Bringing_Relational_Databases_into_the_Semantic_Web:A_Survey") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/SurveyPaper&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey">http://purl.org/SemSur/Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey</seealso>
    let ``Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey`` =
        Prefixed_Name(semsur, "Bringing_Relational_Databases_into_the_Semantic_Web:_A_Survey") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Connor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Connor">http://purl.org/SemSur/Connor</seealso>
    let Connor = Prefixed_Name(semsur, "Connor") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>swrc:Article</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases">http://purl.org/SemSur/Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases</seealso>
    let ``Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases`` =
        Prefixed_Name(semsur, "Cross:_an_OWL_wrapper_for_teasoning_on_relational_databases") |> PrefixedName

    /// <summary>
    ///   <para>semsur:D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>swrc:Article</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs">http://purl.org/SemSur/D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs</seealso>
    let ``D2RQ_%E2%80%93_Treating_Non_RDF_Databases_as_Virtual_RDF_Graphs`` =
        Prefixed_Name(semsur, "D2RQ_%E2%80%93_Treating_Non-RDF_Databases_as_Virtual_RDF_Graphs") |> PrefixedName

    /// <summary>
    ///   <para>semsur:FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>swrc:Article</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data">http://purl.org/SemSur/FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data</seealso>
    let ``FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data`` =
        Prefixed_Name(semsur, "FedX:_a_federation_layer_for_distributed_query_processing_on_linked_open_data") |> PrefixedName

    /// <summary>
    ///   <para>semsur:ICDT_Workshops</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Agent</para>
    ///   <para>dcterms:Agent</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/ICDT_Workshops">http://purl.org/SemSur/ICDT_Workshops</seealso>
    let ICDT_Workshops = Prefixed_Name(semsur, "ICDT_Workshops") |> PrefixedName

    /// <summary>
    ///   <para>semsur:KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>swrc:Article</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion">http://purl.org/SemSur/KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion</seealso>
    let ``KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion`` =
        Prefixed_Name(semsur, "KnoFuss:_A_Comprehensive_Architecture_for_Knowledge_Fusion") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery">http://purl.org/SemSur/Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery</seealso>
    let ``Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery`` =
        Prefixed_Name(semsur, "Linked_hypernyms:_Enriching_DBpedia_with_Targeted_Hypernym_Discovery") |> PrefixedName

    /// <summary>
    ///   <para>semsur:LogMap:Logic-based_and_Scalable_Ontology_Matching</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>swrc:Article</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/LogMap:Logic-based_and_Scalable_Ontology_Matching">http://purl.org/SemSur/LogMap:Logic-based_and_Scalable_Ontology_Matching</seealso>
    let ``LogMap:Logic_based_and_Scalable_Ontology_Matching`` =
        Prefixed_Name(semsur, "LogMap:Logic-based_and_Scalable_Ontology_Matching") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Martin_O%E2%80%99Connor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/SemSur/Martin_O%E2%80%99Connor">http://purl.org/SemSur/Martin_O%E2%80%99Connor</seealso>
    let ``Martin_O%E2%80%99Connor`` =
        Prefixed_Name(semsur, "Martin_O%E2%80%99Connor") |> PrefixedName

    /// <summary>
    ///   <para>semsur:OWLED_Workshop_on_OWL:_Experiences_and_Directions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/OWLED_Workshop_on_OWL:_Experiences_and_Directions">http://purl.org/SemSur/OWLED_Workshop_on_OWL:_Experiences_and_Directions</seealso>
    let ``OWLED_Workshop_on_OWL:_Experiences_and_Directions`` =
        Prefixed_Name(semsur, "OWLED_Workshop_on_OWL:_Experiences_and_Directions") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/SurveyPaper&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey">http://purl.org/SemSur/Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey</seealso>
    let ``Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey`` =
        Prefixed_Name(semsur, "Querying_over_Federated_SPARQL_Endpoints_%E2%80%94A_State_of_the_Art_Survey") |> PrefixedName

    /// <summary>
    ///   <para>semsur:RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Article</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems">http://purl.org/SemSur/RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems</seealso>
    let ``RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems`` =
        Prefixed_Name(semsur, "RDB2ONT:_A_Tool_for_Generating_OWL_Ontologies_From_Relational_Database_Systems") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Runtime_optimization/Blocking</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/Problem&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/ProblemSolution&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Runtime_optimization/Blocking">http://purl.org/SemSur/Runtime_optimization/Blocking</seealso>
    let ``Runtime_optimization/Blocking`` =
        Prefixed_Name(semsur, "Runtime_optimization/Blocking") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Runtime_optimization/Filtering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/ProblemSolution&gt;</para>
    ///   <para>&lt;http://purl.org/semsur/Problem&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Runtime_optimization/Filtering">http://purl.org/SemSur/Runtime_optimization/Filtering</seealso>
    let ``Runtime_optimization/Filtering`` =
        Prefixed_Name(semsur, "Runtime_optimization/Filtering") |> PrefixedName

    /// <summary>
    ///   <para>semsur:SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking.</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>swrc:Article</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking.">http://purl.org/SemSur/SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking.</seealso>
    let ``SERIMI___Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking.`` =
        Prefixed_Name(semsur, "SERIMI_-_Resource_Description_Similarity,_RDF_Instance_Matching_and_Interlinking.") |> PrefixedName

    /// <summary>
    ///   <para>semsur:SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>swrc:Article</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions">http://purl.org/SemSur/SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions</seealso>
    let ``SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions`` =
        Prefixed_Name(semsur, "SPLENDID:_SPARQL_Endpoint_Federation_Exploiting_VOID_Descriptions") |> PrefixedName

    /// <summary>
    ///   <para>semsur:SemSur#m</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/SemSur#m">http://purl.org/SemSur/SemSur#m</seealso>
    let ``SemSur#m`` = Prefixed_Name(semsur, "SemSur#m") |> PrefixedName
    /// <summary>
    ///   <para>semsur:SemSur#p</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/SemSur#p">http://purl.org/SemSur/SemSur#p</seealso>
    let ``SemSur#p`` = Prefixed_Name(semsur, "SemSur#p") |> PrefixedName
    /// <summary>
    ///   <para>semsur:SemSur#x</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/SemSur#x">http://purl.org/SemSur/SemSur#x</seealso>
    let ``SemSur#x`` = Prefixed_Name(semsur, "SemSur#x") |> PrefixedName
    /// <summary>
    ///   <para>semsur:SemSur#y</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/SemSur#y">http://purl.org/SemSur/SemSur#y</seealso>
    let ``SemSur#y`` = Prefixed_Name(semsur, "SemSur#y") |> PrefixedName
    /// <summary>
    ///   <para>semsur:SemSur#z</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/SemSur#z">http://purl.org/SemSur/SemSur#z</seealso>
    let ``SemSur#z`` = Prefixed_Name(semsur, "SemSur#z") |> PrefixedName

    /// <summary>
    ///   <para>semsur:The_Semantic_Web:_Research_and_Applications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/The_Semantic_Web:_Research_and_Applications">http://purl.org/SemSur/The_Semantic_Web:_Research_and_Applications</seealso>
    let ``The_Semantic_Web:_Research_and_Applications`` =
        Prefixed_Name(semsur, "The_Semantic_Web:_Research_and_Applications") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Article</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web">http://purl.org/SemSur/Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web</seealso>
    let ``Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web`` =
        Prefixed_Name(semsur, "Unveiling_the_hidden_bride:_deep_annotation_for_mapping_and_migrating_legacy_data_to_the_Semantic_Web") |> PrefixedName

    /// <summary>
    ///   <para>semsur:Updating_Relational_Data_via_SPARQL/Update</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Article</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>swrc:Publication</para>
    ///   <para>&lt;http://purl.org/semsur/SingleAuthorPublication&gt;</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/Updating_Relational_Data_via_SPARQL/Update">http://purl.org/SemSur/Updating_Relational_Data_via_SPARQL/Update</seealso>
    let ``Updating_Relational_Data_via_SPARQL/Update`` =
        Prefixed_Name(semsur, "Updating_Relational_Data_via_SPARQL/Update") |> PrefixedName

    /// <summary>
    ///   <para>semsur:_A_Schema-Independent_Linked_Data_Interlinking_System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>swrc:Article</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/_A_Schema-Independent_Linked_Data_Interlinking_System">http://purl.org/SemSur/_A_Schema-Independent_Linked_Data_Interlinking_System</seealso>
    let _A_Schema_Independent_Linked_Data_Interlinking_System =
        Prefixed_Name(semsur, "_A_Schema-Independent_Linked_Data_Interlinking_System") |> PrefixedName

    /// <summary>
    ///   <para>semsur:_A_Survey_of_Approaches_and_Evaluation_Methods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://purl.org/semsur/SurveyPaper&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/_A_Survey_of_Approaches_and_Evaluation_Methods">http://purl.org/SemSur/_A_Survey_of_Approaches_and_Evaluation_Methods</seealso>
    let _A_Survey_of_Approaches_and_Evaluation_Methods =
        Prefixed_Name(semsur, "_A_Survey_of_Approaches_and_Evaluation_Methods") |> PrefixedName

    /// <summary>
    ///   <para>semsur:_Putting_the_spirit_of_the_web_back_into_semantic_web_querying</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>swrc:Article</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/_Putting_the_spirit_of_the_web_back_into_semantic_web_querying">http://purl.org/SemSur/_Putting_the_spirit_of_the_web_back_into_semantic_web_querying</seealso>
    let _Putting_the_spirit_of_the_web_back_into_semantic_web_querying =
        Prefixed_Name(semsur, "_Putting_the_spirit_of_the_web_back_into_semantic_web_querying") |> PrefixedName

    /// <summary>
    ///   <para>semsur:_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>swrc:Article</para>
    ///   <para>&lt;http://purl.org/semsur/RegularPaper&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9">http://purl.org/SemSur/_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9</seealso>
    let ``_a_Plug_in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9`` =
        Prefixed_Name(semsur, "_a_Plug-in_for_Importing_Schemas_and_Data_from_Relational_Databases_into_Prot%C3%A9g%C3%A9") |> PrefixedName

    /// <summary>
    ///   <para>semsur:accessedAPI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/accessedAPI">http://purl.org/SemSur/accessedAPI</seealso>
    let accessedAPI = Prefixed_Name(semsur, "accessedAPI") |> PrefixedName
    /// <summary>
    ///   <para>semsur:addressProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/addressProblem">http://purl.org/SemSur/addressProblem</seealso>
    let addressProblem = Prefixed_Name(semsur, "addressProblem") |> PrefixedName

    /// <summary>
    ///   <para>semsur:followsEvaluationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/followsEvaluationMethod">http://purl.org/SemSur/followsEvaluationMethod</seealso>
    let followsEvaluationMethod =
        Prefixed_Name(semsur, "followsEvaluationMethod") |> PrefixedName

    /// <summary>
    ///   <para>semsur:hasConclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasConclusion">http://purl.org/SemSur/hasConclusion</seealso>
    let hasConclusion = Prefixed_Name(semsur, "hasConclusion") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasDescription">http://purl.org/SemSur/hasDescription</seealso>
    let hasDescription = Prefixed_Name(semsur, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasDimension">http://purl.org/SemSur/hasDimension</seealso>
    let hasDimension = Prefixed_Name(semsur, "hasDimension") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasEvaluation">http://purl.org/SemSur/hasEvaluation</seealso>
    let hasEvaluation = Prefixed_Name(semsur, "hasEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>semsur:hasEvaluationDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasEvaluationDimension">http://purl.org/SemSur/hasEvaluationDimension</seealso>
    let hasEvaluationDimension =
        Prefixed_Name(semsur, "hasEvaluationDimension") |> PrefixedName

    /// <summary>
    ///   <para>semsur:hasExperimentSetup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasExperimentSetup">http://purl.org/SemSur/hasExperimentSetup</seealso>
    let hasExperimentSetup = Prefixed_Name(semsur, "hasExperimentSetup") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasFutureWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasFutureWork">http://purl.org/SemSur/hasFutureWork</seealso>
    let hasFutureWork = Prefixed_Name(semsur, "hasFutureWork") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasGUI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasGUI">http://purl.org/SemSur/hasGUI</seealso>
    let hasGUI = Prefixed_Name(semsur, "hasGUI") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasImplementation">http://purl.org/SemSur/hasImplementation</seealso>
    let hasImplementation = Prefixed_Name(semsur, "hasImplementation") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasMotivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasMotivation">http://purl.org/SemSur/hasMotivation</seealso>
    let hasMotivation = Prefixed_Name(semsur, "hasMotivation") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasResult">http://purl.org/SemSur/hasResult</seealso>
    let hasResult = Prefixed_Name(semsur, "hasResult") |> PrefixedName
    /// <summary>
    ///   <para>semsur:hasSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/hasSolution">http://purl.org/SemSur/hasSolution</seealso>
    let hasSolution = Prefixed_Name(semsur, "hasSolution") |> PrefixedName
    /// <summary>
    ///   <para>semsur:implementedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/implementedIn">http://purl.org/SemSur/implementedIn</seealso>
    let implementedIn = Prefixed_Name(semsur, "implementedIn") |> PrefixedName
    /// <summary>
    ///   <para>semsur:inputType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/inputType">http://purl.org/SemSur/inputType</seealso>
    let inputType = Prefixed_Name(semsur, "inputType") |> PrefixedName
    /// <summary>
    ///   <para>semsur:isCoAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/isCoAuthor">http://purl.org/SemSur/isCoAuthor</seealso>
    let isCoAuthor = Prefixed_Name(semsur, "isCoAuthor") |> PrefixedName
    /// <summary>
    ///   <para>semsur:isSubproblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/isSubproblem">http://purl.org/SemSur/isSubproblem</seealso>
    let isSubproblem = Prefixed_Name(semsur, "isSubproblem") |> PrefixedName
    /// <summary>
    ///   <para>semsur:motivatesApproach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/motivatesApproach">http://purl.org/SemSur/motivatesApproach</seealso>
    let motivatesApproach = Prefixed_Name(semsur, "motivatesApproach") |> PrefixedName
    /// <summary>
    ///   <para>semsur:proposeFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/proposeFramework">http://purl.org/SemSur/proposeFramework</seealso>
    let proposeFramework = Prefixed_Name(semsur, "proposeFramework") |> PrefixedName
    /// <summary>
    ///   <para>semsur:provideSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/provideSolution">http://purl.org/SemSur/provideSolution</seealso>
    let provideSolution = Prefixed_Name(semsur, "provideSolution") |> PrefixedName
    /// <summary>
    ///   <para>semsur:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/subject">http://purl.org/SemSur/subject</seealso>
    let subject = Prefixed_Name(semsur, "subject") |> PrefixedName
    /// <summary>
    ///   <para>semsur:supportTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/supportTechnology">http://purl.org/SemSur/supportTechnology</seealso>
    let supportTechnology = Prefixed_Name(semsur, "supportTechnology") |> PrefixedName
    /// <summary>
    ///   <para>semsur:usesInfoAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/usesInfoAsset">http://purl.org/SemSur/usesInfoAsset</seealso>
    let usesInfoAsset = Prefixed_Name(semsur, "usesInfoAsset") |> PrefixedName

    /// <summary>
    ///   <para>semsur:usesInformationAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/SemSur/usesInformationAsset">http://purl.org/SemSur/usesInformationAsset</seealso>
    let usesInformationAsset =
        Prefixed_Name(semsur, "usesInformationAsset") |> PrefixedName
