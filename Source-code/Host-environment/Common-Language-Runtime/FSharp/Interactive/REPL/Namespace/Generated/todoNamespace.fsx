#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module todo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/todo#" "todo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasActionTrace^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relationship between an Action and its Trace^^xsd:string</para>
    ///   <a href="https://w3id.org/todo#hasActionTrace">todo:hasActionTrace</a>
    /// </summary>
    let hasActionTrace = _prefixId.prefix "hasActionTrace"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasObtained^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a SecondaryDialogue and the information (ActionTrace/ArgumentTrace/WorldElementTrace) that has been obtained thanks to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo#hasObtained">todo:hasObtained</a>
    /// </summary>
    let hasObtained = _prefixId.prefix "hasObtained"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isActionTraceOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/todo^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relationship between an ActionTrace and the Action it refers to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo#isActionTraceOf">todo:isActionTraceOf</a>
    /// </summary>
    let isActionTraceOf = _prefixId.prefix "isActionTraceOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : obtainedThrough^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a Trace (ActionTrace/ArgumentTrace/WorldElementTrace) and the SecondaryDialogue performed to obtain said Trace.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo#obtainedThrough">todo:obtainedThrough</a>
    /// </summary>
    let obtainedThrough = _prefixId.prefix "obtainedThrough"
