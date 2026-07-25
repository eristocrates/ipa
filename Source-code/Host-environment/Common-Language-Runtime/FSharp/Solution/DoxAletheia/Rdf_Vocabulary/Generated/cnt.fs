namespace http.www.w3.org._2011.content.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cnt =
    let _namespace_iri = Namespace_Iri cnt |> NamespaceIRI
    /// <summary>
    ///   <para>cnt:ContentAsBase64</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The base64 encoded content (can be used for binary content).</para>
    /// labels<para>Base64 content</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#ContentAsBase64">http://www.w3.org/2011/content#ContentAsBase64</seealso>
    let ContentAsBase64 = Prefixed_Name(cnt, "ContentAsBase64") |> PrefixedName
    /// <summary>
    ///   <para>cnt:ContentAsXML</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The XML content (can only be used for XML-wellformed content).</para>
    /// labels<para>XML content</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#ContentAsXML">http://www.w3.org/2011/content#ContentAsXML</seealso>
    let ContentAsXML = Prefixed_Name(cnt, "ContentAsXML") |> PrefixedName
    /// <summary>
    ///   <para>cnt:bytes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Base64 encoded byte sequence of the content.</para>
    /// labels<para>Base64 encoded byte sequence</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#bytes">http://www.w3.org/2011/content#bytes</seealso>
    let bytes = Prefixed_Name(cnt, "bytes") |> PrefixedName
    /// <summary>
    ///   <para>cnt:leadingMisc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The XML content preceding the document type declaration.</para>
    /// labels<para>XML leading misc</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#leadingMisc">http://www.w3.org/2011/content#leadingMisc</seealso>
    let leadingMisc = Prefixed_Name(cnt, "leadingMisc") |> PrefixedName
    /// <summary>
    ///   <para>cnt:Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The content.</para>
    /// labels<para>Content</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#Content">http://www.w3.org/2011/content#Content</seealso>
    let Content = Prefixed_Name(cnt, "Content") |> PrefixedName
    /// <summary>
    ///   <para>cnt:DoctypeDecl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The document type declaration.</para>
    /// labels<para>Document type declaration</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#DoctypeDecl">http://www.w3.org/2011/content#DoctypeDecl</seealso>
    let DoctypeDecl = Prefixed_Name(cnt, "DoctypeDecl") |> PrefixedName
    /// <summary>
    ///   <para>cnt:chars</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The character sequence of the text content.</para>
    /// labels<para>Character sequence</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#chars">http://www.w3.org/2011/content#chars</seealso>
    let chars = Prefixed_Name(cnt, "chars") |> PrefixedName
    /// <summary>
    ///   <para>cnt:standalone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The standalone declaration in the XML declaration.</para>
    /// labels<para>XML standalone document declaration</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#standalone">http://www.w3.org/2011/content#standalone</seealso>
    let standalone = Prefixed_Name(cnt, "standalone") |> PrefixedName
    /// <summary>
    ///   <para>cnt:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The XML version declared in the XML declaration.</para>
    /// labels<para>XML version</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#version">http://www.w3.org/2011/content#version</seealso>
    let version = Prefixed_Name(cnt, "version") |> PrefixedName
    /// <summary>
    ///   <para>cnt:ContentAsText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The text content (can be used for text content).</para>
    /// labels<para>Text content</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#ContentAsText">http://www.w3.org/2011/content#ContentAsText</seealso>
    let ContentAsText = Prefixed_Name(cnt, "ContentAsText") |> PrefixedName
    /// <summary>
    ///   <para>cnt:characterEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The character encoding used to create a character sequence from a byte sequence or vice versa.</para>
    /// labels<para>Character encoding</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#characterEncoding">http://www.w3.org/2011/content#characterEncoding</seealso>
    let characterEncoding = Prefixed_Name(cnt, "characterEncoding") |> PrefixedName
    /// <summary>
    ///   <para>cnt:doctypeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The document type name.</para>
    /// labels<para>Document type name</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#doctypeName">http://www.w3.org/2011/content#doctypeName</seealso>
    let doctypeName = Prefixed_Name(cnt, "doctypeName") |> PrefixedName
    /// <summary>
    ///   <para>cnt:internalSubset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The internal document type definition subset within the document type declarations.</para>
    /// labels<para>Internal DTD subset</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#internalSubset">http://www.w3.org/2011/content#internalSubset</seealso>
    let internalSubset = Prefixed_Name(cnt, "internalSubset") |> PrefixedName
    /// <summary>
    ///   <para>cnt:declaredEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The character encoding declared in the XML declaration.</para>
    /// labels<para>XML character encoding</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#declaredEncoding">http://www.w3.org/2011/content#declaredEncoding</seealso>
    let declaredEncoding = Prefixed_Name(cnt, "declaredEncoding") |> PrefixedName
    /// <summary>
    ///   <para>cnt:dtDecl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The document type declaration.</para>
    /// labels<para>Document type declaration</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#dtDecl">http://www.w3.org/2011/content#dtDecl</seealso>
    let dtDecl = Prefixed_Name(cnt, "dtDecl") |> PrefixedName
    /// <summary>
    ///   <para>cnt:publicId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The document type declarations's public identifier.</para>
    /// labels<para>Public ID</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#publicId">http://www.w3.org/2011/content#publicId</seealso>
    let publicId = Prefixed_Name(cnt, "publicId") |> PrefixedName
    /// <summary>
    ///   <para>cnt:systemId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The document type declarations's system identifier (typed: xsd:anyURI)</para>
    /// labels<para>System ID</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#systemId">http://www.w3.org/2011/content#systemId</seealso>
    let systemId = Prefixed_Name(cnt, "systemId") |> PrefixedName
    /// <summary>
    ///   <para>cnt:rest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The XML content following the document type declaration.</para>
    /// labels<para>XML rest</para></remarks>
    /// <seealso href="http://www.w3.org/2011/content#rest">http://www.w3.org/2011/content#rest</seealso>
    let rest = Prefixed_Name(cnt, "rest") |> PrefixedName
