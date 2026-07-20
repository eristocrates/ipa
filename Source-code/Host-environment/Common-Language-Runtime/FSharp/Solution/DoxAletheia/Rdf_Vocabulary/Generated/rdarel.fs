namespace http.rdvocab.info.RDARelationshipsWEMI.slash

open DoxAletheia

module rdarel =
    let _namespace_name = "http://rdvocab.info/RDARelationshipsWEMI/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/BasisForLibrettoWork"></see>
    /// </summary>
    let BasisForLibrettoWork = _prefix "BasisForLibrettoWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeWork"></see>
    /// </summary>
    let derivativeWork = _prefix "derivativeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basisForLibretto"></see>
    /// </summary>
    let basisForLibretto = _prefix "basisForLibretto"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAs"></see>
    /// </summary>
    let abridgedAs = _prefix "abridgedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAsExpression"></see>
    /// </summary>
    let abridgedAsExpression = _prefix "abridgedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAsWork"></see>
    /// </summary>
    let abridgedAsWork = _prefix "abridgedAsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeExpression"></see>
    /// </summary>
    let derivativeExpression = _prefix "derivativeExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOf"></see>
    /// </summary>
    let abridgementOf = _prefix "abridgementOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOfExpression"></see>
    /// </summary>
    let abridgementOfExpression = _prefix "abridgementOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOfWork"></see>
    /// </summary>
    let abridgementOfWork = _prefix "abridgementOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basedOn"></see>
    /// </summary>
    let basedOn = _prefix "basedOn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basedOnExpression"></see>
    /// </summary>
    let basedOnExpression = _prefix "basedOnExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basedOnWork"></see>
    /// </summary>
    let basedOnWork = _prefix "basedOnWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbed"></see>
    /// </summary>
    let absorbed = _prefix "absorbed"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedExpression"></see>
    /// </summary>
    let absorbedExpression = _prefix "absorbedExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedWork"></see>
    /// </summary>
    let absorbedWork = _prefix "absorbedWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/precededBy"></see>
    /// </summary>
    let precededBy = _prefix "precededBy"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedBy"></see>
    /// </summary>
    let absorbedBy = _prefix "absorbedBy"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedByExpression"></see>
    /// </summary>
    let absorbedByExpression = _prefix "absorbedByExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedByWork"></see>
    /// </summary>
    let absorbedByWork = _prefix "absorbedByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/succeededBy"></see>
    /// </summary>
    let succeededBy = _prefix "succeededBy"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/succeededByExpression"></see>
    /// </summary>
    let succeededByExpression = _prefix "succeededByExpression"
    /// <summary>
    /// For sequentially numbered works with revised content.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/succeededByWork"></see></summary>
    let succeededByWork = _prefix "succeededByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/precededByExpression"></see>
    /// </summary>
    let precededByExpression = _prefix "precededByExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPart"></see>
    /// </summary>
    let absorbedInPart = _prefix "absorbedInPart"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartExpression"></see>
    /// </summary>
    let absorbedInPartExpression = _prefix "absorbedInPartExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartWork"></see>
    /// </summary>
    let absorbedInPartWork = _prefix "absorbedInPartWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartBy"></see>
    /// </summary>
    let absorbedInPartBy = _prefix "absorbedInPartBy"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByExpression"></see>
    /// </summary>
    let absorbedInPartByExpression = _prefix "absorbedInPartByExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByWork"></see>
    /// </summary>
    let absorbedInPartByWork = _prefix "absorbedInPartByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/precededByWork"></see>
    /// </summary>
    let precededByWork = _prefix "precededByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstract"></see>
    /// </summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractExpression"></see>
    /// </summary>
    let abstractExpression = _prefix "abstractExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractWork"></see>
    /// </summary>
    let abstractWork = _prefix "abstractWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractOf"></see>
    /// </summary>
    let abstractOf = _prefix "abstractOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractOfExpression"></see>
    /// </summary>
    let abstractOfExpression = _prefix "abstractOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractOfWork"></see>
    /// </summary>
    let abstractOfWork = _prefix "abstractOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractedIn"></see>
    /// </summary>
    let abstractedIn = _prefix "abstractedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractedInExpression"></see>
    /// </summary>
    let abstractedInExpression = _prefix "abstractedInExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractedInWork"></see>
    /// </summary>
    let abstractedInWork = _prefix "abstractedInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractsFor"></see>
    /// </summary>
    let abstractsFor = _prefix "abstractsFor"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractsForExpression"></see>
    /// </summary>
    let abstractsForExpression = _prefix "abstractsForExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractsForWork"></see>
    /// </summary>
    let abstractsForWork = _prefix "abstractsForWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedBy"></see>
    /// </summary>
    let accompaniedBy = _prefix "accompaniedBy"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedByManifestation"></see>
    /// </summary>
    let accompaniedByManifestation = _prefix "accompaniedByManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/boundWith"></see>
    /// </summary>
    let boundWith = _prefix "boundWith"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWith"></see>
    /// </summary>
    let onDiscWith = _prefix "onDiscWith"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/issuedWith"></see>
    /// </summary>
    let issuedWith = _prefix "issuedWith"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedByItem"></see>
    /// </summary>
    let accompaniedByItem = _prefix "accompaniedByItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/filmedWith"></see>
    /// </summary>
    let filmedWith = _prefix "filmedWith"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/boundWithItem"></see>
    /// </summary>
    let boundWithItem = _prefix "boundWithItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWithItem"></see>
    /// </summary>
    let onDiscWithItem = _prefix "onDiscWithItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/filmedWithItem"></see>
    /// </summary>
    let filmedWithItem = _prefix "filmedWithItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/issuedWithManifestation"></see>
    /// </summary>
    let issuedWithManifestation = _prefix "issuedWithManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompanyingExpression"></see>
    /// </summary>
    let accompanyingExpression = _prefix "accompanyingExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOfExpression"></see>
    /// </summary>
    let augmentationOfExpression = _prefix "augmentationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentedByExpression"></see>
    /// </summary>
    let augmentedByExpression = _prefix "augmentedByExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/complementedByExpression"></see>
    /// </summary>
    let complementedByExpression = _prefix "complementedByExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompanyingWork"></see>
    /// </summary>
    let accompanyingWork = _prefix "accompanyingWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentedByWork"></see>
    /// </summary>
    let augmentedByWork = _prefix "augmentedByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/complementedByWork"></see>
    /// </summary>
    let complementedByWork = _prefix "complementedByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOf"></see>
    /// </summary>
    let adaptationOf = _prefix "adaptationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOf"></see>
    /// </summary>
    let motionPictureAdaptationOf = _prefix "motionPictureAdaptationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOf"></see>
    /// </summary>
    let radioAdaptationOf = _prefix "radioAdaptationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOn"></see>
    /// </summary>
    let radioScriptBasedOn = _prefix "radioScriptBasedOn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOf"></see>
    /// </summary>
    let televisionAdaptationOf = _prefix "televisionAdaptationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOf"></see>
    /// </summary>
    let videoAdaptationOf = _prefix "videoAdaptationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOn"></see>
    /// </summary>
    let screenplayBasedOn = _prefix "screenplayBasedOn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOf"></see>
    /// </summary>
    let novelizationOf = _prefix "novelizationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOfExpression"></see>
    /// </summary>
    let adaptationOfExpression = _prefix "adaptationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOf"></see>
    /// </summary>
    let dramatizationOf = _prefix "dramatizationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOf"></see>
    /// </summary>
    let verseAdaptationOf = _prefix "verseAdaptationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOfWork"></see>
    /// </summary>
    let adaptationOfWork = _prefix "adaptationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnExpression"></see>
    /// </summary>
    let screenplayBasedOnExpression = _prefix "screenplayBasedOnExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfExpression"></see>
    /// </summary>
    let videoAdaptationOfExpression = _prefix "videoAdaptationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnExpression"></see>
    /// </summary>
    let radioScriptBasedOnExpression = _prefix "radioScriptBasedOnExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfExpression"></see>
    /// </summary>
    let radioAdaptationOfExpression = _prefix "radioAdaptationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfWork"></see>
    /// </summary>
    let dramatizationOfWork = _prefix "dramatizationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfWork"></see>
    /// </summary>
    let videoAdaptationOfWork = _prefix "videoAdaptationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfWork"></see>
    /// </summary>
    let televisionAdaptationOfWork = _prefix "televisionAdaptationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOfWork"></see>
    /// </summary>
    let novelizationOfWork = _prefix "novelizationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnWork"></see>
    /// </summary>
    let screenplayBasedOnWork = _prefix "screenplayBasedOnWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfWork"></see>
    /// </summary>
    let radioAdaptationOfWork = _prefix "radioAdaptationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnWork"></see>
    /// </summary>
    let radioScriptBasedOnWork = _prefix "radioScriptBasedOnWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfWork"></see>
    /// </summary>
    let verseAdaptationOfWork = _prefix "verseAdaptationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfWork"></see>
    /// </summary>
    let motionPictureAdaptationOfWork = _prefix "motionPictureAdaptationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAs"></see>
    /// </summary>
    let adaptedAs = _prefix "adaptedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptation"></see>
    /// </summary>
    let verseAdaptation = _prefix "verseAdaptation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsWork"></see>
    /// </summary>
    let adaptedAsWork = _prefix "adaptedAsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPicture"></see>
    /// </summary>
    let adaptedAsAMotionPicture = _prefix "adaptedAsAMotionPicture"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelization"></see>
    /// </summary>
    let novelization = _prefix "novelization"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideo"></see>
    /// </summary>
    let adaptedAsAVideo = _prefix "adaptedAsAVideo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplay"></see>
    /// </summary>
    let adaptedAsAScreenplay = _prefix "adaptedAsAScreenplay"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgramme"></see>
    /// </summary>
    let adaptedAsATelevisionProgramme = _prefix "adaptedAsATelevisionProgramme"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScript"></see>
    /// </summary>
    let adaptedAsARadioScript = _prefix "adaptedAsARadioScript"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgramme"></see>
    /// </summary>
    let adaptedAsARadioProgramme = _prefix "adaptedAsARadioProgramme"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAs"></see>
    /// </summary>
    let dramatizedAs = _prefix "dramatizedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsExpression"></see>
    /// </summary>
    let adaptedAsExpression = _prefix "adaptedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureExpression"></see>
    /// </summary>
    let adaptedAsAMotionPictureExpression = _prefix "adaptedAsAMotionPictureExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureWork"></see>
    /// </summary>
    let adaptedAsAMotionPictureWork = _prefix "adaptedAsAMotionPictureWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplay"></see>
    /// </summary>
    let adaptedAsAMotionPictureScreenplay = _prefix "adaptedAsAMotionPictureScreenplay"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayExpression"></see>
    /// </summary>
    let adaptedAsAMotionPictureScreenplayExpression =
        _prefix "adaptedAsAMotionPictureScreenplayExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayWork"></see>
    /// </summary>
    let adaptedAsAMotionPictureScreenplayWork =
        _prefix "adaptedAsAMotionPictureScreenplayWork"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayExpression"></see>
    /// </summary>
    let adaptedAsAScreenplayExpression = _prefix "adaptedAsAScreenplayExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayWork"></see>
    /// </summary>
    let adaptedAsAScreenplayWork = _prefix "adaptedAsAScreenplayWork"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeExpression"></see>
    /// </summary>
    let adaptedAsARadioProgrammeExpression =
        _prefix "adaptedAsARadioProgrammeExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeWork"></see>
    /// </summary>
    let adaptedAsARadioProgrammeWork = _prefix "adaptedAsARadioProgrammeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptExpression"></see>
    /// </summary>
    let adaptedAsARadioScriptExpression = _prefix "adaptedAsARadioScriptExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptWork"></see>
    /// </summary>
    let adaptedAsARadioScriptWork = _prefix "adaptedAsARadioScriptWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplay"></see>
    /// </summary>
    let adaptedAsATelevisionScreenplay = _prefix "adaptedAsATelevisionScreenplay"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplay"></see>
    /// </summary>
    let adaptedAsAVideoScreenplay = _prefix "adaptedAsAVideoScreenplay"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayExpression"></see>
    /// </summary>
    let adaptedAsAVideoScreenplayExpression =
        _prefix "adaptedAsAVideoScreenplayExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayExpression"></see>
    /// </summary>
    let adaptedAsATelevisionScreenplayExpression =
        _prefix "adaptedAsATelevisionScreenplayExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayWork"></see>
    /// </summary>
    let adaptedAsAVideoScreenplayWork = _prefix "adaptedAsAVideoScreenplayWork"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayWork"></see>
    /// </summary>
    let adaptedAsATelevisionScreenplayWork =
        _prefix "adaptedAsATelevisionScreenplayWork"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeExpression"></see>
    /// </summary>
    let adaptedAsATelevisionProgrammeExpression =
        _prefix "adaptedAsATelevisionProgrammeExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeWork"></see>
    /// </summary>
    let adaptedAsATelevisionProgrammeWork = _prefix "adaptedAsATelevisionProgrammeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoExpression"></see>
    /// </summary>
    let adaptedAsAVideoExpression = _prefix "adaptedAsAVideoExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoWork"></see>
    /// </summary>
    let adaptedAsAVideoWork = _prefix "adaptedAsAVideoWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationExpression"></see>
    /// </summary>
    let novelizationExpression = _prefix "novelizationExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsExpression"></see>
    /// </summary>
    let dramatizedAsExpression = _prefix "dramatizedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationExpression"></see>
    /// </summary>
    let verseAdaptationExpression = _prefix "verseAdaptationExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoWork"></see>
    /// </summary>
    let screenplayForTheVideoWork = _prefix "screenplayForTheVideoWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsWork"></see>
    /// </summary>
    let dramatizedAsWork = _prefix "dramatizedAsWork"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeWork"></see>
    /// </summary>
    let screenplayForTheTelevisionProgrammeWork =
        _prefix "screenplayForTheTelevisionProgrammeWork"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureWork"></see>
    /// </summary>
    let screenplayForTheMotionPictureWork = _prefix "screenplayForTheMotionPictureWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeWork"></see>
    /// </summary>
    let scriptForTheRadioProgrammeWork = _prefix "scriptForTheRadioProgrammeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationWork"></see>
    /// </summary>
    let novelizationWork = _prefix "novelizationWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationWork"></see>
    /// </summary>
    let verseAdaptationWork = _prefix "verseAdaptationWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addenda"></see>
    /// </summary>
    let addenda = _prefix "addenda"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentedBy"></see>
    /// </summary>
    let augmentedBy = _prefix "augmentedBy"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaExpression"></see>
    /// </summary>
    let addendaExpression = _prefix "addendaExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaTo"></see>
    /// </summary>
    let addendaTo = _prefix "addendaTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaToExpression"></see>
    /// </summary>
    let addendaToExpression = _prefix "addendaToExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaToWork"></see>
    /// </summary>
    let addendaToWork = _prefix "addendaToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOf"></see>
    /// </summary>
    let augmentationOf = _prefix "augmentationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOfWork"></see>
    /// </summary>
    let augmentationOfWork = _prefix "augmentationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaWork"></see>
    /// </summary>
    let addendaWork = _prefix "addendaWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAs"></see>
    /// </summary>
    let alsoIssuedAs = _prefix "alsoIssuedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAsManifestation"></see>
    /// </summary>
    let alsoIssuedAsManifestation = _prefix "alsoIssuedAsManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalentManifestation"></see>
    /// </summary>
    let equivalentManifestation = _prefix "equivalentManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysedIn"></see>
    /// </summary>
    let analysedIn = _prefix "analysedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysedInExpression"></see>
    /// </summary>
    let analysedInExpression = _prefix "analysedInExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysedInWork"></see>
    /// </summary>
    let analysedInWork = _prefix "analysedInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/describedIn"></see>
    /// </summary>
    let describedIn = _prefix "describedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/describedInExpression"></see>
    /// </summary>
    let describedInExpression = _prefix "describedInExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/describedInWork"></see>
    /// </summary>
    let describedInWork = _prefix "describedInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOf"></see>
    /// </summary>
    let analysisOf = _prefix "analysisOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfExpression"></see>
    /// </summary>
    let analysisOfExpression = _prefix "analysisOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfItem"></see>
    /// </summary>
    let analysisOfItem = _prefix "analysisOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfManifestation"></see>
    /// </summary>
    let analysisOfManifestation = _prefix "analysisOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfWork"></see>
    /// </summary>
    let analysisOfWork = _prefix "analysisOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOf"></see>
    /// </summary>
    let descriptionOf = _prefix "descriptionOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfExpression"></see>
    /// </summary>
    let descriptionOfExpression = _prefix "descriptionOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfItem"></see>
    /// </summary>
    let descriptionOfItem = _prefix "descriptionOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfManifestation"></see>
    /// </summary>
    let descriptionOfManifestation = _prefix "descriptionOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfWork"></see>
    /// </summary>
    let descriptionOfWork = _prefix "descriptionOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendix"></see>
    /// </summary>
    let appendix = _prefix "appendix"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixExpression"></see>
    /// </summary>
    let appendixExpression = _prefix "appendixExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixWork"></see>
    /// </summary>
    let appendixWork = _prefix "appendixWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixTo"></see>
    /// </summary>
    let appendixTo = _prefix "appendixTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixToExpression"></see>
    /// </summary>
    let appendixToExpression = _prefix "appendixToExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixToWork"></see>
    /// </summary>
    let appendixToWork = _prefix "appendixToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOf"></see>
    /// </summary>
    let catalogueOf = _prefix "catalogueOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementTo"></see>
    /// </summary>
    let supplementTo = _prefix "supplementTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceTo"></see>
    /// </summary>
    let concordanceTo = _prefix "concordanceTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidFor"></see>
    /// </summary>
    let findingAidFor = _prefix "findingAidFor"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataTo"></see>
    /// </summary>
    let errataTo = _prefix "errataTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsFor"></see>
    /// </summary>
    let illustrationsFor = _prefix "illustrationsFor"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexTo"></see>
    /// </summary>
    let indexTo = _prefix "indexTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideTo"></see>
    /// </summary>
    let guideTo = _prefix "guideTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOfExpression"></see>
    /// </summary>
    let catalogueOfExpression = _prefix "catalogueOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsForExpression"></see>
    /// </summary>
    let illustrationsForExpression = _prefix "illustrationsForExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideToExpression"></see>
    /// </summary>
    let guideToExpression = _prefix "guideToExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexToExpression"></see>
    /// </summary>
    let indexToExpression = _prefix "indexToExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementToExpression"></see>
    /// </summary>
    let supplementToExpression = _prefix "supplementToExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataToExpression"></see>
    /// </summary>
    let errataToExpression = _prefix "errataToExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceToExpression"></see>
    /// </summary>
    let concordanceToExpression = _prefix "concordanceToExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidForExpression"></see>
    /// </summary>
    let findingAidForExpression = _prefix "findingAidForExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidForWork"></see>
    /// </summary>
    let findingAidForWork = _prefix "findingAidForWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceToWork"></see>
    /// </summary>
    let concordanceToWork = _prefix "concordanceToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsForWork"></see>
    /// </summary>
    let illustrationsForWork = _prefix "illustrationsForWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexToWork"></see>
    /// </summary>
    let indexToWork = _prefix "indexToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataToWork"></see>
    /// </summary>
    let errataToWork = _prefix "errataToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOfWork"></see>
    /// </summary>
    let catalogueOfWork = _prefix "catalogueOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementToWork"></see>
    /// </summary>
    let supplementToWork = _prefix "supplementToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideToWork"></see>
    /// </summary>
    let guideToWork = _prefix "guideToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplement"></see>
    /// </summary>
    let supplement = _prefix "supplement"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guide"></see>
    /// </summary>
    let guide = _prefix "guide"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errata"></see>
    /// </summary>
    let errata = _prefix "errata"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/index"></see>
    /// </summary>
    let index = _prefix "index"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordance"></see>
    /// </summary>
    let concordance = _prefix "concordance"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogue"></see>
    /// </summary>
    let catalogue = _prefix "catalogue"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAid"></see>
    /// </summary>
    let findingAid = _prefix "findingAid"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrations"></see>
    /// </summary>
    let illustrations = _prefix "illustrations"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementExpression"></see>
    /// </summary>
    let supplementExpression = _prefix "supplementExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidExpression"></see>
    /// </summary>
    let findingAidExpression = _prefix "findingAidExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexExpression"></see>
    /// </summary>
    let indexExpression = _prefix "indexExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataExpression"></see>
    /// </summary>
    let errataExpression = _prefix "errataExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideExpression"></see>
    /// </summary>
    let guideExpression = _prefix "guideExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsExpression"></see>
    /// </summary>
    let illustrationsExpression = _prefix "illustrationsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceExpression"></see>
    /// </summary>
    let concordanceExpression = _prefix "concordanceExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueExpression"></see>
    /// </summary>
    let catalogueExpression = _prefix "catalogueExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidWork"></see>
    /// </summary>
    let findingAidWork = _prefix "findingAidWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueWork"></see>
    /// </summary>
    let catalogueWork = _prefix "catalogueWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsWork"></see>
    /// </summary>
    let illustrationsWork = _prefix "illustrationsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideWork"></see>
    /// </summary>
    let guideWork = _prefix "guideWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceWork"></see>
    /// </summary>
    let concordanceWork = _prefix "concordanceWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexWork"></see>
    /// </summary>
    let indexWork = _prefix "indexWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataWork"></see>
    /// </summary>
    let errataWork = _prefix "errataWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementWork"></see>
    /// </summary>
    let supplementWork = _prefix "supplementWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOn"></see>
    /// </summary>
    let librettoBasedOn = _prefix "librettoBasedOn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryOf"></see>
    /// </summary>
    let summaryOf = _prefix "summaryOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOf"></see>
    /// </summary>
    let freeTranslationOf = _prefix "freeTranslationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOf"></see>
    /// </summary>
    let expandedVersionOf = _prefix "expandedVersionOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remakeOf"></see>
    /// </summary>
    let remakeOf = _prefix "remakeOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitationOf"></see>
    /// </summary>
    let imitationOf = _prefix "imitationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexingFor"></see>
    /// </summary>
    let indexingFor = _prefix "indexingFor"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestOf"></see>
    /// </summary>
    let digestOf = _prefix "digestOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOf"></see>
    /// </summary>
    let paraphraseOf = _prefix "paraphraseOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyFor"></see>
    /// </summary>
    let choreographyFor = _prefix "choreographyFor"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOn"></see>
    /// </summary>
    let musicalVariationsBasedOn = _prefix "musicalVariationsBasedOn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOf"></see>
    /// </summary>
    let musicalSettingOf = _prefix "musicalSettingOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/translationOf"></see>
    /// </summary>
    let translationOf = _prefix "translationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/revisionOf"></see>
    /// </summary>
    let revisionOf = _prefix "revisionOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOf"></see>
    /// </summary>
    let musicalArrangementOf = _prefix "musicalArrangementOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/translationOfExpression"></see>
    /// </summary>
    let translationOfExpression = _prefix "translationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOfExpression"></see>
    /// </summary>
    let musicalArrangementOfExpression = _prefix "musicalArrangementOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestOfExpression"></see>
    /// </summary>
    let digestOfExpression = _prefix "digestOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfExpression"></see>
    /// </summary>
    let freeTranslationOfExpression = _prefix "freeTranslationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/revisionOfExpression"></see>
    /// </summary>
    let revisionOfExpression = _prefix "revisionOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnExpression"></see>
    /// </summary>
    let librettoBasedOnExpression = _prefix "librettoBasedOnExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitationOfExpression"></see>
    /// </summary>
    let imitationOfExpression = _prefix "imitationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfExpression"></see>
    /// </summary>
    let musicalSettingOfExpression = _prefix "musicalSettingOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryOfExpression"></see>
    /// </summary>
    let summaryOfExpression = _prefix "summaryOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyForExpression"></see>
    /// </summary>
    let choreographyForExpression = _prefix "choreographyForExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfExpression"></see>
    /// </summary>
    let paraphraseOfExpression = _prefix "paraphraseOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexingForExpression"></see>
    /// </summary>
    let indexingForExpression = _prefix "indexingForExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnExpression"></see>
    /// </summary>
    let musicalVariationsBasedOnExpression =
        _prefix "musicalVariationsBasedOnExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remakeOfExpression"></see>
    /// </summary>
    let remakeOfExpression = _prefix "remakeOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfExpression"></see>
    /// </summary>
    let expandedVersionOfExpression = _prefix "expandedVersionOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitationOfWork"></see>
    /// </summary>
    let imitationOfWork = _prefix "imitationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnWork"></see>
    /// </summary>
    let musicalVariationsBasedOnWork = _prefix "musicalVariationsBasedOnWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfWork"></see>
    /// </summary>
    let paraphraseOfWork = _prefix "paraphraseOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnWork"></see>
    /// </summary>
    let televisionScreenplayBasedOnWork = _prefix "televisionScreenplayBasedOnWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remakeOfWork"></see>
    /// </summary>
    let remakeOfWork = _prefix "remakeOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfWork"></see>
    /// </summary>
    let expandedVersionOfWork = _prefix "expandedVersionOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfWork"></see>
    /// </summary>
    let freeTranslationOfWork = _prefix "freeTranslationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestOfWork"></see>
    /// </summary>
    let digestOfWork = _prefix "digestOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnWork"></see>
    /// </summary>
    let librettoBasedOnWork = _prefix "librettoBasedOnWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexingForWork"></see>
    /// </summary>
    let indexingForWork = _prefix "indexingForWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfWork"></see>
    /// </summary>
    let musicalSettingOfWork = _prefix "musicalSettingOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryOfWork"></see>
    /// </summary>
    let summaryOfWork = _prefix "summaryOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyForWork"></see>
    /// </summary>
    let choreographyForWork = _prefix "choreographyForWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipWork"></see>
    /// </summary>
    let derivativeRelationshipWork = _prefix "derivativeRelationshipWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basisForLibrettoExpression"></see>
    /// </summary>
    let basisForLibrettoExpression = _prefix "basisForLibrettoExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenza"></see>
    /// </summary>
    let cadenza = _prefix "cadenza"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaExpression"></see>
    /// </summary>
    let cadenzaExpression = _prefix "cadenzaExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaWork"></see>
    /// </summary>
    let cadenzaWork = _prefix "cadenzaWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/complementedBy"></see>
    /// </summary>
    let complementedBy = _prefix "complementedBy"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedFor"></see>
    /// </summary>
    let cadenzaComposedFor = _prefix "cadenzaComposedFor"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForExpression"></see>
    /// </summary>
    let cadenzaComposedForExpression = _prefix "cadenzaComposedForExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForWork"></see>
    /// </summary>
    let cadenzaComposedForWork = _prefix "cadenzaComposedForWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreography"></see>
    /// </summary>
    let choreography = _prefix "choreography"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyExpression"></see>
    /// </summary>
    let choreographyExpression = _prefix "choreographyExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyWork"></see>
    /// </summary>
    let choreographyWork = _prefix "choreographyWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryIn"></see>
    /// </summary>
    let commentaryIn = _prefix "commentaryIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryInExpression"></see>
    /// </summary>
    let commentaryInExpression = _prefix "commentaryInExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryInWork"></see>
    /// </summary>
    let commentaryInWork = _prefix "commentaryInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOn"></see>
    /// </summary>
    let commentaryOn = _prefix "commentaryOn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnWork"></see>
    /// </summary>
    let commentaryOnWork = _prefix "commentaryOnWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnExpression"></see>
    /// </summary>
    let commentaryOnExpression = _prefix "commentaryOnExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnItem"></see>
    /// </summary>
    let commentaryOnItem = _prefix "commentaryOnItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnManifestation"></see>
    /// </summary>
    let commentaryOnManifestation = _prefix "commentaryOnManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgramme"></see>
    /// </summary>
    let scriptForTheRadioProgramme = _prefix "scriptForTheRadioProgramme"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplay"></see>
    /// </summary>
    let motionPictureScreenplay = _prefix "motionPictureScreenplay"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayFor"></see>
    /// </summary>
    let screenplayFor = _prefix "screenplayFor"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoFor"></see>
    /// </summary>
    let librettoFor = _prefix "librettoFor"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplay"></see>
    /// </summary>
    let screenplay = _prefix "screenplay"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScript"></see>
    /// </summary>
    let radioScript = _prefix "radioScript"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/libretto"></see>
    /// </summary>
    let libretto = _prefix "libretto"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForExpression"></see>
    /// </summary>
    let screenplayForExpression = _prefix "screenplayForExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoExpression"></see>
    /// </summary>
    let librettoExpression = _prefix "librettoExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeExpression"></see>
    /// </summary>
    let scriptForTheRadioProgrammeExpression =
        _prefix "scriptForTheRadioProgrammeExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayExpression"></see>
    /// </summary>
    let motionPictureScreenplayExpression = _prefix "motionPictureScreenplayExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptExpression"></see>
    /// </summary>
    let radioScriptExpression = _prefix "radioScriptExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayExpression"></see>
    /// </summary>
    let screenplayExpression = _prefix "screenplayExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForWork"></see>
    /// </summary>
    let screenplayForWork = _prefix "screenplayForWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedIn"></see>
    /// </summary>
    let containedIn = _prefix "containedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedInManifestation"></see>
    /// </summary>
    let containedInManifestation = _prefix "containedInManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedInItem"></see>
    /// </summary>
    let containedInItem = _prefix "containedInItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/insertedIn"></see>
    /// </summary>
    let insertedIn = _prefix "insertedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/inSeries"></see>
    /// </summary>
    let inSeries = _prefix "inSeries"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedInWork"></see>
    /// </summary>
    let containedInWork = _prefix "containedInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/subseriesOf"></see>
    /// </summary>
    let subseriesOf = _prefix "subseriesOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedInExpression"></see>
    /// </summary>
    let containedInExpression = _prefix "containedInExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueOf"></see>
    /// </summary>
    let specialIssueOf = _prefix "specialIssueOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationship"></see>
    /// </summary>
    let wholePartRelationship = _prefix "wholePartRelationship"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipExpression"></see>
    /// </summary>
    let wholePartRelationshipExpression = _prefix "wholePartRelationshipExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipItem"></see>
    /// </summary>
    let wholePartRelationshipItem = _prefix "wholePartRelationshipItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/insertedInManifestation"></see>
    /// </summary>
    let insertedInManifestation = _prefix "insertedInManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueOfManifestation"></see>
    /// </summary>
    let specialIssueOfManifestation = _prefix "specialIssueOfManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipManifestation"></see>
    /// </summary>
    let wholePartRelationshipManifestation =
        _prefix "wholePartRelationshipManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/inSeriesWork"></see>
    /// </summary>
    let inSeriesWork = _prefix "inSeriesWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/subseriesOfWork"></see>
    /// </summary>
    let subseriesOfWork = _prefix "subseriesOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoForWork"></see>
    /// </summary>
    let librettoForWork = _prefix "librettoForWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipWork"></see>
    /// </summary>
    let wholePartRelationshipWork = _prefix "wholePartRelationshipWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/seriesContains"></see>
    /// </summary>
    let seriesContains = _prefix "seriesContains"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containsExpression"></see>
    /// </summary>
    let containsExpression = _prefix "containsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/subseries"></see>
    /// </summary>
    let subseries = _prefix "subseries"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containsManifestation"></see>
    /// </summary>
    let containsManifestation = _prefix "containsManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/insert"></see>
    /// </summary>
    let insert = _prefix "insert"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/specialIssue"></see>
    /// </summary>
    let specialIssue = _prefix "specialIssue"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containsItem"></see>
    /// </summary>
    let containsItem = _prefix "containsItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containsWork"></see>
    /// </summary>
    let containsWork = _prefix "containsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueManifestation"></see>
    /// </summary>
    let specialIssueManifestation = _prefix "specialIssueManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/insertManifestation"></see>
    /// </summary>
    let insertManifestation = _prefix "insertManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/subseriesWork"></see>
    /// </summary>
    let subseriesWork = _prefix "subseriesWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/seriesContainsWork"></see>
    /// </summary>
    let seriesContainsWork = _prefix "seriesContainsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoWork"></see>
    /// </summary>
    let librettoWork = _prefix "librettoWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedBy"></see>
    /// </summary>
    let continuedBy = _prefix "continuedBy"
    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedByExpression"></see></summary>
    let continuedByExpression = _prefix "continuedByExpression"
    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedByWork"></see></summary>
    let continuedByWork = _prefix "continuedByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartBy"></see>
    /// </summary>
    let continuedInPartBy = _prefix "continuedInPartBy"
    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByExpression"></see></summary>
    let continuedInPartByExpression = _prefix "continuedInPartByExpression"
    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByWork"></see></summary>
    let continuedInPartByWork = _prefix "continuedInPartByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/continues"></see>
    /// </summary>
    let continues = _prefix "continues"
    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesExpression"></see></summary>
    let continuesExpression = _prefix "continuesExpression"
    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesWork"></see></summary>
    let continuesWork = _prefix "continuesWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPart"></see>
    /// </summary>
    let continuesInPart = _prefix "continuesInPart"
    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPartExpression"></see></summary>
    let continuesInPartExpression = _prefix "continuesInPartExpression"
    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPartWork"></see></summary>
    let continuesInPartWork = _prefix "continuesInPartWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOf"></see>
    /// </summary>
    let critiqueOf = _prefix "critiqueOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfItem"></see>
    /// </summary>
    let critiqueOfItem = _prefix "critiqueOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfExpression"></see>
    /// </summary>
    let critiqueOfExpression = _prefix "critiqueOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfWork"></see>
    /// </summary>
    let critiqueOfWork = _prefix "critiqueOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfManifestation"></see>
    /// </summary>
    let critiqueOfManifestation = _prefix "critiqueOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiquedIn"></see>
    /// </summary>
    let critiquedIn = _prefix "critiquedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiquedInExpression"></see>
    /// </summary>
    let critiquedInExpression = _prefix "critiquedInExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiquedInWork"></see>
    /// </summary>
    let critiquedInWork = _prefix "critiquedInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationship"></see>
    /// </summary>
    let derivativeRelationship = _prefix "derivativeRelationship"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexedIn"></see>
    /// </summary>
    let indexedIn = _prefix "indexedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remadeAs"></see>
    /// </summary>
    let remadeAs = _prefix "remadeAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digest"></see>
    /// </summary>
    let digest = _prefix "digest"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipExpression"></see>
    /// </summary>
    let derivativeRelationshipExpression = _prefix "derivativeRelationshipExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAs"></see>
    /// </summary>
    let paraphrasedAs = _prefix "paraphrasedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAs"></see>
    /// </summary>
    let freelyTranslatedAs = _prefix "freelyTranslatedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/translatedAs"></see>
    /// </summary>
    let translatedAs = _prefix "translatedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summary"></see>
    /// </summary>
    let summary = _prefix "summary"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAs"></see>
    /// </summary>
    let imitatedAs = _prefix "imitatedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangement"></see>
    /// </summary>
    let musicalArrangement = _prefix "musicalArrangement"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSetting"></see>
    /// </summary>
    let musicalSetting = _prefix "musicalSetting"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imusicalVariations"></see>
    /// </summary>
    let imusicalVariations = _prefix "imusicalVariations"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementExpression"></see>
    /// </summary>
    let musicalArrangementExpression = _prefix "musicalArrangementExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingExpression"></see>
    /// </summary>
    let musicalSettingExpression = _prefix "musicalSettingExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAsExpression"></see>
    /// </summary>
    let imitatedAsExpression = _prefix "imitatedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexedInExpression"></see>
    /// </summary>
    let indexedInExpression = _prefix "indexedInExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/translatedAsExpression"></see>
    /// </summary>
    let translatedAsExpression = _prefix "translatedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remadeAsExpression"></see>
    /// </summary>
    let remadeAsExpression = _prefix "remadeAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedAsExpression"></see>
    /// </summary>
    let expandedAsExpression = _prefix "expandedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestExpression"></see>
    /// </summary>
    let digestExpression = _prefix "digestExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsExpression"></see>
    /// </summary>
    let paraphrasedAsExpression = _prefix "paraphrasedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsExpression"></see>
    /// </summary>
    let musicalVariationsExpression = _prefix "musicalVariationsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsExpression"></see>
    /// </summary>
    let freelyTranslatedAsExpression = _prefix "freelyTranslatedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryExpression"></see>
    /// </summary>
    let summaryExpression = _prefix "summaryExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryWork"></see>
    /// </summary>
    let summaryWork = _prefix "summaryWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAsWork"></see>
    /// </summary>
    let imitatedAsWork = _prefix "imitatedAsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsWork"></see>
    /// </summary>
    let musicalVariationsWork = _prefix "musicalVariationsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsWork"></see>
    /// </summary>
    let paraphrasedAsWork = _prefix "paraphrasedAsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestWork"></see>
    /// </summary>
    let digestWork = _prefix "digestWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexedInWork"></see>
    /// </summary>
    let indexedInWork = _prefix "indexedInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remadeAsWork"></see>
    /// </summary>
    let remadeAsWork = _prefix "remadeAsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsWork"></see>
    /// </summary>
    let freelyTranslatedAsWork = _prefix "freelyTranslatedAsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedAsWork"></see>
    /// </summary>
    let expandedAsWork = _prefix "expandedAsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingWork"></see>
    /// </summary>
    let musicalSettingWork = _prefix "musicalSettingWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewedIn"></see>
    /// </summary>
    let reviewedIn = _prefix "reviewedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedIn"></see>
    /// </summary>
    let evaluatedIn = _prefix "evaluatedIn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationships"></see>
    /// </summary>
    let descriptiveRelationships = _prefix "descriptiveRelationships"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedInExpression"></see>
    /// </summary>
    let evaluatedInExpression = _prefix "evaluatedInExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewedInExpression"></see>
    /// </summary>
    let reviewedInExpression = _prefix "reviewedInExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsExpression"></see>
    /// </summary>
    let descriptiveRelationshipsExpression =
        _prefix "descriptiveRelationshipsExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewedInWork"></see>
    /// </summary>
    let reviewedInWork = _prefix "reviewedInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedInWork"></see>
    /// </summary>
    let evaluatedInWork = _prefix "evaluatedInWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsWork"></see>
    /// </summary>
    let descriptiveRelationshipsWork = _prefix "descriptiveRelationshipsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOf"></see>
    /// </summary>
    let evaluationOf = _prefix "evaluationOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOf"></see>
    /// </summary>
    let reviewOf = _prefix "reviewOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfExpression"></see>
    /// </summary>
    let reviewOfExpression = _prefix "reviewOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfExpression"></see>
    /// </summary>
    let evaluationOfExpression = _prefix "evaluationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfItem"></see>
    /// </summary>
    let evaluationOfItem = _prefix "evaluationOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfItem"></see>
    /// </summary>
    let reviewOfItem = _prefix "reviewOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsItem"></see>
    /// </summary>
    let descriptiveRelationshipsItem = _prefix "descriptiveRelationshipsItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfManifestation"></see>
    /// </summary>
    let evaluationOfManifestation = _prefix "evaluationOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfManifestation"></see>
    /// </summary>
    let reviewOfManifestation = _prefix "reviewOfManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsManifestation"></see>
    /// </summary>
    let descriptiveRelationshipsManifestation =
        _prefix "descriptiveRelationshipsManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfWork"></see>
    /// </summary>
    let reviewOfWork = _prefix "reviewOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfWork"></see>
    /// </summary>
    let evaluationOfWork = _prefix "evaluationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationships"></see>
    /// </summary>
    let derivativeRelationships = _prefix "derivativeRelationships"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransfer"></see>
    /// </summary>
    let digitalTransfer = _prefix "digitalTransfer"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferManifestation"></see>
    /// </summary>
    let digitalTransferManifestation = _prefix "digitalTransferManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproducedAs"></see>
    /// </summary>
    let reproducedAs = _prefix "reproducedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproducedAsManifestation"></see>
    /// </summary>
    let reproducedAsManifestation = _prefix "reproducedAsManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOf"></see>
    /// </summary>
    let digitalTransferOf = _prefix "digitalTransferOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfItem"></see>
    /// </summary>
    let digitalTransferOfItem = _prefix "digitalTransferOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfManifestation"></see>
    /// </summary>
    let digitalTransferOfManifestation = _prefix "digitalTransferOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOf"></see>
    /// </summary>
    let reproductionOf = _prefix "reproductionOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOfItem"></see>
    /// </summary>
    let reproductionOfItem = _prefix "reproductionOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOfManifestation"></see>
    /// </summary>
    let reproductionOfManifestation = _prefix "reproductionOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfExpression"></see>
    /// </summary>
    let dramatizationOfExpression = _prefix "dramatizationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproduction"></see>
    /// </summary>
    let electronicReproduction = _prefix "electronicReproduction"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionManifestation"></see>
    /// </summary>
    let electronicReproductionManifestation =
        _prefix "electronicReproductionManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOf"></see>
    /// </summary>
    let electronicReproductionOf = _prefix "electronicReproductionOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfItem"></see>
    /// </summary>
    let electronicReproductionOfItem = _prefix "electronicReproductionOfItem"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfManifestation"></see>
    /// </summary>
    let electronicReproductionOfManifestation =
        _prefix "electronicReproductionOfManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationships"></see>
    /// </summary>
    let equivalenceRelationships = _prefix "equivalenceRelationships"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsManifestation"></see>
    /// </summary>
    let equivalenceRelationshipsManifestation =
        _prefix "equivalenceRelationshipsManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mirrorSite"></see>
    /// </summary>
    let mirrorSite = _prefix "mirrorSite"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsItem"></see>
    /// </summary>
    let equivalenceRelationshipsItem = _prefix "equivalenceRelationshipsItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mirrorSiteManifestation"></see>
    /// </summary>
    let mirrorSiteManifestation = _prefix "mirrorSiteManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/exemplarOfManifestation"></see>
    /// </summary>
    let exemplarOfManifestation = _prefix "exemplarOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedAs"></see>
    /// </summary>
    let expandedAs = _prefix "expandedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expressionManifested"></see>
    /// </summary>
    let expressionManifested = _prefix "expressionManifested"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expressionOfWork"></see>
    /// </summary>
    let expressionOfWork = _prefix "expressionOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimile"></see>
    /// </summary>
    let facsimile = _prefix "facsimile"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimile"></see>
    /// </summary>
    let preservationFacsimile = _prefix "preservationFacsimile"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimileManifestation"></see>
    /// </summary>
    let facsimileManifestation = _prefix "facsimileManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileManifestation"></see>
    /// </summary>
    let preservationFacsimileManifestation =
        _prefix "preservationFacsimileManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOf"></see>
    /// </summary>
    let facsimileOf = _prefix "facsimileOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOf"></see>
    /// </summary>
    let preservationFacsimileOf = _prefix "preservationFacsimileOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOfItem"></see>
    /// </summary>
    let facsimileOfItem = _prefix "facsimileOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOfManifestation"></see>
    /// </summary>
    let facsimileOfManifestation = _prefix "facsimileOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfItem"></see>
    /// </summary>
    let preservationFacsimileOfItem = _prefix "preservationFacsimileOfItem"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfManifestation"></see>
    /// </summary>
    let preservationFacsimileOfManifestation =
        _prefix "preservationFacsimileOfManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/filmedWithManifestation"></see>
    /// </summary>
    let filmedWithManifestation = _prefix "filmedWithManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAs"></see>
    /// </summary>
    let parodiedAs = _prefix "parodiedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAsExpression"></see>
    /// </summary>
    let parodiedAsExpression = _prefix "parodiedAsExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAsWork"></see>
    /// </summary>
    let parodiedAsWork = _prefix "parodiedAsWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodyOf"></see>
    /// </summary>
    let parodyOf = _prefix "parodyOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodyOfExpression"></see>
    /// </summary>
    let parodyOfExpression = _prefix "parodyOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodyOfWork"></see>
    /// </summary>
    let parodyOfWork = _prefix "parodyOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWithManifestation"></see>
    /// </summary>
    let onDiscWithManifestation = _prefix "onDiscWithManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoForExpression"></see>
    /// </summary>
    let librettoForExpression = _prefix "librettoForExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/manifestationExemplified"></see>
    /// </summary>
    let manifestationExemplified = _prefix "manifestationExemplified"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/manifestationOfWork"></see>
    /// </summary>
    let manifestationOfWork = _prefix "manifestationOfWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToForm"></see>
    /// </summary>
    let mergedWithToForm = _prefix "mergedWithToForm"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormExpression"></see>
    /// </summary>
    let mergedWithToFormExpression = _prefix "mergedWithToFormExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormWork"></see>
    /// </summary>
    let mergedWithToFormWork = _prefix "mergedWithToFormWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergerOf"></see>
    /// </summary>
    let mergerOf = _prefix "mergerOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergerOfExpression"></see>
    /// </summary>
    let mergerOfExpression = _prefix "mergerOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergerOfWork"></see>
    /// </summary>
    let mergerOfWork = _prefix "mergerOfWork"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfExpression"></see>
    /// </summary>
    let motionPictureAdaptationOfExpression =
        _prefix "motionPictureAdaptationOfExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOn"></see>
    /// </summary>
    let motionPictureScreenplayBasedOn = _prefix "motionPictureScreenplayBasedOn"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnExpression"></see>
    /// </summary>
    let motionPictureScreenplayBasedOnExpression =
        _prefix "motionPictureScreenplayBasedOnExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnWork"></see>
    /// </summary>
    let motionPictureScreenplayBasedOnWork =
        _prefix "motionPictureScreenplayBasedOnWork"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOfExpression"></see>
    /// </summary>
    let novelizationOfExpression = _prefix "novelizationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/numberingOfPart"></see>
    /// </summary>
    let numberingOfPart = _prefix "numberingOfPart"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/numberingOfPartWork"></see>
    /// </summary>
    let numberingOfPartWork = _prefix "numberingOfPartWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/relatedWork"></see>
    /// </summary>
    let relatedWork = _prefix "relatedWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedes"></see>
    /// </summary>
    let supersedes = _prefix "supersedes"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/separatedFrom"></see>
    /// </summary>
    let separatedFrom = _prefix "separatedFrom"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequelTo"></see>
    /// </summary>
    let sequelTo = _prefix "sequelTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/prequel"></see>
    /// </summary>
    let prequel = _prefix "prequel"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPart"></see>
    /// </summary>
    let supersedesInPart = _prefix "supersedesInPart"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationship"></see>
    /// </summary>
    let sequentialRelationship = _prefix "sequentialRelationship"
    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartExpression"></see></summary>
    let supersedesInPartExpression = _prefix "supersedesInPartExpression"
    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesExpression"></see></summary>
    let supersedesExpression = _prefix "supersedesExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/separatedFromExpression"></see>
    /// </summary>
    let separatedFromExpression = _prefix "separatedFromExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipExpression"></see>
    /// </summary>
    let sequentialRelationshipExpression = _prefix "sequentialRelationshipExpression"
    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartWork"></see></summary>
    let supersedesInPartWork = _prefix "supersedesInPartWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/prequelWork"></see>
    /// </summary>
    let prequelWork = _prefix "prequelWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/separatedFromWork"></see>
    /// </summary>
    let separatedFromWork = _prefix "separatedFromWork"
    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesWork"></see></summary>
    let supersedesWork = _prefix "supersedesWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequelToWork"></see>
    /// </summary>
    let sequelToWork = _prefix "sequelToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipWork"></see>
    /// </summary>
    let sequentialRelationshipWork = _prefix "sequentialRelationshipWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/prequelTo"></see>
    /// </summary>
    let prequelTo = _prefix "prequelTo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/prequelToWork"></see>
    /// </summary>
    let prequelToWork = _prefix "prequelToWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintOf"></see>
    /// </summary>
    let reprintOf = _prefix "reprintOf"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintOfItem"></see>
    /// </summary>
    let reprintOfItem = _prefix "reprintOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintOfManifestation"></see>
    /// </summary>
    let reprintOfManifestation = _prefix "reprintOfManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintedAs"></see>
    /// </summary>
    let reprintedAs = _prefix "reprintedAs"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintedAsManifestation"></see>
    /// </summary>
    let reprintedAsManifestation = _prefix "reprintedAsManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalentItem"></see>
    /// </summary>
    let equivalentItem = _prefix "equivalentItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplay"></see>
    /// </summary>
    let televisionScreenplay = _prefix "televisionScreenplay"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplay"></see>
    /// </summary>
    let videoScreenplay = _prefix "videoScreenplay"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOn"></see>
    /// </summary>
    let videoScreenplayBasedOn = _prefix "videoScreenplayBasedOn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOn"></see>
    /// </summary>
    let televisionScreenplayBasedOn = _prefix "televisionScreenplayBasedOn"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnExpression"></see>
    /// </summary>
    let videoScreenplayBasedOnExpression = _prefix "videoScreenplayBasedOnExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnExpression"></see>
    /// </summary>
    let televisionScreenplayBasedOnExpression =
        _prefix "televisionScreenplayBasedOnExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnWork"></see>
    /// </summary>
    let videoScreenplayBasedOnWork = _prefix "videoScreenplayBasedOnWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayExpression"></see>
    /// </summary>
    let televisionScreenplayExpression = _prefix "televisionScreenplayExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayExpression"></see>
    /// </summary>
    let videoScreenplayExpression = _prefix "videoScreenplayExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgramme"></see>
    /// </summary>
    let screenplayForTheTelevisionProgramme =
        _prefix "screenplayForTheTelevisionProgramme"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideo"></see>
    /// </summary>
    let screenplayForTheVideo = _prefix "screenplayForTheVideo"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPicture"></see>
    /// </summary>
    let screenplayForTheMotionPicture = _prefix "screenplayForTheMotionPicture"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeExpression"></see>
    /// </summary>
    let screenplayForTheTelevisionProgrammeExpression =
        _prefix "screenplayForTheTelevisionProgrammeExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoExpression"></see>
    /// </summary>
    let screenplayForTheVideoExpression = _prefix "screenplayForTheVideoExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureExpression"></see>
    /// </summary>
    let screenplayForTheMotionPictureExpression =
        _prefix "screenplayForTheMotionPictureExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequel"></see>
    /// </summary>
    let sequel = _prefix "sequel"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequelWork"></see>
    /// </summary>
    let sequelWork = _prefix "sequelWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipItem"></see>
    /// </summary>
    let sequentialRelationshipItem = _prefix "sequentialRelationshipItem"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipManifestation"></see>
    /// </summary>
    let sequentialRelationshipManifestation =
        _prefix "sequentialRelationshipManifestation"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/splitInto"></see>
    /// </summary>
    let splitInto = _prefix "splitInto"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/splitIntoExpression"></see>
    /// </summary>
    let splitIntoExpression = _prefix "splitIntoExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/splitIntoWork"></see>
    /// </summary>
    let splitIntoWork = _prefix "splitIntoWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededBy"></see>
    /// </summary>
    let supersededBy = _prefix "supersededBy"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartBy"></see>
    /// </summary>
    let supersededInPartBy = _prefix "supersededInPartBy"
    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByExpression"></see></summary>
    let supersededInPartByExpression = _prefix "supersededInPartByExpression"
    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededByExpression"></see></summary>
    let supersededByExpression = _prefix "supersededByExpression"
    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByWork"></see></summary>
    let supersededInPartByWork = _prefix "supersededInPartByWork"
    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededByWork"></see></summary>
    let supersededByWork = _prefix "supersededByWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfExpression"></see>
    /// </summary>
    let televisionAdaptationOfExpression = _prefix "televisionAdaptationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfExpression"></see>
    /// </summary>
    let verseAdaptationOfExpression = _prefix "verseAdaptationOfExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/workManifested"></see>
    /// </summary>
    let workManifested = _prefix "workManifested"
