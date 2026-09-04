#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cnt =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2011/content#" "cnt"
    /// <summary>
    ///   <para>rdfs:comment : The content.</para>
    ///   <para>rdfs:label : Content</para>
    ///   <a href="http://www.w3.org/2011/content#Content">cnt:Content</a>
    /// </summary>
    let Content = _prefixId.prefix "Content"
    /// <summary>
    ///   <para>rdfs:comment : The base64 encoded content (can be used for binary content).</para>
    ///   <para>rdfs:label : Base64 content</para>
    ///   <a href="http://www.w3.org/2011/content#ContentAsBase64">cnt:ContentAsBase64</a>
    /// </summary>
    let ContentAsBase64 = _prefixId.prefix "ContentAsBase64"
    /// <summary>
    ///   <para>rdfs:comment : The text content (can be used for text content).</para>
    ///   <para>rdfs:label : Text content</para>
    ///   <a href="http://www.w3.org/2011/content#ContentAsText">cnt:ContentAsText</a>
    /// </summary>
    let ContentAsText = _prefixId.prefix "ContentAsText"
    /// <summary>
    ///   <para>rdfs:comment : The XML content (can only be used for XML-wellformed content).</para>
    ///   <para>rdfs:label : XML content</para>
    ///   <a href="http://www.w3.org/2011/content#ContentAsXML">cnt:ContentAsXML</a>
    /// </summary>
    let ContentAsXML = _prefixId.prefix "ContentAsXML"
    /// <summary>
    ///   <para>rdfs:comment : The document type declaration.</para>
    ///   <para>rdfs:label : Document type declaration</para>
    ///   <a href="http://www.w3.org/2011/content#DoctypeDecl">cnt:DoctypeDecl</a>
    /// </summary>
    let DoctypeDecl = _prefixId.prefix "DoctypeDecl"
    /// <summary>
    ///   <para>rdfs:comment : The Base64 encoded byte sequence of the content.</para>
    ///   <para>rdfs:label : Base64 encoded byte sequence</para>
    ///   <a href="http://www.w3.org/2011/content#bytes">cnt:bytes</a>
    /// </summary>
    let bytes = _prefixId.prefix "bytes"
    /// <summary>
    ///   <para>rdfs:comment : The character encoding used to create a character sequence from a byte sequence or vice versa.</para>
    ///   <para>rdfs:label : Character encoding</para>
    ///   <a href="http://www.w3.org/2011/content#characterEncoding">cnt:characterEncoding</a>
    /// </summary>
    let characterEncoding = _prefixId.prefix "characterEncoding"
    /// <summary>
    ///   <para>rdfs:comment : The character sequence of the text content.</para>
    ///   <para>rdfs:label : Character sequence</para>
    ///   <a href="http://www.w3.org/2011/content#chars">cnt:chars</a>
    /// </summary>
    let chars = _prefixId.prefix "chars"
    /// <summary>
    ///   <para>rdfs:comment : The character encoding declared in the XML declaration.</para>
    ///   <para>rdfs:label : XML character encoding</para>
    ///   <a href="http://www.w3.org/2011/content#declaredEncoding">cnt:declaredEncoding</a>
    /// </summary>
    let declaredEncoding = _prefixId.prefix "declaredEncoding"
    /// <summary>
    ///   <para>rdfs:comment : The document type name.</para>
    ///   <para>rdfs:label : Document type name</para>
    ///   <a href="http://www.w3.org/2011/content#doctypeName">cnt:doctypeName</a>
    /// </summary>
    let doctypeName = _prefixId.prefix "doctypeName"
    /// <summary>
    ///   <para>rdfs:comment : The document type declaration.</para>
    ///   <para>rdfs:label : Document type declaration</para>
    ///   <a href="http://www.w3.org/2011/content#dtDecl">cnt:dtDecl</a>
    /// </summary>
    let dtDecl = _prefixId.prefix "dtDecl"
    /// <summary>
    ///   <para>rdfs:comment : The internal document type definition subset within the document type declarations.</para>
    ///   <para>rdfs:label : Internal DTD subset</para>
    ///   <a href="http://www.w3.org/2011/content#internalSubset">cnt:internalSubset</a>
    /// </summary>
    let internalSubset = _prefixId.prefix "internalSubset"
    /// <summary>
    ///   <para>rdfs:comment : The XML content preceding the document type declaration.</para>
    ///   <para>rdfs:label : XML leading misc</para>
    ///   <a href="http://www.w3.org/2011/content#leadingMisc">cnt:leadingMisc</a>
    /// </summary>
    let leadingMisc = _prefixId.prefix "leadingMisc"
    /// <summary>
    ///   <para>rdfs:comment : The document type declarations's public identifier.</para>
    ///   <para>rdfs:label : Public ID</para>
    ///   <a href="http://www.w3.org/2011/content#publicId">cnt:publicId</a>
    /// </summary>
    let publicId = _prefixId.prefix "publicId"
    /// <summary>
    ///   <para>rdfs:comment : The XML content following the document type declaration.</para>
    ///   <para>rdfs:label : XML rest</para>
    ///   <a href="http://www.w3.org/2011/content#rest">cnt:rest</a>
    /// </summary>
    let rest = _prefixId.prefix "rest"
    /// <summary>
    ///   <para>rdfs:comment : The standalone declaration in the XML declaration.</para>
    ///   <para>rdfs:label : XML standalone document declaration</para>
    ///   <a href="http://www.w3.org/2011/content#standalone">cnt:standalone</a>
    /// </summary>
    let standalone = _prefixId.prefix "standalone"
    /// <summary>
    ///   <para>rdfs:comment : The document type declarations's system identifier (typed: xsd:anyURI)</para>
    ///   <para>rdfs:label : System ID</para>
    ///   <a href="http://www.w3.org/2011/content#systemId">cnt:systemId</a>
    /// </summary>
    let systemId = _prefixId.prefix "systemId"
    /// <summary>
    ///   <para>rdfs:comment : The XML version declared in the XML declaration.</para>
    ///   <para>rdfs:label : XML version</para>
    ///   <a href="http://www.w3.org/2011/content#version">cnt:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
