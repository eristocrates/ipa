namespace https.w3id.org.idsa.core.slash

open DoxAletheia.Rdf_Vocabulary

module ids =
    let _namespace_name = "https://w3id.org/idsa/core/"
    /// <summary>
    /// Class of all frequencies.
    /// <see href="https://w3id.org/idsa/core/Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    /// The class of languages potentially being used by textual Data Assets.
    /// <see href="https://w3id.org/idsa/core/Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    /// Instances of the LeftOperand class are used as the leftOperand of a Constraint.
    /// <see href="https://w3id.org/idsa/core/LeftOperand"></see></summary>
    let LeftOperand =
        Namespaced_IRI.parse _namespace_name "LeftOperand" |> NamespacedName

    /// <summary>
    /// Class of scopes that may limit the space of query results, e.g. ALL, ACTIVE_ONLY.
    /// <see href="https://w3id.org/idsa/core/QueryScope"></see></summary>
    let QueryScope = Namespaced_IRI.parse _namespace_name "QueryScope" |> NamespacedName

    /// <summary>
    /// The class of binary operators.
    /// <see href="https://w3id.org/idsa/core/BinaryOperator"></see></summary>
    let BinaryOperator =
        Namespaced_IRI.parse _namespace_name "BinaryOperator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    /// The state which an ids:Artifact may have or not.
    /// <see href="https://w3id.org/idsa/core/ArtifactState"></see></summary>
    let ArtifactState =
        Namespaced_IRI.parse _namespace_name "ArtifactState" |> NamespacedName

    /// <summary>
    /// Class of recipients of a query message, e.g. BROKER, APPSTORE, ANY.
    /// <see href="https://w3id.org/idsa/core/QueryTarget"></see></summary>
    let QueryTarget =
        Namespaced_IRI.parse _namespace_name "QueryTarget" |> NamespacedName

    /// <summary>
    /// Resource control for deployed services.
    /// <see href="https://w3id.org/idsa/core/AppExecutionResources"></see></summary>
    let AppExecutionResources =
        Namespaced_IRI.parse _namespace_name "AppExecutionResources" |> NamespacedName

    /// <summary>
    /// Local audit logging (including integrity protection) is the baseline for auditing and clearing. Remote audit log tracing provides means to do external audit verification.
    /// <see href="https://w3id.org/idsa/core/AuditGuarantee"></see></summary>
    let AuditGuarantee =
        Namespaced_IRI.parse _namespace_name "AuditGuarantee" |> NamespacedName

    /// <summary>
    /// Authentication mechanism applied prior to opening a connection. Examples are the verification server's identity or doing mutual authentication.
    /// <see href="https://w3id.org/idsa/core/AuthenticationGuarantee"></see></summary>
    let AuthenticationGuarantee =
        Namespaced_IRI.parse _namespace_name "AuthenticationGuarantee" |> NamespacedName

    /// <summary>
    /// Class of reasons that might lead to issuing a Rejection message.
    /// <see href="https://w3id.org/idsa/core/RejectionReason"></see></summary>
    let RejectionReason =
        Namespaced_IRI.parse _namespace_name "RejectionReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/SecurityProfile"></see>
    /// </summary>
    let SecurityProfile =
        Namespaced_IRI.parse _namespace_name "SecurityProfile" |> NamespacedName

    /// <summary>
    /// Reference to a security guarantee supported by given profile.
    /// <see href="https://w3id.org/idsa/core/securityGuarantee"></see></summary>
    let securityGuarantee =
        Namespaced_IRI.parse _namespace_name "securityGuarantee" |> NamespacedName

    /// <summary>
    /// Level of a Component Certification
    /// <see href="https://w3id.org/idsa/core/ComponentCertificationLevel"></see></summary>
    let ComponentCertificationLevel =
        Namespaced_IRI.parse _namespace_name "ComponentCertificationLevel" |> NamespacedName

    /// <summary>
    /// Certification Level transitively implied by given Certification Level of same root type.
    /// <see href="https://w3id.org/idsa/core/includedCertificationLevel"></see></summary>
    let includedCertificationLevel =
        Namespaced_IRI.parse _namespace_name "includedCertificationLevel" |> NamespacedName

    /// <summary>
    /// Class of endpoint types a data app offers.
    /// <see href="https://w3id.org/idsa/core/AppEndpointType"></see></summary>
    let AppEndpointType =
        Namespaced_IRI.parse _namespace_name "AppEndpointType" |> NamespacedName

    /// <summary>
    /// Connector Status is used to represent a Connectors current state inside the Configuration Model.
    /// <see href="https://w3id.org/idsa/core/ConnectorStatus"></see></summary>
    let ConnectorStatus =
        Namespaced_IRI.parse _namespace_name "ConnectorStatus" |> NamespacedName

    /// <summary>
    /// Instances of ids:LogLevel can be used to specify a log level. Currently this is only used by the Configuration Model.
    /// <see href="https://w3id.org/idsa/core/LogLevel"></see></summary>
    let LogLevel = Namespaced_IRI.parse _namespace_name "LogLevel" |> NamespacedName
    /// <summary>
    /// Cryptographic Key Type.
    /// <see href="https://w3id.org/idsa/core/KeyType"></see></summary>
    let KeyType = Namespaced_IRI.parse _namespace_name "KeyType" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/intervalIn"></see>
    /// </summary>
    let intervalIn = Namespaced_IRI.parse _namespace_name "intervalIn" |> NamespacedName
    /// <summary>
    /// The class of audiences (recipients) used in the JWT.
    /// <see href="https://w3id.org/idsa/core/Audience"></see></summary>
    let Audience = Namespaced_IRI.parse _namespace_name "Audience" |> NamespacedName

    /// <summary>
    /// Level of integrity protection and verification of the installed software stack. Trusted boot is an example of local integrity protection, remote integrity verification comprises, for example, remote attestation.
    /// <see href="https://w3id.org/idsa/core/IntegrityGuarantee"></see></summary>
    let IntegrityGuarantee =
        Namespaced_IRI.parse _namespace_name "IntegrityGuarantee" |> NamespacedName

    /// <summary>
    /// Level/extent of verifying the software stack.
    /// <see href="https://w3id.org/idsa/core/IntegrityVerificationScopeGuarantee"></see></summary>
    let IntegrityVerificationScopeGuarantee =
        Namespaced_IRI.parse _namespace_name "IntegrityVerificationScopeGuarantee" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ContentType"></see>
    /// </summary>
    let ContentType =
        Namespaced_IRI.parse _namespace_name "ContentType" |> NamespacedName

    /// <summary>
    /// Possible formats for (security-related) tokens.
    /// <see href="https://w3id.org/idsa/core/TokenFormat"></see></summary>
    let TokenFormat =
        Namespaced_IRI.parse _namespace_name "TokenFormat" |> NamespacedName

    /// <summary>
    /// Means by which local data is protected.
    /// <see href="https://w3id.org/idsa/core/LocalDataConfidentialityGuarantee"></see></summary>
    let LocalDataConfidentialityGuarantee =
        Namespaced_IRI.parse _namespace_name "LocalDataConfidentialityGuarantee" |> NamespacedName

    /// <summary>
    /// The class of authentication standards that may be supported by Connectors.
    /// <see href="https://w3id.org/idsa/core/AuthStandard"></see></summary>
    let AuthStandard =
        Namespaced_IRI.parse _namespace_name "AuthStandard" |> NamespacedName

    /// <summary>
    /// Level of a Participant Certification
    /// <see href="https://w3id.org/idsa/core/ParticipantCertificationLevel"></see></summary>
    let ParticipantCertificationLevel =
        Namespaced_IRI.parse _namespace_name "ParticipantCertificationLevel" |> NamespacedName

    /// <summary>
    /// This LeftOperand is transitively included in the object LeftOperand.
    /// <see href="https://w3id.org/idsa/core/broader"></see></summary>
    let broader = Namespaced_IRI.parse _namespace_name "broader" |> NamespacedName

    /// <summary>
    /// Deploy mode of a Connector. Used mainly to capture a Connectors deployment type in the Configuration Model.
    /// <see href="https://w3id.org/idsa/core/ConnectorDeployMode"></see></summary>
    let ConnectorDeployMode =
        Namespaced_IRI.parse _namespace_name "ConnectorDeployMode" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/PolicyTemplate"></see>
    /// </summary>
    let PolicyTemplate =
        Namespaced_IRI.parse _namespace_name "PolicyTemplate" |> NamespacedName

    /// <summary>
    /// Service isolation mechanism supported by the Connector. Examples are process group (Docker) or by least privilege with clear separation and support for additional security modules as done by trustme.
    /// <see href="https://w3id.org/idsa/core/ServiceIsolationGuarantee"></see></summary>
    let ServiceIsolationGuarantee =
        Namespaced_IRI.parse _namespace_name "ServiceIsolationGuarantee" |> NamespacedName

    /// <summary>
    /// Class of query languages in which query strings may be formalized.
    /// <see href="https://w3id.org/idsa/core/QueryLanguage"></see></summary>
    let QueryLanguage =
        Namespaced_IRI.parse _namespace_name "QueryLanguage" |> NamespacedName

    /// <summary>
    /// Extent of supporting usage control.
    /// <see href="https://w3id.org/idsa/core/UsageControlGuarantee"></see></summary>
    let UsageControlGuarantee =
        Namespaced_IRI.parse _namespace_name "UsageControlGuarantee" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/IDSA"></see>
    /// </summary>
    let IDSA = Namespaced_IRI.parse _namespace_name "IDSA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AbstractConstraint"></see>
    /// </summary>
    let AbstractConstraint =
        Namespaced_IRI.parse _namespace_name "AbstractConstraint" |> NamespacedName

    /// <summary>
    /// Message requesting an access token. This is intended for point-to-point communication with, e.g., Brokers.
    /// <see href="https://w3id.org/idsa/core/AccessTokenRequestMessage"></see></summary>
    let AccessTokenRequestMessage =
        Namespaced_IRI.parse _namespace_name "AccessTokenRequestMessage" |> NamespacedName

    /// <summary>
    /// Client-generated message initiating a communication, motivated by a certain reason and with an answer expected.
    /// <see href="https://w3id.org/idsa/core/RequestMessage"></see></summary>
    let RequestMessage =
        Namespaced_IRI.parse _namespace_name "RequestMessage" |> NamespacedName

    /// <summary>
    /// Response to an access token request, intended for point-to-point communication.
    /// <see href="https://w3id.org/idsa/core/AccessTokenResponseMessage"></see></summary>
    let AccessTokenResponseMessage =
        Namespaced_IRI.parse _namespace_name "AccessTokenResponseMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ResponseMessage"></see>
    /// </summary>
    let ResponseMessage =
        Namespaced_IRI.parse _namespace_name "ResponseMessage" |> NamespacedName

    /// <summary>
    /// Constraint that refines an Action.
    /// <see href="https://w3id.org/idsa/core/actionRefinement"></see></summary>
    let actionRefinement =
        Namespaced_IRI.parse _namespace_name "actionRefinement" |> NamespacedName

    /// <summary>
    /// Internal or external Agent interacting with the Industrial Data Space, not necessarily an IDS Participant.
    /// <see href="https://w3id.org/idsa/core/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Described"></see>
    /// </summary>
    let Described = Namespaced_IRI.parse _namespace_name "Described" |> NamespacedName

    /// <summary>
    /// Message indicating that a specific App should be available (again) in the AppStore.
    /// <see href="https://w3id.org/idsa/core/AppAvailableMessage"></see></summary>
    let AppAvailableMessage =
        Namespaced_IRI.parse _namespace_name "AppAvailableMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AppNotificationMessage"></see>
    /// </summary>
    let AppNotificationMessage =
        Namespaced_IRI.parse _namespace_name "AppNotificationMessage" |> NamespacedName

    /// <summary>
    /// Message indicating that an App should be deleted from the AppStore.
    /// <see href="https://w3id.org/idsa/core/AppDeleteMessage"></see></summary>
    let AppDeleteMessage =
        Namespaced_IRI.parse _namespace_name "AppDeleteMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AppEndpoint"></see>
    /// </summary>
    let AppEndpoint =
        Namespaced_IRI.parse _namespace_name "AppEndpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Endpoint"></see>
    /// </summary>
    let Endpoint = Namespaced_IRI.parse _namespace_name "Endpoint" |> NamespacedName

    /// <summary>
    /// Type of an app endpoint. Data apps have different endpoint types, e.g., for input, output or health status.
    /// <see href="https://w3id.org/idsa/core/appEndpointType"></see></summary>
    let appEndpointType =
        Namespaced_IRI.parse _namespace_name "appEndpointType" |> NamespacedName

    /// <summary>
    /// Security guarantee claimed by a security profile.
    /// <see href="https://w3id.org/idsa/core/SecurityGuarantee"></see></summary>
    let SecurityGuarantee =
        Namespaced_IRI.parse _namespace_name "SecurityGuarantee" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ResourceNotificationMessage"></see>
    /// </summary>
    let ResourceNotificationMessage =
        Namespaced_IRI.parse _namespace_name "ResourceNotificationMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedDataAppResource"></see>
    /// </summary>
    let affectedDataAppResource =
        Namespaced_IRI.parse _namespace_name "affectedDataAppResource" |> NamespacedName

    /// <summary>
    /// Message that asks for registration or update of a data app to the App Store. Payload contains app-related metadata (instance of class ids:AppResource). Message header may contain an app identifier parameter of a prior registered data app. If the app identifier is supplied, the message should be interpreted as a registration for an app update. Otherwise this message is used to register a new app.
    /// <see href="https://w3id.org/idsa/core/AppRegistrationRequestMessage"></see></summary>
    let AppRegistrationRequestMessage =
        Namespaced_IRI.parse _namespace_name "AppRegistrationRequestMessage" |> NamespacedName

    /// <summary>
    /// Message that follows up an AppRegistrationRequestMessage and contains the app registration confimation.
    /// <see href="https://w3id.org/idsa/core/AppRegistrationResponseMessage"></see></summary>
    let AppRegistrationResponseMessage =
        Namespaced_IRI.parse _namespace_name "AppRegistrationResponseMessage" |> NamespacedName

    /// <summary>
    /// App representation
    /// <see href="https://w3id.org/idsa/core/AppRepresentation"></see></summary>
    let AppRepresentation =
        Namespaced_IRI.parse _namespace_name "AppRepresentation" |> NamespacedName

    /// <summary>
    /// Software representation
    /// <see href="https://w3id.org/idsa/core/SoftwareRepresentation"></see></summary>
    let SoftwareRepresentation =
        Namespaced_IRI.parse _namespace_name "SoftwareRepresentation" |> NamespacedName

    /// <summary>
    /// Resource comprising IDS data apps.
    /// <see href="https://w3id.org/idsa/core/AppResource"></see></summary>
    let AppResource =
        Namespaced_IRI.parse _namespace_name "AppResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Resource"></see>
    /// </summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AppRoute"></see>
    /// </summary>
    let AppRoute = Namespaced_IRI.parse _namespace_name "AppRoute" |> NamespacedName

    /// <summary>
    /// Supplementary information about, e.g., the technology used, for routes.
    /// <see href="https://w3id.org/idsa/core/routeDeployMethod"></see></summary>
    let routeDeployMethod =
        Namespaced_IRI.parse _namespace_name "routeDeployMethod" |> NamespacedName

    /// <summary>
    /// Route between two or more app endpoints inside a app routing pipeline.
    /// <see href="https://w3id.org/idsa/core/subRoute"></see></summary>
    let subRoute = Namespaced_IRI.parse _namespace_name "subRoute" |> NamespacedName

    /// <summary>
    /// Start of a route.
    /// <see href="https://w3id.org/idsa/core/appRouteStart"></see></summary>
    let appRouteStart =
        Namespaced_IRI.parse _namespace_name "appRouteStart" |> NamespacedName

    /// <summary>
    /// End of a route.
    /// <see href="https://w3id.org/idsa/core/appRouteEnd"></see></summary>
    let appRouteEnd =
        Namespaced_IRI.parse _namespace_name "appRouteEnd" |> NamespacedName

    /// <summary>
    /// Secure platform for distributing Data Apps.
    /// <see href="https://w3id.org/idsa/core/AppStore"></see></summary>
    let AppStore = Namespaced_IRI.parse _namespace_name "AppStore" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Connector"></see>
    /// </summary>
    let Connector = Namespaced_IRI.parse _namespace_name "Connector" |> NamespacedName

    /// <summary>
    /// Message indicating that a specific App should be unavailable in the AppStore.
    /// <see href="https://w3id.org/idsa/core/AppUnavailableMessage"></see></summary>
    let AppUnavailableMessage =
        Namespaced_IRI.parse _namespace_name "AppUnavailableMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AppUploadMessage"></see>
    /// </summary>
    let AppUploadMessage =
        Namespaced_IRI.parse _namespace_name "AppUploadMessage" |> NamespacedName

    /// <summary>
    /// Message used to upload a data to a recipient. Payload contains data.
    /// <see href="https://w3id.org/idsa/core/UploadMessage"></see></summary>
    let UploadMessage =
        Namespaced_IRI.parse _namespace_name "UploadMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/appArtifactReference"></see>
    /// </summary>
    let appArtifactReference =
        Namespaced_IRI.parse _namespace_name "appArtifactReference" |> NamespacedName

    /// <summary>
    /// Message that follows up an AppUploadMessage and contains the app upload confimation.
    /// <see href="https://w3id.org/idsa/core/AppUploadResponseMessage"></see></summary>
    let AppUploadResponseMessage =
        Namespaced_IRI.parse _namespace_name "AppUploadResponseMessage" |> NamespacedName

    /// <summary>
    /// Message that follows up a UploadMessage and contains the upload confirmation.
    /// <see href="https://w3id.org/idsa/core/UploadResponseMessage"></see></summary>
    let UploadResponseMessage =
        Namespaced_IRI.parse _namespace_name "UploadResponseMessage" |> NamespacedName

    /// <summary>
    /// Instance of a Representation materialized at a partiuclar version and point in time. Possesses characteristics like file name, size, creation date etc.
    /// <see href="https://w3id.org/idsa/core/Artifact"></see></summary>
    let Artifact = Namespaced_IRI.parse _namespace_name "Artifact" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/RepresentationInstance"></see>
    /// </summary>
    let RepresentationInstance =
        Namespaced_IRI.parse _namespace_name "RepresentationInstance" |> NamespacedName

    /// <summary>
    /// Literal, inline value instantiation of a representation.
    /// <see href="https://w3id.org/idsa/core/Value"></see></summary>
    let Value = Namespaced_IRI.parse _namespace_name "Value" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ArtifactRequestMessage"></see>
    /// </summary>
    let ArtifactRequestMessage =
        Namespaced_IRI.parse _namespace_name "ArtifactRequestMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/requestedArtifact"></see>
    /// </summary>
    let requestedArtifact =
        Namespaced_IRI.parse _namespace_name "requestedArtifact" |> NamespacedName

    /// <summary>
    /// Message that follows up a RetrieveArtifact Message and contains the Artifact's data in the payload section.
    /// <see href="https://w3id.org/idsa/core/ArtifactResponseMessage"></see></summary>
    let ArtifactResponseMessage =
        Namespaced_IRI.parse _namespace_name "ArtifactResponseMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Asset"></see>
    /// </summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName

    /// <summary>
    /// An AssetCollection is a bracket object combining several ids:Assets.
    /// <see href="https://w3id.org/idsa/core/AssetCollection"></see></summary>
    let AssetCollection =
        Namespaced_IRI.parse _namespace_name "AssetCollection" |> NamespacedName

    /// <summary>
    /// Audio representation
    /// <see href="https://w3id.org/idsa/core/AudioRepresentation"></see></summary>
    let AudioRepresentation =
        Namespaced_IRI.parse _namespace_name "AudioRepresentation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Representation"></see>
    /// </summary>
    let Representation =
        Namespaced_IRI.parse _namespace_name "Representation" |> NamespacedName

    /// <summary>
    /// Resource (at least partially) comprising audio content.
    /// <see href="https://w3id.org/idsa/core/AudioResource"></see></summary>
    let AudioResource =
        Namespaced_IRI.parse _namespace_name "AudioResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AuthInfo"></see>
    /// </summary>
    let AuthInfo = Namespaced_IRI.parse _namespace_name "AuthInfo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/authService"></see>
    /// </summary>
    let authService =
        Namespaced_IRI.parse _namespace_name "authService" |> NamespacedName

    /// <summary>
    /// Implementation of the Connector specification providing only restricted security capabilities.
    /// <see href="https://w3id.org/idsa/core/BaseConnector"></see></summary>
    let BaseConnector =
        Namespaced_IRI.parse _namespace_name "BaseConnector" |> NamespacedName

    /// <summary>
    /// Basic authentication using username / password
    /// <see href="https://w3id.org/idsa/core/BasicAuthentication"></see></summary>
    let BasicAuthentication =
        Namespaced_IRI.parse _namespace_name "BasicAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/UserAuthentication"></see>
    /// </summary>
    let UserAuthentication =
        Namespaced_IRI.parse _namespace_name "UserAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/BoundingPolygon"></see>
    /// </summary>
    let BoundingPolygon =
        Namespaced_IRI.parse _namespace_name "BoundingPolygon" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Geometry"></see>
    /// </summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName
    /// <summary>
    /// Refers to a GeoPoint that is member of a BoundingPolygon.
    /// <see href="https://w3id.org/idsa/core/geoPoint"></see></summary>
    let geoPoint = Namespaced_IRI.parse _namespace_name "geoPoint" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Broker"></see>
    /// </summary>
    let Broker = Namespaced_IRI.parse _namespace_name "Broker" |> NamespacedName

    /// <summary>
    /// Reference to catalog of Connectors, which are listed in the Broker.
    /// <see href="https://w3id.org/idsa/core/connectorCatalog"></see></summary>
    let connectorCatalog =
        Namespaced_IRI.parse _namespace_name "connectorCatalog" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Catalog"></see>
    /// </summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Certification"></see>
    /// </summary>
    let Certification =
        Namespaced_IRI.parse _namespace_name "Certification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ManagedEntity"></see>
    /// </summary>
    let ManagedEntity =
        Namespaced_IRI.parse _namespace_name "ManagedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/CertificationLevel"></see>
    /// </summary>
    let CertificationLevel =
        Namespaced_IRI.parse _namespace_name "CertificationLevel" |> NamespacedName

    /// <summary>
    /// The Clearing House provides clearing and settlement services B2B interactions within the International Data Spaces.
    /// <see href="https://w3id.org/idsa/core/ClearingHouse"></see></summary>
    let ClearingHouse =
        Namespaced_IRI.parse _namespace_name "ClearingHouse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/InfrastructureComponent"></see>
    /// </summary>
    let InfrastructureComponent =
        Namespaced_IRI.parse _namespace_name "InfrastructureComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/CommandMessage"></see>
    /// </summary>
    let CommandMessage =
        Namespaced_IRI.parse _namespace_name "CommandMessage" |> NamespacedName

    /// <summary>
    /// Process and result of certifying a software component/servivce in order to become a certified part of the International Data Space infrastructure.
    /// <see href="https://w3id.org/idsa/core/ComponentCertification"></see></summary>
    let ComponentCertification =
        Namespaced_IRI.parse _namespace_name "ComponentCertification" |> NamespacedName

    /// <summary>
    /// Level of certification (based on a combination of requierements, evaluation method etc.)
    /// <see href="https://w3id.org/idsa/core/certificationLevel"></see></summary>
    let certificationLevel =
        Namespaced_IRI.parse _namespace_name "certificationLevel" |> NamespacedName

    /// <summary>
    /// Process and result of certifying an interested party in order to become a certified member of the International Data Space.
    /// <see href="https://w3id.org/idsa/core/ParticipantCertification"></see></summary>
    let ParticipantCertification =
        Namespaced_IRI.parse _namespace_name "ParticipantCertification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Concept"></see>
    /// </summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ConfigurationModel"></see>
    /// </summary>
    let ConfigurationModel =
        Namespaced_IRI.parse _namespace_name "ConfigurationModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/appRoute"></see>
    /// </summary>
    let appRoute = Namespaced_IRI.parse _namespace_name "appRoute" |> NamespacedName

    /// <summary>
    /// Deply mode of a Connector in the Configuration Model
    /// <see href="https://w3id.org/idsa/core/connectorDeployMode"></see></summary>
    let connectorDeployMode =
        Namespaced_IRI.parse _namespace_name "connectorDeployMode" |> NamespacedName

    /// <summary>
    /// Status of a Connector deployed by the Configuration Model
    /// <see href="https://w3id.org/idsa/core/connectorStatus"></see></summary>
    let connectorStatus =
        Namespaced_IRI.parse _namespace_name "connectorStatus" |> NamespacedName

    /// <summary>
    /// Log level configuration for a Connector which is deployed using the Configuration Model
    /// <see href="https://w3id.org/idsa/core/configurationModelLogLevel"></see></summary>
    let configurationModelLogLevel =
        Namespaced_IRI.parse _namespace_name "configurationModelLogLevel" |> NamespacedName

    /// <summary>
    /// authentication methods allowed in a Configuration Model
    /// <see href="https://w3id.org/idsa/core/userAuthentication"></see></summary>
    let userAuthentication =
        Namespaced_IRI.parse _namespace_name "userAuthentication" |> NamespacedName

    /// <summary>
    /// Proxies for a Connector which is deployed using the Configuration Model
    /// <see href="https://w3id.org/idsa/core/connectorProxy"></see></summary>
    let connectorProxy =
        Namespaced_IRI.parse _namespace_name "connectorProxy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/hasAgent"></see>
    /// </summary>
    let hasAgent = Namespaced_IRI.parse _namespace_name "hasAgent" |> NamespacedName

    /// <summary>
    /// The SecurityProfile supported by the Connector.
    /// <see href="https://w3id.org/idsa/core/securityProfile"></see></summary>
    let securityProfile =
        Namespaced_IRI.parse _namespace_name "securityProfile" |> NamespacedName

    /// <summary>
    /// References the Catalog of published or requested resource by this Connector.
    /// <see href="https://w3id.org/idsa/core/resourceCatalog"></see></summary>
    let resourceCatalog =
        Namespaced_IRI.parse _namespace_name "resourceCatalog" |> NamespacedName

    /// <summary>
    /// Reference to the Endpoints serving the resource's content or let you exchange messages with an IDS Connector.
    /// <see href="https://w3id.org/idsa/core/hasEndpoint"></see></summary>
    let hasEndpoint =
        Namespaced_IRI.parse _namespace_name "hasEndpoint" |> NamespacedName

    /// <summary>
    /// Reference to a security guarantee that, if used in combination with a security profile instance, overrides the respective guarantee of the given predefined instance.
    /// <see href="https://w3id.org/idsa/core/extendedGuarantee"></see></summary>
    let extendedGuarantee =
        Namespaced_IRI.parse _namespace_name "extendedGuarantee" |> NamespacedName

    /// <summary>
    /// Indicates the default endpoint that should be used for basic infrastructure interactions, e.g., providing the self description.
    /// <see href="https://w3id.org/idsa/core/hasDefaultEndpoint"></see></summary>
    let hasDefaultEndpoint =
        Namespaced_IRI.parse _namespace_name "hasDefaultEndpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ConnectorCatalog"></see>
    /// </summary>
    let ConnectorCatalog =
        Namespaced_IRI.parse _namespace_name "ConnectorCatalog" |> NamespacedName

    /// <summary>
    /// A Connector, that is part of a Connector catalog.
    /// <see href="https://w3id.org/idsa/core/listedConnector"></see></summary>
    let listedConnector =
        Namespaced_IRI.parse _namespace_name "listedConnector" |> NamespacedName

    /// <summary>
    /// Whenever a Connector has been successfully certified by the Certification Body, the Identity Provider can use this message to notify Infrastructure Components.
    /// <see href="https://w3id.org/idsa/core/ConnectorCertificateGrantedMessage"></see></summary>
    let ConnectorCertificateGrantedMessage =
        Namespaced_IRI.parse _namespace_name "ConnectorCertificateGrantedMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ConnectorNotificationMessage"></see>
    /// </summary>
    let ConnectorNotificationMessage =
        Namespaced_IRI.parse _namespace_name "ConnectorNotificationMessage" |> NamespacedName

    /// <summary>
    /// Indicates that a (previously certified) Connector is no more certified. This could happen, for instance, if the Certification Body revokes a granted certificate or if the certificate just expires.
    /// <see href="https://w3id.org/idsa/core/ConnectorCertificateRevokedMessage"></see></summary>
    let ConnectorCertificateRevokedMessage =
        Namespaced_IRI.parse _namespace_name "ConnectorCertificateRevokedMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ConnectorEndpoint"></see>
    /// </summary>
    let ConnectorEndpoint =
        Namespaced_IRI.parse _namespace_name "ConnectorEndpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/accessUrl"></see>
    /// </summary>
    let accessUrl = Namespaced_IRI.parse _namespace_name "accessUrl" |> NamespacedName

    /// <summary>
    /// Event messages are informative and no response is expected by the sender.
    /// <see href="https://w3id.org/idsa/core/NotificationMessage"></see></summary>
    let NotificationMessage =
        Namespaced_IRI.parse _namespace_name "NotificationMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedConnector"></see>
    /// </summary>
    let affectedConnector =
        Namespaced_IRI.parse _namespace_name "affectedConnector" |> NamespacedName

    /// <summary>
    /// Event notifying the recipient(s) that a connector will be unavailable. The same connector may be available again in the future.
    /// <see href="https://w3id.org/idsa/core/ConnectorUnavailableMessage"></see></summary>
    let ConnectorUnavailableMessage =
        Namespaced_IRI.parse _namespace_name "ConnectorUnavailableMessage" |> NamespacedName

    /// <summary>
    /// Event notifying the recipient(s) about the availability and current configuration of a connector. The payload of the message must contain the updated connector's self-description.
    /// <see href="https://w3id.org/idsa/core/ConnectorUpdateMessage"></see></summary>
    let ConnectorUpdateMessage =
        Namespaced_IRI.parse _namespace_name "ConnectorUpdateMessage" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Connector-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/ConnectorbasedAgreement"></see></summary>
    let ConnectorbasedAgreement =
        Namespaced_IRI.parse _namespace_name "ConnectorbasedAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ContractAgreement"></see>
    /// </summary>
    let ContractAgreement =
        Namespaced_IRI.parse _namespace_name "ContractAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Connector-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/ConnectorbasedOffer"></see></summary>
    let ConnectorbasedOffer =
        Namespaced_IRI.parse _namespace_name "ConnectorbasedOffer" |> NamespacedName

    /// <summary>
    /// Contract issued by the Data Provider offering the usage of a Resource at particular conditions.
    /// <see href="https://w3id.org/idsa/core/ContractOffer"></see></summary>
    let ContractOffer =
        Namespaced_IRI.parse _namespace_name "ContractOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Connector-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/ConnectorbasedRequest"></see></summary>
    let ConnectorbasedRequest =
        Namespaced_IRI.parse _namespace_name "ConnectorbasedRequest" |> NamespacedName

    /// <summary>
    /// Contract issued by the Data Consumer requesting the usage of a Resource at particular conditions.
    /// <see href="https://w3id.org/idsa/core/ContractRequest"></see></summary>
    let ContractRequest =
        Namespaced_IRI.parse _namespace_name "ContractRequest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Constraint"></see>
    /// </summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName

    /// <summary>
    /// The left operand in a constraint expression.
    /// <see href="https://w3id.org/idsa/core/leftOperand"></see></summary>
    let leftOperand =
        Namespaced_IRI.parse _namespace_name "leftOperand" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/operator"></see>
    /// </summary>
    let operator = Namespaced_IRI.parse _namespace_name "operator" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Contract"></see>
    /// </summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/permission"></see>
    /// </summary>
    let permission = Namespaced_IRI.parse _namespace_name "permission" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/prohibition"></see>
    /// </summary>
    let prohibition =
        Namespaced_IRI.parse _namespace_name "prohibition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/obligation"></see>
    /// </summary>
    let obligation = Namespaced_IRI.parse _namespace_name "obligation" |> NamespacedName

    /// <summary>
    /// Absolute datetime the Contract is requested, offered or expected to start, depending on the type of Contract.
    /// <see href="https://w3id.org/idsa/core/contractStart"></see></summary>
    let contractStart =
        Namespaced_IRI.parse _namespace_name "contractStart" |> NamespacedName

    /// <summary>
    /// Message containing a contract, as an instance of ids:ContractAgreement, with resource access modalities on which two parties have agreed in the payload.
    /// <see href="https://w3id.org/idsa/core/ContractAgreementMessage"></see></summary>
    let ContractAgreementMessage =
        Namespaced_IRI.parse _namespace_name "ContractAgreementMessage" |> NamespacedName

    /// <summary>
    /// Message containing a offered content contract (as offered by a data provider to the data consumer) in the associated payload (which is an instance of ContractOffer). In contrast to the ids:ContractResponseMessage, the ids:ContractOfferMessage is not related to a previous contract
    /// <see href="https://w3id.org/idsa/core/ContractOfferMessage"></see></summary>
    let ContractOfferMessage =
        Namespaced_IRI.parse _namespace_name "ContractOfferMessage" |> NamespacedName

    /// <summary>
    /// Message indicating rejection of a contract.
    /// <see href="https://w3id.org/idsa/core/ContractRejectionMessage"></see></summary>
    let ContractRejectionMessage =
        Namespaced_IRI.parse _namespace_name "ContractRejectionMessage" |> NamespacedName

    /// <summary>
    /// Rejection messages are specialized response messages that notify the sender of a message that processing of this message has failed.
    /// <see href="https://w3id.org/idsa/core/RejectionMessage"></see></summary>
    let RejectionMessage =
        Namespaced_IRI.parse _namespace_name "RejectionMessage" |> NamespacedName

    /// <summary>
    /// Message containing a suggested content contract (as offered by the data consumer to the data provider) in the associated payload (which is an instance of ContractRequest).
    /// <see href="https://w3id.org/idsa/core/ContractRequestMessage"></see></summary>
    let ContractRequestMessage =
        Namespaced_IRI.parse _namespace_name "ContractRequestMessage" |> NamespacedName

    /// <summary>
    /// Message containing a response to a contract request (of a data consumer) in form of a counter-proposal of a contract in the associated payload (which is an instance of ContractOffcer).
    /// <see href="https://w3id.org/idsa/core/ContractResponseMessage"></see></summary>
    let ContractResponseMessage =
        Namespaced_IRI.parse _namespace_name "ContractResponseMessage" |> NamespacedName

    /// <summary>
    /// Message containing supplemental information to access resources of a contract (e.g. resource access tokens).
    /// <see href="https://w3id.org/idsa/core/ContractSupplementMessage"></see></summary>
    let ContractSupplementMessage =
        Namespaced_IRI.parse _namespace_name "ContractSupplementMessage" |> NamespacedName

    /// <summary>
    /// A selection of custom media types to be used for data published on the IDS when no IANA type is available.
    /// <see href="https://w3id.org/idsa/core/CustomMediaType"></see></summary>
    let CustomMediaType =
        Namespaced_IRI.parse _namespace_name "CustomMediaType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/MediaType"></see>
    /// </summary>
    let MediaType = Namespaced_IRI.parse _namespace_name "MediaType" |> NamespacedName
    /// <summary>
    /// The Dynamic Attribute Provisioning Service (DAPS) is a component of the Identity Provider and manages and issues the Dynamic Attribute Tokens (DAT), acting as digtial proofs for dynamic attributes of both connectors and participants.
    /// <see href="https://w3id.org/idsa/core/DAPS"></see></summary>
    let DAPS = Namespaced_IRI.parse _namespace_name "DAPS" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DatPayload"></see>
    /// </summary>
    let DatPayload = Namespaced_IRI.parse _namespace_name "DatPayload" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/JwtPayload"></see>
    /// </summary>
    let JwtPayload = Namespaced_IRI.parse _namespace_name "JwtPayload" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/referringConnector"></see>
    /// </summary>
    let referringConnector =
        Namespaced_IRI.parse _namespace_name "referringConnector" |> NamespacedName

    /// <summary>
    /// The 'iss' (issuer) claim identifies the principal that issued the JWT.
    /// <see href="https://w3id.org/idsa/core/iss"></see></summary>
    let iss = Namespaced_IRI.parse _namespace_name "iss" |> NamespacedName

    /// <summary>
    /// The Dynamic Attribute Token (DAT) *Request* Payload is the JSON Element of any DAT containing the claims of the token bearer. This payload itself is a JSON-LD encoded RDF class with a defined set of attributes. These attributes are either defined by RFC 7519 or by the IDS Information Model. As a direct consequence of regarding the DAT Payload as JSON-LD, *all* DAT Payloads must have exactly one "@context" attribute with the IDS context URI as its value and a "@type" with ids:DatPayload as its value. Note that, different to the DatPayload, the DatRequestPayload contains the *self-claims* of a connector and is not yet signed by any DAPS. Consequently, no other connector must accept a DatRequest object as a DAT. A DatRequest and its contained DatRequestPayload is *only* intended for interactions with a DAPS and *nothing else*!
    /// <see href="https://w3id.org/idsa/core/DatRequestPayload"></see></summary>
    let DatRequestPayload =
        Namespaced_IRI.parse _namespace_name "DatRequestPayload" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DataApp"></see>
    /// </summary>
    let DataApp = Namespaced_IRI.parse _namespace_name "DataApp" |> NamespacedName

    /// <summary>
    /// Endpoints of a data app
    /// <see href="https://w3id.org/idsa/core/appEndpoint"></see></summary>
    let appEndpoint =
        Namespaced_IRI.parse _namespace_name "appEndpoint" |> NamespacedName

    /// <summary>
    /// Physical representation of (structured) data.
    /// <see href="https://w3id.org/idsa/core/DataRepresentation"></see></summary>
    let DataRepresentation =
        Namespaced_IRI.parse _namespace_name "DataRepresentation" |> NamespacedName

    /// <summary>
    /// Resource (at least partially) comprising data content.
    /// <see href="https://w3id.org/idsa/core/DataResource"></see></summary>
    let DataResource =
        Namespaced_IRI.parse _namespace_name "DataResource" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.
    /// <see href="https://w3id.org/idsa/core/DeleteAfterIntervalAgreement"></see></summary>
    let DeleteAfterIntervalAgreement =
        Namespaced_IRI.parse _namespace_name "DeleteAfterIntervalAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.
    /// <see href="https://w3id.org/idsa/core/DeleteAfterIntervalOffer"></see></summary>
    let DeleteAfterIntervalOffer =
        Namespaced_IRI.parse _namespace_name "DeleteAfterIntervalOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.
    /// <see href="https://w3id.org/idsa/core/DeleteAfterIntervalRequest"></see></summary>
    let DeleteAfterIntervalRequest =
        Namespaced_IRI.parse _namespace_name "DeleteAfterIntervalRequest" |> NamespacedName

    /// <summary>
    /// Explanation of the resource in a natural language text.
    /// <see href="https://w3id.org/idsa/core/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// (Localized) name of the entity.
    /// <see href="https://w3id.org/idsa/core/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DescribedSemantically"></see>
    /// </summary>
    let DescribedSemantically =
        Namespaced_IRI.parse _namespace_name "DescribedSemantically" |> NamespacedName

    /// <summary>
    /// Message requesting metadata. If no URI is supplied via the ids:requestedElement field, this messages is treated like a self-description request and the recipient should return its self-description via an ids:DescriptionResponseMessage. However, if a URI is supplied, the Connector should either return metadata about the requested element via an ids:DescriptionResponseMessage, or send an ids:RejectionMessage, e.g. because the element was not found.
    /// <see href="https://w3id.org/idsa/core/DescriptionRequestMessage"></see></summary>
    let DescriptionRequestMessage =
        Namespaced_IRI.parse _namespace_name "DescriptionRequestMessage" |> NamespacedName

    /// <summary>
    /// Message containing the metadata, which a Connector previously requested via the ids:DescriptionRequestMessage, in its payload.
    /// <see href="https://w3id.org/idsa/core/DescriptionResponseMessage"></see></summary>
    let DescriptionResponseMessage =
        Namespaced_IRI.parse _namespace_name "DescriptionResponseMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DigitalContent"></see>
    /// </summary>
    let DigitalContent =
        Namespaced_IRI.parse _namespace_name "DigitalContent" |> NamespacedName

    /// <summary>
    /// Named spatial entity covered by the Resource.
    /// <see href="https://w3id.org/idsa/core/spatialCoverage"></see></summary>
    let spatialCoverage =
        Namespaced_IRI.parse _namespace_name "spatialCoverage" |> NamespacedName

    /// <summary>
    /// Natural language(s) used within the content.
    /// <see href="https://w3id.org/idsa/core/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// Controlled keywords that describe the nature, purpose, or use of the content.
    /// <see href="https://w3id.org/idsa/core/keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName

    /// <summary>
    /// Reference to a Digital Content (physically or logically) included, definition of part-whole hierarchies.
    /// <see href="https://w3id.org/idsa/core/contentPart"></see></summary>
    let contentPart =
        Namespaced_IRI.parse _namespace_name "contentPart" |> NamespacedName

    /// <summary>
    /// Representation of the content.
    /// <see href="https://w3id.org/idsa/core/representation"></see></summary>
    let representation =
        Namespaced_IRI.parse _namespace_name "representation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/theme"></see>
    /// </summary>
    let theme = Namespaced_IRI.parse _namespace_name "theme" |> NamespacedName

    /// <summary>
    /// Temporal period or instance covered by the content.
    /// <see href="https://w3id.org/idsa/core/temporalCoverage"></see></summary>
    let temporalCoverage =
        Namespaced_IRI.parse _namespace_name "temporalCoverage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/contentRefinement"></see>
    /// </summary>
    let contentRefinement =
        Namespaced_IRI.parse _namespace_name "contentRefinement" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Distribute only if Encrypted' policy class.
    /// <see href="https://w3id.org/idsa/core/DistributeEcryptedAgreement"></see></summary>
    let DistributeEcryptedAgreement =
        Namespaced_IRI.parse _namespace_name "DistributeEcryptedAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Distribute only if Encrypted' policy class.
    /// <see href="https://w3id.org/idsa/core/DistributeEcryptedOffer"></see></summary>
    let DistributeEcryptedOffer =
        Namespaced_IRI.parse _namespace_name "DistributeEcryptedOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Distribute only if Encrypted' policy class.
    /// <see href="https://w3id.org/idsa/core/DistributeEcryptedRequest"></see></summary>
    let DistributeEcryptedRequest =
        Namespaced_IRI.parse _namespace_name "DistributeEcryptedRequest" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Duration-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/DurationAgreement"></see></summary>
    let DurationAgreement =
        Namespaced_IRI.parse _namespace_name "DurationAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DurationEntity"></see>
    /// </summary>
    let DurationEntity =
        Namespaced_IRI.parse _namespace_name "DurationEntity" |> NamespacedName

    /// <summary>
    /// A temporal interval, instant or a relative duration.
    /// <see href="https://w3id.org/idsa/core/TemporalEntity"></see></summary>
    let TemporalEntity =
        Namespaced_IRI.parse _namespace_name "TemporalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/hasDuration"></see>
    /// </summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Duration-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/DurationOffer"></see></summary>
    let DurationOffer =
        Namespaced_IRI.parse _namespace_name "DurationOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Duration-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/DurationRequest"></see></summary>
    let DurationRequest =
        Namespaced_IRI.parse _namespace_name "DurationRequest" |> NamespacedName

    /// <summary>
    /// The class of Duties as defined in the ODRL ontology.
    /// <see href="https://w3id.org/idsa/core/Duty"></see></summary>
    let Duty = Namespaced_IRI.parse _namespace_name "Duty" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Rule"></see>
    /// </summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DynamicAttributeToken"></see>
    /// </summary>
    let DynamicAttributeToken =
        Namespaced_IRI.parse _namespace_name "DynamicAttributeToken" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Token"></see>
    /// </summary>
    let Token = Namespaced_IRI.parse _namespace_name "Token" |> NamespacedName

    /// <summary>
    /// Describes the format of the authentication token.
    /// <see href="https://w3id.org/idsa/core/tokenFormat"></see></summary>
    let tokenFormat =
        Namespaced_IRI.parse _namespace_name "tokenFormat" |> NamespacedName

    /// <summary>
    ///
    ///     EndToEndRoute hold information about a communication pipelines between apps. An EndToEndRoute should hold
    ///     one value for the ids:appRouteStart and/or ids:appRouteEnd properties, so that communication between app endpoints remain distinguishable.
    ///
    /// <see href="https://w3id.org/idsa/core/EndToEndRoute"></see></summary>
    let EndToEndRoute =
        Namespaced_IRI.parse _namespace_name "EndToEndRoute" |> NamespacedName

    /// <summary>
    /// Human-readable information and description of the endpoint.
    /// <see href="https://w3id.org/idsa/core/endpointInformation"></see></summary>
    let endpointInformation =
        Namespaced_IRI.parse _namespace_name "endpointInformation" |> NamespacedName

    /// <summary>
    /// IRI reference to a documentation of the endpoint,  e.g., reference to an OpenAPI-based documentation.
    /// <see href="https://w3id.org/idsa/core/endpointDocumentation"></see></summary>
    let endpointDocumentation =
        Namespaced_IRI.parse _namespace_name "endpointDocumentation" |> NamespacedName

    /// <summary>
    /// Evaluation Facilities carry out the evaluation work during a certification process and issue the corresponding Certifications.
    /// <see href="https://w3id.org/idsa/core/EvaluationFacility"></see></summary>
    let EvaluationFacility =
        Namespaced_IRI.parse _namespace_name "EvaluationFacility" |> NamespacedName

    /// <summary>
    /// Named event with a known or unknown temporal location or duration.
    /// <see href="https://w3id.org/idsa/core/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Event-restricted Usage Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/EventAgreement"></see></summary>
    let EventAgreement =
        Namespaced_IRI.parse _namespace_name "EventAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Event-restricted Usage Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/EventOffer"></see></summary>
    let EventOffer = Namespaced_IRI.parse _namespace_name "EventOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Event-restricted Usage Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/EventRequest"></see></summary>
    let EventRequest =
        Namespaced_IRI.parse _namespace_name "EventRequest" |> NamespacedName

    /// <summary>
    /// A location identified by a geonames URL.
    /// <see href="https://w3id.org/idsa/core/GeoFeature"></see></summary>
    let GeoFeature = Namespaced_IRI.parse _namespace_name "GeoFeature" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Location"></see>
    /// </summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/GeoPoint"></see>
    /// </summary>
    let GeoPoint = Namespaced_IRI.parse _namespace_name "GeoPoint" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/longitude"></see>
    /// </summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/latitude"></see>
    /// </summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName

    /// <summary>
    /// HTTP authentication.
    /// <see href="https://w3id.org/idsa/core/HTTPAuthentication"></see></summary>
    let HTTPAuthentication =
        Namespaced_IRI.parse _namespace_name "HTTPAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/IANAMediaType"></see>
    /// </summary>
    let IANAMediaType =
        Namespaced_IRI.parse _namespace_name "IANAMediaType" |> NamespacedName

    /// <summary>
    /// The Identity Provider manages and validates the digital identity of International Data Spaces Participants.
    /// <see href="https://w3id.org/idsa/core/IdentityProvider"></see></summary>
    let IdentityProvider =
        Namespaced_IRI.parse _namespace_name "IdentityProvider" |> NamespacedName

    /// <summary>
    /// Image representation
    /// <see href="https://w3id.org/idsa/core/ImageRepresentation"></see></summary>
    let ImageRepresentation =
        Namespaced_IRI.parse _namespace_name "ImageRepresentation" |> NamespacedName

    /// <summary>
    /// Resource (at least partially) comprising image content.
    /// <see href="https://w3id.org/idsa/core/ImageResource"></see></summary>
    let ImageResource =
        Namespaced_IRI.parse _namespace_name "ImageResource" |> NamespacedName

    /// <summary>
    /// Information Model version being produced by the InfrastructureComponent.
    /// <see href="https://w3id.org/idsa/core/outboundModelVersion"></see></summary>
    let outboundModelVersion =
        Namespaced_IRI.parse _namespace_name "outboundModelVersion" |> NamespacedName

    /// <summary>
    /// Information Model version that the InfrastructureComponent is capable of reading/processing.
    /// <see href="https://w3id.org/idsa/core/inboundModelVersion"></see></summary>
    let inboundModelVersion =
        Namespaced_IRI.parse _namespace_name "inboundModelVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/curator"></see>
    /// </summary>
    let curator = Namespaced_IRI.parse _namespace_name "curator" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/maintainer"></see>
    /// </summary>
    let maintainer = Namespaced_IRI.parse _namespace_name "maintainer" |> NamespacedName
    /// <summary>
    /// A defined point in time with zero duration.
    /// <see href="https://w3id.org/idsa/core/Instant"></see></summary>
    let Instant = Namespaced_IRI.parse _namespace_name "Instant" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Interval"></see>
    /// </summary>
    let Interval = Namespaced_IRI.parse _namespace_name "Interval" |> NamespacedName
    /// <summary>
    /// Beginning of an Interval.
    /// <see href="https://w3id.org/idsa/core/begin"></see></summary>
    let begin_ = Namespaced_IRI.parse _namespace_name "begin" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Interval-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/IntervalUsageAgreement"></see></summary>
    let IntervalUsageAgreement =
        Namespaced_IRI.parse _namespace_name "IntervalUsageAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Interval-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/IntervalUsageOffer"></see></summary>
    let IntervalUsageOffer =
        Namespaced_IRI.parse _namespace_name "IntervalUsageOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Interval-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/IntervalUsageRequest"></see></summary>
    let IntervalUsageRequest =
        Namespaced_IRI.parse _namespace_name "IntervalUsageRequest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/InvokeOperationMessage"></see>
    /// </summary>
    let InvokeOperationMessage =
        Namespaced_IRI.parse _namespace_name "InvokeOperationMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/operationReference"></see>
    /// </summary>
    let operationReference =
        Namespaced_IRI.parse _namespace_name "operationReference" |> NamespacedName

    /// <summary>
    /// The 'sub' (subject) claim identifies the principal that is the subject of the JWT.
    /// <see href="https://w3id.org/idsa/core/sub"></see></summary>
    let sub = Namespaced_IRI.parse _namespace_name "sub" |> NamespacedName
    /// <summary>
    /// The 'iat' (issued at) claim contains the point in time when the JWT was created.
    /// <see href="https://w3id.org/idsa/core/iat"></see></summary>
    let iat = Namespaced_IRI.parse _namespace_name "iat" |> NamespacedName
    /// <summary>
    /// The 'aud' (audience) claim identifies the recipients that the JWT is intended for.
    /// <see href="https://w3id.org/idsa/core/nbf"></see></summary>
    let nbf = Namespaced_IRI.parse _namespace_name "nbf" |> NamespacedName

    /// <summary>
    /// Separate certificates for IDS identification and transport encryption opens an attack vector for relay attacks. In order to prevent these attacks, a binding of this transport certificates to the connector is required. The inclusion of SHA256 fingerprints of currently valid transport certificates, mainly into the DAT, enables the client to relate the transport layer security with the IDS interactions.
    /// <see href="https://w3id.org/idsa/core/transportCertsSha256"></see></summary>
    let transportCertsSha256 =
        Namespaced_IRI.parse _namespace_name "transportCertsSha256" |> NamespacedName

    /// <summary>
    /// Currently, the scope is limited to 'Connector' but can be used for scoping purposes in the future. Scope is currently fixed to 'https://w3id.org/idsa/core/Connector'.
    /// <see href="https://w3id.org/idsa/core/scope"></see></summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName
    /// <summary>
    /// The 'aud' (audience) claim identifies the recipients that the JWT is intended for.
    /// <see href="https://w3id.org/idsa/core/aud"></see></summary>
    let aud = Namespaced_IRI.parse _namespace_name "aud" |> NamespacedName
    /// <summary>
    /// The 'exp' (expiration time) claim identifies the expiration time on or after which the JWT MUST NOT be accepted for processing.
    /// <see href="https://w3id.org/idsa/core/exp"></see></summary>
    let exp = Namespaced_IRI.parse _namespace_name "exp" |> NamespacedName
    /// <summary>
    /// Class of Licences to be referred to by Resources.
    /// <see href="https://w3id.org/idsa/core/License"></see></summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName
    /// <summary>
    /// Log Message which can be used to transfer logs e.g. to the clearing house.
    /// <see href="https://w3id.org/idsa/core/LogMessage"></see></summary>
    let LogMessage = Namespaced_IRI.parse _namespace_name "LogMessage" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Local Logging' policy class.
    /// <see href="https://w3id.org/idsa/core/LoggingAgreement"></see></summary>
    let LoggingAgreement =
        Namespaced_IRI.parse _namespace_name "LoggingAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Local Logging' policy class.
    /// <see href="https://w3id.org/idsa/core/LoggingOffer"></see></summary>
    let LoggingOffer =
        Namespaced_IRI.parse _namespace_name "LoggingOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Local Logging' policy class.
    /// <see href="https://w3id.org/idsa/core/LoggingRequest"></see></summary>
    let LoggingRequest =
        Namespaced_IRI.parse _namespace_name "LoggingRequest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/LogicalConstraint"></see>
    /// </summary>
    let LogicalConstraint =
        Namespaced_IRI.parse _namespace_name "LogicalConstraint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/and"></see>
    /// </summary>
    let and_ = Namespaced_IRI.parse _namespace_name "and" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/or"></see>
    /// </summary>
    let or_ = Namespaced_IRI.parse _namespace_name "or" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/xone"></see>
    /// </summary>
    let xone = Namespaced_IRI.parse _namespace_name "xone" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Message"></see>
    /// </summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName

    /// <summary>
    /// A token representing a claim that the message sender supports a certain security profile.
    /// <see href="https://w3id.org/idsa/core/securityToken"></see></summary>
    let securityToken =
        Namespaced_IRI.parse _namespace_name "securityToken" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/issuerConnector"></see>
    /// </summary>
    let issuerConnector =
        Namespaced_IRI.parse _namespace_name "issuerConnector" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/issued"></see>
    /// </summary>
    let issued = Namespaced_IRI.parse _namespace_name "issued" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/recipientAgent"></see>
    /// </summary>
    let recipientAgent =
        Namespaced_IRI.parse _namespace_name "recipientAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/senderAgent"></see>
    /// </summary>
    let senderAgent =
        Namespaced_IRI.parse _namespace_name "senderAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/recipientConnector"></see>
    /// </summary>
    let recipientConnector =
        Namespaced_IRI.parse _namespace_name "recipientConnector" |> NamespacedName

    /// <summary>
    /// Version of the Information Model against which the Message should be interpreted.
    /// <see href="https://w3id.org/idsa/core/modelVersion"></see></summary>
    let modelVersion =
        Namespaced_IRI.parse _namespace_name "modelVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/MessageProcessedNotificationMessage"></see>
    /// </summary>
    let MessageProcessedNotificationMessage =
        Namespaced_IRI.parse _namespace_name "MessageProcessedNotificationMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/correlationMessage"></see>
    /// </summary>
    let correlationMessage =
        Namespaced_IRI.parse _namespace_name "correlationMessage" |> NamespacedName

    /// <summary>
    /// Entity that is identifiable within a context by means of a name.
    /// <see href="https://w3id.org/idsa/core/Named"></see></summary>
    let Named = Namespaced_IRI.parse _namespace_name "Named" |> NamespacedName
    /// <summary>
    /// Entity name unique within a specified context.
    /// <see href="https://w3id.org/idsa/core/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Restricted Number of Usages' policy class.
    /// <see href="https://w3id.org/idsa/core/NotMoreThanNAgreement"></see></summary>
    let NotMoreThanNAgreement =
        Namespaced_IRI.parse _namespace_name "NotMoreThanNAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Restricted Number of Usages' policy class.
    /// <see href="https://w3id.org/idsa/core/NotMoreThanNOffer"></see></summary>
    let NotMoreThanNOffer =
        Namespaced_IRI.parse _namespace_name "NotMoreThanNOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Restricted Number of Usages' policy class.
    /// <see href="https://w3id.org/idsa/core/NotMoreThanNRequest"></see></summary>
    let NotMoreThanNRequest =
        Namespaced_IRI.parse _namespace_name "NotMoreThanNRequest" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Remote Notifications' policy class.
    /// <see href="https://w3id.org/idsa/core/NotificationAgreement"></see></summary>
    let NotificationAgreement =
        Namespaced_IRI.parse _namespace_name "NotificationAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Remote Notifications' policy class.
    /// <see href="https://w3id.org/idsa/core/NotificationOffer"></see></summary>
    let NotificationOffer =
        Namespaced_IRI.parse _namespace_name "NotificationOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Remote Notifications' policy class.
    /// <see href="https://w3id.org/idsa/core/NotificationRequest"></see></summary>
    let NotificationRequest =
        Namespaced_IRI.parse _namespace_name "NotificationRequest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Operation"></see>
    /// </summary>
    let Operation = Namespaced_IRI.parse _namespace_name "Operation" |> NamespacedName

    /// <summary>
    /// Message indicating that the result of a former InvokeOperation message is available. May transfer the result data in its associated payload section.
    /// <see href="https://w3id.org/idsa/core/OperationResultMessage"></see></summary>
    let OperationResultMessage =
        Namespaced_IRI.parse _namespace_name "OperationResultMessage" |> NamespacedName

    /// <summary>
    /// Apps for orchestrating System Adapter Apps or Smart Data Apps, inside a Connector.
    /// <see href="https://w3id.org/idsa/core/OrchestrationApp"></see></summary>
    let OrchestrationApp =
        Namespaced_IRI.parse _namespace_name "OrchestrationApp" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ParIS"></see>
    /// </summary>
    let ParIS = Namespaced_IRI.parse _namespace_name "ParIS" |> NamespacedName

    /// <summary>
    /// List of participants a ParIS may expose.
    /// <see href="https://w3id.org/idsa/core/participantCatalog"></see></summary>
    let participantCatalog =
        Namespaced_IRI.parse _namespace_name "participantCatalog" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Participant"></see>
    /// </summary>
    let Participant =
        Namespaced_IRI.parse _namespace_name "Participant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/memberPerson"></see>
    /// </summary>
    let memberPerson =
        Namespaced_IRI.parse _namespace_name "memberPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/memberParticipant"></see>
    /// </summary>
    let memberParticipant =
        Namespaced_IRI.parse _namespace_name "memberParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/corporateEmailAddress"></see>
    /// </summary>
    let corporateEmailAddress =
        Namespaced_IRI.parse _namespace_name "corporateEmailAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ParticipantCatalog"></see>
    /// </summary>
    let ParticipantCatalog =
        Namespaced_IRI.parse _namespace_name "ParticipantCatalog" |> NamespacedName

    /// <summary>
    /// A Participant, that is part of a participant catalog.
    /// <see href="https://w3id.org/idsa/core/member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// Whenever a Participant has been successfully certified by the Certification Body, the Identity Provider can use this message to notify Infrastructure Components.
    /// <see href="https://w3id.org/idsa/core/ParticipantCertificateGrantedMessage"></see></summary>
    let ParticipantCertificateGrantedMessage =
        Namespaced_IRI.parse _namespace_name "ParticipantCertificateGrantedMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ParticipantNotificationMessage"></see>
    /// </summary>
    let ParticipantNotificationMessage =
        Namespaced_IRI.parse _namespace_name "ParticipantNotificationMessage" |> NamespacedName

    /// <summary>
    /// Indicates that a (previously certified) Participant is no more certified. This could happen, for instance, if the Certification Body revokes a granted certificate or if the certificate just expires.
    /// <see href="https://w3id.org/idsa/core/ParticipantCertificateRevokedMessage"></see></summary>
    let ParticipantCertificateRevokedMessage =
        Namespaced_IRI.parse _namespace_name "ParticipantCertificateRevokedMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedParticipant"></see>
    /// </summary>
    let affectedParticipant =
        Namespaced_IRI.parse _namespace_name "affectedParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ParticipantRequestMessage"></see>
    /// </summary>
    let ParticipantRequestMessage =
        Namespaced_IRI.parse _namespace_name "ParticipantRequestMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/requestedParticipant"></see>
    /// </summary>
    let requestedParticipant =
        Namespaced_IRI.parse _namespace_name "requestedParticipant" |> NamespacedName

    /// <summary>
    /// Message that follows up a ParticipantRequestMessage and contains the Participant's information in the payload section.
    /// <see href="https://w3id.org/idsa/core/ParticipantResponseMessage"></see></summary>
    let ParticipantResponseMessage =
        Namespaced_IRI.parse _namespace_name "ParticipantResponseMessage" |> NamespacedName

    /// <summary>
    /// Event notifying the recipient(s) that a participant will be unavailable. The same participant may be available again in the future.
    /// <see href="https://w3id.org/idsa/core/ParticipantUnavailableMessage"></see></summary>
    let ParticipantUnavailableMessage =
        Namespaced_IRI.parse _namespace_name "ParticipantUnavailableMessage" |> NamespacedName

    /// <summary>
    /// Event notifying the recipient(s) about the availability and current description of a participant. The payload of the message must contain the participant's self-description.
    /// <see href="https://w3id.org/idsa/core/ParticipantUpdateMessage"></see></summary>
    let ParticipantUpdateMessage =
        Namespaced_IRI.parse _namespace_name "ParticipantUpdateMessage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Permission"></see>
    /// </summary>
    let Permission = Namespaced_IRI.parse _namespace_name "Permission" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/preDuty"></see>
    /// </summary>
    let preDuty = Namespaced_IRI.parse _namespace_name "preDuty" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/postDuty"></see>
    /// </summary>
    let postDuty = Namespaced_IRI.parse _namespace_name "postDuty" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/emailAddress"></see>
    /// </summary>
    let emailAddress =
        Namespaced_IRI.parse _namespace_name "emailAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/phoneNumber"></see>
    /// </summary>
    let phoneNumber =
        Namespaced_IRI.parse _namespace_name "phoneNumber" |> NamespacedName

    /// <summary>
    /// The class of Prohibitions as defined in the ODRL ontology.
    /// <see href="https://w3id.org/idsa/core/Prohibition"></see></summary>
    let Prohibition =
        Namespaced_IRI.parse _namespace_name "Prohibition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Proxy"></see>
    /// </summary>
    let Proxy = Namespaced_IRI.parse _namespace_name "Proxy" |> NamespacedName
    /// <summary>
    /// URLs that should be excluded from proxying.GNU emcs documentation contains a good explanation for the usage of noProxy.
    /// <see href="https://w3id.org/idsa/core/noProxy"></see></summary>
    let noProxy = Namespaced_IRI.parse _namespace_name "noProxy" |> NamespacedName
    /// <summary>
    /// URI of the proxy server.
    /// <see href="https://w3id.org/idsa/core/proxyURI"></see></summary>
    let proxyURI = Namespaced_IRI.parse _namespace_name "proxyURI" |> NamespacedName
    /// <summary>
    /// Public key as used in asymmetric cryptography.
    /// <see href="https://w3id.org/idsa/core/PublicKey"></see></summary>
    let PublicKey = Namespaced_IRI.parse _namespace_name "PublicKey" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Purpose-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/PurposeAgreement"></see></summary>
    let PurposeAgreement =
        Namespaced_IRI.parse _namespace_name "PurposeAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Purpose-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/PurposeOffer"></see></summary>
    let PurposeOffer =
        Namespaced_IRI.parse _namespace_name "PurposeOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Purpose-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/PurposeRequest"></see></summary>
    let PurposeRequest =
        Namespaced_IRI.parse _namespace_name "PurposeRequest" |> NamespacedName

    /// <summary>
    /// Query message intended to be consumed by a component.
    /// <see href="https://w3id.org/idsa/core/QueryMessage"></see></summary>
    let QueryMessage =
        Namespaced_IRI.parse _namespace_name "QueryMessage" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Data Rental' policy class.
    /// <see href="https://w3id.org/idsa/core/RentalAgreement"></see></summary>
    let RentalAgreement =
        Namespaced_IRI.parse _namespace_name "RentalAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Data Rental' policy class.
    /// <see href="https://w3id.org/idsa/core/RentalOffer"></see></summary>
    let RentalOffer =
        Namespaced_IRI.parse _namespace_name "RentalOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Data Rental' policy class.
    /// <see href="https://w3id.org/idsa/core/RentalRequest"></see></summary>
    let RentalRequest =
        Namespaced_IRI.parse _namespace_name "RentalRequest" |> NamespacedName

    /// <summary>
    /// Reference to an instance of given representation, i.e. inline value or file placeholder.
    /// <see href="https://w3id.org/idsa/core/instance"></see></summary>
    let instance = Namespaced_IRI.parse _namespace_name "instance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/RequestInProcessMessage"></see>
    /// </summary>
    let RequestInProcessMessage =
        Namespaced_IRI.parse _namespace_name "RequestInProcessMessage" |> NamespacedName

    /// <summary>
    /// Reference to a Resource (physically or logically) included, definition of part-whole hierarchies.
    /// <see href="https://w3id.org/idsa/core/resourcePart"></see></summary>
    let resourcePart =
        Namespaced_IRI.parse _namespace_name "resourcePart" |> NamespacedName

    /// <summary>
    /// Reference to the Endpoints serving the resource's content or let you exchange messages with an IDS Connector.
    /// <see href="https://w3id.org/idsa/core/resourceEndpoint"></see></summary>
    let resourceEndpoint =
        Namespaced_IRI.parse _namespace_name "resourceEndpoint" |> NamespacedName

    /// <summary>
    /// Reference to a Contract Offer defining the authorized use of the Resource.
    /// <see href="https://w3id.org/idsa/core/contractOffer"></see></summary>
    let contractOffer =
        Namespaced_IRI.parse _namespace_name "contractOffer" |> NamespacedName

    /// <summary>
    /// Sample Resource instance.
    /// <see href="https://w3id.org/idsa/core/sample"></see></summary>
    let sample = Namespaced_IRI.parse _namespace_name "sample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ResourceCatalog"></see>
    /// </summary>
    let ResourceCatalog =
        Namespaced_IRI.parse _namespace_name "ResourceCatalog" |> NamespacedName

    /// <summary>
    /// A Resource that is part of a resource catalog, indicating an offering (of, e.g., data).
    /// <see href="https://w3id.org/idsa/core/offeredResource"></see></summary>
    let offeredResource =
        Namespaced_IRI.parse _namespace_name "offeredResource" |> NamespacedName

    /// <summary>
    /// A Resource that is part of a resource catalog, indicating a request (of, e.g., data, software,...).
    /// <see href="https://w3id.org/idsa/core/requestedResource"></see></summary>
    let requestedResource =
        Namespaced_IRI.parse _namespace_name "requestedResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedResource"></see>
    /// </summary>
    let affectedResource =
        Namespaced_IRI.parse _namespace_name "affectedResource" |> NamespacedName

    /// <summary>
    /// Message indicating that a specific resource is unavailable. The same resource may be available again in the future.
    /// <see href="https://w3id.org/idsa/core/ResourceUnavailableMessage"></see></summary>
    let ResourceUnavailableMessage =
        Namespaced_IRI.parse _namespace_name "ResourceUnavailableMessage" |> NamespacedName

    /// <summary>
    /// Message indicating the availability and current description of a specific resource. The resource must be present in the payload of this message.
    /// <see href="https://w3id.org/idsa/core/ResourceUpdateMessage"></see></summary>
    let ResourceUpdateMessage =
        Namespaced_IRI.parse _namespace_name "ResourceUpdateMessage" |> NamespacedName

    /// <summary>
    /// Result messages are intended to annotate the results of a query command.
    /// <see href="https://w3id.org/idsa/core/ResultMessage"></see></summary>
    let ResultMessage =
        Namespaced_IRI.parse _namespace_name "ResultMessage" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Role-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/RolebasedAgreement"></see></summary>
    let RolebasedAgreement =
        Namespaced_IRI.parse _namespace_name "RolebasedAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Role-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/RolebasedOffer"></see></summary>
    let RolebasedOffer =
        Namespaced_IRI.parse _namespace_name "RolebasedOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Role-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/RolebasedRequest"></see></summary>
    let RolebasedRequest =
        Namespaced_IRI.parse _namespace_name "RolebasedRequest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/constraint"></see>
    /// </summary>
    let constraint_ =
        Namespaced_IRI.parse _namespace_name "constraint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/assigner"></see>
    /// </summary>
    let assigner = Namespaced_IRI.parse _namespace_name "assigner" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/assignee"></see>
    /// </summary>
    let assignee = Namespaced_IRI.parse _namespace_name "assignee" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/action"></see>
    /// </summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the Perpetual Data Sale policy class.
    /// <see href="https://w3id.org/idsa/core/SalesAgreement"></see></summary>
    let SalesAgreement =
        Namespaced_IRI.parse _namespace_name "SalesAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Perpetual Data Sale' policy class.
    /// <see href="https://w3id.org/idsa/core/SalesOffer"></see></summary>
    let SalesOffer = Namespaced_IRI.parse _namespace_name "SalesOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Perpetual Data Sale' policy class.
    /// <see href="https://w3id.org/idsa/core/SalesRequest"></see></summary>
    let SalesRequest =
        Namespaced_IRI.parse _namespace_name "SalesRequest" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Security Level Restricted Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/SecurityAgreement"></see></summary>
    let SecurityAgreement =
        Namespaced_IRI.parse _namespace_name "SecurityAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Security Level Restricted Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/SecurityOffer"></see></summary>
    let SecurityOffer =
        Namespaced_IRI.parse _namespace_name "SecurityOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Security Level Restricted Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/SecurityRequest"></see></summary>
    let SecurityRequest =
        Namespaced_IRI.parse _namespace_name "SecurityRequest" |> NamespacedName

    /// <summary>
    /// An office or other premise at which the organization is located
    /// <see href="https://w3id.org/idsa/core/Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName

    /// <summary>
    /// Smart DataApps are executing any kind of necessary data processing or transformation.
    /// <see href="https://w3id.org/idsa/core/SmartDataApp"></see></summary>
    let SmartDataApp =
        Namespaced_IRI.parse _namespace_name "SmartDataApp" |> NamespacedName

    /// <summary>
    /// Resource (at least partially) comprising Software.
    /// <see href="https://w3id.org/idsa/core/SoftwareResource"></see></summary>
    let SoftwareResource =
        Namespaced_IRI.parse _namespace_name "SoftwareResource" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Location Restricted Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/SpatialAgreement"></see></summary>
    let SpatialAgreement =
        Namespaced_IRI.parse _namespace_name "SpatialAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Location Restricted Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/SpatialOffer"></see></summary>
    let SpatialOffer =
        Namespaced_IRI.parse _namespace_name "SpatialOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Location Restricted Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/SpatialRequest"></see></summary>
    let SpatialRequest =
        Namespaced_IRI.parse _namespace_name "SpatialRequest" |> NamespacedName

    /// <summary>
    /// The ContractAgreement class representing the 'Data Swap' policy class.
    /// <see href="https://w3id.org/idsa/core/SwapAgreement"></see></summary>
    let SwapAgreement =
        Namespaced_IRI.parse _namespace_name "SwapAgreement" |> NamespacedName

    /// <summary>
    /// The ContractOffer class representing the 'Data Swap' policy class.
    /// <see href="https://w3id.org/idsa/core/SwapOffer"></see></summary>
    let SwapOffer = Namespaced_IRI.parse _namespace_name "SwapOffer" |> NamespacedName

    /// <summary>
    /// The ContractRequest class representing the 'Data Swap' policy class.
    /// <see href="https://w3id.org/idsa/core/SwapRequest"></see></summary>
    let SwapRequest =
        Namespaced_IRI.parse _namespace_name "SwapRequest" |> NamespacedName

    /// <summary>
    /// Data Apps that integrate sources and sinks of digital content maintained internally on Participant's premises with a Connector.
    /// <see href="https://w3id.org/idsa/core/SystemAdapter"></see></summary>
    let SystemAdapter =
        Namespaced_IRI.parse _namespace_name "SystemAdapter" |> NamespacedName

    /// <summary>
    /// Representation of a textual content.
    /// <see href="https://w3id.org/idsa/core/TextRepresentation"></see></summary>
    let TextRepresentation =
        Namespaced_IRI.parse _namespace_name "TextRepresentation" |> NamespacedName

    /// <summary>
    /// Resource (at least partially) comprising textual content.
    /// <see href="https://w3id.org/idsa/core/TextResource"></see></summary>
    let TextResource =
        Namespaced_IRI.parse _namespace_name "TextResource" |> NamespacedName

    /// <summary>
    /// An authentication token value like JSON Web Token.
    /// <see href="https://w3id.org/idsa/core/tokenValue"></see></summary>
    let tokenValue = Namespaced_IRI.parse _namespace_name "tokenValue" |> NamespacedName

    /// <summary>
    /// Hardened implementation of the Connector specification providing enhanced security capabilities.
    /// <see href="https://w3id.org/idsa/core/TrustedConnector"></see></summary>
    let TrustedConnector =
        Namespaced_IRI.parse _namespace_name "TrustedConnector" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/UsageControlObject"></see>
    /// </summary>
    let UsageControlObject =
        Namespaced_IRI.parse _namespace_name "UsageControlObject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/data"></see>
    /// </summary>
    let data = Namespaced_IRI.parse _namespace_name "data" |> NamespacedName
    /// <summary>
    /// The target contract defining the usage of the data object.
    /// <see href="https://w3id.org/idsa/core/contract"></see></summary>
    let contract = Namespaced_IRI.parse _namespace_name "contract" |> NamespacedName
    /// <summary>
    /// The date of the creation of the Digital Content. In contrast to the ids:temporalCoverage, creation dates of ids:Representation, ids:Artifacts or any other form of meta-data, this property describes the creation date of referenced Digital Content itself.
    /// <see href="https://w3id.org/idsa/core/created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName
    /// <summary>
    /// The list of combined current states of the data object.
    /// <see href="https://w3id.org/idsa/core/hasState"></see></summary>
    let hasState = Namespaced_IRI.parse _namespace_name "hasState" |> NamespacedName

    /// <summary>
    /// Video representation
    /// <see href="https://w3id.org/idsa/core/VideoRepresentation"></see></summary>
    let VideoRepresentation =
        Namespaced_IRI.parse _namespace_name "VideoRepresentation" |> NamespacedName

    /// <summary>
    /// Resource (at least partially) comprising video content.
    /// <see href="https://w3id.org/idsa/core/VideoResource"></see></summary>
    let VideoResource =
        Namespaced_IRI.parse _namespace_name "VideoResource" |> NamespacedName

    /// <summary>
    /// Access URL of an endpoint.
    /// <see href="https://w3id.org/idsa/core/accessURL"></see></summary>
    let accessURL = Namespaced_IRI.parse _namespace_name "accessURL" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/accessed"></see>
    /// </summary>
    let accessed = Namespaced_IRI.parse _namespace_name "accessed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/accrualPeriodicity"></see>
    /// </summary>
    let accrualPeriodicity =
        Namespaced_IRI.parse _namespace_name "accrualPeriodicity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedDataApp"></see>
    /// </summary>
    let affectedDataApp =
        Namespaced_IRI.parse _namespace_name "affectedDataApp" |> NamespacedName

    /// <summary>
    /// text documentation of the data app
    /// <see href="https://w3id.org/idsa/core/appDocumentation"></see></summary>
    let appDocumentation =
        Namespaced_IRI.parse _namespace_name "appDocumentation" |> NamespacedName

    /// <summary>
    /// Mediatype, such as IANA types, of the data an endpoint expects or returns .
    /// <see href="https://w3id.org/idsa/core/appEndpointMediaType"></see></summary>
    let appEndpointMediaType =
        Namespaced_IRI.parse _namespace_name "appEndpointMediaType" |> NamespacedName

    /// <summary>
    /// Port used to access the endpoint.
    /// <see href="https://w3id.org/idsa/core/appEndpointPort"></see></summary>
    let appEndpointPort =
        Namespaced_IRI.parse _namespace_name "appEndpointPort" |> NamespacedName

    /// <summary>
    /// Constraint that refines a (composite) Digital Content.
    /// Conditions which specify whether an arbitrary ids:Asset is a member of this AssetCollection.
    /// <see href="https://w3id.org/idsa/core/assetRefinement"></see></summary>
    let assetRefinement =
        Namespaced_IRI.parse _namespace_name "assetRefinement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/assetSource"></see>
    /// </summary>
    let assetSource =
        Namespaced_IRI.parse _namespace_name "assetSource" |> NamespacedName

    /// <summary>
    /// Information of the authentication service used by the Connector.
    /// <see href="https://w3id.org/idsa/core/authInfo"></see></summary>
    let authInfo = Namespaced_IRI.parse _namespace_name "authInfo" |> NamespacedName

    /// <summary>
    /// Username / ID used for authentication.
    /// <see href="https://w3id.org/idsa/core/authPassword"></see></summary>
    let authPassword =
        Namespaced_IRI.parse _namespace_name "authPassword" |> NamespacedName

    /// <summary>
    /// The standard used by the authentication service that is provided by the Connector.
    /// <see href="https://w3id.org/idsa/core/authStandard"></see></summary>
    let authStandard =
        Namespaced_IRI.parse _namespace_name "authStandard" |> NamespacedName

    /// <summary>
    /// Username / ID used for authentication.
    /// <see href="https://w3id.org/idsa/core/authUsername"></see></summary>
    let authUsername =
        Namespaced_IRI.parse _namespace_name "authUsername" |> NamespacedName

    /// <summary>
    /// An authorization token like JSON Web Token.
    /// <see href="https://w3id.org/idsa/core/authorizationToken"></see></summary>
    let authorizationToken =
        Namespaced_IRI.parse _namespace_name "authorizationToken" |> NamespacedName

    /// <summary>
    /// Size of the Artifact in bytes.
    /// <see href="https://w3id.org/idsa/core/byteSize"></see></summary>
    let byteSize = Namespaced_IRI.parse _namespace_name "byteSize" |> NamespacedName
    /// <summary>
    /// Checksum of the artifact
    /// <see href="https://w3id.org/idsa/core/checkSum"></see></summary>
    let checkSum = Namespaced_IRI.parse _namespace_name "checkSum" |> NamespacedName

    /// <summary>
    /// Certification issued for the given Infrastructure Component.
    /// <see href="https://w3id.org/idsa/core/componentCertification"></see></summary>
    let componentCertification =
        Namespaced_IRI.parse _namespace_name "componentCertification" |> NamespacedName

    /// <summary>
    /// References to Connector which is deployed / maintained in the Configuration Model
    /// <see href="https://w3id.org/idsa/core/connectorDescription"></see></summary>
    let connectorDescription =
        Namespaced_IRI.parse _namespace_name "connectorDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/consumer"></see>
    /// </summary>
    let consumer = Namespaced_IRI.parse _namespace_name "consumer" |> NamespacedName

    /// <summary>
    /// IRI containing document, which defines the standard for the given Digital Content. The content is assumed to conform to that Standard.
    /// <see href="https://w3id.org/idsa/core/contentStandard"></see></summary>
    let contentStandard =
        Namespaced_IRI.parse _namespace_name "contentStandard" |> NamespacedName

    /// <summary>
    /// Detailed type, genre or interpretation of the Digital Content.
    /// <see href="https://w3id.org/idsa/core/contentType"></see></summary>
    let contentType =
        Namespaced_IRI.parse _namespace_name "contentType" |> NamespacedName

    /// <summary>
    /// Version of the content in the payload. Use digits and semantic versioning pattern like MAJOR.MINOR.PATCH.
    /// <see href="https://w3id.org/idsa/core/contentVersion"></see></summary>
    let contentVersion =
        Namespaced_IRI.parse _namespace_name "contentVersion" |> NamespacedName

    /// <summary>
    /// Any type of resource related to the Contract.
    /// <see href="https://w3id.org/idsa/core/contractAnnex"></see></summary>
    let contractAnnex =
        Namespaced_IRI.parse _namespace_name "contractAnnex" |> NamespacedName

    /// <summary>
    /// Absolute datetime of singing the Contract.
    /// <see href="https://w3id.org/idsa/core/contractDate"></see></summary>
    let contractDate =
        Namespaced_IRI.parse _namespace_name "contractDate" |> NamespacedName

    /// <summary>
    /// Equivalent human-readable encoding of this machine-interpretable Contract.
    /// <see href="https://w3id.org/idsa/core/contractDocument"></see></summary>
    let contractDocument =
        Namespaced_IRI.parse _namespace_name "contractDocument" |> NamespacedName

    /// <summary>
    /// Absolute datetime the Contract is requested, offered or expected to end. If omitted, the contract has to be explicitly terminated by any of the parties.
    /// <see href="https://w3id.org/idsa/core/contractEnd"></see></summary>
    let contractEnd =
        Namespaced_IRI.parse _namespace_name "contractEnd" |> NamespacedName

    /// <summary>
    /// Human-readable text describing the reason for contract rejection.
    /// <see href="https://w3id.org/idsa/core/contractRejectionReason"></see></summary>
    let contractRejectionReason =
        Namespaced_IRI.parse _namespace_name "contractRejectionReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/corporateHomepage"></see>
    /// </summary>
    let corporateHomepage =
        Namespaced_IRI.parse _namespace_name "corporateHomepage" |> NamespacedName

    /// <summary>
    /// Date (as xsd:dateTimeStamp) when the artifact was created, i.e. persisted.
    /// <see href="https://w3id.org/idsa/core/creationDate"></see></summary>
    let creationDate =
        Namespaced_IRI.parse _namespace_name "creationDate" |> NamespacedName

    /// <summary>
    /// URL reference to a custom license regulating the general usage of the Resource.
    /// <see href="https://w3id.org/idsa/core/customLicense"></see></summary>
    let customLicense =
        Namespaced_IRI.parse _namespace_name "customLicense" |> NamespacedName

    /// <summary>
    /// Information about the concrete data app implementation
    /// <see href="https://w3id.org/idsa/core/dataAppInformation"></see></summary>
    let dataAppInformation =
        Namespaced_IRI.parse _namespace_name "dataAppInformation" |> NamespacedName

    /// <summary>
    /// Indicates the data type of the Representation.
    /// <see href="https://w3id.org/idsa/core/dataType"></see></summary>
    let dataType = Namespaced_IRI.parse _namespace_name "dataType" |> NamespacedName

    /// <summary>
    /// Indicates the data type schema of the Representation.
    /// <see href="https://w3id.org/idsa/core/dataTypeSchema"></see></summary>
    let dataTypeSchema =
        Namespaced_IRI.parse _namespace_name "dataTypeSchema" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/dateTime"></see>
    /// </summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName

    /// <summary>
    /// Default representation of the content.
    /// <see href="https://w3id.org/idsa/core/defaultRepresentation"></see></summary>
    let defaultRepresentation =
        Namespaced_IRI.parse _namespace_name "defaultRepresentation" |> NamespacedName

    /// <summary>
    /// Duration of the media resource in seconds.
    /// <see href="https://w3id.org/idsa/core/duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// End of an Interval.
    /// <see href="https://w3id.org/idsa/core/end"></see></summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName

    /// <summary>
    /// Content instance mediated via this individual endpoint (1:1 mapping).
    /// <see href="https://w3id.org/idsa/core/endpointArtifact"></see></summary>
    let endpointArtifact =
        Namespaced_IRI.parse _namespace_name "endpointArtifact" |> NamespacedName

    /// <summary>
    /// Evaluation Facility that performed and issued given Certification
    /// <see href="https://w3id.org/idsa/core/evaluationFacility"></see></summary>
    let evaluationFacility =
        Namespaced_IRI.parse _namespace_name "evaluationFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/familyName"></see>
    /// </summary>
    let familyName = Namespaced_IRI.parse _namespace_name "familyName" |> NamespacedName
    /// <summary>
    /// Name of the Artifcat file.
    /// <see href="https://w3id.org/idsa/core/fileName"></see></summary>
    let fileName = Namespaced_IRI.parse _namespace_name "fileName" |> NamespacedName

    /// <summary>
    /// Suffix of a file name, typically separated by a period, indicating the nature and intended processing of the file.
    /// <see href="https://w3id.org/idsa/core/filenameExtension"></see></summary>
    let filenameExtension =
        Namespaced_IRI.parse _namespace_name "filenameExtension" |> NamespacedName

    /// <summary>
    /// Video frame rate, as frames/second.
    /// <see href="https://w3id.org/idsa/core/frameRate"></see></summary>
    let frameRate = Namespaced_IRI.parse _namespace_name "frameRate" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/givenName"></see>
    /// </summary>
    let givenName = Namespaced_IRI.parse _namespace_name "givenName" |> NamespacedName
    /// <summary>
    /// Height of the visible frame.
    /// <see href="https://w3id.org/idsa/core/height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/homepage"></see>
    /// </summary>
    let homepage = Namespaced_IRI.parse _namespace_name "homepage" |> NamespacedName

    /// <summary>
    /// HTTP authentication URI.
    /// <see href="https://w3id.org/idsa/core/httpAuthURI"></see></summary>
    let httpAuthURI =
        Namespaced_IRI.parse _namespace_name "httpAuthURI" |> NamespacedName

    /// <summary>
    /// Relative path used for inbound communication via this endpoint, i.e. input messages and faults only.
    /// <see href="https://w3id.org/idsa/core/inboundPath"></see></summary>
    let inboundPath =
        Namespaced_IRI.parse _namespace_name "inboundPath" |> NamespacedName

    /// <summary>
    /// The subject transitively asserts the object Action.
    /// <see href="https://w3id.org/idsa/core/includedIn"></see></summary>
    let includedIn = Namespaced_IRI.parse _namespace_name "includedIn" |> NamespacedName
    /// <summary>
    /// URI of the key store server.
    /// <see href="https://w3id.org/idsa/core/keyStore"></see></summary>
    let keyStore = Namespaced_IRI.parse _namespace_name "keyStore" |> NamespacedName
    /// <summary>
    /// Type of the public key.
    /// <see href="https://w3id.org/idsa/core/keyType"></see></summary>
    let keyType = Namespaced_IRI.parse _namespace_name "keyType" |> NamespacedName
    /// <summary>
    /// Binary representation of the key.
    /// <see href="https://w3id.org/idsa/core/keyValue"></see></summary>
    let keyValue = Namespaced_IRI.parse _namespace_name "keyValue" |> NamespacedName

    /// <summary>
    /// Last date (as xsd:dateTimeStamp) the given Certification is considered valid.
    /// <see href="https://w3id.org/idsa/core/lastValidDate"></see></summary>
    let lastValidDate =
        Namespaced_IRI.parse _namespace_name "lastValidDate" |> NamespacedName

    /// <summary>
    /// Media Type of the Representation.
    /// <see href="https://w3id.org/idsa/core/mediaType"></see></summary>
    let mediaType = Namespaced_IRI.parse _namespace_name "mediaType" |> NamespacedName

    /// <summary>
    /// End of the participant's IDS membership.
    /// <see href="https://w3id.org/idsa/core/membershipEnd"></see></summary>
    let membershipEnd =
        Namespaced_IRI.parse _namespace_name "membershipEnd" |> NamespacedName

    /// <summary>
    /// The date/time this Digital Content has been changed the last time. Only one 'modified' attribute is usually needed.
    /// <see href="https://w3id.org/idsa/core/modified"></see></summary>
    let modified = Namespaced_IRI.parse _namespace_name "modified" |> NamespacedName

    /// <summary>
    /// Relative path used for outbound communication via this endpoint, i.e. output messages and faults only.
    /// <see href="https://w3id.org/idsa/core/outboundPath"></see></summary>
    let outboundPath =
        Namespaced_IRI.parse _namespace_name "outboundPath" |> NamespacedName

    /// <summary>
    /// Certification issued for the given Participant.
    /// <see href="https://w3id.org/idsa/core/participantCertification"></see></summary>
    let participantCertification =
        Namespaced_IRI.parse _namespace_name "participantCertification" |> NamespacedName

    /// <summary>
    /// Conditions which needs to be satisfied that a single Participant can be seen as a member of the subject Participant. For instance, all Participants with their headquarter in Europe might be a potential consumer of GDPR-releated data.
    /// <see href="https://w3id.org/idsa/core/participantRefinement"></see></summary>
    let participantRefinement =
        Namespaced_IRI.parse _namespace_name "participantRefinement" |> NamespacedName

    /// <summary>
    /// Relative path, topic or queue at which the content is published by the related host.
    /// <see href="https://w3id.org/idsa/core/path"></see></summary>
    let path = Namespaced_IRI.parse _namespace_name "path" |> NamespacedName

    /// <summary>
    /// The location where the Connector is physically deployed.
    /// <see href="https://w3id.org/idsa/core/physicalLocation"></see></summary>
    let physicalLocation =
        Namespaced_IRI.parse _namespace_name "physicalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/pipEndpoint"></see>
    /// </summary>
    let pipEndpoint =
        Namespaced_IRI.parse _namespace_name "pipEndpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/primarySite"></see>
    /// </summary>
    let primarySite =
        Namespaced_IRI.parse _namespace_name "primarySite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/provider"></see>
    /// </summary>
    let provider = Namespaced_IRI.parse _namespace_name "provider" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/proxyAuthentication"></see>
    /// </summary>
    let proxyAuthentication =
        Namespaced_IRI.parse _namespace_name "proxyAuthentication" |> NamespacedName

    /// <summary>
    /// Public Key that has been created for the Component.
    /// <see href="https://w3id.org/idsa/core/publicKey"></see></summary>
    let publicKey = Namespaced_IRI.parse _namespace_name "publicKey" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/publisher"></see>
    /// </summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    /// This property specifies the language of the query.
    /// <see href="https://w3id.org/idsa/core/queryLanguage"></see></summary>
    let queryLanguage =
        Namespaced_IRI.parse _namespace_name "queryLanguage" |> NamespacedName

    /// <summary>
    /// Refers to the scope property of a query message, see ids:QueryScope.
    /// <see href="https://w3id.org/idsa/core/queryScope"></see></summary>
    let queryScope = Namespaced_IRI.parse _namespace_name "queryScope" |> NamespacedName

    /// <summary>
    /// Refers to the target property of a query message, see ids:QueryTarget.
    /// <see href="https://w3id.org/idsa/core/recipientScope"></see></summary>
    let recipientScope =
        Namespaced_IRI.parse _namespace_name "recipientScope" |> NamespacedName

    /// <summary>
    /// Specifies the reason of the rejection.
    /// <see href="https://w3id.org/idsa/core/rejectionReason"></see></summary>
    let rejectionReason =
        Namespaced_IRI.parse _namespace_name "rejectionReason" |> NamespacedName

    /// <summary>
    /// Standards document defining the given Representation (in contrast to general Resource content). The Representation is assumed to conform to that Standard.
    /// <see href="https://w3id.org/idsa/core/representationStandard"></see></summary>
    let representationStandard =
        Namespaced_IRI.parse _namespace_name "representationStandard" |> NamespacedName

    /// <summary>
    /// The element whose metadata is requested.
    /// <see href="https://w3id.org/idsa/core/requestedElement"></see></summary>
    let requestedElement =
        Namespaced_IRI.parse _namespace_name "requestedElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/requester"></see>
    /// </summary>
    let requester = Namespaced_IRI.parse _namespace_name "requester" |> NamespacedName

    /// <summary>
    /// Plain Text containing the reason for revoking an existing certificate of either a connector or participant.
    /// <see href="https://w3id.org/idsa/core/revocationReason"></see></summary>
    let revocationReason =
        Namespaced_IRI.parse _namespace_name "revocationReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/rightOperand"></see>
    /// </summary>
    let rightOperand =
        Namespaced_IRI.parse _namespace_name "rightOperand" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/rightOperandReference"></see>
    /// </summary>
    let rightOperandReference =
        Namespaced_IRI.parse _namespace_name "rightOperandReference" |> NamespacedName

    /// <summary>
    /// Configuration details (e.g. contents of a config file) used to configure the route. Should be Base64 encoded.
    /// <see href="https://w3id.org/idsa/core/routeConfiguration"></see></summary>
    let routeConfiguration =
        Namespaced_IRI.parse _namespace_name "routeConfiguration" |> NamespacedName

    /// <summary>
    /// Route description.
    /// <see href="https://w3id.org/idsa/core/routeDescription"></see></summary>
    let routeDescription =
        Namespaced_IRI.parse _namespace_name "routeDescription" |> NamespacedName

    /// <summary>
    /// Audio sampling rate.
    /// <see href="https://w3id.org/idsa/core/samplingRate"></see></summary>
    let samplingRate =
        Namespaced_IRI.parse _namespace_name "samplingRate" |> NamespacedName

    /// <summary>
    /// Reference to SHACL shape graph, which describes domain-specific knowledge.
    /// <see href="https://w3id.org/idsa/core/shapesGraph"></see></summary>
    let shapesGraph =
        Namespaced_IRI.parse _namespace_name "shapesGraph" |> NamespacedName

    /// <summary>
    /// Indicates an address for the site.
    /// <see href="https://w3id.org/idsa/core/siteAddress"></see></summary>
    let siteAddress =
        Namespaced_IRI.parse _namespace_name "siteAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/sovereign"></see>
    /// </summary>
    let sovereign = Namespaced_IRI.parse _namespace_name "sovereign" |> NamespacedName

    /// <summary>
    ///
    ///     Reference to a well-known License regulating the general usage of the Resource.
    ///     Check wikidata license documentation for an extensive list of licenses.
    ///     License IRI should refer to the direct of link for a given standard license,
    ///     e.g., MIT license (https://www.wikidata.org/wiki/Q334661). The label of the resolved wikidata license IRI can be used to
    ///     present the license in human-readable form.
    ///
    /// <see href="https://w3id.org/idsa/core/standardLicense"></see></summary>
    let standardLicense =
        Namespaced_IRI.parse _namespace_name "standardLicense" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/target"></see>
    /// </summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/temporalResolution"></see>
    /// </summary>
    let temporalResolution =
        Namespaced_IRI.parse _namespace_name "temporalResolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/transferContract"></see>
    /// </summary>
    let transferContract =
        Namespaced_IRI.parse _namespace_name "transferContract" |> NamespacedName

    /// <summary>
    /// URI of the trust store server.
    /// <see href="https://w3id.org/idsa/core/trustStore"></see></summary>
    let trustStore = Namespaced_IRI.parse _namespace_name "trustStore" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/unit"></see>
    /// </summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/usageDuration"></see>
    /// </summary>
    let usageDuration =
        Namespaced_IRI.parse _namespace_name "usageDuration" |> NamespacedName

    /// <summary>
    /// The participant intending to use the data.
    /// <see href="https://w3id.org/idsa/core/user"></see></summary>
    let user = Namespaced_IRI.parse _namespace_name "user" |> NamespacedName
    /// <summary>
    /// (Equivalent) variant of given Resource, e.g. a translation.
    /// <see href="https://w3id.org/idsa/core/variant"></see></summary>
    let variant = Namespaced_IRI.parse _namespace_name "variant" |> NamespacedName
    /// <summary>
    /// Version identifier of the Managed Entity
    /// <see href="https://w3id.org/idsa/core/version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    /// Width of the visible frame.
    /// <see href="https://w3id.org/idsa/core/width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
