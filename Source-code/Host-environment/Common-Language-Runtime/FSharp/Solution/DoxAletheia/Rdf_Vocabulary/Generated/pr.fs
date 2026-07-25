namespace http.purl.org.ontology.prv.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pr =
    let _namespace_iri = Namespace_Iri pr |> NamespaceIRI
    /// <summary>
    ///   <para>pr:object_property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates to the property of the reification class, which relates to the object of the "shortcut relation".</para>
    /// labels<para>has object property</para></remarks>
    /// <seealso href="http://purl.org/ontology/prv/core#object_property">http://purl.org/ontology/prv/core#object_property</seealso>
    let object_property = Prefixed_Name(pr, "object_property") |> PrefixedName
    /// <summary>
    ///   <para>pr:reified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property relates an statement identifier of a shortcut relation with an instance of a reification class. Although, this is at the moment not really applicable, because it requires a notation for statement identifier as optional fourth element of a tuple; that means, triple + statement identifier.</para>
    /// labels<para>reified</para></remarks>
    /// <seealso href="http://purl.org/ontology/prv/core#reified">http://purl.org/ontology/prv/core#reified</seealso>
    let reified = Prefixed_Name(pr, "reified") |> PrefixedName
    /// <summary>
    ///   <para>pr:shortcut</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates to the property of the "shortcut relation" (its predicate).</para>
    /// labels<para>has shortcut</para></remarks>
    /// <seealso href="http://purl.org/ontology/prv/core#shortcut">http://purl.org/ontology/prv/core#shortcut</seealso>
    let shortcut = Prefixed_Name(pr, "shortcut") |> PrefixedName
    /// <summary>
    ///   <para>pr:reification_class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates to the reification class, which can be related to the object and subject property to be able to associate the
    /// object and subject of the "shortcut relation". The reification class should provide detailed descriptions of the relationship that is
    /// described in a simple form by the "shortcut relation".</para>
    /// labels<para>has reification class</para></remarks>
    /// <seealso href="http://purl.org/ontology/prv/core#reification_class">http://purl.org/ontology/prv/core#reification_class</seealso>
    let reification_class = Prefixed_Name(pr, "reification_class") |> PrefixedName
    /// <summary>
    ///   <para>pr:shortcut_property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates to the property of the reification class,  which relates to the predicate of the "shortcut relation". So
    /// that the specific property reification can be "verified" (the property of the prv:shortcut relation and this one associated by the
    /// referred shortcut property should be equal).</para>
    /// labels<para>has shortcut property</para></remarks>
    /// <seealso href="http://purl.org/ontology/prv/core#shortcut_property">http://purl.org/ontology/prv/core#shortcut_property</seealso>
    let shortcut_property = Prefixed_Name(pr, "shortcut_property") |> PrefixedName
    /// <summary>
    ///   <para>pr:subject_property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relates to the property of the reification class, which relates to the subject of the "shortcut relation".</para>
    /// labels<para>has subject property</para></remarks>
    /// <seealso href="http://purl.org/ontology/prv/core#subject_property">http://purl.org/ontology/prv/core#subject_property</seealso>
    let subject_property = Prefixed_Name(pr, "subject_property") |> PrefixedName
    /// <summary>
    ///   <para>pr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/prv/core#">http://purl.org/ontology/prv/core#</seealso>
    let _prefix_iri = Prefixed_Name(pr, "") |> PrefixedName
    /// <summary>
    ///   <para>pr:PropertyReification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class, which describes the relations of a property reification. That means, its "shortcut relation", its
    /// reification class, and the properties that are relating to the subject and object of the "shortcut relation".</para>
    /// labels<para>Property Reification</para></remarks>
    /// <seealso href="http://purl.org/ontology/prv/core#PropertyReification">http://purl.org/ontology/prv/core#PropertyReification</seealso>
    let PropertyReification = Prefixed_Name(pr, "PropertyReification") |> PrefixedName
