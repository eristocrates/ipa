namespace http.www.w3.org.ns.rdfa.hash

open DoxAletheia.Rdf_Vocabulary

module rdfa =
    let _namespace_name = "http://www.w3.org/ns/rdfa#"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#DocumentError"></see>
    /// </summary>
    let DocumentError =
        Namespaced_IRI.parse _namespace_name "DocumentError" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#Error"></see>
    /// </summary>
    let Error = Namespaced_IRI.parse _namespace_name "Error" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#PGClass"></see>
    /// </summary>
    let PGClass = Namespaced_IRI.parse _namespace_name "PGClass" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#Info"></see>
    /// </summary>
    let Info = Namespaced_IRI.parse _namespace_name "Info" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#Pattern"></see>
    /// </summary>
    let Pattern = Namespaced_IRI.parse _namespace_name "Pattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#PrefixMapping"></see>
    /// </summary>
    let PrefixMapping =
        Namespaced_IRI.parse _namespace_name "PrefixMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#PrefixOrTermMapping"></see>
    /// </summary>
    let PrefixOrTermMapping =
        Namespaced_IRI.parse _namespace_name "PrefixOrTermMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#PrefixRedefinition"></see>
    /// </summary>
    let PrefixRedefinition =
        Namespaced_IRI.parse _namespace_name "PrefixRedefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#Warning"></see>
    /// </summary>
    let Warning = Namespaced_IRI.parse _namespace_name "Warning" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#TermMapping"></see>
    /// </summary>
    let TermMapping =
        Namespaced_IRI.parse _namespace_name "TermMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#UnresolvedCURIE"></see>
    /// </summary>
    let UnresolvedCURIE =
        Namespaced_IRI.parse _namespace_name "UnresolvedCURIE" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#UnresolvedTerm"></see>
    /// </summary>
    let UnresolvedTerm =
        Namespaced_IRI.parse _namespace_name "UnresolvedTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#VocabReferenceError"></see>
    /// </summary>
    let VocabReferenceError =
        Namespaced_IRI.parse _namespace_name "VocabReferenceError" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#context"></see>
    /// </summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#copy"></see>
    /// </summary>
    let copy = Namespaced_IRI.parse _namespace_name "copy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#prefix"></see>
    /// </summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#term"></see>
    /// </summary>
    let term = Namespaced_IRI.parse _namespace_name "term" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#uri"></see>
    /// </summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#usesVocabulary"></see>
    /// </summary>
    let usesVocabulary =
        Namespaced_IRI.parse _namespace_name "usesVocabulary" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#vocabulary"></see>
    /// </summary>
    let vocabulary = Namespaced_IRI.parse _namespace_name "vocabulary" |> NamespacedName
