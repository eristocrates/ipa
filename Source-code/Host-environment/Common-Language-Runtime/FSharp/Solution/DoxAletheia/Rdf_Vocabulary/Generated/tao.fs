namespace http.vocab.deri.ie.tao.hash

open DoxAletheia

module tao =
    let _namespace_name = "http://vocab.deri.ie/tao#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#owesac"></see>
    /// </summary>
    let owesac = _prefix "owesac"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#DERI%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``DERI%2C%20NUI%20Galway`` = _prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#TrustAssertion"></see>
    /// </summary>
    let TrustAssertion = _prefix "TrustAssertion"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#TrustScale"></see>
    /// </summary>
    let TrustScale = _prefix "TrustScale"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#TrustValue"></see>
    /// </summary>
    let TrustValue = _prefix "TrustValue"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#appliesToAgent"></see>
    /// </summary>
    let appliesToAgent = _prefix "appliesToAgent"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#appliesToContent"></see>
    /// </summary>
    let appliesToContent = _prefix "appliesToContent"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#appliesToSource"></see>
    /// </summary>
    let appliesToSource = _prefix "appliesToSource"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#assertedBy"></see>
    /// </summary>
    let assertedBy = _prefix "assertedBy"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasCommentsTrust"></see>
    /// </summary>
    let hasCommentsTrust = _prefix "hasCommentsTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasIdentityTrust"></see>
    /// </summary>
    let hasIdentityTrust = _prefix "hasIdentityTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasInteractionsTrust"></see>
    /// </summary>
    let hasInteractionsTrust = _prefix "hasInteractionsTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasLikesTrust"></see>
    /// </summary>
    let hasLikesTrust = _prefix "hasLikesTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasMaxValue"></see>
    /// </summary>
    let hasMaxValue = _prefix "hasMaxValue"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasMinValue"></see>
    /// </summary>
    let hasMinValue = _prefix "hasMinValue"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasProfileSimilarityTrust"></see>
    /// </summary>
    let hasProfileSimilarityTrust = _prefix "hasProfileSimilarityTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasRelationshipTrust"></see>
    /// </summary>
    let hasRelationshipTrust = _prefix "hasRelationshipTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasReputationTrust"></see>
    /// </summary>
    let hasReputationTrust = _prefix "hasReputationTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasResharesTrust"></see>
    /// </summary>
    let hasResharesTrust = _prefix "hasResharesTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasSharesTrust"></see>
    /// </summary>
    let hasSharesTrust = _prefix "hasSharesTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasTaggingTrust"></see>
    /// </summary>
    let hasTaggingTrust = _prefix "hasTaggingTrust"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasTrustScale"></see>
    /// </summary>
    let hasTrustScale = _prefix "hasTrustScale"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/tao#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
