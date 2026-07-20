namespace http.salt.semanticauthoring.org.ontologies.sao.hash

open DoxAletheia

module sao =
    let _namespace_name = "http://salt.semanticauthoring.org/ontologies/sao#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#Annotation"></see>
    /// </summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#CitationContext"></see>
    /// </summary>
    let CitationContext = _prefix "CitationContext"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#annotates"></see>
    /// </summary>
    let annotates = _prefix "annotates"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#cites"></see>
    /// </summary>
    let cites = _prefix "cites"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#hasCitationContext"></see>
    /// </summary>
    let hasCitationContext = _prefix "hasCitationContext"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#hasCitationKey"></see>
    /// </summary>
    let hasCitationKey = _prefix "hasCitationKey"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#hasTopic"></see>
    /// </summary>
    let hasTopic = _prefix "hasTopic"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#isCitedBy"></see>
    /// </summary>
    let isCitedBy = _prefix "isCitedBy"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sao#pointsTo"></see>
    /// </summary>
    let pointsTo = _prefix "pointsTo"
