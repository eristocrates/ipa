#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module odpart =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/participation.owl#" "odpart"

    /// <summary>
    ///   <para>rdfs:comment : Any physical, social, or mental process, event, or state.^^xsd:string</para>
    ///   <para>rdfs:label : Event</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Event">odpart:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:comment : Any physical, social, or mental object, or substance^^xsd:string</para>
    ///   <para>rdfs:label : Object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Object">odpart:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : has participant</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#hasParticipant">odpart:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:label : is participant in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#isParticipantIn">odpart:isParticipantIn</a>
    /// </summary>
    let isParticipantIn = _prefixId.prefix "isParticipantIn"
