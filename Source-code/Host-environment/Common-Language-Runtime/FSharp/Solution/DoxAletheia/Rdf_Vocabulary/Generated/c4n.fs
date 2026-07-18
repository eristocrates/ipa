namespace http.vocab.deri.ie.c4n.hash

open DoxAletheia.Rdf_Vocabulary

module c4n =
    let _namespace_name = "http://vocab.deri.ie/c4n#"

    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#Michael%20Hausenblas"></see>
    /// </summary>
    let ``Michael%20Hausenblas`` =
        Namespaced_IRI.parse _namespace_name "Michael%20Hausenblas" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#Call"></see>
    /// </summary>
    let Call = Namespaced_IRI.parse _namespace_name "Call" |> NamespacedName
    /// <summary>
    /// a condition under which the call event has to be understood
    /// <see href="http://vocab.deri.ie/c4n#Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    /// a temporal condition that must be met to comply the call
    /// <see href="http://vocab.deri.ie/c4n#Deadline"></see></summary>
    let Deadline = Namespaced_IRI.parse _namespace_name "Deadline" |> NamespacedName
    /// <summary>
    /// an event a call refers to
    /// <see href="http://vocab.deri.ie/c4n#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#Issuer"></see>
    /// </summary>
    let Issuer = Namespaced_IRI.parse _namespace_name "Issuer" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#LiDRC"></see>
    /// </summary>
    let LiDRC = Namespaced_IRI.parse _namespace_name "LiDRC" |> NamespacedName

    /// <summary>
    /// a geographic condition that must be met to comply the call
    /// <see href="http://vocab.deri.ie/c4n#SpatialScope"></see></summary>
    let SpatialScope =
        Namespaced_IRI.parse _namespace_name "SpatialScope" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#condition"></see>
    /// </summary>
    let condition = Namespaced_IRI.parse _namespace_name "condition" |> NamespacedName
    /// <summary>
    /// restricts the call to a certain event
    /// <see href="http://vocab.deri.ie/c4n#for"></see></summary>
    let for_ = Namespaced_IRI.parse _namespace_name "for" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#issues"></see>
    /// </summary>
    let issues = Namespaced_IRI.parse _namespace_name "issues" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/c4n#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
