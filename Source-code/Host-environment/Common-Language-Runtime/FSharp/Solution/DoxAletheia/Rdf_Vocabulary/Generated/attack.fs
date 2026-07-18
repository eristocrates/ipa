namespace http.w3id.org.sepses.vocab.ref.attack.hash

open DoxAletheia.Rdf_Vocabulary

module attack =
    let _namespace_name = "http://w3id.org/sepses/vocab/ref/attack#"

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#AdversaryGroup"></see>
    /// </summary>
    let AdversaryGroup =
        Namespaced_IRI.parse _namespace_name "AdversaryGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Asset"></see>
    /// </summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Campaign"></see>
    /// </summary>
    let Campaign = Namespaced_IRI.parse _namespace_name "Campaign" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#DataComponent"></see>
    /// </summary>
    let DataComponent =
        Namespaced_IRI.parse _namespace_name "DataComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#DataSource"></see>
    /// </summary>
    let DataSource = Namespaced_IRI.parse _namespace_name "DataSource" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Malware"></see>
    /// </summary>
    let Malware = Namespaced_IRI.parse _namespace_name "Malware" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Software"></see>
    /// </summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Mitigation"></see>
    /// </summary>
    let Mitigation = Namespaced_IRI.parse _namespace_name "Mitigation" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Reference"></see>
    /// </summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#SubTechnique"></see>
    /// </summary>
    let SubTechnique =
        Namespaced_IRI.parse _namespace_name "SubTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Technique"></see>
    /// </summary>
    let Technique = Namespaced_IRI.parse _namespace_name "Technique" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#Tactic"></see>
    /// </summary>
    let Tactic = Namespaced_IRI.parse _namespace_name "Tactic" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#accomplishesTactic"></see>
    /// </summary>
    let accomplishesTactic =
        Namespaced_IRI.parse _namespace_name "accomplishesTactic" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#aliases"></see>
    /// </summary>
    let aliases = Namespaced_IRI.parse _namespace_name "aliases" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#associatedGroup"></see>
    /// </summary>
    let associatedGroup =
        Namespaced_IRI.parse _namespace_name "associatedGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#dataSource"></see>
    /// </summary>
    let dataSource = Namespaced_IRI.parse _namespace_name "dataSource" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#detection"></see>
    /// </summary>
    let detection = Namespaced_IRI.parse _namespace_name "detection" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasAdversaryGroup"></see>
    /// </summary>
    let hasAdversaryGroup =
        Namespaced_IRI.parse _namespace_name "hasAdversaryGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasCAPEC"></see>
    /// </summary>
    let hasCAPEC = Namespaced_IRI.parse _namespace_name "hasCAPEC" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasMitigation"></see>
    /// </summary>
    let hasMitigation =
        Namespaced_IRI.parse _namespace_name "hasMitigation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasReference"></see>
    /// </summary>
    let hasReference =
        Namespaced_IRI.parse _namespace_name "hasReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasSoftware"></see>
    /// </summary>
    let hasSoftware =
        Namespaced_IRI.parse _namespace_name "hasSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#hasTechnique"></see>
    /// </summary>
    let hasTechnique =
        Namespaced_IRI.parse _namespace_name "hasTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#implementsTechnique"></see>
    /// </summary>
    let implementsTechnique =
        Namespaced_IRI.parse _namespace_name "implementsTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#isSubTechniqueOf"></see>
    /// </summary>
    let isSubTechniqueOf =
        Namespaced_IRI.parse _namespace_name "isSubTechniqueOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#isSubtechnique"></see>
    /// </summary>
    let isSubtechnique =
        Namespaced_IRI.parse _namespace_name "isSubtechnique" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#permissionRequired"></see>
    /// </summary>
    let permissionRequired =
        Namespaced_IRI.parse _namespace_name "permissionRequired" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#platform"></see>
    /// </summary>
    let platform = Namespaced_IRI.parse _namespace_name "platform" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#preventsTechnique"></see>
    /// </summary>
    let preventsTechnique =
        Namespaced_IRI.parse _namespace_name "preventsTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#referenceDescription"></see>
    /// </summary>
    let referenceDescription =
        Namespaced_IRI.parse _namespace_name "referenceDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#referenceId"></see>
    /// </summary>
    let referenceId =
        Namespaced_IRI.parse _namespace_name "referenceId" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#referenceName"></see>
    /// </summary>
    let referenceName =
        Namespaced_IRI.parse _namespace_name "referenceName" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#referenceUrl"></see>
    /// </summary>
    let referenceUrl =
        Namespaced_IRI.parse _namespace_name "referenceUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#targetsAsset"></see>
    /// </summary>
    let targetsAsset =
        Namespaced_IRI.parse _namespace_name "targetsAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#usesMalware"></see>
    /// </summary>
    let usesMalware =
        Namespaced_IRI.parse _namespace_name "usesMalware" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#usesSoftware"></see>
    /// </summary>
    let usesSoftware =
        Namespaced_IRI.parse _namespace_name "usesSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/sepses/vocab/ref/attack#usesTechnique"></see>
    /// </summary>
    let usesTechnique =
        Namespaced_IRI.parse _namespace_name "usesTechnique" |> NamespacedName
