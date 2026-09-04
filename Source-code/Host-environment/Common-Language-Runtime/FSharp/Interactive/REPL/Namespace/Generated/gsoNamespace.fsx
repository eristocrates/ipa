#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gso =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/gen/ont#" "gso"
    let ContentTypeGeneric = _prefixId.prefix "ContentTypeGeneric"
    let ContentTypeGenericResource = _prefixId.prefix "ContentTypeGenericResource"
    let ContentTypeSpecificResource = _prefixId.prefix "ContentTypeSpecificResource"
    /// <summary>
    ///   <para>rdfs:label : fixed resource^^xsd:string</para>
    ///   <para>rdfs:comment : A resource whose representation type and content will not
    /// 	    change under any circumstances.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#FixedResource">gso:FixedResource</a>
    /// </summary>
    let FixedResource = _prefixId.prefix "FixedResource"
    /// <summary>
    ///   <para>rdfs:label : information resource^^xsd:string</para>
    ///   <para>rdfs:comment : An Information Resource is defined by the Architecture of
    /// 	    the WWW.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#InformationResource">gso:InformationResource</a>
    /// </summary>
    let InformationResource = _prefixId.prefix "InformationResource"
    let LanguageGenericResource = _prefixId.prefix "LanguageGenericResource"
    let LanguageSpecificResource = _prefixId.prefix "LanguageSpecificResource"
    let TimeGenericResource = _prefixId.prefix "TimeGenericResource"
    let TimeSpecificResource = _prefixId.prefix "TimeSpecificResource"
    /// <summary>
    ///   <para>rdfs:label : Content-Type generic^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#contentTypeGeneric">gso:contentTypeGeneric</a>
    /// </summary>
    let contentTypeGeneric = _prefixId.prefix "contentTypeGeneric"
    /// <summary>
    ///   <para>rdfs:label : Content-Type specific^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#contentTypeSpecific">gso:contentTypeSpecific</a>
    /// </summary>
    let contentTypeSpecific = _prefixId.prefix "contentTypeSpecific"
    let contentTypeSpecificResource = _prefixId.prefix "contentTypeSpecificResource"
    /// <summary>
    ///   <para>rdfs:label : Content-Type specific^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a generic resource and a fixedResource
    ///     which is an everything-specific version of it.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#fixedResource">gso:fixedResource</a>
    /// </summary>
    let fixedResource = _prefixId.prefix "fixedResource"
    /// <summary>
    ///   <para>rdfs:label : language generic^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#languageGeneric">gso:languageGeneric</a>
    /// </summary>
    let languageGeneric = _prefixId.prefix "languageGeneric"
    /// <summary>
    ///   <para>rdfs:label : language specific^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#languageSpecific">gso:languageSpecific</a>
    /// </summary>
    let languageSpecific = _prefixId.prefix "languageSpecific"
    /// <summary>
    ///   <para>rdfs:label : same work as^^xsd:string</para>
    ///   <para>rdfs:comment : The equivalence relation linking all versions of a work,
    ///             specific or generic along various axes.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#sameWorkAs">gso:sameWorkAs</a>
    /// </summary>
    let sameWorkAs = _prefixId.prefix "sameWorkAs"
    /// <summary>
    ///   <para>rdfs:label : time generic^^xsd:string</para>
    ///   <para>rdfs:comment : The related resource which for this time-sepcific resource
    ///             is the related time-generic resource.
    ///             A representation of the time-generic resource may be expected to be
    ///             the most recent time-specific resource at the time of
    ///             the representation.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#timeGeneric">gso:timeGeneric</a>
    /// </summary>
    let timeGeneric = _prefixId.prefix "timeGeneric"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/gen/ont#timeSpecific">gso:timeSpecific</a>
    /// </summary>
    let timeSpecific = _prefixId.prefix "timeSpecific"
    let timeSpecificResource = _prefixId.prefix "timeSpecificResource"
