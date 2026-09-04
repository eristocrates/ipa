#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ws =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/pim/space#" "ws"
    let ConfigurationFile = _prefixId.prefix "ConfigurationFile"
    /// <summary>
    ///   <para>rdfs:label : access controlled storage^^xsd:string</para>
    ///   <para>rdfs:comment : A  storage is a space of URIs in which you can individually control for each resource
    ///     who has access to it.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/pim/space#ControlledStorage">ws:ControlledStorage</a>
    /// </summary>
    let ControlledStorage = _prefixId.prefix "ControlledStorage"
    let MasterWorkspace = _prefixId.prefix "MasterWorkspace"
    /// <summary>
    ///   <para>rdfs:label : personal storage^^xsd:string</para>
    ///   <para>rdfs:comment : A personal storage is a space of URIs in which you and only you have access to data,
    ///     you cannot give access to anyone else.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/pim/space#PersonalStorage">ws:PersonalStorage</a>
    /// </summary>
    let PersonalStorage = _prefixId.prefix "PersonalStorage"
    let PreferencesWorkspace = _prefixId.prefix "PreferencesWorkspace"
    let PrivateWorkspace = _prefixId.prefix "PrivateWorkspace"
    /// <summary>
    ///   <para>rdfs:label : public storage^^xsd:string</para>
    ///   <para>rdfs:comment : A public storage is a space of URIs in which you have access to data,
    ///     and all data is accessible to anyone without control.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/pim/space#PublicStorage">ws:PublicStorage</a>
    /// </summary>
    let PublicStorage = _prefixId.prefix "PublicStorage"
    let PublicWorkspace = _prefixId.prefix "PublicWorkspace"
    let SharedWorkspace = _prefixId.prefix "SharedWorkspace"
    /// <summary>
    ///   <para>rdfs:label : storage^^xsd:string</para>
    ///   <para>rdfs:comment : A storage is a space of URIs in which you have access to data.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/pim/space#Storage">ws:Storage</a>
    /// </summary>
    let Storage = _prefixId.prefix "Storage"
    /// <summary>
    ///   <para>rdfs:label : workspace^^xsd:string</para>
    ///   <para>rdfs:comment : Workspaces are place where data is stored, and associated polices of privacy.
    /// A given application typically stores information in several different
    /// workspaces, some being user private, some shared, and some public.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/pim/space#Workspace">ws:Workspace</a>
    /// </summary>
    let Workspace = _prefixId.prefix "Workspace"
    /// <summary>
    ///   <para>rdfs:label : master workspace</para>
    ///   <a href="http://www.w3.org/ns/pim/space#masterWorkspace">ws:masterWorkspace</a>
    /// </summary>
    let masterWorkspace = _prefixId.prefix "masterWorkspace"
    /// <summary>
    ///   <para>rdfs:label : preferences file^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/pim/space#preferencesFile">ws:preferencesFile</a>
    /// </summary>
    let preferencesFile = _prefixId.prefix "preferencesFile"
    /// <summary>
    ///   <para>rdfs:label : storage^^xsd:string</para>
    ///   <para>rdfs:comment : The storage in which this workspace is, or the storage which
    /// contains this resource, or a storage available to this agent to use.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/pim/space#storage">ws:storage</a>
    /// </summary>
    let storage = _prefixId.prefix "storage"
    /// <summary>
    ///   <para>ui:prompt : Give the first part of the URis in this workspace^^xsd:string</para>
    ///   <para>rdfs:label : URI prefix^^xsd:string</para>
    ///   <para>rdfs:comment : URIs which start with this string are in this workspace or storage.
    /// This may be used for constructing URIs for new storage resources.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/pim/space#uriPrefix">ws:uriPrefix</a>
    /// </summary>
    let uriPrefix = _prefixId.prefix "uriPrefix"
    /// <summary>
    ///   <para>rdfs:label : workspace</para>
    ///   <a href="http://www.w3.org/ns/pim/space#workspace">ws:workspace</a>
    /// </summary>
    let workspace = _prefixId.prefix "workspace"
