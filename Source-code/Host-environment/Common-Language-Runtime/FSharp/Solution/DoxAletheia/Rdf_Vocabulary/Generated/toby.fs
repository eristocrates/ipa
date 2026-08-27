namespace http.tobyinkster.co.uk.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module toby =
    let _namespace_iri = Namespace_Iri toby |> NamespaceIRI
    /// <summary>
    ///   <para>toby:i</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://tobyinkster.co.uk/#i">http://tobyinkster.co.uk/#i</seealso>
    let i = Prefixed_Name(toby, "i") |> PrefixedName
