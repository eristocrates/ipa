namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.EuropeanEntities.EuropeanFinancialServicesEntitiesIndividuals.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_eufseind =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_eufseind |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-eufseind:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"European Financial Services Entities Individuals Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_eufseind, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufseind:EuropeanBankingFederation</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-fbo:NotForProfitOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"European Banking Federation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/EuropeanBankingFederation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/EuropeanBankingFederation</seealso>
    let EuropeanBankingFederation =
        Prefixed_Name(fibo_fbc_fct_eufseind, "EuropeanBankingFederation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufseind:EuropeanMoneyMarketsInstitute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-fbo:NotForProfitOrganization</para>
    ///
    /// labels<para>"European Money Markets Institute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/EuropeanMoneyMarketsInstitute">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/EuropeanMoneyMarketsInstitute</seealso>
    let EuropeanMoneyMarketsInstitute =
        Prefixed_Name(fibo_fbc_fct_eufseind, "EuropeanMoneyMarketsInstitute") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-eufseind:SwedishBankersAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>Organizations:FormalOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Swedish Bankers' Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/SwedishBankersAssociation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/SwedishBankersAssociation</seealso>
    let SwedishBankersAssociation =
        Prefixed_Name(fibo_fbc_fct_eufseind, "SwedishBankersAssociation") |> PrefixedName
