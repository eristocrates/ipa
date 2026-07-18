namespace http.vocab.deri.ie.tao.hash

open DoxAletheia.Rdf_Vocabulary

module tao =
    let _namespace_name = "http://vocab.deri.ie/tao#"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#owesac"></see>
    /// </summary>
    let owesac = Namespaced_IRI.parse _namespace_name "owesac" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` =
        Namespaced_IRI.parse _namespace_name "DERI%2C%20NUI%20Galway" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#TrustAssertion"></see>
    /// </summary>
    let TrustAssertion =
        Namespaced_IRI.parse _namespace_name "TrustAssertion" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#TrustScale"></see>
    /// </summary>
    let TrustScale = Namespaced_IRI.parse _namespace_name "TrustScale" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#TrustValue"></see>
    /// </summary>
    let TrustValue = Namespaced_IRI.parse _namespace_name "TrustValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#appliesToAgent"></see>
    /// </summary>
    let appliesToAgent =
        Namespaced_IRI.parse _namespace_name "appliesToAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#appliesToContent"></see>
    /// </summary>
    let appliesToContent =
        Namespaced_IRI.parse _namespace_name "appliesToContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#appliesToSource"></see>
    /// </summary>
    let appliesToSource =
        Namespaced_IRI.parse _namespace_name "appliesToSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#assertedBy"></see>
    /// </summary>
    let assertedBy = Namespaced_IRI.parse _namespace_name "assertedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasCommentsTrust"></see>
    /// </summary>
    let hasCommentsTrust =
        Namespaced_IRI.parse _namespace_name "hasCommentsTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasIdentityTrust"></see>
    /// </summary>
    let hasIdentityTrust =
        Namespaced_IRI.parse _namespace_name "hasIdentityTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasInteractionsTrust"></see>
    /// </summary>
    let hasInteractionsTrust =
        Namespaced_IRI.parse _namespace_name "hasInteractionsTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasLikesTrust"></see>
    /// </summary>
    let hasLikesTrust =
        Namespaced_IRI.parse _namespace_name "hasLikesTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasMaxValue"></see>
    /// </summary>
    let hasMaxValue =
        Namespaced_IRI.parse _namespace_name "hasMaxValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasMinValue"></see>
    /// </summary>
    let hasMinValue =
        Namespaced_IRI.parse _namespace_name "hasMinValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasProfileSimilarityTrust"></see>
    /// </summary>
    let hasProfileSimilarityTrust =
        Namespaced_IRI.parse _namespace_name "hasProfileSimilarityTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasRelationshipTrust"></see>
    /// </summary>
    let hasRelationshipTrust =
        Namespaced_IRI.parse _namespace_name "hasRelationshipTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasReputationTrust"></see>
    /// </summary>
    let hasReputationTrust =
        Namespaced_IRI.parse _namespace_name "hasReputationTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasResharesTrust"></see>
    /// </summary>
    let hasResharesTrust =
        Namespaced_IRI.parse _namespace_name "hasResharesTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasSharesTrust"></see>
    /// </summary>
    let hasSharesTrust =
        Namespaced_IRI.parse _namespace_name "hasSharesTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasTaggingTrust"></see>
    /// </summary>
    let hasTaggingTrust =
        Namespaced_IRI.parse _namespace_name "hasTaggingTrust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasTrustScale"></see>
    /// </summary>
    let hasTrustScale =
        Namespaced_IRI.parse _namespace_name "hasTrustScale" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
