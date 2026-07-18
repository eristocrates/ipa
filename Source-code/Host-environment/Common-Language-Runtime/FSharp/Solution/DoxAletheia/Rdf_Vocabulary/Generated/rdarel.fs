namespace http.rdvocab.info.RDARelationshipsWEMI.slash

open DoxAletheia.Rdf_Vocabulary

module rdarel =
    let _namespace_name = "http://rdvocab.info/RDARelationshipsWEMI/"

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/BasisForLibrettoWork"></see>
    /// </summary>
    let BasisForLibrettoWork =
        Namespaced_IRI.parse _namespace_name "BasisForLibrettoWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeWork"></see>
    /// </summary>
    let derivativeWork =
        Namespaced_IRI.parse _namespace_name "derivativeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basisForLibretto"></see>
    /// </summary>
    let basisForLibretto =
        Namespaced_IRI.parse _namespace_name "basisForLibretto" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAs"></see>
    /// </summary>
    let abridgedAs = Namespaced_IRI.parse _namespace_name "abridgedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAsExpression"></see>
    /// </summary>
    let abridgedAsExpression =
        Namespaced_IRI.parse _namespace_name "abridgedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAsWork"></see>
    /// </summary>
    let abridgedAsWork =
        Namespaced_IRI.parse _namespace_name "abridgedAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeExpression"></see>
    /// </summary>
    let derivativeExpression =
        Namespaced_IRI.parse _namespace_name "derivativeExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOf"></see>
    /// </summary>
    let abridgementOf =
        Namespaced_IRI.parse _namespace_name "abridgementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOfExpression"></see>
    /// </summary>
    let abridgementOfExpression =
        Namespaced_IRI.parse _namespace_name "abridgementOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOfWork"></see>
    /// </summary>
    let abridgementOfWork =
        Namespaced_IRI.parse _namespace_name "abridgementOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basedOn"></see>
    /// </summary>
    let basedOn = Namespaced_IRI.parse _namespace_name "basedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basedOnExpression"></see>
    /// </summary>
    let basedOnExpression =
        Namespaced_IRI.parse _namespace_name "basedOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basedOnWork"></see>
    /// </summary>
    let basedOnWork =
        Namespaced_IRI.parse _namespace_name "basedOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbed"></see>
    /// </summary>
    let absorbed = Namespaced_IRI.parse _namespace_name "absorbed" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedExpression"></see>
    /// </summary>
    let absorbedExpression =
        Namespaced_IRI.parse _namespace_name "absorbedExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedWork"></see>
    /// </summary>
    let absorbedWork =
        Namespaced_IRI.parse _namespace_name "absorbedWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/precededBy"></see>
    /// </summary>
    let precededBy = Namespaced_IRI.parse _namespace_name "precededBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedBy"></see>
    /// </summary>
    let absorbedBy = Namespaced_IRI.parse _namespace_name "absorbedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedByExpression"></see>
    /// </summary>
    let absorbedByExpression =
        Namespaced_IRI.parse _namespace_name "absorbedByExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedByWork"></see>
    /// </summary>
    let absorbedByWork =
        Namespaced_IRI.parse _namespace_name "absorbedByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/succeededBy"></see>
    /// </summary>
    let succeededBy =
        Namespaced_IRI.parse _namespace_name "succeededBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/succeededByExpression"></see>
    /// </summary>
    let succeededByExpression =
        Namespaced_IRI.parse _namespace_name "succeededByExpression" |> NamespacedName

    /// <summary>
    /// For sequentially numbered works with revised content.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/succeededByWork"></see></summary>
    let succeededByWork =
        Namespaced_IRI.parse _namespace_name "succeededByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/precededByExpression"></see>
    /// </summary>
    let precededByExpression =
        Namespaced_IRI.parse _namespace_name "precededByExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPart"></see>
    /// </summary>
    let absorbedInPart =
        Namespaced_IRI.parse _namespace_name "absorbedInPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartExpression"></see>
    /// </summary>
    let absorbedInPartExpression =
        Namespaced_IRI.parse _namespace_name "absorbedInPartExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartWork"></see>
    /// </summary>
    let absorbedInPartWork =
        Namespaced_IRI.parse _namespace_name "absorbedInPartWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartBy"></see>
    /// </summary>
    let absorbedInPartBy =
        Namespaced_IRI.parse _namespace_name "absorbedInPartBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByExpression"></see>
    /// </summary>
    let absorbedInPartByExpression =
        Namespaced_IRI.parse _namespace_name "absorbedInPartByExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByWork"></see>
    /// </summary>
    let absorbedInPartByWork =
        Namespaced_IRI.parse _namespace_name "absorbedInPartByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/precededByWork"></see>
    /// </summary>
    let precededByWork =
        Namespaced_IRI.parse _namespace_name "precededByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstract"></see>
    /// </summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractExpression"></see>
    /// </summary>
    let abstractExpression =
        Namespaced_IRI.parse _namespace_name "abstractExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractWork"></see>
    /// </summary>
    let abstractWork =
        Namespaced_IRI.parse _namespace_name "abstractWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractOf"></see>
    /// </summary>
    let abstractOf = Namespaced_IRI.parse _namespace_name "abstractOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractOfExpression"></see>
    /// </summary>
    let abstractOfExpression =
        Namespaced_IRI.parse _namespace_name "abstractOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractOfWork"></see>
    /// </summary>
    let abstractOfWork =
        Namespaced_IRI.parse _namespace_name "abstractOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractedIn"></see>
    /// </summary>
    let abstractedIn =
        Namespaced_IRI.parse _namespace_name "abstractedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractedInExpression"></see>
    /// </summary>
    let abstractedInExpression =
        Namespaced_IRI.parse _namespace_name "abstractedInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractedInWork"></see>
    /// </summary>
    let abstractedInWork =
        Namespaced_IRI.parse _namespace_name "abstractedInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractsFor"></see>
    /// </summary>
    let abstractsFor =
        Namespaced_IRI.parse _namespace_name "abstractsFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractsForExpression"></see>
    /// </summary>
    let abstractsForExpression =
        Namespaced_IRI.parse _namespace_name "abstractsForExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/abstractsForWork"></see>
    /// </summary>
    let abstractsForWork =
        Namespaced_IRI.parse _namespace_name "abstractsForWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedBy"></see>
    /// </summary>
    let accompaniedBy =
        Namespaced_IRI.parse _namespace_name "accompaniedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedByManifestation"></see>
    /// </summary>
    let accompaniedByManifestation =
        Namespaced_IRI.parse _namespace_name "accompaniedByManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/boundWith"></see>
    /// </summary>
    let boundWith = Namespaced_IRI.parse _namespace_name "boundWith" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWith"></see>
    /// </summary>
    let onDiscWith = Namespaced_IRI.parse _namespace_name "onDiscWith" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/issuedWith"></see>
    /// </summary>
    let issuedWith = Namespaced_IRI.parse _namespace_name "issuedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedByItem"></see>
    /// </summary>
    let accompaniedByItem =
        Namespaced_IRI.parse _namespace_name "accompaniedByItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/filmedWith"></see>
    /// </summary>
    let filmedWith = Namespaced_IRI.parse _namespace_name "filmedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/boundWithItem"></see>
    /// </summary>
    let boundWithItem =
        Namespaced_IRI.parse _namespace_name "boundWithItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWithItem"></see>
    /// </summary>
    let onDiscWithItem =
        Namespaced_IRI.parse _namespace_name "onDiscWithItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/filmedWithItem"></see>
    /// </summary>
    let filmedWithItem =
        Namespaced_IRI.parse _namespace_name "filmedWithItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/issuedWithManifestation"></see>
    /// </summary>
    let issuedWithManifestation =
        Namespaced_IRI.parse _namespace_name "issuedWithManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompanyingExpression"></see>
    /// </summary>
    let accompanyingExpression =
        Namespaced_IRI.parse _namespace_name "accompanyingExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOfExpression"></see>
    /// </summary>
    let augmentationOfExpression =
        Namespaced_IRI.parse _namespace_name "augmentationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentedByExpression"></see>
    /// </summary>
    let augmentedByExpression =
        Namespaced_IRI.parse _namespace_name "augmentedByExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/complementedByExpression"></see>
    /// </summary>
    let complementedByExpression =
        Namespaced_IRI.parse _namespace_name "complementedByExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/accompanyingWork"></see>
    /// </summary>
    let accompanyingWork =
        Namespaced_IRI.parse _namespace_name "accompanyingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentedByWork"></see>
    /// </summary>
    let augmentedByWork =
        Namespaced_IRI.parse _namespace_name "augmentedByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/complementedByWork"></see>
    /// </summary>
    let complementedByWork =
        Namespaced_IRI.parse _namespace_name "complementedByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOf"></see>
    /// </summary>
    let adaptationOf =
        Namespaced_IRI.parse _namespace_name "adaptationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOf"></see>
    /// </summary>
    let motionPictureAdaptationOf =
        Namespaced_IRI.parse _namespace_name "motionPictureAdaptationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOf"></see>
    /// </summary>
    let radioAdaptationOf =
        Namespaced_IRI.parse _namespace_name "radioAdaptationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOn"></see>
    /// </summary>
    let radioScriptBasedOn =
        Namespaced_IRI.parse _namespace_name "radioScriptBasedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOf"></see>
    /// </summary>
    let televisionAdaptationOf =
        Namespaced_IRI.parse _namespace_name "televisionAdaptationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOf"></see>
    /// </summary>
    let videoAdaptationOf =
        Namespaced_IRI.parse _namespace_name "videoAdaptationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOn"></see>
    /// </summary>
    let screenplayBasedOn =
        Namespaced_IRI.parse _namespace_name "screenplayBasedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOf"></see>
    /// </summary>
    let novelizationOf =
        Namespaced_IRI.parse _namespace_name "novelizationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOfExpression"></see>
    /// </summary>
    let adaptationOfExpression =
        Namespaced_IRI.parse _namespace_name "adaptationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOf"></see>
    /// </summary>
    let dramatizationOf =
        Namespaced_IRI.parse _namespace_name "dramatizationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOf"></see>
    /// </summary>
    let verseAdaptationOf =
        Namespaced_IRI.parse _namespace_name "verseAdaptationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOfWork"></see>
    /// </summary>
    let adaptationOfWork =
        Namespaced_IRI.parse _namespace_name "adaptationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnExpression"></see>
    /// </summary>
    let screenplayBasedOnExpression =
        Namespaced_IRI.parse _namespace_name "screenplayBasedOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfExpression"></see>
    /// </summary>
    let videoAdaptationOfExpression =
        Namespaced_IRI.parse _namespace_name "videoAdaptationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnExpression"></see>
    /// </summary>
    let radioScriptBasedOnExpression =
        Namespaced_IRI.parse _namespace_name "radioScriptBasedOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfExpression"></see>
    /// </summary>
    let radioAdaptationOfExpression =
        Namespaced_IRI.parse _namespace_name "radioAdaptationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfWork"></see>
    /// </summary>
    let dramatizationOfWork =
        Namespaced_IRI.parse _namespace_name "dramatizationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfWork"></see>
    /// </summary>
    let videoAdaptationOfWork =
        Namespaced_IRI.parse _namespace_name "videoAdaptationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfWork"></see>
    /// </summary>
    let televisionAdaptationOfWork =
        Namespaced_IRI.parse _namespace_name "televisionAdaptationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOfWork"></see>
    /// </summary>
    let novelizationOfWork =
        Namespaced_IRI.parse _namespace_name "novelizationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnWork"></see>
    /// </summary>
    let screenplayBasedOnWork =
        Namespaced_IRI.parse _namespace_name "screenplayBasedOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfWork"></see>
    /// </summary>
    let radioAdaptationOfWork =
        Namespaced_IRI.parse _namespace_name "radioAdaptationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnWork"></see>
    /// </summary>
    let radioScriptBasedOnWork =
        Namespaced_IRI.parse _namespace_name "radioScriptBasedOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfWork"></see>
    /// </summary>
    let verseAdaptationOfWork =
        Namespaced_IRI.parse _namespace_name "verseAdaptationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfWork"></see>
    /// </summary>
    let motionPictureAdaptationOfWork =
        Namespaced_IRI.parse _namespace_name "motionPictureAdaptationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAs"></see>
    /// </summary>
    let adaptedAs = Namespaced_IRI.parse _namespace_name "adaptedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptation"></see>
    /// </summary>
    let verseAdaptation =
        Namespaced_IRI.parse _namespace_name "verseAdaptation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsWork"></see>
    /// </summary>
    let adaptedAsWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPicture"></see>
    /// </summary>
    let adaptedAsAMotionPicture =
        Namespaced_IRI.parse _namespace_name "adaptedAsAMotionPicture" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelization"></see>
    /// </summary>
    let novelization =
        Namespaced_IRI.parse _namespace_name "novelization" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideo"></see>
    /// </summary>
    let adaptedAsAVideo =
        Namespaced_IRI.parse _namespace_name "adaptedAsAVideo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplay"></see>
    /// </summary>
    let adaptedAsAScreenplay =
        Namespaced_IRI.parse _namespace_name "adaptedAsAScreenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgramme"></see>
    /// </summary>
    let adaptedAsATelevisionProgramme =
        Namespaced_IRI.parse _namespace_name "adaptedAsATelevisionProgramme" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScript"></see>
    /// </summary>
    let adaptedAsARadioScript =
        Namespaced_IRI.parse _namespace_name "adaptedAsARadioScript" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgramme"></see>
    /// </summary>
    let adaptedAsARadioProgramme =
        Namespaced_IRI.parse _namespace_name "adaptedAsARadioProgramme" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAs"></see>
    /// </summary>
    let dramatizedAs =
        Namespaced_IRI.parse _namespace_name "dramatizedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsExpression"></see>
    /// </summary>
    let adaptedAsExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureExpression"></see>
    /// </summary>
    let adaptedAsAMotionPictureExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsAMotionPictureExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureWork"></see>
    /// </summary>
    let adaptedAsAMotionPictureWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsAMotionPictureWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplay"></see>
    /// </summary>
    let adaptedAsAMotionPictureScreenplay =
        Namespaced_IRI.parse _namespace_name "adaptedAsAMotionPictureScreenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayExpression"></see>
    /// </summary>
    let adaptedAsAMotionPictureScreenplayExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsAMotionPictureScreenplayExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayWork"></see>
    /// </summary>
    let adaptedAsAMotionPictureScreenplayWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsAMotionPictureScreenplayWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayExpression"></see>
    /// </summary>
    let adaptedAsAScreenplayExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsAScreenplayExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayWork"></see>
    /// </summary>
    let adaptedAsAScreenplayWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsAScreenplayWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeExpression"></see>
    /// </summary>
    let adaptedAsARadioProgrammeExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsARadioProgrammeExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeWork"></see>
    /// </summary>
    let adaptedAsARadioProgrammeWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsARadioProgrammeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptExpression"></see>
    /// </summary>
    let adaptedAsARadioScriptExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsARadioScriptExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptWork"></see>
    /// </summary>
    let adaptedAsARadioScriptWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsARadioScriptWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplay"></see>
    /// </summary>
    let adaptedAsATelevisionScreenplay =
        Namespaced_IRI.parse _namespace_name "adaptedAsATelevisionScreenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplay"></see>
    /// </summary>
    let adaptedAsAVideoScreenplay =
        Namespaced_IRI.parse _namespace_name "adaptedAsAVideoScreenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayExpression"></see>
    /// </summary>
    let adaptedAsAVideoScreenplayExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsAVideoScreenplayExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayExpression"></see>
    /// </summary>
    let adaptedAsATelevisionScreenplayExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsATelevisionScreenplayExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayWork"></see>
    /// </summary>
    let adaptedAsAVideoScreenplayWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsAVideoScreenplayWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayWork"></see>
    /// </summary>
    let adaptedAsATelevisionScreenplayWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsATelevisionScreenplayWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeExpression"></see>
    /// </summary>
    let adaptedAsATelevisionProgrammeExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsATelevisionProgrammeExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeWork"></see>
    /// </summary>
    let adaptedAsATelevisionProgrammeWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsATelevisionProgrammeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoExpression"></see>
    /// </summary>
    let adaptedAsAVideoExpression =
        Namespaced_IRI.parse _namespace_name "adaptedAsAVideoExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoWork"></see>
    /// </summary>
    let adaptedAsAVideoWork =
        Namespaced_IRI.parse _namespace_name "adaptedAsAVideoWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationExpression"></see>
    /// </summary>
    let novelizationExpression =
        Namespaced_IRI.parse _namespace_name "novelizationExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsExpression"></see>
    /// </summary>
    let dramatizedAsExpression =
        Namespaced_IRI.parse _namespace_name "dramatizedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationExpression"></see>
    /// </summary>
    let verseAdaptationExpression =
        Namespaced_IRI.parse _namespace_name "verseAdaptationExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoWork"></see>
    /// </summary>
    let screenplayForTheVideoWork =
        Namespaced_IRI.parse _namespace_name "screenplayForTheVideoWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsWork"></see>
    /// </summary>
    let dramatizedAsWork =
        Namespaced_IRI.parse _namespace_name "dramatizedAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeWork"></see>
    /// </summary>
    let screenplayForTheTelevisionProgrammeWork =
        Namespaced_IRI.parse _namespace_name "screenplayForTheTelevisionProgrammeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureWork"></see>
    /// </summary>
    let screenplayForTheMotionPictureWork =
        Namespaced_IRI.parse _namespace_name "screenplayForTheMotionPictureWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeWork"></see>
    /// </summary>
    let scriptForTheRadioProgrammeWork =
        Namespaced_IRI.parse _namespace_name "scriptForTheRadioProgrammeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationWork"></see>
    /// </summary>
    let novelizationWork =
        Namespaced_IRI.parse _namespace_name "novelizationWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationWork"></see>
    /// </summary>
    let verseAdaptationWork =
        Namespaced_IRI.parse _namespace_name "verseAdaptationWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addenda"></see>
    /// </summary>
    let addenda = Namespaced_IRI.parse _namespace_name "addenda" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentedBy"></see>
    /// </summary>
    let augmentedBy =
        Namespaced_IRI.parse _namespace_name "augmentedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaExpression"></see>
    /// </summary>
    let addendaExpression =
        Namespaced_IRI.parse _namespace_name "addendaExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaTo"></see>
    /// </summary>
    let addendaTo = Namespaced_IRI.parse _namespace_name "addendaTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaToExpression"></see>
    /// </summary>
    let addendaToExpression =
        Namespaced_IRI.parse _namespace_name "addendaToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaToWork"></see>
    /// </summary>
    let addendaToWork =
        Namespaced_IRI.parse _namespace_name "addendaToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOf"></see>
    /// </summary>
    let augmentationOf =
        Namespaced_IRI.parse _namespace_name "augmentationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOfWork"></see>
    /// </summary>
    let augmentationOfWork =
        Namespaced_IRI.parse _namespace_name "augmentationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/addendaWork"></see>
    /// </summary>
    let addendaWork =
        Namespaced_IRI.parse _namespace_name "addendaWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAs"></see>
    /// </summary>
    let alsoIssuedAs =
        Namespaced_IRI.parse _namespace_name "alsoIssuedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAsManifestation"></see>
    /// </summary>
    let alsoIssuedAsManifestation =
        Namespaced_IRI.parse _namespace_name "alsoIssuedAsManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalentManifestation"></see>
    /// </summary>
    let equivalentManifestation =
        Namespaced_IRI.parse _namespace_name "equivalentManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysedIn"></see>
    /// </summary>
    let analysedIn = Namespaced_IRI.parse _namespace_name "analysedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysedInExpression"></see>
    /// </summary>
    let analysedInExpression =
        Namespaced_IRI.parse _namespace_name "analysedInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysedInWork"></see>
    /// </summary>
    let analysedInWork =
        Namespaced_IRI.parse _namespace_name "analysedInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/describedIn"></see>
    /// </summary>
    let describedIn =
        Namespaced_IRI.parse _namespace_name "describedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/describedInExpression"></see>
    /// </summary>
    let describedInExpression =
        Namespaced_IRI.parse _namespace_name "describedInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/describedInWork"></see>
    /// </summary>
    let describedInWork =
        Namespaced_IRI.parse _namespace_name "describedInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOf"></see>
    /// </summary>
    let analysisOf = Namespaced_IRI.parse _namespace_name "analysisOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfExpression"></see>
    /// </summary>
    let analysisOfExpression =
        Namespaced_IRI.parse _namespace_name "analysisOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfItem"></see>
    /// </summary>
    let analysisOfItem =
        Namespaced_IRI.parse _namespace_name "analysisOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfManifestation"></see>
    /// </summary>
    let analysisOfManifestation =
        Namespaced_IRI.parse _namespace_name "analysisOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfWork"></see>
    /// </summary>
    let analysisOfWork =
        Namespaced_IRI.parse _namespace_name "analysisOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOf"></see>
    /// </summary>
    let descriptionOf =
        Namespaced_IRI.parse _namespace_name "descriptionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfExpression"></see>
    /// </summary>
    let descriptionOfExpression =
        Namespaced_IRI.parse _namespace_name "descriptionOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfItem"></see>
    /// </summary>
    let descriptionOfItem =
        Namespaced_IRI.parse _namespace_name "descriptionOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfManifestation"></see>
    /// </summary>
    let descriptionOfManifestation =
        Namespaced_IRI.parse _namespace_name "descriptionOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfWork"></see>
    /// </summary>
    let descriptionOfWork =
        Namespaced_IRI.parse _namespace_name "descriptionOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendix"></see>
    /// </summary>
    let appendix = Namespaced_IRI.parse _namespace_name "appendix" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixExpression"></see>
    /// </summary>
    let appendixExpression =
        Namespaced_IRI.parse _namespace_name "appendixExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixWork"></see>
    /// </summary>
    let appendixWork =
        Namespaced_IRI.parse _namespace_name "appendixWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixTo"></see>
    /// </summary>
    let appendixTo = Namespaced_IRI.parse _namespace_name "appendixTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixToExpression"></see>
    /// </summary>
    let appendixToExpression =
        Namespaced_IRI.parse _namespace_name "appendixToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/appendixToWork"></see>
    /// </summary>
    let appendixToWork =
        Namespaced_IRI.parse _namespace_name "appendixToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOf"></see>
    /// </summary>
    let catalogueOf =
        Namespaced_IRI.parse _namespace_name "catalogueOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementTo"></see>
    /// </summary>
    let supplementTo =
        Namespaced_IRI.parse _namespace_name "supplementTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceTo"></see>
    /// </summary>
    let concordanceTo =
        Namespaced_IRI.parse _namespace_name "concordanceTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidFor"></see>
    /// </summary>
    let findingAidFor =
        Namespaced_IRI.parse _namespace_name "findingAidFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataTo"></see>
    /// </summary>
    let errataTo = Namespaced_IRI.parse _namespace_name "errataTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsFor"></see>
    /// </summary>
    let illustrationsFor =
        Namespaced_IRI.parse _namespace_name "illustrationsFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexTo"></see>
    /// </summary>
    let indexTo = Namespaced_IRI.parse _namespace_name "indexTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideTo"></see>
    /// </summary>
    let guideTo = Namespaced_IRI.parse _namespace_name "guideTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOfExpression"></see>
    /// </summary>
    let catalogueOfExpression =
        Namespaced_IRI.parse _namespace_name "catalogueOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsForExpression"></see>
    /// </summary>
    let illustrationsForExpression =
        Namespaced_IRI.parse _namespace_name "illustrationsForExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideToExpression"></see>
    /// </summary>
    let guideToExpression =
        Namespaced_IRI.parse _namespace_name "guideToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexToExpression"></see>
    /// </summary>
    let indexToExpression =
        Namespaced_IRI.parse _namespace_name "indexToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementToExpression"></see>
    /// </summary>
    let supplementToExpression =
        Namespaced_IRI.parse _namespace_name "supplementToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataToExpression"></see>
    /// </summary>
    let errataToExpression =
        Namespaced_IRI.parse _namespace_name "errataToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceToExpression"></see>
    /// </summary>
    let concordanceToExpression =
        Namespaced_IRI.parse _namespace_name "concordanceToExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidForExpression"></see>
    /// </summary>
    let findingAidForExpression =
        Namespaced_IRI.parse _namespace_name "findingAidForExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidForWork"></see>
    /// </summary>
    let findingAidForWork =
        Namespaced_IRI.parse _namespace_name "findingAidForWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceToWork"></see>
    /// </summary>
    let concordanceToWork =
        Namespaced_IRI.parse _namespace_name "concordanceToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsForWork"></see>
    /// </summary>
    let illustrationsForWork =
        Namespaced_IRI.parse _namespace_name "illustrationsForWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexToWork"></see>
    /// </summary>
    let indexToWork =
        Namespaced_IRI.parse _namespace_name "indexToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataToWork"></see>
    /// </summary>
    let errataToWork =
        Namespaced_IRI.parse _namespace_name "errataToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOfWork"></see>
    /// </summary>
    let catalogueOfWork =
        Namespaced_IRI.parse _namespace_name "catalogueOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementToWork"></see>
    /// </summary>
    let supplementToWork =
        Namespaced_IRI.parse _namespace_name "supplementToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideToWork"></see>
    /// </summary>
    let guideToWork =
        Namespaced_IRI.parse _namespace_name "guideToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplement"></see>
    /// </summary>
    let supplement = Namespaced_IRI.parse _namespace_name "supplement" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guide"></see>
    /// </summary>
    let guide = Namespaced_IRI.parse _namespace_name "guide" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errata"></see>
    /// </summary>
    let errata = Namespaced_IRI.parse _namespace_name "errata" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/index"></see>
    /// </summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordance"></see>
    /// </summary>
    let concordance =
        Namespaced_IRI.parse _namespace_name "concordance" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogue"></see>
    /// </summary>
    let catalogue = Namespaced_IRI.parse _namespace_name "catalogue" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAid"></see>
    /// </summary>
    let findingAid = Namespaced_IRI.parse _namespace_name "findingAid" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrations"></see>
    /// </summary>
    let illustrations =
        Namespaced_IRI.parse _namespace_name "illustrations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementExpression"></see>
    /// </summary>
    let supplementExpression =
        Namespaced_IRI.parse _namespace_name "supplementExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidExpression"></see>
    /// </summary>
    let findingAidExpression =
        Namespaced_IRI.parse _namespace_name "findingAidExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexExpression"></see>
    /// </summary>
    let indexExpression =
        Namespaced_IRI.parse _namespace_name "indexExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataExpression"></see>
    /// </summary>
    let errataExpression =
        Namespaced_IRI.parse _namespace_name "errataExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideExpression"></see>
    /// </summary>
    let guideExpression =
        Namespaced_IRI.parse _namespace_name "guideExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsExpression"></see>
    /// </summary>
    let illustrationsExpression =
        Namespaced_IRI.parse _namespace_name "illustrationsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceExpression"></see>
    /// </summary>
    let concordanceExpression =
        Namespaced_IRI.parse _namespace_name "concordanceExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueExpression"></see>
    /// </summary>
    let catalogueExpression =
        Namespaced_IRI.parse _namespace_name "catalogueExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/findingAidWork"></see>
    /// </summary>
    let findingAidWork =
        Namespaced_IRI.parse _namespace_name "findingAidWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/catalogueWork"></see>
    /// </summary>
    let catalogueWork =
        Namespaced_IRI.parse _namespace_name "catalogueWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsWork"></see>
    /// </summary>
    let illustrationsWork =
        Namespaced_IRI.parse _namespace_name "illustrationsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/guideWork"></see>
    /// </summary>
    let guideWork = Namespaced_IRI.parse _namespace_name "guideWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/concordanceWork"></see>
    /// </summary>
    let concordanceWork =
        Namespaced_IRI.parse _namespace_name "concordanceWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexWork"></see>
    /// </summary>
    let indexWork = Namespaced_IRI.parse _namespace_name "indexWork" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/errataWork"></see>
    /// </summary>
    let errataWork = Namespaced_IRI.parse _namespace_name "errataWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supplementWork"></see>
    /// </summary>
    let supplementWork =
        Namespaced_IRI.parse _namespace_name "supplementWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOn"></see>
    /// </summary>
    let librettoBasedOn =
        Namespaced_IRI.parse _namespace_name "librettoBasedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryOf"></see>
    /// </summary>
    let summaryOf = Namespaced_IRI.parse _namespace_name "summaryOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOf"></see>
    /// </summary>
    let freeTranslationOf =
        Namespaced_IRI.parse _namespace_name "freeTranslationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOf"></see>
    /// </summary>
    let expandedVersionOf =
        Namespaced_IRI.parse _namespace_name "expandedVersionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remakeOf"></see>
    /// </summary>
    let remakeOf = Namespaced_IRI.parse _namespace_name "remakeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitationOf"></see>
    /// </summary>
    let imitationOf =
        Namespaced_IRI.parse _namespace_name "imitationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexingFor"></see>
    /// </summary>
    let indexingFor =
        Namespaced_IRI.parse _namespace_name "indexingFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestOf"></see>
    /// </summary>
    let digestOf = Namespaced_IRI.parse _namespace_name "digestOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOf"></see>
    /// </summary>
    let paraphraseOf =
        Namespaced_IRI.parse _namespace_name "paraphraseOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyFor"></see>
    /// </summary>
    let choreographyFor =
        Namespaced_IRI.parse _namespace_name "choreographyFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOn"></see>
    /// </summary>
    let musicalVariationsBasedOn =
        Namespaced_IRI.parse _namespace_name "musicalVariationsBasedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOf"></see>
    /// </summary>
    let musicalSettingOf =
        Namespaced_IRI.parse _namespace_name "musicalSettingOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/translationOf"></see>
    /// </summary>
    let translationOf =
        Namespaced_IRI.parse _namespace_name "translationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/revisionOf"></see>
    /// </summary>
    let revisionOf = Namespaced_IRI.parse _namespace_name "revisionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOf"></see>
    /// </summary>
    let musicalArrangementOf =
        Namespaced_IRI.parse _namespace_name "musicalArrangementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/translationOfExpression"></see>
    /// </summary>
    let translationOfExpression =
        Namespaced_IRI.parse _namespace_name "translationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOfExpression"></see>
    /// </summary>
    let musicalArrangementOfExpression =
        Namespaced_IRI.parse _namespace_name "musicalArrangementOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestOfExpression"></see>
    /// </summary>
    let digestOfExpression =
        Namespaced_IRI.parse _namespace_name "digestOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfExpression"></see>
    /// </summary>
    let freeTranslationOfExpression =
        Namespaced_IRI.parse _namespace_name "freeTranslationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/revisionOfExpression"></see>
    /// </summary>
    let revisionOfExpression =
        Namespaced_IRI.parse _namespace_name "revisionOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnExpression"></see>
    /// </summary>
    let librettoBasedOnExpression =
        Namespaced_IRI.parse _namespace_name "librettoBasedOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitationOfExpression"></see>
    /// </summary>
    let imitationOfExpression =
        Namespaced_IRI.parse _namespace_name "imitationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfExpression"></see>
    /// </summary>
    let musicalSettingOfExpression =
        Namespaced_IRI.parse _namespace_name "musicalSettingOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryOfExpression"></see>
    /// </summary>
    let summaryOfExpression =
        Namespaced_IRI.parse _namespace_name "summaryOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyForExpression"></see>
    /// </summary>
    let choreographyForExpression =
        Namespaced_IRI.parse _namespace_name "choreographyForExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfExpression"></see>
    /// </summary>
    let paraphraseOfExpression =
        Namespaced_IRI.parse _namespace_name "paraphraseOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexingForExpression"></see>
    /// </summary>
    let indexingForExpression =
        Namespaced_IRI.parse _namespace_name "indexingForExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnExpression"></see>
    /// </summary>
    let musicalVariationsBasedOnExpression =
        Namespaced_IRI.parse _namespace_name "musicalVariationsBasedOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remakeOfExpression"></see>
    /// </summary>
    let remakeOfExpression =
        Namespaced_IRI.parse _namespace_name "remakeOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfExpression"></see>
    /// </summary>
    let expandedVersionOfExpression =
        Namespaced_IRI.parse _namespace_name "expandedVersionOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitationOfWork"></see>
    /// </summary>
    let imitationOfWork =
        Namespaced_IRI.parse _namespace_name "imitationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnWork"></see>
    /// </summary>
    let musicalVariationsBasedOnWork =
        Namespaced_IRI.parse _namespace_name "musicalVariationsBasedOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfWork"></see>
    /// </summary>
    let paraphraseOfWork =
        Namespaced_IRI.parse _namespace_name "paraphraseOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnWork"></see>
    /// </summary>
    let televisionScreenplayBasedOnWork =
        Namespaced_IRI.parse _namespace_name "televisionScreenplayBasedOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remakeOfWork"></see>
    /// </summary>
    let remakeOfWork =
        Namespaced_IRI.parse _namespace_name "remakeOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfWork"></see>
    /// </summary>
    let expandedVersionOfWork =
        Namespaced_IRI.parse _namespace_name "expandedVersionOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfWork"></see>
    /// </summary>
    let freeTranslationOfWork =
        Namespaced_IRI.parse _namespace_name "freeTranslationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestOfWork"></see>
    /// </summary>
    let digestOfWork =
        Namespaced_IRI.parse _namespace_name "digestOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnWork"></see>
    /// </summary>
    let librettoBasedOnWork =
        Namespaced_IRI.parse _namespace_name "librettoBasedOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexingForWork"></see>
    /// </summary>
    let indexingForWork =
        Namespaced_IRI.parse _namespace_name "indexingForWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfWork"></see>
    /// </summary>
    let musicalSettingOfWork =
        Namespaced_IRI.parse _namespace_name "musicalSettingOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryOfWork"></see>
    /// </summary>
    let summaryOfWork =
        Namespaced_IRI.parse _namespace_name "summaryOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyForWork"></see>
    /// </summary>
    let choreographyForWork =
        Namespaced_IRI.parse _namespace_name "choreographyForWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipWork"></see>
    /// </summary>
    let derivativeRelationshipWork =
        Namespaced_IRI.parse _namespace_name "derivativeRelationshipWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/basisForLibrettoExpression"></see>
    /// </summary>
    let basisForLibrettoExpression =
        Namespaced_IRI.parse _namespace_name "basisForLibrettoExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenza"></see>
    /// </summary>
    let cadenza = Namespaced_IRI.parse _namespace_name "cadenza" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaExpression"></see>
    /// </summary>
    let cadenzaExpression =
        Namespaced_IRI.parse _namespace_name "cadenzaExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaWork"></see>
    /// </summary>
    let cadenzaWork =
        Namespaced_IRI.parse _namespace_name "cadenzaWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/complementedBy"></see>
    /// </summary>
    let complementedBy =
        Namespaced_IRI.parse _namespace_name "complementedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedFor"></see>
    /// </summary>
    let cadenzaComposedFor =
        Namespaced_IRI.parse _namespace_name "cadenzaComposedFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForExpression"></see>
    /// </summary>
    let cadenzaComposedForExpression =
        Namespaced_IRI.parse _namespace_name "cadenzaComposedForExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForWork"></see>
    /// </summary>
    let cadenzaComposedForWork =
        Namespaced_IRI.parse _namespace_name "cadenzaComposedForWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreography"></see>
    /// </summary>
    let choreography =
        Namespaced_IRI.parse _namespace_name "choreography" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyExpression"></see>
    /// </summary>
    let choreographyExpression =
        Namespaced_IRI.parse _namespace_name "choreographyExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/choreographyWork"></see>
    /// </summary>
    let choreographyWork =
        Namespaced_IRI.parse _namespace_name "choreographyWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryIn"></see>
    /// </summary>
    let commentaryIn =
        Namespaced_IRI.parse _namespace_name "commentaryIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryInExpression"></see>
    /// </summary>
    let commentaryInExpression =
        Namespaced_IRI.parse _namespace_name "commentaryInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryInWork"></see>
    /// </summary>
    let commentaryInWork =
        Namespaced_IRI.parse _namespace_name "commentaryInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOn"></see>
    /// </summary>
    let commentaryOn =
        Namespaced_IRI.parse _namespace_name "commentaryOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnWork"></see>
    /// </summary>
    let commentaryOnWork =
        Namespaced_IRI.parse _namespace_name "commentaryOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnExpression"></see>
    /// </summary>
    let commentaryOnExpression =
        Namespaced_IRI.parse _namespace_name "commentaryOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnItem"></see>
    /// </summary>
    let commentaryOnItem =
        Namespaced_IRI.parse _namespace_name "commentaryOnItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnManifestation"></see>
    /// </summary>
    let commentaryOnManifestation =
        Namespaced_IRI.parse _namespace_name "commentaryOnManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgramme"></see>
    /// </summary>
    let scriptForTheRadioProgramme =
        Namespaced_IRI.parse _namespace_name "scriptForTheRadioProgramme" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplay"></see>
    /// </summary>
    let motionPictureScreenplay =
        Namespaced_IRI.parse _namespace_name "motionPictureScreenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayFor"></see>
    /// </summary>
    let screenplayFor =
        Namespaced_IRI.parse _namespace_name "screenplayFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoFor"></see>
    /// </summary>
    let librettoFor =
        Namespaced_IRI.parse _namespace_name "librettoFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplay"></see>
    /// </summary>
    let screenplay = Namespaced_IRI.parse _namespace_name "screenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScript"></see>
    /// </summary>
    let radioScript =
        Namespaced_IRI.parse _namespace_name "radioScript" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/libretto"></see>
    /// </summary>
    let libretto = Namespaced_IRI.parse _namespace_name "libretto" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForExpression"></see>
    /// </summary>
    let screenplayForExpression =
        Namespaced_IRI.parse _namespace_name "screenplayForExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoExpression"></see>
    /// </summary>
    let librettoExpression =
        Namespaced_IRI.parse _namespace_name "librettoExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeExpression"></see>
    /// </summary>
    let scriptForTheRadioProgrammeExpression =
        Namespaced_IRI.parse _namespace_name "scriptForTheRadioProgrammeExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayExpression"></see>
    /// </summary>
    let motionPictureScreenplayExpression =
        Namespaced_IRI.parse _namespace_name "motionPictureScreenplayExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptExpression"></see>
    /// </summary>
    let radioScriptExpression =
        Namespaced_IRI.parse _namespace_name "radioScriptExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayExpression"></see>
    /// </summary>
    let screenplayExpression =
        Namespaced_IRI.parse _namespace_name "screenplayExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForWork"></see>
    /// </summary>
    let screenplayForWork =
        Namespaced_IRI.parse _namespace_name "screenplayForWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedIn"></see>
    /// </summary>
    let containedIn =
        Namespaced_IRI.parse _namespace_name "containedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedInManifestation"></see>
    /// </summary>
    let containedInManifestation =
        Namespaced_IRI.parse _namespace_name "containedInManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedInItem"></see>
    /// </summary>
    let containedInItem =
        Namespaced_IRI.parse _namespace_name "containedInItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/insertedIn"></see>
    /// </summary>
    let insertedIn = Namespaced_IRI.parse _namespace_name "insertedIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/inSeries"></see>
    /// </summary>
    let inSeries = Namespaced_IRI.parse _namespace_name "inSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedInWork"></see>
    /// </summary>
    let containedInWork =
        Namespaced_IRI.parse _namespace_name "containedInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/subseriesOf"></see>
    /// </summary>
    let subseriesOf =
        Namespaced_IRI.parse _namespace_name "subseriesOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containedInExpression"></see>
    /// </summary>
    let containedInExpression =
        Namespaced_IRI.parse _namespace_name "containedInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueOf"></see>
    /// </summary>
    let specialIssueOf =
        Namespaced_IRI.parse _namespace_name "specialIssueOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationship"></see>
    /// </summary>
    let wholePartRelationship =
        Namespaced_IRI.parse _namespace_name "wholePartRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipExpression"></see>
    /// </summary>
    let wholePartRelationshipExpression =
        Namespaced_IRI.parse _namespace_name "wholePartRelationshipExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipItem"></see>
    /// </summary>
    let wholePartRelationshipItem =
        Namespaced_IRI.parse _namespace_name "wholePartRelationshipItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/insertedInManifestation"></see>
    /// </summary>
    let insertedInManifestation =
        Namespaced_IRI.parse _namespace_name "insertedInManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueOfManifestation"></see>
    /// </summary>
    let specialIssueOfManifestation =
        Namespaced_IRI.parse _namespace_name "specialIssueOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipManifestation"></see>
    /// </summary>
    let wholePartRelationshipManifestation =
        Namespaced_IRI.parse _namespace_name "wholePartRelationshipManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/inSeriesWork"></see>
    /// </summary>
    let inSeriesWork =
        Namespaced_IRI.parse _namespace_name "inSeriesWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/subseriesOfWork"></see>
    /// </summary>
    let subseriesOfWork =
        Namespaced_IRI.parse _namespace_name "subseriesOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoForWork"></see>
    /// </summary>
    let librettoForWork =
        Namespaced_IRI.parse _namespace_name "librettoForWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipWork"></see>
    /// </summary>
    let wholePartRelationshipWork =
        Namespaced_IRI.parse _namespace_name "wholePartRelationshipWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/contains"></see>
    /// </summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/seriesContains"></see>
    /// </summary>
    let seriesContains =
        Namespaced_IRI.parse _namespace_name "seriesContains" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containsExpression"></see>
    /// </summary>
    let containsExpression =
        Namespaced_IRI.parse _namespace_name "containsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/subseries"></see>
    /// </summary>
    let subseries = Namespaced_IRI.parse _namespace_name "subseries" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containsManifestation"></see>
    /// </summary>
    let containsManifestation =
        Namespaced_IRI.parse _namespace_name "containsManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/insert"></see>
    /// </summary>
    let insert = Namespaced_IRI.parse _namespace_name "insert" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/specialIssue"></see>
    /// </summary>
    let specialIssue =
        Namespaced_IRI.parse _namespace_name "specialIssue" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containsItem"></see>
    /// </summary>
    let containsItem =
        Namespaced_IRI.parse _namespace_name "containsItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/containsWork"></see>
    /// </summary>
    let containsWork =
        Namespaced_IRI.parse _namespace_name "containsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueManifestation"></see>
    /// </summary>
    let specialIssueManifestation =
        Namespaced_IRI.parse _namespace_name "specialIssueManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/insertManifestation"></see>
    /// </summary>
    let insertManifestation =
        Namespaced_IRI.parse _namespace_name "insertManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/subseriesWork"></see>
    /// </summary>
    let subseriesWork =
        Namespaced_IRI.parse _namespace_name "subseriesWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/seriesContainsWork"></see>
    /// </summary>
    let seriesContainsWork =
        Namespaced_IRI.parse _namespace_name "seriesContainsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoWork"></see>
    /// </summary>
    let librettoWork =
        Namespaced_IRI.parse _namespace_name "librettoWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedBy"></see>
    /// </summary>
    let continuedBy =
        Namespaced_IRI.parse _namespace_name "continuedBy" |> NamespacedName

    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedByExpression"></see></summary>
    let continuedByExpression =
        Namespaced_IRI.parse _namespace_name "continuedByExpression" |> NamespacedName

    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedByWork"></see></summary>
    let continuedByWork =
        Namespaced_IRI.parse _namespace_name "continuedByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartBy"></see>
    /// </summary>
    let continuedInPartBy =
        Namespaced_IRI.parse _namespace_name "continuedInPartBy" |> NamespacedName

    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByExpression"></see></summary>
    let continuedInPartByExpression =
        Namespaced_IRI.parse _namespace_name "continuedInPartByExpression" |> NamespacedName

    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByWork"></see></summary>
    let continuedInPartByWork =
        Namespaced_IRI.parse _namespace_name "continuedInPartByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/continues"></see>
    /// </summary>
    let continues = Namespaced_IRI.parse _namespace_name "continues" |> NamespacedName

    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesExpression"></see></summary>
    let continuesExpression =
        Namespaced_IRI.parse _namespace_name "continuesExpression" |> NamespacedName

    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesWork"></see></summary>
    let continuesWork =
        Namespaced_IRI.parse _namespace_name "continuesWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPart"></see>
    /// </summary>
    let continuesInPart =
        Namespaced_IRI.parse _namespace_name "continuesInPart" |> NamespacedName

    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPartExpression"></see></summary>
    let continuesInPartExpression =
        Namespaced_IRI.parse _namespace_name "continuesInPartExpression" |> NamespacedName

    /// <summary>
    /// Apply generally to serials.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPartWork"></see></summary>
    let continuesInPartWork =
        Namespaced_IRI.parse _namespace_name "continuesInPartWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOf"></see>
    /// </summary>
    let critiqueOf = Namespaced_IRI.parse _namespace_name "critiqueOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfItem"></see>
    /// </summary>
    let critiqueOfItem =
        Namespaced_IRI.parse _namespace_name "critiqueOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfExpression"></see>
    /// </summary>
    let critiqueOfExpression =
        Namespaced_IRI.parse _namespace_name "critiqueOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfWork"></see>
    /// </summary>
    let critiqueOfWork =
        Namespaced_IRI.parse _namespace_name "critiqueOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfManifestation"></see>
    /// </summary>
    let critiqueOfManifestation =
        Namespaced_IRI.parse _namespace_name "critiqueOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiquedIn"></see>
    /// </summary>
    let critiquedIn =
        Namespaced_IRI.parse _namespace_name "critiquedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiquedInExpression"></see>
    /// </summary>
    let critiquedInExpression =
        Namespaced_IRI.parse _namespace_name "critiquedInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/critiquedInWork"></see>
    /// </summary>
    let critiquedInWork =
        Namespaced_IRI.parse _namespace_name "critiquedInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationship"></see>
    /// </summary>
    let derivativeRelationship =
        Namespaced_IRI.parse _namespace_name "derivativeRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexedIn"></see>
    /// </summary>
    let indexedIn = Namespaced_IRI.parse _namespace_name "indexedIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remadeAs"></see>
    /// </summary>
    let remadeAs = Namespaced_IRI.parse _namespace_name "remadeAs" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digest"></see>
    /// </summary>
    let digest = Namespaced_IRI.parse _namespace_name "digest" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipExpression"></see>
    /// </summary>
    let derivativeRelationshipExpression =
        Namespaced_IRI.parse _namespace_name "derivativeRelationshipExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAs"></see>
    /// </summary>
    let paraphrasedAs =
        Namespaced_IRI.parse _namespace_name "paraphrasedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAs"></see>
    /// </summary>
    let freelyTranslatedAs =
        Namespaced_IRI.parse _namespace_name "freelyTranslatedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/translatedAs"></see>
    /// </summary>
    let translatedAs =
        Namespaced_IRI.parse _namespace_name "translatedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summary"></see>
    /// </summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAs"></see>
    /// </summary>
    let imitatedAs = Namespaced_IRI.parse _namespace_name "imitatedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangement"></see>
    /// </summary>
    let musicalArrangement =
        Namespaced_IRI.parse _namespace_name "musicalArrangement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSetting"></see>
    /// </summary>
    let musicalSetting =
        Namespaced_IRI.parse _namespace_name "musicalSetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imusicalVariations"></see>
    /// </summary>
    let imusicalVariations =
        Namespaced_IRI.parse _namespace_name "imusicalVariations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementExpression"></see>
    /// </summary>
    let musicalArrangementExpression =
        Namespaced_IRI.parse _namespace_name "musicalArrangementExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingExpression"></see>
    /// </summary>
    let musicalSettingExpression =
        Namespaced_IRI.parse _namespace_name "musicalSettingExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAsExpression"></see>
    /// </summary>
    let imitatedAsExpression =
        Namespaced_IRI.parse _namespace_name "imitatedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexedInExpression"></see>
    /// </summary>
    let indexedInExpression =
        Namespaced_IRI.parse _namespace_name "indexedInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/translatedAsExpression"></see>
    /// </summary>
    let translatedAsExpression =
        Namespaced_IRI.parse _namespace_name "translatedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remadeAsExpression"></see>
    /// </summary>
    let remadeAsExpression =
        Namespaced_IRI.parse _namespace_name "remadeAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedAsExpression"></see>
    /// </summary>
    let expandedAsExpression =
        Namespaced_IRI.parse _namespace_name "expandedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestExpression"></see>
    /// </summary>
    let digestExpression =
        Namespaced_IRI.parse _namespace_name "digestExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsExpression"></see>
    /// </summary>
    let paraphrasedAsExpression =
        Namespaced_IRI.parse _namespace_name "paraphrasedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsExpression"></see>
    /// </summary>
    let musicalVariationsExpression =
        Namespaced_IRI.parse _namespace_name "musicalVariationsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsExpression"></see>
    /// </summary>
    let freelyTranslatedAsExpression =
        Namespaced_IRI.parse _namespace_name "freelyTranslatedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryExpression"></see>
    /// </summary>
    let summaryExpression =
        Namespaced_IRI.parse _namespace_name "summaryExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/summaryWork"></see>
    /// </summary>
    let summaryWork =
        Namespaced_IRI.parse _namespace_name "summaryWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAsWork"></see>
    /// </summary>
    let imitatedAsWork =
        Namespaced_IRI.parse _namespace_name "imitatedAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsWork"></see>
    /// </summary>
    let musicalVariationsWork =
        Namespaced_IRI.parse _namespace_name "musicalVariationsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsWork"></see>
    /// </summary>
    let paraphrasedAsWork =
        Namespaced_IRI.parse _namespace_name "paraphrasedAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digestWork"></see>
    /// </summary>
    let digestWork = Namespaced_IRI.parse _namespace_name "digestWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/indexedInWork"></see>
    /// </summary>
    let indexedInWork =
        Namespaced_IRI.parse _namespace_name "indexedInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/remadeAsWork"></see>
    /// </summary>
    let remadeAsWork =
        Namespaced_IRI.parse _namespace_name "remadeAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsWork"></see>
    /// </summary>
    let freelyTranslatedAsWork =
        Namespaced_IRI.parse _namespace_name "freelyTranslatedAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedAsWork"></see>
    /// </summary>
    let expandedAsWork =
        Namespaced_IRI.parse _namespace_name "expandedAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingWork"></see>
    /// </summary>
    let musicalSettingWork =
        Namespaced_IRI.parse _namespace_name "musicalSettingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewedIn"></see>
    /// </summary>
    let reviewedIn = Namespaced_IRI.parse _namespace_name "reviewedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedIn"></see>
    /// </summary>
    let evaluatedIn =
        Namespaced_IRI.parse _namespace_name "evaluatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationships"></see>
    /// </summary>
    let descriptiveRelationships =
        Namespaced_IRI.parse _namespace_name "descriptiveRelationships" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedInExpression"></see>
    /// </summary>
    let evaluatedInExpression =
        Namespaced_IRI.parse _namespace_name "evaluatedInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewedInExpression"></see>
    /// </summary>
    let reviewedInExpression =
        Namespaced_IRI.parse _namespace_name "reviewedInExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsExpression"></see>
    /// </summary>
    let descriptiveRelationshipsExpression =
        Namespaced_IRI.parse _namespace_name "descriptiveRelationshipsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewedInWork"></see>
    /// </summary>
    let reviewedInWork =
        Namespaced_IRI.parse _namespace_name "reviewedInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedInWork"></see>
    /// </summary>
    let evaluatedInWork =
        Namespaced_IRI.parse _namespace_name "evaluatedInWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsWork"></see>
    /// </summary>
    let descriptiveRelationshipsWork =
        Namespaced_IRI.parse _namespace_name "descriptiveRelationshipsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOf"></see>
    /// </summary>
    let evaluationOf =
        Namespaced_IRI.parse _namespace_name "evaluationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOf"></see>
    /// </summary>
    let reviewOf = Namespaced_IRI.parse _namespace_name "reviewOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfExpression"></see>
    /// </summary>
    let reviewOfExpression =
        Namespaced_IRI.parse _namespace_name "reviewOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfExpression"></see>
    /// </summary>
    let evaluationOfExpression =
        Namespaced_IRI.parse _namespace_name "evaluationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfItem"></see>
    /// </summary>
    let evaluationOfItem =
        Namespaced_IRI.parse _namespace_name "evaluationOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfItem"></see>
    /// </summary>
    let reviewOfItem =
        Namespaced_IRI.parse _namespace_name "reviewOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsItem"></see>
    /// </summary>
    let descriptiveRelationshipsItem =
        Namespaced_IRI.parse _namespace_name "descriptiveRelationshipsItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfManifestation"></see>
    /// </summary>
    let evaluationOfManifestation =
        Namespaced_IRI.parse _namespace_name "evaluationOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfManifestation"></see>
    /// </summary>
    let reviewOfManifestation =
        Namespaced_IRI.parse _namespace_name "reviewOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsManifestation"></see>
    /// </summary>
    let descriptiveRelationshipsManifestation =
        Namespaced_IRI.parse _namespace_name "descriptiveRelationshipsManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfWork"></see>
    /// </summary>
    let reviewOfWork =
        Namespaced_IRI.parse _namespace_name "reviewOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfWork"></see>
    /// </summary>
    let evaluationOfWork =
        Namespaced_IRI.parse _namespace_name "evaluationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationships"></see>
    /// </summary>
    let derivativeRelationships =
        Namespaced_IRI.parse _namespace_name "derivativeRelationships" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransfer"></see>
    /// </summary>
    let digitalTransfer =
        Namespaced_IRI.parse _namespace_name "digitalTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferManifestation"></see>
    /// </summary>
    let digitalTransferManifestation =
        Namespaced_IRI.parse _namespace_name "digitalTransferManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproducedAs"></see>
    /// </summary>
    let reproducedAs =
        Namespaced_IRI.parse _namespace_name "reproducedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproducedAsManifestation"></see>
    /// </summary>
    let reproducedAsManifestation =
        Namespaced_IRI.parse _namespace_name "reproducedAsManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOf"></see>
    /// </summary>
    let digitalTransferOf =
        Namespaced_IRI.parse _namespace_name "digitalTransferOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfItem"></see>
    /// </summary>
    let digitalTransferOfItem =
        Namespaced_IRI.parse _namespace_name "digitalTransferOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfManifestation"></see>
    /// </summary>
    let digitalTransferOfManifestation =
        Namespaced_IRI.parse _namespace_name "digitalTransferOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOf"></see>
    /// </summary>
    let reproductionOf =
        Namespaced_IRI.parse _namespace_name "reproductionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOfItem"></see>
    /// </summary>
    let reproductionOfItem =
        Namespaced_IRI.parse _namespace_name "reproductionOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOfManifestation"></see>
    /// </summary>
    let reproductionOfManifestation =
        Namespaced_IRI.parse _namespace_name "reproductionOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfExpression"></see>
    /// </summary>
    let dramatizationOfExpression =
        Namespaced_IRI.parse _namespace_name "dramatizationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproduction"></see>
    /// </summary>
    let electronicReproduction =
        Namespaced_IRI.parse _namespace_name "electronicReproduction" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionManifestation"></see>
    /// </summary>
    let electronicReproductionManifestation =
        Namespaced_IRI.parse _namespace_name "electronicReproductionManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOf"></see>
    /// </summary>
    let electronicReproductionOf =
        Namespaced_IRI.parse _namespace_name "electronicReproductionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfItem"></see>
    /// </summary>
    let electronicReproductionOfItem =
        Namespaced_IRI.parse _namespace_name "electronicReproductionOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfManifestation"></see>
    /// </summary>
    let electronicReproductionOfManifestation =
        Namespaced_IRI.parse _namespace_name "electronicReproductionOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationships"></see>
    /// </summary>
    let equivalenceRelationships =
        Namespaced_IRI.parse _namespace_name "equivalenceRelationships" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsManifestation"></see>
    /// </summary>
    let equivalenceRelationshipsManifestation =
        Namespaced_IRI.parse _namespace_name "equivalenceRelationshipsManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mirrorSite"></see>
    /// </summary>
    let mirrorSite = Namespaced_IRI.parse _namespace_name "mirrorSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsItem"></see>
    /// </summary>
    let equivalenceRelationshipsItem =
        Namespaced_IRI.parse _namespace_name "equivalenceRelationshipsItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mirrorSiteManifestation"></see>
    /// </summary>
    let mirrorSiteManifestation =
        Namespaced_IRI.parse _namespace_name "mirrorSiteManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/exemplarOfManifestation"></see>
    /// </summary>
    let exemplarOfManifestation =
        Namespaced_IRI.parse _namespace_name "exemplarOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expandedAs"></see>
    /// </summary>
    let expandedAs = Namespaced_IRI.parse _namespace_name "expandedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expressionManifested"></see>
    /// </summary>
    let expressionManifested =
        Namespaced_IRI.parse _namespace_name "expressionManifested" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/expressionOfWork"></see>
    /// </summary>
    let expressionOfWork =
        Namespaced_IRI.parse _namespace_name "expressionOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimile"></see>
    /// </summary>
    let facsimile = Namespaced_IRI.parse _namespace_name "facsimile" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimile"></see>
    /// </summary>
    let preservationFacsimile =
        Namespaced_IRI.parse _namespace_name "preservationFacsimile" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimileManifestation"></see>
    /// </summary>
    let facsimileManifestation =
        Namespaced_IRI.parse _namespace_name "facsimileManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileManifestation"></see>
    /// </summary>
    let preservationFacsimileManifestation =
        Namespaced_IRI.parse _namespace_name "preservationFacsimileManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOf"></see>
    /// </summary>
    let facsimileOf =
        Namespaced_IRI.parse _namespace_name "facsimileOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOf"></see>
    /// </summary>
    let preservationFacsimileOf =
        Namespaced_IRI.parse _namespace_name "preservationFacsimileOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOfItem"></see>
    /// </summary>
    let facsimileOfItem =
        Namespaced_IRI.parse _namespace_name "facsimileOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOfManifestation"></see>
    /// </summary>
    let facsimileOfManifestation =
        Namespaced_IRI.parse _namespace_name "facsimileOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfItem"></see>
    /// </summary>
    let preservationFacsimileOfItem =
        Namespaced_IRI.parse _namespace_name "preservationFacsimileOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfManifestation"></see>
    /// </summary>
    let preservationFacsimileOfManifestation =
        Namespaced_IRI.parse _namespace_name "preservationFacsimileOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/filmedWithManifestation"></see>
    /// </summary>
    let filmedWithManifestation =
        Namespaced_IRI.parse _namespace_name "filmedWithManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAs"></see>
    /// </summary>
    let parodiedAs = Namespaced_IRI.parse _namespace_name "parodiedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAsExpression"></see>
    /// </summary>
    let parodiedAsExpression =
        Namespaced_IRI.parse _namespace_name "parodiedAsExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAsWork"></see>
    /// </summary>
    let parodiedAsWork =
        Namespaced_IRI.parse _namespace_name "parodiedAsWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodyOf"></see>
    /// </summary>
    let parodyOf = Namespaced_IRI.parse _namespace_name "parodyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodyOfExpression"></see>
    /// </summary>
    let parodyOfExpression =
        Namespaced_IRI.parse _namespace_name "parodyOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/parodyOfWork"></see>
    /// </summary>
    let parodyOfWork =
        Namespaced_IRI.parse _namespace_name "parodyOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWithManifestation"></see>
    /// </summary>
    let onDiscWithManifestation =
        Namespaced_IRI.parse _namespace_name "onDiscWithManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/librettoForExpression"></see>
    /// </summary>
    let librettoForExpression =
        Namespaced_IRI.parse _namespace_name "librettoForExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/manifestationExemplified"></see>
    /// </summary>
    let manifestationExemplified =
        Namespaced_IRI.parse _namespace_name "manifestationExemplified" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/manifestationOfWork"></see>
    /// </summary>
    let manifestationOfWork =
        Namespaced_IRI.parse _namespace_name "manifestationOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToForm"></see>
    /// </summary>
    let mergedWithToForm =
        Namespaced_IRI.parse _namespace_name "mergedWithToForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormExpression"></see>
    /// </summary>
    let mergedWithToFormExpression =
        Namespaced_IRI.parse _namespace_name "mergedWithToFormExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormWork"></see>
    /// </summary>
    let mergedWithToFormWork =
        Namespaced_IRI.parse _namespace_name "mergedWithToFormWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergerOf"></see>
    /// </summary>
    let mergerOf = Namespaced_IRI.parse _namespace_name "mergerOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergerOfExpression"></see>
    /// </summary>
    let mergerOfExpression =
        Namespaced_IRI.parse _namespace_name "mergerOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/mergerOfWork"></see>
    /// </summary>
    let mergerOfWork =
        Namespaced_IRI.parse _namespace_name "mergerOfWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfExpression"></see>
    /// </summary>
    let motionPictureAdaptationOfExpression =
        Namespaced_IRI.parse _namespace_name "motionPictureAdaptationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOn"></see>
    /// </summary>
    let motionPictureScreenplayBasedOn =
        Namespaced_IRI.parse _namespace_name "motionPictureScreenplayBasedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnExpression"></see>
    /// </summary>
    let motionPictureScreenplayBasedOnExpression =
        Namespaced_IRI.parse _namespace_name "motionPictureScreenplayBasedOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnWork"></see>
    /// </summary>
    let motionPictureScreenplayBasedOnWork =
        Namespaced_IRI.parse _namespace_name "motionPictureScreenplayBasedOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOfExpression"></see>
    /// </summary>
    let novelizationOfExpression =
        Namespaced_IRI.parse _namespace_name "novelizationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/numberingOfPart"></see>
    /// </summary>
    let numberingOfPart =
        Namespaced_IRI.parse _namespace_name "numberingOfPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/numberingOfPartWork"></see>
    /// </summary>
    let numberingOfPartWork =
        Namespaced_IRI.parse _namespace_name "numberingOfPartWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/relatedWork"></see>
    /// </summary>
    let relatedWork =
        Namespaced_IRI.parse _namespace_name "relatedWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedes"></see>
    /// </summary>
    let supersedes = Namespaced_IRI.parse _namespace_name "supersedes" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/separatedFrom"></see>
    /// </summary>
    let separatedFrom =
        Namespaced_IRI.parse _namespace_name "separatedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequelTo"></see>
    /// </summary>
    let sequelTo = Namespaced_IRI.parse _namespace_name "sequelTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/prequel"></see>
    /// </summary>
    let prequel = Namespaced_IRI.parse _namespace_name "prequel" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPart"></see>
    /// </summary>
    let supersedesInPart =
        Namespaced_IRI.parse _namespace_name "supersedesInPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationship"></see>
    /// </summary>
    let sequentialRelationship =
        Namespaced_IRI.parse _namespace_name "sequentialRelationship" |> NamespacedName

    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartExpression"></see></summary>
    let supersedesInPartExpression =
        Namespaced_IRI.parse _namespace_name "supersedesInPartExpression" |> NamespacedName

    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesExpression"></see></summary>
    let supersedesExpression =
        Namespaced_IRI.parse _namespace_name "supersedesExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/separatedFromExpression"></see>
    /// </summary>
    let separatedFromExpression =
        Namespaced_IRI.parse _namespace_name "separatedFromExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipExpression"></see>
    /// </summary>
    let sequentialRelationshipExpression =
        Namespaced_IRI.parse _namespace_name "sequentialRelationshipExpression" |> NamespacedName

    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartWork"></see></summary>
    let supersedesInPartWork =
        Namespaced_IRI.parse _namespace_name "supersedesInPartWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/prequelWork"></see>
    /// </summary>
    let prequelWork =
        Namespaced_IRI.parse _namespace_name "prequelWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/separatedFromWork"></see>
    /// </summary>
    let separatedFromWork =
        Namespaced_IRI.parse _namespace_name "separatedFromWork" |> NamespacedName

    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersedesWork"></see></summary>
    let supersedesWork =
        Namespaced_IRI.parse _namespace_name "supersedesWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequelToWork"></see>
    /// </summary>
    let sequelToWork =
        Namespaced_IRI.parse _namespace_name "sequelToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipWork"></see>
    /// </summary>
    let sequentialRelationshipWork =
        Namespaced_IRI.parse _namespace_name "sequentialRelationshipWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/prequelTo"></see>
    /// </summary>
    let prequelTo = Namespaced_IRI.parse _namespace_name "prequelTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/prequelToWork"></see>
    /// </summary>
    let prequelToWork =
        Namespaced_IRI.parse _namespace_name "prequelToWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintOf"></see>
    /// </summary>
    let reprintOf = Namespaced_IRI.parse _namespace_name "reprintOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintOfItem"></see>
    /// </summary>
    let reprintOfItem =
        Namespaced_IRI.parse _namespace_name "reprintOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintOfManifestation"></see>
    /// </summary>
    let reprintOfManifestation =
        Namespaced_IRI.parse _namespace_name "reprintOfManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintedAs"></see>
    /// </summary>
    let reprintedAs =
        Namespaced_IRI.parse _namespace_name "reprintedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/reprintedAsManifestation"></see>
    /// </summary>
    let reprintedAsManifestation =
        Namespaced_IRI.parse _namespace_name "reprintedAsManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/equivalentItem"></see>
    /// </summary>
    let equivalentItem =
        Namespaced_IRI.parse _namespace_name "equivalentItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplay"></see>
    /// </summary>
    let televisionScreenplay =
        Namespaced_IRI.parse _namespace_name "televisionScreenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplay"></see>
    /// </summary>
    let videoScreenplay =
        Namespaced_IRI.parse _namespace_name "videoScreenplay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOn"></see>
    /// </summary>
    let videoScreenplayBasedOn =
        Namespaced_IRI.parse _namespace_name "videoScreenplayBasedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOn"></see>
    /// </summary>
    let televisionScreenplayBasedOn =
        Namespaced_IRI.parse _namespace_name "televisionScreenplayBasedOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnExpression"></see>
    /// </summary>
    let videoScreenplayBasedOnExpression =
        Namespaced_IRI.parse _namespace_name "videoScreenplayBasedOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnExpression"></see>
    /// </summary>
    let televisionScreenplayBasedOnExpression =
        Namespaced_IRI.parse _namespace_name "televisionScreenplayBasedOnExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnWork"></see>
    /// </summary>
    let videoScreenplayBasedOnWork =
        Namespaced_IRI.parse _namespace_name "videoScreenplayBasedOnWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayExpression"></see>
    /// </summary>
    let televisionScreenplayExpression =
        Namespaced_IRI.parse _namespace_name "televisionScreenplayExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayExpression"></see>
    /// </summary>
    let videoScreenplayExpression =
        Namespaced_IRI.parse _namespace_name "videoScreenplayExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgramme"></see>
    /// </summary>
    let screenplayForTheTelevisionProgramme =
        Namespaced_IRI.parse _namespace_name "screenplayForTheTelevisionProgramme" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideo"></see>
    /// </summary>
    let screenplayForTheVideo =
        Namespaced_IRI.parse _namespace_name "screenplayForTheVideo" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPicture"></see>
    /// </summary>
    let screenplayForTheMotionPicture =
        Namespaced_IRI.parse _namespace_name "screenplayForTheMotionPicture" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeExpression"></see>
    /// </summary>
    let screenplayForTheTelevisionProgrammeExpression =
        Namespaced_IRI.parse _namespace_name "screenplayForTheTelevisionProgrammeExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoExpression"></see>
    /// </summary>
    let screenplayForTheVideoExpression =
        Namespaced_IRI.parse _namespace_name "screenplayForTheVideoExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureExpression"></see>
    /// </summary>
    let screenplayForTheMotionPictureExpression =
        Namespaced_IRI.parse _namespace_name "screenplayForTheMotionPictureExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequel"></see>
    /// </summary>
    let sequel = Namespaced_IRI.parse _namespace_name "sequel" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequelWork"></see>
    /// </summary>
    let sequelWork = Namespaced_IRI.parse _namespace_name "sequelWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipItem"></see>
    /// </summary>
    let sequentialRelationshipItem =
        Namespaced_IRI.parse _namespace_name "sequentialRelationshipItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipManifestation"></see>
    /// </summary>
    let sequentialRelationshipManifestation =
        Namespaced_IRI.parse _namespace_name "sequentialRelationshipManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/splitInto"></see>
    /// </summary>
    let splitInto = Namespaced_IRI.parse _namespace_name "splitInto" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/splitIntoExpression"></see>
    /// </summary>
    let splitIntoExpression =
        Namespaced_IRI.parse _namespace_name "splitIntoExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/splitIntoWork"></see>
    /// </summary>
    let splitIntoWork =
        Namespaced_IRI.parse _namespace_name "splitIntoWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededBy"></see>
    /// </summary>
    let supersededBy =
        Namespaced_IRI.parse _namespace_name "supersededBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartBy"></see>
    /// </summary>
    let supersededInPartBy =
        Namespaced_IRI.parse _namespace_name "supersededInPartBy" |> NamespacedName

    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByExpression"></see></summary>
    let supersededInPartByExpression =
        Namespaced_IRI.parse _namespace_name "supersededInPartByExpression" |> NamespacedName

    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededByExpression"></see></summary>
    let supersededByExpression =
        Namespaced_IRI.parse _namespace_name "supersededByExpression" |> NamespacedName

    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByWork"></see></summary>
    let supersededInPartByWork =
        Namespaced_IRI.parse _namespace_name "supersededInPartByWork" |> NamespacedName

    /// <summary>
    /// Apply generally to single-part units, multipart monographs, and integrating resources.
    /// <see href="http://rdvocab.info/RDARelationshipsWEMI/supersededByWork"></see></summary>
    let supersededByWork =
        Namespaced_IRI.parse _namespace_name "supersededByWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfExpression"></see>
    /// </summary>
    let televisionAdaptationOfExpression =
        Namespaced_IRI.parse _namespace_name "televisionAdaptationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfExpression"></see>
    /// </summary>
    let verseAdaptationOfExpression =
        Namespaced_IRI.parse _namespace_name "verseAdaptationOfExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/RDARelationshipsWEMI/workManifested"></see>
    /// </summary>
    let workManifested =
        Namespaced_IRI.parse _namespace_name "workManifested" |> NamespacedName
