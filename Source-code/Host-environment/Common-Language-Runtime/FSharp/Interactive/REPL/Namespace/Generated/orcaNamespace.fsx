#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module orca =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/orca#" "orca"
    let AuthorExplicitly = _prefixId.prefix "AuthorExplicitly"
    let AuthorImplicitly = _prefixId.prefix "AuthorImplicitly"
    /// <summary>
    ///   <para>rdfs:label : Basis^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the basis of the knowledge^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#Basis">orca:Basis</a>
    /// </summary>
    let Basis = _prefixId.prefix "Basis"
    /// <summary>
    ///   <para>rdfs:label : ConfidenceLevel^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates how certain the knowledge is^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#ConfidenceLevel">orca:ConfidenceLevel</a>
    /// </summary>
    let ConfidenceLevel = _prefixId.prefix "ConfidenceLevel"
    let DERI = _prefixId.prefix "DERI"
    let Data = _prefixId.prefix "Data"
    let DoxasticKnowledge = _prefixId.prefix "DoxasticKnowledge"
    let DubitativeKnowledge = _prefixId.prefix "DubitativeKnowledge"
    let HypotheticalKnowledge = _prefixId.prefix "HypotheticalKnowledge"
    let ``Jodi%20Schneider`` = _prefixId.prefix "Jodi%20Schneider"
    let LackOfKnowledge = _prefixId.prefix "LackOfKnowledge"
    let NamedExternalSource = _prefixId.prefix "NamedExternalSource"
    let NamelessExternalSource = _prefixId.prefix "NamelessExternalSource"
    let NoSource = _prefixId.prefix "NoSource"
    let Reasoning = _prefixId.prefix "Reasoning"
    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the source of the knowledge^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#Source">orca:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    let Unidentified = _prefixId.prefix "Unidentified"
    let ahogan = _prefixId.prefix "ahogan"
    /// <summary>
    ///   <para>rdfs:label : directlyLessCertainThan^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#directlyLessCertainThan">orca:directlyLessCertainThan</a>
    /// </summary>
    let directlyLessCertainThan = _prefixId.prefix "directlyLessCertainThan"
    /// <summary>
    ///   <para>rdfs:label : directlyMoreCertainThan^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#directlyMoreCertainThan">orca:directlyMoreCertainThan</a>
    /// </summary>
    let directlyMoreCertainThan = _prefixId.prefix "directlyMoreCertainThan"
    /// <summary>
    ///   <para>rdfs:label : hasBasis^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the basis of the knowledge.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#hasBasis">orca:hasBasis</a>
    /// </summary>
    let hasBasis = _prefixId.prefix "hasBasis"
    /// <summary>
    ///   <para>rdfs:label : hasConfidenceLevel^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the confidence/certainty level of the knowledge.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#hasConfidenceLevel">orca:hasConfidenceLevel</a>
    /// </summary>
    let hasConfidenceLevel = _prefixId.prefix "hasConfidenceLevel"
    /// <summary>
    ///   <para>rdfs:label : hasSource^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the source of the knowledge.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#hasSource">orca:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:label : lessCertain^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#lessCertain">orca:lessCertain</a>
    /// </summary>
    let lessCertain = _prefixId.prefix "lessCertain"
    /// <summary>
    ///   <para>rdfs:label : moreCertain^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/orca#moreCertain">orca:moreCertain</a>
    /// </summary>
    let moreCertain = _prefixId.prefix "moreCertain"
    let rdf = _prefixId.prefix "rdf"
    let ttl = _prefixId.prefix "ttl"
