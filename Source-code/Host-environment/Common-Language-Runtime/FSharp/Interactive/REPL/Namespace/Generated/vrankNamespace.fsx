#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vrank =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/voc/vrank#" "vrank"
    /// <summary>
    ///   <para>rdfs:label : algorithm^^xsd:string</para>
    ///   <para>rdfs:comment : A ranking algorithm used to compute the ranking scores associated with an item (vrank:Rank).^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#Algorithm">vrank:Algorithm</a>
    /// </summary>
    let Algorithm = _prefixId.prefix "Algorithm"
    /// <summary>
    ///   <para>rdfs:label : feature^^xsd:string</para>
    ///   <para>rdfs:comment : A feature of a vrank:Algorithm such as Granularity, RankingFactor, etc.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#Feature">vrank:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>rdfs:label : parameter^^xsd:string</para>
    ///   <para>rdfs:comment : A parameter of a vrank:Algorithm such as number of iterations or damping factor.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#Parameter">vrank:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:label : rank^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a ranking score associated with an item.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#Rank">vrank:Rank</a>
    /// </summary>
    let Rank = _prefixId.prefix "Rank"
    /// <summary>
    ///   <para>rdfs:label : computed by^^xsd:string</para>
    ///   <para>rdfs:comment : A vrank:Rank is computed by an vrank:Algorithm.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#computedBy">vrank:computedBy</a>
    /// </summary>
    let computedBy = _prefixId.prefix "computedBy"
    /// <summary>
    ///   <para>rdfs:label : feature id^^xsd:string</para>
    ///   <para>rdfs:comment : The id associated to a vrank:Feature.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#featureId">vrank:featureId</a>
    /// </summary>
    let featureId = _prefixId.prefix "featureId"
    /// <summary>
    ///   <para>rdfs:label : feature value^^xsd:string</para>
    ///   <para>rdfs:comment : The value associated to a vrank:Feature.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#featureValue">vrank:featureValue</a>
    /// </summary>
    let featureValue = _prefixId.prefix "featureValue"
    /// <summary>
    ///   <para>rdfs:label : has feature^^xsd:string</para>
    ///   <para>rdfs:comment : TODO.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#hasFeature">vrank:hasFeature</a>
    /// </summary>
    let hasFeature = _prefixId.prefix "hasFeature"
    /// <summary>
    ///   <para>rdfs:label : has name^^xsd:string</para>
    ///   <para>rdfs:comment : A vrank:Algorithm has a name.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#hasName">vrank:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : has parameter^^xsd:string</para>
    ///   <para>rdfs:comment : TODO.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#hasParameter">vrank:hasParameter</a>
    /// </summary>
    let hasParameter = _prefixId.prefix "hasParameter"
    /// <summary>
    ///   <para>rdfs:label : has rank^^xsd:string</para>
    ///   <para>rdfs:comment : A subject, property or object hasRank a vrank:Rank.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#hasRank">vrank:hasRank</a>
    /// </summary>
    let hasRank = _prefixId.prefix "hasRank"
    /// <summary>
    ///   <para>rdfs:label : has rank timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : The time when a vrank:Rank was computed.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#hasRankTimeStamp">vrank:hasRankTimeStamp</a>
    /// </summary>
    let hasRankTimeStamp = _prefixId.prefix "hasRankTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : parameter id^^xsd:string</para>
    ///   <para>rdfs:comment : The id associated to a vrank:Parameter.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#paramId">vrank:paramId</a>
    /// </summary>
    let paramId = _prefixId.prefix "paramId"
    /// <summary>
    ///   <para>rdfs:label : parameter value^^xsd:string</para>
    ///   <para>rdfs:comment : The value associated to a vrank:Parameter.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#paramValue">vrank:paramValue</a>
    /// </summary>
    let paramValue = _prefixId.prefix "paramValue"
    /// <summary>
    ///   <para>rdfs:label : has rank value^^xsd:string</para>
    ///   <para>rdfs:comment : The numerical value associated to a vrank:Rank.^^xsd:string</para>
    ///   <a href="http://purl.org/voc/vrank#rankValue">vrank:rankValue</a>
    /// </summary>
    let rankValue = _prefixId.prefix "rankValue"
