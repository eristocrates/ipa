namespace http.rdfs.org.sioc.ns.hash

open DoxAletheia

module sioc =
    let _namespace_name = "http://rdfs.org/sioc/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Community is a high-level concept that defines an online community and what it consists of.
    /// <see href="http://rdfs.org/sioc/ns#Community"></see></summary>
    let Community = _prefix "Community"
    /// <summary>
    /// A user account in an online community site.
    /// <see href="http://rdfs.org/sioc/ns#UserAccount"></see></summary>
    let UserAccount = _prefix "UserAccount"
    /// <summary>
    /// A Role is a function of a UserAccount within a scope of a particular Forum, Site, etc.
    /// <see href="http://rdfs.org/sioc/ns#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// An Item is something which can be in a Container.
    /// <see href="http://rdfs.org/sioc/ns#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// An area in which content Items are contained.
    /// <see href="http://rdfs.org/sioc/ns#Container"></see></summary>
    let Container = _prefix "Container"
    /// <summary>
    /// A set of UserAccounts whose owners have a common purpose or interest. Can be used for access control purposes.
    /// <see href="http://rdfs.org/sioc/ns#Usergroup"></see></summary>
    let Usergroup = _prefix "Usergroup"
    /// <summary>
    /// A discussion area on which Posts or entries are made.
    /// <see href="http://rdfs.org/sioc/ns#Forum"></see></summary>
    let Forum = _prefix "Forum"
    /// <summary>
    /// A Space is a place where data resides, e.g. on a website, desktop, fileshare, etc.
    /// <see href="http://rdfs.org/sioc/ns#Space"></see></summary>
    let Space = _prefix "Space"
    /// <summary>
    /// An article or message that can be posted to a Forum.
    /// <see href="http://rdfs.org/sioc/ns#Post"></see></summary>
    let Post = _prefix "Post"
    /// <summary>
    /// A Site can be the location of an online community or set of communities, with UserAccounts and Usergroups creating Items in a set of Containers. It can be thought of as a web-accessible data Space.
    /// <see href="http://rdfs.org/sioc/ns#Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    /// A container for a series of threaded discussion Posts or Items.
    /// <see href="http://rdfs.org/sioc/ns#Thread"></see></summary>
    let Thread = _prefix "Thread"
    /// <summary>
    /// UserAccount is now preferred. This is a deprecated class for a User in an online community site.
    /// <see href="http://rdfs.org/sioc/ns#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// Specifies that this Item is about a particular resource, e.g. a Post describing a book, hotel, etc.
    /// <see href="http://rdfs.org/sioc/ns#about"></see></summary>
    let about = _prefix "about"
    /// <summary>
    /// Refers to the foaf:Agent or foaf:Person who owns this sioc:UserAccount.
    /// <see href="http://rdfs.org/sioc/ns#account_of"></see></summary>
    let account_of = _prefix "account_of"
    /// <summary>
    /// Refers to who (e.g. a UserAccount, e-mail address, etc.) a particular Item is addressed to.
    /// <see href="http://rdfs.org/sioc/ns#addressed_to"></see></summary>
    let addressed_to = _prefix "addressed_to"
    /// <summary>
    /// A Site that the UserAccount is an administrator of.
    /// <see href="http://rdfs.org/sioc/ns#administrator_of"></see></summary>
    let administrator_of = _prefix "administrator_of"
    /// <summary>
    /// A UserAccount that is an administrator of this Site.
    /// <see href="http://rdfs.org/sioc/ns#has_administrator"></see></summary>
    let has_administrator = _prefix "has_administrator"
    /// <summary>
    /// The URI of a file attached to an Item.
    /// <see href="http://rdfs.org/sioc/ns#attachment"></see></summary>
    let attachment = _prefix "attachment"
    /// <summary>
    /// An image or depiction used to represent this UserAccount.
    /// <see href="http://rdfs.org/sioc/ns#avatar"></see></summary>
    let avatar = _prefix "avatar"
    /// <summary>
    /// An Item that this Container contains.
    /// <see href="http://rdfs.org/sioc/ns#container_of"></see></summary>
    let container_of = _prefix "container_of"
    /// <summary>
    /// The Container to which this Item belongs.
    /// <see href="http://rdfs.org/sioc/ns#has_container"></see></summary>
    let has_container = _prefix "has_container"
    /// <summary>
    /// The content of the Item in plain text format.
    /// <see href="http://rdfs.org/sioc/ns#content"></see></summary>
    let content = _prefix "content"
    /// <summary>
    /// The encoded content of the Post, contained in CDATA areas.
    /// <see href="http://rdfs.org/sioc/ns#content_encoded"></see></summary>
    let content_encoded = _prefix "content_encoded"
    /// <summary>
    /// When this was created, in ISO 8601 format.
    /// <see href="http://rdfs.org/sioc/ns#created_at"></see></summary>
    let created_at = _prefix "created_at"
    /// <summary>
    /// A resource that the UserAccount is a creator of.
    /// <see href="http://rdfs.org/sioc/ns#creator_of"></see></summary>
    let creator_of = _prefix "creator_of"
    /// <summary>
    /// This is the UserAccount that made this resource.
    /// <see href="http://rdfs.org/sioc/ns#has_creator"></see></summary>
    let has_creator = _prefix "has_creator"
    /// <summary>
    /// The content of the Post.
    /// <see href="http://rdfs.org/sioc/ns#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Links to a previous (older) revision of this Item or Post.
    /// <see href="http://rdfs.org/sioc/ns#earlier_version"></see></summary>
    let earlier_version = _prefix "earlier_version"
    /// <summary>
    /// Links to a later (newer) revision of this Item or Post.
    /// <see href="http://rdfs.org/sioc/ns#later_version"></see></summary>
    let later_version = _prefix "later_version"
    /// <summary>
    /// An electronic mail address of the UserAccount.
    /// <see href="http://rdfs.org/sioc/ns#email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// An electronic mail address of the UserAccount, encoded using SHA1.
    /// <see href="http://rdfs.org/sioc/ns#email_sha1"></see></summary>
    let email_sha1 = _prefix "email_sha1"
    /// <summary>
    /// This links Items to embedded statements, facts and structured content.
    /// <see href="http://rdfs.org/sioc/ns#embeds_knowledge"></see></summary>
    let embeds_knowledge = _prefix "embeds_knowledge"
    /// <summary>
    /// A feed (e.g. RSS, Atom, etc.) pertaining to this resource (e.g. for a Forum, Site, UserAccount, etc.).
    /// <see href="http://rdfs.org/sioc/ns#feed"></see></summary>
    let feed = _prefix "feed"
    /// <summary>
    /// First (real) name of this User. Synonyms include given name or christian name.
    /// <see href="http://rdfs.org/sioc/ns#first_name"></see></summary>
    let first_name = _prefix "first_name"
    /// <summary>
    /// Indicates that one UserAccount follows another UserAccount (e.g. for microblog posts or other content item updates).
    /// <see href="http://rdfs.org/sioc/ns#follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// A UserAccount that has this Role.
    /// <see href="http://rdfs.org/sioc/ns#function_of"></see></summary>
    let function_of = _prefix "function_of"
    /// <summary>
    /// A Role that this UserAccount has.
    /// <see href="http://rdfs.org/sioc/ns#has_function"></see></summary>
    let has_function = _prefix "has_function"
    /// <summary>
    ///   <see href="http://rdfs.org/sioc/ns#group_of"></see>
    /// </summary>
    let group_of = _prefix "group_of"
    /// <summary>
    ///   <see href="http://rdfs.org/sioc/ns#has_group"></see>
    /// </summary>
    let has_group = _prefix "has_group"
    /// <summary>
    /// The discussion that is related to this Item.
    /// <see href="http://rdfs.org/sioc/ns#has_discussion"></see></summary>
    let has_discussion = _prefix "has_discussion"
    /// <summary>
    /// The Site that hosts this Forum.
    /// <see href="http://rdfs.org/sioc/ns#has_host"></see></summary>
    let has_host = _prefix "has_host"
    /// <summary>
    /// A Forum that is hosted on this Site.
    /// <see href="http://rdfs.org/sioc/ns#host_of"></see></summary>
    let host_of = _prefix "host_of"
    /// <summary>
    /// A UserAccount that is a member of this Usergroup.
    /// <see href="http://rdfs.org/sioc/ns#has_member"></see></summary>
    let has_member = _prefix "has_member"
    /// <summary>
    /// A Usergroup that this UserAccount is a member of.
    /// <see href="http://rdfs.org/sioc/ns#member_of"></see></summary>
    let member_of = _prefix "member_of"
    /// <summary>
    /// A UserAccount that is a moderator of this Forum.
    /// <see href="http://rdfs.org/sioc/ns#has_moderator"></see></summary>
    let has_moderator = _prefix "has_moderator"
    /// <summary>
    /// A UserAccount that modified this Item.
    /// <see href="http://rdfs.org/sioc/ns#has_modifier"></see></summary>
    let has_modifier = _prefix "has_modifier"
    /// <summary>
    /// An Item that this UserAccount has modified.
    /// <see href="http://rdfs.org/sioc/ns#modifier_of"></see></summary>
    let modifier_of = _prefix "modifier_of"
    /// <summary>
    /// A UserAccount that this resource is owned by.
    /// <see href="http://rdfs.org/sioc/ns#has_owner"></see></summary>
    let has_owner = _prefix "has_owner"
    /// <summary>
    /// A resource owned by a particular UserAccount, for example, a weblog or image gallery.
    /// <see href="http://rdfs.org/sioc/ns#owner_of"></see></summary>
    let owner_of = _prefix "owner_of"
    /// <summary>
    /// A Container or Forum that this Container or Forum is a child of.
    /// <see href="http://rdfs.org/sioc/ns#has_parent"></see></summary>
    let has_parent = _prefix "has_parent"
    /// <summary>
    /// A child Container or Forum that this Container or Forum is a parent of.
    /// <see href="http://rdfs.org/sioc/ns#parent_of"></see></summary>
    let parent_of = _prefix "parent_of"
    /// <summary>
    /// An resource that is a part of this subject.
    /// <see href="http://rdfs.org/sioc/ns#has_part"></see></summary>
    let has_part = _prefix "has_part"
    /// <summary>
    /// A resource that the subject is a part of.
    /// <see href="http://rdfs.org/sioc/ns#part_of"></see></summary>
    let part_of = _prefix "part_of"
    /// <summary>
    /// Points to an Item or Post that is a reply or response to this Item or Post.
    /// <see href="http://rdfs.org/sioc/ns#has_reply"></see></summary>
    let has_reply = _prefix "has_reply"
    /// <summary>
    /// Related Posts for this Post, perhaps determined implicitly from topics or references.
    /// <see href="http://rdfs.org/sioc/ns#related_to"></see></summary>
    let related_to = _prefix "related_to"
    /// <summary>
    /// Links to an Item or Post which this Item or Post is a reply to.
    /// <see href="http://rdfs.org/sioc/ns#reply_of"></see></summary>
    let reply_of = _prefix "reply_of"
    /// <summary>
    /// A resource that this Role applies to.
    /// <see href="http://rdfs.org/sioc/ns#has_scope"></see></summary>
    let has_scope = _prefix "has_scope"
    /// <summary>
    /// A Role that has a scope of this resource.
    /// <see href="http://rdfs.org/sioc/ns#scope_of"></see></summary>
    let scope_of = _prefix "scope_of"
    /// <summary>
    /// A data Space which this resource is a part of.
    /// <see href="http://rdfs.org/sioc/ns#has_space"></see></summary>
    let has_space = _prefix "has_space"
    /// <summary>
    /// A resource which belongs to this data Space.
    /// <see href="http://rdfs.org/sioc/ns#space_of"></see></summary>
    let space_of = _prefix "space_of"
    /// <summary>
    /// A UserAccount that is subscribed to this Container.
    /// <see href="http://rdfs.org/sioc/ns#has_subscriber"></see></summary>
    let has_subscriber = _prefix "has_subscriber"
    /// <summary>
    /// A Container that a UserAccount is subscribed to.
    /// <see href="http://rdfs.org/sioc/ns#subscriber_of"></see></summary>
    let subscriber_of = _prefix "subscriber_of"
    /// <summary>
    /// Points to a Usergroup that has certain access to this Space.
    /// <see href="http://rdfs.org/sioc/ns#has_usergroup"></see></summary>
    let has_usergroup = _prefix "has_usergroup"
    /// <summary>
    /// A Space that the Usergroup has access to.
    /// <see href="http://rdfs.org/sioc/ns#usergroup_of"></see></summary>
    let usergroup_of = _prefix "usergroup_of"
    /// <summary>
    /// An identifier of a SIOC concept instance. For example, a user ID. Must be unique for instances of each type of SIOC concept within the same site.
    /// <see href="http://rdfs.org/sioc/ns#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// The IP address used when creating this Item. This can be associated with a creator. Some wiki articles list the IP addresses for the creator or modifiers when the usernames are absent.
    /// <see href="http://rdfs.org/sioc/ns#ip_address"></see></summary>
    let ip_address = _prefix "ip_address"
    /// <summary>
    /// The date and time of the last activity associated with a SIOC concept instance, and expressed in ISO 8601 format. This could be due to a reply Post or Comment, a modification to an Item, etc.
    /// <see href="http://rdfs.org/sioc/ns#last_activity_date"></see></summary>
    let last_activity_date = _prefix "last_activity_date"
    /// <summary>
    /// The date and time of the last Post (or Item) in a Forum (or a Container), in ISO 8601 format.
    /// <see href="http://rdfs.org/sioc/ns#last_item_date"></see></summary>
    let last_item_date = _prefix "last_item_date"
    /// <summary>
    /// Last (real) name of this user. Synonyms include surname or family name.
    /// <see href="http://rdfs.org/sioc/ns#last_name"></see></summary>
    let last_name = _prefix "last_name"
    /// <summary>
    /// The date and time of the last reply Post or Comment, which could be associated with a starter Item or Post or with a Thread, and expressed in ISO 8601 format.
    /// <see href="http://rdfs.org/sioc/ns#last_reply_date"></see></summary>
    let last_reply_date = _prefix "last_reply_date"
    /// <summary>
    /// Links to the latest revision of this Item or Post.
    /// <see href="http://rdfs.org/sioc/ns#latest_version"></see></summary>
    let latest_version = _prefix "latest_version"
    /// <summary>
    /// A URI of a document which contains this SIOC object.
    /// <see href="http://rdfs.org/sioc/ns#link"></see></summary>
    let link = _prefix "link"
    /// <summary>
    /// Links extracted from hyperlinks within a SIOC concept, e.g. Post or Site.
    /// <see href="http://rdfs.org/sioc/ns#links_to"></see></summary>
    let links_to = _prefix "links_to"
    /// <summary>
    /// A Forum that a UserAccount is a moderator of.
    /// <see href="http://rdfs.org/sioc/ns#moderator_of"></see></summary>
    let moderator_of = _prefix "moderator_of"
    /// <summary>
    /// When this was modified, in ISO 8601 format.
    /// <see href="http://rdfs.org/sioc/ns#modified_at"></see></summary>
    let modified_at = _prefix "modified_at"
    /// <summary>
    /// The name of a SIOC concept instance, e.g. a username for a UserAccount, group name for a Usergroup, etc.
    /// <see href="http://rdfs.org/sioc/ns#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Next Item or Post in a given Container sorted by date.
    /// <see href="http://rdfs.org/sioc/ns#next_by_date"></see></summary>
    let next_by_date = _prefix "next_by_date"
    /// <summary>
    /// Previous Item or Post in a given Container sorted by date.
    /// <see href="http://rdfs.org/sioc/ns#previous_by_date"></see></summary>
    let previous_by_date = _prefix "previous_by_date"
    /// <summary>
    /// Links to the next revision of this Item or Post.
    /// <see href="http://rdfs.org/sioc/ns#next_version"></see></summary>
    let next_version = _prefix "next_version"
    /// <summary>
    /// Links to the previous revision of this Item or Post.
    /// <see href="http://rdfs.org/sioc/ns#previous_version"></see></summary>
    let previous_version = _prefix "previous_version"
    /// <summary>
    /// A note associated with this resource, for example, if it has been edited by a UserAccount.
    /// <see href="http://rdfs.org/sioc/ns#note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// The number of unique authors (UserAccounts and unregistered posters) who have contributed to this Item, Thread, Post, etc.
    /// <see href="http://rdfs.org/sioc/ns#num_authors"></see></summary>
    let num_authors = _prefix "num_authors"
    /// <summary>
    /// The number of Posts (or Items) in a Forum (or a Container).
    /// <see href="http://rdfs.org/sioc/ns#num_items"></see></summary>
    let num_items = _prefix "num_items"
    /// <summary>
    /// The number of replies that this Item, Thread, Post, etc. has. Useful for when the reply structure is absent.
    /// <see href="http://rdfs.org/sioc/ns#num_replies"></see></summary>
    let num_replies = _prefix "num_replies"
    /// <summary>
    /// The number of Threads (AKA discussion topics) in a Forum.
    /// <see href="http://rdfs.org/sioc/ns#num_threads"></see></summary>
    let num_threads = _prefix "num_threads"
    /// <summary>
    /// The number of times this Item, Thread, UserAccount profile, etc. has been viewed.
    /// <see href="http://rdfs.org/sioc/ns#num_views"></see></summary>
    let num_views = _prefix "num_views"
    /// <summary>
    /// Links either created explicitly or extracted implicitly on the HTML level from the Post.
    /// <see href="http://rdfs.org/sioc/ns#reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    /// An Item may have a sibling or a twin that exists in a different Container, but the siblings may differ in some small way (for example, language, category, etc.). The sibling of this Item should be self-describing (that is, it should contain all available information).
    /// <see href="http://rdfs.org/sioc/ns#sibling"></see></summary>
    let sibling = _prefix "sibling"
    /// <summary>
    /// Keyword(s) describing subject of the Post.
    /// <see href="http://rdfs.org/sioc/ns#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// This is the title (subject line) of the Post. Note that for a Post within a threaded discussion that has no parents, it would detail the topic thread.
    /// <see href="http://rdfs.org/sioc/ns#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// A topic of interest, linking to the appropriate URI, e.g. in the Open Directory Project or of a SKOS category.
    /// <see href="http://rdfs.org/sioc/ns#topic"></see></summary>
    let topic = _prefix "topic"
