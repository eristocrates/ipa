namespace http.www.w3.org.ns.pim.space.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module space =
    let _namespace_iri = Namespace_Iri space |> NamespaceIRI
    /// <summary>
    ///   <para>space:ConfigurationFile</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#ConfigurationFile">http://www.w3.org/ns/pim/space#ConfigurationFile</seealso>
    let ConfigurationFile = Prefixed_Name(space, "ConfigurationFile") |> PrefixedName
    /// <summary>
    ///   <para>space:ControlledStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A  storage is a space of URIs in which you can individually control for each resource
    ///     who has access to it.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"access controlled storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#ControlledStorage">http://www.w3.org/ns/pim/space#ControlledStorage</seealso>
    let ControlledStorage = Prefixed_Name(space, "ControlledStorage") |> PrefixedName
    /// <summary>
    ///   <para>space:MasterWorkspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>"This is a workspace for storing the
    ///     information about the other workspaces.
    ///     As a user, you normally don't have to worry about it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Master Workspace"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#MasterWorkspace">http://www.w3.org/ns/pim/space#MasterWorkspace</seealso>
    let MasterWorkspace = Prefixed_Name(space, "MasterWorkspace") |> PrefixedName
    /// <summary>
    ///   <para>space:PersonalStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A personal storage is a space of URIs in which you and only you have access to data,
    ///     you cannot give access to anyone else.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"personal storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#PersonalStorage">http://www.w3.org/ns/pim/space#PersonalStorage</seealso>
    let PersonalStorage = Prefixed_Name(space, "PersonalStorage") |> PrefixedName

    /// <summary>
    ///   <para>space:PreferencesWorkspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Aceess may not be open to the public. Contains preferences resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Preferences workspace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#PreferencesWorkspace">http://www.w3.org/ns/pim/space#PreferencesWorkspace</seealso>
    let PreferencesWorkspace =
        Prefixed_Name(space, "PreferencesWorkspace") |> PrefixedName

    /// <summary>
    ///   <para>space:PrivateWorkspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Access only by the you, the user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Private workspace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#PrivateWorkspace">http://www.w3.org/ns/pim/space#PrivateWorkspace</seealso>
    let PrivateWorkspace = Prefixed_Name(space, "PrivateWorkspace") |> PrefixedName
    /// <summary>
    ///   <para>space:PublicStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A public storage is a space of URIs in which you have access to data,
    ///     and all data is accessible to anyone without control.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"public storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#PublicStorage">http://www.w3.org/ns/pim/space#PublicStorage</seealso>
    let PublicStorage = Prefixed_Name(space, "PublicStorage") |> PrefixedName
    /// <summary>
    ///   <para>space:PublicWorkspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Aceess is open to the public. Anything in a public workspace
    ///     can be accesed by anyone."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Public workspace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#PublicWorkspace">http://www.w3.org/ns/pim/space#PublicWorkspace</seealso>
    let PublicWorkspace = Prefixed_Name(space, "PublicWorkspace") |> PrefixedName
    /// <summary>
    ///   <para>space:SharedWorkspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Access is to some but not all people."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Shared workspace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#SharedWorkspace">http://www.w3.org/ns/pim/space#SharedWorkspace</seealso>
    let SharedWorkspace = Prefixed_Name(space, "SharedWorkspace") |> PrefixedName
    /// <summary>
    ///   <para>space:Storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A storage is a space of URIs in which you have access to data.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#Storage">http://www.w3.org/ns/pim/space#Storage</seealso>
    let Storage = Prefixed_Name(space, "Storage") |> PrefixedName
    /// <summary>
    ///   <para>space:Workspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Workspaces are place where data is stored, and associated polices of privacy.
    /// A given application typically stores information in several different
    /// workspaces, some being user private, some shared, and some public.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"workspace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#Workspace">http://www.w3.org/ns/pim/space#Workspace</seealso>
    let Workspace = Prefixed_Name(space, "Workspace") |> PrefixedName
    /// <summary>
    ///   <para>space:masterWorkspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"master workspace"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#masterWorkspace">http://www.w3.org/ns/pim/space#masterWorkspace</seealso>
    let masterWorkspace = Prefixed_Name(space, "masterWorkspace") |> PrefixedName
    /// <summary>
    ///   <para>space:preferencesFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"preferences file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#preferencesFile">http://www.w3.org/ns/pim/space#preferencesFile</seealso>
    let preferencesFile = Prefixed_Name(space, "preferencesFile") |> PrefixedName
    /// <summary>
    ///   <para>space:storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The storage in which this workspace is, or the storage which
    /// contains this resource, or a storage available to this agent to use."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"storage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#storage">http://www.w3.org/ns/pim/space#storage</seealso>
    let storage = Prefixed_Name(space, "storage") |> PrefixedName
    /// <summary>
    ///   <para>space:uriPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URIs which start with this string are in this workspace or storage.
    /// This may be used for constructing URIs for new storage resources.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URI prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#uriPrefix">http://www.w3.org/ns/pim/space#uriPrefix</seealso>
    let uriPrefix = Prefixed_Name(space, "uriPrefix") |> PrefixedName
    /// <summary>
    ///   <para>space:workspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"workspace"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/pim/space#workspace">http://www.w3.org/ns/pim/space#workspace</seealso>
    let workspace = Prefixed_Name(space, "workspace") |> PrefixedName
