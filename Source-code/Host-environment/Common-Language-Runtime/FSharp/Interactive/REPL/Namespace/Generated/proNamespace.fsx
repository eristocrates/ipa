#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pro =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/pro/" "pro"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A role an agent may have with respect to the publishing process.  Individual members of this class are used to specify particular roles.</para>
    ///   <para>rdfs:label : publishing role</para>
    ///   <a href="http://purl.org/spar/pro/PublishingRole">pro:PublishingRole</a>
    /// </summary>
    let PublishingRole = _prefixId.prefix "PublishingRole"
    /// <summary>
    ///   <para>rdfs:comment : A role an agent may have.  Individual members of this class or its sub-classes are used to specify particular roles.</para>
    ///   <para>rdfs:label : role</para>
    ///   <a href="http://purl.org/spar/pro/Role">pro:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>dce:description : A role in time describes always:
    /// - a particular role R
    /// - a particular agent A holding R
    /// - a particular time interval T in which A holds R (optional)
    /// - one or more entities (e.g. a particular bibliographic entity or a specific institution) that defines a context for R held by A. (At least one contextual entity should be specified for a particular role).</para>
    ///   <para>rdfs:comment : A particular situation that describe a role an agent may have, that can be restricted to a particular time interval.</para>
    ///   <para>rdfs:label : role in time</para>
    ///   <a href="http://purl.org/spar/pro/RoleInTime">pro:RoleInTime</a>
    /// </summary>
    let RoleInTime = _prefixId.prefix "RoleInTime"
    let archivist = _prefixId.prefix "archivist"
    let author = _prefixId.prefix "author"
    let authors_agent = _prefixId.prefix "authors-agent"
    let biographer = _prefixId.prefix "biographer"
    let blogger = _prefixId.prefix "blogger"
    let commissioning_editor = _prefixId.prefix "commissioning-editor"
    let compiler = _prefixId.prefix "compiler"
    let contributor = _prefixId.prefix "contributor"
    let copy_editor = _prefixId.prefix "copy-editor"
    let copyright_owner = _prefixId.prefix "copyright-owner"
    let critic = _prefixId.prefix "critic"
    let deputy_editor = _prefixId.prefix "deputy-editor"
    let distributor = _prefixId.prefix "distributor"
    let editor = _prefixId.prefix "editor"
    let editor_in_chief = _prefixId.prefix "editor-in-chief"
    let executive_editor = _prefixId.prefix "executive-editor"
    let ghost_writer = _prefixId.prefix "ghost-writer"
    let guest_editor = _prefixId.prefix "guest-editor"
    /// <summary>
    ///   <para>rdfs:comment : A property relating an agent to a role that the agent holds.  This is done via the indirection: foaf:Agent pro:holdsRoleInTime [ a pro:RoleInTime ; pro:withRole pro:Role ] .  The ontology permits one to specify the time period over which a role is held, and the other contextual entities to which that agent's role relates.</para>
    ///   <para>rdfs:label : holds role in time</para>
    ///   <a href="http://purl.org/spar/pro/holdsRoleInTime">pro:holdsRoleInTime</a>
    /// </summary>
    let holdsRoleInTime = _prefixId.prefix "holdsRoleInTime"
    let illustrator = _prefixId.prefix "illustrator"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a document to the role for which that document provides the context (e.g. relating a document to the role of author or peer-reviewer of that document).</para>
    ///   <para>rdfs:label : is document context for</para>
    ///   <a href="http://purl.org/spar/pro/isDocumentContextFor">pro:isDocumentContextFor</a>
    /// </summary>
    let isDocumentContextFor = _prefixId.prefix "isDocumentContextFor"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a role in time that an agent holds, or a contribution situation that an agent makes, to that agent.</para>
    ///   <para>rdfs:label : is role held by</para>
    ///   <a href="http://purl.org/spar/pro/isHeldBy">pro:isHeldBy</a>
    /// </summary>
    let isHeldBy = _prefixId.prefix "isHeldBy"
    /// <summary>
    ///   <para>rdfs:comment : A property relating an organization to the role for which that organization provides the context (e.g. relating an institution to the role of member held by a person).</para>
    ///   <para>rdfs:label : is organization context for</para>
    ///   <a href="http://purl.org/spar/pro/isOrganizationContextFor">pro:isOrganizationContextFor</a>
    /// </summary>
    let isOrganizationContextFor = _prefixId.prefix "isOrganizationContextFor"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a person to the role for which that person provides the context (e.g. relating a graduate student to the role of supervisor held by a faculty member).</para>
    ///   <para>rdfs:label : is person context for</para>
    ///   <a href="http://purl.org/spar/pro/isPersonContextFor">pro:isPersonContextFor</a>
    /// </summary>
    let isPersonContextFor = _prefixId.prefix "isPersonContextFor"
    /// <summary>
    ///   <para>rdfs:comment : A property relating an entity to the role for which that entity provides the context.</para>
    ///   <para>rdfs:label : is related to role in time</para>
    ///   <a href="http://purl.org/spar/pro/isRelatedToRoleInTime">pro:isRelatedToRoleInTime</a>
    /// </summary>
    let isRelatedToRoleInTime = _prefixId.prefix "isRelatedToRoleInTime"
    /// <summary>
    ///   <para>rdfs:comment : The property relating the definition of a specific role to the situation of an agent holding that role.</para>
    ///   <para>rdfs:label : is role in</para>
    ///   <a href="http://purl.org/spar/pro/isRoleIn">pro:isRoleIn</a>
    /// </summary>
    let isRoleIn = _prefixId.prefix "isRoleIn"
    let journalist = _prefixId.prefix "journalist"
    let librarian = _prefixId.prefix "librarian"
    let managing_editor = _prefixId.prefix "managing-editor"
    let peer_reviewer = _prefixId.prefix "peer-reviewer"
    let printer = _prefixId.prefix "printer"
    let producer = _prefixId.prefix "producer"
    let production_editor = _prefixId.prefix "production-editor"
    let proof_reader = _prefixId.prefix "proof-reader"
    let publisher = _prefixId.prefix "publisher"
    let reader = _prefixId.prefix "reader"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a time-indexed situation describing a publishing role to a document that represents the context for that situation (e.g. relating the role of editor or peer-reviewer to the document being edited or peer-reviewed).</para>
    ///   <para>rdfs:label : relates to document</para>
    ///   <a href="http://purl.org/spar/pro/relatesToDocument">pro:relatesToDocument</a>
    /// </summary>
    let relatesToDocument = _prefixId.prefix "relatesToDocument"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a time-indexed situation to an entity representing the context for that situation.</para>
    ///   <para>rdfs:label : relates to</para>
    ///   <a href="http://purl.org/spar/pro/relatesToEntity">pro:relatesToEntity</a>
    /// </summary>
    let relatesToEntity = _prefixId.prefix "relatesToEntity"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a time-indexed situation to an organization that represents the context for that situation (e.g. relating the role of member to the institution of which that person is a member).</para>
    ///   <para>rdfs:label : relates to organization</para>
    ///   <a href="http://purl.org/spar/pro/relatesToOrganization">pro:relatesToOrganization</a>
    /// </summary>
    let relatesToOrganization = _prefixId.prefix "relatesToOrganization"
    /// <summary>
    ///   <para>rdfs:comment : A property relating a time-indexed situation to a person who represents the context for that situation (e.g. relating the role of an supervisor with respect to the graduate student being supervised).</para>
    ///   <para>rdfs:label : relates to person</para>
    ///   <a href="http://purl.org/spar/pro/relatesToPerson">pro:relatesToPerson</a>
    /// </summary>
    let relatesToPerson = _prefixId.prefix "relatesToPerson"
    let reviewer = _prefixId.prefix "reviewer"
    let senior_editor = _prefixId.prefix "senior-editor"
    let series_editor = _prefixId.prefix "series-editor"
    let translator = _prefixId.prefix "translator"
    /// <summary>
    ///   <para>rdfs:comment : An object property connecting an agent's role in time to a definition of the type of role held by this agent, specified as an instance of the class pro:Role or of one of its sub-classes.</para>
    ///   <para>rdfs:label : with role</para>
    ///   <a href="http://purl.org/spar/pro/withRole">pro:withRole</a>
    /// </summary>
    let withRole = _prefixId.prefix "withRole"
