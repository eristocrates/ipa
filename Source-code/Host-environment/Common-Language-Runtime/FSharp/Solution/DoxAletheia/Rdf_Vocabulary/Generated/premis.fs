namespace http.www.loc.gov.premis.rdf.v3.slash

open DoxAletheia

module premis =
    let _namespace_name = "http://www.loc.gov/premis/rdf/v3/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Operation type to perform on an Object. Effectively performing this action may produce an Event.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Actor (human, machine, or software) associated with one or more Event and/or Rights
    ///       statement associated with a digital object.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Contiguous or non-contiguous data within a file that has meaningful properties for
    ///       preservation purposes.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Bitstream"></see></summary>
    let Bitstream = _prefix "Bitstream"
    /// <summary>
    /// Discrete unit of information subject to digital preservation. Subclasses of Object are
    ///       Intellectual Entity, Representation, File and Bitstream.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// Named and ordered sequence of bytes that is known to an operating system.
    /// <see href="http://www.loc.gov/premis/rdf/v3/File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    /// A set of content that is considered a single intellectual unit for purposes of management and
    ///       description: for example, a particular book, map, photograph, database, or piece of hardware or
    ///       software. An Intellectual Entity can include other Intellectual Entities; for example, a web site can
    ///       include a web page; a web page can include an image. An Intellectual Entity may have one or more digital
    ///       representations. An Intellectual Entity may also describe an environment, defined as technology
    ///       supporting a digital object in some way (e.g. by rendering or executing it). Environments can consist of
    ///       software, hardware, or a combination of both.
    /// <see href="http://www.loc.gov/premis/rdf/v3/IntellectualEntity"></see></summary>
    let IntellectualEntity = _prefix "IntellectualEntity"
    /// <summary>
    /// Digital or physical Object instantiating or embodying an Intellectual Entity. A digital
    ///       representation is the set of stored digital files and structural metadata needed to provide a complete
    ///       and reasonable rendition of the Intellectual Entity. A physical representation is an item such as a
    ///       manuscript, video cassette, or printed document.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Representation"></see></summary>
    let Representation = _prefix "Representation"
    /// <summary>
    /// Copyright law.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Copyright"></see></summary>
    let Copyright = _prefix "Copyright"
    /// <summary>
    /// Designation of the basis for the right or permission governing the Object.
    /// <see href="http://www.loc.gov/premis/rdf/v3/RightsBasis"></see></summary>
    let RightsBasis = _prefix "RightsBasis"
    /// <summary>
    /// A policy decision made by an organization.
    /// <see href="http://www.loc.gov/premis/rdf/v3/InstitutionalPolicy"></see></summary>
    let InstitutionalPolicy = _prefix "InstitutionalPolicy"
    /// <summary>
    /// A license agreement or other legal document that grants rights.
    /// <see href="http://www.loc.gov/premis/rdf/v3/License"></see></summary>
    let License = _prefix "License"
    /// <summary>
    /// A law that grants or revokes rights, such as laws governing privacy or orphan
    ///       works.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Statute"></see></summary>
    let Statute = _prefix "Statute"
    /// <summary>
    /// Relationship where one Object requires another Object to support its function, delivery, or
    ///       the coherence of its content.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Dependency"></see></summary>
    let Dependency = _prefix "Dependency"
    /// <summary>
    /// An assessment of the extent to which the described environment supports its
    ///       purpose.
    /// <see href="http://www.loc.gov/premis/rdf/v3/EnvironmentCharacteristic"></see></summary>
    let EnvironmentCharacteristic = _prefix "EnvironmentCharacteristic"
    /// <summary>
    /// Action performed within or outside the repository that affects its capability to preserve Objects over the long term.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Information used to verify whether an object has been altered in an undocumented or
    ///       unauthorized way.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Fixity"></see></summary>
    let Fixity = _prefix "Fixity"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/HardwareAgent"></see>
    /// </summary>
    let HardwareAgent = _prefix "HardwareAgent"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/Organization"></see>
    /// </summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/SoftwareAgent"></see>
    /// </summary>
    let SoftwareAgent = _prefix "SoftwareAgent"
    /// <summary>
    /// An unambiguous reference to the PREMIS entity within the preservation
    ///       repository.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// Feature of a Digital Object intended to inhibit access, copying, dissemination, or
    ///       migration. Common Inhibitors are encryption and password protection.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Inhibitor"></see></summary>
    let Inhibitor = _prefix "Inhibitor"
    /// <summary>
    /// Overall result of the Event in terms of success, partial success, or failure.
    /// <see href="http://www.loc.gov/premis/rdf/v3/OutcomeStatus"></see></summary>
    let OutcomeStatus = _prefix "OutcomeStatus"
    /// <summary>
    /// Information indicating the decision or policy on the set of preservation functions to be
    ///       applied to an object and the context in which the decision or policy was made. Note that in addition to
    ///       subclasses declared at presLevType, SignificantProperties is also a subclass of PreservationPolicy.
    ///       Implementers may also wish to create locally-defined subclasses.
    /// <see href="http://www.loc.gov/premis/rdf/v3/PreservationPolicy"></see></summary>
    let PreservationPolicy = _prefix "PreservationPolicy"
    /// <summary>
    /// Information about how a RightsBasis applies to a particular object.
    /// <see href="http://www.loc.gov/premis/rdf/v3/RightsStatus"></see></summary>
    let RightsStatus = _prefix "RightsStatus"
    /// <summary>
    /// Statement about the Actions an Agent is permitted to undertake or prohibited from
    ///       undertaking with respect to an Object.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Rule"></see></summary>
    let Rule = _prefix "Rule"
    /// <summary>
    /// Mathematical technique used to validate the authenticity and integrity of a message,
    ///       software or digital document.
    /// <see href="http://www.loc.gov/premis/rdf/v3/Signature"></see></summary>
    let Signature = _prefix "Signature"
    /// <summary>
    /// Encoding used for the signature value and key information.
    /// <see href="http://www.loc.gov/premis/rdf/v3/SignatureEncoding"></see></summary>
    let SignatureEncoding = _prefix "SignatureEncoding"
    /// <summary>
    /// Characteristics of a particular object subjectively determined to be important to maintain
    ///       through preservation actions.
    /// <see href="http://www.loc.gov/premis/rdf/v3/SignificantProperties"></see></summary>
    let SignificantProperties = _prefix "SignificantProperties"
    /// <summary>
    /// Information needed to retrieve a physical item from its physical storage location or a file
    ///       from the storage system, or to access a bitstream within a file.
    /// <see href="http://www.loc.gov/premis/rdf/v3/StorageLocation"></see></summary>
    let StorageLocation = _prefix "StorageLocation"
    /// <summary>
    /// The physical medium on which the Object is stored (e.g., magnetic tape, hard disk, CD-ROM,
    ///       DVD).
    /// <see href="http://www.loc.gov/premis/rdf/v3/StorageMedium"></see></summary>
    let StorageMedium = _prefix "StorageMedium"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/act"></see>
    /// </summary>
    let act = _prefix "act"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/allows"></see>
    /// </summary>
    let allows = _prefix "allows"
    /// <summary>
    /// Links from a RightsStatus to the RightsBasis instance that supports or documents
    ///       it.
    /// <see href="http://www.loc.gov/premis/rdf/v3/basis"></see></summary>
    let basis = _prefix "basis"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/characteristic"></see>
    /// </summary>
    let characteristic = _prefix "characteristic"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/citation"></see>
    /// </summary>
    let citation = _prefix "citation"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/compositionLevel"></see>
    /// </summary>
    let compositionLevel = _prefix "compositionLevel"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/dependency"></see>
    /// </summary>
    let dependency = _prefix "dependency"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/determinationDate"></see>
    /// </summary>
    let determinationDate = _prefix "determinationDate"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/documentation"></see>
    /// </summary>
    let documentation = _prefix "documentation"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/encoding"></see>
    /// </summary>
    let encoding = _prefix "encoding"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/fixity"></see>
    /// </summary>
    let fixity = _prefix "fixity"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/governs"></see>
    /// </summary>
    let governs = _prefix "governs"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/identifier"></see>
    /// </summary>
    let identifier = _prefix "identifier"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/inhibitedBy"></see>
    /// </summary>
    let inhibitedBy = _prefix "inhibitedBy"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/inhibits"></see>
    /// </summary>
    let inhibits = _prefix "inhibits"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/jurisdiction"></see>
    /// </summary>
    let jurisdiction = _prefix "jurisdiction"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/key"></see>
    /// </summary>
    let key = _prefix "key"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/medium"></see>
    /// </summary>
    let medium = _prefix "medium"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/originalName"></see>
    /// </summary>
    let originalName = _prefix "originalName"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/outcome"></see>
    /// </summary>
    let outcome = _prefix "outcome"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/outcomeNote"></see>
    /// </summary>
    let outcomeNote = _prefix "outcomeNote"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/policy"></see>
    /// </summary>
    let policy = _prefix "policy"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/prohibits"></see>
    /// </summary>
    let prohibits = _prefix "prohibits"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/purpose"></see>
    /// </summary>
    let purpose = _prefix "purpose"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/rationale"></see>
    /// </summary>
    let rationale = _prefix "rationale"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/relationship"></see>
    /// </summary>
    let relationship = _prefix "relationship"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/restriction"></see>
    /// </summary>
    let restriction = _prefix "restriction"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/rightsStatus"></see>
    /// </summary>
    let rightsStatus = _prefix "rightsStatus"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/signature"></see>
    /// </summary>
    let signature = _prefix "signature"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/size"></see>
    /// </summary>
    let size = _prefix "size"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/startDate"></see>
    /// </summary>
    let startDate = _prefix "startDate"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/storedAt"></see>
    /// </summary>
    let storedAt = _prefix "storedAt"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/terms"></see>
    /// </summary>
    let terms = _prefix "terms"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/validationRules"></see>
    /// </summary>
    let validationRules = _prefix "validationRules"
    /// <summary>
    ///   <see href="http://www.loc.gov/premis/rdf/v3/version"></see>
    /// </summary>
    let version = _prefix "version"
