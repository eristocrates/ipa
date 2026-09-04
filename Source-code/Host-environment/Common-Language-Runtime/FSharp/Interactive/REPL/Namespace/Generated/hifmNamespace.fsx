#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hifm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/hifm/ontology#" "hifm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : This class represents a brand-name drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#Drug">hifm:Drug</a>
    /// </summary>
    let Drug = _prefixId.prefix "Drug"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the dosage form of the medicine.^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#dosageForm">hifm:dosageForm</a>
    /// </summary>
    let dosageForm = _prefixId.prefix "dosageForm"
    /// <summary>
    ///   <para>rdfs:comment : This is the ID that the medicine has in the local system of the Health Insurance Fund of Macedonia^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#id">hifm:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a manufacturer of a drug.^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#manufacturer">hifm:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>rdfs:comment : This property represents additional notes related to a medicine.^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#notes">hifm:notes</a>
    /// </summary>
    let notes = _prefixId.prefix "notes"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the number of units per drug package.^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#packaging">hifm:packaging</a>
    /// </summary>
    let packaging = _prefixId.prefix "packaging"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the referent price of the medicine in macedonian denars (MKD), with NO VAT calculated^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#refPriceNoVAT">hifm:refPriceNoVAT</a>
    /// </summary>
    let refPriceNoVAT = _prefixId.prefix "refPriceNoVAT"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the referent value of the medicine in macedonian denars (MKD), with VAT calculated^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#refPriceWithVAT">hifm:refPriceWithVAT</a>
    /// </summary>
    let refPriceWithVAT = _prefixId.prefix "refPriceWithVAT"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a similarity that is known between two drugs.^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#similarTo">hifm:similarTo</a>
    /// </summary>
    let similarTo = _prefixId.prefix "similarTo"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the strength of the drug, in milligrams.^^xsd:string</para>
    ///   <a href="http://purl.org/net/hifm/ontology#strength">hifm:strength</a>
    /// </summary>
    let strength = _prefixId.prefix "strength"
