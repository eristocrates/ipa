#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module meb =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdf.myexperiment.org/ontologies/base/" "meb"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actor^^xsd:string</para>
    ///   <para>rdfs:comment : An object that can perform an action^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Actor">meb:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:comment : An object that can be annotated with Annotations^^xsd:string</para>
    ///   <para>rdfs:label : Annotatable^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Annotatable">meb:Annotatable</a>
    /// </summary>
    let Annotatable = _prefixId.prefix "Annotatable"
    /// <summary>
    ///   <para>rdfs:comment : An Annotation of a Annotatable object^^xsd:string</para>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Annotation">meb:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:comment : A public Announcement^^xsd:string</para>
    ///   <para>rdfs:label : Announcement^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Announcement">meb:Announcement</a>
    /// </summary>
    let Announcement = _prefixId.prefix "Announcement"
    /// <summary>
    ///   <para>rdfs:comment : The type of content for an Upload^^xsd:string</para>
    ///   <para>rdfs:label : ContentType^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/ContentType">meb:ContentType</a>
    /// </summary>
    let ContentType = _prefixId.prefix "ContentType"
    /// <summary>
    ///   <para>rdfs:comment : An object that is contributed by a User^^xsd:string</para>
    ///   <para>rdfs:label : Contribution^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Contribution">meb:Contribution</a>
    /// </summary>
    let Contribution = _prefixId.prefix "Contribution"
    /// <summary>
    ///   <para>rdfs:comment : A Friendship between two Users^^xsd:string</para>
    ///   <para>rdfs:label : Friendship^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Friendship">meb:Friendship</a>
    /// </summary>
    let Friendship = _prefixId.prefix "Friendship"
    /// <summary>
    ///   <para>rdfs:comment : A FriendshipInvitation to an external email address^^xsd:string</para>
    ///   <para>rdfs:label : FriendshipInvitation^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/FriendshipInvitation">meb:FriendshipInvitation</a>
    /// </summary>
    let FriendshipInvitation = _prefixId.prefix "FriendshipInvitation"
    /// <summary>
    ///   <para>rdfs:label : Group^^xsd:string</para>
    ///   <para>rdfs:comment : A Group of Users^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Group">meb:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:comment : An Announcement to a Group^^xsd:string</para>
    ///   <para>rdfs:label : GroupAnnouncement^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/GroupAnnouncement">meb:GroupAnnouncement</a>
    /// </summary>
    let GroupAnnouncement = _prefixId.prefix "GroupAnnouncement"
    /// <summary>
    ///   <para>rdfs:comment : Superclass for all Interface classes^^xsd:string</para>
    ///   <para>rdfs:label : Interface^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Interface">meb:Interface</a>
    /// </summary>
    let Interface = _prefixId.prefix "Interface"
    /// <summary>
    ///   <para>rdfs:comment : A Request could be an external Invitation^^xsd:string</para>
    ///   <para>rdfs:label : Invitation^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Invitation">meb:Invitation</a>
    /// </summary>
    let Invitation = _prefixId.prefix "Invitation"
    /// <summary>
    ///   <para>rdfs:label : License^^xsd:string</para>
    ///   <para>rdfs:comment : A License under which an Upload is licensed under^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/License">meb:License</a>
    /// </summary>
    let License = _prefixId.prefix "License"
    /// <summary>
    ///   <para>rdfs:comment : A Membership of a User to a Group^^xsd:string</para>
    ///   <para>rdfs:label : Membership^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Membership">meb:Membership</a>
    /// </summary>
    let Membership = _prefixId.prefix "Membership"
    /// <summary>
    ///   <para>rdfs:comment : A MembershipInvitation to an external email address^^xsd:string</para>
    ///   <para>rdfs:label : MembershipInvitation^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/MembershipInvitation">meb:MembershipInvitation</a>
    /// </summary>
    let MembershipInvitation = _prefixId.prefix "MembershipInvitation"
    /// <summary>
    ///   <para>rdfs:label : Message^^xsd:string</para>
    ///   <para>rdfs:comment : A Message sent between two Users^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Message">meb:Message</a>
    /// </summary>
    let Message = _prefixId.prefix "Message"
    /// <summary>
    ///   <para>rdfs:label : Request^^xsd:string</para>
    ///   <para>rdfs:comment : A Request can be made by an Actor to another Actor^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Request">meb:Request</a>
    /// </summary>
    let Request = _prefixId.prefix "Request"
    /// <summary>
    ///   <para>rdfs:comment : An object that has been submitted.  This might be a Contribution, Annotation, Request or an Attibution/Creditation of an Upload^^xsd:string</para>
    ///   <para>rdfs:label : Submission^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Submission">meb:Submission</a>
    /// </summary>
    let Submission = _prefixId.prefix "Submission"
    /// <summary>
    ///   <para>rdfs:comment : An object that can be contributed by a User that requires uploading^^xsd:string</para>
    ///   <para>rdfs:label : Upload^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Upload">meb:Upload</a>
    /// </summary>
    let Upload = _prefixId.prefix "Upload"
    /// <summary>
    ///   <para>rdfs:label : User^^xsd:string</para>
    ///   <para>rdfs:comment : A User^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/User">meb:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:comment : A Contribution may be a Version of another Contribution^^xsd:string</para>
    ///   <para>rdfs:label : Version^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Version">meb:Version</a>
    /// </summary>
    let Version = _prefixId.prefix "Version"
    /// <summary>
    ///   <para>rdfs:comment : A Contribution that can be a Version^^xsd:string</para>
    ///   <para>rdfs:label : Versionable^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/Versionable">meb:Versionable</a>
    /// </summary>
    let Versionable = _prefixId.prefix "Versionable"
    /// <summary>
    ///   <para>rdfs:comment : A Request can be accepted-at a certain dateTime^^xsd:string</para>
    ///   <para>rdfs:label : accepted-at^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/accepted-at">meb:accepted-at</a>
    /// </summary>
    let accepted_at = _prefixId.prefix "accepted-at"
    /// <summary>
    ///   <para>rdfs:comment : A User account is a activated-at certain dateTime^^xsd:string</para>
    ///   <para>rdfs:label : activated-at^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/activated-at">meb:activated-at</a>
    /// </summary>
    let activated_at = _prefixId.prefix "activated-at"
    /// <summary>
    ///   <para>rdfs:comment : An Annotation is associated with a particular Contribution^^xsd:string</para>
    ///   <para>rdfs:label : annotates^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/annotates">meb:annotates</a>
    /// </summary>
    let annotates = _prefixId.prefix "annotates"
    /// <summary>
    ///   <para>rdfs:comment : A User is an annotator-of an Annotation^^xsd:string</para>
    ///   <para>rdfs:label : annotator^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/annotator-of">meb:annotator-of</a>
    /// </summary>
    let annotator_of = _prefixId.prefix "annotator-of"
    /// <summary>
    ///   <para>rdfs:comment : The Group a GroupAnnouncement has been announced to^^xsd:string</para>
    ///   <para>rdfs:label : announced-to^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/announced-to">meb:announced-to</a>
    /// </summary>
    let announced_to = _prefixId.prefix "announced-to"
    /// <summary>
    ///   <para>rdfs:comment : A User has contact-details^^xsd:string</para>
    ///   <para>rdfs:label : contact-details^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/contact-details">meb:contact-details</a>
    /// </summary>
    let contact_details = _prefixId.prefix "contact-details"
    /// <summary>
    ///   <para>rdfs:comment : An Upload has content at a URL^^xsd:string</para>
    ///   <para>rdfs:label : content-url^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/content-url">meb:content-url</a>
    /// </summary>
    let content_url = _prefixId.prefix "content-url"
    /// <summary>
    ///   <para>rdfs:comment : Certain Annotations may be a count of something^^xsd:string</para>
    ///   <para>rdfs:label : count^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/count">meb:count</a>
    /// </summary>
    let count = _prefixId.prefix "count"
    /// <summary>
    ///   <para>rdfs:comment : A User is based in a country^^xsd:string</para>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/country">meb:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:comment : The recipient has deleted this Message from their inbox^^xsd:string</para>
    ///   <para>rdfs:label : deleted-by-recipient^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/deleted-by-recipient">meb:deleted-by-recipient</a>
    /// </summary>
    let deleted_by_recipient = _prefixId.prefix "deleted-by-recipient"
    /// <summary>
    ///   <para>rdfs:comment : The sender has deleted this Message from their inbox^^xsd:string</para>
    ///   <para>rdfs:label : deleted-by-sender^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/deleted-by-sender">meb:deleted-by-sender</a>
    /// </summary>
    let deleted_by_sender = _prefixId.prefix "deleted-by-sender"
    /// <summary>
    ///   <para>rdfs:comment : A User has an email address^^xsd:string</para>
    ///   <para>rdfs:label : email^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/email">meb:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:comment : An email is confirmed at a certain dateTime^^xsd:string</para>
    ///   <para>rdfs:label : email-confirmed-at^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/email-confirmed-at">meb:email-confirmed-at</a>
    /// </summary>
    let email_confirmed_at = _prefixId.prefix "email-confirmed-at"
    /// <summary>
    ///   <para>rdfs:comment : A User works in a field^^xsd:string</para>
    ///   <para>rdfs:label : field^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/field">meb:field</a>
    /// </summary>
    let field = _prefixId.prefix "field"
    /// <summary>
    ///   <para>rdfs:comment : A File has a filename^^xsd:string</para>
    ///   <para>rdfs:label : filename^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/filename">meb:filename</a>
    /// </summary>
    let filename = _prefixId.prefix "filename"
    /// <summary>
    ///   <para>rdfs:comment : A Message is sent from a User^^xsd:string</para>
    ///   <para>rdfs:label : from^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/from">meb:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    /// <summary>
    ///   <para>rdfs:comment : A Request must have an accepter that can accept^^xsd:string</para>
    ///   <para>rdfs:label : has-accepter^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-accepter">meb:has-accepter</a>
    /// </summary>
    let has_accepter = _prefixId.prefix "has-accepter"
    /// <summary>
    ///   <para>rdfs:comment : An Annotable may have a Annotation^^xsd:string</para>
    ///   <para>rdfs:label : has-annotation^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-annotation">meb:has-annotation</a>
    /// </summary>
    let has_annotation = _prefixId.prefix "has-annotation"
    /// <summary>
    ///   <para>rdfs:comment : An Annotation has User as annotator^^xsd:string</para>
    ///   <para>rdfs:label : has-annotator^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-annotator">meb:has-annotator</a>
    /// </summary>
    let has_annotator = _prefixId.prefix "has-annotator"
    /// <summary>
    ///   <para>rdfs:comment : Groups may have GroupAnnouncements^^xsd:string</para>
    ///   <para>rdfs:label : has-announcement^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-announcement">meb:has-announcement</a>
    /// </summary>
    let has_announcement = _prefixId.prefix "has-announcement"
    /// <summary>
    ///   <para>rdfs:comment : An Announcement has an annoucer that is a User^^xsd:string</para>
    ///   <para>rdfs:label : has-announcer^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-announcer">meb:has-announcer</a>
    /// </summary>
    let has_announcer = _prefixId.prefix "has-announcer"
    /// <summary>
    ///   <para>rdfs:comment : An Upload has a ContentType^^xsd:string</para>
    ///   <para>rdfs:label : has-content-type^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-content-type">meb:has-content-type</a>
    /// </summary>
    let has_content_type = _prefixId.prefix "has-content-type"
    /// <summary>
    ///   <para>rdfs:comment : A Versionable object has a current version^^xsd:string</para>
    ///   <para>rdfs:label : has-current-version^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-current-version">meb:has-current-version</a>
    /// </summary>
    let has_current_version = _prefixId.prefix "has-current-version"
    /// <summary>
    ///   <para>rdfs:comment : A User has a Friendship (with another User)^^xsd:string</para>
    ///   <para>rdfs:label : has-friendship^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-friendship">meb:has-friendship</a>
    /// </summary>
    let has_friendship = _prefixId.prefix "has-friendship"
    /// <summary>
    ///   <para>rdfs:comment : A User has a Membership (of a Group)^^xsd:string</para>
    ///   <para>rdfs:label : has-membership^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-membership">meb:has-membership</a>
    /// </summary>
    let has_membership = _prefixId.prefix "has-membership"
    /// <summary>
    ///   <para>rdfs:comment : A Contribution has a Policy for access rights management^^xsd:string</para>
    ///   <para>rdfs:label : has-policy^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-policy">meb:has-policy</a>
    /// </summary>
    let has_policy = _prefixId.prefix "has-policy"
    /// <summary>
    ///   <para>rdfs:comment : A Request must have a requester^^xsd:string</para>
    ///   <para>rdfs:label : has-requester^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-requester">meb:has-requester</a>
    /// </summary>
    let has_requester = _prefixId.prefix "has-requester"
    /// <summary>
    ///   <para>rdfs:comment : Contributions that are shared within a Group^^xsd:string</para>
    ///   <para>rdfs:label : has-shared-item^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-shared-item">meb:has-shared-item</a>
    /// </summary>
    let has_shared_item = _prefixId.prefix "has-shared-item"
    /// <summary>
    ///   <para>rdfs:comment : A Versionable object has at least one version^^xsd:string</para>
    ///   <para>rdfs:label : has-version^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/has-version">meb:has-version</a>
    /// </summary>
    let has_version = _prefixId.prefix "has-version"
    /// <summary>
    ///   <para>rdfs:comment : A User's interests^^xsd:string</para>
    ///   <para>rdfs:label : interests^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/interests">meb:interests</a>
    /// </summary>
    let interests = _prefixId.prefix "interests"
    /// <summary>
    ///   <para>rdfs:comment : A User's interests^^xsd:string</para>
    ///   <para>rdfs:label : is-current-version^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/is-current-version">meb:is-current-version</a>
    /// </summary>
    let is_current_version = _prefixId.prefix "is-current-version"
    /// <summary>
    ///   <para>rdfs:comment : A User may be friends with another User^^xsd:string</para>
    ///   <para>rdfs:label : is-friends-with^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/is-friends-with">meb:is-friends-with</a>
    /// </summary>
    let is_friends_with = _prefixId.prefix "is-friends-with"
    /// <summary>
    ///   <para>rdfs:comment : The last time a User was seen^^xsd:string</para>
    ///   <para>rdfs:label : last-seen-at^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/last-seen-at">meb:last-seen-at</a>
    /// </summary>
    let last_seen_at = _prefixId.prefix "last-seen-at"
    /// <summary>
    ///   <para>rdfs:comment : The policy for Users joining a Group (e.g. open, invite only, etc.)^^xsd:string</para>
    ///   <para>rdfs:label : ^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/membership-policy">meb:membership-policy</a>
    /// </summary>
    let membership_policy = _prefixId.prefix "membership-policy"
    /// <summary>
    ///   <para>rdfs:comment : A User has an occupation^^xsd:string</para>
    ///   <para>rdfs:label : occupation^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/occupation">meb:occupation</a>
    /// </summary>
    let occupation = _prefixId.prefix "occupation"
    /// <summary>
    ///   <para>rdfs:comment : A User may have an openid-url represented as a uri^^xsd:string</para>
    ///   <para>rdfs:label : openid-url^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/openid-url">meb:openid-url</a>
    /// </summary>
    let openid_url = _prefixId.prefix "openid-url"
    /// <summary>
    ///   <para>rdfs:comment : A User is part of an organisation^^xsd:string</para>
    ///   <para>rdfs:label : organisation^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/organisation">meb:organisation</a>
    /// </summary>
    let organisation = _prefixId.prefix "organisation"
    /// <summary>
    ///   <para>rdfs:comment : Is the GroupAnnouncement viewable (public) to those outside the Group^^xsd:string</para>
    ///   <para>rdfs:label : public-announcement^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/public-announcement">meb:public-announcement</a>
    /// </summary>
    let public_announcement = _prefixId.prefix "public-announcement"
    /// <summary>
    ///   <para>rdfs:comment : A Message is a read-at a particular dateTime^^xsd:string</para>
    ///   <para>rdfs:label : read-at^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/read-at">meb:read-at</a>
    /// </summary>
    let read_at = _prefixId.prefix "read-at"
    /// <summary>
    ///   <para>rdfs:comment : Does the user receive-notifications^^xsd:string</para>
    ///   <para>rdfs:label : receive-notifications^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/receive-notifications">meb:receive-notifications</a>
    /// </summary>
    let receive_notifications = _prefixId.prefix "receive-notifications"
    /// <summary>
    ///   <para>rdfs:comment : A Message may have a Message it is a reply-to^^xsd:string</para>
    ///   <para>rdfs:label : reply-to^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/reply-to">meb:reply-to</a>
    /// </summary>
    let reply_to = _prefixId.prefix "reply-to"
    /// <summary>
    ///   <para>rdfs:comment : Requests may have a request-token as a string^^xsd:string</para>
    ///   <para>rdfs:label : request-token^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/request-token">meb:request-token</a>
    /// </summary>
    let request_token = _prefixId.prefix "request-token"
    /// <summary>
    ///   <para>rdfs:comment : Comments may be associated with a particular Version of something^^xsd:string</para>
    ///   <para>rdfs:label : revision-comments^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/revision-comments">meb:revision-comments</a>
    /// </summary>
    let revision_comments = _prefixId.prefix "revision-comments"
    /// <summary>
    ///   <para>rdfs:comment : A Message has a subject^^xsd:string</para>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/subject">meb:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:comment : A Submission has some text associated with it^^xsd:string</para>
    ///   <para>rdfs:label : text^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/text">meb:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:comment : A Message is sent to a User^^xsd:string</para>
    ///   <para>rdfs:label : to^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/to">meb:to</a>
    /// </summary>
    let to_ = _prefixId.prefix "to"
    /// <summary>
    ///   <para>rdfs:comment : An email that has yet to be confirmed^^xsd:string</para>
    ///   <para>rdfs:label : unconfirmed-email^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/unconfirmed-email">meb:unconfirmed-email</a>
    /// </summary>
    let unconfirmed_email = _prefixId.prefix "unconfirmed-email"
    /// <summary>
    ///   <para>rdfs:comment : The URI for some object^^xsd:string</para>
    ///   <para>rdfs:label : uri^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/uri">meb:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
    /// <summary>
    ///   <para>rdfs:comment : A User may have a username represented as a string^^xsd:string</para>
    ///   <para>rdfs:label : username^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/username">meb:username</a>
    /// </summary>
    let username = _prefixId.prefix "username"
    /// <summary>
    ///   <para>rdfs:comment : A Version has a version-number^^xsd:string</para>
    ///   <para>rdfs:label : version-number^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/base/version-number">meb:version-number</a>
    /// </summary>
    let version_number = _prefixId.prefix "version-number"
