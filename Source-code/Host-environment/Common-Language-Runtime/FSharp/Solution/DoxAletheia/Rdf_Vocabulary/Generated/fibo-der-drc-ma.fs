namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.DerivativesMasterAgreements.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_ma =
    let _namespace_iri = Namespace_Iri fibo_der_drc_ma |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-ma:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Derivatives Master Agreements Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_ma, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ma:AccountChangeNotificationObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account change notification obligation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/AccountChangeNotificationObligation">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/AccountChangeNotificationObligation</seealso>
    let AccountChangeNotificationObligation =
        Prefixed_Name(fibo_der_drc_ma, "AccountChangeNotificationObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ma:DerivativeCreditSupportAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"derivative credit support agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeCreditSupportAgreement">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeCreditSupportAgreement</seealso>
    let DerivativeCreditSupportAgreement =
        Prefixed_Name(fibo_der_drc_ma, "DerivativeCreditSupportAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ma:DerivativeMasterAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"derivative master agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeMasterAgreement">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/DerivativeMasterAgreement</seealso>
    let DerivativeMasterAgreement =
        Prefixed_Name(fibo_der_drc_ma, "DerivativeMasterAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-ma:MasterAgreementEarlyTerminationRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"master agreement early termination right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/MasterAgreementEarlyTerminationRight">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/MasterAgreementEarlyTerminationRight</seealso>
    let MasterAgreementEarlyTerminationRight =
        Prefixed_Name(fibo_der_drc_ma, "MasterAgreementEarlyTerminationRight") |> PrefixedName
