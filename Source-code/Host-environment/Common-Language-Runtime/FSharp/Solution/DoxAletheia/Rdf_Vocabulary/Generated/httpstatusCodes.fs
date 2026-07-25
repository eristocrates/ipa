namespace http.www.w3.org._2011.http_statusCodes.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module httpstatusCodes =
    let _namespace_iri = Namespace_Iri httpstatusCodes |> NamespaceIRI
    /// <summary>
    ///   <para>httpstatusCodes:Accepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Accepted">http://www.w3.org/2011/http-statusCodes#Accepted</seealso>
    let Accepted = Prefixed_Name(httpstatusCodes, "Accepted") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A status code starting with 5</para>
    /// labels<para>Server Error</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#StatusCode5xx">http://www.w3.org/2011/http-statusCodes#StatusCode5xx</seealso>
    let StatusCode5xx = Prefixed_Name(httpstatusCodes, "StatusCode5xx") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:Forbidden</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Forbidden">http://www.w3.org/2011/http-statusCodes#Forbidden</seealso>
    let Forbidden = Prefixed_Name(httpstatusCodes, "Forbidden") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:IMUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#IMUsed">http://www.w3.org/2011/http-statusCodes#IMUsed</seealso>
    let IMUsed = Prefixed_Name(httpstatusCodes, "IMUsed") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:LengthRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#LengthRequired">http://www.w3.org/2011/http-statusCodes#LengthRequired</seealso>
    let LengthRequired =
        Prefixed_Name(httpstatusCodes, "LengthRequired") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A status code starting with 2</para>
    /// labels<para>Successful</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#StatusCode2xx">http://www.w3.org/2011/http-statusCodes#StatusCode2xx</seealso>
    let StatusCode2xx = Prefixed_Name(httpstatusCodes, "StatusCode2xx") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A status code starting with 4</para>
    /// labels<para>Client Error</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#StatusCode4xx">http://www.w3.org/2011/http-statusCodes#StatusCode4xx</seealso>
    let StatusCode4xx = Prefixed_Name(httpstatusCodes, "StatusCode4xx") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:StatusCode1xx</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A status code starting with 1</para>
    /// labels<para>Informational</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#StatusCode1xx">http://www.w3.org/2011/http-statusCodes#StatusCode1xx</seealso>
    let StatusCode1xx = Prefixed_Name(httpstatusCodes, "StatusCode1xx") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:FailedDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#FailedDependency">http://www.w3.org/2011/http-statusCodes#FailedDependency</seealso>
    let FailedDependency =
        Prefixed_Name(httpstatusCodes, "FailedDependency") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:Found</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Found">http://www.w3.org/2011/http-statusCodes#Found</seealso>
    let Found = Prefixed_Name(httpstatusCodes, "Found") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:GatewayTimeout</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#GatewayTimeout">http://www.w3.org/2011/http-statusCodes#GatewayTimeout</seealso>
    let GatewayTimeout =
        Prefixed_Name(httpstatusCodes, "GatewayTimeout") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:HTTPVersionNotSupported</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#HTTPVersionNotSupported">http://www.w3.org/2011/http-statusCodes#HTTPVersionNotSupported</seealso>
    let HTTPVersionNotSupported =
        Prefixed_Name(httpstatusCodes, "HTTPVersionNotSupported") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:BadGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#BadGateway">http://www.w3.org/2011/http-statusCodes#BadGateway</seealso>
    let BadGateway = Prefixed_Name(httpstatusCodes, "BadGateway") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:Conflict</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Conflict">http://www.w3.org/2011/http-statusCodes#Conflict</seealso>
    let Conflict = Prefixed_Name(httpstatusCodes, "Conflict") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:BadRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#BadRequest">http://www.w3.org/2011/http-statusCodes#BadRequest</seealso>
    let BadRequest = Prefixed_Name(httpstatusCodes, "BadRequest") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:Created</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Created">http://www.w3.org/2011/http-statusCodes#Created</seealso>
    let Created = Prefixed_Name(httpstatusCodes, "Created") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:ExpectationFailed</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#ExpectationFailed">http://www.w3.org/2011/http-statusCodes#ExpectationFailed</seealso>
    let ExpectationFailed =
        Prefixed_Name(httpstatusCodes, "ExpectationFailed") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:Gone</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Gone">http://www.w3.org/2011/http-statusCodes#Gone</seealso>
    let Gone = Prefixed_Name(httpstatusCodes, "Gone") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:InsufficientStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#InsufficientStorage">http://www.w3.org/2011/http-statusCodes#InsufficientStorage</seealso>
    let InsufficientStorage =
        Prefixed_Name(httpstatusCodes, "InsufficientStorage") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:InternalServerError</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#InternalServerError">http://www.w3.org/2011/http-statusCodes#InternalServerError</seealso>
    let InternalServerError =
        Prefixed_Name(httpstatusCodes, "InternalServerError") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:Locked</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Locked">http://www.w3.org/2011/http-statusCodes#Locked</seealso>
    let Locked = Prefixed_Name(httpstatusCodes, "Locked") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:MovedPermanently</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#MovedPermanently">http://www.w3.org/2011/http-statusCodes#MovedPermanently</seealso>
    let MovedPermanently =
        Prefixed_Name(httpstatusCodes, "MovedPermanently") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:MultipleChoices</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#MultipleChoices">http://www.w3.org/2011/http-statusCodes#MultipleChoices</seealso>
    let MultipleChoices =
        Prefixed_Name(httpstatusCodes, "MultipleChoices") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:Continue</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode1xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Continue">http://www.w3.org/2011/http-statusCodes#Continue</seealso>
    let Continue = Prefixed_Name(httpstatusCodes, "Continue") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A status code starting with 3</para>
    /// labels<para>Redirection</para></remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#StatusCode3xx">http://www.w3.org/2011/http-statusCodes#StatusCode3xx</seealso>
    let StatusCode3xx = Prefixed_Name(httpstatusCodes, "StatusCode3xx") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:MethodNotAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#MethodNotAllowed">http://www.w3.org/2011/http-statusCodes#MethodNotAllowed</seealso>
    let MethodNotAllowed =
        Prefixed_Name(httpstatusCodes, "MethodNotAllowed") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:NotFound</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#NotFound">http://www.w3.org/2011/http-statusCodes#NotFound</seealso>
    let NotFound = Prefixed_Name(httpstatusCodes, "NotFound") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:NotModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#NotModified">http://www.w3.org/2011/http-statusCodes#NotModified</seealso>
    let NotModified = Prefixed_Name(httpstatusCodes, "NotModified") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:PartialContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#PartialContent">http://www.w3.org/2011/http-statusCodes#PartialContent</seealso>
    let PartialContent =
        Prefixed_Name(httpstatusCodes, "PartialContent") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:ProxyAuthenticationRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#ProxyAuthenticationRequired">http://www.w3.org/2011/http-statusCodes#ProxyAuthenticationRequired</seealso>
    let ProxyAuthenticationRequired =
        Prefixed_Name(httpstatusCodes, "ProxyAuthenticationRequired") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:ResetContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#ResetContent">http://www.w3.org/2011/http-statusCodes#ResetContent</seealso>
    let ResetContent = Prefixed_Name(httpstatusCodes, "ResetContent") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:ServiceUnavailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#ServiceUnavailable">http://www.w3.org/2011/http-statusCodes#ServiceUnavailable</seealso>
    let ServiceUnavailable =
        Prefixed_Name(httpstatusCodes, "ServiceUnavailable") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:SwitchingProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode1xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#SwitchingProtocols">http://www.w3.org/2011/http-statusCodes#SwitchingProtocols</seealso>
    let SwitchingProtocols =
        Prefixed_Name(httpstatusCodes, "SwitchingProtocols") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:TemporaryRedirect</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#TemporaryRedirect">http://www.w3.org/2011/http-statusCodes#TemporaryRedirect</seealso>
    let TemporaryRedirect =
        Prefixed_Name(httpstatusCodes, "TemporaryRedirect") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:UnsupportedMediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#UnsupportedMediaType">http://www.w3.org/2011/http-statusCodes#UnsupportedMediaType</seealso>
    let UnsupportedMediaType =
        Prefixed_Name(httpstatusCodes, "UnsupportedMediaType") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:NoContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#NoContent">http://www.w3.org/2011/http-statusCodes#NoContent</seealso>
    let NoContent = Prefixed_Name(httpstatusCodes, "NoContent") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:MultiStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#MultiStatus">http://www.w3.org/2011/http-statusCodes#MultiStatus</seealso>
    let MultiStatus = Prefixed_Name(httpstatusCodes, "MultiStatus") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:NotAcceptable</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#NotAcceptable">http://www.w3.org/2011/http-statusCodes#NotAcceptable</seealso>
    let NotAcceptable = Prefixed_Name(httpstatusCodes, "NotAcceptable") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:NonAuthoritativeInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#NonAuthoritativeInformation">http://www.w3.org/2011/http-statusCodes#NonAuthoritativeInformation</seealso>
    let NonAuthoritativeInformation =
        Prefixed_Name(httpstatusCodes, "NonAuthoritativeInformation") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:NotExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#NotExtended">http://www.w3.org/2011/http-statusCodes#NotExtended</seealso>
    let NotExtended = Prefixed_Name(httpstatusCodes, "NotExtended") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:NotImplemented</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#NotImplemented">http://www.w3.org/2011/http-statusCodes#NotImplemented</seealso>
    let NotImplemented =
        Prefixed_Name(httpstatusCodes, "NotImplemented") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:OK</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode2xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#OK">http://www.w3.org/2011/http-statusCodes#OK</seealso>
    let OK = Prefixed_Name(httpstatusCodes, "OK") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:PaymentRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#PaymentRequired">http://www.w3.org/2011/http-statusCodes#PaymentRequired</seealso>
    let PaymentRequired =
        Prefixed_Name(httpstatusCodes, "PaymentRequired") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:Processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode1xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Processing">http://www.w3.org/2011/http-statusCodes#Processing</seealso>
    let Processing = Prefixed_Name(httpstatusCodes, "Processing") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:RequestTimeout</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#RequestTimeout">http://www.w3.org/2011/http-statusCodes#RequestTimeout</seealso>
    let RequestTimeout =
        Prefixed_Name(httpstatusCodes, "RequestTimeout") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:RequestedRangeNotSatisfiable</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#RequestedRangeNotSatisfiable">http://www.w3.org/2011/http-statusCodes#RequestedRangeNotSatisfiable</seealso>
    let RequestedRangeNotSatisfiable =
        Prefixed_Name(httpstatusCodes, "RequestedRangeNotSatisfiable") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:PreconditionFailed</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#PreconditionFailed">http://www.w3.org/2011/http-statusCodes#PreconditionFailed</seealso>
    let PreconditionFailed =
        Prefixed_Name(httpstatusCodes, "PreconditionFailed") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:RequestEntityTooLarge</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#RequestEntityTooLarge">http://www.w3.org/2011/http-statusCodes#RequestEntityTooLarge</seealso>
    let RequestEntityTooLarge =
        Prefixed_Name(httpstatusCodes, "RequestEntityTooLarge") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:RequestURITooLong</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#RequestURITooLong">http://www.w3.org/2011/http-statusCodes#RequestURITooLong</seealso>
    let RequestURITooLong =
        Prefixed_Name(httpstatusCodes, "RequestURITooLong") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:Reserved</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Reserved">http://www.w3.org/2011/http-statusCodes#Reserved</seealso>
    let Reserved = Prefixed_Name(httpstatusCodes, "Reserved") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:SeeOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#SeeOther">http://www.w3.org/2011/http-statusCodes#SeeOther</seealso>
    let SeeOther = Prefixed_Name(httpstatusCodes, "SeeOther") |> PrefixedName
    /// <summary>
    ///   <para>httpstatusCodes:Unauthorized</para>
    /// </summary>
    /// <remarks>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    ///   <para>htir:StatusCode</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#Unauthorized">http://www.w3.org/2011/http-statusCodes#Unauthorized</seealso>
    let Unauthorized = Prefixed_Name(httpstatusCodes, "Unauthorized") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:UpgradeRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#UpgradeRequired">http://www.w3.org/2011/http-statusCodes#UpgradeRequired</seealso>
    let UpgradeRequired =
        Prefixed_Name(httpstatusCodes, "UpgradeRequired") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:UnprocessableEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode4xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#UnprocessableEntity">http://www.w3.org/2011/http-statusCodes#UnprocessableEntity</seealso>
    let UnprocessableEntity =
        Prefixed_Name(httpstatusCodes, "UnprocessableEntity") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:UseProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode3xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#UseProxy">http://www.w3.org/2011/http-statusCodes#UseProxy</seealso>
    let UseProxy = Prefixed_Name(httpstatusCodes, "UseProxy") |> PrefixedName

    /// <summary>
    ///   <para>httpstatusCodes:VariantAlsoNegotiates</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:StatusCode</para>
    ///   <para>httpstatusCodes:StatusCode5xx</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-statusCodes#VariantAlsoNegotiates">http://www.w3.org/2011/http-statusCodes#VariantAlsoNegotiates</seealso>
    let VariantAlsoNegotiates =
        Prefixed_Name(httpstatusCodes, "VariantAlsoNegotiates") |> PrefixedName
