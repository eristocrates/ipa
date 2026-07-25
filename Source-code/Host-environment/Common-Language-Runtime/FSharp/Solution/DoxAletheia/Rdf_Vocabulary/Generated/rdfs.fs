namespace http.www.w3.org._2000._01.rdf_schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdfs =
    let _namespace_iri = Namespace_Iri rdfs |> NamespaceIRI
    /// <summary>
    ///   <para>rdfs:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A description of the subject resource.</para>
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#comment">http://www.w3.org/2000/01/rdf-schema#comment</seealso>
    let comment = Prefixed_Name(rdfs, "comment") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of RDF containers.</para>
    /// labels<para>Container</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Container">http://www.w3.org/2000/01/rdf-schema#Container</seealso>
    let Container = Prefixed_Name(rdfs, "Container") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A member of the subject resource.</para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#member">http://www.w3.org/2000/01/rdf-schema#member</seealso>
    let member_ = Prefixed_Name(rdfs, "member") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Further information about the subject resource.</para>
    /// labels<para>seeAlso</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#seeAlso">http://www.w3.org/2000/01/rdf-schema#seeAlso</seealso>
    let seeAlso = Prefixed_Name(rdfs, "seeAlso") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class resource, everything.</para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Resource">http://www.w3.org/2000/01/rdf-schema#Resource</seealso>
    let Resource = Prefixed_Name(rdfs, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A human-readable name for the subject.</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#label">http://www.w3.org/2000/01/rdf-schema#label</seealso>
    let label = Prefixed_Name(rdfs, "label") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of RDF datatypes.</para>
    /// labels<para>Datatype</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Datatype">http://www.w3.org/2000/01/rdf-schema#Datatype</seealso>
    let Datatype = Prefixed_Name(rdfs, "Datatype") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of literal values, eg. textual strings and integers.</para>
    /// labels<para>Literal</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Literal">http://www.w3.org/2000/01/rdf-schema#Literal</seealso>
    let Literal = Prefixed_Name(rdfs, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A range of the subject property.</para>
    /// labels<para>range</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#range">http://www.w3.org/2000/01/rdf-schema#range</seealso>
    let range = Prefixed_Name(rdfs, "range") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A domain of the subject property.</para>
    /// labels<para>domain</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#domain">http://www.w3.org/2000/01/rdf-schema#domain</seealso>
    let domain = Prefixed_Name(rdfs, "domain") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:subPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a subproperty of a property.</para>
    /// labels<para>subPropertyOf</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#subPropertyOf">http://www.w3.org/2000/01/rdf-schema#subPropertyOf</seealso>
    let subPropertyOf = Prefixed_Name(rdfs, "subPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#">http://www.w3.org/2000/01/rdf-schema#</seealso>
    let _prefix_iri = Prefixed_Name(rdfs, "") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of classes.</para>
    /// labels<para>Class</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#Class">http://www.w3.org/2000/01/rdf-schema#Class</seealso>
    let Class = Prefixed_Name(rdfs, "Class") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The defininition of the subject resource.</para>
    /// labels<para>isDefinedBy</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#isDefinedBy">http://www.w3.org/2000/01/rdf-schema#isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(rdfs, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdfs:subClassOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a subclass of a class.</para>
    /// labels<para>subClassOf</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#subClassOf">http://www.w3.org/2000/01/rdf-schema#subClassOf</seealso>
    let subClassOf = Prefixed_Name(rdfs, "subClassOf") |> PrefixedName

    /// <summary>
    ///   <para>rdfs:ContainerMembershipProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.</para>
    /// labels<para>ContainerMembershipProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty">http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty</seealso>
    let ContainerMembershipProperty =
        Prefixed_Name(rdfs, "ContainerMembershipProperty") |> PrefixedName
