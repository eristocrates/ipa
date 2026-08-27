namespace http.spinrdf.org.arg.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module arg =
    let _namespace_iri = Namespace_Iri arg |> NamespaceIRI
    /// <summary>
    ///   <para>arg:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://spinrdf.org/arg#class">http://spinrdf.org/arg#class</seealso>
    let class_ = Prefixed_Name(arg, "class") |> PrefixedName
    /// <summary>
    ///   <para>arg:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://spinrdf.org/arg#property">http://spinrdf.org/arg#property</seealso>
    let property = Prefixed_Name(arg, "property") |> PrefixedName
