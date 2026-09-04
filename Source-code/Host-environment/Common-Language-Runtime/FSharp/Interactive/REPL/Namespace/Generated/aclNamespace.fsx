#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module acl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/auth/acl#" "acl"
    /// <summary>
    ///   <para>acl:label : access</para>
    ///   <para>rdfs:comment : Any kind of access to a resource. Don't use this, use R W and RW^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#Access">acl:Access</a>
    /// </summary>
    let Access = _prefixId.prefix "Access"
    /// <summary>
    ///   <para>rdfs:label : append</para>
    ///   <para>rdfs:comment : Append accesses are specific write access which only add information, and do not remove information.
    ///     For text files, for example, append access allows bytes to be added onto the end of the file.
    ///     For RDF graphs, Append access allows adds triples to the graph but does not remove any.
    ///     Append access is useful for dropbox functionality.
    ///     Dropbox can be used for link notification, which the information added is a notification
    ///     that a some link has been made elsewhere relevant to the given resource.
    ///     ^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#Append">acl:Append</a>
    /// </summary>
    let Append = _prefixId.prefix "Append"
    /// <summary>
    ///   <para>rdfs:label : authorization^^xsd:string</para>
    ///   <para>rdfs:comment : An element of access control,
    ///     allowing agent to agents access of some kind to resources or classes of resources^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#Authorization">acl:Authorization</a>
    /// </summary>
    let Authorization = _prefixId.prefix "Authorization"
    /// <summary>
    ///   <para>rdfs:label : control</para>
    ///   <para>rdfs:comment : Allows read/write access to the ACL for the resource(s)^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#Control">acl:Control</a>
    /// </summary>
    let Control = _prefixId.prefix "Control"
    /// <summary>
    ///   <para>rdfs:label : read</para>
    ///   <para>rdfs:comment : The class of read operations^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#Read">acl:Read</a>
    /// </summary>
    let Read = _prefixId.prefix "Read"
    /// <summary>
    ///   <para>rdfs:label : write</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#Write">acl:Write</a>
    /// </summary>
    let Write = _prefixId.prefix "Write"
    /// <summary>
    ///   <para>rdfs:label : access control^^xsd:string</para>
    ///   <para>rdfs:comment : The Access Control file for this information resource.
    ///         This may of course be a virtual resorce implemented by the access control system.
    ///         Note also HTTP's header  Link:  foo.meta ;rel=meta can be used for this.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#accessControl">acl:accessControl</a>
    /// </summary>
    let accessControl = _prefixId.prefix "accessControl"
    /// <summary>
    ///   <para>rdfs:label : to^^xsd:string</para>
    ///   <para>rdfs:comment : The information resource to which access is being granted.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#accessTo">acl:accessTo</a>
    /// </summary>
    let accessTo = _prefixId.prefix "accessTo"
    /// <summary>
    ///   <para>rdfs:label : to all in^^xsd:string</para>
    ///   <para>rdfs:comment : A class of information resources to which access is being granted.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#accessToClass">acl:accessToClass</a>
    /// </summary>
    let accessToClass = _prefixId.prefix "accessToClass"
    /// <summary>
    ///   <para>rdfs:label : agent^^xsd:string</para>
    ///   <para>rdfs:comment : A person or social entity to being given the right^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#agent">acl:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>rdfs:label : agent class^^xsd:string</para>
    ///   <para>rdfs:comment : A class of persons or social entities to being given the right^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#agentClass">acl:agentClass</a>
    /// </summary>
    let agentClass = _prefixId.prefix "agentClass"
    /// <summary>
    ///   <para>rdfs:label : default access for new things in^^xsd:string</para>
    ///   <para>rdfs:comment : A directory for which this authorization is used for new files in the directory.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#defaultForNew">acl:defaultForNew</a>
    /// </summary>
    let defaultForNew = _prefixId.prefix "defaultForNew"
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : access mode^^xsd:string</para>
    ///   <para>rdfs:comment : A mode of access such as read or write.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#mode">acl:mode</a>
    /// </summary>
    let mode = _prefixId.prefix "mode"
    /// <summary>
    ///   <para>rdfs:label : owner</para>
    ///   <para>rdfs:comment : The person or other agent which owns this.
    ///     For example, the owner of a file in a filesystem.
    ///     There is a sense of right to control.   Typically defaults to the agent who craeted
    ///     something but can be changed.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/auth/acl#owner">acl:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
