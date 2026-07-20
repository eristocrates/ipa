namespace http.resource.geosciml.org.ontology.timescale.thors.hash

open DoxAletheia

module thors =
    let _namespace_name = "http://resource.geosciml.org/ontology/timescale/thors#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#Era"></see>
    /// </summary>
    let Era = _prefix "Era"
    /// <summary>
    /// era or interval beginning or start
    /// <see href="http://resource.geosciml.org/ontology/timescale/thors#begin"></see></summary>
    let begin_ = _prefix "begin"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#end"></see>
    /// </summary>
    let end_ = _prefix "end"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#EraBoundary"></see>
    /// </summary>
    let EraBoundary = _prefix "EraBoundary"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#nextEra"></see>
    /// </summary>
    let nextEra = _prefix "nextEra"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#previousEra"></see>
    /// </summary>
    let previousEra = _prefix "previousEra"
    /// <summary>
    /// A temporal ordinal reference system is a constrained temporal topological complex, in which the edges are called 'eras'. Each era may be subdivided into one set of eras of the next finer rank. This constraint is required to establish a mono-hierarchy, so that a set of temporal positions defined relative to the reference system may be uniquely ordered.
    /// <see href="http://resource.geosciml.org/ontology/timescale/thors#ReferenceSystem"></see></summary>
    let ReferenceSystem = _prefix "ReferenceSystem"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#component"></see>
    /// </summary>
    let component_ = _prefix "component"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#referencePoint"></see>
    /// </summary>
    let referencePoint = _prefix "referencePoint"
    /// <summary>
    /// reference system that this era belongs to
    /// <see href="http://resource.geosciml.org/ontology/timescale/thors#system"></see></summary>
    let system = _prefix "system"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#member"></see>
    /// </summary>
    let member_ = _prefix "member"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/thors#positionalUncertainty"></see>
    /// </summary>
    let positionalUncertainty = _prefix "positionalUncertainty"
