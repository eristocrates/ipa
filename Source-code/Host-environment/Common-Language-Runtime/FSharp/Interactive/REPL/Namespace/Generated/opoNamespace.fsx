#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module opo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://online-presence.net/opo/ns#" "opo"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An action currently performed by the Agent (e.g., listening to music, reading a book).</para>
    ///   <para>rdfs:label : Action</para>
    ///   <a href="http://online-presence.net/opo/ns#Action">opo:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    let Active = _prefixId.prefix "Active"
    /// <summary>
    ///   <para>rdfs:comment : OnlineStatusComponent used to represent the state of
    /// 			Activity of the Agent (e.g., Active, Inactive,
    /// 			ProlongedInactive).</para>
    ///   <para>rdfs:label : Activity</para>
    ///   <a href="http://online-presence.net/opo/ns#Activity">opo:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    let AllNotificationsPass = _prefixId.prefix "AllNotificationsPass"
    let Available = _prefixId.prefix "Available"
    let ConstrainedContactability = _prefixId.prefix "ConstrainedContactability"
    let ConstrainedFindability = _prefixId.prefix "ConstrainedFindability"
    /// <summary>
    ///   <para>rdfs:comment : OnlineStatusComponent used to represent the state of
    /// 			contactability of an Agent. Contatctability relates to the
    /// 			possiblity of other Agents to conatct the Agent freely or
    /// 			only with regard to some conditions.</para>
    ///   <para>rdfs:label : Contactability</para>
    ///   <a href="http://online-presence.net/opo/ns#Contactability">opo:Contactability</a>
    /// </summary>
    let Contactability = _prefixId.prefix "Contactability"
    /// <summary>
    ///   <para>rdfs:comment : OnlineStatusComponent used to represent the wish of an Agent
    /// 			to be or not to be disturbed.</para>
    ///   <para>rdfs:label : Disturbability</para>
    ///   <a href="http://online-presence.net/opo/ns#Disturbability">opo:Disturbability</a>
    /// </summary>
    let Disturbability = _prefixId.prefix "Disturbability"
    let DoNotDistrub = _prefixId.prefix "DoNotDistrub"
    let DoNotDisturb = _prefixId.prefix "DoNotDisturb"
    /// <summary>
    ///   <para>rdfs:comment : The OnlinePresenceComponent used to represent the
    /// 			possibility to find contact details of an Agent in a public
    /// 			listing</para>
    ///   <para>rdfs:label : Findability</para>
    ///   <a href="http://online-presence.net/opo/ns#Findability">opo:Findability</a>
    /// </summary>
    let Findability = _prefixId.prefix "Findability"
    let FreelyContactable = _prefixId.prefix "FreelyContactable"
    let Inactive = _prefixId.prefix "Inactive"
    let Invisible = _prefixId.prefix "Invisible"
    /// <summary>
    ///   <para>rdfs:comment : The OnlinePresenceComponent used to represent the attitude
    /// 			of an Agent towards interaction with applications i.e., the
    /// 			possibility of applications to show notifications.</para>
    ///   <para>rdfs:label : Notifiability</para>
    ///   <a href="http://online-presence.net/opo/ns#Notifiability">opo:Notifiability</a>
    /// </summary>
    let Notifiability = _prefixId.prefix "Notifiability"
    let NotificationsConstrained = _prefixId.prefix "NotificationsConstrained"
    let NotificationsProhibited = _prefixId.prefix "NotificationsProhibited"
    /// <summary>
    ///   <para>rdfs:comment : OnlinePresence, described in termes of various
    /// 			OnlinePresenceComponents to represent the attitude of an
    /// 			Agent towards interaction with other Agents and
    /// 			Applications.</para>
    ///   <para>rdfs:label : OnlinePresence</para>
    ///   <a href="http://online-presence.net/opo/ns#OnlinePresence">opo:OnlinePresence</a>
    /// </summary>
    let OnlinePresence = _prefixId.prefix "OnlinePresence"
    /// <summary>
    ///   <para>rdfs:comment : A component of OnlinePresence used to represent one of its
    /// 			dimensions.</para>
    ///   <para>rdfs:label : OnlinePresenceComponent</para>
    ///   <a href="http://online-presence.net/opo/ns#OnlinePresenceComponent">opo:OnlinePresenceComponent</a>
    /// </summary>
    let OnlinePresenceComponent = _prefixId.prefix "OnlinePresenceComponent"
    /// <summary>
    ///   <para>rdfs:comment : The OnlinePresenceComponent used to represent the attitude
    /// 			of an Agent towards the possibility of communication with
    /// 			other Agents. The OnlineStatus is defined by its components.</para>
    ///   <para>rdfs:label : OnlineStatus</para>
    ///   <a href="http://online-presence.net/opo/ns#OnlineStatus">opo:OnlineStatus</a>
    /// </summary>
    let OnlineStatus = _prefixId.prefix "OnlineStatus"
    /// <summary>
    ///   <para>rdfs:comment : The component of the OnlineStatus representing one of its
    /// 			dimensions.</para>
    ///   <para>rdfs:label : OnlineStatusComponent</para>
    ///   <a href="http://online-presence.net/opo/ns#OnlineStatusComponent">opo:OnlineStatusComponent</a>
    /// </summary>
    let OnlineStatusComponent = _prefixId.prefix "OnlineStatusComponent"
    let ProlongedInactive = _prefixId.prefix "ProlongedInactive"
    let PubliclyFindable = _prefixId.prefix "PubliclyFindable"
    /// <summary>
    ///   <para>rdfs:comment : A group of people belonging to a space for sharing online psresence data - the intended audience of data.</para>
    ///   <para>rdfs:label : SharingSpace</para>
    ///   <a href="http://online-presence.net/opo/ns#SharingSpace">opo:SharingSpace</a>
    /// </summary>
    let SharingSpace = _prefixId.prefix "SharingSpace"
    /// <summary>
    ///   <para>rdfs:comment : The source that can publish Online Presence data.</para>
    ///   <para>rdfs:label : SourceOfPublishing</para>
    ///   <a href="http://online-presence.net/opo/ns#SourceOfPublishing">opo:SourceOfPublishing</a>
    /// </summary>
    let SourceOfPublishing = _prefixId.prefix "SourceOfPublishing"
    /// <summary>
    ///   <para>rdfs:comment : A status message that cannot be commented on.</para>
    ///   <para>rdfs:label : StatusMessage</para>
    ///   <a href="http://online-presence.net/opo/ns#StatusMessage">opo:StatusMessage</a>
    /// </summary>
    let StatusMessage = _prefixId.prefix "StatusMessage"
    /// <summary>
    ///   <para>rdfs:comment : OnlineStatusComponent used to represent the possiblity of
    /// 			others to see the OnlineStatus of the Agent</para>
    ///   <para>rdfs:label : Visibility</para>
    ///   <a href="http://online-presence.net/opo/ns#Visibility">opo:Visibility</a>
    /// </summary>
    let Visibility = _prefixId.prefix "Visibility"
    let Visible = _prefixId.prefix "Visible"
    /// <summary>
    ///   <para>rdfs:comment : The organised event attended by people in the Sharing Space.</para>
    ///   <para>rdfs:label : Attended Organised Event</para>
    ///   <a href="http://online-presence.net/opo/ns#attendedOrganisedEvent">opo:attendedOrganisedEvent</a>
    /// </summary>
    let attendedOrganisedEvent = _prefixId.prefix "attendedOrganisedEvent"
    /// <summary>
    ///   <para>rdfs:comment : The graphical representation of the Agent used to depict him
    /// 			in online systems.</para>
    ///   <para>rdfs:label : avatar</para>
    ///   <a href="http://online-presence.net/opo/ns#avatar">opo:avatar</a>
    /// </summary>
    let avatar = _prefixId.prefix "avatar"
    /// <summary>
    ///   <para>rdfs:comment : The location where members of the Sharing Space are based.</para>
    ///   <para>rdfs:label : Based Near</para>
    ///   <a href="http://online-presence.net/opo/ns#basedNear">opo:basedNear</a>
    /// </summary>
    let basedNear = _prefixId.prefix "basedNear"
    /// <summary>
    ///   <para>rdfs:comment : The Person who's closest friends belog to the Sharing Space.</para>
    ///   <para>rdfs:label : Closest Friends Of</para>
    ///   <a href="http://online-presence.net/opo/ns#closestFriendsOf">opo:closestFriendsOf</a>
    /// </summary>
    let closestFriendsOf = _prefixId.prefix "closestFriendsOf"
    /// <summary>
    ///   <para>rdfs:comment : An interst shared by people in the Sharing Space.</para>
    ///   <para>rdfs:label : Common Interest</para>
    ///   <a href="http://online-presence.net/opo/ns#commonInterest">opo:commonInterest</a>
    /// </summary>
    let commonInterest = _prefixId.prefix "commonInterest"
    /// <summary>
    ///   <para>rdfs:comment : Current action performed by the Agent</para>
    ///   <para>rdfs:label : currentAction</para>
    ///   <a href="http://online-presence.net/opo/ns#currentAction">opo:currentAction</a>
    /// </summary>
    let currentAction = _prefixId.prefix "currentAction"
    /// <summary>
    ///   <para>rdfs:comment : Current location of the Agent</para>
    ///   <para>rdfs:label : currentLocation</para>
    ///   <a href="http://online-presence.net/opo/ns#currentLocation">opo:currentLocation</a>
    /// </summary>
    let currentLocation = _prefixId.prefix "currentLocation"
    /// <summary>
    ///   <para>rdfs:comment : The current location of people in the Sharing Space.</para>
    ///   <para>rdfs:label : Currently In</para>
    ///   <a href="http://online-presence.net/opo/ns#currentlyIn">opo:currentlyIn</a>
    /// </summary>
    let currentlyIn = _prefixId.prefix "currentlyIn"
    /// <summary>
    ///   <para>rdfs:comment : A message associated with the OnlinePresence, often used in
    /// 			chat programs and social networks as custom title as well as in microblogging as status message.</para>
    ///   <para>rdfs:label : customMessage</para>
    ///   <a href="http://online-presence.net/opo/ns#customMessage">opo:customMessage</a>
    /// </summary>
    let customMessage = _prefixId.prefix "customMessage"
    /// <summary>
    ///   <para>rdfs:comment : The Agent that declared the OnlinePresence</para>
    ///   <para>rdfs:label : declaredBy</para>
    ///   <a href="http://online-presence.net/opo/ns#declaredBy">opo:declaredBy</a>
    /// </summary>
    let declaredBy = _prefixId.prefix "declaredBy"
    /// <summary>
    ///   <para>rdfs:comment : The sioc:UserAccount account where the OnlinePresence was declared.</para>
    ///   <para>rdfs:label : declaredOn</para>
    ///   <a href="http://online-presence.net/opo/ns#declaredOn">opo:declaredOn</a>
    /// </summary>
    let declaredOn = _prefixId.prefix "declaredOn"
    /// <summary>
    ///   <para>rdfs:comment : The OnlinePresence declared by the Agent</para>
    ///   <para>rdfs:label : declaresOnlinePresence</para>
    ///   <a href="http://online-presence.net/opo/ns#declaresOnlinePresence">opo:declaresOnlinePresence</a>
    /// </summary>
    let declaresOnlinePresence = _prefixId.prefix "declaresOnlinePresence"
    /// <summary>
    ///   <para>rdfs:comment : The estimated duration of the OnlinePresence after the
    /// 			startTime</para>
    ///   <para>rdfs:label : duration</para>
    ///   <a href="http://online-presence.net/opo/ns#duration">opo:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:comment : The Person who's family members belog to the Sharing Space.</para>
    ///   <para>rdfs:label : Family Of</para>
    ///   <a href="http://online-presence.net/opo/ns#familyOf">opo:familyOf</a>
    /// </summary>
    let familyOf = _prefixId.prefix "familyOf"
    /// <summary>
    ///   <para>rdfs:comment : OnlinePresenceComponent included in this OnlinePresence</para>
    ///   <para>rdfs:label : hasOnlinePresence</para>
    ///   <a href="http://online-presence.net/opo/ns#hasPresenceComponent">opo:hasPresenceComponent</a>
    /// </summary>
    let hasPresenceComponent = _prefixId.prefix "hasPresenceComponent"
    /// <summary>
    ///   <para>rdfs:comment : OnlineStatusComponent included in this OnlineStatus</para>
    ///   <para>rdfs:label : hasStatusComponent</para>
    ///   <a href="http://online-presence.net/opo/ns#hasStatusComponent">opo:hasStatusComponent</a>
    /// </summary>
    let hasStatusComponent = _prefixId.prefix "hasStatusComponent"
    /// <summary>
    ///   <para>rdfs:comment : Period of inactivity on a certain service</para>
    ///   <para>rdfs:label : inactivityPeriod</para>
    ///   <a href="http://online-presence.net/opo/ns#inactivityPeriod">opo:inactivityPeriod</a>
    /// </summary>
    let inactivityPeriod = _prefixId.prefix "inactivityPeriod"
    /// <summary>
    ///   <para>rdfs:comment : A group of people belonging to a space for sharing online psresence data - the intended audience of presence information.</para>
    ///   <para>rdfs:label : intendedFor</para>
    ///   <a href="http://online-presence.net/opo/ns#intendedFor">opo:intendedFor</a>
    /// </summary>
    let intendedFor = _prefixId.prefix "intendedFor"
    /// <summary>
    ///   <para>rdfs:comment : The OnlinePresence that has this OnlinePresenceComponent</para>
    ///   <para>rdfs:label : isPresenceComponentOf</para>
    ///   <a href="http://online-presence.net/opo/ns#isPresenceComponentOf">opo:isPresenceComponentOf</a>
    /// </summary>
    let isPresenceComponentOf = _prefixId.prefix "isPresenceComponentOf"
    /// <summary>
    ///   <para>rdfs:comment : The OnlineStatus that includes this OnlineStatusComponent.</para>
    ///   <para>rdfs:label : isStatusComponentOf</para>
    ///   <a href="http://online-presence.net/opo/ns#isStatusComponentOf">opo:isStatusComponentOf</a>
    /// </summary>
    let isStatusComponentOf = _prefixId.prefix "isStatusComponentOf"
    /// <summary>
    ///   <para>rdfs:comment : A name used by chat systems to distinguish their various
    /// 			statuses.</para>
    ///   <para>rdfs:label : OnlineStatusName</para>
    ///   <a href="http://online-presence.net/opo/ns#onlineStatusName">opo:onlineStatusName</a>
    /// </summary>
    let onlineStatusName = _prefixId.prefix "onlineStatusName"
    /// <summary>
    ///   <para>rdfs:comment : The source from which the OnlinePresence is declared (e.g., a mobile device)</para>
    ///   <para>rdfs:label : publishedFrom</para>
    ///   <a href="http://online-presence.net/opo/ns#publishedFrom">opo:publishedFrom</a>
    /// </summary>
    let publishedFrom = _prefixId.prefix "publishedFrom"
    /// <summary>
    ///   <para>rdfs:comment : The homepage of school attended by people in the Sharing Space.</para>
    ///   <para>rdfs:label : School Homepage</para>
    ///   <a href="http://online-presence.net/opo/ns#schoolHomepage">opo:schoolHomepage</a>
    /// </summary>
    let schoolHomepage = _prefixId.prefix "schoolHomepage"
    /// <summary>
    ///   <para>rdfs:comment : the description of the SourceOfPublishing.</para>
    ///   <para>rdfs:label : sourceDescription</para>
    ///   <a href="http://online-presence.net/opo/ns#sourceDescription">opo:sourceDescription</a>
    /// </summary>
    let sourceDescription = _prefixId.prefix "sourceDescription"
    /// <summary>
    ///   <para>rdfs:comment : The name of the SourceOfPublishing.</para>
    ///   <para>rdfs:label : sourceName</para>
    ///   <a href="http://online-presence.net/opo/ns#sourceName">opo:sourceName</a>
    /// </summary>
    let sourceName = _prefixId.prefix "sourceName"
    /// <summary>
    ///   <para>rdfs:comment : The time when the OnlinePresence started</para>
    ///   <para>rdfs:label : startTime</para>
    ///   <a href="http://online-presence.net/opo/ns#startTime">opo:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>rdfs:comment : The homepage of workplace of people in the Sharing Space.</para>
    ///   <para>rdfs:label : Workplace Homepage</para>
    ///   <a href="http://online-presence.net/opo/ns#workplaceHomepage">opo:workplaceHomepage</a>
    /// </summary>
    let workplaceHomepage = _prefixId.prefix "workplaceHomepage"
