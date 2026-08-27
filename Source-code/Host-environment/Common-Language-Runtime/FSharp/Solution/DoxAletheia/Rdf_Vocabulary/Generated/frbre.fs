namespace http.purl.org.vocab.frbr.extended.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frbre =
    let _namespace_iri = Namespace_Iri frbre |> NamespaceIRI
    /// <summary>
    ///   <para>frbre:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#">http://purl.org/vocab/frbr/extended#</seealso>
    let _prefix_iri = Prefixed_Name(frbre, "") |> PrefixedName

    /// <summary>
    ///   <para>frbre:AutonomousExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"autonomous expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#AutonomousExpression">http://purl.org/vocab/frbr/extended#AutonomousExpression</seealso>
    let AutonomousExpression =
        Prefixed_Name(frbre, "AutonomousExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:AutonomousWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"autonomous work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#AutonomousWork">http://purl.org/vocab/frbr/extended#AutonomousWork</seealso>
    let AutonomousWork = Prefixed_Name(frbre, "AutonomousWork") |> PrefixedName
    /// <summary>
    ///   <para>frbre:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#Expression">http://purl.org/vocab/frbr/extended#Expression</seealso>
    let Expression = Prefixed_Name(frbre, "Expression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:ReferentialExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A referential expression is one which has little meaning when not studied in conjunction with the expression it refers to."</para>
    /// labels<para>"referential expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#ReferentialExpression">http://purl.org/vocab/frbr/extended#ReferentialExpression</seealso>
    let ReferentialExpression =
        Prefixed_Name(frbre, "ReferentialExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:ReferentialWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A referential work is one which has little meaning when not studied in conjunction with the work it refers to."</para>
    /// labels<para>"referential work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#ReferentialWork">http://purl.org/vocab/frbr/extended#ReferentialWork</seealso>
    let ReferentialWork = Prefixed_Name(frbre, "ReferentialWork") |> PrefixedName
    /// <summary>
    ///   <para>frbre:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#Work">http://purl.org/vocab/frbr/extended#Work</seealso>
    let Work = Prefixed_Name(frbre, "Work") |> PrefixedName

    /// <summary>
    ///   <para>frbre:complementsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"complements expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#complementsExpression">http://purl.org/vocab/frbr/extended#complementsExpression</seealso>
    let complementsExpression =
        Prefixed_Name(frbre, "complementsExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:complementsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Referential: cadenza, libretto, choreography, ending for unfinished work, etc.
    /// Autonomous: incidental music, musical setting for a text, pendant, etc."</para>
    /// labels<para>"complements work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#complementsWork">http://purl.org/vocab/frbr/extended#complementsWork</seealso>
    let complementsWork = Prefixed_Name(frbre, "complementsWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:hasDependentPartExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dependent part expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#hasDependentPartExpression">http://purl.org/vocab/frbr/extended#hasDependentPartExpression</seealso>
    let hasDependentPartExpression =
        Prefixed_Name(frbre, "hasDependentPartExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:hasDependentPartWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dependent part work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#hasDependentPartWork">http://purl.org/vocab/frbr/extended#hasDependentPartWork</seealso>
    let hasDependentPartWork =
        Prefixed_Name(frbre, "hasDependentPartWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:hasIndependentPartExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has independent part expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#hasIndependentPartExpression">http://purl.org/vocab/frbr/extended#hasIndependentPartExpression</seealso>
    let hasIndependentPartExpression =
        Prefixed_Name(frbre, "hasIndependentPartExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:hasIndependentPartWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has independent part work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#hasIndependentPartWork">http://purl.org/vocab/frbr/extended#hasIndependentPartWork</seealso>
    let hasIndependentPartWork =
        Prefixed_Name(frbre, "hasIndependentPartWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:hasPartExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has part expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#hasPartExpression">http://purl.org/vocab/frbr/extended#hasPartExpression</seealso>
    let hasPartExpression = Prefixed_Name(frbre, "hasPartExpression") |> PrefixedName
    /// <summary>
    ///   <para>frbre:hasPartItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has part item"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#hasPartItem">http://purl.org/vocab/frbr/extended#hasPartItem</seealso>
    let hasPartItem = Prefixed_Name(frbre, "hasPartItem") |> PrefixedName

    /// <summary>
    ///   <para>frbre:hasPartManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has part manifestation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#hasPartManifestation">http://purl.org/vocab/frbr/extended#hasPartManifestation</seealso>
    let hasPartManifestation =
        Prefixed_Name(frbre, "hasPartManifestation") |> PrefixedName

    /// <summary>
    ///   <para>frbre:hasPartWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has part work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#hasPartWork">http://purl.org/vocab/frbr/extended#hasPartWork</seealso>
    let hasPartWork = Prefixed_Name(frbre, "hasPartWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAReconfigurationOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a reconfiguration of item"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAReconfigurationOfItem">http://purl.org/vocab/frbr/extended#isAReconfigurationOfItem</seealso>
    let isAReconfigurationOfItem =
        Prefixed_Name(frbre, "isAReconfigurationOfItem") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAReferentialSuccessorToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a referential successor to expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToExpression">http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToExpression</seealso>
    let isAReferentialSuccessorToExpression =
        Prefixed_Name(frbre, "isAReferentialSuccessorToExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAReferentialSuccessorToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a referential successor to work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToWork">http://purl.org/vocab/frbr/extended#isAReferentialSuccessorToWork</seealso>
    let isAReferentialSuccessorToWork =
        Prefixed_Name(frbre, "isAReferentialSuccessorToWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAReproductionOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a reproduction of item"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAReproductionOfItem">http://purl.org/vocab/frbr/extended#isAReproductionOfItem</seealso>
    let isAReproductionOfItem =
        Prefixed_Name(frbre, "isAReproductionOfItem") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAReproductionOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a reproduction of manifestation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAReproductionOfManifestation">http://purl.org/vocab/frbr/extended#isAReproductionOfManifestation</seealso>
    let isAReproductionOfManifestation =
        Prefixed_Name(frbre, "isAReproductionOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isARevisionOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Between expressions of the SAME WORK."</para>
    /// labels<para>"is a revision of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isARevisionOfExpression">http://purl.org/vocab/frbr/extended#isARevisionOfExpression</seealso>
    let isARevisionOfExpression =
        Prefixed_Name(frbre, "isARevisionOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isASuccessorToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a successor to expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isASuccessorToExpression">http://purl.org/vocab/frbr/extended#isASuccessorToExpression</seealso>
    let isASuccessorToExpression =
        Prefixed_Name(frbre, "isASuccessorToExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isASuccessorToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Referential: sequel, etc.
    /// Autonomous: sequel, succeeding work, etc."</para>
    /// labels<para>"is a sucessor to work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isASuccessorToWork">http://purl.org/vocab/frbr/extended#isASuccessorToWork</seealso>
    let isASuccessorToWork = Prefixed_Name(frbre, "isASuccessorToWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isASummaryOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a summary of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isASummaryOfExpression">http://purl.org/vocab/frbr/extended#isASummaryOfExpression</seealso>
    let isASummaryOfExpression =
        Prefixed_Name(frbre, "isASummaryOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isASummaryOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Digest, abstract, etc.
    /// The subject is not dependent on the object for meaning."</para>
    /// labels<para>"is a summary of work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isASummaryOfWork">http://purl.org/vocab/frbr/extended#isASummaryOfWork</seealso>
    let isASummaryOfWork = Prefixed_Name(frbre, "isASummaryOfWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isATransformationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is a transformation of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isATransformationOfExpression">http://purl.org/vocab/frbr/extended#isATransformationOfExpression</seealso>
    let isATransformationOfExpression =
        Prefixed_Name(frbre, "isATransformationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isATransformationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Dramatisation, novelisation, versification, screenplay, etc.
    /// The subject is not dependent on the object for meaning."</para>
    /// labels<para>"is a transformation of work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isATransformationOfWork">http://purl.org/vocab/frbr/extended#isATransformationOfWork</seealso>
    let isATransformationOfWork =
        Prefixed_Name(frbre, "isATransformationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isATranslationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Between expressions of the SAME WORK."</para>
    /// labels<para>"is a translation of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isATranslationOfExpression">http://purl.org/vocab/frbr/extended#isATranslationOfExpression</seealso>
    let isATranslationOfExpression =
        Prefixed_Name(frbre, "isATranslationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAnAbridgementOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Between expressions of the SAME WORK."</para>
    /// labels<para>"is an abridgement of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAnAbridgementOfExpression">http://purl.org/vocab/frbr/extended#isAnAbridgementOfExpression</seealso>
    let isAnAbridgementOfExpression =
        Prefixed_Name(frbre, "isAnAbridgementOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAnAdaptationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is an adaptation of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAnAdaptationOfExpression">http://purl.org/vocab/frbr/extended#isAnAdaptationOfExpression</seealso>
    let isAnAdaptationOfExpression =
        Prefixed_Name(frbre, "isAnAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAnAdaptationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Adaptation, paraphrase, free translation, variation (music), harmonisation (music), fantasy (music), etc.
    /// The subject is not dependent on the object for meaning."</para>
    /// labels<para>"is adaption of work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAnAdaptationOfWork">http://purl.org/vocab/frbr/extended#isAnAdaptationOfWork</seealso>
    let isAnAdaptationOfWork =
        Prefixed_Name(frbre, "isAnAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAnAlternativeManifestationTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Alternate is an Americanism."</para>
    /// labels<para>"is an alternative manifestation to"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAnAlternativeManifestationTo">http://purl.org/vocab/frbr/extended#isAnAlternativeManifestationTo</seealso>
    let isAnAlternativeManifestationTo =
        Prefixed_Name(frbre, "isAnAlternativeManifestationTo") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAnArrangementOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Between expressions of the SAME WORK."</para>
    /// labels<para>"is an arrangement of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAnArrangementOfExpression">http://purl.org/vocab/frbr/extended#isAnArrangementOfExpression</seealso>
    let isAnArrangementOfExpression =
        Prefixed_Name(frbre, "isAnArrangementOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAnImitationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is an imitation of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAnImitationOfExpression">http://purl.org/vocab/frbr/extended#isAnImitationOfExpression</seealso>
    let isAnImitationOfExpression =
        Prefixed_Name(frbre, "isAnImitationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAnImitationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Parody, imitation, travesty, etc.
    /// The subject is not dependent on the object for meaning."</para>
    /// labels<para>"is an imitation of work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAnImitationOfWork">http://purl.org/vocab/frbr/extended#isAnImitationOfWork</seealso>
    let isAnImitationOfWork =
        Prefixed_Name(frbre, "isAnImitationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAutonomouslyRelatedToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between two expressions which does not result in the subject becoming a referential expression (i.e. one which has little meaning without the object)."</para>
    /// labels<para>"is autonomously related to expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToExpression">http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToExpression</seealso>
    let isAutonomouslyRelatedToExpression =
        Prefixed_Name(frbre, "isAutonomouslyRelatedToExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isAutonomouslyRelatedToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject is not dependent on the object for meaning."</para>
    /// labels<para>"is autonomously related to work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToWork">http://purl.org/vocab/frbr/extended#isAutonomouslyRelatedToWork</seealso>
    let isAutonomouslyRelatedToWork =
        Prefixed_Name(frbre, "isAutonomouslyRelatedToWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isDependentPartOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is dependent part of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isDependentPartOfExpression">http://purl.org/vocab/frbr/extended#isDependentPartOfExpression</seealso>
    let isDependentPartOfExpression =
        Prefixed_Name(frbre, "isDependentPartOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isDependentPartOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is dependent part of work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isDependentPartOfWork">http://purl.org/vocab/frbr/extended#isDependentPartOfWork</seealso>
    let isDependentPartOfWork =
        Prefixed_Name(frbre, "isDependentPartOfWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isIndependentPartOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is independent part of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isIndependentPartOfExpression">http://purl.org/vocab/frbr/extended#isIndependentPartOfExpression</seealso>
    let isIndependentPartOfExpression =
        Prefixed_Name(frbre, "isIndependentPartOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isIndependentPartOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is independent part of work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isIndependentPartOfWork">http://purl.org/vocab/frbr/extended#isIndependentPartOfWork</seealso>
    let isIndependentPartOfWork =
        Prefixed_Name(frbre, "isIndependentPartOfWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isPartOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is part of expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isPartOfExpression">http://purl.org/vocab/frbr/extended#isPartOfExpression</seealso>
    let isPartOfExpression = Prefixed_Name(frbre, "isPartOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>frbre:isPartOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is part of item"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isPartOfItem">http://purl.org/vocab/frbr/extended#isPartOfItem</seealso>
    let isPartOfItem = Prefixed_Name(frbre, "isPartOfItem") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isPartOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is part of manifestation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isPartOfManifestation">http://purl.org/vocab/frbr/extended#isPartOfManifestation</seealso>
    let isPartOfManifestation =
        Prefixed_Name(frbre, "isPartOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isPartOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is part of work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isPartOfWork">http://purl.org/vocab/frbr/extended#isPartOfWork</seealso>
    let isPartOfWork = Prefixed_Name(frbre, "isPartOfWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isReferentiallyRelatedToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between two expressions which results in the subject becoming a referential expression (i.e. one which has little meaning without the object)."</para>
    /// labels<para>"is referentially related to expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToExpression">http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToExpression</seealso>
    let isReferentiallyRelatedToExpression =
        Prefixed_Name(frbre, "isReferentiallyRelatedToExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isReferentiallyRelatedToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is referentially related to work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToWork">http://purl.org/vocab/frbr/extended#isReferentiallyRelatedToWork</seealso>
    let isReferentiallyRelatedToWork =
        Prefixed_Name(frbre, "isReferentiallyRelatedToWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isRelatedToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is related to expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isRelatedToExpression">http://purl.org/vocab/frbr/extended#isRelatedToExpression</seealso>
    let isRelatedToExpression =
        Prefixed_Name(frbre, "isRelatedToExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isRelatedToItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is related to item"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isRelatedToItem">http://purl.org/vocab/frbr/extended#isRelatedToItem</seealso>
    let isRelatedToItem = Prefixed_Name(frbre, "isRelatedToItem") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isRelatedToManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is related to manifestation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isRelatedToManifestation">http://purl.org/vocab/frbr/extended#isRelatedToManifestation</seealso>
    let isRelatedToManifestation =
        Prefixed_Name(frbre, "isRelatedToManifestation") |> PrefixedName

    /// <summary>
    ///   <para>frbre:isRelatedToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is related to work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#isRelatedToWork">http://purl.org/vocab/frbr/extended#isRelatedToWork</seealso>
    let isRelatedToWork = Prefixed_Name(frbre, "isRelatedToWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:referentiallyComplementsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"referentially complements expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#referentiallyComplementsExpression">http://purl.org/vocab/frbr/extended#referentiallyComplementsExpression</seealso>
    let referentiallyComplementsExpression =
        Prefixed_Name(frbre, "referentiallyComplementsExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:referentiallyComplementsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"referentially complements work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#referentiallyComplementsWork">http://purl.org/vocab/frbr/extended#referentiallyComplementsWork</seealso>
    let referentiallyComplementsWork =
        Prefixed_Name(frbre, "referentiallyComplementsWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:referentiallySupplementsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"referentially supplements expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#referentiallySupplementsExpression">http://purl.org/vocab/frbr/extended#referentiallySupplementsExpression</seealso>
    let referentiallySupplementsExpression =
        Prefixed_Name(frbre, "referentiallySupplementsExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:referentiallySupplementsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"referentially supplements work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#referentiallySupplementsWork">http://purl.org/vocab/frbr/extended#referentiallySupplementsWork</seealso>
    let referentiallySupplementsWork =
        Prefixed_Name(frbre, "referentiallySupplementsWork") |> PrefixedName

    /// <summary>
    ///   <para>frbre:supplementsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"supplements expression"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#supplementsExpression">http://purl.org/vocab/frbr/extended#supplementsExpression</seealso>
    let supplementsExpression =
        Prefixed_Name(frbre, "supplementsExpression") |> PrefixedName

    /// <summary>
    ///   <para>frbre:supplementsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Referential: index, concordance, teacher's guide, gloss, supplement, appendix, etc.
    /// Autonomous: supplement, appendix, etc."</para>
    /// labels<para>"supplements work"</para></remarks>
    /// <seealso href="http://purl.org/vocab/frbr/extended#supplementsWork">http://purl.org/vocab/frbr/extended#supplementsWork</seealso>
    let supplementsWork = Prefixed_Name(frbre, "supplementsWork") |> PrefixedName
