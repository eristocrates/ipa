namespace http.www.w3.org._2011.http_statusCodes.hash

open DoxAletheia.Rdf_Vocabulary

module httpsc =
    let _namespace_name = "http://www.w3.org/2011/http-statusCodes#"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Accepted"></see>
    /// </summary>
    let Accepted = Namespaced_IRI.parse _namespace_name "Accepted" |> NamespacedName

    /// <summary>
    /// A status code starting with 2
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode2xx"></see></summary>
    let StatusCode2xx =
        Namespaced_IRI.parse _namespace_name "StatusCode2xx" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#BadGateway"></see>
    /// </summary>
    let BadGateway = Namespaced_IRI.parse _namespace_name "BadGateway" |> NamespacedName

    /// <summary>
    /// A status code starting with 5
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode5xx"></see></summary>
    let StatusCode5xx =
        Namespaced_IRI.parse _namespace_name "StatusCode5xx" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#BadRequest"></see>
    /// </summary>
    let BadRequest = Namespaced_IRI.parse _namespace_name "BadRequest" |> NamespacedName

    /// <summary>
    /// A status code starting with 4
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode4xx"></see></summary>
    let StatusCode4xx =
        Namespaced_IRI.parse _namespace_name "StatusCode4xx" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Conflict"></see>
    /// </summary>
    let Conflict = Namespaced_IRI.parse _namespace_name "Conflict" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Continue"></see>
    /// </summary>
    let Continue = Namespaced_IRI.parse _namespace_name "Continue" |> NamespacedName

    /// <summary>
    /// A status code starting with 1
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode1xx"></see></summary>
    let StatusCode1xx =
        Namespaced_IRI.parse _namespace_name "StatusCode1xx" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Created"></see>
    /// </summary>
    let Created = Namespaced_IRI.parse _namespace_name "Created" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#ExpectationFailed"></see>
    /// </summary>
    let ExpectationFailed =
        Namespaced_IRI.parse _namespace_name "ExpectationFailed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#FailedDependency"></see>
    /// </summary>
    let FailedDependency =
        Namespaced_IRI.parse _namespace_name "FailedDependency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Forbidden"></see>
    /// </summary>
    let Forbidden = Namespaced_IRI.parse _namespace_name "Forbidden" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Found"></see>
    /// </summary>
    let Found = Namespaced_IRI.parse _namespace_name "Found" |> NamespacedName

    /// <summary>
    /// A status code starting with 3
    /// <see href="http://www.w3.org/2011/http-statusCodes#StatusCode3xx"></see></summary>
    let StatusCode3xx =
        Namespaced_IRI.parse _namespace_name "StatusCode3xx" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#GatewayTimeout"></see>
    /// </summary>
    let GatewayTimeout =
        Namespaced_IRI.parse _namespace_name "GatewayTimeout" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Gone"></see>
    /// </summary>
    let Gone = Namespaced_IRI.parse _namespace_name "Gone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#HTTPVersionNotSupported"></see>
    /// </summary>
    let HTTPVersionNotSupported =
        Namespaced_IRI.parse _namespace_name "HTTPVersionNotSupported" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#IMUsed"></see>
    /// </summary>
    let IMUsed = Namespaced_IRI.parse _namespace_name "IMUsed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#InsufficientStorage"></see>
    /// </summary>
    let InsufficientStorage =
        Namespaced_IRI.parse _namespace_name "InsufficientStorage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#InternalServerError"></see>
    /// </summary>
    let InternalServerError =
        Namespaced_IRI.parse _namespace_name "InternalServerError" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#LengthRequired"></see>
    /// </summary>
    let LengthRequired =
        Namespaced_IRI.parse _namespace_name "LengthRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Locked"></see>
    /// </summary>
    let Locked = Namespaced_IRI.parse _namespace_name "Locked" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#MethodNotAllowed"></see>
    /// </summary>
    let MethodNotAllowed =
        Namespaced_IRI.parse _namespace_name "MethodNotAllowed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#MovedPermanently"></see>
    /// </summary>
    let MovedPermanently =
        Namespaced_IRI.parse _namespace_name "MovedPermanently" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#MultiStatus"></see>
    /// </summary>
    let MultiStatus =
        Namespaced_IRI.parse _namespace_name "MultiStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#MultipleChoices"></see>
    /// </summary>
    let MultipleChoices =
        Namespaced_IRI.parse _namespace_name "MultipleChoices" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NoContent"></see>
    /// </summary>
    let NoContent = Namespaced_IRI.parse _namespace_name "NoContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NonAuthoritativeInformation"></see>
    /// </summary>
    let NonAuthoritativeInformation =
        Namespaced_IRI.parse _namespace_name "NonAuthoritativeInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotAcceptable"></see>
    /// </summary>
    let NotAcceptable =
        Namespaced_IRI.parse _namespace_name "NotAcceptable" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotExtended"></see>
    /// </summary>
    let NotExtended =
        Namespaced_IRI.parse _namespace_name "NotExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotFound"></see>
    /// </summary>
    let NotFound = Namespaced_IRI.parse _namespace_name "NotFound" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotImplemented"></see>
    /// </summary>
    let NotImplemented =
        Namespaced_IRI.parse _namespace_name "NotImplemented" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#NotModified"></see>
    /// </summary>
    let NotModified =
        Namespaced_IRI.parse _namespace_name "NotModified" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#OK"></see>
    /// </summary>
    let OK = Namespaced_IRI.parse _namespace_name "OK" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#PartialContent"></see>
    /// </summary>
    let PartialContent =
        Namespaced_IRI.parse _namespace_name "PartialContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#PaymentRequired"></see>
    /// </summary>
    let PaymentRequired =
        Namespaced_IRI.parse _namespace_name "PaymentRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#PreconditionFailed"></see>
    /// </summary>
    let PreconditionFailed =
        Namespaced_IRI.parse _namespace_name "PreconditionFailed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Processing"></see>
    /// </summary>
    let Processing = Namespaced_IRI.parse _namespace_name "Processing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#ProxyAuthenticationRequired"></see>
    /// </summary>
    let ProxyAuthenticationRequired =
        Namespaced_IRI.parse _namespace_name "ProxyAuthenticationRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#RequestEntityTooLarge"></see>
    /// </summary>
    let RequestEntityTooLarge =
        Namespaced_IRI.parse _namespace_name "RequestEntityTooLarge" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#RequestTimeout"></see>
    /// </summary>
    let RequestTimeout =
        Namespaced_IRI.parse _namespace_name "RequestTimeout" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#RequestURITooLong"></see>
    /// </summary>
    let RequestURITooLong =
        Namespaced_IRI.parse _namespace_name "RequestURITooLong" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#RequestedRangeNotSatisfiable"></see>
    /// </summary>
    let RequestedRangeNotSatisfiable =
        Namespaced_IRI.parse _namespace_name "RequestedRangeNotSatisfiable" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Reserved"></see>
    /// </summary>
    let Reserved = Namespaced_IRI.parse _namespace_name "Reserved" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#ResetContent"></see>
    /// </summary>
    let ResetContent =
        Namespaced_IRI.parse _namespace_name "ResetContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#SeeOther"></see>
    /// </summary>
    let SeeOther = Namespaced_IRI.parse _namespace_name "SeeOther" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#ServiceUnavailable"></see>
    /// </summary>
    let ServiceUnavailable =
        Namespaced_IRI.parse _namespace_name "ServiceUnavailable" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#SwitchingProtocols"></see>
    /// </summary>
    let SwitchingProtocols =
        Namespaced_IRI.parse _namespace_name "SwitchingProtocols" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#TemporaryRedirect"></see>
    /// </summary>
    let TemporaryRedirect =
        Namespaced_IRI.parse _namespace_name "TemporaryRedirect" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#Unauthorized"></see>
    /// </summary>
    let Unauthorized =
        Namespaced_IRI.parse _namespace_name "Unauthorized" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#UnprocessableEntity"></see>
    /// </summary>
    let UnprocessableEntity =
        Namespaced_IRI.parse _namespace_name "UnprocessableEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#UnsupportedMediaType"></see>
    /// </summary>
    let UnsupportedMediaType =
        Namespaced_IRI.parse _namespace_name "UnsupportedMediaType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#UpgradeRequired"></see>
    /// </summary>
    let UpgradeRequired =
        Namespaced_IRI.parse _namespace_name "UpgradeRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#UseProxy"></see>
    /// </summary>
    let UseProxy = Namespaced_IRI.parse _namespace_name "UseProxy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-statusCodes#VariantAlsoNegotiates"></see>
    /// </summary>
    let VariantAlsoNegotiates =
        Namespaced_IRI.parse _namespace_name "VariantAlsoNegotiates" |> NamespacedName
