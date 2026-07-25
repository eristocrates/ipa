namespace http.rdfs.org.sioc.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sioc =
    let _namespace_iri = Namespace_Iri sioc |> NamespaceIRI
    /// <summary>
    ///   <para>sioc:Community</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Community is a high-level concept that defines an online community and what it consists of.</para>
    /// labels<para>Community</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Community">http://rdfs.org/sioc/ns#Community</seealso>
    let Community = Prefixed_Name(sioc, "Community") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Role is a function of a UserAccount within a scope of a particular Forum, Site, etc.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Role">http://rdfs.org/sioc/ns#Role</seealso>
    let Role = Prefixed_Name(sioc, "Role") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Item is something which can be in a Container.</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Item">http://rdfs.org/sioc/ns#Item</seealso>
    let Item = Prefixed_Name(sioc, "Item") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Usergroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of UserAccounts whose owners have a common purpose or interest. Can be used for access control purposes.</para>
    /// labels<para>Usergroup</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Usergroup">http://rdfs.org/sioc/ns#Usergroup</seealso>
    let Usergroup = Prefixed_Name(sioc, "Usergroup") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Site can be the location of an online community or set of communities, with UserAccounts and Usergroups creating Items in a set of Containers. It can be thought of as a web-accessible data Space.</para>
    /// labels<para>Site</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Site">http://rdfs.org/sioc/ns#Site</seealso>
    let Site = Prefixed_Name(sioc, "Site") |> PrefixedName
    /// <summary>
    ///   <para>sioc:addressed_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to who (e.g. a UserAccount, e-mail address, etc.) a particular Item is addressed to.</para>
    /// labels<para>addressed to</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#addressed_to">http://rdfs.org/sioc/ns#addressed_to</seealso>
    let addressed_to = Prefixed_Name(sioc, "addressed_to") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_administrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A UserAccount that is an administrator of this Site.</para>
    /// labels<para>has administrator</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_administrator">http://rdfs.org/sioc/ns#has_administrator</seealso>
    let has_administrator = Prefixed_Name(sioc, "has_administrator") |> PrefixedName
    /// <summary>
    ///   <para>sioc:attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URI of a file attached to an Item.</para>
    /// labels<para>attachment</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#attachment">http://rdfs.org/sioc/ns#attachment</seealso>
    let attachment = Prefixed_Name(sioc, "attachment") |> PrefixedName
    /// <summary>
    ///   <para>sioc:container_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Item that this Container contains.</para>
    /// labels<para>container of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#container_of">http://rdfs.org/sioc/ns#container_of</seealso>
    let container_of = Prefixed_Name(sioc, "container_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:content_encoded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>The encoded content of the Post, contained in CDATA areas.</para>
    /// labels<para>content encoded</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#content_encoded">http://rdfs.org/sioc/ns#content_encoded</seealso>
    let content_encoded = Prefixed_Name(sioc, "content_encoded") |> PrefixedName
    /// <summary>
    ///   <para>sioc:creator_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource that the UserAccount is a creator of.</para>
    /// labels<para>creator of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#creator_of">http://rdfs.org/sioc/ns#creator_of</seealso>
    let creator_of = Prefixed_Name(sioc, "creator_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:later_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Links to a later (newer) revision of this Item or Post.</para>
    /// labels<para>later version</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#later_version">http://rdfs.org/sioc/ns#later_version</seealso>
    let later_version = Prefixed_Name(sioc, "later_version") |> PrefixedName
    /// <summary>
    ///   <para>sioc:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An electronic mail address of the UserAccount.</para>
    /// labels<para>email</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#email">http://rdfs.org/sioc/ns#email</seealso>
    let email = Prefixed_Name(sioc, "email") |> PrefixedName
    /// <summary>
    ///   <para>sioc:email_sha1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An electronic mail address of the UserAccount, encoded using SHA1.</para>
    /// labels<para>email sha1</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#email_sha1">http://rdfs.org/sioc/ns#email_sha1</seealso>
    let email_sha1 = Prefixed_Name(sioc, "email_sha1") |> PrefixedName
    /// <summary>
    ///   <para>sioc:embeds_knowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This links Items to embedded statements, facts and structured content.</para>
    /// labels<para>embeds knowledge</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#embeds_knowledge">http://rdfs.org/sioc/ns#embeds_knowledge</seealso>
    let embeds_knowledge = Prefixed_Name(sioc, "embeds_knowledge") |> PrefixedName
    /// <summary>
    ///   <para>sioc:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that one UserAccount follows another UserAccount (e.g. for microblog posts or other content item updates).</para>
    /// labels<para>follows</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#follows">http://rdfs.org/sioc/ns#follows</seealso>
    let follows = Prefixed_Name(sioc, "follows") |> PrefixedName
    /// <summary>
    ///   <para>sioc:function_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A UserAccount that has this Role.</para>
    /// labels<para>function of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#function_of">http://rdfs.org/sioc/ns#function_of</seealso>
    let function_of = Prefixed_Name(sioc, "function_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Role that this UserAccount has.</para>
    /// labels<para>has function</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_function">http://rdfs.org/sioc/ns#has_function</seealso>
    let has_function = Prefixed_Name(sioc, "has_function") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_discussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The discussion that is related to this Item.</para>
    /// labels<para>has discussion</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_discussion">http://rdfs.org/sioc/ns#has_discussion</seealso>
    let has_discussion = Prefixed_Name(sioc, "has_discussion") |> PrefixedName
    /// <summary>
    ///   <para>sioc:member_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Usergroup that this UserAccount is a member of.</para>
    /// labels<para>member of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#member_of">http://rdfs.org/sioc/ns#member_of</seealso>
    let member_of = Prefixed_Name(sioc, "member_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_moderator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A UserAccount that is a moderator of this Forum.</para>
    /// labels<para>has moderator</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_moderator">http://rdfs.org/sioc/ns#has_moderator</seealso>
    let has_moderator = Prefixed_Name(sioc, "has_moderator") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_modifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A UserAccount that modified this Item.</para>
    /// labels<para>has modifier</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_modifier">http://rdfs.org/sioc/ns#has_modifier</seealso>
    let has_modifier = Prefixed_Name(sioc, "has_modifier") |> PrefixedName
    /// <summary>
    ///   <para>sioc:modifier_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Item that this UserAccount has modified.</para>
    /// labels<para>modifier of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#modifier_of">http://rdfs.org/sioc/ns#modifier_of</seealso>
    let modifier_of = Prefixed_Name(sioc, "modifier_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An resource that is a part of this subject.</para>
    /// labels<para>has part</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_part">http://rdfs.org/sioc/ns#has_part</seealso>
    let has_part = Prefixed_Name(sioc, "has_part") |> PrefixedName
    /// <summary>
    ///   <para>sioc:part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource that the subject is a part of.</para>
    /// labels<para>part of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#part_of">http://rdfs.org/sioc/ns#part_of</seealso>
    let part_of = Prefixed_Name(sioc, "part_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_reply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Points to an Item or Post that is a reply or response to this Item or Post.</para>
    /// labels<para>has reply</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_reply">http://rdfs.org/sioc/ns#has_reply</seealso>
    let has_reply = Prefixed_Name(sioc, "has_reply") |> PrefixedName
    /// <summary>
    ///   <para>sioc:space_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource which belongs to this data Space.</para>
    /// labels<para>space of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#space_of">http://rdfs.org/sioc/ns#space_of</seealso>
    let space_of = Prefixed_Name(sioc, "space_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_subscriber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A UserAccount that is subscribed to this Container.</para>
    /// labels<para>has subscriber</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_subscriber">http://rdfs.org/sioc/ns#has_subscriber</seealso>
    let has_subscriber = Prefixed_Name(sioc, "has_subscriber") |> PrefixedName
    /// <summary>
    ///   <para>sioc:subscriber_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Container that a UserAccount is subscribed to.</para>
    /// labels<para>subscriber of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#subscriber_of">http://rdfs.org/sioc/ns#subscriber_of</seealso>
    let subscriber_of = Prefixed_Name(sioc, "subscriber_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_usergroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Points to a Usergroup that has certain access to this Space.</para>
    /// labels<para>has usergroup</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_usergroup">http://rdfs.org/sioc/ns#has_usergroup</seealso>
    let has_usergroup = Prefixed_Name(sioc, "has_usergroup") |> PrefixedName
    /// <summary>
    ///   <para>sioc:last_activity_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time of the last activity associated with a SIOC concept instance, and expressed in ISO 8601 format. This could be due to a reply Post or Comment, a modification to an Item, etc.</para>
    /// labels<para>last activity date</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#last_activity_date">http://rdfs.org/sioc/ns#last_activity_date</seealso>
    let last_activity_date = Prefixed_Name(sioc, "last_activity_date") |> PrefixedName
    /// <summary>
    ///   <para>sioc:last_item_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time of the last Post (or Item) in a Forum (or a Container), in ISO 8601 format.</para>
    /// labels<para>last item date</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#last_item_date">http://rdfs.org/sioc/ns#last_item_date</seealso>
    let last_item_date = Prefixed_Name(sioc, "last_item_date") |> PrefixedName
    /// <summary>
    ///   <para>sioc:latest_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the latest revision of this Item or Post.</para>
    /// labels<para>latest version</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#latest_version">http://rdfs.org/sioc/ns#latest_version</seealso>
    let latest_version = Prefixed_Name(sioc, "latest_version") |> PrefixedName
    /// <summary>
    ///   <para>sioc:link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A URI of a document which contains this SIOC object.</para>
    /// labels<para>link</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#link">http://rdfs.org/sioc/ns#link</seealso>
    let link = Prefixed_Name(sioc, "link") |> PrefixedName
    /// <summary>
    ///   <para>sioc:links_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links extracted from hyperlinks within a SIOC concept, e.g. Post or Site.</para>
    /// labels<para>links to</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#links_to">http://rdfs.org/sioc/ns#links_to</seealso>
    let links_to = Prefixed_Name(sioc, "links_to") |> PrefixedName
    /// <summary>
    ///   <para>sioc:previous_by_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Previous Item or Post in a given Container sorted by date.</para>
    /// labels<para>previous by date</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#previous_by_date">http://rdfs.org/sioc/ns#previous_by_date</seealso>
    let previous_by_date = Prefixed_Name(sioc, "previous_by_date") |> PrefixedName
    /// <summary>
    ///   <para>sioc:next_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the next revision of this Item or Post.</para>
    /// labels<para>next version</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#next_version">http://rdfs.org/sioc/ns#next_version</seealso>
    let next_version = Prefixed_Name(sioc, "next_version") |> PrefixedName
    /// <summary>
    ///   <para>sioc:previous_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the previous revision of this Item or Post.</para>
    /// labels<para>previous version</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#previous_version">http://rdfs.org/sioc/ns#previous_version</seealso>
    let previous_version = Prefixed_Name(sioc, "previous_version") |> PrefixedName
    /// <summary>
    ///   <para>sioc:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A note associated with this resource, for example, if it has been edited by a UserAccount.</para>
    /// labels<para>note</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#note">http://rdfs.org/sioc/ns#note</seealso>
    let note = Prefixed_Name(sioc, "note") |> PrefixedName
    /// <summary>
    ///   <para>sioc:num_authors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of unique authors (UserAccounts and unregistered posters) who have contributed to this Item, Thread, Post, etc.</para>
    /// labels<para>num authors</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#num_authors">http://rdfs.org/sioc/ns#num_authors</seealso>
    let num_authors = Prefixed_Name(sioc, "num_authors") |> PrefixedName
    /// <summary>
    ///   <para>sioc:num_items</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of Posts (or Items) in a Forum (or a Container).</para>
    /// labels<para>num items</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#num_items">http://rdfs.org/sioc/ns#num_items</seealso>
    let num_items = Prefixed_Name(sioc, "num_items") |> PrefixedName
    /// <summary>
    ///   <para>sioc:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Links either created explicitly or extracted implicitly on the HTML level from the Post.</para>
    /// labels<para>reference</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#reference">http://rdfs.org/sioc/ns#reference</seealso>
    let reference = Prefixed_Name(sioc, "reference") |> PrefixedName
    /// <summary>
    ///   <para>sioc:sibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>An Item may have a sibling or a twin that exists in a different Container, but the siblings may differ in some small way (for example, language, category, etc.). The sibling of this Item should be self-describing (that is, it should contain all available information).</para>
    /// labels<para>sibling</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#sibling">http://rdfs.org/sioc/ns#sibling</seealso>
    let sibling = Prefixed_Name(sioc, "sibling") |> PrefixedName
    /// <summary>
    ///   <para>sioc:next_by_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Next Item or Post in a given Container sorted by date.</para>
    /// labels<para>next by date</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#next_by_date">http://rdfs.org/sioc/ns#next_by_date</seealso>
    let next_by_date = Prefixed_Name(sioc, "next_by_date") |> PrefixedName
    /// <summary>
    ///   <para>sioc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#">http://rdfs.org/sioc/ns#</seealso>
    let _prefix_iri = Prefixed_Name(sioc, "") |> PrefixedName
    /// <summary>
    ///   <para>sioc:UserAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A user account in an online community site.</para>
    /// labels<para>User Account</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#UserAccount">http://rdfs.org/sioc/ns#UserAccount</seealso>
    let UserAccount = Prefixed_Name(sioc, "UserAccount") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area in which content Items are contained.</para>
    /// labels<para>Container</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Container">http://rdfs.org/sioc/ns#Container</seealso>
    let Container = Prefixed_Name(sioc, "Container") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Forum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A discussion area on which Posts or entries are made.</para>
    /// labels<para>Forum</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Forum">http://rdfs.org/sioc/ns#Forum</seealso>
    let Forum = Prefixed_Name(sioc, "Forum") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Space is a place where data resides, e.g. on a website, desktop, fileshare, etc.</para>
    /// labels<para>Space</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Space">http://rdfs.org/sioc/ns#Space</seealso>
    let Space = Prefixed_Name(sioc, "Space") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Post</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An article or message that can be posted to a Forum.</para>
    /// labels<para>Post</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Post">http://rdfs.org/sioc/ns#Post</seealso>
    let Post = Prefixed_Name(sioc, "Post") |> PrefixedName
    /// <summary>
    ///   <para>sioc:Thread</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A container for a series of threaded discussion Posts or Items.</para>
    /// labels<para>Thread</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#Thread">http://rdfs.org/sioc/ns#Thread</seealso>
    let Thread = Prefixed_Name(sioc, "Thread") |> PrefixedName
    /// <summary>
    ///   <para>sioc:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>UserAccount is now preferred. This is a deprecated class for a User in an online community site.</para>
    /// labels<para>User</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#User">http://rdfs.org/sioc/ns#User</seealso>
    let User = Prefixed_Name(sioc, "User") |> PrefixedName
    /// <summary>
    ///   <para>sioc:about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies that this Item is about a particular resource, e.g. a Post describing a book, hotel, etc.</para>
    /// labels<para>about</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#about">http://rdfs.org/sioc/ns#about</seealso>
    let about = Prefixed_Name(sioc, "about") |> PrefixedName
    /// <summary>
    ///   <para>sioc:account_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to the foaf:Agent or foaf:Person who owns this sioc:UserAccount.</para>
    /// labels<para>account of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#account_of">http://rdfs.org/sioc/ns#account_of</seealso>
    let account_of = Prefixed_Name(sioc, "account_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:administrator_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Site that the UserAccount is an administrator of.</para>
    /// labels<para>administrator of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#administrator_of">http://rdfs.org/sioc/ns#administrator_of</seealso>
    let administrator_of = Prefixed_Name(sioc, "administrator_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:avatar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An image or depiction used to represent this UserAccount.</para>
    /// labels<para>avatar</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#avatar">http://rdfs.org/sioc/ns#avatar</seealso>
    let avatar = Prefixed_Name(sioc, "avatar") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Container to which this Item belongs.</para>
    /// labels<para>has container</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_container">http://rdfs.org/sioc/ns#has_container</seealso>
    let has_container = Prefixed_Name(sioc, "has_container") |> PrefixedName
    /// <summary>
    ///   <para>sioc:content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The content of the Item in plain text format.</para>
    /// labels<para>content</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#content">http://rdfs.org/sioc/ns#content</seealso>
    let content = Prefixed_Name(sioc, "content") |> PrefixedName
    /// <summary>
    ///   <para>sioc:created_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>When this was created, in ISO 8601 format.</para>
    /// labels<para>created at</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#created_at">http://rdfs.org/sioc/ns#created_at</seealso>
    let created_at = Prefixed_Name(sioc, "created_at") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the UserAccount that made this resource.</para>
    /// labels<para>has creator</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_creator">http://rdfs.org/sioc/ns#has_creator</seealso>
    let has_creator = Prefixed_Name(sioc, "has_creator") |> PrefixedName
    /// <summary>
    ///   <para>sioc:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The content of the Post.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#description">http://rdfs.org/sioc/ns#description</seealso>
    let description = Prefixed_Name(sioc, "description") |> PrefixedName
    /// <summary>
    ///   <para>sioc:earlier_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Links to a previous (older) revision of this Item or Post.</para>
    /// labels<para>earlier version</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#earlier_version">http://rdfs.org/sioc/ns#earlier_version</seealso>
    let earlier_version = Prefixed_Name(sioc, "earlier_version") |> PrefixedName
    /// <summary>
    ///   <para>sioc:feed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A feed (e.g. RSS, Atom, etc.) pertaining to this resource (e.g. for a Forum, Site, UserAccount, etc.).</para>
    /// labels<para>feed</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#feed">http://rdfs.org/sioc/ns#feed</seealso>
    let feed = Prefixed_Name(sioc, "feed") |> PrefixedName
    /// <summary>
    ///   <para>sioc:first_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>First (real) name of this User. Synonyms include given name or christian name.</para>
    /// labels<para>first name</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#first_name">http://rdfs.org/sioc/ns#first_name</seealso>
    let first_name = Prefixed_Name(sioc, "first_name") |> PrefixedName
    /// <summary>
    ///   <para>sioc:group_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>group of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#group_of">http://rdfs.org/sioc/ns#group_of</seealso>
    let group_of = Prefixed_Name(sioc, "group_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has group</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_group">http://rdfs.org/sioc/ns#has_group</seealso>
    let has_group = Prefixed_Name(sioc, "has_group") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_host</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Site that hosts this Forum.</para>
    /// labels<para>has host</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_host">http://rdfs.org/sioc/ns#has_host</seealso>
    let has_host = Prefixed_Name(sioc, "has_host") |> PrefixedName
    /// <summary>
    ///   <para>sioc:host_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Forum that is hosted on this Site.</para>
    /// labels<para>host of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#host_of">http://rdfs.org/sioc/ns#host_of</seealso>
    let host_of = Prefixed_Name(sioc, "host_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A UserAccount that is a member of this Usergroup.</para>
    /// labels<para>has member</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_member">http://rdfs.org/sioc/ns#has_member</seealso>
    let has_member = Prefixed_Name(sioc, "has_member") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A UserAccount that this resource is owned by.</para>
    /// labels<para>has owner</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_owner">http://rdfs.org/sioc/ns#has_owner</seealso>
    let has_owner = Prefixed_Name(sioc, "has_owner") |> PrefixedName
    /// <summary>
    ///   <para>sioc:owner_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource owned by a particular UserAccount, for example, a weblog or image gallery.</para>
    /// labels<para>owner of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#owner_of">http://rdfs.org/sioc/ns#owner_of</seealso>
    let owner_of = Prefixed_Name(sioc, "owner_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Container or Forum that this Container or Forum is a child of.</para>
    /// labels<para>has parent</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_parent">http://rdfs.org/sioc/ns#has_parent</seealso>
    let has_parent = Prefixed_Name(sioc, "has_parent") |> PrefixedName
    /// <summary>
    ///   <para>sioc:parent_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A child Container or Forum that this Container or Forum is a parent of.</para>
    /// labels<para>parent of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#parent_of">http://rdfs.org/sioc/ns#parent_of</seealso>
    let parent_of = Prefixed_Name(sioc, "parent_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Related Posts for this Post, perhaps determined implicitly from topics or references.</para>
    /// labels<para>related to</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#related_to">http://rdfs.org/sioc/ns#related_to</seealso>
    let related_to = Prefixed_Name(sioc, "related_to") |> PrefixedName
    /// <summary>
    ///   <para>sioc:reply_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to an Item or Post which this Item or Post is a reply to.</para>
    /// labels<para>reply of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#reply_of">http://rdfs.org/sioc/ns#reply_of</seealso>
    let reply_of = Prefixed_Name(sioc, "reply_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource that this Role applies to.</para>
    /// labels<para>has scope</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_scope">http://rdfs.org/sioc/ns#has_scope</seealso>
    let has_scope = Prefixed_Name(sioc, "has_scope") |> PrefixedName
    /// <summary>
    ///   <para>sioc:scope_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Role that has a scope of this resource.</para>
    /// labels<para>scope of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#scope_of">http://rdfs.org/sioc/ns#scope_of</seealso>
    let scope_of = Prefixed_Name(sioc, "scope_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:has_space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A data Space which this resource is a part of.</para>
    /// labels<para>has space</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#has_space">http://rdfs.org/sioc/ns#has_space</seealso>
    let has_space = Prefixed_Name(sioc, "has_space") |> PrefixedName
    /// <summary>
    ///   <para>sioc:usergroup_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Space that the Usergroup has access to.</para>
    /// labels<para>usergroup of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#usergroup_of">http://rdfs.org/sioc/ns#usergroup_of</seealso>
    let usergroup_of = Prefixed_Name(sioc, "usergroup_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An identifier of a SIOC concept instance. For example, a user ID. Must be unique for instances of each type of SIOC concept within the same site.</para>
    /// labels<para>id</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#id">http://rdfs.org/sioc/ns#id</seealso>
    let id = Prefixed_Name(sioc, "id") |> PrefixedName
    /// <summary>
    ///   <para>sioc:ip_address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The IP address used when creating this Item. This can be associated with a creator. Some wiki articles list the IP addresses for the creator or modifiers when the usernames are absent.</para>
    /// labels<para>ip address</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#ip_address">http://rdfs.org/sioc/ns#ip_address</seealso>
    let ip_address = Prefixed_Name(sioc, "ip_address") |> PrefixedName
    /// <summary>
    ///   <para>sioc:last_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Last (real) name of this user. Synonyms include surname or family name.</para>
    /// labels<para>last name</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#last_name">http://rdfs.org/sioc/ns#last_name</seealso>
    let last_name = Prefixed_Name(sioc, "last_name") |> PrefixedName
    /// <summary>
    ///   <para>sioc:last_reply_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date and time of the last reply Post or Comment, which could be associated with a starter Item or Post or with a Thread, and expressed in ISO 8601 format.</para>
    /// labels<para>last reply date</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#last_reply_date">http://rdfs.org/sioc/ns#last_reply_date</seealso>
    let last_reply_date = Prefixed_Name(sioc, "last_reply_date") |> PrefixedName
    /// <summary>
    ///   <para>sioc:moderator_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Forum that a UserAccount is a moderator of.</para>
    /// labels<para>moderator of</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#moderator_of">http://rdfs.org/sioc/ns#moderator_of</seealso>
    let moderator_of = Prefixed_Name(sioc, "moderator_of") |> PrefixedName
    /// <summary>
    ///   <para>sioc:modified_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>When this was modified, in ISO 8601 format.</para>
    /// labels<para>modified at</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#modified_at">http://rdfs.org/sioc/ns#modified_at</seealso>
    let modified_at = Prefixed_Name(sioc, "modified_at") |> PrefixedName
    /// <summary>
    ///   <para>sioc:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a SIOC concept instance, e.g. a username for a UserAccount, group name for a Usergroup, etc.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#name">http://rdfs.org/sioc/ns#name</seealso>
    let name = Prefixed_Name(sioc, "name") |> PrefixedName
    /// <summary>
    ///   <para>sioc:num_replies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of replies that this Item, Thread, Post, etc. has. Useful for when the reply structure is absent.</para>
    /// labels<para>num replies</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#num_replies">http://rdfs.org/sioc/ns#num_replies</seealso>
    let num_replies = Prefixed_Name(sioc, "num_replies") |> PrefixedName
    /// <summary>
    ///   <para>sioc:num_threads</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of Threads (AKA discussion topics) in a Forum.</para>
    /// labels<para>num threads</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#num_threads">http://rdfs.org/sioc/ns#num_threads</seealso>
    let num_threads = Prefixed_Name(sioc, "num_threads") |> PrefixedName
    /// <summary>
    ///   <para>sioc:num_views</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of times this Item, Thread, UserAccount profile, etc. has been viewed.</para>
    /// labels<para>num views</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#num_views">http://rdfs.org/sioc/ns#num_views</seealso>
    let num_views = Prefixed_Name(sioc, "num_views") |> PrefixedName
    /// <summary>
    ///   <para>sioc:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Keyword(s) describing subject of the Post.</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#subject">http://rdfs.org/sioc/ns#subject</seealso>
    let subject = Prefixed_Name(sioc, "subject") |> PrefixedName
    /// <summary>
    ///   <para>sioc:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>This is the title (subject line) of the Post. Note that for a Post within a threaded discussion that has no parents, it would detail the topic thread.</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#title">http://rdfs.org/sioc/ns#title</seealso>
    let title = Prefixed_Name(sioc, "title") |> PrefixedName
    /// <summary>
    ///   <para>sioc:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A topic of interest, linking to the appropriate URI, e.g. in the Open Directory Project or of a SKOS category.</para>
    /// labels<para>topic</para></remarks>
    /// <seealso href="http://rdfs.org/sioc/ns#topic">http://rdfs.org/sioc/ns#topic</seealso>
    let topic = Prefixed_Name(sioc, "topic") |> PrefixedName
