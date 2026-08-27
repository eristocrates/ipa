namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.CorporateBodies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_le_cb =
    let _namespace_iri = Namespace_Iri fibo_be_le_cb |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-le-cb:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Corporate Bodies Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_le_cb, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:BenefitCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"benefit corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/BenefitCorporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/BenefitCorporation</seealso>
    let BenefitCorporation =
        Prefixed_Name(fibo_be_le_cb, "BenefitCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:BoardAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"board agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/BoardAgreement">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/BoardAgreement</seealso>
    let BoardAgreement = Prefixed_Name(fibo_be_le_cb, "BoardAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:CommonInterestDevelopmentCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"common interest development corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/CommonInterestDevelopmentCorporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/CommonInterestDevelopmentCorporation</seealso>
    let CommonInterestDevelopmentCorporation =
        Prefixed_Name(fibo_be_le_cb, "CommonInterestDevelopmentCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:CooperativeSociety</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/CooperativeSociety">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/CooperativeSociety</seealso>
    let CooperativeSociety =
        Prefixed_Name(fibo_be_le_cb, "CooperativeSociety") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:Corporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"corporation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/Corporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/Corporation</seealso>
    let Corporation = Prefixed_Name(fibo_be_le_cb, "Corporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"for profit corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/ForProfitCorporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/ForProfitCorporation</seealso>
    let ForProfitCorporation =
        Prefixed_Name(fibo_be_le_cb, "ForProfitCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:IncorporationGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"incorporation guarantee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/IncorporationGuarantee">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/IncorporationGuarantee</seealso>
    let IncorporationGuarantee =
        Prefixed_Name(fibo_be_le_cb, "IncorporationGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:InstrumentOfIncorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"instrument of incorporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/InstrumentOfIncorporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/InstrumentOfIncorporation</seealso>
    let InstrumentOfIncorporation =
        Prefixed_Name(fibo_be_le_cb, "InstrumentOfIncorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:JointStockCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"joint stock company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/JointStockCompany">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/JointStockCompany</seealso>
    let JointStockCompany =
        Prefixed_Name(fibo_be_le_cb, "JointStockCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:NotForProfitCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"not-for-profit corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/NotForProfitCorporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/NotForProfitCorporation</seealso>
    let NotForProfitCorporation =
        Prefixed_Name(fibo_be_le_cb, "NotForProfitCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:PrivatelyHeldCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"privately held company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/PrivatelyHeldCompany">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/PrivatelyHeldCompany</seealso>
    let PrivatelyHeldCompany =
        Prefixed_Name(fibo_be_le_cb, "PrivatelyHeldCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"publicly held company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/PubliclyHeldCompany">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/PubliclyHeldCompany</seealso>
    let PubliclyHeldCompany =
        Prefixed_Name(fibo_be_le_cb, "PubliclyHeldCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registration identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/RegistrationIdentifier">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/RegistrationIdentifier</seealso>
    let RegistrationIdentifier =
        Prefixed_Name(fibo_be_le_cb, "RegistrationIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registration identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/RegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/RegistrationIdentifierScheme</seealso>
    let RegistrationIdentifierScheme =
        Prefixed_Name(fibo_be_le_cb, "RegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:ReligiousCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"religious corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/ReligiousCorporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/ReligiousCorporation</seealso>
    let ReligiousCorporation =
        Prefixed_Name(fibo_be_le_cb, "ReligiousCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stock corporation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/StockCorporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/StockCorporation</seealso>
    let StockCorporation =
        Prefixed_Name(fibo_be_le_cb, "StockCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:hasDateOfIncorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date of incorporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasDateOfIncorporation">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasDateOfIncorporation</seealso>
    let hasDateOfIncorporation =
        Prefixed_Name(fibo_be_le_cb, "hasDateOfIncorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:hasDateOfRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date of registration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasDateOfRegistration">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasDateOfRegistration</seealso>
    let hasDateOfRegistration =
        Prefixed_Name(fibo_be_le_cb, "hasDateOfRegistration") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:hasIssuedCapital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has issued capital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasIssuedCapital">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasIssuedCapital</seealso>
    let hasIssuedCapital =
        Prefixed_Name(fibo_be_le_cb, "hasIssuedCapital") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:hasSharesAuthorized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has shares authorized"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasSharesAuthorized">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasSharesAuthorized</seealso>
    let hasSharesAuthorized =
        Prefixed_Name(fibo_be_le_cb, "hasSharesAuthorized") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:isConstitutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is constituted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/isConstitutedBy">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/isConstitutedBy</seealso>
    let isConstitutedBy =
        Prefixed_Name(fibo_be_le_cb, "isConstitutedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-cb:isIncorporatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is incorporated in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/isIncorporatedIn">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/isIncorporatedIn</seealso>
    let isIncorporatedIn =
        Prefixed_Name(fibo_be_le_cb, "isIncorporatedIn") |> PrefixedName
