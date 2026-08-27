namespace http.purl.org.net.cartCoord.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cart =
    let _namespace_iri = Namespace_Iri cart |> NamespaceIRI
    /// <summary>
    ///   <para>cart:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This work is licensed under a Creative Commons Attribution-ShareAlike 4.0 International License.
    ///         				http://creativecommons.org/licenses/by-sa/4.0/"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Date Created: 3/7/15. Last Modified: 3/7/15."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/cartCoord#">http://purl.org/net/cartCoord#</seealso>
    let _prefix_iri = Prefixed_Name(cart, "") |> PrefixedName
    /// <summary>
    ///   <para>cart:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/cartCoord#Point">http://purl.org/net/cartCoord#Point</seealso>
    let Point = Prefixed_Name(cart, "Point") |> PrefixedName
    /// <summary>
    ///   <para>cart:Point_List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/cartCoord#Point_List">http://purl.org/net/cartCoord#Point_List</seealso>
    let Point_List = Prefixed_Name(cart, "Point_List") |> PrefixedName
    /// <summary>
    ///   <para>cart:hasPlacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/cartCoord#hasPlacement">http://purl.org/net/cartCoord#hasPlacement</seealso>
    let hasPlacement = Prefixed_Name(cart, "hasPlacement") |> PrefixedName
    /// <summary>
    ///   <para>cart:hasPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/cartCoord#hasPoint">http://purl.org/net/cartCoord#hasPoint</seealso>
    let hasPoint = Prefixed_Name(cart, "hasPoint") |> PrefixedName
    /// <summary>
    ///   <para>cart:xcoord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"X Coordinate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/cartCoord#xcoord">http://purl.org/net/cartCoord#xcoord</seealso>
    let xcoord = Prefixed_Name(cart, "xcoord") |> PrefixedName
    /// <summary>
    ///   <para>cart:ycoord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"Y Coordinate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/cartCoord#ycoord">http://purl.org/net/cartCoord#ycoord</seealso>
    let ycoord = Prefixed_Name(cart, "ycoord") |> PrefixedName
    /// <summary>
    ///   <para>cart:zcoord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"Z Coordinate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/net/cartCoord#zcoord">http://purl.org/net/cartCoord#zcoord</seealso>
    let zcoord = Prefixed_Name(cart, "zcoord") |> PrefixedName
