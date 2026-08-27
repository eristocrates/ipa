namespace http.www.w3.org.ns.solid.interop.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module interop =
    let _namespace_iri = Namespace_Iri interop |> NamespaceIRI
    /// <summary>
    ///   <para>interop:</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Terms for application interoperability in Solid"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#">http://www.w3.org/ns/solid/interop#</seealso>
    let _prefix_iri = Prefixed_Name(interop, "") |> PrefixedName

    /// <summary>
    ///   <para>interop:AccessAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Records an access authorization made by a Social Agent to another Agent for data in their control"</para>
    /// labels<para>"Access Authorization"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessAuthorization">http://www.w3.org/ns/solid/interop#AccessAuthorization</seealso>
    let AccessAuthorization =
        Prefixed_Name(interop, "AccessAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>interop:AccessDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Describes the association between a SKOS label and an Access Need"</para>
    /// labels<para>"Access Description"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessDescription">http://www.w3.org/ns/solid/interop#AccessDescription</seealso>
    let AccessDescription = Prefixed_Name(interop, "AccessDescription") |> PrefixedName

    /// <summary>
    ///   <para>interop:AccessDescriptionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A set of SKOS poly-hierarchies to describe AccessNeeds in an AccessNeedGroup"</para>
    /// labels<para>"Access Description Set"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessDescriptionSet">http://www.w3.org/ns/solid/interop#AccessDescriptionSet</seealso>
    let AccessDescriptionSet =
        Prefixed_Name(interop, "AccessDescriptionSet") |> PrefixedName

    /// <summary>
    ///   <para>interop:AccessGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Provides an Agent with a detailed description of access that has been granted to them"</para>
    /// labels<para>"Access Grant"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessGrant">http://www.w3.org/ns/solid/interop#AccessGrant</seealso>
    let AccessGrant = Prefixed_Name(interop, "AccessGrant") |> PrefixedName
    /// <summary>
    ///   <para>interop:AccessNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Request for access to a type of data at a specified access level"</para>
    /// labels<para>"Access Need"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessNeed">http://www.w3.org/ns/solid/interop#AccessNeed</seealso>
    let AccessNeed = Prefixed_Name(interop, "AccessNeed") |> PrefixedName

    /// <summary>
    ///   <para>interop:AccessNeedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Describes the association between a SKOS label and an Access Need"</para>
    /// labels<para>"Access Need Description"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessNeedDescription">http://www.w3.org/ns/solid/interop#AccessNeedDescription</seealso>
    let AccessNeedDescription =
        Prefixed_Name(interop, "AccessNeedDescription") |> PrefixedName

    /// <summary>
    ///   <para>interop:AccessNeedGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A grouping of access needs"</para>
    /// labels<para>"Access Need Group"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessNeedGroup">http://www.w3.org/ns/solid/interop#AccessNeedGroup</seealso>
    let AccessNeedGroup = Prefixed_Name(interop, "AccessNeedGroup") |> PrefixedName

    /// <summary>
    ///   <para>interop:AccessNeedGroupDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Describes the association between a SKOS label and an Access Need Group"</para>
    /// labels<para>"Access Need Group Description"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessNeedGroupDescription">http://www.w3.org/ns/solid/interop#AccessNeedGroupDescription</seealso>
    let AccessNeedGroupDescription =
        Prefixed_Name(interop, "AccessNeedGroupDescription") |> PrefixedName

    /// <summary>
    ///   <para>interop:AccessOptional</para>
    /// </summary>
    /// <remarks>
    ///   <para>"AccessNeed is not required"</para>
    /// labels<para>"Access Optional"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessOptional">http://www.w3.org/ns/solid/interop#AccessOptional</seealso>
    let AccessOptional = Prefixed_Name(interop, "AccessOptional") |> PrefixedName
    /// <summary>
    ///   <para>interop:AccessReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A record of access granted by another Social Agent in the ecosystem"</para>
    /// labels<para>"Access Receipt"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessReceipt">http://www.w3.org/ns/solid/interop#AccessReceipt</seealso>
    let AccessReceipt = Prefixed_Name(interop, "AccessReceipt") |> PrefixedName
    /// <summary>
    ///   <para>interop:AccessRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Request for access from one agent to another"</para>
    /// labels<para>"Access Request"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessRequest">http://www.w3.org/ns/solid/interop#AccessRequest</seealso>
    let AccessRequest = Prefixed_Name(interop, "AccessRequest") |> PrefixedName
    /// <summary>
    ///   <para>interop:AccessRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>"AccessNeed is required"</para>
    /// labels<para>"Access Required"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessRequired">http://www.w3.org/ns/solid/interop#AccessRequired</seealso>
    let AccessRequired = Prefixed_Name(interop, "AccessRequired") |> PrefixedName
    /// <summary>
    ///   <para>interop:AccessScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Class of access scopes"</para>
    /// labels<para>"AccessScope"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AccessScope">http://www.w3.org/ns/solid/interop#AccessScope</seealso>
    let AccessScope = Prefixed_Name(interop, "AccessScope") |> PrefixedName
    /// <summary>
    ///   <para>interop:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An agent profile for the Solid Ecosystem"</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#Agent">http://www.w3.org/ns/solid/interop#Agent</seealso>
    let Agent = Prefixed_Name(interop, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>interop:AgentRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>"An individual member of an Agent Registry"</para>
    /// labels<para>"Agent Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AgentRegistration">http://www.w3.org/ns/solid/interop#AgentRegistration</seealso>
    let AgentRegistration = Prefixed_Name(interop, "AgentRegistration") |> PrefixedName
    /// <summary>
    ///   <para>interop:AgentRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A collection of Agent Registrations"</para>
    /// labels<para>"Agent Registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AgentRegistry">http://www.w3.org/ns/solid/interop#AgentRegistry</seealso>
    let AgentRegistry = Prefixed_Name(interop, "AgentRegistry") |> PrefixedName
    /// <summary>
    ///   <para>interop:All</para>
    /// </summary>
    /// <remarks>
    ///   <para>interop:AccessScope</para>
    ///   <para>"All of the data owners data of a specified type, and all data shared with the owner of that type, across the owners registries"</para>
    /// labels<para>"All"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#All">http://www.w3.org/ns/solid/interop#All</seealso>
    let All = Prefixed_Name(interop, "All") |> PrefixedName
    /// <summary>
    ///   <para>interop:AllFromAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>interop:AccessScope</para>
    ///   <para>"All data of a given type shared by a specified Social Agent with the owner, across that Social Agents registries"</para>
    /// labels<para>"All From Agent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AllFromAgent">http://www.w3.org/ns/solid/interop#AllFromAgent</seealso>
    let AllFromAgent = Prefixed_Name(interop, "AllFromAgent") |> PrefixedName
    /// <summary>
    ///   <para>interop:AllFromRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>interop:AccessScope</para>
    ///   <para>"All of the data owners data of a specified type in a specified Data Registry"</para>
    /// labels<para>"All From Registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AllFromRegistry">http://www.w3.org/ns/solid/interop#AllFromRegistry</seealso>
    let AllFromRegistry = Prefixed_Name(interop, "AllFromRegistry") |> PrefixedName
    /// <summary>
    ///   <para>interop:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A client software application in the Solid Ecosystem"</para>
    /// labels<para>"Application"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#Application">http://www.w3.org/ns/solid/interop#Application</seealso>
    let Application = Prefixed_Name(interop, "Application") |> PrefixedName

    /// <summary>
    ///   <para>interop:ApplicationRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A registered Application in an Agent Registry"</para>
    /// labels<para>"Application Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#ApplicationRegistration">http://www.w3.org/ns/solid/interop#ApplicationRegistration</seealso>
    let ApplicationRegistration =
        Prefixed_Name(interop, "ApplicationRegistration") |> PrefixedName

    /// <summary>
    ///   <para>interop:AuthorizationAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Service used by end user to manage access"</para>
    /// labels<para>"AuthorizationAgent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AuthorizationAgent">http://www.w3.org/ns/solid/interop#AuthorizationAgent</seealso>
    let AuthorizationAgent =
        Prefixed_Name(interop, "AuthorizationAgent") |> PrefixedName

    /// <summary>
    ///   <para>interop:AuthorizationRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A collection of Access Authorizations"</para>
    /// labels<para>"Authorization Registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#AuthorizationRegistry">http://www.w3.org/ns/solid/interop#AuthorizationRegistry</seealso>
    let AuthorizationRegistry =
        Prefixed_Name(interop, "AuthorizationRegistry") |> PrefixedName

    /// <summary>
    ///   <para>interop:DataAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Records the decision of a Social Agent to grant access to a specific type of data in their control"</para>
    /// labels<para>"Data Authorization"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#DataAuthorization">http://www.w3.org/ns/solid/interop#DataAuthorization</seealso>
    let DataAuthorization = Prefixed_Name(interop, "DataAuthorization") |> PrefixedName
    /// <summary>
    ///   <para>interop:DataGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Associates a DataRegistration with an AccessGrant"</para>
    /// labels<para>"Data Grant"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#DataGrant">http://www.w3.org/ns/solid/interop#DataGrant</seealso>
    let DataGrant = Prefixed_Name(interop, "DataGrant") |> PrefixedName
    /// <summary>
    ///   <para>interop:DataRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>"An individual member of a Data Registry"</para>
    /// labels<para>"Data Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#DataRegistration">http://www.w3.org/ns/solid/interop#DataRegistration</seealso>
    let DataRegistration = Prefixed_Name(interop, "DataRegistration") |> PrefixedName
    /// <summary>
    ///   <para>interop:DataRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A collection of Data Registration instances"</para>
    /// labels<para>"Data Registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#DataRegistry">http://www.w3.org/ns/solid/interop#DataRegistry</seealso>
    let DataRegistry = Prefixed_Name(interop, "DataRegistry") |> PrefixedName

    /// <summary>
    ///   <para>interop:DelegatedDataGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A type of Data Grant where a grantee re-shares or delegates access they have received to another Agent"</para>
    /// labels<para>"Delegated Data Grant"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#DelegatedDataGrant">http://www.w3.org/ns/solid/interop#DelegatedDataGrant</seealso>
    let DelegatedDataGrant =
        Prefixed_Name(interop, "DelegatedDataGrant") |> PrefixedName

    /// <summary>
    ///   <para>interop:Inherited</para>
    /// </summary>
    /// <remarks>
    ///   <para>interop:AccessScope</para>
    ///   <para>"Only Data Instances of the data owners that are associated with Data Instances allowed by another authorization or grant"</para>
    /// labels<para>"Inherited"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#Inherited">http://www.w3.org/ns/solid/interop#Inherited</seealso>
    let Inherited = Prefixed_Name(interop, "Inherited") |> PrefixedName
    /// <summary>
    ///   <para>interop:NoAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>interop:AccessScope</para>
    ///   <para>"No access"</para>
    /// labels<para>"No Access"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#NoAccess">http://www.w3.org/ns/solid/interop#NoAccess</seealso>
    let NoAccess = Prefixed_Name(interop, "NoAccess") |> PrefixedName
    /// <summary>
    ///   <para>interop:PersonalAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Access is for personal use of the Social Agent"</para>
    /// labels<para>"Personal Access"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#PersonalAccess">http://www.w3.org/ns/solid/interop#PersonalAccess</seealso>
    let PersonalAccess = Prefixed_Name(interop, "PersonalAccess") |> PrefixedName
    /// <summary>
    ///   <para>interop:Registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An individual member of a Registry"</para>
    /// labels<para>"Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#Registration">http://www.w3.org/ns/solid/interop#Registration</seealso>
    let Registration = Prefixed_Name(interop, "Registration") |> PrefixedName
    /// <summary>
    ///   <para>interop:Registry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A collection of things pertinent to the operation of the Solid ecosystem"</para>
    /// labels<para>"Registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#Registry">http://www.w3.org/ns/solid/interop#Registry</seealso>
    let Registry = Prefixed_Name(interop, "Registry") |> PrefixedName
    /// <summary>
    ///   <para>interop:RegistrySet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A collection of Registry instances"</para>
    /// labels<para>"Registry Set"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#RegistrySet">http://www.w3.org/ns/solid/interop#RegistrySet</seealso>
    let RegistrySet = Prefixed_Name(interop, "RegistrySet") |> PrefixedName

    /// <summary>
    ///   <para>interop:SelectedFromRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>interop:AccessScope</para>
    ///   <para>"Only specified Data Instances of the data owners of a given type in a specified Data Registry"</para>
    /// labels<para>"Selected From Registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#SelectedFromRegistry">http://www.w3.org/ns/solid/interop#SelectedFromRegistry</seealso>
    let SelectedFromRegistry =
        Prefixed_Name(interop, "SelectedFromRegistry") |> PrefixedName

    /// <summary>
    ///   <para>interop:SharedAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Access is to be shared with other Social Agents"</para>
    /// labels<para>"Shared Access"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#SharedAccess">http://www.w3.org/ns/solid/interop#SharedAccess</seealso>
    let SharedAccess = Prefixed_Name(interop, "SharedAccess") |> PrefixedName
    /// <summary>
    ///   <para>interop:SocialAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A strongly identifiable individual, group, or organization"</para>
    /// labels<para>"Social Agent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#SocialAgent">http://www.w3.org/ns/solid/interop#SocialAgent</seealso>
    let SocialAgent = Prefixed_Name(interop, "SocialAgent") |> PrefixedName

    /// <summary>
    ///   <para>interop:SocialAgentInvitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>"An invited Social Agent in an Agent Registry"</para>
    /// labels<para>"Social Agent Invitation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#SocialAgentInvitation">http://www.w3.org/ns/solid/interop#SocialAgentInvitation</seealso>
    let SocialAgentInvitation =
        Prefixed_Name(interop, "SocialAgentInvitation") |> PrefixedName

    /// <summary>
    ///   <para>interop:SocialAgentRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>"An registered Social Agent in an Agent Registry"</para>
    /// labels<para>"Social Agent Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#SocialAgentRegistration">http://www.w3.org/ns/solid/interop#SocialAgentRegistration</seealso>
    let SocialAgentRegistration =
        Prefixed_Name(interop, "SocialAgentRegistration") |> PrefixedName

    /// <summary>
    ///   <para>interop:accessMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A requested acl:mode of access for an AccessNeed"</para>
    /// labels<para>"Access Mode"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#accessMode">http://www.w3.org/ns/solid/interop#accessMode</seealso>
    let accessMode = Prefixed_Name(interop, "accessMode") |> PrefixedName
    /// <summary>
    ///   <para>interop:accessNecessity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the necessity of the AccessNeed"</para>
    /// labels<para>"Requested Access Necessity"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#accessNecessity">http://www.w3.org/ns/solid/interop#accessNecessity</seealso>
    let accessNecessity = Prefixed_Name(interop, "accessNecessity") |> PrefixedName
    /// <summary>
    ///   <para>interop:accessScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Provides context types for sharing scenarios"</para>
    /// labels<para>"Access Scenario"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#accessScenario">http://www.w3.org/ns/solid/interop#accessScenario</seealso>
    let accessScenario = Prefixed_Name(interop, "accessScenario") |> PrefixedName
    /// <summary>
    ///   <para>interop:applicationAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Author of the Application"</para>
    /// labels<para>"Application Author"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#applicationAuthor">http://www.w3.org/ns/solid/interop#applicationAuthor</seealso>
    let applicationAuthor = Prefixed_Name(interop, "applicationAuthor") |> PrefixedName

    /// <summary>
    ///   <para>interop:applicationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Description of the Application"</para>
    /// labels<para>"Application Description"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#applicationDescription">http://www.w3.org/ns/solid/interop#applicationDescription</seealso>
    let applicationDescription =
        Prefixed_Name(interop, "applicationDescription") |> PrefixedName

    /// <summary>
    ///   <para>interop:applicationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Name of the Application"</para>
    /// labels<para>"Application Name"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#applicationName">http://www.w3.org/ns/solid/interop#applicationName</seealso>
    let applicationName = Prefixed_Name(interop, "applicationName") |> PrefixedName

    /// <summary>
    ///   <para>interop:applicationThumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Thumbnail for the application"</para>
    /// labels<para>"Application Thumbnail"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#applicationThumbnail">http://www.w3.org/ns/solid/interop#applicationThumbnail</seealso>
    let applicationThumbnail =
        Prefixed_Name(interop, "applicationThumbnail") |> PrefixedName

    /// <summary>
    ///   <para>interop:authenticatesAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Agent or mode the Application authenticates as"</para>
    /// labels<para>"Authenticates As"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#authenticatesAs">http://www.w3.org/ns/solid/interop#authenticatesAs</seealso>
    let authenticatesAs = Prefixed_Name(interop, "authenticatesAs") |> PrefixedName
    /// <summary>
    ///   <para>interop:creatorAccessMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An additional requested acl:mode of access for the creator of a resource"</para>
    /// labels<para>"Creator Access Mode"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#creatorAccessMode">http://www.w3.org/ns/solid/interop#creatorAccessMode</seealso>
    let creatorAccessMode = Prefixed_Name(interop, "creatorAccessMode") |> PrefixedName
    /// <summary>
    ///   <para>interop:dataOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the Social Agent that owns a given data set"</para>
    /// labels<para>"Data Owner"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#dataOwner">http://www.w3.org/ns/solid/interop#dataOwner</seealso>
    let dataOwner = Prefixed_Name(interop, "dataOwner") |> PrefixedName
    /// <summary>
    ///   <para>interop:delegationOfGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Data Grant which is being delegated"</para>
    /// labels<para>"Delegation of Grant"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#delegationOfGrant">http://www.w3.org/ns/solid/interop#delegationOfGrant</seealso>
    let delegationOfGrant = Prefixed_Name(interop, "delegationOfGrant") |> PrefixedName
    /// <summary>
    ///   <para>interop:fromSocialAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Social Agent sending a message"</para>
    /// labels<para>"From Social Agent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#fromSocialAgent">http://www.w3.org/ns/solid/interop#fromSocialAgent</seealso>
    let fromSocialAgent = Prefixed_Name(interop, "fromSocialAgent") |> PrefixedName
    /// <summary>
    ///   <para>interop:grantedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Time that authorization or grant was granted"</para>
    /// labels<para>"Granted At"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#grantedAt">http://www.w3.org/ns/solid/interop#grantedAt</seealso>
    let grantedAt = Prefixed_Name(interop, "grantedAt") |> PrefixedName
    /// <summary>
    ///   <para>interop:grantedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Social agent that granted authorization or grant"</para>
    /// labels<para>"Granted By"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#grantedBy">http://www.w3.org/ns/solid/interop#grantedBy</seealso>
    let grantedBy = Prefixed_Name(interop, "grantedBy") |> PrefixedName
    /// <summary>
    ///   <para>interop:grantedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Application used by a Social Agent to grant authorization or issue access grant"</para>
    /// labels<para>"Granted With"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#grantedWith">http://www.w3.org/ns/solid/interop#grantedWith</seealso>
    let grantedWith = Prefixed_Name(interop, "grantedWith") |> PrefixedName
    /// <summary>
    ///   <para>interop:grantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Recipient of authorization or grant"</para>
    /// labels<para>"Granted At"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#grantee">http://www.w3.org/ns/solid/interop#grantee</seealso>
    let grantee = Prefixed_Name(interop, "grantee") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAccessAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Links to an AccessAuthorization in an Authorization Registry"</para>
    /// labels<para>"Has Access Authorization"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAccessAuthorization">http://www.w3.org/ns/solid/interop#hasAccessAuthorization</seealso>
    let hasAccessAuthorization =
        Prefixed_Name(interop, "hasAccessAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAccessDescriptionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Link to an Access Description Set"</para>
    /// labels<para>"Has Access Description Set"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAccessDescriptionSet">http://www.w3.org/ns/solid/interop#hasAccessDescriptionSet</seealso>
    let hasAccessDescriptionSet =
        Prefixed_Name(interop, "hasAccessDescriptionSet") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAccessNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to an Access Need"</para>
    /// labels<para>"Has Access Need"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAccessNeed">http://www.w3.org/ns/solid/interop#hasAccessNeed</seealso>
    let hasAccessNeed = Prefixed_Name(interop, "hasAccessNeed") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAccessNeedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to an AccessNeedDescription"</para>
    /// labels<para>"Has Access Need Description"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAccessNeedDescription">http://www.w3.org/ns/solid/interop#hasAccessNeedDescription</seealso>
    let hasAccessNeedDescription =
        Prefixed_Name(interop, "hasAccessNeedDescription") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAccessNeedGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to AccessNeedGroup"</para>
    /// labels<para>"Has Access Need Group"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAccessNeedGroup">http://www.w3.org/ns/solid/interop#hasAccessNeedGroup</seealso>
    let hasAccessNeedGroup =
        Prefixed_Name(interop, "hasAccessNeedGroup") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAccessNeedGroupDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to an AccessNeedGroupDescription"</para>
    /// labels<para>"Has Access Need Group Description"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAccessNeedGroupDescription">http://www.w3.org/ns/solid/interop#hasAccessNeedGroupDescription</seealso>
    let hasAccessNeedGroupDescription =
        Prefixed_Name(interop, "hasAccessNeedGroupDescription") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAgentRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Links to an Agent Registry in a registry set"</para>
    /// labels<para>"Has Agent Registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAgentRegistry">http://www.w3.org/ns/solid/interop#hasAgentRegistry</seealso>
    let hasAgentRegistry = Prefixed_Name(interop, "hasAgentRegistry") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasApplicationRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Links to an AgentRegistration for an Application"</para>
    /// labels<para>"Has Application Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasApplicationRegistration">http://www.w3.org/ns/solid/interop#hasApplicationRegistration</seealso>
    let hasApplicationRegistration =
        Prefixed_Name(interop, "hasApplicationRegistration") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAuthorizationAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Links a Social Agent to their Authorization Agent"</para>
    /// labels<para>"Has authorization agent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAuthorizationAgent">http://www.w3.org/ns/solid/interop#hasAuthorizationAgent</seealso>
    let hasAuthorizationAgent =
        Prefixed_Name(interop, "hasAuthorizationAgent") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAuthorizationCallbackEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URI expected to be used for redirect after authorization"</para>
    /// labels<para>"Has Authorization Callback Endoint"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAuthorizationCallbackEndpoint">http://www.w3.org/ns/solid/interop#hasAuthorizationCallbackEndpoint</seealso>
    let hasAuthorizationCallbackEndpoint =
        Prefixed_Name(interop, "hasAuthorizationCallbackEndpoint") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAuthorizationRedirectEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"URI expected to be used for redirect to obtain authorization"</para>
    /// labels<para>"Has Authorization Redirect Endpoint"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAuthorizationRedirectEndpoint">http://www.w3.org/ns/solid/interop#hasAuthorizationRedirectEndpoint</seealso>
    let hasAuthorizationRedirectEndpoint =
        Prefixed_Name(interop, "hasAuthorizationRedirectEndpoint") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasAuthorizationRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Links to an Authorization Registry in a registry set"</para>
    /// labels<para>"Has Authorization Registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasAuthorizationRegistry">http://www.w3.org/ns/solid/interop#hasAuthorizationRegistry</seealso>
    let hasAuthorizationRegistry =
        Prefixed_Name(interop, "hasAuthorizationRegistry") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasDataAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Link to a DataAuthorization"</para>
    /// labels<para>"Has Data Authorization"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasDataAuthorization">http://www.w3.org/ns/solid/interop#hasDataAuthorization</seealso>
    let hasDataAuthorization =
        Prefixed_Name(interop, "hasDataAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasDataGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to a Data Grant associated with an Access Grant"</para>
    /// labels<para>"Has Data Grant"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasDataGrant">http://www.w3.org/ns/solid/interop#hasDataGrant</seealso>
    let hasDataGrant = Prefixed_Name(interop, "hasDataGrant") |> PrefixedName
    /// <summary>
    ///   <para>interop:hasDataInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to instances of the shape tree in a data registration"</para>
    /// labels<para>"Data Instance"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasDataInstance">http://www.w3.org/ns/solid/interop#hasDataInstance</seealso>
    let hasDataInstance = Prefixed_Name(interop, "hasDataInstance") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasDataRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Links to a DataRegistration in a Data Registry"</para>
    /// labels<para>"Has Data Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasDataRegistration">http://www.w3.org/ns/solid/interop#hasDataRegistration</seealso>
    let hasDataRegistration =
        Prefixed_Name(interop, "hasDataRegistration") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasDataRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Links to an Data Registry in a registry set"</para>
    /// labels<para>"Has Data registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasDataRegistry">http://www.w3.org/ns/solid/interop#hasDataRegistry</seealso>
    let hasDataRegistry = Prefixed_Name(interop, "hasDataRegistry") |> PrefixedName
    /// <summary>
    ///   <para>interop:hasRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to a registration in a given registry"</para>
    /// labels<para>"Has registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasRegistration">http://www.w3.org/ns/solid/interop#hasRegistration</seealso>
    let hasRegistration = Prefixed_Name(interop, "hasRegistration") |> PrefixedName
    /// <summary>
    ///   <para>interop:hasRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to a registry in a registry set"</para>
    /// labels<para>"Has registry"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasRegistry">http://www.w3.org/ns/solid/interop#hasRegistry</seealso>
    let hasRegistry = Prefixed_Name(interop, "hasRegistry") |> PrefixedName
    /// <summary>
    ///   <para>interop:hasRegistrySet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a Social Agent to their registry set"</para>
    /// labels<para>"Has Registry Set"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasRegistrySet">http://www.w3.org/ns/solid/interop#hasRegistrySet</seealso>
    let hasRegistrySet = Prefixed_Name(interop, "hasRegistrySet") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasShapeTreeDecorator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to a ShapeTreeDecorator"</para>
    /// labels<para>"Has Shape Tree Decorator"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasShapeTreeDecorator">http://www.w3.org/ns/solid/interop#hasShapeTreeDecorator</seealso>
    let hasShapeTreeDecorator =
        Prefixed_Name(interop, "hasShapeTreeDecorator") |> PrefixedName

    /// <summary>
    ///   <para>interop:hasSocialAgentRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Links to an AgentRegistration for a SocialAgent"</para>
    /// labels<para>"Has Social Agent Registration"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#hasSocialAgentRegistration">http://www.w3.org/ns/solid/interop#hasSocialAgentRegistration</seealso>
    let hasSocialAgentRegistration =
        Prefixed_Name(interop, "hasSocialAgentRegistration") |> PrefixedName

    /// <summary>
    ///   <para>interop:inAccessDescriptionSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Access Description Set the description belongs to"</para>
    /// labels<para>"In Access Description Set"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#inAccessDescriptionSet">http://www.w3.org/ns/solid/interop#inAccessDescriptionSet</seealso>
    let inAccessDescriptionSet =
        Prefixed_Name(interop, "inAccessDescriptionSet") |> PrefixedName

    /// <summary>
    ///   <para>interop:inAccessNeedGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the AccessNeedGroup the AccessNeed belongs to"</para>
    /// labels<para>"In Access Need Group"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#inAccessNeedGroup">http://www.w3.org/ns/solid/interop#inAccessNeedGroup</seealso>
    let inAccessNeedGroup = Prefixed_Name(interop, "inAccessNeedGroup") |> PrefixedName

    /// <summary>
    ///   <para>interop:inheritsFromAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Data Authorization to inherit from"</para>
    /// labels<para>"Inherits From Authorization"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#inheritsFromAuthorization">http://www.w3.org/ns/solid/interop#inheritsFromAuthorization</seealso>
    let inheritsFromAuthorization =
        Prefixed_Name(interop, "inheritsFromAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>interop:inheritsFromGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to a Data Grant that another Data Grant inherits from"</para>
    /// labels<para>"Inherits From Grant"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#inheritsFromGrant">http://www.w3.org/ns/solid/interop#inheritsFromGrant</seealso>
    let inheritsFromGrant = Prefixed_Name(interop, "inheritsFromGrant") |> PrefixedName
    /// <summary>
    ///   <para>interop:inheritsFromNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to an Access Need that another Access Need inherits from"</para>
    /// labels<para>"Inherits From Need"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#inheritsFromNeed">http://www.w3.org/ns/solid/interop#inheritsFromNeed</seealso>
    let inheritsFromNeed = Prefixed_Name(interop, "inheritsFromNeed") |> PrefixedName
    /// <summary>
    ///   <para>interop:registeredAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to the Application registered by an ApplicationRegistration"</para>
    /// labels<para>"Registered Agent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#registeredAgent">http://www.w3.org/ns/solid/interop#registeredAgent</seealso>
    let registeredAgent = Prefixed_Name(interop, "registeredAgent") |> PrefixedName
    /// <summary>
    ///   <para>interop:registeredAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Data and time the registration was created"</para>
    /// labels<para>"Registered At"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#registeredAt">http://www.w3.org/ns/solid/interop#registeredAt</seealso>
    let registeredAt = Prefixed_Name(interop, "registeredAt") |> PrefixedName
    /// <summary>
    ///   <para>interop:registeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to the Social Agent that created the registration"</para>
    /// labels<para>"Registered By"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#registeredBy">http://www.w3.org/ns/solid/interop#registeredBy</seealso>
    let registeredBy = Prefixed_Name(interop, "registeredBy") |> PrefixedName

    /// <summary>
    ///   <para>interop:registeredShapeTree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to the relevant shape tree"</para>
    /// labels<para>"Registered Shape Tree"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#registeredShapeTree">http://www.w3.org/ns/solid/interop#registeredShapeTree</seealso>
    let registeredShapeTree =
        Prefixed_Name(interop, "registeredShapeTree") |> PrefixedName

    /// <summary>
    ///   <para>interop:registeredWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to the client Application that was used to create the registration"</para>
    /// labels<para>"Registered With"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#registeredWith">http://www.w3.org/ns/solid/interop#registeredWith</seealso>
    let registeredWith = Prefixed_Name(interop, "registeredWith") |> PrefixedName
    /// <summary>
    ///   <para>interop:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to a previous immutable resource that has been superseded"</para>
    /// labels<para>"Replaces"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#replaces">http://www.w3.org/ns/solid/interop#replaces</seealso>
    let replaces = Prefixed_Name(interop, "replaces") |> PrefixedName

    /// <summary>
    ///   <para>interop:satisfiesAccessNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to an AccessNeed that the grant satisfies"</para>
    /// labels<para>"Satisfies Access Need"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#satisfiesAccessNeed">http://www.w3.org/ns/solid/interop#satisfiesAccessNeed</seealso>
    let satisfiesAccessNeed =
        Prefixed_Name(interop, "satisfiesAccessNeed") |> PrefixedName

    /// <summary>
    ///   <para>interop:scopeOfAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the access scope of a Data Authorization"</para>
    /// labels<para>"Scope of Authorization"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#scopeOfAuthorization">http://www.w3.org/ns/solid/interop#scopeOfAuthorization</seealso>
    let scopeOfAuthorization =
        Prefixed_Name(interop, "scopeOfAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>interop:scopeOfGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to a scope identifier for one of the grant types"</para>
    /// labels<para>"Scope of Grant"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#scopeOfGrant">http://www.w3.org/ns/solid/interop#scopeOfGrant</seealso>
    let scopeOfGrant = Prefixed_Name(interop, "scopeOfGrant") |> PrefixedName
    /// <summary>
    ///   <para>interop:updatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Date and time the registration was updated"</para>
    /// labels<para>"Updated At"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#updatedAt">http://www.w3.org/ns/solid/interop#updatedAt</seealso>
    let updatedAt = Prefixed_Name(interop, "updatedAt") |> PrefixedName
    /// <summary>
    ///   <para>interop:usesLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Language code"</para>
    /// labels<para>"Uses Language"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#usesLanguage">http://www.w3.org/ns/solid/interop#usesLanguage</seealso>
    let usesLanguage = Prefixed_Name(interop, "usesLanguage") |> PrefixedName
    /// <summary>
    ///   <para>interop:viaSocialAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Social Agent providing access on behalf of fromAgent"</para>
    /// labels<para>"Via Social Agent"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/interop#viaSocialAgent">http://www.w3.org/ns/solid/interop#viaSocialAgent</seealso>
    let viaSocialAgent = Prefixed_Name(interop, "viaSocialAgent") |> PrefixedName
