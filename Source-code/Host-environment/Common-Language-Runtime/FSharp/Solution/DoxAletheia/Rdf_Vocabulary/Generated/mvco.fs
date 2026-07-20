namespace http.purl.oclc.org.NET.mvco.owl.hash

open DoxAletheia

module mvco =
    let _namespace_name = "http://purl.oclc.org/NET/mvco.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The exercise of a Right.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Role who has executed the Action
    /// <see href="http://purl.oclc.org/NET/mvco.owl#actedBy"></see></summary>
    let actedBy = _prefix "actedBy"
    /// <summary>
    /// Any person or legal entity in a Value-Chain connecting (and including) Creator and End-User.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// Types of IP Represented as Content: Work, Adaptation, Manifestation, Instance...
    /// <see href="http://purl.oclc.org/NET/mvco.owl#IPEntity"></see></summary>
    let IPEntity = _prefix "IPEntity"
    /// <summary>
    /// Authorisation from one RightsOwner to one or more Users to perform one or more Actions on a given IPEntity.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Permission"></see></summary>
    let Permission = _prefix "Permission"
    /// <summary>
    /// A Work that is derived from another Work
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Adaptation"></see></summary>
    let Adaptation = _prefix "Adaptation"
    /// <summary>
    /// The dependance of one IP Entity on another.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#resultedFrom"></see></summary>
    let resultedFrom = _prefix "resultedFrom"
    /// <summary>
    /// The Action of making an Adaptation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptation"></see></summary>
    let MakeAdaptation = _prefix "MakeAdaptation"
    /// <summary>
    /// The Action of concurrently performing/displaying two distinct IP Entities each for a different human sense e.g. text and audio or video and song
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Synchronise"></see></summary>
    let Synchronise = _prefix "Synchronise"
    /// <summary>
    /// A creation that retains intellectual or artistic attributes independently of its Manifestations
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Work"></see></summary>
    let Work = _prefix "Work"
    /// <summary>
    /// An object or event which is an expression of a Work.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Manifestation"></see></summary>
    let Manifestation = _prefix "Manifestation"
    /// <summary>
    /// An object or event which is an example of an Identified Manifestation (e.g. a File)
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Instance"></see></summary>
    let Instance = _prefix "Instance"
    /// <summary>
    /// A mechanical reproduction of analogue or digital representations of a given IP Entity. In the case of digital Copies the result is virtually identical  while in the case of analogue Copies the results can vary considerably in quality.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Copy"></see></summary>
    let Copy = _prefix "Copy"
    /// <summary>
    /// A Content Item that adds value to IP Entities by including them with an appropriate Licence for the purpose of Publishing
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    /// An object or event which is an example of an Identified Adaptation Manifestation (e.g. a File)
    /// <see href="http://purl.oclc.org/NET/mvco.owl#AdaptationInstance"></see></summary>
    let AdaptationInstance = _prefix "AdaptationInstance"
    /// <summary>
    /// The Action of making an Instance from an AdaptationManifestation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstance"></see></summary>
    let MakeAdaptationInstance = _prefix "MakeAdaptationInstance"
    /// <summary>
    /// A copy of an AdaptationInstance
    /// <see href="http://purl.oclc.org/NET/mvco.owl#AdaptationInstanceCopy"></see></summary>
    let AdaptationInstanceCopy = _prefix "AdaptationInstanceCopy"
    /// <summary>
    /// The Action of making an AdaptationInstanceCopy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstanceCopy"></see></summary>
    let MakeAdaptationInstanceCopy = _prefix "MakeAdaptationInstanceCopy"
    /// <summary>
    /// An object or event which is an expression of an Adaptation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#AdaptationManifestation"></see></summary>
    let AdaptationManifestation = _prefix "AdaptationManifestation"
    /// <summary>
    /// The action of making an AdaptationManifestation from an Adaptation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestation"></see></summary>
    let MakeAdaptationManifestation = _prefix "MakeAdaptationManifestation"
    /// <summary>
    /// A copy of an AdaptationManifestation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#AdaptationManifestationCopy"></see></summary>
    let AdaptationManifestationCopy = _prefix "AdaptationManifestationCopy"
    /// <summary>
    /// The Action of making an AdaptationManifestationCopy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestationCopy"></see></summary>
    let MakeAdaptationManifestationCopy = _prefix "MakeAdaptationManifestationCopy"
    /// <summary>
    /// A User who produces an Adaptation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Adaptor"></see></summary>
    let Adaptor = _prefix "Adaptor"
    /// <summary>
    /// Performance of an Action by a User
    /// <see href="http://purl.oclc.org/NET/mvco.owl#acts"></see></summary>
    let acts = _prefix "acts"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/mvco.owl#Anonymous"></see>
    /// </summary>
    let Anonymous = _prefix "Anonymous"
    /// <summary>
    /// The Function that Delivers Content to a Device in a point-to-multipoint modality
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Broadcast"></see></summary>
    let Broadcast = _prefix "Broadcast"
    /// <summary>
    /// The Function of publicly displaying/performing, e.g. live performance, radio, television, internet streaming, multicast of Instances and Manifestations, and download
    /// <see href="http://purl.oclc.org/NET/mvco.owl#PublicCommunication"></see></summary>
    let PublicCommunication = _prefix "PublicCommunication"
    /// <summary>
    /// Set of two or more Users.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Collective"></see></summary>
    let Collective = _prefix "Collective"
    /// <summary>
    /// User who is appointed to act on Content on behalf and within the scope and responsability of another User´s rights.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#ContentHandler"></see></summary>
    let ContentHandler = _prefix "ContentHandler"
    /// <summary>
    /// Relates a ContentHandler with the User under the auspices of which the ContentHandler operates.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#actOnBehalfOf"></see></summary>
    let actOnBehalfOf = _prefix "actOnBehalfOf"
    /// <summary>
    /// The Action of making a Copy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeCopy"></see></summary>
    let MakeCopy = _prefix "MakeCopy"
    /// <summary>
    /// Fact related to the invokation of a CopyrightException
    /// <see href="http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionFact"></see></summary>
    let CopyrightExceptionFact = _prefix "CopyrightExceptionFact"
    /// <summary>
    /// Positive proposition.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Fact"></see></summary>
    let Fact = _prefix "Fact"
    /// <summary>
    /// Permission to invoke one right exceptionally.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionPermission"></see></summary>
    let CopyrightExceptionPermission = _prefix "CopyrightExceptionPermission"
    /// <summary>
    /// For a Permission to be valid, the Fact has to hold
    /// <see href="http://purl.oclc.org/NET/mvco.owl#hasRequired"></see></summary>
    let hasRequired = _prefix "hasRequired"
    /// <summary>
    /// The action of creating a Work.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#CreateWork"></see></summary>
    let CreateWork = _prefix "CreateWork"
    /// <summary>
    /// Specifies which IPEntity is the object the Action
    /// <see href="http://purl.oclc.org/NET/mvco.owl#actedOver"></see></summary>
    let actedOver = _prefix "actedOver"
    /// <summary>
    /// Declares which IPentity arises as a result of the execution of an Action. It is a functional relation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#resultsIn"></see></summary>
    let resultsIn = _prefix "resultsIn"
    /// <summary>
    /// Action performed by an EndUser
    /// <see href="http://purl.oclc.org/NET/mvco.owl#EndUserAction"></see></summary>
    let EndUserAction = _prefix "EndUserAction"
    /// <summary>
    /// The Function of making Products
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Produce"></see></summary>
    let Produce = _prefix "Produce"
    /// <summary>
    /// The action of making a Manifestation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeManifestation"></see></summary>
    let MakeManifestation = _prefix "MakeManifestation"
    /// <summary>
    /// The Function of selling, renting and lending
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Distribute"></see></summary>
    let Distribute = _prefix "Distribute"
    /// <summary>
    /// The Action of making an Instance from a Manifestation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeInstance"></see></summary>
    let MakeInstance = _prefix "MakeInstance"
    /// <summary>
    /// A User who generates a Work and makes its first Manifestation, also referred to as author
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Creator"></see></summary>
    let Creator = _prefix "Creator"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/mvco.owl#rightGivenBy"></see>
    /// </summary>
    let rightGivenBy = _prefix "rightGivenBy"
    /// <summary>
    /// A User who distributes a Product
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Distributor"></see></summary>
    let Distributor = _prefix "Distributor"
    /// <summary>
    /// The Action of transferring a file or program from a central computer to a smaller computer or to a computer at a remote location
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Download"></see></summary>
    let Download = _prefix "Download"
    /// <summary>
    /// A User in a Value-Chain who ultimately consumes Content.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#EndUser"></see></summary>
    let EndUser = _prefix "EndUser"
    /// <summary>
    /// Truth of a proposition
    /// <see href="http://purl.oclc.org/NET/mvco.owl#isTrue"></see></summary>
    let isTrue = _prefix "isTrue"
    /// <summary>
    /// Defines the owner of the Rights over an IP Entity.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#hasRightsOwner"></see></summary>
    let hasRightsOwner = _prefix "hasRightsOwner"
    /// <summary>
    /// Relates a composite IPEntity with its constituent IPEntities
    /// <see href="http://purl.oclc.org/NET/mvco.owl#isMadeUpOf"></see></summary>
    let isMadeUpOf = _prefix "isMadeUpOf"
    /// <summary>
    /// A User who interprets a Manifestation of a Work making an Instance
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Instantiator"></see></summary>
    let Instantiator = _prefix "Instantiator"
    /// <summary>
    /// The Action of making an Instance from a Work Manifestation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeWorkInstance"></see></summary>
    let MakeWorkInstance = _prefix "MakeWorkInstance"
    /// <summary>
    /// An object or event which is an example of an Identified Manifestation of a Work (e.g. a File)
    /// <see href="http://purl.oclc.org/NET/mvco.owl#WorkInstance"></see></summary>
    let WorkInstance = _prefix "WorkInstance"
    /// <summary>
    /// An object or event which is an expression of a Manifestation of a Work
    /// <see href="http://purl.oclc.org/NET/mvco.owl#WorkManifestation"></see></summary>
    let WorkManifestation = _prefix "WorkManifestation"
    /// <summary>
    /// The Action of making a WorkInstanceCopy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeWorkInstanceCopy"></see></summary>
    let MakeWorkInstanceCopy = _prefix "MakeWorkInstanceCopy"
    /// <summary>
    /// A copy of a WorkInstance
    /// <see href="http://purl.oclc.org/NET/mvco.owl#WorkInstanceCopy"></see></summary>
    let WorkInstanceCopy = _prefix "WorkInstanceCopy"
    /// <summary>
    /// The action of making a Manifestation from Work.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestation"></see></summary>
    let MakeWorkManifestation = _prefix "MakeWorkManifestation"
    /// <summary>
    /// The Action of making a WorkManifestationCopy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestationCopy"></see></summary>
    let MakeWorkManifestationCopy = _prefix "MakeWorkManifestationCopy"
    /// <summary>
    /// A copy of a WorkManifestation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#WorkManifestationCopy"></see></summary>
    let WorkManifestationCopy = _prefix "WorkManifestationCopy"
    /// <summary>
    /// Action of modifying a copy.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#ModifyCopy"></see></summary>
    let ModifyCopy = _prefix "ModifyCopy"
    /// <summary>
    /// The action of moving the location of a content
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MoveContent"></see></summary>
    let MoveContent = _prefix "MoveContent"
    /// <summary>
    /// Declares who has issued a permission
    /// <see href="http://purl.oclc.org/NET/mvco.owl#issuedBy"></see></summary>
    let issuedBy = _prefix "issuedBy"
    /// <summary>
    /// Relation used to express the Actions that are allowed to be performed.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#permitsAction"></see></summary>
    let permitsAction = _prefix "permitsAction"
    /// <summary>
    /// A User who produces a Product from an Instance.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Producer"></see></summary>
    let Producer = _prefix "Producer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/mvco.owl#impliesAlso"></see>
    /// </summary>
    let impliesAlso = _prefix "impliesAlso"
    /// <summary>
    /// The Action of generating a human-perceivable signal
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Render"></see></summary>
    let Render = _prefix "Render"
    /// <summary>
    /// The Function of Delivering Content to a Device where the transferred Content is Processed for Rendering only and not Stored
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Stream"></see></summary>
    let Stream = _prefix "Stream"
    /// <summary>
    /// Data documenting the functions Actions performed by a Device User on a content item and the associated context
    /// <see href="http://purl.oclc.org/NET/mvco.owl#UseData"></see></summary>
    let UseData = _prefix "UseData"
    /// <summary>
    /// Relates a User with a Collective
    /// <see href="http://purl.oclc.org/NET/mvco.owl#belongsTo"></see></summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    /// Attributes a social tag: text, commentary, critique, synopsis (e.g. FOAF)...
    /// <see href="http://purl.oclc.org/NET/mvco.owl#hasSocialTag"></see></summary>
    let hasSocialTag = _prefix "hasSocialTag"
    /// <summary>
    /// distinguishes between digital management of both digital and non digital IP Entities
    /// <see href="http://purl.oclc.org/NET/mvco.owl#isDigital"></see></summary>
    let isDigital = _prefix "isDigital"
    /// <summary>
    /// Declares who is the rights owner of this IP Entity
    /// <see href="http://purl.oclc.org/NET/mvco.owl#isRightsOwnerOf"></see></summary>
    let isRightsOwnerOf = _prefix "isRightsOwnerOf"
