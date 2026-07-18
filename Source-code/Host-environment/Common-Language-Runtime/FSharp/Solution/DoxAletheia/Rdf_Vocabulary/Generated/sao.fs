namespace http.salt.semanticauthoring.org.ontologies.sao.hash

open DoxAletheia.Rdf_Vocabulary

module sao =
    let _namespace_name = "http://salt.semanticauthoring.org/ontologies/sao#"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#Annotation"></see>
    /// </summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#CitationContext"></see>
    /// </summary>
    let CitationContext =
        Namespaced_IRI.parse _namespace_name "CitationContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#annotates"></see>
    /// </summary>
    let annotates = Namespaced_IRI.parse _namespace_name "annotates" |> NamespacedName
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#cites"></see>
    /// </summary>
    let cites = Namespaced_IRI.parse _namespace_name "cites" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#hasCitationContext"></see>
    /// </summary>
    let hasCitationContext =
        Namespaced_IRI.parse _namespace_name "hasCitationContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#hasCitationKey"></see>
    /// </summary>
    let hasCitationKey =
        Namespaced_IRI.parse _namespace_name "hasCitationKey" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#hasTopic"></see>
    /// </summary>
    let hasTopic = Namespaced_IRI.parse _namespace_name "hasTopic" |> NamespacedName
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#isCitedBy"></see>
    /// </summary>
    let isCitedBy = Namespaced_IRI.parse _namespace_name "isCitedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#pointsTo"></see>
    /// </summary>
    let pointsTo = Namespaced_IRI.parse _namespace_name "pointsTo" |> NamespacedName
