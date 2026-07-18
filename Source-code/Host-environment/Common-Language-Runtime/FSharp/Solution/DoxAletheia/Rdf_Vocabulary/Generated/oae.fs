namespace http.www.ics.forth.gr.isl.oae.core.hash

open DoxAletheia.Rdf_Vocabulary

module oae =
    let _namespace_name = "http://www.ics.forth.gr/isl/oae/core#"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#NEE"></see>
    /// </summary>
    let NEE = Namespaced_IRI.parse _namespace_name "NEE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#belongsTo"></see>
    /// </summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#confidence"></see>
    /// </summary>
    let confidence = Namespaced_IRI.parse _namespace_name "confidence" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#detectedAs"></see>
    /// </summary>
    let detectedAs = Namespaced_IRI.parse _namespace_name "detectedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#hasMatchedURI"></see>
    /// </summary>
    let hasMatchedURI =
        Namespaced_IRI.parse _namespace_name "hasMatchedURI" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#position"></see>
    /// </summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#regardsEntityName"></see>
    /// </summary>
    let regardsEntityName =
        Namespaced_IRI.parse _namespace_name "regardsEntityName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#score"></see>
    /// </summary>
    let score = Namespaced_IRI.parse _namespace_name "score" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#usingConfiguration"></see>
    /// </summary>
    let usingConfiguration =
        Namespaced_IRI.parse _namespace_name "usingConfiguration" |> NamespacedName
