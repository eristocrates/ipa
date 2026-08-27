namespace http.www.agfa.com.w3c._2009.clinicalSKOSSchemes.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module clinskosch =
    let _namespace_iri = Namespace_Iri clinskosch |> NamespaceIRI
    /// <summary>
    ///   <para>clinskosch:icd10</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.agfa.com/w3c/2009/clinicalSKOSSchemes#icd10">http://www.agfa.com/w3c/2009/clinicalSKOSSchemes#icd10</seealso>
    let icd10 = Prefixed_Name(clinskosch, "icd10") |> PrefixedName
    /// <summary>
    ///   <para>clinskosch:icpc2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.agfa.com/w3c/2009/clinicalSKOSSchemes#icpc2">http://www.agfa.com/w3c/2009/clinicalSKOSSchemes#icpc2</seealso>
    let icpc2 = Prefixed_Name(clinskosch, "icpc2") |> PrefixedName
    /// <summary>
    ///   <para>clinskosch:sct20080731</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.agfa.com/w3c/2009/clinicalSKOSSchemes#sct20080731">http://www.agfa.com/w3c/2009/clinicalSKOSSchemes#sct20080731</seealso>
    let sct20080731 = Prefixed_Name(clinskosch, "sct20080731") |> PrefixedName
