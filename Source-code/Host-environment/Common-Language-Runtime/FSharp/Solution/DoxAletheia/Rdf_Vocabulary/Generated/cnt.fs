namespace http.www.w3.org._2011.content.hash

open DoxAletheia

module cnt =
    let _namespace_name = "http://www.w3.org/2011/content#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The content.
    /// <see href="http://www.w3.org/2011/content#Content"></see></summary>
    let Content = _prefix "Content"
    /// <summary>
    /// The base64 encoded content (can be used for binary content).
    /// <see href="http://www.w3.org/2011/content#ContentAsBase64"></see></summary>
    let ContentAsBase64 = _prefix "ContentAsBase64"
    /// <summary>
    /// The text content (can be used for text content).
    /// <see href="http://www.w3.org/2011/content#ContentAsText"></see></summary>
    let ContentAsText = _prefix "ContentAsText"
    /// <summary>
    /// The XML content (can only be used for XML-wellformed content).
    /// <see href="http://www.w3.org/2011/content#ContentAsXML"></see></summary>
    let ContentAsXML = _prefix "ContentAsXML"
    /// <summary>
    /// The document type declaration.
    /// <see href="http://www.w3.org/2011/content#DoctypeDecl"></see></summary>
    let DoctypeDecl = _prefix "DoctypeDecl"
    /// <summary>
    /// The Base64 encoded byte sequence of the content.
    /// <see href="http://www.w3.org/2011/content#bytes"></see></summary>
    let bytes = _prefix "bytes"
    /// <summary>
    /// The character encoding used to create a character sequence from a byte sequence or vice versa.
    /// <see href="http://www.w3.org/2011/content#characterEncoding"></see></summary>
    let characterEncoding = _prefix "characterEncoding"
    /// <summary>
    /// The character sequence of the text content.
    /// <see href="http://www.w3.org/2011/content#chars"></see></summary>
    let chars = _prefix "chars"
    /// <summary>
    /// The character encoding declared in the XML declaration.
    /// <see href="http://www.w3.org/2011/content#declaredEncoding"></see></summary>
    let declaredEncoding = _prefix "declaredEncoding"
    /// <summary>
    /// The document type name.
    /// <see href="http://www.w3.org/2011/content#doctypeName"></see></summary>
    let doctypeName = _prefix "doctypeName"
    /// <summary>
    /// The document type declaration.
    /// <see href="http://www.w3.org/2011/content#dtDecl"></see></summary>
    let dtDecl = _prefix "dtDecl"
    /// <summary>
    /// The internal document type definition subset within the document type declarations.
    /// <see href="http://www.w3.org/2011/content#internalSubset"></see></summary>
    let internalSubset = _prefix "internalSubset"
    /// <summary>
    /// The XML content preceding the document type declaration.
    /// <see href="http://www.w3.org/2011/content#leadingMisc"></see></summary>
    let leadingMisc = _prefix "leadingMisc"
    /// <summary>
    /// The document type declarations's public identifier.
    /// <see href="http://www.w3.org/2011/content#publicId"></see></summary>
    let publicId = _prefix "publicId"
    /// <summary>
    /// The XML content following the document type declaration.
    /// <see href="http://www.w3.org/2011/content#rest"></see></summary>
    let rest = _prefix "rest"
    /// <summary>
    /// The standalone declaration in the XML declaration.
    /// <see href="http://www.w3.org/2011/content#standalone"></see></summary>
    let standalone = _prefix "standalone"
    /// <summary>
    /// The document type declarations's system identifier (typed: xsd:anyURI)
    /// <see href="http://www.w3.org/2011/content#systemId"></see></summary>
    let systemId = _prefix "systemId"
    /// <summary>
    /// The XML version declared in the XML declaration.
    /// <see href="http://www.w3.org/2011/content#version"></see></summary>
    let version = _prefix "version"
