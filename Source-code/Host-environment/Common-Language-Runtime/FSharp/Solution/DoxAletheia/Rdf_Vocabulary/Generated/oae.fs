namespace http.www.ics.forth.gr.isl.oae.core.hash

open DoxAletheia

module oae =
    let _namespace_name = "http://www.ics.forth.gr/isl/oae/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#NEE"></see>
    /// </summary>
    let NEE = _prefix "NEE"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#belongsTo"></see>
    /// </summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#confidence"></see>
    /// </summary>
    let confidence = _prefix "confidence"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#detectedAs"></see>
    /// </summary>
    let detectedAs = _prefix "detectedAs"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#hasMatchedURI"></see>
    /// </summary>
    let hasMatchedURI = _prefix "hasMatchedURI"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#position"></see>
    /// </summary>
    let position = _prefix "position"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#regardsEntityName"></see>
    /// </summary>
    let regardsEntityName = _prefix "regardsEntityName"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#score"></see>
    /// </summary>
    let score = _prefix "score"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oae/core#usingConfiguration"></see>
    /// </summary>
    let usingConfiguration = _prefix "usingConfiguration"
