namespace http.www.w3.org.People.Berners_Lee.card.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tblcard =
    let _namespace_iri = Namespace_Iri tblcard |> NamespaceIRI
    /// <summary>
    ///   <para>tblcard:i</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/People/Berners-Lee/card#i">http://www.w3.org/People/Berners-Lee/card#i</seealso>
    let i = Prefixed_Name(tblcard, "i") |> PrefixedName
