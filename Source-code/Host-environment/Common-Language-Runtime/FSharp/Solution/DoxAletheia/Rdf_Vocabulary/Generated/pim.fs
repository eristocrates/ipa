namespace http.www.w3.org.ns.pim.space.hash

open DoxAletheia

module pim =
    let _namespace_name = "http://www.w3.org/ns/pim/space#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/pim/space#ConfigurationFile"></see>
    /// </summary>
    let ConfigurationFile = _prefix "ConfigurationFile"
    /// <summary>
    /// A  storage is a space of URIs in which you can individually control for each resource
    ///     who has access to it.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#ControlledStorage"></see></summary>
    let ControlledStorage = _prefix "ControlledStorage"
    /// <summary>
    /// A storage is a space of URIs in which you have access to data.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#Storage"></see></summary>
    let Storage = _prefix "Storage"
    /// <summary>
    /// This is a workspace for storing the
    ///     information about the other workspaces.
    ///     As a user, you normally don't have to worry about it.
    /// <see href="http://www.w3.org/ns/pim/space#MasterWorkspace"></see></summary>
    let MasterWorkspace = _prefix "MasterWorkspace"
    /// <summary>
    /// Access only by the you, the user.
    /// <see href="http://www.w3.org/ns/pim/space#PrivateWorkspace"></see></summary>
    let PrivateWorkspace = _prefix "PrivateWorkspace"
    /// <summary>
    /// A personal storage is a space of URIs in which you and only you have access to data,
    ///     you cannot give access to anyone else.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#PersonalStorage"></see></summary>
    let PersonalStorage = _prefix "PersonalStorage"
    /// <summary>
    /// Aceess may not be open to the public. Contains preferences resources.
    /// <see href="http://www.w3.org/ns/pim/space#PreferencesWorkspace"></see></summary>
    let PreferencesWorkspace = _prefix "PreferencesWorkspace"
    /// <summary>
    /// Workspaces are place where data is stored, and associated polices of privacy.
    /// A given application typically stores information in several different
    /// workspaces, some being user private, some shared, and some public.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#Workspace"></see></summary>
    let Workspace = _prefix "Workspace"
    /// <summary>
    /// A public storage is a space of URIs in which you have access to data,
    ///     and all data is accessible to anyone without control.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#PublicStorage"></see></summary>
    let PublicStorage = _prefix "PublicStorage"
    /// <summary>
    /// Aceess is open to the public. Anything in a public workspace
    ///     can be accesed by anyone.
    /// <see href="http://www.w3.org/ns/pim/space#PublicWorkspace"></see></summary>
    let PublicWorkspace = _prefix "PublicWorkspace"
    /// <summary>
    /// Access is to some but not all people.
    /// <see href="http://www.w3.org/ns/pim/space#SharedWorkspace"></see></summary>
    let SharedWorkspace = _prefix "SharedWorkspace"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/pim/space#masterWorkspace"></see>
    /// </summary>
    let masterWorkspace = _prefix "masterWorkspace"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/pim/space#preferencesFile"></see>
    /// </summary>
    let preferencesFile = _prefix "preferencesFile"
    /// <summary>
    /// The storage in which this workspace is, or the storage which
    /// contains this resource, or a storage available to this agent to use.
    /// <see href="http://www.w3.org/ns/pim/space#storage"></see></summary>
    let storage = _prefix "storage"
    /// <summary>
    /// URIs which start with this string are in this workspace or storage.
    /// This may be used for constructing URIs for new storage resources.
    ///
    /// <see href="http://www.w3.org/ns/pim/space#uriPrefix"></see></summary>
    let uriPrefix = _prefix "uriPrefix"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/pim/space#workspace"></see>
    /// </summary>
    let workspace = _prefix "workspace"
