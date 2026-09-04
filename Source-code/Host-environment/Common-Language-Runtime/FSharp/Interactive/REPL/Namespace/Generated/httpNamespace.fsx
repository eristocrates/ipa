#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module http =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2011/http#" "http"
    /// <summary>
    ///   <para>rdfs:comment : A connection used for HTTP transfer.</para>
    ///   <para>rdfs:label : Connection</para>
    ///   <a href="http://www.w3.org/2011/http#Connection">http:Connection</a>
    /// </summary>
    let Connection = _prefixId.prefix "Connection"
    /// <summary>
    ///   <para>rdfs:comment : An entity header in an HTTP message.</para>
    ///   <para>rdfs:label : Entity Header</para>
    ///   <a href="http://www.w3.org/2011/http#EntityHeader">http:EntityHeader</a>
    /// </summary>
    let EntityHeader = _prefixId.prefix "EntityHeader"
    /// <summary>
    ///   <para>rdfs:comment : A general header in an HTTP message.</para>
    ///   <para>rdfs:label : General Header</para>
    ///   <a href="http://www.w3.org/2011/http#GeneralHeader">http:GeneralHeader</a>
    /// </summary>
    let GeneralHeader = _prefixId.prefix "GeneralHeader"
    /// <summary>
    ///   <para>rdfs:comment : A part of a deconstructed header value.</para>
    ///   <para>rdfs:label : Header Element</para>
    ///   <a href="http://www.w3.org/2011/http#HeaderElement">http:HeaderElement</a>
    /// </summary>
    let HeaderElement = _prefixId.prefix "HeaderElement"
    /// <summary>
    ///   <para>rdfs:comment : A header name.</para>
    ///   <para>rdfs:label : Header Name</para>
    ///   <a href="http://www.w3.org/2011/http#HeaderName">http:HeaderName</a>
    /// </summary>
    let HeaderName = _prefixId.prefix "HeaderName"
    /// <summary>
    ///   <para>rdfs:comment : An HTTP message.</para>
    ///   <para>rdfs:label : Message</para>
    ///   <a href="http://www.w3.org/2011/http#Message">http:Message</a>
    /// </summary>
    let Message = _prefixId.prefix "Message"
    /// <summary>
    ///   <para>rdfs:comment : A header in an HTTP message.</para>
    ///   <para>rdfs:label : Message Header</para>
    ///   <a href="http://www.w3.org/2011/http#MessageHeader">http:MessageHeader</a>
    /// </summary>
    let MessageHeader = _prefixId.prefix "MessageHeader"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP method used for the request.</para>
    ///   <para>rdfs:label : Method</para>
    ///   <a href="http://www.w3.org/2011/http#Method">http:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:label : Parameter</para>
    ///   <para>rdfs:comment : A parameter for a part of a header value.</para>
    ///   <a href="http://www.w3.org/2011/http#Parameter">http:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:comment : An HTTP request.</para>
    ///   <para>rdfs:label : Request</para>
    ///   <a href="http://www.w3.org/2011/http#Request">http:Request</a>
    /// </summary>
    let Request = _prefixId.prefix "Request"
    /// <summary>
    ///   <para>rdfs:comment : A header in an HTTP request message.</para>
    ///   <para>rdfs:label : Request Header</para>
    ///   <a href="http://www.w3.org/2011/http#RequestHeader">http:RequestHeader</a>
    /// </summary>
    let RequestHeader = _prefixId.prefix "RequestHeader"
    /// <summary>
    ///   <para>rdfs:comment : An HTTP response.</para>
    ///   <para>rdfs:label : Response</para>
    ///   <a href="http://www.w3.org/2011/http#Response">http:Response</a>
    /// </summary>
    let Response = _prefixId.prefix "Response"
    /// <summary>
    ///   <para>rdfs:comment : A header in an HTTP response message.</para>
    ///   <para>rdfs:label : Response Header</para>
    ///   <a href="http://www.w3.org/2011/http#ResponseHeader">http:ResponseHeader</a>
    /// </summary>
    let ResponseHeader = _prefixId.prefix "ResponseHeader"
    /// <summary>
    ///   <para>rdfs:comment : The status code of an HTTP response.</para>
    ///   <para>rdfs:label : Status code</para>
    ///   <a href="http://www.w3.org/2011/http#StatusCode">http:StatusCode</a>
    /// </summary>
    let StatusCode = _prefixId.prefix "StatusCode"
    /// <summary>
    ///   <para>rdfs:comment : The absolute path sort of request URI.</para>
    ///   <para>rdfs:label : Absolute path</para>
    ///   <a href="http://www.w3.org/2011/http#absolutePath">http:absolutePath</a>
    /// </summary>
    let absolutePath = _prefixId.prefix "absolutePath"
    /// <summary>
    ///   <para>rdfs:comment : The absolute request URI.</para>
    ///   <para>rdfs:label : Absolute URI</para>
    ///   <a href="http://www.w3.org/2011/http#absoluteURI">http:absoluteURI</a>
    /// </summary>
    let absoluteURI = _prefixId.prefix "absoluteURI"
    /// <summary>
    ///   <para>rdfs:comment : The authority sort of request URI.</para>
    ///   <para>rdfs:label : Authority</para>
    ///   <a href="http://www.w3.org/2011/http#authority">http:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>rdfs:comment : The entity body of an HTTP message.</para>
    ///   <para>rdfs:label : Entity Body</para>
    ///   <a href="http://www.w3.org/2011/http#body">http:body</a>
    /// </summary>
    let body = _prefixId.prefix "body"
    /// <summary>
    ///   <para>rdfs:comment : The authority of a connection used for the HTTP transfer.</para>
    ///   <para>rdfs:label : Connection authority</para>
    ///   <a href="http://www.w3.org/2011/http#connectionAuthority">http:connectionAuthority</a>
    /// </summary>
    let connectionAuthority = _prefixId.prefix "connectionAuthority"
    /// <summary>
    ///   <para>rdfs:comment : The name of a header element.</para>
    ///   <para>rdfs:label : Header element name</para>
    ///   <a href="http://www.w3.org/2011/http#elementName">http:elementName</a>
    /// </summary>
    let elementName = _prefixId.prefix "elementName"
    /// <summary>
    ///   <para>rdfs:comment : The value of a header element.</para>
    ///   <para>rdfs:label : Header element value</para>
    ///   <a href="http://www.w3.org/2011/http#elementValue">http:elementValue</a>
    /// </summary>
    let elementValue = _prefixId.prefix "elementValue"
    /// <summary>
    ///   <para>rdfs:comment : The name of an HTTP header field.</para>
    ///   <para>rdfs:label : Field name</para>
    ///   <a href="http://www.w3.org/2011/http#fieldName">http:fieldName</a>
    /// </summary>
    let fieldName = _prefixId.prefix "fieldName"
    /// <summary>
    ///   <para>rdfs:comment : The value of an HTTP header field.</para>
    ///   <para>rdfs:label : Field value</para>
    ///   <a href="http://www.w3.org/2011/http#fieldValue">http:fieldValue</a>
    /// </summary>
    let fieldValue = _prefixId.prefix "fieldValue"
    /// <summary>
    ///   <para>rdfs:comment : The name of an HTTP header.</para>
    ///   <para>rdfs:label : Header name</para>
    ///   <a href="http://www.w3.org/2011/http#hdrName">http:hdrName</a>
    /// </summary>
    let hdrName = _prefixId.prefix "hdrName"
    /// <summary>
    ///   <para>rdfs:comment : The deconstructed parts of an HTTP header value.</para>
    ///   <para>rdfs:label : Header elements</para>
    ///   <a href="http://www.w3.org/2011/http#headerElements">http:headerElements</a>
    /// </summary>
    let headerElements = _prefixId.prefix "headerElements"
    /// <summary>
    ///   <para>rdfs:comment : The headers in an HTTP message.</para>
    ///   <para>rdfs:label : Headers</para>
    ///   <a href="http://www.w3.org/2011/http#headers">http:headers</a>
    /// </summary>
    let headers = _prefixId.prefix "headers"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP version of an HTTP message.</para>
    ///   <para>rdfs:label : HTTP version</para>
    ///   <a href="http://www.w3.org/2011/http#httpVersion">http:httpVersion</a>
    /// </summary>
    let httpVersion = _prefixId.prefix "httpVersion"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP method name used for the HTTP request.</para>
    ///   <para>rdfs:label : Method name</para>
    ///   <a href="http://www.w3.org/2011/http#methodName">http:methodName</a>
    /// </summary>
    let methodName = _prefixId.prefix "methodName"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP method used for the HTTP request.</para>
    ///   <para>rdfs:label : Method</para>
    ///   <a href="http://www.w3.org/2011/http#mthd">http:mthd</a>
    /// </summary>
    let mthd = _prefixId.prefix "mthd"
    /// <summary>
    ///   <para>rdfs:comment : The name of a parameter in a part of a deconstructed HTTP header value.</para>
    ///   <para>rdfs:label : Parameter name</para>
    ///   <a href="http://www.w3.org/2011/http#paramName">http:paramName</a>
    /// </summary>
    let paramName = _prefixId.prefix "paramName"
    /// <summary>
    ///   <para>rdfs:comment : The value of a parameter in a part of a deconstructed HTTP header value.</para>
    ///   <para>rdfs:label : Parameter value</para>
    ///   <a href="http://www.w3.org/2011/http#paramValue">http:paramValue</a>
    /// </summary>
    let paramValue = _prefixId.prefix "paramValue"
    /// <summary>
    ///   <para>rdfs:comment : The parameters in a part of a deconstructed HTTP header value.</para>
    ///   <para>rdfs:label : Header parameters</para>
    ///   <a href="http://www.w3.org/2011/http#params">http:params</a>
    /// </summary>
    let params_ = _prefixId.prefix "params"
    /// <summary>
    ///   <para>rdfs:comment : The reason phrase (status text) of an HTTP response.</para>
    ///   <para>rdfs:label : Reason phrase</para>
    ///   <a href="http://www.w3.org/2011/http#reasonPhrase">http:reasonPhrase</a>
    /// </summary>
    let reasonPhrase = _prefixId.prefix "reasonPhrase"
    /// <summary>
    ///   <para>rdfs:comment : The request URI of an HTTP request.</para>
    ///   <para>rdfs:label : Request URI</para>
    ///   <a href="http://www.w3.org/2011/http#requestURI">http:requestURI</a>
    /// </summary>
    let requestURI = _prefixId.prefix "requestURI"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP requests made via a connection.</para>
    ///   <para>rdfs:label : Requests</para>
    ///   <a href="http://www.w3.org/2011/http#requests">http:requests</a>
    /// </summary>
    let requests = _prefixId.prefix "requests"
    /// <summary>
    ///   <para>rdfs:comment : The HTTP response sent in answer to an HTTP request.</para>
    ///   <para>rdfs:label : Response</para>
    ///   <a href="http://www.w3.org/2011/http#resp">http:resp</a>
    /// </summary>
    let resp = _prefixId.prefix "resp"
    /// <summary>
    ///   <para>rdfs:comment : The status code of an HTTP response.</para>
    ///   <para>rdfs:label : Status code</para>
    ///   <a href="http://www.w3.org/2011/http#sc">http:sc</a>
    /// </summary>
    let sc = _prefixId.prefix "sc"
    /// <summary>
    ///   <para>rdfs:comment : The status code number.</para>
    ///   <para>rdfs:label : Status code</para>
    ///   <a href="http://www.w3.org/2011/http#statusCodeNumber">http:statusCodeNumber</a>
    /// </summary>
    let statusCodeNumber = _prefixId.prefix "statusCodeNumber"
    /// <summary>
    ///   <para>rdfs:comment : The status code value of an HTTP response.</para>
    ///   <para>rdfs:label : Status code</para>
    ///   <a href="http://www.w3.org/2011/http#statusCodeValue">http:statusCodeValue</a>
    /// </summary>
    let statusCodeValue = _prefixId.prefix "statusCodeValue"
