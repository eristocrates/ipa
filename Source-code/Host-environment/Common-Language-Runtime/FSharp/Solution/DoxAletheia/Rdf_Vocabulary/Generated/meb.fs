namespace http.rdf.myexperiment.org.ontologies._base.slash

open DoxAletheia

module meb =
    let _namespace_name = "http://rdf.myexperiment.org/ontologies/base/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An object that can perform an action
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    /// An object that has been submitted.  This might be a Contribution, Annotation, Request or an Attibution/Creditation of an Upload
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Submission"></see></summary>
    let Submission = _prefix "Submission"
    /// <summary>
    /// An object that can be annotated with Annotations
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Annotatable"></see></summary>
    let Annotatable = _prefix "Annotatable"
    /// <summary>
    /// An Annotable may have a Annotation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-annotation"></see></summary>
    let ``has-annotation`` = _prefix "has-annotation"
    /// <summary>
    /// Superclass for all Interface classes
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Interface"></see></summary>
    let Interface = _prefix "Interface"
    /// <summary>
    /// An Annotation of a Annotatable object
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// An Annotation is associated with a particular Contribution
    /// <see href="http://rdf.myexperiment.org/ontologies/base/annotates"></see></summary>
    let annotates = _prefix "annotates"
    /// <summary>
    /// An Annotation has User as annotator
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-annotator"></see></summary>
    let ``has-annotator`` = _prefix "has-annotator"
    /// <summary>
    /// A Message sent between two Users
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Message"></see></summary>
    let Message = _prefix "Message"
    /// <summary>
    /// A public Announcement
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Announcement"></see></summary>
    let Announcement = _prefix "Announcement"
    /// <summary>
    /// An object that is contributed by a User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Contribution"></see></summary>
    let Contribution = _prefix "Contribution"
    /// <summary>
    /// A Request can be made by an Actor to another Actor
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Request"></see></summary>
    let Request = _prefix "Request"
    /// <summary>
    /// A Submission has some text associated with it
    /// <see href="http://rdf.myexperiment.org/ontologies/base/text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// An Announcement has an annoucer that is a User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-announcer"></see></summary>
    let ``has-announcer`` = _prefix "has-announcer"
    /// <summary>
    /// The type of content for an Upload
    /// <see href="http://rdf.myexperiment.org/ontologies/base/ContentType"></see></summary>
    let ContentType = _prefix "ContentType"
    /// <summary>
    /// A Contribution has a Policy for access rights management
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-policy"></see></summary>
    let ``has-policy`` = _prefix "has-policy"
    /// <summary>
    /// A Friendship between two Users
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Friendship"></see></summary>
    let Friendship = _prefix "Friendship"
    /// <summary>
    /// A Request could be an external Invitation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Invitation"></see></summary>
    let Invitation = _prefix "Invitation"
    /// <summary>
    /// A Membership of a User to a Group
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Membership"></see></summary>
    let Membership = _prefix "Membership"
    /// <summary>
    /// A FriendshipInvitation to an external email address
    /// <see href="http://rdf.myexperiment.org/ontologies/base/FriendshipInvitation"></see></summary>
    let FriendshipInvitation = _prefix "FriendshipInvitation"
    /// <summary>
    /// A MembershipInvitation to an external email address
    /// <see href="http://rdf.myexperiment.org/ontologies/base/MembershipInvitation"></see></summary>
    let MembershipInvitation = _prefix "MembershipInvitation"
    /// <summary>
    /// A Group of Users
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// A User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// An Announcement to a Group
    /// <see href="http://rdf.myexperiment.org/ontologies/base/GroupAnnouncement"></see></summary>
    let GroupAnnouncement = _prefix "GroupAnnouncement"
    /// <summary>
    /// The Group a GroupAnnouncement has been announced to
    /// <see href="http://rdf.myexperiment.org/ontologies/base/announced-to"></see></summary>
    let ``announced-to`` = _prefix "announced-to"
    /// <summary>
    /// Is the GroupAnnouncement viewable (public) to those outside the Group
    /// <see href="http://rdf.myexperiment.org/ontologies/base/public-announcement"></see></summary>
    let ``public-announcement`` = _prefix "public-announcement"
    /// <summary>
    /// A License under which an Upload is licensed under
    /// <see href="http://rdf.myexperiment.org/ontologies/base/License"></see></summary>
    let License = _prefix "License"
    /// <summary>
    /// A Request can be accepted-at a certain dateTime
    /// <see href="http://rdf.myexperiment.org/ontologies/base/accepted-at"></see></summary>
    let ``accepted-at`` = _prefix "accepted-at"
    /// <summary>
    /// A Request must have an accepter that can accept
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-accepter"></see></summary>
    let ``has-accepter`` = _prefix "has-accepter"
    /// <summary>
    /// A Request must have a requester
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-requester"></see></summary>
    let ``has-requester`` = _prefix "has-requester"
    /// <summary>
    /// An object that can be contributed by a User that requires uploading
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Upload"></see></summary>
    let Upload = _prefix "Upload"
    /// <summary>
    /// An Upload has a ContentType
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-content-type"></see></summary>
    let ``has-content-type`` = _prefix "has-content-type"
    /// <summary>
    /// An Upload has content at a URL
    /// <see href="http://rdf.myexperiment.org/ontologies/base/content-url"></see></summary>
    let ``content-url`` = _prefix "content-url"
    /// <summary>
    /// A User may have a username represented as a string
    /// <see href="http://rdf.myexperiment.org/ontologies/base/username"></see></summary>
    let username = _prefix "username"
    /// <summary>
    /// A Contribution may be a Version of another Contribution
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Version"></see></summary>
    let Version = _prefix "Version"
    /// <summary>
    /// A Version has a version-number
    /// <see href="http://rdf.myexperiment.org/ontologies/base/version-number"></see></summary>
    let ``version-number`` = _prefix "version-number"
    /// <summary>
    /// A Contribution that can be a Version
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Versionable"></see></summary>
    let Versionable = _prefix "Versionable"
    /// <summary>
    /// A Versionable object has at least one version
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-version"></see></summary>
    let ``has-version`` = _prefix "has-version"
    /// <summary>
    /// A User account is a activated-at certain dateTime
    /// <see href="http://rdf.myexperiment.org/ontologies/base/activated-at"></see></summary>
    let ``activated-at`` = _prefix "activated-at"
    /// <summary>
    /// A User is an annotator-of an Annotation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/annotator-of"></see></summary>
    let ``annotator-of`` = _prefix "annotator-of"
    /// <summary>
    /// A User has contact-details
    /// <see href="http://rdf.myexperiment.org/ontologies/base/contact-details"></see></summary>
    let ``contact-details`` = _prefix "contact-details"
    /// <summary>
    /// Certain Annotations may be a count of something
    /// <see href="http://rdf.myexperiment.org/ontologies/base/count"></see></summary>
    let count = _prefix "count"
    /// <summary>
    /// A User is based in a country
    /// <see href="http://rdf.myexperiment.org/ontologies/base/country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// The recipient has deleted this Message from their inbox
    /// <see href="http://rdf.myexperiment.org/ontologies/base/deleted-by-recipient"></see></summary>
    let ``deleted-by-recipient`` = _prefix "deleted-by-recipient"
    /// <summary>
    /// The sender has deleted this Message from their inbox
    /// <see href="http://rdf.myexperiment.org/ontologies/base/deleted-by-sender"></see></summary>
    let ``deleted-by-sender`` = _prefix "deleted-by-sender"
    /// <summary>
    /// A User has an email address
    /// <see href="http://rdf.myexperiment.org/ontologies/base/email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// An email is confirmed at a certain dateTime
    /// <see href="http://rdf.myexperiment.org/ontologies/base/email-confirmed-at"></see></summary>
    let ``email-confirmed-at`` = _prefix "email-confirmed-at"
    /// <summary>
    /// A User works in a field
    /// <see href="http://rdf.myexperiment.org/ontologies/base/field"></see></summary>
    let field = _prefix "field"
    /// <summary>
    /// A File has a filename
    /// <see href="http://rdf.myexperiment.org/ontologies/base/filename"></see></summary>
    let filename = _prefix "filename"
    /// <summary>
    /// A Message is sent from a User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    /// Groups may have GroupAnnouncements
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-announcement"></see></summary>
    let ``has-announcement`` = _prefix "has-announcement"
    /// <summary>
    /// A Versionable object has a current version
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-current-version"></see></summary>
    let ``has-current-version`` = _prefix "has-current-version"
    /// <summary>
    /// A User has a Friendship (with another User)
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-friendship"></see></summary>
    let ``has-friendship`` = _prefix "has-friendship"
    /// <summary>
    /// A User has a Membership (of a Group)
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-membership"></see></summary>
    let ``has-membership`` = _prefix "has-membership"
    /// <summary>
    /// Contributions that are shared within a Group
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-shared-item"></see></summary>
    let ``has-shared-item`` = _prefix "has-shared-item"
    /// <summary>
    /// A User's interests
    /// <see href="http://rdf.myexperiment.org/ontologies/base/interests"></see></summary>
    let interests = _prefix "interests"
    /// <summary>
    /// A User's interests
    /// <see href="http://rdf.myexperiment.org/ontologies/base/is-current-version"></see></summary>
    let ``is-current-version`` = _prefix "is-current-version"
    /// <summary>
    /// A User may be friends with another User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/is-friends-with"></see></summary>
    let ``is-friends-with`` = _prefix "is-friends-with"
    /// <summary>
    /// The last time a User was seen
    /// <see href="http://rdf.myexperiment.org/ontologies/base/last-seen-at"></see></summary>
    let ``last-seen-at`` = _prefix "last-seen-at"
    /// <summary>
    /// The policy for Users joining a Group (e.g. open, invite only, etc.)
    /// <see href="http://rdf.myexperiment.org/ontologies/base/membership-policy"></see></summary>
    let ``membership-policy`` = _prefix "membership-policy"
    /// <summary>
    /// A User has an occupation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/occupation"></see></summary>
    let occupation = _prefix "occupation"
    /// <summary>
    /// A User may have an openid-url represented as a uri
    /// <see href="http://rdf.myexperiment.org/ontologies/base/openid-url"></see></summary>
    let ``openid-url`` = _prefix "openid-url"
    /// <summary>
    /// A User is part of an organisation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/organisation"></see></summary>
    let organisation = _prefix "organisation"
    /// <summary>
    /// A Message is a read-at a particular dateTime
    /// <see href="http://rdf.myexperiment.org/ontologies/base/read-at"></see></summary>
    let ``read-at`` = _prefix "read-at"
    /// <summary>
    /// Does the user receive-notifications
    /// <see href="http://rdf.myexperiment.org/ontologies/base/receive-notifications"></see></summary>
    let ``receive-notifications`` = _prefix "receive-notifications"
    /// <summary>
    /// A Message may have a Message it is a reply-to
    /// <see href="http://rdf.myexperiment.org/ontologies/base/reply-to"></see></summary>
    let ``reply-to`` = _prefix "reply-to"
    /// <summary>
    /// Requests may have a request-token as a string
    /// <see href="http://rdf.myexperiment.org/ontologies/base/request-token"></see></summary>
    let ``request-token`` = _prefix "request-token"
    /// <summary>
    /// Comments may be associated with a particular Version of something
    /// <see href="http://rdf.myexperiment.org/ontologies/base/revision-comments"></see></summary>
    let ``revision-comments`` = _prefix "revision-comments"
    /// <summary>
    /// A Message has a subject
    /// <see href="http://rdf.myexperiment.org/ontologies/base/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// A Message is sent to a User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/to"></see></summary>
    let to_ = _prefix "to"
    /// <summary>
    /// An email that has yet to be confirmed
    /// <see href="http://rdf.myexperiment.org/ontologies/base/unconfirmed-email"></see></summary>
    let ``unconfirmed-email`` = _prefix "unconfirmed-email"
    /// <summary>
    /// The URI for some object
    /// <see href="http://rdf.myexperiment.org/ontologies/base/uri"></see></summary>
    let uri = _prefix "uri"
