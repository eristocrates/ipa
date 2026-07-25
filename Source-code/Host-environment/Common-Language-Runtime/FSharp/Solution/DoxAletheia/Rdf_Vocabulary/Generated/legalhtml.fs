namespace https.w3id.org.legalhtml.ov.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module legalhtml =
    let _namespace_iri = Namespace_Iri legalhtml |> NamespaceIRI
    /// <summary>
    ///   <para>legalhtml:Insertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>insertion</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Insertion">https://w3id.org/legalhtml/ov#Insertion</seealso>
    let Insertion = Prefixed_Name(legalhtml, "Insertion") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:ProcedureStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>procedure stage</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#ProcedureStage">https://w3id.org/legalhtml/ov#ProcedureStage</seealso>
    let ProcedureStage = Prefixed_Name(legalhtml, "ProcedureStage") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:ConsolidatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>consolidated resource</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#ConsolidatedResource">https://w3id.org/legalhtml/ov#ConsolidatedResource</seealso>
    let ConsolidatedResource =
        Prefixed_Name(legalhtml, "ConsolidatedResource") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:EntryIntoForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>entry into force</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#EntryIntoForce">https://w3id.org/legalhtml/ov#EntryIntoForce</seealso>
    let EntryIntoForce = Prefixed_Name(legalhtml, "EntryIntoForce") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:addendum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>addendum</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#addendum">https://w3id.org/legalhtml/ov#addendum</seealso>
    let addendum = Prefixed_Name(legalhtml, "addendum") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:amendingText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>amending text</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#amendingText">https://w3id.org/legalhtml/ov#amendingText</seealso>
    let amendingText = Prefixed_Name(legalhtml, "amendingText") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:change</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>change</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#change">https://w3id.org/legalhtml/ov#change</seealso>
    let change = Prefixed_Name(legalhtml, "change") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:deletion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>deletion</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#deletion">https://w3id.org/legalhtml/ov#deletion</seealso>
    let deletion = Prefixed_Name(legalhtml, "deletion") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:entryIntoForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>entry into force</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#entryIntoForce">https://w3id.org/legalhtml/ov#entryIntoForce</seealso>
    let entryIntoForce = Prefixed_Name(legalhtml, "entryIntoForce") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:legislature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>legislature</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#legislature">https://w3id.org/legalhtml/ov#legislature</seealso>
    let legislature = Prefixed_Name(legalhtml, "legislature") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:procedureID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>procedure identifier</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#procedureID">https://w3id.org/legalhtml/ov#procedureID</seealso>
    let procedureID = Prefixed_Name(legalhtml, "procedureID") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:EndOfEfficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>end of efficacy</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#EndOfEfficacy">https://w3id.org/legalhtml/ov#EndOfEfficacy</seealso>
    let EndOfEfficacy = Prefixed_Name(legalhtml, "EndOfEfficacy") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Extraefficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>extraefficacy</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Extraefficacy">https://w3id.org/legalhtml/ov#Extraefficacy</seealso>
    let Extraefficacy = Prefixed_Name(legalhtml, "Extraefficacy") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Inapplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>inapplication</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Inapplication">https://w3id.org/legalhtml/ov#Inapplication</seealso>
    let Inapplication = Prefixed_Name(legalhtml, "Inapplication") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:PostponementOfEntryIntoForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>postponement of entry into force</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#PostponementOfEntryIntoForce">https://w3id.org/legalhtml/ov#PostponementOfEntryIntoForce</seealso>
    let PostponementOfEntryIntoForce =
        Prefixed_Name(legalhtml, "PostponementOfEntryIntoForce") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:ProrogationOfEfficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prorogation of efficacy</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#ProrogationOfEfficacy">https://w3id.org/legalhtml/ov#ProrogationOfEfficacy</seealso>
    let ProrogationOfEfficacy =
        Prefixed_Name(legalhtml, "ProrogationOfEfficacy") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:ReEnactment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>re-enactment</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#ReEnactment">https://w3id.org/legalhtml/ov#ReEnactment</seealso>
    let ReEnactment = Prefixed_Name(legalhtml, "ReEnactment") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Retroactivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>retroactivity</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Retroactivity">https://w3id.org/legalhtml/ov#Retroactivity</seealso>
    let Retroactivity = Prefixed_Name(legalhtml, "Retroactivity") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:ForceChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>force change</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#ForceChange">https://w3id.org/legalhtml/ov#ForceChange</seealso>
    let ForceChange = Prefixed_Name(legalhtml, "ForceChange") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:ProrogationOfForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prorogation of force</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#ProrogationOfForce">https://w3id.org/legalhtml/ov#ProrogationOfForce</seealso>
    let ProrogationOfForce =
        Prefixed_Name(legalhtml, "ProrogationOfForce") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:Signature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>signature</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Signature">https://w3id.org/legalhtml/ov#Signature</seealso>
    let Signature = Prefixed_Name(legalhtml, "Signature") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:actingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>acting entity</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#actingEntity">https://w3id.org/legalhtml/ov#actingEntity</seealso>
    let actingEntity = Prefixed_Name(legalhtml, "actingEntity") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Repeal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>repeal</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Repeal">https://w3id.org/legalhtml/ov#Repeal</seealso>
    let Repeal = Prefixed_Name(legalhtml, "Repeal") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>status</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Status">https://w3id.org/legalhtml/ov#Status</seealso>
    let Status = Prefixed_Name(legalhtml, "Status") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Substitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>substitution</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Substitution">https://w3id.org/legalhtml/ov#Substitution</seealso>
    let Substitution = Prefixed_Name(legalhtml, "Substitution") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:Unconstitutionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>uncostitutionality</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Unconstitutionality">https://w3id.org/legalhtml/ov#Unconstitutionality</seealso>
    let Unconstitutionality =
        Prefixed_Name(legalhtml, "Unconstitutionality") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:addressee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>addressee</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#addressee">https://w3id.org/legalhtml/ov#addressee</seealso>
    let addressee = Prefixed_Name(legalhtml, "addressee") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:amendedText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>amended text</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#amendedText">https://w3id.org/legalhtml/ov#amendedText</seealso>
    let amendedText = Prefixed_Name(legalhtml, "amendedText") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:applicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicability</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#applicability">https://w3id.org/legalhtml/ov#applicability</seealso>
    let applicability = Prefixed_Name(legalhtml, "applicability") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:changeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>change set</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#changeSet">https://w3id.org/legalhtml/ov#changeSet</seealso>
    let changeSet = Prefixed_Name(legalhtml, "changeSet") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:changingAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>changing act</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#changingAct">https://w3id.org/legalhtml/ov#changingAct</seealso>
    let changingAct = Prefixed_Name(legalhtml, "changingAct") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:forceChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>force change</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#forceChange">https://w3id.org/legalhtml/ov#forceChange</seealso>
    let forceChange = Prefixed_Name(legalhtml, "forceChange") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>role</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Role">https://w3id.org/legalhtml/ov#Role</seealso>
    let Role = Prefixed_Name(legalhtml, "Role") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>issuer</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#issuer">https://w3id.org/legalhtml/ov#issuer</seealso>
    let issuer = Prefixed_Name(legalhtml, "issuer") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:procedureStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>procedure stage</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#procedureStage">https://w3id.org/legalhtml/ov#procedureStage</seealso>
    let procedureStage = Prefixed_Name(legalhtml, "procedureStage") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>published</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#published">https://w3id.org/legalhtml/ov#published</seealso>
    let published = Prefixed_Name(legalhtml, "published") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>reference</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#reference">https://w3id.org/legalhtml/ov#reference</seealso>
    let reference = Prefixed_Name(legalhtml, "reference") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:replacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>replacement</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#replacement">https://w3id.org/legalhtml/ov#replacement</seealso>
    let replacement = Prefixed_Name(legalhtml, "replacement") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:originalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>original language</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#originalLanguage">https://w3id.org/legalhtml/ov#originalLanguage</seealso>
    let originalLanguage = Prefixed_Name(legalhtml, "originalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:proposingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>proposing entity</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#proposingEntity">https://w3id.org/legalhtml/ov#proposingEntity</seealso>
    let proposingEntity = Prefixed_Name(legalhtml, "proposingEntity") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:replacedContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>replaced content</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#replacedContent">https://w3id.org/legalhtml/ov#replacedContent</seealso>
    let replacedContent = Prefixed_Name(legalhtml, "replacedContent") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:relevance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>relevance</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#relevance">https://w3id.org/legalhtml/ov#relevance</seealso>
    let relevance = Prefixed_Name(legalhtml, "relevance") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:signatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>signatory</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#signatory">https://w3id.org/legalhtml/ov#signatory</seealso>
    let signatory = Prefixed_Name(legalhtml, "signatory") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:signatoryRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>signatory role</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#signatoryRole">https://w3id.org/legalhtml/ov#signatoryRole</seealso>
    let signatoryRole = Prefixed_Name(legalhtml, "signatoryRole") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:signatureDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>signature date</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#signatureDate">https://w3id.org/legalhtml/ov#signatureDate</seealso>
    let signatureDate = Prefixed_Name(legalhtml, "signatureDate") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:signaturePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>signature place</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#signaturePlace">https://w3id.org/legalhtml/ov#signaturePlace</seealso>
    let signaturePlace = Prefixed_Name(legalhtml, "signaturePlace") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:startOfApplicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>start of applicability</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#startOfApplicability">https://w3id.org/legalhtml/ov#startOfApplicability</seealso>
    let startOfApplicability =
        Prefixed_Name(legalhtml, "startOfApplicability") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:textualChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>textual change</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#textualChange">https://w3id.org/legalhtml/ov#textualChange</seealso>
    let textualChange = Prefixed_Name(legalhtml, "textualChange") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:signatoryOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>signatory organization</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#signatoryOrganization">https://w3id.org/legalhtml/ov#signatoryOrganization</seealso>
    let signatoryOrganization =
        Prefixed_Name(legalhtml, "signatoryOrganization") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:signature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>signature</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#signature">https://w3id.org/legalhtml/ov#signature</seealso>
    let signature = Prefixed_Name(legalhtml, "signature") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>status</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#status">https://w3id.org/legalhtml/ov#status</seealso>
    let status = Prefixed_Name(legalhtml, "status") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Change</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>change</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Change">https://w3id.org/legalhtml/ov#Change</seealso>
    let Change = Prefixed_Name(legalhtml, "Change") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:ChangeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>change set</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#ChangeSet">https://w3id.org/legalhtml/ov#ChangeSet</seealso>
    let ChangeSet = Prefixed_Name(legalhtml, "ChangeSet") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:EfficacyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>efficacy change</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#EfficacyChange">https://w3id.org/legalhtml/ov#EfficacyChange</seealso>
    let EfficacyChange = Prefixed_Name(legalhtml, "EfficacyChange") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:EndOfEnactment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>end of enactment</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#EndOfEnactment">https://w3id.org/legalhtml/ov#EndOfEnactment</seealso>
    let EndOfEnactment = Prefixed_Name(legalhtml, "EndOfEnactment") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:EntryIntoEfficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>entry into efficacy</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#EntryIntoEfficacy">https://w3id.org/legalhtml/ov#EntryIntoEfficacy</seealso>
    let EntryIntoEfficacy =
        Prefixed_Name(legalhtml, "EntryIntoEfficacy") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:TextualChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>textual change</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#TextualChange">https://w3id.org/legalhtml/ov#TextualChange</seealso>
    let TextualChange = Prefixed_Name(legalhtml, "TextualChange") |> PrefixedName
    /// <summary>
    ///   <para>legalhtml:Legislature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>legislature</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#Legislature">https://w3id.org/legalhtml/ov#Legislature</seealso>
    let Legislature = Prefixed_Name(legalhtml, "Legislature") |> PrefixedName

    /// <summary>
    ///   <para>legalhtml:PostponementOfEfficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>postponement of efficacy</para></remarks>
    /// <seealso href="https://w3id.org/legalhtml/ov#PostponementOfEfficacy">https://w3id.org/legalhtml/ov#PostponementOfEfficacy</seealso>
    let PostponementOfEfficacy =
        Prefixed_Name(legalhtml, "PostponementOfEfficacy") |> PrefixedName
