namespace http.rdvocab.info.RDARelationshipsWEMI.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdarel =
    let _namespace_iri = Namespace_Iri rdarel |> NamespaceIRI
    /// <summary>
    ///   <para>rdarel:derivativeWork</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/derivativeWork">http://rdvocab.info/RDARelationshipsWEMI/derivativeWork</seealso>
    let derivativeWork = Prefixed_Name(rdarel, "derivativeWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abridgedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abridged as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/abridgedAsExpression</seealso>
    let abridgedAsExpression =
        Prefixed_Name(rdarel, "abridgedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abridgedAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abridged as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAsWork">http://rdvocab.info/RDARelationshipsWEMI/abridgedAsWork</seealso>
    let abridgedAsWork = Prefixed_Name(rdarel, "abridgedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abstractOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstract of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractOf">http://rdvocab.info/RDARelationshipsWEMI/abstractOf</seealso>
    let abstractOf = Prefixed_Name(rdarel, "abstractOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abstractedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstracted in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractedIn">http://rdvocab.info/RDARelationshipsWEMI/abstractedIn</seealso>
    let abstractedIn = Prefixed_Name(rdarel, "abstractedIn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abstractedInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstracted in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractedInWork">http://rdvocab.info/RDARelationshipsWEMI/abstractedInWork</seealso>
    let abstractedInWork = Prefixed_Name(rdarel, "abstractedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:accompaniedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Accompanied by </para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedBy">http://rdvocab.info/RDARelationshipsWEMI/accompaniedBy</seealso>
    let accompaniedBy = Prefixed_Name(rdarel, "accompaniedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:onDiscWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>On disc with</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWith">http://rdvocab.info/RDARelationshipsWEMI/onDiscWith</seealso>
    let onDiscWith = Prefixed_Name(rdarel, "onDiscWith") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:issuedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Issued with</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/issuedWith">http://rdvocab.info/RDARelationshipsWEMI/issuedWith</seealso>
    let issuedWith = Prefixed_Name(rdarel, "issuedWith") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:accompaniedByItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Accompanied by (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedByItem">http://rdvocab.info/RDARelationshipsWEMI/accompaniedByItem</seealso>
    let accompaniedByItem = Prefixed_Name(rdarel, "accompaniedByItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:filmedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Filmed with</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/filmedWith">http://rdvocab.info/RDARelationshipsWEMI/filmedWith</seealso>
    let filmedWith = Prefixed_Name(rdarel, "filmedWith") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:accompanyingExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Accompanying expression</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/accompanyingExpression">http://rdvocab.info/RDARelationshipsWEMI/accompanyingExpression</seealso>
    let accompanyingExpression =
        Prefixed_Name(rdarel, "accompanyingExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:augmentationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Augmentation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/augmentationOfExpression</seealso>
    let augmentationOfExpression =
        Prefixed_Name(rdarel, "augmentationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:augmentedByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Augmented by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/augmentedByWork">http://rdvocab.info/RDARelationshipsWEMI/augmentedByWork</seealso>
    let augmentedByWork = Prefixed_Name(rdarel, "augmentedByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:complementedByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Complemented by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/complementedByWork">http://rdvocab.info/RDARelationshipsWEMI/complementedByWork</seealso>
    let complementedByWork = Prefixed_Name(rdarel, "complementedByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:adaptationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adaptation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOf">http://rdvocab.info/RDARelationshipsWEMI/adaptationOf</seealso>
    let adaptationOf = Prefixed_Name(rdarel, "adaptationOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:motionPictureAdaptationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Motion picture adaptation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOf">http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOf</seealso>
    let motionPictureAdaptationOf =
        Prefixed_Name(rdarel, "motionPictureAdaptationOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:radioAdaptationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Radio adaptation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOf">http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOf</seealso>
    let radioAdaptationOf = Prefixed_Name(rdarel, "radioAdaptationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:radioScriptBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Radio script based on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOn">http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOn</seealso>
    let radioScriptBasedOn = Prefixed_Name(rdarel, "radioScriptBasedOn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:splitInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Split into</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/splitInto">http://rdvocab.info/RDARelationshipsWEMI/splitInto</seealso>
    let splitInto = Prefixed_Name(rdarel, "splitInto") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:splitIntoExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Split into (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/splitIntoExpression">http://rdvocab.info/RDARelationshipsWEMI/splitIntoExpression</seealso>
    let splitIntoExpression =
        Prefixed_Name(rdarel, "splitIntoExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:splitIntoWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Split into (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/splitIntoWork">http://rdvocab.info/RDARelationshipsWEMI/splitIntoWork</seealso>
    let splitIntoWork = Prefixed_Name(rdarel, "splitIntoWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:basisForLibretto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Basis for libretto</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/basisForLibretto">http://rdvocab.info/RDARelationshipsWEMI/basisForLibretto</seealso>
    let basisForLibretto = Prefixed_Name(rdarel, "basisForLibretto") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abridgementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abridgement of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOf">http://rdvocab.info/RDARelationshipsWEMI/abridgementOf</seealso>
    let abridgementOf = Prefixed_Name(rdarel, "abridgementOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abridgementOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abridgement of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOfWork">http://rdvocab.info/RDARelationshipsWEMI/abridgementOfWork</seealso>
    let abridgementOfWork = Prefixed_Name(rdarel, "abridgementOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:basedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Based on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/basedOn">http://rdvocab.info/RDARelationshipsWEMI/basedOn</seealso>
    let basedOn = Prefixed_Name(rdarel, "basedOn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:describedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Described in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/describedIn">http://rdvocab.info/RDARelationshipsWEMI/describedIn</seealso>
    let describedIn = Prefixed_Name(rdarel, "describedIn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:analysisOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Analysis of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/analysisOf">http://rdvocab.info/RDARelationshipsWEMI/analysisOf</seealso>
    let analysisOf = Prefixed_Name(rdarel, "analysisOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:analysisOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Analysis of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfExpression">http://rdvocab.info/RDARelationshipsWEMI/analysisOfExpression</seealso>
    let analysisOfExpression =
        Prefixed_Name(rdarel, "analysisOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptionOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Description of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfExpression">http://rdvocab.info/RDARelationshipsWEMI/descriptionOfExpression</seealso>
    let descriptionOfExpression =
        Prefixed_Name(rdarel, "descriptionOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptionOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Description of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfItem">http://rdvocab.info/RDARelationshipsWEMI/descriptionOfItem</seealso>
    let descriptionOfItem = Prefixed_Name(rdarel, "descriptionOfItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:critiqueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Critique of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOf">http://rdvocab.info/RDARelationshipsWEMI/critiqueOf</seealso>
    let critiqueOf = Prefixed_Name(rdarel, "critiqueOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:critiqueOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Critique of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfItem">http://rdvocab.info/RDARelationshipsWEMI/critiqueOfItem</seealso>
    let critiqueOfItem = Prefixed_Name(rdarel, "critiqueOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:electronicReproductionOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Electronic reproduction of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfItem">http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfItem</seealso>
    let electronicReproductionOfItem =
        Prefixed_Name(rdarel, "electronicReproductionOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abridgementOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abridgement of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOfExpression">http://rdvocab.info/RDARelationshipsWEMI/abridgementOfExpression</seealso>
    let abridgementOfExpression =
        Prefixed_Name(rdarel, "abridgementOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:basedOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Based on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/basedOnExpression">http://rdvocab.info/RDARelationshipsWEMI/basedOnExpression</seealso>
    let basedOnExpression = Prefixed_Name(rdarel, "basedOnExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:basedOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Based on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/basedOnWork">http://rdvocab.info/RDARelationshipsWEMI/basedOnWork</seealso>
    let basedOnWork = Prefixed_Name(rdarel, "basedOnWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:absorbedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedWork">http://rdvocab.info/RDARelationshipsWEMI/absorbedWork</seealso>
    let absorbedWork = Prefixed_Name(rdarel, "absorbedWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:precededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preceded by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/precededBy">http://rdvocab.info/RDARelationshipsWEMI/precededBy</seealso>
    let precededBy = Prefixed_Name(rdarel, "precededBy") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:absorbedByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedByExpression">http://rdvocab.info/RDARelationshipsWEMI/absorbedByExpression</seealso>
    let absorbedByExpression =
        Prefixed_Name(rdarel, "absorbedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:succeededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Succeeded by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/succeededBy">http://rdvocab.info/RDARelationshipsWEMI/succeededBy</seealso>
    let succeededBy = Prefixed_Name(rdarel, "succeededBy") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayBasedOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay based on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnWork">http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnWork</seealso>
    let screenplayBasedOnWork =
        Prefixed_Name(rdarel, "screenplayBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:radioAdaptationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Radio adaptation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfWork">http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfWork</seealso>
    let radioAdaptationOfWork =
        Prefixed_Name(rdarel, "radioAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAs">http://rdvocab.info/RDARelationshipsWEMI/adaptedAs</seealso>
    let adaptedAs = Prefixed_Name(rdarel, "adaptedAs") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:verseAdaptation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Verse adaptation</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptation">http://rdvocab.info/RDARelationshipsWEMI/verseAdaptation</seealso>
    let verseAdaptation = Prefixed_Name(rdarel, "verseAdaptation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAMotionPicture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a motion picture</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPicture">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPicture</seealso>
    let adaptedAsAMotionPicture =
        Prefixed_Name(rdarel, "adaptedAsAMotionPicture") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:novelization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Novelization</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/novelization">http://rdvocab.info/RDARelationshipsWEMI/novelization</seealso>
    let novelization = Prefixed_Name(rdarel, "novelization") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:dramatizedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dramatized as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAs">http://rdvocab.info/RDARelationshipsWEMI/dramatizedAs</seealso>
    let dramatizedAs = Prefixed_Name(rdarel, "dramatizedAs") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsExpression</seealso>
    let adaptedAsExpression =
        Prefixed_Name(rdarel, "adaptedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAMotionPictureScreenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a motion picture screenplay</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplay">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplay</seealso>
    let adaptedAsAMotionPictureScreenplay =
        Prefixed_Name(rdarel, "adaptedAsAMotionPictureScreenplay") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAMotionPictureScreenplayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a motion picture screenplay (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayExpression</seealso>
    let adaptedAsAMotionPictureScreenplayExpression =
        Prefixed_Name(rdarel, "adaptedAsAMotionPictureScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAScreenplayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a screenplay (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayExpression</seealso>
    let adaptedAsAScreenplayExpression =
        Prefixed_Name(rdarel, "adaptedAsAScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsARadioProgrammeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a radio programme (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeExpression</seealso>
    let adaptedAsARadioProgrammeExpression =
        Prefixed_Name(rdarel, "adaptedAsARadioProgrammeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsARadioProgrammeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a radio programme (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeWork</seealso>
    let adaptedAsARadioProgrammeWork =
        Prefixed_Name(rdarel, "adaptedAsARadioProgrammeWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayFor">http://rdvocab.info/RDARelationshipsWEMI/screenplayFor</seealso>
    let screenplayFor = Prefixed_Name(rdarel, "screenplayFor") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:librettoFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto for</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/librettoFor">http://rdvocab.info/RDARelationshipsWEMI/librettoFor</seealso>
    let librettoFor = Prefixed_Name(rdarel, "librettoFor") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:screenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplay">http://rdvocab.info/RDARelationshipsWEMI/screenplay</seealso>
    let screenplay = Prefixed_Name(rdarel, "screenplay") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:radioScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Radio script</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/radioScript">http://rdvocab.info/RDARelationshipsWEMI/radioScript</seealso>
    let radioScript = Prefixed_Name(rdarel, "radioScript") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:screenplayForWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForWork">http://rdvocab.info/RDARelationshipsWEMI/screenplayForWork</seealso>
    let screenplayForWork = Prefixed_Name(rdarel, "screenplayForWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:mirrorSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Mirror site</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/mirrorSite">http://rdvocab.info/RDARelationshipsWEMI/mirrorSite</seealso>
    let mirrorSite = Prefixed_Name(rdarel, "mirrorSite") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:equivalenceRelationshipsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Equivalence relationships (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsItem">http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsItem</seealso>
    let equivalenceRelationshipsItem =
        Prefixed_Name(rdarel, "equivalenceRelationshipsItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:exemplarOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Exemplar of manifestation</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/exemplarOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/exemplarOfManifestation</seealso>
    let exemplarOfManifestation =
        Prefixed_Name(rdarel, "exemplarOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:expandedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Expanded as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/expandedAs">http://rdvocab.info/RDARelationshipsWEMI/expandedAs</seealso>
    let expandedAs = Prefixed_Name(rdarel, "expandedAs") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:expressionManifested</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Expression manifested</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/expressionManifested">http://rdvocab.info/RDARelationshipsWEMI/expressionManifested</seealso>
    let expressionManifested =
        Prefixed_Name(rdarel, "expressionManifested") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:preservationFacsimileManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preservation facsimile (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileManifestation">http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileManifestation</seealso>
    let preservationFacsimileManifestation =
        Prefixed_Name(rdarel, "preservationFacsimileManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:facsimileOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Facsimile of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOf">http://rdvocab.info/RDARelationshipsWEMI/facsimileOf</seealso>
    let facsimileOf = Prefixed_Name(rdarel, "facsimileOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:preservationFacsimileOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preservation facsimile of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOf">http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOf</seealso>
    let preservationFacsimileOf =
        Prefixed_Name(rdarel, "preservationFacsimileOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:preservationFacsimileOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preservation facsimile of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfManifestation</seealso>
    let preservationFacsimileOfManifestation =
        Prefixed_Name(rdarel, "preservationFacsimileOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:filmedWithManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Filmed with (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/filmedWithManifestation">http://rdvocab.info/RDARelationshipsWEMI/filmedWithManifestation</seealso>
    let filmedWithManifestation =
        Prefixed_Name(rdarel, "filmedWithManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:absorbed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbed">http://rdvocab.info/RDARelationshipsWEMI/absorbed</seealso>
    let absorbed = Prefixed_Name(rdarel, "absorbed") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:succeededByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For sequentially numbered works with revised content.</para>
    /// labels<para>Succeeded by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/succeededByWork">http://rdvocab.info/RDARelationshipsWEMI/succeededByWork</seealso>
    let succeededByWork = Prefixed_Name(rdarel, "succeededByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:absorbedInPartBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed in part by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartBy">http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartBy</seealso>
    let absorbedInPartBy = Prefixed_Name(rdarel, "absorbedInPartBy") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:absorbedInPartByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed in part by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByExpression">http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByExpression</seealso>
    let absorbedInPartByExpression =
        Prefixed_Name(rdarel, "absorbedInPartByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:librettoExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/librettoExpression">http://rdvocab.info/RDARelationshipsWEMI/librettoExpression</seealso>
    let librettoExpression = Prefixed_Name(rdarel, "librettoExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:scriptForTheRadioProgrammeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Script for the radio programme (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeExpression">http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeExpression</seealso>
    let scriptForTheRadioProgrammeExpression =
        Prefixed_Name(rdarel, "scriptForTheRadioProgrammeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:containedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contained in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containedIn">http://rdvocab.info/RDARelationshipsWEMI/containedIn</seealso>
    let containedIn = Prefixed_Name(rdarel, "containedIn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:containedInManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contained in (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containedInManifestation">http://rdvocab.info/RDARelationshipsWEMI/containedInManifestation</seealso>
    let containedInManifestation =
        Prefixed_Name(rdarel, "containedInManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:containedInItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contained in (item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containedInItem">http://rdvocab.info/RDARelationshipsWEMI/containedInItem</seealso>
    let containedInItem = Prefixed_Name(rdarel, "containedInItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:insertedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Inserted in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/insertedIn">http://rdvocab.info/RDARelationshipsWEMI/insertedIn</seealso>
    let insertedIn = Prefixed_Name(rdarel, "insertedIn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:subseriesOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Subseries of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/subseriesOf">http://rdvocab.info/RDARelationshipsWEMI/subseriesOf</seealso>
    let subseriesOf = Prefixed_Name(rdarel, "subseriesOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:containedInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contained in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containedInExpression">http://rdvocab.info/RDARelationshipsWEMI/containedInExpression</seealso>
    let containedInExpression =
        Prefixed_Name(rdarel, "containedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:specialIssueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Special issue of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueOf">http://rdvocab.info/RDARelationshipsWEMI/specialIssueOf</seealso>
    let specialIssueOf = Prefixed_Name(rdarel, "specialIssueOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:wholePartRelationshipItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Whole-part relationship (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipItem">http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipItem</seealso>
    let wholePartRelationshipItem =
        Prefixed_Name(rdarel, "wholePartRelationshipItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:insertedInManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Inserted in (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/insertedInManifestation">http://rdvocab.info/RDARelationshipsWEMI/insertedInManifestation</seealso>
    let insertedInManifestation =
        Prefixed_Name(rdarel, "insertedInManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:specialIssueOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Special issue of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/specialIssueOfManifestation</seealso>
    let specialIssueOfManifestation =
        Prefixed_Name(rdarel, "specialIssueOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:wholePartRelationshipWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Whole-part relationship (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipWork">http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipWork</seealso>
    let wholePartRelationshipWork =
        Prefixed_Name(rdarel, "wholePartRelationshipWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contains</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/contains">http://rdvocab.info/RDARelationshipsWEMI/contains</seealso>
    let contains = Prefixed_Name(rdarel, "contains") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:specialIssueManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Special issue (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueManifestation">http://rdvocab.info/RDARelationshipsWEMI/specialIssueManifestation</seealso>
    let specialIssueManifestation =
        Prefixed_Name(rdarel, "specialIssueManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Continued by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuedBy">http://rdvocab.info/RDARelationshipsWEMI/continuedBy</seealso>
    let continuedBy = Prefixed_Name(rdarel, "continuedBy") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuedByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to serials.</para>
    /// labels<para>Continued by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuedByExpression">http://rdvocab.info/RDARelationshipsWEMI/continuedByExpression</seealso>
    let continuedByExpression =
        Prefixed_Name(rdarel, "continuedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuedByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to serials.</para>
    /// labels<para>Continued by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuedByWork">http://rdvocab.info/RDARelationshipsWEMI/continuedByWork</seealso>
    let continuedByWork = Prefixed_Name(rdarel, "continuedByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:expressionOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Expression of work</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/expressionOfWork">http://rdvocab.info/RDARelationshipsWEMI/expressionOfWork</seealso>
    let expressionOfWork = Prefixed_Name(rdarel, "expressionOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:facsimile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Facsimile</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/facsimile">http://rdvocab.info/RDARelationshipsWEMI/facsimile</seealso>
    let facsimile = Prefixed_Name(rdarel, "facsimile") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:preservationFacsimile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preservation facsimile</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimile">http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimile</seealso>
    let preservationFacsimile =
        Prefixed_Name(rdarel, "preservationFacsimile") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:facsimileManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Facsimile (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/facsimileManifestation">http://rdvocab.info/RDARelationshipsWEMI/facsimileManifestation</seealso>
    let facsimileManifestation =
        Prefixed_Name(rdarel, "facsimileManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:facsimileOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Facsimile of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOfItem">http://rdvocab.info/RDARelationshipsWEMI/facsimileOfItem</seealso>
    let facsimileOfItem = Prefixed_Name(rdarel, "facsimileOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:facsimileOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Facsimile of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/facsimileOfManifestation</seealso>
    let facsimileOfManifestation =
        Prefixed_Name(rdarel, "facsimileOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:preservationFacsimileOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preservation facsimile of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfItem">http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfItem</seealso>
    let preservationFacsimileOfItem =
        Prefixed_Name(rdarel, "preservationFacsimileOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:prequelTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Prequel to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/prequelTo">http://rdvocab.info/RDARelationshipsWEMI/prequelTo</seealso>
    let prequelTo = Prefixed_Name(rdarel, "prequelTo") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:prequelToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Prequel to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/prequelToWork">http://rdvocab.info/RDARelationshipsWEMI/prequelToWork</seealso>
    let prequelToWork = Prefixed_Name(rdarel, "prequelToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:absorbedExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedExpression">http://rdvocab.info/RDARelationshipsWEMI/absorbedExpression</seealso>
    let absorbedExpression = Prefixed_Name(rdarel, "absorbedExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abstractsForExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstracts for (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractsForExpression">http://rdvocab.info/RDARelationshipsWEMI/abstractsForExpression</seealso>
    let abstractsForExpression =
        Prefixed_Name(rdarel, "abstractsForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:freeTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Free translation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOf">http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOf</seealso>
    let freeTranslationOf = Prefixed_Name(rdarel, "freeTranslationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:musicalSettingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical setting of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOf">http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOf</seealso>
    let musicalSettingOf = Prefixed_Name(rdarel, "musicalSettingOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:translationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Translation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/translationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/translationOfExpression</seealso>
    let translationOfExpression =
        Prefixed_Name(rdarel, "translationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:digestOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digest of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digestOfExpression">http://rdvocab.info/RDARelationshipsWEMI/digestOfExpression</seealso>
    let digestOfExpression = Prefixed_Name(rdarel, "digestOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:choreographyForExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Choreography for (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/choreographyForExpression">http://rdvocab.info/RDARelationshipsWEMI/choreographyForExpression</seealso>
    let choreographyForExpression =
        Prefixed_Name(rdarel, "choreographyForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:paraphraseOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Paraphrase of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfExpression">http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfExpression</seealso>
    let paraphraseOfExpression =
        Prefixed_Name(rdarel, "paraphraseOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:expandedVersionOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Expanded version of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfExpression">http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfExpression</seealso>
    let expandedVersionOfExpression =
        Prefixed_Name(rdarel, "expandedVersionOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:televisionScreenplayBasedOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Television screenplay based on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnWork">http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnWork</seealso>
    let televisionScreenplayBasedOnWork =
        Prefixed_Name(rdarel, "televisionScreenplayBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:remakeOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Remake of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/remakeOfWork">http://rdvocab.info/RDARelationshipsWEMI/remakeOfWork</seealso>
    let remakeOfWork = Prefixed_Name(rdarel, "remakeOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalSettingOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical setting of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfWork">http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfWork</seealso>
    let musicalSettingOfWork =
        Prefixed_Name(rdarel, "musicalSettingOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:summaryOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Summary of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/summaryOfWork">http://rdvocab.info/RDARelationshipsWEMI/summaryOfWork</seealso>
    let summaryOfWork = Prefixed_Name(rdarel, "summaryOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:absorbedByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedByWork">http://rdvocab.info/RDARelationshipsWEMI/absorbedByWork</seealso>
    let absorbedByWork = Prefixed_Name(rdarel, "absorbedByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:absorbedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedBy">http://rdvocab.info/RDARelationshipsWEMI/absorbedBy</seealso>
    let absorbedBy = Prefixed_Name(rdarel, "absorbedBy") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:succeededByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Succeeded by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/succeededByExpression">http://rdvocab.info/RDARelationshipsWEMI/succeededByExpression</seealso>
    let succeededByExpression =
        Prefixed_Name(rdarel, "succeededByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:absorbedInPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed in part</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPart">http://rdvocab.info/RDARelationshipsWEMI/absorbedInPart</seealso>
    let absorbedInPart = Prefixed_Name(rdarel, "absorbedInPart") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:absorbedInPartWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed in part (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartWork">http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartWork</seealso>
    let absorbedInPartWork = Prefixed_Name(rdarel, "absorbedInPartWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAVideoScreenplayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a video screenplay (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayExpression</seealso>
    let adaptedAsAVideoScreenplayExpression =
        Prefixed_Name(rdarel, "adaptedAsAVideoScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsATelevisionScreenplayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a television screenplay (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayExpression</seealso>
    let adaptedAsATelevisionScreenplayExpression =
        Prefixed_Name(rdarel, "adaptedAsATelevisionScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsATelevisionProgrammeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a television programme (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeExpression</seealso>
    let adaptedAsATelevisionProgrammeExpression =
        Prefixed_Name(rdarel, "adaptedAsATelevisionProgrammeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsATelevisionProgrammeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a television programme (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeWork</seealso>
    let adaptedAsATelevisionProgrammeWork =
        Prefixed_Name(rdarel, "adaptedAsATelevisionProgrammeWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:inSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>In series</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/inSeries">http://rdvocab.info/RDARelationshipsWEMI/inSeries</seealso>
    let inSeries = Prefixed_Name(rdarel, "inSeries") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:containedInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contained in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containedInWork">http://rdvocab.info/RDARelationshipsWEMI/containedInWork</seealso>
    let containedInWork = Prefixed_Name(rdarel, "containedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:boundWithItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Bound with (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/boundWithItem">http://rdvocab.info/RDARelationshipsWEMI/boundWithItem</seealso>
    let boundWithItem = Prefixed_Name(rdarel, "boundWithItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:cadenzaComposedForWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Cadenza composed for (work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForWork">http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForWork</seealso>
    let cadenzaComposedForWork =
        Prefixed_Name(rdarel, "cadenzaComposedForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:mergedWithToFormWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Merged with to form (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormWork">http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormWork</seealso>
    let mergedWithToFormWork =
        Prefixed_Name(rdarel, "mergedWithToFormWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:absorbedInPartExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed in part (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartExpression">http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartExpression</seealso>
    let absorbedInPartExpression =
        Prefixed_Name(rdarel, "absorbedInPartExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:precededByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preceded by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/precededByWork">http://rdvocab.info/RDARelationshipsWEMI/precededByWork</seealso>
    let precededByWork = Prefixed_Name(rdarel, "precededByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstract</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstract">http://rdvocab.info/RDARelationshipsWEMI/abstract</seealso>
    let abstract_ = Prefixed_Name(rdarel, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abstractExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstract (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractExpression">http://rdvocab.info/RDARelationshipsWEMI/abstractExpression</seealso>
    let abstractExpression = Prefixed_Name(rdarel, "abstractExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:augmentationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Augmentation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOfWork">http://rdvocab.info/RDARelationshipsWEMI/augmentationOfWork</seealso>
    let augmentationOfWork = Prefixed_Name(rdarel, "augmentationOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:alsoIssuedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Also issued as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAs">http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAs</seealso>
    let alsoIssuedAs = Prefixed_Name(rdarel, "alsoIssuedAs") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:alsoIssuedAsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Also issued as (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAsManifestation">http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAsManifestation</seealso>
    let alsoIssuedAsManifestation =
        Prefixed_Name(rdarel, "alsoIssuedAsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:analysedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Analysed in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/analysedIn">http://rdvocab.info/RDARelationshipsWEMI/analysedIn</seealso>
    let analysedIn = Prefixed_Name(rdarel, "analysedIn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:analysedInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Analysed in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/analysedInExpression">http://rdvocab.info/RDARelationshipsWEMI/analysedInExpression</seealso>
    let analysedInExpression =
        Prefixed_Name(rdarel, "analysedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:analysedInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Analysed in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/analysedInWork">http://rdvocab.info/RDARelationshipsWEMI/analysedInWork</seealso>
    let analysedInWork = Prefixed_Name(rdarel, "analysedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:describedInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Described in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/describedInWork">http://rdvocab.info/RDARelationshipsWEMI/describedInWork</seealso>
    let describedInWork = Prefixed_Name(rdarel, "describedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:descriptionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Description of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOf">http://rdvocab.info/RDARelationshipsWEMI/descriptionOf</seealso>
    let descriptionOf = Prefixed_Name(rdarel, "descriptionOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:continues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Continues</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continues">http://rdvocab.info/RDARelationshipsWEMI/continues</seealso>
    let continues = Prefixed_Name(rdarel, "continues") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuesExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to serials.</para>
    /// labels<para>Continues (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuesExpression">http://rdvocab.info/RDARelationshipsWEMI/continuesExpression</seealso>
    let continuesExpression =
        Prefixed_Name(rdarel, "continuesExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:sequentialRelationshipExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequential relationship (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipExpression">http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipExpression</seealso>
    let sequentialRelationshipExpression =
        Prefixed_Name(rdarel, "sequentialRelationshipExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersedesInPartWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    /// labels<para>Supersedes in part (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartWork">http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartWork</seealso>
    let supersedesInPartWork =
        Prefixed_Name(rdarel, "supersedesInPartWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:novelizationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Novelization (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/novelizationExpression">http://rdvocab.info/RDARelationshipsWEMI/novelizationExpression</seealso>
    let novelizationExpression =
        Prefixed_Name(rdarel, "novelizationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:dramatizedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dramatized as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsExpression</seealso>
    let dramatizedAsExpression =
        Prefixed_Name(rdarel, "dramatizedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheVideoWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the video (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoWork">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoWork</seealso>
    let screenplayForTheVideoWork =
        Prefixed_Name(rdarel, "screenplayForTheVideoWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:dramatizedAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dramatized as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsWork">http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsWork</seealso>
    let dramatizedAsWork = Prefixed_Name(rdarel, "dramatizedAsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:scriptForTheRadioProgrammeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Script for the radio programme (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeWork">http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeWork</seealso>
    let scriptForTheRadioProgrammeWork =
        Prefixed_Name(rdarel, "scriptForTheRadioProgrammeWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:novelizationWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Novelization (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/novelizationWork">http://rdvocab.info/RDARelationshipsWEMI/novelizationWork</seealso>
    let novelizationWork = Prefixed_Name(rdarel, "novelizationWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:augmentedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Augmented by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/augmentedBy">http://rdvocab.info/RDARelationshipsWEMI/augmentedBy</seealso>
    let augmentedBy = Prefixed_Name(rdarel, "augmentedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:addendaExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Addenda (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/addendaExpression">http://rdvocab.info/RDARelationshipsWEMI/addendaExpression</seealso>
    let addendaExpression = Prefixed_Name(rdarel, "addendaExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:addendaTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Addenda to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/addendaTo">http://rdvocab.info/RDARelationshipsWEMI/addendaTo</seealso>
    let addendaTo = Prefixed_Name(rdarel, "addendaTo") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:addendaToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Addenda to (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/addendaToExpression">http://rdvocab.info/RDARelationshipsWEMI/addendaToExpression</seealso>
    let addendaToExpression =
        Prefixed_Name(rdarel, "addendaToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:addendaToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Addenda to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/addendaToWork">http://rdvocab.info/RDARelationshipsWEMI/addendaToWork</seealso>
    let addendaToWork = Prefixed_Name(rdarel, "addendaToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:augmentationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Augmentation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOf">http://rdvocab.info/RDARelationshipsWEMI/augmentationOf</seealso>
    let augmentationOf = Prefixed_Name(rdarel, "augmentationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:addendaWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Addenda (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/addendaWork">http://rdvocab.info/RDARelationshipsWEMI/addendaWork</seealso>
    let addendaWork = Prefixed_Name(rdarel, "addendaWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:equivalentManifestation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/equivalentManifestation">http://rdvocab.info/RDARelationshipsWEMI/equivalentManifestation</seealso>
    let equivalentManifestation =
        Prefixed_Name(rdarel, "equivalentManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:describedInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Described in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/describedInExpression">http://rdvocab.info/RDARelationshipsWEMI/describedInExpression</seealso>
    let describedInExpression =
        Prefixed_Name(rdarel, "describedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:analysisOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Analysis of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfItem">http://rdvocab.info/RDARelationshipsWEMI/analysisOfItem</seealso>
    let analysisOfItem = Prefixed_Name(rdarel, "analysisOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:analysisOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Analysis of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/analysisOfManifestation</seealso>
    let analysisOfManifestation =
        Prefixed_Name(rdarel, "analysisOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:analysisOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Analysis of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfWork">http://rdvocab.info/RDARelationshipsWEMI/analysisOfWork</seealso>
    let analysisOfWork = Prefixed_Name(rdarel, "analysisOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptionOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Description of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/descriptionOfManifestation</seealso>
    let descriptionOfManifestation =
        Prefixed_Name(rdarel, "descriptionOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:appendix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Appendix</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/appendix">http://rdvocab.info/RDARelationshipsWEMI/appendix</seealso>
    let appendix = Prefixed_Name(rdarel, "appendix") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:appendixExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Appendix (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/appendixExpression">http://rdvocab.info/RDARelationshipsWEMI/appendixExpression</seealso>
    let appendixExpression = Prefixed_Name(rdarel, "appendixExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:appendixWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Appendix (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/appendixWork">http://rdvocab.info/RDARelationshipsWEMI/appendixWork</seealso>
    let appendixWork = Prefixed_Name(rdarel, "appendixWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:appendixToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Appendix to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/appendixToWork">http://rdvocab.info/RDARelationshipsWEMI/appendixToWork</seealso>
    let appendixToWork = Prefixed_Name(rdarel, "appendixToWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:critiqueOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Critique of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfExpression">http://rdvocab.info/RDARelationshipsWEMI/critiqueOfExpression</seealso>
    let critiqueOfExpression =
        Prefixed_Name(rdarel, "critiqueOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:critiqueOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Critique of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfWork">http://rdvocab.info/RDARelationshipsWEMI/critiqueOfWork</seealso>
    let critiqueOfWork = Prefixed_Name(rdarel, "critiqueOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:critiqueOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Critique of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/critiqueOfManifestation</seealso>
    let critiqueOfManifestation =
        Prefixed_Name(rdarel, "critiqueOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:critiquedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Critiqued in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/critiquedIn">http://rdvocab.info/RDARelationshipsWEMI/critiquedIn</seealso>
    let critiquedIn = Prefixed_Name(rdarel, "critiquedIn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:critiquedInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Critiqued in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/critiquedInExpression">http://rdvocab.info/RDARelationshipsWEMI/critiquedInExpression</seealso>
    let critiquedInExpression =
        Prefixed_Name(rdarel, "critiquedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:critiquedInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Critiqued in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/critiquedInWork">http://rdvocab.info/RDARelationshipsWEMI/critiquedInWork</seealso>
    let critiquedInWork = Prefixed_Name(rdarel, "critiquedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abstractWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstract (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractWork">http://rdvocab.info/RDARelationshipsWEMI/abstractWork</seealso>
    let abstractWork = Prefixed_Name(rdarel, "abstractWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheMotionPictureWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the motion picture (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureWork">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureWork</seealso>
    let screenplayForTheMotionPictureWork =
        Prefixed_Name(rdarel, "screenplayForTheMotionPictureWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:seriesContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Series contains</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/seriesContains">http://rdvocab.info/RDARelationshipsWEMI/seriesContains</seealso>
    let seriesContains = Prefixed_Name(rdarel, "seriesContains") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:verseAdaptationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Verse adaptation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfExpression</seealso>
    let verseAdaptationOfExpression =
        Prefixed_Name(rdarel, "verseAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:workManifested</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Work manifested</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/workManifested">http://rdvocab.info/RDARelationshipsWEMI/workManifested</seealso>
    let workManifested = Prefixed_Name(rdarel, "workManifested") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:verseAdaptationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Verse adaptation (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationExpression">http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationExpression</seealso>
    let verseAdaptationExpression =
        Prefixed_Name(rdarel, "verseAdaptationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheTelevisionProgrammeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the television programme (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeWork">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeWork</seealso>
    let screenplayForTheTelevisionProgrammeWork =
        Prefixed_Name(rdarel, "screenplayForTheTelevisionProgrammeWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:verseAdaptationWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Verse adaptation (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationWork">http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationWork</seealso>
    let verseAdaptationWork =
        Prefixed_Name(rdarel, "verseAdaptationWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:addenda</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Addenda</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/addenda">http://rdvocab.info/RDARelationshipsWEMI/addenda</seealso>
    let addenda = Prefixed_Name(rdarel, "addenda") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:prequel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Prequel</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/prequel">http://rdvocab.info/RDARelationshipsWEMI/prequel</seealso>
    let prequel = Prefixed_Name(rdarel, "prequel") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abstractOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstract of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractOfExpression">http://rdvocab.info/RDARelationshipsWEMI/abstractOfExpression</seealso>
    let abstractOfExpression =
        Prefixed_Name(rdarel, "abstractOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptionOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Description of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfWork">http://rdvocab.info/RDARelationshipsWEMI/descriptionOfWork</seealso>
    let descriptionOfWork = Prefixed_Name(rdarel, "descriptionOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:appendixTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Appendix to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/appendixTo">http://rdvocab.info/RDARelationshipsWEMI/appendixTo</seealso>
    let appendixTo = Prefixed_Name(rdarel, "appendixTo") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:appendixToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Appendix to (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/appendixToExpression">http://rdvocab.info/RDARelationshipsWEMI/appendixToExpression</seealso>
    let appendixToExpression =
        Prefixed_Name(rdarel, "appendixToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:catalogueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Catalogue of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOf">http://rdvocab.info/RDARelationshipsWEMI/catalogueOf</seealso>
    let catalogueOf = Prefixed_Name(rdarel, "catalogueOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:findingAidFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Finding aid for</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/findingAidFor">http://rdvocab.info/RDARelationshipsWEMI/findingAidFor</seealso>
    let findingAidFor = Prefixed_Name(rdarel, "findingAidFor") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:errataTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Errata to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/errataTo">http://rdvocab.info/RDARelationshipsWEMI/errataTo</seealso>
    let errataTo = Prefixed_Name(rdarel, "errataTo") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:catalogueOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Catalogue of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOfExpression">http://rdvocab.info/RDARelationshipsWEMI/catalogueOfExpression</seealso>
    let catalogueOfExpression =
        Prefixed_Name(rdarel, "catalogueOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:illustrationsForExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Illustrations for (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsForExpression">http://rdvocab.info/RDARelationshipsWEMI/illustrationsForExpression</seealso>
    let illustrationsForExpression =
        Prefixed_Name(rdarel, "illustrationsForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:errataToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Errata to (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/errataToExpression">http://rdvocab.info/RDARelationshipsWEMI/errataToExpression</seealso>
    let errataToExpression = Prefixed_Name(rdarel, "errataToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:concordanceToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Concordance to (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/concordanceToExpression">http://rdvocab.info/RDARelationshipsWEMI/concordanceToExpression</seealso>
    let concordanceToExpression =
        Prefixed_Name(rdarel, "concordanceToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:indexToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Index to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexToWork">http://rdvocab.info/RDARelationshipsWEMI/indexToWork</seealso>
    let indexToWork = Prefixed_Name(rdarel, "indexToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:errataToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Errata to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/errataToWork">http://rdvocab.info/RDARelationshipsWEMI/errataToWork</seealso>
    let errataToWork = Prefixed_Name(rdarel, "errataToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:catalogueOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Catalogue of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOfWork">http://rdvocab.info/RDARelationshipsWEMI/catalogueOfWork</seealso>
    let catalogueOfWork = Prefixed_Name(rdarel, "catalogueOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:supplementToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supplement to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supplementToWork">http://rdvocab.info/RDARelationshipsWEMI/supplementToWork</seealso>
    let supplementToWork = Prefixed_Name(rdarel, "supplementToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:illustrations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Illustrations</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/illustrations">http://rdvocab.info/RDARelationshipsWEMI/illustrations</seealso>
    let illustrations = Prefixed_Name(rdarel, "illustrations") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supplementExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supplement (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supplementExpression">http://rdvocab.info/RDARelationshipsWEMI/supplementExpression</seealso>
    let supplementExpression =
        Prefixed_Name(rdarel, "supplementExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:catalogueExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Catalogue (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/catalogueExpression">http://rdvocab.info/RDARelationshipsWEMI/catalogueExpression</seealso>
    let catalogueExpression =
        Prefixed_Name(rdarel, "catalogueExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:guideWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Guide (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/guideWork">http://rdvocab.info/RDARelationshipsWEMI/guideWork</seealso>
    let guideWork = Prefixed_Name(rdarel, "guideWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:concordanceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Concordance (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/concordanceWork">http://rdvocab.info/RDARelationshipsWEMI/concordanceWork</seealso>
    let concordanceWork = Prefixed_Name(rdarel, "concordanceWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:indexWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Index (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexWork">http://rdvocab.info/RDARelationshipsWEMI/indexWork</seealso>
    let indexWork = Prefixed_Name(rdarel, "indexWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:errataWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Errata (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/errataWork">http://rdvocab.info/RDARelationshipsWEMI/errataWork</seealso>
    let errataWork = Prefixed_Name(rdarel, "errataWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:digestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digest of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digestOf">http://rdvocab.info/RDARelationshipsWEMI/digestOf</seealso>
    let digestOf = Prefixed_Name(rdarel, "digestOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:paraphraseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Paraphrase of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOf">http://rdvocab.info/RDARelationshipsWEMI/paraphraseOf</seealso>
    let paraphraseOf = Prefixed_Name(rdarel, "paraphraseOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:choreographyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Choreography for</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/choreographyFor">http://rdvocab.info/RDARelationshipsWEMI/choreographyFor</seealso>
    let choreographyFor = Prefixed_Name(rdarel, "choreographyFor") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalVariationsBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical variations based on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOn">http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOn</seealso>
    let musicalVariationsBasedOn =
        Prefixed_Name(rdarel, "musicalVariationsBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:freeTranslationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Free translation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfExpression</seealso>
    let freeTranslationOfExpression =
        Prefixed_Name(rdarel, "freeTranslationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:revisionOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Revision of (expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/revisionOfExpression">http://rdvocab.info/RDARelationshipsWEMI/revisionOfExpression</seealso>
    let revisionOfExpression =
        Prefixed_Name(rdarel, "revisionOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:librettoBasedOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto based on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnExpression">http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnExpression</seealso>
    let librettoBasedOnExpression =
        Prefixed_Name(rdarel, "librettoBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:imitationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Imitation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/imitationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/imitationOfExpression</seealso>
    let imitationOfExpression =
        Prefixed_Name(rdarel, "imitationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalSettingExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical setting (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingExpression">http://rdvocab.info/RDARelationshipsWEMI/musicalSettingExpression</seealso>
    let musicalSettingExpression =
        Prefixed_Name(rdarel, "musicalSettingExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:imitatedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Imitated as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/imitatedAsExpression</seealso>
    let imitatedAsExpression =
        Prefixed_Name(rdarel, "imitatedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:indexedInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Indexed in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexedInExpression">http://rdvocab.info/RDARelationshipsWEMI/indexedInExpression</seealso>
    let indexedInExpression =
        Prefixed_Name(rdarel, "indexedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:translatedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Translated as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/translatedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/translatedAsExpression</seealso>
    let translatedAsExpression =
        Prefixed_Name(rdarel, "translatedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:imitatedAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Imitated as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAsWork">http://rdvocab.info/RDARelationshipsWEMI/imitatedAsWork</seealso>
    let imitatedAsWork = Prefixed_Name(rdarel, "imitatedAsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalVariationsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical variations (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsWork">http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsWork</seealso>
    let musicalVariationsWork =
        Prefixed_Name(rdarel, "musicalVariationsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:paraphrasedAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Paraphrased as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsWork">http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsWork</seealso>
    let paraphrasedAsWork = Prefixed_Name(rdarel, "paraphrasedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:digestWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digest (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digestWork">http://rdvocab.info/RDARelationshipsWEMI/digestWork</seealso>
    let digestWork = Prefixed_Name(rdarel, "digestWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptiveRelationships</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Descriptive relationships</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationships">http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationships</seealso>
    let descriptiveRelationships =
        Prefixed_Name(rdarel, "descriptiveRelationships") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:evaluatedInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Evaluated in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedInExpression">http://rdvocab.info/RDARelationshipsWEMI/evaluatedInExpression</seealso>
    let evaluatedInExpression =
        Prefixed_Name(rdarel, "evaluatedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reviewedInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reviewed in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reviewedInExpression">http://rdvocab.info/RDARelationshipsWEMI/reviewedInExpression</seealso>
    let reviewedInExpression =
        Prefixed_Name(rdarel, "reviewedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptiveRelationshipsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Descriptive relationships (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsExpression">http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsExpression</seealso>
    let descriptiveRelationshipsExpression =
        Prefixed_Name(rdarel, "descriptiveRelationshipsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptiveRelationshipsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Descriptive relationships (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsWork">http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsWork</seealso>
    let descriptiveRelationshipsWork =
        Prefixed_Name(rdarel, "descriptiveRelationshipsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:evaluationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Evaluation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOf">http://rdvocab.info/RDARelationshipsWEMI/evaluationOf</seealso>
    let evaluationOf = Prefixed_Name(rdarel, "evaluationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:reviewOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Review of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reviewOf">http://rdvocab.info/RDARelationshipsWEMI/reviewOf</seealso>
    let reviewOf = Prefixed_Name(rdarel, "reviewOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:reviewOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Review of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfExpression">http://rdvocab.info/RDARelationshipsWEMI/reviewOfExpression</seealso>
    let reviewOfExpression = Prefixed_Name(rdarel, "reviewOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:evaluationOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Evaluation of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfItem">http://rdvocab.info/RDARelationshipsWEMI/evaluationOfItem</seealso>
    let evaluationOfItem = Prefixed_Name(rdarel, "evaluationOfItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:reviewOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Review of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfItem">http://rdvocab.info/RDARelationshipsWEMI/reviewOfItem</seealso>
    let reviewOfItem = Prefixed_Name(rdarel, "reviewOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptiveRelationshipsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Descriptive relationships (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsItem">http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsItem</seealso>
    let descriptiveRelationshipsItem =
        Prefixed_Name(rdarel, "descriptiveRelationshipsItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reviewOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Review of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/reviewOfManifestation</seealso>
    let reviewOfManifestation =
        Prefixed_Name(rdarel, "reviewOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:descriptiveRelationshipsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Descriptive relationships (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsManifestation">http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsManifestation</seealso>
    let descriptiveRelationshipsManifestation =
        Prefixed_Name(rdarel, "descriptiveRelationshipsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reviewOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Review of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfWork">http://rdvocab.info/RDARelationshipsWEMI/reviewOfWork</seealso>
    let reviewOfWork = Prefixed_Name(rdarel, "reviewOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:evaluationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Evaluation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfWork">http://rdvocab.info/RDARelationshipsWEMI/evaluationOfWork</seealso>
    let evaluationOfWork = Prefixed_Name(rdarel, "evaluationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:derivativeRelationships</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationships">http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationships</seealso>
    let derivativeRelationships =
        Prefixed_Name(rdarel, "derivativeRelationships") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:digitalTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital transfer</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransfer">http://rdvocab.info/RDARelationshipsWEMI/digitalTransfer</seealso>
    let digitalTransfer = Prefixed_Name(rdarel, "digitalTransfer") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:digitalTransferManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital transfer (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferManifestation">http://rdvocab.info/RDARelationshipsWEMI/digitalTransferManifestation</seealso>
    let digitalTransferManifestation =
        Prefixed_Name(rdarel, "digitalTransferManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reproducedAsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reproduced as (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reproducedAsManifestation">http://rdvocab.info/RDARelationshipsWEMI/reproducedAsManifestation</seealso>
    let reproducedAsManifestation =
        Prefixed_Name(rdarel, "reproducedAsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:digitalTransferOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital transfer of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOf">http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOf</seealso>
    let digitalTransferOf = Prefixed_Name(rdarel, "digitalTransferOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:digitalTransferOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital transfer of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfItem">http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfItem</seealso>
    let digitalTransferOfItem =
        Prefixed_Name(rdarel, "digitalTransferOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:digitalTransferOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digital transfer of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfManifestation</seealso>
    let digitalTransferOfManifestation =
        Prefixed_Name(rdarel, "digitalTransferOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reproductionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reproduction of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOf">http://rdvocab.info/RDARelationshipsWEMI/reproductionOf</seealso>
    let reproductionOf = Prefixed_Name(rdarel, "reproductionOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:reproductionOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reproduction of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOfItem">http://rdvocab.info/RDARelationshipsWEMI/reproductionOfItem</seealso>
    let reproductionOfItem = Prefixed_Name(rdarel, "reproductionOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reproductionOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reproduction of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/reproductionOfManifestation</seealso>
    let reproductionOfManifestation =
        Prefixed_Name(rdarel, "reproductionOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:electronicReproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Electronic reproduction</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproduction">http://rdvocab.info/RDARelationshipsWEMI/electronicReproduction</seealso>
    let electronicReproduction =
        Prefixed_Name(rdarel, "electronicReproduction") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:electronicReproductionManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Electronic reproduction (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionManifestation">http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionManifestation</seealso>
    let electronicReproductionManifestation =
        Prefixed_Name(rdarel, "electronicReproductionManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abstractOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstract of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractOfWork">http://rdvocab.info/RDARelationshipsWEMI/abstractOfWork</seealso>
    let abstractOfWork = Prefixed_Name(rdarel, "abstractOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:supplementTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supplement to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supplementTo">http://rdvocab.info/RDARelationshipsWEMI/supplementTo</seealso>
    let supplementTo = Prefixed_Name(rdarel, "supplementTo") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:illustrationsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Illustrations for</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsFor">http://rdvocab.info/RDARelationshipsWEMI/illustrationsFor</seealso>
    let illustrationsFor = Prefixed_Name(rdarel, "illustrationsFor") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:guideTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Guide to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/guideTo">http://rdvocab.info/RDARelationshipsWEMI/guideTo</seealso>
    let guideTo = Prefixed_Name(rdarel, "guideTo") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:indexToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Index to (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexToExpression">http://rdvocab.info/RDARelationshipsWEMI/indexToExpression</seealso>
    let indexToExpression = Prefixed_Name(rdarel, "indexToExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:findingAidForWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Finding aid for (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/findingAidForWork">http://rdvocab.info/RDARelationshipsWEMI/findingAidForWork</seealso>
    let findingAidForWork = Prefixed_Name(rdarel, "findingAidForWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:supplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supplement</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supplement">http://rdvocab.info/RDARelationshipsWEMI/supplement</seealso>
    let supplement = Prefixed_Name(rdarel, "supplement") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:errata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Errata</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/errata">http://rdvocab.info/RDARelationshipsWEMI/errata</seealso>
    let errata = Prefixed_Name(rdarel, "errata") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Index</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/index">http://rdvocab.info/RDARelationshipsWEMI/index</seealso>
    let index = Prefixed_Name(rdarel, "index") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:indexExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Index (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexExpression">http://rdvocab.info/RDARelationshipsWEMI/indexExpression</seealso>
    let indexExpression = Prefixed_Name(rdarel, "indexExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:errataExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Errata (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/errataExpression">http://rdvocab.info/RDARelationshipsWEMI/errataExpression</seealso>
    let errataExpression = Prefixed_Name(rdarel, "errataExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:concordanceTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Concordance to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/concordanceTo">http://rdvocab.info/RDARelationshipsWEMI/concordanceTo</seealso>
    let concordanceTo = Prefixed_Name(rdarel, "concordanceTo") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:indexTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Index to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexTo">http://rdvocab.info/RDARelationshipsWEMI/indexTo</seealso>
    let indexTo = Prefixed_Name(rdarel, "indexTo") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:guideToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Guide to (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/guideToExpression">http://rdvocab.info/RDARelationshipsWEMI/guideToExpression</seealso>
    let guideToExpression = Prefixed_Name(rdarel, "guideToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supplementToExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supplement to (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supplementToExpression">http://rdvocab.info/RDARelationshipsWEMI/supplementToExpression</seealso>
    let supplementToExpression =
        Prefixed_Name(rdarel, "supplementToExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:findingAidForExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Finding aid for (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/findingAidForExpression">http://rdvocab.info/RDARelationshipsWEMI/findingAidForExpression</seealso>
    let findingAidForExpression =
        Prefixed_Name(rdarel, "findingAidForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:illustrationsForWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Illustrations for (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsForWork">http://rdvocab.info/RDARelationshipsWEMI/illustrationsForWork</seealso>
    let illustrationsForWork =
        Prefixed_Name(rdarel, "illustrationsForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:guideToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Guide to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/guideToWork">http://rdvocab.info/RDARelationshipsWEMI/guideToWork</seealso>
    let guideToWork = Prefixed_Name(rdarel, "guideToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:concordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Concordance</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/concordance">http://rdvocab.info/RDARelationshipsWEMI/concordance</seealso>
    let concordance = Prefixed_Name(rdarel, "concordance") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:catalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Catalogue</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/catalogue">http://rdvocab.info/RDARelationshipsWEMI/catalogue</seealso>
    let catalogue = Prefixed_Name(rdarel, "catalogue") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:guideExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Guide (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/guideExpression">http://rdvocab.info/RDARelationshipsWEMI/guideExpression</seealso>
    let guideExpression = Prefixed_Name(rdarel, "guideExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:illustrationsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Illustrations (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsExpression">http://rdvocab.info/RDARelationshipsWEMI/illustrationsExpression</seealso>
    let illustrationsExpression =
        Prefixed_Name(rdarel, "illustrationsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:findingAidWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Finding aid (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/findingAidWork">http://rdvocab.info/RDARelationshipsWEMI/findingAidWork</seealso>
    let findingAidWork = Prefixed_Name(rdarel, "findingAidWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:catalogueWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Catalogue (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/catalogueWork">http://rdvocab.info/RDARelationshipsWEMI/catalogueWork</seealso>
    let catalogueWork = Prefixed_Name(rdarel, "catalogueWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:librettoBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto based on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOn">http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOn</seealso>
    let librettoBasedOn = Prefixed_Name(rdarel, "librettoBasedOn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:summaryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Summary of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/summaryOf">http://rdvocab.info/RDARelationshipsWEMI/summaryOf</seealso>
    let summaryOf = Prefixed_Name(rdarel, "summaryOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:imitationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Imitation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/imitationOf">http://rdvocab.info/RDARelationshipsWEMI/imitationOf</seealso>
    let imitationOf = Prefixed_Name(rdarel, "imitationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:indexingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Indexing for</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexingFor">http://rdvocab.info/RDARelationshipsWEMI/indexingFor</seealso>
    let indexingFor = Prefixed_Name(rdarel, "indexingFor") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalArrangementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical arrangement of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOf">http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOf</seealso>
    let musicalArrangementOf =
        Prefixed_Name(rdarel, "musicalArrangementOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:remadeAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Remade as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/remadeAs">http://rdvocab.info/RDARelationshipsWEMI/remadeAs</seealso>
    let remadeAs = Prefixed_Name(rdarel, "remadeAs") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:digest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digest</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digest">http://rdvocab.info/RDARelationshipsWEMI/digest</seealso>
    let digest = Prefixed_Name(rdarel, "digest") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:freelyTranslatedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Freely translated as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAs">http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAs</seealso>
    let freelyTranslatedAs = Prefixed_Name(rdarel, "freelyTranslatedAs") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:translatedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Translated as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/translatedAs">http://rdvocab.info/RDARelationshipsWEMI/translatedAs</seealso>
    let translatedAs = Prefixed_Name(rdarel, "translatedAs") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Summary</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/summary">http://rdvocab.info/RDARelationshipsWEMI/summary</seealso>
    let summary = Prefixed_Name(rdarel, "summary") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:imitatedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Imitated as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAs">http://rdvocab.info/RDARelationshipsWEMI/imitatedAs</seealso>
    let imitatedAs = Prefixed_Name(rdarel, "imitatedAs") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:paraphrasedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Paraphrased as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsExpression</seealso>
    let paraphrasedAsExpression =
        Prefixed_Name(rdarel, "paraphrasedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalVariationsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical variations (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsExpression">http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsExpression</seealso>
    let musicalVariationsExpression =
        Prefixed_Name(rdarel, "musicalVariationsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:freelyTranslatedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Freely translated as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsExpression</seealso>
    let freelyTranslatedAsExpression =
        Prefixed_Name(rdarel, "freelyTranslatedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:summaryExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Summary (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/summaryExpression">http://rdvocab.info/RDARelationshipsWEMI/summaryExpression</seealso>
    let summaryExpression = Prefixed_Name(rdarel, "summaryExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:freelyTranslatedAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Freely translated as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsWork">http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsWork</seealso>
    let freelyTranslatedAsWork =
        Prefixed_Name(rdarel, "freelyTranslatedAsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:expandedAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Expanded as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/expandedAsWork">http://rdvocab.info/RDARelationshipsWEMI/expandedAsWork</seealso>
    let expandedAsWork = Prefixed_Name(rdarel, "expandedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:musicalSettingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical setting (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingWork">http://rdvocab.info/RDARelationshipsWEMI/musicalSettingWork</seealso>
    let musicalSettingWork = Prefixed_Name(rdarel, "musicalSettingWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:reviewedInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reviewed in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reviewedInWork">http://rdvocab.info/RDARelationshipsWEMI/reviewedInWork</seealso>
    let reviewedInWork = Prefixed_Name(rdarel, "reviewedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:evaluatedInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Evaluated in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedInWork">http://rdvocab.info/RDARelationshipsWEMI/evaluatedInWork</seealso>
    let evaluatedInWork = Prefixed_Name(rdarel, "evaluatedInWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abstractedInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstracted in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractedInExpression">http://rdvocab.info/RDARelationshipsWEMI/abstractedInExpression</seealso>
    let abstractedInExpression =
        Prefixed_Name(rdarel, "abstractedInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:concordanceToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Concordance to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/concordanceToWork">http://rdvocab.info/RDARelationshipsWEMI/concordanceToWork</seealso>
    let concordanceToWork = Prefixed_Name(rdarel, "concordanceToWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:guide</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Guide</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/guide">http://rdvocab.info/RDARelationshipsWEMI/guide</seealso>
    let guide = Prefixed_Name(rdarel, "guide") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:findingAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Finding aid</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/findingAid">http://rdvocab.info/RDARelationshipsWEMI/findingAid</seealso>
    let findingAid = Prefixed_Name(rdarel, "findingAid") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:findingAidExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Finding aid (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/findingAidExpression">http://rdvocab.info/RDARelationshipsWEMI/findingAidExpression</seealso>
    let findingAidExpression =
        Prefixed_Name(rdarel, "findingAidExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:concordanceExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Concordance (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/concordanceExpression">http://rdvocab.info/RDARelationshipsWEMI/concordanceExpression</seealso>
    let concordanceExpression =
        Prefixed_Name(rdarel, "concordanceExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:illustrationsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Illustrations (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsWork">http://rdvocab.info/RDARelationshipsWEMI/illustrationsWork</seealso>
    let illustrationsWork = Prefixed_Name(rdarel, "illustrationsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:supplementWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supplement (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supplementWork">http://rdvocab.info/RDARelationshipsWEMI/supplementWork</seealso>
    let supplementWork = Prefixed_Name(rdarel, "supplementWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:expandedVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Expanded version of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOf">http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOf</seealso>
    let expandedVersionOf = Prefixed_Name(rdarel, "expandedVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:remakeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Remake of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/remakeOf">http://rdvocab.info/RDARelationshipsWEMI/remakeOf</seealso>
    let remakeOf = Prefixed_Name(rdarel, "remakeOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:translationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Translation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/translationOf">http://rdvocab.info/RDARelationshipsWEMI/translationOf</seealso>
    let translationOf = Prefixed_Name(rdarel, "translationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:revisionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Revision of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/revisionOf">http://rdvocab.info/RDARelationshipsWEMI/revisionOf</seealso>
    let revisionOf = Prefixed_Name(rdarel, "revisionOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalSettingOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical setting of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfExpression">http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfExpression</seealso>
    let musicalSettingOfExpression =
        Prefixed_Name(rdarel, "musicalSettingOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:summaryOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Summary of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/summaryOfExpression">http://rdvocab.info/RDARelationshipsWEMI/summaryOfExpression</seealso>
    let summaryOfExpression =
        Prefixed_Name(rdarel, "summaryOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalVariationsBasedOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical variations based on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnExpression">http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnExpression</seealso>
    let musicalVariationsBasedOnExpression =
        Prefixed_Name(rdarel, "musicalVariationsBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:remakeOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Remake of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/remakeOfExpression">http://rdvocab.info/RDARelationshipsWEMI/remakeOfExpression</seealso>
    let remakeOfExpression = Prefixed_Name(rdarel, "remakeOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalVariationsBasedOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical variations based on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnWork">http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnWork</seealso>
    let musicalVariationsBasedOnWork =
        Prefixed_Name(rdarel, "musicalVariationsBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:paraphraseOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Paraphrase of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfWork">http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfWork</seealso>
    let paraphraseOfWork = Prefixed_Name(rdarel, "paraphraseOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:freeTranslationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Free translation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfWork">http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfWork</seealso>
    let freeTranslationOfWork =
        Prefixed_Name(rdarel, "freeTranslationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:digestOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digest of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digestOfWork">http://rdvocab.info/RDARelationshipsWEMI/digestOfWork</seealso>
    let digestOfWork = Prefixed_Name(rdarel, "digestOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:derivativeRelationshipWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Derivative relationship (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipWork">http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipWork</seealso>
    let derivativeRelationshipWork =
        Prefixed_Name(rdarel, "derivativeRelationshipWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:cadenza</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Cadenza</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/cadenza">http://rdvocab.info/RDARelationshipsWEMI/cadenza</seealso>
    let cadenza = Prefixed_Name(rdarel, "cadenza") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:cadenzaExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Cadenza (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaExpression">http://rdvocab.info/RDARelationshipsWEMI/cadenzaExpression</seealso>
    let cadenzaExpression = Prefixed_Name(rdarel, "cadenzaExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:complementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Complemented by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/complementedBy">http://rdvocab.info/RDARelationshipsWEMI/complementedBy</seealso>
    let complementedBy = Prefixed_Name(rdarel, "complementedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:cadenzaComposedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Cadenza composed for</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedFor">http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedFor</seealso>
    let cadenzaComposedFor = Prefixed_Name(rdarel, "cadenzaComposedFor") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:abstractsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstracts for</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractsFor">http://rdvocab.info/RDARelationshipsWEMI/abstractsFor</seealso>
    let abstractsFor = Prefixed_Name(rdarel, "abstractsFor") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:derivativeRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Derivative relationship</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationship">http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationship</seealso>
    let derivativeRelationship =
        Prefixed_Name(rdarel, "derivativeRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:indexedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Indexed in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexedIn">http://rdvocab.info/RDARelationshipsWEMI/indexedIn</seealso>
    let indexedIn = Prefixed_Name(rdarel, "indexedIn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:derivativeRelationshipExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Derivative relationship (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipExpression">http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipExpression</seealso>
    let derivativeRelationshipExpression =
        Prefixed_Name(rdarel, "derivativeRelationshipExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:paraphrasedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Paraphrased as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAs">http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAs</seealso>
    let paraphrasedAs = Prefixed_Name(rdarel, "paraphrasedAs") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:musicalSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical setting</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalSetting">http://rdvocab.info/RDARelationshipsWEMI/musicalSetting</seealso>
    let musicalSetting = Prefixed_Name(rdarel, "musicalSetting") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:imusicalVariations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical variations</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/imusicalVariations">http://rdvocab.info/RDARelationshipsWEMI/imusicalVariations</seealso>
    let imusicalVariations = Prefixed_Name(rdarel, "imusicalVariations") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:remadeAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Remade as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/remadeAsExpression">http://rdvocab.info/RDARelationshipsWEMI/remadeAsExpression</seealso>
    let remadeAsExpression = Prefixed_Name(rdarel, "remadeAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:expandedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Expanded as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/expandedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/expandedAsExpression</seealso>
    let expandedAsExpression =
        Prefixed_Name(rdarel, "expandedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:parodiedAsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parodied as (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAsExpression">http://rdvocab.info/RDARelationshipsWEMI/parodiedAsExpression</seealso>
    let parodiedAsExpression =
        Prefixed_Name(rdarel, "parodiedAsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abstractsForWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abstracts for (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abstractsForWork">http://rdvocab.info/RDARelationshipsWEMI/abstractsForWork</seealso>
    let abstractsForWork = Prefixed_Name(rdarel, "abstractsForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalArrangementOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical arrangement of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOfExpression">http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOfExpression</seealso>
    let musicalArrangementOfExpression =
        Prefixed_Name(rdarel, "musicalArrangementOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:indexingForExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Indexing for (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexingForExpression">http://rdvocab.info/RDARelationshipsWEMI/indexingForExpression</seealso>
    let indexingForExpression =
        Prefixed_Name(rdarel, "indexingForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:imitationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Imitation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/imitationOfWork">http://rdvocab.info/RDARelationshipsWEMI/imitationOfWork</seealso>
    let imitationOfWork = Prefixed_Name(rdarel, "imitationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:expandedVersionOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Expanded version of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfWork">http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfWork</seealso>
    let expandedVersionOfWork =
        Prefixed_Name(rdarel, "expandedVersionOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:librettoBasedOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto based on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnWork">http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnWork</seealso>
    let librettoBasedOnWork =
        Prefixed_Name(rdarel, "librettoBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:choreographyForWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Choreography for (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/choreographyForWork">http://rdvocab.info/RDARelationshipsWEMI/choreographyForWork</seealso>
    let choreographyForWork =
        Prefixed_Name(rdarel, "choreographyForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:accompaniedByManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Accompanied by (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedByManifestation">http://rdvocab.info/RDARelationshipsWEMI/accompaniedByManifestation</seealso>
    let accompaniedByManifestation =
        Prefixed_Name(rdarel, "accompaniedByManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:filmedWithItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Filmed with (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/filmedWithItem">http://rdvocab.info/RDARelationshipsWEMI/filmedWithItem</seealso>
    let filmedWithItem = Prefixed_Name(rdarel, "filmedWithItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:augmentedByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Augmented by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/augmentedByExpression">http://rdvocab.info/RDARelationshipsWEMI/augmentedByExpression</seealso>
    let augmentedByExpression =
        Prefixed_Name(rdarel, "augmentedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:accompanyingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Accompanying work</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/accompanyingWork">http://rdvocab.info/RDARelationshipsWEMI/accompanyingWork</seealso>
    let accompanyingWork = Prefixed_Name(rdarel, "accompanyingWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:videoAdaptationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video adaptation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOf">http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOf</seealso>
    let videoAdaptationOf = Prefixed_Name(rdarel, "videoAdaptationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:novelizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Novelization of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOf">http://rdvocab.info/RDARelationshipsWEMI/novelizationOf</seealso>
    let novelizationOf = Prefixed_Name(rdarel, "novelizationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:verseAdaptationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Verse adaptation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOf">http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOf</seealso>
    let verseAdaptationOf = Prefixed_Name(rdarel, "verseAdaptationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:reproducedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reproduced as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reproducedAs">http://rdvocab.info/RDARelationshipsWEMI/reproducedAs</seealso>
    let reproducedAs = Prefixed_Name(rdarel, "reproducedAs") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:supersededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Superseded by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersededBy">http://rdvocab.info/RDARelationshipsWEMI/supersededBy</seealso>
    let supersededBy = Prefixed_Name(rdarel, "supersededBy") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersededInPartByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    /// labels<para>Superseded in part by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByExpression">http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByExpression</seealso>
    let supersededInPartByExpression =
        Prefixed_Name(rdarel, "supersededInPartByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:boundWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Bound with</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/boundWith">http://rdvocab.info/RDARelationshipsWEMI/boundWith</seealso>
    let boundWith = Prefixed_Name(rdarel, "boundWith") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:musicalArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical arrangement</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangement">http://rdvocab.info/RDARelationshipsWEMI/musicalArrangement</seealso>
    let musicalArrangement = Prefixed_Name(rdarel, "musicalArrangement") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:musicalArrangementExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Musical arrangement (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementExpression">http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementExpression</seealso>
    let musicalArrangementExpression =
        Prefixed_Name(rdarel, "musicalArrangementExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:digestExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Digest (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/digestExpression">http://rdvocab.info/RDARelationshipsWEMI/digestExpression</seealso>
    let digestExpression = Prefixed_Name(rdarel, "digestExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:summaryWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Summary (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/summaryWork">http://rdvocab.info/RDARelationshipsWEMI/summaryWork</seealso>
    let summaryWork = Prefixed_Name(rdarel, "summaryWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:indexedInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Indexed in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexedInWork">http://rdvocab.info/RDARelationshipsWEMI/indexedInWork</seealso>
    let indexedInWork = Prefixed_Name(rdarel, "indexedInWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:remadeAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Remade as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/remadeAsWork">http://rdvocab.info/RDARelationshipsWEMI/remadeAsWork</seealso>
    let remadeAsWork = Prefixed_Name(rdarel, "remadeAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:reviewedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reviewed in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reviewedIn">http://rdvocab.info/RDARelationshipsWEMI/reviewedIn</seealso>
    let reviewedIn = Prefixed_Name(rdarel, "reviewedIn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:evaluatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Evaluated in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedIn">http://rdvocab.info/RDARelationshipsWEMI/evaluatedIn</seealso>
    let evaluatedIn = Prefixed_Name(rdarel, "evaluatedIn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:onDiscWithItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>On disc with (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWithItem">http://rdvocab.info/RDARelationshipsWEMI/onDiscWithItem</seealso>
    let onDiscWithItem = Prefixed_Name(rdarel, "onDiscWithItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:issuedWithManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Issued with (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/issuedWithManifestation">http://rdvocab.info/RDARelationshipsWEMI/issuedWithManifestation</seealso>
    let issuedWithManifestation =
        Prefixed_Name(rdarel, "issuedWithManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:cadenzaWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Cadenza (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaWork">http://rdvocab.info/RDARelationshipsWEMI/cadenzaWork</seealso>
    let cadenzaWork = Prefixed_Name(rdarel, "cadenzaWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:cadenzaComposedForExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Cadenza composed for (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForExpression">http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForExpression</seealso>
    let cadenzaComposedForExpression =
        Prefixed_Name(rdarel, "cadenzaComposedForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:choreography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Choreography</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/choreography">http://rdvocab.info/RDARelationshipsWEMI/choreography</seealso>
    let choreography = Prefixed_Name(rdarel, "choreography") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:choreographyExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Choreography (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/choreographyExpression">http://rdvocab.info/RDARelationshipsWEMI/choreographyExpression</seealso>
    let choreographyExpression =
        Prefixed_Name(rdarel, "choreographyExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:choreographyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Choreography (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/choreographyWork">http://rdvocab.info/RDARelationshipsWEMI/choreographyWork</seealso>
    let choreographyWork = Prefixed_Name(rdarel, "choreographyWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:commentaryIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Commentary in</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/commentaryIn">http://rdvocab.info/RDARelationshipsWEMI/commentaryIn</seealso>
    let commentaryIn = Prefixed_Name(rdarel, "commentaryIn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:commentaryInExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Commentary in (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/commentaryInExpression">http://rdvocab.info/RDARelationshipsWEMI/commentaryInExpression</seealso>
    let commentaryInExpression =
        Prefixed_Name(rdarel, "commentaryInExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:commentaryOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Commentary on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOn">http://rdvocab.info/RDARelationshipsWEMI/commentaryOn</seealso>
    let commentaryOn = Prefixed_Name(rdarel, "commentaryOn") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:commentaryOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Commentary on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnWork">http://rdvocab.info/RDARelationshipsWEMI/commentaryOnWork</seealso>
    let commentaryOnWork = Prefixed_Name(rdarel, "commentaryOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:commentaryOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Commentary on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnExpression">http://rdvocab.info/RDARelationshipsWEMI/commentaryOnExpression</seealso>
    let commentaryOnExpression =
        Prefixed_Name(rdarel, "commentaryOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:commentaryOnItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Commentary on (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnItem">http://rdvocab.info/RDARelationshipsWEMI/commentaryOnItem</seealso>
    let commentaryOnItem = Prefixed_Name(rdarel, "commentaryOnItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersededInPartByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    /// labels<para>Superseded in part by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByWork">http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByWork</seealso>
    let supersededInPartByWork =
        Prefixed_Name(rdarel, "supersededInPartByWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersededByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    /// labels<para>Superseded by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersededByWork">http://rdvocab.info/RDARelationshipsWEMI/supersededByWork</seealso>
    let supersededByWork = Prefixed_Name(rdarel, "supersededByWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:indexingForWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Indexing for (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/indexingForWork">http://rdvocab.info/RDARelationshipsWEMI/indexingForWork</seealso>
    let indexingForWork = Prefixed_Name(rdarel, "indexingForWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:basisForLibrettoExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Basis for libretto (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/basisForLibrettoExpression">http://rdvocab.info/RDARelationshipsWEMI/basisForLibrettoExpression</seealso>
    let basisForLibrettoExpression =
        Prefixed_Name(rdarel, "basisForLibrettoExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:evaluationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Evaluation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/evaluationOfExpression</seealso>
    let evaluationOfExpression =
        Prefixed_Name(rdarel, "evaluationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:evaluationOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Evaluation of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/evaluationOfManifestation</seealso>
    let evaluationOfManifestation =
        Prefixed_Name(rdarel, "evaluationOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:manifestationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Manifestation of work</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/manifestationOfWork">http://rdvocab.info/RDARelationshipsWEMI/manifestationOfWork</seealso>
    let manifestationOfWork =
        Prefixed_Name(rdarel, "manifestationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:mergedWithToForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Merged with to form</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToForm">http://rdvocab.info/RDARelationshipsWEMI/mergedWithToForm</seealso>
    let mergedWithToForm = Prefixed_Name(rdarel, "mergedWithToForm") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:mergedWithToFormExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Merged with to form (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormExpression">http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormExpression</seealso>
    let mergedWithToFormExpression =
        Prefixed_Name(rdarel, "mergedWithToFormExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:mergerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Merger of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/mergerOf">http://rdvocab.info/RDARelationshipsWEMI/mergerOf</seealso>
    let mergerOf = Prefixed_Name(rdarel, "mergerOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:mergerOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Merger of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/mergerOfWork">http://rdvocab.info/RDARelationshipsWEMI/mergerOfWork</seealso>
    let mergerOfWork = Prefixed_Name(rdarel, "mergerOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:motionPictureAdaptationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Motion picture adaptation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfExpression</seealso>
    let motionPictureAdaptationOfExpression =
        Prefixed_Name(rdarel, "motionPictureAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:motionPictureScreenplayBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Motion picture screenplay based on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOn">http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOn</seealso>
    let motionPictureScreenplayBasedOn =
        Prefixed_Name(rdarel, "motionPictureScreenplayBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:motionPictureScreenplayBasedOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Motion picture screenplay based on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnExpression">http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnExpression</seealso>
    let motionPictureScreenplayBasedOnExpression =
        Prefixed_Name(rdarel, "motionPictureScreenplayBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:motionPictureScreenplayBasedOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Motion picture screenplay based on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnWork">http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnWork</seealso>
    let motionPictureScreenplayBasedOnWork =
        Prefixed_Name(rdarel, "motionPictureScreenplayBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:novelizationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Novelization of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/novelizationOfExpression</seealso>
    let novelizationOfExpression =
        Prefixed_Name(rdarel, "novelizationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:numberingOfPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numbering of part</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/numberingOfPart">http://rdvocab.info/RDARelationshipsWEMI/numberingOfPart</seealso>
    let numberingOfPart = Prefixed_Name(rdarel, "numberingOfPart") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:numberingOfPartWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Numbering of part (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/numberingOfPartWork">http://rdvocab.info/RDARelationshipsWEMI/numberingOfPartWork</seealso>
    let numberingOfPartWork =
        Prefixed_Name(rdarel, "numberingOfPartWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:relatedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Related work</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/relatedWork">http://rdvocab.info/RDARelationshipsWEMI/relatedWork</seealso>
    let relatedWork = Prefixed_Name(rdarel, "relatedWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:complementedByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Complemented by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/complementedByExpression">http://rdvocab.info/RDARelationshipsWEMI/complementedByExpression</seealso>
    let complementedByExpression =
        Prefixed_Name(rdarel, "complementedByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:televisionAdaptationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Television adaptation of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOf">http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOf</seealso>
    let televisionAdaptationOf =
        Prefixed_Name(rdarel, "televisionAdaptationOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:dramatizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dramatization of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOf">http://rdvocab.info/RDARelationshipsWEMI/dramatizationOf</seealso>
    let dramatizationOf = Prefixed_Name(rdarel, "dramatizationOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:adaptationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adaptation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOfWork">http://rdvocab.info/RDARelationshipsWEMI/adaptationOfWork</seealso>
    let adaptationOfWork = Prefixed_Name(rdarel, "adaptationOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:mergerOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Merger of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/mergerOfExpression">http://rdvocab.info/RDARelationshipsWEMI/mergerOfExpression</seealso>
    let mergerOfExpression = Prefixed_Name(rdarel, "mergerOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:screenplayBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay based on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOn">http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOn</seealso>
    let screenplayBasedOn = Prefixed_Name(rdarel, "screenplayBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:radioAdaptationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Radio adaptation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfExpression</seealso>
    let radioAdaptationOfExpression =
        Prefixed_Name(rdarel, "radioAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:videoAdaptationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video adaptation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfWork">http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfWork</seealso>
    let videoAdaptationOfWork =
        Prefixed_Name(rdarel, "videoAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:dramatizationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dramatization of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfExpression</seealso>
    let dramatizationOfExpression =
        Prefixed_Name(rdarel, "dramatizationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:televisionAdaptationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Television adaptation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfExpression</seealso>
    let televisionAdaptationOfExpression =
        Prefixed_Name(rdarel, "televisionAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adaptation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptationOfExpression</seealso>
    let adaptationOfExpression =
        Prefixed_Name(rdarel, "adaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayBasedOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay based on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnExpression">http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnExpression</seealso>
    let screenplayBasedOnExpression =
        Prefixed_Name(rdarel, "screenplayBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:videoAdaptationOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video adaptation of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfExpression">http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfExpression</seealso>
    let videoAdaptationOfExpression =
        Prefixed_Name(rdarel, "videoAdaptationOfExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:dramatizationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Dramatization of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfWork">http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfWork</seealso>
    let dramatizationOfWork =
        Prefixed_Name(rdarel, "dramatizationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersededInPartBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Superseded in part by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartBy">http://rdvocab.info/RDARelationshipsWEMI/supersededInPartBy</seealso>
    let supersededInPartBy = Prefixed_Name(rdarel, "supersededInPartBy") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersededByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    /// labels<para>Superseded by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersededByExpression">http://rdvocab.info/RDARelationshipsWEMI/supersededByExpression</seealso>
    let supersededByExpression =
        Prefixed_Name(rdarel, "supersededByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:radioScriptBasedOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Radio script based on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnExpression">http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnExpression</seealso>
    let radioScriptBasedOnExpression =
        Prefixed_Name(rdarel, "radioScriptBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:televisionAdaptationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Television adaptation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfWork">http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfWork</seealso>
    let televisionAdaptationOfWork =
        Prefixed_Name(rdarel, "televisionAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:commentaryInWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Commentary in (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/commentaryInWork">http://rdvocab.info/RDARelationshipsWEMI/commentaryInWork</seealso>
    let commentaryInWork = Prefixed_Name(rdarel, "commentaryInWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:commentaryOnManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Commentary on (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnManifestation">http://rdvocab.info/RDARelationshipsWEMI/commentaryOnManifestation</seealso>
    let commentaryOnManifestation =
        Prefixed_Name(rdarel, "commentaryOnManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:scriptForTheRadioProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Script for the radio programme</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgramme">http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgramme</seealso>
    let scriptForTheRadioProgramme =
        Prefixed_Name(rdarel, "scriptForTheRadioProgramme") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:motionPictureScreenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Motion picture screenplay</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplay">http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplay</seealso>
    let motionPictureScreenplay =
        Prefixed_Name(rdarel, "motionPictureScreenplay") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:libretto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/libretto">http://rdvocab.info/RDARelationshipsWEMI/libretto</seealso>
    let libretto = Prefixed_Name(rdarel, "libretto") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForExpression">http://rdvocab.info/RDARelationshipsWEMI/screenplayForExpression</seealso>
    let screenplayForExpression =
        Prefixed_Name(rdarel, "screenplayForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:motionPictureScreenplayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Motion picture screenplay (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayExpression">http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayExpression</seealso>
    let motionPictureScreenplayExpression =
        Prefixed_Name(rdarel, "motionPictureScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:radioScriptExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Radio script (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptExpression">http://rdvocab.info/RDARelationshipsWEMI/radioScriptExpression</seealso>
    let radioScriptExpression =
        Prefixed_Name(rdarel, "radioScriptExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayExpression">http://rdvocab.info/RDARelationshipsWEMI/screenplayExpression</seealso>
    let screenplayExpression =
        Prefixed_Name(rdarel, "screenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:novelizationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Novelization of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOfWork">http://rdvocab.info/RDARelationshipsWEMI/novelizationOfWork</seealso>
    let novelizationOfWork = Prefixed_Name(rdarel, "novelizationOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:adaptedAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsWork</seealso>
    let adaptedAsWork = Prefixed_Name(rdarel, "adaptedAsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsARadioProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a radio programme</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgramme">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgramme</seealso>
    let adaptedAsARadioProgramme =
        Prefixed_Name(rdarel, "adaptedAsARadioProgramme") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:electronicReproductionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Electronic reproduction of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOf">http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOf</seealso>
    let electronicReproductionOf =
        Prefixed_Name(rdarel, "electronicReproductionOf") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:electronicReproductionOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Electronic reproduction of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfManifestation</seealso>
    let electronicReproductionOfManifestation =
        Prefixed_Name(rdarel, "electronicReproductionOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:equivalenceRelationships</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Equivalence relationships</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationships">http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationships</seealso>
    let equivalenceRelationships =
        Prefixed_Name(rdarel, "equivalenceRelationships") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:equivalenceRelationshipsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Equivalence relationships (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsManifestation">http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsManifestation</seealso>
    let equivalenceRelationshipsManifestation =
        Prefixed_Name(rdarel, "equivalenceRelationshipsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:mirrorSiteManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Mirror site (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/mirrorSiteManifestation">http://rdvocab.info/RDARelationshipsWEMI/mirrorSiteManifestation</seealso>
    let mirrorSiteManifestation =
        Prefixed_Name(rdarel, "mirrorSiteManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supersedes</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersedes">http://rdvocab.info/RDARelationshipsWEMI/supersedes</seealso>
    let supersedes = Prefixed_Name(rdarel, "supersedes") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:separatedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Separated from</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/separatedFrom">http://rdvocab.info/RDARelationshipsWEMI/separatedFrom</seealso>
    let separatedFrom = Prefixed_Name(rdarel, "separatedFrom") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:sequelTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequel to</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequelTo">http://rdvocab.info/RDARelationshipsWEMI/sequelTo</seealso>
    let sequelTo = Prefixed_Name(rdarel, "sequelTo") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:supersedesInPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Supersedes in part</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPart">http://rdvocab.info/RDARelationshipsWEMI/supersedesInPart</seealso>
    let supersedesInPart = Prefixed_Name(rdarel, "supersedesInPart") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:sequentialRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequential relationship</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationship">http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationship</seealso>
    let sequentialRelationship =
        Prefixed_Name(rdarel, "sequentialRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersedesInPartExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    /// labels<para>Supersedes in part (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartExpression">http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartExpression</seealso>
    let supersedesInPartExpression =
        Prefixed_Name(rdarel, "supersedesInPartExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:supersedesExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    /// labels<para>Supersedes (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersedesExpression">http://rdvocab.info/RDARelationshipsWEMI/supersedesExpression</seealso>
    let supersedesExpression =
        Prefixed_Name(rdarel, "supersedesExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:separatedFromExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Separated from (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/separatedFromExpression">http://rdvocab.info/RDARelationshipsWEMI/separatedFromExpression</seealso>
    let separatedFromExpression =
        Prefixed_Name(rdarel, "separatedFromExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:prequelWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Prequel (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/prequelWork">http://rdvocab.info/RDARelationshipsWEMI/prequelWork</seealso>
    let prequelWork = Prefixed_Name(rdarel, "prequelWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:separatedFromWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Separated from (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/separatedFromWork">http://rdvocab.info/RDARelationshipsWEMI/separatedFromWork</seealso>
    let separatedFromWork = Prefixed_Name(rdarel, "separatedFromWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:supersedesWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    /// labels<para>Supersedes (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/supersedesWork">http://rdvocab.info/RDARelationshipsWEMI/supersedesWork</seealso>
    let supersedesWork = Prefixed_Name(rdarel, "supersedesWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:sequelToWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequel to (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequelToWork">http://rdvocab.info/RDARelationshipsWEMI/sequelToWork</seealso>
    let sequelToWork = Prefixed_Name(rdarel, "sequelToWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:sequentialRelationshipWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequential relationship (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipWork">http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipWork</seealso>
    let sequentialRelationshipWork =
        Prefixed_Name(rdarel, "sequentialRelationshipWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reprintOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reprint of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reprintOf">http://rdvocab.info/RDARelationshipsWEMI/reprintOf</seealso>
    let reprintOf = Prefixed_Name(rdarel, "reprintOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:reprintOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reprint of (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reprintOfItem">http://rdvocab.info/RDARelationshipsWEMI/reprintOfItem</seealso>
    let reprintOfItem = Prefixed_Name(rdarel, "reprintOfItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reprintOfManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reprint of (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reprintOfManifestation">http://rdvocab.info/RDARelationshipsWEMI/reprintOfManifestation</seealso>
    let reprintOfManifestation =
        Prefixed_Name(rdarel, "reprintOfManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reprintedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reprinted as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reprintedAs">http://rdvocab.info/RDARelationshipsWEMI/reprintedAs</seealso>
    let reprintedAs = Prefixed_Name(rdarel, "reprintedAs") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:reprintedAsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Reprinted as (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/reprintedAsManifestation">http://rdvocab.info/RDARelationshipsWEMI/reprintedAsManifestation</seealso>
    let reprintedAsManifestation =
        Prefixed_Name(rdarel, "reprintedAsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:equivalentItem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/equivalentItem">http://rdvocab.info/RDARelationshipsWEMI/equivalentItem</seealso>
    let equivalentItem = Prefixed_Name(rdarel, "equivalentItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:televisionScreenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Television screenplay</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplay">http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplay</seealso>
    let televisionScreenplay =
        Prefixed_Name(rdarel, "televisionScreenplay") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:videoScreenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video screenplay</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplay">http://rdvocab.info/RDARelationshipsWEMI/videoScreenplay</seealso>
    let videoScreenplay = Prefixed_Name(rdarel, "videoScreenplay") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:videoScreenplayBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video screenplay based on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOn">http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOn</seealso>
    let videoScreenplayBasedOn =
        Prefixed_Name(rdarel, "videoScreenplayBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:televisionScreenplayBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Television screenplay based on</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOn">http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOn</seealso>
    let televisionScreenplayBasedOn =
        Prefixed_Name(rdarel, "televisionScreenplayBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:BasisForLibrettoWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Basis for libretto (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/BasisForLibrettoWork">http://rdvocab.info/RDARelationshipsWEMI/BasisForLibrettoWork</seealso>
    let BasisForLibrettoWork =
        Prefixed_Name(rdarel, "BasisForLibrettoWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:abridgedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abridged as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAs">http://rdvocab.info/RDARelationshipsWEMI/abridgedAs</seealso>
    let abridgedAs = Prefixed_Name(rdarel, "abridgedAs") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:derivativeExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/derivativeExpression">http://rdvocab.info/RDARelationshipsWEMI/derivativeExpression</seealso>
    let derivativeExpression =
        Prefixed_Name(rdarel, "derivativeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:precededByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preceded by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/precededByExpression">http://rdvocab.info/RDARelationshipsWEMI/precededByExpression</seealso>
    let precededByExpression =
        Prefixed_Name(rdarel, "precededByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:absorbedInPartByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Absorbed in part by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByWork">http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByWork</seealso>
    let absorbedInPartByWork =
        Prefixed_Name(rdarel, "absorbedInPartByWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:radioScriptBasedOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Radio script based on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnWork">http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnWork</seealso>
    let radioScriptBasedOnWork =
        Prefixed_Name(rdarel, "radioScriptBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:verseAdaptationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Verse adaptation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfWork">http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfWork</seealso>
    let verseAdaptationOfWork =
        Prefixed_Name(rdarel, "verseAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:motionPictureAdaptationOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Motion picture adaptation of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfWork">http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfWork</seealso>
    let motionPictureAdaptationOfWork =
        Prefixed_Name(rdarel, "motionPictureAdaptationOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAVideo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a video</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideo">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideo</seealso>
    let adaptedAsAVideo = Prefixed_Name(rdarel, "adaptedAsAVideo") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAScreenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a screenplay</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplay">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplay</seealso>
    let adaptedAsAScreenplay =
        Prefixed_Name(rdarel, "adaptedAsAScreenplay") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsATelevisionProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a television programme</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgramme">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgramme</seealso>
    let adaptedAsATelevisionProgramme =
        Prefixed_Name(rdarel, "adaptedAsATelevisionProgramme") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsARadioScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a radio script</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScript">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScript</seealso>
    let adaptedAsARadioScript =
        Prefixed_Name(rdarel, "adaptedAsARadioScript") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAMotionPictureExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a motion picture (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureExpression</seealso>
    let adaptedAsAMotionPictureExpression =
        Prefixed_Name(rdarel, "adaptedAsAMotionPictureExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAMotionPictureWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a motion picture (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureWork</seealso>
    let adaptedAsAMotionPictureWork =
        Prefixed_Name(rdarel, "adaptedAsAMotionPictureWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAMotionPictureScreenplayWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a motion picture screenplay (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayWork</seealso>
    let adaptedAsAMotionPictureScreenplayWork =
        Prefixed_Name(rdarel, "adaptedAsAMotionPictureScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAScreenplayWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a screenplay (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayWork</seealso>
    let adaptedAsAScreenplayWork =
        Prefixed_Name(rdarel, "adaptedAsAScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsARadioScriptExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a radio script (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptExpression</seealso>
    let adaptedAsARadioScriptExpression =
        Prefixed_Name(rdarel, "adaptedAsARadioScriptExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsARadioScriptWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a radio script (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptWork</seealso>
    let adaptedAsARadioScriptWork =
        Prefixed_Name(rdarel, "adaptedAsARadioScriptWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsATelevisionScreenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a television screenplay</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplay">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplay</seealso>
    let adaptedAsATelevisionScreenplay =
        Prefixed_Name(rdarel, "adaptedAsATelevisionScreenplay") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAVideoScreenplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a video screenplay</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplay">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplay</seealso>
    let adaptedAsAVideoScreenplay =
        Prefixed_Name(rdarel, "adaptedAsAVideoScreenplay") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAVideoScreenplayWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a video screenplay (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayWork</seealso>
    let adaptedAsAVideoScreenplayWork =
        Prefixed_Name(rdarel, "adaptedAsAVideoScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsATelevisionScreenplayWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a television screenplay (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayWork</seealso>
    let adaptedAsATelevisionScreenplayWork =
        Prefixed_Name(rdarel, "adaptedAsATelevisionScreenplayWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAVideoExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a video (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoExpression">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoExpression</seealso>
    let adaptedAsAVideoExpression =
        Prefixed_Name(rdarel, "adaptedAsAVideoExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:adaptedAsAVideoWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Adapted as a video (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoWork">http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoWork</seealso>
    let adaptedAsAVideoWork =
        Prefixed_Name(rdarel, "adaptedAsAVideoWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:wholePartRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Whole-part relationship</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationship">http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationship</seealso>
    let wholePartRelationship =
        Prefixed_Name(rdarel, "wholePartRelationship") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:wholePartRelationshipExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Whole-part relationship (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipExpression">http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipExpression</seealso>
    let wholePartRelationshipExpression =
        Prefixed_Name(rdarel, "wholePartRelationshipExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:wholePartRelationshipManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Whole-part relationship (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipManifestation">http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipManifestation</seealso>
    let wholePartRelationshipManifestation =
        Prefixed_Name(rdarel, "wholePartRelationshipManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:inSeriesWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>In series (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/inSeriesWork">http://rdvocab.info/RDARelationshipsWEMI/inSeriesWork</seealso>
    let inSeriesWork = Prefixed_Name(rdarel, "inSeriesWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:subseriesOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Subseries of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/subseriesOfWork">http://rdvocab.info/RDARelationshipsWEMI/subseriesOfWork</seealso>
    let subseriesOfWork = Prefixed_Name(rdarel, "subseriesOfWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:librettoForWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto for (work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/librettoForWork">http://rdvocab.info/RDARelationshipsWEMI/librettoForWork</seealso>
    let librettoForWork = Prefixed_Name(rdarel, "librettoForWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:containsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contains (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containsExpression">http://rdvocab.info/RDARelationshipsWEMI/containsExpression</seealso>
    let containsExpression = Prefixed_Name(rdarel, "containsExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:subseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Subseries</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/subseries">http://rdvocab.info/RDARelationshipsWEMI/subseries</seealso>
    let subseries = Prefixed_Name(rdarel, "subseries") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:containsManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contains (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containsManifestation">http://rdvocab.info/RDARelationshipsWEMI/containsManifestation</seealso>
    let containsManifestation =
        Prefixed_Name(rdarel, "containsManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:insert</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Insert</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/insert">http://rdvocab.info/RDARelationshipsWEMI/insert</seealso>
    let insert = Prefixed_Name(rdarel, "insert") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:specialIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Special issue</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/specialIssue">http://rdvocab.info/RDARelationshipsWEMI/specialIssue</seealso>
    let specialIssue = Prefixed_Name(rdarel, "specialIssue") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:containsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contains (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containsItem">http://rdvocab.info/RDARelationshipsWEMI/containsItem</seealso>
    let containsItem = Prefixed_Name(rdarel, "containsItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:containsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contains (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/containsWork">http://rdvocab.info/RDARelationshipsWEMI/containsWork</seealso>
    let containsWork = Prefixed_Name(rdarel, "containsWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:insertManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Insert (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/insertManifestation">http://rdvocab.info/RDARelationshipsWEMI/insertManifestation</seealso>
    let insertManifestation =
        Prefixed_Name(rdarel, "insertManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:subseriesWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Subseries (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/subseriesWork">http://rdvocab.info/RDARelationshipsWEMI/subseriesWork</seealso>
    let subseriesWork = Prefixed_Name(rdarel, "subseriesWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:seriesContainsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Series contains (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/seriesContainsWork">http://rdvocab.info/RDARelationshipsWEMI/seriesContainsWork</seealso>
    let seriesContainsWork = Prefixed_Name(rdarel, "seriesContainsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:librettoWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/librettoWork">http://rdvocab.info/RDARelationshipsWEMI/librettoWork</seealso>
    let librettoWork = Prefixed_Name(rdarel, "librettoWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:continuedInPartBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Continued in part by</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartBy">http://rdvocab.info/RDARelationshipsWEMI/continuedInPartBy</seealso>
    let continuedInPartBy = Prefixed_Name(rdarel, "continuedInPartBy") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuedInPartByExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to serials.</para>
    /// labels<para>Continued in part by (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByExpression">http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByExpression</seealso>
    let continuedInPartByExpression =
        Prefixed_Name(rdarel, "continuedInPartByExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuedInPartByWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to serials.</para>
    /// labels<para>Continued in part by (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByWork">http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByWork</seealso>
    let continuedInPartByWork =
        Prefixed_Name(rdarel, "continuedInPartByWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuesWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to serials.</para>
    /// labels<para>Continues (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuesWork">http://rdvocab.info/RDARelationshipsWEMI/continuesWork</seealso>
    let continuesWork = Prefixed_Name(rdarel, "continuesWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:continuesInPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Continues in part</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPart">http://rdvocab.info/RDARelationshipsWEMI/continuesInPart</seealso>
    let continuesInPart = Prefixed_Name(rdarel, "continuesInPart") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuesInPartExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to serials.</para>
    /// labels<para>Continues in part (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPartExpression">http://rdvocab.info/RDARelationshipsWEMI/continuesInPartExpression</seealso>
    let continuesInPartExpression =
        Prefixed_Name(rdarel, "continuesInPartExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:continuesInPartWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Apply generally to serials.</para>
    /// labels<para>Continues in part (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPartWork">http://rdvocab.info/RDARelationshipsWEMI/continuesInPartWork</seealso>
    let continuesInPartWork =
        Prefixed_Name(rdarel, "continuesInPartWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:parodiedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parodied as</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAs">http://rdvocab.info/RDARelationshipsWEMI/parodiedAs</seealso>
    let parodiedAs = Prefixed_Name(rdarel, "parodiedAs") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:parodiedAsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parodied as (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAsWork">http://rdvocab.info/RDARelationshipsWEMI/parodiedAsWork</seealso>
    let parodiedAsWork = Prefixed_Name(rdarel, "parodiedAsWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:parodyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parody of</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/parodyOf">http://rdvocab.info/RDARelationshipsWEMI/parodyOf</seealso>
    let parodyOf = Prefixed_Name(rdarel, "parodyOf") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:parodyOfExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parody of (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/parodyOfExpression">http://rdvocab.info/RDARelationshipsWEMI/parodyOfExpression</seealso>
    let parodyOfExpression = Prefixed_Name(rdarel, "parodyOfExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:parodyOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Parody of (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/parodyOfWork">http://rdvocab.info/RDARelationshipsWEMI/parodyOfWork</seealso>
    let parodyOfWork = Prefixed_Name(rdarel, "parodyOfWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:onDiscWithManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>On disc with (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWithManifestation">http://rdvocab.info/RDARelationshipsWEMI/onDiscWithManifestation</seealso>
    let onDiscWithManifestation =
        Prefixed_Name(rdarel, "onDiscWithManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:librettoForExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Libretto for (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/librettoForExpression">http://rdvocab.info/RDARelationshipsWEMI/librettoForExpression</seealso>
    let librettoForExpression =
        Prefixed_Name(rdarel, "librettoForExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:manifestationExemplified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Manifestation exemplified</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/manifestationExemplified">http://rdvocab.info/RDARelationshipsWEMI/manifestationExemplified</seealso>
    let manifestationExemplified =
        Prefixed_Name(rdarel, "manifestationExemplified") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:videoScreenplayBasedOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video screenplay based on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnExpression">http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnExpression</seealso>
    let videoScreenplayBasedOnExpression =
        Prefixed_Name(rdarel, "videoScreenplayBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:televisionScreenplayBasedOnExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Television screenplay based on (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnExpression">http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnExpression</seealso>
    let televisionScreenplayBasedOnExpression =
        Prefixed_Name(rdarel, "televisionScreenplayBasedOnExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:videoScreenplayBasedOnWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video screenplay based on (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnWork">http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnWork</seealso>
    let videoScreenplayBasedOnWork =
        Prefixed_Name(rdarel, "videoScreenplayBasedOnWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:televisionScreenplayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Television screenplay (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayExpression">http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayExpression</seealso>
    let televisionScreenplayExpression =
        Prefixed_Name(rdarel, "televisionScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:videoScreenplayExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Video screenplay (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayExpression">http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayExpression</seealso>
    let videoScreenplayExpression =
        Prefixed_Name(rdarel, "videoScreenplayExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheTelevisionProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the television programme</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgramme">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgramme</seealso>
    let screenplayForTheTelevisionProgramme =
        Prefixed_Name(rdarel, "screenplayForTheTelevisionProgramme") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheVideo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the video</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideo">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideo</seealso>
    let screenplayForTheVideo =
        Prefixed_Name(rdarel, "screenplayForTheVideo") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheMotionPicture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the motion picture</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPicture">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPicture</seealso>
    let screenplayForTheMotionPicture =
        Prefixed_Name(rdarel, "screenplayForTheMotionPicture") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheTelevisionProgrammeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the television programme (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeExpression">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeExpression</seealso>
    let screenplayForTheTelevisionProgrammeExpression =
        Prefixed_Name(rdarel, "screenplayForTheTelevisionProgrammeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheVideoExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the video (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoExpression">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoExpression</seealso>
    let screenplayForTheVideoExpression =
        Prefixed_Name(rdarel, "screenplayForTheVideoExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:screenplayForTheMotionPictureExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Screenplay for the motion picture (Expression)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureExpression">http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureExpression</seealso>
    let screenplayForTheMotionPictureExpression =
        Prefixed_Name(rdarel, "screenplayForTheMotionPictureExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:sequel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequel</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequel">http://rdvocab.info/RDARelationshipsWEMI/sequel</seealso>
    let sequel = Prefixed_Name(rdarel, "sequel") |> PrefixedName
    /// <summary>
    ///   <para>rdarel:sequelWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequel (Work)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequelWork">http://rdvocab.info/RDARelationshipsWEMI/sequelWork</seealso>
    let sequelWork = Prefixed_Name(rdarel, "sequelWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:sequentialRelationshipItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequential relationship (Item)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipItem">http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipItem</seealso>
    let sequentialRelationshipItem =
        Prefixed_Name(rdarel, "sequentialRelationshipItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarel:sequentialRelationshipManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Sequential relationship (Manifestation)</para></remarks>
    /// <seealso href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipManifestation">http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipManifestation</seealso>
    let sequentialRelationshipManifestation =
        Prefixed_Name(rdarel, "sequentialRelationshipManifestation") |> PrefixedName
