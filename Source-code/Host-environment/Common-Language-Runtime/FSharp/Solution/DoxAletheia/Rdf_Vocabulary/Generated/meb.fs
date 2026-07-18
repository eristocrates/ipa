namespace http.rdf.myexperiment.org.ontologies._base.slash

open DoxAletheia.Rdf_Vocabulary

module meb =
    let _namespace_name = "http://rdf.myexperiment.org/ontologies/base/"
    /// <summary>
    /// An object that can perform an action
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName
    /// <summary>
    /// An object that has been submitted.  This might be a Contribution, Annotation, Request or an Attibution/Creditation of an Upload
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Submission"></see></summary>
    let Submission = Namespaced_IRI.parse _namespace_name "Submission" |> NamespacedName

    /// <summary>
    /// An object that can be annotated with Annotations
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Annotatable"></see></summary>
    let Annotatable =
        Namespaced_IRI.parse _namespace_name "Annotatable" |> NamespacedName

    /// <summary>
    /// An Annotable may have a Annotation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-annotation"></see></summary>
    let ``has-annotation`` =
        Namespaced_IRI.parse _namespace_name "has-annotation" |> NamespacedName

    /// <summary>
    /// Superclass for all Interface classes
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Interface"></see></summary>
    let Interface = Namespaced_IRI.parse _namespace_name "Interface" |> NamespacedName
    /// <summary>
    /// An Annotation of a Annotatable object
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Annotation"></see></summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName
    /// <summary>
    /// An Annotation is associated with a particular Contribution
    /// <see href="http://rdf.myexperiment.org/ontologies/base/annotates"></see></summary>
    let annotates = Namespaced_IRI.parse _namespace_name "annotates" |> NamespacedName

    /// <summary>
    /// An Annotation has User as annotator
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-annotator"></see></summary>
    let ``has-annotator`` =
        Namespaced_IRI.parse _namespace_name "has-annotator" |> NamespacedName

    /// <summary>
    /// A Message sent between two Users
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Message"></see></summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName

    /// <summary>
    /// A public Announcement
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Announcement"></see></summary>
    let Announcement =
        Namespaced_IRI.parse _namespace_name "Announcement" |> NamespacedName

    /// <summary>
    /// An object that is contributed by a User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Contribution"></see></summary>
    let Contribution =
        Namespaced_IRI.parse _namespace_name "Contribution" |> NamespacedName

    /// <summary>
    /// A Request can be made by an Actor to another Actor
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Request"></see></summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName
    /// <summary>
    /// A Submission has some text associated with it
    /// <see href="http://rdf.myexperiment.org/ontologies/base/text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName

    /// <summary>
    /// An Announcement has an annoucer that is a User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-announcer"></see></summary>
    let ``has-announcer`` =
        Namespaced_IRI.parse _namespace_name "has-announcer" |> NamespacedName

    /// <summary>
    /// The type of content for an Upload
    /// <see href="http://rdf.myexperiment.org/ontologies/base/ContentType"></see></summary>
    let ContentType =
        Namespaced_IRI.parse _namespace_name "ContentType" |> NamespacedName

    /// <summary>
    /// A Contribution has a Policy for access rights management
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-policy"></see></summary>
    let ``has-policy`` =
        Namespaced_IRI.parse _namespace_name "has-policy" |> NamespacedName

    /// <summary>
    /// A Friendship between two Users
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Friendship"></see></summary>
    let Friendship = Namespaced_IRI.parse _namespace_name "Friendship" |> NamespacedName
    /// <summary>
    /// A Request could be an external Invitation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Invitation"></see></summary>
    let Invitation = Namespaced_IRI.parse _namespace_name "Invitation" |> NamespacedName
    /// <summary>
    /// A Membership of a User to a Group
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Membership"></see></summary>
    let Membership = Namespaced_IRI.parse _namespace_name "Membership" |> NamespacedName

    /// <summary>
    /// A FriendshipInvitation to an external email address
    /// <see href="http://rdf.myexperiment.org/ontologies/base/FriendshipInvitation"></see></summary>
    let FriendshipInvitation =
        Namespaced_IRI.parse _namespace_name "FriendshipInvitation" |> NamespacedName

    /// <summary>
    /// A MembershipInvitation to an external email address
    /// <see href="http://rdf.myexperiment.org/ontologies/base/MembershipInvitation"></see></summary>
    let MembershipInvitation =
        Namespaced_IRI.parse _namespace_name "MembershipInvitation" |> NamespacedName

    /// <summary>
    /// A Group of Users
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// A User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName

    /// <summary>
    /// An Announcement to a Group
    /// <see href="http://rdf.myexperiment.org/ontologies/base/GroupAnnouncement"></see></summary>
    let GroupAnnouncement =
        Namespaced_IRI.parse _namespace_name "GroupAnnouncement" |> NamespacedName

    /// <summary>
    /// The Group a GroupAnnouncement has been announced to
    /// <see href="http://rdf.myexperiment.org/ontologies/base/announced-to"></see></summary>
    let ``announced-to`` =
        Namespaced_IRI.parse _namespace_name "announced-to" |> NamespacedName

    /// <summary>
    /// Is the GroupAnnouncement viewable (public) to those outside the Group
    /// <see href="http://rdf.myexperiment.org/ontologies/base/public-announcement"></see></summary>
    let ``public-announcement`` =
        Namespaced_IRI.parse _namespace_name "public-announcement" |> NamespacedName

    /// <summary>
    /// A License under which an Upload is licensed under
    /// <see href="http://rdf.myexperiment.org/ontologies/base/License"></see></summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName

    /// <summary>
    /// A Request can be accepted-at a certain dateTime
    /// <see href="http://rdf.myexperiment.org/ontologies/base/accepted-at"></see></summary>
    let ``accepted-at`` =
        Namespaced_IRI.parse _namespace_name "accepted-at" |> NamespacedName

    /// <summary>
    /// A Request must have an accepter that can accept
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-accepter"></see></summary>
    let ``has-accepter`` =
        Namespaced_IRI.parse _namespace_name "has-accepter" |> NamespacedName

    /// <summary>
    /// A Request must have a requester
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-requester"></see></summary>
    let ``has-requester`` =
        Namespaced_IRI.parse _namespace_name "has-requester" |> NamespacedName

    /// <summary>
    /// An object that can be contributed by a User that requires uploading
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Upload"></see></summary>
    let Upload = Namespaced_IRI.parse _namespace_name "Upload" |> NamespacedName

    /// <summary>
    /// An Upload has a ContentType
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-content-type"></see></summary>
    let ``has-content-type`` =
        Namespaced_IRI.parse _namespace_name "has-content-type" |> NamespacedName

    /// <summary>
    /// An Upload has content at a URL
    /// <see href="http://rdf.myexperiment.org/ontologies/base/content-url"></see></summary>
    let ``content-url`` =
        Namespaced_IRI.parse _namespace_name "content-url" |> NamespacedName

    /// <summary>
    /// A User may have a username represented as a string
    /// <see href="http://rdf.myexperiment.org/ontologies/base/username"></see></summary>
    let username = Namespaced_IRI.parse _namespace_name "username" |> NamespacedName
    /// <summary>
    /// A Contribution may be a Version of another Contribution
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Version"></see></summary>
    let Version = Namespaced_IRI.parse _namespace_name "Version" |> NamespacedName

    /// <summary>
    /// A Version has a version-number
    /// <see href="http://rdf.myexperiment.org/ontologies/base/version-number"></see></summary>
    let ``version-number`` =
        Namespaced_IRI.parse _namespace_name "version-number" |> NamespacedName

    /// <summary>
    /// A Contribution that can be a Version
    /// <see href="http://rdf.myexperiment.org/ontologies/base/Versionable"></see></summary>
    let Versionable =
        Namespaced_IRI.parse _namespace_name "Versionable" |> NamespacedName

    /// <summary>
    /// A Versionable object has at least one version
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-version"></see></summary>
    let ``has-version`` =
        Namespaced_IRI.parse _namespace_name "has-version" |> NamespacedName

    /// <summary>
    /// A User account is a activated-at certain dateTime
    /// <see href="http://rdf.myexperiment.org/ontologies/base/activated-at"></see></summary>
    let ``activated-at`` =
        Namespaced_IRI.parse _namespace_name "activated-at" |> NamespacedName

    /// <summary>
    /// A User is an annotator-of an Annotation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/annotator-of"></see></summary>
    let ``annotator-of`` =
        Namespaced_IRI.parse _namespace_name "annotator-of" |> NamespacedName

    /// <summary>
    /// A User has contact-details
    /// <see href="http://rdf.myexperiment.org/ontologies/base/contact-details"></see></summary>
    let ``contact-details`` =
        Namespaced_IRI.parse _namespace_name "contact-details" |> NamespacedName

    /// <summary>
    /// Certain Annotations may be a count of something
    /// <see href="http://rdf.myexperiment.org/ontologies/base/count"></see></summary>
    let count = Namespaced_IRI.parse _namespace_name "count" |> NamespacedName
    /// <summary>
    /// A User is based in a country
    /// <see href="http://rdf.myexperiment.org/ontologies/base/country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    /// The recipient has deleted this Message from their inbox
    /// <see href="http://rdf.myexperiment.org/ontologies/base/deleted-by-recipient"></see></summary>
    let ``deleted-by-recipient`` =
        Namespaced_IRI.parse _namespace_name "deleted-by-recipient" |> NamespacedName

    /// <summary>
    /// The sender has deleted this Message from their inbox
    /// <see href="http://rdf.myexperiment.org/ontologies/base/deleted-by-sender"></see></summary>
    let ``deleted-by-sender`` =
        Namespaced_IRI.parse _namespace_name "deleted-by-sender" |> NamespacedName

    /// <summary>
    /// A User has an email address
    /// <see href="http://rdf.myexperiment.org/ontologies/base/email"></see></summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName

    /// <summary>
    /// An email is confirmed at a certain dateTime
    /// <see href="http://rdf.myexperiment.org/ontologies/base/email-confirmed-at"></see></summary>
    let ``email-confirmed-at`` =
        Namespaced_IRI.parse _namespace_name "email-confirmed-at" |> NamespacedName

    /// <summary>
    /// A User works in a field
    /// <see href="http://rdf.myexperiment.org/ontologies/base/field"></see></summary>
    let field = Namespaced_IRI.parse _namespace_name "field" |> NamespacedName
    /// <summary>
    /// A File has a filename
    /// <see href="http://rdf.myexperiment.org/ontologies/base/filename"></see></summary>
    let filename = Namespaced_IRI.parse _namespace_name "filename" |> NamespacedName
    /// <summary>
    /// A Message is sent from a User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName

    /// <summary>
    /// Groups may have GroupAnnouncements
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-announcement"></see></summary>
    let ``has-announcement`` =
        Namespaced_IRI.parse _namespace_name "has-announcement" |> NamespacedName

    /// <summary>
    /// A Versionable object has a current version
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-current-version"></see></summary>
    let ``has-current-version`` =
        Namespaced_IRI.parse _namespace_name "has-current-version" |> NamespacedName

    /// <summary>
    /// A User has a Friendship (with another User)
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-friendship"></see></summary>
    let ``has-friendship`` =
        Namespaced_IRI.parse _namespace_name "has-friendship" |> NamespacedName

    /// <summary>
    /// A User has a Membership (of a Group)
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-membership"></see></summary>
    let ``has-membership`` =
        Namespaced_IRI.parse _namespace_name "has-membership" |> NamespacedName

    /// <summary>
    /// Contributions that are shared within a Group
    /// <see href="http://rdf.myexperiment.org/ontologies/base/has-shared-item"></see></summary>
    let ``has-shared-item`` =
        Namespaced_IRI.parse _namespace_name "has-shared-item" |> NamespacedName

    /// <summary>
    /// A User's interests
    /// <see href="http://rdf.myexperiment.org/ontologies/base/interests"></see></summary>
    let interests = Namespaced_IRI.parse _namespace_name "interests" |> NamespacedName

    /// <summary>
    /// A User's interests
    /// <see href="http://rdf.myexperiment.org/ontologies/base/is-current-version"></see></summary>
    let ``is-current-version`` =
        Namespaced_IRI.parse _namespace_name "is-current-version" |> NamespacedName

    /// <summary>
    /// A User may be friends with another User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/is-friends-with"></see></summary>
    let ``is-friends-with`` =
        Namespaced_IRI.parse _namespace_name "is-friends-with" |> NamespacedName

    /// <summary>
    /// The last time a User was seen
    /// <see href="http://rdf.myexperiment.org/ontologies/base/last-seen-at"></see></summary>
    let ``last-seen-at`` =
        Namespaced_IRI.parse _namespace_name "last-seen-at" |> NamespacedName

    /// <summary>
    /// The policy for Users joining a Group (e.g. open, invite only, etc.)
    /// <see href="http://rdf.myexperiment.org/ontologies/base/membership-policy"></see></summary>
    let ``membership-policy`` =
        Namespaced_IRI.parse _namespace_name "membership-policy" |> NamespacedName

    /// <summary>
    /// A User has an occupation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/occupation"></see></summary>
    let occupation = Namespaced_IRI.parse _namespace_name "occupation" |> NamespacedName

    /// <summary>
    /// A User may have an openid-url represented as a uri
    /// <see href="http://rdf.myexperiment.org/ontologies/base/openid-url"></see></summary>
    let ``openid-url`` =
        Namespaced_IRI.parse _namespace_name "openid-url" |> NamespacedName

    /// <summary>
    /// A User is part of an organisation
    /// <see href="http://rdf.myexperiment.org/ontologies/base/organisation"></see></summary>
    let organisation =
        Namespaced_IRI.parse _namespace_name "organisation" |> NamespacedName

    /// <summary>
    /// A Message is a read-at a particular dateTime
    /// <see href="http://rdf.myexperiment.org/ontologies/base/read-at"></see></summary>
    let ``read-at`` = Namespaced_IRI.parse _namespace_name "read-at" |> NamespacedName

    /// <summary>
    /// Does the user receive-notifications
    /// <see href="http://rdf.myexperiment.org/ontologies/base/receive-notifications"></see></summary>
    let ``receive-notifications`` =
        Namespaced_IRI.parse _namespace_name "receive-notifications" |> NamespacedName

    /// <summary>
    /// A Message may have a Message it is a reply-to
    /// <see href="http://rdf.myexperiment.org/ontologies/base/reply-to"></see></summary>
    let ``reply-to`` = Namespaced_IRI.parse _namespace_name "reply-to" |> NamespacedName

    /// <summary>
    /// Requests may have a request-token as a string
    /// <see href="http://rdf.myexperiment.org/ontologies/base/request-token"></see></summary>
    let ``request-token`` =
        Namespaced_IRI.parse _namespace_name "request-token" |> NamespacedName

    /// <summary>
    /// Comments may be associated with a particular Version of something
    /// <see href="http://rdf.myexperiment.org/ontologies/base/revision-comments"></see></summary>
    let ``revision-comments`` =
        Namespaced_IRI.parse _namespace_name "revision-comments" |> NamespacedName

    /// <summary>
    /// A Message has a subject
    /// <see href="http://rdf.myexperiment.org/ontologies/base/subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// A Message is sent to a User
    /// <see href="http://rdf.myexperiment.org/ontologies/base/to"></see></summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName

    /// <summary>
    /// An email that has yet to be confirmed
    /// <see href="http://rdf.myexperiment.org/ontologies/base/unconfirmed-email"></see></summary>
    let ``unconfirmed-email`` =
        Namespaced_IRI.parse _namespace_name "unconfirmed-email" |> NamespacedName

    /// <summary>
    /// The URI for some object
    /// <see href="http://rdf.myexperiment.org/ontologies/base/uri"></see></summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName
