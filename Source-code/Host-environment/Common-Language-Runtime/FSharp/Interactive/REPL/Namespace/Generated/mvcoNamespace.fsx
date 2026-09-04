#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mvco =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/mvco.owl#" "mvco"

    /// <summary>
    ///   <para>rdfs:comment : The exercise of a Right.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Action">mvco:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : A Work that is derived from another Work</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Adaptation">mvco:Adaptation</a>
    /// </summary>
    let Adaptation = _prefixId.prefix "Adaptation"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : An object or event which is an example of an Identified Adaptation Manifestation (e.g. a File)</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#AdaptationInstance">mvco:AdaptationInstance</a>
    /// </summary>
    let AdaptationInstance = _prefixId.prefix "AdaptationInstance"
    /// <summary>
    ///   <para>rdfs:comment : A copy of an AdaptationInstance</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#AdaptationInstanceCopy">mvco:AdaptationInstanceCopy</a>
    /// </summary>
    let AdaptationInstanceCopy = _prefixId.prefix "AdaptationInstanceCopy"
    /// <summary>
    ///   <para>rdfs:comment : An object or event which is an expression of an Adaptation</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#AdaptationManifestation">mvco:AdaptationManifestation</a>
    /// </summary>
    let AdaptationManifestation = _prefixId.prefix "AdaptationManifestation"
    /// <summary>
    ///   <para>rdfs:comment : A copy of an AdaptationManifestation</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#AdaptationManifestationCopy">mvco:AdaptationManifestationCopy</a>
    /// </summary>
    let AdaptationManifestationCopy = _prefixId.prefix "AdaptationManifestationCopy"
    /// <summary>
    ///   <para>rdfs:comment : A User who produces an Adaptation</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Adaptor">mvco:Adaptor</a>
    /// </summary>
    let Adaptor = _prefixId.prefix "Adaptor"
    let Anonymous = _prefixId.prefix "Anonymous"
    /// <summary>
    ///   <para>rdfs:comment : The Function that Delivers Content to a Device in a point-to-multipoint modality</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Broadcast">mvco:Broadcast</a>
    /// </summary>
    let Broadcast = _prefixId.prefix "Broadcast"
    /// <summary>
    ///   <para>rdfs:comment : Set of two or more Users.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Collective">mvco:Collective</a>
    /// </summary>
    let Collective = _prefixId.prefix "Collective"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : User who is appointed to act on Content on behalf and within the scope and responsability of another User´s rights.</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#ContentHandler">mvco:ContentHandler</a>
    /// </summary>
    let ContentHandler = _prefixId.prefix "ContentHandler"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : A mechanical reproduction of analogue or digital representations of a given IP Entity. In the case of digital Copies the result is virtually identical  while in the case of analogue Copies the results can vary considerably in quality.</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Copy">mvco:Copy</a>
    /// </summary>
    let Copy = _prefixId.prefix "Copy"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Fact related to the invokation of a CopyrightException^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionFact">mvco:CopyrightExceptionFact</a>
    /// </summary>
    let CopyrightExceptionFact = _prefixId.prefix "CopyrightExceptionFact"
    /// <summary>
    ///   <para>rdfs:comment : Permission to invoke one right exceptionally.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionPermission">mvco:CopyrightExceptionPermission</a>
    /// </summary>
    let CopyrightExceptionPermission = _prefixId.prefix "CopyrightExceptionPermission"
    /// <summary>
    ///   <para>rdfs:comment : The action of creating a Work.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#CreateWork">mvco:CreateWork</a>
    /// </summary>
    let CreateWork = _prefixId.prefix "CreateWork"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : A User who generates a Work and makes its first Manifestation, also referred to as author</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Creator">mvco:Creator</a>
    /// </summary>
    let Creator = _prefixId.prefix "Creator"
    /// <summary>
    ///   <para>rdfs:comment : The Function of selling, renting and lending</para>
    ///   <para>mvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Producer^^xsd:anyURImvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Creator^^xsd:anyURI</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Distribute">mvco:Distribute</a>
    /// </summary>
    let Distribute = _prefixId.prefix "Distribute"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : A User who distributes a Product</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Distributor">mvco:Distributor</a>
    /// </summary>
    let Distributor = _prefixId.prefix "Distributor"
    /// <summary>
    ///   <para>rdfs:comment : The Action of transferring a file or program from a central computer to a smaller computer or to a computer at a remote location</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Download">mvco:Download</a>
    /// </summary>
    let Download = _prefixId.prefix "Download"
    /// <summary>
    ///   <para>rdfs:comment : A User in a Value-Chain who ultimately consumes Content.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#EndUser">mvco:EndUser</a>
    /// </summary>
    let EndUser = _prefixId.prefix "EndUser"
    /// <summary>
    ///   <para>rdfs:comment : Action performed by an EndUser^^xsd:string</para>
    ///   <para>mvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Distributor^^xsd:anyURI</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#EndUserAction">mvco:EndUserAction</a>
    /// </summary>
    let EndUserAction = _prefixId.prefix "EndUserAction"
    /// <summary>
    ///   <para>rdfs:comment : Positive proposition.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Fact">mvco:Fact</a>
    /// </summary>
    let Fact = _prefixId.prefix "Fact"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Types of IP Represented as Content: Work, Adaptation, Manifestation, Instance...</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#IPEntity">mvco:IPEntity</a>
    /// </summary>
    let IPEntity = _prefixId.prefix "IPEntity"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : An object or event which is an example of an Identified Manifestation (e.g. a File)</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Instance">mvco:Instance</a>
    /// </summary>
    let Instance = _prefixId.prefix "Instance"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : A User who interprets a Manifestation of a Work making an Instance</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Instantiator">mvco:Instantiator</a>
    /// </summary>
    let Instantiator = _prefixId.prefix "Instantiator"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>mvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Adaptor^^xsd:anyURImvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Creator^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The Action of making an Adaptation</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptation">mvco:MakeAdaptation</a>
    /// </summary>
    let MakeAdaptation = _prefixId.prefix "MakeAdaptation"
    /// <summary>
    ///   <para>rdfs:comment : The Action of making an Instance from an AdaptationManifestation</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstance">mvco:MakeAdaptationInstance</a>
    /// </summary>
    let MakeAdaptationInstance = _prefixId.prefix "MakeAdaptationInstance"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : The Action of making an AdaptationInstanceCopy</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstanceCopy">mvco:MakeAdaptationInstanceCopy</a>
    /// </summary>
    let MakeAdaptationInstanceCopy = _prefixId.prefix "MakeAdaptationInstanceCopy"
    /// <summary>
    ///   <para>rdfs:comment : The action of making an AdaptationManifestation from an Adaptation.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestation">mvco:MakeAdaptationManifestation</a>
    /// </summary>
    let MakeAdaptationManifestation = _prefixId.prefix "MakeAdaptationManifestation"

    /// <summary>
    ///   <para>rdfs:comment : The Action of making an AdaptationManifestationCopy^^xsd:string</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestationCopy">mvco:MakeAdaptationManifestationCopy</a>
    /// </summary>
    let MakeAdaptationManifestationCopy =
        _prefixId.prefix "MakeAdaptationManifestationCopy"

    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : The Action of making a Copy</para>
    ///   <para>mvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Creator^^xsd:anyURImvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Instantiator^^xsd:anyURI</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeCopy">mvco:MakeCopy</a>
    /// </summary>
    let MakeCopy = _prefixId.prefix "MakeCopy"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : The Action of making an Instance from a Manifestation.</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeInstance">mvco:MakeInstance</a>
    /// </summary>
    let MakeInstance = _prefixId.prefix "MakeInstance"
    /// <summary>
    ///   <para>rdfs:comment : The action of making a Manifestation.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeManifestation">mvco:MakeManifestation</a>
    /// </summary>
    let MakeManifestation = _prefixId.prefix "MakeManifestation"
    /// <summary>
    ///   <para>rdfs:comment : The Action of making an Instance from a Work Manifestation.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeWorkInstance">mvco:MakeWorkInstance</a>
    /// </summary>
    let MakeWorkInstance = _prefixId.prefix "MakeWorkInstance"
    /// <summary>
    ///   <para>rdfs:comment : The Action of making a WorkInstanceCopy</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeWorkInstanceCopy">mvco:MakeWorkInstanceCopy</a>
    /// </summary>
    let MakeWorkInstanceCopy = _prefixId.prefix "MakeWorkInstanceCopy"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : The action of making a Manifestation from Work.</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestation">mvco:MakeWorkManifestation</a>
    /// </summary>
    let MakeWorkManifestation = _prefixId.prefix "MakeWorkManifestation"
    /// <summary>
    ///   <para>rdfs:comment : The Action of making a WorkManifestationCopy</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestationCopy">mvco:MakeWorkManifestationCopy</a>
    /// </summary>
    let MakeWorkManifestationCopy = _prefixId.prefix "MakeWorkManifestationCopy"
    /// <summary>
    ///   <para>rdfs:comment : An object or event which is an expression of a Work.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Manifestation">mvco:Manifestation</a>
    /// </summary>
    let Manifestation = _prefixId.prefix "Manifestation"
    /// <summary>
    ///   <para>rdfs:comment : Action of modifying a copy.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#ModifyCopy">mvco:ModifyCopy</a>
    /// </summary>
    let ModifyCopy = _prefixId.prefix "ModifyCopy"
    /// <summary>
    ///   <para>rdfs:comment : The action of moving the location of a content</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#MoveContent">mvco:MoveContent</a>
    /// </summary>
    let MoveContent = _prefixId.prefix "MoveContent"
    /// <summary>
    ///   <para>rdfs:comment : Authorisation from one RightsOwner to one or more Users to perform one or more Actions on a given IPEntity.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Permission">mvco:Permission</a>
    /// </summary>
    let Permission = _prefixId.prefix "Permission"
    /// <summary>
    ///   <para>mvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Instantiator^^xsd:anyURImvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Creator^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The Function of making Products</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Produce">mvco:Produce</a>
    /// </summary>
    let Produce = _prefixId.prefix "Produce"
    /// <summary>
    ///   <para>rdfs:comment : A User who produces a Product from an Instance.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Producer">mvco:Producer</a>
    /// </summary>
    let Producer = _prefixId.prefix "Producer"
    /// <summary>
    ///   <para>rdfs:comment : A Content Item that adds value to IP Entities by including them with an appropriate Licence for the purpose of Publishing</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Product">mvco:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>mvco:impliesAlso : http://purl.oclc.org/NET/mvco.owl#Render^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The Function of publicly displaying/performing, e.g. live performance, radio, television, internet streaming, multicast of Instances and Manifestations, and download</para>
    ///   <para>mvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Creator^^xsd:anyURImvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Producer^^xsd:anyURI</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#PublicCommunication">mvco:PublicCommunication</a>
    /// </summary>
    let PublicCommunication = _prefixId.prefix "PublicCommunication"
    /// <summary>
    ///   <para>rdfs:comment : The Action of generating a human-perceivable signal</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Render">mvco:Render</a>
    /// </summary>
    let Render = _prefixId.prefix "Render"
    /// <summary>
    ///   <para>rdfs:comment : The Function of Delivering Content to a Device where the transferred Content is Processed for Rendering only and not Stored</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Stream">mvco:Stream</a>
    /// </summary>
    let Stream = _prefixId.prefix "Stream"
    /// <summary>
    ///   <para>mvco:rightGivenBy : http://purl.oclc.org/NET/mvco.owl#Creator^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The Action of concurrently performing/displaying two distinct IP Entities each for a different human sense e.g. text and audio or video and song</para>
    ///   <para>mvco:impliesAlso : http://purl.oclc.org/NET/mvco.owl#ModifyCopy^^xsd:anyURImvco:impliesAlso : http://purl.oclc.org/NET/mvco.owl#Render^^xsd:anyURI</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Synchronise">mvco:Synchronise</a>
    /// </summary>
    let Synchronise = _prefixId.prefix "Synchronise"
    /// <summary>
    ///   <para>rdfs:comment : Data documenting the functions Actions performed by a Device User on a content item and the associated context^^xsd:string</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#UseData">mvco:UseData</a>
    /// </summary>
    let UseData = _prefixId.prefix "UseData"
    /// <summary>
    ///   <para>rdfs:comment : Any person or legal entity in a Value-Chain connecting (and including) Creator and End-User.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#User">mvco:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : A creation that retains intellectual or artistic attributes independently of its Manifestations</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#Work">mvco:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : An object or event which is an example of an Identified Manifestation of a Work (e.g. a File)</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#WorkInstance">mvco:WorkInstance</a>
    /// </summary>
    let WorkInstance = _prefixId.prefix "WorkInstance"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : A copy of a WorkInstance</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#WorkInstanceCopy">mvco:WorkInstanceCopy</a>
    /// </summary>
    let WorkInstanceCopy = _prefixId.prefix "WorkInstanceCopy"
    /// <summary>
    ///   <para>rdfs:comment : An object or event which is an expression of a Manifestation of a Work</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#WorkManifestation">mvco:WorkManifestation</a>
    /// </summary>
    let WorkManifestation = _prefixId.prefix "WorkManifestation"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : A copy of a WorkManifestation.</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#WorkManifestationCopy">mvco:WorkManifestationCopy</a>
    /// </summary>
    let WorkManifestationCopy = _prefixId.prefix "WorkManifestationCopy"
    /// <summary>
    ///   <para>rdfs:comment : Relates a ContentHandler with the User under the auspices of which the ContentHandler operates.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#actOnBehalfOf">mvco:actOnBehalfOf</a>
    /// </summary>
    let actOnBehalfOf = _prefixId.prefix "actOnBehalfOf"
    /// <summary>
    ///   <para>rdfs:comment : Role who has executed the Action^^xsd:string</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#actedBy">mvco:actedBy</a>
    /// </summary>
    let actedBy = _prefixId.prefix "actedBy"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies which IPEntity is the object the Action^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#actedOver">mvco:actedOver</a>
    /// </summary>
    let actedOver = _prefixId.prefix "actedOver"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Performance of an Action by a User^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#acts">mvco:acts</a>
    /// </summary>
    let acts = _prefixId.prefix "acts"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a User with a Collective</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#belongsTo">mvco:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>rdfs:comment : For a Permission to be valid, the Fact has to hold^^xsd:string</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#hasRequired">mvco:hasRequired</a>
    /// </summary>
    let hasRequired = _prefixId.prefix "hasRequired"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the owner of the Rights over an IP Entity.</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#hasRightsOwner">mvco:hasRightsOwner</a>
    /// </summary>
    let hasRightsOwner = _prefixId.prefix "hasRightsOwner"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Attributes a social tag: text, commentary, critique, synopsis (e.g. FOAF)...^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#hasSocialTag">mvco:hasSocialTag</a>
    /// </summary>
    let hasSocialTag = _prefixId.prefix "hasSocialTag"
    let impliesAlso = _prefixId.prefix "impliesAlso"
    /// <summary>
    ///   <para>rdfs:comment : distinguishes between digital management of both digital and non digital IP Entities^^xsd:string</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#isDigital">mvco:isDigital</a>
    /// </summary>
    let isDigital = _prefixId.prefix "isDigital"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a composite IPEntity with its constituent IPEntities</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#isMadeUpOf">mvco:isMadeUpOf</a>
    /// </summary>
    let isMadeUpOf = _prefixId.prefix "isMadeUpOf"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Declares who is the rights owner of this IP Entity^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#isRightsOwnerOf">mvco:isRightsOwnerOf</a>
    /// </summary>
    let isRightsOwnerOf = _prefixId.prefix "isRightsOwnerOf"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Truth of a proposition^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#isTrue">mvco:isTrue</a>
    /// </summary>
    let isTrue = _prefixId.prefix "isTrue"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Declares who has issued a permission^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#issuedBy">mvco:issuedBy</a>
    /// </summary>
    let issuedBy = _prefixId.prefix "issuedBy"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <para>rdfs:comment : Relation used to express the Actions that are allowed to be performed.</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#permitsAction">mvco:permitsAction</a>
    /// </summary>
    let permitsAction = _prefixId.prefix "permitsAction"
    /// <summary>
    ///   <para>rdfs:comment : The dependance of one IP Entity on another.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#resultedFrom">mvco:resultedFrom</a>
    /// </summary>
    let resultedFrom = _prefixId.prefix "resultedFrom"
    /// <summary>
    ///   <para>rdfs:comment : Declares which IPentity arises as a result of the execution of an Action. It is a functional relation.</para>
    ///   <para>owl:versionInfo : 1.0^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/mvco.owl#resultsIn">mvco:resultsIn</a>
    /// </summary>
    let resultsIn = _prefixId.prefix "resultsIn"
    let rightGivenBy = _prefixId.prefix "rightGivenBy"
