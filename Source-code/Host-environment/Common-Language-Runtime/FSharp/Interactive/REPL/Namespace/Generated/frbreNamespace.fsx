#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module frbre =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/vocab/frbr/extended#" "frbre"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : autonomous expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#AutonomousExpression">frbre:AutonomousExpression</a>
    /// </summary>
    let AutonomousExpression = _prefixId.prefix "AutonomousExpression"
    /// <summary>
    ///   <para>rdfs:label : autonomous work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#AutonomousWork">frbre:AutonomousWork</a>
    /// </summary>
    let AutonomousWork = _prefixId.prefix "AutonomousWork"
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:comment : A referential expression is one which has little meaning when not studied in conjunction with the expression it refers to.</para>
    ///   <para>rdfs:label : referential expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#ReferentialExpression">frbre:ReferentialExpression</a>
    /// </summary>
    let ReferentialExpression = _prefixId.prefix "ReferentialExpression"
    /// <summary>
    ///   <para>rdfs:comment : A referential work is one which has little meaning when not studied in conjunction with the work it refers to.</para>
    ///   <para>rdfs:label : referential work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#ReferentialWork">frbre:ReferentialWork</a>
    /// </summary>
    let ReferentialWork = _prefixId.prefix "ReferentialWork"
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : complements expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#complementsExpression">frbre:complementsExpression</a>
    /// </summary>
    let complementsExpression = _prefixId.prefix "complementsExpression"
    /// <summary>
    ///   <para>rdfs:comment : Referential: cadenza, libretto, choreography, ending for unfinished work, etc.
    /// Autonomous: incidental music, musical setting for a text, pendant, etc.</para>
    ///   <para>rdfs:label : complements work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#complementsWork">frbre:complementsWork</a>
    /// </summary>
    let complementsWork = _prefixId.prefix "complementsWork"
    /// <summary>
    ///   <para>rdfs:label : has dependent part expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#hasDependentPartExpression">frbre:hasDependentPartExpression</a>
    /// </summary>
    let hasDependentPartExpression = _prefixId.prefix "hasDependentPartExpression"
    /// <summary>
    ///   <para>rdfs:label : has dependent part work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#hasDependentPartWork">frbre:hasDependentPartWork</a>
    /// </summary>
    let hasDependentPartWork = _prefixId.prefix "hasDependentPartWork"
    /// <summary>
    ///   <para>rdfs:label : has independent part expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#hasIndependentPartExpression">frbre:hasIndependentPartExpression</a>
    /// </summary>
    let hasIndependentPartExpression = _prefixId.prefix "hasIndependentPartExpression"
    /// <summary>
    ///   <para>rdfs:label : has independent part work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#hasIndependentPartWork">frbre:hasIndependentPartWork</a>
    /// </summary>
    let hasIndependentPartWork = _prefixId.prefix "hasIndependentPartWork"
    /// <summary>
    ///   <para>rdfs:label : has part expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#hasPartExpression">frbre:hasPartExpression</a>
    /// </summary>
    let hasPartExpression = _prefixId.prefix "hasPartExpression"
    /// <summary>
    ///   <para>rdfs:label : has part item</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#hasPartItem">frbre:hasPartItem</a>
    /// </summary>
    let hasPartItem = _prefixId.prefix "hasPartItem"
    /// <summary>
    ///   <para>rdfs:label : has part manifestation</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#hasPartManifestation">frbre:hasPartManifestation</a>
    /// </summary>
    let hasPartManifestation = _prefixId.prefix "hasPartManifestation"
    /// <summary>
    ///   <para>rdfs:label : has part work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#hasPartWork">frbre:hasPartWork</a>
    /// </summary>
    let hasPartWork = _prefixId.prefix "hasPartWork"
    /// <summary>
    ///   <para>rdfs:label : is a reconfiguration of item</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAReconfigurationOfItem">frbre:isAReconfigurationOfItem</a>
    /// </summary>
    let isAReconfigurationOfItem = _prefixId.prefix "isAReconfigurationOfItem"

    /// <summary>
    ///   <para>rdfs:label : is a referential successor to expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToExpression">frbre:isAReferentialSuccessorToExpression</a>
    /// </summary>
    let isAReferentialSuccessorToExpression =
        _prefixId.prefix "isAReferentialSuccessorToExpression"

    /// <summary>
    ///   <para>rdfs:label : is a referential successor to work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToWork">frbre:isAReferentialSuccessorToWork</a>
    /// </summary>
    let isAReferentialSuccessorToWork = _prefixId.prefix "isAReferentialSuccessorToWork"
    /// <summary>
    ///   <para>rdfs:label : is a reproduction of item</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAReproductionOfItem">frbre:isAReproductionOfItem</a>
    /// </summary>
    let isAReproductionOfItem = _prefixId.prefix "isAReproductionOfItem"

    /// <summary>
    ///   <para>rdfs:label : is a reproduction of manifestation</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAReproductionOfManifestation">frbre:isAReproductionOfManifestation</a>
    /// </summary>
    let isAReproductionOfManifestation =
        _prefixId.prefix "isAReproductionOfManifestation"

    /// <summary>
    ///   <para>rdfs:comment : Between expressions of the SAME WORK.</para>
    ///   <para>rdfs:label : is a revision of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isARevisionOfExpression">frbre:isARevisionOfExpression</a>
    /// </summary>
    let isARevisionOfExpression = _prefixId.prefix "isARevisionOfExpression"
    /// <summary>
    ///   <para>rdfs:label : is a successor to expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isASuccessorToExpression">frbre:isASuccessorToExpression</a>
    /// </summary>
    let isASuccessorToExpression = _prefixId.prefix "isASuccessorToExpression"
    /// <summary>
    ///   <para>rdfs:comment : Referential: sequel, etc.
    /// Autonomous: sequel, succeeding work, etc.</para>
    ///   <para>rdfs:label : is a sucessor to work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isASuccessorToWork">frbre:isASuccessorToWork</a>
    /// </summary>
    let isASuccessorToWork = _prefixId.prefix "isASuccessorToWork"
    /// <summary>
    ///   <para>rdfs:label : is a summary of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isASummaryOfExpression">frbre:isASummaryOfExpression</a>
    /// </summary>
    let isASummaryOfExpression = _prefixId.prefix "isASummaryOfExpression"
    /// <summary>
    ///   <para>rdfs:comment : Digest, abstract, etc.
    /// The subject is not dependent on the object for meaning.</para>
    ///   <para>rdfs:label : is a summary of work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isASummaryOfWork">frbre:isASummaryOfWork</a>
    /// </summary>
    let isASummaryOfWork = _prefixId.prefix "isASummaryOfWork"
    /// <summary>
    ///   <para>rdfs:label : is a transformation of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isATransformationOfExpression">frbre:isATransformationOfExpression</a>
    /// </summary>
    let isATransformationOfExpression = _prefixId.prefix "isATransformationOfExpression"
    /// <summary>
    ///   <para>rdfs:comment : Dramatisation, novelisation, versification, screenplay, etc.
    /// The subject is not dependent on the object for meaning.</para>
    ///   <para>rdfs:label : is a transformation of work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isATransformationOfWork">frbre:isATransformationOfWork</a>
    /// </summary>
    let isATransformationOfWork = _prefixId.prefix "isATransformationOfWork"
    /// <summary>
    ///   <para>rdfs:comment : Between expressions of the SAME WORK.</para>
    ///   <para>rdfs:label : is a translation of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isATranslationOfExpression">frbre:isATranslationOfExpression</a>
    /// </summary>
    let isATranslationOfExpression = _prefixId.prefix "isATranslationOfExpression"
    /// <summary>
    ///   <para>rdfs:comment : Between expressions of the SAME WORK.</para>
    ///   <para>rdfs:label : is an abridgement of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAnAbridgementOfExpression">frbre:isAnAbridgementOfExpression</a>
    /// </summary>
    let isAnAbridgementOfExpression = _prefixId.prefix "isAnAbridgementOfExpression"
    /// <summary>
    ///   <para>rdfs:label : is an adaptation of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAnAdaptationOfExpression">frbre:isAnAdaptationOfExpression</a>
    /// </summary>
    let isAnAdaptationOfExpression = _prefixId.prefix "isAnAdaptationOfExpression"
    /// <summary>
    ///   <para>rdfs:comment : Adaptation, paraphrase, free translation, variation (music), harmonisation (music), fantasy (music), etc.
    /// The subject is not dependent on the object for meaning.</para>
    ///   <para>rdfs:label : is adaption of work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAnAdaptationOfWork">frbre:isAnAdaptationOfWork</a>
    /// </summary>
    let isAnAdaptationOfWork = _prefixId.prefix "isAnAdaptationOfWork"

    /// <summary>
    ///   <para>rdfs:comment : Alternate is an Americanism.</para>
    ///   <para>rdfs:label : is an alternative manifestation to</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAnAlternativeManifestationTo">frbre:isAnAlternativeManifestationTo</a>
    /// </summary>
    let isAnAlternativeManifestationTo =
        _prefixId.prefix "isAnAlternativeManifestationTo"

    /// <summary>
    ///   <para>rdfs:comment : Between expressions of the SAME WORK.</para>
    ///   <para>rdfs:label : is an arrangement of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAnArrangementOfExpression">frbre:isAnArrangementOfExpression</a>
    /// </summary>
    let isAnArrangementOfExpression = _prefixId.prefix "isAnArrangementOfExpression"
    /// <summary>
    ///   <para>rdfs:label : is an imitation of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAnImitationOfExpression">frbre:isAnImitationOfExpression</a>
    /// </summary>
    let isAnImitationOfExpression = _prefixId.prefix "isAnImitationOfExpression"
    /// <summary>
    ///   <para>rdfs:comment : Parody, imitation, travesty, etc.
    /// The subject is not dependent on the object for meaning.</para>
    ///   <para>rdfs:label : is an imitation of work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAnImitationOfWork">frbre:isAnImitationOfWork</a>
    /// </summary>
    let isAnImitationOfWork = _prefixId.prefix "isAnImitationOfWork"

    /// <summary>
    ///   <para>rdfs:comment : A relation between two expressions which does not result in the subject becoming a referential expression (i.e. one which has little meaning without the object).</para>
    ///   <para>rdfs:label : is autonomously related to expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToExpression">frbre:isAutonomouslyRelatedToExpression</a>
    /// </summary>
    let isAutonomouslyRelatedToExpression =
        _prefixId.prefix "isAutonomouslyRelatedToExpression"

    /// <summary>
    ///   <para>rdfs:comment : The subject is not dependent on the object for meaning.</para>
    ///   <para>rdfs:label : is autonomously related to work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToWork">frbre:isAutonomouslyRelatedToWork</a>
    /// </summary>
    let isAutonomouslyRelatedToWork = _prefixId.prefix "isAutonomouslyRelatedToWork"
    /// <summary>
    ///   <para>rdfs:label : is dependent part of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isDependentPartOfExpression">frbre:isDependentPartOfExpression</a>
    /// </summary>
    let isDependentPartOfExpression = _prefixId.prefix "isDependentPartOfExpression"
    /// <summary>
    ///   <para>rdfs:label : is dependent part of work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isDependentPartOfWork">frbre:isDependentPartOfWork</a>
    /// </summary>
    let isDependentPartOfWork = _prefixId.prefix "isDependentPartOfWork"
    /// <summary>
    ///   <para>rdfs:label : is independent part of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isIndependentPartOfExpression">frbre:isIndependentPartOfExpression</a>
    /// </summary>
    let isIndependentPartOfExpression = _prefixId.prefix "isIndependentPartOfExpression"
    /// <summary>
    ///   <para>rdfs:label : is independent part of work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isIndependentPartOfWork">frbre:isIndependentPartOfWork</a>
    /// </summary>
    let isIndependentPartOfWork = _prefixId.prefix "isIndependentPartOfWork"
    /// <summary>
    ///   <para>rdfs:label : is part of expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isPartOfExpression">frbre:isPartOfExpression</a>
    /// </summary>
    let isPartOfExpression = _prefixId.prefix "isPartOfExpression"
    /// <summary>
    ///   <para>rdfs:label : is part of item</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isPartOfItem">frbre:isPartOfItem</a>
    /// </summary>
    let isPartOfItem = _prefixId.prefix "isPartOfItem"
    /// <summary>
    ///   <para>rdfs:label : is part of manifestation</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isPartOfManifestation">frbre:isPartOfManifestation</a>
    /// </summary>
    let isPartOfManifestation = _prefixId.prefix "isPartOfManifestation"
    /// <summary>
    ///   <para>rdfs:label : is part of work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isPartOfWork">frbre:isPartOfWork</a>
    /// </summary>
    let isPartOfWork = _prefixId.prefix "isPartOfWork"

    /// <summary>
    ///   <para>rdfs:comment : A relation between two expressions which results in the subject becoming a referential expression (i.e. one which has little meaning without the object).</para>
    ///   <para>rdfs:label : is referentially related to expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToExpression">frbre:isReferentiallyRelatedToExpression</a>
    /// </summary>
    let isReferentiallyRelatedToExpression =
        _prefixId.prefix "isReferentiallyRelatedToExpression"

    /// <summary>
    ///   <para>rdfs:label : is referentially related to work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToWork">frbre:isReferentiallyRelatedToWork</a>
    /// </summary>
    let isReferentiallyRelatedToWork = _prefixId.prefix "isReferentiallyRelatedToWork"
    /// <summary>
    ///   <para>rdfs:label : is related to expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isRelatedToExpression">frbre:isRelatedToExpression</a>
    /// </summary>
    let isRelatedToExpression = _prefixId.prefix "isRelatedToExpression"
    /// <summary>
    ///   <para>rdfs:label : is related to item</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isRelatedToItem">frbre:isRelatedToItem</a>
    /// </summary>
    let isRelatedToItem = _prefixId.prefix "isRelatedToItem"
    /// <summary>
    ///   <para>rdfs:label : is related to manifestation</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isRelatedToManifestation">frbre:isRelatedToManifestation</a>
    /// </summary>
    let isRelatedToManifestation = _prefixId.prefix "isRelatedToManifestation"
    /// <summary>
    ///   <para>rdfs:label : is related to work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#isRelatedToWork">frbre:isRelatedToWork</a>
    /// </summary>
    let isRelatedToWork = _prefixId.prefix "isRelatedToWork"

    /// <summary>
    ///   <para>rdfs:label : referentially complements expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#referentiallyComplementsExpression">frbre:referentiallyComplementsExpression</a>
    /// </summary>
    let referentiallyComplementsExpression =
        _prefixId.prefix "referentiallyComplementsExpression"

    /// <summary>
    ///   <para>rdfs:label : referentially complements work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#referentiallyComplementsWork">frbre:referentiallyComplementsWork</a>
    /// </summary>
    let referentiallyComplementsWork = _prefixId.prefix "referentiallyComplementsWork"

    /// <summary>
    ///   <para>rdfs:label : referentially supplements expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#referentiallySupplementsExpression">frbre:referentiallySupplementsExpression</a>
    /// </summary>
    let referentiallySupplementsExpression =
        _prefixId.prefix "referentiallySupplementsExpression"

    /// <summary>
    ///   <para>rdfs:label : referentially supplements work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#referentiallySupplementsWork">frbre:referentiallySupplementsWork</a>
    /// </summary>
    let referentiallySupplementsWork = _prefixId.prefix "referentiallySupplementsWork"
    /// <summary>
    ///   <para>rdfs:label : supplements expression</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#supplementsExpression">frbre:supplementsExpression</a>
    /// </summary>
    let supplementsExpression = _prefixId.prefix "supplementsExpression"
    /// <summary>
    ///   <para>rdfs:comment : Referential: index, concordance, teacher's guide, gloss, supplement, appendix, etc.
    /// Autonomous: supplement, appendix, etc.</para>
    ///   <para>rdfs:label : supplements work</para>
    ///   <a href="http://purl.org/vocab/frbr/extended#supplementsWork">frbre:supplementsWork</a>
    /// </summary>
    let supplementsWork = _prefixId.prefix "supplementsWork"
