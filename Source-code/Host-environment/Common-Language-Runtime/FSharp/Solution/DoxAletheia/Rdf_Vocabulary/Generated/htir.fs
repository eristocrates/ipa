namespace http.www.w3.org._2011.http.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module htir =
    let _namespace_iri = Namespace_Iri htir |> NamespaceIRI
    /// <summary>
    ///   <para>htir:Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A connection used for HTTP transfer.</para>
    /// labels<para>Connection</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#Connection">http://www.w3.org/2011/http#Connection</seealso>
    let Connection = Prefixed_Name(htir, "Connection") |> PrefixedName
    /// <summary>
    ///   <para>htir:HeaderElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A part of a deconstructed header value.</para>
    /// labels<para>Header Element</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#HeaderElement">http://www.w3.org/2011/http#HeaderElement</seealso>
    let HeaderElement = Prefixed_Name(htir, "HeaderElement") |> PrefixedName
    /// <summary>
    ///   <para>htir:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An HTTP request.</para>
    /// labels<para>Request</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#Request">http://www.w3.org/2011/http#Request</seealso>
    let Request = Prefixed_Name(htir, "Request") |> PrefixedName
    /// <summary>
    ///   <para>htir:ResponseHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A header in an HTTP response message.</para>
    /// labels<para>Response Header</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#ResponseHeader">http://www.w3.org/2011/http#ResponseHeader</seealso>
    let ResponseHeader = Prefixed_Name(htir, "ResponseHeader") |> PrefixedName
    /// <summary>
    ///   <para>htir:body</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The entity body of an HTTP message.</para>
    /// labels<para>Entity Body</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#body">http://www.w3.org/2011/http#body</seealso>
    let body = Prefixed_Name(htir, "body") |> PrefixedName
    /// <summary>
    ///   <para>htir:HeaderName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A header name.</para>
    /// labels<para>Header Name</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#HeaderName">http://www.w3.org/2011/http#HeaderName</seealso>
    let HeaderName = Prefixed_Name(htir, "HeaderName") |> PrefixedName
    /// <summary>
    ///   <para>htir:httpVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The HTTP version of an HTTP message.</para>
    /// labels<para>HTTP version</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#httpVersion">http://www.w3.org/2011/http#httpVersion</seealso>
    let httpVersion = Prefixed_Name(htir, "httpVersion") |> PrefixedName
    /// <summary>
    ///   <para>htir:paramName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The name of a parameter in a part of a deconstructed HTTP header value.</para>
    /// labels<para>Parameter name</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#paramName">http://www.w3.org/2011/http#paramName</seealso>
    let paramName = Prefixed_Name(htir, "paramName") |> PrefixedName
    /// <summary>
    ///   <para>htir:params</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The parameters in a part of a deconstructed HTTP header value.</para>
    /// labels<para>Header parameters</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#params">http://www.w3.org/2011/http#params</seealso>
    let params_ = Prefixed_Name(htir, "params") |> PrefixedName
    /// <summary>
    ///   <para>htir:resp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The HTTP response sent in answer to an HTTP request.</para>
    /// labels<para>Response</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#resp">http://www.w3.org/2011/http#resp</seealso>
    let resp = Prefixed_Name(htir, "resp") |> PrefixedName
    /// <summary>
    ///   <para>htir:statusCodeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The status code value of an HTTP response.</para>
    /// labels<para>Status code</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#statusCodeValue">http://www.w3.org/2011/http#statusCodeValue</seealso>
    let statusCodeValue = Prefixed_Name(htir, "statusCodeValue") |> PrefixedName
    /// <summary>
    ///   <para>htir:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An HTTP message.</para>
    /// labels<para>Message</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#Message">http://www.w3.org/2011/http#Message</seealso>
    let Message = Prefixed_Name(htir, "Message") |> PrefixedName
    /// <summary>
    ///   <para>htir:elementName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The name of a header element.</para>
    /// labels<para>Header element name</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#elementName">http://www.w3.org/2011/http#elementName</seealso>
    let elementName = Prefixed_Name(htir, "elementName") |> PrefixedName
    /// <summary>
    ///   <para>htir:fieldName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The name of an HTTP header field.</para>
    /// labels<para>Field name</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#fieldName">http://www.w3.org/2011/http#fieldName</seealso>
    let fieldName = Prefixed_Name(htir, "fieldName") |> PrefixedName
    /// <summary>
    ///   <para>htir:hdrName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The name of an HTTP header.</para>
    /// labels<para>Header name</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#hdrName">http://www.w3.org/2011/http#hdrName</seealso>
    let hdrName = Prefixed_Name(htir, "hdrName") |> PrefixedName
    /// <summary>
    ///   <para>htir:headers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The headers in an HTTP message.</para>
    /// labels<para>Headers</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#headers">http://www.w3.org/2011/http#headers</seealso>
    let headers = Prefixed_Name(htir, "headers") |> PrefixedName
    /// <summary>
    ///   <para>htir:mthd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The HTTP method used for the HTTP request.</para>
    /// labels<para>Method</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#mthd">http://www.w3.org/2011/http#mthd</seealso>
    let mthd = Prefixed_Name(htir, "mthd") |> PrefixedName
    /// <summary>
    ///   <para>htir:paramValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The value of a parameter in a part of a deconstructed HTTP header value.</para>
    /// labels<para>Parameter value</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#paramValue">http://www.w3.org/2011/http#paramValue</seealso>
    let paramValue = Prefixed_Name(htir, "paramValue") |> PrefixedName
    /// <summary>
    ///   <para>htir:reasonPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The reason phrase (status text) of an HTTP response.</para>
    /// labels<para>Reason phrase</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#reasonPhrase">http://www.w3.org/2011/http#reasonPhrase</seealso>
    let reasonPhrase = Prefixed_Name(htir, "reasonPhrase") |> PrefixedName
    /// <summary>
    ///   <para>htir:requests</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The HTTP requests made via a connection.</para>
    /// labels<para>Requests</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#requests">http://www.w3.org/2011/http#requests</seealso>
    let requests = Prefixed_Name(htir, "requests") |> PrefixedName
    /// <summary>
    ///   <para>htir:statusCodeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The status code number.</para>
    /// labels<para>Status code</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#statusCodeNumber">http://www.w3.org/2011/http#statusCodeNumber</seealso>
    let statusCodeNumber = Prefixed_Name(htir, "statusCodeNumber") |> PrefixedName
    /// <summary>
    ///   <para>htir:Response</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An HTTP response.</para>
    /// labels<para>Response</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#Response">http://www.w3.org/2011/http#Response</seealso>
    let Response = Prefixed_Name(htir, "Response") |> PrefixedName
    /// <summary>
    ///   <para>htir:absolutePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The absolute path sort of request URI.</para>
    /// labels<para>Absolute path</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#absolutePath">http://www.w3.org/2011/http#absolutePath</seealso>
    let absolutePath = Prefixed_Name(htir, "absolutePath") |> PrefixedName
    /// <summary>
    ///   <para>htir:elementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The value of a header element.</para>
    /// labels<para>Header element value</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#elementValue">http://www.w3.org/2011/http#elementValue</seealso>
    let elementValue = Prefixed_Name(htir, "elementValue") |> PrefixedName
    /// <summary>
    ///   <para>htir:fieldValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The value of an HTTP header field.</para>
    /// labels<para>Field value</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#fieldValue">http://www.w3.org/2011/http#fieldValue</seealso>
    let fieldValue = Prefixed_Name(htir, "fieldValue") |> PrefixedName
    /// <summary>
    ///   <para>htir:headerElements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The deconstructed parts of an HTTP header value.</para>
    /// labels<para>Header elements</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#headerElements">http://www.w3.org/2011/http#headerElements</seealso>
    let headerElements = Prefixed_Name(htir, "headerElements") |> PrefixedName
    /// <summary>
    ///   <para>htir:methodName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The HTTP method name used for the HTTP request.</para>
    /// labels<para>Method name</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#methodName">http://www.w3.org/2011/http#methodName</seealso>
    let methodName = Prefixed_Name(htir, "methodName") |> PrefixedName
    /// <summary>
    ///   <para>htir:sc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The status code of an HTTP response.</para>
    /// labels<para>Status code</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#sc">http://www.w3.org/2011/http#sc</seealso>
    let sc = Prefixed_Name(htir, "sc") |> PrefixedName
    /// <summary>
    ///   <para>htir:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The authority sort of request URI.</para>
    /// labels<para>Authority</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#authority">http://www.w3.org/2011/http#authority</seealso>
    let authority = Prefixed_Name(htir, "authority") |> PrefixedName
    /// <summary>
    ///   <para>htir:EntityHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An entity header in an HTTP message.</para>
    /// labels<para>Entity Header</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#EntityHeader">http://www.w3.org/2011/http#EntityHeader</seealso>
    let EntityHeader = Prefixed_Name(htir, "EntityHeader") |> PrefixedName
    /// <summary>
    ///   <para>htir:MessageHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A header in an HTTP message.</para>
    /// labels<para>Message Header</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#MessageHeader">http://www.w3.org/2011/http#MessageHeader</seealso>
    let MessageHeader = Prefixed_Name(htir, "MessageHeader") |> PrefixedName
    /// <summary>
    ///   <para>htir:GeneralHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A general header in an HTTP message.</para>
    /// labels<para>General Header</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#GeneralHeader">http://www.w3.org/2011/http#GeneralHeader</seealso>
    let GeneralHeader = Prefixed_Name(htir, "GeneralHeader") |> PrefixedName
    /// <summary>
    ///   <para>htir:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The HTTP method used for the request.</para>
    /// labels<para>Method</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#Method">http://www.w3.org/2011/http#Method</seealso>
    let Method = Prefixed_Name(htir, "Method") |> PrefixedName
    /// <summary>
    ///   <para>htir:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A parameter for a part of a header value.</para>
    /// labels<para>Parameter</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#Parameter">http://www.w3.org/2011/http#Parameter</seealso>
    let Parameter = Prefixed_Name(htir, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>htir:RequestHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A header in an HTTP request message.</para>
    /// labels<para>Request Header</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#RequestHeader">http://www.w3.org/2011/http#RequestHeader</seealso>
    let RequestHeader = Prefixed_Name(htir, "RequestHeader") |> PrefixedName
    /// <summary>
    ///   <para>htir:StatusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The status code of an HTTP response.</para>
    /// labels<para>Status code</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#StatusCode">http://www.w3.org/2011/http#StatusCode</seealso>
    let StatusCode = Prefixed_Name(htir, "StatusCode") |> PrefixedName
    /// <summary>
    ///   <para>htir:requestURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The request URI of an HTTP request.</para>
    /// labels<para>Request URI</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#requestURI">http://www.w3.org/2011/http#requestURI</seealso>
    let requestURI = Prefixed_Name(htir, "requestURI") |> PrefixedName
    /// <summary>
    ///   <para>htir:absoluteURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The absolute request URI.</para>
    /// labels<para>Absolute URI</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#absoluteURI">http://www.w3.org/2011/http#absoluteURI</seealso>
    let absoluteURI = Prefixed_Name(htir, "absoluteURI") |> PrefixedName
    /// <summary>
    ///   <para>htir:connectionAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The authority of a connection used for the HTTP transfer.</para>
    /// labels<para>Connection authority</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http#connectionAuthority">http://www.w3.org/2011/http#connectionAuthority</seealso>
    let connectionAuthority = Prefixed_Name(htir, "connectionAuthority") |> PrefixedName
