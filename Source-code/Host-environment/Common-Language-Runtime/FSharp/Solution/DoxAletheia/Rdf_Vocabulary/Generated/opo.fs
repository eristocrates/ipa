namespace http.online_presence.net.opo.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module opo =
    let _namespace_iri = Namespace_Iri opo |> NamespaceIRI
    /// <summary>
    ///   <para>opo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://online-presence.net/opo/ns#">http://online-presence.net/opo/ns#</seealso>
    let _prefix_iri = Prefixed_Name(opo, "") |> PrefixedName
    /// <summary>
    ///   <para>opo:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An action currently performed by the Agent (e.g., listening to music, reading a book)."</para>
    /// labels<para>"Action"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Action">http://online-presence.net/opo/ns#Action</seealso>
    let Action = Prefixed_Name(opo, "Action") |> PrefixedName
    /// <summary>
    ///   <para>opo:Active</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Activity</para>
    ///   <para>"The Agent is active on the system."</para>
    /// labels<para>"Active"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Active">http://online-presence.net/opo/ns#Active</seealso>
    let Active = Prefixed_Name(opo, "Active") |> PrefixedName
    /// <summary>
    ///   <para>opo:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"OnlineStatusComponent used to represent the state of
    /// 			Activity of the Agent (e.g., Active, Inactive,
    /// 			ProlongedInactive)."</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Activity">http://online-presence.net/opo/ns#Activity</seealso>
    let Activity = Prefixed_Name(opo, "Activity") |> PrefixedName

    /// <summary>
    ///   <para>opo:AllNotificationsPass</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Notifiability</para>
    ///   <para>"Agent can receive notifications from applications"</para>
    /// labels<para>"AllNotificationsPass"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#AllNotificationsPass">http://online-presence.net/opo/ns#AllNotificationsPass</seealso>
    let AllNotificationsPass =
        Prefixed_Name(opo, "AllNotificationsPass") |> PrefixedName

    /// <summary>
    ///   <para>opo:Available</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Disturbability</para>
    ///   <para>"The agent is not busy and therefore available for contatc by
    /// 			other Agents."</para>
    /// labels<para>"Available"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Available">http://online-presence.net/opo/ns#Available</seealso>
    let Available = Prefixed_Name(opo, "Available") |> PrefixedName

    /// <summary>
    ///   <para>opo:ConstrainedContactability</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Contactability</para>
    ///   <para>"The Agent cannot be contated by anyone on the Web, but the
    /// 			contactability is controled by some rules/policies."</para>
    /// labels<para>"ConstrainedContactability"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#ConstrainedContactability">http://online-presence.net/opo/ns#ConstrainedContactability</seealso>
    let ConstrainedContactability =
        Prefixed_Name(opo, "ConstrainedContactability") |> PrefixedName

    /// <summary>
    ///   <para>opo:ConstrainedFindability</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Findability</para>
    ///   <para>"The Agent's contact details cannot be found by anyone on
    /// 			the Web, but the findability is controled by some
    /// 			rules/policies."</para>
    /// labels<para>"ConstrainedFindability"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#ConstrainedFindability">http://online-presence.net/opo/ns#ConstrainedFindability</seealso>
    let ConstrainedFindability =
        Prefixed_Name(opo, "ConstrainedFindability") |> PrefixedName

    /// <summary>
    ///   <para>opo:Contactability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"OnlineStatusComponent used to represent the state of
    /// 			contactability of an Agent. Contatctability relates to the
    /// 			possiblity of other Agents to conatct the Agent freely or
    /// 			only with regard to some conditions."</para>
    /// labels<para>"Contactability"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Contactability">http://online-presence.net/opo/ns#Contactability</seealso>
    let Contactability = Prefixed_Name(opo, "Contactability") |> PrefixedName
    /// <summary>
    ///   <para>opo:Disturbability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"OnlineStatusComponent used to represent the wish of an Agent
    /// 			to be or not to be disturbed."</para>
    /// labels<para>"Disturbability"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Disturbability">http://online-presence.net/opo/ns#Disturbability</seealso>
    let Disturbability = Prefixed_Name(opo, "Disturbability") |> PrefixedName
    /// <summary>
    ///   <para>opo:DoNotDistrub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://online-presence.net/opo/ns#DoNotDistrub">http://online-presence.net/opo/ns#DoNotDistrub</seealso>
    let DoNotDistrub = Prefixed_Name(opo, "DoNotDistrub") |> PrefixedName
    /// <summary>
    ///   <para>opo:DoNotDisturb</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Disturbability</para>
    ///   <para>"The Agent is busy and does not want to be contacted by other
    /// 			Agents."</para>
    /// labels<para>"DoNotDisturb"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#DoNotDisturb">http://online-presence.net/opo/ns#DoNotDisturb</seealso>
    let DoNotDisturb = Prefixed_Name(opo, "DoNotDisturb") |> PrefixedName
    /// <summary>
    ///   <para>opo:Findability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The OnlinePresenceComponent used to represent the
    /// 			possibility to find contact details of an Agent in a public
    /// 			listing"</para>
    /// labels<para>"Findability"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Findability">http://online-presence.net/opo/ns#Findability</seealso>
    let Findability = Prefixed_Name(opo, "Findability") |> PrefixedName
    /// <summary>
    ///   <para>opo:FreelyContactable</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Contactability</para>
    ///   <para>"The Agent can be contacted by anyone on the Web"</para>
    /// labels<para>"FreelyContactable"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#FreelyContactable">http://online-presence.net/opo/ns#FreelyContactable</seealso>
    let FreelyContactable = Prefixed_Name(opo, "FreelyContactable") |> PrefixedName
    /// <summary>
    ///   <para>opo:Inactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Activity</para>
    ///   <para>"The Agent is inactive for at least 5 min."</para>
    /// labels<para>"Inactive"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Inactive">http://online-presence.net/opo/ns#Inactive</seealso>
    let Inactive = Prefixed_Name(opo, "Inactive") |> PrefixedName
    /// <summary>
    ///   <para>opo:Invisible</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Visibility</para>
    ///   <para>"The Agent's OnlineStatus is not visible to other Agents"</para>
    /// labels<para>"Invisible"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Invisible">http://online-presence.net/opo/ns#Invisible</seealso>
    let Invisible = Prefixed_Name(opo, "Invisible") |> PrefixedName
    /// <summary>
    ///   <para>opo:Notifiability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The OnlinePresenceComponent used to represent the attitude
    /// 			of an Agent towards interaction with applications i.e., the
    /// 			possibility of applications to show notifications."</para>
    /// labels<para>"Notifiability"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Notifiability">http://online-presence.net/opo/ns#Notifiability</seealso>
    let Notifiability = Prefixed_Name(opo, "Notifiability") |> PrefixedName

    /// <summary>
    ///   <para>opo:NotificationsConstrained</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Notifiability</para>
    ///   <para>"The acceptance of notifications from applications is somehow
    /// 			constrained (by using some rules or policies)."</para>
    /// labels<para>"NotificationsConstrained"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#NotificationsConstrained">http://online-presence.net/opo/ns#NotificationsConstrained</seealso>
    let NotificationsConstrained =
        Prefixed_Name(opo, "NotificationsConstrained") |> PrefixedName

    /// <summary>
    ///   <para>opo:NotificationsProhibited</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Notifiability</para>
    ///   <para>"Agent cannot receive any notification form applications"</para>
    /// labels<para>"NotificationsProhibited"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#NotificationsProhibited">http://online-presence.net/opo/ns#NotificationsProhibited</seealso>
    let NotificationsProhibited =
        Prefixed_Name(opo, "NotificationsProhibited") |> PrefixedName

    /// <summary>
    ///   <para>opo:OnlinePresence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"OnlinePresence, described in termes of various
    /// 			OnlinePresenceComponents to represent the attitude of an
    /// 			Agent towards interaction with other Agents and
    /// 			Applications."</para>
    /// labels<para>"OnlinePresence"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#OnlinePresence">http://online-presence.net/opo/ns#OnlinePresence</seealso>
    let OnlinePresence = Prefixed_Name(opo, "OnlinePresence") |> PrefixedName

    /// <summary>
    ///   <para>opo:OnlinePresenceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A component of OnlinePresence used to represent one of its
    /// 			dimensions."</para>
    /// labels<para>"OnlinePresenceComponent"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#OnlinePresenceComponent">http://online-presence.net/opo/ns#OnlinePresenceComponent</seealso>
    let OnlinePresenceComponent =
        Prefixed_Name(opo, "OnlinePresenceComponent") |> PrefixedName

    /// <summary>
    ///   <para>opo:OnlineStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The OnlinePresenceComponent used to represent the attitude
    /// 			of an Agent towards the possibility of communication with
    /// 			other Agents. The OnlineStatus is defined by its components."</para>
    /// labels<para>"OnlineStatus"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#OnlineStatus">http://online-presence.net/opo/ns#OnlineStatus</seealso>
    let OnlineStatus = Prefixed_Name(opo, "OnlineStatus") |> PrefixedName

    /// <summary>
    ///   <para>opo:OnlineStatusComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The component of the OnlineStatus representing one of its
    /// 			dimensions."</para>
    /// labels<para>"OnlineStatusComponent"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#OnlineStatusComponent">http://online-presence.net/opo/ns#OnlineStatusComponent</seealso>
    let OnlineStatusComponent =
        Prefixed_Name(opo, "OnlineStatusComponent") |> PrefixedName

    /// <summary>
    ///   <para>opo:ProlongedInactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Activity</para>
    ///   <para>"The Agent is inactive for at least 20 min."</para>
    /// labels<para>"ProlongedInactive"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#ProlongedInactive">http://online-presence.net/opo/ns#ProlongedInactive</seealso>
    let ProlongedInactive = Prefixed_Name(opo, "ProlongedInactive") |> PrefixedName
    /// <summary>
    ///   <para>opo:PubliclyFindable</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Findability</para>
    ///   <para>"The Agent's contact details canbe found by anyone on the
    /// 			Web"</para>
    /// labels<para>"PubliclyFindable"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#PubliclyFindable">http://online-presence.net/opo/ns#PubliclyFindable</seealso>
    let PubliclyFindable = Prefixed_Name(opo, "PubliclyFindable") |> PrefixedName
    /// <summary>
    ///   <para>opo:SharingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of people belonging to a space for sharing online psresence data - the intended audience of data."</para>
    /// labels<para>"SharingSpace"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#SharingSpace">http://online-presence.net/opo/ns#SharingSpace</seealso>
    let SharingSpace = Prefixed_Name(opo, "SharingSpace") |> PrefixedName
    /// <summary>
    ///   <para>opo:SourceOfPublishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The source that can publish Online Presence data."</para>
    /// labels<para>"SourceOfPublishing"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#SourceOfPublishing">http://online-presence.net/opo/ns#SourceOfPublishing</seealso>
    let SourceOfPublishing = Prefixed_Name(opo, "SourceOfPublishing") |> PrefixedName
    /// <summary>
    ///   <para>opo:StatusMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A status message that cannot be commented on."</para>
    /// labels<para>"StatusMessage"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#StatusMessage">http://online-presence.net/opo/ns#StatusMessage</seealso>
    let StatusMessage = Prefixed_Name(opo, "StatusMessage") |> PrefixedName
    /// <summary>
    ///   <para>opo:Visibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"OnlineStatusComponent used to represent the possiblity of
    /// 			others to see the OnlineStatus of the Agent"</para>
    /// labels<para>"Visibility"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Visibility">http://online-presence.net/opo/ns#Visibility</seealso>
    let Visibility = Prefixed_Name(opo, "Visibility") |> PrefixedName
    /// <summary>
    ///   <para>opo:Visible</para>
    /// </summary>
    /// <remarks>
    ///   <para>opo:Visibility</para>
    ///   <para>"The Agent's OnlineStatus is visible to other Agents"</para>
    /// labels<para>"Visible"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#Visible">http://online-presence.net/opo/ns#Visible</seealso>
    let Visible = Prefixed_Name(opo, "Visible") |> PrefixedName

    /// <summary>
    ///   <para>opo:attendedOrganisedEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The organised event attended by people in the Sharing Space."</para>
    /// labels<para>"Attended Organised Event"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#attendedOrganisedEvent">http://online-presence.net/opo/ns#attendedOrganisedEvent</seealso>
    let attendedOrganisedEvent =
        Prefixed_Name(opo, "attendedOrganisedEvent") |> PrefixedName

    /// <summary>
    ///   <para>opo:avatar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The graphical representation of the Agent used to depict him
    /// 			in online systems."</para>
    /// labels<para>"avatar"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#avatar">http://online-presence.net/opo/ns#avatar</seealso>
    let avatar = Prefixed_Name(opo, "avatar") |> PrefixedName
    /// <summary>
    ///   <para>opo:basedNear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location where members of the Sharing Space are based."</para>
    /// labels<para>"Based Near"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#basedNear">http://online-presence.net/opo/ns#basedNear</seealso>
    let basedNear = Prefixed_Name(opo, "basedNear") |> PrefixedName
    /// <summary>
    ///   <para>opo:closestFriendsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Person who's closest friends belog to the Sharing Space."</para>
    /// labels<para>"Closest Friends Of"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#closestFriendsOf">http://online-presence.net/opo/ns#closestFriendsOf</seealso>
    let closestFriendsOf = Prefixed_Name(opo, "closestFriendsOf") |> PrefixedName
    /// <summary>
    ///   <para>opo:commonInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An interst shared by people in the Sharing Space."</para>
    /// labels<para>"Common Interest"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#commonInterest">http://online-presence.net/opo/ns#commonInterest</seealso>
    let commonInterest = Prefixed_Name(opo, "commonInterest") |> PrefixedName
    /// <summary>
    ///   <para>opo:currentAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Current action performed by the Agent"</para>
    /// labels<para>"currentAction"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#currentAction">http://online-presence.net/opo/ns#currentAction</seealso>
    let currentAction = Prefixed_Name(opo, "currentAction") |> PrefixedName
    /// <summary>
    ///   <para>opo:currentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Current location of the Agent"</para>
    /// labels<para>"currentLocation"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#currentLocation">http://online-presence.net/opo/ns#currentLocation</seealso>
    let currentLocation = Prefixed_Name(opo, "currentLocation") |> PrefixedName
    /// <summary>
    ///   <para>opo:currentlyIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The current location of people in the Sharing Space."</para>
    /// labels<para>"Currently In"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#currentlyIn">http://online-presence.net/opo/ns#currentlyIn</seealso>
    let currentlyIn = Prefixed_Name(opo, "currentlyIn") |> PrefixedName
    /// <summary>
    ///   <para>opo:customMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A message associated with the OnlinePresence, often used in
    /// 			chat programs and social networks as custom title as well as in microblogging as status message."</para>
    /// labels<para>"customMessage"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#customMessage">http://online-presence.net/opo/ns#customMessage</seealso>
    let customMessage = Prefixed_Name(opo, "customMessage") |> PrefixedName
    /// <summary>
    ///   <para>opo:declaredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Agent that declared the OnlinePresence"</para>
    /// labels<para>"declaredBy"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#declaredBy">http://online-presence.net/opo/ns#declaredBy</seealso>
    let declaredBy = Prefixed_Name(opo, "declaredBy") |> PrefixedName
    /// <summary>
    ///   <para>opo:declaredOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The sioc:UserAccount account where the OnlinePresence was declared."</para>
    /// labels<para>"declaredOn"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#declaredOn">http://online-presence.net/opo/ns#declaredOn</seealso>
    let declaredOn = Prefixed_Name(opo, "declaredOn") |> PrefixedName

    /// <summary>
    ///   <para>opo:declaresOnlinePresence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The OnlinePresence declared by the Agent"</para>
    /// labels<para>"declaresOnlinePresence"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#declaresOnlinePresence">http://online-presence.net/opo/ns#declaresOnlinePresence</seealso>
    let declaresOnlinePresence =
        Prefixed_Name(opo, "declaresOnlinePresence") |> PrefixedName

    /// <summary>
    ///   <para>opo:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The estimated duration of the OnlinePresence after the
    /// 			startTime"</para>
    /// labels<para>"duration"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#duration">http://online-presence.net/opo/ns#duration</seealso>
    let duration = Prefixed_Name(opo, "duration") |> PrefixedName
    /// <summary>
    ///   <para>opo:familyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Person who's family members belog to the Sharing Space."</para>
    /// labels<para>"Family Of"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#familyOf">http://online-presence.net/opo/ns#familyOf</seealso>
    let familyOf = Prefixed_Name(opo, "familyOf") |> PrefixedName

    /// <summary>
    ///   <para>opo:hasPresenceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"OnlinePresenceComponent included in this OnlinePresence"</para>
    /// labels<para>"hasOnlinePresence"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#hasPresenceComponent">http://online-presence.net/opo/ns#hasPresenceComponent</seealso>
    let hasPresenceComponent =
        Prefixed_Name(opo, "hasPresenceComponent") |> PrefixedName

    /// <summary>
    ///   <para>opo:hasStatusComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"OnlineStatusComponent included in this OnlineStatus"</para>
    /// labels<para>"hasStatusComponent"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#hasStatusComponent">http://online-presence.net/opo/ns#hasStatusComponent</seealso>
    let hasStatusComponent = Prefixed_Name(opo, "hasStatusComponent") |> PrefixedName
    /// <summary>
    ///   <para>opo:inactivityPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Period of inactivity on a certain service"</para>
    /// labels<para>"inactivityPeriod"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#inactivityPeriod">http://online-presence.net/opo/ns#inactivityPeriod</seealso>
    let inactivityPeriod = Prefixed_Name(opo, "inactivityPeriod") |> PrefixedName
    /// <summary>
    ///   <para>opo:intendedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A group of people belonging to a space for sharing online psresence data - the intended audience of presence information."</para>
    /// labels<para>"intendedFor"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#intendedFor">http://online-presence.net/opo/ns#intendedFor</seealso>
    let intendedFor = Prefixed_Name(opo, "intendedFor") |> PrefixedName

    /// <summary>
    ///   <para>opo:isPresenceComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The OnlinePresence that has this OnlinePresenceComponent"</para>
    /// labels<para>"isPresenceComponentOf"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#isPresenceComponentOf">http://online-presence.net/opo/ns#isPresenceComponentOf</seealso>
    let isPresenceComponentOf =
        Prefixed_Name(opo, "isPresenceComponentOf") |> PrefixedName

    /// <summary>
    ///   <para>opo:isStatusComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The OnlineStatus that includes this OnlineStatusComponent."</para>
    /// labels<para>"isStatusComponentOf"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#isStatusComponentOf">http://online-presence.net/opo/ns#isStatusComponentOf</seealso>
    let isStatusComponentOf = Prefixed_Name(opo, "isStatusComponentOf") |> PrefixedName
    /// <summary>
    ///   <para>opo:onlineStatusName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A name used by chat systems to distinguish their various
    /// 			statuses."</para>
    /// labels<para>"OnlineStatusName"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#onlineStatusName">http://online-presence.net/opo/ns#onlineStatusName</seealso>
    let onlineStatusName = Prefixed_Name(opo, "onlineStatusName") |> PrefixedName
    /// <summary>
    ///   <para>opo:publishedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The source from which the OnlinePresence is declared (e.g., a mobile device)"</para>
    /// labels<para>"publishedFrom"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#publishedFrom">http://online-presence.net/opo/ns#publishedFrom</seealso>
    let publishedFrom = Prefixed_Name(opo, "publishedFrom") |> PrefixedName
    /// <summary>
    ///   <para>opo:schoolHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The homepage of school attended by people in the Sharing Space."</para>
    /// labels<para>"School Homepage"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#schoolHomepage">http://online-presence.net/opo/ns#schoolHomepage</seealso>
    let schoolHomepage = Prefixed_Name(opo, "schoolHomepage") |> PrefixedName
    /// <summary>
    ///   <para>opo:sourceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the description of the SourceOfPublishing."</para>
    /// labels<para>"sourceDescription"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#sourceDescription">http://online-presence.net/opo/ns#sourceDescription</seealso>
    let sourceDescription = Prefixed_Name(opo, "sourceDescription") |> PrefixedName
    /// <summary>
    ///   <para>opo:sourceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The name of the SourceOfPublishing."</para>
    /// labels<para>"sourceName"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#sourceName">http://online-presence.net/opo/ns#sourceName</seealso>
    let sourceName = Prefixed_Name(opo, "sourceName") |> PrefixedName
    /// <summary>
    ///   <para>opo:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The time when the OnlinePresence started"</para>
    /// labels<para>"startTime"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#startTime">http://online-presence.net/opo/ns#startTime</seealso>
    let startTime = Prefixed_Name(opo, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>opo:workplaceHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The homepage of workplace of people in the Sharing Space."</para>
    /// labels<para>"Workplace Homepage"</para></remarks>
    /// <seealso href="http://online-presence.net/opo/ns#workplaceHomepage">http://online-presence.net/opo/ns#workplaceHomepage</seealso>
    let workplaceHomepage = Prefixed_Name(opo, "workplaceHomepage") |> PrefixedName
