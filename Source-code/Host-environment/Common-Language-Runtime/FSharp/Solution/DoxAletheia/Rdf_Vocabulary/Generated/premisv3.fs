namespace http.www.loc.gov.premis.rdf.v3.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module premisv3 =
    let _namespace_iri = Namespace_Iri premisv3 |> NamespaceIRI
    /// <summary>
    ///   <para>premisv3:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete unit of information subject to digital preservation. Subclasses of Object are
    ///       Intellectual Entity, Representation, File and Bitstream.</para>
    /// labels<para>Object</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Object">http://www.loc.gov/premis/rdf/v3/Object</seealso>
    let Object = Prefixed_Name(premisv3, "Object") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:RightsBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Designation of the basis for the right or permission governing the Object.</para>
    /// labels<para>Rights basis</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/RightsBasis">http://www.loc.gov/premis/rdf/v3/RightsBasis</seealso>
    let RightsBasis = Prefixed_Name(premisv3, "RightsBasis") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action performed within or outside the repository that affects its capability to preserve Objects over the long term.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Event">http://www.loc.gov/premis/rdf/v3/Event</seealso>
    let Event = Prefixed_Name(premisv3, "Event") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Operation type to perform on an Object. Effectively performing this action may produce an Event.</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Action">http://www.loc.gov/premis/rdf/v3/Action</seealso>
    let Action = Prefixed_Name(premisv3, "Action") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:PreservationPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information indicating the decision or policy on the set of preservation functions to be
    ///       applied to an object and the context in which the decision or policy was made. Note that in addition to
    ///       subclasses declared at presLevType, SignificantProperties is also a subclass of PreservationPolicy.
    ///       Implementers may also wish to create locally-defined subclasses.</para>
    /// labels<para>Preservation policy</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/PreservationPolicy">http://www.loc.gov/premis/rdf/v3/PreservationPolicy</seealso>
    let PreservationPolicy =
        Prefixed_Name(premisv3, "PreservationPolicy") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:RightsStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about how a RightsBasis applies to a particular object.</para>
    /// labels<para>Rights status</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/RightsStatus">http://www.loc.gov/premis/rdf/v3/RightsStatus</seealso>
    let RightsStatus = Prefixed_Name(premisv3, "RightsStatus") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Statement about the Actions an Agent is permitted to undertake or prohibited from
    ///       undertaking with respect to an Object.</para>
    /// labels<para>Rule</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Rule">http://www.loc.gov/premis/rdf/v3/Rule</seealso>
    let Rule = Prefixed_Name(premisv3, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:SignatureEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Encoding used for the signature value and key information.</para>
    /// labels<para>Signature encoding</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/SignatureEncoding">http://www.loc.gov/premis/rdf/v3/SignatureEncoding</seealso>
    let SignatureEncoding = Prefixed_Name(premisv3, "SignatureEncoding") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:StorageLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information needed to retrieve a physical item from its physical storage location or a file
    ///       from the storage system, or to access a bitstream within a file.</para>
    /// labels<para>Storage location</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/StorageLocation">http://www.loc.gov/premis/rdf/v3/StorageLocation</seealso>
    let StorageLocation = Prefixed_Name(premisv3, "StorageLocation") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:StorageMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The physical medium on which the Object is stored (e.g., magnetic tape, hard disk, CD-ROM,
    ///       DVD).</para>
    /// labels<para>Storage medium</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/StorageMedium">http://www.loc.gov/premis/rdf/v3/StorageMedium</seealso>
    let StorageMedium = Prefixed_Name(premisv3, "StorageMedium") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:basis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links from a RightsStatus to the RightsBasis instance that supports or documents
    ///       it.</para>
    /// labels<para>has basis</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/basis">http://www.loc.gov/premis/rdf/v3/basis</seealso>
    let basis = Prefixed_Name(premisv3, "basis") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:compositionLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has composition level</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/compositionLevel">http://www.loc.gov/premis/rdf/v3/compositionLevel</seealso>
    let compositionLevel = Prefixed_Name(premisv3, "compositionLevel") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Bitstream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contiguous or non-contiguous data within a file that has meaningful properties for
    ///       preservation purposes.</para>
    /// labels<para>Bitstream</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Bitstream">http://www.loc.gov/premis/rdf/v3/Bitstream</seealso>
    let Bitstream = Prefixed_Name(premisv3, "Bitstream") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Named and ordered sequence of bytes that is known to an operating system.</para>
    /// labels<para>File</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/File">http://www.loc.gov/premis/rdf/v3/File</seealso>
    let File = Prefixed_Name(premisv3, "File") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:IntellectualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of content that is considered a single intellectual unit for purposes of management and
    ///       description: for example, a particular book, map, photograph, database, or piece of hardware or
    ///       software. An Intellectual Entity can include other Intellectual Entities; for example, a web site can
    ///       include a web page; a web page can include an image. An Intellectual Entity may have one or more digital
    ///       representations. An Intellectual Entity may also describe an environment, defined as technology
    ///       supporting a digital object in some way (e.g. by rendering or executing it). Environments can consist of
    ///       software, hardware, or a combination of both.</para>
    /// labels<para>Intellectual entity</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/IntellectualEntity">http://www.loc.gov/premis/rdf/v3/IntellectualEntity</seealso>
    let IntellectualEntity =
        Prefixed_Name(premisv3, "IntellectualEntity") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:Copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Copyright law.</para>
    /// labels<para>Copyright</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Copyright">http://www.loc.gov/premis/rdf/v3/Copyright</seealso>
    let Copyright = Prefixed_Name(premisv3, "Copyright") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A license agreement or other legal document that grants rights.</para>
    /// labels<para>License</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/License">http://www.loc.gov/premis/rdf/v3/License</seealso>
    let License = Prefixed_Name(premisv3, "License") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Statute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A law that grants or revokes rights, such as laws governing privacy or orphan
    ///       works.</para>
    /// labels<para>Statute</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Statute">http://www.loc.gov/premis/rdf/v3/Statute</seealso>
    let Statute = Prefixed_Name(premisv3, "Statute") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Fixity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information used to verify whether an object has been altered in an undocumented or
    ///       unauthorized way.</para>
    /// labels<para>Fixity</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Fixity">http://www.loc.gov/premis/rdf/v3/Fixity</seealso>
    let Fixity = Prefixed_Name(premisv3, "Fixity") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:HardwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hardware agent</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/HardwareAgent">http://www.loc.gov/premis/rdf/v3/HardwareAgent</seealso>
    let HardwareAgent = Prefixed_Name(premisv3, "HardwareAgent") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:SoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Software agent</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/SoftwareAgent">http://www.loc.gov/premis/rdf/v3/SoftwareAgent</seealso>
    let SoftwareAgent = Prefixed_Name(premisv3, "SoftwareAgent") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Actor (human, machine, or software) associated with one or more Event and/or Rights
    ///       statement associated with a digital object.</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Agent">http://www.loc.gov/premis/rdf/v3/Agent</seealso>
    let Agent = Prefixed_Name(premisv3, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:OutcomeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Overall result of the Event in terms of success, partial success, or failure.</para>
    /// labels<para>Outcome status</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/OutcomeStatus">http://www.loc.gov/premis/rdf/v3/OutcomeStatus</seealso>
    let OutcomeStatus = Prefixed_Name(premisv3, "OutcomeStatus") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has jurisdiction</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/jurisdiction">http://www.loc.gov/premis/rdf/v3/jurisdiction</seealso>
    let jurisdiction = Prefixed_Name(premisv3, "jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Digital or physical Object instantiating or embodying an Intellectual Entity. A digital
    ///       representation is the set of stored digital files and structural metadata needed to provide a complete
    ///       and reasonable rendition of the Intellectual Entity. A physical representation is an item such as a
    ///       manuscript, video cassette, or printed document.</para>
    /// labels<para>Representation</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Representation">http://www.loc.gov/premis/rdf/v3/Representation</seealso>
    let Representation = Prefixed_Name(premisv3, "Representation") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relationship where one Object requires another Object to support its function, delivery, or
    ///       the coherence of its content.</para>
    /// labels<para>Dependency</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Dependency">http://www.loc.gov/premis/rdf/v3/Dependency</seealso>
    let Dependency = Prefixed_Name(premisv3, "Dependency") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:EnvironmentCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An assessment of the extent to which the described environment supports its
    ///       purpose.</para>
    /// labels<para>Environment characteristic</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/EnvironmentCharacteristic">http://www.loc.gov/premis/rdf/v3/EnvironmentCharacteristic</seealso>
    let EnvironmentCharacteristic =
        Prefixed_Name(premisv3, "EnvironmentCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Organization">http://www.loc.gov/premis/rdf/v3/Organization</seealso>
    let Organization = Prefixed_Name(premisv3, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:prohibits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>prohibits</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/prohibits">http://www.loc.gov/premis/rdf/v3/prohibits</seealso>
    let prohibits = Prefixed_Name(premisv3, "prohibits") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has relationship</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/relationship">http://www.loc.gov/premis/rdf/v3/relationship</seealso>
    let relationship = Prefixed_Name(premisv3, "relationship") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has restriction</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/restriction">http://www.loc.gov/premis/rdf/v3/restriction</seealso>
    let restriction = Prefixed_Name(premisv3, "restriction") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:rightsStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has rights status</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/rightsStatus">http://www.loc.gov/premis/rdf/v3/rightsStatus</seealso>
    let rightsStatus = Prefixed_Name(premisv3, "rightsStatus") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has size</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/size">http://www.loc.gov/premis/rdf/v3/size</seealso>
    let size = Prefixed_Name(premisv3, "size") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>start date</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/startDate">http://www.loc.gov/premis/rdf/v3/startDate</seealso>
    let startDate = Prefixed_Name(premisv3, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:storedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>stored at</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/storedAt">http://www.loc.gov/premis/rdf/v3/storedAt</seealso>
    let storedAt = Prefixed_Name(premisv3, "storedAt") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:validationRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has validation rules</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/validationRules">http://www.loc.gov/premis/rdf/v3/validationRules</seealso>
    let validationRules = Prefixed_Name(premisv3, "validationRules") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:signature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has signature</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/signature">http://www.loc.gov/premis/rdf/v3/signature</seealso>
    let signature = Prefixed_Name(premisv3, "signature") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:terms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has terms</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/terms">http://www.loc.gov/premis/rdf/v3/terms</seealso>
    let terms = Prefixed_Name(premisv3, "terms") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has version</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/version">http://www.loc.gov/premis/rdf/v3/version</seealso>
    let version = Prefixed_Name(premisv3, "version") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Person">http://www.loc.gov/premis/rdf/v3/Person</seealso>
    let Person = Prefixed_Name(premisv3, "Person") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Inhibitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Feature of a Digital Object intended to inhibit access, copying, dissemination, or
    ///       migration. Common Inhibitors are encryption and password protection.</para>
    /// labels<para>Inhibitor</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Inhibitor">http://www.loc.gov/premis/rdf/v3/Inhibitor</seealso>
    let Inhibitor = Prefixed_Name(premisv3, "Inhibitor") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An unambiguous reference to the PREMIS entity within the preservation
    ///       repository.</para>
    /// labels<para>Identifier</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Identifier">http://www.loc.gov/premis/rdf/v3/Identifier</seealso>
    let Identifier = Prefixed_Name(premisv3, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:Signature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mathematical technique used to validate the authenticity and integrity of a message,
    ///       software or digital document.</para>
    /// labels<para>Signature</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/Signature">http://www.loc.gov/premis/rdf/v3/Signature</seealso>
    let Signature = Prefixed_Name(premisv3, "Signature") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:SignificantProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Characteristics of a particular object subjectively determined to be important to maintain
    ///       through preservation actions.</para>
    /// labels<para>Significant properties</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/SignificantProperties">http://www.loc.gov/premis/rdf/v3/SignificantProperties</seealso>
    let SignificantProperties =
        Prefixed_Name(premisv3, "SignificantProperties") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:allows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>allows</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/allows">http://www.loc.gov/premis/rdf/v3/allows</seealso>
    let allows = Prefixed_Name(premisv3, "allows") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has citation</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/citation">http://www.loc.gov/premis/rdf/v3/citation</seealso>
    let citation = Prefixed_Name(premisv3, "citation") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:determinationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has determination date</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/determinationDate">http://www.loc.gov/premis/rdf/v3/determinationDate</seealso>
    let determinationDate = Prefixed_Name(premisv3, "determinationDate") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has documentation</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/documentation">http://www.loc.gov/premis/rdf/v3/documentation</seealso>
    let documentation = Prefixed_Name(premisv3, "documentation") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:act</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>act</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/act">http://www.loc.gov/premis/rdf/v3/act</seealso>
    let act = Prefixed_Name(premisv3, "act") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:characteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has characteristic</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/characteristic">http://www.loc.gov/premis/rdf/v3/characteristic</seealso>
    let characteristic = Prefixed_Name(premisv3, "characteristic") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has dependency</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/dependency">http://www.loc.gov/premis/rdf/v3/dependency</seealso>
    let dependency = Prefixed_Name(premisv3, "dependency") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>end date</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/endDate">http://www.loc.gov/premis/rdf/v3/endDate</seealso>
    let endDate = Prefixed_Name(premisv3, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:fixity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has fixity</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/fixity">http://www.loc.gov/premis/rdf/v3/fixity</seealso>
    let fixity = Prefixed_Name(premisv3, "fixity") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:governs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>governs</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/governs">http://www.loc.gov/premis/rdf/v3/governs</seealso>
    let governs = Prefixed_Name(premisv3, "governs") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:inhibitedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inhibited by</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/inhibitedBy">http://www.loc.gov/premis/rdf/v3/inhibitedBy</seealso>
    let inhibitedBy = Prefixed_Name(premisv3, "inhibitedBy") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:inhibits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inhibits</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/inhibits">http://www.loc.gov/premis/rdf/v3/inhibits</seealso>
    let inhibits = Prefixed_Name(premisv3, "inhibits") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has key</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/key">http://www.loc.gov/premis/rdf/v3/key</seealso>
    let key = Prefixed_Name(premisv3, "key") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has medium</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/medium">http://www.loc.gov/premis/rdf/v3/medium</seealso>
    let medium = Prefixed_Name(premisv3, "medium") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has note</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/note">http://www.loc.gov/premis/rdf/v3/note</seealso>
    let note = Prefixed_Name(premisv3, "note") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:originalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has original name</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/originalName">http://www.loc.gov/premis/rdf/v3/originalName</seealso>
    let originalName = Prefixed_Name(premisv3, "originalName") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:outcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has outcome</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/outcome">http://www.loc.gov/premis/rdf/v3/outcome</seealso>
    let outcome = Prefixed_Name(premisv3, "outcome") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:outcomeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has outcome note</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/outcomeNote">http://www.loc.gov/premis/rdf/v3/outcomeNote</seealso>
    let outcomeNote = Prefixed_Name(premisv3, "outcomeNote") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has policy</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/policy">http://www.loc.gov/premis/rdf/v3/policy</seealso>
    let policy = Prefixed_Name(premisv3, "policy") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has purpose</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/purpose">http://www.loc.gov/premis/rdf/v3/purpose</seealso>
    let purpose = Prefixed_Name(premisv3, "purpose") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:rationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has rationale</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/rationale">http://www.loc.gov/premis/rdf/v3/rationale</seealso>
    let rationale = Prefixed_Name(premisv3, "rationale") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has encoding</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/encoding">http://www.loc.gov/premis/rdf/v3/encoding</seealso>
    let encoding = Prefixed_Name(premisv3, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has identifier</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/identifier">http://www.loc.gov/premis/rdf/v3/identifier</seealso>
    let identifier = Prefixed_Name(premisv3, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>premisv3:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Ontology for PREMIS 3, the international standard
    ///       for metadata to support the preservation of digital objects and ensure their
    ///       long-term usability.</para>
    /// labels<para>PREMIS 3 Ontology</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/">http://www.loc.gov/premis/rdf/v3/</seealso>
    let _prefix_iri = Prefixed_Name(premisv3, "") |> PrefixedName

    /// <summary>
    ///   <para>premisv3:InstitutionalPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A policy decision made by an organization.</para>
    /// labels<para>Institutional policy</para></remarks>
    /// <seealso href="http://www.loc.gov/premis/rdf/v3/InstitutionalPolicy">http://www.loc.gov/premis/rdf/v3/InstitutionalPolicy</seealso>
    let InstitutionalPolicy =
        Prefixed_Name(premisv3, "InstitutionalPolicy") |> PrefixedName
