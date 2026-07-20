namespace http.www.w3.org._2011.http.hash

open DoxAletheia

module http =
    let _namespace_name = "http://www.w3.org/2011/http#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A connection used for HTTP transfer.
    /// <see href="http://www.w3.org/2011/http#Connection"></see></summary>
    let Connection = _prefix "Connection"
    /// <summary>
    /// An entity header in an HTTP message.
    /// <see href="http://www.w3.org/2011/http#EntityHeader"></see></summary>
    let EntityHeader = _prefix "EntityHeader"
    /// <summary>
    /// A header in an HTTP message.
    /// <see href="http://www.w3.org/2011/http#MessageHeader"></see></summary>
    let MessageHeader = _prefix "MessageHeader"
    /// <summary>
    /// A general header in an HTTP message.
    /// <see href="http://www.w3.org/2011/http#GeneralHeader"></see></summary>
    let GeneralHeader = _prefix "GeneralHeader"
    /// <summary>
    /// A part of a deconstructed header value.
    /// <see href="http://www.w3.org/2011/http#HeaderElement"></see></summary>
    let HeaderElement = _prefix "HeaderElement"
    /// <summary>
    /// A header name.
    /// <see href="http://www.w3.org/2011/http#HeaderName"></see></summary>
    let HeaderName = _prefix "HeaderName"
    /// <summary>
    /// An HTTP message.
    /// <see href="http://www.w3.org/2011/http#Message"></see></summary>
    let Message = _prefix "Message"
    /// <summary>
    /// The HTTP method used for the request.
    /// <see href="http://www.w3.org/2011/http#Method"></see></summary>
    let Method = _prefix "Method"
    /// <summary>
    /// A parameter for a part of a header value.
    /// <see href="http://www.w3.org/2011/http#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// An HTTP request.
    /// <see href="http://www.w3.org/2011/http#Request"></see></summary>
    let Request = _prefix "Request"
    /// <summary>
    /// A header in an HTTP request message.
    /// <see href="http://www.w3.org/2011/http#RequestHeader"></see></summary>
    let RequestHeader = _prefix "RequestHeader"
    /// <summary>
    /// An HTTP response.
    /// <see href="http://www.w3.org/2011/http#Response"></see></summary>
    let Response = _prefix "Response"
    /// <summary>
    /// A header in an HTTP response message.
    /// <see href="http://www.w3.org/2011/http#ResponseHeader"></see></summary>
    let ResponseHeader = _prefix "ResponseHeader"
    /// <summary>
    /// The status code of an HTTP response.
    /// <see href="http://www.w3.org/2011/http#StatusCode"></see></summary>
    let StatusCode = _prefix "StatusCode"
    /// <summary>
    /// The absolute path sort of request URI.
    /// <see href="http://www.w3.org/2011/http#absolutePath"></see></summary>
    let absolutePath = _prefix "absolutePath"
    /// <summary>
    /// The request URI of an HTTP request.
    /// <see href="http://www.w3.org/2011/http#requestURI"></see></summary>
    let requestURI = _prefix "requestURI"
    /// <summary>
    /// The absolute request URI.
    /// <see href="http://www.w3.org/2011/http#absoluteURI"></see></summary>
    let absoluteURI = _prefix "absoluteURI"
    /// <summary>
    /// The authority sort of request URI.
    /// <see href="http://www.w3.org/2011/http#authority"></see></summary>
    let authority = _prefix "authority"
    /// <summary>
    /// The entity body of an HTTP message.
    /// <see href="http://www.w3.org/2011/http#body"></see></summary>
    let body = _prefix "body"
    /// <summary>
    /// The authority of a connection used for the HTTP transfer.
    /// <see href="http://www.w3.org/2011/http#connectionAuthority"></see></summary>
    let connectionAuthority = _prefix "connectionAuthority"
    /// <summary>
    /// The name of a header element.
    /// <see href="http://www.w3.org/2011/http#elementName"></see></summary>
    let elementName = _prefix "elementName"
    /// <summary>
    /// The value of a header element.
    /// <see href="http://www.w3.org/2011/http#elementValue"></see></summary>
    let elementValue = _prefix "elementValue"
    /// <summary>
    /// The name of an HTTP header field.
    /// <see href="http://www.w3.org/2011/http#fieldName"></see></summary>
    let fieldName = _prefix "fieldName"
    /// <summary>
    /// The value of an HTTP header field.
    /// <see href="http://www.w3.org/2011/http#fieldValue"></see></summary>
    let fieldValue = _prefix "fieldValue"
    /// <summary>
    /// The name of an HTTP header.
    /// <see href="http://www.w3.org/2011/http#hdrName"></see></summary>
    let hdrName = _prefix "hdrName"
    /// <summary>
    /// The deconstructed parts of an HTTP header value.
    /// <see href="http://www.w3.org/2011/http#headerElements"></see></summary>
    let headerElements = _prefix "headerElements"
    /// <summary>
    /// The headers in an HTTP message.
    /// <see href="http://www.w3.org/2011/http#headers"></see></summary>
    let headers = _prefix "headers"
    /// <summary>
    /// The HTTP version of an HTTP message.
    /// <see href="http://www.w3.org/2011/http#httpVersion"></see></summary>
    let httpVersion = _prefix "httpVersion"
    /// <summary>
    /// The HTTP method name used for the HTTP request.
    /// <see href="http://www.w3.org/2011/http#methodName"></see></summary>
    let methodName = _prefix "methodName"
    /// <summary>
    /// The HTTP method used for the HTTP request.
    /// <see href="http://www.w3.org/2011/http#mthd"></see></summary>
    let mthd = _prefix "mthd"
    /// <summary>
    /// The name of a parameter in a part of a deconstructed HTTP header value.
    /// <see href="http://www.w3.org/2011/http#paramName"></see></summary>
    let paramName = _prefix "paramName"
    /// <summary>
    /// The value of a parameter in a part of a deconstructed HTTP header value.
    /// <see href="http://www.w3.org/2011/http#paramValue"></see></summary>
    let paramValue = _prefix "paramValue"
    /// <summary>
    /// The parameters in a part of a deconstructed HTTP header value.
    /// <see href="http://www.w3.org/2011/http#params"></see></summary>
    let params_ = _prefix "params"
    /// <summary>
    /// The reason phrase (status text) of an HTTP response.
    /// <see href="http://www.w3.org/2011/http#reasonPhrase"></see></summary>
    let reasonPhrase = _prefix "reasonPhrase"
    /// <summary>
    /// The HTTP requests made via a connection.
    /// <see href="http://www.w3.org/2011/http#requests"></see></summary>
    let requests = _prefix "requests"
    /// <summary>
    /// The HTTP response sent in answer to an HTTP request.
    /// <see href="http://www.w3.org/2011/http#resp"></see></summary>
    let resp = _prefix "resp"
    /// <summary>
    /// The status code of an HTTP response.
    /// <see href="http://www.w3.org/2011/http#sc"></see></summary>
    let sc = _prefix "sc"
    /// <summary>
    /// The status code number.
    /// <see href="http://www.w3.org/2011/http#statusCodeNumber"></see></summary>
    let statusCodeNumber = _prefix "statusCodeNumber"
    /// <summary>
    /// The status code value of an HTTP response.
    /// <see href="http://www.w3.org/2011/http#statusCodeValue"></see></summary>
    let statusCodeValue = _prefix "statusCodeValue"
