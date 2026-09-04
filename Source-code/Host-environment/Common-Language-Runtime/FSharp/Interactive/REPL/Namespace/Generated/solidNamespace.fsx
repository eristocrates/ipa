#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module solid =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/ns/solid/terms#" "solid"

    /// <summary>
    ///   <para>rdfs:label : Account</para>
    ///   <para>rdfs:comment : A Solid account.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#Account">solid:Account</a>
    /// </summary>
    let Account = _prefixId.prefix "Account"
    /// <summary>
    ///   <para>rdfs:label : Inbox</para>
    ///   <para>rdfs:comment : A resource containing notifications.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#Inbox">solid:Inbox</a>
    /// </summary>
    let Inbox = _prefixId.prefix "Inbox"
    /// <summary>
    ///   <para>rdfs:label : Listed Type Index</para>
    ///   <para>rdfs:comment : Listed Type Index is a registry of resources that are publicly discoverable by outside users and applications.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#ListedDocument">solid:ListedDocument</a>
    /// </summary>
    let ListedDocument = _prefixId.prefix "ListedDocument"
    /// <summary>
    ///   <para>rdfs:label : Notification</para>
    ///   <para>rdfs:comment : A notification resource.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#Notification">solid:Notification</a>
    /// </summary>
    let Notification = _prefixId.prefix "Notification"
    /// <summary>
    ///   <para>rdfs:label : Patch</para>
    ///   <para>rdfs:comment : A patch expresses conditional modifications to a resource that has an RDF-based representation.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#Patch">solid:Patch</a>
    /// </summary>
    let Patch = _prefixId.prefix "Patch"
    /// <summary>
    ///   <para>rdfs:label : Timeline</para>
    ///   <para>rdfs:comment : A resource containing time ordered items and sub-containers.  Sub-containers may be desirable in file based systems to split the timeline into logical components e.g. /yyyy-mm-dd/ as used in ISO 8061.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#Timeline">solid:Timeline</a>
    /// </summary>
    let Timeline = _prefixId.prefix "Timeline"
    /// <summary>
    ///   <para>rdfs:label : Type index</para>
    ///   <para>rdfs:comment : A index of type registries for resources. Applications can register the RDF type they use and list them in the index resource.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#TypeIndex">solid:TypeIndex</a>
    /// </summary>
    let TypeIndex = _prefixId.prefix "TypeIndex"
    /// <summary>
    ///   <para>rdfs:label : Type Registration</para>
    ///   <para>rdfs:comment : The registered types that map a RDF classes/types to their locations using either `instance` or `instanceContainer` property.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#TypeRegistration">solid:TypeRegistration</a>
    /// </summary>
    let TypeRegistration = _prefixId.prefix "TypeRegistration"
    /// <summary>
    ///   <para>rdfs:label : Unlisted Type Index</para>
    ///   <para>rdfs:comment : Unlisted Type Index is a registry of resources that are private to the user and their apps, for types that are not publicly discoverable.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#UnlistedDocument">solid:UnlistedDocument</a>
    /// </summary>
    let UnlistedDocument = _prefixId.prefix "UnlistedDocument"
    /// <summary>
    ///   <para>rdfs:label : account</para>
    ///   <para>rdfs:comment : A solid account belonging to an Agent.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#account">solid:account</a>
    /// </summary>
    let account = _prefixId.prefix "account"
    /// <summary>
    ///   <para>rdfs:label : deletes</para>
    ///   <para>rdfs:comment : The triple patterns this patch removes from the document.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#deletes">solid:deletes</a>
    /// </summary>
    let deletes = _prefixId.prefix "deletes"
    /// <summary>
    ///   <para>rdfs:label : registry class</para>
    ///   <para>rdfs:comment : A class that is used to map an listed or unlisted type index.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#forClass">solid:forClass</a>
    /// </summary>
    let forClass = _prefixId.prefix "forClass"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : inbox (deprecated)</para>
    ///   <para>rdfs:comment : Deprecated pointer to a Linked Data Notifications inbox; please use http://www.w3.org/ns/ldp#inbox instead.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#inbox">solid:inbox</a>
    /// </summary>
    let inbox = _prefixId.prefix "inbox"
    /// <summary>
    ///   <para>rdfs:label : inserts</para>
    ///   <para>rdfs:comment : The triple patterns this patch adds to the document.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#inserts">solid:inserts</a>
    /// </summary>
    let inserts = _prefixId.prefix "inserts"
    /// <summary>
    ///   <para>rdfs:label : instance</para>
    ///   <para>rdfs:comment : Maps a type to an individual resource, typically an index or a directory listing resource.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#instance">solid:instance</a>
    /// </summary>
    let instance = _prefixId.prefix "instance"
    /// <summary>
    ///   <para>rdfs:label : instance container</para>
    ///   <para>rdfs:comment : Maps a type to a container which the client would have to list to get the instances of that type.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#instanceContainer">solid:instanceContainer</a>
    /// </summary>
    let instanceContainer = _prefixId.prefix "instanceContainer"
    /// <summary>
    ///   <para>rdfs:label : loginEndpoint</para>
    ///   <para>rdfs:comment : The login URI of a given server.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#loginEndpoint">solid:loginEndpoint</a>
    /// </summary>
    let loginEndpoint = _prefixId.prefix "loginEndpoint"
    /// <summary>
    ///   <para>rdfs:label : logoutEndpoint</para>
    ///   <para>rdfs:comment : The logout URI of a given server.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#logoutEndpoint">solid:logoutEndpoint</a>
    /// </summary>
    let logoutEndpoint = _prefixId.prefix "logoutEndpoint"
    /// <summary>
    ///   <para>rdfs:label : notification</para>
    ///   <para>rdfs:comment : Notification resource for an inbox.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#notification">solid:notification</a>
    /// </summary>
    let notification = _prefixId.prefix "notification"
    /// <summary>
    ///   <para>rdfs:label : oidcIssuer</para>
    ///   <para>rdfs:comment : The preferred OpenID Connect issuer URI for a given Web ID.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#oidcIssuer">solid:oidcIssuer</a>
    /// </summary>
    let oidcIssuer = _prefixId.prefix "oidcIssuer"
    /// <summary>
    ///   <para>rdfs:label : patches</para>
    ///   <para>rdfs:comment : The document to which this patch applies.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#patches">solid:patches</a>
    /// </summary>
    let patches = _prefixId.prefix "patches"
    /// <summary>
    ///   <para>rdfs:label : private type index</para>
    ///   <para>rdfs:comment : Points to an unlisted type index resource.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#privateTypeIndex">solid:privateTypeIndex</a>
    /// </summary>
    let privateTypeIndex = _prefixId.prefix "privateTypeIndex"
    /// <summary>
    ///   <para>rdfs:label : public type index</para>
    ///   <para>rdfs:comment : Points to a listed type index resource.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#publicTypeIndex">solid:publicTypeIndex</a>
    /// </summary>
    let publicTypeIndex = _prefixId.prefix "publicTypeIndex"
    /// <summary>
    ///   <para>rdfs:label : read</para>
    ///   <para>rdfs:comment : Indicates if a message has been read or not. This property should have a boolean datatype.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#read">solid:read</a>
    /// </summary>
    let read = _prefixId.prefix "read"
    /// <summary>
    ///   <para>rdfs:label : Non-volatile memory quota</para>
    ///   <para>rdfs:comment : The quota of non-volatile memory that is available for the account (in bytes)</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#storageQuota">solid:storageQuota</a>
    /// </summary>
    let storageQuota = _prefixId.prefix "storageQuota"
    /// <summary>
    ///   <para>rdfs:label : Non-volatile memory usage</para>
    ///   <para>rdfs:comment : The amount of non-volatile memory that the account have used (in bytes)</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#storageUsage">solid:storageUsage</a>
    /// </summary>
    let storageUsage = _prefixId.prefix "storageUsage"
    /// <summary>
    ///   <para>rdfs:label : timeline</para>
    ///   <para>rdfs:comment : Timeline for a given resource.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#timeline">solid:timeline</a>
    /// </summary>
    let timeline = _prefixId.prefix "timeline"
    /// <summary>
    ///   <para>rdfs:label : type index</para>
    ///   <para>rdfs:comment : Points to a TypeIndex resource.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#typeIndex">solid:typeIndex</a>
    /// </summary>
    let typeIndex = _prefixId.prefix "typeIndex"
    /// <summary>
    ///   <para>rdfs:label : where</para>
    ///   <para>rdfs:comment : The conditions the document and the inserted and deleted triple patterns need to satisfy in order for the patch to be applied.</para>
    ///   <a href="http://www.w3.org/ns/solid/terms#where">solid:where</a>
    /// </summary>
    let where = _prefixId.prefix "where"
