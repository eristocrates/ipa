#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://iserve.kmi.open.ac.uk/ns/hrests#" "hr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:description : an input parameter that carries an authentication credential (this class is intended for use in sawsdl:modelReference on msm:MessagePart)</para>
    ///   <para>rdfs:label : Authentication Credential</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#AuthenticationCredential">hr:AuthenticationCredential</a>
    /// </summary>
    let AuthenticationCredential = _prefixId.prefix "AuthenticationCredential"
    let MediaType = _prefixId.prefix "MediaType"
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:description : an input parameter that dictates the output format that the service should return (this class is intended for use in sawsdl:modelReference on msm:MessagePart)</para>
    ///   <para>rdfs:label : Output Format Parameter</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#OutputFormatParameter">hr:OutputFormatParameter</a>
    /// </summary>
    let OutputFormatParameter = _prefixId.prefix "OutputFormatParameter"
    /// <summary>
    ///   <para>rdfs:description : URI template for use as a service address, possibly with parameters</para>
    ///   <para>rdfs:label : URI Template</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#URITemplate">hr:URITemplate</a>
    /// </summary>
    let URITemplate = _prefixId.prefix "URITemplate"
    /// <summary>
    ///   <para>rdfs:description : the content type accepted by the operation</para>
    ///   <para>rdfs:label : accepts Content Type</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#acceptsContentType">hr:acceptsContentType</a>
    /// </summary>
    let acceptsContentType = _prefixId.prefix "acceptsContentType"

    /// <summary>
    ///   <para>rdfs:label : automatically Extracted Description</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#automaticallyExtractedDescription">hr:automaticallyExtractedDescription</a>
    /// </summary>
    let automaticallyExtractedDescription =
        _prefixId.prefix "automaticallyExtractedDescription"

    /// <summary>
    ///   <para>rdfs:description : the address of the operation or service (expected to be used on msm:Service or msm:Operation)</para>
    ///   <para>rdfs:label : has Address</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#hasAddress">hr:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>rdfs:label : has Comment</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#hasComment">hr:hasComment</a>
    /// </summary>
    let hasComment = _prefixId.prefix "hasComment"
    /// <summary>
    ///   <para>rdfs:description : the method of an operation</para>
    ///   <para>rdfs:label : has Method</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#hasMethod">hr:hasMethod</a>
    /// </summary>
    let hasMethod = _prefixId.prefix "hasMethod"
    /// <summary>
    ///   <para>rdfs:description : the URI template parameter in which a message part is grounded (may be accompanied by sawsdl lowering schema mapping)</para>
    ///   <para>rdfs:label : is Grounded In</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#isGroundedIn">hr:isGroundedIn</a>
    /// </summary>
    let isGroundedIn = _prefixId.prefix "isGroundedIn"
    /// <summary>
    ///   <para>rdfs:description : the content type produced by the operation</para>
    ///   <para>rdfs:label : produces Content Type</para>
    ///   <a href="http://iserve.kmi.open.ac.uk/ns/hrests#producesContentType">hr:producesContentType</a>
    /// </summary>
    let producesContentType = _prefixId.prefix "producesContentType"
