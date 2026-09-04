#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module docso =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/dso#" "docso"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : DocumentService</para>
    ///   <a href="http://purl.org/ontology/dso#DocumentService">docso:DocumentService</a>
    /// </summary>
    let DocumentService = _prefixId.prefix "DocumentService"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Interloan</para>
    ///   <a href="http://purl.org/ontology/dso#Interloan">docso:Interloan</a>
    /// </summary>
    let Interloan = _prefixId.prefix "Interloan"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Loan</para>
    ///   <a href="http://purl.org/ontology/dso#Loan">docso:Loan</a>
    /// </summary>
    let Loan = _prefixId.prefix "Loan"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:stringvs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : OpenAccessrdfs:label : Digitization</para>
    ///   <a href="http://purl.org/ontology/dso#OpenAccess">docso:OpenAccess</a>
    /// </summary>
    let OpenAccess = _prefixId.prefix "OpenAccess"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Presentation</para>
    ///   <a href="http://purl.org/ontology/dso#Presentation">docso:Presentation</a>
    /// </summary>
    let Presentation = _prefixId.prefix "Presentation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasDocument</para>
    ///   <a href="http://purl.org/ontology/dso#hasDocument">docso:hasDocument</a>
    /// </summary>
    let hasDocument = _prefixId.prefix "hasDocument"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasService</para>
    ///   <a href="http://purl.org/ontology/dso#hasService">docso:hasService</a>
    /// </summary>
    let hasService = _prefixId.prefix "hasService"
