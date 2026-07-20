namespace https.w3id.org.legalhtml.ov.hash

open DoxAletheia

module lh =
    let _namespace_name = "https://w3id.org/legalhtml/ov#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Change"></see>
    /// </summary>
    let Change = _prefix "Change"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ChangeSet"></see>
    /// </summary>
    let ChangeSet = _prefix "ChangeSet"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ConsolidatedResource"></see>
    /// </summary>
    let ConsolidatedResource = _prefix "ConsolidatedResource"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EfficacyChange"></see>
    /// </summary>
    let EfficacyChange = _prefix "EfficacyChange"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EndOfEfficacy"></see>
    /// </summary>
    let EndOfEfficacy = _prefix "EndOfEfficacy"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EndOfEnactment"></see>
    /// </summary>
    let EndOfEnactment = _prefix "EndOfEnactment"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ForceChange"></see>
    /// </summary>
    let ForceChange = _prefix "ForceChange"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EntryIntoEfficacy"></see>
    /// </summary>
    let EntryIntoEfficacy = _prefix "EntryIntoEfficacy"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#EntryIntoForce"></see>
    /// </summary>
    let EntryIntoForce = _prefix "EntryIntoForce"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Extraefficacy"></see>
    /// </summary>
    let Extraefficacy = _prefix "Extraefficacy"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Inapplication"></see>
    /// </summary>
    let Inapplication = _prefix "Inapplication"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Insertion"></see>
    /// </summary>
    let Insertion = _prefix "Insertion"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#TextualChange"></see>
    /// </summary>
    let TextualChange = _prefix "TextualChange"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Legislature"></see>
    /// </summary>
    let Legislature = _prefix "Legislature"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#PostponementOfEfficacy"></see>
    /// </summary>
    let PostponementOfEfficacy = _prefix "PostponementOfEfficacy"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#PostponementOfEntryIntoForce"></see>
    /// </summary>
    let PostponementOfEntryIntoForce = _prefix "PostponementOfEntryIntoForce"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ProcedureStage"></see>
    /// </summary>
    let ProcedureStage = _prefix "ProcedureStage"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ProrogationOfEfficacy"></see>
    /// </summary>
    let ProrogationOfEfficacy = _prefix "ProrogationOfEfficacy"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ProrogationOfForce"></see>
    /// </summary>
    let ProrogationOfForce = _prefix "ProrogationOfForce"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#ReEnactment"></see>
    /// </summary>
    let ReEnactment = _prefix "ReEnactment"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Repeal"></see>
    /// </summary>
    let Repeal = _prefix "Repeal"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Retroactivity"></see>
    /// </summary>
    let Retroactivity = _prefix "Retroactivity"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Signature"></see>
    /// </summary>
    let Signature = _prefix "Signature"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Status"></see>
    /// </summary>
    let Status = _prefix "Status"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Substitution"></see>
    /// </summary>
    let Substitution = _prefix "Substitution"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#Unconstitutionality"></see>
    /// </summary>
    let Unconstitutionality = _prefix "Unconstitutionality"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#actingEntity"></see>
    /// </summary>
    let actingEntity = _prefix "actingEntity"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#addendum"></see>
    /// </summary>
    let addendum = _prefix "addendum"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#addressee"></see>
    /// </summary>
    let addressee = _prefix "addressee"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#amendedText"></see>
    /// </summary>
    let amendedText = _prefix "amendedText"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#amendingText"></see>
    /// </summary>
    let amendingText = _prefix "amendingText"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#applicability"></see>
    /// </summary>
    let applicability = _prefix "applicability"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#change"></see>
    /// </summary>
    let change = _prefix "change"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#changeSet"></see>
    /// </summary>
    let changeSet = _prefix "changeSet"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#changingAct"></see>
    /// </summary>
    let changingAct = _prefix "changingAct"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#deletion"></see>
    /// </summary>
    let deletion = _prefix "deletion"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#entryIntoForce"></see>
    /// </summary>
    let entryIntoForce = _prefix "entryIntoForce"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#forceChange"></see>
    /// </summary>
    let forceChange = _prefix "forceChange"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#issuer"></see>
    /// </summary>
    let issuer = _prefix "issuer"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#legislature"></see>
    /// </summary>
    let legislature = _prefix "legislature"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#originalLanguage"></see>
    /// </summary>
    let originalLanguage = _prefix "originalLanguage"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#procedureID"></see>
    /// </summary>
    let procedureID = _prefix "procedureID"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#procedureStage"></see>
    /// </summary>
    let procedureStage = _prefix "procedureStage"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#proposingEntity"></see>
    /// </summary>
    let proposingEntity = _prefix "proposingEntity"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#published"></see>
    /// </summary>
    let published = _prefix "published"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#reference"></see>
    /// </summary>
    let reference = _prefix "reference"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#relevance"></see>
    /// </summary>
    let relevance = _prefix "relevance"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#replacedContent"></see>
    /// </summary>
    let replacedContent = _prefix "replacedContent"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#replacement"></see>
    /// </summary>
    let replacement = _prefix "replacement"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signatory"></see>
    /// </summary>
    let signatory = _prefix "signatory"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signatoryOrganization"></see>
    /// </summary>
    let signatoryOrganization = _prefix "signatoryOrganization"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signatoryRole"></see>
    /// </summary>
    let signatoryRole = _prefix "signatoryRole"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signature"></see>
    /// </summary>
    let signature = _prefix "signature"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signatureDate"></see>
    /// </summary>
    let signatureDate = _prefix "signatureDate"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#signaturePlace"></see>
    /// </summary>
    let signaturePlace = _prefix "signaturePlace"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#startOfApplicability"></see>
    /// </summary>
    let startOfApplicability = _prefix "startOfApplicability"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="https://w3id.org/legalhtml/ov#textualChange"></see>
    /// </summary>
    let textualChange = _prefix "textualChange"
