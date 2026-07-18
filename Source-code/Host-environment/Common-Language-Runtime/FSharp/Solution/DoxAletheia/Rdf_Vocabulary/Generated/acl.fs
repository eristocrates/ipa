namespace http.www.w3.org.ns.auth.acl.hash

open DoxAletheia.Rdf_Vocabulary

module acl =
    let _namespace_name = "http://www.w3.org/ns/auth/acl#"
    /// <summary>
    /// Any kind of access to a resource. Don't use this, use R W and RW
    /// <see href="http://www.w3.org/ns/auth/acl#Access"></see></summary>
    let Access = Namespaced_IRI.parse _namespace_name "Access" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/auth/acl#label"></see>
    /// </summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// Append accesses are specific write access which only add information, and do not remove information.
    ///     For text files, for example, append access allows bytes to be added onto the end of the file.
    ///     For RDF graphs, Append access allows adds triples to the graph but does not remove any.
    ///     Append access is useful for dropbox functionality.
    ///     Dropbox can be used for link notification, which the information added is a notification
    ///     that a some link has been made elsewhere relevant to the given resource.
    ///
    /// <see href="http://www.w3.org/ns/auth/acl#Append"></see></summary>
    let Append = Namespaced_IRI.parse _namespace_name "Append" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/auth/acl#Write"></see>
    /// </summary>
    let Write = Namespaced_IRI.parse _namespace_name "Write" |> NamespacedName

    /// <summary>
    /// An element of access control,
    ///     allowing agent to agents access of some kind to resources or classes of resources
    /// <see href="http://www.w3.org/ns/auth/acl#Authorization"></see></summary>
    let Authorization =
        Namespaced_IRI.parse _namespace_name "Authorization" |> NamespacedName

    /// <summary>
    /// Allows read/write access to the ACL for the resource(s)
    /// <see href="http://www.w3.org/ns/auth/acl#Control"></see></summary>
    let Control = Namespaced_IRI.parse _namespace_name "Control" |> NamespacedName
    /// <summary>
    /// The class of read operations
    /// <see href="http://www.w3.org/ns/auth/acl#Read"></see></summary>
    let Read = Namespaced_IRI.parse _namespace_name "Read" |> NamespacedName

    /// <summary>
    /// The Access Control file for this information resource.
    ///         This may of course be a virtual resorce implemented by the access control system.
    ///         Note also HTTP's header  Link:  foo.meta ;rel=meta can be used for this.
    /// <see href="http://www.w3.org/ns/auth/acl#accessControl"></see></summary>
    let accessControl =
        Namespaced_IRI.parse _namespace_name "accessControl" |> NamespacedName

    /// <summary>
    /// The information resource to which access is being granted.
    /// <see href="http://www.w3.org/ns/auth/acl#accessTo"></see></summary>
    let accessTo = Namespaced_IRI.parse _namespace_name "accessTo" |> NamespacedName

    /// <summary>
    /// A class of information resources to which access is being granted.
    /// <see href="http://www.w3.org/ns/auth/acl#accessToClass"></see></summary>
    let accessToClass =
        Namespaced_IRI.parse _namespace_name "accessToClass" |> NamespacedName

    /// <summary>
    /// A person or social entity to being given the right
    /// <see href="http://www.w3.org/ns/auth/acl#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName
    /// <summary>
    /// A class of persons or social entities to being given the right
    /// <see href="http://www.w3.org/ns/auth/acl#agentClass"></see></summary>
    let agentClass = Namespaced_IRI.parse _namespace_name "agentClass" |> NamespacedName

    /// <summary>
    /// A directory for which this authorization is used for new files in the directory.
    /// <see href="http://www.w3.org/ns/auth/acl#defaultForNew"></see></summary>
    let defaultForNew =
        Namespaced_IRI.parse _namespace_name "defaultForNew" |> NamespacedName

    /// <summary>
    /// A mode of access such as read or write.
    /// <see href="http://www.w3.org/ns/auth/acl#mode"></see></summary>
    let mode = Namespaced_IRI.parse _namespace_name "mode" |> NamespacedName
    /// <summary>
    /// The person or other agent which owns this.
    ///     For example, the owner of a file in a filesystem.
    ///     There is a sense of right to control.   Typically defaults to the agent who craeted
    ///     something but can be changed.
    /// <see href="http://www.w3.org/ns/auth/acl#owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
