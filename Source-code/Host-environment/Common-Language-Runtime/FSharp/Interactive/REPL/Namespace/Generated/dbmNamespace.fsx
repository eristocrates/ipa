#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dbm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/dbm/ontology#" "dbm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : This class represents a Drug entity from the Macedonian Drug Bureau.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#Drug">dbm:Drug</a>
    /// </summary>
    let Drug = _prefixId.prefix "Drug"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the approval number assigned by the Macedonian Drug Bureau, for the company.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#approvalNumber">dbm:approvalNumber</a>
    /// </summary>
    let approvalNumber = _prefixId.prefix "approvalNumber"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the company which holds the approval by the Macedonian Drug Bureau for the drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#approvedFor">dbm:approvedFor</a>
    /// </summary>
    let approvedFor = _prefixId.prefix "approvedFor"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the date the company was given the approval by the Macedonian Drug Bureau for the drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#approvedOn">dbm:approvedOn</a>
    /// </summary>
    let approvedOn = _prefixId.prefix "approvedOn"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the expiry date of the approval which the company was given by the Macedonian Drug Bureau for the drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#approvedUntil">dbm:approvedUntil</a>
    /// </summary>
    let approvedUntil = _prefixId.prefix "approvedUntil"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the extended ATC code for the drug, assigned by the Ministry of Health, of the Republic of Macedonia.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#atcCodeExtended">dbm:atcCodeExtended</a>
    /// </summary>
    let atcCodeExtended = _prefixId.prefix "atcCodeExtended"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates wether the drug packaging has Braille support or not.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#brailleSupport">dbm:brailleSupport</a>
    /// </summary>
    let brailleSupport = _prefixId.prefix "brailleSupport"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the brand name of the drug, in cyrillic alphabet.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#brandNameCyrillic">dbm:brandNameCyrillic</a>
    /// </summary>
    let brandNameCyrillic = _prefixId.prefix "brandNameCyrillic"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the dosage information for the drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#dosage">dbm:dosage</a>
    /// </summary>
    let dosage = _prefixId.prefix "dosage"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the EAN code of the drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#eanCode">dbm:eanCode</a>
    /// </summary>
    let eanCode = _prefixId.prefix "eanCode"
    /// <summary>
    ///   <para>rdfs:comment : This is the code that the drug instance has in the local system of the Health Insurance Fund of Macedonia.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#hifmCode">dbm:hifmCode</a>
    /// </summary>
    let hifmCode = _prefixId.prefix "hifmCode"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a manufacturer of a drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#manufacturer">dbm:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the packaging information of the drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#packaging">dbm:packaging</a>
    /// </summary>
    let packaging = _prefixId.prefix "packaging"
    /// <summary>
    ///   <para>rdfs:comment : This property tells if the drug is featured on the positive list of drugs, or not.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#positiveList">dbm:positiveList</a>
    /// </summary>
    let positiveList = _prefixId.prefix "positiveList"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the price of the drug in Macedonian Denars (MKD), with VAT calculated.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#priceWithVAT">dbm:priceWithVAT</a>
    /// </summary>
    let priceWithVAT = _prefixId.prefix "priceWithVAT"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the price of the drug in Macedonian Denars (MKD), with no VAT calculated.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#priceWithoutVAT">dbm:priceWithoutVAT</a>
    /// </summary>
    let priceWithoutVAT = _prefixId.prefix "priceWithoutVAT"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the reference price for the drug, as assigned by the Ministry of Health of the Republic of Macedonia.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#referencePrice">dbm:referencePrice</a>
    /// </summary>
    let referencePrice = _prefixId.prefix "referencePrice"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to represent that the drugs in question are similar in their purpose, i.e. contain the same active substance.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#similarTo">dbm:similarTo</a>
    /// </summary>
    let similarTo = _prefixId.prefix "similarTo"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the strength of the drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#strength">dbm:strength</a>
    /// </summary>
    let strength = _prefixId.prefix "strength"
    /// <summary>
    ///   <para>rdfs:comment : This property holds the URL to the summary report for the drug, published by the Macedonian Drug Bureau.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#summaryReport">dbm:summaryReport</a>
    /// </summary>
    let summaryReport = _prefixId.prefix "summaryReport"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the date the drug data has been updated.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#updateDate">dbm:updateDate</a>
    /// </summary>
    let updateDate = _prefixId.prefix "updateDate"
    /// <summary>
    ///   <para>rdfs:comment : This property holds the URL to the usage guidelines for the drug, published by the Macedonian Drug Bureau.^^xsd:string</para>
    ///   <a href="http://purl.org/net/dbm/ontology#usageGuidelines">dbm:usageGuidelines</a>
    /// </summary>
    let usageGuidelines = _prefixId.prefix "usageGuidelines"
