namespace http.qudt.org.vocab.quantitykind.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module quantitykind =
    let _namespace_iri = Namespace_Iri quantitykind |> NamespaceIRI
    /// <summary>
    ///   <para>quantitykind:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/vocab/quantitykind">http://qudt.org/vocab/quantitykind</seealso>
    let _prefix_iri = Prefixed_Name(quantitykind, "") |> PrefixedName
