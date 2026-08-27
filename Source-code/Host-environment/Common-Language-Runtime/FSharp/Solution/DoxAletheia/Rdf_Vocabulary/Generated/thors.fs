namespace http.resource.geosciml.org.ontology.timescale.thors.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module thors =
    let _namespace_iri = Namespace_Iri thors |> NamespaceIRI
    /// <summary>
    ///   <para>thors:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#">http://resource.geosciml.org/ontology/timescale/thors#</seealso>
    let _prefix_iri = Prefixed_Name(thors, "") |> PrefixedName
    /// <summary>
    ///   <para>thors:Era</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Time Ordinal Era or Interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#Era">http://resource.geosciml.org/ontology/timescale/thors#Era</seealso>
    let Era = Prefixed_Name(thors, "Era") |> PrefixedName
    /// <summary>
    ///   <para>thors:EraBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Time Ordinal Era Boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#EraBoundary">http://resource.geosciml.org/ontology/timescale/thors#EraBoundary</seealso>
    let EraBoundary = Prefixed_Name(thors, "EraBoundary") |> PrefixedName
    /// <summary>
    ///   <para>thors:ReferenceSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A temporal ordinal reference system is a constrained temporal topological complex, in which the edges are called 'eras'. Each era may be subdivided into one set of eras of the next finer rank. This constraint is required to establish a mono-hierarchy, so that a set of temporal positions defined relative to the reference system may be uniquely ordered."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hierarchical Time Ordinal Reference System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#ReferenceSystem">http://resource.geosciml.org/ontology/timescale/thors#ReferenceSystem</seealso>
    let ReferenceSystem = Prefixed_Name(thors, "ReferenceSystem") |> PrefixedName
    /// <summary>
    ///   <para>thors:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"era or interval beginning or start"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"era beginning"</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#begin">http://resource.geosciml.org/ontology/timescale/thors#begin</seealso>
    let begin_ = Prefixed_Name(thors, "begin") |> PrefixedName
    /// <summary>
    ///   <para>thors:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"temporal reference system component"</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#component">http://resource.geosciml.org/ontology/timescale/thors#component</seealso>
    let component_ = Prefixed_Name(thors, "component") |> PrefixedName
    /// <summary>
    ///   <para>thors:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"era end"</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#end">http://resource.geosciml.org/ontology/timescale/thors#end</seealso>
    let end_ = Prefixed_Name(thors, "end") |> PrefixedName
    /// <summary>
    ///   <para>thors:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"era member / sub-era"</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#member">http://resource.geosciml.org/ontology/timescale/thors#member</seealso>
    let member_ = Prefixed_Name(thors, "member") |> PrefixedName
    /// <summary>
    ///   <para>thors:nextEra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"next era"</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#nextEra">http://resource.geosciml.org/ontology/timescale/thors#nextEra</seealso>
    let nextEra = Prefixed_Name(thors, "nextEra") |> PrefixedName

    /// <summary>
    ///   <para>thors:positionalUncertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"uncertainty in temporal position"</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#positionalUncertainty">http://resource.geosciml.org/ontology/timescale/thors#positionalUncertainty</seealso>
    let positionalUncertainty =
        Prefixed_Name(thors, "positionalUncertainty") |> PrefixedName

    /// <summary>
    ///   <para>thors:previousEra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"previous era"</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#previousEra">http://resource.geosciml.org/ontology/timescale/thors#previousEra</seealso>
    let previousEra = Prefixed_Name(thors, "previousEra") |> PrefixedName
    /// <summary>
    ///   <para>thors:referencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"reference point in timescale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#referencePoint">http://resource.geosciml.org/ontology/timescale/thors#referencePoint</seealso>
    let referencePoint = Prefixed_Name(thors, "referencePoint") |> PrefixedName
    /// <summary>
    ///   <para>thors:system</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"reference system that this era belongs to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"system"</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/thors#system">http://resource.geosciml.org/ontology/timescale/thors#system</seealso>
    let system = Prefixed_Name(thors, "system") |> PrefixedName
