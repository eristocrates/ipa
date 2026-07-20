namespace http.online_presence.net.opo.ns.hash

open DoxAletheia

module opo =
    let _namespace_name = "http://online-presence.net/opo/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Agent cannot receive any notification form applications
    /// <see href="http://online-presence.net/opo/ns#NotificationsProhibited"></see></summary>
    let NotificationsProhibited = _prefix "NotificationsProhibited"
    /// <summary>
    /// The acceptance of notifications from applications is somehow
    /// 			constrained (by using some rules or policies).
    /// <see href="http://online-presence.net/opo/ns#NotificationsConstrained"></see></summary>
    let NotificationsConstrained = _prefix "NotificationsConstrained"
    /// <summary>
    /// The Agent's OnlineStatus is visible to other Agents
    /// <see href="http://online-presence.net/opo/ns#Visible"></see></summary>
    let Visible = _prefix "Visible"
    /// <summary>
    /// The Agent's OnlineStatus is not visible to other Agents
    /// <see href="http://online-presence.net/opo/ns#Invisible"></see></summary>
    let Invisible = _prefix "Invisible"
    /// <summary>
    /// Agent can receive notifications from applications
    /// <see href="http://online-presence.net/opo/ns#AllNotificationsPass"></see></summary>
    let AllNotificationsPass = _prefix "AllNotificationsPass"
    /// <summary>
    /// The Agent is active on the system.
    /// <see href="http://online-presence.net/opo/ns#Active"></see></summary>
    let Active = _prefix "Active"
    /// <summary>
    /// The Agent is inactive for at least 20 min.
    /// <see href="http://online-presence.net/opo/ns#ProlongedInactive"></see></summary>
    let ProlongedInactive = _prefix "ProlongedInactive"
    /// <summary>
    ///   <see href="http://online-presence.net/opo/ns#DoNotDistrub"></see>
    /// </summary>
    let DoNotDistrub = _prefix "DoNotDistrub"
    /// <summary>
    /// The agent is not busy and therefore available for contatc by
    /// 			other Agents.
    /// <see href="http://online-presence.net/opo/ns#Available"></see></summary>
    let Available = _prefix "Available"
    /// <summary>
    /// The Agent is inactive for at least 5 min.
    /// <see href="http://online-presence.net/opo/ns#Inactive"></see></summary>
    let Inactive = _prefix "Inactive"
    /// <summary>
    /// The Agent can be contacted by anyone on the Web
    /// <see href="http://online-presence.net/opo/ns#FreelyContactable"></see></summary>
    let FreelyContactable = _prefix "FreelyContactable"
    /// <summary>
    /// The Agent cannot be contated by anyone on the Web, but the
    /// 			contactability is controled by some rules/policies.
    /// <see href="http://online-presence.net/opo/ns#ConstrainedContactability"></see></summary>
    let ConstrainedContactability = _prefix "ConstrainedContactability"
    /// <summary>
    /// The Agent's contact details canbe found by anyone on the
    /// 			Web
    /// <see href="http://online-presence.net/opo/ns#PubliclyFindable"></see></summary>
    let PubliclyFindable = _prefix "PubliclyFindable"
    /// <summary>
    /// The Agent's contact details cannot be found by anyone on
    /// 			the Web, but the findability is controled by some
    /// 			rules/policies.
    /// <see href="http://online-presence.net/opo/ns#ConstrainedFindability"></see></summary>
    let ConstrainedFindability = _prefix "ConstrainedFindability"
    /// <summary>
    /// An action currently performed by the Agent (e.g., listening to music, reading a book).
    /// <see href="http://online-presence.net/opo/ns#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// The source that can publish Online Presence data.
    /// <see href="http://online-presence.net/opo/ns#SourceOfPublishing"></see></summary>
    let SourceOfPublishing = _prefix "SourceOfPublishing"
    /// <summary>
    /// OnlinePresence, described in termes of various
    /// 			OnlinePresenceComponents to represent the attitude of an
    /// 			Agent towards interaction with other Agents and
    /// 			Applications.
    /// <see href="http://online-presence.net/opo/ns#OnlinePresence"></see></summary>
    let OnlinePresence = _prefix "OnlinePresence"
    /// <summary>
    /// OnlineStatusComponent used to represent the state of
    /// 			Activity of the Agent (e.g., Active, Inactive,
    /// 			ProlongedInactive).
    /// <see href="http://online-presence.net/opo/ns#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// The component of the OnlineStatus representing one of its
    /// 			dimensions.
    /// <see href="http://online-presence.net/opo/ns#OnlineStatusComponent"></see></summary>
    let OnlineStatusComponent = _prefix "OnlineStatusComponent"
    /// <summary>
    /// OnlineStatusComponent used to represent the possiblity of
    /// 			others to see the OnlineStatus of the Agent
    /// <see href="http://online-presence.net/opo/ns#Visibility"></see></summary>
    let Visibility = _prefix "Visibility"
    /// <summary>
    /// OnlineStatusComponent used to represent the wish of an Agent
    /// 			to be or not to be disturbed.
    /// <see href="http://online-presence.net/opo/ns#Disturbability"></see></summary>
    let Disturbability = _prefix "Disturbability"
    /// <summary>
    /// OnlineStatusComponent used to represent the state of
    /// 			contactability of an Agent. Contatctability relates to the
    /// 			possiblity of other Agents to conatct the Agent freely or
    /// 			only with regard to some conditions.
    /// <see href="http://online-presence.net/opo/ns#Contactability"></see></summary>
    let Contactability = _prefix "Contactability"
    /// <summary>
    /// The OnlinePresenceComponent used to represent the attitude
    /// 			of an Agent towards interaction with applications i.e., the
    /// 			possibility of applications to show notifications.
    /// <see href="http://online-presence.net/opo/ns#Notifiability"></see></summary>
    let Notifiability = _prefix "Notifiability"
    /// <summary>
    /// The OnlinePresenceComponent used to represent the
    /// 			possibility to find contact details of an Agent in a public
    /// 			listing
    /// <see href="http://online-presence.net/opo/ns#Findability"></see></summary>
    let Findability = _prefix "Findability"
    /// <summary>
    /// The Agent is busy and does not want to be contacted by other
    /// 			Agents.
    /// <see href="http://online-presence.net/opo/ns#DoNotDisturb"></see></summary>
    let DoNotDisturb = _prefix "DoNotDisturb"
    /// <summary>
    /// A component of OnlinePresence used to represent one of its
    /// 			dimensions.
    /// <see href="http://online-presence.net/opo/ns#OnlinePresenceComponent"></see></summary>
    let OnlinePresenceComponent = _prefix "OnlinePresenceComponent"
    /// <summary>
    /// The OnlinePresenceComponent used to represent the attitude
    /// 			of an Agent towards the possibility of communication with
    /// 			other Agents. The OnlineStatus is defined by its components.
    /// <see href="http://online-presence.net/opo/ns#OnlineStatus"></see></summary>
    let OnlineStatus = _prefix "OnlineStatus"
    /// <summary>
    /// Period of inactivity on a certain service
    /// <see href="http://online-presence.net/opo/ns#inactivityPeriod"></see></summary>
    let inactivityPeriod = _prefix "inactivityPeriod"
    /// <summary>
    /// OnlineStatusComponent included in this OnlineStatus
    /// <see href="http://online-presence.net/opo/ns#hasStatusComponent"></see></summary>
    let hasStatusComponent = _prefix "hasStatusComponent"
    /// <summary>
    /// A group of people belonging to a space for sharing online psresence data - the intended audience of data.
    /// <see href="http://online-presence.net/opo/ns#SharingSpace"></see></summary>
    let SharingSpace = _prefix "SharingSpace"
    /// <summary>
    /// A status message that cannot be commented on.
    /// <see href="http://online-presence.net/opo/ns#StatusMessage"></see></summary>
    let StatusMessage = _prefix "StatusMessage"
    /// <summary>
    /// The organised event attended by people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#attendedOrganisedEvent"></see></summary>
    let attendedOrganisedEvent = _prefix "attendedOrganisedEvent"
    /// <summary>
    /// The graphical representation of the Agent used to depict him
    /// 			in online systems.
    /// <see href="http://online-presence.net/opo/ns#avatar"></see></summary>
    let avatar = _prefix "avatar"
    /// <summary>
    /// The location where members of the Sharing Space are based.
    /// <see href="http://online-presence.net/opo/ns#basedNear"></see></summary>
    let basedNear = _prefix "basedNear"
    /// <summary>
    /// The Person who's closest friends belog to the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#closestFriendsOf"></see></summary>
    let closestFriendsOf = _prefix "closestFriendsOf"
    /// <summary>
    /// An interst shared by people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#commonInterest"></see></summary>
    let commonInterest = _prefix "commonInterest"
    /// <summary>
    /// Current action performed by the Agent
    /// <see href="http://online-presence.net/opo/ns#currentAction"></see></summary>
    let currentAction = _prefix "currentAction"
    /// <summary>
    /// Current location of the Agent
    /// <see href="http://online-presence.net/opo/ns#currentLocation"></see></summary>
    let currentLocation = _prefix "currentLocation"
    /// <summary>
    /// The current location of people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#currentlyIn"></see></summary>
    let currentlyIn = _prefix "currentlyIn"
    /// <summary>
    /// A message associated with the OnlinePresence, often used in
    /// 			chat programs and social networks as custom title as well as in microblogging as status message.
    /// <see href="http://online-presence.net/opo/ns#customMessage"></see></summary>
    let customMessage = _prefix "customMessage"
    /// <summary>
    /// The Agent that declared the OnlinePresence
    /// <see href="http://online-presence.net/opo/ns#declaredBy"></see></summary>
    let declaredBy = _prefix "declaredBy"
    /// <summary>
    /// The OnlinePresence declared by the Agent
    /// <see href="http://online-presence.net/opo/ns#declaresOnlinePresence"></see></summary>
    let declaresOnlinePresence = _prefix "declaresOnlinePresence"
    /// <summary>
    /// The sioc:UserAccount account where the OnlinePresence was declared.
    /// <see href="http://online-presence.net/opo/ns#declaredOn"></see></summary>
    let declaredOn = _prefix "declaredOn"
    /// <summary>
    /// The estimated duration of the OnlinePresence after the
    /// 			startTime
    /// <see href="http://online-presence.net/opo/ns#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// The Person who's family members belog to the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#familyOf"></see></summary>
    let familyOf = _prefix "familyOf"
    /// <summary>
    /// OnlinePresenceComponent included in this OnlinePresence
    /// <see href="http://online-presence.net/opo/ns#hasPresenceComponent"></see></summary>
    let hasPresenceComponent = _prefix "hasPresenceComponent"
    /// <summary>
    /// The OnlinePresence that has this OnlinePresenceComponent
    /// <see href="http://online-presence.net/opo/ns#isPresenceComponentOf"></see></summary>
    let isPresenceComponentOf = _prefix "isPresenceComponentOf"
    /// <summary>
    /// The OnlineStatus that includes this OnlineStatusComponent.
    /// <see href="http://online-presence.net/opo/ns#isStatusComponentOf"></see></summary>
    let isStatusComponentOf = _prefix "isStatusComponentOf"
    /// <summary>
    /// A group of people belonging to a space for sharing online psresence data - the intended audience of presence information.
    /// <see href="http://online-presence.net/opo/ns#intendedFor"></see></summary>
    let intendedFor = _prefix "intendedFor"
    /// <summary>
    /// A name used by chat systems to distinguish their various
    /// 			statuses.
    /// <see href="http://online-presence.net/opo/ns#onlineStatusName"></see></summary>
    let onlineStatusName = _prefix "onlineStatusName"
    /// <summary>
    /// The source from which the OnlinePresence is declared (e.g., a mobile device)
    /// <see href="http://online-presence.net/opo/ns#publishedFrom"></see></summary>
    let publishedFrom = _prefix "publishedFrom"
    /// <summary>
    /// The homepage of school attended by people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#schoolHomepage"></see></summary>
    let schoolHomepage = _prefix "schoolHomepage"
    /// <summary>
    /// the description of the SourceOfPublishing.
    /// <see href="http://online-presence.net/opo/ns#sourceDescription"></see></summary>
    let sourceDescription = _prefix "sourceDescription"
    /// <summary>
    /// The name of the SourceOfPublishing.
    /// <see href="http://online-presence.net/opo/ns#sourceName"></see></summary>
    let sourceName = _prefix "sourceName"
    /// <summary>
    /// The time when the OnlinePresence started
    /// <see href="http://online-presence.net/opo/ns#startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// The homepage of workplace of people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#workplaceHomepage"></see></summary>
    let workplaceHomepage = _prefix "workplaceHomepage"
