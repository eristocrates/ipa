namespace https.w3id.org.legalhtml.ov.hash

open DoxAletheia.Rdf_Vocabulary

module lh =
    let _namespace_name = "https://w3id.org/legalhtml/ov#"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Change"></see>
    /// </summary>
    let Change = Namespaced_IRI.parse _namespace_name "Change" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ChangeSet"></see>
    /// </summary>
    let ChangeSet = Namespaced_IRI.parse _namespace_name "ChangeSet" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ConsolidatedResource"></see>
    /// </summary>
    let ConsolidatedResource =
        Namespaced_IRI.parse _namespace_name "ConsolidatedResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EfficacyChange"></see>
    /// </summary>
    let EfficacyChange =
        Namespaced_IRI.parse _namespace_name "EfficacyChange" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EndOfEfficacy"></see>
    /// </summary>
    let EndOfEfficacy =
        Namespaced_IRI.parse _namespace_name "EndOfEfficacy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EndOfEnactment"></see>
    /// </summary>
    let EndOfEnactment =
        Namespaced_IRI.parse _namespace_name "EndOfEnactment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ForceChange"></see>
    /// </summary>
    let ForceChange =
        Namespaced_IRI.parse _namespace_name "ForceChange" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EntryIntoEfficacy"></see>
    /// </summary>
    let EntryIntoEfficacy =
        Namespaced_IRI.parse _namespace_name "EntryIntoEfficacy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EntryIntoForce"></see>
    /// </summary>
    let EntryIntoForce =
        Namespaced_IRI.parse _namespace_name "EntryIntoForce" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Extraefficacy"></see>
    /// </summary>
    let Extraefficacy =
        Namespaced_IRI.parse _namespace_name "Extraefficacy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Inapplication"></see>
    /// </summary>
    let Inapplication =
        Namespaced_IRI.parse _namespace_name "Inapplication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Insertion"></see>
    /// </summary>
    let Insertion = Namespaced_IRI.parse _namespace_name "Insertion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#TextualChange"></see>
    /// </summary>
    let TextualChange =
        Namespaced_IRI.parse _namespace_name "TextualChange" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Legislature"></see>
    /// </summary>
    let Legislature =
        Namespaced_IRI.parse _namespace_name "Legislature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#PostponementOfEfficacy"></see>
    /// </summary>
    let PostponementOfEfficacy =
        Namespaced_IRI.parse _namespace_name "PostponementOfEfficacy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#PostponementOfEntryIntoForce"></see>
    /// </summary>
    let PostponementOfEntryIntoForce =
        Namespaced_IRI.parse _namespace_name "PostponementOfEntryIntoForce" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ProcedureStage"></see>
    /// </summary>
    let ProcedureStage =
        Namespaced_IRI.parse _namespace_name "ProcedureStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ProrogationOfEfficacy"></see>
    /// </summary>
    let ProrogationOfEfficacy =
        Namespaced_IRI.parse _namespace_name "ProrogationOfEfficacy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ProrogationOfForce"></see>
    /// </summary>
    let ProrogationOfForce =
        Namespaced_IRI.parse _namespace_name "ProrogationOfForce" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ReEnactment"></see>
    /// </summary>
    let ReEnactment =
        Namespaced_IRI.parse _namespace_name "ReEnactment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Repeal"></see>
    /// </summary>
    let Repeal = Namespaced_IRI.parse _namespace_name "Repeal" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Retroactivity"></see>
    /// </summary>
    let Retroactivity =
        Namespaced_IRI.parse _namespace_name "Retroactivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Signature"></see>
    /// </summary>
    let Signature = Namespaced_IRI.parse _namespace_name "Signature" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Status"></see>
    /// </summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Substitution"></see>
    /// </summary>
    let Substitution =
        Namespaced_IRI.parse _namespace_name "Substitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Unconstitutionality"></see>
    /// </summary>
    let Unconstitutionality =
        Namespaced_IRI.parse _namespace_name "Unconstitutionality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#actingEntity"></see>
    /// </summary>
    let actingEntity =
        Namespaced_IRI.parse _namespace_name "actingEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#addendum"></see>
    /// </summary>
    let addendum = Namespaced_IRI.parse _namespace_name "addendum" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#addressee"></see>
    /// </summary>
    let addressee = Namespaced_IRI.parse _namespace_name "addressee" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#amendedText"></see>
    /// </summary>
    let amendedText =
        Namespaced_IRI.parse _namespace_name "amendedText" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#amendingText"></see>
    /// </summary>
    let amendingText =
        Namespaced_IRI.parse _namespace_name "amendingText" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#applicability"></see>
    /// </summary>
    let applicability =
        Namespaced_IRI.parse _namespace_name "applicability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#change"></see>
    /// </summary>
    let change = Namespaced_IRI.parse _namespace_name "change" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#changeSet"></see>
    /// </summary>
    let changeSet = Namespaced_IRI.parse _namespace_name "changeSet" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#changingAct"></see>
    /// </summary>
    let changingAct =
        Namespaced_IRI.parse _namespace_name "changingAct" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#deletion"></see>
    /// </summary>
    let deletion = Namespaced_IRI.parse _namespace_name "deletion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#entryIntoForce"></see>
    /// </summary>
    let entryIntoForce =
        Namespaced_IRI.parse _namespace_name "entryIntoForce" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#forceChange"></see>
    /// </summary>
    let forceChange =
        Namespaced_IRI.parse _namespace_name "forceChange" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#issuer"></see>
    /// </summary>
    let issuer = Namespaced_IRI.parse _namespace_name "issuer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#legislature"></see>
    /// </summary>
    let legislature =
        Namespaced_IRI.parse _namespace_name "legislature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#originalLanguage"></see>
    /// </summary>
    let originalLanguage =
        Namespaced_IRI.parse _namespace_name "originalLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#procedureID"></see>
    /// </summary>
    let procedureID =
        Namespaced_IRI.parse _namespace_name "procedureID" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#procedureStage"></see>
    /// </summary>
    let procedureStage =
        Namespaced_IRI.parse _namespace_name "procedureStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#proposingEntity"></see>
    /// </summary>
    let proposingEntity =
        Namespaced_IRI.parse _namespace_name "proposingEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#published"></see>
    /// </summary>
    let published = Namespaced_IRI.parse _namespace_name "published" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#reference"></see>
    /// </summary>
    let reference = Namespaced_IRI.parse _namespace_name "reference" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#relevance"></see>
    /// </summary>
    let relevance = Namespaced_IRI.parse _namespace_name "relevance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#replacedContent"></see>
    /// </summary>
    let replacedContent =
        Namespaced_IRI.parse _namespace_name "replacedContent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#replacement"></see>
    /// </summary>
    let replacement =
        Namespaced_IRI.parse _namespace_name "replacement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signatory"></see>
    /// </summary>
    let signatory = Namespaced_IRI.parse _namespace_name "signatory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signatoryOrganization"></see>
    /// </summary>
    let signatoryOrganization =
        Namespaced_IRI.parse _namespace_name "signatoryOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signatoryRole"></see>
    /// </summary>
    let signatoryRole =
        Namespaced_IRI.parse _namespace_name "signatoryRole" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signature"></see>
    /// </summary>
    let signature = Namespaced_IRI.parse _namespace_name "signature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signatureDate"></see>
    /// </summary>
    let signatureDate =
        Namespaced_IRI.parse _namespace_name "signatureDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signaturePlace"></see>
    /// </summary>
    let signaturePlace =
        Namespaced_IRI.parse _namespace_name "signaturePlace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#startOfApplicability"></see>
    /// </summary>
    let startOfApplicability =
        Namespaced_IRI.parse _namespace_name "startOfApplicability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#textualChange"></see>
    /// </summary>
    let textualChange =
        Namespaced_IRI.parse _namespace_name "textualChange" |> NamespacedName
