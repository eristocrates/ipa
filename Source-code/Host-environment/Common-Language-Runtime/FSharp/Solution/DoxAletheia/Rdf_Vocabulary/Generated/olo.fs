namespace http.purl.org.ontology.olo.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module olo =
    let _namespace_iri = Namespace_Iri olo |> NamespaceIRI
    /// <summary>
    ///   <para>olo:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The length of an ordered list.</para>
    /// labels<para>has length</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#length">http://purl.org/ontology/olo/core#length</seealso>
    let length = Prefixed_Name(olo, "length") |> PrefixedName
    /// <summary>
    ///   <para>olo:OrderedList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An ordered list with a given length an indexed items.</para>
    /// labels<para>Ordered List</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#OrderedList">http://purl.org/ontology/olo/core#OrderedList</seealso>
    let OrderedList = Prefixed_Name(olo, "OrderedList") |> PrefixedName
    /// <summary>
    ///   <para>olo:Slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A slot in an ordered list with a fixed index.</para>
    /// labels<para>Slot</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#Slot">http://purl.org/ontology/olo/core#Slot</seealso>
    let Slot = Prefixed_Name(olo, "Slot") |> PrefixedName
    /// <summary>
    ///   <para>olo:previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Associates the previous slot in an ordered list</para>
    /// labels<para>has previous</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#previous">http://purl.org/ontology/olo/core#previous</seealso>
    let previous = Prefixed_Name(olo, "previous") |> PrefixedName
    /// <summary>
    ///   <para>olo:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An index of a slot in an ordered list.</para>
    /// labels<para>has index</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#index">http://purl.org/ontology/olo/core#index</seealso>
    let index = Prefixed_Name(olo, "index") |> PrefixedName
    /// <summary>
    ///   <para>olo:ordered_list</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An ordered list of an slot.</para>
    /// labels<para>has ordered list</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#ordered_list">http://purl.org/ontology/olo/core#ordered_list</seealso>
    let ordered_list = Prefixed_Name(olo, "ordered_list") |> PrefixedName
    /// <summary>
    ///   <para>olo:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Associates the next slot in an ordered list.</para>
    /// labels<para>has next</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#next">http://purl.org/ontology/olo/core#next</seealso>
    let next = Prefixed_Name(olo, "next") |> PrefixedName
    /// <summary>
    ///   <para>olo:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An item of a slot in an ordered list.</para>
    /// labels<para>has item</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#item">http://purl.org/ontology/olo/core#item</seealso>
    let item = Prefixed_Name(olo, "item") |> PrefixedName
    /// <summary>
    ///   <para>olo:slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A slot in an ordered list.</para>
    /// labels<para>has slot</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#slot">http://purl.org/ontology/olo/core#slot</seealso>
    let slot = Prefixed_Name(olo, "slot") |> PrefixedName
    /// <summary>
    ///   <para>olo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#">http://purl.org/ontology/olo/core#</seealso>
    let _prefix_iri = Prefixed_Name(olo, "") |> PrefixedName
