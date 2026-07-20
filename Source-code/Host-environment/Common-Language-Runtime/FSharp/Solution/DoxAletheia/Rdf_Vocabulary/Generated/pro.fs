namespace http.purl.org.spar.pro.slash

open DoxAletheia

module pro =
    let _namespace_name = "http://purl.org/spar/pro/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A role an agent may have with respect to the publishing process.  Individual members of this class are used to specify particular roles.
    /// <see href="http://purl.org/spar/pro/PublishingRole"></see></summary>
    let PublishingRole = _prefix "PublishingRole"
    /// <summary>
    /// A role an agent may have.  Individual members of this class or its sub-classes are used to specify particular roles.
    /// <see href="http://purl.org/spar/pro/Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A particular situation that describe a role an agent may have, that can be restricted to a particular time interval.
    /// <see href="http://purl.org/spar/pro/RoleInTime"></see></summary>
    let RoleInTime = _prefix "RoleInTime"
    /// <summary>
    /// A property relating a role in time that an agent holds, or a contribution situation that an agent makes, to that agent.
    /// <see href="http://purl.org/spar/pro/isHeldBy"></see></summary>
    let isHeldBy = _prefix "isHeldBy"
    /// <summary>
    /// An object property connecting an agent's role in time to a definition of the type of role held by this agent, specified as an instance of the class pro:Role or of one of its sub-classes.
    /// <see href="http://purl.org/spar/pro/withRole"></see></summary>
    let withRole = _prefix "withRole"
    /// <summary>
    /// A property relating a time-indexed situation to an entity representing the context for that situation.
    /// <see href="http://purl.org/spar/pro/relatesToEntity"></see></summary>
    let relatesToEntity = _prefix "relatesToEntity"
    /// <summary>
    /// The role of a person who manages, undertakes and supervises the work of an archive.  [This term is typically used with respect to a document archive, whereas the term data curator is used with respect to a data archive.]
    /// <see href="http://purl.org/spar/pro/archivist"></see></summary>
    let archivist = _prefix "archivist"
    /// <summary>
    /// The role a person has of authorship of some material (for example a document).
    /// <see href="http://purl.org/spar/pro/author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// A person who finds work for professional authors, manages their contracts, and works to advance their careers, charging their clients as fees for their services a percentage of the money made from the authors' writings.
    /// <see href="http://purl.org/spar/pro/authors-agent"></see></summary>
    let ``authors-agent`` = _prefix "authors-agent"
    /// <summary>
    /// The role of an author who writes biographies.
    /// <see href="http://purl.org/spar/pro/biographer"></see></summary>
    let biographer = _prefix "biographer"
    /// <summary>
    /// The role of an author who writes blog posts.
    /// <see href="http://purl.org/spar/pro/blogger"></see></summary>
    let blogger = _prefix "blogger"
    /// <summary>
    /// The role of an editor who actively commissions authors to write books to be published by the publishing house for which the commissioning editor works.
    /// <see href="http://purl.org/spar/pro/commissioning-editor"></see></summary>
    let ``commissioning-editor`` = _prefix "commissioning-editor"
    /// <summary>
    /// The role an agent has of compiling a number of items into a compilation or collection.
    /// <see href="http://purl.org/spar/pro/compiler"></see></summary>
    let compiler = _prefix "compiler"
    /// <summary>
    /// The role an agent has of contribution of some material (for example an article to a magazine).
    /// <see href="http://purl.org/spar/pro/contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// The role of an editor who undertakes alterations to the text of a document submitted for publication to improve the formatting, style and accuracy of text, or to bring the text into the house style of the publisher (e.g. Americanization of British spelling), without intentionally altering the substance or meaning of the text.
    /// <see href="http://purl.org/spar/pro/copy-editor"></see></summary>
    let ``copy-editor`` = _prefix "copy-editor"
    /// <summary>
    /// The role of owning the copyright to a publication, usually held by the author or by the publishing house that publishes the author's work.
    /// <see href="http://purl.org/spar/pro/copyright-owner"></see></summary>
    let ``copyright-owner`` = _prefix "copyright-owner"
    /// <summary>
    /// The role of an author who writes evaluations and criticisms of, for example, plays or other works of art.
    /// <see href="http://purl.org/spar/pro/critic"></see></summary>
    let critic = _prefix "critic"
    /// <summary>
    /// The role of a person who subjects a publication to a written review and critical analysis of its content, scope and quality.
    /// <see href="http://purl.org/spar/pro/reviewer"></see></summary>
    let reviewer = _prefix "reviewer"
    /// <summary>
    /// The role of a senior editor of a publication who deputizes for the Editor-in-Chief.
    /// <see href="http://purl.org/spar/pro/deputy-editor"></see></summary>
    let ``deputy-editor`` = _prefix "deputy-editor"
    /// <summary>
    /// The role of a person who distributes publications.
    /// <see href="http://purl.org/spar/pro/distributor"></see></summary>
    let distributor = _prefix "distributor"
    /// <summary>
    /// The role of a person who selects and prepares for publication material written and submitted by authors.
    /// <see href="http://purl.org/spar/pro/editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// The role of the person who has final responsibility for the editorial operations and policies for a particular publication.
    /// <see href="http://purl.org/spar/pro/editor-in-chief"></see></summary>
    let ``editor-in-chief`` = _prefix "editor-in-chief"
    /// <summary>
    /// The role of an editor who has executive responsibility for the production of particular publication, usually acting under the authority of the Editor-in-Chief.
    /// <see href="http://purl.org/spar/pro/executive-editor"></see></summary>
    let ``executive-editor`` = _prefix "executive-editor"
    /// <summary>
    /// The role of a professional writer who assists an aspiring author lacking authorship skills to write a book or article for publication, for example by helping the author to create grammatically correct and lucid prose, or who writes the book on behalf of the named author, without himself/herself claiming authorship.
    /// <see href="http://purl.org/spar/pro/ghost-writer"></see></summary>
    let ``ghost-writer`` = _prefix "ghost-writer"
    /// <summary>
    /// The role of someone who is a guest editor, for example for a special themed issue of a journal.
    /// <see href="http://purl.org/spar/pro/guest-editor"></see></summary>
    let ``guest-editor`` = _prefix "guest-editor"
    /// <summary>
    /// A property relating an agent to a role that the agent holds.  This is done via the indirection: foaf:Agent pro:holdsRoleInTime [ a pro:RoleInTime ; pro:withRole pro:Role ] .  The ontology permits one to specify the time period over which a role is held, and the other contextual entities to which that agent's role relates.
    /// <see href="http://purl.org/spar/pro/holdsRoleInTime"></see></summary>
    let holdsRoleInTime = _prefix "holdsRoleInTime"
    /// <summary>
    /// The role of an agent that illustrates a document.
    /// <see href="http://purl.org/spar/pro/illustrator"></see></summary>
    let illustrator = _prefix "illustrator"
    /// <summary>
    /// A property relating a document to the role for which that document provides the context (e.g. relating a document to the role of author or peer-reviewer of that document).
    /// <see href="http://purl.org/spar/pro/isDocumentContextFor"></see></summary>
    let isDocumentContextFor = _prefix "isDocumentContextFor"
    /// <summary>
    /// A property relating an entity to the role for which that entity provides the context.
    /// <see href="http://purl.org/spar/pro/isRelatedToRoleInTime"></see></summary>
    let isRelatedToRoleInTime = _prefix "isRelatedToRoleInTime"
    /// <summary>
    /// A property relating a time-indexed situation describing a publishing role to a document that represents the context for that situation (e.g. relating the role of editor or peer-reviewer to the document being edited or peer-reviewed).
    /// <see href="http://purl.org/spar/pro/relatesToDocument"></see></summary>
    let relatesToDocument = _prefix "relatesToDocument"
    /// <summary>
    /// A property relating an organization to the role for which that organization provides the context (e.g. relating an institution to the role of member held by a person).
    /// <see href="http://purl.org/spar/pro/isOrganizationContextFor"></see></summary>
    let isOrganizationContextFor = _prefix "isOrganizationContextFor"
    /// <summary>
    /// A property relating a time-indexed situation to an organization that represents the context for that situation (e.g. relating the role of member to the institution of which that person is a member).
    /// <see href="http://purl.org/spar/pro/relatesToOrganization"></see></summary>
    let relatesToOrganization = _prefix "relatesToOrganization"
    /// <summary>
    /// A property relating a person to the role for which that person provides the context (e.g. relating a graduate student to the role of supervisor held by a faculty member).
    /// <see href="http://purl.org/spar/pro/isPersonContextFor"></see></summary>
    let isPersonContextFor = _prefix "isPersonContextFor"
    /// <summary>
    /// The property relating the definition of a specific role to the situation of an agent holding that role.
    /// <see href="http://purl.org/spar/pro/isRoleIn"></see></summary>
    let isRoleIn = _prefix "isRoleIn"
    /// <summary>
    /// The role of an author who writes newspaper or magazine news reports or articles.
    /// <see href="http://purl.org/spar/pro/journalist"></see></summary>
    let journalist = _prefix "journalist"
    /// <summary>
    /// The role of a person who manages, undertakes and supervises the work of a library.
    /// <see href="http://purl.org/spar/pro/librarian"></see></summary>
    let librarian = _prefix "librarian"
    /// <summary>
    /// The role of an editor who has management responsibility for the production of particular publication, usually acting under the authority of the Executive Editor and the Editor-in-Chief.
    /// <see href="http://purl.org/spar/pro/managing-editor"></see></summary>
    let ``managing-editor`` = _prefix "managing-editor"
    /// <summary>
    /// The role of an academic peer in evaluating a manuscript submitted by an author for publication as a journal article on behalf of the journal editor, or a conference paper on behalf of the conference programme committee, and in deciding whether it is suitable for acceptance, usually subject to revisions suggested by the peer-reviewer.
    /// <see href="http://purl.org/spar/pro/peer-reviewer"></see></summary>
    let ``peer-reviewer`` = _prefix "peer-reviewer"
    /// <summary>
    /// The role of an agent involved in printing documents, either a company providing printing services or an individual engaged in the process of printing documents.
    /// <see href="http://purl.org/spar/pro/printer"></see></summary>
    let printer = _prefix "printer"
    /// <summary>
    /// The role of someone who acts as a producer.
    /// <see href="http://purl.org/spar/pro/producer"></see></summary>
    let producer = _prefix "producer"
    /// <summary>
    /// The role of an editor who takes responsibility for the passage of a document through the various stages of the publication workflow from the submitted manuscript to the final publication, including responsibility for scheduling and budget.
    /// <see href="http://purl.org/spar/pro/production-editor"></see></summary>
    let ``production-editor`` = _prefix "production-editor"
    /// <summary>
    /// The role of a person who reads the proofs of documents to detect any errors prior to final publication.
    /// <see href="http://purl.org/spar/pro/proof-reader"></see></summary>
    let ``proof-reader`` = _prefix "proof-reader"
    /// <summary>
    /// The role of a person or an organization that published material, or of a publisher's employee who has responsibility for such publications.
    /// <see href="http://purl.org/spar/pro/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// The role of a person who reads publications.
    /// <see href="http://purl.org/spar/pro/reader"></see></summary>
    let reader = _prefix "reader"
    /// <summary>
    /// A property relating a time-indexed situation to a person who represents the context for that situation (e.g. relating the role of an supervisor with respect to the graduate student being supervised).
    /// <see href="http://purl.org/spar/pro/relatesToPerson"></see></summary>
    let relatesToPerson = _prefix "relatesToPerson"
    /// <summary>
    /// The role of the person who has senior responsibility for the editorial operations and policies for a particular publication, usually acting under the authority of the Editor-in-Chief.
    /// <see href="http://purl.org/spar/pro/senior-editor"></see></summary>
    let ``senior-editor`` = _prefix "senior-editor"
    /// <summary>
    /// The role of the person who has editorial responsibility for publication series, for example a book series.
    /// <see href="http://purl.org/spar/pro/series-editor"></see></summary>
    let ``series-editor`` = _prefix "series-editor"
    /// <summary>
    /// The role of an agent that translates a document into another language.
    /// <see href="http://purl.org/spar/pro/translator"></see></summary>
    let translator = _prefix "translator"
