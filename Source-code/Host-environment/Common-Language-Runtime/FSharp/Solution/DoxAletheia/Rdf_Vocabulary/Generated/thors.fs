namespace http.resource.geosciml.org.ontology.timescale.thors.hash

open DoxAletheia.Rdf_Vocabulary

module thors =
    let _namespace_name = "http://resource.geosciml.org/ontology/timescale/thors#"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#Era"></see>
    /// </summary>
    let Era = Namespaced_IRI.parse _namespace_name "Era" |> NamespacedName
    /// <summary>
    /// era or interval beginning or start
    /// <see href="http://resource.geosciml.org/ontology/timescale/thors#begin"></see></summary>
    let begin_ = Namespaced_IRI.parse _namespace_name "begin" |> NamespacedName
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#end"></see>
    /// </summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#EraBoundary"></see>
    /// </summary>
    let EraBoundary =
        Namespaced_IRI.parse _namespace_name "EraBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#nextEra"></see>
    /// </summary>
    let nextEra = Namespaced_IRI.parse _namespace_name "nextEra" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#previousEra"></see>
    /// </summary>
    let previousEra =
        Namespaced_IRI.parse _namespace_name "previousEra" |> NamespacedName

    /// <summary>
    /// A temporal ordinal reference system is a constrained temporal topological complex, in which the edges are called 'eras'. Each era may be subdivided into one set of eras of the next finer rank. This constraint is required to establish a mono-hierarchy, so that a set of temporal positions defined relative to the reference system may be uniquely ordered.
    /// <see href="http://resource.geosciml.org/ontology/timescale/thors#ReferenceSystem"></see></summary>
    let ReferenceSystem =
        Namespaced_IRI.parse _namespace_name "ReferenceSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#component"></see>
    /// </summary>
    let component_ = Namespaced_IRI.parse _namespace_name "component" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#referencePoint"></see>
    /// </summary>
    let referencePoint =
        Namespaced_IRI.parse _namespace_name "referencePoint" |> NamespacedName

    /// <summary>
    /// reference system that this era belongs to
    /// <see href="http://resource.geosciml.org/ontology/timescale/thors#system"></see></summary>
    let system = Namespaced_IRI.parse _namespace_name "system" |> NamespacedName
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#member"></see>
    /// </summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#positionalUncertainty"></see>
    /// </summary>
    let positionalUncertainty =
        Namespaced_IRI.parse _namespace_name "positionalUncertainty" |> NamespacedName
