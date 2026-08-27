namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.MetadataFBCDebtAndEquities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_dae_mod =
    let _namespace_iri = Namespace_Iri fibo_fbc_dae_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-dae-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Financial Business and Commerce(FBC) Debt and Equities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_dae_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-mod:DebtAndEquitiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"debt and equities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/DebtAndEquitiesModule">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/DebtAndEquitiesModule</seealso>
    let DebtAndEquitiesModule =
        Prefixed_Name(fibo_fbc_dae_mod, "DebtAndEquitiesModule") |> PrefixedName
