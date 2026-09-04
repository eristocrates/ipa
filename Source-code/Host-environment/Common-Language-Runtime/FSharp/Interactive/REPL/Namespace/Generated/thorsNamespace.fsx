#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module thors =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://resource.geosciml.org/ontology/timescale/thors#" "thors"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Time Ordinal Era or Interval^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#Era">thors:Era</a>
    /// </summary>
    let Era = _prefixId.prefix "Era"
    /// <summary>
    ///   <para>rdfs:label : Time Ordinal Era Boundary^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#EraBoundary">thors:EraBoundary</a>
    /// </summary>
    let EraBoundary = _prefixId.prefix "EraBoundary"
    /// <summary>
    ///   <para>rdfs:comment : A temporal ordinal reference system is a constrained temporal topological complex, in which the edges are called 'eras'. Each era may be subdivided into one set of eras of the next finer rank. This constraint is required to establish a mono-hierarchy, so that a set of temporal positions defined relative to the reference system may be uniquely ordered.^^xsd:string</para>
    ///   <para>rdfs:label : Hierarchical Time Ordinal Reference System^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#ReferenceSystem">thors:ReferenceSystem</a>
    /// </summary>
    let ReferenceSystem = _prefixId.prefix "ReferenceSystem"
    /// <summary>
    ///   <para>rdfs:comment : era or interval beginning or start^^xsd:string</para>
    ///   <para>rdfs:label : era beginning</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#begin">thors:begin</a>
    /// </summary>
    let begin_ = _prefixId.prefix "begin"
    /// <summary>
    ///   <para>rdfs:label : temporal reference system component</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#component">thors:component</a>
    /// </summary>
    let component_ = _prefixId.prefix "component"
    /// <summary>
    ///   <para>rdfs:label : era end</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#end">thors:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:label : era member / sub-era</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#member">thors:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : next era</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#nextEra">thors:nextEra</a>
    /// </summary>
    let nextEra = _prefixId.prefix "nextEra"
    /// <summary>
    ///   <para>rdfs:label : uncertainty in temporal position</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#positionalUncertainty">thors:positionalUncertainty</a>
    /// </summary>
    let positionalUncertainty = _prefixId.prefix "positionalUncertainty"
    /// <summary>
    ///   <para>rdfs:label : previous era</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#previousEra">thors:previousEra</a>
    /// </summary>
    let previousEra = _prefixId.prefix "previousEra"
    /// <summary>
    ///   <para>rdfs:label : reference point in timescale^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#referencePoint">thors:referencePoint</a>
    /// </summary>
    let referencePoint = _prefixId.prefix "referencePoint"
    /// <summary>
    ///   <para>rdfs:comment : reference system that this era belongs to^^xsd:string</para>
    ///   <para>rdfs:label : system</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/thors#system">thors:system</a>
    /// </summary>
    let system = _prefixId.prefix "system"
