namespace http.purl.org.net.dbm.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dbm =
    let _namespace_iri = Namespace_Iri dbm |> NamespaceIRI
    /// <summary>
    ///   <para>dbm:Drug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a Drug entity from the Macedonian Drug Bureau.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#Drug">http://purl.org/net/dbm/ontology#Drug</seealso>
    let Drug = Prefixed_Name(dbm, "Drug") |> PrefixedName
    /// <summary>
    ///   <para>dbm:approvedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the date the company was given the approval by the Macedonian Drug Bureau for the drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#approvedOn">http://purl.org/net/dbm/ontology#approvedOn</seealso>
    let approvedOn = Prefixed_Name(dbm, "approvedOn") |> PrefixedName
    /// <summary>
    ///   <para>dbm:atcCodeExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the extended ATC code for the drug, assigned by the Ministry of Health, of the Republic of Macedonia.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#atcCodeExtended">http://purl.org/net/dbm/ontology#atcCodeExtended</seealso>
    let atcCodeExtended = Prefixed_Name(dbm, "atcCodeExtended") |> PrefixedName
    /// <summary>
    ///   <para>dbm:brailleSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property indicates wether the drug packaging has Braille support or not.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#brailleSupport">http://purl.org/net/dbm/ontology#brailleSupport</seealso>
    let brailleSupport = Prefixed_Name(dbm, "brailleSupport") |> PrefixedName
    /// <summary>
    ///   <para>dbm:eanCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property represents the EAN code of the drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#eanCode">http://purl.org/net/dbm/ontology#eanCode</seealso>
    let eanCode = Prefixed_Name(dbm, "eanCode") |> PrefixedName
    /// <summary>
    ///   <para>dbm:hifmCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This is the code that the drug instance has in the local system of the Health Insurance Fund of Macedonia.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#hifmCode">http://purl.org/net/dbm/ontology#hifmCode</seealso>
    let hifmCode = Prefixed_Name(dbm, "hifmCode") |> PrefixedName
    /// <summary>
    ///   <para>dbm:packaging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the packaging information of the drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#packaging">http://purl.org/net/dbm/ontology#packaging</seealso>
    let packaging = Prefixed_Name(dbm, "packaging") |> PrefixedName
    /// <summary>
    ///   <para>dbm:positiveList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property tells if the drug is featured on the positive list of drugs, or not.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#positiveList">http://purl.org/net/dbm/ontology#positiveList</seealso>
    let positiveList = Prefixed_Name(dbm, "positiveList") |> PrefixedName
    /// <summary>
    ///   <para>dbm:priceWithoutVAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the price of the drug in Macedonian Denars (MKD), with no VAT calculated.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#priceWithoutVAT">http://purl.org/net/dbm/ontology#priceWithoutVAT</seealso>
    let priceWithoutVAT = Prefixed_Name(dbm, "priceWithoutVAT") |> PrefixedName
    /// <summary>
    ///   <para>dbm:referencePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the reference price for the drug, as assigned by the Ministry of Health of the Republic of Macedonia.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#referencePrice">http://purl.org/net/dbm/ontology#referencePrice</seealso>
    let referencePrice = Prefixed_Name(dbm, "referencePrice") |> PrefixedName
    /// <summary>
    ///   <para>dbm:strength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the strength of the drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#strength">http://purl.org/net/dbm/ontology#strength</seealso>
    let strength = Prefixed_Name(dbm, "strength") |> PrefixedName
    /// <summary>
    ///   <para>dbm:summaryReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property holds the URL to the summary report for the drug, published by the Macedonian Drug Bureau.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#summaryReport">http://purl.org/net/dbm/ontology#summaryReport</seealso>
    let summaryReport = Prefixed_Name(dbm, "summaryReport") |> PrefixedName
    /// <summary>
    ///   <para>dbm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>An ontology for the Drug Bureau of Macedonia (DBM).</para>
    /// labels<para>DBM Ontology</para></remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#">http://purl.org/net/dbm/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(dbm, "") |> PrefixedName
    /// <summary>
    ///   <para>dbm:approvalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the approval number assigned by the Macedonian Drug Bureau, for the company.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#approvalNumber">http://purl.org/net/dbm/ontology#approvalNumber</seealso>
    let approvalNumber = Prefixed_Name(dbm, "approvalNumber") |> PrefixedName
    /// <summary>
    ///   <para>dbm:approvedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the company which holds the approval by the Macedonian Drug Bureau for the drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#approvedFor">http://purl.org/net/dbm/ontology#approvedFor</seealso>
    let approvedFor = Prefixed_Name(dbm, "approvedFor") |> PrefixedName
    /// <summary>
    ///   <para>dbm:approvedUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the expiry date of the approval which the company was given by the Macedonian Drug Bureau for the drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#approvedUntil">http://purl.org/net/dbm/ontology#approvedUntil</seealso>
    let approvedUntil = Prefixed_Name(dbm, "approvedUntil") |> PrefixedName
    /// <summary>
    ///   <para>dbm:brandNameCyrillic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the brand name of the drug, in cyrillic alphabet.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#brandNameCyrillic">http://purl.org/net/dbm/ontology#brandNameCyrillic</seealso>
    let brandNameCyrillic = Prefixed_Name(dbm, "brandNameCyrillic") |> PrefixedName
    /// <summary>
    ///   <para>dbm:dosage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the dosage information for the drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#dosage">http://purl.org/net/dbm/ontology#dosage</seealso>
    let dosage = Prefixed_Name(dbm, "dosage") |> PrefixedName
    /// <summary>
    ///   <para>dbm:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents a manufacturer of a drug.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#manufacturer">http://purl.org/net/dbm/ontology#manufacturer</seealso>
    let manufacturer = Prefixed_Name(dbm, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>dbm:priceWithVAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the price of the drug in Macedonian Denars (MKD), with VAT calculated.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#priceWithVAT">http://purl.org/net/dbm/ontology#priceWithVAT</seealso>
    let priceWithVAT = Prefixed_Name(dbm, "priceWithVAT") |> PrefixedName
    /// <summary>
    ///   <para>dbm:similarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to represent that the drugs in question are similar in their purpose, i.e. contain the same active substance.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#similarTo">http://purl.org/net/dbm/ontology#similarTo</seealso>
    let similarTo = Prefixed_Name(dbm, "similarTo") |> PrefixedName
    /// <summary>
    ///   <para>dbm:updateDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the date the drug data has been updated.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#updateDate">http://purl.org/net/dbm/ontology#updateDate</seealso>
    let updateDate = Prefixed_Name(dbm, "updateDate") |> PrefixedName
    /// <summary>
    ///   <para>dbm:usageGuidelines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property holds the URL to the usage guidelines for the drug, published by the Macedonian Drug Bureau.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/dbm/ontology#usageGuidelines">http://purl.org/net/dbm/ontology#usageGuidelines</seealso>
    let usageGuidelines = Prefixed_Name(dbm, "usageGuidelines") |> PrefixedName
