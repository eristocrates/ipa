#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdfa =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/rdfa#" "rdfa"
    let _namespaceIri = _prefixId.prefix ""
    let DocumentError = _prefixId.prefix "DocumentError"
    let Error = _prefixId.prefix "Error"
    let Info = _prefixId.prefix "Info"
    /// <summary>
    ///   <para>dcterms:description : is the top level class of the hierarchy^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#PGClass">rdfa:PGClass</a>
    /// </summary>
    let PGClass = _prefixId.prefix "PGClass"
    /// <summary>
    ///   <para>dcterms:description : Class to identify an (RDF) resource whose properties are to be copied to another resource^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#Pattern">rdfa:Pattern</a>
    /// </summary>
    let Pattern = _prefixId.prefix "Pattern"
    let PrefixMapping = _prefixId.prefix "PrefixMapping"
    /// <summary>
    ///   <para>dcterms:description : is the top level class for prefix or term mappings^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#PrefixOrTermMapping">rdfa:PrefixOrTermMapping</a>
    /// </summary>
    let PrefixOrTermMapping = _prefixId.prefix "PrefixOrTermMapping"
    let PrefixRedefinition = _prefixId.prefix "PrefixRedefinition"
    let TermMapping = _prefixId.prefix "TermMapping"
    let UnresolvedCURIE = _prefixId.prefix "UnresolvedCURIE"
    let UnresolvedTerm = _prefixId.prefix "UnresolvedTerm"
    let VocabReferenceError = _prefixId.prefix "VocabReferenceError"
    let Warning = _prefixId.prefix "Warning"
    /// <summary>
    ///   <para>dcterms:description : provides extra context for the error, eg, http response, an XPointer/XPath information, or simply the URI that created the error^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#context">rdfa:context</a>
    /// </summary>
    let context = _prefixId.prefix "context"
    /// <summary>
    ///   <para>dcterms:description : identifies the resource (i.e., pattern) whose properties and values should be copied to replace the current triple (retaining the subject of the triple).^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#copy">rdfa:copy</a>
    /// </summary>
    let copy = _prefixId.prefix "copy"
    /// <summary>
    ///   <para>dcterms:description : defines a prefix mapping for a URI; the value is supposed to be a NMTOKEN^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#prefix">rdfa:prefix</a>
    /// </summary>
    let prefix = _prefixId.prefix "prefix"
    /// <summary>
    ///   <para>dcterms:description : defines a term mapping for a URI; the value is supposed to be a NMTOKEN^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#term">rdfa:term</a>
    /// </summary>
    let term = _prefixId.prefix "term"
    /// <summary>
    ///   <para>dcterms:description : defines the URI for either a prefix or a term mapping; the value is supposed to be an absolute URI^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#uri">rdfa:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
    /// <summary>
    ///   <para>dcterms:description : provides a relationship between the host document and a vocabulary
    /// 	defined using the @vocab facility of RDFa1.1^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#usesVocabulary">rdfa:usesVocabulary</a>
    /// </summary>
    let usesVocabulary = _prefixId.prefix "usesVocabulary"
    /// <summary>
    ///   <para>dcterms:description : defines an absolute URI to be used as a default vocabulary; the value is can be any string; for documentation purposes it is advised to use the string 'true' or 'True'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/rdfa#vocabulary">rdfa:vocabulary</a>
    /// </summary>
    let vocabulary = _prefixId.prefix "vocabulary"
