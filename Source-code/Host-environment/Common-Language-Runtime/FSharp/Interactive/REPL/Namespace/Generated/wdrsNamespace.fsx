#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wdrs =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2007/05/powder-s#" "wdrs"

    /// <summary>
    ///   <para>rdfs:label : POWDER document</para>
    ///   <para>rdfs:comment : A POWDER document.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#Document">wdrs:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : POWDER processor</para>
    ///   <para>rdfs:comment : A software agent able to process POWDER documents.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#Processor">wdrs:Processor</a>
    /// </summary>
    let Processor = _prefixId.prefix "Processor"
    /// <summary>
    ///   <para>rdfs:label : authenticate</para>
    ///   <para>rdfs:comment : A pointer to a document that describes how Description Resources created by a FOAF Agent or a DC Terms Agent may be authenticated</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#authenticate">wdrs:authenticate</a>
    /// </summary>
    let authenticate = _prefixId.prefix "authenticate"
    /// <summary>
    ///   <para>rdfs:label : certified</para>
    ///   <para>rdfs:comment : A property that takes a Boolean value to declare whether the author of the data certifies the described resource.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#certified">wdrs:certified</a>
    /// </summary>
    let certified = _prefixId.prefix "certified"
    /// <summary>
    ///   <para>rdfs:label : certified by</para>
    ///   <para>rdfs:comment : A property that links a resource to a POWDER document that certifies it.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#certifiedby">wdrs:certifiedby</a>
    /// </summary>
    let certifiedby = _prefixId.prefix "certifiedby"
    /// <summary>
    ///   <para>rdfs:label : data error</para>
    ///   <para>rdfs:comment : A property denoting a description of the specific error found in a given POWDER document.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#data_error">wdrs:data_error</a>
    /// </summary>
    let data_error = _prefixId.prefix "data_error"
    /// <summary>
    ///   <para>rdfs:label : described by</para>
    ///   <para>rdfs:comment : An RDF property to exactly match the describedby relationship type introduced in http://www.w3.org/TR/powder-dr/#assoc-linking and formally defined in appendix D of the same document, i.e. the relationship A 'describedby' B asserts that resource B provides a description of resource A. There are no constraints on the format or representation of either A or B, neither are there any further constraints on either resource.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#describedby">wdrs:describedby</a>
    /// </summary>
    let describedby = _prefixId.prefix "describedby"
    /// <summary>
    ///   <para>rdfs:label : error code</para>
    ///   <para>rdfs:comment : A property denoting the code of any error encountered by the POWDER processor.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#error_code">wdrs:error_code</a>
    /// </summary>
    let error_code = _prefixId.prefix "error_code"
    /// <summary>
    ///   <para>rdfs:label : has IRI</para>
    ///   <para>rdfs:comment : This property is meant to be used in OWL2 instead of wdrs:matchesregex. It denotes the string data range corresponding to a set of IRIs.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#hasIRI">wdrs:hasIRI</a>
    /// </summary>
    let hasIRI = _prefixId.prefix "hasIRI"
    /// <summary>
    ///   <para>rdfs:label : issued by</para>
    ///   <para>rdfs:comment : This property denotes the author of a POWDER document.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#issuedby">wdrs:issuedby</a>
    /// </summary>
    let issuedby = _prefixId.prefix "issuedby"
    /// <summary>
    ///   <para>rdfs:label : logo</para>
    ///   <para>rdfs:comment : Points to a graphic summary for the resources in a given class. Typically, it is a logo denoting conformance of a given (set of) resource(s) to a given set of criteria.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#logo">wdrs:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    /// <summary>
    ///   <para>rdfs:label : matches regular expression</para>
    ///   <para>rdfs:comment : This is the key 'include' property for IRI set definitions in POWDER-S. It is necessary to take account of the POWDER Semantic Extension to process this fully. The value is a regular expression that is matched against an IRI.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#matchesregex">wdrs:matchesregex</a>
    /// </summary>
    let matchesregex = _prefixId.prefix "matchesregex"
    /// <summary>
    ///   <para>rdfs:label : not known to</para>
    ///   <para>rdfs:comment : Property used in results returned from a POWDER Processor that has no data about the candidate resource. The value is the IRI of the processor.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#notknownto">wdrs:notknownto</a>
    /// </summary>
    let notknownto = _prefixId.prefix "notknownto"
    /// <summary>
    ///   <para>rdfs:label : matches regular expression</para>
    ///   <para>rdfs:comment : This is the key 'exclude' property for IRI set definitions in POWDER-S. It is necessary to take account of the POWDER Semantic Extension to process this fully. The value is a regular expression that is matched against an IRI.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#notmatchesregex">wdrs:notmatchesregex</a>
    /// </summary>
    let notmatchesregex = _prefixId.prefix "notmatchesregex"
    /// <summary>
    ///   <para>rdfs:label : processing error</para>
    ///   <para>rdfs:comment : A property denoting a description of the specific software error.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#proc_error">wdrs:proc_error</a>
    /// </summary>
    let proc_error = _prefixId.prefix "proc_error"
    /// <summary>
    ///   <para>rdfs:label : SHA-1 sum</para>
    ///   <para>rdfs:comment : Links to a Base64-encoded binary SHA-1 hash of the described resource. May be used by POWDER Processors when assessing trustworthiness of a DR.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#sha1sum">wdrs:sha1sum</a>
    /// </summary>
    let sha1sum = _prefixId.prefix "sha1sum"
    /// <summary>
    ///   <para>rdfs:label : supported by</para>
    ///   <para>rdfs:comment : A property that links a POWDER document to some other data source that supports the descriptions provided.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#supportedby">wdrs:supportedby</a>
    /// </summary>
    let supportedby = _prefixId.prefix "supportedby"
    /// <summary>
    ///   <para>rdfs:label : tag</para>
    ///   <para>rdfs:comment : Property linking to a free-text tag which may include spaces.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#tag">wdrs:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    /// <summary>
    ///   <para>rdfs:label : text that may be displayed</para>
    ///   <para>rdfs:comment : This property provides a summary of the descriptorset that it annotates, suitable for display to end users.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#text">wdrs:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:label : valid from</para>
    ///   <para>rdfs:comment : Provides a timestamp that a POWDER Processor may use when assessing trustworthiness of a POWDER document. Informally, a POWDER Processor should normally ignore data in the document before the given date.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#validfrom">wdrs:validfrom</a>
    /// </summary>
    let validfrom = _prefixId.prefix "validfrom"
    /// <summary>
    ///   <para>rdfs:label : valid until</para>
    ///   <para>rdfs:comment : Provides a timestamp that a POWDER Processor may use when assessing trustworthiness of a POWDER document. Informally, a POWDER Processor should normally ignore data in the document after the given date.</para>
    ///   <a href="http://www.w3.org/2007/05/powder-s#validuntil">wdrs:validuntil</a>
    /// </summary>
    let validuntil = _prefixId.prefix "validuntil"
