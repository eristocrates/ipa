#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tddial =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododial#" "tddial"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasDialogueProcessStep^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododial#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the DialogueProcessStep corresponding to a DialogueTrace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododial#hasDialogueProcessStep">tddial:hasDialogueProcessStep</a>
    /// </summary>
    let hasDialogueProcessStep = _prefixId.prefix "hasDialogueProcessStep"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododial#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relationship between an element and its Trace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododial#hasTrace">tddial:hasTrace</a>
    /// </summary>
    let hasTrace = _prefixId.prefix "hasTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isTraceOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododial#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relationship between a Trace and the element it refers to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododial#isTraceOf">tddial:isTraceOf</a>
    /// </summary>
    let isTraceOf = _prefixId.prefix "isTraceOf"
