namespace http.online_presence.net.opo.ns.hash

open DoxAletheia.Rdf_Vocabulary

module opo =
    let _namespace_name = "http://online-presence.net/opo/ns#"

    /// <summary>
    /// Agent cannot receive any notification form applications
    /// <see href="http://online-presence.net/opo/ns#NotificationsProhibited"></see></summary>
    let NotificationsProhibited =
        Namespaced_IRI.parse _namespace_name "NotificationsProhibited" |> NamespacedName

    /// <summary>
    /// The acceptance of notifications from applications is somehow
    /// 			constrained (by using some rules or policies).
    /// <see href="http://online-presence.net/opo/ns#NotificationsConstrained"></see></summary>
    let NotificationsConstrained =
        Namespaced_IRI.parse _namespace_name "NotificationsConstrained" |> NamespacedName

    /// <summary>
    /// The Agent's OnlineStatus is visible to other Agents
    /// <see href="http://online-presence.net/opo/ns#Visible"></see></summary>
    let Visible = Namespaced_IRI.parse _namespace_name "Visible" |> NamespacedName
    /// <summary>
    /// The Agent's OnlineStatus is not visible to other Agents
    /// <see href="http://online-presence.net/opo/ns#Invisible"></see></summary>
    let Invisible = Namespaced_IRI.parse _namespace_name "Invisible" |> NamespacedName

    /// <summary>
    /// Agent can receive notifications from applications
    /// <see href="http://online-presence.net/opo/ns#AllNotificationsPass"></see></summary>
    let AllNotificationsPass =
        Namespaced_IRI.parse _namespace_name "AllNotificationsPass" |> NamespacedName

    /// <summary>
    /// The Agent is active on the system.
    /// <see href="http://online-presence.net/opo/ns#Active"></see></summary>
    let Active = Namespaced_IRI.parse _namespace_name "Active" |> NamespacedName

    /// <summary>
    /// The Agent is inactive for at least 20 min.
    /// <see href="http://online-presence.net/opo/ns#ProlongedInactive"></see></summary>
    let ProlongedInactive =
        Namespaced_IRI.parse _namespace_name "ProlongedInactive" |> NamespacedName

    /// <summary>
    ///   <see href="http://online-presence.net/opo/ns#DoNotDistrub"></see>
    /// </summary>
    let DoNotDistrub =
        Namespaced_IRI.parse _namespace_name "DoNotDistrub" |> NamespacedName

    /// <summary>
    /// The agent is not busy and therefore available for contatc by
    /// 			other Agents.
    /// <see href="http://online-presence.net/opo/ns#Available"></see></summary>
    let Available = Namespaced_IRI.parse _namespace_name "Available" |> NamespacedName
    /// <summary>
    /// The Agent is inactive for at least 5 min.
    /// <see href="http://online-presence.net/opo/ns#Inactive"></see></summary>
    let Inactive = Namespaced_IRI.parse _namespace_name "Inactive" |> NamespacedName

    /// <summary>
    /// The Agent can be contacted by anyone on the Web
    /// <see href="http://online-presence.net/opo/ns#FreelyContactable"></see></summary>
    let FreelyContactable =
        Namespaced_IRI.parse _namespace_name "FreelyContactable" |> NamespacedName

    /// <summary>
    /// The Agent cannot be contated by anyone on the Web, but the
    /// 			contactability is controled by some rules/policies.
    /// <see href="http://online-presence.net/opo/ns#ConstrainedContactability"></see></summary>
    let ConstrainedContactability =
        Namespaced_IRI.parse _namespace_name "ConstrainedContactability" |> NamespacedName

    /// <summary>
    /// The Agent's contact details canbe found by anyone on the
    /// 			Web
    /// <see href="http://online-presence.net/opo/ns#PubliclyFindable"></see></summary>
    let PubliclyFindable =
        Namespaced_IRI.parse _namespace_name "PubliclyFindable" |> NamespacedName

    /// <summary>
    /// The Agent's contact details cannot be found by anyone on
    /// 			the Web, but the findability is controled by some
    /// 			rules/policies.
    /// <see href="http://online-presence.net/opo/ns#ConstrainedFindability"></see></summary>
    let ConstrainedFindability =
        Namespaced_IRI.parse _namespace_name "ConstrainedFindability" |> NamespacedName

    /// <summary>
    /// An action currently performed by the Agent (e.g., listening to music, reading a book).
    /// <see href="http://online-presence.net/opo/ns#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    /// The source that can publish Online Presence data.
    /// <see href="http://online-presence.net/opo/ns#SourceOfPublishing"></see></summary>
    let SourceOfPublishing =
        Namespaced_IRI.parse _namespace_name "SourceOfPublishing" |> NamespacedName

    /// <summary>
    /// OnlinePresence, described in termes of various
    /// 			OnlinePresenceComponents to represent the attitude of an
    /// 			Agent towards interaction with other Agents and
    /// 			Applications.
    /// <see href="http://online-presence.net/opo/ns#OnlinePresence"></see></summary>
    let OnlinePresence =
        Namespaced_IRI.parse _namespace_name "OnlinePresence" |> NamespacedName

    /// <summary>
    /// OnlineStatusComponent used to represent the state of
    /// 			Activity of the Agent (e.g., Active, Inactive,
    /// 			ProlongedInactive).
    /// <see href="http://online-presence.net/opo/ns#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    /// The component of the OnlineStatus representing one of its
    /// 			dimensions.
    /// <see href="http://online-presence.net/opo/ns#OnlineStatusComponent"></see></summary>
    let OnlineStatusComponent =
        Namespaced_IRI.parse _namespace_name "OnlineStatusComponent" |> NamespacedName

    /// <summary>
    /// OnlineStatusComponent used to represent the possiblity of
    /// 			others to see the OnlineStatus of the Agent
    /// <see href="http://online-presence.net/opo/ns#Visibility"></see></summary>
    let Visibility = Namespaced_IRI.parse _namespace_name "Visibility" |> NamespacedName

    /// <summary>
    /// OnlineStatusComponent used to represent the wish of an Agent
    /// 			to be or not to be disturbed.
    /// <see href="http://online-presence.net/opo/ns#Disturbability"></see></summary>
    let Disturbability =
        Namespaced_IRI.parse _namespace_name "Disturbability" |> NamespacedName

    /// <summary>
    /// OnlineStatusComponent used to represent the state of
    /// 			contactability of an Agent. Contatctability relates to the
    /// 			possiblity of other Agents to conatct the Agent freely or
    /// 			only with regard to some conditions.
    /// <see href="http://online-presence.net/opo/ns#Contactability"></see></summary>
    let Contactability =
        Namespaced_IRI.parse _namespace_name "Contactability" |> NamespacedName

    /// <summary>
    /// The OnlinePresenceComponent used to represent the attitude
    /// 			of an Agent towards interaction with applications i.e., the
    /// 			possibility of applications to show notifications.
    /// <see href="http://online-presence.net/opo/ns#Notifiability"></see></summary>
    let Notifiability =
        Namespaced_IRI.parse _namespace_name "Notifiability" |> NamespacedName

    /// <summary>
    /// The OnlinePresenceComponent used to represent the
    /// 			possibility to find contact details of an Agent in a public
    /// 			listing
    /// <see href="http://online-presence.net/opo/ns#Findability"></see></summary>
    let Findability =
        Namespaced_IRI.parse _namespace_name "Findability" |> NamespacedName

    /// <summary>
    /// The Agent is busy and does not want to be contacted by other
    /// 			Agents.
    /// <see href="http://online-presence.net/opo/ns#DoNotDisturb"></see></summary>
    let DoNotDisturb =
        Namespaced_IRI.parse _namespace_name "DoNotDisturb" |> NamespacedName

    /// <summary>
    /// A component of OnlinePresence used to represent one of its
    /// 			dimensions.
    /// <see href="http://online-presence.net/opo/ns#OnlinePresenceComponent"></see></summary>
    let OnlinePresenceComponent =
        Namespaced_IRI.parse _namespace_name "OnlinePresenceComponent" |> NamespacedName

    /// <summary>
    /// The OnlinePresenceComponent used to represent the attitude
    /// 			of an Agent towards the possibility of communication with
    /// 			other Agents. The OnlineStatus is defined by its components.
    /// <see href="http://online-presence.net/opo/ns#OnlineStatus"></see></summary>
    let OnlineStatus =
        Namespaced_IRI.parse _namespace_name "OnlineStatus" |> NamespacedName

    /// <summary>
    /// Period of inactivity on a certain service
    /// <see href="http://online-presence.net/opo/ns#inactivityPeriod"></see></summary>
    let inactivityPeriod =
        Namespaced_IRI.parse _namespace_name "inactivityPeriod" |> NamespacedName

    /// <summary>
    /// OnlineStatusComponent included in this OnlineStatus
    /// <see href="http://online-presence.net/opo/ns#hasStatusComponent"></see></summary>
    let hasStatusComponent =
        Namespaced_IRI.parse _namespace_name "hasStatusComponent" |> NamespacedName

    /// <summary>
    /// A group of people belonging to a space for sharing online psresence data - the intended audience of data.
    /// <see href="http://online-presence.net/opo/ns#SharingSpace"></see></summary>
    let SharingSpace =
        Namespaced_IRI.parse _namespace_name "SharingSpace" |> NamespacedName

    /// <summary>
    /// A status message that cannot be commented on.
    /// <see href="http://online-presence.net/opo/ns#StatusMessage"></see></summary>
    let StatusMessage =
        Namespaced_IRI.parse _namespace_name "StatusMessage" |> NamespacedName

    /// <summary>
    /// The organised event attended by people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#attendedOrganisedEvent"></see></summary>
    let attendedOrganisedEvent =
        Namespaced_IRI.parse _namespace_name "attendedOrganisedEvent" |> NamespacedName

    /// <summary>
    /// The graphical representation of the Agent used to depict him
    /// 			in online systems.
    /// <see href="http://online-presence.net/opo/ns#avatar"></see></summary>
    let avatar = Namespaced_IRI.parse _namespace_name "avatar" |> NamespacedName
    /// <summary>
    /// The location where members of the Sharing Space are based.
    /// <see href="http://online-presence.net/opo/ns#basedNear"></see></summary>
    let basedNear = Namespaced_IRI.parse _namespace_name "basedNear" |> NamespacedName

    /// <summary>
    /// The Person who's closest friends belog to the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#closestFriendsOf"></see></summary>
    let closestFriendsOf =
        Namespaced_IRI.parse _namespace_name "closestFriendsOf" |> NamespacedName

    /// <summary>
    /// An interst shared by people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#commonInterest"></see></summary>
    let commonInterest =
        Namespaced_IRI.parse _namespace_name "commonInterest" |> NamespacedName

    /// <summary>
    /// Current action performed by the Agent
    /// <see href="http://online-presence.net/opo/ns#currentAction"></see></summary>
    let currentAction =
        Namespaced_IRI.parse _namespace_name "currentAction" |> NamespacedName

    /// <summary>
    /// Current location of the Agent
    /// <see href="http://online-presence.net/opo/ns#currentLocation"></see></summary>
    let currentLocation =
        Namespaced_IRI.parse _namespace_name "currentLocation" |> NamespacedName

    /// <summary>
    /// The current location of people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#currentlyIn"></see></summary>
    let currentlyIn =
        Namespaced_IRI.parse _namespace_name "currentlyIn" |> NamespacedName

    /// <summary>
    /// A message associated with the OnlinePresence, often used in
    /// 			chat programs and social networks as custom title as well as in microblogging as status message.
    /// <see href="http://online-presence.net/opo/ns#customMessage"></see></summary>
    let customMessage =
        Namespaced_IRI.parse _namespace_name "customMessage" |> NamespacedName

    /// <summary>
    /// The Agent that declared the OnlinePresence
    /// <see href="http://online-presence.net/opo/ns#declaredBy"></see></summary>
    let declaredBy = Namespaced_IRI.parse _namespace_name "declaredBy" |> NamespacedName

    /// <summary>
    /// The OnlinePresence declared by the Agent
    /// <see href="http://online-presence.net/opo/ns#declaresOnlinePresence"></see></summary>
    let declaresOnlinePresence =
        Namespaced_IRI.parse _namespace_name "declaresOnlinePresence" |> NamespacedName

    /// <summary>
    /// The sioc:UserAccount account where the OnlinePresence was declared.
    /// <see href="http://online-presence.net/opo/ns#declaredOn"></see></summary>
    let declaredOn = Namespaced_IRI.parse _namespace_name "declaredOn" |> NamespacedName
    /// <summary>
    /// The estimated duration of the OnlinePresence after the
    /// 			startTime
    /// <see href="http://online-presence.net/opo/ns#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// The Person who's family members belog to the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#familyOf"></see></summary>
    let familyOf = Namespaced_IRI.parse _namespace_name "familyOf" |> NamespacedName

    /// <summary>
    /// OnlinePresenceComponent included in this OnlinePresence
    /// <see href="http://online-presence.net/opo/ns#hasPresenceComponent"></see></summary>
    let hasPresenceComponent =
        Namespaced_IRI.parse _namespace_name "hasPresenceComponent" |> NamespacedName

    /// <summary>
    /// The OnlinePresence that has this OnlinePresenceComponent
    /// <see href="http://online-presence.net/opo/ns#isPresenceComponentOf"></see></summary>
    let isPresenceComponentOf =
        Namespaced_IRI.parse _namespace_name "isPresenceComponentOf" |> NamespacedName

    /// <summary>
    /// The OnlineStatus that includes this OnlineStatusComponent.
    /// <see href="http://online-presence.net/opo/ns#isStatusComponentOf"></see></summary>
    let isStatusComponentOf =
        Namespaced_IRI.parse _namespace_name "isStatusComponentOf" |> NamespacedName

    /// <summary>
    /// A group of people belonging to a space for sharing online psresence data - the intended audience of presence information.
    /// <see href="http://online-presence.net/opo/ns#intendedFor"></see></summary>
    let intendedFor =
        Namespaced_IRI.parse _namespace_name "intendedFor" |> NamespacedName

    /// <summary>
    /// A name used by chat systems to distinguish their various
    /// 			statuses.
    /// <see href="http://online-presence.net/opo/ns#onlineStatusName"></see></summary>
    let onlineStatusName =
        Namespaced_IRI.parse _namespace_name "onlineStatusName" |> NamespacedName

    /// <summary>
    /// The source from which the OnlinePresence is declared (e.g., a mobile device)
    /// <see href="http://online-presence.net/opo/ns#publishedFrom"></see></summary>
    let publishedFrom =
        Namespaced_IRI.parse _namespace_name "publishedFrom" |> NamespacedName

    /// <summary>
    /// The homepage of school attended by people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#schoolHomepage"></see></summary>
    let schoolHomepage =
        Namespaced_IRI.parse _namespace_name "schoolHomepage" |> NamespacedName

    /// <summary>
    /// the description of the SourceOfPublishing.
    /// <see href="http://online-presence.net/opo/ns#sourceDescription"></see></summary>
    let sourceDescription =
        Namespaced_IRI.parse _namespace_name "sourceDescription" |> NamespacedName

    /// <summary>
    /// The name of the SourceOfPublishing.
    /// <see href="http://online-presence.net/opo/ns#sourceName"></see></summary>
    let sourceName = Namespaced_IRI.parse _namespace_name "sourceName" |> NamespacedName
    /// <summary>
    /// The time when the OnlinePresence started
    /// <see href="http://online-presence.net/opo/ns#startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName

    /// <summary>
    /// The homepage of workplace of people in the Sharing Space.
    /// <see href="http://online-presence.net/opo/ns#workplaceHomepage"></see></summary>
    let workplaceHomepage =
        Namespaced_IRI.parse _namespace_name "workplaceHomepage" |> NamespacedName
