namespace https.w3id.org.idsa.core.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ids =
    let _namespace_iri = Namespace_Iri ids |> NamespaceIRI

    /// <summary>
    ///   <para>ids:transportCertsSha256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Separate certificates for IDS identification and transport encryption opens an attack vector for relay attacks. In order to prevent these attacks, a binding of this transport certificates to the connector is required. The inclusion of SHA256 fingerprints of currently valid transport certificates, mainly into the DAT, enables the client to relate the transport layer security with the IDS interactions.</para>
    /// labels<para>transportCertsSha256</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/transportCertsSha256">https://w3id.org/idsa/core/transportCertsSha256</seealso>
    let transportCertsSha256 =
        Prefixed_Name(ids, "transportCertsSha256") |> PrefixedName

    /// <summary>
    ///   <para>ids:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Currently, the scope is limited to 'Connector' but can be used for scoping purposes in the future. Scope is currently fixed to 'https://w3id.org/idsa/core/Connector'.</para>
    /// labels<para>scope</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/scope">https://w3id.org/idsa/core/scope</seealso>
    let scope = Prefixed_Name(ids, "scope") |> PrefixedName
    /// <summary>
    ///   <para>ids:exp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'exp' (expiration time) claim identifies the expiration time on or after which the JWT MUST NOT be accepted for processing.</para>
    /// labels<para>exp</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/exp">https://w3id.org/idsa/core/exp</seealso>
    let exp = Prefixed_Name(ids, "exp") |> PrefixedName
    /// <summary>
    ///   <para>ids:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class of Licences to be referred to by Resources.</para>
    /// labels<para>License</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/License">https://w3id.org/idsa/core/License</seealso>
    let License = Prefixed_Name(ids, "License") |> PrefixedName
    /// <summary>
    ///   <para>ids:LogMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Log Message which can be used to transfer logs e.g. to the clearing house.</para>
    /// labels<para>Log Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/LogMessage">https://w3id.org/idsa/core/LogMessage</seealso>
    let LogMessage = Prefixed_Name(ids, "LogMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:standardLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     Reference to a well-known License regulating the general usage of the Resource.
    ///     Check wikidata license documentation for an extensive list of licenses.
    ///     License IRI should refer to the direct of link for a given standard license,
    ///     e.g., MIT license (https://www.wikidata.org/wiki/Q334661). The label of the resolved wikidata license IRI can be used to
    ///     present the license in human-readable form.
    ///     </para>
    /// labels<para>Standard License</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/standardLicense">https://w3id.org/idsa/core/standardLicense</seealso>
    let standardLicense = Prefixed_Name(ids, "standardLicense") |> PrefixedName
    /// <summary>
    ///   <para>ids:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/target">https://w3id.org/idsa/core/target</seealso>
    let target = Prefixed_Name(ids, "target") |> PrefixedName
    /// <summary>
    ///   <para>ids:RequestMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Client-generated message initiating a communication, motivated by a certain reason and with an answer expected.</para>
    /// labels<para>Request Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RequestMessage">https://w3id.org/idsa/core/RequestMessage</seealso>
    let RequestMessage = Prefixed_Name(ids, "RequestMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Internal or external Agent interacting with the Industrial Data Space, not necessarily an IDS Participant.</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Agent">https://w3id.org/idsa/core/Agent</seealso>
    let Agent = Prefixed_Name(ids, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>ids:Described</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Described">https://w3id.org/idsa/core/Described</seealso>
    let Described = Prefixed_Name(ids, "Described") |> PrefixedName
    /// <summary>
    ///   <para>ids:postDuty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/postDuty">https://w3id.org/idsa/core/postDuty</seealso>
    let postDuty = Prefixed_Name(ids, "postDuty") |> PrefixedName
    /// <summary>
    ///   <para>ids:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Person">https://w3id.org/idsa/core/Person</seealso>
    let Person = Prefixed_Name(ids, "Person") |> PrefixedName
    /// <summary>
    ///   <para>ids:Proxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Proxy">https://w3id.org/idsa/core/Proxy</seealso>
    let Proxy = Prefixed_Name(ids, "Proxy") |> PrefixedName
    /// <summary>
    ///   <para>ids:proxyURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URI of the proxy server.</para>
    /// labels<para>proxy URI</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/proxyURI">https://w3id.org/idsa/core/proxyURI</seealso>
    let proxyURI = Prefixed_Name(ids, "proxyURI") |> PrefixedName
    /// <summary>
    ///   <para>ids:PurposeAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Purpose-restricted Data Usage' policy class.</para>
    /// labels<para>Purpose Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/PurposeAgreement">https://w3id.org/idsa/core/PurposeAgreement</seealso>
    let PurposeAgreement = Prefixed_Name(ids, "PurposeAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:appRouteStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Start of a route.</para>
    /// labels<para>app route start</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/appRouteStart">https://w3id.org/idsa/core/appRouteStart</seealso>
    let appRouteStart = Prefixed_Name(ids, "appRouteStart") |> PrefixedName
    /// <summary>
    ///   <para>ids:Connector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Connector">https://w3id.org/idsa/core/Connector</seealso>
    let Connector = Prefixed_Name(ids, "Connector") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppUnavailableMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message indicating that a specific App should be unavailable in the AppStore.</para>
    /// labels<para>App Unavailable Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppUnavailableMessage">https://w3id.org/idsa/core/AppUnavailableMessage</seealso>
    let AppUnavailableMessage =
        Prefixed_Name(ids, "AppUnavailableMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ArtifactRequestMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ArtifactRequestMessage">https://w3id.org/idsa/core/ArtifactRequestMessage</seealso>
    let ArtifactRequestMessage =
        Prefixed_Name(ids, "ArtifactRequestMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:requestedArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/requestedArtifact">https://w3id.org/idsa/core/requestedArtifact</seealso>
    let requestedArtifact = Prefixed_Name(ids, "requestedArtifact") |> PrefixedName

    /// <summary>
    ///   <para>ids:ArtifactResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message that follows up a RetrieveArtifact Message and contains the Artifact's data in the payload section.</para>
    /// labels<para>Artifact Response Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ArtifactResponseMessage">https://w3id.org/idsa/core/ArtifactResponseMessage</seealso>
    let ArtifactResponseMessage =
        Prefixed_Name(ids, "ArtifactResponseMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:SpatialRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Location Restricted Usage' policy class.</para>
    /// labels<para>Spatial Usage Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SpatialRequest">https://w3id.org/idsa/core/SpatialRequest</seealso>
    let SpatialRequest = Prefixed_Name(ids, "SpatialRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:Endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Endpoint">https://w3id.org/idsa/core/Endpoint</seealso>
    let Endpoint = Prefixed_Name(ids, "Endpoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:SecurityGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Security guarantee claimed by a security profile.</para>
    /// labels<para>Security guarantee</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SecurityGuarantee">https://w3id.org/idsa/core/SecurityGuarantee</seealso>
    let SecurityGuarantee = Prefixed_Name(ids, "SecurityGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:ResourceUpdateMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message indicating the availability and current description of a specific resource. The resource must be present in the payload of this message.</para>
    /// labels<para>Resource Update Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ResourceUpdateMessage">https://w3id.org/idsa/core/ResourceUpdateMessage</seealso>
    let ResourceUpdateMessage =
        Prefixed_Name(ids, "ResourceUpdateMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/constraint">https://w3id.org/idsa/core/constraint</seealso>
    let constraint_ = Prefixed_Name(ids, "constraint") |> PrefixedName
    /// <summary>
    ///   <para>ids:SalesOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Perpetual Data Sale' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SalesOffer">https://w3id.org/idsa/core/SalesOffer</seealso>
    let SalesOffer = Prefixed_Name(ids, "SalesOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:SalesRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Perpetual Data Sale' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SalesRequest">https://w3id.org/idsa/core/SalesRequest</seealso>
    let SalesRequest = Prefixed_Name(ids, "SalesRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:IDSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>International Data Spaces Association</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/IDSA">https://w3id.org/idsa/core/IDSA</seealso>
    let IDSA = Prefixed_Name(ids, "IDSA") |> PrefixedName

    /// <summary>
    ///   <para>ids:requestedParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/requestedParticipant">https://w3id.org/idsa/core/requestedParticipant</seealso>
    let requestedParticipant =
        Prefixed_Name(ids, "requestedParticipant") |> PrefixedName

    /// <summary>
    ///   <para>ids:preDuty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/preDuty">https://w3id.org/idsa/core/preDuty</seealso>
    let preDuty = Prefixed_Name(ids, "preDuty") |> PrefixedName
    /// <summary>
    ///   <para>ids:emailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/emailAddress">https://w3id.org/idsa/core/emailAddress</seealso>
    let emailAddress = Prefixed_Name(ids, "emailAddress") |> PrefixedName
    /// <summary>
    ///   <para>ids:noProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URLs that should be excluded from proxying.GNU emcs documentation contains a good explanation for the usage of noProxy.</para>
    /// labels<para>no proxy</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/noProxy">https://w3id.org/idsa/core/noProxy</seealso>
    let noProxy = Prefixed_Name(ids, "noProxy") |> PrefixedName
    /// <summary>
    ///   <para>ids:PublicKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Public key as used in asymmetric cryptography.</para>
    /// labels<para>Public Key</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/PublicKey">https://w3id.org/idsa/core/PublicKey</seealso>
    let PublicKey = Prefixed_Name(ids, "PublicKey") |> PrefixedName
    /// <summary>
    ///   <para>ids:QueryMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Query message intended to be consumed by a component.</para>
    /// labels<para>Query Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/QueryMessage">https://w3id.org/idsa/core/QueryMessage</seealso>
    let QueryMessage = Prefixed_Name(ids, "QueryMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to an instance of given representation, i.e. inline value or file placeholder.</para>
    /// labels<para>instance</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/instance">https://w3id.org/idsa/core/instance</seealso>
    let instance = Prefixed_Name(ids, "instance") |> PrefixedName

    /// <summary>
    ///   <para>ids:RequestInProcessMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/RequestInProcessMessage">https://w3id.org/idsa/core/RequestInProcessMessage</seealso>
    let RequestInProcessMessage =
        Prefixed_Name(ids, "RequestInProcessMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sample Resource instance.</para>
    /// labels<para>sample</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/sample">https://w3id.org/idsa/core/sample</seealso>
    let sample = Prefixed_Name(ids, "sample") |> PrefixedName
    /// <summary>
    ///   <para>ids:ResourceCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ResourceCatalog">https://w3id.org/idsa/core/ResourceCatalog</seealso>
    let ResourceCatalog = Prefixed_Name(ids, "ResourceCatalog") |> PrefixedName
    /// <summary>
    ///   <para>ids:ResultMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Result messages are intended to annotate the results of a query command. </para>
    /// labels<para>Result Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ResultMessage">https://w3id.org/idsa/core/ResultMessage</seealso>
    let ResultMessage = Prefixed_Name(ids, "ResultMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppRegistrationRequestMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message that asks for registration or update of a data app to the App Store. Payload contains app-related metadata (instance of class ids:AppResource). Message header may contain an app identifier parameter of a prior registered data app. If the app identifier is supplied, the message should be interpreted as a registration for an app update. Otherwise this message is used to register a new app. </para>
    /// labels<para>App Registration Request Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppRegistrationRequestMessage">https://w3id.org/idsa/core/AppRegistrationRequestMessage</seealso>
    let AppRegistrationRequestMessage =
        Prefixed_Name(ids, "AppRegistrationRequestMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:subRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Route between two or more app endpoints inside a app routing pipeline.</para>
    /// labels<para>sub route</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/subRoute">https://w3id.org/idsa/core/subRoute</seealso>
    let subRoute = Prefixed_Name(ids, "subRoute") |> PrefixedName
    /// <summary>
    ///   <para>ids:appRouteEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>End of a route.</para>
    /// labels<para>app route end</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/appRouteEnd">https://w3id.org/idsa/core/appRouteEnd</seealso>
    let appRouteEnd = Prefixed_Name(ids, "appRouteEnd") |> PrefixedName
    /// <summary>
    ///   <para>ids:AppStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Secure platform for distributing Data Apps.</para>
    /// labels<para>App Store</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppStore">https://w3id.org/idsa/core/AppStore</seealso>
    let AppStore = Prefixed_Name(ids, "AppStore") |> PrefixedName

    /// <summary>
    ///   <para>ids:ConnectorNotificationMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorNotificationMessage">https://w3id.org/idsa/core/ConnectorNotificationMessage</seealso>
    let ConnectorNotificationMessage =
        Prefixed_Name(ids, "ConnectorNotificationMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ConnectorCertificateRevokedMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates that a (previously certified) Connector is no more certified. This could happen, for instance, if the Certification Body revokes a granted certificate or if the certificate just expires.</para>
    /// labels<para>Connector Certificate Revoked Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorCertificateRevokedMessage">https://w3id.org/idsa/core/ConnectorCertificateRevokedMessage</seealso>
    let ConnectorCertificateRevokedMessage =
        Prefixed_Name(ids, "ConnectorCertificateRevokedMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ConnectorUnavailableMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event notifying the recipient(s) that a connector will be unavailable. The same connector may be available again in the future.</para>
    /// labels<para>Connector Unavailable Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorUnavailableMessage">https://w3id.org/idsa/core/ConnectorUnavailableMessage</seealso>
    let ConnectorUnavailableMessage =
        Prefixed_Name(ids, "ConnectorUnavailableMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contract issued by the Data Provider offering the usage of a Resource at particular conditions.</para>
    /// labels<para>Contract offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractOffer">https://w3id.org/idsa/core/ContractOffer</seealso>
    let ContractOffer = Prefixed_Name(ids, "ContractOffer") |> PrefixedName

    /// <summary>
    ///   <para>ids:ConnectorbasedRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Connector-restricted Data Usage' policy class.</para>
    /// labels<para>Connector-restricted Data Usage Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorbasedRequest">https://w3id.org/idsa/core/ConnectorbasedRequest</seealso>
    let ConnectorbasedRequest =
        Prefixed_Name(ids, "ConnectorbasedRequest") |> PrefixedName

    /// <summary>
    ///   <para>ids:SecurityAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Security Level Restricted Policy' policy class.</para>
    /// labels<para>Security Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SecurityAgreement">https://w3id.org/idsa/core/SecurityAgreement</seealso>
    let SecurityAgreement = Prefixed_Name(ids, "SecurityAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:SecurityRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Security Level Restricted Policy' policy class.</para>
    /// labels<para>Security Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SecurityRequest">https://w3id.org/idsa/core/SecurityRequest</seealso>
    let SecurityRequest = Prefixed_Name(ids, "SecurityRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:authService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/authService">https://w3id.org/idsa/core/authService</seealso>
    let authService = Prefixed_Name(ids, "authService") |> PrefixedName
    /// <summary>
    ///   <para>ids:BaseConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Implementation of the Connector specification providing only restricted security capabilities.</para>
    /// labels<para>Base Connector</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/BaseConnector">https://w3id.org/idsa/core/BaseConnector</seealso>
    let BaseConnector = Prefixed_Name(ids, "BaseConnector") |> PrefixedName
    /// <summary>
    ///   <para>ids:BasicAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Basic authentication using username / password </para>
    /// labels<para>User Authentication</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/BasicAuthentication">https://w3id.org/idsa/core/BasicAuthentication</seealso>
    let BasicAuthentication = Prefixed_Name(ids, "BasicAuthentication") |> PrefixedName
    /// <summary>
    ///   <para>ids:UserAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/UserAuthentication">https://w3id.org/idsa/core/UserAuthentication</seealso>
    let UserAuthentication = Prefixed_Name(ids, "UserAuthentication") |> PrefixedName
    /// <summary>
    ///   <para>ids:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Geometry">https://w3id.org/idsa/core/Geometry</seealso>
    let Geometry = Prefixed_Name(ids, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>ids:connectorCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to catalog of Connectors, which are listed in the Broker.</para>
    /// labels<para>connector Catalog</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/connectorCatalog">https://w3id.org/idsa/core/connectorCatalog</seealso>
    let connectorCatalog = Prefixed_Name(ids, "connectorCatalog") |> PrefixedName
    /// <summary>
    ///   <para>ids:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Catalog">https://w3id.org/idsa/core/Catalog</seealso>
    let Catalog = Prefixed_Name(ids, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>ids:AuthInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/AuthInfo">https://w3id.org/idsa/core/AuthInfo</seealso>
    let AuthInfo = Prefixed_Name(ids, "AuthInfo") |> PrefixedName
    /// <summary>
    ///   <para>ids:BoundingPolygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/BoundingPolygon">https://w3id.org/idsa/core/BoundingPolygon</seealso>
    let BoundingPolygon = Prefixed_Name(ids, "BoundingPolygon") |> PrefixedName
    /// <summary>
    ///   <para>ids:Broker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Broker">https://w3id.org/idsa/core/Broker</seealso>
    let Broker = Prefixed_Name(ids, "Broker") |> PrefixedName
    /// <summary>
    ///   <para>ids:CertificationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/CertificationLevel">https://w3id.org/idsa/core/CertificationLevel</seealso>
    let CertificationLevel = Prefixed_Name(ids, "CertificationLevel") |> PrefixedName
    /// <summary>
    ///   <para>ids:ClearingHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Clearing House provides clearing and settlement services B2B interactions within the International Data Spaces.</para>
    /// labels<para>Clearing House</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ClearingHouse">https://w3id.org/idsa/core/ClearingHouse</seealso>
    let ClearingHouse = Prefixed_Name(ids, "ClearingHouse") |> PrefixedName

    /// <summary>
    ///   <para>ids:InfrastructureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/InfrastructureComponent">https://w3id.org/idsa/core/InfrastructureComponent</seealso>
    let InfrastructureComponent =
        Prefixed_Name(ids, "InfrastructureComponent") |> PrefixedName

    /// <summary>
    ///   <para>ids:CommandMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/CommandMessage">https://w3id.org/idsa/core/CommandMessage</seealso>
    let CommandMessage = Prefixed_Name(ids, "CommandMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ComponentCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Process and result of certifying a software component/servivce in order to become a certified part of the International Data Space infrastructure.</para>
    /// labels<para>Component Certification</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ComponentCertification">https://w3id.org/idsa/core/ComponentCertification</seealso>
    let ComponentCertification =
        Prefixed_Name(ids, "ComponentCertification") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Process and result of certifying an interested party in order to become a certified member of the International Data Space.</para>
    /// labels<para>Participant Certification</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantCertification">https://w3id.org/idsa/core/ParticipantCertification</seealso>
    let ParticipantCertification =
        Prefixed_Name(ids, "ParticipantCertification") |> PrefixedName

    /// <summary>
    ///   <para>ids:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Concept">https://w3id.org/idsa/core/Concept</seealso>
    let Concept = Prefixed_Name(ids, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>ids:appRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>app route</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/appRoute">https://w3id.org/idsa/core/appRoute</seealso>
    let appRoute = Prefixed_Name(ids, "appRoute") |> PrefixedName
    /// <summary>
    ///   <para>ids:connectorDeployMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Deply mode of a Connector in the Configuration Model</para>
    /// labels<para>connector deploy mode</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/connectorDeployMode">https://w3id.org/idsa/core/connectorDeployMode</seealso>
    let connectorDeployMode = Prefixed_Name(ids, "connectorDeployMode") |> PrefixedName
    /// <summary>
    ///   <para>ids:connectorProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proxies for a Connector which is deployed using the Configuration Model</para>
    /// labels<para>Connector proxy</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/connectorProxy">https://w3id.org/idsa/core/connectorProxy</seealso>
    let connectorProxy = Prefixed_Name(ids, "connectorProxy") |> PrefixedName
    /// <summary>
    ///   <para>ids:hasAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/hasAgent">https://w3id.org/idsa/core/hasAgent</seealso>
    let hasAgent = Prefixed_Name(ids, "hasAgent") |> PrefixedName
    /// <summary>
    ///   <para>ids:resourceCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>References the Catalog of published or requested resource by this Connector.</para>
    /// labels<para>resource catalog</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/resourceCatalog">https://w3id.org/idsa/core/resourceCatalog</seealso>
    let resourceCatalog = Prefixed_Name(ids, "resourceCatalog") |> PrefixedName
    /// <summary>
    ///   <para>ids:hasEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to the Endpoints serving the resource's content or let you exchange messages with an IDS Connector.</para>
    /// labels<para>has endpoint</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/hasEndpoint">https://w3id.org/idsa/core/hasEndpoint</seealso>
    let hasEndpoint = Prefixed_Name(ids, "hasEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:hasDefaultEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the default endpoint that should be used for basic infrastructure interactions, e.g., providing the self description.</para>
    /// labels<para>has default endpoint</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/hasDefaultEndpoint">https://w3id.org/idsa/core/hasDefaultEndpoint</seealso>
    let hasDefaultEndpoint = Prefixed_Name(ids, "hasDefaultEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:ConnectorCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorCatalog">https://w3id.org/idsa/core/ConnectorCatalog</seealso>
    let ConnectorCatalog = Prefixed_Name(ids, "ConnectorCatalog") |> PrefixedName
    /// <summary>
    ///   <para>ids:listedConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Connector, that is part of a Connector catalog.</para>
    /// labels<para>listed Connector</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/listedConnector">https://w3id.org/idsa/core/listedConnector</seealso>
    let listedConnector = Prefixed_Name(ids, "listedConnector") |> PrefixedName
    /// <summary>
    ///   <para>ids:ConnectorEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorEndpoint">https://w3id.org/idsa/core/ConnectorEndpoint</seealso>
    let ConnectorEndpoint = Prefixed_Name(ids, "ConnectorEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:NotificationMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event messages are informative and no response is expected by the sender.</para>
    /// labels<para>Notification Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/NotificationMessage">https://w3id.org/idsa/core/NotificationMessage</seealso>
    let NotificationMessage = Prefixed_Name(ids, "NotificationMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:affectedConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/affectedConnector">https://w3id.org/idsa/core/affectedConnector</seealso>
    let affectedConnector = Prefixed_Name(ids, "affectedConnector") |> PrefixedName

    /// <summary>
    ///   <para>ids:ConnectorUpdateMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event notifying the recipient(s) about the availability and current configuration of a connector. The payload of the message must contain the updated connector's self-description.</para>
    /// labels<para>Connector Update Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorUpdateMessage">https://w3id.org/idsa/core/ConnectorUpdateMessage</seealso>
    let ConnectorUpdateMessage =
        Prefixed_Name(ids, "ConnectorUpdateMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ConnectorbasedAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Connector-restricted Data Usage' policy class.</para>
    /// labels<para>Connector-restricted Data Usage Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorbasedAgreement">https://w3id.org/idsa/core/ConnectorbasedAgreement</seealso>
    let ConnectorbasedAgreement =
        Prefixed_Name(ids, "ConnectorbasedAgreement") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractAgreement">https://w3id.org/idsa/core/ContractAgreement</seealso>
    let ContractAgreement = Prefixed_Name(ids, "ContractAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:ConnectorbasedOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Connector-restricted Data Usage' policy class.</para>
    /// labels<para>Connector-restricted Data Usage Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorbasedOffer">https://w3id.org/idsa/core/ConnectorbasedOffer</seealso>
    let ConnectorbasedOffer = Prefixed_Name(ids, "ConnectorbasedOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:authPassword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Username / ID used for authentication.</para>
    /// labels<para>auth password</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/authPassword">https://w3id.org/idsa/core/authPassword</seealso>
    let authPassword = Prefixed_Name(ids, "authPassword") |> PrefixedName
    /// <summary>
    ///   <para>ids:authStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The standard used by the authentication service that is provided by the Connector.</para>
    /// labels<para>authStandard</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/authStandard">https://w3id.org/idsa/core/authStandard</seealso>
    let authStandard = Prefixed_Name(ids, "authStandard") |> PrefixedName
    /// <summary>
    ///   <para>ids:geoPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to a GeoPoint that is member of a BoundingPolygon.</para>
    /// labels<para>geoPoint</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/geoPoint">https://w3id.org/idsa/core/geoPoint</seealso>
    let geoPoint = Prefixed_Name(ids, "geoPoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:Certification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Certification">https://w3id.org/idsa/core/Certification</seealso>
    let Certification = Prefixed_Name(ids, "Certification") |> PrefixedName
    /// <summary>
    ///   <para>ids:ManagedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ManagedEntity">https://w3id.org/idsa/core/ManagedEntity</seealso>
    let ManagedEntity = Prefixed_Name(ids, "ManagedEntity") |> PrefixedName
    /// <summary>
    ///   <para>ids:certificationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Level of certification (based on a combination of requierements, evaluation method etc.)</para>
    /// labels<para>certification level</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/certificationLevel">https://w3id.org/idsa/core/certificationLevel</seealso>
    let certificationLevel = Prefixed_Name(ids, "certificationLevel") |> PrefixedName
    /// <summary>
    ///   <para>ids:ConfigurationModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConfigurationModel">https://w3id.org/idsa/core/ConfigurationModel</seealso>
    let ConfigurationModel = Prefixed_Name(ids, "ConfigurationModel") |> PrefixedName
    /// <summary>
    ///   <para>ids:connectorStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Status of a Connector deployed by the Configuration Model</para>
    /// labels<para>Connector Status</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/connectorStatus">https://w3id.org/idsa/core/connectorStatus</seealso>
    let connectorStatus = Prefixed_Name(ids, "connectorStatus") |> PrefixedName

    /// <summary>
    ///   <para>ids:configurationModelLogLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Log level configuration for a Connector which is deployed using the Configuration Model</para>
    /// labels<para>configuration model log level</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/configurationModelLogLevel">https://w3id.org/idsa/core/configurationModelLogLevel</seealso>
    let configurationModelLogLevel =
        Prefixed_Name(ids, "configurationModelLogLevel") |> PrefixedName

    /// <summary>
    ///   <para>ids:userAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>authentication methods allowed in a Configuration Model</para>
    /// labels<para>user authentication</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/userAuthentication">https://w3id.org/idsa/core/userAuthentication</seealso>
    let userAuthentication = Prefixed_Name(ids, "userAuthentication") |> PrefixedName
    /// <summary>
    ///   <para>ids:securityProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The SecurityProfile supported by the Connector.</para>
    /// labels<para>securityProfile</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/securityProfile">https://w3id.org/idsa/core/securityProfile</seealso>
    let securityProfile = Prefixed_Name(ids, "securityProfile") |> PrefixedName
    /// <summary>
    ///   <para>ids:extendedGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to a security guarantee that, if used in combination with a security profile instance, overrides the respective guarantee of the given predefined instance.</para>
    /// labels<para>extended guarantee</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/extendedGuarantee">https://w3id.org/idsa/core/extendedGuarantee</seealso>
    let extendedGuarantee = Prefixed_Name(ids, "extendedGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:ConnectorCertificateGrantedMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Whenever a Connector has been successfully certified by the Certification Body, the Identity Provider can use this message to notify Infrastructure Components.</para>
    /// labels<para>Connector Certificate Granted Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorCertificateGrantedMessage">https://w3id.org/idsa/core/ConnectorCertificateGrantedMessage</seealso>
    let ConnectorCertificateGrantedMessage =
        Prefixed_Name(ids, "ConnectorCertificateGrantedMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:affectedDataApp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/affectedDataApp">https://w3id.org/idsa/core/affectedDataApp</seealso>
    let affectedDataApp = Prefixed_Name(ids, "affectedDataApp") |> PrefixedName
    /// <summary>
    ///   <para>ids:appDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>text documentation of the data app</para>
    /// labels<para>app documentation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/appDocumentation">https://w3id.org/idsa/core/appDocumentation</seealso>
    let appDocumentation = Prefixed_Name(ids, "appDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>ids:appEndpointPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Port used to access the endpoint.</para>
    /// labels<para>app endpoint port</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/appEndpointPort">https://w3id.org/idsa/core/appEndpointPort</seealso>
    let appEndpointPort = Prefixed_Name(ids, "appEndpointPort") |> PrefixedName
    /// <summary>
    ///   <para>ids:assetSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/assetSource">https://w3id.org/idsa/core/assetSource</seealso>
    let assetSource = Prefixed_Name(ids, "assetSource") |> PrefixedName
    /// <summary>
    ///   <para>ids:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class of all frequencies.</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Frequency">https://w3id.org/idsa/core/Frequency</seealso>
    let Frequency = Prefixed_Name(ids, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>ids:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of languages potentially being used by textual Data Assets.</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Language">https://w3id.org/idsa/core/Language</seealso>
    let Language = Prefixed_Name(ids, "Language") |> PrefixedName
    /// <summary>
    ///   <para>ids:LeftOperand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Instances of the LeftOperand class are used as the leftOperand of a Constraint.</para>
    /// labels<para>LeftOperand</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/LeftOperand">https://w3id.org/idsa/core/LeftOperand</seealso>
    let LeftOperand = Prefixed_Name(ids, "LeftOperand") |> PrefixedName
    /// <summary>
    ///   <para>ids:QueryScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class of scopes that may limit the space of query results, e.g. ALL, ACTIVE_ONLY.</para>
    /// labels<para>Query Scope</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/QueryScope">https://w3id.org/idsa/core/QueryScope</seealso>
    let QueryScope = Prefixed_Name(ids, "QueryScope") |> PrefixedName
    /// <summary>
    ///   <para>ids:BinaryOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of binary operators.</para>
    /// labels<para>BinaryOperator</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/BinaryOperator">https://w3id.org/idsa/core/BinaryOperator</seealso>
    let BinaryOperator = Prefixed_Name(ids, "BinaryOperator") |> PrefixedName
    /// <summary>
    ///   <para>ids:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Action">https://w3id.org/idsa/core/Action</seealso>
    let Action = Prefixed_Name(ids, "Action") |> PrefixedName
    /// <summary>
    ///   <para>ids:ArtifactState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state which an ids:Artifact may have or not.</para>
    /// labels<para>Artifact State</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ArtifactState">https://w3id.org/idsa/core/ArtifactState</seealso>
    let ArtifactState = Prefixed_Name(ids, "ArtifactState") |> PrefixedName
    /// <summary>
    ///   <para>ids:QueryTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class of recipients of a query message, e.g. BROKER, APPSTORE, ANY.</para>
    /// labels<para>Query Target</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/QueryTarget">https://w3id.org/idsa/core/QueryTarget</seealso>
    let QueryTarget = Prefixed_Name(ids, "QueryTarget") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppExecutionResources</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource control for deployed services.</para>
    /// labels<para>App execution resources</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppExecutionResources">https://w3id.org/idsa/core/AppExecutionResources</seealso>
    let AppExecutionResources =
        Prefixed_Name(ids, "AppExecutionResources") |> PrefixedName

    /// <summary>
    ///   <para>ids:AuditGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Local audit logging (including integrity protection) is the baseline for auditing and clearing. Remote audit log tracing provides means to do external audit verification.</para>
    /// labels<para>Audit guarantee</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AuditGuarantee">https://w3id.org/idsa/core/AuditGuarantee</seealso>
    let AuditGuarantee = Prefixed_Name(ids, "AuditGuarantee") |> PrefixedName
    /// <summary>
    ///   <para>ids:broader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This LeftOperand is transitively included in the object LeftOperand.</para>
    /// labels<para>broader LeftOperand</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/broader">https://w3id.org/idsa/core/broader</seealso>
    let broader = Prefixed_Name(ids, "broader") |> PrefixedName
    /// <summary>
    ///   <para>ids:ConnectorDeployMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Deploy mode of a Connector. Used mainly to capture a Connectors deployment type in the Configuration Model.</para>
    /// labels<para>Connector Deploy Mode</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorDeployMode">https://w3id.org/idsa/core/ConnectorDeployMode</seealso>
    let ConnectorDeployMode = Prefixed_Name(ids, "ConnectorDeployMode") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractRequestMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message containing a suggested content contract (as offered by the data consumer to the data provider) in the associated payload (which is an instance of ContractRequest).</para>
    /// labels<para>Contract Request Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractRequestMessage">https://w3id.org/idsa/core/ContractRequestMessage</seealso>
    let ContractRequestMessage =
        Prefixed_Name(ids, "ContractRequestMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message containing a response to a contract request (of a data consumer) in form of a counter-proposal of a contract in the associated payload (which is an instance of ContractOffcer). </para>
    /// labels<para>Contract Response Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractResponseMessage">https://w3id.org/idsa/core/ContractResponseMessage</seealso>
    let ContractResponseMessage =
        Prefixed_Name(ids, "ContractResponseMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractSupplementMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message containing supplemental information to access resources of a contract (e.g. resource access tokens).</para>
    /// labels<para>Contract Supplement Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractSupplementMessage">https://w3id.org/idsa/core/ContractSupplementMessage</seealso>
    let ContractSupplementMessage =
        Prefixed_Name(ids, "ContractSupplementMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:CustomMediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A selection of custom media types to be used for data published on the IDS when no IANA type is available.</para>
    /// labels<para>Custom Media Type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/CustomMediaType">https://w3id.org/idsa/core/CustomMediaType</seealso>
    let CustomMediaType = Prefixed_Name(ids, "CustomMediaType") |> PrefixedName
    /// <summary>
    ///   <para>ids:MediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/MediaType">https://w3id.org/idsa/core/MediaType</seealso>
    let MediaType = Prefixed_Name(ids, "MediaType") |> PrefixedName
    /// <summary>
    ///   <para>ids:DAPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Dynamic Attribute Provisioning Service (DAPS) is a component of the Identity Provider and manages and issues the Dynamic Attribute Tokens (DAT), acting as digtial proofs for dynamic attributes of both connectors and participants.</para>
    /// labels<para>Dynamic Attribute Provisioning Service</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DAPS">https://w3id.org/idsa/core/DAPS</seealso>
    let DAPS = Prefixed_Name(ids, "DAPS") |> PrefixedName
    /// <summary>
    ///   <para>ids:DatPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/DatPayload">https://w3id.org/idsa/core/DatPayload</seealso>
    let DatPayload = Prefixed_Name(ids, "DatPayload") |> PrefixedName
    /// <summary>
    ///   <para>ids:JwtPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/JwtPayload">https://w3id.org/idsa/core/JwtPayload</seealso>
    let JwtPayload = Prefixed_Name(ids, "JwtPayload") |> PrefixedName
    /// <summary>
    ///   <para>ids:referringConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/referringConnector">https://w3id.org/idsa/core/referringConnector</seealso>
    let referringConnector = Prefixed_Name(ids, "referringConnector") |> PrefixedName
    /// <summary>
    ///   <para>ids:iss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'iss' (issuer) claim identifies the principal that issued the JWT.</para>
    /// labels<para>iss</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/iss">https://w3id.org/idsa/core/iss</seealso>
    let iss = Prefixed_Name(ids, "iss") |> PrefixedName
    /// <summary>
    ///   <para>ids:DatRequestPayload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Dynamic Attribute Token (DAT) *Request* Payload is the JSON Element of any DAT containing the claims of the token bearer. This payload itself is a JSON-LD encoded RDF class with a defined set of attributes. These attributes are either defined by RFC 7519 or by the IDS Information Model. As a direct consequence of regarding the DAT Payload as JSON-LD, *all* DAT Payloads must have exactly one "@context" attribute with the IDS context URI as its value and a "@type" with ids:DatPayload as its value. Note that, different to the DatPayload, the DatRequestPayload contains the *self-claims* of a connector and is not yet signed by any DAPS. Consequently, no other connector must accept a DatRequest object as a DAT. A DatRequest and its contained DatRequestPayload is *only* intended for interactions with a DAPS and *nothing else*!</para>
    /// labels<para>DAT Request Payload</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DatRequestPayload">https://w3id.org/idsa/core/DatRequestPayload</seealso>
    let DatRequestPayload = Prefixed_Name(ids, "DatRequestPayload") |> PrefixedName
    /// <summary>
    ///   <para>ids:DataApp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/DataApp">https://w3id.org/idsa/core/DataApp</seealso>
    let DataApp = Prefixed_Name(ids, "DataApp") |> PrefixedName
    /// <summary>
    ///   <para>ids:appEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Endpoints of a data app</para>
    /// labels<para>app endpoint</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/appEndpoint">https://w3id.org/idsa/core/appEndpoint</seealso>
    let appEndpoint = Prefixed_Name(ids, "appEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:DataRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Physical representation of (structured) data.</para>
    /// labels<para>Data representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DataRepresentation">https://w3id.org/idsa/core/DataRepresentation</seealso>
    let DataRepresentation = Prefixed_Name(ids, "DataRepresentation") |> PrefixedName
    /// <summary>
    ///   <para>ids:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Explanation of the resource in a natural language text.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/description">https://w3id.org/idsa/core/description</seealso>
    let description = Prefixed_Name(ids, "description") |> PrefixedName
    /// <summary>
    ///   <para>ids:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>(Localized) name of the entity.</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/title">https://w3id.org/idsa/core/title</seealso>
    let title = Prefixed_Name(ids, "title") |> PrefixedName

    /// <summary>
    ///   <para>ids:DescribedSemantically</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/DescribedSemantically">https://w3id.org/idsa/core/DescribedSemantically</seealso>
    let DescribedSemantically =
        Prefixed_Name(ids, "DescribedSemantically") |> PrefixedName

    /// <summary>
    ///   <para>ids:DescriptionRequestMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message requesting metadata. If no URI is supplied via the ids:requestedElement field, this messages is treated like a self-description request and the recipient should return its self-description via an ids:DescriptionResponseMessage. However, if a URI is supplied, the Connector should either return metadata about the requested element via an ids:DescriptionResponseMessage, or send an ids:RejectionMessage, e.g. because the element was not found.</para>
    /// labels<para>Description Request Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DescriptionRequestMessage">https://w3id.org/idsa/core/DescriptionRequestMessage</seealso>
    let DescriptionRequestMessage =
        Prefixed_Name(ids, "DescriptionRequestMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:DescriptionResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message containing the metadata, which a Connector previously requested via the ids:DescriptionRequestMessage, in its payload.</para>
    /// labels<para>Description Response Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DescriptionResponseMessage">https://w3id.org/idsa/core/DescriptionResponseMessage</seealso>
    let DescriptionResponseMessage =
        Prefixed_Name(ids, "DescriptionResponseMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:DigitalContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/DigitalContent">https://w3id.org/idsa/core/DigitalContent</seealso>
    let DigitalContent = Prefixed_Name(ids, "DigitalContent") |> PrefixedName
    /// <summary>
    ///   <para>ids:spatialCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Named spatial entity covered by the Resource.</para>
    /// labels<para>spatial coverage</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/spatialCoverage">https://w3id.org/idsa/core/spatialCoverage</seealso>
    let spatialCoverage = Prefixed_Name(ids, "spatialCoverage") |> PrefixedName
    /// <summary>
    ///   <para>ids:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Natural language(s) used within the content.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/language">https://w3id.org/idsa/core/language</seealso>
    let language = Prefixed_Name(ids, "language") |> PrefixedName
    /// <summary>
    ///   <para>ids:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Controlled keywords that describe the nature, purpose, or use of the content.</para>
    /// labels<para>keyword</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/keyword">https://w3id.org/idsa/core/keyword</seealso>
    let keyword = Prefixed_Name(ids, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>ids:contentPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to a Digital Content (physically or logically) included, definition of part-whole hierarchies.</para>
    /// labels<para>content part</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contentPart">https://w3id.org/idsa/core/contentPart</seealso>
    let contentPart = Prefixed_Name(ids, "contentPart") |> PrefixedName
    /// <summary>
    ///   <para>ids:representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Representation of the content.</para>
    /// labels<para>representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/representation">https://w3id.org/idsa/core/representation</seealso>
    let representation = Prefixed_Name(ids, "representation") |> PrefixedName
    /// <summary>
    ///   <para>ids:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/theme">https://w3id.org/idsa/core/theme</seealso>
    let theme = Prefixed_Name(ids, "theme") |> PrefixedName
    /// <summary>
    ///   <para>ids:temporalCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Temporal period or instance covered by the content.</para>
    /// labels<para>temporal coverage</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/temporalCoverage">https://w3id.org/idsa/core/temporalCoverage</seealso>
    let temporalCoverage = Prefixed_Name(ids, "temporalCoverage") |> PrefixedName
    /// <summary>
    ///   <para>ids:contentRefinement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contentRefinement">https://w3id.org/idsa/core/contentRefinement</seealso>
    let contentRefinement = Prefixed_Name(ids, "contentRefinement") |> PrefixedName

    /// <summary>
    ///   <para>ids:DistributeEcryptedAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Distribute only if Encrypted' policy class.</para>
    /// labels<para>Distribute Encrypted Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DistributeEcryptedAgreement">https://w3id.org/idsa/core/DistributeEcryptedAgreement</seealso>
    let DistributeEcryptedAgreement =
        Prefixed_Name(ids, "DistributeEcryptedAgreement") |> PrefixedName

    /// <summary>
    ///   <para>ids:Duty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of Duties as defined in the ODRL ontology.</para>
    /// labels<para>Duty</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Duty">https://w3id.org/idsa/core/Duty</seealso>
    let Duty = Prefixed_Name(ids, "Duty") |> PrefixedName
    /// <summary>
    ///   <para>ids:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Rule">https://w3id.org/idsa/core/Rule</seealso>
    let Rule = Prefixed_Name(ids, "Rule") |> PrefixedName

    /// <summary>
    ///   <para>ids:DynamicAttributeToken</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/DynamicAttributeToken">https://w3id.org/idsa/core/DynamicAttributeToken</seealso>
    let DynamicAttributeToken =
        Prefixed_Name(ids, "DynamicAttributeToken") |> PrefixedName

    /// <summary>
    ///   <para>ids:Token</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Token">https://w3id.org/idsa/core/Token</seealso>
    let Token = Prefixed_Name(ids, "Token") |> PrefixedName
    /// <summary>
    ///   <para>ids:tokenFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the format of the authentication token.</para>
    /// labels<para>tokenFormat</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/tokenFormat">https://w3id.org/idsa/core/tokenFormat</seealso>
    let tokenFormat = Prefixed_Name(ids, "tokenFormat") |> PrefixedName
    /// <summary>
    ///   <para>ids:EndToEndRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     EndToEndRoute hold information about a communication pipelines between apps. An EndToEndRoute should hold
    ///     one value for the ids:appRouteStart and/or ids:appRouteEnd properties, so that communication between app endpoints remain distinguishable.
    ///     </para>
    /// labels<para>end to end route</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/EndToEndRoute">https://w3id.org/idsa/core/EndToEndRoute</seealso>
    let EndToEndRoute = Prefixed_Name(ids, "EndToEndRoute") |> PrefixedName
    /// <summary>
    ///   <para>ids:endpointInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Human-readable information and description of the endpoint.</para>
    /// labels<para>endpoint information</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/endpointInformation">https://w3id.org/idsa/core/endpointInformation</seealso>
    let endpointInformation = Prefixed_Name(ids, "endpointInformation") |> PrefixedName

    /// <summary>
    ///   <para>ids:endpointDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>IRI reference to a documentation of the endpoint,  e.g., reference to an OpenAPI-based documentation.</para>
    /// labels<para>endpoint documentation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/endpointDocumentation">https://w3id.org/idsa/core/endpointDocumentation</seealso>
    let endpointDocumentation =
        Prefixed_Name(ids, "endpointDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>ids:EvaluationFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Evaluation Facilities carry out the evaluation work during a certification process and issue the corresponding Certifications.</para>
    /// labels<para>Evaluation Facility</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/EvaluationFacility">https://w3id.org/idsa/core/EvaluationFacility</seealso>
    let EvaluationFacility = Prefixed_Name(ids, "EvaluationFacility") |> PrefixedName
    /// <summary>
    ///   <para>ids:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Named event with a known or unknown temporal location or duration.</para>
    /// labels<para>event</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Event">https://w3id.org/idsa/core/Event</seealso>
    let Event = Prefixed_Name(ids, "Event") |> PrefixedName
    /// <summary>
    ///   <para>ids:EventAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Event-restricted Usage Policy' policy class.</para>
    /// labels<para>Event-restricted Data Usage Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/EventAgreement">https://w3id.org/idsa/core/EventAgreement</seealso>
    let EventAgreement = Prefixed_Name(ids, "EventAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:EventOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Event-restricted Usage Policy' policy class.</para>
    /// labels<para>Event-restricted Data Usage Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/EventOffer">https://w3id.org/idsa/core/EventOffer</seealso>
    let EventOffer = Prefixed_Name(ids, "EventOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:EventRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Event-restricted Usage Policy' policy class.</para>
    /// labels<para>Event-restricted Data Usage Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/EventRequest">https://w3id.org/idsa/core/EventRequest</seealso>
    let EventRequest = Prefixed_Name(ids, "EventRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/longitude">https://w3id.org/idsa/core/longitude</seealso>
    let longitude = Prefixed_Name(ids, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>ids:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/latitude">https://w3id.org/idsa/core/latitude</seealso>
    let latitude = Prefixed_Name(ids, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>ids:HTTPAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>HTTP authentication.</para>
    /// labels<para>HTTP Authentication</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/HTTPAuthentication">https://w3id.org/idsa/core/HTTPAuthentication</seealso>
    let HTTPAuthentication = Prefixed_Name(ids, "HTTPAuthentication") |> PrefixedName
    /// <summary>
    ///   <para>ids:IANAMediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/IANAMediaType">https://w3id.org/idsa/core/IANAMediaType</seealso>
    let IANAMediaType = Prefixed_Name(ids, "IANAMediaType") |> PrefixedName
    /// <summary>
    ///   <para>ids:IdentityProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Identity Provider manages and validates the digital identity of International Data Spaces Participants.</para>
    /// labels<para>Identity provider</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/IdentityProvider">https://w3id.org/idsa/core/IdentityProvider</seealso>
    let IdentityProvider = Prefixed_Name(ids, "IdentityProvider") |> PrefixedName
    /// <summary>
    ///   <para>ids:ImageRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Image representation</para>
    /// labels<para>Image Representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ImageRepresentation">https://w3id.org/idsa/core/ImageRepresentation</seealso>
    let ImageRepresentation = Prefixed_Name(ids, "ImageRepresentation") |> PrefixedName
    /// <summary>
    ///   <para>ids:ImageResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource (at least partially) comprising image content.</para>
    /// labels<para>Image Resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ImageResource">https://w3id.org/idsa/core/ImageResource</seealso>
    let ImageResource = Prefixed_Name(ids, "ImageResource") |> PrefixedName

    /// <summary>
    ///   <para>ids:outboundModelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information Model version being produced by the InfrastructureComponent.</para>
    /// labels<para>outbound model version</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/outboundModelVersion">https://w3id.org/idsa/core/outboundModelVersion</seealso>
    let outboundModelVersion =
        Prefixed_Name(ids, "outboundModelVersion") |> PrefixedName

    /// <summary>
    ///   <para>ids:inboundModelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information Model version that the InfrastructureComponent is capable of reading/processing.</para>
    /// labels<para>inboundModelVersion</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/inboundModelVersion">https://w3id.org/idsa/core/inboundModelVersion</seealso>
    let inboundModelVersion = Prefixed_Name(ids, "inboundModelVersion") |> PrefixedName
    /// <summary>
    ///   <para>ids:curator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/curator">https://w3id.org/idsa/core/curator</seealso>
    let curator = Prefixed_Name(ids, "curator") |> PrefixedName
    /// <summary>
    ///   <para>ids:maintainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/maintainer">https://w3id.org/idsa/core/maintainer</seealso>
    let maintainer = Prefixed_Name(ids, "maintainer") |> PrefixedName
    /// <summary>
    ///   <para>ids:Instant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A defined point in time with zero duration.</para>
    /// labels<para>Instant</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Instant">https://w3id.org/idsa/core/Instant</seealso>
    let Instant = Prefixed_Name(ids, "Instant") |> PrefixedName
    /// <summary>
    ///   <para>ids:Interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Interval">https://w3id.org/idsa/core/Interval</seealso>
    let Interval = Prefixed_Name(ids, "Interval") |> PrefixedName
    /// <summary>
    ///   <para>ids:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Beginning of an Interval.</para>
    /// labels<para>beginning</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/begin">https://w3id.org/idsa/core/begin</seealso>
    let begin_ = Prefixed_Name(ids, "begin") |> PrefixedName

    /// <summary>
    ///   <para>ids:IntervalUsageAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Interval-restricted Data Usage' policy class.</para>
    /// labels<para>Interval Usage Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/IntervalUsageAgreement">https://w3id.org/idsa/core/IntervalUsageAgreement</seealso>
    let IntervalUsageAgreement =
        Prefixed_Name(ids, "IntervalUsageAgreement") |> PrefixedName

    /// <summary>
    ///   <para>ids:IntervalUsageOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Interval-restricted Data Usage' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/IntervalUsageOffer">https://w3id.org/idsa/core/IntervalUsageOffer</seealso>
    let IntervalUsageOffer = Prefixed_Name(ids, "IntervalUsageOffer") |> PrefixedName

    /// <summary>
    ///   <para>ids:IntervalUsageRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Interval-restricted Data Usage' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/IntervalUsageRequest">https://w3id.org/idsa/core/IntervalUsageRequest</seealso>
    let IntervalUsageRequest =
        Prefixed_Name(ids, "IntervalUsageRequest") |> PrefixedName

    /// <summary>
    ///   <para>ids:InvokeOperationMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/InvokeOperationMessage">https://w3id.org/idsa/core/InvokeOperationMessage</seealso>
    let InvokeOperationMessage =
        Prefixed_Name(ids, "InvokeOperationMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:operationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/operationReference">https://w3id.org/idsa/core/operationReference</seealso>
    let operationReference = Prefixed_Name(ids, "operationReference") |> PrefixedName
    /// <summary>
    ///   <para>ids:sub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'sub' (subject) claim identifies the principal that is the subject of the JWT.</para>
    /// labels<para>sub</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/sub">https://w3id.org/idsa/core/sub</seealso>
    let sub = Prefixed_Name(ids, "sub") |> PrefixedName
    /// <summary>
    ///   <para>ids:iat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'iat' (issued at) claim contains the point in time when the JWT was created.</para>
    /// labels<para>iat</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/iat">https://w3id.org/idsa/core/iat</seealso>
    let iat = Prefixed_Name(ids, "iat") |> PrefixedName
    /// <summary>
    ///   <para>ids:nbf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The 'aud' (audience) claim identifies the recipients that the JWT is intended for.</para>
    /// labels<para>nbf</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/nbf">https://w3id.org/idsa/core/nbf</seealso>
    let nbf = Prefixed_Name(ids, "nbf") |> PrefixedName
    /// <summary>
    ///   <para>ids:LoggingAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Local Logging' policy class.</para>
    /// labels<para>Logging Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/LoggingAgreement">https://w3id.org/idsa/core/LoggingAgreement</seealso>
    let LoggingAgreement = Prefixed_Name(ids, "LoggingAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:LoggingOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Local Logging' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/LoggingOffer">https://w3id.org/idsa/core/LoggingOffer</seealso>
    let LoggingOffer = Prefixed_Name(ids, "LoggingOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:LoggingRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Local Logging' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/LoggingRequest">https://w3id.org/idsa/core/LoggingRequest</seealso>
    let LoggingRequest = Prefixed_Name(ids, "LoggingRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:LogicalConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/LogicalConstraint">https://w3id.org/idsa/core/LogicalConstraint</seealso>
    let LogicalConstraint = Prefixed_Name(ids, "LogicalConstraint") |> PrefixedName
    /// <summary>
    ///   <para>ids:and</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/and">https://w3id.org/idsa/core/and</seealso>
    let and_ = Prefixed_Name(ids, "and") |> PrefixedName
    /// <summary>
    ///   <para>ids:or</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/or">https://w3id.org/idsa/core/or</seealso>
    let or_ = Prefixed_Name(ids, "or") |> PrefixedName
    /// <summary>
    ///   <para>ids:xone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/xone">https://w3id.org/idsa/core/xone</seealso>
    let xone = Prefixed_Name(ids, "xone") |> PrefixedName
    /// <summary>
    ///   <para>ids:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Message">https://w3id.org/idsa/core/Message</seealso>
    let Message = Prefixed_Name(ids, "Message") |> PrefixedName
    /// <summary>
    ///   <para>ids:securityToken</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A token representing a claim that the message sender supports a certain security profile.</para>
    /// labels<para>Security token</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/securityToken">https://w3id.org/idsa/core/securityToken</seealso>
    let securityToken = Prefixed_Name(ids, "securityToken") |> PrefixedName
    /// <summary>
    ///   <para>ids:issuerConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/issuerConnector">https://w3id.org/idsa/core/issuerConnector</seealso>
    let issuerConnector = Prefixed_Name(ids, "issuerConnector") |> PrefixedName
    /// <summary>
    ///   <para>ids:issued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/issued">https://w3id.org/idsa/core/issued</seealso>
    let issued = Prefixed_Name(ids, "issued") |> PrefixedName
    /// <summary>
    ///   <para>ids:recipientAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/recipientAgent">https://w3id.org/idsa/core/recipientAgent</seealso>
    let recipientAgent = Prefixed_Name(ids, "recipientAgent") |> PrefixedName
    /// <summary>
    ///   <para>ids:senderAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/senderAgent">https://w3id.org/idsa/core/senderAgent</seealso>
    let senderAgent = Prefixed_Name(ids, "senderAgent") |> PrefixedName
    /// <summary>
    ///   <para>ids:recipientConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/recipientConnector">https://w3id.org/idsa/core/recipientConnector</seealso>
    let recipientConnector = Prefixed_Name(ids, "recipientConnector") |> PrefixedName
    /// <summary>
    ///   <para>ids:modelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version of the Information Model against which the Message should be interpreted.</para>
    /// labels<para>model version</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/modelVersion">https://w3id.org/idsa/core/modelVersion</seealso>
    let modelVersion = Prefixed_Name(ids, "modelVersion") |> PrefixedName

    /// <summary>
    ///   <para>ids:MessageProcessedNotificationMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/MessageProcessedNotificationMessage">https://w3id.org/idsa/core/MessageProcessedNotificationMessage</seealso>
    let MessageProcessedNotificationMessage =
        Prefixed_Name(ids, "MessageProcessedNotificationMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:correlationMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/correlationMessage">https://w3id.org/idsa/core/correlationMessage</seealso>
    let correlationMessage = Prefixed_Name(ids, "correlationMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:Named</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Entity that is identifiable within a context by means of a name.</para>
    /// labels<para>Named</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Named">https://w3id.org/idsa/core/Named</seealso>
    let Named = Prefixed_Name(ids, "Named") |> PrefixedName
    /// <summary>
    ///   <para>ids:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Entity name unique within a specified context.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/name">https://w3id.org/idsa/core/name</seealso>
    let name = Prefixed_Name(ids, "name") |> PrefixedName

    /// <summary>
    ///   <para>ids:NotMoreThanNAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Restricted Number of Usages' policy class.</para>
    /// labels<para>Use Not More Than N Times Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/NotMoreThanNAgreement">https://w3id.org/idsa/core/NotMoreThanNAgreement</seealso>
    let NotMoreThanNAgreement =
        Prefixed_Name(ids, "NotMoreThanNAgreement") |> PrefixedName

    /// <summary>
    ///   <para>ids:NotMoreThanNOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Restricted Number of Usages' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/NotMoreThanNOffer">https://w3id.org/idsa/core/NotMoreThanNOffer</seealso>
    let NotMoreThanNOffer = Prefixed_Name(ids, "NotMoreThanNOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:NotMoreThanNRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Restricted Number of Usages' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/NotMoreThanNRequest">https://w3id.org/idsa/core/NotMoreThanNRequest</seealso>
    let NotMoreThanNRequest = Prefixed_Name(ids, "NotMoreThanNRequest") |> PrefixedName

    /// <summary>
    ///   <para>ids:NotificationAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Remote Notifications' policy class.</para>
    /// labels<para>Notification Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/NotificationAgreement">https://w3id.org/idsa/core/NotificationAgreement</seealso>
    let NotificationAgreement =
        Prefixed_Name(ids, "NotificationAgreement") |> PrefixedName

    /// <summary>
    ///   <para>ids:NotificationOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Remote Notifications' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/NotificationOffer">https://w3id.org/idsa/core/NotificationOffer</seealso>
    let NotificationOffer = Prefixed_Name(ids, "NotificationOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:NotificationRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Remote Notifications' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/NotificationRequest">https://w3id.org/idsa/core/NotificationRequest</seealso>
    let NotificationRequest = Prefixed_Name(ids, "NotificationRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Operation">https://w3id.org/idsa/core/Operation</seealso>
    let Operation = Prefixed_Name(ids, "Operation") |> PrefixedName

    /// <summary>
    ///   <para>ids:OperationResultMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message indicating that the result of a former InvokeOperation message is available. May transfer the result data in its associated payload section.</para>
    /// labels<para>Operation Result Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/OperationResultMessage">https://w3id.org/idsa/core/OperationResultMessage</seealso>
    let OperationResultMessage =
        Prefixed_Name(ids, "OperationResultMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:OrchestrationApp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Apps for orchestrating System Adapter Apps or Smart Data Apps, inside a Connector.</para>
    /// labels<para>Orchestration App</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/OrchestrationApp">https://w3id.org/idsa/core/OrchestrationApp</seealso>
    let OrchestrationApp = Prefixed_Name(ids, "OrchestrationApp") |> PrefixedName
    /// <summary>
    ///   <para>ids:ParIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParIS">https://w3id.org/idsa/core/ParIS</seealso>
    let ParIS = Prefixed_Name(ids, "ParIS") |> PrefixedName
    /// <summary>
    ///   <para>ids:VideoRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Video representation</para>
    /// labels<para>Video Representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/VideoRepresentation">https://w3id.org/idsa/core/VideoRepresentation</seealso>
    let VideoRepresentation = Prefixed_Name(ids, "VideoRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>ids:AuthenticationGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Authentication mechanism applied prior to opening a connection. Examples are the verification server's identity or doing mutual authentication.</para>
    /// labels<para>Authentication</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AuthenticationGuarantee">https://w3id.org/idsa/core/AuthenticationGuarantee</seealso>
    let AuthenticationGuarantee =
        Prefixed_Name(ids, "AuthenticationGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:accessUrl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/idsa/core/accessUrl">https://w3id.org/idsa/core/accessUrl</seealso>
    let accessUrl = Prefixed_Name(ids, "accessUrl") |> PrefixedName

    /// <summary>
    ///   <para>ids:appEndpointMediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Mediatype, such as IANA types, of the data an endpoint expects or returns .</para>
    /// labels<para>app endpoint media type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/appEndpointMediaType">https://w3id.org/idsa/core/appEndpointMediaType</seealso>
    let appEndpointMediaType =
        Prefixed_Name(ids, "appEndpointMediaType") |> PrefixedName

    /// <summary>
    ///   <para>ids:assetRefinement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Conditions which specify whether an arbitrary ids:Asset is a member of this AssetCollection.</para>
    ///   <para>Constraint that refines a (composite) Digital Content.</para>
    /// labels<para>content refinement</para><para>asset refinement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/assetRefinement">https://w3id.org/idsa/core/assetRefinement</seealso>
    let assetRefinement = Prefixed_Name(ids, "assetRefinement") |> PrefixedName
    /// <summary>
    ///   <para>ids:authInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information of the authentication service used by the Connector.</para>
    /// labels<para>authInfo</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/authInfo">https://w3id.org/idsa/core/authInfo</seealso>
    let authInfo = Prefixed_Name(ids, "authInfo") |> PrefixedName
    /// <summary>
    ///   <para>ids:DataResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource (at least partially) comprising data content.</para>
    /// labels<para>Data Resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DataResource">https://w3id.org/idsa/core/DataResource</seealso>
    let DataResource = Prefixed_Name(ids, "DataResource") |> PrefixedName

    /// <summary>
    ///   <para>ids:DeleteAfterIntervalAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.</para>
    /// labels<para>Delete After Interval Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DeleteAfterIntervalAgreement">https://w3id.org/idsa/core/DeleteAfterIntervalAgreement</seealso>
    let DeleteAfterIntervalAgreement =
        Prefixed_Name(ids, "DeleteAfterIntervalAgreement") |> PrefixedName

    /// <summary>
    ///   <para>ids:DeleteAfterIntervalRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DeleteAfterIntervalRequest">https://w3id.org/idsa/core/DeleteAfterIntervalRequest</seealso>
    let DeleteAfterIntervalRequest =
        Prefixed_Name(ids, "DeleteAfterIntervalRequest") |> PrefixedName

    /// <summary>
    ///   <para>ids:consumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/consumer">https://w3id.org/idsa/core/consumer</seealso>
    let consumer = Prefixed_Name(ids, "consumer") |> PrefixedName
    /// <summary>
    ///   <para>ids:RejectionReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class of reasons that might lead to issuing a Rejection message.</para>
    /// labels<para>RejectionReason</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RejectionReason">https://w3id.org/idsa/core/RejectionReason</seealso>
    let RejectionReason = Prefixed_Name(ids, "RejectionReason") |> PrefixedName
    /// <summary>
    ///   <para>ids:securityGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to a security guarantee supported by given profile.</para>
    /// labels<para>Security guarantee</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/securityGuarantee">https://w3id.org/idsa/core/securityGuarantee</seealso>
    let securityGuarantee = Prefixed_Name(ids, "securityGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:ComponentCertificationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Level of a Component Certification</para>
    /// labels<para>Component Certification Level</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ComponentCertificationLevel">https://w3id.org/idsa/core/ComponentCertificationLevel</seealso>
    let ComponentCertificationLevel =
        Prefixed_Name(ids, "ComponentCertificationLevel") |> PrefixedName

    /// <summary>
    ///   <para>ids:includedCertificationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Certification Level transitively implied by given Certification Level of same root type.</para>
    /// labels<para>included certification level</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/includedCertificationLevel">https://w3id.org/idsa/core/includedCertificationLevel</seealso>
    let includedCertificationLevel =
        Prefixed_Name(ids, "includedCertificationLevel") |> PrefixedName

    /// <summary>
    ///   <para>ids:DurationAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Duration-restricted Data Usage' policy class.</para>
    /// labels<para>Duration Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DurationAgreement">https://w3id.org/idsa/core/DurationAgreement</seealso>
    let DurationAgreement = Prefixed_Name(ids, "DurationAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:TemporalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal interval, instant or a relative duration.</para>
    /// labels<para>TemporalEntity</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/TemporalEntity">https://w3id.org/idsa/core/TemporalEntity</seealso>
    let TemporalEntity = Prefixed_Name(ids, "TemporalEntity") |> PrefixedName
    /// <summary>
    ///   <para>ids:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/hasDuration">https://w3id.org/idsa/core/hasDuration</seealso>
    let hasDuration = Prefixed_Name(ids, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>ids:DurationOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Duration-restricted Data Usage' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DurationOffer">https://w3id.org/idsa/core/DurationOffer</seealso>
    let DurationOffer = Prefixed_Name(ids, "DurationOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:inboundPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relative path used for inbound communication via this endpoint, i.e. input messages and faults only.</para>
    /// labels<para>inbound topic</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/inboundPath">https://w3id.org/idsa/core/inboundPath</seealso>
    let inboundPath = Prefixed_Name(ids, "inboundPath") |> PrefixedName
    /// <summary>
    ///   <para>ids:SecurityProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/SecurityProfile">https://w3id.org/idsa/core/SecurityProfile</seealso>
    let SecurityProfile = Prefixed_Name(ids, "SecurityProfile") |> PrefixedName
    /// <summary>
    ///   <para>ids:PolicyTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/PolicyTemplate">https://w3id.org/idsa/core/PolicyTemplate</seealso>
    let PolicyTemplate = Prefixed_Name(ids, "PolicyTemplate") |> PrefixedName

    /// <summary>
    ///   <para>ids:ServiceIsolationGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Service isolation mechanism supported by the Connector. Examples are process group (Docker) or by least privilege with clear separation and support for additional security modules as done by trustme.</para>
    /// labels<para>Service isolation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ServiceIsolationGuarantee">https://w3id.org/idsa/core/ServiceIsolationGuarantee</seealso>
    let ServiceIsolationGuarantee =
        Prefixed_Name(ids, "ServiceIsolationGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:QueryLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class of query languages in which query strings may be formalized.</para>
    /// labels<para>QueryLanguage</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/QueryLanguage">https://w3id.org/idsa/core/QueryLanguage</seealso>
    let QueryLanguage = Prefixed_Name(ids, "QueryLanguage") |> PrefixedName

    /// <summary>
    ///   <para>ids:UsageControlGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of supporting usage control.</para>
    /// labels<para>Usage control</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/UsageControlGuarantee">https://w3id.org/idsa/core/UsageControlGuarantee</seealso>
    let UsageControlGuarantee =
        Prefixed_Name(ids, "UsageControlGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:shapesGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reference to SHACL shape graph, which describes domain-specific knowledge.</para>
    /// labels<para>shapeGraph</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/shapesGraph">https://w3id.org/idsa/core/shapesGraph</seealso>
    let shapesGraph = Prefixed_Name(ids, "shapesGraph") |> PrefixedName
    /// <summary>
    ///   <para>ids:siteAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates an address for the site.</para>
    /// labels<para>site address</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/siteAddress">https://w3id.org/idsa/core/siteAddress</seealso>
    let siteAddress = Prefixed_Name(ids, "siteAddress") |> PrefixedName

    /// <summary>
    ///   <para>ids:DeleteAfterIntervalOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Interval-restricted Data Usage' policy class with the further obligation to delete the data.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DeleteAfterIntervalOffer">https://w3id.org/idsa/core/DeleteAfterIntervalOffer</seealso>
    let DeleteAfterIntervalOffer =
        Prefixed_Name(ids, "DeleteAfterIntervalOffer") |> PrefixedName

    /// <summary>
    ///   <para>ids:corporateHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/corporateHomepage">https://w3id.org/idsa/core/corporateHomepage</seealso>
    let corporateHomepage = Prefixed_Name(ids, "corporateHomepage") |> PrefixedName
    /// <summary>
    ///   <para>ids:AppEndpointType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class of endpoint types a data app offers.</para>
    /// labels<para>App endpoint type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppEndpointType">https://w3id.org/idsa/core/AppEndpointType</seealso>
    let AppEndpointType = Prefixed_Name(ids, "AppEndpointType") |> PrefixedName
    /// <summary>
    ///   <para>ids:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Location">https://w3id.org/idsa/core/Location</seealso>
    let Location = Prefixed_Name(ids, "Location") |> PrefixedName

    /// <summary>
    ///   <para>ids:DistributeEcryptedOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Distribute only if Encrypted' policy class.</para>
    /// labels<para>Distribute Encrypted Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DistributeEcryptedOffer">https://w3id.org/idsa/core/DistributeEcryptedOffer</seealso>
    let DistributeEcryptedOffer =
        Prefixed_Name(ids, "DistributeEcryptedOffer") |> PrefixedName

    /// <summary>
    ///   <para>ids:DistributeEcryptedRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Distribute only if Encrypted' policy class.</para>
    /// labels<para>Distribute Encrypted Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DistributeEcryptedRequest">https://w3id.org/idsa/core/DistributeEcryptedRequest</seealso>
    let DistributeEcryptedRequest =
        Prefixed_Name(ids, "DistributeEcryptedRequest") |> PrefixedName

    /// <summary>
    ///   <para>ids:DurationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/DurationEntity">https://w3id.org/idsa/core/DurationEntity</seealso>
    let DurationEntity = Prefixed_Name(ids, "DurationEntity") |> PrefixedName
    /// <summary>
    ///   <para>ids:DurationRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Duration-restricted Data Usage' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/DurationRequest">https://w3id.org/idsa/core/DurationRequest</seealso>
    let DurationRequest = Prefixed_Name(ids, "DurationRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:ConnectorStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connector Status is used to represent a Connectors current state inside the Configuration Model.</para>
    /// labels<para>Connector Status</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ConnectorStatus">https://w3id.org/idsa/core/ConnectorStatus</seealso>
    let ConnectorStatus = Prefixed_Name(ids, "ConnectorStatus") |> PrefixedName
    /// <summary>
    ///   <para>ids:samplingRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Audio sampling rate.</para>
    /// labels<para>sampling rate</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/samplingRate">https://w3id.org/idsa/core/samplingRate</seealso>
    let samplingRate = Prefixed_Name(ids, "samplingRate") |> PrefixedName
    /// <summary>
    ///   <para>ids:evaluationFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Evaluation Facility that performed and issued given Certification</para>
    /// labels<para>evaluation facility</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/evaluationFacility">https://w3id.org/idsa/core/evaluationFacility</seealso>
    let evaluationFacility = Prefixed_Name(ids, "evaluationFacility") |> PrefixedName
    /// <summary>
    ///   <para>ids:GeoFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location identified by a geonames URL.</para>
    /// labels<para>GeoFeature</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/GeoFeature">https://w3id.org/idsa/core/GeoFeature</seealso>
    let GeoFeature = Prefixed_Name(ids, "GeoFeature") |> PrefixedName
    /// <summary>
    ///   <para>ids:GeoPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/GeoPoint">https://w3id.org/idsa/core/GeoPoint</seealso>
    let GeoPoint = Prefixed_Name(ids, "GeoPoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:outboundPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relative path used for outbound communication via this endpoint, i.e. output messages and faults only.</para>
    /// labels<para>outbound topic</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/outboundPath">https://w3id.org/idsa/core/outboundPath</seealso>
    let outboundPath = Prefixed_Name(ids, "outboundPath") |> PrefixedName
    /// <summary>
    ///   <para>ids:intervalIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/idsa/core/intervalIn">https://w3id.org/idsa/core/intervalIn</seealso>
    let intervalIn = Prefixed_Name(ids, "intervalIn") |> PrefixedName
    /// <summary>
    ///   <para>ids:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/">https://w3id.org/idsa/core/</seealso>
    let _prefix_iri = Prefixed_Name(ids, "") |> PrefixedName
    /// <summary>
    ///   <para>ids:AbstractConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/AbstractConstraint">https://w3id.org/idsa/core/AbstractConstraint</seealso>
    let AbstractConstraint = Prefixed_Name(ids, "AbstractConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ids:AccessTokenRequestMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message requesting an access token. This is intended for point-to-point communication with, e.g., Brokers.</para>
    /// labels<para>AccessToken Request Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AccessTokenRequestMessage">https://w3id.org/idsa/core/AccessTokenRequestMessage</seealso>
    let AccessTokenRequestMessage =
        Prefixed_Name(ids, "AccessTokenRequestMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:AccessTokenResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response to an access token request, intended for point-to-point communication.</para>
    /// labels<para>Access Token Response</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AccessTokenResponseMessage">https://w3id.org/idsa/core/AccessTokenResponseMessage</seealso>
    let AccessTokenResponseMessage =
        Prefixed_Name(ids, "AccessTokenResponseMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ResponseMessage">https://w3id.org/idsa/core/ResponseMessage</seealso>
    let ResponseMessage = Prefixed_Name(ids, "ResponseMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:actionRefinement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Constraint that refines an Action.</para>
    /// labels<para>action refinement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/actionRefinement">https://w3id.org/idsa/core/actionRefinement</seealso>
    let actionRefinement = Prefixed_Name(ids, "actionRefinement") |> PrefixedName
    /// <summary>
    ///   <para>ids:AppAvailableMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message indicating that a specific App should be available (again) in the AppStore.</para>
    /// labels<para>App Available Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppAvailableMessage">https://w3id.org/idsa/core/AppAvailableMessage</seealso>
    let AppAvailableMessage = Prefixed_Name(ids, "AppAvailableMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppNotificationMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppNotificationMessage">https://w3id.org/idsa/core/AppNotificationMessage</seealso>
    let AppNotificationMessage =
        Prefixed_Name(ids, "AppNotificationMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppDeleteMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message indicating that an App should be deleted from the AppStore.</para>
    /// labels<para>App Delete Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppDeleteMessage">https://w3id.org/idsa/core/AppDeleteMessage</seealso>
    let AppDeleteMessage = Prefixed_Name(ids, "AppDeleteMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:AppEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppEndpoint">https://w3id.org/idsa/core/AppEndpoint</seealso>
    let AppEndpoint = Prefixed_Name(ids, "AppEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:appEndpointType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of an app endpoint. Data apps have different endpoint types, e.g., for input, output or health status.</para>
    /// labels<para>App endpoint type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/appEndpointType">https://w3id.org/idsa/core/appEndpointType</seealso>
    let appEndpointType = Prefixed_Name(ids, "appEndpointType") |> PrefixedName

    /// <summary>
    ///   <para>ids:ResourceNotificationMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ResourceNotificationMessage">https://w3id.org/idsa/core/ResourceNotificationMessage</seealso>
    let ResourceNotificationMessage =
        Prefixed_Name(ids, "ResourceNotificationMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:affectedDataAppResource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/idsa/core/affectedDataAppResource">https://w3id.org/idsa/core/affectedDataAppResource</seealso>
    let affectedDataAppResource =
        Prefixed_Name(ids, "affectedDataAppResource") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppRegistrationResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message that follows up an AppRegistrationRequestMessage and contains the app registration confimation.</para>
    /// labels<para>App Registration Response Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppRegistrationResponseMessage">https://w3id.org/idsa/core/AppRegistrationResponseMessage</seealso>
    let AppRegistrationResponseMessage =
        Prefixed_Name(ids, "AppRegistrationResponseMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>App representation</para>
    /// labels<para>App Representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppRepresentation">https://w3id.org/idsa/core/AppRepresentation</seealso>
    let AppRepresentation = Prefixed_Name(ids, "AppRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>ids:SoftwareRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Software representation</para>
    /// labels<para>Software Representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SoftwareRepresentation">https://w3id.org/idsa/core/SoftwareRepresentation</seealso>
    let SoftwareRepresentation =
        Prefixed_Name(ids, "SoftwareRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource comprising IDS data apps.</para>
    /// labels<para>App Resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppResource">https://w3id.org/idsa/core/AppResource</seealso>
    let AppResource = Prefixed_Name(ids, "AppResource") |> PrefixedName
    /// <summary>
    ///   <para>ids:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Resource">https://w3id.org/idsa/core/Resource</seealso>
    let Resource = Prefixed_Name(ids, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>ids:AppRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppRoute">https://w3id.org/idsa/core/AppRoute</seealso>
    let AppRoute = Prefixed_Name(ids, "AppRoute") |> PrefixedName
    /// <summary>
    ///   <para>ids:routeDeployMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Supplementary information about, e.g., the technology used, for routes.</para>
    /// labels<para>route deploy method</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/routeDeployMethod">https://w3id.org/idsa/core/routeDeployMethod</seealso>
    let routeDeployMethod = Prefixed_Name(ids, "routeDeployMethod") |> PrefixedName
    /// <summary>
    ///   <para>ids:AppUploadMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppUploadMessage">https://w3id.org/idsa/core/AppUploadMessage</seealso>
    let AppUploadMessage = Prefixed_Name(ids, "AppUploadMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:UploadMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message used to upload a data to a recipient. Payload contains data.</para>
    /// labels<para>Upload Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/UploadMessage">https://w3id.org/idsa/core/UploadMessage</seealso>
    let UploadMessage = Prefixed_Name(ids, "UploadMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:appArtifactReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/appArtifactReference">https://w3id.org/idsa/core/appArtifactReference</seealso>
    let appArtifactReference =
        Prefixed_Name(ids, "appArtifactReference") |> PrefixedName

    /// <summary>
    ///   <para>ids:AppUploadResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message that follows up an AppUploadMessage and contains the app upload confimation.</para>
    /// labels<para>App Upload Response Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AppUploadResponseMessage">https://w3id.org/idsa/core/AppUploadResponseMessage</seealso>
    let AppUploadResponseMessage =
        Prefixed_Name(ids, "AppUploadResponseMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:UploadResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message that follows up a UploadMessage and contains the upload confirmation.</para>
    /// labels<para>Upload Response Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/UploadResponseMessage">https://w3id.org/idsa/core/UploadResponseMessage</seealso>
    let UploadResponseMessage =
        Prefixed_Name(ids, "UploadResponseMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Instance of a Representation materialized at a partiuclar version and point in time. Possesses characteristics like file name, size, creation date etc.</para>
    /// labels<para>Artifact</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Artifact">https://w3id.org/idsa/core/Artifact</seealso>
    let Artifact = Prefixed_Name(ids, "Artifact") |> PrefixedName

    /// <summary>
    ///   <para>ids:RepresentationInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/RepresentationInstance">https://w3id.org/idsa/core/RepresentationInstance</seealso>
    let RepresentationInstance =
        Prefixed_Name(ids, "RepresentationInstance") |> PrefixedName

    /// <summary>
    ///   <para>ids:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Literal, inline value instantiation of a representation.</para>
    /// labels<para>Value</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Value">https://w3id.org/idsa/core/Value</seealso>
    let Value = Prefixed_Name(ids, "Value") |> PrefixedName
    /// <summary>
    ///   <para>ids:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Asset">https://w3id.org/idsa/core/Asset</seealso>
    let Asset = Prefixed_Name(ids, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>ids:AssetCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An AssetCollection is a bracket object combining several ids:Assets.</para>
    /// labels<para>Asset Collection</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AssetCollection">https://w3id.org/idsa/core/AssetCollection</seealso>
    let AssetCollection = Prefixed_Name(ids, "AssetCollection") |> PrefixedName
    /// <summary>
    ///   <para>ids:AudioRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Audio representation</para>
    /// labels<para>Audio Representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AudioRepresentation">https://w3id.org/idsa/core/AudioRepresentation</seealso>
    let AudioRepresentation = Prefixed_Name(ids, "AudioRepresentation") |> PrefixedName
    /// <summary>
    ///   <para>ids:Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Representation">https://w3id.org/idsa/core/Representation</seealso>
    let Representation = Prefixed_Name(ids, "Representation") |> PrefixedName
    /// <summary>
    ///   <para>ids:AudioResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource (at least partially) comprising audio content.</para>
    /// labels<para>Audio Resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AudioResource">https://w3id.org/idsa/core/AudioResource</seealso>
    let AudioResource = Prefixed_Name(ids, "AudioResource") |> PrefixedName
    /// <summary>
    ///   <para>ids:TextResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource (at least partially) comprising textual content.</para>
    /// labels<para>Text Resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/TextResource">https://w3id.org/idsa/core/TextResource</seealso>
    let TextResource = Prefixed_Name(ids, "TextResource") |> PrefixedName
    /// <summary>
    ///   <para>ids:tokenValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An authentication token value like JSON Web Token.</para>
    /// labels<para>tokenValue</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/tokenValue">https://w3id.org/idsa/core/tokenValue</seealso>
    let tokenValue = Prefixed_Name(ids, "tokenValue") |> PrefixedName
    /// <summary>
    ///   <para>ids:TrustedConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hardened implementation of the Connector specification providing enhanced security capabilities.</para>
    /// labels<para>Trusted Connector</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/TrustedConnector">https://w3id.org/idsa/core/TrustedConnector</seealso>
    let TrustedConnector = Prefixed_Name(ids, "TrustedConnector") |> PrefixedName
    /// <summary>
    ///   <para>ids:UsageControlObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/UsageControlObject">https://w3id.org/idsa/core/UsageControlObject</seealso>
    let UsageControlObject = Prefixed_Name(ids, "UsageControlObject") |> PrefixedName
    /// <summary>
    ///   <para>ids:data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/data">https://w3id.org/idsa/core/data</seealso>
    let data = Prefixed_Name(ids, "data") |> PrefixedName
    /// <summary>
    ///   <para>ids:contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The target contract defining the usage of the data object.</para>
    /// labels<para>has contract</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contract">https://w3id.org/idsa/core/contract</seealso>
    let contract = Prefixed_Name(ids, "contract") |> PrefixedName
    /// <summary>
    ///   <para>ids:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date of the creation of the Digital Content. In contrast to the ids:temporalCoverage, creation dates of ids:Representation, ids:Artifacts or any other form of meta-data, this property describes the creation date of referenced Digital Content itself.</para>
    /// labels<para>created</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/created">https://w3id.org/idsa/core/created</seealso>
    let created = Prefixed_Name(ids, "created") |> PrefixedName
    /// <summary>
    ///   <para>ids:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The list of combined current states of the data object.</para>
    /// labels<para>has state</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/hasState">https://w3id.org/idsa/core/hasState</seealso>
    let hasState = Prefixed_Name(ids, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>ids:VideoResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource (at least partially) comprising video content.</para>
    /// labels<para>Video Resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/VideoResource">https://w3id.org/idsa/core/VideoResource</seealso>
    let VideoResource = Prefixed_Name(ids, "VideoResource") |> PrefixedName
    /// <summary>
    ///   <para>ids:accessURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Access URL of an endpoint.</para>
    /// labels<para>access URL</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/accessURL">https://w3id.org/idsa/core/accessURL</seealso>
    let accessURL = Prefixed_Name(ids, "accessURL") |> PrefixedName
    /// <summary>
    ///   <para>ids:accessed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/accessed">https://w3id.org/idsa/core/accessed</seealso>
    let accessed = Prefixed_Name(ids, "accessed") |> PrefixedName
    /// <summary>
    ///   <para>ids:accrualPeriodicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/accrualPeriodicity">https://w3id.org/idsa/core/accrualPeriodicity</seealso>
    let accrualPeriodicity = Prefixed_Name(ids, "accrualPeriodicity") |> PrefixedName
    /// <summary>
    ///   <para>ids:LogLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Instances of ids:LogLevel can be used to specify a log level. Currently this is only used by the Configuration Model.</para>
    /// labels<para>Log Level</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/LogLevel">https://w3id.org/idsa/core/LogLevel</seealso>
    let LogLevel = Prefixed_Name(ids, "LogLevel") |> PrefixedName
    /// <summary>
    ///   <para>ids:aud</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The 'aud' (audience) claim identifies the recipients that the JWT is intended for.</para>
    /// labels<para>aud</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/aud">https://w3id.org/idsa/core/aud</seealso>
    let aud = Prefixed_Name(ids, "aud") |> PrefixedName
    /// <summary>
    ///   <para>ids:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/source">https://w3id.org/idsa/core/source</seealso>
    let source = Prefixed_Name(ids, "source") |> PrefixedName
    /// <summary>
    ///   <para>ids:sovereign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/sovereign">https://w3id.org/idsa/core/sovereign</seealso>
    let sovereign = Prefixed_Name(ids, "sovereign") |> PrefixedName
    /// <summary>
    ///   <para>ids:temporalResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/temporalResolution">https://w3id.org/idsa/core/temporalResolution</seealso>
    let temporalResolution = Prefixed_Name(ids, "temporalResolution") |> PrefixedName
    /// <summary>
    ///   <para>ids:transferContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/transferContract">https://w3id.org/idsa/core/transferContract</seealso>
    let transferContract = Prefixed_Name(ids, "transferContract") |> PrefixedName
    /// <summary>
    ///   <para>ids:trustStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URI of the trust store server.</para>
    /// labels<para>trust store</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/trustStore">https://w3id.org/idsa/core/trustStore</seealso>
    let trustStore = Prefixed_Name(ids, "trustStore") |> PrefixedName
    /// <summary>
    ///   <para>ids:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/unit">https://w3id.org/idsa/core/unit</seealso>
    let unit = Prefixed_Name(ids, "unit") |> PrefixedName
    /// <summary>
    ///   <para>ids:variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(Equivalent) variant of given Resource, e.g. a translation.</para>
    /// labels<para>variant</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/variant">https://w3id.org/idsa/core/variant</seealso>
    let variant = Prefixed_Name(ids, "variant") |> PrefixedName
    /// <summary>
    ///   <para>ids:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version identifier of the Managed Entity</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/version">https://w3id.org/idsa/core/version</seealso>
    let version = Prefixed_Name(ids, "version") |> PrefixedName
    /// <summary>
    ///   <para>ids:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Width of the visible frame.</para>
    /// labels<para>width</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/width">https://w3id.org/idsa/core/width</seealso>
    let width = Prefixed_Name(ids, "width") |> PrefixedName
    /// <summary>
    ///   <para>ids:KeyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cryptographic Key Type.</para>
    /// labels<para>Key Type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/KeyType">https://w3id.org/idsa/core/KeyType</seealso>
    let KeyType = Prefixed_Name(ids, "KeyType") |> PrefixedName
    /// <summary>
    ///   <para>ids:memberPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/memberPerson">https://w3id.org/idsa/core/memberPerson</seealso>
    let memberPerson = Prefixed_Name(ids, "memberPerson") |> PrefixedName
    /// <summary>
    ///   <para>ids:memberParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/memberParticipant">https://w3id.org/idsa/core/memberParticipant</seealso>
    let memberParticipant = Prefixed_Name(ids, "memberParticipant") |> PrefixedName
    /// <summary>
    ///   <para>ids:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Participant, that is part of a participant catalog.</para>
    /// labels<para>member</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/member">https://w3id.org/idsa/core/member</seealso>
    let member_ = Prefixed_Name(ids, "member") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantCertificateGrantedMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Whenever a Participant has been successfully certified by the Certification Body, the Identity Provider can use this message to notify Infrastructure Components.</para>
    /// labels<para>Participant Certificate Granted Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantCertificateGrantedMessage">https://w3id.org/idsa/core/ParticipantCertificateGrantedMessage</seealso>
    let ParticipantCertificateGrantedMessage =
        Prefixed_Name(ids, "ParticipantCertificateGrantedMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:affectedParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/affectedParticipant">https://w3id.org/idsa/core/affectedParticipant</seealso>
    let affectedParticipant = Prefixed_Name(ids, "affectedParticipant") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantRequestMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantRequestMessage">https://w3id.org/idsa/core/ParticipantRequestMessage</seealso>
    let ParticipantRequestMessage =
        Prefixed_Name(ids, "ParticipantRequestMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantResponseMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message that follows up a ParticipantRequestMessage and contains the Participant's information in the payload section.</para>
    /// labels<para>Participant Response Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantResponseMessage">https://w3id.org/idsa/core/ParticipantResponseMessage</seealso>
    let ParticipantResponseMessage =
        Prefixed_Name(ids, "ParticipantResponseMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantUnavailableMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event notifying the recipient(s) that a participant will be unavailable. The same participant may be available again in the future.</para>
    /// labels<para>Participant Unavailable Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantUnavailableMessage">https://w3id.org/idsa/core/ParticipantUnavailableMessage</seealso>
    let ParticipantUnavailableMessage =
        Prefixed_Name(ids, "ParticipantUnavailableMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantUpdateMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event notifying the recipient(s) about the availability and current description of a participant. The payload of the message must contain the participant's self-description.</para>
    /// labels<para>Participant Available Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantUpdateMessage">https://w3id.org/idsa/core/ParticipantUpdateMessage</seealso>
    let ParticipantUpdateMessage =
        Prefixed_Name(ids, "ParticipantUpdateMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:Permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Permission">https://w3id.org/idsa/core/Permission</seealso>
    let Permission = Prefixed_Name(ids, "Permission") |> PrefixedName
    /// <summary>
    ///   <para>ids:phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/phoneNumber">https://w3id.org/idsa/core/phoneNumber</seealso>
    let phoneNumber = Prefixed_Name(ids, "phoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>ids:Prohibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of Prohibitions as defined in the ODRL ontology.</para>
    /// labels<para>Prohibition</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Prohibition">https://w3id.org/idsa/core/Prohibition</seealso>
    let Prohibition = Prefixed_Name(ids, "Prohibition") |> PrefixedName
    /// <summary>
    ///   <para>ids:PurposeOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Purpose-restricted Data Usage' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/PurposeOffer">https://w3id.org/idsa/core/PurposeOffer</seealso>
    let PurposeOffer = Prefixed_Name(ids, "PurposeOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:PurposeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Purpose-restricted Data Usage' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/PurposeRequest">https://w3id.org/idsa/core/PurposeRequest</seealso>
    let PurposeRequest = Prefixed_Name(ids, "PurposeRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:RentalAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Data Rental' policy class.</para>
    /// labels<para>Rental Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RentalAgreement">https://w3id.org/idsa/core/RentalAgreement</seealso>
    let RentalAgreement = Prefixed_Name(ids, "RentalAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:RentalOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Data Rental' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RentalOffer">https://w3id.org/idsa/core/RentalOffer</seealso>
    let RentalOffer = Prefixed_Name(ids, "RentalOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:RentalRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Data Rental' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RentalRequest">https://w3id.org/idsa/core/RentalRequest</seealso>
    let RentalRequest = Prefixed_Name(ids, "RentalRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:resourcePart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to a Resource (physically or logically) included, definition of part-whole hierarchies.</para>
    /// labels<para>resource part</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/resourcePart">https://w3id.org/idsa/core/resourcePart</seealso>
    let resourcePart = Prefixed_Name(ids, "resourcePart") |> PrefixedName
    /// <summary>
    ///   <para>ids:resourceEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to the Endpoints serving the resource's content or let you exchange messages with an IDS Connector.</para>
    /// labels<para>resource endpoint</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/resourceEndpoint">https://w3id.org/idsa/core/resourceEndpoint</seealso>
    let resourceEndpoint = Prefixed_Name(ids, "resourceEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:contractOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to a Contract Offer defining the authorized use of the Resource.</para>
    /// labels<para>contract offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contractOffer">https://w3id.org/idsa/core/contractOffer</seealso>
    let contractOffer = Prefixed_Name(ids, "contractOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:offeredResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Resource that is part of a resource catalog, indicating an offering (of, e.g., data).</para>
    /// labels<para>offered resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/offeredResource">https://w3id.org/idsa/core/offeredResource</seealso>
    let offeredResource = Prefixed_Name(ids, "offeredResource") |> PrefixedName
    /// <summary>
    ///   <para>ids:requestedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Resource that is part of a resource catalog, indicating a request (of, e.g., data, software,...).</para>
    /// labels<para>requested resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/requestedResource">https://w3id.org/idsa/core/requestedResource</seealso>
    let requestedResource = Prefixed_Name(ids, "requestedResource") |> PrefixedName
    /// <summary>
    ///   <para>ids:affectedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/affectedResource">https://w3id.org/idsa/core/affectedResource</seealso>
    let affectedResource = Prefixed_Name(ids, "affectedResource") |> PrefixedName

    /// <summary>
    ///   <para>ids:ResourceUnavailableMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message indicating that a specific resource is unavailable. The same resource may be available again in the future.</para>
    /// labels<para>Resource Unavailable Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ResourceUnavailableMessage">https://w3id.org/idsa/core/ResourceUnavailableMessage</seealso>
    let ResourceUnavailableMessage =
        Prefixed_Name(ids, "ResourceUnavailableMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:RolebasedAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Role-restricted Data Usage' policy class.</para>
    /// labels<para>Role-restricted Data Usage Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RolebasedAgreement">https://w3id.org/idsa/core/RolebasedAgreement</seealso>
    let RolebasedAgreement = Prefixed_Name(ids, "RolebasedAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:RolebasedOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Role-restricted Data Usage' policy class.</para>
    /// labels<para>Role-restricted Data Usage Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RolebasedOffer">https://w3id.org/idsa/core/RolebasedOffer</seealso>
    let RolebasedOffer = Prefixed_Name(ids, "RolebasedOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:RolebasedRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Role-restricted Data Usage' policy class.</para>
    /// labels<para>Role-restricted Data Usage Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RolebasedRequest">https://w3id.org/idsa/core/RolebasedRequest</seealso>
    let RolebasedRequest = Prefixed_Name(ids, "RolebasedRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:assigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/assigner">https://w3id.org/idsa/core/assigner</seealso>
    let assigner = Prefixed_Name(ids, "assigner") |> PrefixedName
    /// <summary>
    ///   <para>ids:assignee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/assignee">https://w3id.org/idsa/core/assignee</seealso>
    let assignee = Prefixed_Name(ids, "assignee") |> PrefixedName
    /// <summary>
    ///   <para>ids:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/action">https://w3id.org/idsa/core/action</seealso>
    let action = Prefixed_Name(ids, "action") |> PrefixedName
    /// <summary>
    ///   <para>ids:SalesAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the Perpetual Data Sale policy class.</para>
    /// labels<para>Sales Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SalesAgreement">https://w3id.org/idsa/core/SalesAgreement</seealso>
    let SalesAgreement = Prefixed_Name(ids, "SalesAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:SecurityOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Security Level Restricted Policy' policy class.</para>
    /// labels<para>Security Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SecurityOffer">https://w3id.org/idsa/core/SecurityOffer</seealso>
    let SecurityOffer = Prefixed_Name(ids, "SecurityOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An office or other premise at which the organization is located</para>
    /// labels<para>Site</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Site">https://w3id.org/idsa/core/Site</seealso>
    let Site = Prefixed_Name(ids, "Site") |> PrefixedName
    /// <summary>
    ///   <para>ids:SmartDataApp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Smart DataApps are executing any kind of necessary data processing or transformation.</para>
    /// labels<para>Smart DataApp</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SmartDataApp">https://w3id.org/idsa/core/SmartDataApp</seealso>
    let SmartDataApp = Prefixed_Name(ids, "SmartDataApp") |> PrefixedName
    /// <summary>
    ///   <para>ids:SoftwareResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource (at least partially) comprising Software.</para>
    /// labels<para>Software Resource</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SoftwareResource">https://w3id.org/idsa/core/SoftwareResource</seealso>
    let SoftwareResource = Prefixed_Name(ids, "SoftwareResource") |> PrefixedName
    /// <summary>
    ///   <para>ids:SpatialAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Location Restricted Usage' policy class.</para>
    /// labels<para>Spatial Usage Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SpatialAgreement">https://w3id.org/idsa/core/SpatialAgreement</seealso>
    let SpatialAgreement = Prefixed_Name(ids, "SpatialAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:SpatialOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Location Restricted Usage' policy class.</para>
    /// labels<para>Spatial Usage Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SpatialOffer">https://w3id.org/idsa/core/SpatialOffer</seealso>
    let SpatialOffer = Prefixed_Name(ids, "SpatialOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:SwapAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractAgreement class representing the 'Data Swap' policy class.</para>
    /// labels<para>Swap Agreement</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SwapAgreement">https://w3id.org/idsa/core/SwapAgreement</seealso>
    let SwapAgreement = Prefixed_Name(ids, "SwapAgreement") |> PrefixedName
    /// <summary>
    ///   <para>ids:SwapOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractOffer class representing the 'Data Swap' policy class.</para>
    /// labels<para>Sales Offer</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SwapOffer">https://w3id.org/idsa/core/SwapOffer</seealso>
    let SwapOffer = Prefixed_Name(ids, "SwapOffer") |> PrefixedName
    /// <summary>
    ///   <para>ids:SwapRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ContractRequest class representing the 'Data Swap' policy class.</para>
    /// labels<para>Sales Request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SwapRequest">https://w3id.org/idsa/core/SwapRequest</seealso>
    let SwapRequest = Prefixed_Name(ids, "SwapRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:SystemAdapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data Apps that integrate sources and sinks of digital content maintained internally on Participant's premises with a Connector.</para>
    /// labels<para>System Adapter</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/SystemAdapter">https://w3id.org/idsa/core/SystemAdapter</seealso>
    let SystemAdapter = Prefixed_Name(ids, "SystemAdapter") |> PrefixedName
    /// <summary>
    ///   <para>ids:TextRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Representation of a textual content.</para>
    /// labels<para>Text representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/TextRepresentation">https://w3id.org/idsa/core/TextRepresentation</seealso>
    let TextRepresentation = Prefixed_Name(ids, "TextRepresentation") |> PrefixedName
    /// <summary>
    ///   <para>ids:participantCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of participants a ParIS may expose.</para>
    /// labels<para>participant catalog</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/participantCatalog">https://w3id.org/idsa/core/participantCatalog</seealso>
    let participantCatalog = Prefixed_Name(ids, "participantCatalog") |> PrefixedName
    /// <summary>
    ///   <para>ids:Participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Participant">https://w3id.org/idsa/core/Participant</seealso>
    let Participant = Prefixed_Name(ids, "Participant") |> PrefixedName

    /// <summary>
    ///   <para>ids:corporateEmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/corporateEmailAddress">https://w3id.org/idsa/core/corporateEmailAddress</seealso>
    let corporateEmailAddress =
        Prefixed_Name(ids, "corporateEmailAddress") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantCatalog">https://w3id.org/idsa/core/ParticipantCatalog</seealso>
    let ParticipantCatalog = Prefixed_Name(ids, "ParticipantCatalog") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantNotificationMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantNotificationMessage">https://w3id.org/idsa/core/ParticipantNotificationMessage</seealso>
    let ParticipantNotificationMessage =
        Prefixed_Name(ids, "ParticipantNotificationMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantCertificateRevokedMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates that a (previously certified) Participant is no more certified. This could happen, for instance, if the Certification Body revokes a granted certificate or if the certificate just expires.</para>
    /// labels<para>Participant Certificate Revoked Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantCertificateRevokedMessage">https://w3id.org/idsa/core/ParticipantCertificateRevokedMessage</seealso>
    let ParticipantCertificateRevokedMessage =
        Prefixed_Name(ids, "ParticipantCertificateRevokedMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:usageDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/usageDuration">https://w3id.org/idsa/core/usageDuration</seealso>
    let usageDuration = Prefixed_Name(ids, "usageDuration") |> PrefixedName
    /// <summary>
    ///   <para>ids:user</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The participant intending to use the data.</para>
    /// labels<para>has user</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/user">https://w3id.org/idsa/core/user</seealso>
    let user = Prefixed_Name(ids, "user") |> PrefixedName
    /// <summary>
    ///   <para>ids:Audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of audiences (recipients) used in the JWT. </para>
    /// labels<para>Audience</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/Audience">https://w3id.org/idsa/core/Audience</seealso>
    let Audience = Prefixed_Name(ids, "Audience") |> PrefixedName
    /// <summary>
    ///   <para>ids:IntegrityGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Level of integrity protection and verification of the installed software stack. Trusted boot is an example of local integrity protection, remote integrity verification comprises, for example, remote attestation.</para>
    /// labels<para>Integrity protection and verification</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/IntegrityGuarantee">https://w3id.org/idsa/core/IntegrityGuarantee</seealso>
    let IntegrityGuarantee = Prefixed_Name(ids, "IntegrityGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:IntegrityVerificationScopeGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Level/extent of verifying the software stack.</para>
    /// labels<para>Integrity verification scope</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/IntegrityVerificationScopeGuarantee">https://w3id.org/idsa/core/IntegrityVerificationScopeGuarantee</seealso>
    let IntegrityVerificationScopeGuarantee =
        Prefixed_Name(ids, "IntegrityVerificationScopeGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContentType">https://w3id.org/idsa/core/ContentType</seealso>
    let ContentType = Prefixed_Name(ids, "ContentType") |> PrefixedName
    /// <summary>
    ///   <para>ids:TokenFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Possible formats for (security-related) tokens.</para>
    /// labels<para>Token format</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/TokenFormat">https://w3id.org/idsa/core/TokenFormat</seealso>
    let TokenFormat = Prefixed_Name(ids, "TokenFormat") |> PrefixedName

    /// <summary>
    ///   <para>ids:LocalDataConfidentialityGuarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Means by which local data is protected.</para>
    /// labels<para>Local data confidentiality</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/LocalDataConfidentialityGuarantee">https://w3id.org/idsa/core/LocalDataConfidentialityGuarantee</seealso>
    let LocalDataConfidentialityGuarantee =
        Prefixed_Name(ids, "LocalDataConfidentialityGuarantee") |> PrefixedName

    /// <summary>
    ///   <para>ids:AuthStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of authentication standards that may be supported by Connectors.</para>
    /// labels<para>AuthStandard</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/AuthStandard">https://w3id.org/idsa/core/AuthStandard</seealso>
    let AuthStandard = Prefixed_Name(ids, "AuthStandard") |> PrefixedName

    /// <summary>
    ///   <para>ids:ParticipantCertificationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Level of a Participant Certification</para>
    /// labels<para>Participant Certification Level</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ParticipantCertificationLevel">https://w3id.org/idsa/core/ParticipantCertificationLevel</seealso>
    let ParticipantCertificationLevel =
        Prefixed_Name(ids, "ParticipantCertificationLevel") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contract issued by the Data Consumer requesting the usage of a Resource at particular conditions.</para>
    /// labels<para>Contract request</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractRequest">https://w3id.org/idsa/core/ContractRequest</seealso>
    let ContractRequest = Prefixed_Name(ids, "ContractRequest") |> PrefixedName
    /// <summary>
    ///   <para>ids:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Constraint">https://w3id.org/idsa/core/Constraint</seealso>
    let Constraint = Prefixed_Name(ids, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>ids:leftOperand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The left operand in a constraint expression.</para>
    /// labels<para>leftOperand</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/leftOperand">https://w3id.org/idsa/core/leftOperand</seealso>
    let leftOperand = Prefixed_Name(ids, "leftOperand") |> PrefixedName
    /// <summary>
    ///   <para>ids:operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/operator">https://w3id.org/idsa/core/operator</seealso>
    let operator = Prefixed_Name(ids, "operator") |> PrefixedName
    /// <summary>
    ///   <para>ids:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/Contract">https://w3id.org/idsa/core/Contract</seealso>
    let Contract = Prefixed_Name(ids, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>ids:permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/permission">https://w3id.org/idsa/core/permission</seealso>
    let permission = Prefixed_Name(ids, "permission") |> PrefixedName
    /// <summary>
    ///   <para>ids:prohibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/prohibition">https://w3id.org/idsa/core/prohibition</seealso>
    let prohibition = Prefixed_Name(ids, "prohibition") |> PrefixedName
    /// <summary>
    ///   <para>ids:obligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/obligation">https://w3id.org/idsa/core/obligation</seealso>
    let obligation = Prefixed_Name(ids, "obligation") |> PrefixedName
    /// <summary>
    ///   <para>ids:contractStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Absolute datetime the Contract is requested, offered or expected to start, depending on the type of Contract.</para>
    /// labels<para>Contract start</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contractStart">https://w3id.org/idsa/core/contractStart</seealso>
    let contractStart = Prefixed_Name(ids, "contractStart") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractAgreementMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message containing a contract, as an instance of ids:ContractAgreement, with resource access modalities on which two parties have agreed in the payload.</para>
    /// labels<para>Contract Agreement Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractAgreementMessage">https://w3id.org/idsa/core/ContractAgreementMessage</seealso>
    let ContractAgreementMessage =
        Prefixed_Name(ids, "ContractAgreementMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractOfferMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message containing a offered content contract (as offered by a data provider to the data consumer) in the associated payload (which is an instance of ContractOffer). In contrast to the ids:ContractResponseMessage, the ids:ContractOfferMessage is not related to a previous contract </para>
    /// labels<para>Contract Offer Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractOfferMessage">https://w3id.org/idsa/core/ContractOfferMessage</seealso>
    let ContractOfferMessage =
        Prefixed_Name(ids, "ContractOfferMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:ContractRejectionMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message indicating rejection of a contract.</para>
    /// labels<para>Contract Rejection Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/ContractRejectionMessage">https://w3id.org/idsa/core/ContractRejectionMessage</seealso>
    let ContractRejectionMessage =
        Prefixed_Name(ids, "ContractRejectionMessage") |> PrefixedName

    /// <summary>
    ///   <para>ids:RejectionMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rejection messages are specialized response messages that notify the sender of a message that processing of this message has failed.</para>
    /// labels<para>Rejection Message</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/RejectionMessage">https://w3id.org/idsa/core/RejectionMessage</seealso>
    let RejectionMessage = Prefixed_Name(ids, "RejectionMessage") |> PrefixedName
    /// <summary>
    ///   <para>ids:authUsername</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Username / ID used for authentication.</para>
    /// labels<para>auth username</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/authUsername">https://w3id.org/idsa/core/authUsername</seealso>
    let authUsername = Prefixed_Name(ids, "authUsername") |> PrefixedName
    /// <summary>
    ///   <para>ids:authorizationToken</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An authorization token like JSON Web Token.</para>
    /// labels<para>Authorization token</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/authorizationToken">https://w3id.org/idsa/core/authorizationToken</seealso>
    let authorizationToken = Prefixed_Name(ids, "authorizationToken") |> PrefixedName
    /// <summary>
    ///   <para>ids:byteSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Size of the Artifact in bytes.</para>
    /// labels<para>byte size</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/byteSize">https://w3id.org/idsa/core/byteSize</seealso>
    let byteSize = Prefixed_Name(ids, "byteSize") |> PrefixedName
    /// <summary>
    ///   <para>ids:checkSum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Checksum of the artifact</para>
    /// labels<para>checksum</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/checkSum">https://w3id.org/idsa/core/checkSum</seealso>
    let checkSum = Prefixed_Name(ids, "checkSum") |> PrefixedName

    /// <summary>
    ///   <para>ids:componentCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Certification issued for the given Infrastructure Component.</para>
    /// labels<para>component certification</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/componentCertification">https://w3id.org/idsa/core/componentCertification</seealso>
    let componentCertification =
        Prefixed_Name(ids, "componentCertification") |> PrefixedName

    /// <summary>
    ///   <para>ids:connectorDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>References to Connector which is deployed / maintained in the Configuration Model</para>
    /// labels<para>Connector description</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/connectorDescription">https://w3id.org/idsa/core/connectorDescription</seealso>
    let connectorDescription =
        Prefixed_Name(ids, "connectorDescription") |> PrefixedName

    /// <summary>
    ///   <para>ids:contentStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>IRI containing document, which defines the standard for the given Digital Content. The content is assumed to conform to that Standard.</para>
    /// labels<para>content standard</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contentStandard">https://w3id.org/idsa/core/contentStandard</seealso>
    let contentStandard = Prefixed_Name(ids, "contentStandard") |> PrefixedName
    /// <summary>
    ///   <para>ids:contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Detailed type, genre or interpretation of the Digital Content.</para>
    /// labels<para>content type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contentType">https://w3id.org/idsa/core/contentType</seealso>
    let contentType = Prefixed_Name(ids, "contentType") |> PrefixedName
    /// <summary>
    ///   <para>ids:contentVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version of the content in the payload. Use digits and semantic versioning pattern like MAJOR.MINOR.PATCH.</para>
    /// labels<para>contentVersion</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contentVersion">https://w3id.org/idsa/core/contentVersion</seealso>
    let contentVersion = Prefixed_Name(ids, "contentVersion") |> PrefixedName
    /// <summary>
    ///   <para>ids:contractAnnex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any type of resource related to the Contract.</para>
    /// labels<para>Annex to contract</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contractAnnex">https://w3id.org/idsa/core/contractAnnex</seealso>
    let contractAnnex = Prefixed_Name(ids, "contractAnnex") |> PrefixedName
    /// <summary>
    ///   <para>ids:contractDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Absolute datetime of singing the Contract.</para>
    /// labels<para>Contract date</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contractDate">https://w3id.org/idsa/core/contractDate</seealso>
    let contractDate = Prefixed_Name(ids, "contractDate") |> PrefixedName
    /// <summary>
    ///   <para>ids:contractDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Equivalent human-readable encoding of this machine-interpretable Contract.</para>
    /// labels<para>Contract document</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contractDocument">https://w3id.org/idsa/core/contractDocument</seealso>
    let contractDocument = Prefixed_Name(ids, "contractDocument") |> PrefixedName
    /// <summary>
    ///   <para>ids:contractEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Absolute datetime the Contract is requested, offered or expected to end. If omitted, the contract has to be explicitly terminated by any of the parties.</para>
    /// labels<para>Contract end</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contractEnd">https://w3id.org/idsa/core/contractEnd</seealso>
    let contractEnd = Prefixed_Name(ids, "contractEnd") |> PrefixedName

    /// <summary>
    ///   <para>ids:contractRejectionReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Human-readable text describing the reason for contract rejection.</para>
    /// labels<para>Contract Rejection Reason</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/contractRejectionReason">https://w3id.org/idsa/core/contractRejectionReason</seealso>
    let contractRejectionReason =
        Prefixed_Name(ids, "contractRejectionReason") |> PrefixedName

    /// <summary>
    ///   <para>ids:creationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date (as xsd:dateTimeStamp) when the artifact was created, i.e. persisted.</para>
    /// labels<para>creation date</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/creationDate">https://w3id.org/idsa/core/creationDate</seealso>
    let creationDate = Prefixed_Name(ids, "creationDate") |> PrefixedName
    /// <summary>
    ///   <para>ids:customLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URL reference to a custom license regulating the general usage of the Resource.</para>
    /// labels<para>Custom License</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/customLicense">https://w3id.org/idsa/core/customLicense</seealso>
    let customLicense = Prefixed_Name(ids, "customLicense") |> PrefixedName
    /// <summary>
    ///   <para>ids:dataAppInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information about the concrete data app implementation</para>
    /// labels<para>data app information</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/dataAppInformation">https://w3id.org/idsa/core/dataAppInformation</seealso>
    let dataAppInformation = Prefixed_Name(ids, "dataAppInformation") |> PrefixedName
    /// <summary>
    ///   <para>ids:dataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the data type of the Representation.</para>
    /// labels<para>Data type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/dataType">https://w3id.org/idsa/core/dataType</seealso>
    let dataType = Prefixed_Name(ids, "dataType") |> PrefixedName
    /// <summary>
    ///   <para>ids:dataTypeSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the data type schema of the Representation.</para>
    /// labels<para>Data Type Schema</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/dataTypeSchema">https://w3id.org/idsa/core/dataTypeSchema</seealso>
    let dataTypeSchema = Prefixed_Name(ids, "dataTypeSchema") |> PrefixedName
    /// <summary>
    ///   <para>ids:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/dateTime">https://w3id.org/idsa/core/dateTime</seealso>
    let dateTime = Prefixed_Name(ids, "dateTime") |> PrefixedName

    /// <summary>
    ///   <para>ids:defaultRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Default representation of the content.</para>
    /// labels<para>Default representation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/defaultRepresentation">https://w3id.org/idsa/core/defaultRepresentation</seealso>
    let defaultRepresentation =
        Prefixed_Name(ids, "defaultRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>ids:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Duration of the media resource in seconds.</para>
    /// labels<para>duration</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/duration">https://w3id.org/idsa/core/duration</seealso>
    let duration = Prefixed_Name(ids, "duration") |> PrefixedName
    /// <summary>
    ///   <para>ids:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>End of an Interval.</para>
    /// labels<para>end</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/end">https://w3id.org/idsa/core/end</seealso>
    let end_ = Prefixed_Name(ids, "end") |> PrefixedName
    /// <summary>
    ///   <para>ids:endpointArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Content instance mediated via this individual endpoint (1:1 mapping).</para>
    /// labels<para>endpoint artifact</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/endpointArtifact">https://w3id.org/idsa/core/endpointArtifact</seealso>
    let endpointArtifact = Prefixed_Name(ids, "endpointArtifact") |> PrefixedName
    /// <summary>
    ///   <para>ids:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/familyName">https://w3id.org/idsa/core/familyName</seealso>
    let familyName = Prefixed_Name(ids, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>ids:fileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the Artifcat file.</para>
    /// labels<para>file name</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/fileName">https://w3id.org/idsa/core/fileName</seealso>
    let fileName = Prefixed_Name(ids, "fileName") |> PrefixedName
    /// <summary>
    ///   <para>ids:filenameExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Suffix of a file name, typically separated by a period, indicating the nature and intended processing of the file.</para>
    /// labels<para>filename extension</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/filenameExtension">https://w3id.org/idsa/core/filenameExtension</seealso>
    let filenameExtension = Prefixed_Name(ids, "filenameExtension") |> PrefixedName
    /// <summary>
    ///   <para>ids:frameRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Video frame rate, as frames/second.</para>
    /// labels<para>frame rate</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/frameRate">https://w3id.org/idsa/core/frameRate</seealso>
    let frameRate = Prefixed_Name(ids, "frameRate") |> PrefixedName
    /// <summary>
    ///   <para>ids:givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/givenName">https://w3id.org/idsa/core/givenName</seealso>
    let givenName = Prefixed_Name(ids, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>ids:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Height of the visible frame.</para>
    /// labels<para>height</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/height">https://w3id.org/idsa/core/height</seealso>
    let height = Prefixed_Name(ids, "height") |> PrefixedName
    /// <summary>
    ///   <para>ids:homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/homepage">https://w3id.org/idsa/core/homepage</seealso>
    let homepage = Prefixed_Name(ids, "homepage") |> PrefixedName
    /// <summary>
    ///   <para>ids:httpAuthURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>HTTP authentication URI.</para>
    /// labels<para>http auth URI</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/httpAuthURI">https://w3id.org/idsa/core/httpAuthURI</seealso>
    let httpAuthURI = Prefixed_Name(ids, "httpAuthURI") |> PrefixedName
    /// <summary>
    ///   <para>ids:includedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The subject transitively asserts the object Action.</para>
    /// labels<para>is included in</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/includedIn">https://w3id.org/idsa/core/includedIn</seealso>
    let includedIn = Prefixed_Name(ids, "includedIn") |> PrefixedName
    /// <summary>
    ///   <para>ids:keyStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URI of the key store server.</para>
    /// labels<para>key store</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/keyStore">https://w3id.org/idsa/core/keyStore</seealso>
    let keyStore = Prefixed_Name(ids, "keyStore") |> PrefixedName
    /// <summary>
    ///   <para>ids:keyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of the public key.</para>
    /// labels<para>Key Type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/keyType">https://w3id.org/idsa/core/keyType</seealso>
    let keyType = Prefixed_Name(ids, "keyType") |> PrefixedName
    /// <summary>
    ///   <para>ids:keyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Binary representation of the key.</para>
    /// labels<para>Key Value</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/keyValue">https://w3id.org/idsa/core/keyValue</seealso>
    let keyValue = Prefixed_Name(ids, "keyValue") |> PrefixedName
    /// <summary>
    ///   <para>ids:lastValidDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Last date (as xsd:dateTimeStamp) the given Certification is considered valid.</para>
    /// labels<para>last valid date</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/lastValidDate">https://w3id.org/idsa/core/lastValidDate</seealso>
    let lastValidDate = Prefixed_Name(ids, "lastValidDate") |> PrefixedName
    /// <summary>
    ///   <para>ids:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Media Type of the Representation.</para>
    /// labels<para>media type</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/mediaType">https://w3id.org/idsa/core/mediaType</seealso>
    let mediaType = Prefixed_Name(ids, "mediaType") |> PrefixedName
    /// <summary>
    ///   <para>ids:membershipEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>End of the participant's IDS membership.</para>
    /// labels<para>membership end</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/membershipEnd">https://w3id.org/idsa/core/membershipEnd</seealso>
    let membershipEnd = Prefixed_Name(ids, "membershipEnd") |> PrefixedName
    /// <summary>
    ///   <para>ids:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date/time this Digital Content has been changed the last time. Only one 'modified' attribute is usually needed.</para>
    /// labels<para>modified</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/modified">https://w3id.org/idsa/core/modified</seealso>
    let modified = Prefixed_Name(ids, "modified") |> PrefixedName

    /// <summary>
    ///   <para>ids:participantCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Certification issued for the given Participant.</para>
    /// labels<para>participant certification</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/participantCertification">https://w3id.org/idsa/core/participantCertification</seealso>
    let participantCertification =
        Prefixed_Name(ids, "participantCertification") |> PrefixedName

    /// <summary>
    ///   <para>ids:participantRefinement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Conditions which needs to be satisfied that a single Participant can be seen as a member of the subject Participant. For instance, all Participants with their headquarter in Europe might be a potential consumer of GDPR-releated data.</para>
    /// labels<para>participant refinment</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/participantRefinement">https://w3id.org/idsa/core/participantRefinement</seealso>
    let participantRefinement =
        Prefixed_Name(ids, "participantRefinement") |> PrefixedName

    /// <summary>
    ///   <para>ids:path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relative path, topic or queue at which the content is published by the related host.</para>
    /// labels<para>path</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/path">https://w3id.org/idsa/core/path</seealso>
    let path = Prefixed_Name(ids, "path") |> PrefixedName
    /// <summary>
    ///   <para>ids:physicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location where the Connector is physically deployed.</para>
    /// labels<para>physicalLocation</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/physicalLocation">https://w3id.org/idsa/core/physicalLocation</seealso>
    let physicalLocation = Prefixed_Name(ids, "physicalLocation") |> PrefixedName
    /// <summary>
    ///   <para>ids:pipEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/pipEndpoint">https://w3id.org/idsa/core/pipEndpoint</seealso>
    let pipEndpoint = Prefixed_Name(ids, "pipEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>ids:primarySite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/primarySite">https://w3id.org/idsa/core/primarySite</seealso>
    let primarySite = Prefixed_Name(ids, "primarySite") |> PrefixedName
    /// <summary>
    ///   <para>ids:provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/provider">https://w3id.org/idsa/core/provider</seealso>
    let provider = Prefixed_Name(ids, "provider") |> PrefixedName
    /// <summary>
    ///   <para>ids:proxyAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/proxyAuthentication">https://w3id.org/idsa/core/proxyAuthentication</seealso>
    let proxyAuthentication = Prefixed_Name(ids, "proxyAuthentication") |> PrefixedName
    /// <summary>
    ///   <para>ids:publicKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Public Key that has been created for the Component.</para>
    /// labels<para>Public Key</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/publicKey">https://w3id.org/idsa/core/publicKey</seealso>
    let publicKey = Prefixed_Name(ids, "publicKey") |> PrefixedName
    /// <summary>
    ///   <para>ids:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/publisher">https://w3id.org/idsa/core/publisher</seealso>
    let publisher = Prefixed_Name(ids, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>ids:queryLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the language of the query.</para>
    /// labels<para>queryLanguage</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/queryLanguage">https://w3id.org/idsa/core/queryLanguage</seealso>
    let queryLanguage = Prefixed_Name(ids, "queryLanguage") |> PrefixedName
    /// <summary>
    ///   <para>ids:queryScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to the scope property of a query message, see ids:QueryScope.</para>
    /// labels<para>queryScope</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/queryScope">https://w3id.org/idsa/core/queryScope</seealso>
    let queryScope = Prefixed_Name(ids, "queryScope") |> PrefixedName
    /// <summary>
    ///   <para>ids:recipientScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to the target property of a query message, see ids:QueryTarget.</para>
    /// labels<para>recipient scope</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/recipientScope">https://w3id.org/idsa/core/recipientScope</seealso>
    let recipientScope = Prefixed_Name(ids, "recipientScope") |> PrefixedName
    /// <summary>
    ///   <para>ids:rejectionReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the reason of the rejection.</para>
    /// labels<para>rejectionReason</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/rejectionReason">https://w3id.org/idsa/core/rejectionReason</seealso>
    let rejectionReason = Prefixed_Name(ids, "rejectionReason") |> PrefixedName

    /// <summary>
    ///   <para>ids:representationStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Standards document defining the given Representation (in contrast to general Resource content). The Representation is assumed to conform to that Standard.</para>
    /// labels<para>representation standard</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/representationStandard">https://w3id.org/idsa/core/representationStandard</seealso>
    let representationStandard =
        Prefixed_Name(ids, "representationStandard") |> PrefixedName

    /// <summary>
    ///   <para>ids:requestedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The element whose metadata is requested. </para>
    /// labels<para>requested Element</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/requestedElement">https://w3id.org/idsa/core/requestedElement</seealso>
    let requestedElement = Prefixed_Name(ids, "requestedElement") |> PrefixedName
    /// <summary>
    ///   <para>ids:requester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/requester">https://w3id.org/idsa/core/requester</seealso>
    let requester = Prefixed_Name(ids, "requester") |> PrefixedName
    /// <summary>
    ///   <para>ids:revocationReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Plain Text containing the reason for revoking an existing certificate of either a connector or participant.</para>
    /// labels<para>Revocation Reason</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/revocationReason">https://w3id.org/idsa/core/revocationReason</seealso>
    let revocationReason = Prefixed_Name(ids, "revocationReason") |> PrefixedName
    /// <summary>
    ///   <para>ids:rightOperand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/rightOperand">https://w3id.org/idsa/core/rightOperand</seealso>
    let rightOperand = Prefixed_Name(ids, "rightOperand") |> PrefixedName

    /// <summary>
    ///   <para>ids:rightOperandReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/core/rightOperandReference">https://w3id.org/idsa/core/rightOperandReference</seealso>
    let rightOperandReference =
        Prefixed_Name(ids, "rightOperandReference") |> PrefixedName

    /// <summary>
    ///   <para>ids:routeConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Configuration details (e.g. contents of a config file) used to configure the route. Should be Base64 encoded.</para>
    /// labels<para>route configuration</para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/routeConfiguration">https://w3id.org/idsa/core/routeConfiguration</seealso>
    let routeConfiguration = Prefixed_Name(ids, "routeConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>ids:routeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Route description.</para>
    /// labels<para>route description </para></remarks>
    /// <seealso href="https://w3id.org/idsa/core/routeDescription">https://w3id.org/idsa/core/routeDescription</seealso>
    let routeDescription = Prefixed_Name(ids, "routeDescription") |> PrefixedName
