namespace http.www.lingvoj.org.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lingvoj =
    let _namespace_iri = Namespace_Iri lingvoj |> NamespaceIRI
    /// <summary>
    ///   <para>lingvoj:Lingvo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.lingvoj.org/ontology#Lingvo">http://www.lingvoj.org/ontology#Lingvo</seealso>
    let Lingvo = Prefixed_Name(lingvoj, "Lingvo") |> PrefixedName
