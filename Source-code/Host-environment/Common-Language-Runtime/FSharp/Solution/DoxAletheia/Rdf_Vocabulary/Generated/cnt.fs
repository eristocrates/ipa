namespace http.www.w3.org._2011.content.hash

open DoxAletheia.Rdf_Vocabulary

module cnt =
    let _namespace_name = "http://www.w3.org/2011/content#"
    /// <summary>
    /// The content.
    /// <see href="http://www.w3.org/2011/content#Content"></see></summary>
    let Content = Namespaced_IRI.parse _namespace_name "Content" |> NamespacedName

    /// <summary>
    /// The base64 encoded content (can be used for binary content).
    /// <see href="http://www.w3.org/2011/content#ContentAsBase64"></see></summary>
    let ContentAsBase64 =
        Namespaced_IRI.parse _namespace_name "ContentAsBase64" |> NamespacedName

    /// <summary>
    /// The text content (can be used for text content).
    /// <see href="http://www.w3.org/2011/content#ContentAsText"></see></summary>
    let ContentAsText =
        Namespaced_IRI.parse _namespace_name "ContentAsText" |> NamespacedName

    /// <summary>
    /// The XML content (can only be used for XML-wellformed content).
    /// <see href="http://www.w3.org/2011/content#ContentAsXML"></see></summary>
    let ContentAsXML =
        Namespaced_IRI.parse _namespace_name "ContentAsXML" |> NamespacedName

    /// <summary>
    /// The document type declaration.
    /// <see href="http://www.w3.org/2011/content#DoctypeDecl"></see></summary>
    let DoctypeDecl =
        Namespaced_IRI.parse _namespace_name "DoctypeDecl" |> NamespacedName

    /// <summary>
    /// The Base64 encoded byte sequence of the content.
    /// <see href="http://www.w3.org/2011/content#bytes"></see></summary>
    let bytes = Namespaced_IRI.parse _namespace_name "bytes" |> NamespacedName

    /// <summary>
    /// The character encoding used to create a character sequence from a byte sequence or vice versa.
    /// <see href="http://www.w3.org/2011/content#characterEncoding"></see></summary>
    let characterEncoding =
        Namespaced_IRI.parse _namespace_name "characterEncoding" |> NamespacedName

    /// <summary>
    /// The character sequence of the text content.
    /// <see href="http://www.w3.org/2011/content#chars"></see></summary>
    let chars = Namespaced_IRI.parse _namespace_name "chars" |> NamespacedName

    /// <summary>
    /// The character encoding declared in the XML declaration.
    /// <see href="http://www.w3.org/2011/content#declaredEncoding"></see></summary>
    let declaredEncoding =
        Namespaced_IRI.parse _namespace_name "declaredEncoding" |> NamespacedName

    /// <summary>
    /// The document type name.
    /// <see href="http://www.w3.org/2011/content#doctypeName"></see></summary>
    let doctypeName =
        Namespaced_IRI.parse _namespace_name "doctypeName" |> NamespacedName

    /// <summary>
    /// The document type declaration.
    /// <see href="http://www.w3.org/2011/content#dtDecl"></see></summary>
    let dtDecl = Namespaced_IRI.parse _namespace_name "dtDecl" |> NamespacedName

    /// <summary>
    /// The internal document type definition subset within the document type declarations.
    /// <see href="http://www.w3.org/2011/content#internalSubset"></see></summary>
    let internalSubset =
        Namespaced_IRI.parse _namespace_name "internalSubset" |> NamespacedName

    /// <summary>
    /// The XML content preceding the document type declaration.
    /// <see href="http://www.w3.org/2011/content#leadingMisc"></see></summary>
    let leadingMisc =
        Namespaced_IRI.parse _namespace_name "leadingMisc" |> NamespacedName

    /// <summary>
    /// The document type declarations's public identifier.
    /// <see href="http://www.w3.org/2011/content#publicId"></see></summary>
    let publicId = Namespaced_IRI.parse _namespace_name "publicId" |> NamespacedName
    /// <summary>
    /// The XML content following the document type declaration.
    /// <see href="http://www.w3.org/2011/content#rest"></see></summary>
    let rest = Namespaced_IRI.parse _namespace_name "rest" |> NamespacedName
    /// <summary>
    /// The standalone declaration in the XML declaration.
    /// <see href="http://www.w3.org/2011/content#standalone"></see></summary>
    let standalone = Namespaced_IRI.parse _namespace_name "standalone" |> NamespacedName
    /// <summary>
    /// The document type declarations's system identifier (typed: xsd:anyURI)
    /// <see href="http://www.w3.org/2011/content#systemId"></see></summary>
    let systemId = Namespaced_IRI.parse _namespace_name "systemId" |> NamespacedName
    /// <summary>
    /// The XML version declared in the XML declaration.
    /// <see href="http://www.w3.org/2011/content#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
