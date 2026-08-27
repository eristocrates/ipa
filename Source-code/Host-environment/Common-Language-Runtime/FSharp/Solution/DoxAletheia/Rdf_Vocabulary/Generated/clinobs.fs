namespace http.www.agfa.com.w3c._2009.clinicalObservation.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module clinobs =
    let _namespace_iri = Namespace_Iri clinobs |> NamespaceIRI
    /// <summary>
    ///   <para>clinobs:Finding</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.agfa.com/w3c/2009/clinicalObservation#Finding">http://www.agfa.com/w3c/2009/clinicalObservation#Finding</seealso>
    let Finding = Prefixed_Name(clinobs, "Finding") |> PrefixedName
