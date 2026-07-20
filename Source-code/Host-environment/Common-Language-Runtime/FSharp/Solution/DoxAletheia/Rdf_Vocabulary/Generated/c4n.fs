namespace http.vocab.deri.ie.c4n.hash

open DoxAletheia

module c4n =
    let _namespace_name = "http://vocab.deri.ie/c4n#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#Michael%20Hausenblas"></see>
    /// </summary>
    let ``Michael%20Hausenblas`` = _prefix "Michael%20Hausenblas"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#Call"></see>
    /// </summary>
    let Call = _prefix "Call"
    /// <summary>
    /// a condition under which the call event has to be understood
    /// <see href="http://vocab.deri.ie/c4n#Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// a temporal condition that must be met to comply the call
    /// <see href="http://vocab.deri.ie/c4n#Deadline"></see></summary>
    let Deadline = _prefix "Deadline"
    /// <summary>
    /// an event a call refers to
    /// <see href="http://vocab.deri.ie/c4n#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#Issuer"></see>
    /// </summary>
    let Issuer = _prefix "Issuer"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#LiDRC"></see>
    /// </summary>
    let LiDRC = _prefix "LiDRC"
    /// <summary>
    /// a geographic condition that must be met to comply the call
    /// <see href="http://vocab.deri.ie/c4n#SpatialScope"></see></summary>
    let SpatialScope = _prefix "SpatialScope"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#condition"></see>
    /// </summary>
    let condition = _prefix "condition"
    /// <summary>
    /// restricts the call to a certain event
    /// <see href="http://vocab.deri.ie/c4n#for"></see></summary>
    let for_ = _prefix "for"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#issues"></see>
    /// </summary>
    let issues = _prefix "issues"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
