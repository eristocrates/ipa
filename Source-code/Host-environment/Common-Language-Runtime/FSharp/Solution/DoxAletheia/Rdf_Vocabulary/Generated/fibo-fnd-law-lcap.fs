namespace https.spec.edmcouncil.org.fibo.ontology.FND.Law.LegalCapacity.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_law_lcap =
    let _namespace_iri = Namespace_Iri fibo_fnd_law_lcap |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-law-lcap:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Legal Capacity Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_law_lcap, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-lcap:Claim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"claim"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Claim">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Claim</seealso>
    let Claim = Prefixed_Name(fibo_fnd_law_lcap, "Claim") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:ContingentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contingent obligation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentObligation">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentObligation</seealso>
    let ContingentObligation =
        Prefixed_Name(fibo_fnd_law_lcap, "ContingentObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:ContingentRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contingent right"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentRight">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContingentRight</seealso>
    let ContingentRight =
        Prefixed_Name(fibo_fnd_law_lcap, "ContingentRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:ContractualCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual capability"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualCapability">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualCapability</seealso>
    let ContractualCapability =
        Prefixed_Name(fibo_fnd_law_lcap, "ContractualCapability") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:ContractualInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualInterest">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualInterest</seealso>
    let ContractualInterest =
        Prefixed_Name(fibo_fnd_law_lcap, "ContractualInterest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:ContractualObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualObligation">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualObligation</seealso>
    let ContractualObligation =
        Prefixed_Name(fibo_fnd_law_lcap, "ContractualObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:ContractualOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual option"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualOption">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualOption</seealso>
    let ContractualOption =
        Prefixed_Name(fibo_fnd_law_lcap, "ContractualOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:ContractualRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual right"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualRight">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ContractualRight</seealso>
    let ContractualRight =
        Prefixed_Name(fibo_fnd_law_lcap, "ContractualRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:DelegatedLegalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"delegated legal authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DelegatedLegalAuthority">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DelegatedLegalAuthority</seealso>
    let DelegatedLegalAuthority =
        Prefixed_Name(fibo_fnd_law_lcap, "DelegatedLegalAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:DeliveryObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"delivery obligation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DeliveryObligation">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/DeliveryObligation</seealso>
    let DeliveryObligation =
        Prefixed_Name(fibo_fnd_law_lcap, "DeliveryObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:Duty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"duty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Duty">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Duty</seealso>
    let Duty = Prefixed_Name(fibo_fnd_law_lcap, "Duty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:LegalCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalCapacity">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalCapacity</seealso>
    let LegalCapacity =
        Prefixed_Name(fibo_fnd_law_lcap, "LegalCapacity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:LegalConstruct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal construct"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalConstruct">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalConstruct</seealso>
    let LegalConstruct =
        Prefixed_Name(fibo_fnd_law_lcap, "LegalConstruct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:LegalObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalObligation">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalObligation</seealso>
    let LegalObligation =
        Prefixed_Name(fibo_fnd_law_lcap, "LegalObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:LegalRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal right"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalRight">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LegalRight</seealso>
    let LegalRight = Prefixed_Name(fibo_fnd_law_lcap, "LegalRight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:LiabilityCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"liability capacity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LiabilityCapacity">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LiabilityCapacity</seealso>
    let LiabilityCapacity =
        Prefixed_Name(fibo_fnd_law_lcap, "LiabilityCapacity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"license"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/License">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/License</seealso>
    let License = Prefixed_Name(fibo_fnd_law_lcap, "License") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:LicenseIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"license identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LicenseIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LicenseIdentifier</seealso>
    let LicenseIdentifier =
        Prefixed_Name(fibo_fnd_law_lcap, "LicenseIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:Licensee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"licensee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensee">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensee</seealso>
    let Licensee = Prefixed_Name(fibo_fnd_law_lcap, "Licensee") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-lcap:Licensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"licensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensor">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Licensor</seealso>
    let Licensor = Prefixed_Name(fibo_fnd_law_lcap, "Licensor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:LitigationCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"litigation capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LitigationCapacity">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/LitigationCapacity</seealso>
    let LitigationCapacity =
        Prefixed_Name(fibo_fnd_law_lcap, "LitigationCapacity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:NotificationObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notification obligation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/NotificationObligation">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/NotificationObligation</seealso>
    let NotificationObligation =
        Prefixed_Name(fibo_fnd_law_lcap, "NotificationObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"policy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Policy">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Policy</seealso>
    let Policy = Prefixed_Name(fibo_fnd_law_lcap, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-lcap:Regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Regulation">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Regulation</seealso>
    let Regulation = Prefixed_Name(fibo_fnd_law_lcap, "Regulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:ReportingPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reporting policy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ReportingPolicy">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/ReportingPolicy</seealso>
    let ReportingPolicy =
        Prefixed_Name(fibo_fnd_law_lcap, "ReportingPolicy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:Right</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"right"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Right">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/Right</seealso>
    let Right = Prefixed_Name(fibo_fnd_law_lcap, "Right") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:SignatoryCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"signatory capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/SignatoryCapacity">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/SignatoryCapacity</seealso>
    let SignatoryCapacity =
        Prefixed_Name(fibo_fnd_law_lcap, "SignatoryCapacity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:hasCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasCapacity">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasCapacity</seealso>
    let hasCapacity = Prefixed_Name(fibo_fnd_law_lcap, "hasCapacity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:hasFractionalInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has fractional interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasFractionalInterest">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/hasFractionalInterest</seealso>
    let hasFractionalInterest =
        Prefixed_Name(fibo_fnd_law_lcap, "hasFractionalInterest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"implements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implements">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implements</seealso>
    let implements = Prefixed_Name(fibo_fnd_law_lcap, "implements") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-lcap:implies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"implies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implies">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/implies</seealso>
    let implies = Prefixed_Name(fibo_fnd_law_lcap, "implies") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-lcap:isCapacityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is capacity of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isCapacityOf">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isCapacityOf</seealso>
    let isCapacityOf = Prefixed_Name(fibo_fnd_law_lcap, "isCapacityOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:isConferredOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is conferred on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isConferredOn">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isConferredOn</seealso>
    let isConferredOn =
        Prefixed_Name(fibo_fnd_law_lcap, "isConferredOn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:isImplementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is implemented by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImplementedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImplementedBy</seealso>
    let isImplementedBy =
        Prefixed_Name(fibo_fnd_law_lcap, "isImplementedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:isImpliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is implied by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImpliedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isImpliedBy</seealso>
    let isImpliedBy = Prefixed_Name(fibo_fnd_law_lcap, "isImpliedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-law-lcap:isLicensedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is licensed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isLicensedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isLicensedBy</seealso>
    let isLicensedBy = Prefixed_Name(fibo_fnd_law_lcap, "isLicensedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:isPredicatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is predicated on"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isPredicatedOn">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/isPredicatedOn</seealso>
    let isPredicatedOn =
        Prefixed_Name(fibo_fnd_law_lcap, "isPredicatedOn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-law-lcap:licenses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"licenses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/licenses">https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/licenses</seealso>
    let licenses = Prefixed_Name(fibo_fnd_law_lcap, "licenses") |> PrefixedName
