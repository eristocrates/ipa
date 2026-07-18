namespace http.vocab.deri.ie.orca.hash

open DoxAletheia.Rdf_Vocabulary

module orca =
    let _namespace_name = "http://vocab.deri.ie/orca#"

    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#Jodi%20Schneider"></see>
    /// </summary>
    let ``Jodi%20Schneider`` =
        Namespaced_IRI.parse _namespace_name "Jodi%20Schneider" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#ahogan"></see>
    /// </summary>
    let ahogan = Namespaced_IRI.parse _namespace_name "ahogan" |> NamespacedName

    /// <summary>
    /// Indicates knowledge explicitly attributed to the author.
    /// <see href="http://vocab.deri.ie/orca#AuthorExplicitly"></see></summary>
    let AuthorExplicitly =
        Namespaced_IRI.parse _namespace_name "AuthorExplicitly" |> NamespacedName

    /// <summary>
    /// Indicates the source of the knowledge
    /// <see href="http://vocab.deri.ie/orca#Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName

    /// <summary>
    /// Indicates knowledge implicitly attributed to the author.
    /// <see href="http://vocab.deri.ie/orca#AuthorImplicitly"></see></summary>
    let AuthorImplicitly =
        Namespaced_IRI.parse _namespace_name "AuthorImplicitly" |> NamespacedName

    /// <summary>
    /// Indicates the basis of the knowledge
    /// <see href="http://vocab.deri.ie/orca#Basis"></see></summary>
    let Basis = Namespaced_IRI.parse _namespace_name "Basis" |> NamespacedName

    /// <summary>
    /// Indicates how certain the knowledge is
    /// <see href="http://vocab.deri.ie/orca#ConfidenceLevel"></see></summary>
    let ConfidenceLevel =
        Namespaced_IRI.parse _namespace_name "ConfidenceLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#DERI"></see>
    /// </summary>
    let DERI = Namespaced_IRI.parse _namespace_name "DERI" |> NamespacedName
    /// <summary>
    /// Indicates knowledge known by data.
    /// <see href="http://vocab.deri.ie/orca#Data"></see></summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName

    /// <summary>
    /// Indicates duoxastic knowledge: complete certainty, reflecting an accepted, known and/or proven fact.
    /// <see href="http://vocab.deri.ie/orca#DoxasticKnowledge"></see></summary>
    let DoxasticKnowledge =
        Namespaced_IRI.parse _namespace_name "DoxasticKnowledge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#directlyMoreCertainThan"></see>
    /// </summary>
    let directlyMoreCertainThan =
        Namespaced_IRI.parse _namespace_name "directlyMoreCertainThan" |> NamespacedName

    /// <summary>
    /// Indicates dubitative knowledge: higher likelihood but short of complete certainty.
    /// <see href="http://vocab.deri.ie/orca#DubitativeKnowledge"></see></summary>
    let DubitativeKnowledge =
        Namespaced_IRI.parse _namespace_name "DubitativeKnowledge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#directlyLessCertainThan"></see>
    /// </summary>
    let directlyLessCertainThan =
        Namespaced_IRI.parse _namespace_name "directlyLessCertainThan" |> NamespacedName

    /// <summary>
    /// Indicates hypothetical knowledge: low certainty.
    /// <see href="http://vocab.deri.ie/orca#HypotheticalKnowledge"></see></summary>
    let HypotheticalKnowledge =
        Namespaced_IRI.parse _namespace_name "HypotheticalKnowledge" |> NamespacedName

    /// <summary>
    /// Indicates lack of knowledge.
    /// <see href="http://vocab.deri.ie/orca#LackOfKnowledge"></see></summary>
    let LackOfKnowledge =
        Namespaced_IRI.parse _namespace_name "LackOfKnowledge" |> NamespacedName

    /// <summary>
    /// Indicates knowledge attributed to a named external source (either explicitly or as a reference).
    /// <see href="http://vocab.deri.ie/orca#NamedExternalSource"></see></summary>
    let NamedExternalSource =
        Namespaced_IRI.parse _namespace_name "NamedExternalSource" |> NamespacedName

    /// <summary>
    /// Indicates knowledge attributed to a nameless external source.
    /// <see href="http://vocab.deri.ie/orca#NamelessExternalSource"></see></summary>
    let NamelessExternalSource =
        Namespaced_IRI.parse _namespace_name "NamelessExternalSource" |> NamespacedName

    /// <summary>
    /// Indicates knowledge not attributed to any source.
    /// <see href="http://vocab.deri.ie/orca#NoSource"></see></summary>
    let NoSource = Namespaced_IRI.parse _namespace_name "NoSource" |> NamespacedName
    /// <summary>
    /// Indicates knowledge known by reasoning.
    /// <see href="http://vocab.deri.ie/orca#Reasoning"></see></summary>
    let Reasoning = Namespaced_IRI.parse _namespace_name "Reasoning" |> NamespacedName

    /// <summary>
    /// Indicates knowledge whose basis is unidentified.
    /// <see href="http://vocab.deri.ie/orca#Unidentified"></see></summary>
    let Unidentified =
        Namespaced_IRI.parse _namespace_name "Unidentified" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#lessCertain"></see>
    /// </summary>
    let lessCertain =
        Namespaced_IRI.parse _namespace_name "lessCertain" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#moreCertain"></see>
    /// </summary>
    let moreCertain =
        Namespaced_IRI.parse _namespace_name "moreCertain" |> NamespacedName

    /// <summary>
    /// Indicates the basis of the knowledge.
    /// <see href="http://vocab.deri.ie/orca#hasBasis"></see></summary>
    let hasBasis = Namespaced_IRI.parse _namespace_name "hasBasis" |> NamespacedName

    /// <summary>
    /// Indicates the confidence/certainty level of the knowledge.
    /// <see href="http://vocab.deri.ie/orca#hasConfidenceLevel"></see></summary>
    let hasConfidenceLevel =
        Namespaced_IRI.parse _namespace_name "hasConfidenceLevel" |> NamespacedName

    /// <summary>
    /// Indicates the source of the knowledge.
    /// <see href="http://vocab.deri.ie/orca#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/orca#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
