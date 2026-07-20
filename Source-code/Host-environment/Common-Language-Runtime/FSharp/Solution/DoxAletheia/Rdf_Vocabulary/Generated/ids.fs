namespace https.w3id.org.idsa.core.slash

open DoxAletheia

module ids =
    let _namespace_name = "https://w3id.org/idsa/core/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Class of all frequencies.
    /// <see href="https://w3id.org/idsa/core/Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// The class of languages potentially being used by textual Data Assets.
    /// <see href="https://w3id.org/idsa/core/Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// Instances of the LeftOperand class are used as the leftOperand of a Constraint.
    /// <see href="https://w3id.org/idsa/core/LeftOperand"></see></summary>
    let LeftOperand = _prefix "LeftOperand"
    /// <summary>
    /// Class of scopes that may limit the space of query results, e.g. ALL, ACTIVE_ONLY.
    /// <see href="https://w3id.org/idsa/core/QueryScope"></see></summary>
    let QueryScope = _prefix "QueryScope"
    /// <summary>
    /// The class of binary operators.
    /// <see href="https://w3id.org/idsa/core/BinaryOperator"></see></summary>
    let BinaryOperator = _prefix "BinaryOperator"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    /// The state which an ids:Artifact may have or not.
    /// <see href="https://w3id.org/idsa/core/ArtifactState"></see></summary>
    let ArtifactState = _prefix "ArtifactState"
    /// <summary>
    /// Class of recipients of a query message, e.g. BROKER, APPSTORE, ANY.
    /// <see href="https://w3id.org/idsa/core/QueryTarget"></see></summary>
    let QueryTarget = _prefix "QueryTarget"
    /// <summary>
    /// Resource control for deployed services.
    /// <see href="https://w3id.org/idsa/core/AppExecutionResources"></see></summary>
    let AppExecutionResources = _prefix "AppExecutionResources"
    /// <summary>
    /// Local audit logging (including integrity protection) is the baseline for auditing and clearing. Remote audit log tracing provides means to do external audit verification.
    /// <see href="https://w3id.org/idsa/core/AuditGuarantee"></see></summary>
    let AuditGuarantee = _prefix "AuditGuarantee"
    /// <summary>
    /// Authentication mechanism applied prior to opening a connection. Examples are the verification server's identity or doing mutual authentication.
    /// <see href="https://w3id.org/idsa/core/AuthenticationGuarantee"></see></summary>
    let AuthenticationGuarantee = _prefix "AuthenticationGuarantee"
    /// <summary>
    /// Class of reasons that might lead to issuing a Rejection message.
    /// <see href="https://w3id.org/idsa/core/RejectionReason"></see></summary>
    let RejectionReason = _prefix "RejectionReason"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/SecurityProfile"></see>
    /// </summary>
    let SecurityProfile = _prefix "SecurityProfile"
    /// <summary>
    /// Reference to a security guarantee supported by given profile.
    /// <see href="https://w3id.org/idsa/core/securityGuarantee"></see></summary>
    let securityGuarantee = _prefix "securityGuarantee"
    /// <summary>
    /// Level of a Component Certification
    /// <see href="https://w3id.org/idsa/core/ComponentCertificationLevel"></see></summary>
    let ComponentCertificationLevel = _prefix "ComponentCertificationLevel"
    /// <summary>
    /// Certification Level transitively implied by given Certification Level of same root type.
    /// <see href="https://w3id.org/idsa/core/includedCertificationLevel"></see></summary>
    let includedCertificationLevel = _prefix "includedCertificationLevel"
    /// <summary>
    /// Class of endpoint types a data app offers.
    /// <see href="https://w3id.org/idsa/core/AppEndpointType"></see></summary>
    let AppEndpointType = _prefix "AppEndpointType"
    /// <summary>
    /// Connector Status is used to represent a Connectors current state inside the Configuration Model.
    /// <see href="https://w3id.org/idsa/core/ConnectorStatus"></see></summary>
    let ConnectorStatus = _prefix "ConnectorStatus"
    /// <summary>
    /// Instances of ids:LogLevel can be used to specify a log level. Currently this is only used by the Configuration Model.
    /// <see href="https://w3id.org/idsa/core/LogLevel"></see></summary>
    let LogLevel = _prefix "LogLevel"
    /// <summary>
    /// Cryptographic Key Type.
    /// <see href="https://w3id.org/idsa/core/KeyType"></see></summary>
    let KeyType = _prefix "KeyType"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/intervalIn"></see>
    /// </summary>
    let intervalIn = _prefix "intervalIn"
    /// <summary>
    /// The class of audiences (recipients) used in the JWT.
    /// <see href="https://w3id.org/idsa/core/Audience"></see></summary>
    let Audience = _prefix "Audience"
    /// <summary>
    /// Level of integrity protection and verification of the installed software stack. Trusted boot is an example of local integrity protection, remote integrity verification comprises, for example, remote attestation.
    /// <see href="https://w3id.org/idsa/core/IntegrityGuarantee"></see></summary>
    let IntegrityGuarantee = _prefix "IntegrityGuarantee"

    /// <summary>
    /// Level/extent of verifying the software stack.
    /// <see href="https://w3id.org/idsa/core/IntegrityVerificationScopeGuarantee"></see></summary>
    let IntegrityVerificationScopeGuarantee =
        _prefix "IntegrityVerificationScopeGuarantee"

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ContentType"></see>
    /// </summary>
    let ContentType = _prefix "ContentType"
    /// <summary>
    /// Possible formats for (security-related) tokens.
    /// <see href="https://w3id.org/idsa/core/TokenFormat"></see></summary>
    let TokenFormat = _prefix "TokenFormat"
    /// <summary>
    /// Means by which local data is protected.
    /// <see href="https://w3id.org/idsa/core/LocalDataConfidentialityGuarantee"></see></summary>
    let LocalDataConfidentialityGuarantee = _prefix "LocalDataConfidentialityGuarantee"
    /// <summary>
    /// The class of authentication standards that may be supported by Connectors.
    /// <see href="https://w3id.org/idsa/core/AuthStandard"></see></summary>
    let AuthStandard = _prefix "AuthStandard"
    /// <summary>
    /// Level of a Participant Certification
    /// <see href="https://w3id.org/idsa/core/ParticipantCertificationLevel"></see></summary>
    let ParticipantCertificationLevel = _prefix "ParticipantCertificationLevel"
    /// <summary>
    /// This LeftOperand is transitively included in the object LeftOperand.
    /// <see href="https://w3id.org/idsa/core/broader"></see></summary>
    let broader = _prefix "broader"
    /// <summary>
    /// Deploy mode of a Connector. Used mainly to capture a Connectors deployment type in the Configuration Model.
    /// <see href="https://w3id.org/idsa/core/ConnectorDeployMode"></see></summary>
    let ConnectorDeployMode = _prefix "ConnectorDeployMode"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/PolicyTemplate"></see>
    /// </summary>
    let PolicyTemplate = _prefix "PolicyTemplate"
    /// <summary>
    /// Service isolation mechanism supported by the Connector. Examples are process group (Docker) or by least privilege with clear separation and support for additional security modules as done by trustme.
    /// <see href="https://w3id.org/idsa/core/ServiceIsolationGuarantee"></see></summary>
    let ServiceIsolationGuarantee = _prefix "ServiceIsolationGuarantee"
    /// <summary>
    /// Class of query languages in which query strings may be formalized.
    /// <see href="https://w3id.org/idsa/core/QueryLanguage"></see></summary>
    let QueryLanguage = _prefix "QueryLanguage"
    /// <summary>
    /// Extent of supporting usage control.
    /// <see href="https://w3id.org/idsa/core/UsageControlGuarantee"></see></summary>
    let UsageControlGuarantee = _prefix "UsageControlGuarantee"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/IDSA"></see>
    /// </summary>
    let IDSA = _prefix "IDSA"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AbstractConstraint"></see>
    /// </summary>
    let AbstractConstraint = _prefix "AbstractConstraint"
    /// <summary>
    /// Message requesting an access token. This is intended for point-to-point communication with, e.g., Brokers.
    /// <see href="https://w3id.org/idsa/core/AccessTokenRequestMessage"></see></summary>
    let AccessTokenRequestMessage = _prefix "AccessTokenRequestMessage"
    /// <summary>
    /// Client-generated message initiating a communication, motivated by a certain reason and with an answer expected.
    /// <see href="https://w3id.org/idsa/core/RequestMessage"></see></summary>
    let RequestMessage = _prefix "RequestMessage"
    /// <summary>
    /// Response to an access token request, intended for point-to-point communication.
    /// <see href="https://w3id.org/idsa/core/AccessTokenResponseMessage"></see></summary>
    let AccessTokenResponseMessage = _prefix "AccessTokenResponseMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ResponseMessage"></see>
    /// </summary>
    let ResponseMessage = _prefix "ResponseMessage"
    /// <summary>
    /// Constraint that refines an Action.
    /// <see href="https://w3id.org/idsa/core/actionRefinement"></see></summary>
    let actionRefinement = _prefix "actionRefinement"
    /// <summary>
    /// Internal or external Agent interacting with the Industrial Data Space, not necessarily an IDS Participant.
    /// <see href="https://w3id.org/idsa/core/Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Described"></see>
    /// </summary>
    let Described = _prefix "Described"
    /// <summary>
    /// Message indicating that a specific App should be available (again) in the AppStore.
    /// <see href="https://w3id.org/idsa/core/AppAvailableMessage"></see></summary>
    let AppAvailableMessage = _prefix "AppAvailableMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AppNotificationMessage"></see>
    /// </summary>
    let AppNotificationMessage = _prefix "AppNotificationMessage"
    /// <summary>
    /// Message indicating that an App should be deleted from the AppStore.
    /// <see href="https://w3id.org/idsa/core/AppDeleteMessage"></see></summary>
    let AppDeleteMessage = _prefix "AppDeleteMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AppEndpoint"></see>
    /// </summary>
    let AppEndpoint = _prefix "AppEndpoint"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Endpoint"></see>
    /// </summary>
    let Endpoint = _prefix "Endpoint"
    /// <summary>
    /// Type of an app endpoint. Data apps have different endpoint types, e.g., for input, output or health status.
    /// <see href="https://w3id.org/idsa/core/appEndpointType"></see></summary>
    let appEndpointType = _prefix "appEndpointType"
    /// <summary>
    /// Security guarantee claimed by a security profile.
    /// <see href="https://w3id.org/idsa/core/SecurityGuarantee"></see></summary>
    let SecurityGuarantee = _prefix "SecurityGuarantee"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ResourceNotificationMessage"></see>
    /// </summary>
    let ResourceNotificationMessage = _prefix "ResourceNotificationMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedDataAppResource"></see>
    /// </summary>
    let affectedDataAppResource = _prefix "affectedDataAppResource"
    /// <summary>
    /// Message that asks for registration or update of a data app to the App Store. Payload contains app-related metadata (instance of class ids:AppResource). Message header may contain an app identifier parameter of a prior registered data app. If the app identifier is supplied, the message should be interpreted as a registration for an app update. Otherwise this message is used to register a new app.
    /// <see href="https://w3id.org/idsa/core/AppRegistrationRequestMessage"></see></summary>
    let AppRegistrationRequestMessage = _prefix "AppRegistrationRequestMessage"
    /// <summary>
    /// Message that follows up an AppRegistrationRequestMessage and contains the app registration confimation.
    /// <see href="https://w3id.org/idsa/core/AppRegistrationResponseMessage"></see></summary>
    let AppRegistrationResponseMessage = _prefix "AppRegistrationResponseMessage"
    /// <summary>
    /// App representation
    /// <see href="https://w3id.org/idsa/core/AppRepresentation"></see></summary>
    let AppRepresentation = _prefix "AppRepresentation"
    /// <summary>
    /// Software representation
    /// <see href="https://w3id.org/idsa/core/SoftwareRepresentation"></see></summary>
    let SoftwareRepresentation = _prefix "SoftwareRepresentation"
    /// <summary>
    /// Resource comprising IDS data apps.
    /// <see href="https://w3id.org/idsa/core/AppResource"></see></summary>
    let AppResource = _prefix "AppResource"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Resource"></see>
    /// </summary>
    let Resource = _prefix "Resource"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AppRoute"></see>
    /// </summary>
    let AppRoute = _prefix "AppRoute"
    /// <summary>
    /// Supplementary information about, e.g., the technology used, for routes.
    /// <see href="https://w3id.org/idsa/core/routeDeployMethod"></see></summary>
    let routeDeployMethod = _prefix "routeDeployMethod"
    /// <summary>
    /// Route between two or more app endpoints inside a app routing pipeline.
    /// <see href="https://w3id.org/idsa/core/subRoute"></see></summary>
    let subRoute = _prefix "subRoute"
    /// <summary>
    /// Start of a route.
    /// <see href="https://w3id.org/idsa/core/appRouteStart"></see></summary>
    let appRouteStart = _prefix "appRouteStart"
    /// <summary>
    /// End of a route.
    /// <see href="https://w3id.org/idsa/core/appRouteEnd"></see></summary>
    let appRouteEnd = _prefix "appRouteEnd"
    /// <summary>
    /// Secure platform for distributing Data Apps.
    /// <see href="https://w3id.org/idsa/core/AppStore"></see></summary>
    let AppStore = _prefix "AppStore"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Connector"></see>
    /// </summary>
    let Connector = _prefix "Connector"
    /// <summary>
    /// Message indicating that a specific App should be unavailable in the AppStore.
    /// <see href="https://w3id.org/idsa/core/AppUnavailableMessage"></see></summary>
    let AppUnavailableMessage = _prefix "AppUnavailableMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AppUploadMessage"></see>
    /// </summary>
    let AppUploadMessage = _prefix "AppUploadMessage"
    /// <summary>
    /// Message used to upload a data to a recipient. Payload contains data.
    /// <see href="https://w3id.org/idsa/core/UploadMessage"></see></summary>
    let UploadMessage = _prefix "UploadMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/appArtifactReference"></see>
    /// </summary>
    let appArtifactReference = _prefix "appArtifactReference"
    /// <summary>
    /// Message that follows up an AppUploadMessage and contains the app upload confimation.
    /// <see href="https://w3id.org/idsa/core/AppUploadResponseMessage"></see></summary>
    let AppUploadResponseMessage = _prefix "AppUploadResponseMessage"
    /// <summary>
    /// Message that follows up a UploadMessage and contains the upload confirmation.
    /// <see href="https://w3id.org/idsa/core/UploadResponseMessage"></see></summary>
    let UploadResponseMessage = _prefix "UploadResponseMessage"
    /// <summary>
    /// Instance of a Representation materialized at a partiuclar version and point in time. Possesses characteristics like file name, size, creation date etc.
    /// <see href="https://w3id.org/idsa/core/Artifact"></see></summary>
    let Artifact = _prefix "Artifact"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/RepresentationInstance"></see>
    /// </summary>
    let RepresentationInstance = _prefix "RepresentationInstance"
    /// <summary>
    /// Literal, inline value instantiation of a representation.
    /// <see href="https://w3id.org/idsa/core/Value"></see></summary>
    let Value = _prefix "Value"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ArtifactRequestMessage"></see>
    /// </summary>
    let ArtifactRequestMessage = _prefix "ArtifactRequestMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/requestedArtifact"></see>
    /// </summary>
    let requestedArtifact = _prefix "requestedArtifact"
    /// <summary>
    /// Message that follows up a RetrieveArtifact Message and contains the Artifact's data in the payload section.
    /// <see href="https://w3id.org/idsa/core/ArtifactResponseMessage"></see></summary>
    let ArtifactResponseMessage = _prefix "ArtifactResponseMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Asset"></see>
    /// </summary>
    let Asset = _prefix "Asset"
    /// <summary>
    /// An AssetCollection is a bracket object combining several ids:Assets.
    /// <see href="https://w3id.org/idsa/core/AssetCollection"></see></summary>
    let AssetCollection = _prefix "AssetCollection"
    /// <summary>
    /// Audio representation
    /// <see href="https://w3id.org/idsa/core/AudioRepresentation"></see></summary>
    let AudioRepresentation = _prefix "AudioRepresentation"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Representation"></see>
    /// </summary>
    let Representation = _prefix "Representation"
    /// <summary>
    /// Resource (at least partially) comprising audio content.
    /// <see href="https://w3id.org/idsa/core/AudioResource"></see></summary>
    let AudioResource = _prefix "AudioResource"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/AuthInfo"></see>
    /// </summary>
    let AuthInfo = _prefix "AuthInfo"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/authService"></see>
    /// </summary>
    let authService = _prefix "authService"
    /// <summary>
    /// Implementation of the Connector specification providing only restricted security capabilities.
    /// <see href="https://w3id.org/idsa/core/BaseConnector"></see></summary>
    let BaseConnector = _prefix "BaseConnector"
    /// <summary>
    /// Basic authentication using username / password
    /// <see href="https://w3id.org/idsa/core/BasicAuthentication"></see></summary>
    let BasicAuthentication = _prefix "BasicAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/UserAuthentication"></see>
    /// </summary>
    let UserAuthentication = _prefix "UserAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/BoundingPolygon"></see>
    /// </summary>
    let BoundingPolygon = _prefix "BoundingPolygon"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Geometry"></see>
    /// </summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    /// Refers to a GeoPoint that is member of a BoundingPolygon.
    /// <see href="https://w3id.org/idsa/core/geoPoint"></see></summary>
    let geoPoint = _prefix "geoPoint"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Broker"></see>
    /// </summary>
    let Broker = _prefix "Broker"
    /// <summary>
    /// Reference to catalog of Connectors, which are listed in the Broker.
    /// <see href="https://w3id.org/idsa/core/connectorCatalog"></see></summary>
    let connectorCatalog = _prefix "connectorCatalog"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Catalog"></see>
    /// </summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Certification"></see>
    /// </summary>
    let Certification = _prefix "Certification"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ManagedEntity"></see>
    /// </summary>
    let ManagedEntity = _prefix "ManagedEntity"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/CertificationLevel"></see>
    /// </summary>
    let CertificationLevel = _prefix "CertificationLevel"
    /// <summary>
    /// The Clearing House provides clearing and settlement services B2B interactions within the International Data Spaces.
    /// <see href="https://w3id.org/idsa/core/ClearingHouse"></see></summary>
    let ClearingHouse = _prefix "ClearingHouse"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/InfrastructureComponent"></see>
    /// </summary>
    let InfrastructureComponent = _prefix "InfrastructureComponent"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/CommandMessage"></see>
    /// </summary>
    let CommandMessage = _prefix "CommandMessage"
    /// <summary>
    /// Process and result of certifying a software component/servivce in order to become a certified part of the International Data Space infrastructure.
    /// <see href="https://w3id.org/idsa/core/ComponentCertification"></see></summary>
    let ComponentCertification = _prefix "ComponentCertification"
    /// <summary>
    /// Level of certification (based on a combination of requierements, evaluation method etc.)
    /// <see href="https://w3id.org/idsa/core/certificationLevel"></see></summary>
    let certificationLevel = _prefix "certificationLevel"
    /// <summary>
    /// Process and result of certifying an interested party in order to become a certified member of the International Data Space.
    /// <see href="https://w3id.org/idsa/core/ParticipantCertification"></see></summary>
    let ParticipantCertification = _prefix "ParticipantCertification"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Concept"></see>
    /// </summary>
    let Concept = _prefix "Concept"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ConfigurationModel"></see>
    /// </summary>
    let ConfigurationModel = _prefix "ConfigurationModel"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/appRoute"></see>
    /// </summary>
    let appRoute = _prefix "appRoute"
    /// <summary>
    /// Deply mode of a Connector in the Configuration Model
    /// <see href="https://w3id.org/idsa/core/connectorDeployMode"></see></summary>
    let connectorDeployMode = _prefix "connectorDeployMode"
    /// <summary>
    /// Status of a Connector deployed by the Configuration Model
    /// <see href="https://w3id.org/idsa/core/connectorStatus"></see></summary>
    let connectorStatus = _prefix "connectorStatus"
    /// <summary>
    /// Log level configuration for a Connector which is deployed using the Configuration Model
    /// <see href="https://w3id.org/idsa/core/configurationModelLogLevel"></see></summary>
    let configurationModelLogLevel = _prefix "configurationModelLogLevel"
    /// <summary>
    /// authentication methods allowed in a Configuration Model
    /// <see href="https://w3id.org/idsa/core/userAuthentication"></see></summary>
    let userAuthentication = _prefix "userAuthentication"
    /// <summary>
    /// Proxies for a Connector which is deployed using the Configuration Model
    /// <see href="https://w3id.org/idsa/core/connectorProxy"></see></summary>
    let connectorProxy = _prefix "connectorProxy"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/hasAgent"></see>
    /// </summary>
    let hasAgent = _prefix "hasAgent"
    /// <summary>
    /// The SecurityProfile supported by the Connector.
    /// <see href="https://w3id.org/idsa/core/securityProfile"></see></summary>
    let securityProfile = _prefix "securityProfile"
    /// <summary>
    /// References the Catalog of published or requested resource by this Connector.
    /// <see href="https://w3id.org/idsa/core/resourceCatalog"></see></summary>
    let resourceCatalog = _prefix "resourceCatalog"
    /// <summary>
    /// Reference to the Endpoints serving the resource's content or let you exchange messages with an IDS Connector.
    /// <see href="https://w3id.org/idsa/core/hasEndpoint"></see></summary>
    let hasEndpoint = _prefix "hasEndpoint"
    /// <summary>
    /// Reference to a security guarantee that, if used in combination with a security profile instance, overrides the respective guarantee of the given predefined instance.
    /// <see href="https://w3id.org/idsa/core/extendedGuarantee"></see></summary>
    let extendedGuarantee = _prefix "extendedGuarantee"
    /// <summary>
    /// Indicates the default endpoint that should be used for basic infrastructure interactions, e.g., providing the self description.
    /// <see href="https://w3id.org/idsa/core/hasDefaultEndpoint"></see></summary>
    let hasDefaultEndpoint = _prefix "hasDefaultEndpoint"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ConnectorCatalog"></see>
    /// </summary>
    let ConnectorCatalog = _prefix "ConnectorCatalog"
    /// <summary>
    /// A Connector, that is part of a Connector catalog.
    /// <see href="https://w3id.org/idsa/core/listedConnector"></see></summary>
    let listedConnector = _prefix "listedConnector"

    /// <summary>
    /// Whenever a Connector has been successfully certified by the Certification Body, the Identity Provider can use this message to notify Infrastructure Components.
    /// <see href="https://w3id.org/idsa/core/ConnectorCertificateGrantedMessage"></see></summary>
    let ConnectorCertificateGrantedMessage =
        _prefix "ConnectorCertificateGrantedMessage"

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ConnectorNotificationMessage"></see>
    /// </summary>
    let ConnectorNotificationMessage = _prefix "ConnectorNotificationMessage"

    /// <summary>
    /// Indicates that a (previously certified) Connector is no more certified. This could happen, for instance, if the Certification Body revokes a granted certificate or if the certificate just expires.
    /// <see href="https://w3id.org/idsa/core/ConnectorCertificateRevokedMessage"></see></summary>
    let ConnectorCertificateRevokedMessage =
        _prefix "ConnectorCertificateRevokedMessage"

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ConnectorEndpoint"></see>
    /// </summary>
    let ConnectorEndpoint = _prefix "ConnectorEndpoint"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/accessUrl"></see>
    /// </summary>
    let accessUrl = _prefix "accessUrl"
    /// <summary>
    /// Event messages are informative and no response is expected by the sender.
    /// <see href="https://w3id.org/idsa/core/NotificationMessage"></see></summary>
    let NotificationMessage = _prefix "NotificationMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedConnector"></see>
    /// </summary>
    let affectedConnector = _prefix "affectedConnector"
    /// <summary>
    /// Event notifying the recipient(s) that a connector will be unavailable. The same connector may be available again in the future.
    /// <see href="https://w3id.org/idsa/core/ConnectorUnavailableMessage"></see></summary>
    let ConnectorUnavailableMessage = _prefix "ConnectorUnavailableMessage"
    /// <summary>
    /// Event notifying the recipient(s) about the availability and current configuration of a connector. The payload of the message must contain the updated connector's self-description.
    /// <see href="https://w3id.org/idsa/core/ConnectorUpdateMessage"></see></summary>
    let ConnectorUpdateMessage = _prefix "ConnectorUpdateMessage"
    /// <summary>
    /// The ContractAgreement class representing the 'Connector-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/ConnectorbasedAgreement"></see></summary>
    let ConnectorbasedAgreement = _prefix "ConnectorbasedAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ContractAgreement"></see>
    /// </summary>
    let ContractAgreement = _prefix "ContractAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Connector-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/ConnectorbasedOffer"></see></summary>
    let ConnectorbasedOffer = _prefix "ConnectorbasedOffer"
    /// <summary>
    /// Contract issued by the Data Provider offering the usage of a Resource at particular conditions.
    /// <see href="https://w3id.org/idsa/core/ContractOffer"></see></summary>
    let ContractOffer = _prefix "ContractOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Connector-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/ConnectorbasedRequest"></see></summary>
    let ConnectorbasedRequest = _prefix "ConnectorbasedRequest"
    /// <summary>
    /// Contract issued by the Data Consumer requesting the usage of a Resource at particular conditions.
    /// <see href="https://w3id.org/idsa/core/ContractRequest"></see></summary>
    let ContractRequest = _prefix "ContractRequest"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Constraint"></see>
    /// </summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    /// The left operand in a constraint expression.
    /// <see href="https://w3id.org/idsa/core/leftOperand"></see></summary>
    let leftOperand = _prefix "leftOperand"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/operator"></see>
    /// </summary>
    let operator = _prefix "operator"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Contract"></see>
    /// </summary>
    let Contract = _prefix "Contract"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/permission"></see>
    /// </summary>
    let permission = _prefix "permission"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/prohibition"></see>
    /// </summary>
    let prohibition = _prefix "prohibition"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/obligation"></see>
    /// </summary>
    let obligation = _prefix "obligation"
    /// <summary>
    /// Absolute datetime the Contract is requested, offered or expected to start, depending on the type of Contract.
    /// <see href="https://w3id.org/idsa/core/contractStart"></see></summary>
    let contractStart = _prefix "contractStart"
    /// <summary>
    /// Message containing a contract, as an instance of ids:ContractAgreement, with resource access modalities on which two parties have agreed in the payload.
    /// <see href="https://w3id.org/idsa/core/ContractAgreementMessage"></see></summary>
    let ContractAgreementMessage = _prefix "ContractAgreementMessage"
    /// <summary>
    /// Message containing a offered content contract (as offered by a data provider to the data consumer) in the associated payload (which is an instance of ContractOffer). In contrast to the ids:ContractResponseMessage, the ids:ContractOfferMessage is not related to a previous contract
    /// <see href="https://w3id.org/idsa/core/ContractOfferMessage"></see></summary>
    let ContractOfferMessage = _prefix "ContractOfferMessage"
    /// <summary>
    /// Message indicating rejection of a contract.
    /// <see href="https://w3id.org/idsa/core/ContractRejectionMessage"></see></summary>
    let ContractRejectionMessage = _prefix "ContractRejectionMessage"
    /// <summary>
    /// Rejection messages are specialized response messages that notify the sender of a message that processing of this message has failed.
    /// <see href="https://w3id.org/idsa/core/RejectionMessage"></see></summary>
    let RejectionMessage = _prefix "RejectionMessage"
    /// <summary>
    /// Message containing a suggested content contract (as offered by the data consumer to the data provider) in the associated payload (which is an instance of ContractRequest).
    /// <see href="https://w3id.org/idsa/core/ContractRequestMessage"></see></summary>
    let ContractRequestMessage = _prefix "ContractRequestMessage"
    /// <summary>
    /// Message containing a response to a contract request (of a data consumer) in form of a counter-proposal of a contract in the associated payload (which is an instance of ContractOffcer).
    /// <see href="https://w3id.org/idsa/core/ContractResponseMessage"></see></summary>
    let ContractResponseMessage = _prefix "ContractResponseMessage"
    /// <summary>
    /// Message containing supplemental information to access resources of a contract (e.g. resource access tokens).
    /// <see href="https://w3id.org/idsa/core/ContractSupplementMessage"></see></summary>
    let ContractSupplementMessage = _prefix "ContractSupplementMessage"
    /// <summary>
    /// A selection of custom media types to be used for data published on the IDS when no IANA type is available.
    /// <see href="https://w3id.org/idsa/core/CustomMediaType"></see></summary>
    let CustomMediaType = _prefix "CustomMediaType"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/MediaType"></see>
    /// </summary>
    let MediaType = _prefix "MediaType"
    /// <summary>
    /// The Dynamic Attribute Provisioning Service (DAPS) is a component of the Identity Provider and manages and issues the Dynamic Attribute Tokens (DAT), acting as digtial proofs for dynamic attributes of both connectors and participants.
    /// <see href="https://w3id.org/idsa/core/DAPS"></see></summary>
    let DAPS = _prefix "DAPS"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DatPayload"></see>
    /// </summary>
    let DatPayload = _prefix "DatPayload"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/JwtPayload"></see>
    /// </summary>
    let JwtPayload = _prefix "JwtPayload"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/referringConnector"></see>
    /// </summary>
    let referringConnector = _prefix "referringConnector"
    /// <summary>
    /// The 'iss' (issuer) claim identifies the principal that issued the JWT.
    /// <see href="https://w3id.org/idsa/core/iss"></see></summary>
    let iss = _prefix "iss"
    /// <summary>
    /// The Dynamic Attribute Token (DAT) *Request* Payload is the JSON Element of any DAT containing the claims of the token bearer. This payload itself is a JSON-LD encoded RDF class with a defined set of attributes. These attributes are either defined by RFC 7519 or by the IDS Information Model. As a direct consequence of regarding the DAT Payload as JSON-LD, *all* DAT Payloads must have exactly one "@context" attribute with the IDS context URI as its value and a "@type" with ids:DatPayload as its value. Note that, different to the DatPayload, the DatRequestPayload contains the *self-claims* of a connector and is not yet signed by any DAPS. Consequently, no other connector must accept a DatRequest object as a DAT. A DatRequest and its contained DatRequestPayload is *only* intended for interactions with a DAPS and *nothing else*!
    /// <see href="https://w3id.org/idsa/core/DatRequestPayload"></see></summary>
    let DatRequestPayload = _prefix "DatRequestPayload"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DataApp"></see>
    /// </summary>
    let DataApp = _prefix "DataApp"
    /// <summary>
    /// Endpoints of a data app
    /// <see href="https://w3id.org/idsa/core/appEndpoint"></see></summary>
    let appEndpoint = _prefix "appEndpoint"
    /// <summary>
    /// Physical representation of (structured) data.
    /// <see href="https://w3id.org/idsa/core/DataRepresentation"></see></summary>
    let DataRepresentation = _prefix "DataRepresentation"
    /// <summary>
    /// Resource (at least partially) comprising data content.
    /// <see href="https://w3id.org/idsa/core/DataResource"></see></summary>
    let DataResource = _prefix "DataResource"
    /// <summary>
    /// The ContractAgreement class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.
    /// <see href="https://w3id.org/idsa/core/DeleteAfterIntervalAgreement"></see></summary>
    let DeleteAfterIntervalAgreement = _prefix "DeleteAfterIntervalAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.
    /// <see href="https://w3id.org/idsa/core/DeleteAfterIntervalOffer"></see></summary>
    let DeleteAfterIntervalOffer = _prefix "DeleteAfterIntervalOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.
    /// <see href="https://w3id.org/idsa/core/DeleteAfterIntervalRequest"></see></summary>
    let DeleteAfterIntervalRequest = _prefix "DeleteAfterIntervalRequest"
    /// <summary>
    /// Explanation of the resource in a natural language text.
    /// <see href="https://w3id.org/idsa/core/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// (Localized) name of the entity.
    /// <see href="https://w3id.org/idsa/core/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DescribedSemantically"></see>
    /// </summary>
    let DescribedSemantically = _prefix "DescribedSemantically"
    /// <summary>
    /// Message requesting metadata. If no URI is supplied via the ids:requestedElement field, this messages is treated like a self-description request and the recipient should return its self-description via an ids:DescriptionResponseMessage. However, if a URI is supplied, the Connector should either return metadata about the requested element via an ids:DescriptionResponseMessage, or send an ids:RejectionMessage, e.g. because the element was not found.
    /// <see href="https://w3id.org/idsa/core/DescriptionRequestMessage"></see></summary>
    let DescriptionRequestMessage = _prefix "DescriptionRequestMessage"
    /// <summary>
    /// Message containing the metadata, which a Connector previously requested via the ids:DescriptionRequestMessage, in its payload.
    /// <see href="https://w3id.org/idsa/core/DescriptionResponseMessage"></see></summary>
    let DescriptionResponseMessage = _prefix "DescriptionResponseMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DigitalContent"></see>
    /// </summary>
    let DigitalContent = _prefix "DigitalContent"
    /// <summary>
    /// Named spatial entity covered by the Resource.
    /// <see href="https://w3id.org/idsa/core/spatialCoverage"></see></summary>
    let spatialCoverage = _prefix "spatialCoverage"
    /// <summary>
    /// Natural language(s) used within the content.
    /// <see href="https://w3id.org/idsa/core/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Controlled keywords that describe the nature, purpose, or use of the content.
    /// <see href="https://w3id.org/idsa/core/keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// Reference to a Digital Content (physically or logically) included, definition of part-whole hierarchies.
    /// <see href="https://w3id.org/idsa/core/contentPart"></see></summary>
    let contentPart = _prefix "contentPart"
    /// <summary>
    /// Representation of the content.
    /// <see href="https://w3id.org/idsa/core/representation"></see></summary>
    let representation = _prefix "representation"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/theme"></see>
    /// </summary>
    let theme = _prefix "theme"
    /// <summary>
    /// Temporal period or instance covered by the content.
    /// <see href="https://w3id.org/idsa/core/temporalCoverage"></see></summary>
    let temporalCoverage = _prefix "temporalCoverage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/contentRefinement"></see>
    /// </summary>
    let contentRefinement = _prefix "contentRefinement"
    /// <summary>
    /// The ContractAgreement class representing the 'Distribute only if Encrypted' policy class.
    /// <see href="https://w3id.org/idsa/core/DistributeEcryptedAgreement"></see></summary>
    let DistributeEcryptedAgreement = _prefix "DistributeEcryptedAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Distribute only if Encrypted' policy class.
    /// <see href="https://w3id.org/idsa/core/DistributeEcryptedOffer"></see></summary>
    let DistributeEcryptedOffer = _prefix "DistributeEcryptedOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Distribute only if Encrypted' policy class.
    /// <see href="https://w3id.org/idsa/core/DistributeEcryptedRequest"></see></summary>
    let DistributeEcryptedRequest = _prefix "DistributeEcryptedRequest"
    /// <summary>
    /// The ContractAgreement class representing the 'Duration-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/DurationAgreement"></see></summary>
    let DurationAgreement = _prefix "DurationAgreement"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DurationEntity"></see>
    /// </summary>
    let DurationEntity = _prefix "DurationEntity"
    /// <summary>
    /// A temporal interval, instant or a relative duration.
    /// <see href="https://w3id.org/idsa/core/TemporalEntity"></see></summary>
    let TemporalEntity = _prefix "TemporalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/hasDuration"></see>
    /// </summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    /// The ContractOffer class representing the 'Duration-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/DurationOffer"></see></summary>
    let DurationOffer = _prefix "DurationOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Duration-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/DurationRequest"></see></summary>
    let DurationRequest = _prefix "DurationRequest"
    /// <summary>
    /// The class of Duties as defined in the ODRL ontology.
    /// <see href="https://w3id.org/idsa/core/Duty"></see></summary>
    let Duty = _prefix "Duty"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Rule"></see>
    /// </summary>
    let Rule = _prefix "Rule"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/DynamicAttributeToken"></see>
    /// </summary>
    let DynamicAttributeToken = _prefix "DynamicAttributeToken"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Token"></see>
    /// </summary>
    let Token = _prefix "Token"
    /// <summary>
    /// Describes the format of the authentication token.
    /// <see href="https://w3id.org/idsa/core/tokenFormat"></see></summary>
    let tokenFormat = _prefix "tokenFormat"
    /// <summary>
    ///
    ///     EndToEndRoute hold information about a communication pipelines between apps. An EndToEndRoute should hold
    ///     one value for the ids:appRouteStart and/or ids:appRouteEnd properties, so that communication between app endpoints remain distinguishable.
    ///
    /// <see href="https://w3id.org/idsa/core/EndToEndRoute"></see></summary>
    let EndToEndRoute = _prefix "EndToEndRoute"
    /// <summary>
    /// Human-readable information and description of the endpoint.
    /// <see href="https://w3id.org/idsa/core/endpointInformation"></see></summary>
    let endpointInformation = _prefix "endpointInformation"
    /// <summary>
    /// IRI reference to a documentation of the endpoint,  e.g., reference to an OpenAPI-based documentation.
    /// <see href="https://w3id.org/idsa/core/endpointDocumentation"></see></summary>
    let endpointDocumentation = _prefix "endpointDocumentation"
    /// <summary>
    /// Evaluation Facilities carry out the evaluation work during a certification process and issue the corresponding Certifications.
    /// <see href="https://w3id.org/idsa/core/EvaluationFacility"></see></summary>
    let EvaluationFacility = _prefix "EvaluationFacility"
    /// <summary>
    /// Named event with a known or unknown temporal location or duration.
    /// <see href="https://w3id.org/idsa/core/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// The ContractAgreement class representing the 'Event-restricted Usage Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/EventAgreement"></see></summary>
    let EventAgreement = _prefix "EventAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Event-restricted Usage Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/EventOffer"></see></summary>
    let EventOffer = _prefix "EventOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Event-restricted Usage Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/EventRequest"></see></summary>
    let EventRequest = _prefix "EventRequest"
    /// <summary>
    /// A location identified by a geonames URL.
    /// <see href="https://w3id.org/idsa/core/GeoFeature"></see></summary>
    let GeoFeature = _prefix "GeoFeature"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Location"></see>
    /// </summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/GeoPoint"></see>
    /// </summary>
    let GeoPoint = _prefix "GeoPoint"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/longitude"></see>
    /// </summary>
    let longitude = _prefix "longitude"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/latitude"></see>
    /// </summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// HTTP authentication.
    /// <see href="https://w3id.org/idsa/core/HTTPAuthentication"></see></summary>
    let HTTPAuthentication = _prefix "HTTPAuthentication"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/IANAMediaType"></see>
    /// </summary>
    let IANAMediaType = _prefix "IANAMediaType"
    /// <summary>
    /// The Identity Provider manages and validates the digital identity of International Data Spaces Participants.
    /// <see href="https://w3id.org/idsa/core/IdentityProvider"></see></summary>
    let IdentityProvider = _prefix "IdentityProvider"
    /// <summary>
    /// Image representation
    /// <see href="https://w3id.org/idsa/core/ImageRepresentation"></see></summary>
    let ImageRepresentation = _prefix "ImageRepresentation"
    /// <summary>
    /// Resource (at least partially) comprising image content.
    /// <see href="https://w3id.org/idsa/core/ImageResource"></see></summary>
    let ImageResource = _prefix "ImageResource"
    /// <summary>
    /// Information Model version being produced by the InfrastructureComponent.
    /// <see href="https://w3id.org/idsa/core/outboundModelVersion"></see></summary>
    let outboundModelVersion = _prefix "outboundModelVersion"
    /// <summary>
    /// Information Model version that the InfrastructureComponent is capable of reading/processing.
    /// <see href="https://w3id.org/idsa/core/inboundModelVersion"></see></summary>
    let inboundModelVersion = _prefix "inboundModelVersion"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/curator"></see>
    /// </summary>
    let curator = _prefix "curator"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/maintainer"></see>
    /// </summary>
    let maintainer = _prefix "maintainer"
    /// <summary>
    /// A defined point in time with zero duration.
    /// <see href="https://w3id.org/idsa/core/Instant"></see></summary>
    let Instant = _prefix "Instant"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Interval"></see>
    /// </summary>
    let Interval = _prefix "Interval"
    /// <summary>
    /// Beginning of an Interval.
    /// <see href="https://w3id.org/idsa/core/begin"></see></summary>
    let begin_ = _prefix "begin"
    /// <summary>
    /// The ContractAgreement class representing the 'Interval-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/IntervalUsageAgreement"></see></summary>
    let IntervalUsageAgreement = _prefix "IntervalUsageAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Interval-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/IntervalUsageOffer"></see></summary>
    let IntervalUsageOffer = _prefix "IntervalUsageOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Interval-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/IntervalUsageRequest"></see></summary>
    let IntervalUsageRequest = _prefix "IntervalUsageRequest"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/InvokeOperationMessage"></see>
    /// </summary>
    let InvokeOperationMessage = _prefix "InvokeOperationMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/operationReference"></see>
    /// </summary>
    let operationReference = _prefix "operationReference"
    /// <summary>
    /// The 'sub' (subject) claim identifies the principal that is the subject of the JWT.
    /// <see href="https://w3id.org/idsa/core/sub"></see></summary>
    let sub = _prefix "sub"
    /// <summary>
    /// The 'iat' (issued at) claim contains the point in time when the JWT was created.
    /// <see href="https://w3id.org/idsa/core/iat"></see></summary>
    let iat = _prefix "iat"
    /// <summary>
    /// The 'aud' (audience) claim identifies the recipients that the JWT is intended for.
    /// <see href="https://w3id.org/idsa/core/nbf"></see></summary>
    let nbf = _prefix "nbf"
    /// <summary>
    /// Separate certificates for IDS identification and transport encryption opens an attack vector for relay attacks. In order to prevent these attacks, a binding of this transport certificates to the connector is required. The inclusion of SHA256 fingerprints of currently valid transport certificates, mainly into the DAT, enables the client to relate the transport layer security with the IDS interactions.
    /// <see href="https://w3id.org/idsa/core/transportCertsSha256"></see></summary>
    let transportCertsSha256 = _prefix "transportCertsSha256"
    /// <summary>
    /// Currently, the scope is limited to 'Connector' but can be used for scoping purposes in the future. Scope is currently fixed to 'https://w3id.org/idsa/core/Connector'.
    /// <see href="https://w3id.org/idsa/core/scope"></see></summary>
    let scope = _prefix "scope"
    /// <summary>
    /// The 'aud' (audience) claim identifies the recipients that the JWT is intended for.
    /// <see href="https://w3id.org/idsa/core/aud"></see></summary>
    let aud = _prefix "aud"
    /// <summary>
    /// The 'exp' (expiration time) claim identifies the expiration time on or after which the JWT MUST NOT be accepted for processing.
    /// <see href="https://w3id.org/idsa/core/exp"></see></summary>
    let exp = _prefix "exp"
    /// <summary>
    /// Class of Licences to be referred to by Resources.
    /// <see href="https://w3id.org/idsa/core/License"></see></summary>
    let License = _prefix "License"
    /// <summary>
    /// Log Message which can be used to transfer logs e.g. to the clearing house.
    /// <see href="https://w3id.org/idsa/core/LogMessage"></see></summary>
    let LogMessage = _prefix "LogMessage"
    /// <summary>
    /// The ContractAgreement class representing the 'Local Logging' policy class.
    /// <see href="https://w3id.org/idsa/core/LoggingAgreement"></see></summary>
    let LoggingAgreement = _prefix "LoggingAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Local Logging' policy class.
    /// <see href="https://w3id.org/idsa/core/LoggingOffer"></see></summary>
    let LoggingOffer = _prefix "LoggingOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Local Logging' policy class.
    /// <see href="https://w3id.org/idsa/core/LoggingRequest"></see></summary>
    let LoggingRequest = _prefix "LoggingRequest"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/LogicalConstraint"></see>
    /// </summary>
    let LogicalConstraint = _prefix "LogicalConstraint"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/and"></see>
    /// </summary>
    let and_ = _prefix "and"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/or"></see>
    /// </summary>
    let or_ = _prefix "or"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/xone"></see>
    /// </summary>
    let xone = _prefix "xone"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Message"></see>
    /// </summary>
    let Message = _prefix "Message"
    /// <summary>
    /// A token representing a claim that the message sender supports a certain security profile.
    /// <see href="https://w3id.org/idsa/core/securityToken"></see></summary>
    let securityToken = _prefix "securityToken"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/issuerConnector"></see>
    /// </summary>
    let issuerConnector = _prefix "issuerConnector"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/issued"></see>
    /// </summary>
    let issued = _prefix "issued"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/recipientAgent"></see>
    /// </summary>
    let recipientAgent = _prefix "recipientAgent"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/senderAgent"></see>
    /// </summary>
    let senderAgent = _prefix "senderAgent"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/recipientConnector"></see>
    /// </summary>
    let recipientConnector = _prefix "recipientConnector"
    /// <summary>
    /// Version of the Information Model against which the Message should be interpreted.
    /// <see href="https://w3id.org/idsa/core/modelVersion"></see></summary>
    let modelVersion = _prefix "modelVersion"

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/MessageProcessedNotificationMessage"></see>
    /// </summary>
    let MessageProcessedNotificationMessage =
        _prefix "MessageProcessedNotificationMessage"

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/correlationMessage"></see>
    /// </summary>
    let correlationMessage = _prefix "correlationMessage"
    /// <summary>
    /// Entity that is identifiable within a context by means of a name.
    /// <see href="https://w3id.org/idsa/core/Named"></see></summary>
    let Named = _prefix "Named"
    /// <summary>
    /// Entity name unique within a specified context.
    /// <see href="https://w3id.org/idsa/core/name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// The ContractAgreement class representing the 'Restricted Number of Usages' policy class.
    /// <see href="https://w3id.org/idsa/core/NotMoreThanNAgreement"></see></summary>
    let NotMoreThanNAgreement = _prefix "NotMoreThanNAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Restricted Number of Usages' policy class.
    /// <see href="https://w3id.org/idsa/core/NotMoreThanNOffer"></see></summary>
    let NotMoreThanNOffer = _prefix "NotMoreThanNOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Restricted Number of Usages' policy class.
    /// <see href="https://w3id.org/idsa/core/NotMoreThanNRequest"></see></summary>
    let NotMoreThanNRequest = _prefix "NotMoreThanNRequest"
    /// <summary>
    /// The ContractAgreement class representing the 'Remote Notifications' policy class.
    /// <see href="https://w3id.org/idsa/core/NotificationAgreement"></see></summary>
    let NotificationAgreement = _prefix "NotificationAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Remote Notifications' policy class.
    /// <see href="https://w3id.org/idsa/core/NotificationOffer"></see></summary>
    let NotificationOffer = _prefix "NotificationOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Remote Notifications' policy class.
    /// <see href="https://w3id.org/idsa/core/NotificationRequest"></see></summary>
    let NotificationRequest = _prefix "NotificationRequest"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Operation"></see>
    /// </summary>
    let Operation = _prefix "Operation"
    /// <summary>
    /// Message indicating that the result of a former InvokeOperation message is available. May transfer the result data in its associated payload section.
    /// <see href="https://w3id.org/idsa/core/OperationResultMessage"></see></summary>
    let OperationResultMessage = _prefix "OperationResultMessage"
    /// <summary>
    /// Apps for orchestrating System Adapter Apps or Smart Data Apps, inside a Connector.
    /// <see href="https://w3id.org/idsa/core/OrchestrationApp"></see></summary>
    let OrchestrationApp = _prefix "OrchestrationApp"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ParIS"></see>
    /// </summary>
    let ParIS = _prefix "ParIS"
    /// <summary>
    /// List of participants a ParIS may expose.
    /// <see href="https://w3id.org/idsa/core/participantCatalog"></see></summary>
    let participantCatalog = _prefix "participantCatalog"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Participant"></see>
    /// </summary>
    let Participant = _prefix "Participant"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/memberPerson"></see>
    /// </summary>
    let memberPerson = _prefix "memberPerson"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/memberParticipant"></see>
    /// </summary>
    let memberParticipant = _prefix "memberParticipant"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/corporateEmailAddress"></see>
    /// </summary>
    let corporateEmailAddress = _prefix "corporateEmailAddress"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ParticipantCatalog"></see>
    /// </summary>
    let ParticipantCatalog = _prefix "ParticipantCatalog"
    /// <summary>
    /// A Participant, that is part of a participant catalog.
    /// <see href="https://w3id.org/idsa/core/member"></see></summary>
    let member_ = _prefix "member"

    /// <summary>
    /// Whenever a Participant has been successfully certified by the Certification Body, the Identity Provider can use this message to notify Infrastructure Components.
    /// <see href="https://w3id.org/idsa/core/ParticipantCertificateGrantedMessage"></see></summary>
    let ParticipantCertificateGrantedMessage =
        _prefix "ParticipantCertificateGrantedMessage"

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ParticipantNotificationMessage"></see>
    /// </summary>
    let ParticipantNotificationMessage = _prefix "ParticipantNotificationMessage"

    /// <summary>
    /// Indicates that a (previously certified) Participant is no more certified. This could happen, for instance, if the Certification Body revokes a granted certificate or if the certificate just expires.
    /// <see href="https://w3id.org/idsa/core/ParticipantCertificateRevokedMessage"></see></summary>
    let ParticipantCertificateRevokedMessage =
        _prefix "ParticipantCertificateRevokedMessage"

    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedParticipant"></see>
    /// </summary>
    let affectedParticipant = _prefix "affectedParticipant"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ParticipantRequestMessage"></see>
    /// </summary>
    let ParticipantRequestMessage = _prefix "ParticipantRequestMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/requestedParticipant"></see>
    /// </summary>
    let requestedParticipant = _prefix "requestedParticipant"
    /// <summary>
    /// Message that follows up a ParticipantRequestMessage and contains the Participant's information in the payload section.
    /// <see href="https://w3id.org/idsa/core/ParticipantResponseMessage"></see></summary>
    let ParticipantResponseMessage = _prefix "ParticipantResponseMessage"
    /// <summary>
    /// Event notifying the recipient(s) that a participant will be unavailable. The same participant may be available again in the future.
    /// <see href="https://w3id.org/idsa/core/ParticipantUnavailableMessage"></see></summary>
    let ParticipantUnavailableMessage = _prefix "ParticipantUnavailableMessage"
    /// <summary>
    /// Event notifying the recipient(s) about the availability and current description of a participant. The payload of the message must contain the participant's self-description.
    /// <see href="https://w3id.org/idsa/core/ParticipantUpdateMessage"></see></summary>
    let ParticipantUpdateMessage = _prefix "ParticipantUpdateMessage"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Permission"></see>
    /// </summary>
    let Permission = _prefix "Permission"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/preDuty"></see>
    /// </summary>
    let preDuty = _prefix "preDuty"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/postDuty"></see>
    /// </summary>
    let postDuty = _prefix "postDuty"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/emailAddress"></see>
    /// </summary>
    let emailAddress = _prefix "emailAddress"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/phoneNumber"></see>
    /// </summary>
    let phoneNumber = _prefix "phoneNumber"
    /// <summary>
    /// The class of Prohibitions as defined in the ODRL ontology.
    /// <see href="https://w3id.org/idsa/core/Prohibition"></see></summary>
    let Prohibition = _prefix "Prohibition"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/Proxy"></see>
    /// </summary>
    let Proxy = _prefix "Proxy"
    /// <summary>
    /// URLs that should be excluded from proxying.GNU emcs documentation contains a good explanation for the usage of noProxy.
    /// <see href="https://w3id.org/idsa/core/noProxy"></see></summary>
    let noProxy = _prefix "noProxy"
    /// <summary>
    /// URI of the proxy server.
    /// <see href="https://w3id.org/idsa/core/proxyURI"></see></summary>
    let proxyURI = _prefix "proxyURI"
    /// <summary>
    /// Public key as used in asymmetric cryptography.
    /// <see href="https://w3id.org/idsa/core/PublicKey"></see></summary>
    let PublicKey = _prefix "PublicKey"
    /// <summary>
    /// The ContractAgreement class representing the 'Purpose-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/PurposeAgreement"></see></summary>
    let PurposeAgreement = _prefix "PurposeAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Purpose-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/PurposeOffer"></see></summary>
    let PurposeOffer = _prefix "PurposeOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Purpose-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/PurposeRequest"></see></summary>
    let PurposeRequest = _prefix "PurposeRequest"
    /// <summary>
    /// Query message intended to be consumed by a component.
    /// <see href="https://w3id.org/idsa/core/QueryMessage"></see></summary>
    let QueryMessage = _prefix "QueryMessage"
    /// <summary>
    /// The ContractAgreement class representing the 'Data Rental' policy class.
    /// <see href="https://w3id.org/idsa/core/RentalAgreement"></see></summary>
    let RentalAgreement = _prefix "RentalAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Data Rental' policy class.
    /// <see href="https://w3id.org/idsa/core/RentalOffer"></see></summary>
    let RentalOffer = _prefix "RentalOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Data Rental' policy class.
    /// <see href="https://w3id.org/idsa/core/RentalRequest"></see></summary>
    let RentalRequest = _prefix "RentalRequest"
    /// <summary>
    /// Reference to an instance of given representation, i.e. inline value or file placeholder.
    /// <see href="https://w3id.org/idsa/core/instance"></see></summary>
    let instance = _prefix "instance"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/RequestInProcessMessage"></see>
    /// </summary>
    let RequestInProcessMessage = _prefix "RequestInProcessMessage"
    /// <summary>
    /// Reference to a Resource (physically or logically) included, definition of part-whole hierarchies.
    /// <see href="https://w3id.org/idsa/core/resourcePart"></see></summary>
    let resourcePart = _prefix "resourcePart"
    /// <summary>
    /// Reference to the Endpoints serving the resource's content or let you exchange messages with an IDS Connector.
    /// <see href="https://w3id.org/idsa/core/resourceEndpoint"></see></summary>
    let resourceEndpoint = _prefix "resourceEndpoint"
    /// <summary>
    /// Reference to a Contract Offer defining the authorized use of the Resource.
    /// <see href="https://w3id.org/idsa/core/contractOffer"></see></summary>
    let contractOffer = _prefix "contractOffer"
    /// <summary>
    /// Sample Resource instance.
    /// <see href="https://w3id.org/idsa/core/sample"></see></summary>
    let sample = _prefix "sample"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/ResourceCatalog"></see>
    /// </summary>
    let ResourceCatalog = _prefix "ResourceCatalog"
    /// <summary>
    /// A Resource that is part of a resource catalog, indicating an offering (of, e.g., data).
    /// <see href="https://w3id.org/idsa/core/offeredResource"></see></summary>
    let offeredResource = _prefix "offeredResource"
    /// <summary>
    /// A Resource that is part of a resource catalog, indicating a request (of, e.g., data, software,...).
    /// <see href="https://w3id.org/idsa/core/requestedResource"></see></summary>
    let requestedResource = _prefix "requestedResource"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedResource"></see>
    /// </summary>
    let affectedResource = _prefix "affectedResource"
    /// <summary>
    /// Message indicating that a specific resource is unavailable. The same resource may be available again in the future.
    /// <see href="https://w3id.org/idsa/core/ResourceUnavailableMessage"></see></summary>
    let ResourceUnavailableMessage = _prefix "ResourceUnavailableMessage"
    /// <summary>
    /// Message indicating the availability and current description of a specific resource. The resource must be present in the payload of this message.
    /// <see href="https://w3id.org/idsa/core/ResourceUpdateMessage"></see></summary>
    let ResourceUpdateMessage = _prefix "ResourceUpdateMessage"
    /// <summary>
    /// Result messages are intended to annotate the results of a query command.
    /// <see href="https://w3id.org/idsa/core/ResultMessage"></see></summary>
    let ResultMessage = _prefix "ResultMessage"
    /// <summary>
    /// The ContractAgreement class representing the 'Role-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/RolebasedAgreement"></see></summary>
    let RolebasedAgreement = _prefix "RolebasedAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Role-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/RolebasedOffer"></see></summary>
    let RolebasedOffer = _prefix "RolebasedOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Role-restricted Data Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/RolebasedRequest"></see></summary>
    let RolebasedRequest = _prefix "RolebasedRequest"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/constraint"></see>
    /// </summary>
    let constraint_ = _prefix "constraint"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/assigner"></see>
    /// </summary>
    let assigner = _prefix "assigner"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/assignee"></see>
    /// </summary>
    let assignee = _prefix "assignee"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/action"></see>
    /// </summary>
    let action = _prefix "action"
    /// <summary>
    /// The ContractAgreement class representing the Perpetual Data Sale policy class.
    /// <see href="https://w3id.org/idsa/core/SalesAgreement"></see></summary>
    let SalesAgreement = _prefix "SalesAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Perpetual Data Sale' policy class.
    /// <see href="https://w3id.org/idsa/core/SalesOffer"></see></summary>
    let SalesOffer = _prefix "SalesOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Perpetual Data Sale' policy class.
    /// <see href="https://w3id.org/idsa/core/SalesRequest"></see></summary>
    let SalesRequest = _prefix "SalesRequest"
    /// <summary>
    /// The ContractAgreement class representing the 'Security Level Restricted Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/SecurityAgreement"></see></summary>
    let SecurityAgreement = _prefix "SecurityAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Security Level Restricted Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/SecurityOffer"></see></summary>
    let SecurityOffer = _prefix "SecurityOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Security Level Restricted Policy' policy class.
    /// <see href="https://w3id.org/idsa/core/SecurityRequest"></see></summary>
    let SecurityRequest = _prefix "SecurityRequest"
    /// <summary>
    /// An office or other premise at which the organization is located
    /// <see href="https://w3id.org/idsa/core/Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    /// Smart DataApps are executing any kind of necessary data processing or transformation.
    /// <see href="https://w3id.org/idsa/core/SmartDataApp"></see></summary>
    let SmartDataApp = _prefix "SmartDataApp"
    /// <summary>
    /// Resource (at least partially) comprising Software.
    /// <see href="https://w3id.org/idsa/core/SoftwareResource"></see></summary>
    let SoftwareResource = _prefix "SoftwareResource"
    /// <summary>
    /// The ContractAgreement class representing the 'Location Restricted Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/SpatialAgreement"></see></summary>
    let SpatialAgreement = _prefix "SpatialAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Location Restricted Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/SpatialOffer"></see></summary>
    let SpatialOffer = _prefix "SpatialOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Location Restricted Usage' policy class.
    /// <see href="https://w3id.org/idsa/core/SpatialRequest"></see></summary>
    let SpatialRequest = _prefix "SpatialRequest"
    /// <summary>
    /// The ContractAgreement class representing the 'Data Swap' policy class.
    /// <see href="https://w3id.org/idsa/core/SwapAgreement"></see></summary>
    let SwapAgreement = _prefix "SwapAgreement"
    /// <summary>
    /// The ContractOffer class representing the 'Data Swap' policy class.
    /// <see href="https://w3id.org/idsa/core/SwapOffer"></see></summary>
    let SwapOffer = _prefix "SwapOffer"
    /// <summary>
    /// The ContractRequest class representing the 'Data Swap' policy class.
    /// <see href="https://w3id.org/idsa/core/SwapRequest"></see></summary>
    let SwapRequest = _prefix "SwapRequest"
    /// <summary>
    /// Data Apps that integrate sources and sinks of digital content maintained internally on Participant's premises with a Connector.
    /// <see href="https://w3id.org/idsa/core/SystemAdapter"></see></summary>
    let SystemAdapter = _prefix "SystemAdapter"
    /// <summary>
    /// Representation of a textual content.
    /// <see href="https://w3id.org/idsa/core/TextRepresentation"></see></summary>
    let TextRepresentation = _prefix "TextRepresentation"
    /// <summary>
    /// Resource (at least partially) comprising textual content.
    /// <see href="https://w3id.org/idsa/core/TextResource"></see></summary>
    let TextResource = _prefix "TextResource"
    /// <summary>
    /// An authentication token value like JSON Web Token.
    /// <see href="https://w3id.org/idsa/core/tokenValue"></see></summary>
    let tokenValue = _prefix "tokenValue"
    /// <summary>
    /// Hardened implementation of the Connector specification providing enhanced security capabilities.
    /// <see href="https://w3id.org/idsa/core/TrustedConnector"></see></summary>
    let TrustedConnector = _prefix "TrustedConnector"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/UsageControlObject"></see>
    /// </summary>
    let UsageControlObject = _prefix "UsageControlObject"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/data"></see>
    /// </summary>
    let data = _prefix "data"
    /// <summary>
    /// The target contract defining the usage of the data object.
    /// <see href="https://w3id.org/idsa/core/contract"></see></summary>
    let contract = _prefix "contract"
    /// <summary>
    /// The date of the creation of the Digital Content. In contrast to the ids:temporalCoverage, creation dates of ids:Representation, ids:Artifacts or any other form of meta-data, this property describes the creation date of referenced Digital Content itself.
    /// <see href="https://w3id.org/idsa/core/created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// The list of combined current states of the data object.
    /// <see href="https://w3id.org/idsa/core/hasState"></see></summary>
    let hasState = _prefix "hasState"
    /// <summary>
    /// Video representation
    /// <see href="https://w3id.org/idsa/core/VideoRepresentation"></see></summary>
    let VideoRepresentation = _prefix "VideoRepresentation"
    /// <summary>
    /// Resource (at least partially) comprising video content.
    /// <see href="https://w3id.org/idsa/core/VideoResource"></see></summary>
    let VideoResource = _prefix "VideoResource"
    /// <summary>
    /// Access URL of an endpoint.
    /// <see href="https://w3id.org/idsa/core/accessURL"></see></summary>
    let accessURL = _prefix "accessURL"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/accessed"></see>
    /// </summary>
    let accessed = _prefix "accessed"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/accrualPeriodicity"></see>
    /// </summary>
    let accrualPeriodicity = _prefix "accrualPeriodicity"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/affectedDataApp"></see>
    /// </summary>
    let affectedDataApp = _prefix "affectedDataApp"
    /// <summary>
    /// text documentation of the data app
    /// <see href="https://w3id.org/idsa/core/appDocumentation"></see></summary>
    let appDocumentation = _prefix "appDocumentation"
    /// <summary>
    /// Mediatype, such as IANA types, of the data an endpoint expects or returns .
    /// <see href="https://w3id.org/idsa/core/appEndpointMediaType"></see></summary>
    let appEndpointMediaType = _prefix "appEndpointMediaType"
    /// <summary>
    /// Port used to access the endpoint.
    /// <see href="https://w3id.org/idsa/core/appEndpointPort"></see></summary>
    let appEndpointPort = _prefix "appEndpointPort"
    /// <summary>
    /// Constraint that refines a (composite) Digital Content.
    /// Conditions which specify whether an arbitrary ids:Asset is a member of this AssetCollection.
    /// <see href="https://w3id.org/idsa/core/assetRefinement"></see></summary>
    let assetRefinement = _prefix "assetRefinement"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/assetSource"></see>
    /// </summary>
    let assetSource = _prefix "assetSource"
    /// <summary>
    /// Information of the authentication service used by the Connector.
    /// <see href="https://w3id.org/idsa/core/authInfo"></see></summary>
    let authInfo = _prefix "authInfo"
    /// <summary>
    /// Username / ID used for authentication.
    /// <see href="https://w3id.org/idsa/core/authPassword"></see></summary>
    let authPassword = _prefix "authPassword"
    /// <summary>
    /// The standard used by the authentication service that is provided by the Connector.
    /// <see href="https://w3id.org/idsa/core/authStandard"></see></summary>
    let authStandard = _prefix "authStandard"
    /// <summary>
    /// Username / ID used for authentication.
    /// <see href="https://w3id.org/idsa/core/authUsername"></see></summary>
    let authUsername = _prefix "authUsername"
    /// <summary>
    /// An authorization token like JSON Web Token.
    /// <see href="https://w3id.org/idsa/core/authorizationToken"></see></summary>
    let authorizationToken = _prefix "authorizationToken"
    /// <summary>
    /// Size of the Artifact in bytes.
    /// <see href="https://w3id.org/idsa/core/byteSize"></see></summary>
    let byteSize = _prefix "byteSize"
    /// <summary>
    /// Checksum of the artifact
    /// <see href="https://w3id.org/idsa/core/checkSum"></see></summary>
    let checkSum = _prefix "checkSum"
    /// <summary>
    /// Certification issued for the given Infrastructure Component.
    /// <see href="https://w3id.org/idsa/core/componentCertification"></see></summary>
    let componentCertification = _prefix "componentCertification"
    /// <summary>
    /// References to Connector which is deployed / maintained in the Configuration Model
    /// <see href="https://w3id.org/idsa/core/connectorDescription"></see></summary>
    let connectorDescription = _prefix "connectorDescription"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/consumer"></see>
    /// </summary>
    let consumer = _prefix "consumer"
    /// <summary>
    /// IRI containing document, which defines the standard for the given Digital Content. The content is assumed to conform to that Standard.
    /// <see href="https://w3id.org/idsa/core/contentStandard"></see></summary>
    let contentStandard = _prefix "contentStandard"
    /// <summary>
    /// Detailed type, genre or interpretation of the Digital Content.
    /// <see href="https://w3id.org/idsa/core/contentType"></see></summary>
    let contentType = _prefix "contentType"
    /// <summary>
    /// Version of the content in the payload. Use digits and semantic versioning pattern like MAJOR.MINOR.PATCH.
    /// <see href="https://w3id.org/idsa/core/contentVersion"></see></summary>
    let contentVersion = _prefix "contentVersion"
    /// <summary>
    /// Any type of resource related to the Contract.
    /// <see href="https://w3id.org/idsa/core/contractAnnex"></see></summary>
    let contractAnnex = _prefix "contractAnnex"
    /// <summary>
    /// Absolute datetime of singing the Contract.
    /// <see href="https://w3id.org/idsa/core/contractDate"></see></summary>
    let contractDate = _prefix "contractDate"
    /// <summary>
    /// Equivalent human-readable encoding of this machine-interpretable Contract.
    /// <see href="https://w3id.org/idsa/core/contractDocument"></see></summary>
    let contractDocument = _prefix "contractDocument"
    /// <summary>
    /// Absolute datetime the Contract is requested, offered or expected to end. If omitted, the contract has to be explicitly terminated by any of the parties.
    /// <see href="https://w3id.org/idsa/core/contractEnd"></see></summary>
    let contractEnd = _prefix "contractEnd"
    /// <summary>
    /// Human-readable text describing the reason for contract rejection.
    /// <see href="https://w3id.org/idsa/core/contractRejectionReason"></see></summary>
    let contractRejectionReason = _prefix "contractRejectionReason"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/corporateHomepage"></see>
    /// </summary>
    let corporateHomepage = _prefix "corporateHomepage"
    /// <summary>
    /// Date (as xsd:dateTimeStamp) when the artifact was created, i.e. persisted.
    /// <see href="https://w3id.org/idsa/core/creationDate"></see></summary>
    let creationDate = _prefix "creationDate"
    /// <summary>
    /// URL reference to a custom license regulating the general usage of the Resource.
    /// <see href="https://w3id.org/idsa/core/customLicense"></see></summary>
    let customLicense = _prefix "customLicense"
    /// <summary>
    /// Information about the concrete data app implementation
    /// <see href="https://w3id.org/idsa/core/dataAppInformation"></see></summary>
    let dataAppInformation = _prefix "dataAppInformation"
    /// <summary>
    /// Indicates the data type of the Representation.
    /// <see href="https://w3id.org/idsa/core/dataType"></see></summary>
    let dataType = _prefix "dataType"
    /// <summary>
    /// Indicates the data type schema of the Representation.
    /// <see href="https://w3id.org/idsa/core/dataTypeSchema"></see></summary>
    let dataTypeSchema = _prefix "dataTypeSchema"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/dateTime"></see>
    /// </summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    /// Default representation of the content.
    /// <see href="https://w3id.org/idsa/core/defaultRepresentation"></see></summary>
    let defaultRepresentation = _prefix "defaultRepresentation"
    /// <summary>
    /// Duration of the media resource in seconds.
    /// <see href="https://w3id.org/idsa/core/duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// End of an Interval.
    /// <see href="https://w3id.org/idsa/core/end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    /// Content instance mediated via this individual endpoint (1:1 mapping).
    /// <see href="https://w3id.org/idsa/core/endpointArtifact"></see></summary>
    let endpointArtifact = _prefix "endpointArtifact"
    /// <summary>
    /// Evaluation Facility that performed and issued given Certification
    /// <see href="https://w3id.org/idsa/core/evaluationFacility"></see></summary>
    let evaluationFacility = _prefix "evaluationFacility"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/familyName"></see>
    /// </summary>
    let familyName = _prefix "familyName"
    /// <summary>
    /// Name of the Artifcat file.
    /// <see href="https://w3id.org/idsa/core/fileName"></see></summary>
    let fileName = _prefix "fileName"
    /// <summary>
    /// Suffix of a file name, typically separated by a period, indicating the nature and intended processing of the file.
    /// <see href="https://w3id.org/idsa/core/filenameExtension"></see></summary>
    let filenameExtension = _prefix "filenameExtension"
    /// <summary>
    /// Video frame rate, as frames/second.
    /// <see href="https://w3id.org/idsa/core/frameRate"></see></summary>
    let frameRate = _prefix "frameRate"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/givenName"></see>
    /// </summary>
    let givenName = _prefix "givenName"
    /// <summary>
    /// Height of the visible frame.
    /// <see href="https://w3id.org/idsa/core/height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/homepage"></see>
    /// </summary>
    let homepage = _prefix "homepage"
    /// <summary>
    /// HTTP authentication URI.
    /// <see href="https://w3id.org/idsa/core/httpAuthURI"></see></summary>
    let httpAuthURI = _prefix "httpAuthURI"
    /// <summary>
    /// Relative path used for inbound communication via this endpoint, i.e. input messages and faults only.
    /// <see href="https://w3id.org/idsa/core/inboundPath"></see></summary>
    let inboundPath = _prefix "inboundPath"
    /// <summary>
    /// The subject transitively asserts the object Action.
    /// <see href="https://w3id.org/idsa/core/includedIn"></see></summary>
    let includedIn = _prefix "includedIn"
    /// <summary>
    /// URI of the key store server.
    /// <see href="https://w3id.org/idsa/core/keyStore"></see></summary>
    let keyStore = _prefix "keyStore"
    /// <summary>
    /// Type of the public key.
    /// <see href="https://w3id.org/idsa/core/keyType"></see></summary>
    let keyType = _prefix "keyType"
    /// <summary>
    /// Binary representation of the key.
    /// <see href="https://w3id.org/idsa/core/keyValue"></see></summary>
    let keyValue = _prefix "keyValue"
    /// <summary>
    /// Last date (as xsd:dateTimeStamp) the given Certification is considered valid.
    /// <see href="https://w3id.org/idsa/core/lastValidDate"></see></summary>
    let lastValidDate = _prefix "lastValidDate"
    /// <summary>
    /// Media Type of the Representation.
    /// <see href="https://w3id.org/idsa/core/mediaType"></see></summary>
    let mediaType = _prefix "mediaType"
    /// <summary>
    /// End of the participant's IDS membership.
    /// <see href="https://w3id.org/idsa/core/membershipEnd"></see></summary>
    let membershipEnd = _prefix "membershipEnd"
    /// <summary>
    /// The date/time this Digital Content has been changed the last time. Only one 'modified' attribute is usually needed.
    /// <see href="https://w3id.org/idsa/core/modified"></see></summary>
    let modified = _prefix "modified"
    /// <summary>
    /// Relative path used for outbound communication via this endpoint, i.e. output messages and faults only.
    /// <see href="https://w3id.org/idsa/core/outboundPath"></see></summary>
    let outboundPath = _prefix "outboundPath"
    /// <summary>
    /// Certification issued for the given Participant.
    /// <see href="https://w3id.org/idsa/core/participantCertification"></see></summary>
    let participantCertification = _prefix "participantCertification"
    /// <summary>
    /// Conditions which needs to be satisfied that a single Participant can be seen as a member of the subject Participant. For instance, all Participants with their headquarter in Europe might be a potential consumer of GDPR-releated data.
    /// <see href="https://w3id.org/idsa/core/participantRefinement"></see></summary>
    let participantRefinement = _prefix "participantRefinement"
    /// <summary>
    /// Relative path, topic or queue at which the content is published by the related host.
    /// <see href="https://w3id.org/idsa/core/path"></see></summary>
    let path = _prefix "path"
    /// <summary>
    /// The location where the Connector is physically deployed.
    /// <see href="https://w3id.org/idsa/core/physicalLocation"></see></summary>
    let physicalLocation = _prefix "physicalLocation"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/pipEndpoint"></see>
    /// </summary>
    let pipEndpoint = _prefix "pipEndpoint"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/primarySite"></see>
    /// </summary>
    let primarySite = _prefix "primarySite"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/provider"></see>
    /// </summary>
    let provider = _prefix "provider"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/proxyAuthentication"></see>
    /// </summary>
    let proxyAuthentication = _prefix "proxyAuthentication"
    /// <summary>
    /// Public Key that has been created for the Component.
    /// <see href="https://w3id.org/idsa/core/publicKey"></see></summary>
    let publicKey = _prefix "publicKey"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/publisher"></see>
    /// </summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// This property specifies the language of the query.
    /// <see href="https://w3id.org/idsa/core/queryLanguage"></see></summary>
    let queryLanguage = _prefix "queryLanguage"
    /// <summary>
    /// Refers to the scope property of a query message, see ids:QueryScope.
    /// <see href="https://w3id.org/idsa/core/queryScope"></see></summary>
    let queryScope = _prefix "queryScope"
    /// <summary>
    /// Refers to the target property of a query message, see ids:QueryTarget.
    /// <see href="https://w3id.org/idsa/core/recipientScope"></see></summary>
    let recipientScope = _prefix "recipientScope"
    /// <summary>
    /// Specifies the reason of the rejection.
    /// <see href="https://w3id.org/idsa/core/rejectionReason"></see></summary>
    let rejectionReason = _prefix "rejectionReason"
    /// <summary>
    /// Standards document defining the given Representation (in contrast to general Resource content). The Representation is assumed to conform to that Standard.
    /// <see href="https://w3id.org/idsa/core/representationStandard"></see></summary>
    let representationStandard = _prefix "representationStandard"
    /// <summary>
    /// The element whose metadata is requested.
    /// <see href="https://w3id.org/idsa/core/requestedElement"></see></summary>
    let requestedElement = _prefix "requestedElement"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/requester"></see>
    /// </summary>
    let requester = _prefix "requester"
    /// <summary>
    /// Plain Text containing the reason for revoking an existing certificate of either a connector or participant.
    /// <see href="https://w3id.org/idsa/core/revocationReason"></see></summary>
    let revocationReason = _prefix "revocationReason"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/rightOperand"></see>
    /// </summary>
    let rightOperand = _prefix "rightOperand"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/rightOperandReference"></see>
    /// </summary>
    let rightOperandReference = _prefix "rightOperandReference"
    /// <summary>
    /// Configuration details (e.g. contents of a config file) used to configure the route. Should be Base64 encoded.
    /// <see href="https://w3id.org/idsa/core/routeConfiguration"></see></summary>
    let routeConfiguration = _prefix "routeConfiguration"
    /// <summary>
    /// Route description.
    /// <see href="https://w3id.org/idsa/core/routeDescription"></see></summary>
    let routeDescription = _prefix "routeDescription"
    /// <summary>
    /// Audio sampling rate.
    /// <see href="https://w3id.org/idsa/core/samplingRate"></see></summary>
    let samplingRate = _prefix "samplingRate"
    /// <summary>
    /// Reference to SHACL shape graph, which describes domain-specific knowledge.
    /// <see href="https://w3id.org/idsa/core/shapesGraph"></see></summary>
    let shapesGraph = _prefix "shapesGraph"
    /// <summary>
    /// Indicates an address for the site.
    /// <see href="https://w3id.org/idsa/core/siteAddress"></see></summary>
    let siteAddress = _prefix "siteAddress"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/sovereign"></see>
    /// </summary>
    let sovereign = _prefix "sovereign"
    /// <summary>
    ///
    ///     Reference to a well-known License regulating the general usage of the Resource.
    ///     Check wikidata license documentation for an extensive list of licenses.
    ///     License IRI should refer to the direct of link for a given standard license,
    ///     e.g., MIT license (https://www.wikidata.org/wiki/Q334661). The label of the resolved wikidata license IRI can be used to
    ///     present the license in human-readable form.
    ///
    /// <see href="https://w3id.org/idsa/core/standardLicense"></see></summary>
    let standardLicense = _prefix "standardLicense"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/target"></see>
    /// </summary>
    let target = _prefix "target"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/temporalResolution"></see>
    /// </summary>
    let temporalResolution = _prefix "temporalResolution"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/transferContract"></see>
    /// </summary>
    let transferContract = _prefix "transferContract"
    /// <summary>
    /// URI of the trust store server.
    /// <see href="https://w3id.org/idsa/core/trustStore"></see></summary>
    let trustStore = _prefix "trustStore"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/unit"></see>
    /// </summary>
    let unit = _prefix "unit"
    /// <summary>
    ///   <see href="https://w3id.org/idsa/core/usageDuration"></see>
    /// </summary>
    let usageDuration = _prefix "usageDuration"
    /// <summary>
    /// The participant intending to use the data.
    /// <see href="https://w3id.org/idsa/core/user"></see></summary>
    let user = _prefix "user"
    /// <summary>
    /// (Equivalent) variant of given Resource, e.g. a translation.
    /// <see href="https://w3id.org/idsa/core/variant"></see></summary>
    let variant = _prefix "variant"
    /// <summary>
    /// Version identifier of the Managed Entity
    /// <see href="https://w3id.org/idsa/core/version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// Width of the visible frame.
    /// <see href="https://w3id.org/idsa/core/width"></see></summary>
    let width = _prefix "width"
