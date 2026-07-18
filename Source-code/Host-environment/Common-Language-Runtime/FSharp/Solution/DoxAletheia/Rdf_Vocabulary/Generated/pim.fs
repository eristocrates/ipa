namespace http.www.w3.org.ns.pim.space.hash

open DoxAletheia.Rdf_Vocabulary

module pim =
    let _namespace_name = "http://www.w3.org/ns/pim/space#"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/pim/space#ConfigurationFile"></see>
    /// </summary>
    let ConfigurationFile =
        Namespaced_IRI.parse _namespace_name "ConfigurationFile" |> NamespacedName

    /// <summary>
    /// A  storage is a space of URIs in which you can individually control for each resource
    ///     who has access to it.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#ControlledStorage"></see></summary>
    let ControlledStorage =
        Namespaced_IRI.parse _namespace_name "ControlledStorage" |> NamespacedName

    /// <summary>
    /// A storage is a space of URIs in which you have access to data.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#Storage"></see></summary>
    let Storage = Namespaced_IRI.parse _namespace_name "Storage" |> NamespacedName

    /// <summary>
    /// This is a workspace for storing the
    ///     information about the other workspaces.
    ///     As a user, you normally don't have to worry about it.
    /// <see href="http://www.w3.org/ns/pim/space#MasterWorkspace"></see></summary>
    let MasterWorkspace =
        Namespaced_IRI.parse _namespace_name "MasterWorkspace" |> NamespacedName

    /// <summary>
    /// Access only by the you, the user.
    /// <see href="http://www.w3.org/ns/pim/space#PrivateWorkspace"></see></summary>
    let PrivateWorkspace =
        Namespaced_IRI.parse _namespace_name "PrivateWorkspace" |> NamespacedName

    /// <summary>
    /// A personal storage is a space of URIs in which you and only you have access to data,
    ///     you cannot give access to anyone else.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#PersonalStorage"></see></summary>
    let PersonalStorage =
        Namespaced_IRI.parse _namespace_name "PersonalStorage" |> NamespacedName

    /// <summary>
    /// Aceess may not be open to the public. Contains preferences resources.
    /// <see href="http://www.w3.org/ns/pim/space#PreferencesWorkspace"></see></summary>
    let PreferencesWorkspace =
        Namespaced_IRI.parse _namespace_name "PreferencesWorkspace" |> NamespacedName

    /// <summary>
    /// Workspaces are place where data is stored, and associated polices of privacy.
    /// A given application typically stores information in several different
    /// workspaces, some being user private, some shared, and some public.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#Workspace"></see></summary>
    let Workspace = Namespaced_IRI.parse _namespace_name "Workspace" |> NamespacedName

    /// <summary>
    /// A public storage is a space of URIs in which you have access to data,
    ///     and all data is accessible to anyone without control.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#PublicStorage"></see></summary>
    let PublicStorage =
        Namespaced_IRI.parse _namespace_name "PublicStorage" |> NamespacedName

    /// <summary>
    /// Aceess is open to the public. Anything in a public workspace
    ///     can be accesed by anyone.
    /// <see href="http://www.w3.org/ns/pim/space#PublicWorkspace"></see></summary>
    let PublicWorkspace =
        Namespaced_IRI.parse _namespace_name "PublicWorkspace" |> NamespacedName

    /// <summary>
    /// Access is to some but not all people.
    /// <see href="http://www.w3.org/ns/pim/space#SharedWorkspace"></see></summary>
    let SharedWorkspace =
        Namespaced_IRI.parse _namespace_name "SharedWorkspace" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/pim/space#masterWorkspace"></see>
    /// </summary>
    let masterWorkspace =
        Namespaced_IRI.parse _namespace_name "masterWorkspace" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/pim/space#preferencesFile"></see>
    /// </summary>
    let preferencesFile =
        Namespaced_IRI.parse _namespace_name "preferencesFile" |> NamespacedName

    /// <summary>
    /// The storage in which this workspace is, or the storage which
    /// contains this resource, or a storage available to this agent to use.
    /// <see href="http://www.w3.org/ns/pim/space#storage"></see></summary>
    let storage = Namespaced_IRI.parse _namespace_name "storage" |> NamespacedName
    /// <summary>
    /// URIs which start with this string are in this workspace or storage.
    /// This may be used for constructing URIs for new storage resources.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#uriPrefix"></see></summary>
    let uriPrefix = Namespaced_IRI.parse _namespace_name "uriPrefix" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/pim/space#workspace"></see>
    /// </summary>
    let workspace = Namespaced_IRI.parse _namespace_name "workspace" |> NamespacedName
