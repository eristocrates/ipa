namespace http.rdaregistry.info.Elements.w.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdaw =
    let _namespace_iri = Namespace_Iri rdaw |> NamespaceIRI
    /// <summary>
    ///   <para>rdaw:P10001</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has respondent</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10001">http://rdaregistry.info/Elements/w/P10001</seealso>
    let P10001 = Prefixed_Name(rdaw, "P10001") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:respondent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/respondent">http://rdaregistry.info/Elements/w/respondent</seealso>
    let respondent = Prefixed_Name(rdaw, "respondent") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:identifierForTheWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/identifierForTheWork">http://rdaregistry.info/Elements/w/identifierForTheWork</seealso>
    let identifierForTheWork =
        Prefixed_Name(rdaw, "identifierForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:otherDistinguishingCharacteristicOfTheWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/otherDistinguishingCharacteristicOfTheWork">http://rdaregistry.info/Elements/w/otherDistinguishingCharacteristicOfTheWork</seealso>
    let otherDistinguishingCharacteristicOfTheWork =
        Prefixed_Name(rdaw, "otherDistinguishingCharacteristicOfTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10004</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has form of work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10004">http://rdaregistry.info/Elements/w/P10004</seealso>
    let P10004 = Prefixed_Name(rdaw, "P10004") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:appelleeCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appelleeCorporateBody.en">http://rdaregistry.info/Elements/w/appelleeCorporateBody.en</seealso>
    let ``appelleeCorporateBody.en`` =
        Prefixed_Name(rdaw, "appelleeCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10037</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has appellee</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10037">http://rdaregistry.info/Elements/w/P10037</seealso>
    let P10037 = Prefixed_Name(rdaw, "P10037") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:appelleeCorporateBody</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appelleeCorporateBody">http://rdaregistry.info/Elements/w/appelleeCorporateBody</seealso>
    let appelleeCorporateBody =
        Prefixed_Name(rdaw, "appelleeCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:hostInstitution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/hostInstitution">http://rdaregistry.info/Elements/w/hostInstitution</seealso>
    let hostInstitution = Prefixed_Name(rdaw, "hostInstitution") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10008</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has production company</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10008">http://rdaregistry.info/Elements/w/P10008</seealso>
    let P10008 = Prefixed_Name(rdaw, "P10008") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10038</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has appellant</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10038">http://rdaregistry.info/Elements/w/P10038</seealso>
    let P10038 = Prefixed_Name(rdaw, "P10038") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:appellantCorporateBody</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appellantCorporateBody">http://rdaregistry.info/Elements/w/appellantCorporateBody</seealso>
    let appellantCorporateBody =
        Prefixed_Name(rdaw, "appellantCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:plaintiffCorporateBody</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/plaintiffCorporateBody">http://rdaregistry.info/Elements/w/plaintiffCorporateBody</seealso>
    let plaintiffCorporateBody =
        Prefixed_Name(rdaw, "plaintiffCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10011</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has court governed</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10011">http://rdaregistry.info/Elements/w/P10011</seealso>
    let P10011 = Prefixed_Name(rdaw, "P10011") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:courtGoverned.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/courtGoverned.en">http://rdaregistry.info/Elements/w/courtGoverned.en</seealso>
    let ``courtGoverned.en`` = Prefixed_Name(rdaw, "courtGoverned.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:numberingOfPart</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/numberingOfPart">http://rdaregistry.info/Elements/w/numberingOfPart</seealso>
    let numberingOfPart = Prefixed_Name(rdaw, "numberingOfPart") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has director</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10066">http://rdaregistry.info/Elements/w/P10066</seealso>
    let P10066 = Prefixed_Name(rdaw, "P10066") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:filmDirector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/filmDirector">http://rdaregistry.info/Elements/w/filmDirector</seealso>
    let filmDirector = Prefixed_Name(rdaw, "filmDirector") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionDirector.en">http://rdaregistry.info/Elements/w/televisionDirector.en</seealso>
    let ``televisionDirector.en`` =
        Prefixed_Name(rdaw, "televisionDirector.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionDirector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionDirector">http://rdaregistry.info/Elements/w/televisionDirector</seealso>
    let televisionDirector = Prefixed_Name(rdaw, "televisionDirector") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10127</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dramatization of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10127">http://rdaregistry.info/Elements/w/P10127</seealso>
    let P10127 = Prefixed_Name(rdaw, "P10127") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:dramatizedAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dramatizedAsWork">http://rdaregistry.info/Elements/w/dramatizedAsWork</seealso>
    let dramatizedAsWork = Prefixed_Name(rdaw, "dramatizedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10017</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has enacting jurisdiction</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10017">http://rdaregistry.info/Elements/w/P10017</seealso>
    let P10017 = Prefixed_Name(rdaw, "P10017") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:enactingJurisdiction.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/enactingJurisdiction.en">http://rdaregistry.info/Elements/w/enactingJurisdiction.en</seealso>
    let ``enactingJurisdiction.en`` =
        Prefixed_Name(rdaw, "enactingJurisdiction.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:jurisdictionGoverned</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/jurisdictionGoverned">http://rdaregistry.info/Elements/w/jurisdictionGoverned</seealso>
    let jurisdictionGoverned =
        Prefixed_Name(rdaw, "jurisdictionGoverned") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10019</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is contained in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10019">http://rdaregistry.info/Elements/w/P10019</seealso>
    let P10019 = Prefixed_Name(rdaw, "P10019") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10147</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is container of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10147">http://rdaregistry.info/Elements/w/P10147</seealso>
    let P10147 = Prefixed_Name(rdaw, "P10147") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:containedInWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/containedInWork">http://rdaregistry.info/Elements/w/containedInWork</seealso>
    let containedInWork = Prefixed_Name(rdaw, "containedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10020</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is sequel</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10020">http://rdaregistry.info/Elements/w/P10020</seealso>
    let P10020 = Prefixed_Name(rdaw, "P10020") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:sequel.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sequel.en">http://rdaregistry.info/Elements/w/sequel.en</seealso>
    let ``sequel.en`` = Prefixed_Name(rdaw, "sequel.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:replacedInPartByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/replacedInPartByWork">http://rdaregistry.info/Elements/w/replacedInPartByWork</seealso>
    let replacedInPartByWork =
        Prefixed_Name(rdaw, "replacedInPartByWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10022</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is replaced by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10022">http://rdaregistry.info/Elements/w/P10022</seealso>
    let P10022 = Prefixed_Name(rdaw, "P10022") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:replacedByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/replacedByWork.en">http://rdaregistry.info/Elements/w/replacedByWork.en</seealso>
    let ``replacedByWork.en`` = Prefixed_Name(rdaw, "replacedByWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:coordinatesOfCartographicContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/coordinatesOfCartographicContent">http://rdaregistry.info/Elements/w/coordinatesOfCartographicContent</seealso>
    let coordinatesOfCartographicContent =
        Prefixed_Name(rdaw, "coordinatesOfCartographicContent") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10025</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as motion picture (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10025">http://rdaregistry.info/Elements/w/P10025</seealso>
    let P10025 = Prefixed_Name(rdaw, "P10025") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsMotionPictureWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsMotionPictureWork.en">http://rdaregistry.info/Elements/w/adaptedAsMotionPictureWork.en</seealso>
    let ``adaptedAsMotionPictureWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsMotionPictureWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10129</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is motion picture adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10129">http://rdaregistry.info/Elements/w/P10129</seealso>
    let P10129 = Prefixed_Name(rdaw, "P10129") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsAMotionPictureWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsAMotionPictureWork">http://rdaregistry.info/Elements/w/adaptedAsAMotionPictureWork</seealso>
    let adaptedAsAMotionPictureWork =
        Prefixed_Name(rdaw, "adaptedAsAMotionPictureWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10108</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is augmented by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10108">http://rdaregistry.info/Elements/w/P10108</seealso>
    let P10108 = Prefixed_Name(rdaw, "P10108") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10029</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is cadenza composed for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10029">http://rdaregistry.info/Elements/w/P10029</seealso>
    let P10029 = Prefixed_Name(rdaw, "P10029") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:cadenzaWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/cadenzaWork">http://rdaregistry.info/Elements/w/cadenzaWork</seealso>
    let cadenzaWork = Prefixed_Name(rdaw, "cadenzaWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10027</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is variations based on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10027">http://rdaregistry.info/Elements/w/P10027</seealso>
    let P10027 = Prefixed_Name(rdaw, "P10027") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:variationsBasedOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/variationsBasedOnWork.en">http://rdaregistry.info/Elements/w/variationsBasedOnWork.en</seealso>
    let ``variationsBasedOnWork.en`` =
        Prefixed_Name(rdaw, "variationsBasedOnWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10190</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is based on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10190">http://rdaregistry.info/Elements/w/P10190</seealso>
    let P10190 = Prefixed_Name(rdaw, "P10190") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10028</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is modified by variation as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10028">http://rdaregistry.info/Elements/w/P10028</seealso>
    let P10028 = Prefixed_Name(rdaw, "P10028") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicalVariationsBasedOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicalVariationsBasedOnWork">http://rdaregistry.info/Elements/w/musicalVariationsBasedOnWork</seealso>
    let musicalVariationsBasedOnWork =
        Prefixed_Name(rdaw, "musicalVariationsBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:cadenzaComposedForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/cadenzaComposedForWork.en">http://rdaregistry.info/Elements/w/cadenzaComposedForWork.en</seealso>
    let ``cadenzaComposedForWork.en`` =
        Prefixed_Name(rdaw, "cadenzaComposedForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10192</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is augmentation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10192">http://rdaregistry.info/Elements/w/P10192</seealso>
    let P10192 = Prefixed_Name(rdaw, "P10192") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:cadenzaComposedForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/cadenzaComposedForWork">http://rdaregistry.info/Elements/w/cadenzaComposedForWork</seealso>
    let cadenzaComposedForWork =
        Prefixed_Name(rdaw, "cadenzaComposedForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10030</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is libretto for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10030">http://rdaregistry.info/Elements/w/P10030</seealso>
    let P10030 = Prefixed_Name(rdaw, "P10030") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:librettoForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/librettoForWork.en">http://rdaregistry.info/Elements/w/librettoForWork.en</seealso>
    let ``librettoForWork.en`` =
        Prefixed_Name(rdaw, "librettoForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10031</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is incidental music (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10031">http://rdaregistry.info/Elements/w/P10031</seealso>
    let P10031 = Prefixed_Name(rdaw, "P10031") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:incidentalMusicWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/incidentalMusicWork.en">http://rdaregistry.info/Elements/w/incidentalMusicWork.en</seealso>
    let ``incidentalMusicWork.en`` =
        Prefixed_Name(rdaw, "incidentalMusicWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10106</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is incidental music for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10106">http://rdaregistry.info/Elements/w/P10106</seealso>
    let P10106 = Prefixed_Name(rdaw, "P10106") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:incidentalMusicWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/incidentalMusicWork">http://rdaregistry.info/Elements/w/incidentalMusicWork</seealso>
    let incidentalMusicWork = Prefixed_Name(rdaw, "incidentalMusicWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10032</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is remade as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10032">http://rdaregistry.info/Elements/w/P10032</seealso>
    let P10032 = Prefixed_Name(rdaw, "P10032") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:remadeAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/remadeAsWork.en">http://rdaregistry.info/Elements/w/remadeAsWork.en</seealso>
    let ``remadeAsWork.en`` = Prefixed_Name(rdaw, "remadeAsWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10033</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is set to music as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10033">http://rdaregistry.info/Elements/w/P10033</seealso>
    let P10033 = Prefixed_Name(rdaw, "P10033") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:setToMusicAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/setToMusicAsWork.en">http://rdaregistry.info/Elements/w/setToMusicAsWork.en</seealso>
    let ``setToMusicAsWork.en`` =
        Prefixed_Name(rdaw, "setToMusicAsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10161</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical setting of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10161">http://rdaregistry.info/Elements/w/P10161</seealso>
    let P10161 = Prefixed_Name(rdaw, "P10161") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:musicalSettingWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicalSettingWork">http://rdaregistry.info/Elements/w/musicalSettingWork</seealso>
    let musicalSettingWork = Prefixed_Name(rdaw, "musicalSettingWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10034</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as novel (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10034">http://rdaregistry.info/Elements/w/P10034</seealso>
    let P10034 = Prefixed_Name(rdaw, "P10034") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsNovelWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsNovelWork.en">http://rdaregistry.info/Elements/w/adaptedAsNovelWork.en</seealso>
    let ``adaptedAsNovelWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsNovelWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:medium</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/medium">http://rdaregistry.info/Elements/w/medium</seealso>
    let medium = Prefixed_Name(rdaw, "medium") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appellee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appellee.en">http://rdaregistry.info/Elements/w/appellee.en</seealso>
    let ``appellee.en`` = Prefixed_Name(rdaw, "appellee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appellee</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appellee">http://rdaregistry.info/Elements/w/appellee</seealso>
    let appellee = Prefixed_Name(rdaw, "appellee") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appellant.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appellant.en">http://rdaregistry.info/Elements/w/appellant.en</seealso>
    let ``appellant.en`` = Prefixed_Name(rdaw, "appellant.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10292</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has participant in a treaty</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10292">http://rdaregistry.info/Elements/w/P10292</seealso>
    let P10292 = Prefixed_Name(rdaw, "P10292") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10070</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has addressee</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10070">http://rdaregistry.info/Elements/w/P10070</seealso>
    let P10070 = Prefixed_Name(rdaw, "P10070") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10284</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has degree committee member</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10284">http://rdaregistry.info/Elements/w/P10284</seealso>
    let P10284 = Prefixed_Name(rdaw, "P10284") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10064</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has producer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10064">http://rdaregistry.info/Elements/w/P10064</seealso>
    let P10064 = Prefixed_Name(rdaw, "P10064") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10068</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has director of photography</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10068">http://rdaregistry.info/Elements/w/P10068</seealso>
    let P10068 = Prefixed_Name(rdaw, "P10068") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10048</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has dedicator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10048">http://rdaregistry.info/Elements/w/P10048</seealso>
    let P10048 = Prefixed_Name(rdaw, "P10048") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10071</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has consultant</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10071">http://rdaregistry.info/Elements/w/P10071</seealso>
    let P10071 = Prefixed_Name(rdaw, "P10071") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10297</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has organizer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10297">http://rdaregistry.info/Elements/w/P10297</seealso>
    let P10297 = Prefixed_Name(rdaw, "P10297") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10049</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has honouree</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10049">http://rdaregistry.info/Elements/w/P10049</seealso>
    let P10049 = Prefixed_Name(rdaw, "P10049") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10287</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has commissioning body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10287">http://rdaregistry.info/Elements/w/P10287</seealso>
    let P10287 = Prefixed_Name(rdaw, "P10287") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:otherPFCWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/otherPFCWork.en">http://rdaregistry.info/Elements/w/otherPFCWork.en</seealso>
    let ``otherPFCWork.en`` = Prefixed_Name(rdaw, "otherPFCWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:honouree.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/honouree.en">http://rdaregistry.info/Elements/w/honouree.en</seealso>
    let ``honouree.en`` = Prefixed_Name(rdaw, "honouree.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:honouree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/honouree">http://rdaregistry.info/Elements/w/honouree</seealso>
    let honouree = Prefixed_Name(rdaw, "honouree") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10050</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has programmer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10050">http://rdaregistry.info/Elements/w/P10050</seealso>
    let P10050 = Prefixed_Name(rdaw, "P10050") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:programmer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/programmer.en">http://rdaregistry.info/Elements/w/programmer.en</seealso>
    let ``programmer.en`` = Prefixed_Name(rdaw, "programmer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:cartographer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/cartographer">http://rdaregistry.info/Elements/w/cartographer</seealso>
    let cartographer = Prefixed_Name(rdaw, "cartographer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10053</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has composer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10053">http://rdaregistry.info/Elements/w/P10053</seealso>
    let P10053 = Prefixed_Name(rdaw, "P10053") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:composer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/composer.en">http://rdaregistry.info/Elements/w/composer.en</seealso>
    let ``composer.en`` = Prefixed_Name(rdaw, "composer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:composer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/composer">http://rdaregistry.info/Elements/w/composer</seealso>
    let composer = Prefixed_Name(rdaw, "composer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10054</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has inventor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10054">http://rdaregistry.info/Elements/w/P10054</seealso>
    let P10054 = Prefixed_Name(rdaw, "P10054") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:inventor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/inventor.en">http://rdaregistry.info/Elements/w/inventor.en</seealso>
    let ``inventor.en`` = Prefixed_Name(rdaw, "inventor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:inventor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/inventor">http://rdaregistry.info/Elements/w/inventor</seealso>
    let inventor = Prefixed_Name(rdaw, "inventor") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10055</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has compiler</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10055">http://rdaregistry.info/Elements/w/P10055</seealso>
    let P10055 = Prefixed_Name(rdaw, "P10055") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:compiler.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/compiler.en">http://rdaregistry.info/Elements/w/compiler.en</seealso>
    let ``compiler.en`` = Prefixed_Name(rdaw, "compiler.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:compiler</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/compiler">http://rdaregistry.info/Elements/w/compiler</seealso>
    let compiler = Prefixed_Name(rdaw, "compiler") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10056</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has photographer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10056">http://rdaregistry.info/Elements/w/P10056</seealso>
    let P10056 = Prefixed_Name(rdaw, "P10056") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:artist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/artist.en">http://rdaregistry.info/Elements/w/artist.en</seealso>
    let ``artist.en`` = Prefixed_Name(rdaw, "artist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:artist</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/artist">http://rdaregistry.info/Elements/w/artist</seealso>
    let artist = Prefixed_Name(rdaw, "artist") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10059</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has interviewee</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10059">http://rdaregistry.info/Elements/w/P10059</seealso>
    let P10059 = Prefixed_Name(rdaw, "P10059") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:interviewee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/interviewee.en">http://rdaregistry.info/Elements/w/interviewee.en</seealso>
    let ``interviewee.en`` = Prefixed_Name(rdaw, "interviewee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:interviewee</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/interviewee">http://rdaregistry.info/Elements/w/interviewee</seealso>
    let interviewee = Prefixed_Name(rdaw, "interviewee") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10060</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has choreographer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10060">http://rdaregistry.info/Elements/w/P10060</seealso>
    let P10060 = Prefixed_Name(rdaw, "P10060") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:choreographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/choreographer.en">http://rdaregistry.info/Elements/w/choreographer.en</seealso>
    let ``choreographer.en`` = Prefixed_Name(rdaw, "choreographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:choreographer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/choreographer">http://rdaregistry.info/Elements/w/choreographer</seealso>
    let choreographer = Prefixed_Name(rdaw, "choreographer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10061</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has author</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10061">http://rdaregistry.info/Elements/w/P10061</seealso>
    let P10061 = Prefixed_Name(rdaw, "P10061") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10205</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has librettist</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10205">http://rdaregistry.info/Elements/w/P10205</seealso>
    let P10205 = Prefixed_Name(rdaw, "P10205") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10255</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has rapporteur</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10255">http://rdaregistry.info/Elements/w/P10255</seealso>
    let P10255 = Prefixed_Name(rdaw, "P10255") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10204</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has lyricist</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10204">http://rdaregistry.info/Elements/w/P10204</seealso>
    let P10204 = Prefixed_Name(rdaw, "P10204") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10203</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has screenwriter</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10203">http://rdaregistry.info/Elements/w/P10203</seealso>
    let P10203 = Prefixed_Name(rdaw, "P10203") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:author.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/author.en">http://rdaregistry.info/Elements/w/author.en</seealso>
    let ``author.en`` = Prefixed_Name(rdaw, "author.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:filmmaker</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/filmmaker">http://rdaregistry.info/Elements/w/filmmaker</seealso>
    let filmmaker = Prefixed_Name(rdaw, "filmmaker") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10074</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has radio producer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10074">http://rdaregistry.info/Elements/w/P10074</seealso>
    let P10074 = Prefixed_Name(rdaw, "P10074") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10075</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has television producer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10075">http://rdaregistry.info/Elements/w/P10075</seealso>
    let P10075 = Prefixed_Name(rdaw, "P10075") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10073</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has film producer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10073">http://rdaregistry.info/Elements/w/P10073</seealso>
    let P10073 = Prefixed_Name(rdaw, "P10073") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:producer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/producer.en">http://rdaregistry.info/Elements/w/producer.en</seealso>
    let ``producer.en`` = Prefixed_Name(rdaw, "producer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:producer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/producer">http://rdaregistry.info/Elements/w/producer</seealso>
    let producer = Prefixed_Name(rdaw, "producer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:creator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/creator.en">http://rdaregistry.info/Elements/w/creator.en</seealso>
    let ``creator.en`` = Prefixed_Name(rdaw, "creator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:creator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/creator">http://rdaregistry.info/Elements/w/creator</seealso>
    let creator = Prefixed_Name(rdaw, "creator") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:director.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/director.en">http://rdaregistry.info/Elements/w/director.en</seealso>
    let ``director.en`` = Prefixed_Name(rdaw, "director.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionProducer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionProducer.en">http://rdaregistry.info/Elements/w/televisionProducer.en</seealso>
    let ``televisionProducer.en`` =
        Prefixed_Name(rdaw, "televisionProducer.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionProducer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionProducer">http://rdaregistry.info/Elements/w/televisionProducer</seealso>
    let televisionProducer = Prefixed_Name(rdaw, "televisionProducer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10076</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as radio program (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10076">http://rdaregistry.info/Elements/w/P10076</seealso>
    let P10076 = Prefixed_Name(rdaw, "P10076") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsRadioProgramWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsRadioProgramWork.en">http://rdaregistry.info/Elements/w/adaptedAsRadioProgramWork.en</seealso>
    let ``adaptedAsRadioProgramWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsRadioProgramWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10131</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10131">http://rdaregistry.info/Elements/w/P10131</seealso>
    let P10131 = Prefixed_Name(rdaw, "P10131") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsARadioProgramWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsARadioProgramWork">http://rdaregistry.info/Elements/w/adaptedAsARadioProgramWork</seealso>
    let adaptedAsARadioProgramWork =
        Prefixed_Name(rdaw, "adaptedAsARadioProgramWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10077</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has academic degree</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10077">http://rdaregistry.info/Elements/w/P10077</seealso>
    let P10077 = Prefixed_Name(rdaw, "P10077") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:academicDegree.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/academicDegree.en">http://rdaregistry.info/Elements/w/academicDegree.en</seealso>
    let ``academicDegree.en`` = Prefixed_Name(rdaw, "academicDegree.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:academicDegree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/academicDegree">http://rdaregistry.info/Elements/w/academicDegree</seealso>
    let academicDegree = Prefixed_Name(rdaw, "academicDegree") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10078</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has expression of work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10078">http://rdaregistry.info/Elements/w/P10078</seealso>
    let P10078 = Prefixed_Name(rdaw, "P10078") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:expressionOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/expressionOfWork.en">http://rdaregistry.info/Elements/w/expressionOfWork.en</seealso>
    let ``expressionOfWork.en`` =
        Prefixed_Name(rdaw, "expressionOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:numericDesignationOfAMusicalWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/numericDesignationOfAMusicalWork.en">http://rdaregistry.info/Elements/w/numericDesignationOfAMusicalWork.en</seealso>
    let ``numericDesignationOfAMusicalWork.en`` =
        Prefixed_Name(rdaw, "numericDesignationOfAMusicalWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:numericDesignationOfAMusicalWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/numericDesignationOfAMusicalWork">http://rdaregistry.info/Elements/w/numericDesignationOfAMusicalWork</seealso>
    let numericDesignationOfAMusicalWork =
        Prefixed_Name(rdaw, "numericDesignationOfAMusicalWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10080</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subseries</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10080">http://rdaregistry.info/Elements/w/P10080</seealso>
    let P10080 = Prefixed_Name(rdaw, "P10080") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:subseries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subseries.en">http://rdaregistry.info/Elements/w/subseries.en</seealso>
    let ``subseries.en`` = Prefixed_Name(rdaw, "subseries.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:subseries</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subseries">http://rdaregistry.info/Elements/w/subseries</seealso>
    let subseries = Prefixed_Name(rdaw, "subseries") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:longitudeAndLatitude.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/longitudeAndLatitude.en">http://rdaregistry.info/Elements/w/longitudeAndLatitude.en</seealso>
    let ``longitudeAndLatitude.en`` =
        Prefixed_Name(rdaw, "longitudeAndLatitude.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:longitudeAndLatitude</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/longitudeAndLatitude">http://rdaregistry.info/Elements/w/longitudeAndLatitude</seealso>
    let longitudeAndLatitude =
        Prefixed_Name(rdaw, "longitudeAndLatitude") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:rightAscensionAndDeclination.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/rightAscensionAndDeclination.en">http://rdaregistry.info/Elements/w/rightAscensionAndDeclination.en</seealso>
    let ``rightAscensionAndDeclination.en`` =
        Prefixed_Name(rdaw, "rightAscensionAndDeclination.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:systemOfOrganization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/systemOfOrganization">http://rdaregistry.info/Elements/w/systemOfOrganization</seealso>
    let systemOfOrganization =
        Prefixed_Name(rdaw, "systemOfOrganization") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10085</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as television program (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10085">http://rdaregistry.info/Elements/w/P10085</seealso>
    let P10085 = Prefixed_Name(rdaw, "P10085") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsTelevisionProgramWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsTelevisionProgramWork.en">http://rdaregistry.info/Elements/w/adaptedAsTelevisionProgramWork.en</seealso>
    let ``adaptedAsTelevisionProgramWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsTelevisionProgramWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10132</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10132">http://rdaregistry.info/Elements/w/P10132</seealso>
    let P10132 = Prefixed_Name(rdaw, "P10132") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsATelevisionProgramWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsATelevisionProgramWork">http://rdaregistry.info/Elements/w/adaptedAsATelevisionProgramWork</seealso>
    let adaptedAsATelevisionProgramWork =
        Prefixed_Name(rdaw, "adaptedAsATelevisionProgramWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10086</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has variant title for the work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10086">http://rdaregistry.info/Elements/w/P10086</seealso>
    let P10086 = Prefixed_Name(rdaw, "P10086") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:variantTitleForTheWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/variantTitleForTheWork.en">http://rdaregistry.info/Elements/w/variantTitleForTheWork.en</seealso>
    let ``variantTitleForTheWork.en`` =
        Prefixed_Name(rdaw, "variantTitleForTheWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10088</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has title of the work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10088">http://rdaregistry.info/Elements/w/P10088</seealso>
    let P10088 = Prefixed_Name(rdaw, "P10088") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:variantTitleForTheWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/variantTitleForTheWork">http://rdaregistry.info/Elements/w/variantTitleForTheWork</seealso>
    let variantTitleForTheWork =
        Prefixed_Name(rdaw, "variantTitleForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10087</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as video (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10087">http://rdaregistry.info/Elements/w/P10087</seealso>
    let P10087 = Prefixed_Name(rdaw, "P10087") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsVideoWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsVideoWork.en">http://rdaregistry.info/Elements/w/adaptedAsVideoWork.en</seealso>
    let ``adaptedAsVideoWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsVideoWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10193</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abstracts for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10193">http://rdaregistry.info/Elements/w/P10193</seealso>
    let P10193 = Prefixed_Name(rdaw, "P10193") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:abstractedInWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abstractedInWork">http://rdaregistry.info/Elements/w/abstractedInWork</seealso>
    let abstractedInWork = Prefixed_Name(rdaw, "abstractedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10090</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is indexed in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10090">http://rdaregistry.info/Elements/w/P10090</seealso>
    let P10090 = Prefixed_Name(rdaw, "P10090") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:indexedInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/indexedInWork.en">http://rdaregistry.info/Elements/w/indexedInWork.en</seealso>
    let ``indexedInWork.en`` = Prefixed_Name(rdaw, "indexedInWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10194</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is indexing for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10194">http://rdaregistry.info/Elements/w/P10194</seealso>
    let P10194 = Prefixed_Name(rdaw, "P10194") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:indexedInWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/indexedInWork">http://rdaregistry.info/Elements/w/indexedInWork</seealso>
    let indexedInWork = Prefixed_Name(rdaw, "indexedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10091</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as choreography (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10091">http://rdaregistry.info/Elements/w/P10091</seealso>
    let P10091 = Prefixed_Name(rdaw, "P10091") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsChoreographyWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsChoreographyWork.en">http://rdaregistry.info/Elements/w/adaptedAsChoreographyWork.en</seealso>
    let ``adaptedAsChoreographyWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsChoreographyWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10183</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is choreographic adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10183">http://rdaregistry.info/Elements/w/P10183</seealso>
    let P10183 = Prefixed_Name(rdaw, "P10183") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:choreographyWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/choreographyWork">http://rdaregistry.info/Elements/w/choreographyWork</seealso>
    let choreographyWork = Prefixed_Name(rdaw, "choreographyWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10092</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is errata (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10092">http://rdaregistry.info/Elements/w/P10092</seealso>
    let P10092 = Prefixed_Name(rdaw, "P10092") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:errataWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/errataWork.en">http://rdaregistry.info/Elements/w/errataWork.en</seealso>
    let ``errataWork.en`` = Prefixed_Name(rdaw, "errataWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10095</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as screenplay (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10095">http://rdaregistry.info/Elements/w/P10095</seealso>
    let P10095 = Prefixed_Name(rdaw, "P10095") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10134</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is motion picture screenplay based on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10134">http://rdaregistry.info/Elements/w/P10134</seealso>
    let P10134 = Prefixed_Name(rdaw, "P10134") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsAMotionPictureScreenplayWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsAMotionPictureScreenplayWork">http://rdaregistry.info/Elements/w/adaptedAsAMotionPictureScreenplayWork</seealso>
    let adaptedAsAMotionPictureScreenplayWork =
        Prefixed_Name(rdaw, "adaptedAsAMotionPictureScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10097</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as video screenplay (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10097">http://rdaregistry.info/Elements/w/P10097</seealso>
    let P10097 = Prefixed_Name(rdaw, "P10097") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10096</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as television screenplay (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10096">http://rdaregistry.info/Elements/w/P10096</seealso>
    let P10096 = Prefixed_Name(rdaw, "P10096") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsScreenplayWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsScreenplayWork.en">http://rdaregistry.info/Elements/w/adaptedAsScreenplayWork.en</seealso>
    let ``adaptedAsScreenplayWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsScreenplayWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10133</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay based on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10133">http://rdaregistry.info/Elements/w/P10133</seealso>
    let P10133 = Prefixed_Name(rdaw, "P10133") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsAScreenplayWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsAScreenplayWork">http://rdaregistry.info/Elements/w/adaptedAsAScreenplayWork</seealso>
    let adaptedAsAScreenplayWork =
        Prefixed_Name(rdaw, "adaptedAsAScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsTelevisionScreenplayWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsTelevisionScreenplayWork.en">http://rdaregistry.info/Elements/w/adaptedAsTelevisionScreenplayWork.en</seealso>
    let ``adaptedAsTelevisionScreenplayWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsTelevisionScreenplayWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10135</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television screenplay based on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10135">http://rdaregistry.info/Elements/w/P10135</seealso>
    let P10135 = Prefixed_Name(rdaw, "P10135") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsATelevisionScreenplayWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsATelevisionScreenplayWork">http://rdaregistry.info/Elements/w/adaptedAsATelevisionScreenplayWork</seealso>
    let adaptedAsATelevisionScreenplayWork =
        Prefixed_Name(rdaw, "adaptedAsATelevisionScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsVideoScreenplayWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsVideoScreenplayWork.en">http://rdaregistry.info/Elements/w/adaptedAsVideoScreenplayWork.en</seealso>
    let ``adaptedAsVideoScreenplayWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsVideoScreenplayWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10111</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is concordance (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10111">http://rdaregistry.info/Elements/w/P10111</seealso>
    let P10111 = Prefixed_Name(rdaw, "P10111") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10110</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is catalogue (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10110">http://rdaregistry.info/Elements/w/P10110</seealso>
    let P10110 = Prefixed_Name(rdaw, "P10110") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10157</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is finding aid (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10157">http://rdaregistry.info/Elements/w/P10157</seealso>
    let P10157 = Prefixed_Name(rdaw, "P10157") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10123</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appendix (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10123">http://rdaregistry.info/Elements/w/P10123</seealso>
    let P10123 = Prefixed_Name(rdaw, "P10123") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10112</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is addenda (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10112">http://rdaregistry.info/Elements/w/P10112</seealso>
    let P10112 = Prefixed_Name(rdaw, "P10112") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:augmentedByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/augmentedByWork.en">http://rdaregistry.info/Elements/w/augmentedByWork.en</seealso>
    let ``augmentedByWork.en`` =
        Prefixed_Name(rdaw, "augmentedByWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:augmentedByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/augmentedByWork">http://rdaregistry.info/Elements/w/augmentedByWork</seealso>
    let augmentedByWork = Prefixed_Name(rdaw, "augmentedByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10109</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is summarized as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10109">http://rdaregistry.info/Elements/w/P10109</seealso>
    let P10109 = Prefixed_Name(rdaw, "P10109") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:summarizedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/summarizedAsWork.en">http://rdaregistry.info/Elements/w/summarizedAsWork.en</seealso>
    let ``summarizedAsWork.en`` =
        Prefixed_Name(rdaw, "summarizedAsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10179</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is summary of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10179">http://rdaregistry.info/Elements/w/P10179</seealso>
    let P10179 = Prefixed_Name(rdaw, "P10179") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:summaryWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/summaryWork">http://rdaregistry.info/Elements/w/summaryWork</seealso>
    let summaryWork = Prefixed_Name(rdaw, "summaryWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:catalogueWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/catalogueWork.en">http://rdaregistry.info/Elements/w/catalogueWork.en</seealso>
    let ``catalogueWork.en`` = Prefixed_Name(rdaw, "catalogueWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10180</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is catalogue of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10180">http://rdaregistry.info/Elements/w/P10180</seealso>
    let P10180 = Prefixed_Name(rdaw, "P10180") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:catalogueWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/catalogueWork">http://rdaregistry.info/Elements/w/catalogueWork</seealso>
    let catalogueWork = Prefixed_Name(rdaw, "catalogueWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:concordanceWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/concordanceWork.en">http://rdaregistry.info/Elements/w/concordanceWork.en</seealso>
    let ``concordanceWork.en`` =
        Prefixed_Name(rdaw, "concordanceWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10181</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is concordance to (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10181">http://rdaregistry.info/Elements/w/P10181</seealso>
    let P10181 = Prefixed_Name(rdaw, "P10181") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:concordanceWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/concordanceWork">http://rdaregistry.info/Elements/w/concordanceWork</seealso>
    let concordanceWork = Prefixed_Name(rdaw, "concordanceWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:addendaWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/addendaWork.en">http://rdaregistry.info/Elements/w/addendaWork.en</seealso>
    let ``addendaWork.en`` = Prefixed_Name(rdaw, "addendaWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10177</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is addenda to (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10177">http://rdaregistry.info/Elements/w/P10177</seealso>
    let P10177 = Prefixed_Name(rdaw, "P10177") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:addendaWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/addendaWork">http://rdaregistry.info/Elements/w/addendaWork</seealso>
    let addendaWork = Prefixed_Name(rdaw, "addendaWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10113</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as libretto (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10113">http://rdaregistry.info/Elements/w/P10113</seealso>
    let P10113 = Prefixed_Name(rdaw, "P10113") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsLibrettoWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsLibrettoWork.en">http://rdaregistry.info/Elements/w/adaptedAsLibrettoWork.en</seealso>
    let ``adaptedAsLibrettoWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsLibrettoWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10189</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is libretto based on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10189">http://rdaregistry.info/Elements/w/P10189</seealso>
    let P10189 = Prefixed_Name(rdaw, "P10189") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:basisForLibrettoWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/basisForLibrettoWork">http://rdaregistry.info/Elements/w/basisForLibrettoWork</seealso>
    let basisForLibrettoWork =
        Prefixed_Name(rdaw, "basisForLibrettoWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10114</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is reviewed in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10114">http://rdaregistry.info/Elements/w/P10114</seealso>
    let P10114 = Prefixed_Name(rdaw, "P10114") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:reviewedInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/reviewedInWork.en">http://rdaregistry.info/Elements/w/reviewedInWork.en</seealso>
    let ``reviewedInWork.en`` = Prefixed_Name(rdaw, "reviewedInWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:radioAdaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioAdaptationOfWork.en">http://rdaregistry.info/Elements/w/radioAdaptationOfWork.en</seealso>
    let ``radioAdaptationOfWork.en`` =
        Prefixed_Name(rdaw, "radioAdaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:radioAdaptationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioAdaptationOfWork">http://rdaregistry.info/Elements/w/radioAdaptationOfWork</seealso>
    let radioAdaptationOfWork =
        Prefixed_Name(rdaw, "radioAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionAdaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionAdaptationOfWork.en">http://rdaregistry.info/Elements/w/televisionAdaptationOfWork.en</seealso>
    let ``televisionAdaptationOfWork.en`` =
        Prefixed_Name(rdaw, "televisionAdaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionAdaptationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionAdaptationOfWork">http://rdaregistry.info/Elements/w/televisionAdaptationOfWork</seealso>
    let televisionAdaptationOfWork =
        Prefixed_Name(rdaw, "televisionAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayBasedOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayBasedOnWork.en">http://rdaregistry.info/Elements/w/screenplayBasedOnWork.en</seealso>
    let ``screenplayBasedOnWork.en`` =
        Prefixed_Name(rdaw, "screenplayBasedOnWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayBasedOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayBasedOnWork">http://rdaregistry.info/Elements/w/screenplayBasedOnWork</seealso>
    let screenplayBasedOnWork =
        Prefixed_Name(rdaw, "screenplayBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:motionPictureScreenplayBasedOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/motionPictureScreenplayBasedOnWork.en">http://rdaregistry.info/Elements/w/motionPictureScreenplayBasedOnWork.en</seealso>
    let ``motionPictureScreenplayBasedOnWork.en`` =
        Prefixed_Name(rdaw, "motionPictureScreenplayBasedOnWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:motionPictureScreenplayBasedOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/motionPictureScreenplayBasedOnWork">http://rdaregistry.info/Elements/w/motionPictureScreenplayBasedOnWork</seealso>
    let motionPictureScreenplayBasedOnWork =
        Prefixed_Name(rdaw, "motionPictureScreenplayBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionScreenplayBasedOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionScreenplayBasedOnWork.en">http://rdaregistry.info/Elements/w/televisionScreenplayBasedOnWork.en</seealso>
    let ``televisionScreenplayBasedOnWork.en`` =
        Prefixed_Name(rdaw, "televisionScreenplayBasedOnWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionScreenplayBasedOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionScreenplayBasedOnWork">http://rdaregistry.info/Elements/w/televisionScreenplayBasedOnWork</seealso>
    let televisionScreenplayBasedOnWork =
        Prefixed_Name(rdaw, "televisionScreenplayBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:videoScreenplayBasedOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoScreenplayBasedOnWork.en">http://rdaregistry.info/Elements/w/videoScreenplayBasedOnWork.en</seealso>
    let ``videoScreenplayBasedOnWork.en`` =
        Prefixed_Name(rdaw, "videoScreenplayBasedOnWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:videoScreenplayBasedOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoScreenplayBasedOnWork">http://rdaregistry.info/Elements/w/videoScreenplayBasedOnWork</seealso>
    let videoScreenplayBasedOnWork =
        Prefixed_Name(rdaw, "videoScreenplayBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:radioScriptBasedOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioScriptBasedOnWork.en">http://rdaregistry.info/Elements/w/radioScriptBasedOnWork.en</seealso>
    let ``radioScriptBasedOnWork.en`` =
        Prefixed_Name(rdaw, "radioScriptBasedOnWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:radioScriptBasedOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioScriptBasedOnWork">http://rdaregistry.info/Elements/w/radioScriptBasedOnWork</seealso>
    let radioScriptBasedOnWork =
        Prefixed_Name(rdaw, "radioScriptBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:videoAdaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoAdaptationOfWork.en">http://rdaregistry.info/Elements/w/videoAdaptationOfWork.en</seealso>
    let ``videoAdaptationOfWork.en`` =
        Prefixed_Name(rdaw, "videoAdaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:videoAdaptationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoAdaptationOfWork">http://rdaregistry.info/Elements/w/videoAdaptationOfWork</seealso>
    let videoAdaptationOfWork =
        Prefixed_Name(rdaw, "videoAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10229</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has derivative work relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10229">http://rdaregistry.info/Elements/w/P10229</seealso>
    let P10229 = Prefixed_Name(rdaw, "P10229") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:derivativeWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/derivativeWork">http://rdaregistry.info/Elements/w/derivativeWork</seealso>
    let derivativeWork = Prefixed_Name(rdaw, "derivativeWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:errataToWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/errataToWork.en">http://rdaregistry.info/Elements/w/errataToWork.en</seealso>
    let ``errataToWork.en`` = Prefixed_Name(rdaw, "errataToWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:errataToWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/errataToWork">http://rdaregistry.info/Elements/w/errataToWork</seealso>
    let errataToWork = Prefixed_Name(rdaw, "errataToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:guideToWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/guideToWork.en">http://rdaregistry.info/Elements/w/guideToWork.en</seealso>
    let ``guideToWork.en`` = Prefixed_Name(rdaw, "guideToWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:guideToWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/guideToWork">http://rdaregistry.info/Elements/w/guideToWork</seealso>
    let guideToWork = Prefixed_Name(rdaw, "guideToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appendixToWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appendixToWork.en">http://rdaregistry.info/Elements/w/appendixToWork.en</seealso>
    let ``appendixToWork.en`` = Prefixed_Name(rdaw, "appendixToWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appendixToWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appendixToWork">http://rdaregistry.info/Elements/w/appendixToWork</seealso>
    let appendixToWork = Prefixed_Name(rdaw, "appendixToWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:illustrationsForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/illustrationsForWork.en">http://rdaregistry.info/Elements/w/illustrationsForWork.en</seealso>
    let ``illustrationsForWork.en`` =
        Prefixed_Name(rdaw, "illustrationsForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:illustrationsForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/illustrationsForWork">http://rdaregistry.info/Elements/w/illustrationsForWork</seealso>
    let illustrationsForWork =
        Prefixed_Name(rdaw, "illustrationsForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:evaluationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/evaluationOfWork.en">http://rdaregistry.info/Elements/w/evaluationOfWork.en</seealso>
    let ``evaluationOfWork.en`` =
        Prefixed_Name(rdaw, "evaluationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:evaluationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/evaluationOfWork">http://rdaregistry.info/Elements/w/evaluationOfWork</seealso>
    let evaluationOfWork = Prefixed_Name(rdaw, "evaluationOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10154</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is supplement to (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10154">http://rdaregistry.info/Elements/w/P10154</seealso>
    let P10154 = Prefixed_Name(rdaw, "P10154") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:supplementToWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/supplementToWork.en">http://rdaregistry.info/Elements/w/supplementToWork.en</seealso>
    let ``supplementToWork.en`` =
        Prefixed_Name(rdaw, "supplementToWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:supplementToWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/supplementToWork">http://rdaregistry.info/Elements/w/supplementToWork</seealso>
    let supplementToWork = Prefixed_Name(rdaw, "supplementToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10251</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as graphic novel (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10251">http://rdaregistry.info/Elements/w/P10251</seealso>
    let P10251 = Prefixed_Name(rdaw, "P10251") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10249</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as video game (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10249">http://rdaregistry.info/Elements/w/P10249</seealso>
    let P10249 = Prefixed_Name(rdaw, "P10249") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10289</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as oratorio (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10289">http://rdaregistry.info/Elements/w/P10289</seealso>
    let P10289 = Prefixed_Name(rdaw, "P10289") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10235</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as musical theatre (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10235">http://rdaregistry.info/Elements/w/P10235</seealso>
    let P10235 = Prefixed_Name(rdaw, "P10235") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10236</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as opera (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10236">http://rdaregistry.info/Elements/w/P10236</seealso>
    let P10236 = Prefixed_Name(rdaw, "P10236") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:adaptedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsWork.en">http://rdaregistry.info/Elements/w/adaptedAsWork.en</seealso>
    let ``adaptedAsWork.en`` = Prefixed_Name(rdaw, "adaptedAsWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:adaptedAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsWork">http://rdaregistry.info/Elements/w/adaptedAsWork</seealso>
    let adaptedAsWork = Prefixed_Name(rdaw, "adaptedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10188</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is index to (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10188">http://rdaregistry.info/Elements/w/P10188</seealso>
    let P10188 = Prefixed_Name(rdaw, "P10188") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:indexWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/indexWork">http://rdaregistry.info/Elements/w/indexWork</seealso>
    let indexWork = Prefixed_Name(rdaw, "indexWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10163</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television screenplay (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10163">http://rdaregistry.info/Elements/w/P10163</seealso>
    let P10163 = Prefixed_Name(rdaw, "P10163") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10164</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video screenplay (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10164">http://rdaregistry.info/Elements/w/P10164</seealso>
    let P10164 = Prefixed_Name(rdaw, "P10164") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10160</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is motion picture screenplay (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10160">http://rdaregistry.info/Elements/w/P10160</seealso>
    let P10160 = Prefixed_Name(rdaw, "P10160") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:screenplayWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayWork.en">http://rdaregistry.info/Elements/w/screenplayWork.en</seealso>
    let ``screenplayWork.en`` = Prefixed_Name(rdaw, "screenplayWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:screenplayWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayWork">http://rdaregistry.info/Elements/w/screenplayWork</seealso>
    let screenplayWork = Prefixed_Name(rdaw, "screenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:motionPictureScreenplayWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/motionPictureScreenplayWork.en">http://rdaregistry.info/Elements/w/motionPictureScreenplayWork.en</seealso>
    let ``motionPictureScreenplayWork.en`` =
        Prefixed_Name(rdaw, "motionPictureScreenplayWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:motionPictureScreenplayWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/motionPictureScreenplayWork">http://rdaregistry.info/Elements/w/motionPictureScreenplayWork</seealso>
    let motionPictureScreenplayWork =
        Prefixed_Name(rdaw, "motionPictureScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicalSettingOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicalSettingOfWork.en">http://rdaregistry.info/Elements/w/musicalSettingOfWork.en</seealso>
    let ``musicalSettingOfWork.en`` =
        Prefixed_Name(rdaw, "musicalSettingOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicalSettingOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicalSettingOfWork">http://rdaregistry.info/Elements/w/musicalSettingOfWork</seealso>
    let musicalSettingOfWork =
        Prefixed_Name(rdaw, "musicalSettingOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:radioScriptWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioScriptWork.en">http://rdaregistry.info/Elements/w/radioScriptWork.en</seealso>
    let ``radioScriptWork.en`` =
        Prefixed_Name(rdaw, "radioScriptWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:radioScriptWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioScriptWork">http://rdaregistry.info/Elements/w/radioScriptWork</seealso>
    let radioScriptWork = Prefixed_Name(rdaw, "radioScriptWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionScreenplayWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionScreenplayWork.en">http://rdaregistry.info/Elements/w/televisionScreenplayWork.en</seealso>
    let ``televisionScreenplayWork.en`` =
        Prefixed_Name(rdaw, "televisionScreenplayWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionScreenplayWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionScreenplayWork">http://rdaregistry.info/Elements/w/televisionScreenplayWork</seealso>
    let televisionScreenplayWork =
        Prefixed_Name(rdaw, "televisionScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:videoScreenplayWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoScreenplayWork.en">http://rdaregistry.info/Elements/w/videoScreenplayWork.en</seealso>
    let ``videoScreenplayWork.en`` =
        Prefixed_Name(rdaw, "videoScreenplayWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:videoScreenplayWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoScreenplayWork">http://rdaregistry.info/Elements/w/videoScreenplayWork</seealso>
    let videoScreenplayWork = Prefixed_Name(rdaw, "videoScreenplayWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:librettoWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/librettoWork.en">http://rdaregistry.info/Elements/w/librettoWork.en</seealso>
    let ``librettoWork.en`` = Prefixed_Name(rdaw, "librettoWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:commentaryOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commentaryOnWork">http://rdaregistry.info/Elements/w/commentaryOnWork</seealso>
    let commentaryOnWork = Prefixed_Name(rdaw, "commentaryOnWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:indexToWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/indexToWork.en">http://rdaregistry.info/Elements/w/indexToWork.en</seealso>
    let ``indexToWork.en`` = Prefixed_Name(rdaw, "indexToWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:indexToWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/indexToWork">http://rdaregistry.info/Elements/w/indexToWork</seealso>
    let indexToWork = Prefixed_Name(rdaw, "indexToWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:librettoBasedOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/librettoBasedOnWork.en">http://rdaregistry.info/Elements/w/librettoBasedOnWork.en</seealso>
    let ``librettoBasedOnWork.en`` =
        Prefixed_Name(rdaw, "librettoBasedOnWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:librettoBasedOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/librettoBasedOnWork">http://rdaregistry.info/Elements/w/librettoBasedOnWork</seealso>
    let librettoBasedOnWork = Prefixed_Name(rdaw, "librettoBasedOnWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10290</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is inspired by</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10290">http://rdaregistry.info/Elements/w/P10290</seealso>
    let P10290 = Prefixed_Name(rdaw, "P10290") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:basedOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/basedOnWork.en">http://rdaregistry.info/Elements/w/basedOnWork.en</seealso>
    let ``basedOnWork.en`` = Prefixed_Name(rdaw, "basedOnWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:basedOnWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/basedOnWork">http://rdaregistry.info/Elements/w/basedOnWork</seealso>
    let basedOnWork = Prefixed_Name(rdaw, "basedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:continuedByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/continuedByWork.en">http://rdaregistry.info/Elements/w/continuedByWork.en</seealso>
    let ``continuedByWork.en`` =
        Prefixed_Name(rdaw, "continuedByWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:continuedByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/continuedByWork">http://rdaregistry.info/Elements/w/continuedByWork</seealso>
    let continuedByWork = Prefixed_Name(rdaw, "continuedByWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:augmentationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/augmentationOfWork.en">http://rdaregistry.info/Elements/w/augmentationOfWork.en</seealso>
    let ``augmentationOfWork.en`` =
        Prefixed_Name(rdaw, "augmentationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:augmentationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/augmentationOfWork">http://rdaregistry.info/Elements/w/augmentationOfWork</seealso>
    let augmentationOfWork = Prefixed_Name(rdaw, "augmentationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:abstractsForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abstractsForWork.en">http://rdaregistry.info/Elements/w/abstractsForWork.en</seealso>
    let ``abstractsForWork.en`` =
        Prefixed_Name(rdaw, "abstractsForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:abstractsForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abstractsForWork">http://rdaregistry.info/Elements/w/abstractsForWork</seealso>
    let abstractsForWork = Prefixed_Name(rdaw, "abstractsForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:indexingForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/indexingForWork.en">http://rdaregistry.info/Elements/w/indexingForWork.en</seealso>
    let ``indexingForWork.en`` =
        Prefixed_Name(rdaw, "indexingForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:indexingForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/indexingForWork">http://rdaregistry.info/Elements/w/indexingForWork</seealso>
    let indexingForWork = Prefixed_Name(rdaw, "indexingForWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:prequelTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/prequelTo.en">http://rdaregistry.info/Elements/w/prequelTo.en</seealso>
    let ``prequelTo.en`` = Prefixed_Name(rdaw, "prequelTo.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10199</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has epoch</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10199">http://rdaregistry.info/Elements/w/P10199</seealso>
    let P10199 = Prefixed_Name(rdaw, "P10199") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:epoch.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/epoch.en">http://rdaregistry.info/Elements/w/epoch.en</seealso>
    let ``epoch.en`` = Prefixed_Name(rdaw, "epoch.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:epoch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/epoch">http://rdaregistry.info/Elements/w/epoch</seealso>
    let epoch = Prefixed_Name(rdaw, "epoch") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:landscapeArchitect.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/landscapeArchitect.en">http://rdaregistry.info/Elements/w/landscapeArchitect.en</seealso>
    let ``landscapeArchitect.en`` =
        Prefixed_Name(rdaw, "landscapeArchitect.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:landscapeArchitect</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/landscapeArchitect">http://rdaregistry.info/Elements/w/landscapeArchitect</seealso>
    let landscapeArchitect = Prefixed_Name(rdaw, "landscapeArchitect") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:findingAidForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/findingAidForWork.en">http://rdaregistry.info/Elements/w/findingAidForWork.en</seealso>
    let ``findingAidForWork.en`` =
        Prefixed_Name(rdaw, "findingAidForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:findingAidForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/findingAidForWork">http://rdaregistry.info/Elements/w/findingAidForWork</seealso>
    let findingAidForWork = Prefixed_Name(rdaw, "findingAidForWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:sculptor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sculptor.en">http://rdaregistry.info/Elements/w/sculptor.en</seealso>
    let ``sculptor.en`` = Prefixed_Name(rdaw, "sculptor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:sculptor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sculptor">http://rdaregistry.info/Elements/w/sculptor</seealso>
    let sculptor = Prefixed_Name(rdaw, "sculptor") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:screenwriter.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenwriter.en">http://rdaregistry.info/Elements/w/screenwriter.en</seealso>
    let ``screenwriter.en`` = Prefixed_Name(rdaw, "screenwriter.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:screenwriter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenwriter">http://rdaregistry.info/Elements/w/screenwriter</seealso>
    let screenwriter = Prefixed_Name(rdaw, "screenwriter") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:lyricist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/lyricist.en">http://rdaregistry.info/Elements/w/lyricist.en</seealso>
    let ``lyricist.en`` = Prefixed_Name(rdaw, "lyricist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:lyricist</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/lyricist">http://rdaregistry.info/Elements/w/lyricist</seealso>
    let lyricist = Prefixed_Name(rdaw, "lyricist") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:librettist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/librettist.en">http://rdaregistry.info/Elements/w/librettist.en</seealso>
    let ``librettist.en`` = Prefixed_Name(rdaw, "librettist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:librettist</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/librettist">http://rdaregistry.info/Elements/w/librettist</seealso>
    let librettist = Prefixed_Name(rdaw, "librettist") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:replacementInPartOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/replacementInPartOfWork.en">http://rdaregistry.info/Elements/w/replacementInPartOfWork.en</seealso>
    let ``replacementInPartOfWork.en`` =
        Prefixed_Name(rdaw, "replacementInPartOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10209</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has dissertation or thesis information</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10209">http://rdaregistry.info/Elements/w/P10209</seealso>
    let P10209 = Prefixed_Name(rdaw, "P10209") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:dissertationOrThesisInformation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dissertationOrThesisInformation.en">http://rdaregistry.info/Elements/w/dissertationOrThesisInformation.en</seealso>
    let ``dissertationOrThesisInformation.en`` =
        Prefixed_Name(rdaw, "dissertationOrThesisInformation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:dissertationOrThesisInformation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dissertationOrThesisInformation">http://rdaregistry.info/Elements/w/dissertationOrThesisInformation</seealso>
    let dissertationOrThesisInformation =
        Prefixed_Name(rdaw, "dissertationOrThesisInformation") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10210</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has history of the work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10210">http://rdaregistry.info/Elements/w/P10210</seealso>
    let P10210 = Prefixed_Name(rdaw, "P10210") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:historyOfTheWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/historyOfTheWork.en">http://rdaregistry.info/Elements/w/historyOfTheWork.en</seealso>
    let ``historyOfTheWork.en`` =
        Prefixed_Name(rdaw, "historyOfTheWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:historyOfTheWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/historyOfTheWork">http://rdaregistry.info/Elements/w/historyOfTheWork</seealso>
    let historyOfTheWork = Prefixed_Name(rdaw, "historyOfTheWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:splitIntoWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/splitIntoWork.en">http://rdaregistry.info/Elements/w/splitIntoWork.en</seealso>
    let ``splitIntoWork.en`` = Prefixed_Name(rdaw, "splitIntoWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:splitIntoWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/splitIntoWork">http://rdaregistry.info/Elements/w/splitIntoWork</seealso>
    let splitIntoWork = Prefixed_Name(rdaw, "splitIntoWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:mergedToFormWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/mergedToFormWork.en">http://rdaregistry.info/Elements/w/mergedToFormWork.en</seealso>
    let ``mergedToFormWork.en`` =
        Prefixed_Name(rdaw, "mergedToFormWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:mergedToFormWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/mergedToFormWork">http://rdaregistry.info/Elements/w/mergedToFormWork</seealso>
    let mergedToFormWork = Prefixed_Name(rdaw, "mergedToFormWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:mergerOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/mergerOfWork.en">http://rdaregistry.info/Elements/w/mergerOfWork.en</seealso>
    let ``mergerOfWork.en`` = Prefixed_Name(rdaw, "mergerOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:mergerOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/mergerOfWork">http://rdaregistry.info/Elements/w/mergerOfWork</seealso>
    let mergerOfWork = Prefixed_Name(rdaw, "mergerOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10214</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has equinox</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10214">http://rdaregistry.info/Elements/w/P10214</seealso>
    let P10214 = Prefixed_Name(rdaw, "P10214") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:equinox.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/equinox.en">http://rdaregistry.info/Elements/w/equinox.en</seealso>
    let ``equinox.en`` = Prefixed_Name(rdaw, "equinox.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:equinox</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/equinox">http://rdaregistry.info/Elements/w/equinox</seealso>
    let equinox = Prefixed_Name(rdaw, "equinox") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10215</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has year degree granted</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10215">http://rdaregistry.info/Elements/w/P10215</seealso>
    let P10215 = Prefixed_Name(rdaw, "P10215") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:yearDegreeGranted.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/yearDegreeGranted.en">http://rdaregistry.info/Elements/w/yearDegreeGranted.en</seealso>
    let ``yearDegreeGranted.en`` =
        Prefixed_Name(rdaw, "yearDegreeGranted.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:yearDegreeGranted</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/yearDegreeGranted">http://rdaregistry.info/Elements/w/yearDegreeGranted</seealso>
    let yearDegreeGranted = Prefixed_Name(rdaw, "yearDegreeGranted") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10216</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has coverage of the content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10216">http://rdaregistry.info/Elements/w/P10216</seealso>
    let P10216 = Prefixed_Name(rdaw, "P10216") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:dateOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dateOfWork">http://rdaregistry.info/Elements/w/dateOfWork</seealso>
    let dateOfWork = Prefixed_Name(rdaw, "dateOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10220</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has medium of performance</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10220">http://rdaregistry.info/Elements/w/P10220</seealso>
    let P10220 = Prefixed_Name(rdaw, "P10220") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:mediumOfPerformance.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/mediumOfPerformance.en">http://rdaregistry.info/Elements/w/mediumOfPerformance.en</seealso>
    let ``mediumOfPerformance.en`` =
        Prefixed_Name(rdaw, "mediumOfPerformance.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:mediumOfPerformance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/mediumOfPerformance">http://rdaregistry.info/Elements/w/mediumOfPerformance</seealso>
    let mediumOfPerformance = Prefixed_Name(rdaw, "mediumOfPerformance") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10221</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has key</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10221">http://rdaregistry.info/Elements/w/P10221</seealso>
    let P10221 = Prefixed_Name(rdaw, "P10221") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:key.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/key.en">http://rdaregistry.info/Elements/w/key.en</seealso>
    let ``key.en`` = Prefixed_Name(rdaw, "key.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:key</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/key">http://rdaregistry.info/Elements/w/key</seealso>
    let key = Prefixed_Name(rdaw, "key") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10222</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has nature of the content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10222">http://rdaregistry.info/Elements/w/P10222</seealso>
    let P10222 = Prefixed_Name(rdaw, "P10222") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:natureOfTheContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/natureOfTheContent.en">http://rdaregistry.info/Elements/w/natureOfTheContent.en</seealso>
    let ``natureOfTheContent.en`` =
        Prefixed_Name(rdaw, "natureOfTheContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:natureOfTheContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/natureOfTheContent">http://rdaregistry.info/Elements/w/natureOfTheContent</seealso>
    let natureOfTheContent = Prefixed_Name(rdaw, "natureOfTheContent") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:preferredTitleForTheWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/preferredTitleForTheWork.en">http://rdaregistry.info/Elements/w/preferredTitleForTheWork.en</seealso>
    let ``preferredTitleForTheWork.en`` =
        Prefixed_Name(rdaw, "preferredTitleForTheWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:preferredTitleForTheWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/preferredTitleForTheWork">http://rdaregistry.info/Elements/w/preferredTitleForTheWork</seealso>
    let preferredTitleForTheWork =
        Prefixed_Name(rdaw, "preferredTitleForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:absorptionOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/absorptionOfWork.en">http://rdaregistry.info/Elements/w/absorptionOfWork.en</seealso>
    let ``absorptionOfWork.en`` =
        Prefixed_Name(rdaw, "absorptionOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:absorbedWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/absorbedWork">http://rdaregistry.info/Elements/w/absorbedWork</seealso>
    let absorbedWork = Prefixed_Name(rdaw, "absorbedWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:absorptionInPartOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/absorptionInPartOfWork.en">http://rdaregistry.info/Elements/w/absorptionInPartOfWork.en</seealso>
    let ``absorptionInPartOfWork.en`` =
        Prefixed_Name(rdaw, "absorptionInPartOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:absorbedInPartWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/absorbedInPartWork">http://rdaregistry.info/Elements/w/absorbedInPartWork</seealso>
    let absorbedInPartWork = Prefixed_Name(rdaw, "absorbedInPartWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:continuationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/continuationOfWork.en">http://rdaregistry.info/Elements/w/continuationOfWork.en</seealso>
    let ``continuationOfWork.en`` =
        Prefixed_Name(rdaw, "continuationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:sequentialWorkRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sequentialWorkRelationship.en">http://rdaregistry.info/Elements/w/sequentialWorkRelationship.en</seealso>
    let ``sequentialWorkRelationship.en`` =
        Prefixed_Name(rdaw, "sequentialWorkRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:sequentialWorkRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sequentialWorkRelationship">http://rdaregistry.info/Elements/w/sequentialWorkRelationship</seealso>
    let sequentialWorkRelationship =
        Prefixed_Name(rdaw, "sequentialWorkRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:wholePartWorkRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/wholePartWorkRelationship.en">http://rdaregistry.info/Elements/w/wholePartWorkRelationship.en</seealso>
    let ``wholePartWorkRelationship.en`` =
        Prefixed_Name(rdaw, "wholePartWorkRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:wholePartWorkRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/wholePartWorkRelationship">http://rdaregistry.info/Elements/w/wholePartWorkRelationship</seealso>
    let wholePartWorkRelationship =
        Prefixed_Name(rdaw, "wholePartWorkRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicalTheatreAdaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicalTheatreAdaptationOfWork.en">http://rdaregistry.info/Elements/w/musicalTheatreAdaptationOfWork.en</seealso>
    let ``musicalTheatreAdaptationOfWork.en`` =
        Prefixed_Name(rdaw, "musicalTheatreAdaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicalTheatreAdaptationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicalTheatreAdaptationOfWork">http://rdaregistry.info/Elements/w/musicalTheatreAdaptationOfWork</seealso>
    let musicalTheatreAdaptationOfWork =
        Prefixed_Name(rdaw, "musicalTheatreAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:operaAdaptationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/operaAdaptationOf.en">http://rdaregistry.info/Elements/w/operaAdaptationOf.en</seealso>
    let ``operaAdaptationOf.en`` =
        Prefixed_Name(rdaw, "operaAdaptationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:operaAdaptationOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/operaAdaptationOf">http://rdaregistry.info/Elements/w/operaAdaptationOf</seealso>
    let operaAdaptationOf = Prefixed_Name(rdaw, "operaAdaptationOf") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsMusicalTheatreWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsMusicalTheatreWork.en">http://rdaregistry.info/Elements/w/adaptedAsMusicalTheatreWork.en</seealso>
    let ``adaptedAsMusicalTheatreWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsMusicalTheatreWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsMusicalTheatreWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsMusicalTheatreWork">http://rdaregistry.info/Elements/w/adaptedAsMusicalTheatreWork</seealso>
    let adaptedAsMusicalTheatreWork =
        Prefixed_Name(rdaw, "adaptedAsMusicalTheatreWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsOperaWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsOperaWork.en">http://rdaregistry.info/Elements/w/adaptedAsOperaWork.en</seealso>
    let ``adaptedAsOperaWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsOperaWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsOperaWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsOperaWork">http://rdaregistry.info/Elements/w/adaptedAsOperaWork</seealso>
    let adaptedAsOperaWork = Prefixed_Name(rdaw, "adaptedAsOperaWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10237</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10237">http://rdaregistry.info/Elements/w/P10237</seealso>
    let P10237 = Prefixed_Name(rdaw, "P10237") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:musicWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicWork.en">http://rdaregistry.info/Elements/w/musicWork.en</seealso>
    let ``musicWork.en`` = Prefixed_Name(rdaw, "musicWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10238</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10238">http://rdaregistry.info/Elements/w/P10238</seealso>
    let P10238 = Prefixed_Name(rdaw, "P10238") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:musicWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicWork">http://rdaregistry.info/Elements/w/musicWork</seealso>
    let musicWork = Prefixed_Name(rdaw, "musicWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:musicForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForWork.en">http://rdaregistry.info/Elements/w/musicForWork.en</seealso>
    let ``musicForWork.en`` = Prefixed_Name(rdaw, "musicForWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10283</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject relationship of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10283">http://rdaregistry.info/Elements/w/P10283</seealso>
    let P10283 = Prefixed_Name(rdaw, "P10283") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:subjectWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectWork.en">http://rdaregistry.info/Elements/w/subjectWork.en</seealso>
    let ``subjectWork.en`` = Prefixed_Name(rdaw, "subjectWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10277</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is description of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10277">http://rdaregistry.info/Elements/w/P10277</seealso>
    let P10277 = Prefixed_Name(rdaw, "P10277") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:subjectExpression.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectExpression.en">http://rdaregistry.info/Elements/w/subjectExpression.en</seealso>
    let ``subjectExpression.en`` =
        Prefixed_Name(rdaw, "subjectExpression.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10271</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is description of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10271">http://rdaregistry.info/Elements/w/P10271</seealso>
    let P10271 = Prefixed_Name(rdaw, "P10271") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:subjectManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectManifestation.en">http://rdaregistry.info/Elements/w/subjectManifestation.en</seealso>
    let ``subjectManifestation.en`` =
        Prefixed_Name(rdaw, "subjectManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10265</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is description of (item)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10265">http://rdaregistry.info/Elements/w/P10265</seealso>
    let P10265 = Prefixed_Name(rdaw, "P10265") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:subjectItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectItem.en">http://rdaregistry.info/Elements/w/subjectItem.en</seealso>
    let ``subjectItem.en`` = Prefixed_Name(rdaw, "subjectItem.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:subjectPerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectPerson.en">http://rdaregistry.info/Elements/w/subjectPerson.en</seealso>
    let ``subjectPerson.en`` = Prefixed_Name(rdaw, "subjectPerson.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:subjectFamily.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectFamily.en">http://rdaregistry.info/Elements/w/subjectFamily.en</seealso>
    let ``subjectFamily.en`` = Prefixed_Name(rdaw, "subjectFamily.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:subjectCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectCorporateBody.en">http://rdaregistry.info/Elements/w/subjectCorporateBody.en</seealso>
    let ``subjectCorporateBody.en`` =
        Prefixed_Name(rdaw, "subjectCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:subjectOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectOfWork.en">http://rdaregistry.info/Elements/w/subjectOfWork.en</seealso>
    let ``subjectOfWork.en`` = Prefixed_Name(rdaw, "subjectOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10268</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is review of (item)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10268">http://rdaregistry.info/Elements/w/P10268</seealso>
    let P10268 = Prefixed_Name(rdaw, "P10268") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:respondent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/respondent.en">http://rdaregistry.info/Elements/w/respondent.en</seealso>
    let ``respondent.en`` = Prefixed_Name(rdaw, "respondent.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10002</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has identifier for the work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10002">http://rdaregistry.info/Elements/w/P10002</seealso>
    let P10002 = Prefixed_Name(rdaw, "P10002") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:otherDistinguishingCharacteristicOfTheWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/otherDistinguishingCharacteristicOfTheWork.en">http://rdaregistry.info/Elements/w/otherDistinguishingCharacteristicOfTheWork.en</seealso>
    let ``otherDistinguishingCharacteristicOfTheWork.en`` =
        Prefixed_Name(rdaw, "otherDistinguishingCharacteristicOfTheWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:formOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/formOfWork">http://rdaregistry.info/Elements/w/formOfWork</seealso>
    let formOfWork = Prefixed_Name(rdaw, "formOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10047</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other person, family, or corporate body associated with a work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10047">http://rdaregistry.info/Elements/w/P10047</seealso>
    let P10047 = Prefixed_Name(rdaw, "P10047") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:degreeGrantingInstitution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/degreeGrantingInstitution">http://rdaregistry.info/Elements/w/degreeGrantingInstitution</seealso>
    let degreeGrantingInstitution =
        Prefixed_Name(rdaw, "degreeGrantingInstitution") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:productionCompany</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/productionCompany">http://rdaregistry.info/Elements/w/productionCompany</seealso>
    let productionCompany = Prefixed_Name(rdaw, "productionCompany") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10010</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has plaintiff corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10010">http://rdaregistry.info/Elements/w/P10010</seealso>
    let P10010 = Prefixed_Name(rdaw, "P10010") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:plaintiffCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/plaintiffCorporateBody.en">http://rdaregistry.info/Elements/w/plaintiffCorporateBody.en</seealso>
    let ``plaintiffCorporateBody.en`` =
        Prefixed_Name(rdaw, "plaintiffCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10014</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has radio director</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10014">http://rdaregistry.info/Elements/w/P10014</seealso>
    let P10014 = Prefixed_Name(rdaw, "P10014") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:radioDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioDirector.en">http://rdaregistry.info/Elements/w/radioDirector.en</seealso>
    let ``radioDirector.en`` = Prefixed_Name(rdaw, "radioDirector.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10082</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has right ascension and declination</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10082">http://rdaregistry.info/Elements/w/P10082</seealso>
    let P10082 = Prefixed_Name(rdaw, "P10082") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10081</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has longitude and latitude</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10081">http://rdaregistry.info/Elements/w/P10081</seealso>
    let P10081 = Prefixed_Name(rdaw, "P10081") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10083</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has strings of coordinate pairs</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10083">http://rdaregistry.info/Elements/w/P10083</seealso>
    let P10083 = Prefixed_Name(rdaw, "P10083") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10185</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is remake of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10185">http://rdaregistry.info/Elements/w/P10185</seealso>
    let P10185 = Prefixed_Name(rdaw, "P10185") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:remadeAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/remadeAsWork">http://rdaregistry.info/Elements/w/remadeAsWork</seealso>
    let remadeAsWork = Prefixed_Name(rdaw, "remadeAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:defendant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/defendant">http://rdaregistry.info/Elements/w/defendant</seealso>
    let defendant = Prefixed_Name(rdaw, "defendant") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10041</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has degree supervisor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10041">http://rdaregistry.info/Elements/w/P10041</seealso>
    let P10041 = Prefixed_Name(rdaw, "P10041") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:plaintiffPerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/plaintiffPerson.en">http://rdaregistry.info/Elements/w/plaintiffPerson.en</seealso>
    let ``plaintiffPerson.en`` =
        Prefixed_Name(rdaw, "plaintiffPerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:plaintiffPerson</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/plaintiffPerson">http://rdaregistry.info/Elements/w/plaintiffPerson</seealso>
    let plaintiffPerson = Prefixed_Name(rdaw, "plaintiffPerson") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10044</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has judge</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10044">http://rdaregistry.info/Elements/w/P10044</seealso>
    let P10044 = Prefixed_Name(rdaw, "P10044") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:judge.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/judge.en">http://rdaregistry.info/Elements/w/judge.en</seealso>
    let ``judge.en`` = Prefixed_Name(rdaw, "judge.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:judge</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/judge">http://rdaregistry.info/Elements/w/judge</seealso>
    let judge = Prefixed_Name(rdaw, "judge") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10045</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has praeses</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10045">http://rdaregistry.info/Elements/w/P10045</seealso>
    let P10045 = Prefixed_Name(rdaw, "P10045") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:praeses.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/praeses.en">http://rdaregistry.info/Elements/w/praeses.en</seealso>
    let ``praeses.en`` = Prefixed_Name(rdaw, "praeses.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:issuingBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/issuingBody.en">http://rdaregistry.info/Elements/w/issuingBody.en</seealso>
    let ``issuingBody.en`` = Prefixed_Name(rdaw, "issuingBody.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:issuingBody</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/issuingBody">http://rdaregistry.info/Elements/w/issuingBody</seealso>
    let issuingBody = Prefixed_Name(rdaw, "issuingBody") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:photographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/photographer.en">http://rdaregistry.info/Elements/w/photographer.en</seealso>
    let ``photographer.en`` = Prefixed_Name(rdaw, "photographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:photographer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/photographer">http://rdaregistry.info/Elements/w/photographer</seealso>
    let photographer = Prefixed_Name(rdaw, "photographer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:interviewer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/interviewer">http://rdaregistry.info/Elements/w/interviewer</seealso>
    let interviewer = Prefixed_Name(rdaw, "interviewer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10058</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has artist</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10058">http://rdaregistry.info/Elements/w/P10058</seealso>
    let P10058 = Prefixed_Name(rdaw, "P10058") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10253</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has calligrapher</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10253">http://rdaregistry.info/Elements/w/P10253</seealso>
    let P10253 = Prefixed_Name(rdaw, "P10253") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10254</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has book artist</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10254">http://rdaregistry.info/Elements/w/P10254</seealso>
    let P10254 = Prefixed_Name(rdaw, "P10254") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:director</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/director">http://rdaregistry.info/Elements/w/director</seealso>
    let director = Prefixed_Name(rdaw, "director") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:sponsoringBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sponsoringBody.en">http://rdaregistry.info/Elements/w/sponsoringBody.en</seealso>
    let ``sponsoringBody.en`` = Prefixed_Name(rdaw, "sponsoringBody.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:sponsoringBody</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sponsoringBody">http://rdaregistry.info/Elements/w/sponsoringBody</seealso>
    let sponsoringBody = Prefixed_Name(rdaw, "sponsoringBody") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:directorOfPhotography.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/directorOfPhotography.en">http://rdaregistry.info/Elements/w/directorOfPhotography.en</seealso>
    let ``directorOfPhotography.en`` =
        Prefixed_Name(rdaw, "directorOfPhotography.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:dedicatee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dedicatee.en">http://rdaregistry.info/Elements/w/dedicatee.en</seealso>
    let ``dedicatee.en`` = Prefixed_Name(rdaw, "dedicatee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:dedicatee</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dedicatee">http://rdaregistry.info/Elements/w/dedicatee</seealso>
    let dedicatee = Prefixed_Name(rdaw, "dedicatee") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:addressee</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/addressee">http://rdaregistry.info/Elements/w/addressee</seealso>
    let addressee = Prefixed_Name(rdaw, "addressee") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:consultant.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/consultant.en">http://rdaregistry.info/Elements/w/consultant.en</seealso>
    let ``consultant.en`` = Prefixed_Name(rdaw, "consultant.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:consultant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/consultant">http://rdaregistry.info/Elements/w/consultant</seealso>
    let consultant = Prefixed_Name(rdaw, "consultant") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10072</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has manifestation of work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10072">http://rdaregistry.info/Elements/w/P10072</seealso>
    let P10072 = Prefixed_Name(rdaw, "P10072") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:manifestationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/manifestationOfWork.en">http://rdaregistry.info/Elements/w/manifestationOfWork.en</seealso>
    let ``manifestationOfWork.en`` =
        Prefixed_Name(rdaw, "manifestationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:filmProducer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/filmProducer">http://rdaregistry.info/Elements/w/filmProducer</seealso>
    let filmProducer = Prefixed_Name(rdaw, "filmProducer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:radioProducer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioProducer.en">http://rdaregistry.info/Elements/w/radioProducer.en</seealso>
    let ``radioProducer.en`` = Prefixed_Name(rdaw, "radioProducer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:radioProducer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioProducer">http://rdaregistry.info/Elements/w/radioProducer</seealso>
    let radioProducer = Prefixed_Name(rdaw, "radioProducer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10149</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is errata to (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10149">http://rdaregistry.info/Elements/w/P10149</seealso>
    let P10149 = Prefixed_Name(rdaw, "P10149") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:errataWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/errataWork">http://rdaregistry.info/Elements/w/errataWork</seealso>
    let errataWork = Prefixed_Name(rdaw, "errataWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10093</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is illustrations (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10093">http://rdaregistry.info/Elements/w/P10093</seealso>
    let P10093 = Prefixed_Name(rdaw, "P10093") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:illustrationsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/illustrationsWork.en">http://rdaregistry.info/Elements/w/illustrationsWork.en</seealso>
    let ``illustrationsWork.en`` =
        Prefixed_Name(rdaw, "illustrationsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10152</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is illustrations for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10152">http://rdaregistry.info/Elements/w/P10152</seealso>
    let P10152 = Prefixed_Name(rdaw, "P10152") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:illustrationsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/illustrationsWork">http://rdaregistry.info/Elements/w/illustrationsWork</seealso>
    let illustrationsWork = Prefixed_Name(rdaw, "illustrationsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10094</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as motion picture screenplay (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10094">http://rdaregistry.info/Elements/w/P10094</seealso>
    let P10094 = Prefixed_Name(rdaw, "P10094") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsMotionPictureScreenplayWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsMotionPictureScreenplayWork.en">http://rdaregistry.info/Elements/w/adaptedAsMotionPictureScreenplayWork.en</seealso>
    let ``adaptedAsMotionPictureScreenplayWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsMotionPictureScreenplayWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10247</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is choreography (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10247">http://rdaregistry.info/Elements/w/P10247</seealso>
    let P10247 = Prefixed_Name(rdaw, "P10247") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:complementedByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/complementedByWork.en">http://rdaregistry.info/Elements/w/complementedByWork.en</seealso>
    let ``complementedByWork.en`` =
        Prefixed_Name(rdaw, "complementedByWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10228</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has accompanying work relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10228">http://rdaregistry.info/Elements/w/P10228</seealso>
    let P10228 = Prefixed_Name(rdaw, "P10228") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:complementedByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/complementedByWork">http://rdaregistry.info/Elements/w/complementedByWork</seealso>
    let complementedByWork = Prefixed_Name(rdaw, "complementedByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10104</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is continued in part by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10104">http://rdaregistry.info/Elements/w/P10104</seealso>
    let P10104 = Prefixed_Name(rdaw, "P10104") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:continuedInPartByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/continuedInPartByWork.en">http://rdaregistry.info/Elements/w/continuedInPartByWork.en</seealso>
    let ``continuedInPartByWork.en`` =
        Prefixed_Name(rdaw, "continuedInPartByWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:evaluatedInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/evaluatedInWork.en">http://rdaregistry.info/Elements/w/evaluatedInWork.en</seealso>
    let ``evaluatedInWork.en`` =
        Prefixed_Name(rdaw, "evaluatedInWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:evaluatedInWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/evaluatedInWork">http://rdaregistry.info/Elements/w/evaluatedInWork</seealso>
    let evaluatedInWork = Prefixed_Name(rdaw, "evaluatedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:analysedInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/analysedInWork.en">http://rdaregistry.info/Elements/w/analysedInWork.en</seealso>
    let ``analysedInWork.en`` = Prefixed_Name(rdaw, "analysedInWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:zxd</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/zxd">http://rdaregistry.info/Elements/w/zxd</seealso>
    let zxd = Prefixed_Name(rdaw, "zxd") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:seriesContains</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/seriesContains">http://rdaregistry.info/Elements/w/seriesContains</seealso>
    let seriesContains = Prefixed_Name(rdaw, "seriesContains") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10288</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is oratorio adaptation of  (work)</para><para>is oratorio adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10288">http://rdaregistry.info/Elements/w/P10288</seealso>
    let P10288 = Prefixed_Name(rdaw, "P10288") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10233</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is musical theatre adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10233">http://rdaregistry.info/Elements/w/P10233</seealso>
    let P10233 = Prefixed_Name(rdaw, "P10233") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10234</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is opera adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10234">http://rdaregistry.info/Elements/w/P10234</seealso>
    let P10234 = Prefixed_Name(rdaw, "P10234") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10250</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video game adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10250">http://rdaregistry.info/Elements/w/P10250</seealso>
    let P10250 = Prefixed_Name(rdaw, "P10250") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10252</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is graphic novelization of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10252">http://rdaregistry.info/Elements/w/P10252</seealso>
    let P10252 = Prefixed_Name(rdaw, "P10252") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptationOfWork.en">http://rdaregistry.info/Elements/w/adaptationOfWork.en</seealso>
    let ``adaptationOfWork.en`` =
        Prefixed_Name(rdaw, "adaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptationOfWork">http://rdaregistry.info/Elements/w/adaptationOfWork</seealso>
    let adaptationOfWork = Prefixed_Name(rdaw, "adaptationOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:parodiedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/parodiedAsWork.en">http://rdaregistry.info/Elements/w/parodiedAsWork.en</seealso>
    let ``parodiedAsWork.en`` = Prefixed_Name(rdaw, "parodiedAsWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10197</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is parody of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10197">http://rdaregistry.info/Elements/w/P10197</seealso>
    let P10197 = Prefixed_Name(rdaw, "P10197") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:parodiedAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/parodiedAsWork">http://rdaregistry.info/Elements/w/parodiedAsWork</seealso>
    let parodiedAsWork = Prefixed_Name(rdaw, "parodiedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10145</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is absorbed by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10145">http://rdaregistry.info/Elements/w/P10145</seealso>
    let P10145 = Prefixed_Name(rdaw, "P10145") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:absorbedByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/absorbedByWork.en">http://rdaregistry.info/Elements/w/absorbedByWork.en</seealso>
    let ``absorbedByWork.en`` = Prefixed_Name(rdaw, "absorbedByWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:absorbedByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/absorbedByWork">http://rdaregistry.info/Elements/w/absorbedByWork</seealso>
    let absorbedByWork = Prefixed_Name(rdaw, "absorbedByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10146</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is absorbed in part by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10146">http://rdaregistry.info/Elements/w/P10146</seealso>
    let P10146 = Prefixed_Name(rdaw, "P10146") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:absorbedInPartByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/absorbedInPartByWork.en">http://rdaregistry.info/Elements/w/absorbedInPartByWork.en</seealso>
    let ``absorbedInPartByWork.en`` =
        Prefixed_Name(rdaw, "absorbedInPartByWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10225</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is absorption in part of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10225">http://rdaregistry.info/Elements/w/P10225</seealso>
    let P10225 = Prefixed_Name(rdaw, "P10225") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:absorbedInPartByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/absorbedInPartByWork">http://rdaregistry.info/Elements/w/absorbedInPartByWork</seealso>
    let absorbedInPartByWork =
        Prefixed_Name(rdaw, "absorbedInPartByWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:containerOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/containerOfWork.en">http://rdaregistry.info/Elements/w/containerOfWork.en</seealso>
    let ``containerOfWork.en`` =
        Prefixed_Name(rdaw, "containerOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10186</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is paraphrase of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10186">http://rdaregistry.info/Elements/w/P10186</seealso>
    let P10186 = Prefixed_Name(rdaw, "P10186") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:paraphrasedAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/paraphrasedAsWork">http://rdaregistry.info/Elements/w/paraphrasedAsWork</seealso>
    let paraphrasedAsWork = Prefixed_Name(rdaw, "paraphrasedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:abridgedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abridgedAsWork.en">http://rdaregistry.info/Elements/w/abridgedAsWork.en</seealso>
    let ``abridgedAsWork.en`` = Prefixed_Name(rdaw, "abridgedAsWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:abridgedAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abridgedAsWork">http://rdaregistry.info/Elements/w/abridgedAsWork</seealso>
    let abridgedAsWork = Prefixed_Name(rdaw, "abridgedAsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:continuationInPartOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/continuationInPartOfWork.en">http://rdaregistry.info/Elements/w/continuationInPartOfWork.en</seealso>
    let ``continuationInPartOfWork.en`` =
        Prefixed_Name(rdaw, "continuationInPartOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10211</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is split into (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10211">http://rdaregistry.info/Elements/w/P10211</seealso>
    let P10211 = Prefixed_Name(rdaw, "P10211") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:continuationInPartOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/continuationInPartOfWork">http://rdaregistry.info/Elements/w/continuationInPartOfWork</seealso>
    let continuationInPartOfWork =
        Prefixed_Name(rdaw, "continuationInPartOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:separatedFromWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/separatedFromWork.en">http://rdaregistry.info/Elements/w/separatedFromWork.en</seealso>
    let ``separatedFromWork.en`` =
        Prefixed_Name(rdaw, "separatedFromWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:separatedFromWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/separatedFromWork">http://rdaregistry.info/Elements/w/separatedFromWork</seealso>
    let separatedFromWork = Prefixed_Name(rdaw, "separatedFromWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:prequelTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/prequelTo">http://rdaregistry.info/Elements/w/prequelTo</seealso>
    let prequelTo = Prefixed_Name(rdaw, "prequelTo") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:imitationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/imitationOfWork.en">http://rdaregistry.info/Elements/w/imitationOfWork.en</seealso>
    let ``imitationOfWork.en`` =
        Prefixed_Name(rdaw, "imitationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:imitationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/imitationOfWork">http://rdaregistry.info/Elements/w/imitationOfWork</seealso>
    let imitationOfWork = Prefixed_Name(rdaw, "imitationOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:parodyOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/parodyOfWork.en">http://rdaregistry.info/Elements/w/parodyOfWork.en</seealso>
    let ``parodyOfWork.en`` = Prefixed_Name(rdaw, "parodyOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:parodyOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/parodyOfWork">http://rdaregistry.info/Elements/w/parodyOfWork</seealso>
    let parodyOfWork = Prefixed_Name(rdaw, "parodyOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10198</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has related work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10198">http://rdaregistry.info/Elements/w/P10198</seealso>
    let P10198 = Prefixed_Name(rdaw, "P10198") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10296</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has referential work relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10296">http://rdaregistry.info/Elements/w/P10296</seealso>
    let P10296 = Prefixed_Name(rdaw, "P10296") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:relatedWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/relatedWork.en">http://rdaregistry.info/Elements/w/relatedWork.en</seealso>
    let ``relatedWork.en`` = Prefixed_Name(rdaw, "relatedWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:relatedWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/relatedWork">http://rdaregistry.info/Elements/w/relatedWork</seealso>
    let relatedWork = Prefixed_Name(rdaw, "relatedWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:continuesWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/continuesWork">http://rdaregistry.info/Elements/w/continuesWork</seealso>
    let continuesWork = Prefixed_Name(rdaw, "continuesWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:sequelTo.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sequelTo.en">http://rdaregistry.info/Elements/w/sequelTo.en</seealso>
    let ``sequelTo.en`` = Prefixed_Name(rdaw, "sequelTo.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:sequelTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sequelTo">http://rdaregistry.info/Elements/w/sequelTo</seealso>
    let sequelTo = Prefixed_Name(rdaw, "sequelTo") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:accompanyingWorkRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/accompanyingWorkRelationship.en">http://rdaregistry.info/Elements/w/accompanyingWorkRelationship.en</seealso>
    let ``accompanyingWorkRelationship.en`` =
        Prefixed_Name(rdaw, "accompanyingWorkRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:accompanyingWorkRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/accompanyingWorkRelationship">http://rdaregistry.info/Elements/w/accompanyingWorkRelationship</seealso>
    let accompanyingWorkRelationship =
        Prefixed_Name(rdaw, "accompanyingWorkRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:derivativeWorkRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/derivativeWorkRelationship.en">http://rdaregistry.info/Elements/w/derivativeWorkRelationship.en</seealso>
    let ``derivativeWorkRelationship.en`` =
        Prefixed_Name(rdaw, "derivativeWorkRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:derivativeWorkRelationship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/derivativeWorkRelationship">http://rdaregistry.info/Elements/w/derivativeWorkRelationship</seealso>
    let derivativeWorkRelationship =
        Prefixed_Name(rdaw, "derivativeWorkRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10230</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10230">http://rdaregistry.info/Elements/w/P10230</seealso>
    let P10230 = Prefixed_Name(rdaw, "P10230") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:bookArtist.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/bookArtist.en">http://rdaregistry.info/Elements/w/bookArtist.en</seealso>
    let ``bookArtist.en`` = Prefixed_Name(rdaw, "bookArtist.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:rapporteur.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/rapporteur.en">http://rdaregistry.info/Elements/w/rapporteur.en</seealso>
    let ``rapporteur.en`` = Prefixed_Name(rdaw, "rapporteur.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10256</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject relationship</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10256">http://rdaregistry.info/Elements/w/P10256</seealso>
    let P10256 = Prefixed_Name(rdaw, "P10256") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10263</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject (corporate body)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10263">http://rdaregistry.info/Elements/w/P10263</seealso>
    let P10263 = Prefixed_Name(rdaw, "P10263") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10260</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject (item)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10260">http://rdaregistry.info/Elements/w/P10260</seealso>
    let P10260 = Prefixed_Name(rdaw, "P10260") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10259</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10259">http://rdaregistry.info/Elements/w/P10259</seealso>
    let P10259 = Prefixed_Name(rdaw, "P10259") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10262</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject (family)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10262">http://rdaregistry.info/Elements/w/P10262</seealso>
    let P10262 = Prefixed_Name(rdaw, "P10262") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10258</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10258">http://rdaregistry.info/Elements/w/P10258</seealso>
    let P10258 = Prefixed_Name(rdaw, "P10258") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10261</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject (person)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10261">http://rdaregistry.info/Elements/w/P10261</seealso>
    let P10261 = Prefixed_Name(rdaw, "P10261") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:subjectRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subjectRelationship.en">http://rdaregistry.info/Elements/w/subjectRelationship.en</seealso>
    let ``subjectRelationship.en`` =
        Prefixed_Name(rdaw, "subjectRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:SubjectRelationshipOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/SubjectRelationshipOf.en">http://rdaregistry.info/Elements/w/SubjectRelationshipOf.en</seealso>
    let ``SubjectRelationshipOf.en`` =
        Prefixed_Name(rdaw, "SubjectRelationshipOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:degreeCommitteeMember.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/degreeCommitteeMember.en">http://rdaregistry.info/Elements/w/degreeCommitteeMember.en</seealso>
    let ``degreeCommitteeMember.en`` =
        Prefixed_Name(rdaw, "degreeCommitteeMember.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:defendantCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/defendantCorporateBody.en">http://rdaregistry.info/Elements/w/defendantCorporateBody.en</seealso>
    let ``defendantCorporateBody.en`` =
        Prefixed_Name(rdaw, "defendantCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:defendantPerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/defendantPerson.en">http://rdaregistry.info/Elements/w/defendantPerson.en</seealso>
    let ``defendantPerson.en`` =
        Prefixed_Name(rdaw, "defendantPerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:oratorioAdaptationWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/oratorioAdaptationWork.en">http://rdaregistry.info/Elements/w/oratorioAdaptationWork.en</seealso>
    let ``oratorioAdaptationWork.en`` =
        Prefixed_Name(rdaw, "oratorioAdaptationWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsOratorioWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsOratorioWork.en">http://rdaregistry.info/Elements/w/adaptedAsOratorioWork.en</seealso>
    let ``adaptedAsOratorioWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsOratorioWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:inspiredBy.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/inspiredBy.en">http://rdaregistry.info/Elements/w/inspiredBy.en</seealso>
    let ``inspiredBy.en`` = Prefixed_Name(rdaw, "inspiredBy.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:inspirationFor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/inspirationFor.en">http://rdaregistry.info/Elements/w/inspirationFor.en</seealso>
    let ``inspirationFor.en`` = Prefixed_Name(rdaw, "inspirationFor.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:researcher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/researcher.en">http://rdaregistry.info/Elements/w/researcher.en</seealso>
    let ``researcher.en`` = Prefixed_Name(rdaw, "researcher.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10294</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has commemoration</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10294">http://rdaregistry.info/Elements/w/P10294</seealso>
    let P10294 = Prefixed_Name(rdaw, "P10294") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:commemoration.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commemoration.en">http://rdaregistry.info/Elements/w/commemoration.en</seealso>
    let ``commemoration.en`` = Prefixed_Name(rdaw, "commemoration.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10295</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commemoration of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10295">http://rdaregistry.info/Elements/w/P10295</seealso>
    let P10295 = Prefixed_Name(rdaw, "P10295") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:commemorationOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commemorationOf.en">http://rdaregistry.info/Elements/w/commemorationOf.en</seealso>
    let ``commemorationOf.en`` =
        Prefixed_Name(rdaw, "commemorationOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:referentialWorkRelationship.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/referentialWorkRelationship.en">http://rdaregistry.info/Elements/w/referentialWorkRelationship.en</seealso>
    let ``referentialWorkRelationship.en`` =
        Prefixed_Name(rdaw, "referentialWorkRelationship.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10102</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is in series</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10102">http://rdaregistry.info/Elements/w/P10102</seealso>
    let P10102 = Prefixed_Name(rdaw, "P10102") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10170</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is succeeded by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10170">http://rdaregistry.info/Elements/w/P10170</seealso>
    let P10170 = Prefixed_Name(rdaw, "P10170") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10206</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is replacement in part of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10206">http://rdaregistry.info/Elements/w/P10206</seealso>
    let P10206 = Prefixed_Name(rdaw, "P10206") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10207</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is replacement of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10207">http://rdaregistry.info/Elements/w/P10207</seealso>
    let P10207 = Prefixed_Name(rdaw, "P10207") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:replacedByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/replacedByWork">http://rdaregistry.info/Elements/w/replacedByWork</seealso>
    let replacedByWork = Prefixed_Name(rdaw, "replacedByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10128</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is verse adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10128">http://rdaregistry.info/Elements/w/P10128</seealso>
    let P10128 = Prefixed_Name(rdaw, "P10128") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:verseAdaptationWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/verseAdaptationWork">http://rdaregistry.info/Elements/w/verseAdaptationWork</seealso>
    let verseAdaptationWork = Prefixed_Name(rdaw, "verseAdaptationWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10024</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has coordinates of cartographic content</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10024">http://rdaregistry.info/Elements/w/P10024</seealso>
    let P10024 = Prefixed_Name(rdaw, "P10024") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:coordinatesOfCartographicContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/coordinatesOfCartographicContent.en">http://rdaregistry.info/Elements/w/coordinatesOfCartographicContent.en</seealso>
    let ``coordinatesOfCartographicContent.en`` =
        Prefixed_Name(rdaw, "coordinatesOfCartographicContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10103</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is complemented by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10103">http://rdaregistry.info/Elements/w/P10103</seealso>
    let P10103 = Prefixed_Name(rdaw, "P10103") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10165</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is libretto (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10165">http://rdaregistry.info/Elements/w/P10165</seealso>
    let P10165 = Prefixed_Name(rdaw, "P10165") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:librettoForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/librettoForWork">http://rdaregistry.info/Elements/w/librettoForWork</seealso>
    let librettoForWork = Prefixed_Name(rdaw, "librettoForWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:praeses</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/praeses">http://rdaregistry.info/Elements/w/praeses</seealso>
    let praeses = Prefixed_Name(rdaw, "praeses") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10046</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has issuing body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10046">http://rdaregistry.info/Elements/w/P10046</seealso>
    let P10046 = Prefixed_Name(rdaw, "P10046") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10293</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has researcher</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10293">http://rdaregistry.info/Elements/w/P10293</seealso>
    let P10293 = Prefixed_Name(rdaw, "P10293") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10067</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sponsoring body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10067">http://rdaregistry.info/Elements/w/P10067</seealso>
    let P10067 = Prefixed_Name(rdaw, "P10067") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10069</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has dedicatee</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10069">http://rdaregistry.info/Elements/w/P10069</seealso>
    let P10069 = Prefixed_Name(rdaw, "P10069") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10057</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has interviewer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10057">http://rdaregistry.info/Elements/w/P10057</seealso>
    let P10057 = Prefixed_Name(rdaw, "P10057") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:interviewer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/interviewer.en">http://rdaregistry.info/Elements/w/interviewer.en</seealso>
    let ``interviewer.en`` = Prefixed_Name(rdaw, "interviewer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:manifestationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/manifestationOfWork">http://rdaregistry.info/Elements/w/manifestationOfWork</seealso>
    let manifestationOfWork = Prefixed_Name(rdaw, "manifestationOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:filmProducer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/filmProducer.en">http://rdaregistry.info/Elements/w/filmProducer.en</seealso>
    let ``filmProducer.en`` = Prefixed_Name(rdaw, "filmProducer.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:abstractedInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abstractedInWork.en">http://rdaregistry.info/Elements/w/abstractedInWork.en</seealso>
    let ``abstractedInWork.en`` =
        Prefixed_Name(rdaw, "abstractedInWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10143</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is free translation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10143">http://rdaregistry.info/Elements/w/P10143</seealso>
    let P10143 = Prefixed_Name(rdaw, "P10143") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:freelyTranslatedAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/freelyTranslatedAsWork">http://rdaregistry.info/Elements/w/freelyTranslatedAsWork</seealso>
    let freelyTranslatedAsWork =
        Prefixed_Name(rdaw, "freelyTranslatedAsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10153</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is evaluation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10153">http://rdaregistry.info/Elements/w/P10153</seealso>
    let P10153 = Prefixed_Name(rdaw, "P10153") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10187</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentary on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10187">http://rdaregistry.info/Elements/w/P10187</seealso>
    let P10187 = Prefixed_Name(rdaw, "P10187") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10178</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is review of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10178">http://rdaregistry.info/Elements/w/P10178</seealso>
    let P10178 = Prefixed_Name(rdaw, "P10178") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10182</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is critique of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10182">http://rdaregistry.info/Elements/w/P10182</seealso>
    let P10182 = Prefixed_Name(rdaw, "P10182") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:commentaryInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commentaryInWork.en">http://rdaregistry.info/Elements/w/commentaryInWork.en</seealso>
    let ``commentaryInWork.en`` =
        Prefixed_Name(rdaw, "commentaryInWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:commentaryInWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commentaryInWork">http://rdaregistry.info/Elements/w/commentaryInWork</seealso>
    let commentaryInWork = Prefixed_Name(rdaw, "commentaryInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10117</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is imitated as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10117">http://rdaregistry.info/Elements/w/P10117</seealso>
    let P10117 = Prefixed_Name(rdaw, "P10117") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10196</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is imitation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10196">http://rdaregistry.info/Elements/w/P10196</seealso>
    let P10196 = Prefixed_Name(rdaw, "P10196") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:imitatedAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/imitatedAsWork">http://rdaregistry.info/Elements/w/imitatedAsWork</seealso>
    let imitatedAsWork = Prefixed_Name(rdaw, "imitatedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10121</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is analysed in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10121">http://rdaregistry.info/Elements/w/P10121</seealso>
    let P10121 = Prefixed_Name(rdaw, "P10121") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10120</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is evaluated in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10120">http://rdaregistry.info/Elements/w/P10120</seealso>
    let P10120 = Prefixed_Name(rdaw, "P10120") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:describedInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/describedInWork.en">http://rdaregistry.info/Elements/w/describedInWork.en</seealso>
    let ``describedInWork.en`` =
        Prefixed_Name(rdaw, "describedInWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:expandedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/expandedAsWork.en">http://rdaregistry.info/Elements/w/expandedAsWork.en</seealso>
    let ``expandedAsWork.en`` = Prefixed_Name(rdaw, "expandedAsWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10184</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is expanded version of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10184">http://rdaregistry.info/Elements/w/P10184</seealso>
    let P10184 = Prefixed_Name(rdaw, "P10184") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:expandedAsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/expandedAsWork">http://rdaregistry.info/Elements/w/expandedAsWork</seealso>
    let expandedAsWork = Prefixed_Name(rdaw, "expandedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10171</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is digested as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10171">http://rdaregistry.info/Elements/w/P10171</seealso>
    let P10171 = Prefixed_Name(rdaw, "P10171") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:digestOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/digestOfWork">http://rdaregistry.info/Elements/w/digestOfWork</seealso>
    let digestOfWork = Prefixed_Name(rdaw, "digestOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10166</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is paraphrased as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10166">http://rdaregistry.info/Elements/w/P10166</seealso>
    let P10166 = Prefixed_Name(rdaw, "P10166") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10291</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is inspiration for</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10291">http://rdaregistry.info/Elements/w/P10291</seealso>
    let P10291 = Prefixed_Name(rdaw, "P10291") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:derivativeWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/derivativeWork.en">http://rdaregistry.info/Elements/w/derivativeWork.en</seealso>
    let ``derivativeWork.en`` = Prefixed_Name(rdaw, "derivativeWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10191</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is continued by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10191">http://rdaregistry.info/Elements/w/P10191</seealso>
    let P10191 = Prefixed_Name(rdaw, "P10191") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10212</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is merged to form (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10212">http://rdaregistry.info/Elements/w/P10212</seealso>
    let P10212 = Prefixed_Name(rdaw, "P10212") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:succeededByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/succeededByWork.en">http://rdaregistry.info/Elements/w/succeededByWork.en</seealso>
    let ``succeededByWork.en`` =
        Prefixed_Name(rdaw, "succeededByWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:digestWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/digestWork">http://rdaregistry.info/Elements/w/digestWork</seealso>
    let digestWork = Prefixed_Name(rdaw, "digestWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:supplementWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/supplementWork.en">http://rdaregistry.info/Elements/w/supplementWork.en</seealso>
    let ``supplementWork.en`` = Prefixed_Name(rdaw, "supplementWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayForTheMotionPictureWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayForTheMotionPictureWork">http://rdaregistry.info/Elements/w/screenplayForTheMotionPictureWork</seealso>
    let screenplayForTheMotionPictureWork =
        Prefixed_Name(rdaw, "screenplayForTheMotionPictureWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayForTheTelevisionProgramWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayForTheTelevisionProgramWork.en">http://rdaregistry.info/Elements/w/screenplayForTheTelevisionProgramWork.en</seealso>
    let ``screenplayForTheTelevisionProgramWork.en`` =
        Prefixed_Name(rdaw, "screenplayForTheTelevisionProgramWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayForTheVideoWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayForTheVideoWork">http://rdaregistry.info/Elements/w/screenplayForTheVideoWork</seealso>
    let screenplayForTheVideoWork =
        Prefixed_Name(rdaw, "screenplayForTheVideoWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:scriptForTheRadioProgramWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/scriptForTheRadioProgramWork.en">http://rdaregistry.info/Elements/w/scriptForTheRadioProgramWork.en</seealso>
    let ``scriptForTheRadioProgramWork.en`` =
        Prefixed_Name(rdaw, "scriptForTheRadioProgramWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:scriptForTheRadioProgramWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/scriptForTheRadioProgramWork">http://rdaregistry.info/Elements/w/scriptForTheRadioProgramWork</seealso>
    let scriptForTheRadioProgramWork =
        Prefixed_Name(rdaw, "scriptForTheRadioProgramWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:addendaToWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/addendaToWork.en">http://rdaregistry.info/Elements/w/addendaToWork.en</seealso>
    let ``addendaToWork.en`` = Prefixed_Name(rdaw, "addendaToWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:supersedesInPartWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/supersedesInPartWork">http://rdaregistry.info/Elements/w/supersedesInPartWork</seealso>
    let supersedesInPartWork =
        Prefixed_Name(rdaw, "supersedesInPartWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:replacementOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/replacementOfWork.en">http://rdaregistry.info/Elements/w/replacementOfWork.en</seealso>
    let ``replacementOfWork.en`` =
        Prefixed_Name(rdaw, "replacementOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:supersedesWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/supersedesWork">http://rdaregistry.info/Elements/w/supersedesWork</seealso>
    let supersedesWork = Prefixed_Name(rdaw, "supersedesWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10208</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has granting institution or faculty</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10208">http://rdaregistry.info/Elements/w/P10208</seealso>
    let P10208 = Prefixed_Name(rdaw, "P10208") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:grantingInstitutionOrFaculty.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/grantingInstitutionOrFaculty.en">http://rdaregistry.info/Elements/w/grantingInstitutionOrFaculty.en</seealso>
    let ``grantingInstitutionOrFaculty.en`` =
        Prefixed_Name(rdaw, "grantingInstitutionOrFaculty.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForWork">http://rdaregistry.info/Elements/w/musicForWork</seealso>
    let musicForWork = Prefixed_Name(rdaw, "musicForWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10239</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video music (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10239">http://rdaregistry.info/Elements/w/P10239</seealso>
    let P10239 = Prefixed_Name(rdaw, "P10239") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:videoMusicWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoMusicWork.en">http://rdaregistry.info/Elements/w/videoMusicWork.en</seealso>
    let ``videoMusicWork.en`` = Prefixed_Name(rdaw, "videoMusicWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10240</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for video (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10240">http://rdaregistry.info/Elements/w/P10240</seealso>
    let P10240 = Prefixed_Name(rdaw, "P10240") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:videoMusicWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoMusicWork">http://rdaregistry.info/Elements/w/videoMusicWork</seealso>
    let videoMusicWork = Prefixed_Name(rdaw, "videoMusicWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicForVideoWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForVideoWork.en">http://rdaregistry.info/Elements/w/musicForVideoWork.en</seealso>
    let ``musicForVideoWork.en`` =
        Prefixed_Name(rdaw, "musicForVideoWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10241</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is television program music (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10241">http://rdaregistry.info/Elements/w/P10241</seealso>
    let P10241 = Prefixed_Name(rdaw, "P10241") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionProgramMusicWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionProgramMusicWork.en">http://rdaregistry.info/Elements/w/televisionProgramMusicWork.en</seealso>
    let ``televisionProgramMusicWork.en`` =
        Prefixed_Name(rdaw, "televisionProgramMusicWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10242</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for television program (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10242">http://rdaregistry.info/Elements/w/P10242</seealso>
    let P10242 = Prefixed_Name(rdaw, "P10242") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:televisionProgramMusicWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/televisionProgramMusicWork">http://rdaregistry.info/Elements/w/televisionProgramMusicWork</seealso>
    let televisionProgramMusicWork =
        Prefixed_Name(rdaw, "televisionProgramMusicWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicForTelevisionProgramWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForTelevisionProgramWork.en">http://rdaregistry.info/Elements/w/musicForTelevisionProgramWork.en</seealso>
    let ``musicForTelevisionProgramWork.en`` =
        Prefixed_Name(rdaw, "musicForTelevisionProgramWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10244</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for radio program (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10244">http://rdaregistry.info/Elements/w/P10244</seealso>
    let P10244 = Prefixed_Name(rdaw, "P10244") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:radioProgramMusicWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioProgramMusicWork">http://rdaregistry.info/Elements/w/radioProgramMusicWork</seealso>
    let radioProgramMusicWork =
        Prefixed_Name(rdaw, "radioProgramMusicWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicForRadioProgramWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForRadioProgramWork.en">http://rdaregistry.info/Elements/w/musicForRadioProgramWork.en</seealso>
    let ``musicForRadioProgramWork.en`` =
        Prefixed_Name(rdaw, "musicForRadioProgramWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicForRadioProgramWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForRadioProgramWork">http://rdaregistry.info/Elements/w/musicForRadioProgramWork</seealso>
    let musicForRadioProgramWork =
        Prefixed_Name(rdaw, "musicForRadioProgramWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10245</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is music for motion picture (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10245">http://rdaregistry.info/Elements/w/P10245</seealso>
    let P10245 = Prefixed_Name(rdaw, "P10245") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicForMotionPictureWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForMotionPictureWork.en">http://rdaregistry.info/Elements/w/musicForMotionPictureWork.en</seealso>
    let ``musicForMotionPictureWork.en`` =
        Prefixed_Name(rdaw, "musicForMotionPictureWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:motionPictureMusicWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/motionPictureMusicWork">http://rdaregistry.info/Elements/w/motionPictureMusicWork</seealso>
    let motionPictureMusicWork =
        Prefixed_Name(rdaw, "motionPictureMusicWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:choreographyWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/choreographyWork.en">http://rdaregistry.info/Elements/w/choreographyWork.en</seealso>
    let ``choreographyWork.en`` =
        Prefixed_Name(rdaw, "choreographyWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:choreographyForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/choreographyForWork.en">http://rdaregistry.info/Elements/w/choreographyForWork.en</seealso>
    let ``choreographyForWork.en`` =
        Prefixed_Name(rdaw, "choreographyForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:analysisOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/analysisOfManifestation.en">http://rdaregistry.info/Elements/w/analysisOfManifestation.en</seealso>
    let ``analysisOfManifestation.en`` =
        Prefixed_Name(rdaw, "analysisOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:evaluationOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/evaluationOfManifestation.en">http://rdaregistry.info/Elements/w/evaluationOfManifestation.en</seealso>
    let ``evaluationOfManifestation.en`` =
        Prefixed_Name(rdaw, "evaluationOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:defendant.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/defendant.en">http://rdaregistry.info/Elements/w/defendant.en</seealso>
    let ``defendant.en`` = Prefixed_Name(rdaw, "defendant.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:otherPFCWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/otherPFCWork">http://rdaregistry.info/Elements/w/otherPFCWork</seealso>
    let otherPFCWork = Prefixed_Name(rdaw, "otherPFCWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:dedicator.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dedicator.en">http://rdaregistry.info/Elements/w/dedicator.en</seealso>
    let ``dedicator.en`` = Prefixed_Name(rdaw, "dedicator.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:dedicator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dedicator">http://rdaregistry.info/Elements/w/dedicator</seealso>
    let dedicator = Prefixed_Name(rdaw, "dedicator") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10202</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sculptor</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10202">http://rdaregistry.info/Elements/w/P10202</seealso>
    let P10202 = Prefixed_Name(rdaw, "P10202") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:directorOfPhotography</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/directorOfPhotography">http://rdaregistry.info/Elements/w/directorOfPhotography</seealso>
    let directorOfPhotography =
        Prefixed_Name(rdaw, "directorOfPhotography") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:addressee.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/addressee.en">http://rdaregistry.info/Elements/w/addressee.en</seealso>
    let ``addressee.en`` = Prefixed_Name(rdaw, "addressee.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10136</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video screenplay based on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10136">http://rdaregistry.info/Elements/w/P10136</seealso>
    let P10136 = Prefixed_Name(rdaw, "P10136") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsAVideoScreenplayWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsAVideoScreenplayWork">http://rdaregistry.info/Elements/w/adaptedAsAVideoScreenplayWork</seealso>
    let adaptedAsAVideoScreenplayWork =
        Prefixed_Name(rdaw, "adaptedAsAVideoScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10169</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is separated from (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10169">http://rdaregistry.info/Elements/w/P10169</seealso>
    let P10169 = Prefixed_Name(rdaw, "P10169") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:continuedInPartByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/continuedInPartByWork">http://rdaregistry.info/Elements/w/continuedInPartByWork</seealso>
    let continuedInPartByWork =
        Prefixed_Name(rdaw, "continuedInPartByWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:imitatedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/imitatedAsWork.en">http://rdaregistry.info/Elements/w/imitatedAsWork.en</seealso>
    let ``imitatedAsWork.en`` = Prefixed_Name(rdaw, "imitatedAsWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10264</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10264">http://rdaregistry.info/Elements/w/P10264</seealso>
    let P10264 = Prefixed_Name(rdaw, "P10264") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:describedInWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/describedInWork">http://rdaregistry.info/Elements/w/describedInWork</seealso>
    let describedInWork = Prefixed_Name(rdaw, "describedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10119</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is expanded as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10119">http://rdaregistry.info/Elements/w/P10119</seealso>
    let P10119 = Prefixed_Name(rdaw, "P10119") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10139</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is digest of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10139">http://rdaregistry.info/Elements/w/P10139</seealso>
    let P10139 = Prefixed_Name(rdaw, "P10139") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:digestOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/digestOfWork.en">http://rdaregistry.info/Elements/w/digestOfWork.en</seealso>
    let ``digestOfWork.en`` = Prefixed_Name(rdaw, "digestOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:analysisOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/analysisOfWork.en">http://rdaregistry.info/Elements/w/analysisOfWork.en</seealso>
    let ``analysisOfWork.en`` = Prefixed_Name(rdaw, "analysisOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:analysisOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/analysisOfWork">http://rdaregistry.info/Elements/w/analysisOfWork</seealso>
    let analysisOfWork = Prefixed_Name(rdaw, "analysisOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:seriesContainerOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/seriesContainerOf.en">http://rdaregistry.info/Elements/w/seriesContainerOf.en</seealso>
    let ``seriesContainerOf.en`` =
        Prefixed_Name(rdaw, "seriesContainerOf.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10226</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is continuation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10226">http://rdaregistry.info/Elements/w/P10226</seealso>
    let P10226 = Prefixed_Name(rdaw, "P10226") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10168</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is continuation in part of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10168">http://rdaregistry.info/Elements/w/P10168</seealso>
    let P10168 = Prefixed_Name(rdaw, "P10168") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10213</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is merger of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10213">http://rdaregistry.info/Elements/w/P10213</seealso>
    let P10213 = Prefixed_Name(rdaw, "P10213") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:precededByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/precededByWork.en">http://rdaregistry.info/Elements/w/precededByWork.en</seealso>
    let ``precededByWork.en`` = Prefixed_Name(rdaw, "precededByWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:succeededByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/succeededByWork">http://rdaregistry.info/Elements/w/succeededByWork</seealso>
    let succeededByWork = Prefixed_Name(rdaw, "succeededByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:digestedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/digestedAsWork.en">http://rdaregistry.info/Elements/w/digestedAsWork.en</seealso>
    let ``digestedAsWork.en`` = Prefixed_Name(rdaw, "digestedAsWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:supplementWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/supplementWork">http://rdaregistry.info/Elements/w/supplementWork</seealso>
    let supplementWork = Prefixed_Name(rdaw, "supplementWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayForTheMotionPictureWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayForTheMotionPictureWork.en">http://rdaregistry.info/Elements/w/screenplayForTheMotionPictureWork.en</seealso>
    let ``screenplayForTheMotionPictureWork.en`` =
        Prefixed_Name(rdaw, "screenplayForTheMotionPictureWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayForTheTelevisionProgramWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayForTheTelevisionProgramWork">http://rdaregistry.info/Elements/w/screenplayForTheTelevisionProgramWork</seealso>
    let screenplayForTheTelevisionProgramWork =
        Prefixed_Name(rdaw, "screenplayForTheTelevisionProgramWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayForTheVideoWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayForTheVideoWork.en">http://rdaregistry.info/Elements/w/screenplayForTheVideoWork.en</seealso>
    let ``screenplayForTheVideoWork.en`` =
        Prefixed_Name(rdaw, "screenplayForTheVideoWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10266</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is analysis of (item)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10266">http://rdaregistry.info/Elements/w/P10266</seealso>
    let P10266 = Prefixed_Name(rdaw, "P10266") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10270</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentary on (item)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10270">http://rdaregistry.info/Elements/w/P10270</seealso>
    let P10270 = Prefixed_Name(rdaw, "P10270") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:descriptionOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/descriptionOfItem.en">http://rdaregistry.info/Elements/w/descriptionOfItem.en</seealso>
    let ``descriptionOfItem.en`` =
        Prefixed_Name(rdaw, "descriptionOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:evaluationOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/evaluationOfItem.en">http://rdaregistry.info/Elements/w/evaluationOfItem.en</seealso>
    let ``evaluationOfItem.en`` =
        Prefixed_Name(rdaw, "evaluationOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:participantInATreaty.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/participantInATreaty.en">http://rdaregistry.info/Elements/w/participantInATreaty.en</seealso>
    let ``participantInATreaty.en`` =
        Prefixed_Name(rdaw, "participantInATreaty.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:expressionOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/expressionOfWork">http://rdaregistry.info/Elements/w/expressionOfWork</seealso>
    let expressionOfWork = Prefixed_Name(rdaw, "expressionOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10140</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is analysis of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10140">http://rdaregistry.info/Elements/w/P10140</seealso>
    let P10140 = Prefixed_Name(rdaw, "P10140") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:reviewedInWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/reviewedInWork">http://rdaregistry.info/Elements/w/reviewedInWork</seealso>
    let reviewedInWork = Prefixed_Name(rdaw, "reviewedInWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:critiquedInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/critiquedInWork.en">http://rdaregistry.info/Elements/w/critiquedInWork.en</seealso>
    let ``critiquedInWork.en`` =
        Prefixed_Name(rdaw, "critiquedInWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:critiquedInWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/critiquedInWork">http://rdaregistry.info/Elements/w/critiquedInWork</seealso>
    let critiquedInWork = Prefixed_Name(rdaw, "critiquedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10167</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abridged as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10167">http://rdaregistry.info/Elements/w/P10167</seealso>
    let P10167 = Prefixed_Name(rdaw, "P10167") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:abridgementOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abridgementOfWork">http://rdaregistry.info/Elements/w/abridgementOfWork</seealso>
    let abridgementOfWork = Prefixed_Name(rdaw, "abridgementOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:abstractOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abstractOfWork">http://rdaregistry.info/Elements/w/abstractOfWork</seealso>
    let abstractOfWork = Prefixed_Name(rdaw, "abstractOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:freeTranslationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/freeTranslationOfWork.en">http://rdaregistry.info/Elements/w/freeTranslationOfWork.en</seealso>
    let ``freeTranslationOfWork.en`` =
        Prefixed_Name(rdaw, "freeTranslationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:freeTranslationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/freeTranslationOfWork">http://rdaregistry.info/Elements/w/freeTranslationOfWork</seealso>
    let freeTranslationOfWork =
        Prefixed_Name(rdaw, "freeTranslationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:precededByWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/precededByWork">http://rdaregistry.info/Elements/w/precededByWork</seealso>
    let precededByWork = Prefixed_Name(rdaw, "precededByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:findingAidWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/findingAidWork.en">http://rdaregistry.info/Elements/w/findingAidWork.en</seealso>
    let ``findingAidWork.en`` = Prefixed_Name(rdaw, "findingAidWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:findingAidWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/findingAidWork">http://rdaregistry.info/Elements/w/findingAidWork</seealso>
    let findingAidWork = Prefixed_Name(rdaw, "findingAidWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:indexWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/indexWork.en">http://rdaregistry.info/Elements/w/indexWork.en</seealso>
    let ``indexWork.en`` = Prefixed_Name(rdaw, "indexWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:critiqueOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/critiqueOfWork.en">http://rdaregistry.info/Elements/w/critiqueOfWork.en</seealso>
    let ``critiqueOfWork.en`` = Prefixed_Name(rdaw, "critiqueOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:musicForVideoWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForVideoWork">http://rdaregistry.info/Elements/w/musicForVideoWork</seealso>
    let musicForVideoWork = Prefixed_Name(rdaw, "musicForVideoWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicForTelevisionProgramWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForTelevisionProgramWork">http://rdaregistry.info/Elements/w/musicForTelevisionProgramWork</seealso>
    let musicForTelevisionProgramWork =
        Prefixed_Name(rdaw, "musicForTelevisionProgramWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10243</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio program music (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10243">http://rdaregistry.info/Elements/w/P10243</seealso>
    let P10243 = Prefixed_Name(rdaw, "P10243") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:radioProgramMusicWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioProgramMusicWork.en">http://rdaregistry.info/Elements/w/radioProgramMusicWork.en</seealso>
    let ``radioProgramMusicWork.en`` =
        Prefixed_Name(rdaw, "radioProgramMusicWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10246</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is motion picture music (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10246">http://rdaregistry.info/Elements/w/P10246</seealso>
    let P10246 = Prefixed_Name(rdaw, "P10246") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicForMotionPictureWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicForMotionPictureWork">http://rdaregistry.info/Elements/w/musicForMotionPictureWork</seealso>
    let musicForMotionPictureWork =
        Prefixed_Name(rdaw, "musicForMotionPictureWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:reviewOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/reviewOfItem.en">http://rdaregistry.info/Elements/w/reviewOfItem.en</seealso>
    let ``reviewOfItem.en`` = Prefixed_Name(rdaw, "reviewOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:commentaryOnItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commentaryOnItem.en">http://rdaregistry.info/Elements/w/commentaryOnItem.en</seealso>
    let ``commentaryOnItem.en`` =
        Prefixed_Name(rdaw, "commentaryOnItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10275</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is critique of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10275">http://rdaregistry.info/Elements/w/P10275</seealso>
    let P10275 = Prefixed_Name(rdaw, "P10275") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10276</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentary on (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10276">http://rdaregistry.info/Elements/w/P10276</seealso>
    let P10276 = Prefixed_Name(rdaw, "P10276") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10274</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is review of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10274">http://rdaregistry.info/Elements/w/P10274</seealso>
    let P10274 = Prefixed_Name(rdaw, "P10274") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10273</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is evaluation of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10273">http://rdaregistry.info/Elements/w/P10273</seealso>
    let P10273 = Prefixed_Name(rdaw, "P10273") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10272</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is analysis of (manifestation)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10272">http://rdaregistry.info/Elements/w/P10272</seealso>
    let P10272 = Prefixed_Name(rdaw, "P10272") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:descriptionOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/descriptionOfManifestation.en">http://rdaregistry.info/Elements/w/descriptionOfManifestation.en</seealso>
    let ``descriptionOfManifestation.en`` =
        Prefixed_Name(rdaw, "descriptionOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10079</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has numeric designation of a musical work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10079">http://rdaregistry.info/Elements/w/P10079</seealso>
    let P10079 = Prefixed_Name(rdaw, "P10079") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10115</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is critiqued in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10115">http://rdaregistry.info/Elements/w/P10115</seealso>
    let P10115 = Prefixed_Name(rdaw, "P10115") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10116</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentary in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10116">http://rdaregistry.info/Elements/w/P10116</seealso>
    let P10116 = Prefixed_Name(rdaw, "P10116") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:abstractOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abstractOfWork.en">http://rdaregistry.info/Elements/w/abstractOfWork.en</seealso>
    let ``abstractOfWork.en`` = Prefixed_Name(rdaw, "abstractOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10224</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is absorption of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10224">http://rdaregistry.info/Elements/w/P10224</seealso>
    let P10224 = Prefixed_Name(rdaw, "P10224") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:containerOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/containerOfWork">http://rdaregistry.info/Elements/w/containerOfWork</seealso>
    let containerOfWork = Prefixed_Name(rdaw, "containerOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:librettoWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/librettoWork">http://rdaregistry.info/Elements/w/librettoWork</seealso>
    let librettoWork = Prefixed_Name(rdaw, "librettoWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:paraphrasedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/paraphrasedAsWork.en">http://rdaregistry.info/Elements/w/paraphrasedAsWork.en</seealso>
    let ``paraphrasedAsWork.en`` =
        Prefixed_Name(rdaw, "paraphrasedAsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:commentaryOnWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commentaryOnWork.en">http://rdaregistry.info/Elements/w/commentaryOnWork.en</seealso>
    let ``commentaryOnWork.en`` =
        Prefixed_Name(rdaw, "commentaryOnWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:dateOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dateOfWork.en">http://rdaregistry.info/Elements/w/dateOfWork.en</seealso>
    let ``dateOfWork.en`` = Prefixed_Name(rdaw, "dateOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:motionPictureMusicWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/motionPictureMusicWork.en">http://rdaregistry.info/Elements/w/motionPictureMusicWork.en</seealso>
    let ``motionPictureMusicWork.en`` =
        Prefixed_Name(rdaw, "motionPictureMusicWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:critiqueOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/critiqueOfItem.en">http://rdaregistry.info/Elements/w/critiqueOfItem.en</seealso>
    let ``critiqueOfItem.en`` = Prefixed_Name(rdaw, "critiqueOfItem.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:organizer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/organizer.en">http://rdaregistry.info/Elements/w/organizer.en</seealso>
    let ``organizer.en`` = Prefixed_Name(rdaw, "organizer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10100</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is description of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10100">http://rdaregistry.info/Elements/w/P10100</seealso>
    let P10100 = Prefixed_Name(rdaw, "P10100") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10144</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is parodied as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10144">http://rdaregistry.info/Elements/w/P10144</seealso>
    let P10144 = Prefixed_Name(rdaw, "P10144") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10231</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has sequential work relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10231">http://rdaregistry.info/Elements/w/P10231</seealso>
    let P10231 = Prefixed_Name(rdaw, "P10231") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10201</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is finding aid for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10201">http://rdaregistry.info/Elements/w/P10201</seealso>
    let P10201 = Prefixed_Name(rdaw, "P10201") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:concordanceToWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/concordanceToWork">http://rdaregistry.info/Elements/w/concordanceToWork</seealso>
    let concordanceToWork = Prefixed_Name(rdaw, "concordanceToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:critiqueOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/critiqueOfWork">http://rdaregistry.info/Elements/w/critiqueOfWork</seealso>
    let critiqueOfWork = Prefixed_Name(rdaw, "critiqueOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:grantingInstitutionOrFaculty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/grantingInstitutionOrFaculty">http://rdaregistry.info/Elements/w/grantingInstitutionOrFaculty</seealso>
    let grantingInstitutionOrFaculty =
        Prefixed_Name(rdaw, "grantingInstitutionOrFaculty") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10269</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is critique of (item)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10269">http://rdaregistry.info/Elements/w/P10269</seealso>
    let P10269 = Prefixed_Name(rdaw, "P10269") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10267</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is evaluation of (item)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10267">http://rdaregistry.info/Elements/w/P10267</seealso>
    let P10267 = Prefixed_Name(rdaw, "P10267") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:analysisOfItem.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/analysisOfItem.en">http://rdaregistry.info/Elements/w/analysisOfItem.en</seealso>
    let ``analysisOfItem.en`` = Prefixed_Name(rdaw, "analysisOfItem.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:commissioningBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commissioningBody.en">http://rdaregistry.info/Elements/w/commissioningBody.en</seealso>
    let ``commissioningBody.en`` =
        Prefixed_Name(rdaw, "commissioningBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/">http://rdaregistry.info/Elements/w/</seealso>
    let _prefix_iri = Prefixed_Name(rdaw, "") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10065</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has creator</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10065">http://rdaregistry.info/Elements/w/P10065</seealso>
    let P10065 = Prefixed_Name(rdaw, "P10065") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:identifierForTheWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/identifierForTheWork.en">http://rdaregistry.info/Elements/w/identifierForTheWork.en</seealso>
    let ``identifierForTheWork.en`` =
        Prefixed_Name(rdaw, "identifierForTheWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10003</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has other distinguishing characteristic of the work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10003">http://rdaregistry.info/Elements/w/P10003</seealso>
    let P10003 = Prefixed_Name(rdaw, "P10003") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:formOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/formOfWork.en">http://rdaregistry.info/Elements/w/formOfWork.en</seealso>
    let ``formOfWork.en`` = Prefixed_Name(rdaw, "formOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10005</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has appellee corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10005">http://rdaregistry.info/Elements/w/P10005</seealso>
    let P10005 = Prefixed_Name(rdaw, "P10005") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10006</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has degree granting institution</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10006">http://rdaregistry.info/Elements/w/P10006</seealso>
    let P10006 = Prefixed_Name(rdaw, "P10006") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:degreeGrantingInstitution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/degreeGrantingInstitution.en">http://rdaregistry.info/Elements/w/degreeGrantingInstitution.en</seealso>
    let ``degreeGrantingInstitution.en`` =
        Prefixed_Name(rdaw, "degreeGrantingInstitution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10007</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has host institution</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10007">http://rdaregistry.info/Elements/w/P10007</seealso>
    let P10007 = Prefixed_Name(rdaw, "P10007") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:hostInstitution.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/hostInstitution.en">http://rdaregistry.info/Elements/w/hostInstitution.en</seealso>
    let ``hostInstitution.en`` =
        Prefixed_Name(rdaw, "hostInstitution.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:productionCompany.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/productionCompany.en">http://rdaregistry.info/Elements/w/productionCompany.en</seealso>
    let ``productionCompany.en`` =
        Prefixed_Name(rdaw, "productionCompany.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10009</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has appellant corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10009">http://rdaregistry.info/Elements/w/P10009</seealso>
    let P10009 = Prefixed_Name(rdaw, "P10009") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:appellantCorporateBody.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appellantCorporateBody.en">http://rdaregistry.info/Elements/w/appellantCorporateBody.en</seealso>
    let ``appellantCorporateBody.en`` =
        Prefixed_Name(rdaw, "appellantCorporateBody.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10039</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has plaintiff</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10039">http://rdaregistry.info/Elements/w/P10039</seealso>
    let P10039 = Prefixed_Name(rdaw, "P10039") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:courtGoverned</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/courtGoverned">http://rdaregistry.info/Elements/w/courtGoverned</seealso>
    let courtGoverned = Prefixed_Name(rdaw, "courtGoverned") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10012</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has numbering of part</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10012">http://rdaregistry.info/Elements/w/P10012</seealso>
    let P10012 = Prefixed_Name(rdaw, "P10012") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:numberingOfPart.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/numberingOfPart.en">http://rdaregistry.info/Elements/w/numberingOfPart.en</seealso>
    let ``numberingOfPart.en`` =
        Prefixed_Name(rdaw, "numberingOfPart.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10013</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has film director</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10013">http://rdaregistry.info/Elements/w/P10013</seealso>
    let P10013 = Prefixed_Name(rdaw, "P10013") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:filmDirector.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/filmDirector.en">http://rdaregistry.info/Elements/w/filmDirector.en</seealso>
    let ``filmDirector.en`` = Prefixed_Name(rdaw, "filmDirector.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:radioDirector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/radioDirector">http://rdaregistry.info/Elements/w/radioDirector</seealso>
    let radioDirector = Prefixed_Name(rdaw, "radioDirector") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10015</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has television director</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10015">http://rdaregistry.info/Elements/w/P10015</seealso>
    let P10015 = Prefixed_Name(rdaw, "P10015") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10016</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is dramatized as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10016">http://rdaregistry.info/Elements/w/P10016</seealso>
    let P10016 = Prefixed_Name(rdaw, "P10016") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:dramatizedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dramatizedAsWork.en">http://rdaregistry.info/Elements/w/dramatizedAsWork.en</seealso>
    let ``dramatizedAsWork.en`` =
        Prefixed_Name(rdaw, "dramatizedAsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10155</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10155">http://rdaregistry.info/Elements/w/P10155</seealso>
    let P10155 = Prefixed_Name(rdaw, "P10155") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:enactingJurisdiction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/enactingJurisdiction">http://rdaregistry.info/Elements/w/enactingJurisdiction</seealso>
    let enactingJurisdiction =
        Prefixed_Name(rdaw, "enactingJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10018</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has jurisdiction governed</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10018">http://rdaregistry.info/Elements/w/P10018</seealso>
    let P10018 = Prefixed_Name(rdaw, "P10018") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:jurisdictionGoverned.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/jurisdictionGoverned.en">http://rdaregistry.info/Elements/w/jurisdictionGoverned.en</seealso>
    let ``jurisdictionGoverned.en`` =
        Prefixed_Name(rdaw, "jurisdictionGoverned.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10101</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subseries of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10101">http://rdaregistry.info/Elements/w/P10101</seealso>
    let P10101 = Prefixed_Name(rdaw, "P10101") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:containedInWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/containedInWork.en">http://rdaregistry.info/Elements/w/containedInWork.en</seealso>
    let ``containedInWork.en`` =
        Prefixed_Name(rdaw, "containedInWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10232</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has whole-part work relationship with</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10232">http://rdaregistry.info/Elements/w/P10232</seealso>
    let P10232 = Prefixed_Name(rdaw, "P10232") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10227</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is sequel to</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10227">http://rdaregistry.info/Elements/w/P10227</seealso>
    let P10227 = Prefixed_Name(rdaw, "P10227") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:sequel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/sequel">http://rdaregistry.info/Elements/w/sequel</seealso>
    let sequel = Prefixed_Name(rdaw, "sequel") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10021</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is replaced in part by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10021">http://rdaregistry.info/Elements/w/P10021</seealso>
    let P10021 = Prefixed_Name(rdaw, "P10021") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:replacedInPartByWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/replacedInPartByWork.en">http://rdaregistry.info/Elements/w/replacedInPartByWork.en</seealso>
    let ``replacedInPartByWork.en`` =
        Prefixed_Name(rdaw, "replacedInPartByWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10023</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted in verse as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10023">http://rdaregistry.info/Elements/w/P10023</seealso>
    let P10023 = Prefixed_Name(rdaw, "P10023") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedInVerseAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedInVerseAsWork.en">http://rdaregistry.info/Elements/w/adaptedInVerseAsWork.en</seealso>
    let ``adaptedInVerseAsWork.en`` =
        Prefixed_Name(rdaw, "adaptedInVerseAsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10026</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is cadenza (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10026">http://rdaregistry.info/Elements/w/P10026</seealso>
    let P10026 = Prefixed_Name(rdaw, "P10026") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:cadenzaWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/cadenzaWork.en">http://rdaregistry.info/Elements/w/cadenzaWork.en</seealso>
    let ``cadenzaWork.en`` = Prefixed_Name(rdaw, "cadenzaWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:modifiedByVariationAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/modifiedByVariationAsWork.en">http://rdaregistry.info/Elements/w/modifiedByVariationAsWork.en</seealso>
    let ``modifiedByVariationAsWork.en`` =
        Prefixed_Name(rdaw, "modifiedByVariationAsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10148</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is derivative (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10148">http://rdaregistry.info/Elements/w/P10148</seealso>
    let P10148 = Prefixed_Name(rdaw, "P10148") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:musicalVariationsWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/musicalVariationsWork">http://rdaregistry.info/Elements/w/musicalVariationsWork</seealso>
    let musicalVariationsWork =
        Prefixed_Name(rdaw, "musicalVariationsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10130</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is novelization of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10130">http://rdaregistry.info/Elements/w/P10130</seealso>
    let P10130 = Prefixed_Name(rdaw, "P10130") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:novelizationWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/novelizationWork">http://rdaregistry.info/Elements/w/novelizationWork</seealso>
    let novelizationWork = Prefixed_Name(rdaw, "novelizationWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10035</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has appellee person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10035">http://rdaregistry.info/Elements/w/P10035</seealso>
    let P10035 = Prefixed_Name(rdaw, "P10035") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appelleePerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appelleePerson.en">http://rdaregistry.info/Elements/w/appelleePerson.en</seealso>
    let ``appelleePerson.en`` = Prefixed_Name(rdaw, "appelleePerson.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appelleePerson</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appelleePerson">http://rdaregistry.info/Elements/w/appelleePerson</seealso>
    let appelleePerson = Prefixed_Name(rdaw, "appelleePerson") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10036</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has medium</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10036">http://rdaregistry.info/Elements/w/P10036</seealso>
    let P10036 = Prefixed_Name(rdaw, "P10036") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:medium.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/medium.en">http://rdaregistry.info/Elements/w/medium.en</seealso>
    let ``medium.en`` = Prefixed_Name(rdaw, "medium.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appellant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appellant">http://rdaregistry.info/Elements/w/appellant</seealso>
    let appellant = Prefixed_Name(rdaw, "appellant") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10043</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has plaintiff person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10043">http://rdaregistry.info/Elements/w/P10043</seealso>
    let P10043 = Prefixed_Name(rdaw, "P10043") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:plaintiff.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/plaintiff.en">http://rdaregistry.info/Elements/w/plaintiff.en</seealso>
    let ``plaintiff.en`` = Prefixed_Name(rdaw, "plaintiff.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:plaintiff</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/plaintiff">http://rdaregistry.info/Elements/w/plaintiff</seealso>
    let plaintiff = Prefixed_Name(rdaw, "plaintiff") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10040</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has defendant</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10040">http://rdaregistry.info/Elements/w/P10040</seealso>
    let P10040 = Prefixed_Name(rdaw, "P10040") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10285</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has defendant corporate body</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10285">http://rdaregistry.info/Elements/w/P10285</seealso>
    let P10285 = Prefixed_Name(rdaw, "P10285") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10286</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has defendant person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10286">http://rdaregistry.info/Elements/w/P10286</seealso>
    let P10286 = Prefixed_Name(rdaw, "P10286") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:degreeSupervisor.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/degreeSupervisor.en">http://rdaregistry.info/Elements/w/degreeSupervisor.en</seealso>
    let ``degreeSupervisor.en`` =
        Prefixed_Name(rdaw, "degreeSupervisor.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:degreeSupervisor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/degreeSupervisor">http://rdaregistry.info/Elements/w/degreeSupervisor</seealso>
    let degreeSupervisor = Prefixed_Name(rdaw, "degreeSupervisor") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10042</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has appellant person</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10042">http://rdaregistry.info/Elements/w/P10042</seealso>
    let P10042 = Prefixed_Name(rdaw, "P10042") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:appellantPerson.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appellantPerson.en">http://rdaregistry.info/Elements/w/appellantPerson.en</seealso>
    let ``appellantPerson.en`` =
        Prefixed_Name(rdaw, "appellantPerson.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:appellantPerson</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appellantPerson">http://rdaregistry.info/Elements/w/appellantPerson</seealso>
    let appellantPerson = Prefixed_Name(rdaw, "appellantPerson") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:programmer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/programmer">http://rdaregistry.info/Elements/w/programmer</seealso>
    let programmer = Prefixed_Name(rdaw, "programmer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10051</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has designer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10051">http://rdaregistry.info/Elements/w/P10051</seealso>
    let P10051 = Prefixed_Name(rdaw, "P10051") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:designer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/designer.en">http://rdaregistry.info/Elements/w/designer.en</seealso>
    let ``designer.en`` = Prefixed_Name(rdaw, "designer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:designer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/designer">http://rdaregistry.info/Elements/w/designer</seealso>
    let designer = Prefixed_Name(rdaw, "designer") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10052</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has cartographer</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10052">http://rdaregistry.info/Elements/w/P10052</seealso>
    let P10052 = Prefixed_Name(rdaw, "P10052") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:cartographer.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/cartographer.en">http://rdaregistry.info/Elements/w/cartographer.en</seealso>
    let ``cartographer.en`` = Prefixed_Name(rdaw, "cartographer.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:author</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/author">http://rdaregistry.info/Elements/w/author</seealso>
    let author = Prefixed_Name(rdaw, "author") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10062</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has architect</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10062">http://rdaregistry.info/Elements/w/P10062</seealso>
    let P10062 = Prefixed_Name(rdaw, "P10062") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10200</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has landscape architect</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10200">http://rdaregistry.info/Elements/w/P10200</seealso>
    let P10200 = Prefixed_Name(rdaw, "P10200") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:architect.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/architect.en">http://rdaregistry.info/Elements/w/architect.en</seealso>
    let ``architect.en`` = Prefixed_Name(rdaw, "architect.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:architect</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/architect">http://rdaregistry.info/Elements/w/architect</seealso>
    let architect = Prefixed_Name(rdaw, "architect") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10063</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has filmmaker</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10063">http://rdaregistry.info/Elements/w/P10063</seealso>
    let P10063 = Prefixed_Name(rdaw, "P10063") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:filmmaker.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/filmmaker.en">http://rdaregistry.info/Elements/w/filmmaker.en</seealso>
    let ``filmmaker.en`` = Prefixed_Name(rdaw, "filmmaker.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:rightAscensionAndDeclination</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/rightAscensionAndDeclination">http://rdaregistry.info/Elements/w/rightAscensionAndDeclination</seealso>
    let rightAscensionAndDeclination =
        Prefixed_Name(rdaw, "rightAscensionAndDeclination") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:stringsOfCoordinatePairs.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/stringsOfCoordinatePairs.en">http://rdaregistry.info/Elements/w/stringsOfCoordinatePairs.en</seealso>
    let ``stringsOfCoordinatePairs.en`` =
        Prefixed_Name(rdaw, "stringsOfCoordinatePairs.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:stringsOfCoordinatePairs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/stringsOfCoordinatePairs">http://rdaregistry.info/Elements/w/stringsOfCoordinatePairs</seealso>
    let stringsOfCoordinatePairs =
        Prefixed_Name(rdaw, "stringsOfCoordinatePairs") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10084</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has system of organization</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10084">http://rdaregistry.info/Elements/w/P10084</seealso>
    let P10084 = Prefixed_Name(rdaw, "P10084") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:systemOfOrganization.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/systemOfOrganization.en">http://rdaregistry.info/Elements/w/systemOfOrganization.en</seealso>
    let ``systemOfOrganization.en`` =
        Prefixed_Name(rdaw, "systemOfOrganization.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10138</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is video adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10138">http://rdaregistry.info/Elements/w/P10138</seealso>
    let P10138 = Prefixed_Name(rdaw, "P10138") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:adaptedAsAVideoWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsAVideoWork">http://rdaregistry.info/Elements/w/adaptedAsAVideoWork</seealso>
    let adaptedAsAVideoWork = Prefixed_Name(rdaw, "adaptedAsAVideoWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10223</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has preferred title for the work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10223">http://rdaregistry.info/Elements/w/P10223</seealso>
    let P10223 = Prefixed_Name(rdaw, "P10223") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:titleOfTheWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/titleOfTheWork.en">http://rdaregistry.info/Elements/w/titleOfTheWork.en</seealso>
    let ``titleOfTheWork.en`` = Prefixed_Name(rdaw, "titleOfTheWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:titleOfTheWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/titleOfTheWork">http://rdaregistry.info/Elements/w/titleOfTheWork</seealso>
    let titleOfTheWork = Prefixed_Name(rdaw, "titleOfTheWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10089</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abstracted in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10089">http://rdaregistry.info/Elements/w/P10089</seealso>
    let P10089 = Prefixed_Name(rdaw, "P10089") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10098</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adapted as radio script (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10098">http://rdaregistry.info/Elements/w/P10098</seealso>
    let P10098 = Prefixed_Name(rdaw, "P10098") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsRadioScriptWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsRadioScriptWork.en">http://rdaregistry.info/Elements/w/adaptedAsRadioScriptWork.en</seealso>
    let ``adaptedAsRadioScriptWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsRadioScriptWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10137</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio script based on (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10137">http://rdaregistry.info/Elements/w/P10137</seealso>
    let P10137 = Prefixed_Name(rdaw, "P10137") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsARadioScriptWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsARadioScriptWork">http://rdaregistry.info/Elements/w/adaptedAsARadioScriptWork</seealso>
    let adaptedAsARadioScriptWork =
        Prefixed_Name(rdaw, "adaptedAsARadioScriptWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10099</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is freely translated as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10099">http://rdaregistry.info/Elements/w/P10099</seealso>
    let P10099 = Prefixed_Name(rdaw, "P10099") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:freelyTranslatedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/freelyTranslatedAsWork.en">http://rdaregistry.info/Elements/w/freelyTranslatedAsWork.en</seealso>
    let ``freelyTranslatedAsWork.en`` =
        Prefixed_Name(rdaw, "freelyTranslatedAsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:descriptionOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/descriptionOfWork.en">http://rdaregistry.info/Elements/w/descriptionOfWork.en</seealso>
    let ``descriptionOfWork.en`` =
        Prefixed_Name(rdaw, "descriptionOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10257</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has subject (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10257">http://rdaregistry.info/Elements/w/P10257</seealso>
    let P10257 = Prefixed_Name(rdaw, "P10257") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10118</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is described in (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10118">http://rdaregistry.info/Elements/w/P10118</seealso>
    let P10118 = Prefixed_Name(rdaw, "P10118") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:descriptionOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/descriptionOfWork">http://rdaregistry.info/Elements/w/descriptionOfWork</seealso>
    let descriptionOfWork = Prefixed_Name(rdaw, "descriptionOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:subseriesOf.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subseriesOf.en">http://rdaregistry.info/Elements/w/subseriesOf.en</seealso>
    let ``subseriesOf.en`` = Prefixed_Name(rdaw, "subseriesOf.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:subseriesOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/subseriesOf">http://rdaregistry.info/Elements/w/subseriesOf</seealso>
    let subseriesOf = Prefixed_Name(rdaw, "subseriesOf") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:inSeries.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/inSeries.en">http://rdaregistry.info/Elements/w/inSeries.en</seealso>
    let ``inSeries.en`` = Prefixed_Name(rdaw, "inSeries.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10141</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is series container of</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10141">http://rdaregistry.info/Elements/w/P10141</seealso>
    let P10141 = Prefixed_Name(rdaw, "P10141") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:inSeries</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/inSeries">http://rdaregistry.info/Elements/w/inSeries</seealso>
    let inSeries = Prefixed_Name(rdaw, "inSeries") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10162</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is radio script (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10162">http://rdaregistry.info/Elements/w/P10162</seealso>
    let P10162 = Prefixed_Name(rdaw, "P10162") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10176</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is script for radio program (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10176">http://rdaregistry.info/Elements/w/P10176</seealso>
    let P10176 = Prefixed_Name(rdaw, "P10176") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10159</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10159">http://rdaregistry.info/Elements/w/P10159</seealso>
    let P10159 = Prefixed_Name(rdaw, "P10159") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10248</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is choreography for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10248">http://rdaregistry.info/Elements/w/P10248</seealso>
    let P10248 = Prefixed_Name(rdaw, "P10248") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10105</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay for (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10105">http://rdaregistry.info/Elements/w/P10105</seealso>
    let P10105 = Prefixed_Name(rdaw, "P10105") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10175</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay for video (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10175">http://rdaregistry.info/Elements/w/P10175</seealso>
    let P10175 = Prefixed_Name(rdaw, "P10175") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10173</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay for motion picture (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10173">http://rdaregistry.info/Elements/w/P10173</seealso>
    let P10173 = Prefixed_Name(rdaw, "P10173") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10174</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is screenplay for television program (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10174">http://rdaregistry.info/Elements/w/P10174</seealso>
    let P10174 = Prefixed_Name(rdaw, "P10174") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayForWork.en">http://rdaregistry.info/Elements/w/screenplayForWork.en</seealso>
    let ``screenplayForWork.en`` =
        Prefixed_Name(rdaw, "screenplayForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:screenplayForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/screenplayForWork">http://rdaregistry.info/Elements/w/screenplayForWork</seealso>
    let screenplayForWork = Prefixed_Name(rdaw, "screenplayForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:incidentalMusicForWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/incidentalMusicForWork.en">http://rdaregistry.info/Elements/w/incidentalMusicForWork.en</seealso>
    let ``incidentalMusicForWork.en`` =
        Prefixed_Name(rdaw, "incidentalMusicForWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:incidentalMusicForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/incidentalMusicForWork">http://rdaregistry.info/Elements/w/incidentalMusicForWork</seealso>
    let incidentalMusicForWork =
        Prefixed_Name(rdaw, "incidentalMusicForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10107</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abstracted as (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10107">http://rdaregistry.info/Elements/w/P10107</seealso>
    let P10107 = Prefixed_Name(rdaw, "P10107") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:abstractedAsWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abstractedAsWork.en">http://rdaregistry.info/Elements/w/abstractedAsWork.en</seealso>
    let ``abstractedAsWork.en`` =
        Prefixed_Name(rdaw, "abstractedAsWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10126</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abstract of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10126">http://rdaregistry.info/Elements/w/P10126</seealso>
    let P10126 = Prefixed_Name(rdaw, "P10126") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:abstractWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abstractWork">http://rdaregistry.info/Elements/w/abstractWork</seealso>
    let abstractWork = Prefixed_Name(rdaw, "abstractWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10158</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is index (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10158">http://rdaregistry.info/Elements/w/P10158</seealso>
    let P10158 = Prefixed_Name(rdaw, "P10158") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10172</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is supplement (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10172">http://rdaregistry.info/Elements/w/P10172</seealso>
    let P10172 = Prefixed_Name(rdaw, "P10172") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10124</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is guide (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10124">http://rdaregistry.info/Elements/w/P10124</seealso>
    let P10124 = Prefixed_Name(rdaw, "P10124") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10122</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is prequel</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10122">http://rdaregistry.info/Elements/w/P10122</seealso>
    let P10122 = Prefixed_Name(rdaw, "P10122") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:prequel.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/prequel.en">http://rdaregistry.info/Elements/w/prequel.en</seealso>
    let ``prequel.en`` = Prefixed_Name(rdaw, "prequel.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10156</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is preceded by (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10156">http://rdaregistry.info/Elements/w/P10156</seealso>
    let P10156 = Prefixed_Name(rdaw, "P10156") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10195</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is prequel to</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10195">http://rdaregistry.info/Elements/w/P10195</seealso>
    let P10195 = Prefixed_Name(rdaw, "P10195") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:prequel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/prequel">http://rdaregistry.info/Elements/w/prequel</seealso>
    let prequel = Prefixed_Name(rdaw, "prequel") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appendixWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appendixWork.en">http://rdaregistry.info/Elements/w/appendixWork.en</seealso>
    let ``appendixWork.en`` = Prefixed_Name(rdaw, "appendixWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10151</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is appendix to (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10151">http://rdaregistry.info/Elements/w/P10151</seealso>
    let P10151 = Prefixed_Name(rdaw, "P10151") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:appendixWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/appendixWork">http://rdaregistry.info/Elements/w/appendixWork</seealso>
    let appendixWork = Prefixed_Name(rdaw, "appendixWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:guideWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/guideWork.en">http://rdaregistry.info/Elements/w/guideWork.en</seealso>
    let ``guideWork.en`` = Prefixed_Name(rdaw, "guideWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10150</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is guide to (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10150">http://rdaregistry.info/Elements/w/P10150</seealso>
    let P10150 = Prefixed_Name(rdaw, "P10150") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:guideWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/guideWork">http://rdaregistry.info/Elements/w/guideWork</seealso>
    let guideWork = Prefixed_Name(rdaw, "guideWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10125</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is abridgement of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10125">http://rdaregistry.info/Elements/w/P10125</seealso>
    let P10125 = Prefixed_Name(rdaw, "P10125") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:abridgementOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/abridgementOfWork.en">http://rdaregistry.info/Elements/w/abridgementOfWork.en</seealso>
    let ``abridgementOfWork.en`` =
        Prefixed_Name(rdaw, "abridgementOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:dramatizationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dramatizationOfWork.en">http://rdaregistry.info/Elements/w/dramatizationOfWork.en</seealso>
    let ``dramatizationOfWork.en`` =
        Prefixed_Name(rdaw, "dramatizationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10142</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is adaptation of (work)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10142">http://rdaregistry.info/Elements/w/P10142</seealso>
    let P10142 = Prefixed_Name(rdaw, "P10142") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:dramatizationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/dramatizationOfWork">http://rdaregistry.info/Elements/w/dramatizationOfWork</seealso>
    let dramatizationOfWork = Prefixed_Name(rdaw, "dramatizationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:verseAdaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/verseAdaptationOfWork.en">http://rdaregistry.info/Elements/w/verseAdaptationOfWork.en</seealso>
    let ``verseAdaptationOfWork.en`` =
        Prefixed_Name(rdaw, "verseAdaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:verseAdaptationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/verseAdaptationOfWork">http://rdaregistry.info/Elements/w/verseAdaptationOfWork</seealso>
    let verseAdaptationOfWork =
        Prefixed_Name(rdaw, "verseAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:motionPictureAdaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/motionPictureAdaptationOfWork.en">http://rdaregistry.info/Elements/w/motionPictureAdaptationOfWork.en</seealso>
    let ``motionPictureAdaptationOfWork.en`` =
        Prefixed_Name(rdaw, "motionPictureAdaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:motionPictureAdaptationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/motionPictureAdaptationOfWork">http://rdaregistry.info/Elements/w/motionPictureAdaptationOfWork</seealso>
    let motionPictureAdaptationOfWork =
        Prefixed_Name(rdaw, "motionPictureAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:novelizationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/novelizationOfWork.en">http://rdaregistry.info/Elements/w/novelizationOfWork.en</seealso>
    let ``novelizationOfWork.en`` =
        Prefixed_Name(rdaw, "novelizationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:novelizationOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/novelizationOfWork">http://rdaregistry.info/Elements/w/novelizationOfWork</seealso>
    let novelizationOfWork = Prefixed_Name(rdaw, "novelizationOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:addendaToWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/addendaToWork">http://rdaregistry.info/Elements/w/addendaToWork</seealso>
    let addendaToWork = Prefixed_Name(rdaw, "addendaToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:reviewOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/reviewOfWork.en">http://rdaregistry.info/Elements/w/reviewOfWork.en</seealso>
    let ``reviewOfWork.en`` = Prefixed_Name(rdaw, "reviewOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:reviewOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/reviewOfWork">http://rdaregistry.info/Elements/w/reviewOfWork</seealso>
    let reviewOfWork = Prefixed_Name(rdaw, "reviewOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:summaryOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/summaryOfWork.en">http://rdaregistry.info/Elements/w/summaryOfWork.en</seealso>
    let ``summaryOfWork.en`` = Prefixed_Name(rdaw, "summaryOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:summaryOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/summaryOfWork">http://rdaregistry.info/Elements/w/summaryOfWork</seealso>
    let summaryOfWork = Prefixed_Name(rdaw, "summaryOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:catalogueOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/catalogueOfWork.en">http://rdaregistry.info/Elements/w/catalogueOfWork.en</seealso>
    let ``catalogueOfWork.en`` =
        Prefixed_Name(rdaw, "catalogueOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:catalogueOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/catalogueOfWork">http://rdaregistry.info/Elements/w/catalogueOfWork</seealso>
    let catalogueOfWork = Prefixed_Name(rdaw, "catalogueOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:concordanceToWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/concordanceToWork.en">http://rdaregistry.info/Elements/w/concordanceToWork.en</seealso>
    let ``concordanceToWork.en`` =
        Prefixed_Name(rdaw, "concordanceToWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:choreographicAdaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/choreographicAdaptationOfWork.en">http://rdaregistry.info/Elements/w/choreographicAdaptationOfWork.en</seealso>
    let ``choreographicAdaptationOfWork.en`` =
        Prefixed_Name(rdaw, "choreographicAdaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:choreographyForWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/choreographyForWork">http://rdaregistry.info/Elements/w/choreographyForWork</seealso>
    let choreographyForWork = Prefixed_Name(rdaw, "choreographyForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:expandedVersionOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/expandedVersionOfWork.en">http://rdaregistry.info/Elements/w/expandedVersionOfWork.en</seealso>
    let ``expandedVersionOfWork.en`` =
        Prefixed_Name(rdaw, "expandedVersionOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:expandedVersionOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/expandedVersionOfWork">http://rdaregistry.info/Elements/w/expandedVersionOfWork</seealso>
    let expandedVersionOfWork =
        Prefixed_Name(rdaw, "expandedVersionOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:remakeOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/remakeOfWork.en">http://rdaregistry.info/Elements/w/remakeOfWork.en</seealso>
    let ``remakeOfWork.en`` = Prefixed_Name(rdaw, "remakeOfWork.en") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:remakeOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/remakeOfWork">http://rdaregistry.info/Elements/w/remakeOfWork</seealso>
    let remakeOfWork = Prefixed_Name(rdaw, "remakeOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:paraphraseOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/paraphraseOfWork.en">http://rdaregistry.info/Elements/w/paraphraseOfWork.en</seealso>
    let ``paraphraseOfWork.en`` =
        Prefixed_Name(rdaw, "paraphraseOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:paraphraseOfWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/paraphraseOfWork">http://rdaregistry.info/Elements/w/paraphraseOfWork</seealso>
    let paraphraseOfWork = Prefixed_Name(rdaw, "paraphraseOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:coverageOfTheContent.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/coverageOfTheContent.en">http://rdaregistry.info/Elements/w/coverageOfTheContent.en</seealso>
    let ``coverageOfTheContent.en`` =
        Prefixed_Name(rdaw, "coverageOfTheContent.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:coverageOfTheContent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/coverageOfTheContent">http://rdaregistry.info/Elements/w/coverageOfTheContent</seealso>
    let coverageOfTheContent =
        Prefixed_Name(rdaw, "coverageOfTheContent") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10217</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has intended audience</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10217">http://rdaregistry.info/Elements/w/P10217</seealso>
    let P10217 = Prefixed_Name(rdaw, "P10217") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:intendedAudience.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/intendedAudience.en">http://rdaregistry.info/Elements/w/intendedAudience.en</seealso>
    let ``intendedAudience.en`` =
        Prefixed_Name(rdaw, "intendedAudience.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:intendedAudience</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/intendedAudience">http://rdaregistry.info/Elements/w/intendedAudience</seealso>
    let intendedAudience = Prefixed_Name(rdaw, "intendedAudience") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10218</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has place of origin of the work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10218">http://rdaregistry.info/Elements/w/P10218</seealso>
    let P10218 = Prefixed_Name(rdaw, "P10218") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:placeOfOriginOfTheWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/placeOfOriginOfTheWork.en">http://rdaregistry.info/Elements/w/placeOfOriginOfTheWork.en</seealso>
    let ``placeOfOriginOfTheWork.en`` =
        Prefixed_Name(rdaw, "placeOfOriginOfTheWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:placeOfOriginOfTheWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/placeOfOriginOfTheWork">http://rdaregistry.info/Elements/w/placeOfOriginOfTheWork</seealso>
    let placeOfOriginOfTheWork =
        Prefixed_Name(rdaw, "placeOfOriginOfTheWork") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10219</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has date of work</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10219">http://rdaregistry.info/Elements/w/P10219</seealso>
    let P10219 = Prefixed_Name(rdaw, "P10219") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsVideoGameWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsVideoGameWork.en">http://rdaregistry.info/Elements/w/adaptedAsVideoGameWork.en</seealso>
    let ``adaptedAsVideoGameWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsVideoGameWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:videoGameAdaptationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/videoGameAdaptationOfWork.en">http://rdaregistry.info/Elements/w/videoGameAdaptationOfWork.en</seealso>
    let ``videoGameAdaptationOfWork.en`` =
        Prefixed_Name(rdaw, "videoGameAdaptationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:adaptedAsGraphicNovelWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/adaptedAsGraphicNovelWork.en">http://rdaregistry.info/Elements/w/adaptedAsGraphicNovelWork.en</seealso>
    let ``adaptedAsGraphicNovelWork.en`` =
        Prefixed_Name(rdaw, "adaptedAsGraphicNovelWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:graphicNovelizationOfWork.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/graphicNovelizationOfWork.en">http://rdaregistry.info/Elements/w/graphicNovelizationOfWork.en</seealso>
    let ``graphicNovelizationOfWork.en`` =
        Prefixed_Name(rdaw, "graphicNovelizationOfWork.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:calligrapher.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/calligrapher.en">http://rdaregistry.info/Elements/w/calligrapher.en</seealso>
    let ``calligrapher.en`` = Prefixed_Name(rdaw, "calligrapher.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:reviewOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/reviewOfManifestation.en">http://rdaregistry.info/Elements/w/reviewOfManifestation.en</seealso>
    let ``reviewOfManifestation.en`` =
        Prefixed_Name(rdaw, "reviewOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:critiqueOfManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/critiqueOfManifestation.en">http://rdaregistry.info/Elements/w/critiqueOfManifestation.en</seealso>
    let ``critiqueOfManifestation.en`` =
        Prefixed_Name(rdaw, "critiqueOfManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:commentaryOnManifestation.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commentaryOnManifestation.en">http://rdaregistry.info/Elements/w/commentaryOnManifestation.en</seealso>
    let ``commentaryOnManifestation.en`` =
        Prefixed_Name(rdaw, "commentaryOnManifestation.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:P10281</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is critique of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10281">http://rdaregistry.info/Elements/w/P10281</seealso>
    let P10281 = Prefixed_Name(rdaw, "P10281") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10280</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is review of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10280">http://rdaregistry.info/Elements/w/P10280</seealso>
    let P10280 = Prefixed_Name(rdaw, "P10280") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10279</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is evaluation of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10279">http://rdaregistry.info/Elements/w/P10279</seealso>
    let P10279 = Prefixed_Name(rdaw, "P10279") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10278</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is analysis of (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10278">http://rdaregistry.info/Elements/w/P10278</seealso>
    let P10278 = Prefixed_Name(rdaw, "P10278") |> PrefixedName
    /// <summary>
    ///   <para>rdaw:P10282</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is commentary on (expression)</para></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/P10282">http://rdaregistry.info/Elements/w/P10282</seealso>
    let P10282 = Prefixed_Name(rdaw, "P10282") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:descriptionOfExpression.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/descriptionOfExpression.en">http://rdaregistry.info/Elements/w/descriptionOfExpression.en</seealso>
    let ``descriptionOfExpression.en`` =
        Prefixed_Name(rdaw, "descriptionOfExpression.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:analysisOfExpression.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/analysisOfExpression.en">http://rdaregistry.info/Elements/w/analysisOfExpression.en</seealso>
    let ``analysisOfExpression.en`` =
        Prefixed_Name(rdaw, "analysisOfExpression.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:evaluationOfExpression.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/evaluationOfExpression.en">http://rdaregistry.info/Elements/w/evaluationOfExpression.en</seealso>
    let ``evaluationOfExpression.en`` =
        Prefixed_Name(rdaw, "evaluationOfExpression.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:reviewOfExpression.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/reviewOfExpression.en">http://rdaregistry.info/Elements/w/reviewOfExpression.en</seealso>
    let ``reviewOfExpression.en`` =
        Prefixed_Name(rdaw, "reviewOfExpression.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:critiqueOfExpression.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/critiqueOfExpression.en">http://rdaregistry.info/Elements/w/critiqueOfExpression.en</seealso>
    let ``critiqueOfExpression.en`` =
        Prefixed_Name(rdaw, "critiqueOfExpression.en") |> PrefixedName

    /// <summary>
    ///   <para>rdaw:commentaryOnExpression.en</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdaregistry.info/Elements/w/commentaryOnExpression.en">http://rdaregistry.info/Elements/w/commentaryOnExpression.en</seealso>
    let ``commentaryOnExpression.en`` =
        Prefixed_Name(rdaw, "commentaryOnExpression.en") |> PrefixedName
