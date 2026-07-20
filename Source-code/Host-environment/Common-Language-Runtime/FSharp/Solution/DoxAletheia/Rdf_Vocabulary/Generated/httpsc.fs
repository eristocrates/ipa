namespace http.www.w3.org._2011.http_statusCodes.hash

open DoxAletheia

module httpsc =
    let _namespace_name = "http://www.w3.org/2011/http-statusCodes#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Accepted"></see>
    /// </summary>
    let Accepted = _prefix "Accepted"
    /// <summary>
    /// A status code starting with 2
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode2xx"></see></summary>
    let StatusCode2xx = _prefix "StatusCode2xx"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#BadGateway"></see>
    /// </summary>
    let BadGateway = _prefix "BadGateway"
    /// <summary>
    /// A status code starting with 5
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode5xx"></see></summary>
    let StatusCode5xx = _prefix "StatusCode5xx"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#BadRequest"></see>
    /// </summary>
    let BadRequest = _prefix "BadRequest"
    /// <summary>
    /// A status code starting with 4
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode4xx"></see></summary>
    let StatusCode4xx = _prefix "StatusCode4xx"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Conflict"></see>
    /// </summary>
    let Conflict = _prefix "Conflict"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Continue"></see>
    /// </summary>
    let Continue = _prefix "Continue"
    /// <summary>
    /// A status code starting with 1
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode1xx"></see></summary>
    let StatusCode1xx = _prefix "StatusCode1xx"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Created"></see>
    /// </summary>
    let Created = _prefix "Created"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#ExpectationFailed"></see>
    /// </summary>
    let ExpectationFailed = _prefix "ExpectationFailed"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#FailedDependency"></see>
    /// </summary>
    let FailedDependency = _prefix "FailedDependency"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Forbidden"></see>
    /// </summary>
    let Forbidden = _prefix "Forbidden"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Found"></see>
    /// </summary>
    let Found = _prefix "Found"
    /// <summary>
    /// A status code starting with 3
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode3xx"></see></summary>
    let StatusCode3xx = _prefix "StatusCode3xx"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#GatewayTimeout"></see>
    /// </summary>
    let GatewayTimeout = _prefix "GatewayTimeout"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Gone"></see>
    /// </summary>
    let Gone = _prefix "Gone"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#HTTPVersionNotSupported"></see>
    /// </summary>
    let HTTPVersionNotSupported = _prefix "HTTPVersionNotSupported"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#IMUsed"></see>
    /// </summary>
    let IMUsed = _prefix "IMUsed"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#InsufficientStorage"></see>
    /// </summary>
    let InsufficientStorage = _prefix "InsufficientStorage"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#InternalServerError"></see>
    /// </summary>
    let InternalServerError = _prefix "InternalServerError"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#LengthRequired"></see>
    /// </summary>
    let LengthRequired = _prefix "LengthRequired"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Locked"></see>
    /// </summary>
    let Locked = _prefix "Locked"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#MethodNotAllowed"></see>
    /// </summary>
    let MethodNotAllowed = _prefix "MethodNotAllowed"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#MovedPermanently"></see>
    /// </summary>
    let MovedPermanently = _prefix "MovedPermanently"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#MultiStatus"></see>
    /// </summary>
    let MultiStatus = _prefix "MultiStatus"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#MultipleChoices"></see>
    /// </summary>
    let MultipleChoices = _prefix "MultipleChoices"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NoContent"></see>
    /// </summary>
    let NoContent = _prefix "NoContent"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NonAuthoritativeInformation"></see>
    /// </summary>
    let NonAuthoritativeInformation = _prefix "NonAuthoritativeInformation"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotAcceptable"></see>
    /// </summary>
    let NotAcceptable = _prefix "NotAcceptable"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotExtended"></see>
    /// </summary>
    let NotExtended = _prefix "NotExtended"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotFound"></see>
    /// </summary>
    let NotFound = _prefix "NotFound"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotImplemented"></see>
    /// </summary>
    let NotImplemented = _prefix "NotImplemented"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotModified"></see>
    /// </summary>
    let NotModified = _prefix "NotModified"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#OK"></see>
    /// </summary>
    let OK = _prefix "OK"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#PartialContent"></see>
    /// </summary>
    let PartialContent = _prefix "PartialContent"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#PaymentRequired"></see>
    /// </summary>
    let PaymentRequired = _prefix "PaymentRequired"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#PreconditionFailed"></see>
    /// </summary>
    let PreconditionFailed = _prefix "PreconditionFailed"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Processing"></see>
    /// </summary>
    let Processing = _prefix "Processing"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#ProxyAuthenticationRequired"></see>
    /// </summary>
    let ProxyAuthenticationRequired = _prefix "ProxyAuthenticationRequired"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#RequestEntityTooLarge"></see>
    /// </summary>
    let RequestEntityTooLarge = _prefix "RequestEntityTooLarge"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#RequestTimeout"></see>
    /// </summary>
    let RequestTimeout = _prefix "RequestTimeout"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#RequestURITooLong"></see>
    /// </summary>
    let RequestURITooLong = _prefix "RequestURITooLong"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#RequestedRangeNotSatisfiable"></see>
    /// </summary>
    let RequestedRangeNotSatisfiable = _prefix "RequestedRangeNotSatisfiable"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Reserved"></see>
    /// </summary>
    let Reserved = _prefix "Reserved"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#ResetContent"></see>
    /// </summary>
    let ResetContent = _prefix "ResetContent"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#SeeOther"></see>
    /// </summary>
    let SeeOther = _prefix "SeeOther"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#ServiceUnavailable"></see>
    /// </summary>
    let ServiceUnavailable = _prefix "ServiceUnavailable"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#SwitchingProtocols"></see>
    /// </summary>
    let SwitchingProtocols = _prefix "SwitchingProtocols"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#TemporaryRedirect"></see>
    /// </summary>
    let TemporaryRedirect = _prefix "TemporaryRedirect"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Unauthorized"></see>
    /// </summary>
    let Unauthorized = _prefix "Unauthorized"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#UnprocessableEntity"></see>
    /// </summary>
    let UnprocessableEntity = _prefix "UnprocessableEntity"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#UnsupportedMediaType"></see>
    /// </summary>
    let UnsupportedMediaType = _prefix "UnsupportedMediaType"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#UpgradeRequired"></see>
    /// </summary>
    let UpgradeRequired = _prefix "UpgradeRequired"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#UseProxy"></see>
    /// </summary>
    let UseProxy = _prefix "UseProxy"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#VariantAlsoNegotiates"></see>
    /// </summary>
    let VariantAlsoNegotiates = _prefix "VariantAlsoNegotiates"
