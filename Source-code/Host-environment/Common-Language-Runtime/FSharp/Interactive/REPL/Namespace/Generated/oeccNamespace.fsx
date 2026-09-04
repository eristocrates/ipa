#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oecc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.oegov.org/core/owl/cc#" "oecc"

    /// <summary>
    ///   <para>rdfs:comment : The name, url and other details of an attribution.^^xsd:string</para>
    ///   <para>rdfs:label : Attributed Source^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/cc#AttributedSource">oecc:AttributedSource</a>
    /// </summary>
    let AttributedSource = _prefixId.prefix "AttributedSource"

    let ``CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense`` =
        _prefixId.prefix "CreativeCommonsAttributionShareAlike3.0_UnitedStatesLicense"

    let TopQuadrantAttribution = _prefixId.prefix "TopQuadrantAttribution"
    /// <summary>
    ///   <para>rdfs:label : attributed source^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/cc#attributedSource">oecc:attributedSource</a>
    /// </summary>
    let attributedSource = _prefixId.prefix "attributedSource"
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:label : licence^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/cc#licence">oecc:licence</a>
    /// </summary>
    let licence = _prefixId.prefix "licence"
    /// <summary>
    ///   <para>rdfs:label : point of contact^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/cc#pointOfContact">oecc:pointOfContact</a>
    /// </summary>
    let pointOfContact = _prefixId.prefix "pointOfContact"
    let revision = _prefixId.prefix "revision"
    /// <summary>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <a href="http://www.oegov.org/core/owl/cc#url">oecc:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
