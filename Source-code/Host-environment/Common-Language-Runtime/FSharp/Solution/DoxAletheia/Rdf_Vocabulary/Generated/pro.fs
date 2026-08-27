namespace http.purl.org.spar.pro.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pro =
    let _namespace_iri = Namespace_Iri pro |> NamespaceIRI
    /// <summary>
    ///   <para>pro:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This ontology is available at http://purl.org/spar/pro, and uses the namespace prefix pro."</para>
    ///   <para>"PRO, the Publishing Roles Ontology, is an ontology for describing roles in the publication process, or in other scholarly activities or situations, held by particular agent.  The role can be specified to exist over a defined period of time, and within a specific context, e.g. with respect to a particular document.
    ///
    /// PRO forms part of SPAR, a suite of Semantic Publishing and Referencing Ontologies.  Other SPAR ontologies are described at http://purl.org/spar/."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/pro/">http://purl.org/spar/pro/</seealso>
    let _prefix_iri = Prefixed_Name(pro, "") |> PrefixedName
    /// <summary>
    ///   <para>pro:PublishingRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A role an agent may have with respect to the publishing process.  Individual members of this class are used to specify particular roles."</para>
    /// labels<para>"publishing role"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/PublishingRole">http://purl.org/spar/pro/PublishingRole</seealso>
    let PublishingRole = Prefixed_Name(pro, "PublishingRole") |> PrefixedName
    /// <summary>
    ///   <para>pro:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A role an agent may have.  Individual members of this class or its sub-classes are used to specify particular roles."</para>
    /// labels<para>"role"</para><para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/Role">http://purl.org/spar/pro/Role</seealso>
    let Role = Prefixed_Name(pro, "Role") |> PrefixedName
    /// <summary>
    ///   <para>pro:RoleInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular situation that describe a role an agent may have, that can be restricted to a particular time interval."</para>
    /// labels<para>"role in time"</para><para>"Role In Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/RoleInTime">http://purl.org/spar/pro/RoleInTime</seealso>
    let RoleInTime = Prefixed_Name(pro, "RoleInTime") |> PrefixedName
    /// <summary>
    ///   <para>pro:archivist</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of a person who manages, undertakes and supervises the work of an archive.  [This term is typically used with respect to a document archive, whereas the term data curator is used with respect to a data archive.]"</para>
    /// labels<para>"archivist"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/archivist">http://purl.org/spar/pro/archivist</seealso>
    let archivist = Prefixed_Name(pro, "archivist") |> PrefixedName
    /// <summary>
    ///   <para>pro:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>scoro:AuthorshipRole</para>
    ///   <para>"The role a person has of authorship of some material (for example a document)."</para>
    /// labels<para>"author"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/author">http://purl.org/spar/pro/author</seealso>
    let author = Prefixed_Name(pro, "author") |> PrefixedName
    /// <summary>
    ///   <para>pro:authors-agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A person who finds work for professional authors, manages their contracts, and works to advance their careers, charging their clients as fees for their services a percentage of the money made from the authors' writings."</para>
    /// labels<para>"author's agent"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/authors-agent">http://purl.org/spar/pro/authors-agent</seealso>
    let authors_agent = Prefixed_Name(pro, "authors-agent") |> PrefixedName
    /// <summary>
    ///   <para>pro:biographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of an author who writes biographies."</para>
    /// labels<para>"biographer"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/biographer">http://purl.org/spar/pro/biographer</seealso>
    let biographer = Prefixed_Name(pro, "biographer") |> PrefixedName
    /// <summary>
    ///   <para>pro:blogger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of an author who writes blog posts."</para>
    /// labels<para>"blogger"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/blogger">http://purl.org/spar/pro/blogger</seealso>
    let blogger = Prefixed_Name(pro, "blogger") |> PrefixedName

    /// <summary>
    ///   <para>pro:commissioning-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of an editor who actively commissions authors to write books to be published by the publishing house for which the commissioning editor works."</para>
    /// labels<para>"commissioning editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/commissioning-editor">http://purl.org/spar/pro/commissioning-editor</seealso>
    let commissioning_editor =
        Prefixed_Name(pro, "commissioning-editor") |> PrefixedName

    /// <summary>
    ///   <para>pro:compiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role an agent has of compiling a number of items into a compilation or collection."</para>
    /// labels<para>"compiler"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/compiler">http://purl.org/spar/pro/compiler</seealso>
    let compiler = Prefixed_Name(pro, "compiler") |> PrefixedName
    /// <summary>
    ///   <para>pro:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role an agent has of contribution of some material (for example an article to a magazine)."</para>
    /// labels<para>"contributor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/contributor">http://purl.org/spar/pro/contributor</seealso>
    let contributor = Prefixed_Name(pro, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>pro:copy-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of an editor who undertakes alterations to the text of a document submitted for publication to improve the formatting, style and accuracy of text, or to bring the text into the house style of the publisher (e.g. Americanization of British spelling), without intentionally altering the substance or meaning of the text."</para>
    /// labels<para>"copy editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/copy-editor">http://purl.org/spar/pro/copy-editor</seealso>
    let copy_editor = Prefixed_Name(pro, "copy-editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:copyright-owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of owning the copyright to a publication, usually held by the author or by the publishing house that publishes the author's work."</para>
    /// labels<para>"copyright owner"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/copyright-owner">http://purl.org/spar/pro/copyright-owner</seealso>
    let copyright_owner = Prefixed_Name(pro, "copyright-owner") |> PrefixedName
    /// <summary>
    ///   <para>pro:critic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of an author who writes evaluations and criticisms of, for example, plays or other works of art."</para>
    /// labels<para>"critic"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/critic">http://purl.org/spar/pro/critic</seealso>
    let critic = Prefixed_Name(pro, "critic") |> PrefixedName
    /// <summary>
    ///   <para>pro:deputy-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of a senior editor of a publication who deputizes for the Editor-in-Chief."</para>
    /// labels<para>"deputy editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/deputy-editor">http://purl.org/spar/pro/deputy-editor</seealso>
    let deputy_editor = Prefixed_Name(pro, "deputy-editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of a person who distributes publications."</para>
    /// labels<para>"distributor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/distributor">http://purl.org/spar/pro/distributor</seealso>
    let distributor = Prefixed_Name(pro, "distributor") |> PrefixedName
    /// <summary>
    ///   <para>pro:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of a person who selects and prepares for publication material written and submitted by authors."</para>
    /// labels<para>"editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/editor">http://purl.org/spar/pro/editor</seealso>
    let editor = Prefixed_Name(pro, "editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:editor-in-chief</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of the person who has final responsibility for the editorial operations and policies for a particular publication."</para>
    /// labels<para>"editor-in-chief"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/editor-in-chief">http://purl.org/spar/pro/editor-in-chief</seealso>
    let editor_in_chief = Prefixed_Name(pro, "editor-in-chief") |> PrefixedName
    /// <summary>
    ///   <para>pro:executive-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of an editor who has executive responsibility for the production of particular publication, usually acting under the authority of the Editor-in-Chief."</para>
    /// labels<para>"executive editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/executive-editor">http://purl.org/spar/pro/executive-editor</seealso>
    let executive_editor = Prefixed_Name(pro, "executive-editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:ghost-writer</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of a professional writer who assists an aspiring author lacking authorship skills to write a book or article for publication, for example by helping the author to create grammatically correct and lucid prose, or who writes the book on behalf of the named author, without himself/herself claiming authorship."</para>
    /// labels<para>"ghost writer"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/ghost-writer">http://purl.org/spar/pro/ghost-writer</seealso>
    let ghost_writer = Prefixed_Name(pro, "ghost-writer") |> PrefixedName
    /// <summary>
    ///   <para>pro:guest-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of someone who is a guest editor, for example for a special themed issue of a journal."</para>
    /// labels<para>"guest editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/guest-editor">http://purl.org/spar/pro/guest-editor</seealso>
    let guest_editor = Prefixed_Name(pro, "guest-editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:holdsRoleInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating an agent to a role that the agent holds.  This is done via the indirection: foaf:Agent pro:holdsRoleInTime [ a pro:RoleInTime ; pro:withRole pro:Role ] .  The ontology permits one to specify the time period over which a role is held, and the other contextual entities to which that agent's role relates."</para>
    /// labels<para>"holds role in time"</para><para>"holds role in time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/holdsRoleInTime">http://purl.org/spar/pro/holdsRoleInTime</seealso>
    let holdsRoleInTime = Prefixed_Name(pro, "holdsRoleInTime") |> PrefixedName
    /// <summary>
    ///   <para>pro:illustrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of an agent that illustrates a document."</para>
    /// labels<para>"illustrator"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/illustrator">http://purl.org/spar/pro/illustrator</seealso>
    let illustrator = Prefixed_Name(pro, "illustrator") |> PrefixedName

    /// <summary>
    ///   <para>pro:isDocumentContextFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a document to the role for which that document provides the context (e.g. relating a document to the role of author or peer-reviewer of that document)."</para>
    /// labels<para>"is document context for"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/isDocumentContextFor">http://purl.org/spar/pro/isDocumentContextFor</seealso>
    let isDocumentContextFor =
        Prefixed_Name(pro, "isDocumentContextFor") |> PrefixedName

    /// <summary>
    ///   <para>pro:isHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a role in time that an agent holds, or a contribution situation that an agent makes, to that agent."</para>
    /// labels<para>"is role held by"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/isHeldBy">http://purl.org/spar/pro/isHeldBy</seealso>
    let isHeldBy = Prefixed_Name(pro, "isHeldBy") |> PrefixedName

    /// <summary>
    ///   <para>pro:isOrganizationContextFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating an organization to the role for which that organization provides the context (e.g. relating an institution to the role of member held by a person)."</para>
    /// labels<para>"is organization context for"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/isOrganizationContextFor">http://purl.org/spar/pro/isOrganizationContextFor</seealso>
    let isOrganizationContextFor =
        Prefixed_Name(pro, "isOrganizationContextFor") |> PrefixedName

    /// <summary>
    ///   <para>pro:isPersonContextFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a person to the role for which that person provides the context (e.g. relating a graduate student to the role of supervisor held by a faculty member)."</para>
    /// labels<para>"is person context for"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/isPersonContextFor">http://purl.org/spar/pro/isPersonContextFor</seealso>
    let isPersonContextFor = Prefixed_Name(pro, "isPersonContextFor") |> PrefixedName

    /// <summary>
    ///   <para>pro:isRelatedToRoleInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating an entity to the role for which that entity provides the context."</para>
    /// labels<para>"is related to role in time"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/isRelatedToRoleInTime">http://purl.org/spar/pro/isRelatedToRoleInTime</seealso>
    let isRelatedToRoleInTime =
        Prefixed_Name(pro, "isRelatedToRoleInTime") |> PrefixedName

    /// <summary>
    ///   <para>pro:isRoleIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property relating the definition of a specific role to the situation of an agent holding that role."</para>
    /// labels<para>"is role in"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/isRoleIn">http://purl.org/spar/pro/isRoleIn</seealso>
    let isRoleIn = Prefixed_Name(pro, "isRoleIn") |> PrefixedName
    /// <summary>
    ///   <para>pro:journalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of an author who writes newspaper or magazine news reports or articles."</para>
    /// labels<para>"journalist"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/journalist">http://purl.org/spar/pro/journalist</seealso>
    let journalist = Prefixed_Name(pro, "journalist") |> PrefixedName
    /// <summary>
    ///   <para>pro:librarian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of a person who manages, undertakes and supervises the work of a library."</para>
    /// labels<para>"librarian"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/librarian">http://purl.org/spar/pro/librarian</seealso>
    let librarian = Prefixed_Name(pro, "librarian") |> PrefixedName
    /// <summary>
    ///   <para>pro:managing-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of an editor who has management responsibility for the production of particular publication, usually acting under the authority of the Executive Editor and the Editor-in-Chief."</para>
    /// labels<para>"managing editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/managing-editor">http://purl.org/spar/pro/managing-editor</seealso>
    let managing_editor = Prefixed_Name(pro, "managing-editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:peer-reviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of an academic peer in evaluating a manuscript submitted by an author for publication as a journal article on behalf of the journal editor, or a conference paper on behalf of the conference programme committee, and in deciding whether it is suitable for acceptance, usually subject to revisions suggested by the peer-reviewer."</para>
    /// labels<para>"peer reviewer"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/peer-reviewer">http://purl.org/spar/pro/peer-reviewer</seealso>
    let peer_reviewer = Prefixed_Name(pro, "peer-reviewer") |> PrefixedName
    /// <summary>
    ///   <para>pro:printer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of an agent involved in printing documents, either a company providing printing services or an individual engaged in the process of printing documents."</para>
    /// labels<para>"printer"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/printer">http://purl.org/spar/pro/printer</seealso>
    let printer = Prefixed_Name(pro, "printer") |> PrefixedName
    /// <summary>
    ///   <para>pro:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of someone who acts as a producer."</para>
    /// labels<para>"producer"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/producer">http://purl.org/spar/pro/producer</seealso>
    let producer = Prefixed_Name(pro, "producer") |> PrefixedName
    /// <summary>
    ///   <para>pro:production-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of an editor who takes responsibility for the passage of a document through the various stages of the publication workflow from the submitted manuscript to the final publication, including responsibility for scheduling and budget."</para>
    /// labels<para>"production editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/production-editor">http://purl.org/spar/pro/production-editor</seealso>
    let production_editor = Prefixed_Name(pro, "production-editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:proof-reader</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of a person who reads the proofs of documents to detect any errors prior to final publication."</para>
    /// labels<para>"proof reader"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/proof-reader">http://purl.org/spar/pro/proof-reader</seealso>
    let proof_reader = Prefixed_Name(pro, "proof-reader") |> PrefixedName
    /// <summary>
    ///   <para>pro:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of a person or an organization that published material, or of a publisher's employee who has responsibility for such publications."</para>
    /// labels<para>"publisher"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/publisher">http://purl.org/spar/pro/publisher</seealso>
    let publisher = Prefixed_Name(pro, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>pro:reader</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of a person who reads publications."</para>
    /// labels<para>"reader"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/reader">http://purl.org/spar/pro/reader</seealso>
    let reader = Prefixed_Name(pro, "reader") |> PrefixedName
    /// <summary>
    ///   <para>pro:relatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"relates to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/relatesTo">http://purl.org/spar/pro/relatesTo</seealso>
    let relatesTo = Prefixed_Name(pro, "relatesTo") |> PrefixedName
    /// <summary>
    ///   <para>pro:relatesToDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a time-indexed situation describing a publishing role to a document that represents the context for that situation (e.g. relating the role of editor or peer-reviewer to the document being edited or peer-reviewed)."</para>
    /// labels<para>"relates to document"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/relatesToDocument">http://purl.org/spar/pro/relatesToDocument</seealso>
    let relatesToDocument = Prefixed_Name(pro, "relatesToDocument") |> PrefixedName
    /// <summary>
    ///   <para>pro:relatesToEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a time-indexed situation to an entity representing the context for that situation."</para>
    /// labels<para>"relates to"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/relatesToEntity">http://purl.org/spar/pro/relatesToEntity</seealso>
    let relatesToEntity = Prefixed_Name(pro, "relatesToEntity") |> PrefixedName

    /// <summary>
    ///   <para>pro:relatesToOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a time-indexed situation to an organization that represents the context for that situation (e.g. relating the role of member to the institution of which that person is a member)."</para>
    /// labels<para>"relates to organization"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/relatesToOrganization">http://purl.org/spar/pro/relatesToOrganization</seealso>
    let relatesToOrganization =
        Prefixed_Name(pro, "relatesToOrganization") |> PrefixedName

    /// <summary>
    ///   <para>pro:relatesToPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property relating a time-indexed situation to a person who represents the context for that situation (e.g. relating the role of an supervisor with respect to the graduate student being supervised)."</para>
    /// labels<para>"relates to person"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/relatesToPerson">http://purl.org/spar/pro/relatesToPerson</seealso>
    let relatesToPerson = Prefixed_Name(pro, "relatesToPerson") |> PrefixedName
    /// <summary>
    ///   <para>pro:reviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pro:PublishingRole</para>
    ///   <para>"The role of a person who subjects a publication to a written review and critical analysis of its content, scope and quality."</para>
    /// labels<para>"reviewer"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/reviewer">http://purl.org/spar/pro/reviewer</seealso>
    let reviewer = Prefixed_Name(pro, "reviewer") |> PrefixedName
    /// <summary>
    ///   <para>pro:senior-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of the person who has senior responsibility for the editorial operations and policies for a particular publication, usually acting under the authority of the Editor-in-Chief."</para>
    /// labels<para>"senior editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/senior-editor">http://purl.org/spar/pro/senior-editor</seealso>
    let senior_editor = Prefixed_Name(pro, "senior-editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:series-editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of the person who has editorial responsibility for publication series, for example a book series."</para>
    /// labels<para>"series editor"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/series-editor">http://purl.org/spar/pro/series-editor</seealso>
    let series_editor = Prefixed_Name(pro, "series-editor") |> PrefixedName
    /// <summary>
    ///   <para>pro:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>pro:PublishingRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The role of an agent that translates a document into another language."</para>
    /// labels<para>"translator"</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/translator">http://purl.org/spar/pro/translator</seealso>
    let translator = Prefixed_Name(pro, "translator") |> PrefixedName
    /// <summary>
    ///   <para>pro:withRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property connecting an agent's role in time to a definition of the type of role held by this agent, specified as an instance of the class pro:Role or of one of its sub-classes."</para>
    /// labels<para>"with role"</para><para>"with role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/pro/withRole">http://purl.org/spar/pro/withRole</seealso>
    let withRole = Prefixed_Name(pro, "withRole") |> PrefixedName
