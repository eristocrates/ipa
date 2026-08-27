namespace http.rdf.myexperiment.org.ontologies._base.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module meb =
    let _namespace_iri = Namespace_Iri meb |> NamespaceIRI
    /// <summary>
    ///   <para>meb:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This provides the base elements required by myExperiment for content management, social networking and object annotation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"myExperiment Base v1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/">http://rdf.myexperiment.org/ontologies/base/</seealso>
    let _prefix_iri = Prefixed_Name(meb, "") |> PrefixedName
    /// <summary>
    ///   <para>meb:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object that can perform an action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Actor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Actor">http://rdf.myexperiment.org/ontologies/base/Actor</seealso>
    let Actor = Prefixed_Name(meb, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>meb:Annotatable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object that can be annotated with Annotations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Annotatable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Annotatable">http://rdf.myexperiment.org/ontologies/base/Annotatable</seealso>
    let Annotatable = Prefixed_Name(meb, "Annotatable") |> PrefixedName
    /// <summary>
    ///   <para>meb:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Annotation of a Annotatable object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Annotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Annotation">http://rdf.myexperiment.org/ontologies/base/Annotation</seealso>
    let Annotation = Prefixed_Name(meb, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>meb:Announcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A public Announcement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Announcement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Announcement">http://rdf.myexperiment.org/ontologies/base/Announcement</seealso>
    let Announcement = Prefixed_Name(meb, "Announcement") |> PrefixedName
    /// <summary>
    ///   <para>meb:ContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The type of content for an Upload"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContentType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/ContentType">http://rdf.myexperiment.org/ontologies/base/ContentType</seealso>
    let ContentType = Prefixed_Name(meb, "ContentType") |> PrefixedName
    /// <summary>
    ///   <para>meb:Contribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object that is contributed by a User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Contribution">http://rdf.myexperiment.org/ontologies/base/Contribution</seealso>
    let Contribution = Prefixed_Name(meb, "Contribution") |> PrefixedName
    /// <summary>
    ///   <para>meb:Friendship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Friendship between two Users"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Friendship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Friendship">http://rdf.myexperiment.org/ontologies/base/Friendship</seealso>
    let Friendship = Prefixed_Name(meb, "Friendship") |> PrefixedName

    /// <summary>
    ///   <para>meb:FriendshipInvitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A FriendshipInvitation to an external email address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FriendshipInvitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/FriendshipInvitation">http://rdf.myexperiment.org/ontologies/base/FriendshipInvitation</seealso>
    let FriendshipInvitation =
        Prefixed_Name(meb, "FriendshipInvitation") |> PrefixedName

    /// <summary>
    ///   <para>meb:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Group of Users"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Group">http://rdf.myexperiment.org/ontologies/base/Group</seealso>
    let Group = Prefixed_Name(meb, "Group") |> PrefixedName
    /// <summary>
    ///   <para>meb:GroupAnnouncement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Announcement to a Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GroupAnnouncement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/GroupAnnouncement">http://rdf.myexperiment.org/ontologies/base/GroupAnnouncement</seealso>
    let GroupAnnouncement = Prefixed_Name(meb, "GroupAnnouncement") |> PrefixedName
    /// <summary>
    ///   <para>meb:Interface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Superclass for all Interface classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Interface">http://rdf.myexperiment.org/ontologies/base/Interface</seealso>
    let Interface = Prefixed_Name(meb, "Interface") |> PrefixedName
    /// <summary>
    ///   <para>meb:Invitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Request could be an external Invitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Invitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Invitation">http://rdf.myexperiment.org/ontologies/base/Invitation</seealso>
    let Invitation = Prefixed_Name(meb, "Invitation") |> PrefixedName
    /// <summary>
    ///   <para>meb:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A License under which an Upload is licensed under"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"License"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/License">http://rdf.myexperiment.org/ontologies/base/License</seealso>
    let License = Prefixed_Name(meb, "License") |> PrefixedName
    /// <summary>
    ///   <para>meb:Membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Membership of a User to a Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Membership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Membership">http://rdf.myexperiment.org/ontologies/base/Membership</seealso>
    let Membership = Prefixed_Name(meb, "Membership") |> PrefixedName

    /// <summary>
    ///   <para>meb:MembershipInvitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A MembershipInvitation to an external email address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MembershipInvitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/MembershipInvitation">http://rdf.myexperiment.org/ontologies/base/MembershipInvitation</seealso>
    let MembershipInvitation =
        Prefixed_Name(meb, "MembershipInvitation") |> PrefixedName

    /// <summary>
    ///   <para>meb:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Message sent between two Users"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Message"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Message">http://rdf.myexperiment.org/ontologies/base/Message</seealso>
    let Message = Prefixed_Name(meb, "Message") |> PrefixedName
    /// <summary>
    ///   <para>meb:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Request can be made by an Actor to another Actor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Request"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Request">http://rdf.myexperiment.org/ontologies/base/Request</seealso>
    let Request = Prefixed_Name(meb, "Request") |> PrefixedName
    /// <summary>
    ///   <para>meb:Submission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object that has been submitted.  This might be a Contribution, Annotation, Request or an Attibution/Creditation of an Upload"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Submission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Submission">http://rdf.myexperiment.org/ontologies/base/Submission</seealso>
    let Submission = Prefixed_Name(meb, "Submission") |> PrefixedName
    /// <summary>
    ///   <para>meb:Upload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object that can be contributed by a User that requires uploading"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Upload"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Upload">http://rdf.myexperiment.org/ontologies/base/Upload</seealso>
    let Upload = Prefixed_Name(meb, "Upload") |> PrefixedName
    /// <summary>
    ///   <para>meb:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/User">http://rdf.myexperiment.org/ontologies/base/User</seealso>
    let User = Prefixed_Name(meb, "User") |> PrefixedName
    /// <summary>
    ///   <para>meb:Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Contribution may be a Version of another Contribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Version">http://rdf.myexperiment.org/ontologies/base/Version</seealso>
    let Version = Prefixed_Name(meb, "Version") |> PrefixedName
    /// <summary>
    ///   <para>meb:Versionable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Contribution that can be a Version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Versionable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/Versionable">http://rdf.myexperiment.org/ontologies/base/Versionable</seealso>
    let Versionable = Prefixed_Name(meb, "Versionable") |> PrefixedName
    /// <summary>
    ///   <para>meb:accepted-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Request can be accepted-at a certain dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"accepted-at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/accepted-at">http://rdf.myexperiment.org/ontologies/base/accepted-at</seealso>
    let accepted_at = Prefixed_Name(meb, "accepted-at") |> PrefixedName
    /// <summary>
    ///   <para>meb:activated-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A User account is a activated-at certain dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"activated-at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/activated-at">http://rdf.myexperiment.org/ontologies/base/activated-at</seealso>
    let activated_at = Prefixed_Name(meb, "activated-at") |> PrefixedName
    /// <summary>
    ///   <para>meb:annotates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Annotation is associated with a particular Contribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"annotates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/annotates">http://rdf.myexperiment.org/ontologies/base/annotates</seealso>
    let annotates = Prefixed_Name(meb, "annotates") |> PrefixedName
    /// <summary>
    ///   <para>meb:annotator-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A User is an annotator-of an Annotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"annotator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/annotator-of">http://rdf.myexperiment.org/ontologies/base/annotator-of</seealso>
    let annotator_of = Prefixed_Name(meb, "annotator-of") |> PrefixedName
    /// <summary>
    ///   <para>meb:announced-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Group a GroupAnnouncement has been announced to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"announced-to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/announced-to">http://rdf.myexperiment.org/ontologies/base/announced-to</seealso>
    let announced_to = Prefixed_Name(meb, "announced-to") |> PrefixedName
    /// <summary>
    ///   <para>meb:contact-details</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A User has contact-details"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contact-details"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/contact-details">http://rdf.myexperiment.org/ontologies/base/contact-details</seealso>
    let contact_details = Prefixed_Name(meb, "contact-details") |> PrefixedName
    /// <summary>
    ///   <para>meb:content-url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Upload has content at a URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"content-url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/content-url">http://rdf.myexperiment.org/ontologies/base/content-url</seealso>
    let content_url = Prefixed_Name(meb, "content-url") |> PrefixedName
    /// <summary>
    ///   <para>meb:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Certain Annotations may be a count of something"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/count">http://rdf.myexperiment.org/ontologies/base/count</seealso>
    let count = Prefixed_Name(meb, "count") |> PrefixedName
    /// <summary>
    ///   <para>meb:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A User is based in a country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/country">http://rdf.myexperiment.org/ontologies/base/country</seealso>
    let country = Prefixed_Name(meb, "country") |> PrefixedName

    /// <summary>
    ///   <para>meb:deleted-by-recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The recipient has deleted this Message from their inbox"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deleted-by-recipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/deleted-by-recipient">http://rdf.myexperiment.org/ontologies/base/deleted-by-recipient</seealso>
    let deleted_by_recipient =
        Prefixed_Name(meb, "deleted-by-recipient") |> PrefixedName

    /// <summary>
    ///   <para>meb:deleted-by-sender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The sender has deleted this Message from their inbox"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deleted-by-sender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/deleted-by-sender">http://rdf.myexperiment.org/ontologies/base/deleted-by-sender</seealso>
    let deleted_by_sender = Prefixed_Name(meb, "deleted-by-sender") |> PrefixedName
    /// <summary>
    ///   <para>meb:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A User has an email address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"email"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/email">http://rdf.myexperiment.org/ontologies/base/email</seealso>
    let email = Prefixed_Name(meb, "email") |> PrefixedName
    /// <summary>
    ///   <para>meb:email-confirmed-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An email is confirmed at a certain dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"email-confirmed-at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/email-confirmed-at">http://rdf.myexperiment.org/ontologies/base/email-confirmed-at</seealso>
    let email_confirmed_at = Prefixed_Name(meb, "email-confirmed-at") |> PrefixedName
    /// <summary>
    ///   <para>meb:field</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A User works in a field"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"field"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/field">http://rdf.myexperiment.org/ontologies/base/field</seealso>
    let field = Prefixed_Name(meb, "field") |> PrefixedName
    /// <summary>
    ///   <para>meb:filename</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A File has a filename"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"filename"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/filename">http://rdf.myexperiment.org/ontologies/base/filename</seealso>
    let filename = Prefixed_Name(meb, "filename") |> PrefixedName
    /// <summary>
    ///   <para>meb:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Message is sent from a User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/from">http://rdf.myexperiment.org/ontologies/base/from</seealso>
    let from = Prefixed_Name(meb, "from") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-accepter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A Request must have an accepter that can accept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-accepter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-accepter">http://rdf.myexperiment.org/ontologies/base/has-accepter</seealso>
    let has_accepter = Prefixed_Name(meb, "has-accepter") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Annotable may have a Annotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-annotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-annotation">http://rdf.myexperiment.org/ontologies/base/has-annotation</seealso>
    let has_annotation = Prefixed_Name(meb, "has-annotation") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-annotator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Annotation has User as annotator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-annotator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-annotator">http://rdf.myexperiment.org/ontologies/base/has-annotator</seealso>
    let has_annotator = Prefixed_Name(meb, "has-annotator") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-announcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Groups may have GroupAnnouncements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-announcement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-announcement">http://rdf.myexperiment.org/ontologies/base/has-announcement</seealso>
    let has_announcement = Prefixed_Name(meb, "has-announcement") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-announcer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Announcement has an annoucer that is a User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-announcer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-announcer">http://rdf.myexperiment.org/ontologies/base/has-announcer</seealso>
    let has_announcer = Prefixed_Name(meb, "has-announcer") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-content-type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An Upload has a ContentType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-content-type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-content-type">http://rdf.myexperiment.org/ontologies/base/has-content-type</seealso>
    let has_content_type = Prefixed_Name(meb, "has-content-type") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-current-version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A Versionable object has a current version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-current-version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-current-version">http://rdf.myexperiment.org/ontologies/base/has-current-version</seealso>
    let has_current_version = Prefixed_Name(meb, "has-current-version") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-friendship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A User has a Friendship (with another User)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-friendship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-friendship">http://rdf.myexperiment.org/ontologies/base/has-friendship</seealso>
    let has_friendship = Prefixed_Name(meb, "has-friendship") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"A User has a Membership (of a Group)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-membership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-membership">http://rdf.myexperiment.org/ontologies/base/has-membership</seealso>
    let has_membership = Prefixed_Name(meb, "has-membership") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A Contribution has a Policy for access rights management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-policy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-policy">http://rdf.myexperiment.org/ontologies/base/has-policy</seealso>
    let has_policy = Prefixed_Name(meb, "has-policy") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-requester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Request must have a requester"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-requester"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-requester">http://rdf.myexperiment.org/ontologies/base/has-requester</seealso>
    let has_requester = Prefixed_Name(meb, "has-requester") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-shared-item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Contributions that are shared within a Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-shared-item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-shared-item">http://rdf.myexperiment.org/ontologies/base/has-shared-item</seealso>
    let has_shared_item = Prefixed_Name(meb, "has-shared-item") |> PrefixedName
    /// <summary>
    ///   <para>meb:has-version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Versionable object has at least one version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has-version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/has-version">http://rdf.myexperiment.org/ontologies/base/has-version</seealso>
    let has_version = Prefixed_Name(meb, "has-version") |> PrefixedName
    /// <summary>
    ///   <para>meb:interests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A User's interests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/interests">http://rdf.myexperiment.org/ontologies/base/interests</seealso>
    let interests = Prefixed_Name(meb, "interests") |> PrefixedName
    /// <summary>
    ///   <para>meb:is-current-version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A User's interests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is-current-version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/is-current-version">http://rdf.myexperiment.org/ontologies/base/is-current-version</seealso>
    let is_current_version = Prefixed_Name(meb, "is-current-version") |> PrefixedName
    /// <summary>
    ///   <para>meb:is-friends-with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A User may be friends with another User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is-friends-with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/is-friends-with">http://rdf.myexperiment.org/ontologies/base/is-friends-with</seealso>
    let is_friends_with = Prefixed_Name(meb, "is-friends-with") |> PrefixedName
    /// <summary>
    ///   <para>meb:last-seen-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The last time a User was seen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"last-seen-at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/last-seen-at">http://rdf.myexperiment.org/ontologies/base/last-seen-at</seealso>
    let last_seen_at = Prefixed_Name(meb, "last-seen-at") |> PrefixedName
    /// <summary>
    ///   <para>meb:membership-policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The policy for Users joining a Group (e.g. open, invite only, etc.)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/membership-policy">http://rdf.myexperiment.org/ontologies/base/membership-policy</seealso>
    let membership_policy = Prefixed_Name(meb, "membership-policy") |> PrefixedName
    /// <summary>
    ///   <para>meb:occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A User has an occupation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"occupation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/occupation">http://rdf.myexperiment.org/ontologies/base/occupation</seealso>
    let occupation = Prefixed_Name(meb, "occupation") |> PrefixedName
    /// <summary>
    ///   <para>meb:openid-url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A User may have an openid-url represented as a uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"openid-url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/openid-url">http://rdf.myexperiment.org/ontologies/base/openid-url</seealso>
    let openid_url = Prefixed_Name(meb, "openid-url") |> PrefixedName
    /// <summary>
    ///   <para>meb:organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A User is part of an organisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/organisation">http://rdf.myexperiment.org/ontologies/base/organisation</seealso>
    let organisation = Prefixed_Name(meb, "organisation") |> PrefixedName
    /// <summary>
    ///   <para>meb:public-announcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Is the GroupAnnouncement viewable (public) to those outside the Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"public-announcement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/public-announcement">http://rdf.myexperiment.org/ontologies/base/public-announcement</seealso>
    let public_announcement = Prefixed_Name(meb, "public-announcement") |> PrefixedName
    /// <summary>
    ///   <para>meb:read-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Message is a read-at a particular dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"read-at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/read-at">http://rdf.myexperiment.org/ontologies/base/read-at</seealso>
    let read_at = Prefixed_Name(meb, "read-at") |> PrefixedName

    /// <summary>
    ///   <para>meb:receive-notifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Does the user receive-notifications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"receive-notifications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/receive-notifications">http://rdf.myexperiment.org/ontologies/base/receive-notifications</seealso>
    let receive_notifications =
        Prefixed_Name(meb, "receive-notifications") |> PrefixedName

    /// <summary>
    ///   <para>meb:reply-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A Message may have a Message it is a reply-to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reply-to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/reply-to">http://rdf.myexperiment.org/ontologies/base/reply-to</seealso>
    let reply_to = Prefixed_Name(meb, "reply-to") |> PrefixedName
    /// <summary>
    ///   <para>meb:request-token</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Requests may have a request-token as a string"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"request-token"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/request-token">http://rdf.myexperiment.org/ontologies/base/request-token</seealso>
    let request_token = Prefixed_Name(meb, "request-token") |> PrefixedName
    /// <summary>
    ///   <para>meb:revision-comments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Comments may be associated with a particular Version of something"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"revision-comments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/revision-comments">http://rdf.myexperiment.org/ontologies/base/revision-comments</seealso>
    let revision_comments = Prefixed_Name(meb, "revision-comments") |> PrefixedName
    /// <summary>
    ///   <para>meb:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A Message has a subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/subject">http://rdf.myexperiment.org/ontologies/base/subject</seealso>
    let subject = Prefixed_Name(meb, "subject") |> PrefixedName
    /// <summary>
    ///   <para>meb:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Submission has some text associated with it"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/text">http://rdf.myexperiment.org/ontologies/base/text</seealso>
    let text = Prefixed_Name(meb, "text") |> PrefixedName
    /// <summary>
    ///   <para>meb:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Message is sent to a User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/to">http://rdf.myexperiment.org/ontologies/base/to</seealso>
    let to_ = Prefixed_Name(meb, "to") |> PrefixedName
    /// <summary>
    ///   <para>meb:unconfirmed-email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An email that has yet to be confirmed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unconfirmed-email"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/unconfirmed-email">http://rdf.myexperiment.org/ontologies/base/unconfirmed-email</seealso>
    let unconfirmed_email = Prefixed_Name(meb, "unconfirmed-email") |> PrefixedName
    /// <summary>
    ///   <para>meb:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The URI for some object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uri"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/uri">http://rdf.myexperiment.org/ontologies/base/uri</seealso>
    let uri = Prefixed_Name(meb, "uri") |> PrefixedName
    /// <summary>
    ///   <para>meb:username</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A User may have a username represented as a string"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"username"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/username">http://rdf.myexperiment.org/ontologies/base/username</seealso>
    let username = Prefixed_Name(meb, "username") |> PrefixedName
    /// <summary>
    ///   <para>meb:version-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Version has a version-number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version-number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.myexperiment.org/ontologies/base/version-number">http://rdf.myexperiment.org/ontologies/base/version-number</seealso>
    let version_number = Prefixed_Name(meb, "version-number") |> PrefixedName
