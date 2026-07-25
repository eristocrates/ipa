namespace http.rdaregistry.info.Elements.m.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdam =
    let _namespace_iri = Namespace_Iri rdam |> NamespaceIRI
    /// <summary>
    ///   <para>rdam:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/">http://rdaregistry.info/Elements/m/</seealso>
    let _prefix_iri = Prefixed_Name(rdam, "") |> PrefixedName
    /// <summary>
    ///   <para>rdam:modeOfIssuance.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/modeOfIssuance.en">http://rdaregistry.info/Elements/m/modeOfIssuance.en</seealso>
    let ``modeOfIssuance.en`` = Prefixed_Name(rdam, "modeOfIssuance.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has identifier for the manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30004">http://rdaregistry.info/Elements/m/P30004</seealso>
    let P30004 = Prefixed_Name(rdam, "P30004") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has preferred citation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30005">http://rdaregistry.info/Elements/m/P30005</seealso>
    let P30005 = Prefixed_Name(rdam, "P30005") |> PrefixedName

    /// <summary>
    ///   <para>rdam:containedInManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/containedInManifestation.en">http://rdaregistry.info/Elements/m/containedInManifestation.en</seealso>
    let ``containedInManifestation.en`` =
        Prefixed_Name(rdam, "containedInManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is facsimile (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30031">http://rdaregistry.info/Elements/m/P30031</seealso>
    let P30031 = Prefixed_Name(rdam, "P30031") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is preservation facsimile of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30045">http://rdaregistry.info/Elements/m/P30045</seealso>
    let P30045 = Prefixed_Name(rdam, "P30045") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is reproduction of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30043">http://rdaregistry.info/Elements/m/P30043</seealso>
    let P30043 = Prefixed_Name(rdam, "P30043") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is mirror site</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30028">http://rdaregistry.info/Elements/m/P30028</seealso>
    let P30028 = Prefixed_Name(rdam, "P30028") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is also issued as</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30026">http://rdaregistry.info/Elements/m/P30026</seealso>
    let P30026 = Prefixed_Name(rdam, "P30026") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30044">http://rdaregistry.info/Elements/m/P30044</seealso>
    let P30044 = Prefixed_Name(rdam, "P30044") |> PrefixedName

    /// <summary>
    ///   <para>rdam:preservationFacsimileOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/preservationFacsimileOfManifestation.en">http://rdaregistry.info/Elements/m/preservationFacsimileOfManifestation.en</seealso>
    let ``preservationFacsimileOfManifestation.en`` =
        Prefixed_Name(rdam, "preservationFacsimileOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30203</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel title proper</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30203">http://rdaregistry.info/Elements/m/P30203</seealso>
    let P30203 = Prefixed_Name(rdam, "P30203") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30142</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other title information</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30142">http://rdaregistry.info/Elements/m/P30142</seealso>
    let P30142 = Prefixed_Name(rdam, "P30142") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30168</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has frequency</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30168">http://rdaregistry.info/Elements/m/P30168</seealso>
    let P30168 = Prefixed_Name(rdam, "P30168") |> PrefixedName

    /// <summary>
    ///   <para>rdam:generationOfMotionPictureFilm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/generationOfMotionPictureFilm.en">http://rdaregistry.info/Elements/m/generationOfMotionPictureFilm.en</seealso>
    let ``generationOfMotionPictureFilm.en`` =
        Prefixed_Name(rdam, "generationOfMotionPictureFilm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30196</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has polarity</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30196">http://rdaregistry.info/Elements/m/P30196</seealso>
    let P30196 = Prefixed_Name(rdam, "P30196") |> PrefixedName
    /// <summary>
    ///   <para>rdam:polarity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/polarity.en">http://rdaregistry.info/Elements/m/polarity.en</seealso>
    let ``polarity.en`` = Prefixed_Name(rdam, "polarity.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30198</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has reduction ratio</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30198">http://rdaregistry.info/Elements/m/P30198</seealso>
    let P30198 = Prefixed_Name(rdam, "P30198") |> PrefixedName
    /// <summary>
    ///   <para>rdam:fontSize.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/fontSize.en">http://rdaregistry.info/Elements/m/fontSize.en</seealso>
    let ``fontSize.en`` = Prefixed_Name(rdam, "fontSize.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:playingSpeed.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/playingSpeed.en">http://rdaregistry.info/Elements/m/playingSpeed.en</seealso>
    let ``playingSpeed.en`` = Prefixed_Name(rdam, "playingSpeed.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelTitleProper.en">http://rdaregistry.info/Elements/m/parallelTitleProper.en</seealso>
    let ``parallelTitleProper.en`` =
        Prefixed_Name(rdam, "parallelTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30205</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel title proper of subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30205">http://rdaregistry.info/Elements/m/P30205</seealso>
    let P30205 = Prefixed_Name(rdam, "P30205") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelTitleProperOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelTitleProperOfSubseries.en">http://rdaregistry.info/Elements/m/parallelTitleProperOfSubseries.en</seealso>
    let ``parallelTitleProperOfSubseries.en`` =
        Prefixed_Name(rdam, "parallelTitleProperOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:recordingMedium.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/recordingMedium.en">http://rdaregistry.info/Elements/m/recordingMedium.en</seealso>
    let ``recordingMedium.en`` =
        Prefixed_Name(rdam, "recordingMedium.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:accompanyingManifestationRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/accompanyingManifestationRelationship.en">http://rdaregistry.info/Elements/m/accompanyingManifestationRelationship.en</seealso>
    let ``accompanyingManifestationRelationship.en`` =
        Prefixed_Name(rdam, "accompanyingManifestationRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30211</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30211">http://rdaregistry.info/Elements/m/P30211</seealso>
    let P30211 = Prefixed_Name(rdam, "P30211") |> PrefixedName

    /// <summary>
    ///   <para>rdam:equivalentManifestationRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/equivalentManifestationRelationship.en">http://rdaregistry.info/Elements/m/equivalentManifestationRelationship.en</seealso>
    let ``equivalentManifestationRelationship.en`` =
        Prefixed_Name(rdam, "equivalentManifestationRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfPolarity.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfPolarity.en">http://rdaregistry.info/Elements/m/detailsOfPolarity.en</seealso>
    let ``detailsOfPolarity.en`` =
        Prefixed_Name(rdam, "detailsOfPolarity.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30237</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of presentation format</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30237">http://rdaregistry.info/Elements/m/P30237</seealso>
    let P30237 = Prefixed_Name(rdam, "P30237") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfPresentationFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfPresentationFormat.en">http://rdaregistry.info/Elements/m/detailsOfPresentationFormat.en</seealso>
    let ``detailsOfPresentationFormat.en`` =
        Prefixed_Name(rdam, "detailsOfPresentationFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:carrierType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/carrierType.en">http://rdaregistry.info/Elements/m/carrierType.en</seealso>
    let ``carrierType.en`` = Prefixed_Name(rdam, "carrierType.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has media type</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30002">http://rdaregistry.info/Elements/m/P30002</seealso>
    let P30002 = Prefixed_Name(rdam, "P30002") |> PrefixedName

    /// <summary>
    ///   <para>rdam:digitalTransferManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/digitalTransferManifestation.en">http://rdaregistry.info/Elements/m/digitalTransferManifestation.en</seealso>
    let ``digitalTransferManifestation.en`` =
        Prefixed_Name(rdam, "digitalTransferManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30137</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30137">http://rdaregistry.info/Elements/m/P30137</seealso>
    let P30137 = Prefixed_Name(rdam, "P30137") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30214</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on carrier</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30214">http://rdaregistry.info/Elements/m/P30214</seealso>
    let P30214 = Prefixed_Name(rdam, "P30214") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on manufacture statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30053">http://rdaregistry.info/Elements/m/P30053</seealso>
    let P30053 = Prefixed_Name(rdam, "P30053") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnManufactureStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnManufactureStatement.en">http://rdaregistry.info/Elements/m/noteOnManufactureStatement.en</seealso>
    let ``noteOnManufactureStatement.en`` =
        Prefixed_Name(rdam, "noteOnManufactureStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnProductionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnProductionStatement.en">http://rdaregistry.info/Elements/m/noteOnProductionStatement.en</seealso>
    let ``noteOnProductionStatement.en`` =
        Prefixed_Name(rdam, "noteOnProductionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30055</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on publication statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30055">http://rdaregistry.info/Elements/m/P30055</seealso>
    let P30055 = Prefixed_Name(rdam, "P30055") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnPublicationStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnPublicationStatement.en">http://rdaregistry.info/Elements/m/noteOnPublicationStatement.en</seealso>
    let ``noteOnPublicationStatement.en`` =
        Prefixed_Name(rdam, "noteOnPublicationStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnFrequency.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnFrequency.en">http://rdaregistry.info/Elements/m/noteOnFrequency.en</seealso>
    let ``noteOnFrequency.en`` =
        Prefixed_Name(rdam, "noteOnFrequency.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnStatementOfResponsibility.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnStatementOfResponsibility.en">http://rdaregistry.info/Elements/m/noteOnStatementOfResponsibility.en</seealso>
    let ``noteOnStatementOfResponsibility.en`` =
        Prefixed_Name(rdam, "noteOnStatementOfResponsibility.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on dimensions of manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30060">http://rdaregistry.info/Elements/m/P30060</seealso>
    let P30060 = Prefixed_Name(rdam, "P30060") |> PrefixedName

    /// <summary>
    ///   <para>rdam:statementOfResponsibility.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/statementOfResponsibility.en">http://rdaregistry.info/Elements/m/statementOfResponsibility.en</seealso>
    let ``statementOfResponsibility.en`` =
        Prefixed_Name(rdam, "statementOfResponsibility.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30131</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has abbreviated title</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30131">http://rdaregistry.info/Elements/m/P30131</seealso>
    let P30131 = Prefixed_Name(rdam, "P30131") |> PrefixedName

    /// <summary>
    ///   <para>rdam:abbreviatedTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/abbreviatedTitle.en">http://rdaregistry.info/Elements/m/abbreviatedTitle.en</seealso>
    let ``abbreviatedTitle.en`` =
        Prefixed_Name(rdam, "abbreviatedTitle.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30147</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has numeric and/or alphabetic designation of first issue or part of sequence</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30147">http://rdaregistry.info/Elements/m/P30147</seealso>
    let P30147 = Prefixed_Name(rdam, "P30147") |> PrefixedName

    /// <summary>
    ///   <para>rdam:numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/m/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en</seealso>
    let ``numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdam, "numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30197</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has book format</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30197">http://rdaregistry.info/Elements/m/P30197</seealso>
    let P30197 = Prefixed_Name(rdam, "P30197") |> PrefixedName
    /// <summary>
    ///   <para>rdam:bookFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/bookFormat.en">http://rdaregistry.info/Elements/m/bookFormat.en</seealso>
    let ``bookFormat.en`` = Prefixed_Name(rdam, "bookFormat.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:reductionRatio.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/reductionRatio.en">http://rdaregistry.info/Elements/m/reductionRatio.en</seealso>
    let ``reductionRatio.en`` = Prefixed_Name(rdam, "reductionRatio.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30199</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has font size</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30199">http://rdaregistry.info/Elements/m/P30199</seealso>
    let P30199 = Prefixed_Name(rdam, "P30199") |> PrefixedName

    /// <summary>
    ///   <para>rdam:projectionSpeed.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/projectionSpeed.en">http://rdaregistry.info/Elements/m/projectionSpeed.en</seealso>
    let ``projectionSpeed.en`` =
        Prefixed_Name(rdam, "projectionSpeed.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:encodedBitrate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/encodedBitrate.en">http://rdaregistry.info/Elements/m/encodedBitrate.en</seealso>
    let ``encodedBitrate.en`` = Prefixed_Name(rdam, "encodedBitrate.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30204</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel title proper of series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30204">http://rdaregistry.info/Elements/m/P30204</seealso>
    let P30204 = Prefixed_Name(rdam, "P30204") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelTitleProperOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelTitleProperOfSeries.en">http://rdaregistry.info/Elements/m/parallelTitleProperOfSeries.en</seealso>
    let ``parallelTitleProperOfSeries.en`` =
        Prefixed_Name(rdam, "parallelTitleProperOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30207</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30207">http://rdaregistry.info/Elements/m/P30207</seealso>
    let P30207 = Prefixed_Name(rdam, "P30207") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30208</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has base material</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30208">http://rdaregistry.info/Elements/m/P30208</seealso>
    let P30208 = Prefixed_Name(rdam, "P30208") |> PrefixedName
    /// <summary>
    ///   <para>rdam:baseMaterial.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/baseMaterial.en">http://rdaregistry.info/Elements/m/baseMaterial.en</seealso>
    let ``baseMaterial.en`` = Prefixed_Name(rdam, "baseMaterial.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:keyTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/keyTitle.en">http://rdaregistry.info/Elements/m/keyTitle.en</seealso>
    let ``keyTitle.en`` = Prefixed_Name(rdam, "keyTitle.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:wholePartManifestationRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/wholePartManifestationRelationship.en">http://rdaregistry.info/Elements/m/wholePartManifestationRelationship.en</seealso>
    let ``wholePartManifestationRelationship.en`` =
        Prefixed_Name(rdam, "wholePartManifestationRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnCarrier.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnCarrier.en">http://rdaregistry.info/Elements/m/noteOnCarrier.en</seealso>
    let ``noteOnCarrier.en`` = Prefixed_Name(rdam, "noteOnCarrier.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:papermaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/papermaker.en">http://rdaregistry.info/Elements/m/papermaker.en</seealso>
    let ``papermaker.en`` = Prefixed_Name(rdam, "papermaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30216</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of applied material</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30216">http://rdaregistry.info/Elements/m/P30216</seealso>
    let P30216 = Prefixed_Name(rdam, "P30216") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30223</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of emulsion on microfilm and microfiche</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30223">http://rdaregistry.info/Elements/m/P30223</seealso>
    let P30223 = Prefixed_Name(rdam, "P30223") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfAppliedMaterial.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfAppliedMaterial.en">http://rdaregistry.info/Elements/m/detailsOfAppliedMaterial.en</seealso>
    let ``detailsOfAppliedMaterial.en`` =
        Prefixed_Name(rdam, "detailsOfAppliedMaterial.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30219</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of broadcast standard</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30219">http://rdaregistry.info/Elements/m/P30219</seealso>
    let P30219 = Prefixed_Name(rdam, "P30219") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfBroadcastStandard.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfBroadcastStandard.en">http://rdaregistry.info/Elements/m/detailsOfBroadcastStandard.en</seealso>
    let ``detailsOfBroadcastStandard.en`` =
        Prefixed_Name(rdam, "detailsOfBroadcastStandard.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30250</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of video characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30250">http://rdaregistry.info/Elements/m/P30250</seealso>
    let P30250 = Prefixed_Name(rdam, "P30250") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30220</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of configuration of playback channels</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30220">http://rdaregistry.info/Elements/m/P30220</seealso>
    let P30220 = Prefixed_Name(rdam, "P30220") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfProjectionSpeed.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfProjectionSpeed.en">http://rdaregistry.info/Elements/m/detailsOfProjectionSpeed.en</seealso>
    let ``detailsOfProjectionSpeed.en`` =
        Prefixed_Name(rdam, "detailsOfProjectionSpeed.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30243</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of recording medium</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30243">http://rdaregistry.info/Elements/m/P30243</seealso>
    let P30243 = Prefixed_Name(rdam, "P30243") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has mode of issuance</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30003">http://rdaregistry.info/Elements/m/P30003</seealso>
    let P30003 = Prefixed_Name(rdam, "P30003") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has plate number for music</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30066">http://rdaregistry.info/Elements/m/P30066</seealso>
    let P30066 = Prefixed_Name(rdam, "P30066") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on distribution statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30052">http://rdaregistry.info/Elements/m/P30052</seealso>
    let P30052 = Prefixed_Name(rdam, "P30052") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on production statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30054">http://rdaregistry.info/Elements/m/P30054</seealso>
    let P30054 = Prefixed_Name(rdam, "P30054") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on frequency</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30056">http://rdaregistry.info/Elements/m/P30056</seealso>
    let P30056 = Prefixed_Name(rdam, "P30056") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on statement of responsibility</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30057">http://rdaregistry.info/Elements/m/P30057</seealso>
    let P30057 = Prefixed_Name(rdam, "P30057") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on series statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30058">http://rdaregistry.info/Elements/m/P30058</seealso>
    let P30058 = Prefixed_Name(rdam, "P30058") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnSeriesStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnSeriesStatement.en">http://rdaregistry.info/Elements/m/noteOnSeriesStatement.en</seealso>
    let ``noteOnSeriesStatement.en`` =
        Prefixed_Name(rdam, "noteOnSeriesStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30073</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has caster</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30073">http://rdaregistry.info/Elements/m/P30073</seealso>
    let P30073 = Prefixed_Name(rdam, "P30073") |> PrefixedName
    /// <summary>
    ///   <para>rdam:caster.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/caster.en">http://rdaregistry.info/Elements/m/caster.en</seealso>
    let ``caster.en`` = Prefixed_Name(rdam, "caster.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelPlaceOfManufacture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelPlaceOfManufacture.en">http://rdaregistry.info/Elements/m/parallelPlaceOfManufacture.en</seealso>
    let ``parallelPlaceOfManufacture.en`` =
        Prefixed_Name(rdam, "parallelPlaceOfManufacture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:reprintOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/reprintOfManifestation.en">http://rdaregistry.info/Elements/m/reprintOfManifestation.en</seealso>
    let ``reprintOfManifestation.en`` =
        Prefixed_Name(rdam, "reprintOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30095</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel publisher’s name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30095">http://rdaregistry.info/Elements/m/P30095</seealso>
    let P30095 = Prefixed_Name(rdam, "P30095") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelPublishersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelPublishersName.en">http://rdaregistry.info/Elements/m/parallelPublishersName.en</seealso>
    let ``parallelPublishersName.en`` =
        Prefixed_Name(rdam, "parallelPublishersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30097</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has alternative numeric and/or alphabetic designation of first issue or part of sequence</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30097">http://rdaregistry.info/Elements/m/P30097</seealso>
    let P30097 = Prefixed_Name(rdam, "P30097") |> PrefixedName

    /// <summary>
    ///   <para>rdam:alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/m/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en</seealso>
    let ``alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdam, "alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30099</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has alternative chronological designation of first issue or part of sequence</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30099">http://rdaregistry.info/Elements/m/P30099</seealso>
    let P30099 = Prefixed_Name(rdam, "P30099") |> PrefixedName

    /// <summary>
    ///   <para>rdam:statementOfResponsibilityRelatingToTheEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToTheEdition.en">http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToTheEdition.en</seealso>
    let ``statementOfResponsibilityRelatingToTheEdition.en`` =
        Prefixed_Name(rdam, "statementOfResponsibilityRelatingToTheEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:electronicReproductionOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/electronicReproductionOfManifestation.en">http://rdaregistry.info/Elements/m/electronicReproductionOfManifestation.en</seealso>
    let ``electronicReproductionOfManifestation.en`` =
        Prefixed_Name(rdam, "electronicReproductionOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelOtherTitleInformationOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelOtherTitleInformationOfSubseries.en">http://rdaregistry.info/Elements/m/parallelOtherTitleInformationOfSubseries.en</seealso>
    let ``parallelOtherTitleInformationOfSubseries.en`` =
        Prefixed_Name(rdam, "parallelOtherTitleInformationOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:titleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/titleProper.en">http://rdaregistry.info/Elements/m/titleProper.en</seealso>
    let ``titleProper.en`` = Prefixed_Name(rdam, "titleProper.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30176</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has publisher’s name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30176">http://rdaregistry.info/Elements/m/P30176</seealso>
    let P30176 = Prefixed_Name(rdam, "P30176") |> PrefixedName
    /// <summary>
    ///   <para>rdam:publishersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/publishersName.en">http://rdaregistry.info/Elements/m/publishersName.en</seealso>
    let ``publishersName.en`` = Prefixed_Name(rdam, "publishersName.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30177</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has extent of cartographic resource</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30177">http://rdaregistry.info/Elements/m/P30177</seealso>
    let P30177 = Prefixed_Name(rdam, "P30177") |> PrefixedName

    /// <summary>
    ///   <para>rdam:extentOfCartographicResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/extentOfCartographicResource.en">http://rdaregistry.info/Elements/m/extentOfCartographicResource.en</seealso>
    let ``extentOfCartographicResource.en`` =
        Prefixed_Name(rdam, "extentOfCartographicResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30217</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of base material</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30217">http://rdaregistry.info/Elements/m/P30217</seealso>
    let P30217 = Prefixed_Name(rdam, "P30217") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfBaseMaterial.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfBaseMaterial.en">http://rdaregistry.info/Elements/m/detailsOfBaseMaterial.en</seealso>
    let ``detailsOfBaseMaterial.en`` =
        Prefixed_Name(rdam, "detailsOfBaseMaterial.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30218</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of book format</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30218">http://rdaregistry.info/Elements/m/P30218</seealso>
    let P30218 = Prefixed_Name(rdam, "P30218") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfBookFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfBookFormat.en">http://rdaregistry.info/Elements/m/detailsOfBookFormat.en</seealso>
    let ``detailsOfBookFormat.en`` =
        Prefixed_Name(rdam, "detailsOfBookFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfConfigurationOfPlaybackChannels.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfConfigurationOfPlaybackChannels.en">http://rdaregistry.info/Elements/m/detailsOfConfigurationOfPlaybackChannels.en</seealso>
    let ``detailsOfConfigurationOfPlaybackChannels.en`` =
        Prefixed_Name(rdam, "detailsOfConfigurationOfPlaybackChannels.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30245</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of sound characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30245">http://rdaregistry.info/Elements/m/P30245</seealso>
    let P30245 = Prefixed_Name(rdam, "P30245") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30221</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of digital file characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30221">http://rdaregistry.info/Elements/m/P30221</seealso>
    let P30221 = Prefixed_Name(rdam, "P30221") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30222</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of digital representation of cartographic content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30222">http://rdaregistry.info/Elements/m/P30222</seealso>
    let P30222 = Prefixed_Name(rdam, "P30222") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30224</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of encoding format</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30224">http://rdaregistry.info/Elements/m/P30224</seealso>
    let P30224 = Prefixed_Name(rdam, "P30224") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30225</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of file type</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30225">http://rdaregistry.info/Elements/m/P30225</seealso>
    let P30225 = Prefixed_Name(rdam, "P30225") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfDigitalFileCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfDigitalFileCharacteristic.en">http://rdaregistry.info/Elements/m/detailsOfDigitalFileCharacteristic.en</seealso>
    let ``detailsOfDigitalFileCharacteristic.en`` =
        Prefixed_Name(rdam, "detailsOfDigitalFileCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:identifierForTheManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/identifierForTheManifestation.en">http://rdaregistry.info/Elements/m/identifierForTheManifestation.en</seealso>
    let ``identifierForTheManifestation.en`` =
        Prefixed_Name(rdam, "identifierForTheManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30124</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has digital file characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30124">http://rdaregistry.info/Elements/m/P30124</seealso>
    let P30124 = Prefixed_Name(rdam, "P30124") |> PrefixedName

    /// <summary>
    ///   <para>rdam:equivalentManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/equivalentManifestation.en">http://rdaregistry.info/Elements/m/equivalentManifestation.en</seealso>
    let ``equivalentManifestation.en`` =
        Prefixed_Name(rdam, "equivalentManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:alsoIssuedAs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/alsoIssuedAs.en">http://rdaregistry.info/Elements/m/alsoIssuedAs.en</seealso>
    let ``alsoIssuedAs.en`` = Prefixed_Name(rdam, "alsoIssuedAs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:accompaniedByManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/accompaniedByManifestation.en">http://rdaregistry.info/Elements/m/accompaniedByManifestation.en</seealso>
    let ``accompaniedByManifestation.en`` =
        Prefixed_Name(rdam, "accompaniedByManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is digital transfer (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30029">http://rdaregistry.info/Elements/m/P30029</seealso>
    let P30029 = Prefixed_Name(rdam, "P30029") |> PrefixedName

    /// <summary>
    ///   <para>rdam:relatedManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/relatedManifestation.en">http://rdaregistry.info/Elements/m/relatedManifestation.en</seealso>
    let ``relatedManifestation.en`` =
        Prefixed_Name(rdam, "relatedManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on issue, part, or iteration used as the basis for identification of the resource</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30050">http://rdaregistry.info/Elements/m/P30050</seealso>
    let P30050 = Prefixed_Name(rdam, "P30050") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en">http://rdaregistry.info/Elements/m/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en</seealso>
    let ``noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en`` =
        Prefixed_Name(rdam, "noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on changes in carrier characteristics</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30051">http://rdaregistry.info/Elements/m/P30051</seealso>
    let P30051 = Prefixed_Name(rdam, "P30051") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnChangesInCarrierCharacteristics.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnChangesInCarrierCharacteristics.en">http://rdaregistry.info/Elements/m/noteOnChangesInCarrierCharacteristics.en</seealso>
    let ``noteOnChangesInCarrierCharacteristics.en`` =
        Prefixed_Name(rdam, "noteOnChangesInCarrierCharacteristics.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnDistributionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnDistributionStatement.en">http://rdaregistry.info/Elements/m/noteOnDistributionStatement.en</seealso>
    let ``noteOnDistributionStatement.en`` =
        Prefixed_Name(rdam, "noteOnDistributionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30080</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has distributor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30080">http://rdaregistry.info/Elements/m/P30080</seealso>
    let P30080 = Prefixed_Name(rdam, "P30080") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30069</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has book designer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30069">http://rdaregistry.info/Elements/m/P30069</seealso>
    let P30069 = Prefixed_Name(rdam, "P30069") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30070</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has engraver</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30070">http://rdaregistry.info/Elements/m/P30070</seealso>
    let P30070 = Prefixed_Name(rdam, "P30070") |> PrefixedName
    /// <summary>
    ///   <para>rdam:engraver.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/engraver.en">http://rdaregistry.info/Elements/m/engraver.en</seealso>
    let ``engraver.en`` = Prefixed_Name(rdam, "engraver.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30090</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel place of manufacture</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30090">http://rdaregistry.info/Elements/m/P30090</seealso>
    let P30090 = Prefixed_Name(rdam, "P30090") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30091</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel place of production</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30091">http://rdaregistry.info/Elements/m/P30091</seealso>
    let P30091 = Prefixed_Name(rdam, "P30091") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelPlaceOfProduction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelPlaceOfProduction.en">http://rdaregistry.info/Elements/m/parallelPlaceOfProduction.en</seealso>
    let ``parallelPlaceOfProduction.en`` =
        Prefixed_Name(rdam, "parallelPlaceOfProduction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30092</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel place of publication</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30092">http://rdaregistry.info/Elements/m/P30092</seealso>
    let P30092 = Prefixed_Name(rdam, "P30092") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelPlaceOfPublication.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelPlaceOfPublication.en">http://rdaregistry.info/Elements/m/parallelPlaceOfPublication.en</seealso>
    let ``parallelPlaceOfPublication.en`` =
        Prefixed_Name(rdam, "parallelPlaceOfPublication.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30094</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel producer’s name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30094">http://rdaregistry.info/Elements/m/P30094</seealso>
    let P30094 = Prefixed_Name(rdam, "P30094") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelProducersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelProducersName.en">http://rdaregistry.info/Elements/m/parallelProducersName.en</seealso>
    let ``parallelProducersName.en`` =
        Prefixed_Name(rdam, "parallelProducersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30096</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has encoding format</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30096">http://rdaregistry.info/Elements/m/P30096</seealso>
    let P30096 = Prefixed_Name(rdam, "P30096") |> PrefixedName
    /// <summary>
    ///   <para>rdam:encodingFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/encodingFormat.en">http://rdaregistry.info/Elements/m/encodingFormat.en</seealso>
    let ``encodingFormat.en`` = Prefixed_Name(rdam, "encodingFormat.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30165</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has numbering of serials</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30165">http://rdaregistry.info/Elements/m/P30165</seealso>
    let P30165 = Prefixed_Name(rdam, "P30165") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30098</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has alternative numeric and/or alphabetic designation of last issue or part of sequence</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30098">http://rdaregistry.info/Elements/m/P30098</seealso>
    let P30098 = Prefixed_Name(rdam, "P30098") |> PrefixedName

    /// <summary>
    ///   <para>rdam:alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/m/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en</seealso>
    let ``alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdam, "alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30100</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has alternative chronological designation of last issue or part of sequence</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30100">http://rdaregistry.info/Elements/m/P30100</seealso>
    let P30100 = Prefixed_Name(rdam, "P30100") |> PrefixedName

    /// <summary>
    ///   <para>rdam:alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/m/alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en</seealso>
    let ``alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdam, "alternativeChronologicalDesignationOfLastIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:specialIssueOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/specialIssueOf.en">http://rdaregistry.info/Elements/m/specialIssueOf.en</seealso>
    let ``specialIssueOf.en`` = Prefixed_Name(rdam, "specialIssueOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:digitalRepresentationOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/digitalRepresentationOfCartographicContent.en">http://rdaregistry.info/Elements/m/digitalRepresentationOfCartographicContent.en</seealso>
    let ``digitalRepresentationOfCartographicContent.en`` =
        Prefixed_Name(rdam, "digitalRepresentationOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30103</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has exemplar of manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30103">http://rdaregistry.info/Elements/m/P30103</seealso>
    let P30103 = Prefixed_Name(rdam, "P30103") |> PrefixedName

    /// <summary>
    ///   <para>rdam:exemplarOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/exemplarOfManifestation.en">http://rdaregistry.info/Elements/m/exemplarOfManifestation.en</seealso>
    let ``exemplarOfManifestation.en`` =
        Prefixed_Name(rdam, "exemplarOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30152</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel other title information of series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30152">http://rdaregistry.info/Elements/m/P30152</seealso>
    let P30152 = Prefixed_Name(rdam, "P30152") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelOtherTitleInformationOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelOtherTitleInformationOfSeries.en">http://rdaregistry.info/Elements/m/parallelOtherTitleInformationOfSeries.en</seealso>
    let ``parallelOtherTitleInformationOfSeries.en`` =
        Prefixed_Name(rdam, "parallelOtherTitleInformationOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30153</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel other title information of subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30153">http://rdaregistry.info/Elements/m/P30153</seealso>
    let P30153 = Prefixed_Name(rdam, "P30153") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30154</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has uniform resource locator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30154">http://rdaregistry.info/Elements/m/P30154</seealso>
    let P30154 = Prefixed_Name(rdam, "P30154") |> PrefixedName

    /// <summary>
    ///   <para>rdam:uniformResourceLocator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/uniformResourceLocator.en">http://rdaregistry.info/Elements/m/uniformResourceLocator.en</seealso>
    let ``uniformResourceLocator.en`` =
        Prefixed_Name(rdam, "uniformResourceLocator.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30155</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has layout</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30155">http://rdaregistry.info/Elements/m/P30155</seealso>
    let P30155 = Prefixed_Name(rdam, "P30155") |> PrefixedName
    /// <summary>
    ///   <para>rdam:layout.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/layout.en">http://rdaregistry.info/Elements/m/layout.en</seealso>
    let ``layout.en`` = Prefixed_Name(rdam, "layout.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30157</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has title proper of series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30157">http://rdaregistry.info/Elements/m/P30157</seealso>
    let P30157 = Prefixed_Name(rdam, "P30157") |> PrefixedName

    /// <summary>
    ///   <para>rdam:titleProperOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/titleProperOfSeries.en">http://rdaregistry.info/Elements/m/titleProperOfSeries.en</seealso>
    let ``titleProperOfSeries.en`` =
        Prefixed_Name(rdam, "titleProperOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30158</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has title proper of subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30158">http://rdaregistry.info/Elements/m/P30158</seealso>
    let P30158 = Prefixed_Name(rdam, "P30158") |> PrefixedName

    /// <summary>
    ///   <para>rdam:titleProperOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/titleProperOfSubseries.en">http://rdaregistry.info/Elements/m/titleProperOfSubseries.en</seealso>
    let ``titleProperOfSubseries.en`` =
        Prefixed_Name(rdam, "titleProperOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has publisher’s number for music</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30065">http://rdaregistry.info/Elements/m/P30065</seealso>
    let P30065 = Prefixed_Name(rdam, "P30065") |> PrefixedName

    /// <summary>
    ///   <para>rdam:preferredCitation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/preferredCitation.en">http://rdaregistry.info/Elements/m/preferredCitation.en</seealso>
    let ``preferredCitation.en`` =
        Prefixed_Name(rdam, "preferredCitation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has regional encoding</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30006">http://rdaregistry.info/Elements/m/P30006</seealso>
    let P30006 = Prefixed_Name(rdam, "P30006") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has copyright date</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30007">http://rdaregistry.info/Elements/m/P30007</seealso>
    let P30007 = Prefixed_Name(rdam, "P30007") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of distribution</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30008">http://rdaregistry.info/Elements/m/P30008</seealso>
    let P30008 = Prefixed_Name(rdam, "P30008") |> PrefixedName

    /// <summary>
    ///   <para>rdam:dateOfProduction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/dateOfProduction.en">http://rdaregistry.info/Elements/m/dateOfProduction.en</seealso>
    let ``dateOfProduction.en`` =
        Prefixed_Name(rdam, "dateOfProduction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of manufacture</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30010">http://rdaregistry.info/Elements/m/P30010</seealso>
    let P30010 = Prefixed_Name(rdam, "P30010") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of publication</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30011">http://rdaregistry.info/Elements/m/P30011</seealso>
    let P30011 = Prefixed_Name(rdam, "P30011") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelDesignationOfANamedRevisionOfAnEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelDesignationOfANamedRevisionOfAnEdition.en">http://rdaregistry.info/Elements/m/parallelDesignationOfANamedRevisionOfAnEdition.en</seealso>
    let ``parallelDesignationOfANamedRevisionOfAnEdition.en`` =
        Prefixed_Name(rdam, "parallelDesignationOfANamedRevisionOfAnEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has numbering within series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30014">http://rdaregistry.info/Elements/m/P30014</seealso>
    let P30014 = Prefixed_Name(rdam, "P30014") |> PrefixedName

    /// <summary>
    ///   <para>rdam:numberingWithinSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/numberingWithinSubseries.en">http://rdaregistry.info/Elements/m/numberingWithinSubseries.en</seealso>
    let ``numberingWithinSubseries.en`` =
        Prefixed_Name(rdam, "numberingWithinSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:electronicReproductionManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/electronicReproductionManifestation.en">http://rdaregistry.info/Elements/m/electronicReproductionManifestation.en</seealso>
    let ``electronicReproductionManifestation.en`` =
        Prefixed_Name(rdam, "electronicReproductionManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel distributor’s name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30017">http://rdaregistry.info/Elements/m/P30017</seealso>
    let P30017 = Prefixed_Name(rdam, "P30017") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelDistributorsName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelDistributorsName.en">http://rdaregistry.info/Elements/m/parallelDistributorsName.en</seealso>
    let ``parallelDistributorsName.en`` =
        Prefixed_Name(rdam, "parallelDistributorsName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:onDiscWithManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/onDiscWithManifestation.en">http://rdaregistry.info/Elements/m/onDiscWithManifestation.en</seealso>
    let ``onDiscWithManifestation.en`` =
        Prefixed_Name(rdam, "onDiscWithManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:filmedWithManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/filmedWithManifestation.en">http://rdaregistry.info/Elements/m/filmedWithManifestation.en</seealso>
    let ``filmedWithManifestation.en`` =
        Prefixed_Name(rdam, "filmedWithManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is reprinted as (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30038">http://rdaregistry.info/Elements/m/P30038</seealso>
    let P30038 = Prefixed_Name(rdam, "P30038") |> PrefixedName

    /// <summary>
    ///   <para>rdam:reprintedAsManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/reprintedAsManifestation.en">http://rdaregistry.info/Elements/m/reprintedAsManifestation.en</seealso>
    let ``reprintedAsManifestation.en`` =
        Prefixed_Name(rdam, "reprintedAsManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:reproducedAsManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/reproducedAsManifestation.en">http://rdaregistry.info/Elements/m/reproducedAsManifestation.en</seealso>
    let ``reproducedAsManifestation.en`` =
        Prefixed_Name(rdam, "reproducedAsManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:digitalTransferOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/digitalTransferOfManifestation.en">http://rdaregistry.info/Elements/m/digitalTransferOfManifestation.en</seealso>
    let ``digitalTransferOfManifestation.en`` =
        Prefixed_Name(rdam, "digitalTransferOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30042">http://rdaregistry.info/Elements/m/P30042</seealso>
    let P30042 = Prefixed_Name(rdam, "P30042") |> PrefixedName

    /// <summary>
    ///   <para>rdam:reproductionOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/reproductionOfManifestation.en">http://rdaregistry.info/Elements/m/reproductionOfManifestation.en</seealso>
    let ``reproductionOfManifestation.en`` =
        Prefixed_Name(rdam, "reproductionOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:facsimileContainerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/facsimileContainerOf.en">http://rdaregistry.info/Elements/m/facsimileContainerOf.en</seealso>
    let ``facsimileContainerOf.en`` =
        Prefixed_Name(rdam, "facsimileContainerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:facsimileOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/facsimileOfManifestation.en">http://rdaregistry.info/Elements/m/facsimileOfManifestation.en</seealso>
    let ``facsimileOfManifestation.en`` =
        Prefixed_Name(rdam, "facsimileOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has related manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30048">http://rdaregistry.info/Elements/m/P30048</seealso>
    let P30048 = Prefixed_Name(rdam, "P30048") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel manufacturer’s name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30049">http://rdaregistry.info/Elements/m/P30049</seealso>
    let P30049 = Prefixed_Name(rdam, "P30049") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelManufacturersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelManufacturersName.en">http://rdaregistry.info/Elements/m/parallelManufacturersName.en</seealso>
    let ``parallelManufacturersName.en`` =
        Prefixed_Name(rdam, "parallelManufacturersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30078</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has printer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30078">http://rdaregistry.info/Elements/m/P30078</seealso>
    let P30078 = Prefixed_Name(rdam, "P30078") |> PrefixedName
    /// <summary>
    ///   <para>rdam:printer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/printer.en">http://rdaregistry.info/Elements/m/printer.en</seealso>
    let ``printer.en`` = Prefixed_Name(rdam, "printer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30081</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has producer of an unpublished resource</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30081">http://rdaregistry.info/Elements/m/P30081</seealso>
    let P30081 = Prefixed_Name(rdam, "P30081") |> PrefixedName

    /// <summary>
    ///   <para>rdam:producerOfAnUnpublishedResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/producerOfAnUnpublishedResource.en">http://rdaregistry.info/Elements/m/producerOfAnUnpublishedResource.en</seealso>
    let ``producerOfAnUnpublishedResource.en`` =
        Prefixed_Name(rdam, "producerOfAnUnpublishedResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:videoFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/videoFormat.en">http://rdaregistry.info/Elements/m/videoFormat.en</seealso>
    let ``videoFormat.en`` = Prefixed_Name(rdam, "videoFormat.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30126</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has video characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30126">http://rdaregistry.info/Elements/m/P30126</seealso>
    let P30126 = Prefixed_Name(rdam, "P30126") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30105</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has statement of responsibility relating to title proper</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30105">http://rdaregistry.info/Elements/m/P30105</seealso>
    let P30105 = Prefixed_Name(rdam, "P30105") |> PrefixedName

    /// <summary>
    ///   <para>rdam:statementOfResponsibilityRelatingToTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToTitleProper.en">http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToTitleProper.en</seealso>
    let ``statementOfResponsibilityRelatingToTitleProper.en`` =
        Prefixed_Name(rdam, "statementOfResponsibilityRelatingToTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30107</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has edition statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30107">http://rdaregistry.info/Elements/m/P30107</seealso>
    let P30107 = Prefixed_Name(rdam, "P30107") |> PrefixedName

    /// <summary>
    ///   <para>rdam:editionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/editionStatement.en">http://rdaregistry.info/Elements/m/editionStatement.en</seealso>
    let ``editionStatement.en`` =
        Prefixed_Name(rdam, "editionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30108</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has distribution statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30108">http://rdaregistry.info/Elements/m/P30108</seealso>
    let P30108 = Prefixed_Name(rdam, "P30108") |> PrefixedName

    /// <summary>
    ///   <para>rdam:manufactureStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/manufactureStatement.en">http://rdaregistry.info/Elements/m/manufactureStatement.en</seealso>
    let ``manufactureStatement.en`` =
        Prefixed_Name(rdam, "manufactureStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30110</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has production statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30110">http://rdaregistry.info/Elements/m/P30110</seealso>
    let P30110 = Prefixed_Name(rdam, "P30110") |> PrefixedName

    /// <summary>
    ///   <para>rdam:productionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/productionStatement.en">http://rdaregistry.info/Elements/m/productionStatement.en</seealso>
    let ``productionStatement.en`` =
        Prefixed_Name(rdam, "productionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30112</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel statement of responsibility relating to a named revision of an edition</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30112">http://rdaregistry.info/Elements/m/P30112</seealso>
    let P30112 = Prefixed_Name(rdam, "P30112") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en">http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en`` =
        Prefixed_Name(rdam, "parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30113</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel statement of responsibility relating to series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30113">http://rdaregistry.info/Elements/m/P30113</seealso>
    let P30113 = Prefixed_Name(rdam, "P30113") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30129</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has later title proper</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30129">http://rdaregistry.info/Elements/m/P30129</seealso>
    let P30129 = Prefixed_Name(rdam, "P30129") |> PrefixedName

    /// <summary>
    ///   <para>rdam:laterTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/laterTitleProper.en">http://rdaregistry.info/Elements/m/laterTitleProper.en</seealso>
    let ``laterTitleProper.en`` =
        Prefixed_Name(rdam, "laterTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30130</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has earlier title proper</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30130">http://rdaregistry.info/Elements/m/P30130</seealso>
    let P30130 = Prefixed_Name(rdam, "P30130") |> PrefixedName

    /// <summary>
    ///   <para>rdam:earlierTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/earlierTitleProper.en">http://rdaregistry.info/Elements/m/earlierTitleProper.en</seealso>
    let ``earlierTitleProper.en`` =
        Prefixed_Name(rdam, "earlierTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30132</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has designation of a named revision of an edition</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30132">http://rdaregistry.info/Elements/m/P30132</seealso>
    let P30132 = Prefixed_Name(rdam, "P30132") |> PrefixedName

    /// <summary>
    ///   <para>rdam:designationOfANamedRevisionOfAnEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/designationOfANamedRevisionOfAnEdition.en">http://rdaregistry.info/Elements/m/designationOfANamedRevisionOfAnEdition.en</seealso>
    let ``designationOfANamedRevisionOfAnEdition.en`` =
        Prefixed_Name(rdam, "designationOfANamedRevisionOfAnEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30133</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has designation of edition</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30133">http://rdaregistry.info/Elements/m/P30133</seealso>
    let P30133 = Prefixed_Name(rdam, "P30133") |> PrefixedName

    /// <summary>
    ///   <para>rdam:designationOfEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/designationOfEdition.en">http://rdaregistry.info/Elements/m/designationOfEdition.en</seealso>
    let ``designationOfEdition.en`` =
        Prefixed_Name(rdam, "designationOfEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30156</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has title proper</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30156">http://rdaregistry.info/Elements/m/P30156</seealso>
    let P30156 = Prefixed_Name(rdam, "P30156") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30209</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has key title</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30209">http://rdaregistry.info/Elements/m/P30209</seealso>
    let P30209 = Prefixed_Name(rdam, "P30209") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30151</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel other title information</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30151">http://rdaregistry.info/Elements/m/P30151</seealso>
    let P30151 = Prefixed_Name(rdam, "P30151") |> PrefixedName
    /// <summary>
    ///   <para>rdam:title.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/title.en">http://rdaregistry.info/Elements/m/title.en</seealso>
    let ``title.en`` = Prefixed_Name(rdam, "title.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30135</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has work manifested</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30135">http://rdaregistry.info/Elements/m/P30135</seealso>
    let P30135 = Prefixed_Name(rdam, "P30135") |> PrefixedName
    /// <summary>
    ///   <para>rdam:workManifested.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/workManifested.en">http://rdaregistry.info/Elements/m/workManifested.en</seealso>
    let ``workManifested.en`` = Prefixed_Name(rdam, "workManifested.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnManifestation.en">http://rdaregistry.info/Elements/m/noteOnManifestation.en</seealso>
    let ``noteOnManifestation.en`` =
        Prefixed_Name(rdam, "noteOnManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:specialPlaybackCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/specialPlaybackCharacteristic.en">http://rdaregistry.info/Elements/m/specialPlaybackCharacteristic.en</seealso>
    let ``specialPlaybackCharacteristic.en`` =
        Prefixed_Name(rdam, "specialPlaybackCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:resolution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/resolution.en">http://rdaregistry.info/Elements/m/resolution.en</seealso>
    let ``resolution.en`` = Prefixed_Name(rdam, "resolution.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30160</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has terms of availability</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30160">http://rdaregistry.info/Elements/m/P30160</seealso>
    let P30160 = Prefixed_Name(rdam, "P30160") |> PrefixedName

    /// <summary>
    ///   <para>rdam:termsOfAvailability.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/termsOfAvailability.en">http://rdaregistry.info/Elements/m/termsOfAvailability.en</seealso>
    let ``termsOfAvailability.en`` =
        Prefixed_Name(rdam, "termsOfAvailability.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:trackConfiguration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/trackConfiguration.en">http://rdaregistry.info/Elements/m/trackConfiguration.en</seealso>
    let ``trackConfiguration.en`` =
        Prefixed_Name(rdam, "trackConfiguration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30162</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has equipment or system requirement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30162">http://rdaregistry.info/Elements/m/P30162</seealso>
    let P30162 = Prefixed_Name(rdam, "P30162") |> PrefixedName

    /// <summary>
    ///   <para>rdam:equipmentOrSystemRequirement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/equipmentOrSystemRequirement.en">http://rdaregistry.info/Elements/m/equipmentOrSystemRequirement.en</seealso>
    let ``equipmentOrSystemRequirement.en`` =
        Prefixed_Name(rdam, "equipmentOrSystemRequirement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:grooveCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/grooveCharacteristic.en">http://rdaregistry.info/Elements/m/grooveCharacteristic.en</seealso>
    let ``grooveCharacteristic.en`` =
        Prefixed_Name(rdam, "grooveCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:numberingOfSerials.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/numberingOfSerials.en">http://rdaregistry.info/Elements/m/numberingOfSerials.en</seealso>
    let ``numberingOfSerials.en`` =
        Prefixed_Name(rdam, "numberingOfSerials.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30166</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has ISSN of series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30166">http://rdaregistry.info/Elements/m/P30166</seealso>
    let P30166 = Prefixed_Name(rdam, "P30166") |> PrefixedName
    /// <summary>
    ///   <para>rdam:issnOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/issnOfSeries.en">http://rdaregistry.info/Elements/m/issnOfSeries.en</seealso>
    let ``issnOfSeries.en`` = Prefixed_Name(rdam, "issnOfSeries.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30167</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has ISSN of subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30167">http://rdaregistry.info/Elements/m/P30167</seealso>
    let P30167 = Prefixed_Name(rdam, "P30167") |> PrefixedName

    /// <summary>
    ///   <para>rdam:issnOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/issnOfSubseries.en">http://rdaregistry.info/Elements/m/issnOfSubseries.en</seealso>
    let ``issnOfSubseries.en`` =
        Prefixed_Name(rdam, "issnOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:frequency.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/frequency.en">http://rdaregistry.info/Elements/m/frequency.en</seealso>
    let ``frequency.en`` = Prefixed_Name(rdam, "frequency.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30169</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has dimensions</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30169">http://rdaregistry.info/Elements/m/P30169</seealso>
    let P30169 = Prefixed_Name(rdam, "P30169") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30170</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has dimensions of map, etc.</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30170">http://rdaregistry.info/Elements/m/P30170</seealso>
    let P30170 = Prefixed_Name(rdam, "P30170") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30171</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has dimensions of still image</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30171">http://rdaregistry.info/Elements/m/P30171</seealso>
    let P30171 = Prefixed_Name(rdam, "P30171") |> PrefixedName
    /// <summary>
    ///   <para>rdam:dimensions.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/dimensions.en">http://rdaregistry.info/Elements/m/dimensions.en</seealso>
    let ``dimensions.en`` = Prefixed_Name(rdam, "dimensions.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:dimensionsOfMapEtc.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/dimensionsOfMapEtc.en">http://rdaregistry.info/Elements/m/dimensionsOfMapEtc.en</seealso>
    let ``dimensionsOfMapEtc.en`` =
        Prefixed_Name(rdam, "dimensionsOfMapEtc.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:dimensionsOfStillImage.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/dimensionsOfStillImage.en">http://rdaregistry.info/Elements/m/dimensionsOfStillImage.en</seealso>
    let ``dimensionsOfStillImage.en`` =
        Prefixed_Name(rdam, "dimensionsOfStillImage.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30233</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of layout</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30233">http://rdaregistry.info/Elements/m/P30233</seealso>
    let P30233 = Prefixed_Name(rdam, "P30233") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfLayout.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfLayout.en">http://rdaregistry.info/Elements/m/detailsOfLayout.en</seealso>
    let ``detailsOfLayout.en`` =
        Prefixed_Name(rdam, "detailsOfLayout.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30234</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of mount</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30234">http://rdaregistry.info/Elements/m/P30234</seealso>
    let P30234 = Prefixed_Name(rdam, "P30234") |> PrefixedName
    /// <summary>
    ///   <para>rdam:detailsOfMount.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfMount.en">http://rdaregistry.info/Elements/m/detailsOfMount.en</seealso>
    let ``detailsOfMount.en`` = Prefixed_Name(rdam, "detailsOfMount.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30235</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of playing speed</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30235">http://rdaregistry.info/Elements/m/P30235</seealso>
    let P30235 = Prefixed_Name(rdam, "P30235") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfPlayingSpeed.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfPlayingSpeed.en">http://rdaregistry.info/Elements/m/detailsOfPlayingSpeed.en</seealso>
    let ``detailsOfPlayingSpeed.en`` =
        Prefixed_Name(rdam, "detailsOfPlayingSpeed.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30236</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of polarity</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30236">http://rdaregistry.info/Elements/m/P30236</seealso>
    let P30236 = Prefixed_Name(rdam, "P30236") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30238</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of production method</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30238">http://rdaregistry.info/Elements/m/P30238</seealso>
    let P30238 = Prefixed_Name(rdam, "P30238") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30240</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of production method for tactile resource</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30240">http://rdaregistry.info/Elements/m/P30240</seealso>
    let P30240 = Prefixed_Name(rdam, "P30240") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30239</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of production method for manuscript</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30239">http://rdaregistry.info/Elements/m/P30239</seealso>
    let P30239 = Prefixed_Name(rdam, "P30239") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfProductionMethod.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfProductionMethod.en">http://rdaregistry.info/Elements/m/detailsOfProductionMethod.en</seealso>
    let ``detailsOfProductionMethod.en`` =
        Prefixed_Name(rdam, "detailsOfProductionMethod.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfProductionMethodForManuscript.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfProductionMethodForManuscript.en">http://rdaregistry.info/Elements/m/detailsOfProductionMethodForManuscript.en</seealso>
    let ``detailsOfProductionMethodForManuscript.en`` =
        Prefixed_Name(rdam, "detailsOfProductionMethodForManuscript.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfProductionMethodForTactileResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfProductionMethodForTactileResource.en">http://rdaregistry.info/Elements/m/detailsOfProductionMethodForTactileResource.en</seealso>
    let ``detailsOfProductionMethodForTactileResource.en`` =
        Prefixed_Name(rdam, "detailsOfProductionMethodForTactileResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30241</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of projection characteristic of motion picture film</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30241">http://rdaregistry.info/Elements/m/P30241</seealso>
    let P30241 = Prefixed_Name(rdam, "P30241") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30242</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of projection speed</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30242">http://rdaregistry.info/Elements/m/P30242</seealso>
    let P30242 = Prefixed_Name(rdam, "P30242") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfProjectionCharacteristicOfMotionPictureFilm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfProjectionCharacteristicOfMotionPictureFilm.en">http://rdaregistry.info/Elements/m/detailsOfProjectionCharacteristicOfMotionPictureFilm.en</seealso>
    let ``detailsOfProjectionCharacteristicOfMotionPictureFilm.en`` =
        Prefixed_Name(rdam, "detailsOfProjectionCharacteristicOfMotionPictureFilm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfRecordingMedium.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfRecordingMedium.en">http://rdaregistry.info/Elements/m/detailsOfRecordingMedium.en</seealso>
    let ``detailsOfRecordingMedium.en`` =
        Prefixed_Name(rdam, "detailsOfRecordingMedium.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30244</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of reduction ratio</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30244">http://rdaregistry.info/Elements/m/P30244</seealso>
    let P30244 = Prefixed_Name(rdam, "P30244") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfReductionRatio.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfReductionRatio.en">http://rdaregistry.info/Elements/m/detailsOfReductionRatio.en</seealso>
    let ``detailsOfReductionRatio.en`` =
        Prefixed_Name(rdam, "detailsOfReductionRatio.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30247</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of tape configuration</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30247">http://rdaregistry.info/Elements/m/P30247</seealso>
    let P30247 = Prefixed_Name(rdam, "P30247") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30249</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of type of recording</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30249">http://rdaregistry.info/Elements/m/P30249</seealso>
    let P30249 = Prefixed_Name(rdam, "P30249") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30246</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of special playback characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30246">http://rdaregistry.info/Elements/m/P30246</seealso>
    let P30246 = Prefixed_Name(rdam, "P30246") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30248</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of track configuration</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30248">http://rdaregistry.info/Elements/m/P30248</seealso>
    let P30248 = Prefixed_Name(rdam, "P30248") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfSoundCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfSoundCharacteristic.en">http://rdaregistry.info/Elements/m/detailsOfSoundCharacteristic.en</seealso>
    let ``detailsOfSoundCharacteristic.en`` =
        Prefixed_Name(rdam, "detailsOfSoundCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfSpecialPlaybackCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfSpecialPlaybackCharacteristic.en">http://rdaregistry.info/Elements/m/detailsOfSpecialPlaybackCharacteristic.en</seealso>
    let ``detailsOfSpecialPlaybackCharacteristic.en`` =
        Prefixed_Name(rdam, "detailsOfSpecialPlaybackCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is equivalent (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30024">http://rdaregistry.info/Elements/m/P30024</seealso>
    let P30024 = Prefixed_Name(rdam, "P30024") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30041">http://rdaregistry.info/Elements/m/P30041</seealso>
    let P30041 = Prefixed_Name(rdam, "P30041") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on title</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30063">http://rdaregistry.info/Elements/m/P30063</seealso>
    let P30063 = Prefixed_Name(rdam, "P30063") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on edition statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30064">http://rdaregistry.info/Elements/m/P30064</seealso>
    let P30064 = Prefixed_Name(rdam, "P30064") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnEditionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnEditionStatement.en">http://rdaregistry.info/Elements/m/noteOnEditionStatement.en</seealso>
    let ``noteOnEditionStatement.en`` =
        Prefixed_Name(rdam, "noteOnEditionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:publishersNumberForMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/publishersNumberForMusic.en">http://rdaregistry.info/Elements/m/publishersNumberForMusic.en</seealso>
    let ``publishersNumberForMusic.en`` =
        Prefixed_Name(rdam, "publishersNumberForMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:plateNumberForMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/plateNumberForMusic.en">http://rdaregistry.info/Elements/m/plateNumberForMusic.en</seealso>
    let ``plateNumberForMusic.en`` =
        Prefixed_Name(rdam, "plateNumberForMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/m/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en</seealso>
    let ``alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdam, "alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30102</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has digital representation of cartographic content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30102">http://rdaregistry.info/Elements/m/P30102</seealso>
    let P30102 = Prefixed_Name(rdam, "P30102") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30104</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has video format</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30104">http://rdaregistry.info/Elements/m/P30104</seealso>
    let P30104 = Prefixed_Name(rdam, "P30104") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30117</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has statement of responsibility</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30117">http://rdaregistry.info/Elements/m/P30117</seealso>
    let P30117 = Prefixed_Name(rdam, "P30117") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30106</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has series statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30106">http://rdaregistry.info/Elements/m/P30106</seealso>
    let P30106 = Prefixed_Name(rdam, "P30106") |> PrefixedName

    /// <summary>
    ///   <para>rdam:seriesStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/seriesStatement.en">http://rdaregistry.info/Elements/m/seriesStatement.en</seealso>
    let ``seriesStatement.en`` =
        Prefixed_Name(rdam, "seriesStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:distributionStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/distributionStatement.en">http://rdaregistry.info/Elements/m/distributionStatement.en</seealso>
    let ``distributionStatement.en`` =
        Prefixed_Name(rdam, "distributionStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30109</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has manufacture statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30109">http://rdaregistry.info/Elements/m/P30109</seealso>
    let P30109 = Prefixed_Name(rdam, "P30109") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30111</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has publication statement</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30111">http://rdaregistry.info/Elements/m/P30111</seealso>
    let P30111 = Prefixed_Name(rdam, "P30111") |> PrefixedName

    /// <summary>
    ///   <para>rdam:publicationStatement.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/publicationStatement.en">http://rdaregistry.info/Elements/m/publicationStatement.en</seealso>
    let ``publicationStatement.en`` =
        Prefixed_Name(rdam, "publicationStatement.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:videoCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/videoCharacteristic.en">http://rdaregistry.info/Elements/m/videoCharacteristic.en</seealso>
    let ``videoCharacteristic.en`` =
        Prefixed_Name(rdam, "videoCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:projectionCharacteristicOfMotionPictureFilm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/projectionCharacteristicOfMotionPictureFilm.en">http://rdaregistry.info/Elements/m/projectionCharacteristicOfMotionPictureFilm.en</seealso>
    let ``projectionCharacteristicOfMotionPictureFilm.en`` =
        Prefixed_Name(rdam, "projectionCharacteristicOfMotionPictureFilm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30128</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has variant title</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30128">http://rdaregistry.info/Elements/m/P30128</seealso>
    let P30128 = Prefixed_Name(rdam, "P30128") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30143</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other title information of series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30143">http://rdaregistry.info/Elements/m/P30143</seealso>
    let P30143 = Prefixed_Name(rdam, "P30143") |> PrefixedName

    /// <summary>
    ///   <para>rdam:presentationFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/presentationFormat.en">http://rdaregistry.info/Elements/m/presentationFormat.en</seealso>
    let ``presentationFormat.en`` =
        Prefixed_Name(rdam, "presentationFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30187</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has production method</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30187">http://rdaregistry.info/Elements/m/P30187</seealso>
    let P30187 = Prefixed_Name(rdam, "P30187") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30189</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has production method for manuscript</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30189">http://rdaregistry.info/Elements/m/P30189</seealso>
    let P30189 = Prefixed_Name(rdam, "P30189") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30188</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has production method for tactile resource</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30188">http://rdaregistry.info/Elements/m/P30188</seealso>
    let P30188 = Prefixed_Name(rdam, "P30188") |> PrefixedName

    /// <summary>
    ///   <para>rdam:productionMethodForManuscript.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/productionMethodForManuscript.en">http://rdaregistry.info/Elements/m/productionMethodForManuscript.en</seealso>
    let ``productionMethodForManuscript.en`` =
        Prefixed_Name(rdam, "productionMethodForManuscript.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30190</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has generation of audio recording</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30190">http://rdaregistry.info/Elements/m/P30190</seealso>
    let P30190 = Prefixed_Name(rdam, "P30190") |> PrefixedName

    /// <summary>
    ///   <para>rdam:generationOfAudioRecording.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/generationOfAudioRecording.en">http://rdaregistry.info/Elements/m/generationOfAudioRecording.en</seealso>
    let ``generationOfAudioRecording.en`` =
        Prefixed_Name(rdam, "generationOfAudioRecording.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30229</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of generation of microform</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30229">http://rdaregistry.info/Elements/m/P30229</seealso>
    let P30229 = Prefixed_Name(rdam, "P30229") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfGenerationOfMicroform.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfGenerationOfMicroform.en">http://rdaregistry.info/Elements/m/detailsOfGenerationOfMicroform.en</seealso>
    let ``detailsOfGenerationOfMicroform.en`` =
        Prefixed_Name(rdam, "detailsOfGenerationOfMicroform.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30230</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of generation of motion picture film</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30230">http://rdaregistry.info/Elements/m/P30230</seealso>
    let P30230 = Prefixed_Name(rdam, "P30230") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfGenerationOfMotionPictureFilm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfGenerationOfMotionPictureFilm.en">http://rdaregistry.info/Elements/m/detailsOfGenerationOfMotionPictureFilm.en</seealso>
    let ``detailsOfGenerationOfMotionPictureFilm.en`` =
        Prefixed_Name(rdam, "detailsOfGenerationOfMotionPictureFilm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30258</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is evaluated in (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30258">http://rdaregistry.info/Elements/m/P30258</seealso>
    let P30258 = Prefixed_Name(rdam, "P30258") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30259</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is reviewed in (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30259">http://rdaregistry.info/Elements/m/P30259</seealso>
    let P30259 = Prefixed_Name(rdam, "P30259") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30256</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentary in (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30256">http://rdaregistry.info/Elements/m/P30256</seealso>
    let P30256 = Prefixed_Name(rdam, "P30256") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30257</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is critiqued in (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30257">http://rdaregistry.info/Elements/m/P30257</seealso>
    let P30257 = Prefixed_Name(rdam, "P30257") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30255</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is analysed in (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30255">http://rdaregistry.info/Elements/m/P30255</seealso>
    let P30255 = Prefixed_Name(rdam, "P30255") |> PrefixedName

    /// <summary>
    ///   <para>rdam:describedInManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/describedInManifestation.en">http://rdaregistry.info/Elements/m/describedInManifestation.en</seealso>
    let ``describedInManifestation.en`` =
        Prefixed_Name(rdam, "describedInManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:analysedInManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/analysedInManifestation.en">http://rdaregistry.info/Elements/m/analysedInManifestation.en</seealso>
    let ``analysedInManifestation.en`` =
        Prefixed_Name(rdam, "analysedInManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:regionalEncoding.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/regionalEncoding.en">http://rdaregistry.info/Elements/m/regionalEncoding.en</seealso>
    let ``regionalEncoding.en`` =
        Prefixed_Name(rdam, "regionalEncoding.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:copyrightDate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/copyrightDate.en">http://rdaregistry.info/Elements/m/copyrightDate.en</seealso>
    let ``copyrightDate.en`` = Prefixed_Name(rdam, "copyrightDate.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:dateOfDistribution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/dateOfDistribution.en">http://rdaregistry.info/Elements/m/dateOfDistribution.en</seealso>
    let ``dateOfDistribution.en`` =
        Prefixed_Name(rdam, "dateOfDistribution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:dateOfManufacture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/dateOfManufacture.en">http://rdaregistry.info/Elements/m/dateOfManufacture.en</seealso>
    let ``dateOfManufacture.en`` =
        Prefixed_Name(rdam, "dateOfManufacture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:dateOfPublication.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/dateOfPublication.en">http://rdaregistry.info/Elements/m/dateOfPublication.en</seealso>
    let ``dateOfPublication.en`` =
        Prefixed_Name(rdam, "dateOfPublication.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:numberingWithinSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/numberingWithinSeries.en">http://rdaregistry.info/Elements/m/numberingWithinSeries.en</seealso>
    let ``numberingWithinSeries.en`` =
        Prefixed_Name(rdam, "numberingWithinSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is electronic reproduction (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30016">http://rdaregistry.info/Elements/m/P30016</seealso>
    let P30016 = Prefixed_Name(rdam, "P30016") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30136</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is electronic reproduction of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30136">http://rdaregistry.info/Elements/m/P30136</seealso>
    let P30136 = Prefixed_Name(rdam, "P30136") |> PrefixedName
    /// <summary>
    ///   <para>rdam:fileType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/fileType.en">http://rdaregistry.info/Elements/m/fileType.en</seealso>
    let ``fileType.en`` = Prefixed_Name(rdam, "fileType.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30093</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is reprint of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30093">http://rdaregistry.info/Elements/m/P30093</seealso>
    let P30093 = Prefixed_Name(rdam, "P30093") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on copyright date</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30059">http://rdaregistry.info/Elements/m/P30059</seealso>
    let P30059 = Prefixed_Name(rdam, "P30059") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnCopyrightDate.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnCopyrightDate.en">http://rdaregistry.info/Elements/m/noteOnCopyrightDate.en</seealso>
    let ``noteOnCopyrightDate.en`` =
        Prefixed_Name(rdam, "noteOnCopyrightDate.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnDimensionsOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnDimensionsOfManifestation.en">http://rdaregistry.info/Elements/m/noteOnDimensionsOfManifestation.en</seealso>
    let ``noteOnDimensionsOfManifestation.en`` =
        Prefixed_Name(rdam, "noteOnDimensionsOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on extent of manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30061">http://rdaregistry.info/Elements/m/P30061</seealso>
    let P30061 = Prefixed_Name(rdam, "P30061") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnExtentOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnExtentOfManifestation.en">http://rdaregistry.info/Elements/m/noteOnExtentOfManifestation.en</seealso>
    let ``noteOnExtentOfManifestation.en`` =
        Prefixed_Name(rdam, "noteOnExtentOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has note on numbering of serials</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30062">http://rdaregistry.info/Elements/m/P30062</seealso>
    let P30062 = Prefixed_Name(rdam, "P30062") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnNumberingOfSerials.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnNumberingOfSerials.en">http://rdaregistry.info/Elements/m/noteOnNumberingOfSerials.en</seealso>
    let ``noteOnNumberingOfSerials.en`` =
        Prefixed_Name(rdam, "noteOnNumberingOfSerials.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:noteOnTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/noteOnTitle.en">http://rdaregistry.info/Elements/m/noteOnTitle.en</seealso>
    let ``noteOnTitle.en`` = Prefixed_Name(rdam, "noteOnTitle.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has broadcaster</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30067">http://rdaregistry.info/Elements/m/P30067</seealso>
    let P30067 = Prefixed_Name(rdam, "P30067") |> PrefixedName
    /// <summary>
    ///   <para>rdam:broadcaster.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/broadcaster.en">http://rdaregistry.info/Elements/m/broadcaster.en</seealso>
    let ``broadcaster.en`` = Prefixed_Name(rdam, "broadcaster.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30083</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has publisher</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30083">http://rdaregistry.info/Elements/m/P30083</seealso>
    let P30083 = Prefixed_Name(rdam, "P30083") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30068</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has film distributor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30068">http://rdaregistry.info/Elements/m/P30068</seealso>
    let P30068 = Prefixed_Name(rdam, "P30068") |> PrefixedName

    /// <summary>
    ///   <para>rdam:filmDistributor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/filmDistributor.en">http://rdaregistry.info/Elements/m/filmDistributor.en</seealso>
    let ``filmDistributor.en`` =
        Prefixed_Name(rdam, "filmDistributor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:bookDesigner.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/bookDesigner.en">http://rdaregistry.info/Elements/m/bookDesigner.en</seealso>
    let ``bookDesigner.en`` = Prefixed_Name(rdam, "bookDesigner.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30082</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has manufacturer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30082">http://rdaregistry.info/Elements/m/P30082</seealso>
    let P30082 = Prefixed_Name(rdam, "P30082") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30085</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of distribution</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30085">http://rdaregistry.info/Elements/m/P30085</seealso>
    let P30085 = Prefixed_Name(rdam, "P30085") |> PrefixedName

    /// <summary>
    ///   <para>rdam:placeOfDistribution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/placeOfDistribution.en">http://rdaregistry.info/Elements/m/placeOfDistribution.en</seealso>
    let ``placeOfDistribution.en`` =
        Prefixed_Name(rdam, "placeOfDistribution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30164</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has groove characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30164">http://rdaregistry.info/Elements/m/P30164</seealso>
    let P30164 = Prefixed_Name(rdam, "P30164") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30206</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has recording medium</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30206">http://rdaregistry.info/Elements/m/P30206</seealso>
    let P30206 = Prefixed_Name(rdam, "P30206") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30201</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has playing speed</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30201">http://rdaregistry.info/Elements/m/P30201</seealso>
    let P30201 = Prefixed_Name(rdam, "P30201") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30161</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has track configuration</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30161">http://rdaregistry.info/Elements/m/P30161</seealso>
    let P30161 = Prefixed_Name(rdam, "P30161") |> PrefixedName

    /// <summary>
    ///   <para>rdam:soundCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/soundCharacteristic.en">http://rdaregistry.info/Elements/m/soundCharacteristic.en</seealso>
    let ``soundCharacteristic.en`` =
        Prefixed_Name(rdam, "soundCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30127</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has projection characteristic of motion picture film</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30127">http://rdaregistry.info/Elements/m/P30127</seealso>
    let P30127 = Prefixed_Name(rdam, "P30127") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30163</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has presentation format</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30163">http://rdaregistry.info/Elements/m/P30163</seealso>
    let P30163 = Prefixed_Name(rdam, "P30163") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30200</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has projection speed</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30200">http://rdaregistry.info/Elements/m/P30200</seealso>
    let P30200 = Prefixed_Name(rdam, "P30200") |> PrefixedName
    /// <summary>
    ///   <para>rdam:variantTitle.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/variantTitle.en">http://rdaregistry.info/Elements/m/variantTitle.en</seealso>
    let ``variantTitle.en`` = Prefixed_Name(rdam, "variantTitle.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30134</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has title</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30134">http://rdaregistry.info/Elements/m/P30134</seealso>
    let P30134 = Prefixed_Name(rdam, "P30134") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30186</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has mount</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30186">http://rdaregistry.info/Elements/m/P30186</seealso>
    let P30186 = Prefixed_Name(rdam, "P30186") |> PrefixedName
    /// <summary>
    ///   <para>rdam:mount.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/mount.en">http://rdaregistry.info/Elements/m/mount.en</seealso>
    let ``mount.en`` = Prefixed_Name(rdam, "mount.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:productionMethod.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/productionMethod.en">http://rdaregistry.info/Elements/m/productionMethod.en</seealso>
    let ``productionMethod.en`` =
        Prefixed_Name(rdam, "productionMethod.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:productionMethodForTactileResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/productionMethodForTactileResource.en">http://rdaregistry.info/Elements/m/productionMethodForTactileResource.en</seealso>
    let ``productionMethodForTactileResource.en`` =
        Prefixed_Name(rdam, "productionMethodForTactileResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30191</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has generation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30191">http://rdaregistry.info/Elements/m/P30191</seealso>
    let P30191 = Prefixed_Name(rdam, "P30191") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30193</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has generation of motion picture film</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30193">http://rdaregistry.info/Elements/m/P30193</seealso>
    let P30193 = Prefixed_Name(rdam, "P30193") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30192</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has generation of digital resource</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30192">http://rdaregistry.info/Elements/m/P30192</seealso>
    let P30192 = Prefixed_Name(rdam, "P30192") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30195</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has generation of microform</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30195">http://rdaregistry.info/Elements/m/P30195</seealso>
    let P30195 = Prefixed_Name(rdam, "P30195") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30194</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has generation of videotape</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30194">http://rdaregistry.info/Elements/m/P30194</seealso>
    let P30194 = Prefixed_Name(rdam, "P30194") |> PrefixedName
    /// <summary>
    ///   <para>rdam:generation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/generation.en">http://rdaregistry.info/Elements/m/generation.en</seealso>
    let ``generation.en`` = Prefixed_Name(rdam, "generation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:generationOfDigitalResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/generationOfDigitalResource.en">http://rdaregistry.info/Elements/m/generationOfDigitalResource.en</seealso>
    let ``generationOfDigitalResource.en`` =
        Prefixed_Name(rdam, "generationOfDigitalResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:generationOfVideotape.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/generationOfVideotape.en">http://rdaregistry.info/Elements/m/generationOfVideotape.en</seealso>
    let ``generationOfVideotape.en`` =
        Prefixed_Name(rdam, "generationOfVideotape.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:generationOfMicroform.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/generationOfMicroform.en">http://rdaregistry.info/Elements/m/generationOfMicroform.en</seealso>
    let ``generationOfMicroform.en`` =
        Prefixed_Name(rdam, "generationOfMicroform.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30231</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of generation of videotape</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30231">http://rdaregistry.info/Elements/m/P30231</seealso>
    let P30231 = Prefixed_Name(rdam, "P30231") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfGenerationOfVideotape.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfGenerationOfVideotape.en">http://rdaregistry.info/Elements/m/detailsOfGenerationOfVideotape.en</seealso>
    let ``detailsOfGenerationOfVideotape.en`` =
        Prefixed_Name(rdam, "detailsOfGenerationOfVideotape.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30232</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of groove characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30232">http://rdaregistry.info/Elements/m/P30232</seealso>
    let P30232 = Prefixed_Name(rdam, "P30232") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfGrooveCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfGrooveCharacteristic.en">http://rdaregistry.info/Elements/m/detailsOfGrooveCharacteristic.en</seealso>
    let ``detailsOfGrooveCharacteristic.en`` =
        Prefixed_Name(rdam, "detailsOfGrooveCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has carrier type</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30001">http://rdaregistry.info/Elements/m/P30001</seealso>
    let P30001 = Prefixed_Name(rdam, "P30001") |> PrefixedName
    /// <summary>
    ///   <para>rdam:mediaType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/mediaType.en">http://rdaregistry.info/Elements/m/mediaType.en</seealso>
    let ``mediaType.en`` = Prefixed_Name(rdam, "mediaType.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of production</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30009">http://rdaregistry.info/Elements/m/P30009</seealso>
    let P30009 = Prefixed_Name(rdam, "P30009") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel designation of a named revision of an edition</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30012">http://rdaregistry.info/Elements/m/P30012</seealso>
    let P30012 = Prefixed_Name(rdam, "P30012") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel designation of edition</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30013">http://rdaregistry.info/Elements/m/P30013</seealso>
    let P30013 = Prefixed_Name(rdam, "P30013") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelDesignationOfEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelDesignationOfEdition.en">http://rdaregistry.info/Elements/m/parallelDesignationOfEdition.en</seealso>
    let ``parallelDesignationOfEdition.en`` =
        Prefixed_Name(rdam, "parallelDesignationOfEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has numbering within subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30015">http://rdaregistry.info/Elements/m/P30015</seealso>
    let P30015 = Prefixed_Name(rdam, "P30015") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is reproduced as (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30039">http://rdaregistry.info/Elements/m/P30039</seealso>
    let P30039 = Prefixed_Name(rdam, "P30039") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has file type</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30018">http://rdaregistry.info/Elements/m/P30018</seealso>
    let P30018 = Prefixed_Name(rdam, "P30018") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is facsimile contained in</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30019">http://rdaregistry.info/Elements/m/P30019</seealso>
    let P30019 = Prefixed_Name(rdam, "P30019") |> PrefixedName

    /// <summary>
    ///   <para>rdam:facsimileContainedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/facsimileContainedIn.en">http://rdaregistry.info/Elements/m/facsimileContainedIn.en</seealso>
    let ``facsimileContainedIn.en`` =
        Prefixed_Name(rdam, "facsimileContainedIn.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is contained in (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30020">http://rdaregistry.info/Elements/m/P30020</seealso>
    let P30020 = Prefixed_Name(rdam, "P30020") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is facsimile container of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30046">http://rdaregistry.info/Elements/m/P30046</seealso>
    let P30046 = Prefixed_Name(rdam, "P30046") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30101</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is special issue of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30101">http://rdaregistry.info/Elements/m/P30101</seealso>
    let P30101 = Prefixed_Name(rdam, "P30101") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is inserted in</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30025">http://rdaregistry.info/Elements/m/P30025</seealso>
    let P30025 = Prefixed_Name(rdam, "P30025") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30213</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has whole-part manifestation relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30213">http://rdaregistry.info/Elements/m/P30213</seealso>
    let P30213 = Prefixed_Name(rdam, "P30213") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is container of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30033">http://rdaregistry.info/Elements/m/P30033</seealso>
    let P30033 = Prefixed_Name(rdam, "P30033") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is preservation facsimile (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30021">http://rdaregistry.info/Elements/m/P30021</seealso>
    let P30021 = Prefixed_Name(rdam, "P30021") |> PrefixedName

    /// <summary>
    ///   <para>rdam:preservationFacsimileManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/preservationFacsimileManifestation.en">http://rdaregistry.info/Elements/m/preservationFacsimileManifestation.en</seealso>
    let ``preservationFacsimileManifestation.en`` =
        Prefixed_Name(rdam, "preservationFacsimileManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is insert</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30022">http://rdaregistry.info/Elements/m/P30022</seealso>
    let P30022 = Prefixed_Name(rdam, "P30022") |> PrefixedName
    /// <summary>
    ///   <para>rdam:insert.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/insert.en">http://rdaregistry.info/Elements/m/insert.en</seealso>
    let ``insert.en`` = Prefixed_Name(rdam, "insert.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30023">http://rdaregistry.info/Elements/m/P30023</seealso>
    let P30023 = Prefixed_Name(rdam, "P30023") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30212</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has equivalent manifestation relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30212">http://rdaregistry.info/Elements/m/P30212</seealso>
    let P30212 = Prefixed_Name(rdam, "P30212") |> PrefixedName
    /// <summary>
    ///   <para>rdam:insertedIn.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/insertedIn.en">http://rdaregistry.info/Elements/m/insertedIn.en</seealso>
    let ``insertedIn.en`` = Prefixed_Name(rdam, "insertedIn.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is accompanied by (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30027">http://rdaregistry.info/Elements/m/P30027</seealso>
    let P30027 = Prefixed_Name(rdam, "P30027") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is issued with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30035">http://rdaregistry.info/Elements/m/P30035</seealso>
    let P30035 = Prefixed_Name(rdam, "P30035") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30210</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has accompanying manifestation relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30210">http://rdaregistry.info/Elements/m/P30210</seealso>
    let P30210 = Prefixed_Name(rdam, "P30210") |> PrefixedName
    /// <summary>
    ///   <para>rdam:mirrorSite.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/mirrorSite.en">http://rdaregistry.info/Elements/m/mirrorSite.en</seealso>
    let ``mirrorSite.en`` = Prefixed_Name(rdam, "mirrorSite.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is digital transfer of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30040">http://rdaregistry.info/Elements/m/P30040</seealso>
    let P30040 = Prefixed_Name(rdam, "P30040") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is special issue</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30030">http://rdaregistry.info/Elements/m/P30030</seealso>
    let P30030 = Prefixed_Name(rdam, "P30030") |> PrefixedName
    /// <summary>
    ///   <para>rdam:specialIssue.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/specialIssue.en">http://rdaregistry.info/Elements/m/specialIssue.en</seealso>
    let ``specialIssue.en`` = Prefixed_Name(rdam, "specialIssue.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:facsimileManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/facsimileManifestation.en">http://rdaregistry.info/Elements/m/facsimileManifestation.en</seealso>
    let ``facsimileManifestation.en`` =
        Prefixed_Name(rdam, "facsimileManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is facsimile of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30047">http://rdaregistry.info/Elements/m/P30047</seealso>
    let P30047 = Prefixed_Name(rdam, "P30047") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30032">http://rdaregistry.info/Elements/m/P30032</seealso>
    let P30032 = Prefixed_Name(rdam, "P30032") |> PrefixedName

    /// <summary>
    ///   <para>rdam:containerOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/containerOfManifestation.en">http://rdaregistry.info/Elements/m/containerOfManifestation.en</seealso>
    let ``containerOfManifestation.en`` =
        Prefixed_Name(rdam, "containerOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30034">http://rdaregistry.info/Elements/m/P30034</seealso>
    let P30034 = Prefixed_Name(rdam, "P30034") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is on disc with (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30036">http://rdaregistry.info/Elements/m/P30036</seealso>
    let P30036 = Prefixed_Name(rdam, "P30036") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is filmed with (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30037">http://rdaregistry.info/Elements/m/P30037</seealso>
    let P30037 = Prefixed_Name(rdam, "P30037") |> PrefixedName
    /// <summary>
    ///   <para>rdam:issuedWith.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/issuedWith.en">http://rdaregistry.info/Elements/m/issuedWith.en</seealso>
    let ``issuedWith.en`` = Prefixed_Name(rdam, "issuedWith.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30071</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has braille embosser</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30071">http://rdaregistry.info/Elements/m/P30071</seealso>
    let P30071 = Prefixed_Name(rdam, "P30071") |> PrefixedName

    /// <summary>
    ///   <para>rdam:brailleEmbosser.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/brailleEmbosser.en">http://rdaregistry.info/Elements/m/brailleEmbosser.en</seealso>
    let ``brailleEmbosser.en`` =
        Prefixed_Name(rdam, "brailleEmbosser.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30072</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has printmaker</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30072">http://rdaregistry.info/Elements/m/P30072</seealso>
    let P30072 = Prefixed_Name(rdam, "P30072") |> PrefixedName
    /// <summary>
    ///   <para>rdam:printmaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/printmaker.en">http://rdaregistry.info/Elements/m/printmaker.en</seealso>
    let ``printmaker.en`` = Prefixed_Name(rdam, "printmaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30074</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has lithographer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30074">http://rdaregistry.info/Elements/m/P30074</seealso>
    let P30074 = Prefixed_Name(rdam, "P30074") |> PrefixedName
    /// <summary>
    ///   <para>rdam:lithographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/lithographer.en">http://rdaregistry.info/Elements/m/lithographer.en</seealso>
    let ``lithographer.en`` = Prefixed_Name(rdam, "lithographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30075</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has platemaker</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30075">http://rdaregistry.info/Elements/m/P30075</seealso>
    let P30075 = Prefixed_Name(rdam, "P30075") |> PrefixedName
    /// <summary>
    ///   <para>rdam:platemaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/platemaker.en">http://rdaregistry.info/Elements/m/platemaker.en</seealso>
    let ``platemaker.en`` = Prefixed_Name(rdam, "platemaker.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30076</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has etcher</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30076">http://rdaregistry.info/Elements/m/P30076</seealso>
    let P30076 = Prefixed_Name(rdam, "P30076") |> PrefixedName
    /// <summary>
    ///   <para>rdam:etcher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/etcher.en">http://rdaregistry.info/Elements/m/etcher.en</seealso>
    let ``etcher.en`` = Prefixed_Name(rdam, "etcher.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30077</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has collotyper</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30077">http://rdaregistry.info/Elements/m/P30077</seealso>
    let P30077 = Prefixed_Name(rdam, "P30077") |> PrefixedName
    /// <summary>
    ///   <para>rdam:collotyper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/collotyper.en">http://rdaregistry.info/Elements/m/collotyper.en</seealso>
    let ``collotyper.en`` = Prefixed_Name(rdam, "collotyper.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30079</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other person, family, or corporate body associated with a manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30079">http://rdaregistry.info/Elements/m/P30079</seealso>
    let P30079 = Prefixed_Name(rdam, "P30079") |> PrefixedName

    /// <summary>
    ///   <para>rdam:otherPFCManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/otherPFCManifestation.en">http://rdaregistry.info/Elements/m/otherPFCManifestation.en</seealso>
    let ``otherPFCManifestation.en`` =
        Prefixed_Name(rdam, "otherPFCManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:distributor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/distributor.en">http://rdaregistry.info/Elements/m/distributor.en</seealso>
    let ``distributor.en`` = Prefixed_Name(rdam, "distributor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30215</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has papermaker</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30215">http://rdaregistry.info/Elements/m/P30215</seealso>
    let P30215 = Prefixed_Name(rdam, "P30215") |> PrefixedName
    /// <summary>
    ///   <para>rdam:manufacturer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/manufacturer.en">http://rdaregistry.info/Elements/m/manufacturer.en</seealso>
    let ``manufacturer.en`` = Prefixed_Name(rdam, "manufacturer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:publisher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/publisher.en">http://rdaregistry.info/Elements/m/publisher.en</seealso>
    let ``publisher.en`` = Prefixed_Name(rdam, "publisher.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30084</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has applied material</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30084">http://rdaregistry.info/Elements/m/P30084</seealso>
    let P30084 = Prefixed_Name(rdam, "P30084") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30122</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has emulsion on microfilm and microfiche</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30122">http://rdaregistry.info/Elements/m/P30122</seealso>
    let P30122 = Prefixed_Name(rdam, "P30122") |> PrefixedName

    /// <summary>
    ///   <para>rdam:appliedMaterial.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/appliedMaterial.en">http://rdaregistry.info/Elements/m/appliedMaterial.en</seealso>
    let ``appliedMaterial.en`` =
        Prefixed_Name(rdam, "appliedMaterial.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30086</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of production</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30086">http://rdaregistry.info/Elements/m/P30086</seealso>
    let P30086 = Prefixed_Name(rdam, "P30086") |> PrefixedName

    /// <summary>
    ///   <para>rdam:placeOfProduction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/placeOfProduction.en">http://rdaregistry.info/Elements/m/placeOfProduction.en</seealso>
    let ``placeOfProduction.en`` =
        Prefixed_Name(rdam, "placeOfProduction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30087</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of manufacture</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30087">http://rdaregistry.info/Elements/m/P30087</seealso>
    let P30087 = Prefixed_Name(rdam, "P30087") |> PrefixedName

    /// <summary>
    ///   <para>rdam:placeOfManufacture.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/placeOfManufacture.en">http://rdaregistry.info/Elements/m/placeOfManufacture.en</seealso>
    let ``placeOfManufacture.en`` =
        Prefixed_Name(rdam, "placeOfManufacture.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30088</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of publication</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30088">http://rdaregistry.info/Elements/m/P30088</seealso>
    let P30088 = Prefixed_Name(rdam, "P30088") |> PrefixedName

    /// <summary>
    ///   <para>rdam:placeOfPublication.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/placeOfPublication.en">http://rdaregistry.info/Elements/m/placeOfPublication.en</seealso>
    let ``placeOfPublication.en`` =
        Prefixed_Name(rdam, "placeOfPublication.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30089</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel place of distribution</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30089">http://rdaregistry.info/Elements/m/P30089</seealso>
    let P30089 = Prefixed_Name(rdam, "P30089") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelPlaceOfDistribution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelPlaceOfDistribution.en">http://rdaregistry.info/Elements/m/parallelPlaceOfDistribution.en</seealso>
    let ``parallelPlaceOfDistribution.en`` =
        Prefixed_Name(rdam, "parallelPlaceOfDistribution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelStatementOfResponsibilityRelatingToSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToSeries.en">http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToSeries.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToSeries.en`` =
        Prefixed_Name(rdam, "parallelStatementOfResponsibilityRelatingToSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30114</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel statement of responsibility relating to subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30114">http://rdaregistry.info/Elements/m/P30114</seealso>
    let P30114 = Prefixed_Name(rdam, "P30114") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelStatementOfResponsibilityRelatingToSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToSubseries.en">http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToSubseries.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToSubseries.en`` =
        Prefixed_Name(rdam, "parallelStatementOfResponsibilityRelatingToSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30115</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel statement of responsibility relating to the edition</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30115">http://rdaregistry.info/Elements/m/P30115</seealso>
    let P30115 = Prefixed_Name(rdam, "P30115") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelStatementOfResponsibilityRelatingToTheEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToTheEdition.en">http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToTheEdition.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToTheEdition.en`` =
        Prefixed_Name(rdam, "parallelStatementOfResponsibilityRelatingToTheEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30116</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has parallel statement of responsibility relating to title proper</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30116">http://rdaregistry.info/Elements/m/P30116</seealso>
    let P30116 = Prefixed_Name(rdam, "P30116") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelStatementOfResponsibilityRelatingToTitleProper.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToTitleProper.en">http://rdaregistry.info/Elements/m/parallelStatementOfResponsibilityRelatingToTitleProper.en</seealso>
    let ``parallelStatementOfResponsibilityRelatingToTitleProper.en`` =
        Prefixed_Name(rdam, "parallelStatementOfResponsibilityRelatingToTitleProper.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30118</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has statement of responsibility relating to a named revision of an edition</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30118">http://rdaregistry.info/Elements/m/P30118</seealso>
    let P30118 = Prefixed_Name(rdam, "P30118") |> PrefixedName

    /// <summary>
    ///   <para>rdam:statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en">http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en</seealso>
    let ``statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en`` =
        Prefixed_Name(rdam, "statementOfResponsibilityRelatingToANamedRevisionOfAnEdition.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30119</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has statement of responsibility relating to series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30119">http://rdaregistry.info/Elements/m/P30119</seealso>
    let P30119 = Prefixed_Name(rdam, "P30119") |> PrefixedName

    /// <summary>
    ///   <para>rdam:statementOfResponsibilityRelatingToSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToSeries.en">http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToSeries.en</seealso>
    let ``statementOfResponsibilityRelatingToSeries.en`` =
        Prefixed_Name(rdam, "statementOfResponsibilityRelatingToSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30120</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has statement of responsibility relating to subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30120">http://rdaregistry.info/Elements/m/P30120</seealso>
    let P30120 = Prefixed_Name(rdam, "P30120") |> PrefixedName

    /// <summary>
    ///   <para>rdam:statementOfResponsibilityRelatingToSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToSubseries.en">http://rdaregistry.info/Elements/m/statementOfResponsibilityRelatingToSubseries.en</seealso>
    let ``statementOfResponsibilityRelatingToSubseries.en`` =
        Prefixed_Name(rdam, "statementOfResponsibilityRelatingToSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30121</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has statement of responsibility relating to the edition</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30121">http://rdaregistry.info/Elements/m/P30121</seealso>
    let P30121 = Prefixed_Name(rdam, "P30121") |> PrefixedName

    /// <summary>
    ///   <para>rdam:emulsionOnMicrofilmAndMicrofiche.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/emulsionOnMicrofilmAndMicrofiche.en">http://rdaregistry.info/Elements/m/emulsionOnMicrofilmAndMicrofiche.en</seealso>
    let ``emulsionOnMicrofilmAndMicrofiche.en`` =
        Prefixed_Name(rdam, "emulsionOnMicrofilmAndMicrofiche.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30123</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has broadcast standard</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30123">http://rdaregistry.info/Elements/m/P30123</seealso>
    let P30123 = Prefixed_Name(rdam, "P30123") |> PrefixedName

    /// <summary>
    ///   <para>rdam:broadcastStandard.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/broadcastStandard.en">http://rdaregistry.info/Elements/m/broadcastStandard.en</seealso>
    let ``broadcastStandard.en`` =
        Prefixed_Name(rdam, "broadcastStandard.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30202</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has encoded bitrate</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30202">http://rdaregistry.info/Elements/m/P30202</seealso>
    let P30202 = Prefixed_Name(rdam, "P30202") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30159</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has resolution</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30159">http://rdaregistry.info/Elements/m/P30159</seealso>
    let P30159 = Prefixed_Name(rdam, "P30159") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30183</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has file size</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30183">http://rdaregistry.info/Elements/m/P30183</seealso>
    let P30183 = Prefixed_Name(rdam, "P30183") |> PrefixedName

    /// <summary>
    ///   <para>rdam:digitalFileCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/digitalFileCharacteristic.en">http://rdaregistry.info/Elements/m/digitalFileCharacteristic.en</seealso>
    let ``digitalFileCharacteristic.en`` =
        Prefixed_Name(rdam, "digitalFileCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30125</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sound characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30125">http://rdaregistry.info/Elements/m/P30125</seealso>
    let P30125 = Prefixed_Name(rdam, "P30125") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30185</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has tape configuration</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30185">http://rdaregistry.info/Elements/m/P30185</seealso>
    let P30185 = Prefixed_Name(rdam, "P30185") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30172</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has type of recording</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30172">http://rdaregistry.info/Elements/m/P30172</seealso>
    let P30172 = Prefixed_Name(rdam, "P30172") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30184</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has configuration of playback channels</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30184">http://rdaregistry.info/Elements/m/P30184</seealso>
    let P30184 = Prefixed_Name(rdam, "P30184") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30138</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has special playback characteristic</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30138">http://rdaregistry.info/Elements/m/P30138</seealso>
    let P30138 = Prefixed_Name(rdam, "P30138") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30139</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has expression manifested</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30139">http://rdaregistry.info/Elements/m/P30139</seealso>
    let P30139 = Prefixed_Name(rdam, "P30139") |> PrefixedName

    /// <summary>
    ///   <para>rdam:expressionManifested.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/expressionManifested.en">http://rdaregistry.info/Elements/m/expressionManifested.en</seealso>
    let ``expressionManifested.en`` =
        Prefixed_Name(rdam, "expressionManifested.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30140</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has related item</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30140">http://rdaregistry.info/Elements/m/P30140</seealso>
    let P30140 = Prefixed_Name(rdam, "P30140") |> PrefixedName
    /// <summary>
    ///   <para>rdam:relatedItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/relatedItem.en">http://rdaregistry.info/Elements/m/relatedItem.en</seealso>
    let ``relatedItem.en`` = Prefixed_Name(rdam, "relatedItem.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30141</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has contact information</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30141">http://rdaregistry.info/Elements/m/P30141</seealso>
    let P30141 = Prefixed_Name(rdam, "P30141") |> PrefixedName

    /// <summary>
    ///   <para>rdam:contactInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/contactInformation.en">http://rdaregistry.info/Elements/m/contactInformation.en</seealso>
    let ``contactInformation.en`` =
        Prefixed_Name(rdam, "contactInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:otherTitleInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/otherTitleInformation.en">http://rdaregistry.info/Elements/m/otherTitleInformation.en</seealso>
    let ``otherTitleInformation.en`` =
        Prefixed_Name(rdam, "otherTitleInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:otherTitleInformationOfSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/otherTitleInformationOfSeries.en">http://rdaregistry.info/Elements/m/otherTitleInformationOfSeries.en</seealso>
    let ``otherTitleInformationOfSeries.en`` =
        Prefixed_Name(rdam, "otherTitleInformationOfSeries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30144</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other title information of subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30144">http://rdaregistry.info/Elements/m/P30144</seealso>
    let P30144 = Prefixed_Name(rdam, "P30144") |> PrefixedName

    /// <summary>
    ///   <para>rdam:otherTitleInformationOfSubseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/otherTitleInformationOfSubseries.en">http://rdaregistry.info/Elements/m/otherTitleInformationOfSubseries.en</seealso>
    let ``otherTitleInformationOfSubseries.en`` =
        Prefixed_Name(rdam, "otherTitleInformationOfSubseries.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30145</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has restrictions on access to manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30145">http://rdaregistry.info/Elements/m/P30145</seealso>
    let P30145 = Prefixed_Name(rdam, "P30145") |> PrefixedName

    /// <summary>
    ///   <para>rdam:restrictionsOnAccessToManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/restrictionsOnAccessToManifestation.en">http://rdaregistry.info/Elements/m/restrictionsOnAccessToManifestation.en</seealso>
    let ``restrictionsOnAccessToManifestation.en`` =
        Prefixed_Name(rdam, "restrictionsOnAccessToManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30146</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has restrictions on use of manifestation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30146">http://rdaregistry.info/Elements/m/P30146</seealso>
    let P30146 = Prefixed_Name(rdam, "P30146") |> PrefixedName

    /// <summary>
    ///   <para>rdam:restrictionsOnUseOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/restrictionsOnUseOfManifestation.en">http://rdaregistry.info/Elements/m/restrictionsOnUseOfManifestation.en</seealso>
    let ``restrictionsOnUseOfManifestation.en`` =
        Prefixed_Name(rdam, "restrictionsOnUseOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30148</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has numeric and/or alphabetic designation of last issue or part of sequence</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30148">http://rdaregistry.info/Elements/m/P30148</seealso>
    let P30148 = Prefixed_Name(rdam, "P30148") |> PrefixedName

    /// <summary>
    ///   <para>rdam:numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/m/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en</seealso>
    let ``numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdam, "numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30149</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has chronological designation of first issue or part of sequence</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30149">http://rdaregistry.info/Elements/m/P30149</seealso>
    let P30149 = Prefixed_Name(rdam, "P30149") |> PrefixedName

    /// <summary>
    ///   <para>rdam:chronologicalDesignationOfFirstIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/chronologicalDesignationOfFirstIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/m/chronologicalDesignationOfFirstIssueOrPartOfSequence.en</seealso>
    let ``chronologicalDesignationOfFirstIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdam, "chronologicalDesignationOfFirstIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30150</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has chronological designation of last issue or part of sequence</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30150">http://rdaregistry.info/Elements/m/P30150</seealso>
    let P30150 = Prefixed_Name(rdam, "P30150") |> PrefixedName

    /// <summary>
    ///   <para>rdam:chronologicalDesignationOfLastIssueOrPartOfSequence.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/chronologicalDesignationOfLastIssueOrPartOfSequence.en">http://rdaregistry.info/Elements/m/chronologicalDesignationOfLastIssueOrPartOfSequence.en</seealso>
    let ``chronologicalDesignationOfLastIssueOrPartOfSequence.en`` =
        Prefixed_Name(rdam, "chronologicalDesignationOfLastIssueOrPartOfSequence.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:parallelOtherTitleInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/parallelOtherTitleInformation.en">http://rdaregistry.info/Elements/m/parallelOtherTitleInformation.en</seealso>
    let ``parallelOtherTitleInformation.en`` =
        Prefixed_Name(rdam, "parallelOtherTitleInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:typeOfRecording.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/typeOfRecording.en">http://rdaregistry.info/Elements/m/typeOfRecording.en</seealso>
    let ``typeOfRecording.en`` =
        Prefixed_Name(rdam, "typeOfRecording.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30173</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has distributor’s name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30173">http://rdaregistry.info/Elements/m/P30173</seealso>
    let P30173 = Prefixed_Name(rdam, "P30173") |> PrefixedName

    /// <summary>
    ///   <para>rdam:distributorsName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/distributorsName.en">http://rdaregistry.info/Elements/m/distributorsName.en</seealso>
    let ``distributorsName.en`` =
        Prefixed_Name(rdam, "distributorsName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30174</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has producer’s name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30174">http://rdaregistry.info/Elements/m/P30174</seealso>
    let P30174 = Prefixed_Name(rdam, "P30174") |> PrefixedName
    /// <summary>
    ///   <para>rdam:producersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/producersName.en">http://rdaregistry.info/Elements/m/producersName.en</seealso>
    let ``producersName.en`` = Prefixed_Name(rdam, "producersName.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30175</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has manufacturer’s name</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30175">http://rdaregistry.info/Elements/m/P30175</seealso>
    let P30175 = Prefixed_Name(rdam, "P30175") |> PrefixedName

    /// <summary>
    ///   <para>rdam:manufacturersName.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/manufacturersName.en">http://rdaregistry.info/Elements/m/manufacturersName.en</seealso>
    let ``manufacturersName.en`` =
        Prefixed_Name(rdam, "manufacturersName.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30182</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has extent</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30182">http://rdaregistry.info/Elements/m/P30182</seealso>
    let P30182 = Prefixed_Name(rdam, "P30182") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30178</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has extent of notated music</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30178">http://rdaregistry.info/Elements/m/P30178</seealso>
    let P30178 = Prefixed_Name(rdam, "P30178") |> PrefixedName

    /// <summary>
    ///   <para>rdam:extentOfNotatedMusic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/extentOfNotatedMusic.en">http://rdaregistry.info/Elements/m/extentOfNotatedMusic.en</seealso>
    let ``extentOfNotatedMusic.en`` =
        Prefixed_Name(rdam, "extentOfNotatedMusic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30179</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has extent of still image</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30179">http://rdaregistry.info/Elements/m/P30179</seealso>
    let P30179 = Prefixed_Name(rdam, "P30179") |> PrefixedName

    /// <summary>
    ///   <para>rdam:extentOfStillImage.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/extentOfStillImage.en">http://rdaregistry.info/Elements/m/extentOfStillImage.en</seealso>
    let ``extentOfStillImage.en`` =
        Prefixed_Name(rdam, "extentOfStillImage.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30180</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has extent of three-dimensional form</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30180">http://rdaregistry.info/Elements/m/P30180</seealso>
    let P30180 = Prefixed_Name(rdam, "P30180") |> PrefixedName

    /// <summary>
    ///   <para>rdam:extentOfThreeDimensionalForm.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/extentOfThreeDimensionalForm.en">http://rdaregistry.info/Elements/m/extentOfThreeDimensionalForm.en</seealso>
    let ``extentOfThreeDimensionalForm.en`` =
        Prefixed_Name(rdam, "extentOfThreeDimensionalForm.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30181</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has extent of text</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30181">http://rdaregistry.info/Elements/m/P30181</seealso>
    let P30181 = Prefixed_Name(rdam, "P30181") |> PrefixedName
    /// <summary>
    ///   <para>rdam:extentOfText.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/extentOfText.en">http://rdaregistry.info/Elements/m/extentOfText.en</seealso>
    let ``extentOfText.en`` = Prefixed_Name(rdam, "extentOfText.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:extent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/extent.en">http://rdaregistry.info/Elements/m/extent.en</seealso>
    let ``extent.en`` = Prefixed_Name(rdam, "extent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdam:fileSize.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/fileSize.en">http://rdaregistry.info/Elements/m/fileSize.en</seealso>
    let ``fileSize.en`` = Prefixed_Name(rdam, "fileSize.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:configurationOfPlaybackChannels.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/configurationOfPlaybackChannels.en">http://rdaregistry.info/Elements/m/configurationOfPlaybackChannels.en</seealso>
    let ``configurationOfPlaybackChannels.en`` =
        Prefixed_Name(rdam, "configurationOfPlaybackChannels.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:tapeConfiguration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/tapeConfiguration.en">http://rdaregistry.info/Elements/m/tapeConfiguration.en</seealso>
    let ``tapeConfiguration.en`` =
        Prefixed_Name(rdam, "tapeConfiguration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfDigitalRepresentationOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfDigitalRepresentationOfCartographicContent.en">http://rdaregistry.info/Elements/m/detailsOfDigitalRepresentationOfCartographicContent.en</seealso>
    let ``detailsOfDigitalRepresentationOfCartographicContent.en`` =
        Prefixed_Name(rdam, "detailsOfDigitalRepresentationOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfEmulsionOnMicrofilmAndMicrofiche.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfEmulsionOnMicrofilmAndMicrofiche.en">http://rdaregistry.info/Elements/m/detailsOfEmulsionOnMicrofilmAndMicrofiche.en</seealso>
    let ``detailsOfEmulsionOnMicrofilmAndMicrofiche.en`` =
        Prefixed_Name(rdam, "detailsOfEmulsionOnMicrofilmAndMicrofiche.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfEncodingFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfEncodingFormat.en">http://rdaregistry.info/Elements/m/detailsOfEncodingFormat.en</seealso>
    let ``detailsOfEncodingFormat.en`` =
        Prefixed_Name(rdam, "detailsOfEncodingFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfFileType.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfFileType.en">http://rdaregistry.info/Elements/m/detailsOfFileType.en</seealso>
    let ``detailsOfFileType.en`` =
        Prefixed_Name(rdam, "detailsOfFileType.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30226</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of font size</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30226">http://rdaregistry.info/Elements/m/P30226</seealso>
    let P30226 = Prefixed_Name(rdam, "P30226") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfFontSize.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfFontSize.en">http://rdaregistry.info/Elements/m/detailsOfFontSize.en</seealso>
    let ``detailsOfFontSize.en`` =
        Prefixed_Name(rdam, "detailsOfFontSize.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30227</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of generation of audio recording</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30227">http://rdaregistry.info/Elements/m/P30227</seealso>
    let P30227 = Prefixed_Name(rdam, "P30227") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfGenerationOfAudioRecording.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfGenerationOfAudioRecording.en">http://rdaregistry.info/Elements/m/detailsOfGenerationOfAudioRecording.en</seealso>
    let ``detailsOfGenerationOfAudioRecording.en`` =
        Prefixed_Name(rdam, "detailsOfGenerationOfAudioRecording.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30252</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of generation</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30252">http://rdaregistry.info/Elements/m/P30252</seealso>
    let P30252 = Prefixed_Name(rdam, "P30252") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30228</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of generation of digital resource</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30228">http://rdaregistry.info/Elements/m/P30228</seealso>
    let P30228 = Prefixed_Name(rdam, "P30228") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfGenerationOfDigitalResource.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfGenerationOfDigitalResource.en">http://rdaregistry.info/Elements/m/detailsOfGenerationOfDigitalResource.en</seealso>
    let ``detailsOfGenerationOfDigitalResource.en`` =
        Prefixed_Name(rdam, "detailsOfGenerationOfDigitalResource.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfTapeConfiguration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfTapeConfiguration.en">http://rdaregistry.info/Elements/m/detailsOfTapeConfiguration.en</seealso>
    let ``detailsOfTapeConfiguration.en`` =
        Prefixed_Name(rdam, "detailsOfTapeConfiguration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfTrackConfiguration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfTrackConfiguration.en">http://rdaregistry.info/Elements/m/detailsOfTrackConfiguration.en</seealso>
    let ``detailsOfTrackConfiguration.en`` =
        Prefixed_Name(rdam, "detailsOfTrackConfiguration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfTypeOfRecording.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfTypeOfRecording.en">http://rdaregistry.info/Elements/m/detailsOfTypeOfRecording.en</seealso>
    let ``detailsOfTypeOfRecording.en`` =
        Prefixed_Name(rdam, "detailsOfTypeOfRecording.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30251</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has details of video format</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30251">http://rdaregistry.info/Elements/m/P30251</seealso>
    let P30251 = Prefixed_Name(rdam, "P30251") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfVideoCharacteristic.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfVideoCharacteristic.en">http://rdaregistry.info/Elements/m/detailsOfVideoCharacteristic.en</seealso>
    let ``detailsOfVideoCharacteristic.en`` =
        Prefixed_Name(rdam, "detailsOfVideoCharacteristic.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfVideoFormat.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfVideoFormat.en">http://rdaregistry.info/Elements/m/detailsOfVideoFormat.en</seealso>
    let ``detailsOfVideoFormat.en`` =
        Prefixed_Name(rdam, "detailsOfVideoFormat.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:detailsOfGeneration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/detailsOfGeneration.en">http://rdaregistry.info/Elements/m/detailsOfGeneration.en</seealso>
    let ``detailsOfGeneration.en`` =
        Prefixed_Name(rdam, "detailsOfGeneration.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:P30253</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30253">http://rdaregistry.info/Elements/m/P30253</seealso>
    let P30253 = Prefixed_Name(rdam, "P30253") |> PrefixedName
    /// <summary>
    ///   <para>rdam:P30254</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is described in (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/P30254">http://rdaregistry.info/Elements/m/P30254</seealso>
    let P30254 = Prefixed_Name(rdam, "P30254") |> PrefixedName

    /// <summary>
    ///   <para>rdam:subjectOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/subjectOfManifestation.en">http://rdaregistry.info/Elements/m/subjectOfManifestation.en</seealso>
    let ``subjectOfManifestation.en`` =
        Prefixed_Name(rdam, "subjectOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:commentaryInManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/commentaryInManifestation.en">http://rdaregistry.info/Elements/m/commentaryInManifestation.en</seealso>
    let ``commentaryInManifestation.en`` =
        Prefixed_Name(rdam, "commentaryInManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:critiquedInManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/critiquedInManifestation.en">http://rdaregistry.info/Elements/m/critiquedInManifestation.en</seealso>
    let ``critiquedInManifestation.en`` =
        Prefixed_Name(rdam, "critiquedInManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:evaluatedInManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/evaluatedInManifestation.en">http://rdaregistry.info/Elements/m/evaluatedInManifestation.en</seealso>
    let ``evaluatedInManifestation.en`` =
        Prefixed_Name(rdam, "evaluatedInManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdam:reviewedInManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/m/reviewedInManifestation.en">http://rdaregistry.info/Elements/m/reviewedInManifestation.en</seealso>
    let ``reviewedInManifestation.en`` =
        Prefixed_Name(rdam, "reviewedInManifestation.en") |> PrefixedName
