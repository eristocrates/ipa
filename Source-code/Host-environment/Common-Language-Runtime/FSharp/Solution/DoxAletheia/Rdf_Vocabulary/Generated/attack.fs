namespace http.w3id.org.sepses.vocab.ref.attack.hash

open DoxAletheia

module attack =
    let _namespace_name = "http://w3id.org/sepses/vocab/ref/attack#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#AdversaryGroup"></see>
    /// </summary>
    let AdversaryGroup = _prefix "AdversaryGroup"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Asset"></see>
    /// </summary>
    let Asset = _prefix "Asset"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Campaign"></see>
    /// </summary>
    let Campaign = _prefix "Campaign"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#DataComponent"></see>
    /// </summary>
    let DataComponent = _prefix "DataComponent"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#DataSource"></see>
    /// </summary>
    let DataSource = _prefix "DataSource"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Malware"></see>
    /// </summary>
    let Malware = _prefix "Malware"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Software"></see>
    /// </summary>
    let Software = _prefix "Software"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Mitigation"></see>
    /// </summary>
    let Mitigation = _prefix "Mitigation"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Reference"></see>
    /// </summary>
    let Reference = _prefix "Reference"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#SubTechnique"></see>
    /// </summary>
    let SubTechnique = _prefix "SubTechnique"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Technique"></see>
    /// </summary>
    let Technique = _prefix "Technique"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Tactic"></see>
    /// </summary>
    let Tactic = _prefix "Tactic"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#accomplishesTactic"></see>
    /// </summary>
    let accomplishesTactic = _prefix "accomplishesTactic"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#aliases"></see>
    /// </summary>
    let aliases = _prefix "aliases"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#associatedGroup"></see>
    /// </summary>
    let associatedGroup = _prefix "associatedGroup"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#dataSource"></see>
    /// </summary>
    let dataSource = _prefix "dataSource"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#detection"></see>
    /// </summary>
    let detection = _prefix "detection"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasAdversaryGroup"></see>
    /// </summary>
    let hasAdversaryGroup = _prefix "hasAdversaryGroup"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasCAPEC"></see>
    /// </summary>
    let hasCAPEC = _prefix "hasCAPEC"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasMitigation"></see>
    /// </summary>
    let hasMitigation = _prefix "hasMitigation"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasReference"></see>
    /// </summary>
    let hasReference = _prefix "hasReference"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasSoftware"></see>
    /// </summary>
    let hasSoftware = _prefix "hasSoftware"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasTechnique"></see>
    /// </summary>
    let hasTechnique = _prefix "hasTechnique"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#implementsTechnique"></see>
    /// </summary>
    let implementsTechnique = _prefix "implementsTechnique"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#isSubTechniqueOf"></see>
    /// </summary>
    let isSubTechniqueOf = _prefix "isSubTechniqueOf"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#isSubtechnique"></see>
    /// </summary>
    let isSubtechnique = _prefix "isSubtechnique"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#permissionRequired"></see>
    /// </summary>
    let permissionRequired = _prefix "permissionRequired"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#platform"></see>
    /// </summary>
    let platform = _prefix "platform"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#preventsTechnique"></see>
    /// </summary>
    let preventsTechnique = _prefix "preventsTechnique"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#referenceDescription"></see>
    /// </summary>
    let referenceDescription = _prefix "referenceDescription"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#referenceId"></see>
    /// </summary>
    let referenceId = _prefix "referenceId"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#referenceName"></see>
    /// </summary>
    let referenceName = _prefix "referenceName"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#referenceUrl"></see>
    /// </summary>
    let referenceUrl = _prefix "referenceUrl"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#targetsAsset"></see>
    /// </summary>
    let targetsAsset = _prefix "targetsAsset"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#usesMalware"></see>
    /// </summary>
    let usesMalware = _prefix "usesMalware"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#usesSoftware"></see>
    /// </summary>
    let usesSoftware = _prefix "usesSoftware"
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#usesTechnique"></see>
    /// </summary>
    let usesTechnique = _prefix "usesTechnique"
