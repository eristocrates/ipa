namespace http.purl.org.ibis.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ibis =
    let _namespace_iri = Namespace_Iri ibis |> NamespaceIRI
    /// <summary>
    ///   <para>ibis:Idea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ibis#Idea">http://purl.org/ibis#Idea</seealso>
    let Idea = Prefixed_Name(ibis, "Idea") |> PrefixedName
