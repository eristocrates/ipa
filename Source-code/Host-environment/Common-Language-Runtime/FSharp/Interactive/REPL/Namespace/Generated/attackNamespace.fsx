#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module attack =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/sepses/vocab/ref/attack#" "attack"

    /// <summary>
    ///   <para>rdfs:label : AdversaryGroup^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#AdversaryGroup">attack:AdversaryGroup</a>
    /// </summary>
    let AdversaryGroup = _prefixId.prefix "AdversaryGroup"
    /// <summary>
    ///   <para>rdfs:label : Asset^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#Asset">attack:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>rdfs:label : Campaign^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#Campaign">attack:Campaign</a>
    /// </summary>
    let Campaign = _prefixId.prefix "Campaign"
    /// <summary>
    ///   <para>rdfs:label : DataComponent^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#DataComponent">attack:DataComponent</a>
    /// </summary>
    let DataComponent = _prefixId.prefix "DataComponent"
    /// <summary>
    ///   <para>rdfs:label : DataSource^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#DataSource">attack:DataSource</a>
    /// </summary>
    let DataSource = _prefixId.prefix "DataSource"
    /// <summary>
    ///   <para>rdfs:label : Malware^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#Malware">attack:Malware</a>
    /// </summary>
    let Malware = _prefixId.prefix "Malware"
    /// <summary>
    ///   <para>rdfs:label : Mitigation^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#Mitigation">attack:Mitigation</a>
    /// </summary>
    let Mitigation = _prefixId.prefix "Mitigation"
    /// <summary>
    ///   <para>rdfs:label : Reference^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#Reference">attack:Reference</a>
    /// </summary>
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:label : Software^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#Software">attack:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>rdfs:label : SubTechnique^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#SubTechnique">attack:SubTechnique</a>
    /// </summary>
    let SubTechnique = _prefixId.prefix "SubTechnique"
    /// <summary>
    ///   <para>rdfs:label : Tactic^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#Tactic">attack:Tactic</a>
    /// </summary>
    let Tactic = _prefixId.prefix "Tactic"
    /// <summary>
    ///   <para>rdfs:label : Technique^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#Technique">attack:Technique</a>
    /// </summary>
    let Technique = _prefixId.prefix "Technique"
    /// <summary>
    ///   <para>rdfs:label : accomplishesTactic^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#accomplishesTactic">attack:accomplishesTactic</a>
    /// </summary>
    let accomplishesTactic = _prefixId.prefix "accomplishesTactic"
    /// <summary>
    ///   <para>rdfs:label : aliases^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#aliases">attack:aliases</a>
    /// </summary>
    let aliases = _prefixId.prefix "aliases"
    /// <summary>
    ///   <para>rdfs:label : associatedGroup^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#associatedGroup">attack:associatedGroup</a>
    /// </summary>
    let associatedGroup = _prefixId.prefix "associatedGroup"
    /// <summary>
    ///   <para>rdfs:label : dataSource^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#dataSource">attack:dataSource</a>
    /// </summary>
    let dataSource = _prefixId.prefix "dataSource"
    /// <summary>
    ///   <para>rdfs:label : detection^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#detection">attack:detection</a>
    /// </summary>
    let detection = _prefixId.prefix "detection"
    /// <summary>
    ///   <para>rdfs:label : hasAdversaryGroup^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#hasAdversaryGroup">attack:hasAdversaryGroup</a>
    /// </summary>
    let hasAdversaryGroup = _prefixId.prefix "hasAdversaryGroup"
    /// <summary>
    ///   <para>rdfs:label : hasCAPEC^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#hasCAPEC">attack:hasCAPEC</a>
    /// </summary>
    let hasCAPEC = _prefixId.prefix "hasCAPEC"
    /// <summary>
    ///   <para>rdfs:label : hasMitigation^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#hasMitigation">attack:hasMitigation</a>
    /// </summary>
    let hasMitigation = _prefixId.prefix "hasMitigation"
    /// <summary>
    ///   <para>rdfs:label : hasReference^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#hasReference">attack:hasReference</a>
    /// </summary>
    let hasReference = _prefixId.prefix "hasReference"
    /// <summary>
    ///   <para>rdfs:label : hasSoftware^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#hasSoftware">attack:hasSoftware</a>
    /// </summary>
    let hasSoftware = _prefixId.prefix "hasSoftware"
    /// <summary>
    ///   <para>rdfs:label : hasTechnique^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#hasTechnique">attack:hasTechnique</a>
    /// </summary>
    let hasTechnique = _prefixId.prefix "hasTechnique"
    /// <summary>
    ///   <para>rdfs:label : implementsTechnique^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#implementsTechnique">attack:implementsTechnique</a>
    /// </summary>
    let implementsTechnique = _prefixId.prefix "implementsTechnique"
    /// <summary>
    ///   <para>rdfs:label : isSubTechniqueOf^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#isSubTechniqueOf">attack:isSubTechniqueOf</a>
    /// </summary>
    let isSubTechniqueOf = _prefixId.prefix "isSubTechniqueOf"
    /// <summary>
    ///   <para>rdfs:label : isSubtechnique^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#isSubtechnique">attack:isSubtechnique</a>
    /// </summary>
    let isSubtechnique = _prefixId.prefix "isSubtechnique"
    /// <summary>
    ///   <para>rdfs:label : permissionRequired^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#permissionRequired">attack:permissionRequired</a>
    /// </summary>
    let permissionRequired = _prefixId.prefix "permissionRequired"
    /// <summary>
    ///   <para>rdfs:label : platform^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#platform">attack:platform</a>
    /// </summary>
    let platform = _prefixId.prefix "platform"
    /// <summary>
    ///   <para>rdfs:label : preventsTechnique^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#preventsTechnique">attack:preventsTechnique</a>
    /// </summary>
    let preventsTechnique = _prefixId.prefix "preventsTechnique"
    /// <summary>
    ///   <para>rdfs:label : referenceDescription^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#referenceDescription">attack:referenceDescription</a>
    /// </summary>
    let referenceDescription = _prefixId.prefix "referenceDescription"
    /// <summary>
    ///   <para>rdfs:label : referenceId^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#referenceId">attack:referenceId</a>
    /// </summary>
    let referenceId = _prefixId.prefix "referenceId"
    /// <summary>
    ///   <para>rdfs:label : referenceName^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#referenceName">attack:referenceName</a>
    /// </summary>
    let referenceName = _prefixId.prefix "referenceName"
    /// <summary>
    ///   <para>rdfs:label : referenceUrl^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#referenceUrl">attack:referenceUrl</a>
    /// </summary>
    let referenceUrl = _prefixId.prefix "referenceUrl"
    /// <summary>
    ///   <para>rdfs:label : targetsAsset^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#targetsAsset">attack:targetsAsset</a>
    /// </summary>
    let targetsAsset = _prefixId.prefix "targetsAsset"
    /// <summary>
    ///   <para>rdfs:label : usesMalware^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#usesMalware">attack:usesMalware</a>
    /// </summary>
    let usesMalware = _prefixId.prefix "usesMalware"
    /// <summary>
    ///   <para>rdfs:label : usesSoftware^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#usesSoftware">attack:usesSoftware</a>
    /// </summary>
    let usesSoftware = _prefixId.prefix "usesSoftware"
    /// <summary>
    ///   <para>rdfs:label : usesTechnique^^xsd:string</para>
    ///   <a href="http://w3id.org/sepses/vocab/ref/attack#usesTechnique">attack:usesTechnique</a>
    /// </summary>
    let usesTechnique = _prefixId.prefix "usesTechnique"
