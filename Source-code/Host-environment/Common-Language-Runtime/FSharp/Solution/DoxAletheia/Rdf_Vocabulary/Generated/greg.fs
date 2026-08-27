namespace http.kasei.us.about.foaf.xrdf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module greg =
    let _namespace_iri = Namespace_Iri greg |> NamespaceIRI
    /// <summary>
    ///   <para>greg:greg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://kasei.us/about/foaf.xrdf#greg">http://kasei.us/about/foaf.xrdf#greg</seealso>
    let greg_ = Prefixed_Name(greg, "greg") |> PrefixedName
