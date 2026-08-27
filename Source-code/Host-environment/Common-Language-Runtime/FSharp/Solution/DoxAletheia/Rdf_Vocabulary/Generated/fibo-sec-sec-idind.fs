namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesIdentificationIndividuals.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_idind =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_idind |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-idind:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Securities Identification Individuals Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_idind, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:CGSCUSIPAccessRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-id:NationalSecuritiesIdentifyingNumberRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CGS CUSIP Access Repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CGSCUSIPAccessRepository">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CGSCUSIPAccessRepository</seealso>
    let CGSCUSIPAccessRepository =
        Prefixed_Name(fibo_sec_sec_idind, "CGSCUSIPAccessRepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:CUSIPGlobalServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-fct-pub:Publisher</para>
    ///   <para>fibo-sec-sec-id:NationalNumberingAgency</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CUSIP Global Services"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CUSIPGlobalServices">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CUSIPGlobalServices</seealso>
    let CUSIPGlobalServices =
        Prefixed_Name(fibo_sec_sec_idind, "CUSIPGlobalServices") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:CUSIPInternationalNumberingSystemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CUSIP International Numbering System (CINS) number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CUSIPInternationalNumberingSystemNumber">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CUSIPInternationalNumberingSystemNumber</seealso>
    let CUSIPInternationalNumberingSystemNumber =
        Prefixed_Name(fibo_sec_sec_idind, "CUSIPInternationalNumberingSystemNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:CUSIPInternationalNumberingSystemScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    ///
    /// labels<para>"CUSIP International Numbering System (CINS) scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CUSIPInternationalNumberingSystemScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CUSIPInternationalNumberingSystemScheme</seealso>
    let CUSIPInternationalNumberingSystemScheme =
        Prefixed_Name(fibo_sec_sec_idind, "CUSIPInternationalNumberingSystemScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:CommitteeOnUniformSecuritiesIdentificationProceduresNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Committee on Uniform Securities Identification Procedures (CUSIP) number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommitteeOnUniformSecuritiesIdentificationProceduresNumber">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommitteeOnUniformSecuritiesIdentificationProceduresNumber</seealso>
    let CommitteeOnUniformSecuritiesIdentificationProceduresNumber =
        Prefixed_Name(fibo_sec_sec_idind, "CommitteeOnUniformSecuritiesIdentificationProceduresNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:CommitteeOnUniformSecuritiesIdentificationProceduresScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:NationalSecurityIdentificationScheme</para>
    ///
    /// labels<para>"Committee on Uniform Securities Identification Procedures (CUSIP) scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommitteeOnUniformSecuritiesIdentificationProceduresScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommitteeOnUniformSecuritiesIdentificationProceduresScheme</seealso>
    let CommitteeOnUniformSecuritiesIdentificationProceduresScheme =
        Prefixed_Name(fibo_sec_sec_idind, "CommitteeOnUniformSecuritiesIdentificationProceduresScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:CommonCodeRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common code registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommonCodeRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommonCodeRegistryEntry</seealso>
    let CommonCodeRegistryEntry =
        Prefixed_Name(fibo_sec_sec_idind, "CommonCodeRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:CommonCodeRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"common code repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommonCodeRepository">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommonCodeRepository</seealso>
    let CommonCodeRepository =
        Prefixed_Name(fibo_sec_sec_idind, "CommonCodeRepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:EuroclearClearstreamCommonCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Euroclear Clearstream common code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/EuroclearClearstreamCommonCode">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/EuroclearClearstreamCommonCode</seealso>
    let EuroclearClearstreamCommonCode =
        Prefixed_Name(fibo_sec_sec_idind, "EuroclearClearstreamCommonCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:EuroclearClearstreamCommonCodeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    ///
    /// labels<para>"Euroclear Clearstream common code scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/EuroclearClearstreamCommonCodeScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/EuroclearClearstreamCommonCodeScheme</seealso>
    let EuroclearClearstreamCommonCodeScheme =
        Prefixed_Name(fibo_sec_sec_idind, "EuroclearClearstreamCommonCodeScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:FinancialInstrumentGlobalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial instrument global identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifier">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifier</seealso>
    let FinancialInstrumentGlobalIdentifier =
        Prefixed_Name(fibo_sec_sec_idind, "FinancialInstrumentGlobalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:FinancialInstrumentGlobalIdentifierRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Financial Instrument Global Identifier (FIGI) Registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifierRegistry">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifierRegistry</seealso>
    let FinancialInstrumentGlobalIdentifierRegistry =
        Prefixed_Name(fibo_sec_sec_idind, "FinancialInstrumentGlobalIdentifierRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:FinancialInstrumentGlobalIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Financial Instrument Global Identifier (FIGI) registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifierRegistryEntry</seealso>
    let FinancialInstrumentGlobalIdentifierRegistryEntry =
        Prefixed_Name(fibo_sec_sec_idind, "FinancialInstrumentGlobalIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:FinancialInstrumentGlobalIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:FinancialInstrumentIdentificationScheme</para>
    ///
    /// labels<para>"financial instrument global identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifierScheme</seealso>
    let FinancialInstrumentGlobalIdentifierScheme =
        Prefixed_Name(fibo_sec_sec_idind, "FinancialInstrumentGlobalIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:FinancialTimesInteractiveDataScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    ///
    /// labels<para>"Financial Times interactive data scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialTimesInteractiveDataScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialTimesInteractiveDataScheme</seealso>
    let FinancialTimesInteractiveDataScheme =
        Prefixed_Name(fibo_sec_sec_idind, "FinancialTimesInteractiveDataScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:RefinitivInstrumentCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Refinitiv instrument code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/RefinitivInstrumentCode">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/RefinitivInstrumentCode</seealso>
    let RefinitivInstrumentCode =
        Prefixed_Name(fibo_sec_sec_idind, "RefinitivInstrumentCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:RefinitivInstrumentCodeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Refinitiv instrument code scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/RefinitivInstrumentCodeScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/RefinitivInstrumentCodeScheme</seealso>
    let RefinitivInstrumentCodeScheme =
        Prefixed_Name(fibo_sec_sec_idind, "RefinitivInstrumentCodeScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:SEDOLMasterFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:SecurityRegistry</para>
    ///   <para>fibo-sec-sec-id:NationalSecuritiesIdentifyingNumberRegistry</para>
    ///
    /// labels<para>"SEDOL Master File"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/SEDOLMasterFile">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/SEDOLMasterFile</seealso>
    let SEDOLMasterFile =
        Prefixed_Name(fibo_sec_sec_idind, "SEDOLMasterFile") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:StockExchangeDailyOfficialListCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stock Exchange Daily Official List (SEDOL) code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/StockExchangeDailyOfficialListCode">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/StockExchangeDailyOfficialListCode</seealso>
    let StockExchangeDailyOfficialListCode =
        Prefixed_Name(fibo_sec_sec_idind, "StockExchangeDailyOfficialListCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:StockExchangeDailyOfficialListScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    ///   <para>fibo-sec-sec-id:NationalSecurityIdentificationScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:SecurityIdentificationScheme</para>
    ///
    /// labels<para>"Stock Exchange Daily Official List (SEDOL) scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/StockExchangeDailyOfficialListScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/StockExchangeDailyOfficialListScheme</seealso>
    let StockExchangeDailyOfficialListScheme =
        Prefixed_Name(fibo_sec_sec_idind, "StockExchangeDailyOfficialListScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:TelekursId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Telekurs Id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/TelekursId">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/TelekursId</seealso>
    let TelekursId = Prefixed_Name(fibo_sec_sec_idind, "TelekursId") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:TelekursSecurityIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Telekurs security identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/TelekursSecurityIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/TelekursSecurityIdentifierScheme</seealso>
    let TelekursSecurityIdentifierScheme =
        Prefixed_Name(fibo_sec_sec_idind, "TelekursSecurityIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:Valoren</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valoren"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/Valoren">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/Valoren</seealso>
    let Valoren = Prefixed_Name(fibo_sec_sec_idind, "Valoren") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-idind:ValorenScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    ///   <para>fibo-sec-sec-id:NationalSecurityIdentificationScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-id:SecurityIdentificationScheme</para>
    ///
    /// labels<para>"Valoren scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/ValorenScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/ValorenScheme</seealso>
    let ValorenScheme =
        Prefixed_Name(fibo_sec_sec_idind, "ValorenScheme") |> PrefixedName
