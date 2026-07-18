namespace http.www.w3.org._2011.http.hash

open DoxAletheia.Rdf_Vocabulary

module http =
    let _namespace_name = "http://www.w3.org/2011/http#"
    /// <summary>
    /// A connection used for HTTP transfer.
    /// <see href="http://www.w3.org/2011/http#Connection"></see></summary>
    let Connection = Namespaced_IRI.parse _namespace_name "Connection" |> NamespacedName

    /// <summary>
    /// An entity header in an HTTP message.
    /// <see href="http://www.w3.org/2011/http#EntityHeader"></see></summary>
    let EntityHeader =
        Namespaced_IRI.parse _namespace_name "EntityHeader" |> NamespacedName

    /// <summary>
    /// A header in an HTTP message.
    /// <see href="http://www.w3.org/2011/http#MessageHeader"></see></summary>
    let MessageHeader =
        Namespaced_IRI.parse _namespace_name "MessageHeader" |> NamespacedName

    /// <summary>
    /// A general header in an HTTP message.
    /// <see href="http://www.w3.org/2011/http#GeneralHeader"></see></summary>
    let GeneralHeader =
        Namespaced_IRI.parse _namespace_name "GeneralHeader" |> NamespacedName

    /// <summary>
    /// A part of a deconstructed header value.
    /// <see href="http://www.w3.org/2011/http#HeaderElement"></see></summary>
    let HeaderElement =
        Namespaced_IRI.parse _namespace_name "HeaderElement" |> NamespacedName

    /// <summary>
    /// A header name.
    /// <see href="http://www.w3.org/2011/http#HeaderName"></see></summary>
    let HeaderName = Namespaced_IRI.parse _namespace_name "HeaderName" |> NamespacedName
    /// <summary>
    /// An HTTP message.
    /// <see href="http://www.w3.org/2011/http#Message"></see></summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName
    /// <summary>
    /// The HTTP method used for the request.
    /// <see href="http://www.w3.org/2011/http#Method"></see></summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName
    /// <summary>
    /// A parameter for a part of a header value.
    /// <see href="http://www.w3.org/2011/http#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName
    /// <summary>
    /// An HTTP request.
    /// <see href="http://www.w3.org/2011/http#Request"></see></summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName

    /// <summary>
    /// A header in an HTTP request message.
    /// <see href="http://www.w3.org/2011/http#RequestHeader"></see></summary>
    let RequestHeader =
        Namespaced_IRI.parse _namespace_name "RequestHeader" |> NamespacedName

    /// <summary>
    /// An HTTP response.
    /// <see href="http://www.w3.org/2011/http#Response"></see></summary>
    let Response = Namespaced_IRI.parse _namespace_name "Response" |> NamespacedName

    /// <summary>
    /// A header in an HTTP response message.
    /// <see href="http://www.w3.org/2011/http#ResponseHeader"></see></summary>
    let ResponseHeader =
        Namespaced_IRI.parse _namespace_name "ResponseHeader" |> NamespacedName

    /// <summary>
    /// The status code of an HTTP response.
    /// <see href="http://www.w3.org/2011/http#StatusCode"></see></summary>
    let StatusCode = Namespaced_IRI.parse _namespace_name "StatusCode" |> NamespacedName

    /// <summary>
    /// The absolute path sort of request URI.
    /// <see href="http://www.w3.org/2011/http#absolutePath"></see></summary>
    let absolutePath =
        Namespaced_IRI.parse _namespace_name "absolutePath" |> NamespacedName

    /// <summary>
    /// The request URI of an HTTP request.
    /// <see href="http://www.w3.org/2011/http#requestURI"></see></summary>
    let requestURI = Namespaced_IRI.parse _namespace_name "requestURI" |> NamespacedName

    /// <summary>
    /// The absolute request URI.
    /// <see href="http://www.w3.org/2011/http#absoluteURI"></see></summary>
    let absoluteURI =
        Namespaced_IRI.parse _namespace_name "absoluteURI" |> NamespacedName

    /// <summary>
    /// The authority sort of request URI.
    /// <see href="http://www.w3.org/2011/http#authority"></see></summary>
    let authority = Namespaced_IRI.parse _namespace_name "authority" |> NamespacedName
    /// <summary>
    /// The entity body of an HTTP message.
    /// <see href="http://www.w3.org/2011/http#body"></see></summary>
    let body = Namespaced_IRI.parse _namespace_name "body" |> NamespacedName

    /// <summary>
    /// The authority of a connection used for the HTTP transfer.
    /// <see href="http://www.w3.org/2011/http#connectionAuthority"></see></summary>
    let connectionAuthority =
        Namespaced_IRI.parse _namespace_name "connectionAuthority" |> NamespacedName

    /// <summary>
    /// The name of a header element.
    /// <see href="http://www.w3.org/2011/http#elementName"></see></summary>
    let elementName =
        Namespaced_IRI.parse _namespace_name "elementName" |> NamespacedName

    /// <summary>
    /// The value of a header element.
    /// <see href="http://www.w3.org/2011/http#elementValue"></see></summary>
    let elementValue =
        Namespaced_IRI.parse _namespace_name "elementValue" |> NamespacedName

    /// <summary>
    /// The name of an HTTP header field.
    /// <see href="http://www.w3.org/2011/http#fieldName"></see></summary>
    let fieldName = Namespaced_IRI.parse _namespace_name "fieldName" |> NamespacedName
    /// <summary>
    /// The value of an HTTP header field.
    /// <see href="http://www.w3.org/2011/http#fieldValue"></see></summary>
    let fieldValue = Namespaced_IRI.parse _namespace_name "fieldValue" |> NamespacedName
    /// <summary>
    /// The name of an HTTP header.
    /// <see href="http://www.w3.org/2011/http#hdrName"></see></summary>
    let hdrName = Namespaced_IRI.parse _namespace_name "hdrName" |> NamespacedName

    /// <summary>
    /// The deconstructed parts of an HTTP header value.
    /// <see href="http://www.w3.org/2011/http#headerElements"></see></summary>
    let headerElements =
        Namespaced_IRI.parse _namespace_name "headerElements" |> NamespacedName

    /// <summary>
    /// The headers in an HTTP message.
    /// <see href="http://www.w3.org/2011/http#headers"></see></summary>
    let headers = Namespaced_IRI.parse _namespace_name "headers" |> NamespacedName

    /// <summary>
    /// The HTTP version of an HTTP message.
    /// <see href="http://www.w3.org/2011/http#httpVersion"></see></summary>
    let httpVersion =
        Namespaced_IRI.parse _namespace_name "httpVersion" |> NamespacedName

    /// <summary>
    /// The HTTP method name used for the HTTP request.
    /// <see href="http://www.w3.org/2011/http#methodName"></see></summary>
    let methodName = Namespaced_IRI.parse _namespace_name "methodName" |> NamespacedName
    /// <summary>
    /// The HTTP method used for the HTTP request.
    /// <see href="http://www.w3.org/2011/http#mthd"></see></summary>
    let mthd = Namespaced_IRI.parse _namespace_name "mthd" |> NamespacedName
    /// <summary>
    /// The name of a parameter in a part of a deconstructed HTTP header value.
    /// <see href="http://www.w3.org/2011/http#paramName"></see></summary>
    let paramName = Namespaced_IRI.parse _namespace_name "paramName" |> NamespacedName
    /// <summary>
    /// The value of a parameter in a part of a deconstructed HTTP header value.
    /// <see href="http://www.w3.org/2011/http#paramValue"></see></summary>
    let paramValue = Namespaced_IRI.parse _namespace_name "paramValue" |> NamespacedName
    /// <summary>
    /// The parameters in a part of a deconstructed HTTP header value.
    /// <see href="http://www.w3.org/2011/http#params"></see></summary>
    let params_ = Namespaced_IRI.parse _namespace_name "params" |> NamespacedName

    /// <summary>
    /// The reason phrase (status text) of an HTTP response.
    /// <see href="http://www.w3.org/2011/http#reasonPhrase"></see></summary>
    let reasonPhrase =
        Namespaced_IRI.parse _namespace_name "reasonPhrase" |> NamespacedName

    /// <summary>
    /// The HTTP requests made via a connection.
    /// <see href="http://www.w3.org/2011/http#requests"></see></summary>
    let requests = Namespaced_IRI.parse _namespace_name "requests" |> NamespacedName
    /// <summary>
    /// The HTTP response sent in answer to an HTTP request.
    /// <see href="http://www.w3.org/2011/http#resp"></see></summary>
    let resp = Namespaced_IRI.parse _namespace_name "resp" |> NamespacedName
    /// <summary>
    /// The status code of an HTTP response.
    /// <see href="http://www.w3.org/2011/http#sc"></see></summary>
    let sc = Namespaced_IRI.parse _namespace_name "sc" |> NamespacedName

    /// <summary>
    /// The status code number.
    /// <see href="http://www.w3.org/2011/http#statusCodeNumber"></see></summary>
    let statusCodeNumber =
        Namespaced_IRI.parse _namespace_name "statusCodeNumber" |> NamespacedName

    /// <summary>
    /// The status code value of an HTTP response.
    /// <see href="http://www.w3.org/2011/http#statusCodeValue"></see></summary>
    let statusCodeValue =
        Namespaced_IRI.parse _namespace_name "statusCodeValue" |> NamespacedName
