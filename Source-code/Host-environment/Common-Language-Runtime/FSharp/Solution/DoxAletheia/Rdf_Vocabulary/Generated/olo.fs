namespace http.purl.org.ontology.olo.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module olo =
    let _namespace_iri = Namespace_Iri olo |> NamespaceIRI
    /// <summary>
    ///   <para>olo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#">http://purl.org/ontology/olo/core#</seealso>
    let _prefix_iri = Prefixed_Name(olo, "") |> PrefixedName
    /// <summary>
    ///   <para>olo:OrderedList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An ordered list with a given length an indexed items."</para>
    ///   <para>"An ordered list with a given length an indexed items."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ordered List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Ordered List"</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#OrderedList">http://purl.org/ontology/olo/core#OrderedList</seealso>
    let OrderedList = Prefixed_Name(olo, "OrderedList") |> PrefixedName
    /// <summary>
    ///   <para>olo:Slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A slot in an ordered list with a fixed index."</para>
    ///   <para>"A slot in an ordered list with a fixed index."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Slot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Slot"</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#Slot">http://purl.org/ontology/olo/core#Slot</seealso>
    let Slot = Prefixed_Name(olo, "Slot") |> PrefixedName
    /// <summary>
    ///   <para>olo:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An index of a slot in an ordered list."</para>
    ///   <para>"An index of a slot in an ordered list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has index"</para><para>"index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#index">http://purl.org/ontology/olo/core#index</seealso>
    let index = Prefixed_Name(olo, "index") |> PrefixedName
    /// <summary>
    ///   <para>olo:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An item of a slot in an ordered list."</para>
    ///   <para>"An item of a slot in an ordered list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has item"</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#item">http://purl.org/ontology/olo/core#item</seealso>
    let item = Prefixed_Name(olo, "item") |> PrefixedName
    /// <summary>
    ///   <para>olo:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The length of an ordered list."</para>
    /// labels<para>"has length"</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#length">http://purl.org/ontology/olo/core#length</seealso>
    let length = Prefixed_Name(olo, "length") |> PrefixedName
    /// <summary>
    ///   <para>olo:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Associates the next slot in an ordered list."</para>
    /// labels<para>"has next"</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#next">http://purl.org/ontology/olo/core#next</seealso>
    let next = Prefixed_Name(olo, "next") |> PrefixedName
    /// <summary>
    ///   <para>olo:olo:OrderedList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#olo:OrderedList">http://purl.org/ontology/olo/core#olo:OrderedList</seealso>
    let ``olo:OrderedList`` = Prefixed_Name(olo, "olo:OrderedList") |> PrefixedName
    /// <summary>
    ///   <para>olo:olo:Slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#olo:Slot">http://purl.org/ontology/olo/core#olo:Slot</seealso>
    let ``olo:Slot`` = Prefixed_Name(olo, "olo:Slot") |> PrefixedName
    /// <summary>
    ///   <para>olo:olo:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#olo:item">http://purl.org/ontology/olo/core#olo:item</seealso>
    let ``olo:item`` = Prefixed_Name(olo, "olo:item") |> PrefixedName
    /// <summary>
    ///   <para>olo:olo:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#olo:next">http://purl.org/ontology/olo/core#olo:next</seealso>
    let ``olo:next`` = Prefixed_Name(olo, "olo:next") |> PrefixedName
    /// <summary>
    ///   <para>olo:olo:previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#olo:previous">http://purl.org/ontology/olo/core#olo:previous</seealso>
    let ``olo:previous`` = Prefixed_Name(olo, "olo:previous") |> PrefixedName
    /// <summary>
    ///   <para>olo:olo:slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#olo:slot">http://purl.org/ontology/olo/core#olo:slot</seealso>
    let ``olo:slot`` = Prefixed_Name(olo, "olo:slot") |> PrefixedName
    /// <summary>
    ///   <para>olo:ordered_list</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An ordered list of an slot."</para>
    /// labels<para>"has ordered list"</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#ordered_list">http://purl.org/ontology/olo/core#ordered_list</seealso>
    let ordered_list = Prefixed_Name(olo, "ordered_list") |> PrefixedName
    /// <summary>
    ///   <para>olo:previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Associates the previous slot in an ordered list"</para>
    /// labels<para>"has previous"</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#previous">http://purl.org/ontology/olo/core#previous</seealso>
    let previous = Prefixed_Name(olo, "previous") |> PrefixedName
    /// <summary>
    ///   <para>olo:slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A slot in an ordered list."</para>
    ///   <para>"A slot in an ordered list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has slot"</para><para>"slot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/olo/core#slot">http://purl.org/ontology/olo/core#slot</seealso>
    let slot = Prefixed_Name(olo, "slot") |> PrefixedName
