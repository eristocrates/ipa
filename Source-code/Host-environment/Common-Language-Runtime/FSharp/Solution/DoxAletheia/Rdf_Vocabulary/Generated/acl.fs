namespace http.www.w3.org.ns.auth.acl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module acl =
    let _namespace_iri = Namespace_Iri acl |> NamespaceIRI
    /// <summary>
    ///   <para>acl:label</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#label">http://www.w3.org/ns/auth/acl#label</seealso>
    let label = Prefixed_Name(acl, "label") |> PrefixedName
    /// <summary>
    ///   <para>acl:Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Allows read/write access to the ACL for the resource(s)</para>
    /// labels<para>control</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#Control">http://www.w3.org/ns/auth/acl#Control</seealso>
    let Control = Prefixed_Name(acl, "Control") |> PrefixedName
    /// <summary>
    ///   <para>acl:accessControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Access Control file for this information resource.
    ///         This may of course be a virtual resorce implemented by the access control system.
    ///         Note also HTTP's header  Link:  foo.meta ;rel=meta can be used for this.</para>
    /// labels<para>access control</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#accessControl">http://www.w3.org/ns/auth/acl#accessControl</seealso>
    let accessControl = Prefixed_Name(acl, "accessControl") |> PrefixedName
    /// <summary>
    ///   <para>acl:defaultForNew</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A directory for which this authorization is used for new files in the directory.</para>
    /// labels<para>default access for new things in</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#defaultForNew">http://www.w3.org/ns/auth/acl#defaultForNew</seealso>
    let defaultForNew = Prefixed_Name(acl, "defaultForNew") |> PrefixedName
    /// <summary>
    ///   <para>acl:Write</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>write</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#Write">http://www.w3.org/ns/auth/acl#Write</seealso>
    let Write = Prefixed_Name(acl, "Write") |> PrefixedName
    /// <summary>
    ///   <para>acl:Read</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of read operations</para>
    /// labels<para>read</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#Read">http://www.w3.org/ns/auth/acl#Read</seealso>
    let Read = Prefixed_Name(acl, "Read") |> PrefixedName
    /// <summary>
    ///   <para>acl:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person or social entity to being given the right</para>
    /// labels<para>agent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#agent">http://www.w3.org/ns/auth/acl#agent</seealso>
    let agent = Prefixed_Name(acl, "agent") |> PrefixedName
    /// <summary>
    ///   <para>acl:agentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A class of persons or social entities to being given the right</para>
    /// labels<para>agent class</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#agentClass">http://www.w3.org/ns/auth/acl#agentClass</seealso>
    let agentClass = Prefixed_Name(acl, "agentClass") |> PrefixedName
    /// <summary>
    ///   <para>acl:accessToClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A class of information resources to which access is being granted.</para>
    /// labels<para>to all in</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#accessToClass">http://www.w3.org/ns/auth/acl#accessToClass</seealso>
    let accessToClass = Prefixed_Name(acl, "accessToClass") |> PrefixedName
    /// <summary>
    ///   <para>acl:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The person or other agent which owns this.
    ///     For example, the owner of a file in a filesystem.
    ///     There is a sense of right to control.   Typically defaults to the agent who craeted
    ///     something but can be changed.</para>
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#owner">http://www.w3.org/ns/auth/acl#owner</seealso>
    let owner = Prefixed_Name(acl, "owner") |> PrefixedName
    /// <summary>
    ///   <para>acl:mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A mode of access such as read or write.</para>
    /// labels<para>access mode</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#mode">http://www.w3.org/ns/auth/acl#mode</seealso>
    let mode = Prefixed_Name(acl, "mode") |> PrefixedName
    /// <summary>
    ///   <para>acl:Access</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Any kind of access to a resource. Don't use this, use R W and RW</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#Access">http://www.w3.org/ns/auth/acl#Access</seealso>
    let Access = Prefixed_Name(acl, "Access") |> PrefixedName
    /// <summary>
    ///   <para>acl:Append</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Append accesses are specific write access which only add information, and do not remove information.
    ///     For text files, for example, append access allows bytes to be added onto the end of the file.
    ///     For RDF graphs, Append access allows adds triples to the graph but does not remove any.
    ///     Append access is useful for dropbox functionality.
    ///     Dropbox can be used for link notification, which the information added is a notification
    ///     that a some link has been made elsewhere relevant to the given resource.
    ///     </para>
    /// labels<para>append</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#Append">http://www.w3.org/ns/auth/acl#Append</seealso>
    let Append = Prefixed_Name(acl, "Append") |> PrefixedName
    /// <summary>
    ///   <para>acl:Authorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An element of access control,
    ///     allowing agent to agents access of some kind to resources or classes of resources</para>
    /// labels<para>authorization</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#Authorization">http://www.w3.org/ns/auth/acl#Authorization</seealso>
    let Authorization = Prefixed_Name(acl, "Authorization") |> PrefixedName
    /// <summary>
    ///   <para>acl:accessTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The information resource to which access is being granted.</para>
    /// labels<para>to</para></remarks>
    /// <seealso href="http://www.w3.org/ns/auth/acl#accessTo">http://www.w3.org/ns/auth/acl#accessTo</seealso>
    let accessTo = Prefixed_Name(acl, "accessTo") |> PrefixedName
