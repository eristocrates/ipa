namespace http.webns.net.mvcb.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module admin =
    let _namespace_iri = Namespace_Iri admin |> NamespaceIRI
    /// <summary>
    ///   <para>admin:generatorAgent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://webns.net/mvcb/generatorAgent">http://webns.net/mvcb/generatorAgent</seealso>
    let generatorAgent = Prefixed_Name(admin, "generatorAgent") |> PrefixedName
