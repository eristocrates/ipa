#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module deps =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ontologi.es/doap-deps#" "deps"
    let _namespaceIri = _prefixId.prefix ""
    let BuildPhase = _prefixId.prefix "BuildPhase"
    let ConfigurePhase = _prefixId.prefix "ConfigurePhase"
    let CpanId = _prefixId.prefix "CpanId"
    let DebianId = _prefixId.prefix "DebianId"
    /// <summary>
    ///   <para>rdfs:comment : A condition to be met^^xsd:string</para>
    ///   <para>rdfs:label : Dependency^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#Dependency">deps:Dependency</a>
    /// </summary>
    let Dependency = _prefixId.prefix "Dependency"
    let DevelopmentPhase = _prefixId.prefix "DevelopmentPhase"
    let GemId = _prefixId.prefix "GemId"
    /// <summary>
    ///   <para>rdfs:label : Historic Dependency^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#HistoricDependency">deps:HistoricDependency</a>
    /// </summary>
    let HistoricDependency = _prefixId.prefix "HistoricDependency"
    let IdentifierScheme = _prefixId.prefix "IdentifierScheme"
    let Level = _prefixId.prefix "Level"
    let MvnId = _prefixId.prefix "MvnId"
    let Phase = _prefixId.prefix "Phase"
    let PipId = _prefixId.prefix "PipId"
    let Recommended = _prefixId.prefix "Recommended"
    let Required = _prefixId.prefix "Required"
    let RpmId = _prefixId.prefix "RpmId"
    let RuntimePhase = _prefixId.prefix "RuntimePhase"
    let Suggested = _prefixId.prefix "Suggested"
    let TestPhase = _prefixId.prefix "TestPhase"
    /// <summary>
    ///   <para>rdfs:label : build recommendation^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#build-recommendation">deps:build-recommendation</a>
    /// </summary>
    let build_recommendation = _prefixId.prefix "build-recommendation"
    /// <summary>
    ///   <para>rdfs:label : build requirement^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#build-requirement">deps:build-requirement</a>
    /// </summary>
    let build_requirement = _prefixId.prefix "build-requirement"
    /// <summary>
    ///   <para>rdfs:label : build suggestion^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#build-suggestion">deps:build-suggestion</a>
    /// </summary>
    let build_suggestion = _prefixId.prefix "build-suggestion"
    /// <summary>
    ///   <para>rdfs:label : configure recommendation^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#configure-recommendation">deps:configure-recommendation</a>
    /// </summary>
    let configure_recommendation = _prefixId.prefix "configure-recommendation"
    /// <summary>
    ///   <para>rdfs:label : configure requirement^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#configure-requirement">deps:configure-requirement</a>
    /// </summary>
    let configure_requirement = _prefixId.prefix "configure-requirement"
    /// <summary>
    ///   <para>rdfs:label : configure suggestion^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#configure-suggestion">deps:configure-suggestion</a>
    /// </summary>
    let configure_suggestion = _prefixId.prefix "configure-suggestion"
    /// <summary>
    ///   <para>rdfs:label : development recommendation^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#develop-recommendation">deps:develop-recommendation</a>
    /// </summary>
    let develop_recommendation = _prefixId.prefix "develop-recommendation"
    /// <summary>
    ///   <para>rdfs:label : development requirement^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#develop-requirement">deps:develop-requirement</a>
    /// </summary>
    let develop_requirement = _prefixId.prefix "develop-requirement"
    /// <summary>
    ///   <para>rdfs:label : development suggestion^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#develop-suggestion">deps:develop-suggestion</a>
    /// </summary>
    let develop_suggestion = _prefixId.prefix "develop-suggestion"
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>rdfs:label : on^^xsd:string</para>
    ///   <para>rdfs:comment : the range of this property is a little woolly; a doap:Project is certainly fine, as is a literal which acts as an identifier, provided it's qualified with a datatype indicating what scheme it's an identifier in^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#on">deps:on</a>
    /// </summary>
    let on = _prefixId.prefix "on"
    let phase = _prefixId.prefix "phase"
    /// <summary>
    ///   <para>rdfs:label : runtime recommendation^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#runtime-recommendation">deps:runtime-recommendation</a>
    /// </summary>
    let runtime_recommendation = _prefixId.prefix "runtime-recommendation"
    /// <summary>
    ///   <para>rdfs:label : runtime requirement^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#runtime-requirement">deps:runtime-requirement</a>
    /// </summary>
    let runtime_requirement = _prefixId.prefix "runtime-requirement"
    /// <summary>
    ///   <para>rdfs:label : runtime suggestion^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#runtime-suggestion">deps:runtime-suggestion</a>
    /// </summary>
    let runtime_suggestion = _prefixId.prefix "runtime-suggestion"
    /// <summary>
    ///   <para>rdfs:label : since^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#since">deps:since</a>
    /// </summary>
    let since = _prefixId.prefix "since"
    /// <summary>
    ///   <para>rdfs:label : test recommendation^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#test-recommendation">deps:test-recommendation</a>
    /// </summary>
    let test_recommendation = _prefixId.prefix "test-recommendation"
    /// <summary>
    ///   <para>rdfs:label : test requirement^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#test-requirement">deps:test-requirement</a>
    /// </summary>
    let test_requirement = _prefixId.prefix "test-requirement"
    /// <summary>
    ///   <para>rdfs:label : test suggestion^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#test-suggestion">deps:test-suggestion</a>
    /// </summary>
    let test_suggestion = _prefixId.prefix "test-suggestion"
    /// <summary>
    ///   <para>rdfs:label : until^^xsd:string</para>
    ///   <a href="http://ontologi.es/doap-deps#until">deps:until</a>
    /// </summary>
    let until = _prefixId.prefix "until"
