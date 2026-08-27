namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.Ownership.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_oac_own =
    let _namespace_iri = Namespace_Iri fibo_fnd_oac_own |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-oac-own:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Ownership Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_oac_own, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Asset">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Asset</seealso>
    let Asset = Prefixed_Name(fibo_fnd_oac_own, "Asset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:CapitalSurplus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capital surplus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/CapitalSurplus">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/CapitalSurplus</seealso>
    let CapitalSurplus =
        Prefixed_Name(fibo_fnd_oac_own, "CapitalSurplus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:EarningsBeforeInterestTaxesDepreciationAmortization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"earnings before interest, taxes, depreciation and amortization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/EarningsBeforeInterestTaxesDepreciationAmortization">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/EarningsBeforeInterestTaxesDepreciationAmortization</seealso>
    let EarningsBeforeInterestTaxesDepreciationAmortization =
        Prefixed_Name(fibo_fnd_oac_own, "EarningsBeforeInterestTaxesDepreciationAmortization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:FinancialAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/FinancialAsset">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/FinancialAsset</seealso>
    let FinancialAsset =
        Prefixed_Name(fibo_fnd_oac_own, "FinancialAsset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:Holding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"holding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Holding">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Holding</seealso>
    let Holding = Prefixed_Name(fibo_fnd_oac_own, "Holding") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:Income</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"income"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Income">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Income</seealso>
    let Income = Prefixed_Name(fibo_fnd_oac_own, "Income") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:IntangibleAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intangible asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/IntangibleAsset">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/IntangibleAsset</seealso>
    let IntangibleAsset =
        Prefixed_Name(fibo_fnd_oac_own, "IntangibleAsset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:Owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Owner">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Owner</seealso>
    let Owner = Prefixed_Name(fibo_fnd_oac_own, "Owner") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:OwnersEquity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"owners' equity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/OwnersEquity">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/OwnersEquity</seealso>
    let OwnersEquity = Prefixed_Name(fibo_fnd_oac_own, "OwnersEquity") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:Ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ownership"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Ownership">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Ownership</seealso>
    let Ownership = Prefixed_Name(fibo_fnd_oac_own, "Ownership") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:PaidInCapital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"paid-in capital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/PaidInCapital">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/PaidInCapital</seealso>
    let PaidInCapital = Prefixed_Name(fibo_fnd_oac_own, "PaidInCapital") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:PhysicalAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/PhysicalAsset">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/PhysicalAsset</seealso>
    let PhysicalAsset = Prefixed_Name(fibo_fnd_oac_own, "PhysicalAsset") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:Portfolio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"portfolio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Portfolio">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Portfolio</seealso>
    let Portfolio = Prefixed_Name(fibo_fnd_oac_own, "Portfolio") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:RetainedEarnings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"retained earnings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/RetainedEarnings">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/RetainedEarnings</seealso>
    let RetainedEarnings =
        Prefixed_Name(fibo_fnd_oac_own, "RetainedEarnings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:ShareholdersEquity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"shareholders' equity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/ShareholdersEquity">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/ShareholdersEquity</seealso>
    let ShareholdersEquity =
        Prefixed_Name(fibo_fnd_oac_own, "ShareholdersEquity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:TangibleAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tangible asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/TangibleAsset">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/TangibleAsset</seealso>
    let TangibleAsset = Prefixed_Name(fibo_fnd_oac_own, "TangibleAsset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:hasAcquisitionPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has acquisition price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasAcquisitionPrice">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasAcquisitionPrice</seealso>
    let hasAcquisitionPrice =
        Prefixed_Name(fibo_fnd_oac_own, "hasAcquisitionPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:hasOwnedAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has owned asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasOwnedAsset">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasOwnedAsset</seealso>
    let hasOwnedAsset = Prefixed_Name(fibo_fnd_oac_own, "hasOwnedAsset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:hasOwningParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has owning party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasOwningParty">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasOwningParty</seealso>
    let hasOwningParty =
        Prefixed_Name(fibo_fnd_oac_own, "hasOwningParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-oac-own:isAssetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is asset of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isAssetOf">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isAssetOf</seealso>
    let isAssetOf = Prefixed_Name(fibo_fnd_oac_own, "isAssetOf") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:isOwnedAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is owned asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwnedAsset">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwnedAsset</seealso>
    let isOwnedAsset = Prefixed_Name(fibo_fnd_oac_own, "isOwnedAsset") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:isOwnedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is owned by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwnedBy">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwnedBy</seealso>
    let isOwnedBy = Prefixed_Name(fibo_fnd_oac_own, "isOwnedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:isOwningParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is owning party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwningParty">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwningParty</seealso>
    let isOwningParty = Prefixed_Name(fibo_fnd_oac_own, "isOwningParty") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/owns">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/owns</seealso>
    let owns = Prefixed_Name(fibo_fnd_oac_own, "owns") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-oac-own:ownsAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owns asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/ownsAsset">https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/ownsAsset</seealso>
    let ownsAsset = Prefixed_Name(fibo_fnd_oac_own, "ownsAsset") |> PrefixedName
