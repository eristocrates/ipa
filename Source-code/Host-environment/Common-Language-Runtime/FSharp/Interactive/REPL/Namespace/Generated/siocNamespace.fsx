#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sioc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdfs.org/sioc/ns#" "sioc"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Community is a high-level concept that defines an online community and what it consists of.</para>
    ///   <para>rdfs:label : Community</para>
    ///   <a href="http://rdfs.org/sioc/ns#Community">sioc:Community</a>
    /// </summary>
    let Community = _prefixId.prefix "Community"
    /// <summary>
    ///   <para>rdfs:comment : An area in which content Items are contained.</para>
    ///   <para>rdfs:label : Container</para>
    ///   <a href="http://rdfs.org/sioc/ns#Container">sioc:Container</a>
    /// </summary>
    let Container = _prefixId.prefix "Container"
    /// <summary>
    ///   <para>rdfs:comment : A discussion area on which Posts or entries are made.</para>
    ///   <para>rdfs:label : Forum</para>
    ///   <a href="http://rdfs.org/sioc/ns#Forum">sioc:Forum</a>
    /// </summary>
    let Forum = _prefixId.prefix "Forum"
    /// <summary>
    ///   <para>rdfs:comment : An Item is something which can be in a Container.</para>
    ///   <para>rdfs:label : Item</para>
    ///   <a href="http://rdfs.org/sioc/ns#Item">sioc:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:comment : An article or message that can be posted to a Forum.</para>
    ///   <para>rdfs:label : Post</para>
    ///   <a href="http://rdfs.org/sioc/ns#Post">sioc:Post</a>
    /// </summary>
    let Post = _prefixId.prefix "Post"
    /// <summary>
    ///   <para>rdfs:comment : A Role is a function of a UserAccount within a scope of a particular Forum, Site, etc.</para>
    ///   <para>rdfs:label : Role</para>
    ///   <a href="http://rdfs.org/sioc/ns#Role">sioc:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:comment : A Site can be the location of an online community or set of communities, with UserAccounts and Usergroups creating Items in a set of Containers. It can be thought of as a web-accessible data Space.</para>
    ///   <para>rdfs:label : Site</para>
    ///   <a href="http://rdfs.org/sioc/ns#Site">sioc:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:comment : A Space is a place where data resides, e.g. on a website, desktop, fileshare, etc.</para>
    ///   <para>rdfs:label : Space</para>
    ///   <a href="http://rdfs.org/sioc/ns#Space">sioc:Space</a>
    /// </summary>
    let Space = _prefixId.prefix "Space"
    /// <summary>
    ///   <para>rdfs:comment : A container for a series of threaded discussion Posts or Items.</para>
    ///   <para>rdfs:label : Thread</para>
    ///   <a href="http://rdfs.org/sioc/ns#Thread">sioc:Thread</a>
    /// </summary>
    let Thread = _prefixId.prefix "Thread"
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:comment : A user account in an online community site.</para>
    ///   <para>rdfs:label : User Account</para>
    ///   <a href="http://rdfs.org/sioc/ns#UserAccount">sioc:UserAccount</a>
    /// </summary>
    let UserAccount = _prefixId.prefix "UserAccount"
    /// <summary>
    ///   <para>rdfs:comment : A set of UserAccounts whose owners have a common purpose or interest. Can be used for access control purposes.</para>
    ///   <para>rdfs:label : Usergroup</para>
    ///   <a href="http://rdfs.org/sioc/ns#Usergroup">sioc:Usergroup</a>
    /// </summary>
    let Usergroup = _prefixId.prefix "Usergroup"
    /// <summary>
    ///   <para>rdfs:comment : Specifies that this Item is about a particular resource, e.g. a Post describing a book, hotel, etc.</para>
    ///   <para>rdfs:label : about</para>
    ///   <a href="http://rdfs.org/sioc/ns#about">sioc:about</a>
    /// </summary>
    let about = _prefixId.prefix "about"
    /// <summary>
    ///   <para>rdfs:comment : Refers to the foaf:Agent or foaf:Person who owns this sioc:UserAccount.</para>
    ///   <para>rdfs:label : account of</para>
    ///   <a href="http://rdfs.org/sioc/ns#account_of">sioc:account_of</a>
    /// </summary>
    let account_of = _prefixId.prefix "account_of"
    /// <summary>
    ///   <para>rdfs:comment : Refers to who (e.g. a UserAccount, e-mail address, etc.) a particular Item is addressed to.</para>
    ///   <para>rdfs:label : addressed to</para>
    ///   <a href="http://rdfs.org/sioc/ns#addressed_to">sioc:addressed_to</a>
    /// </summary>
    let addressed_to = _prefixId.prefix "addressed_to"
    /// <summary>
    ///   <para>rdfs:comment : A Site that the UserAccount is an administrator of.</para>
    ///   <para>rdfs:label : administrator of</para>
    ///   <a href="http://rdfs.org/sioc/ns#administrator_of">sioc:administrator_of</a>
    /// </summary>
    let administrator_of = _prefixId.prefix "administrator_of"
    /// <summary>
    ///   <para>rdfs:comment : The URI of a file attached to an Item.</para>
    ///   <para>rdfs:label : attachment</para>
    ///   <a href="http://rdfs.org/sioc/ns#attachment">sioc:attachment</a>
    /// </summary>
    let attachment = _prefixId.prefix "attachment"
    /// <summary>
    ///   <para>rdfs:comment : An image or depiction used to represent this UserAccount.</para>
    ///   <para>rdfs:label : avatar</para>
    ///   <a href="http://rdfs.org/sioc/ns#avatar">sioc:avatar</a>
    /// </summary>
    let avatar = _prefixId.prefix "avatar"
    /// <summary>
    ///   <para>rdfs:comment : An Item that this Container contains.</para>
    ///   <para>rdfs:label : container of</para>
    ///   <a href="http://rdfs.org/sioc/ns#container_of">sioc:container_of</a>
    /// </summary>
    let container_of = _prefixId.prefix "container_of"
    /// <summary>
    ///   <para>rdfs:comment : The content of the Item in plain text format.</para>
    ///   <para>rdfs:label : content</para>
    ///   <a href="http://rdfs.org/sioc/ns#content">sioc:content</a>
    /// </summary>
    let content = _prefixId.prefix "content"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use content:encoded from the RSS 1.0 content module instead.^^xsd:string</para>
    ///   <para>rdfs:comment : The encoded content of the Post, contained in CDATA areas.</para>
    ///   <para>rdfs:label : content encoded</para>
    ///   <a href="http://rdfs.org/sioc/ns#content_encoded">sioc:content_encoded</a>
    /// </summary>
    let content_encoded = _prefixId.prefix "content_encoded"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use dcterms:created from the Dublin Core ontology instead.^^xsd:string</para>
    ///   <para>rdfs:comment : When this was created, in ISO 8601 format.</para>
    ///   <para>rdfs:label : created at</para>
    ///   <a href="http://rdfs.org/sioc/ns#created_at">sioc:created_at</a>
    /// </summary>
    let created_at = _prefixId.prefix "created_at"
    /// <summary>
    ///   <para>rdfs:comment : A resource that the UserAccount is a creator of.</para>
    ///   <para>rdfs:label : creator of</para>
    ///   <a href="http://rdfs.org/sioc/ns#creator_of">sioc:creator_of</a>
    /// </summary>
    let creator_of = _prefixId.prefix "creator_of"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use sioc:content or other methods (AtomOwl, content:encoded from RSS 1.0, etc.) instead.^^xsd:string</para>
    ///   <para>rdfs:comment : The content of the Post.</para>
    ///   <para>rdfs:label : description</para>
    ///   <a href="http://rdfs.org/sioc/ns#description">sioc:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    let earlier_version = _prefixId.prefix "earlier_version"
    /// <summary>
    ///   <para>rdfs:comment : An electronic mail address of the UserAccount.</para>
    ///   <para>rdfs:label : email</para>
    ///   <a href="http://rdfs.org/sioc/ns#email">sioc:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:comment : An electronic mail address of the UserAccount, encoded using SHA1.</para>
    ///   <para>rdfs:label : email sha1</para>
    ///   <a href="http://rdfs.org/sioc/ns#email_sha1">sioc:email_sha1</a>
    /// </summary>
    let email_sha1 = _prefixId.prefix "email_sha1"
    /// <summary>
    ///   <para>rdfs:comment : This links Items to embedded statements, facts and structured content.</para>
    ///   <para>rdfs:label : embeds knowledge</para>
    ///   <a href="http://rdfs.org/sioc/ns#embeds_knowledge">sioc:embeds_knowledge</a>
    /// </summary>
    let embeds_knowledge = _prefixId.prefix "embeds_knowledge"
    /// <summary>
    ///   <para>rdfs:comment : A feed (e.g. RSS, Atom, etc.) pertaining to this resource (e.g. for a Forum, Site, UserAccount, etc.).</para>
    ///   <para>rdfs:label : feed</para>
    ///   <a href="http://rdfs.org/sioc/ns#feed">sioc:feed</a>
    /// </summary>
    let feed = _prefixId.prefix "feed"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use foaf:name or foaf:firstName from the FOAF vocabulary instead.^^xsd:string</para>
    ///   <para>rdfs:comment : First (real) name of this User. Synonyms include given name or christian name.</para>
    ///   <para>rdfs:label : first name</para>
    ///   <a href="http://rdfs.org/sioc/ns#first_name">sioc:first_name</a>
    /// </summary>
    let first_name = _prefixId.prefix "first_name"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that one UserAccount follows another UserAccount (e.g. for microblog posts or other content item updates).</para>
    ///   <para>rdfs:label : follows</para>
    ///   <a href="http://rdfs.org/sioc/ns#follows">sioc:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:comment : A UserAccount that has this Role.</para>
    ///   <para>rdfs:label : function of</para>
    ///   <a href="http://rdfs.org/sioc/ns#function_of">sioc:function_of</a>
    /// </summary>
    let function_of = _prefixId.prefix "function_of"
    /// <summary>
    ///   <para>owl:versionInfo : This property has been renamed. Use sioc:usergroup_of instead.^^xsd:string</para>
    ///   <para>rdfs:label : group of</para>
    ///   <a href="http://rdfs.org/sioc/ns#group_of">sioc:group_of</a>
    /// </summary>
    let group_of = _prefixId.prefix "group_of"
    /// <summary>
    ///   <para>rdfs:comment : A UserAccount that is an administrator of this Site.</para>
    ///   <para>rdfs:label : has administrator</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_administrator">sioc:has_administrator</a>
    /// </summary>
    let has_administrator = _prefixId.prefix "has_administrator"
    /// <summary>
    ///   <para>rdfs:comment : The Container to which this Item belongs.</para>
    ///   <para>rdfs:label : has container</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_container">sioc:has_container</a>
    /// </summary>
    let has_container = _prefixId.prefix "has_container"
    /// <summary>
    ///   <para>rdfs:comment : This is the UserAccount that made this resource.</para>
    ///   <para>rdfs:label : has creator</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_creator">sioc:has_creator</a>
    /// </summary>
    let has_creator = _prefixId.prefix "has_creator"
    /// <summary>
    ///   <para>rdfs:label : has discussion</para>
    ///   <para>rdfs:comment : The discussion that is related to this Item.</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_discussion">sioc:has_discussion</a>
    /// </summary>
    let has_discussion = _prefixId.prefix "has_discussion"
    /// <summary>
    ///   <para>rdfs:comment : A Role that this UserAccount has.</para>
    ///   <para>rdfs:label : has function</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_function">sioc:has_function</a>
    /// </summary>
    let has_function = _prefixId.prefix "has_function"
    /// <summary>
    ///   <para>owl:versionInfo : This property has been renamed. Use sioc:has_usergroup instead.^^xsd:string</para>
    ///   <para>rdfs:label : has group</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_group">sioc:has_group</a>
    /// </summary>
    let has_group = _prefixId.prefix "has_group"
    /// <summary>
    ///   <para>rdfs:comment : The Site that hosts this Forum.</para>
    ///   <para>rdfs:label : has host</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_host">sioc:has_host</a>
    /// </summary>
    let has_host = _prefixId.prefix "has_host"
    /// <summary>
    ///   <para>rdfs:comment : A UserAccount that is a member of this Usergroup.</para>
    ///   <para>rdfs:label : has member</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_member">sioc:has_member</a>
    /// </summary>
    let has_member = _prefixId.prefix "has_member"
    /// <summary>
    ///   <para>rdfs:comment : A UserAccount that is a moderator of this Forum.</para>
    ///   <para>rdfs:label : has moderator</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_moderator">sioc:has_moderator</a>
    /// </summary>
    let has_moderator = _prefixId.prefix "has_moderator"
    /// <summary>
    ///   <para>rdfs:comment : A UserAccount that modified this Item.</para>
    ///   <para>rdfs:label : has modifier</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_modifier">sioc:has_modifier</a>
    /// </summary>
    let has_modifier = _prefixId.prefix "has_modifier"
    /// <summary>
    ///   <para>rdfs:comment : A UserAccount that this resource is owned by.</para>
    ///   <para>rdfs:label : has owner</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_owner">sioc:has_owner</a>
    /// </summary>
    let has_owner = _prefixId.prefix "has_owner"
    /// <summary>
    ///   <para>rdfs:comment : A Container or Forum that this Container or Forum is a child of.</para>
    ///   <para>rdfs:label : has parent</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_parent">sioc:has_parent</a>
    /// </summary>
    let has_parent = _prefixId.prefix "has_parent"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use dcterms:hasPart from the Dublin Core ontology instead.^^xsd:string</para>
    ///   <para>rdfs:comment : An resource that is a part of this subject.</para>
    ///   <para>rdfs:label : has part</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_part">sioc:has_part</a>
    /// </summary>
    let has_part = _prefixId.prefix "has_part"
    /// <summary>
    ///   <para>rdfs:comment : Points to an Item or Post that is a reply or response to this Item or Post.</para>
    ///   <para>rdfs:label : has reply</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_reply">sioc:has_reply</a>
    /// </summary>
    let has_reply = _prefixId.prefix "has_reply"
    /// <summary>
    ///   <para>rdfs:comment : A resource that this Role applies to.</para>
    ///   <para>rdfs:label : has scope</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_scope">sioc:has_scope</a>
    /// </summary>
    let has_scope = _prefixId.prefix "has_scope"
    /// <summary>
    ///   <para>rdfs:comment : A data Space which this resource is a part of.</para>
    ///   <para>rdfs:label : has space</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_space">sioc:has_space</a>
    /// </summary>
    let has_space = _prefixId.prefix "has_space"
    /// <summary>
    ///   <para>rdfs:comment : A UserAccount that is subscribed to this Container.</para>
    ///   <para>rdfs:label : has subscriber</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_subscriber">sioc:has_subscriber</a>
    /// </summary>
    let has_subscriber = _prefixId.prefix "has_subscriber"
    /// <summary>
    ///   <para>rdfs:comment : Points to a Usergroup that has certain access to this Space.</para>
    ///   <para>rdfs:label : has usergroup</para>
    ///   <a href="http://rdfs.org/sioc/ns#has_usergroup">sioc:has_usergroup</a>
    /// </summary>
    let has_usergroup = _prefixId.prefix "has_usergroup"
    /// <summary>
    ///   <para>rdfs:comment : A Forum that is hosted on this Site.</para>
    ///   <para>rdfs:label : host of</para>
    ///   <a href="http://rdfs.org/sioc/ns#host_of">sioc:host_of</a>
    /// </summary>
    let host_of = _prefixId.prefix "host_of"
    /// <summary>
    ///   <para>rdfs:comment : An identifier of a SIOC concept instance. For example, a user ID. Must be unique for instances of each type of SIOC concept within the same site.</para>
    ///   <para>rdfs:label : id</para>
    ///   <a href="http://rdfs.org/sioc/ns#id">sioc:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:comment : The IP address used when creating this Item. This can be associated with a creator. Some wiki articles list the IP addresses for the creator or modifiers when the usernames are absent.</para>
    ///   <para>rdfs:label : ip address</para>
    ///   <a href="http://rdfs.org/sioc/ns#ip_address">sioc:ip_address</a>
    /// </summary>
    let ip_address = _prefixId.prefix "ip_address"
    /// <summary>
    ///   <para>rdfs:comment : The date and time of the last activity associated with a SIOC concept instance, and expressed in ISO 8601 format. This could be due to a reply Post or Comment, a modification to an Item, etc.</para>
    ///   <para>rdfs:label : last activity date</para>
    ///   <a href="http://rdfs.org/sioc/ns#last_activity_date">sioc:last_activity_date</a>
    /// </summary>
    let last_activity_date = _prefixId.prefix "last_activity_date"
    /// <summary>
    ///   <para>rdfs:comment : The date and time of the last Post (or Item) in a Forum (or a Container), in ISO 8601 format.</para>
    ///   <para>rdfs:label : last item date</para>
    ///   <a href="http://rdfs.org/sioc/ns#last_item_date">sioc:last_item_date</a>
    /// </summary>
    let last_item_date = _prefixId.prefix "last_item_date"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use foaf:name or foaf:surname from the FOAF vocabulary instead.^^xsd:string</para>
    ///   <para>rdfs:comment : Last (real) name of this user. Synonyms include surname or family name.</para>
    ///   <para>rdfs:label : last name</para>
    ///   <a href="http://rdfs.org/sioc/ns#last_name">sioc:last_name</a>
    /// </summary>
    let last_name = _prefixId.prefix "last_name"
    /// <summary>
    ///   <para>rdfs:comment : The date and time of the last reply Post or Comment, which could be associated with a starter Item or Post or with a Thread, and expressed in ISO 8601 format.</para>
    ///   <para>rdfs:label : last reply date</para>
    ///   <a href="http://rdfs.org/sioc/ns#last_reply_date">sioc:last_reply_date</a>
    /// </summary>
    let last_reply_date = _prefixId.prefix "last_reply_date"
    let later_version = _prefixId.prefix "later_version"
    /// <summary>
    ///   <para>rdfs:label : latest version</para>
    ///   <para>rdfs:comment : Links to the latest revision of this Item or Post.</para>
    ///   <a href="http://rdfs.org/sioc/ns#latest_version">sioc:latest_version</a>
    /// </summary>
    let latest_version = _prefixId.prefix "latest_version"
    /// <summary>
    ///   <para>rdfs:comment : A URI of a document which contains this SIOC object.</para>
    ///   <para>rdfs:label : link</para>
    ///   <a href="http://rdfs.org/sioc/ns#link">sioc:link</a>
    /// </summary>
    let link = _prefixId.prefix "link"
    /// <summary>
    ///   <para>rdfs:comment : Links extracted from hyperlinks within a SIOC concept, e.g. Post or Site.</para>
    ///   <para>rdfs:label : links to</para>
    ///   <a href="http://rdfs.org/sioc/ns#links_to">sioc:links_to</a>
    /// </summary>
    let links_to = _prefixId.prefix "links_to"
    /// <summary>
    ///   <para>rdfs:comment : A Usergroup that this UserAccount is a member of.</para>
    ///   <para>rdfs:label : member of</para>
    ///   <a href="http://rdfs.org/sioc/ns#member_of">sioc:member_of</a>
    /// </summary>
    let member_of = _prefixId.prefix "member_of"
    /// <summary>
    ///   <para>rdfs:comment : A Forum that a UserAccount is a moderator of.</para>
    ///   <para>rdfs:label : moderator of</para>
    ///   <a href="http://rdfs.org/sioc/ns#moderator_of">sioc:moderator_of</a>
    /// </summary>
    let moderator_of = _prefixId.prefix "moderator_of"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use dcterms:modified from the Dublin Core ontology instead.^^xsd:string</para>
    ///   <para>rdfs:comment : When this was modified, in ISO 8601 format.</para>
    ///   <para>rdfs:label : modified at</para>
    ///   <a href="http://rdfs.org/sioc/ns#modified_at">sioc:modified_at</a>
    /// </summary>
    let modified_at = _prefixId.prefix "modified_at"
    /// <summary>
    ///   <para>rdfs:comment : An Item that this UserAccount has modified.</para>
    ///   <para>rdfs:label : modifier of</para>
    ///   <a href="http://rdfs.org/sioc/ns#modifier_of">sioc:modifier_of</a>
    /// </summary>
    let modifier_of = _prefixId.prefix "modifier_of"
    /// <summary>
    ///   <para>rdfs:comment : The name of a SIOC concept instance, e.g. a username for a UserAccount, group name for a Usergroup, etc.</para>
    ///   <para>rdfs:label : name</para>
    ///   <a href="http://rdfs.org/sioc/ns#name">sioc:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : Next Item or Post in a given Container sorted by date.</para>
    ///   <para>rdfs:label : next by date</para>
    ///   <a href="http://rdfs.org/sioc/ns#next_by_date">sioc:next_by_date</a>
    /// </summary>
    let next_by_date = _prefixId.prefix "next_by_date"
    /// <summary>
    ///   <para>rdfs:comment : Links to the next revision of this Item or Post.</para>
    ///   <para>rdfs:label : next version</para>
    ///   <a href="http://rdfs.org/sioc/ns#next_version">sioc:next_version</a>
    /// </summary>
    let next_version = _prefixId.prefix "next_version"
    /// <summary>
    ///   <para>rdfs:comment : A note associated with this resource, for example, if it has been edited by a UserAccount.</para>
    ///   <para>rdfs:label : note</para>
    ///   <a href="http://rdfs.org/sioc/ns#note">sioc:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:comment : The number of unique authors (UserAccounts and unregistered posters) who have contributed to this Item, Thread, Post, etc.</para>
    ///   <para>rdfs:label : num authors</para>
    ///   <a href="http://rdfs.org/sioc/ns#num_authors">sioc:num_authors</a>
    /// </summary>
    let num_authors = _prefixId.prefix "num_authors"
    /// <summary>
    ///   <para>rdfs:comment : The number of Posts (or Items) in a Forum (or a Container).</para>
    ///   <para>rdfs:label : num items</para>
    ///   <a href="http://rdfs.org/sioc/ns#num_items">sioc:num_items</a>
    /// </summary>
    let num_items = _prefixId.prefix "num_items"
    /// <summary>
    ///   <para>rdfs:comment : The number of replies that this Item, Thread, Post, etc. has. Useful for when the reply structure is absent.</para>
    ///   <para>rdfs:label : num replies</para>
    ///   <a href="http://rdfs.org/sioc/ns#num_replies">sioc:num_replies</a>
    /// </summary>
    let num_replies = _prefixId.prefix "num_replies"
    /// <summary>
    ///   <para>rdfs:comment : The number of Threads (AKA discussion topics) in a Forum.</para>
    ///   <para>rdfs:label : num threads</para>
    ///   <a href="http://rdfs.org/sioc/ns#num_threads">sioc:num_threads</a>
    /// </summary>
    let num_threads = _prefixId.prefix "num_threads"
    /// <summary>
    ///   <para>rdfs:comment : The number of times this Item, Thread, UserAccount profile, etc. has been viewed.</para>
    ///   <para>rdfs:label : num views</para>
    ///   <a href="http://rdfs.org/sioc/ns#num_views">sioc:num_views</a>
    /// </summary>
    let num_views = _prefixId.prefix "num_views"
    /// <summary>
    ///   <para>rdfs:comment : A resource owned by a particular UserAccount, for example, a weblog or image gallery.</para>
    ///   <para>rdfs:label : owner of</para>
    ///   <a href="http://rdfs.org/sioc/ns#owner_of">sioc:owner_of</a>
    /// </summary>
    let owner_of = _prefixId.prefix "owner_of"
    /// <summary>
    ///   <para>rdfs:comment : A child Container or Forum that this Container or Forum is a parent of.</para>
    ///   <para>rdfs:label : parent of</para>
    ///   <a href="http://rdfs.org/sioc/ns#parent_of">sioc:parent_of</a>
    /// </summary>
    let parent_of = _prefixId.prefix "parent_of"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use dcterms:isPartOf from the Dublin Core ontology instead.^^xsd:string</para>
    ///   <para>rdfs:comment : A resource that the subject is a part of.</para>
    ///   <para>rdfs:label : part of</para>
    ///   <a href="http://rdfs.org/sioc/ns#part_of">sioc:part_of</a>
    /// </summary>
    let part_of = _prefixId.prefix "part_of"
    /// <summary>
    ///   <para>rdfs:comment : Previous Item or Post in a given Container sorted by date.</para>
    ///   <para>rdfs:label : previous by date</para>
    ///   <a href="http://rdfs.org/sioc/ns#previous_by_date">sioc:previous_by_date</a>
    /// </summary>
    let previous_by_date = _prefixId.prefix "previous_by_date"
    /// <summary>
    ///   <para>rdfs:comment : Links to the previous revision of this Item or Post.</para>
    ///   <para>rdfs:label : previous version</para>
    ///   <a href="http://rdfs.org/sioc/ns#previous_version">sioc:previous_version</a>
    /// </summary>
    let previous_version = _prefixId.prefix "previous_version"
    /// <summary>
    ///   <para>owl:versionInfo : Renamed to sioc:links_to.^^xsd:string</para>
    ///   <para>rdfs:comment : Links either created explicitly or extracted implicitly on the HTML level from the Post.</para>
    ///   <para>rdfs:label : reference</para>
    ///   <a href="http://rdfs.org/sioc/ns#reference">sioc:reference</a>
    /// </summary>
    let reference = _prefixId.prefix "reference"
    /// <summary>
    ///   <para>rdfs:comment : Related Posts for this Post, perhaps determined implicitly from topics or references.</para>
    ///   <para>rdfs:label : related to</para>
    ///   <a href="http://rdfs.org/sioc/ns#related_to">sioc:related_to</a>
    /// </summary>
    let related_to = _prefixId.prefix "related_to"
    /// <summary>
    ///   <para>rdfs:comment : Links to an Item or Post which this Item or Post is a reply to.</para>
    ///   <para>rdfs:label : reply of</para>
    ///   <a href="http://rdfs.org/sioc/ns#reply_of">sioc:reply_of</a>
    /// </summary>
    let reply_of = _prefixId.prefix "reply_of"
    /// <summary>
    ///   <para>rdfs:comment : A Role that has a scope of this resource.</para>
    ///   <para>rdfs:label : scope of</para>
    ///   <a href="http://rdfs.org/sioc/ns#scope_of">sioc:scope_of</a>
    /// </summary>
    let scope_of = _prefixId.prefix "scope_of"
    let sibling = _prefixId.prefix "sibling"
    /// <summary>
    ///   <para>rdfs:comment : A resource which belongs to this data Space.</para>
    ///   <para>rdfs:label : space of</para>
    ///   <a href="http://rdfs.org/sioc/ns#space_of">sioc:space_of</a>
    /// </summary>
    let space_of = _prefixId.prefix "space_of"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use dcterms:subject from the Dublin Core ontology for text keywords and sioc:topic if the subject can be represented by a URI instead.^^xsd:string</para>
    ///   <para>rdfs:comment : Keyword(s) describing subject of the Post.</para>
    ///   <para>rdfs:label : subject</para>
    ///   <a href="http://rdfs.org/sioc/ns#subject">sioc:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:comment : A Container that a UserAccount is subscribed to.</para>
    ///   <para>rdfs:label : subscriber of</para>
    ///   <a href="http://rdfs.org/sioc/ns#subscriber_of">sioc:subscriber_of</a>
    /// </summary>
    let subscriber_of = _prefixId.prefix "subscriber_of"
    /// <summary>
    ///   <para>owl:versionInfo : This property is deprecated. Use dcterms:title from the Dublin Core ontology instead.^^xsd:string</para>
    ///   <para>rdfs:comment : This is the title (subject line) of the Post. Note that for a Post within a threaded discussion that has no parents, it would detail the topic thread.</para>
    ///   <para>rdfs:label : title</para>
    ///   <a href="http://rdfs.org/sioc/ns#title">sioc:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : A topic of interest, linking to the appropriate URI, e.g. in the Open Directory Project or of a SKOS category.</para>
    ///   <para>rdfs:label : topic</para>
    ///   <a href="http://rdfs.org/sioc/ns#topic">sioc:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
    /// <summary>
    ///   <para>rdfs:comment : A Space that the Usergroup has access to.</para>
    ///   <para>rdfs:label : usergroup of</para>
    ///   <a href="http://rdfs.org/sioc/ns#usergroup_of">sioc:usergroup_of</a>
    /// </summary>
    let usergroup_of = _prefixId.prefix "usergroup_of"
