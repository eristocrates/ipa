namespace http.inference_web.org._2._0.ds.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dso =
    let _namespace_iri = Namespace_Iri dso |> NamespaceIRI
    /// <summary>
    ///   <para>dso:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://inference-web.org/2.0/ds.owl#">http://inference-web.org/2.0/ds.owl#</seealso>
    let _prefix_iri = Prefixed_Name(dso, "") |> PrefixedName
    /// <summary>
    ///   <para>dso:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A template for defining typed-list. It functions like rdf:List with object members."</para>
    /// labels<para>"List"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/ds.owl#List">http://inference-web.org/2.0/ds.owl#List</seealso>
    let List = Prefixed_Name(dso, "List") |> PrefixedName
    /// <summary>
    ///   <para>dso:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The first item in the subject RDF list."</para>
    /// labels<para>"first"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/ds.owl#first">http://inference-web.org/2.0/ds.owl#first</seealso>
    let first = Prefixed_Name(dso, "first") |> PrefixedName
    /// <summary>
    ///   <para>dso:nil</para>
    /// </summary>
    /// <remarks>
    ///   <para>dso:List</para>
    ///   <para>"The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it."</para>
    /// labels<para>"nil"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/ds.owl#nil">http://inference-web.org/2.0/ds.owl#nil</seealso>
    let nil = Prefixed_Name(dso, "nil") |> PrefixedName
    /// <summary>
    ///   <para>dso:rest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The rest of the subject RDF list after the first item."</para>
    /// labels<para>"rest"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/ds.owl#rest">http://inference-web.org/2.0/ds.owl#rest</seealso>
    let rest = Prefixed_Name(dso, "rest") |> PrefixedName
