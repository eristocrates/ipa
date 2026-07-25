namespace http.purl.oclc.org.NET.mvco.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mvco =
    let _namespace_iri = Namespace_Iri mvco |> NamespaceIRI
    /// <summary>
    ///   <para>mvco:actedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Role who has executed the Action</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#actedBy">http://purl.oclc.org/NET/mvco.owl#actedBy</seealso>
    let actedBy = Prefixed_Name(mvco, "actedBy") |> PrefixedName
    /// <summary>
    ///   <para>mvco:IPEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of IP Represented as Content: Work, Adaptation, Manifestation, Instance...</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#IPEntity">http://purl.oclc.org/NET/mvco.owl#IPEntity</seealso>
    let IPEntity = Prefixed_Name(mvco, "IPEntity") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Adaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Work that is derived from another Work</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Adaptation">http://purl.oclc.org/NET/mvco.owl#Adaptation</seealso>
    let Adaptation = Prefixed_Name(mvco, "Adaptation") |> PrefixedName
    /// <summary>
    ///   <para>mvco:resultedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The dependance of one IP Entity on another.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#resultedFrom">http://purl.oclc.org/NET/mvco.owl#resultedFrom</seealso>
    let resultedFrom = Prefixed_Name(mvco, "resultedFrom") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Synchronise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of concurrently performing/displaying two distinct IP Entities each for a different human sense e.g. text and audio or video and song</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Synchronise">http://purl.oclc.org/NET/mvco.owl#Synchronise</seealso>
    let Synchronise = Prefixed_Name(mvco, "Synchronise") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Anonymous</para>
    /// </summary>
    /// <remarks>
    ///   <para>mvco:User</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Anonymous">http://purl.oclc.org/NET/mvco.owl#Anonymous</seealso>
    let Anonymous = Prefixed_Name(mvco, "Anonymous") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Broadcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Function that Delivers Content to a Device in a point-to-multipoint modality</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Broadcast">http://purl.oclc.org/NET/mvco.owl#Broadcast</seealso>
    let Broadcast = Prefixed_Name(mvco, "Broadcast") |> PrefixedName
    /// <summary>
    ///   <para>mvco:PublicCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Function of publicly displaying/performing, e.g. live performance, radio, television, internet streaming, multicast of Instances and Manifestations, and download</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#PublicCommunication">http://purl.oclc.org/NET/mvco.owl#PublicCommunication</seealso>
    let PublicCommunication = Prefixed_Name(mvco, "PublicCommunication") |> PrefixedName
    /// <summary>
    ///   <para>mvco:MakeCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making a Copy</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeCopy">http://purl.oclc.org/NET/mvco.owl#MakeCopy</seealso>
    let MakeCopy = Prefixed_Name(mvco, "MakeCopy") |> PrefixedName

    /// <summary>
    ///   <para>mvco:CopyrightExceptionFact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fact related to the invokation of a CopyrightException</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionFact">http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionFact</seealso>
    let CopyrightExceptionFact =
        Prefixed_Name(mvco, "CopyrightExceptionFact") |> PrefixedName

    /// <summary>
    ///   <para>mvco:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any person or legal entity in a Value-Chain connecting (and including) Creator and End-User.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#User">http://purl.oclc.org/NET/mvco.owl#User</seealso>
    let User = Prefixed_Name(mvco, "User") |> PrefixedName

    /// <summary>
    ///   <para>mvco:AdaptationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object or event which is an expression of an Adaptation</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#AdaptationManifestation">http://purl.oclc.org/NET/mvco.owl#AdaptationManifestation</seealso>
    let AdaptationManifestation =
        Prefixed_Name(mvco, "AdaptationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>mvco:MakeAdaptationManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action of making an AdaptationManifestation from an Adaptation.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestation">http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestation</seealso>
    let MakeAdaptationManifestation =
        Prefixed_Name(mvco, "MakeAdaptationManifestation") |> PrefixedName

    /// <summary>
    ///   <para>mvco:WorkInstanceCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A copy of a WorkInstance</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#WorkInstanceCopy">http://purl.oclc.org/NET/mvco.owl#WorkInstanceCopy</seealso>
    let WorkInstanceCopy = Prefixed_Name(mvco, "WorkInstanceCopy") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Authorisation from one RightsOwner to one or more Users to perform one or more Actions on a given IPEntity.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Permission">http://purl.oclc.org/NET/mvco.owl#Permission</seealso>
    let Permission = Prefixed_Name(mvco, "Permission") |> PrefixedName
    /// <summary>
    ///   <para>mvco:MakeAdaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making an Adaptation</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptation">http://purl.oclc.org/NET/mvco.owl#MakeAdaptation</seealso>
    let MakeAdaptation = Prefixed_Name(mvco, "MakeAdaptation") |> PrefixedName

    /// <summary>
    ///   <para>mvco:CopyrightExceptionPermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Permission to invoke one right exceptionally.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionPermission">http://purl.oclc.org/NET/mvco.owl#CopyrightExceptionPermission</seealso>
    let CopyrightExceptionPermission =
        Prefixed_Name(mvco, "CopyrightExceptionPermission") |> PrefixedName

    /// <summary>
    ///   <para>mvco:actedOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies which IPEntity is the object the Action</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#actedOver">http://purl.oclc.org/NET/mvco.owl#actedOver</seealso>
    let actedOver = Prefixed_Name(mvco, "actedOver") |> PrefixedName
    /// <summary>
    ///   <para>mvco:EndUserAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action performed by an EndUser</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#EndUserAction">http://purl.oclc.org/NET/mvco.owl#EndUserAction</seealso>
    let EndUserAction = Prefixed_Name(mvco, "EndUserAction") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Distribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Function of selling, renting and lending</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Distribute">http://purl.oclc.org/NET/mvco.owl#Distribute</seealso>
    let Distribute = Prefixed_Name(mvco, "Distribute") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A creation that retains intellectual or artistic attributes independently of its Manifestations</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Work">http://purl.oclc.org/NET/mvco.owl#Work</seealso>
    let Work = Prefixed_Name(mvco, "Work") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanical reproduction of analogue or digital representations of a given IP Entity. In the case of digital Copies the result is virtually identical  while in the case of analogue Copies the results can vary considerably in quality.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Copy">http://purl.oclc.org/NET/mvco.owl#Copy</seealso>
    let Copy = Prefixed_Name(mvco, "Copy") |> PrefixedName
    /// <summary>
    ///   <para>mvco:AdaptationInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object or event which is an example of an Identified Adaptation Manifestation (e.g. a File)</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#AdaptationInstance">http://purl.oclc.org/NET/mvco.owl#AdaptationInstance</seealso>
    let AdaptationInstance = Prefixed_Name(mvco, "AdaptationInstance") |> PrefixedName

    /// <summary>
    ///   <para>mvco:MakeAdaptationInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making an Instance from an AdaptationManifestation</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstance">http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstance</seealso>
    let MakeAdaptationInstance =
        Prefixed_Name(mvco, "MakeAdaptationInstance") |> PrefixedName

    /// <summary>
    ///   <para>mvco:Manifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object or event which is an expression of a Work.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Manifestation">http://purl.oclc.org/NET/mvco.owl#Manifestation</seealso>
    let Manifestation = Prefixed_Name(mvco, "Manifestation") |> PrefixedName

    /// <summary>
    ///   <para>mvco:MakeAdaptationInstanceCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making an AdaptationInstanceCopy</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstanceCopy">http://purl.oclc.org/NET/mvco.owl#MakeAdaptationInstanceCopy</seealso>
    let MakeAdaptationInstanceCopy =
        Prefixed_Name(mvco, "MakeAdaptationInstanceCopy") |> PrefixedName

    /// <summary>
    ///   <para>mvco:AdaptationManifestationCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A copy of an AdaptationManifestation</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#AdaptationManifestationCopy">http://purl.oclc.org/NET/mvco.owl#AdaptationManifestationCopy</seealso>
    let AdaptationManifestationCopy =
        Prefixed_Name(mvco, "AdaptationManifestationCopy") |> PrefixedName

    /// <summary>
    ///   <para>mvco:issuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Declares who has issued a permission</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#issuedBy">http://purl.oclc.org/NET/mvco.owl#issuedBy</seealso>
    let issuedBy = Prefixed_Name(mvco, "issuedBy") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Content Item that adds value to IP Entities by including them with an appropriate Licence for the purpose of Publishing</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Product">http://purl.oclc.org/NET/mvco.owl#Product</seealso>
    let Product = Prefixed_Name(mvco, "Product") |> PrefixedName

    /// <summary>
    ///   <para>mvco:AdaptationInstanceCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A copy of an AdaptationInstance</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#AdaptationInstanceCopy">http://purl.oclc.org/NET/mvco.owl#AdaptationInstanceCopy</seealso>
    let AdaptationInstanceCopy =
        Prefixed_Name(mvco, "AdaptationInstanceCopy") |> PrefixedName

    /// <summary>
    ///   <para>mvco:MakeWorkInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making an Instance from a Work Manifestation.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeWorkInstance">http://purl.oclc.org/NET/mvco.owl#MakeWorkInstance</seealso>
    let MakeWorkInstance = Prefixed_Name(mvco, "MakeWorkInstance") |> PrefixedName
    /// <summary>
    ///   <para>mvco:WorkInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object or event which is an example of an Identified Manifestation of a Work (e.g. a File)</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#WorkInstance">http://purl.oclc.org/NET/mvco.owl#WorkInstance</seealso>
    let WorkInstance = Prefixed_Name(mvco, "WorkInstance") |> PrefixedName

    /// <summary>
    ///   <para>mvco:MakeWorkInstanceCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making a WorkInstanceCopy</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeWorkInstanceCopy">http://purl.oclc.org/NET/mvco.owl#MakeWorkInstanceCopy</seealso>
    let MakeWorkInstanceCopy =
        Prefixed_Name(mvco, "MakeWorkInstanceCopy") |> PrefixedName

    /// <summary>
    ///   <para>mvco:MakeWorkManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action of making a Manifestation from Work.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestation">http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestation</seealso>
    let MakeWorkManifestation =
        Prefixed_Name(mvco, "MakeWorkManifestation") |> PrefixedName

    /// <summary>
    ///   <para>mvco:WorkManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object or event which is an expression of a Manifestation of a Work</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#WorkManifestation">http://purl.oclc.org/NET/mvco.owl#WorkManifestation</seealso>
    let WorkManifestation = Prefixed_Name(mvco, "WorkManifestation") |> PrefixedName

    /// <summary>
    ///   <para>mvco:MakeWorkManifestationCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making a WorkManifestationCopy</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestationCopy">http://purl.oclc.org/NET/mvco.owl#MakeWorkManifestationCopy</seealso>
    let MakeWorkManifestationCopy =
        Prefixed_Name(mvco, "MakeWorkManifestationCopy") |> PrefixedName

    /// <summary>
    ///   <para>mvco:WorkManifestationCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A copy of a WorkManifestation.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#WorkManifestationCopy">http://purl.oclc.org/NET/mvco.owl#WorkManifestationCopy</seealso>
    let WorkManifestationCopy =
        Prefixed_Name(mvco, "WorkManifestationCopy") |> PrefixedName

    /// <summary>
    ///   <para>mvco:ModifyCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action of modifying a copy.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#ModifyCopy">http://purl.oclc.org/NET/mvco.owl#ModifyCopy</seealso>
    let ModifyCopy = Prefixed_Name(mvco, "ModifyCopy") |> PrefixedName
    /// <summary>
    ///   <para>mvco:permitsAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation used to express the Actions that are allowed to be performed.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#permitsAction">http://purl.oclc.org/NET/mvco.owl#permitsAction</seealso>
    let permitsAction = Prefixed_Name(mvco, "permitsAction") |> PrefixedName

    /// <summary>
    ///   <para>mvco:MakeAdaptationManifestationCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making an AdaptationManifestationCopy</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestationCopy">http://purl.oclc.org/NET/mvco.owl#MakeAdaptationManifestationCopy</seealso>
    let MakeAdaptationManifestationCopy =
        Prefixed_Name(mvco, "MakeAdaptationManifestationCopy") |> PrefixedName

    /// <summary>
    ///   <para>mvco:acts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Performance of an Action by a User</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#acts">http://purl.oclc.org/NET/mvco.owl#acts</seealso>
    let acts = Prefixed_Name(mvco, "acts") |> PrefixedName
    /// <summary>
    ///   <para>mvco:MoveContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action of moving the location of a content</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MoveContent">http://purl.oclc.org/NET/mvco.owl#MoveContent</seealso>
    let MoveContent = Prefixed_Name(mvco, "MoveContent") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A User who produces a Product from an Instance.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Producer">http://purl.oclc.org/NET/mvco.owl#Producer</seealso>
    let Producer = Prefixed_Name(mvco, "Producer") |> PrefixedName
    /// <summary>
    ///   <para>mvco:impliesAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#impliesAlso">http://purl.oclc.org/NET/mvco.owl#impliesAlso</seealso>
    let impliesAlso = Prefixed_Name(mvco, "impliesAlso") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Render</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of generating a human-perceivable signal</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Render">http://purl.oclc.org/NET/mvco.owl#Render</seealso>
    let Render = Prefixed_Name(mvco, "Render") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Function of Delivering Content to a Device where the transferred Content is Processed for Rendering only and not Stored</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Stream">http://purl.oclc.org/NET/mvco.owl#Stream</seealso>
    let Stream = Prefixed_Name(mvco, "Stream") |> PrefixedName
    /// <summary>
    ///   <para>mvco:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Relates a User with a Collective</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#belongsTo">http://purl.oclc.org/NET/mvco.owl#belongsTo</seealso>
    let belongsTo = Prefixed_Name(mvco, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Adaptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A User who produces an Adaptation</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Adaptor">http://purl.oclc.org/NET/mvco.owl#Adaptor</seealso>
    let Adaptor = Prefixed_Name(mvco, "Adaptor") |> PrefixedName
    /// <summary>
    ///   <para>mvco:ContentHandler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>User who is appointed to act on Content on behalf and within the scope and responsability of another User´s rights.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#ContentHandler">http://purl.oclc.org/NET/mvco.owl#ContentHandler</seealso>
    let ContentHandler = Prefixed_Name(mvco, "ContentHandler") |> PrefixedName
    /// <summary>
    ///   <para>mvco:actOnBehalfOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Relates a ContentHandler with the User under the auspices of which the ContentHandler operates.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#actOnBehalfOf">http://purl.oclc.org/NET/mvco.owl#actOnBehalfOf</seealso>
    let actOnBehalfOf = Prefixed_Name(mvco, "actOnBehalfOf") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Fact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Positive proposition.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Fact">http://purl.oclc.org/NET/mvco.owl#Fact</seealso>
    let Fact = Prefixed_Name(mvco, "Fact") |> PrefixedName
    /// <summary>
    ///   <para>mvco:hasRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>For a Permission to be valid, the Fact has to hold</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#hasRequired">http://purl.oclc.org/NET/mvco.owl#hasRequired</seealso>
    let hasRequired = Prefixed_Name(mvco, "hasRequired") |> PrefixedName
    /// <summary>
    ///   <para>mvco:CreateWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action of creating a Work.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#CreateWork">http://purl.oclc.org/NET/mvco.owl#CreateWork</seealso>
    let CreateWork = Prefixed_Name(mvco, "CreateWork") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Collective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of two or more Users.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Collective">http://purl.oclc.org/NET/mvco.owl#Collective</seealso>
    let Collective = Prefixed_Name(mvco, "Collective") |> PrefixedName
    /// <summary>
    ///   <para>mvco:UseData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data documenting the functions Actions performed by a Device User on a content item and the associated context</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#UseData">http://purl.oclc.org/NET/mvco.owl#UseData</seealso>
    let UseData = Prefixed_Name(mvco, "UseData") |> PrefixedName
    /// <summary>
    ///   <para>mvco:hasSocialTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Attributes a social tag: text, commentary, critique, synopsis (e.g. FOAF)...</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#hasSocialTag">http://purl.oclc.org/NET/mvco.owl#hasSocialTag</seealso>
    let hasSocialTag = Prefixed_Name(mvco, "hasSocialTag") |> PrefixedName
    /// <summary>
    ///   <para>mvco:isDigital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>distinguishes between digital management of both digital and non digital IP Entities</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#isDigital">http://purl.oclc.org/NET/mvco.owl#isDigital</seealso>
    let isDigital = Prefixed_Name(mvco, "isDigital") |> PrefixedName
    /// <summary>
    ///   <para>mvco:isRightsOwnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Declares who is the rights owner of this IP Entity</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#isRightsOwnerOf">http://purl.oclc.org/NET/mvco.owl#isRightsOwnerOf</seealso>
    let isRightsOwnerOf = Prefixed_Name(mvco, "isRightsOwnerOf") |> PrefixedName
    /// <summary>
    ///   <para>mvco:resultsIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Declares which IPentity arises as a result of the execution of an Action. It is a functional relation.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#resultsIn">http://purl.oclc.org/NET/mvco.owl#resultsIn</seealso>
    let resultsIn = Prefixed_Name(mvco, "resultsIn") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A User who generates a Work and makes its first Manifestation, also referred to as author</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Creator">http://purl.oclc.org/NET/mvco.owl#Creator</seealso>
    let Creator = Prefixed_Name(mvco, "Creator") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A User who distributes a Product</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Distributor">http://purl.oclc.org/NET/mvco.owl#Distributor</seealso>
    let Distributor = Prefixed_Name(mvco, "Distributor") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Download</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of transferring a file or program from a central computer to a smaller computer or to a computer at a remote location</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Download">http://purl.oclc.org/NET/mvco.owl#Download</seealso>
    let Download = Prefixed_Name(mvco, "Download") |> PrefixedName
    /// <summary>
    ///   <para>mvco:isTrue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Truth of a proposition</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#isTrue">http://purl.oclc.org/NET/mvco.owl#isTrue</seealso>
    let isTrue = Prefixed_Name(mvco, "isTrue") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Produce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Function of making Products</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Produce">http://purl.oclc.org/NET/mvco.owl#Produce</seealso>
    let Produce = Prefixed_Name(mvco, "Produce") |> PrefixedName
    /// <summary>
    ///   <para>mvco:MakeInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action of making an Instance from a Manifestation.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeInstance">http://purl.oclc.org/NET/mvco.owl#MakeInstance</seealso>
    let MakeInstance = Prefixed_Name(mvco, "MakeInstance") |> PrefixedName
    /// <summary>
    ///   <para>mvco:MakeManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action of making a Manifestation.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#MakeManifestation">http://purl.oclc.org/NET/mvco.owl#MakeManifestation</seealso>
    let MakeManifestation = Prefixed_Name(mvco, "MakeManifestation") |> PrefixedName
    /// <summary>
    ///   <para>mvco:rightGivenBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#rightGivenBy">http://purl.oclc.org/NET/mvco.owl#rightGivenBy</seealso>
    let rightGivenBy = Prefixed_Name(mvco, "rightGivenBy") |> PrefixedName
    /// <summary>
    ///   <para>mvco:EndUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A User in a Value-Chain who ultimately consumes Content.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#EndUser">http://purl.oclc.org/NET/mvco.owl#EndUser</seealso>
    let EndUser = Prefixed_Name(mvco, "EndUser") |> PrefixedName
    /// <summary>
    ///   <para>mvco:isMadeUpOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a composite IPEntity with its constituent IPEntities</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#isMadeUpOf">http://purl.oclc.org/NET/mvco.owl#isMadeUpOf</seealso>
    let isMadeUpOf = Prefixed_Name(mvco, "isMadeUpOf") |> PrefixedName
    /// <summary>
    ///   <para>mvco:hasRightsOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the owner of the Rights over an IP Entity.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#hasRightsOwner">http://purl.oclc.org/NET/mvco.owl#hasRightsOwner</seealso>
    let hasRightsOwner = Prefixed_Name(mvco, "hasRightsOwner") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Instantiator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A User who interprets a Manifestation of a Work making an Instance</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Instantiator">http://purl.oclc.org/NET/mvco.owl#Instantiator</seealso>
    let Instantiator = Prefixed_Name(mvco, "Instantiator") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The exercise of a Right.</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Action">http://purl.oclc.org/NET/mvco.owl#Action</seealso>
    let Action = Prefixed_Name(mvco, "Action") |> PrefixedName
    /// <summary>
    ///   <para>mvco:Instance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object or event which is an example of an Identified Manifestation (e.g. a File)</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/mvco.owl#Instance">http://purl.oclc.org/NET/mvco.owl#Instance</seealso>
    let Instance = Prefixed_Name(mvco, "Instance") |> PrefixedName
