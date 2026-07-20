namespace http.www.w3.org.ns.solid.terms.hash

open DoxAletheia

module solid =
    let _namespace_name = "http://www.w3.org/ns/solid/terms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Solid account.
    /// <see href="http://www.w3.org/ns/solid/terms#Account"></see></summary>
    let Account = _prefix "Account"
    /// <summary>
    /// A resource containing notifications.
    /// <see href="http://www.w3.org/ns/solid/terms#Inbox"></see></summary>
    let Inbox = _prefix "Inbox"
    /// <summary>
    /// Listed Type Index is a registry of resources that are publicly discoverable by outside users and applications.
    /// <see href="http://www.w3.org/ns/solid/terms#ListedDocument"></see></summary>
    let ListedDocument = _prefix "ListedDocument"
    /// <summary>
    /// A notification resource.
    /// <see href="http://www.w3.org/ns/solid/terms#Notification"></see></summary>
    let Notification = _prefix "Notification"
    /// <summary>
    /// A patch expresses conditional modifications to a resource that has an RDF-based representation.
    /// <see href="http://www.w3.org/ns/solid/terms#Patch"></see></summary>
    let Patch = _prefix "Patch"
    /// <summary>
    /// A resource containing time ordered items and sub-containers.  Sub-containers may be desirable in file based systems to split the timeline into logical components e.g. /yyyy-mm-dd/ as used in ISO 8061.
    /// <see href="http://www.w3.org/ns/solid/terms#Timeline"></see></summary>
    let Timeline = _prefix "Timeline"
    /// <summary>
    /// A index of type registries for resources. Applications can register the RDF type they use and list them in the index resource.
    /// <see href="http://www.w3.org/ns/solid/terms#TypeIndex"></see></summary>
    let TypeIndex = _prefix "TypeIndex"
    /// <summary>
    /// The registered types that map a RDF classes/types to their locations using either `instance` or `instanceContainer` property.
    /// <see href="http://www.w3.org/ns/solid/terms#TypeRegistration"></see></summary>
    let TypeRegistration = _prefix "TypeRegistration"
    /// <summary>
    /// Unlisted Type Index is a registry of resources that are private to the user and their apps, for types that are not publicly discoverable.
    /// <see href="http://www.w3.org/ns/solid/terms#UnlistedDocument"></see></summary>
    let UnlistedDocument = _prefix "UnlistedDocument"
    /// <summary>
    /// A solid account belonging to an Agent.
    /// <see href="http://www.w3.org/ns/solid/terms#account"></see></summary>
    let account = _prefix "account"
    /// <summary>
    /// The triple patterns this patch removes from the document.
    /// <see href="http://www.w3.org/ns/solid/terms#deletes"></see></summary>
    let deletes = _prefix "deletes"
    /// <summary>
    /// A class that is used to map an listed or unlisted type index.
    /// <see href="http://www.w3.org/ns/solid/terms#forClass"></see></summary>
    let forClass = _prefix "forClass"
    /// <summary>
    /// Deprecated pointer to a Linked Data Notifications inbox; please use http://www.w3.org/ns/ldp#inbox instead.
    /// <see href="http://www.w3.org/ns/solid/terms#inbox"></see></summary>
    let inbox = _prefix "inbox"
    /// <summary>
    /// The triple patterns this patch adds to the document.
    /// <see href="http://www.w3.org/ns/solid/terms#inserts"></see></summary>
    let inserts = _prefix "inserts"
    /// <summary>
    /// Maps a type to an individual resource, typically an index or a directory listing resource.
    /// <see href="http://www.w3.org/ns/solid/terms#instance"></see></summary>
    let instance = _prefix "instance"
    /// <summary>
    /// Maps a type to a container which the client would have to list to get the instances of that type.
    /// <see href="http://www.w3.org/ns/solid/terms#instanceContainer"></see></summary>
    let instanceContainer = _prefix "instanceContainer"
    /// <summary>
    /// The login URI of a given server.
    /// <see href="http://www.w3.org/ns/solid/terms#loginEndpoint"></see></summary>
    let loginEndpoint = _prefix "loginEndpoint"
    /// <summary>
    /// The logout URI of a given server.
    /// <see href="http://www.w3.org/ns/solid/terms#logoutEndpoint"></see></summary>
    let logoutEndpoint = _prefix "logoutEndpoint"
    /// <summary>
    /// Notification resource for an inbox.
    /// <see href="http://www.w3.org/ns/solid/terms#notification"></see></summary>
    let notification = _prefix "notification"
    /// <summary>
    /// The preferred OpenID Connect issuer URI for a given Web ID.
    /// <see href="http://www.w3.org/ns/solid/terms#oidcIssuer"></see></summary>
    let oidcIssuer = _prefix "oidcIssuer"
    /// <summary>
    /// The document to which this patch applies.
    /// <see href="http://www.w3.org/ns/solid/terms#patches"></see></summary>
    let patches = _prefix "patches"
    /// <summary>
    /// Points to an unlisted type index resource.
    /// <see href="http://www.w3.org/ns/solid/terms#privateTypeIndex"></see></summary>
    let privateTypeIndex = _prefix "privateTypeIndex"
    /// <summary>
    /// Points to a listed type index resource.
    /// <see href="http://www.w3.org/ns/solid/terms#publicTypeIndex"></see></summary>
    let publicTypeIndex = _prefix "publicTypeIndex"
    /// <summary>
    /// Points to a TypeIndex resource.
    /// <see href="http://www.w3.org/ns/solid/terms#typeIndex"></see></summary>
    let typeIndex = _prefix "typeIndex"
    /// <summary>
    /// Indicates if a message has been read or not. This property should have a boolean datatype.
    /// <see href="http://www.w3.org/ns/solid/terms#read"></see></summary>
    let read = _prefix "read"
    /// <summary>
    /// The quota of non-volatile memory that is available for the account (in bytes)
    /// <see href="http://www.w3.org/ns/solid/terms#storageQuota"></see></summary>
    let storageQuota = _prefix "storageQuota"
    /// <summary>
    /// The amount of non-volatile memory that the account have used (in bytes)
    /// <see href="http://www.w3.org/ns/solid/terms#storageUsage"></see></summary>
    let storageUsage = _prefix "storageUsage"
    /// <summary>
    /// Timeline for a given resource.
    /// <see href="http://www.w3.org/ns/solid/terms#timeline"></see></summary>
    let timeline = _prefix "timeline"
    /// <summary>
    /// The conditions the document and the inserted and deleted triple patterns need to satisfy in order for the patch to be applied.
    /// <see href="http://www.w3.org/ns/solid/terms#where"></see></summary>
    let where = _prefix "where"
