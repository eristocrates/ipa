namespace http.www.w3.org.ns.solid.terms.hash

open DoxAletheia.Rdf_Vocabulary

module solid =
    let _namespace_name = "http://www.w3.org/ns/solid/terms#"
    /// <summary>
    /// A Solid account.
    /// <see href="http://www.w3.org/ns/solid/terms#Account"></see></summary>
    let Account = Namespaced_IRI.parse _namespace_name "Account" |> NamespacedName
    /// <summary>
    /// A resource containing notifications.
    /// <see href="http://www.w3.org/ns/solid/terms#Inbox"></see></summary>
    let Inbox = Namespaced_IRI.parse _namespace_name "Inbox" |> NamespacedName

    /// <summary>
    /// Listed Type Index is a registry of resources that are publicly discoverable by outside users and applications.
    /// <see href="http://www.w3.org/ns/solid/terms#ListedDocument"></see></summary>
    let ListedDocument =
        Namespaced_IRI.parse _namespace_name "ListedDocument" |> NamespacedName

    /// <summary>
    /// A notification resource.
    /// <see href="http://www.w3.org/ns/solid/terms#Notification"></see></summary>
    let Notification =
        Namespaced_IRI.parse _namespace_name "Notification" |> NamespacedName

    /// <summary>
    /// A patch expresses conditional modifications to a resource that has an RDF-based representation.
    /// <see href="http://www.w3.org/ns/solid/terms#Patch"></see></summary>
    let Patch = Namespaced_IRI.parse _namespace_name "Patch" |> NamespacedName
    /// <summary>
    /// A resource containing time ordered items and sub-containers.  Sub-containers may be desirable in file based systems to split the timeline into logical components e.g. /yyyy-mm-dd/ as used in ISO 8061.
    /// <see href="http://www.w3.org/ns/solid/terms#Timeline"></see></summary>
    let Timeline = Namespaced_IRI.parse _namespace_name "Timeline" |> NamespacedName
    /// <summary>
    /// A index of type registries for resources. Applications can register the RDF type they use and list them in the index resource.
    /// <see href="http://www.w3.org/ns/solid/terms#TypeIndex"></see></summary>
    let TypeIndex = Namespaced_IRI.parse _namespace_name "TypeIndex" |> NamespacedName

    /// <summary>
    /// The registered types that map a RDF classes/types to their locations using either `instance` or `instanceContainer` property.
    /// <see href="http://www.w3.org/ns/solid/terms#TypeRegistration"></see></summary>
    let TypeRegistration =
        Namespaced_IRI.parse _namespace_name "TypeRegistration" |> NamespacedName

    /// <summary>
    /// Unlisted Type Index is a registry of resources that are private to the user and their apps, for types that are not publicly discoverable.
    /// <see href="http://www.w3.org/ns/solid/terms#UnlistedDocument"></see></summary>
    let UnlistedDocument =
        Namespaced_IRI.parse _namespace_name "UnlistedDocument" |> NamespacedName

    /// <summary>
    /// A solid account belonging to an Agent.
    /// <see href="http://www.w3.org/ns/solid/terms#account"></see></summary>
    let account = Namespaced_IRI.parse _namespace_name "account" |> NamespacedName
    /// <summary>
    /// The triple patterns this patch removes from the document.
    /// <see href="http://www.w3.org/ns/solid/terms#deletes"></see></summary>
    let deletes = Namespaced_IRI.parse _namespace_name "deletes" |> NamespacedName
    /// <summary>
    /// A class that is used to map an listed or unlisted type index.
    /// <see href="http://www.w3.org/ns/solid/terms#forClass"></see></summary>
    let forClass = Namespaced_IRI.parse _namespace_name "forClass" |> NamespacedName
    /// <summary>
    /// Deprecated pointer to a Linked Data Notifications inbox; please use http://www.w3.org/ns/ldp#inbox instead.
    /// <see href="http://www.w3.org/ns/solid/terms#inbox"></see></summary>
    let inbox = Namespaced_IRI.parse _namespace_name "inbox" |> NamespacedName
    /// <summary>
    /// The triple patterns this patch adds to the document.
    /// <see href="http://www.w3.org/ns/solid/terms#inserts"></see></summary>
    let inserts = Namespaced_IRI.parse _namespace_name "inserts" |> NamespacedName
    /// <summary>
    /// Maps a type to an individual resource, typically an index or a directory listing resource.
    /// <see href="http://www.w3.org/ns/solid/terms#instance"></see></summary>
    let instance = Namespaced_IRI.parse _namespace_name "instance" |> NamespacedName

    /// <summary>
    /// Maps a type to a container which the client would have to list to get the instances of that type.
    /// <see href="http://www.w3.org/ns/solid/terms#instanceContainer"></see></summary>
    let instanceContainer =
        Namespaced_IRI.parse _namespace_name "instanceContainer" |> NamespacedName

    /// <summary>
    /// The login URI of a given server.
    /// <see href="http://www.w3.org/ns/solid/terms#loginEndpoint"></see></summary>
    let loginEndpoint =
        Namespaced_IRI.parse _namespace_name "loginEndpoint" |> NamespacedName

    /// <summary>
    /// The logout URI of a given server.
    /// <see href="http://www.w3.org/ns/solid/terms#logoutEndpoint"></see></summary>
    let logoutEndpoint =
        Namespaced_IRI.parse _namespace_name "logoutEndpoint" |> NamespacedName

    /// <summary>
    /// Notification resource for an inbox.
    /// <see href="http://www.w3.org/ns/solid/terms#notification"></see></summary>
    let notification =
        Namespaced_IRI.parse _namespace_name "notification" |> NamespacedName

    /// <summary>
    /// The preferred OpenID Connect issuer URI for a given Web ID.
    /// <see href="http://www.w3.org/ns/solid/terms#oidcIssuer"></see></summary>
    let oidcIssuer = Namespaced_IRI.parse _namespace_name "oidcIssuer" |> NamespacedName
    /// <summary>
    /// The document to which this patch applies.
    /// <see href="http://www.w3.org/ns/solid/terms#patches"></see></summary>
    let patches = Namespaced_IRI.parse _namespace_name "patches" |> NamespacedName

    /// <summary>
    /// Points to an unlisted type index resource.
    /// <see href="http://www.w3.org/ns/solid/terms#privateTypeIndex"></see></summary>
    let privateTypeIndex =
        Namespaced_IRI.parse _namespace_name "privateTypeIndex" |> NamespacedName

    /// <summary>
    /// Points to a listed type index resource.
    /// <see href="http://www.w3.org/ns/solid/terms#publicTypeIndex"></see></summary>
    let publicTypeIndex =
        Namespaced_IRI.parse _namespace_name "publicTypeIndex" |> NamespacedName

    /// <summary>
    /// Points to a TypeIndex resource.
    /// <see href="http://www.w3.org/ns/solid/terms#typeIndex"></see></summary>
    let typeIndex = Namespaced_IRI.parse _namespace_name "typeIndex" |> NamespacedName
    /// <summary>
    /// Indicates if a message has been read or not. This property should have a boolean datatype.
    /// <see href="http://www.w3.org/ns/solid/terms#read"></see></summary>
    let read = Namespaced_IRI.parse _namespace_name "read" |> NamespacedName

    /// <summary>
    /// The quota of non-volatile memory that is available for the account (in bytes)
    /// <see href="http://www.w3.org/ns/solid/terms#storageQuota"></see></summary>
    let storageQuota =
        Namespaced_IRI.parse _namespace_name "storageQuota" |> NamespacedName

    /// <summary>
    /// The amount of non-volatile memory that the account have used (in bytes)
    /// <see href="http://www.w3.org/ns/solid/terms#storageUsage"></see></summary>
    let storageUsage =
        Namespaced_IRI.parse _namespace_name "storageUsage" |> NamespacedName

    /// <summary>
    /// Timeline for a given resource.
    /// <see href="http://www.w3.org/ns/solid/terms#timeline"></see></summary>
    let timeline = Namespaced_IRI.parse _namespace_name "timeline" |> NamespacedName
    /// <summary>
    /// The conditions the document and the inserted and deleted triple patterns need to satisfy in order for the patch to be applied.
    /// <see href="http://www.w3.org/ns/solid/terms#where"></see></summary>
    let where = Namespaced_IRI.parse _namespace_name "where" |> NamespacedName
