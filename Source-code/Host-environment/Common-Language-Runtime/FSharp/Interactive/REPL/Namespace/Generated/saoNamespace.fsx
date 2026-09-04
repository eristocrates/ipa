#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sao =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://salt.semanticauthoring.org/ontologies/sao#" "sao"

    /// <summary>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#Annotation">sao:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:label : CitationContext^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#CitationContext">sao:CitationContext</a>
    /// </summary>
    let CitationContext = _prefixId.prefix "CitationContext"
    /// <summary>
    ///   <para>rdfs:label : annotates^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#annotates">sao:annotates</a>
    /// </summary>
    let annotates = _prefixId.prefix "annotates"
    /// <summary>
    ///   <para>rdfs:label : cites^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#cites">sao:cites</a>
    /// </summary>
    let cites = _prefixId.prefix "cites"
    /// <summary>
    ///   <para>rdfs:label : hasCitationContext^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#hasCitationContext">sao:hasCitationContext</a>
    /// </summary>
    let hasCitationContext = _prefixId.prefix "hasCitationContext"
    /// <summary>
    ///   <para>rdfs:label : hasCitationKey^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#hasCitationKey">sao:hasCitationKey</a>
    /// </summary>
    let hasCitationKey = _prefixId.prefix "hasCitationKey"
    /// <summary>
    ///   <para>rdfs:label : hasTopic^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#hasTopic">sao:hasTopic</a>
    /// </summary>
    let hasTopic = _prefixId.prefix "hasTopic"
    /// <summary>
    ///   <para>rdfs:label : isCitedBy^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#isCitedBy">sao:isCitedBy</a>
    /// </summary>
    let isCitedBy = _prefixId.prefix "isCitedBy"
    /// <summary>
    ///   <para>rdfs:label : pointsTo^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sao#pointsTo">sao:pointsTo</a>
    /// </summary>
    let pointsTo = _prefixId.prefix "pointsTo"
