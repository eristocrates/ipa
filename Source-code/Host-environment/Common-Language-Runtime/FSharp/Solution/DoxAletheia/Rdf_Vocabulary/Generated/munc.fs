namespace http.ns.inria.fr.munc.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module munc =
    let _namespace_iri = Namespace_Iri munc |> NamespaceIRI
    /// <summary>
    ///   <para>munc:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/munc/">http://ns.inria.fr/munc/</seealso>
    let _prefix_iri = Prefixed_Name(munc, "") |> PrefixedName
    /// <summary>
    ///   <para>munc:v1#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/munc/v1#">http://ns.inria.fr/munc/v1#</seealso>
    let ``v1#`` = Prefixed_Name(munc, "v1#") |> PrefixedName
