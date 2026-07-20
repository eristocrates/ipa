namespace http.vocab.deri.ie.orca.hash

open DoxAletheia

module orca =
    let _namespace_name = "http://vocab.deri.ie/orca#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#Jodi%20Schneider"></see>
    /// </summary>
    let ``Jodi%20Schneider`` = _prefix "Jodi%20Schneider"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#ahogan"></see>
    /// </summary>
    let ahogan = _prefix "ahogan"
    /// <summary>
    /// Indicates knowledge explicitly attributed to the author.
    /// <see href="http://vocab.deri.ie/orca#AuthorExplicitly"></see></summary>
    let AuthorExplicitly = _prefix "AuthorExplicitly"
    /// <summary>
    /// Indicates the source of the knowledge
    /// <see href="http://vocab.deri.ie/orca#Source"></see></summary>
    let Source = _prefix "Source"
    /// <summary>
    /// Indicates knowledge implicitly attributed to the author.
    /// <see href="http://vocab.deri.ie/orca#AuthorImplicitly"></see></summary>
    let AuthorImplicitly = _prefix "AuthorImplicitly"
    /// <summary>
    /// Indicates the basis of the knowledge
    /// <see href="http://vocab.deri.ie/orca#Basis"></see></summary>
    let Basis = _prefix "Basis"
    /// <summary>
    /// Indicates how certain the knowledge is
    /// <see href="http://vocab.deri.ie/orca#ConfidenceLevel"></see></summary>
    let ConfidenceLevel = _prefix "ConfidenceLevel"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#DERI"></see>
    /// </summary>
    let DERI = _prefix "DERI"
    /// <summary>
    /// Indicates knowledge known by data.
    /// <see href="http://vocab.deri.ie/orca#Data"></see></summary>
    let Data = _prefix "Data"
    /// <summary>
    /// Indicates duoxastic knowledge: complete certainty, reflecting an accepted, known and/or proven fact.
    /// <see href="http://vocab.deri.ie/orca#DoxasticKnowledge"></see></summary>
    let DoxasticKnowledge = _prefix "DoxasticKnowledge"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#directlyMoreCertainThan"></see>
    /// </summary>
    let directlyMoreCertainThan = _prefix "directlyMoreCertainThan"
    /// <summary>
    /// Indicates dubitative knowledge: higher likelihood but short of complete certainty.
    /// <see href="http://vocab.deri.ie/orca#DubitativeKnowledge"></see></summary>
    let DubitativeKnowledge = _prefix "DubitativeKnowledge"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#directlyLessCertainThan"></see>
    /// </summary>
    let directlyLessCertainThan = _prefix "directlyLessCertainThan"
    /// <summary>
    /// Indicates hypothetical knowledge: low certainty.
    /// <see href="http://vocab.deri.ie/orca#HypotheticalKnowledge"></see></summary>
    let HypotheticalKnowledge = _prefix "HypotheticalKnowledge"
    /// <summary>
    /// Indicates lack of knowledge.
    /// <see href="http://vocab.deri.ie/orca#LackOfKnowledge"></see></summary>
    let LackOfKnowledge = _prefix "LackOfKnowledge"
    /// <summary>
    /// Indicates knowledge attributed to a named external source (either explicitly or as a reference).
    /// <see href="http://vocab.deri.ie/orca#NamedExternalSource"></see></summary>
    let NamedExternalSource = _prefix "NamedExternalSource"
    /// <summary>
    /// Indicates knowledge attributed to a nameless external source.
    /// <see href="http://vocab.deri.ie/orca#NamelessExternalSource"></see></summary>
    let NamelessExternalSource = _prefix "NamelessExternalSource"
    /// <summary>
    /// Indicates knowledge not attributed to any source.
    /// <see href="http://vocab.deri.ie/orca#NoSource"></see></summary>
    let NoSource = _prefix "NoSource"
    /// <summary>
    /// Indicates knowledge known by reasoning.
    /// <see href="http://vocab.deri.ie/orca#Reasoning"></see></summary>
    let Reasoning = _prefix "Reasoning"
    /// <summary>
    /// Indicates knowledge whose basis is unidentified.
    /// <see href="http://vocab.deri.ie/orca#Unidentified"></see></summary>
    let Unidentified = _prefix "Unidentified"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#lessCertain"></see>
    /// </summary>
    let lessCertain = _prefix "lessCertain"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#moreCertain"></see>
    /// </summary>
    let moreCertain = _prefix "moreCertain"
    /// <summary>
    /// Indicates the basis of the knowledge.
    /// <see href="http://vocab.deri.ie/orca#hasBasis"></see></summary>
    let hasBasis = _prefix "hasBasis"
    /// <summary>
    /// Indicates the confidence/certainty level of the knowledge.
    /// <see href="http://vocab.deri.ie/orca#hasConfidenceLevel"></see></summary>
    let hasConfidenceLevel = _prefix "hasConfidenceLevel"
    /// <summary>
    /// Indicates the source of the knowledge.
    /// <see href="http://vocab.deri.ie/orca#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
