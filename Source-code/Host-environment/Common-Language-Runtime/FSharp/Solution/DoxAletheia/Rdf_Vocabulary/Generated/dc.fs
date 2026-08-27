namespace http.dublincore.org.elements._1._1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dc =
    let _namespace_iri = Namespace_Iri dc |> NamespaceIRI
    /// <summary>
    ///   <para>dc:creator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dublincore.org/elements/1.1/creator">http://dublincore.org/elements/1.1/creator</seealso>
    let creator = Prefixed_Name(dc, "creator") |> PrefixedName
    /// <summary>
    ///   <para>dc:title</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dublincore.org/elements/1.1/title">http://dublincore.org/elements/1.1/title</seealso>
    let title = Prefixed_Name(dc, "title") |> PrefixedName
