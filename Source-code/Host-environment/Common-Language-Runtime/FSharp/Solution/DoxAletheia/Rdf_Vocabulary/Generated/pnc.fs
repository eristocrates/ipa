namespace http.data.press.net.ontology.classification.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pnc =
    let _namespace_iri = Namespace_Iri pnc |> NamespaceIRI
    /// <summary>
    ///   <para>pnc:Classifiable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.press.net/ontology/classification/Classifiable">http://data.press.net/ontology/classification/Classifiable</seealso>
    let Classifiable = Prefixed_Name(pnc, "Classifiable") |> PrefixedName
