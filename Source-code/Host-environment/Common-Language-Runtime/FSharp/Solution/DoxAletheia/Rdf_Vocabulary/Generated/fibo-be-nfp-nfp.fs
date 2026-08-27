namespace https.spec.edmcouncil.org.fibo.ontology.BE.NotForProfitOrganizations.NotForProfitOrganizations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_nfp_nfp =
    let _namespace_iri = Namespace_Iri fibo_be_nfp_nfp |> NamespaceIRI

    /// <summary>
    ///   <para>fibo-be-nfp-nfp:NonGovernmentalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/NotForProfitOrganizations/NotForProfitOrganizations/NonGovernmentalOrganization">https://spec.edmcouncil.org/fibo/ontology/BE/NotForProfitOrganizations/NotForProfitOrganizations/NonGovernmentalOrganization</seealso>
    let NonGovernmentalOrganization =
        Prefixed_Name(fibo_be_nfp_nfp, "NonGovernmentalOrganization") |> PrefixedName
