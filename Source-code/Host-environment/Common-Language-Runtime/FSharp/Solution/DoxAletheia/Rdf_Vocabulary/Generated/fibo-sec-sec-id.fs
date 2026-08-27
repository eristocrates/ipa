namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesIdentification.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_id =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_id |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-id:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Securities Identification Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_id, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:FinancialInstrumentIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial instrument identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/FinancialInstrumentIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/FinancialInstrumentIdentificationScheme</seealso>
    let FinancialInstrumentIdentificationScheme =
        Prefixed_Name(fibo_sec_sec_id, "FinancialInstrumentIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:InternationalSecuritiesIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"international securities identification number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/InternationalSecuritiesIdentificationNumber">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/InternationalSecuritiesIdentificationNumber</seealso>
    let InternationalSecuritiesIdentificationNumber =
        Prefixed_Name(fibo_sec_sec_id, "InternationalSecuritiesIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:InternationalSecuritiesIdentificationNumberingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"international securities identification numbering scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/InternationalSecuritiesIdentificationNumberingScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/InternationalSecuritiesIdentificationNumberingScheme</seealso>
    let InternationalSecuritiesIdentificationNumberingScheme =
        Prefixed_Name(fibo_sec_sec_id, "InternationalSecuritiesIdentificationNumberingScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:ListedSecurityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"listed security identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ListedSecurityIdentifier">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ListedSecurityIdentifier</seealso>
    let ListedSecurityIdentifier =
        Prefixed_Name(fibo_sec_sec_id, "ListedSecurityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:NationalNumberingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"national numbering agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalNumberingAgency">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalNumberingAgency</seealso>
    let NationalNumberingAgency =
        Prefixed_Name(fibo_sec_sec_id, "NationalNumberingAgency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:NationalSecuritiesIdentifyingNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"National Securities Identifying Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumber">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumber</seealso>
    let NationalSecuritiesIdentifyingNumber =
        Prefixed_Name(fibo_sec_sec_id, "NationalSecuritiesIdentifyingNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:NationalSecuritiesIdentifyingNumberRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"National Securities Identifying Number registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumberRegistry">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumberRegistry</seealso>
    let NationalSecuritiesIdentifyingNumberRegistry =
        Prefixed_Name(fibo_sec_sec_id, "NationalSecuritiesIdentifyingNumberRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:NationalSecuritiesIdentifyingNumberRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"national numbering agency registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumberRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumberRegistryEntry</seealso>
    let NationalSecuritiesIdentifyingNumberRegistryEntry =
        Prefixed_Name(fibo_sec_sec_id, "NationalSecuritiesIdentifyingNumberRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:NationalSecurityIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"national security identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecurityIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecurityIdentificationScheme</seealso>
    let NationalSecurityIdentificationScheme =
        Prefixed_Name(fibo_sec_sec_id, "NationalSecurityIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"proprietary security identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ProprietarySecurityIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ProprietarySecurityIdentificationScheme</seealso>
    let ProprietarySecurityIdentificationScheme =
        Prefixed_Name(fibo_sec_sec_id, "ProprietarySecurityIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:ProprietarySecurityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"proprietary security identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ProprietarySecurityIdentifier">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ProprietarySecurityIdentifier</seealso>
    let ProprietarySecurityIdentifier =
        Prefixed_Name(fibo_sec_sec_id, "ProprietarySecurityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:SecurityIdentificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security identification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityIdentificationScheme">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityIdentificationScheme</seealso>
    let SecurityIdentificationScheme =
        Prefixed_Name(fibo_sec_sec_id, "SecurityIdentificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:SecurityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityIdentifier">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityIdentifier</seealso>
    let SecurityIdentifier =
        Prefixed_Name(fibo_sec_sec_id, "SecurityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:SecurityRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityRegistry">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityRegistry</seealso>
    let SecurityRegistry =
        Prefixed_Name(fibo_sec_sec_id, "SecurityRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:SecurityRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityRegistryEntry</seealso>
    let SecurityRegistryEntry =
        Prefixed_Name(fibo_sec_sec_id, "SecurityRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-id:TickerSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ticker symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/TickerSymbol">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/TickerSymbol</seealso>
    let TickerSymbol = Prefixed_Name(fibo_sec_sec_id, "TickerSymbol") |> PrefixedName
