namespace http.bblfish.net.people.henry.card.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bblfish =
    let _namespace_iri = Namespace_Iri bblfish |> NamespaceIRI
    /// <summary>
    ///   <para>bblfish:me</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://bblfish.net/people/henry/card#me">http://bblfish.net/people/henry/card#me</seealso>
    let me = Prefixed_Name(bblfish, "me") |> PrefixedName
