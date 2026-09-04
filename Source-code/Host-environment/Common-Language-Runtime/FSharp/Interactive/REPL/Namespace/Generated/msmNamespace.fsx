#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module msm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://iserve.kmi.open.ac.uk/ns/msm#" "msm"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Message Content</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#MessageContent">msm:MessageContent</a>
    /// </summary>
    let MessageContent = _prefixId.prefix "MessageContent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Message Part</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#MessagePart">msm:MessagePart</a>
    /// </summary>
    let MessagePart = _prefixId.prefix "MessagePart"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Operation</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#Operation">msm:Operation</a>
    /// </summary>
    let Operation = _prefixId.prefix "Operation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Service</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#Service">msm:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Fault</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#hasFault">msm:hasFault</a>
    /// </summary>
    let hasFault = _prefixId.prefix "hasFault"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Input</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#hasInput">msm:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    let hasInputFault = _prefixId.prefix "hasInputFault"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Mandatory Part</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#hasMandatoryPart">msm:hasMandatoryPart</a>
    /// </summary>
    let hasMandatoryPart = _prefixId.prefix "hasMandatoryPart"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Name</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#hasName">msm:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Operation</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#hasOperation">msm:hasOperation</a>
    /// </summary>
    let hasOperation = _prefixId.prefix "hasOperation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Optional Part</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#hasOptionalPart">msm:hasOptionalPart</a>
    /// </summary>
    let hasOptionalPart = _prefixId.prefix "hasOptionalPart"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Output</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#hasOutput">msm:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    let hasOutputFault = _prefixId.prefix "hasOutputFault"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has Part</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#hasPart">msm:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    let hasPartTransitive = _prefixId.prefix "hasPartTransitive"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : is grounded in</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/msm#isGroundedIn">msm:isGroundedIn</a>
    /// </summary>
    let isGroundedIn = _prefixId.prefix "isGroundedIn"
