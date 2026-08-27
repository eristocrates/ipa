namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.CorporateOwnership.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_oac_cown =
    let _namespace_iri = Namespace_Iri fibo_be_oac_cown |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-oac-cown:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Corporate Ownership Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_oac_cown, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cown:BeneficialOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"beneficial owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwner">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwner</seealso>
    let BeneficialOwner =
        Prefixed_Name(fibo_be_oac_cown, "BeneficialOwner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cown:BeneficialOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"beneficial ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwnership">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwnership</seealso>
    let BeneficialOwnership =
        Prefixed_Name(fibo_be_oac_cown, "BeneficialOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cown:PurchaseLot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"purchase lot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/PurchaseLot">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/PurchaseLot</seealso>
    let PurchaseLot = Prefixed_Name(fibo_be_oac_cown, "PurchaseLot") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-cown:Shareholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"shareholder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholder">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholder</seealso>
    let Shareholder = Prefixed_Name(fibo_be_oac_cown, "Shareholder") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-cown:Shareholding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"shareholding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholding">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholding</seealso>
    let Shareholding = Prefixed_Name(fibo_be_oac_cown, "Shareholding") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-cown:TaxLot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tax lot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/TaxLot">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/TaxLot</seealso>
    let TaxLot = Prefixed_Name(fibo_be_oac_cown, "TaxLot") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cown:consistsOfNumberOfUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"consists of number of units"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/consistsOfNumberOfUnits">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/consistsOfNumberOfUnits</seealso>
    let consistsOfNumberOfUnits =
        Prefixed_Name(fibo_be_oac_cown, "consistsOfNumberOfUnits") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cown:hasBeneficialOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has beneficial owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/hasBeneficialOwner">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/hasBeneficialOwner</seealso>
    let hasBeneficialOwner =
        Prefixed_Name(fibo_be_oac_cown, "hasBeneficialOwner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-cown:isBeneficialOwnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is beneficial owner of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/isBeneficialOwnerOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/isBeneficialOwnerOf</seealso>
    let isBeneficialOwnerOf =
        Prefixed_Name(fibo_be_oac_cown, "isBeneficialOwnerOf") |> PrefixedName
