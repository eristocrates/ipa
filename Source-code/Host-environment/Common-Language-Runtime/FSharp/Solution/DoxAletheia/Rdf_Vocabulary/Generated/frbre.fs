namespace http.purl.org.vocab.frbr.extended.hash

open DoxAletheia

module frbre =
    let _namespace_name = "http://purl.org/vocab/frbr/extended#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A referential expression is one which has little meaning when not studied in conjunction with the expression it refers to.
    /// <see href="http://purl.org/vocab/frbr/extended#ReferentialExpression"></see></summary>
    let ReferentialExpression = _prefix "ReferentialExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#AutonomousExpression"></see>
    /// </summary>
    let AutonomousExpression = _prefix "AutonomousExpression"
    /// <summary>
    /// A referential work is one which has little meaning when not studied in conjunction with the work it refers to.
    /// <see href="http://purl.org/vocab/frbr/extended#ReferentialWork"></see></summary>
    let ReferentialWork = _prefix "ReferentialWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#AutonomousWork"></see>
    /// </summary>
    let AutonomousWork = _prefix "AutonomousWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#Expression"></see>
    /// </summary>
    let Expression = _prefix "Expression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#Work"></see>
    /// </summary>
    let Work = _prefix "Work"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#complementsExpression"></see>
    /// </summary>
    let complementsExpression = _prefix "complementsExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isRelatedToExpression"></see>
    /// </summary>
    let isRelatedToExpression = _prefix "isRelatedToExpression"
    /// <summary>
    /// Referential: cadenza, libretto, choreography, ending for unfinished work, etc.
    /// Autonomous: incidental music, musical setting for a text, pendant, etc.
    /// <see href="http://purl.org/vocab/frbr/extended#complementsWork"></see></summary>
    let complementsWork = _prefix "complementsWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isRelatedToWork"></see>
    /// </summary>
    let isRelatedToWork = _prefix "isRelatedToWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasDependentPartExpression"></see>
    /// </summary>
    let hasDependentPartExpression = _prefix "hasDependentPartExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasPartExpression"></see>
    /// </summary>
    let hasPartExpression = _prefix "hasPartExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isDependentPartOfExpression"></see>
    /// </summary>
    let isDependentPartOfExpression = _prefix "isDependentPartOfExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasDependentPartWork"></see>
    /// </summary>
    let hasDependentPartWork = _prefix "hasDependentPartWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasPartWork"></see>
    /// </summary>
    let hasPartWork = _prefix "hasPartWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasIndependentPartExpression"></see>
    /// </summary>
    let hasIndependentPartExpression = _prefix "hasIndependentPartExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isIndependentPartOfExpression"></see>
    /// </summary>
    let isIndependentPartOfExpression = _prefix "isIndependentPartOfExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasIndependentPartWork"></see>
    /// </summary>
    let hasIndependentPartWork = _prefix "hasIndependentPartWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isIndependentPartOfWork"></see>
    /// </summary>
    let isIndependentPartOfWork = _prefix "isIndependentPartOfWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isPartOfExpression"></see>
    /// </summary>
    let isPartOfExpression = _prefix "isPartOfExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasPartItem"></see>
    /// </summary>
    let hasPartItem = _prefix "hasPartItem"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isPartOfItem"></see>
    /// </summary>
    let isPartOfItem = _prefix "isPartOfItem"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#hasPartManifestation"></see>
    /// </summary>
    let hasPartManifestation = _prefix "hasPartManifestation"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isPartOfManifestation"></see>
    /// </summary>
    let isPartOfManifestation = _prefix "isPartOfManifestation"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isPartOfWork"></see>
    /// </summary>
    let isPartOfWork = _prefix "isPartOfWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReconfigurationOfItem"></see>
    /// </summary>
    let isAReconfigurationOfItem = _prefix "isAReconfigurationOfItem"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isRelatedToItem"></see>
    /// </summary>
    let isRelatedToItem = _prefix "isRelatedToItem"

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToExpression"></see>
    /// </summary>
    let isAReferentialSuccessorToExpression =
        _prefix "isAReferentialSuccessorToExpression"

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isASuccessorToExpression"></see>
    /// </summary>
    let isASuccessorToExpression = _prefix "isASuccessorToExpression"

    /// <summary>
    /// A relation between two expressions which results in the subject becoming a referential expression (i.e. one which has little meaning without the object).
    /// <see href="http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToExpression"></see></summary>
    let isReferentiallyRelatedToExpression =
        _prefix "isReferentiallyRelatedToExpression"

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToWork"></see>
    /// </summary>
    let isAReferentialSuccessorToWork = _prefix "isAReferentialSuccessorToWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToWork"></see>
    /// </summary>
    let isReferentiallyRelatedToWork = _prefix "isReferentiallyRelatedToWork"
    /// <summary>
    /// Referential: sequel, etc.
    /// Autonomous: sequel, succeeding work, etc.
    /// <see href="http://purl.org/vocab/frbr/extended#isASuccessorToWork"></see></summary>
    let isASuccessorToWork = _prefix "isASuccessorToWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReproductionOfItem"></see>
    /// </summary>
    let isAReproductionOfItem = _prefix "isAReproductionOfItem"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAReproductionOfManifestation"></see>
    /// </summary>
    let isAReproductionOfManifestation = _prefix "isAReproductionOfManifestation"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isRelatedToManifestation"></see>
    /// </summary>
    let isRelatedToManifestation = _prefix "isRelatedToManifestation"
    /// <summary>
    /// Between expressions of the SAME WORK.
    /// <see href="http://purl.org/vocab/frbr/extended#isARevisionOfExpression"></see></summary>
    let isARevisionOfExpression = _prefix "isARevisionOfExpression"
    /// <summary>
    /// A relation between two expressions which does not result in the subject becoming a referential expression (i.e. one which has little meaning without the object).
    /// <see href="http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToExpression"></see></summary>
    let isAutonomouslyRelatedToExpression = _prefix "isAutonomouslyRelatedToExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isASummaryOfExpression"></see>
    /// </summary>
    let isASummaryOfExpression = _prefix "isASummaryOfExpression"
    /// <summary>
    /// Digest, abstract, etc.
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isASummaryOfWork"></see></summary>
    let isASummaryOfWork = _prefix "isASummaryOfWork"
    /// <summary>
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToWork"></see></summary>
    let isAutonomouslyRelatedToWork = _prefix "isAutonomouslyRelatedToWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isATransformationOfExpression"></see>
    /// </summary>
    let isATransformationOfExpression = _prefix "isATransformationOfExpression"
    /// <summary>
    /// Dramatisation, novelisation, versification, screenplay, etc.
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isATransformationOfWork"></see></summary>
    let isATransformationOfWork = _prefix "isATransformationOfWork"
    /// <summary>
    /// Between expressions of the SAME WORK.
    /// <see href="http://purl.org/vocab/frbr/extended#isATranslationOfExpression"></see></summary>
    let isATranslationOfExpression = _prefix "isATranslationOfExpression"
    /// <summary>
    /// Between expressions of the SAME WORK.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnAbridgementOfExpression"></see></summary>
    let isAnAbridgementOfExpression = _prefix "isAnAbridgementOfExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAnAdaptationOfExpression"></see>
    /// </summary>
    let isAnAdaptationOfExpression = _prefix "isAnAdaptationOfExpression"
    /// <summary>
    /// Adaptation, paraphrase, free translation, variation (music), harmonisation (music), fantasy (music), etc.
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnAdaptationOfWork"></see></summary>
    let isAnAdaptationOfWork = _prefix "isAnAdaptationOfWork"
    /// <summary>
    /// Alternate is an Americanism.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnAlternativeManifestationTo"></see></summary>
    let isAnAlternativeManifestationTo = _prefix "isAnAlternativeManifestationTo"
    /// <summary>
    /// Between expressions of the SAME WORK.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnArrangementOfExpression"></see></summary>
    let isAnArrangementOfExpression = _prefix "isAnArrangementOfExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isAnImitationOfExpression"></see>
    /// </summary>
    let isAnImitationOfExpression = _prefix "isAnImitationOfExpression"
    /// <summary>
    /// Parody, imitation, travesty, etc.
    /// The subject is not dependent on the object for meaning.
    /// <see href="http://purl.org/vocab/frbr/extended#isAnImitationOfWork"></see></summary>
    let isAnImitationOfWork = _prefix "isAnImitationOfWork"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#isDependentPartOfWork"></see>
    /// </summary>
    let isDependentPartOfWork = _prefix "isDependentPartOfWork"

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#referentiallyComplementsExpression"></see>
    /// </summary>
    let referentiallyComplementsExpression =
        _prefix "referentiallyComplementsExpression"

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#referentiallyComplementsWork"></see>
    /// </summary>
    let referentiallyComplementsWork = _prefix "referentiallyComplementsWork"

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#referentiallySupplementsExpression"></see>
    /// </summary>
    let referentiallySupplementsExpression =
        _prefix "referentiallySupplementsExpression"

    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#supplementsExpression"></see>
    /// </summary>
    let supplementsExpression = _prefix "supplementsExpression"
    /// <summary>
    ///   <see href="http://purl.org/vocab/frbr/extended#referentiallySupplementsWork"></see>
    /// </summary>
    let referentiallySupplementsWork = _prefix "referentiallySupplementsWork"
    /// <summary>
    /// Referential: index, concordance, teacher's guide, gloss, supplement, appendix, etc.
    /// Autonomous: supplement, appendix, etc.
    /// <see href="http://purl.org/vocab/frbr/extended#supplementsWork"></see></summary>
    let supplementsWork = _prefix "supplementsWork"
