namespace http.purl.oclc.org.NET.mvco.owl.hash

open DoxAletheia.Rdf_Vocabulary

module mvco =
    let _namespace_name = "http://purl.oclc.org/NET/mvco.owl#"
    /// <summary>
    /// The exercise of a Right.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// Role who has executed the Action
    /// <see href="http://purl.oclc.org/NET/mvco.owl#actedBy"></see></summary>
    let actedBy = Namespaced_IRI.parse _namespace_name "actedBy" |> NamespacedName
    /// <summary>
    /// Any person or legal entity in a Value-Chain connecting (and including) Creator and End-User.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// Types of IP Represented as Content: Work, Adaptation, Manifestation, Instance...
    /// <see href="http://purl.oclc.org/NET/mvco.owl#IPEntity"></see></summary>
    let IPEntity = Namespaced_IRI.parse _namespace_name "IPEntity" |> NamespacedName
    /// <summary>
    /// Authorisation from one RightsOwner to one or more Users to perform one or more Actions on a given IPEntity.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Permission"></see></summary>
    let Permission = Namespaced_IRI.parse _namespace_name "Permission" |> NamespacedName
    /// <summary>
    /// A Work that is derived from another Work
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Adaptation"></see></summary>
    let Adaptation = Namespaced_IRI.parse _namespace_name "Adaptation" |> NamespacedName

    /// <summary>
    /// The dependance of one IP Entity on another.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#resultedFrom"></see></summary>
    let resultedFrom =
        Namespaced_IRI.parse _namespace_name "resultedFrom" |> NamespacedName

    /// <summary>
    /// The Action of making an Adaptation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptation"></see></summary>
    let MakeAdaptation =
        Namespaced_IRI.parse _namespace_name "MakeAdaptation" |> NamespacedName

    /// <summary>
    /// The Action of concurrently performing/displaying two distinct IP Entities each for a different human sense e.g. text and audio or video and song
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Synchronise"></see></summary>
    let Synchronise =
        Namespaced_IRI.parse _namespace_name "Synchronise" |> NamespacedName

    /// <summary>
    /// A creation that retains intellectual or artistic attributes independently of its Manifestations
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName

    /// <summary>
    /// An object or event which is an expression of a Work.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Manifestation"></see></summary>
    let Manifestation =
        Namespaced_IRI.parse _namespace_name "Manifestation" |> NamespacedName

    /// <summary>
    /// An object or event which is an example of an Identified Manifestation (e.g. a File)
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Instance"></see></summary>
    let Instance = Namespaced_IRI.parse _namespace_name "Instance" |> NamespacedName
    /// <summary>
    /// A mechanical reproduction of analogue or digital representations of a given IP Entity. In the case of digital Copies the result is virtually identical  while in the case of analogue Copies the results can vary considerably in quality.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Copy"></see></summary>
    let Copy = Namespaced_IRI.parse _namespace_name "Copy" |> NamespacedName
    /// <summary>
    /// A Content Item that adds value to IP Entities by including them with an appropriate Licence for the purpose of Publishing
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName

    /// <summary>
    /// An object or event which is an example of an Identified Adaptation Manifestation (e.g. a File)
    /// <see href="http://purl.oclc.org/NET/mvco.owl#AdaptationInstance"></see></summary>
    let AdaptationInstance =
        Namespaced_IRI.parse _namespace_name "AdaptationInstance" |> NamespacedName

    /// <summary>
    /// The Action of making an Instance from an AdaptationManifestation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstance"></see></summary>
    let MakeAdaptationInstance =
        Namespaced_IRI.parse _namespace_name "MakeAdaptationInstance" |> NamespacedName

    /// <summary>
    /// A copy of an AdaptationInstance
    /// <see href="http://purl.oclc.org/NET/mvco.owl#AdaptationInstanceCopy"></see></summary>
    let AdaptationInstanceCopy =
        Namespaced_IRI.parse _namespace_name "AdaptationInstanceCopy" |> NamespacedName

    /// <summary>
    /// The Action of making an AdaptationInstanceCopy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstanceCopy"></see></summary>
    let MakeAdaptationInstanceCopy =
        Namespaced_IRI.parse _namespace_name "MakeAdaptationInstanceCopy" |> NamespacedName

    /// <summary>
    /// An object or event which is an expression of an Adaptation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#AdaptationManifestation"></see></summary>
    let AdaptationManifestation =
        Namespaced_IRI.parse _namespace_name "AdaptationManifestation" |> NamespacedName

    /// <summary>
    /// The action of making an AdaptationManifestation from an Adaptation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestation"></see></summary>
    let MakeAdaptationManifestation =
        Namespaced_IRI.parse _namespace_name "MakeAdaptationManifestation" |> NamespacedName

    /// <summary>
    /// A copy of an AdaptationManifestation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#AdaptationManifestationCopy"></see></summary>
    let AdaptationManifestationCopy =
        Namespaced_IRI.parse _namespace_name "AdaptationManifestationCopy" |> NamespacedName

    /// <summary>
    /// The Action of making an AdaptationManifestationCopy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestationCopy"></see></summary>
    let MakeAdaptationManifestationCopy =
        Namespaced_IRI.parse _namespace_name "MakeAdaptationManifestationCopy" |> NamespacedName

    /// <summary>
    /// A User who produces an Adaptation
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Adaptor"></see></summary>
    let Adaptor = Namespaced_IRI.parse _namespace_name "Adaptor" |> NamespacedName
    /// <summary>
    /// Performance of an Action by a User
    /// <see href="http://purl.oclc.org/NET/mvco.owl#acts"></see></summary>
    let acts = Namespaced_IRI.parse _namespace_name "acts" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/mvco.owl#Anonymous"></see>
    /// </summary>
    let Anonymous = Namespaced_IRI.parse _namespace_name "Anonymous" |> NamespacedName
    /// <summary>
    /// The Function that Delivers Content to a Device in a point-to-multipoint modality
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Broadcast"></see></summary>
    let Broadcast = Namespaced_IRI.parse _namespace_name "Broadcast" |> NamespacedName

    /// <summary>
    /// The Function of publicly displaying/performing, e.g. live performance, radio, television, internet streaming, multicast of Instances and Manifestations, and download
    /// <see href="http://purl.oclc.org/NET/mvco.owl#PublicCommunication"></see></summary>
    let PublicCommunication =
        Namespaced_IRI.parse _namespace_name "PublicCommunication" |> NamespacedName

    /// <summary>
    /// Set of two or more Users.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Collective"></see></summary>
    let Collective = Namespaced_IRI.parse _namespace_name "Collective" |> NamespacedName

    /// <summary>
    /// User who is appointed to act on Content on behalf and within the scope and responsability of another User´s rights.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#ContentHandler"></see></summary>
    let ContentHandler =
        Namespaced_IRI.parse _namespace_name "ContentHandler" |> NamespacedName

    /// <summary>
    /// Relates a ContentHandler with the User under the auspices of which the ContentHandler operates.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#actOnBehalfOf"></see></summary>
    let actOnBehalfOf =
        Namespaced_IRI.parse _namespace_name "actOnBehalfOf" |> NamespacedName

    /// <summary>
    /// The Action of making a Copy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeCopy"></see></summary>
    let MakeCopy = Namespaced_IRI.parse _namespace_name "MakeCopy" |> NamespacedName

    /// <summary>
    /// Fact related to the invokation of a CopyrightException
    /// <see href="http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionFact"></see></summary>
    let CopyrightExceptionFact =
        Namespaced_IRI.parse _namespace_name "CopyrightExceptionFact" |> NamespacedName

    /// <summary>
    /// Positive proposition.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Fact"></see></summary>
    let Fact = Namespaced_IRI.parse _namespace_name "Fact" |> NamespacedName

    /// <summary>
    /// Permission to invoke one right exceptionally.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionPermission"></see></summary>
    let CopyrightExceptionPermission =
        Namespaced_IRI.parse _namespace_name "CopyrightExceptionPermission" |> NamespacedName

    /// <summary>
    /// For a Permission to be valid, the Fact has to hold
    /// <see href="http://purl.oclc.org/NET/mvco.owl#hasRequired"></see></summary>
    let hasRequired =
        Namespaced_IRI.parse _namespace_name "hasRequired" |> NamespacedName

    /// <summary>
    /// The action of creating a Work.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#CreateWork"></see></summary>
    let CreateWork = Namespaced_IRI.parse _namespace_name "CreateWork" |> NamespacedName
    /// <summary>
    /// Specifies which IPEntity is the object the Action
    /// <see href="http://purl.oclc.org/NET/mvco.owl#actedOver"></see></summary>
    let actedOver = Namespaced_IRI.parse _namespace_name "actedOver" |> NamespacedName
    /// <summary>
    /// Declares which IPentity arises as a result of the execution of an Action. It is a functional relation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#resultsIn"></see></summary>
    let resultsIn = Namespaced_IRI.parse _namespace_name "resultsIn" |> NamespacedName

    /// <summary>
    /// Action performed by an EndUser
    /// <see href="http://purl.oclc.org/NET/mvco.owl#EndUserAction"></see></summary>
    let EndUserAction =
        Namespaced_IRI.parse _namespace_name "EndUserAction" |> NamespacedName

    /// <summary>
    /// The Function of making Products
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Produce"></see></summary>
    let Produce = Namespaced_IRI.parse _namespace_name "Produce" |> NamespacedName

    /// <summary>
    /// The action of making a Manifestation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeManifestation"></see></summary>
    let MakeManifestation =
        Namespaced_IRI.parse _namespace_name "MakeManifestation" |> NamespacedName

    /// <summary>
    /// The Function of selling, renting and lending
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Distribute"></see></summary>
    let Distribute = Namespaced_IRI.parse _namespace_name "Distribute" |> NamespacedName

    /// <summary>
    /// The Action of making an Instance from a Manifestation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeInstance"></see></summary>
    let MakeInstance =
        Namespaced_IRI.parse _namespace_name "MakeInstance" |> NamespacedName

    /// <summary>
    /// A User who generates a Work and makes its first Manifestation, also referred to as author
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Creator"></see></summary>
    let Creator = Namespaced_IRI.parse _namespace_name "Creator" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/mvco.owl#rightGivenBy"></see>
    /// </summary>
    let rightGivenBy =
        Namespaced_IRI.parse _namespace_name "rightGivenBy" |> NamespacedName

    /// <summary>
    /// A User who distributes a Product
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Distributor"></see></summary>
    let Distributor =
        Namespaced_IRI.parse _namespace_name "Distributor" |> NamespacedName

    /// <summary>
    /// The Action of transferring a file or program from a central computer to a smaller computer or to a computer at a remote location
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Download"></see></summary>
    let Download = Namespaced_IRI.parse _namespace_name "Download" |> NamespacedName
    /// <summary>
    /// A User in a Value-Chain who ultimately consumes Content.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#EndUser"></see></summary>
    let EndUser = Namespaced_IRI.parse _namespace_name "EndUser" |> NamespacedName
    /// <summary>
    /// Truth of a proposition
    /// <see href="http://purl.oclc.org/NET/mvco.owl#isTrue"></see></summary>
    let isTrue = Namespaced_IRI.parse _namespace_name "isTrue" |> NamespacedName

    /// <summary>
    /// Defines the owner of the Rights over an IP Entity.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#hasRightsOwner"></see></summary>
    let hasRightsOwner =
        Namespaced_IRI.parse _namespace_name "hasRightsOwner" |> NamespacedName

    /// <summary>
    /// Relates a composite IPEntity with its constituent IPEntities
    /// <see href="http://purl.oclc.org/NET/mvco.owl#isMadeUpOf"></see></summary>
    let isMadeUpOf = Namespaced_IRI.parse _namespace_name "isMadeUpOf" |> NamespacedName

    /// <summary>
    /// A User who interprets a Manifestation of a Work making an Instance
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Instantiator"></see></summary>
    let Instantiator =
        Namespaced_IRI.parse _namespace_name "Instantiator" |> NamespacedName

    /// <summary>
    /// The Action of making an Instance from a Work Manifestation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeWorkInstance"></see></summary>
    let MakeWorkInstance =
        Namespaced_IRI.parse _namespace_name "MakeWorkInstance" |> NamespacedName

    /// <summary>
    /// An object or event which is an example of an Identified Manifestation of a Work (e.g. a File)
    /// <see href="http://purl.oclc.org/NET/mvco.owl#WorkInstance"></see></summary>
    let WorkInstance =
        Namespaced_IRI.parse _namespace_name "WorkInstance" |> NamespacedName

    /// <summary>
    /// An object or event which is an expression of a Manifestation of a Work
    /// <see href="http://purl.oclc.org/NET/mvco.owl#WorkManifestation"></see></summary>
    let WorkManifestation =
        Namespaced_IRI.parse _namespace_name "WorkManifestation" |> NamespacedName

    /// <summary>
    /// The Action of making a WorkInstanceCopy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeWorkInstanceCopy"></see></summary>
    let MakeWorkInstanceCopy =
        Namespaced_IRI.parse _namespace_name "MakeWorkInstanceCopy" |> NamespacedName

    /// <summary>
    /// A copy of a WorkInstance
    /// <see href="http://purl.oclc.org/NET/mvco.owl#WorkInstanceCopy"></see></summary>
    let WorkInstanceCopy =
        Namespaced_IRI.parse _namespace_name "WorkInstanceCopy" |> NamespacedName

    /// <summary>
    /// The action of making a Manifestation from Work.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestation"></see></summary>
    let MakeWorkManifestation =
        Namespaced_IRI.parse _namespace_name "MakeWorkManifestation" |> NamespacedName

    /// <summary>
    /// The Action of making a WorkManifestationCopy
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestationCopy"></see></summary>
    let MakeWorkManifestationCopy =
        Namespaced_IRI.parse _namespace_name "MakeWorkManifestationCopy" |> NamespacedName

    /// <summary>
    /// A copy of a WorkManifestation.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#WorkManifestationCopy"></see></summary>
    let WorkManifestationCopy =
        Namespaced_IRI.parse _namespace_name "WorkManifestationCopy" |> NamespacedName

    /// <summary>
    /// Action of modifying a copy.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#ModifyCopy"></see></summary>
    let ModifyCopy = Namespaced_IRI.parse _namespace_name "ModifyCopy" |> NamespacedName

    /// <summary>
    /// The action of moving the location of a content
    /// <see href="http://purl.oclc.org/NET/mvco.owl#MoveContent"></see></summary>
    let MoveContent =
        Namespaced_IRI.parse _namespace_name "MoveContent" |> NamespacedName

    /// <summary>
    /// Declares who has issued a permission
    /// <see href="http://purl.oclc.org/NET/mvco.owl#issuedBy"></see></summary>
    let issuedBy = Namespaced_IRI.parse _namespace_name "issuedBy" |> NamespacedName

    /// <summary>
    /// Relation used to express the Actions that are allowed to be performed.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#permitsAction"></see></summary>
    let permitsAction =
        Namespaced_IRI.parse _namespace_name "permitsAction" |> NamespacedName

    /// <summary>
    /// A User who produces a Product from an Instance.
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Producer"></see></summary>
    let Producer = Namespaced_IRI.parse _namespace_name "Producer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/mvco.owl#impliesAlso"></see>
    /// </summary>
    let impliesAlso =
        Namespaced_IRI.parse _namespace_name "impliesAlso" |> NamespacedName

    /// <summary>
    /// The Action of generating a human-perceivable signal
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Render"></see></summary>
    let Render = Namespaced_IRI.parse _namespace_name "Render" |> NamespacedName
    /// <summary>
    /// The Function of Delivering Content to a Device where the transferred Content is Processed for Rendering only and not Stored
    /// <see href="http://purl.oclc.org/NET/mvco.owl#Stream"></see></summary>
    let Stream = Namespaced_IRI.parse _namespace_name "Stream" |> NamespacedName
    /// <summary>
    /// Data documenting the functions Actions performed by a Device User on a content item and the associated context
    /// <see href="http://purl.oclc.org/NET/mvco.owl#UseData"></see></summary>
    let UseData = Namespaced_IRI.parse _namespace_name "UseData" |> NamespacedName
    /// <summary>
    /// Relates a User with a Collective
    /// <see href="http://purl.oclc.org/NET/mvco.owl#belongsTo"></see></summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName

    /// <summary>
    /// Attributes a social tag: text, commentary, critique, synopsis (e.g. FOAF)...
    /// <see href="http://purl.oclc.org/NET/mvco.owl#hasSocialTag"></see></summary>
    let hasSocialTag =
        Namespaced_IRI.parse _namespace_name "hasSocialTag" |> NamespacedName

    /// <summary>
    /// distinguishes between digital management of both digital and non digital IP Entities
    /// <see href="http://purl.oclc.org/NET/mvco.owl#isDigital"></see></summary>
    let isDigital = Namespaced_IRI.parse _namespace_name "isDigital" |> NamespacedName

    /// <summary>
    /// Declares who is the rights owner of this IP Entity
    /// <see href="http://purl.oclc.org/NET/mvco.owl#isRightsOwnerOf"></see></summary>
    let isRightsOwnerOf =
        Namespaced_IRI.parse _namespace_name "isRightsOwnerOf" |> NamespacedName
