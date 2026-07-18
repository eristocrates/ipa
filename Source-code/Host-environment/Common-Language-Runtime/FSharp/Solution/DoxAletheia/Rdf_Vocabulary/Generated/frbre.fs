namespace http.purl.org.vocab.frbr.extended.hash

open DoxAletheia.Rdf_Vocabulary

module frbre =
    let _namespace_name = "http://purl.org/vocab/frbr/extended#"

    /// <summary>
    /// A referential expression is one which has little meaning when not studied in conjunction with the expression it refers to.
    /// <see href="http://purl.org/vocab/frbr/extended#ReferentialExpression"></see></summary>
    let ReferentialExpression =
        Namespaced_IRI.parse _namespace_name "ReferentialExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#AutonomousExpression"></see>
    /// </summary>
    let AutonomousExpression =
        Namespaced_IRI.parse _namespace_name "AutonomousExpression" |> NamespacedName

    /// <summary>
    /// A referential work is one which has little meaning when not studied in conjunction with the work it refers to.
    /// <see href="http://purl.org/vocab/frbr/extended#ReferentialWork"></see></summary>
    let ReferentialWork =
        Namespaced_IRI.parse _namespace_name "ReferentialWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#AutonomousWork"></see>
    /// </summary>
    let AutonomousWork =
        Namespaced_IRI.parse _namespace_name "AutonomousWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#Expression"></see>
    /// </summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#Work"></see>
    /// </summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#complementsExpression"></see>
    /// </summary>
    let complementsExpression =
        Namespaced_IRI.parse _namespace_name "complementsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isRelatedToExpression"></see>
    /// </summary>
    let isRelatedToExpression =
        Namespaced_IRI.parse _namespace_name "isRelatedToExpression" |> NamespacedName

    /// <summary>
    /// Referential: cadenza, libretto, choreography, ending for unfinished work, etc.
    /// Autonomous: incidental music, musical setting for a text, pendant, etc.
    /// <see href="http://purl.org/vocab/frbr/extended#complementsWork"></see></summary>
    let complementsWork =
        Namespaced_IRI.parse _namespace_name "complementsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isRelatedToWork"></see>
    /// </summary>
    let isRelatedToWork =
        Namespaced_IRI.parse _namespace_name "isRelatedToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasDependentPartExpression"></see>
    /// </summary>
    let hasDependentPartExpression =
        Namespaced_IRI.parse _namespace_name "hasDependentPartExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasPartExpression"></see>
    /// </summary>
    let hasPartExpression =
        Namespaced_IRI.parse _namespace_name "hasPartExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isDependentPartOfExpression"></see>
    /// </summary>
    let isDependentPartOfExpression =
        Namespaced_IRI.parse _namespace_name "isDependentPartOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasDependentPartWork"></see>
    /// </summary>
    let hasDependentPartWork =
        Namespaced_IRI.parse _namespace_name "hasDependentPartWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasPartWork"></see>
    /// </summary>
    let hasPartWork =
        Namespaced_IRI.parse _namespace_name "hasPartWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasIndependentPartExpression"></see>
    /// </summary>
    let hasIndependentPartExpression =
        Namespaced_IRI.parse _namespace_name "hasIndependentPartExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isIndependentPartOfExpression"></see>
    /// </summary>
    let isIndependentPartOfExpression =
        Namespaced_IRI.parse _namespace_name "isIndependentPartOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasIndependentPartWork"></see>
    /// </summary>
    let hasIndependentPartWork =
        Namespaced_IRI.parse _namespace_name "hasIndependentPartWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isIndependentPartOfWork"></see>
    /// </summary>
    let isIndependentPartOfWork =
        Namespaced_IRI.parse _namespace_name "isIndependentPartOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isPartOfExpression"></see>
    /// </summary>
    let isPartOfExpression =
        Namespaced_IRI.parse _namespace_name "isPartOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasPartItem"></see>
    /// </summary>
    let hasPartItem =
        Namespaced_IRI.parse _namespace_name "hasPartItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isPartOfItem"></see>
    /// </summary>
    let isPartOfItem =
        Namespaced_IRI.parse _namespace_name "isPartOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasPartManifestation"></see>
    /// </summary>
    let hasPartManifestation =
        Namespaced_IRI.parse _namespace_name "hasPartManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isPartOfManifestation"></see>
    /// </summary>
    let isPartOfManifestation =
        Namespaced_IRI.parse _namespace_name "isPartOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isPartOfWork"></see>
    /// </summary>
    let isPartOfWork =
        Namespaced_IRI.parse _namespace_name "isPartOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReconfigurationOfItem"></see>
    /// </summary>
    let isAReconfigurationOfItem =
        Namespaced_IRI.parse _namespace_name "isAReconfigurationOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isRelatedToItem"></see>
    /// </summary>
    let isRelatedToItem =
        Namespaced_IRI.parse _namespace_name "isRelatedToItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToExpression"></see>
    /// </summary>
    let isAReferentialSuccessorToExpression =
        Namespaced_IRI.parse _namespace_name "isAReferentialSuccessorToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isASuccessorToExpression"></see>
    /// </summary>
    let isASuccessorToExpression =
        Namespaced_IRI.parse _namespace_name "isASuccessorToExpression" |> NamespacedName

    /// <summary>
    /// A relation between two expressions which results in the subject becoming a referential expression (i.e. one which has little meaning without the object).
    /// <see href="http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToExpression"></see></summary>
    let isReferentiallyRelatedToExpression =
        Namespaced_IRI.parse _namespace_name "isReferentiallyRelatedToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToWork"></see>
    /// </summary>
    let isAReferentialSuccessorToWork =
        Namespaced_IRI.parse _namespace_name "isAReferentialSuccessorToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToWork"></see>
    /// </summary>
    let isReferentiallyRelatedToWork =
        Namespaced_IRI.parse _namespace_name "isReferentiallyRelatedToWork" |> NamespacedName

    /// <summary>
    /// Referential: sequel, etc.
    /// Autonomous: sequel, succeeding work, etc.
    /// <see href="http://purl.org/vocab/frbr/extended#isASuccessorToWork"></see></summary>
    let isASuccessorToWork =
        Namespaced_IRI.parse _namespace_name "isASuccessorToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReproductionOfItem"></see>
    /// </summary>
    let isAReproductionOfItem =
        Namespaced_IRI.parse _namespace_name "isAReproductionOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReproductionOfManifestation"></see>
    /// </summary>
    let isAReproductionOfManifestation =
        Namespaced_IRI.parse _namespace_name "isAReproductionOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isRelatedToManifestation"></see>
    /// </summary>
    let isRelatedToManifestation =
        Namespaced_IRI.parse _namespace_name "isRelatedToManifestation" |> NamespacedName

    /// <summary>
    /// Between expressions of the SAME WORK.
    /// <see href="http://purl.org/vocab/frbr/extended#isARevisionOfExpression"></see></summary>
    let isARevisionOfExpression =
        Namespaced_IRI.parse _namespace_name "isARevisionOfExpression" |> NamespacedName

    /// <summary>
    /// A relation between two expressions which does not result in the subject becoming a referential expression (i.e. one which has little meaning without the object).
    /// <see href="http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToExpression"></see></summary>
    let isAutonomouslyRelatedToExpression =
        Namespaced_IRI.parse _namespace_name "isAutonomouslyRelatedToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isASummaryOfExpression"></see>
    /// </summary>
    let isASummaryOfExpression =
        Namespaced_IRI.parse _namespace_name "isASummaryOfExpression" |> NamespacedName

    /// <summary>
    /// Digest, abstract, etc.
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isASummaryOfWork"></see></summary>
    let isASummaryOfWork =
        Namespaced_IRI.parse _namespace_name "isASummaryOfWork" |> NamespacedName

    /// <summary>
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToWork"></see></summary>
    let isAutonomouslyRelatedToWork =
        Namespaced_IRI.parse _namespace_name "isAutonomouslyRelatedToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isATransformationOfExpression"></see>
    /// </summary>
    let isATransformationOfExpression =
        Namespaced_IRI.parse _namespace_name "isATransformationOfExpression" |> NamespacedName

    /// <summary>
    /// Dramatisation, novelisation, versification, screenplay, etc.
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isATransformationOfWork"></see></summary>
    let isATransformationOfWork =
        Namespaced_IRI.parse _namespace_name "isATransformationOfWork" |> NamespacedName

    /// <summary>
    /// Between expressions of the SAME WORK.
    /// <see href="http://purl.org/vocab/frbr/extended#isATranslationOfExpression"></see></summary>
    let isATranslationOfExpression =
        Namespaced_IRI.parse _namespace_name "isATranslationOfExpression" |> NamespacedName

    /// <summary>
    /// Between expressions of the SAME WORK.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnAbridgementOfExpression"></see></summary>
    let isAnAbridgementOfExpression =
        Namespaced_IRI.parse _namespace_name "isAnAbridgementOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAnAdaptationOfExpression"></see>
    /// </summary>
    let isAnAdaptationOfExpression =
        Namespaced_IRI.parse _namespace_name "isAnAdaptationOfExpression" |> NamespacedName

    /// <summary>
    /// Adaptation, paraphrase, free translation, variation (music), harmonisation (music), fantasy (music), etc.
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnAdaptationOfWork"></see></summary>
    let isAnAdaptationOfWork =
        Namespaced_IRI.parse _namespace_name "isAnAdaptationOfWork" |> NamespacedName

    /// <summary>
    /// Alternate is an Americanism.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnAlternativeManifestationTo"></see></summary>
    let isAnAlternativeManifestationTo =
        Namespaced_IRI.parse _namespace_name "isAnAlternativeManifestationTo" |> NamespacedName

    /// <summary>
    /// Between expressions of the SAME WORK.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnArrangementOfExpression"></see></summary>
    let isAnArrangementOfExpression =
        Namespaced_IRI.parse _namespace_name "isAnArrangementOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAnImitationOfExpression"></see>
    /// </summary>
    let isAnImitationOfExpression =
        Namespaced_IRI.parse _namespace_name "isAnImitationOfExpression" |> NamespacedName

    /// <summary>
    /// Parody, imitation, travesty, etc.
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnImitationOfWork"></see></summary>
    let isAnImitationOfWork =
        Namespaced_IRI.parse _namespace_name "isAnImitationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isDependentPartOfWork"></see>
    /// </summary>
    let isDependentPartOfWork =
        Namespaced_IRI.parse _namespace_name "isDependentPartOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#referentiallyComplementsExpression"></see>
    /// </summary>
    let referentiallyComplementsExpression =
        Namespaced_IRI.parse _namespace_name "referentiallyComplementsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#referentiallyComplementsWork"></see>
    /// </summary>
    let referentiallyComplementsWork =
        Namespaced_IRI.parse _namespace_name "referentiallyComplementsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#referentiallySupplementsExpression"></see>
    /// </summary>
    let referentiallySupplementsExpression =
        Namespaced_IRI.parse _namespace_name "referentiallySupplementsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#supplementsExpression"></see>
    /// </summary>
    let supplementsExpression =
        Namespaced_IRI.parse _namespace_name "supplementsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#referentiallySupplementsWork"></see>
    /// </summary>
    let referentiallySupplementsWork =
        Namespaced_IRI.parse _namespace_name "referentiallySupplementsWork" |> NamespacedName

    /// <summary>
    /// Referential: index, concordance, teacher's guide, gloss, supplement, appendix, etc.
    /// Autonomous: supplement, appendix, etc.
    /// <see href="http://purl.org/vocab/frbr/extended#supplementsWork"></see></summary>
    let supplementsWork =
        Namespaced_IRI.parse _namespace_name "supplementsWork" |> NamespacedName
