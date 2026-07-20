namespace http.www.w3.org.ns.rdfa.hash

open DoxAletheia

module rdfa =
    let _namespace_name = "http://www.w3.org/ns/rdfa#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#DocumentError"></see>
    /// </summary>
    let DocumentError = _prefix "DocumentError"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#Error"></see>
    /// </summary>
    let Error = _prefix "Error"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#PGClass"></see>
    /// </summary>
    let PGClass = _prefix "PGClass"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#Info"></see>
    /// </summary>
    let Info = _prefix "Info"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#Pattern"></see>
    /// </summary>
    let Pattern = _prefix "Pattern"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#PrefixMapping"></see>
    /// </summary>
    let PrefixMapping = _prefix "PrefixMapping"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#PrefixOrTermMapping"></see>
    /// </summary>
    let PrefixOrTermMapping = _prefix "PrefixOrTermMapping"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#PrefixRedefinition"></see>
    /// </summary>
    let PrefixRedefinition = _prefix "PrefixRedefinition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#Warning"></see>
    /// </summary>
    let Warning = _prefix "Warning"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#TermMapping"></see>
    /// </summary>
    let TermMapping = _prefix "TermMapping"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#UnresolvedCURIE"></see>
    /// </summary>
    let UnresolvedCURIE = _prefix "UnresolvedCURIE"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#UnresolvedTerm"></see>
    /// </summary>
    let UnresolvedTerm = _prefix "UnresolvedTerm"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#VocabReferenceError"></see>
    /// </summary>
    let VocabReferenceError = _prefix "VocabReferenceError"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#context"></see>
    /// </summary>
    let context = _prefix "context"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#copy"></see>
    /// </summary>
    let copy = _prefix "copy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#prefix"></see>
    /// </summary>
    let prefix = _prefix "prefix"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#term"></see>
    /// </summary>
    let term = _prefix "term"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#uri"></see>
    /// </summary>
    let uri = _prefix "uri"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#usesVocabulary"></see>
    /// </summary>
    let usesVocabulary = _prefix "usesVocabulary"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/rdfa#vocabulary"></see>
    /// </summary>
    let vocabulary = _prefix "vocabulary"
