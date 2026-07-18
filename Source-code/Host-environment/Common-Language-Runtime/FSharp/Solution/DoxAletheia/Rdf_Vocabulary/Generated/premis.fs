namespace http.www.loc.gov.premis.rdf.v3.slash

open DoxAletheia.Rdf_Vocabulary

module premis =
    let _namespace_name = "http://www.loc.gov/premis/rdf/v3/"
    /// <summary>
    /// Operation type to perform on an Object. Effectively performing this action may produce an Event.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// Actor (human, machine, or software) associated with one or more Event and/or Rights
    ///       statement associated with a digital object.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// Contiguous or non-contiguous data within a file that has meaningful properties for
    ///       preservation purposes.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Bitstream"></see></summary>
    let Bitstream = Namespaced_IRI.parse _namespace_name "Bitstream" |> NamespacedName
    /// <summary>
    /// Discrete unit of information subject to digital preservation. Subclasses of Object are
    ///       Intellectual Entity, Representation, File and Bitstream.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// Named and ordered sequence of bytes that is known to an operating system.
    /// <see href="http://www.loc.gov/premis/rdf/v3/File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName

    /// <summary>
    /// A set of content that is considered a single intellectual unit for purposes of management and
    ///       description: for example, a particular book, map, photograph, database, or piece of hardware or
    ///       software. An Intellectual Entity can include other Intellectual Entities; for example, a web site can
    ///       include a web page; a web page can include an image. An Intellectual Entity may have one or more digital
    ///       representations. An Intellectual Entity may also describe an environment, defined as technology
    ///       supporting a digital object in some way (e.g. by rendering or executing it). Environments can consist of
    ///       software, hardware, or a combination of both.
    /// <see href="http://www.loc.gov/premis/rdf/v3/IntellectualEntity"></see></summary>
    let IntellectualEntity =
        Namespaced_IRI.parse _namespace_name "IntellectualEntity" |> NamespacedName

    /// <summary>
    /// Digital or physical Object instantiating or embodying an Intellectual Entity. A digital
    ///       representation is the set of stored digital files and structural metadata needed to provide a complete
    ///       and reasonable rendition of the Intellectual Entity. A physical representation is an item such as a
    ///       manuscript, video cassette, or printed document.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Representation"></see></summary>
    let Representation =
        Namespaced_IRI.parse _namespace_name "Representation" |> NamespacedName

    /// <summary>
    /// Copyright law.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Copyright"></see></summary>
    let Copyright = Namespaced_IRI.parse _namespace_name "Copyright" |> NamespacedName

    /// <summary>
    /// Designation of the basis for the right or permission governing the Object.
    /// <see href="http://www.loc.gov/premis/rdf/v3/RightsBasis"></see></summary>
    let RightsBasis =
        Namespaced_IRI.parse _namespace_name "RightsBasis" |> NamespacedName

    /// <summary>
    /// A policy decision made by an organization.
    /// <see href="http://www.loc.gov/premis/rdf/v3/InstitutionalPolicy"></see></summary>
    let InstitutionalPolicy =
        Namespaced_IRI.parse _namespace_name "InstitutionalPolicy" |> NamespacedName

    /// <summary>
    /// A license agreement or other legal document that grants rights.
    /// <see href="http://www.loc.gov/premis/rdf/v3/License"></see></summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName
    /// <summary>
    /// A law that grants or revokes rights, such as laws governing privacy or orphan
    ///       works.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Statute"></see></summary>
    let Statute = Namespaced_IRI.parse _namespace_name "Statute" |> NamespacedName
    /// <summary>
    /// Relationship where one Object requires another Object to support its function, delivery, or
    ///       the coherence of its content.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Dependency"></see></summary>
    let Dependency = Namespaced_IRI.parse _namespace_name "Dependency" |> NamespacedName

    /// <summary>
    /// An assessment of the extent to which the described environment supports its
    ///       purpose.
    /// <see href="http://www.loc.gov/premis/rdf/v3/EnvironmentCharacteristic"></see></summary>
    let EnvironmentCharacteristic =
        Namespaced_IRI.parse _namespace_name "EnvironmentCharacteristic" |> NamespacedName

    /// <summary>
    /// Action performed within or outside the repository that affects its capability to preserve Objects over the long term.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// Information used to verify whether an object has been altered in an undocumented or
    ///       unauthorized way.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Fixity"></see></summary>
    let Fixity = Namespaced_IRI.parse _namespace_name "Fixity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/HardwareAgent"></see>
    /// </summary>
    let HardwareAgent =
        Namespaced_IRI.parse _namespace_name "HardwareAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/Organization"></see>
    /// </summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/SoftwareAgent"></see>
    /// </summary>
    let SoftwareAgent =
        Namespaced_IRI.parse _namespace_name "SoftwareAgent" |> NamespacedName

    /// <summary>
    /// An unambiguous reference to the PREMIS entity within the preservation
    ///       repository.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Identifier"></see></summary>
    let Identifier = Namespaced_IRI.parse _namespace_name "Identifier" |> NamespacedName
    /// <summary>
    /// Feature of a Digital Object intended to inhibit access, copying, dissemination, or
    ///       migration. Common Inhibitors are encryption and password protection.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Inhibitor"></see></summary>
    let Inhibitor = Namespaced_IRI.parse _namespace_name "Inhibitor" |> NamespacedName

    /// <summary>
    /// Overall result of the Event in terms of success, partial success, or failure.
    /// <see href="http://www.loc.gov/premis/rdf/v3/OutcomeStatus"></see></summary>
    let OutcomeStatus =
        Namespaced_IRI.parse _namespace_name "OutcomeStatus" |> NamespacedName

    /// <summary>
    /// Information indicating the decision or policy on the set of preservation functions to be
    ///       applied to an object and the context in which the decision or policy was made. Note that in addition to
    ///       subclasses declared at presLevType, SignificantProperties is also a subclass of PreservationPolicy.
    ///       Implementers may also wish to create locally-defined subclasses.
    /// <see href="http://www.loc.gov/premis/rdf/v3/PreservationPolicy"></see></summary>
    let PreservationPolicy =
        Namespaced_IRI.parse _namespace_name "PreservationPolicy" |> NamespacedName

    /// <summary>
    /// Information about how a RightsBasis applies to a particular object.
    /// <see href="http://www.loc.gov/premis/rdf/v3/RightsStatus"></see></summary>
    let RightsStatus =
        Namespaced_IRI.parse _namespace_name "RightsStatus" |> NamespacedName

    /// <summary>
    /// Statement about the Actions an Agent is permitted to undertake or prohibited from
    ///       undertaking with respect to an Object.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Rule"></see></summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName
    /// <summary>
    /// Mathematical technique used to validate the authenticity and integrity of a message,
    ///       software or digital document.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Signature"></see></summary>
    let Signature = Namespaced_IRI.parse _namespace_name "Signature" |> NamespacedName

    /// <summary>
    /// Encoding used for the signature value and key information.
    /// <see href="http://www.loc.gov/premis/rdf/v3/SignatureEncoding"></see></summary>
    let SignatureEncoding =
        Namespaced_IRI.parse _namespace_name "SignatureEncoding" |> NamespacedName

    /// <summary>
    /// Characteristics of a particular object subjectively determined to be important to maintain
    ///       through preservation actions.
    /// <see href="http://www.loc.gov/premis/rdf/v3/SignificantProperties"></see></summary>
    let SignificantProperties =
        Namespaced_IRI.parse _namespace_name "SignificantProperties" |> NamespacedName

    /// <summary>
    /// Information needed to retrieve a physical item from its physical storage location or a file
    ///       from the storage system, or to access a bitstream within a file.
    /// <see href="http://www.loc.gov/premis/rdf/v3/StorageLocation"></see></summary>
    let StorageLocation =
        Namespaced_IRI.parse _namespace_name "StorageLocation" |> NamespacedName

    /// <summary>
    /// The physical medium on which the Object is stored (e.g., magnetic tape, hard disk, CD-ROM,
    ///       DVD).
    /// <see href="http://www.loc.gov/premis/rdf/v3/StorageMedium"></see></summary>
    let StorageMedium =
        Namespaced_IRI.parse _namespace_name "StorageMedium" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/act"></see>
    /// </summary>
    let act = Namespaced_IRI.parse _namespace_name "act" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/allows"></see>
    /// </summary>
    let allows = Namespaced_IRI.parse _namespace_name "allows" |> NamespacedName
    /// <summary>
    /// Links from a RightsStatus to the RightsBasis instance that supports or documents
    ///       it.
    /// <see href="http://www.loc.gov/premis/rdf/v3/basis"></see></summary>
    let basis = Namespaced_IRI.parse _namespace_name "basis" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/characteristic"></see>
    /// </summary>
    let characteristic =
        Namespaced_IRI.parse _namespace_name "characteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/citation"></see>
    /// </summary>
    let citation = Namespaced_IRI.parse _namespace_name "citation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/compositionLevel"></see>
    /// </summary>
    let compositionLevel =
        Namespaced_IRI.parse _namespace_name "compositionLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/dependency"></see>
    /// </summary>
    let dependency = Namespaced_IRI.parse _namespace_name "dependency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/determinationDate"></see>
    /// </summary>
    let determinationDate =
        Namespaced_IRI.parse _namespace_name "determinationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/documentation"></see>
    /// </summary>
    let documentation =
        Namespaced_IRI.parse _namespace_name "documentation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/encoding"></see>
    /// </summary>
    let encoding = Namespaced_IRI.parse _namespace_name "encoding" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/fixity"></see>
    /// </summary>
    let fixity = Namespaced_IRI.parse _namespace_name "fixity" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/governs"></see>
    /// </summary>
    let governs = Namespaced_IRI.parse _namespace_name "governs" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/identifier"></see>
    /// </summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/inhibitedBy"></see>
    /// </summary>
    let inhibitedBy =
        Namespaced_IRI.parse _namespace_name "inhibitedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/inhibits"></see>
    /// </summary>
    let inhibits = Namespaced_IRI.parse _namespace_name "inhibits" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/jurisdiction"></see>
    /// </summary>
    let jurisdiction =
        Namespaced_IRI.parse _namespace_name "jurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/key"></see>
    /// </summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/medium"></see>
    /// </summary>
    let medium = Namespaced_IRI.parse _namespace_name "medium" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/note"></see>
    /// </summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/originalName"></see>
    /// </summary>
    let originalName =
        Namespaced_IRI.parse _namespace_name "originalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/outcome"></see>
    /// </summary>
    let outcome = Namespaced_IRI.parse _namespace_name "outcome" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/outcomeNote"></see>
    /// </summary>
    let outcomeNote =
        Namespaced_IRI.parse _namespace_name "outcomeNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/policy"></see>
    /// </summary>
    let policy = Namespaced_IRI.parse _namespace_name "policy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/prohibits"></see>
    /// </summary>
    let prohibits = Namespaced_IRI.parse _namespace_name "prohibits" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/purpose"></see>
    /// </summary>
    let purpose = Namespaced_IRI.parse _namespace_name "purpose" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/rationale"></see>
    /// </summary>
    let rationale = Namespaced_IRI.parse _namespace_name "rationale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/relationship"></see>
    /// </summary>
    let relationship =
        Namespaced_IRI.parse _namespace_name "relationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/restriction"></see>
    /// </summary>
    let restriction =
        Namespaced_IRI.parse _namespace_name "restriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/rightsStatus"></see>
    /// </summary>
    let rightsStatus =
        Namespaced_IRI.parse _namespace_name "rightsStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/signature"></see>
    /// </summary>
    let signature = Namespaced_IRI.parse _namespace_name "signature" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/size"></see>
    /// </summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/startDate"></see>
    /// </summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/storedAt"></see>
    /// </summary>
    let storedAt = Namespaced_IRI.parse _namespace_name "storedAt" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/terms"></see>
    /// </summary>
    let terms = Namespaced_IRI.parse _namespace_name "terms" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/validationRules"></see>
    /// </summary>
    let validationRules =
        Namespaced_IRI.parse _namespace_name "validationRules" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
