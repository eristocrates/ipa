namespace http.ns.bergnet.org.tac._0._1.triple_access_control.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tac =
    let _namespace_iri = Namespace_Iri tac |> NamespaceIRI
    /// <summary>
    ///   <para>tac:Authorization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#Authorization">http://ns.bergnet.org/tac/0.1/triple-access-control#Authorization</seealso>
    let Authorization = Prefixed_Name(tac, "Authorization") |> PrefixedName
    /// <summary>
    ///   <para>tac:Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A triple filter."</para>
    /// labels<para>"Filter"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#Filter">http://ns.bergnet.org/tac/0.1/triple-access-control#Filter</seealso>
    let Filter = Prefixed_Name(tac, "Filter") |> PrefixedName
    /// <summary>
    ///   <para>tac:TripleAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A triple authorization."</para>
    /// labels<para>"TripleAuthorization"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#TripleAuthorization">http://ns.bergnet.org/tac/0.1/triple-access-control#TripleAuthorization</seealso>
    let TripleAuthorization = Prefixed_Name(tac, "TripleAuthorization") |> PrefixedName
    /// <summary>
    ///   <para>tac:accessToTriple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Contains triple authorization information."</para>
    /// labels<para>"accesToTriple"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#accessToTriple">http://ns.bergnet.org/tac/0.1/triple-access-control#accessToTriple</seealso>
    let accessToTriple = Prefixed_Name(tac, "accessToTriple") |> PrefixedName
    /// <summary>
    ///   <para>tac:children</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Contains sub triple authorization informations."</para>
    /// labels<para>"children"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#children">http://ns.bergnet.org/tac/0.1/triple-access-control#children</seealso>
    let children = Prefixed_Name(tac, "children") |> PrefixedName
    /// <summary>
    ///   <para>tac:filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Contains triple filter rules."</para>
    /// labels<para>"filter"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#filter">http://ns.bergnet.org/tac/0.1/triple-access-control#filter</seealso>
    let filter = Prefixed_Name(tac, "filter") |> PrefixedName
    /// <summary>
    ///   <para>tac:graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Graph for a triple filter."</para>
    /// labels<para>"graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#graph">http://ns.bergnet.org/tac/0.1/triple-access-control#graph</seealso>
    let graph = Prefixed_Name(tac, "graph") |> PrefixedName
    /// <summary>
    ///   <para>tac:mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Access mode is defined per triple authorization."</para>
    /// labels<para>"mode"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#mode">http://ns.bergnet.org/tac/0.1/triple-access-control#mode</seealso>
    let mode = Prefixed_Name(tac, "mode") |> PrefixedName
    /// <summary>
    ///   <para>tac:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Object for a triple filter"</para>
    /// labels<para>"object"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#object">http://ns.bergnet.org/tac/0.1/triple-access-control#object</seealso>
    let object = Prefixed_Name(tac, "object") |> PrefixedName
    /// <summary>
    ///   <para>tac:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Predicate for a triple filter."</para>
    /// labels<para>"predicate"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#predicate">http://ns.bergnet.org/tac/0.1/triple-access-control#predicate</seealso>
    let predicate = Prefixed_Name(tac, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>tac:required</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this property is true access to the parent triple is only granted if childrens are found."</para>
    /// labels<para>"required"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#required">http://ns.bergnet.org/tac/0.1/triple-access-control#required</seealso>
    let required = Prefixed_Name(tac, "required") |> PrefixedName
    /// <summary>
    ///   <para>tac:statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Statement for a triple filter."</para>
    /// labels<para>"statement"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#statement">http://ns.bergnet.org/tac/0.1/triple-access-control#statement</seealso>
    let statement = Prefixed_Name(tac, "statement") |> PrefixedName
    /// <summary>
    ///   <para>tac:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Subject for a triple filter."</para>
    /// labels<para>"subject"</para></remarks>
    /// <seealso href="http://ns.bergnet.org/tac/0.1/triple-access-control#subject">http://ns.bergnet.org/tac/0.1/triple-access-control#subject</seealso>
    let subject = Prefixed_Name(tac, "subject") |> PrefixedName
