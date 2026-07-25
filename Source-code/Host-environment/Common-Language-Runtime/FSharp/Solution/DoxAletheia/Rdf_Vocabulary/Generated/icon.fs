namespace https.w3id.org.icon.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module icon =
    let _namespace_iri = Namespace_Iri icon |> NamespaceIRI
    /// <summary>
    ///   <para>icon:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An event as recognized at level 1 of interpretation, e.g. a man who lifts one hand or a man riding a horse. Generally, all the actions should be described by this class.  When an action is identified, it is suggested to create a Composition with all the elements involved in this action</para>
    /// labels<para>Action (ICON)</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Action">https://w3id.org/icon/ontology/Action</seealso>
    let Action = Prefixed_Name(icon, "Action") |> PrefixedName
    /// <summary>
    ///   <para>icon:composedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This Property links an invenzione with its components, which may vary from Characters, Events, Named Objects, Places to Personifications, Symbols according to the kind of Invenzione is being described.</para>
    /// labels<para>Composed Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/composedOf">https://w3id.org/icon/ontology/composedOf</seealso>
    let composedOf = Prefixed_Name(icon, "composedOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasExpressionalMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links the Expressional Meaning recognized to the Artistic Motif</para>
    /// labels<para>Has Expressional Meaning</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasExpressionalMeaning">https://w3id.org/icon/ontology/hasExpressionalMeaning</seealso>
    let hasExpressionalMeaning =
        Prefixed_Name(icon, "hasExpressionalMeaning") |> PrefixedName

    /// <summary>
    ///   <para>icon:recognizedImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation associates the Image to the Iconographical Recognition that recognizes it at the second level of interpretation.</para>
    /// labels<para>Recognized Image</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedImage">https://w3id.org/icon/ontology/recognizedImage</seealso>
    let recognizedImage = Prefixed_Name(icon, "recognizedImage") |> PrefixedName
    /// <summary>
    ///   <para>icon:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Image is a reification class linking the identified second level subject (namely: Characters, Events, Places, Named Objects, Symbols and Personifications) to the specific interpretation that recognizes it. It represents the subject depicted as a manifestation in the specific artwork taken into account, in contrast to the second level subjects cited and Invenzione, identifying iconographies from an abstract and general point of view. This distinction between the general subject level and the artwork-specific one is functional to identify the variants of a subject in relation to the specific context.</para>
    /// labels<para>Image</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Image">https://w3id.org/icon/ontology/Image</seealso>
    let Image = Prefixed_Name(icon, "Image") |> PrefixedName

    /// <summary>
    ///   <para>icon:IconographicalSynthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Iconographical Synthesis is the enumeration of iconological recognitions of intrinsic meanings recognized by one or more agents concerning a work of art. It is thus a collection of triples. It is the summary of what would be called in Panofsky's term the third level of interpretation.</para>
    /// labels<para>Iconographical Synthesis</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/IconographicalSynthesis">https://w3id.org/icon/ontology/IconographicalSynthesis</seealso>
    let IconographicalSynthesis =
        Prefixed_Name(icon, "IconographicalSynthesis") |> PrefixedName

    /// <summary>
    ///   <para>icon:IconologicalRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Iconological Recognition is a n-ary relationship class that links the artwork described (and optionally all the subjects represented at the first and second level of interpretation) to the Intrinsic Meanings recognized. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed. This class can represent: (1) the third level act of Interpretation described by Panofsky (1939), without a distinction between a overall artwork symbolic meaning and a societal aspect, (2) the third and second level described by Van Straten, according to the value associated to the intrinsic meaning, (3) the iconic act of interpretation described by Imdahl (2012), when the intrinsic meaning is directly linked to level 1 characteristics of the image.</para>
    /// labels<para>Iconological Recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/IconologicalRecognition">https://w3id.org/icon/ontology/IconologicalRecognition</seealso>
    let IconologicalRecognition =
        Prefixed_Name(icon, "IconologicalRecognition") |> PrefixedName

    /// <summary>
    ///   <para>icon:IntrinsicMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>N-ary relatioship class linking the identified cultural phenomenon or deeper meaning to the whole artwork or to the specific part of its representation and to the interpretation that identifies it. From a theoretical point of view, it corresponds to the manifestation in the specific artwork of the concepts and cultural phenomena identified by the iconological analysis. The terminology is taken from Panofsky (1939, 1955).</para>
    /// labels<para>Intrinsic Meaning</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/IntrinsicMeaning">https://w3id.org/icon/ontology/IntrinsicMeaning</seealso>
    let IntrinsicMeaning = Prefixed_Name(icon, "IntrinsicMeaning") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation links an image to the Event depicted</para>
    /// labels<para>Has Event</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasEvent">https://w3id.org/icon/ontology/hasEvent</seealso>
    let hasEvent = Prefixed_Name(icon, "hasEvent") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasNamedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation links an image to the Named Object depicted</para>
    /// labels<para>Has Named Object</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasNamedObject">https://w3id.org/icon/ontology/hasNamedObject</seealso>
    let hasNamedObject = Prefixed_Name(icon, "hasNamedObject") |> PrefixedName
    /// <summary>
    ///   <para>icon:NamedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A named object is a non-living unique element that is often used as an attribute for the recognition of specific characters or as the individuals of a more general concept class. (e.g. Bible for the Book class)</para>
    /// labels<para>Named Object</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/NamedObject">https://w3id.org/icon/ontology/NamedObject</seealso>
    let NamedObject = Prefixed_Name(icon, "NamedObject") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links an image to the Symbol depicted</para>
    /// labels<para>Has Symbol</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasSymbol">https://w3id.org/icon/ontology/hasSymbol</seealso>
    let hasSymbol = Prefixed_Name(icon, "hasSymbol") |> PrefixedName

    /// <summary>
    ///   <para>icon:isIconographicallyRecognizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of recognizedImage</para>
    /// labels<para>Is Iconographically Recognized By</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isIconographicallyRecognizedBy">https://w3id.org/icon/ontology/isIconographicallyRecognizedBy</seealso>
    let isIconographicallyRecognizedBy =
        Prefixed_Name(icon, "isIconographicallyRecognizedBy") |> PrefixedName

    /// <summary>
    ///   <para>icon:isCompliantWithIconologicalRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>inverse of iconologically complies with</para>
    /// labels<para>is compliant with iconological recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isCompliantWithIconologicalRecognition">https://w3id.org/icon/ontology/isCompliantWithIconologicalRecognition</seealso>
    let isCompliantWithIconologicalRecognition =
        Prefixed_Name(icon, "isCompliantWithIconologicalRecognition") |> PrefixedName

    /// <summary>
    ///   <para>icon:recognizedConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation expresses the Concept that is related to the Intrinsic Meaning</para>
    /// labels<para>Recognized Concept</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedConcept">https://w3id.org/icon/ontology/recognizedConcept</seealso>
    let recognizedConcept = Prefixed_Name(icon, "recognizedConcept") |> PrefixedName

    /// <summary>
    ///   <para>icon:recognizedCulturalPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation expresses the Cultural Phenomenon that is related to the Intrinsic Meaning</para>
    /// labels<para>Recognized Cultural Phenomenon</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedCulturalPhenomenon">https://w3id.org/icon/ontology/recognizedCulturalPhenomenon</seealso>
    let recognizedCulturalPhenomenon =
        Prefixed_Name(icon, "recognizedCulturalPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>icon:isIntrinsicMeaningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of recognized intrinsic meaning</para>
    /// labels<para>Is Intrinsic Meaning Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isIntrinsicMeaningOf">https://w3id.org/icon/ontology/isIntrinsicMeaningOf</seealso>
    let isIntrinsicMeaningOf =
        Prefixed_Name(icon, "isIntrinsicMeaningOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represent the material expressed in an artistic motif or image (referring to the element recognized in them)</para>
    /// labels<para>Material</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Material">https://w3id.org/icon/ontology/Material</seealso>
    let Material = Prefixed_Name(icon, "Material") |> PrefixedName

    /// <summary>
    ///   <para>icon:PreiconographicalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Pre-iconographical description is the enumeration of the Pre-Iconographical Recognitions of a certain work of art, performed by one or more agents. It is thus a collection of triples constituting the documentation of the interpretation at level 1. The term and its definition is taken from Panofsky's Studies in Iconology (1939).</para>
    /// labels<para>Preiconographical Description</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/PreiconographicalDescription">https://w3id.org/icon/ontology/PreiconographicalDescription</seealso>
    let PreiconographicalDescription =
        Prefixed_Name(icon, "PreiconographicalDescription") |> PrefixedName

    /// <summary>
    ///   <para>icon:recognizedArtisticMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation associates the Artistic Motif to the Pre-iconographical Recognition that recognizes it at the first level of interpretation.</para>
    /// labels<para>Recognized Artistic Motif</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedArtisticMotif">https://w3id.org/icon/ontology/recognizedArtisticMotif</seealso>
    let recognizedArtisticMotif =
        Prefixed_Name(icon, "recognizedArtisticMotif") |> PrefixedName

    /// <summary>
    ///   <para>icon:recognizedComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation associates the Composition to the Pre-iconographical Recognition that recognizes it at the first level of interpretation.</para>
    /// labels<para>Recognized Composition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedComposition">https://w3id.org/icon/ontology/recognizedComposition</seealso>
    let recognizedComposition =
        Prefixed_Name(icon, "recognizedComposition") |> PrefixedName

    /// <summary>
    ///   <para>icon:aboutWorkOfArt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation associates each Recognition directly to the artwork. In this way, it is possible to retrieve easily all the interpretations about an artwork. Therefore, it a highly recommended good practice to declare it for each interpretation.</para>
    /// labels<para>About Work Of Art</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/aboutWorkOfArt">https://w3id.org/icon/ontology/aboutWorkOfArt</seealso>
    let aboutWorkOfArt = Prefixed_Name(icon, "aboutWorkOfArt") |> PrefixedName
    /// <summary>
    ///   <para>icon:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the Role of an element recognized in an artistic motif or an image.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Role">https://w3id.org/icon/ontology/Role</seealso>
    let Role = Prefixed_Name(icon, "Role") |> PrefixedName
    /// <summary>
    ///   <para>icon:Story</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A story is a cohese combination of images that represent narrative elements such as Characters, Places, Events, Named Objects. The recognition of a story happens in the context of an Iconographical Recognition, and it is included in an Iconographical Description. As the super class Invenzione, it concerns the word of the subject matter. It is not necessary to have multiple images to compose a story.</para>
    /// labels<para>Story</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Story">https://w3id.org/icon/ontology/Story</seealso>
    let Story = Prefixed_Name(icon, "Story") |> PrefixedName
    /// <summary>
    ///   <para>icon:Tendency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a tendency</para>
    /// labels<para>Tendency</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Tendency">https://w3id.org/icon/ontology/Tendency</seealso>
    let Tendency = Prefixed_Name(icon, "Tendency") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of aboutWorkOfArt</para>
    /// labels<para>Has Recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasRecognition">https://w3id.org/icon/ontology/hasRecognition</seealso>
    let hasRecognition = Prefixed_Name(icon, "hasRecognition") |> PrefixedName
    /// <summary>
    ///   <para>icon:associatedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation associates a Pure Form to the Pre-iconographical Recognition that describes it at the first level of interpretation.</para>
    /// labels<para>Associated Form</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/associatedForm">https://w3id.org/icon/ontology/associatedForm</seealso>
    let associatedForm = Prefixed_Name(icon, "associatedForm") |> PrefixedName
    /// <summary>
    ///   <para>icon:isPureFormOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of associatedForm</para>
    /// labels<para>Is Pure Form Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isPureFormOf">https://w3id.org/icon/ontology/isPureFormOf</seealso>
    let isPureFormOf = Prefixed_Name(icon, "isPureFormOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:associatedMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This property is used to link an artistic motif or an image to one of the (recognized) materials of the element that are recognized in those artistic motifs or images. For instance, expressing that the artistic motif representing a crown in a portrait denotes also that the crown is made of bronze. Or that the image of the Thor's Hammer is denoting that the hammer is made of steel.</para>
    /// labels<para>associated Material</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/associatedMaterial">https://w3id.org/icon/ontology/associatedMaterial</seealso>
    let associatedMaterial = Prefixed_Name(icon, "associatedMaterial") |> PrefixedName
    /// <summary>
    ///   <para>icon:takesPartIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of composed of</para>
    /// labels<para>Takes part in</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/takesPartIn">https://w3id.org/icon/ontology/takesPartIn</seealso>
    let takesPartIn = Prefixed_Name(icon, "takesPartIn") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasArtisticMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links an Intrinsic Meaning to the Artistic Motif recognized at the first level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Artistic Motif, and not only to the general artwork.</para>
    /// labels<para>Has Artistic Motif</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasArtisticMotif">https://w3id.org/icon/ontology/hasArtisticMotif</seealso>
    let hasArtisticMotif = Prefixed_Name(icon, "hasArtisticMotif") |> PrefixedName
    /// <summary>
    ///   <para>icon:isArtisticMotifOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of has artistic motif</para>
    /// labels<para>Is artistic motif of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isArtisticMotifOf">https://w3id.org/icon/ontology/isArtisticMotifOf</seealso>
    let isArtisticMotifOf = Prefixed_Name(icon, "isArtisticMotifOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasIconographicalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link an image to the iconographical subject it represents, it is used when it is difficult to distinguish between the different iconographical subjects (for instance in the case of an automatic conversion of data into the ICON ontology)</para>
    /// labels<para>has Iconographical Subject</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasIconographicalSubject">https://w3id.org/icon/ontology/hasIconographicalSubject</seealso>
    let hasIconographicalSubject =
        Prefixed_Name(icon, "hasIconographicalSubject") |> PrefixedName

    /// <summary>
    ///   <para>icon:isCharacterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasCharacter</para>
    /// labels<para>Is Character Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isCharacterOf">https://w3id.org/icon/ontology/isCharacterOf</seealso>
    let isCharacterOf = Prefixed_Name(icon, "isCharacterOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links an Intrinsic Meaning to the Composition recognized at the first level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Composition, and not only to the general artwork.</para>
    /// labels<para>Has Composition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasComposition">https://w3id.org/icon/ontology/hasComposition</seealso>
    let hasComposition = Prefixed_Name(icon, "hasComposition") |> PrefixedName
    /// <summary>
    ///   <para>icon:isCompositionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of has composition</para>
    /// labels<para>Is composition of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isCompositionOf">https://w3id.org/icon/ontology/isCompositionOf</seealso>
    let isCompositionOf = Prefixed_Name(icon, "isCompositionOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasCompositionalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation describes the arrangement of the Artistic Motifs composing the Composition. It is suggested to use it only when they are arranged in a relevant observable structure (e.g. pyramidal, oblique)</para>
    /// labels<para>Has Compositional Structure</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasCompositionalStructure">https://w3id.org/icon/ontology/hasCompositionalStructure</seealso>
    let hasCompositionalStructure =
        Prefixed_Name(icon, "hasCompositionalStructure") |> PrefixedName

    /// <summary>
    ///   <para>icon:isCompositionalStructureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasCompositionalStructure</para>
    /// labels<para>Is Compositional Structure Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isCompositionalStructureOf">https://w3id.org/icon/ontology/isCompositionalStructureOf</seealso>
    let isCompositionalStructureOf =
        Prefixed_Name(icon, "isCompositionalStructureOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:preiconographicallyCompliesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link all the pre-iconographical and formal motif recognitions recognitions that take part in one or more interpretation(s), to that/those interpretation(s)</para>
    /// labels<para>pre-iconographically complies with</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/preiconographicallyCompliesWith">https://w3id.org/icon/ontology/preiconographicallyCompliesWith</seealso>
    let preiconographicallyCompliesWith =
        Prefixed_Name(icon, "preiconographicallyCompliesWith") |> PrefixedName

    /// <summary>
    ///   <para>icon:isCulturalPhenomenonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of recognizedCulturalPhenomenon</para>
    /// labels<para>Is Cultural Phenomenon Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isCulturalPhenomenonOf">https://w3id.org/icon/ontology/isCulturalPhenomenonOf</seealso>
    let isCulturalPhenomenonOf =
        Prefixed_Name(icon, "isCulturalPhenomenonOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:isIconographicallyReferredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of refers to artistic motif</para>
    /// labels<para>Is iconographically referred by</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isIconographicallyReferredBy">https://w3id.org/icon/ontology/isIconographicallyReferredBy</seealso>
    let isIconographicallyReferredBy =
        Prefixed_Name(icon, "isIconographicallyReferredBy") |> PrefixedName

    /// <summary>
    ///   <para>icon:refersToArtisticMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation associates a Composition or an Artistic Motif to the Iconographical Recognition that describes it at the second level of interpretation.</para>
    /// labels<para>Refers To Artistic Motif</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/refersToArtisticMotif">https://w3id.org/icon/ontology/refersToArtisticMotif</seealso>
    let refersToArtisticMotif =
        Prefixed_Name(icon, "refersToArtisticMotif") |> PrefixedName

    /// <summary>
    ///   <para>icon:Personification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A representation of a concept through a human figure</para>
    /// labels<para>Personification (ICON)</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Personification">https://w3id.org/icon/ontology/Personification</seealso>
    let Personification = Prefixed_Name(icon, "Personification") |> PrefixedName
    /// <summary>
    ///   <para>icon:ArtisticMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>An ArtisticMotif is the output of a Pre Iconographic Recognition. It is a N-ary relationship class linking the physical unique representation depicted in an artwork to the corresponding real world meaning recognized. Each artistic motif describes exactly one meaning among: Natural Element, Action, Expression Quality. Qualities (e.g. colors) can be expressed.
    /// The N-ary structure allow first of all to maintain the distinction between the particular representation belonging to the artwork considered and the general meaning of which the representation is an expression. Furthermore, it allows to carefully describe in detail what is represented in the visual representation, since it gives the chance to identify uniquely details of objects and iconographies.</para>
    /// labels<para>Artistic Motif</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/ArtisticMotif">https://w3id.org/icon/ontology/ArtisticMotif</seealso>
    let ArtisticMotif = Prefixed_Name(icon, "ArtisticMotif") |> PrefixedName
    /// <summary>
    ///   <para>icon:ExpressionalQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>An Expression Quality corresponds to the "expressional subject matter" described by Panofsky (1939), which belongs, along with the factual ones, to the Primary or natural subject matter of a work of art. Indeed, it individuates, by way of example, emotions, an atmosphere, the character of a person.</para>
    /// labels<para>Expressional Quality</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/ExpressionalQuality">https://w3id.org/icon/ontology/ExpressionalQuality</seealso>
    let ExpressionalQuality = Prefixed_Name(icon, "ExpressionalQuality") |> PrefixedName

    /// <summary>
    ///   <para>icon:recognizedVisualSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link a Recognition to the recognized Visual Subject.</para>
    /// labels<para>Recognized Visual Subject</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedVisualSubject">https://w3id.org/icon/ontology/recognizedVisualSubject</seealso>
    let recognizedVisualSubject =
        Prefixed_Name(icon, "recognizedVisualSubject") |> PrefixedName

    /// <summary>
    ///   <para>icon:ArtGenre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is substituted by the the solution adopted by linked.art using crm:P2_has_type as follows: &lt;subject&gt;, crm:P2_has_type, &lt;specific style term&gt;.  &lt;specific style term&gt; crm:P2_has_type, &lt;http://vocab.getty.edu/aat/300015646&gt; # the AAT term indicating the concept of style.</para>
    /// labels<para>Art Genre</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/ArtGenre">https://w3id.org/icon/ontology/ArtGenre</seealso>
    let ArtGenre = Prefixed_Name(icon, "ArtGenre") |> PrefixedName
    /// <summary>
    ///   <para>icon:CulturalPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The cultural phenomenon entity expresses the cultural, social and historical aspects of which the work of art can be document. The iconographical evolution of subjects can have a cultural meaning as well. Also the personal characteristics of the artist, or of the patron, can be involved (Wittkower, Van Straten). The cultural phenomena are the object of investigation of an iconological interpretation (Van Straten, 2012, p. 12), which is considered, in the current work, a level 3 interpretation.</para>
    /// labels<para>Cultural Phenomenon</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/CulturalPhenomenon">https://w3id.org/icon/ontology/CulturalPhenomenon</seealso>
    let CulturalPhenomenon = Prefixed_Name(icon, "CulturalPhenomenon") |> PrefixedName

    /// <summary>
    ///   <para>icon:IconographicalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents all the iconographical subjects of an artwork recognized in images</para>
    /// labels<para>Iconographical Subject</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/IconographicalSubject">https://w3id.org/icon/ontology/IconographicalSubject</seealso>
    let IconographicalSubject =
        Prefixed_Name(icon, "IconographicalSubject") |> PrefixedName

    /// <summary>
    ///   <para>icon:isRecognizedCompositionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of recognizedComposition</para>
    /// labels<para>Is Recognized Composition Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isRecognizedCompositionOf">https://w3id.org/icon/ontology/isRecognizedCompositionOf</seealso>
    let isRecognizedCompositionOf =
        Prefixed_Name(icon, "isRecognizedCompositionOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:iconographicallyDepicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link an artwork to the element of the second level of interpretation (iconographical) which it depicts. This elements can be Characters, Symbols, Personifications, Places, Stories, Allegories (and the element these stories and allegories are composed of).
    ///
    /// Example: There is an IconographicalRecognition of Artwork1 of Image1, which is linked to the character Thor through the hasCharacter property.
    ///
    /// Then Artwork1 iconographicallyDepicts Thor.
    ///
    /// Example2: There is an IconographicalRecognition of Artwork1 of Story1, which is the story of the death of Julius C. This story is composed by the Place Rome and the character Julius C. (and more...)
    ///
    /// Then Artwork1 IconographicallyDepicts the story of the death of Julius C., Julius C., and the city of Rome.
    ///
    /// This link can be created automatically through inference thanks to the super property chain, or it can be written by users who are not planning of including contextual information to the interpretation.</para>
    /// labels<para>Iconographically Depicts</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/iconographicallyDepicts">https://w3id.org/icon/ontology/iconographicallyDepicts</seealso>
    let iconographicallyDepicts =
        Prefixed_Name(icon, "iconographicallyDepicts") |> PrefixedName

    /// <summary>
    ///   <para>icon:isRecognizedConceptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of recognizedConcept</para>
    /// labels<para>Is Recognized Concept Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isRecognizedConceptOf">https://w3id.org/icon/ontology/isRecognizedConceptOf</seealso>
    let isRecognizedConceptOf =
        Prefixed_Name(icon, "isRecognizedConceptOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:preiconographicallyDepicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link an artwork to the element of the first level of interpretation (pre-iconographical) which it depicts. This element can be a Natural Element, an Action, Expression, or an element included in a recognized Composition (again, natural element, action, expression).
    ///
    /// Example: There is a PreiconographicalRecognition of Artwork1 of ArtisticMotif1, which is linked to the natural element bear.
    /// Then Artwork1 preiconographicallyDepicts  bear.
    ///
    /// Example2: There is a PreiconographicalRecognition of Artwork1 of ArtisticMotif2, which is linked to the composition1, composed by a bear and the action of eating.
    /// Then Artwork1 preiconographicallyDepicts bear and eating.
    ///
    /// This link can be created automatically through inference thanks to the super property chain, or it can be written by users who are not planning of including contextual information to the interpretation.</para>
    /// labels<para>Pre-iconographically Depicts</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/preiconographicallyDepicts">https://w3id.org/icon/ontology/preiconographicallyDepicts</seealso>
    let preiconographicallyDepicts =
        Prefixed_Name(icon, "preiconographicallyDepicts") |> PrefixedName

    /// <summary>
    ///   <para>icon:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This data property expresses the number or elements represented in an artistic motif, especially when the recognition of each element is not needed</para>
    /// labels<para>Quantity</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/quantity">https://w3id.org/icon/ontology/quantity</seealso>
    let quantity = Prefixed_Name(icon, "quantity") |> PrefixedName
    /// <summary>
    ///   <para>icon:recognizedGenre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is substituted by the the solution adopted by linked.art using crm:P2_has_type as follows: &lt;subject&gt;, crm:P2_has_type, &lt;specific style term&gt;.  &lt;specific style term&gt; crm:P2_has_type, &lt;http://vocab.getty.edu/aat/300015646&gt; # the AAT term indicating the concept of style.</para>
    /// labels<para>Recognized Genre</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedGenre">https://w3id.org/icon/ontology/recognizedGenre</seealso>
    let recognizedGenre = Prefixed_Name(icon, "recognizedGenre") |> PrefixedName
    /// <summary>
    ///   <para>icon:Belief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a Belief</para>
    /// labels<para>Belief</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Belief">https://w3id.org/icon/ontology/Belief</seealso>
    let Belief = Prefixed_Name(icon, "Belief") |> PrefixedName
    /// <summary>
    ///   <para>icon:Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A Character is a real or imaginary being identifiable as a subject in the Iconographical Analysis (level 2 of interpretation)</para>
    /// labels<para>Character</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Character">https://w3id.org/icon/ontology/Character</seealso>
    let Character = Prefixed_Name(icon, "Character") |> PrefixedName

    /// <summary>
    ///   <para>icon:recognizedIntrinsicMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation associates the Intrinsic Meaning to the Iconological Recognition that recognizes it at the third level of interpretation.</para>
    /// labels<para>Recognized Intrinsic Meaning</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedIntrinsicMeaning">https://w3id.org/icon/ontology/recognizedIntrinsicMeaning</seealso>
    let recognizedIntrinsicMeaning =
        Prefixed_Name(icon, "recognizedIntrinsicMeaning") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links an image to the Place depicted</para>
    /// labels<para>Has Place</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasPlace">https://w3id.org/icon/ontology/hasPlace</seealso>
    let hasPlace = Prefixed_Name(icon, "hasPlace") |> PrefixedName
    /// <summary>
    ///   <para>icon:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An identified setting, e.g. the city of Bologna, which is recognized as a Level 2 subject. The recognition of a generic city is formally represented by the Natural Element class (level 1).</para>
    /// labels<para>Place (ICON)</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Place">https://w3id.org/icon/ontology/Place</seealso>
    let Place = Prefixed_Name(icon, "Place") |> PrefixedName
    /// <summary>
    ///   <para>icon:isFactualMeaningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasFactualMeaning</para>
    /// labels<para>Is Factual Meaning Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isFactualMeaningOf">https://w3id.org/icon/ontology/isFactualMeaningOf</seealso>
    let isFactualMeaningOf = Prefixed_Name(icon, "isFactualMeaningOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links an Intrinsic Meaning to the Image recognized at the second level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Image, and not only to the general artwork.</para>
    /// labels<para>Has Image</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasImage">https://w3id.org/icon/ontology/hasImage</seealso>
    let hasImage = Prefixed_Name(icon, "hasImage") |> PrefixedName
    /// <summary>
    ///   <para>icon:isImageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of has image</para>
    /// labels<para>Is image of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isImageOf">https://w3id.org/icon/ontology/isImageOf</seealso>
    let isImageOf = Prefixed_Name(icon, "isImageOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:isNamedObjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasNamedObject</para>
    /// labels<para>Is Named Object Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isNamedObjectOf">https://w3id.org/icon/ontology/isNamedObjectOf</seealso>
    let isNamedObjectOf = Prefixed_Name(icon, "isNamedObjectOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation links a Composition to the Artistic Motifs of which it consists.</para>
    /// labels<para>Has Part (ICON)</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasPart">https://w3id.org/icon/ontology/hasPart</seealso>
    let hasPart = Prefixed_Name(icon, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>icon:isPersonificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasPersonification</para>
    /// labels<para>Is Personification Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isPersonificationOf">https://w3id.org/icon/ontology/isPersonificationOf</seealso>
    let isPersonificationOf = Prefixed_Name(icon, "isPersonificationOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:isPrototypicalMotifOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasPrototypicalMotif</para>
    /// labels<para>Is Prototypical Motif Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isPrototypicalMotifOf">https://w3id.org/icon/ontology/isPrototypicalMotifOf</seealso>
    let isPrototypicalMotifOf =
        Prefixed_Name(icon, "isPrototypicalMotifOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasRecAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation identifies objects belonging to the level 1 as fundamental for the recognition of a certain subject. It is suggested that the Artistic Motif of the object is included in the Composition corresponding to the subject.</para>
    /// labels<para>Has Rec Attribute</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasRecAttribute">https://w3id.org/icon/ontology/hasRecAttribute</seealso>
    let hasRecAttribute = Prefixed_Name(icon, "hasRecAttribute") |> PrefixedName
    /// <summary>
    ///   <para>icon:isRecAttributeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasRecAttribute</para>
    /// labels<para>Is Rec Attribute Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isRecAttributeOf">https://w3id.org/icon/ontology/isRecAttributeOf</seealso>
    let isRecAttributeOf = Prefixed_Name(icon, "isRecAttributeOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link an artistic motif or an image to one of the (recognized) roles of the elements recognized in those artistic motifs or images. For instance, expressing that the role of the man recognized in a painting is "butcher", "prince", etc...</para>
    /// labels<para>has Role</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasRole">https://w3id.org/icon/ontology/hasRole</seealso>
    let hasRole = Prefixed_Name(icon, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>icon:isSymbolOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of has symbol</para>
    /// labels<para>Is Symbol Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isSymbolOf">https://w3id.org/icon/ontology/isSymbolOf</seealso>
    let isSymbolOf = Prefixed_Name(icon, "isSymbolOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:iconographicallyCompliesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link all the iconographical recognitions that take part in one or more interpretation(s), to that/those interpretation(s)</para>
    /// labels<para>iconographically complies with</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/iconographicallyCompliesWith">https://w3id.org/icon/ontology/iconographicallyCompliesWith</seealso>
    let iconographicallyCompliesWith =
        Prefixed_Name(icon, "iconographicallyCompliesWith") |> PrefixedName

    /// <summary>
    ///   <para>icon:iconologicallyCompliesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link all the iconological recognitions that take part in one or more interpretation(s), to that/those interpretation(s)</para>
    /// labels<para>iconologically complies with</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/iconologicallyCompliesWith">https://w3id.org/icon/ontology/iconologicallyCompliesWith</seealso>
    let iconologicallyCompliesWith =
        Prefixed_Name(icon, "iconologicallyCompliesWith") |> PrefixedName

    /// <summary>
    ///   <para>icon:iconologicallyRepresents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link an artwork to the element of the third level of interpretation (iconological) which it represents. This elements can be Cultural Phenomena, Social Objects (abstract concepts).
    ///
    /// Example: There is an IconologicalRecognition of Artwork1 of IntrinsicMeaning1, which is linked to the cultural phenomenon of ImitationOfClassics
    /// Then Artwork1 iconologicallyRepresents  ImitationOfClassics.
    ///
    /// Example2: There is an IconologicalRecognition of Artwork1 of IntrinsicMeaning2, which is linked to the social object "Absurdity" (and to other elements from other levels that suppor this claim...)
    ///
    /// Then Artwork1 IconologicallyRepresents Absurdity
    ///
    /// This link can be created automatically through inference thanks to the super property chain, or it can be written by users who are not planning of including contextual information to the interpretation.</para>
    /// labels<para>Iconologically Represents</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/iconologicallyRepresents">https://w3id.org/icon/ontology/iconologicallyRepresents</seealso>
    let iconologicallyRepresents =
        Prefixed_Name(icon, "iconologicallyRepresents") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation links an image to the Character depicted</para>
    /// labels<para>Has Character</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasCharacter">https://w3id.org/icon/ontology/hasCharacter</seealso>
    let hasCharacter = Prefixed_Name(icon, "hasCharacter") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasPersonification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links an image to the Personification depicted</para>
    /// labels<para>Has Personification</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasPersonification">https://w3id.org/icon/ontology/hasPersonification</seealso>
    let hasPersonification = Prefixed_Name(icon, "hasPersonification") |> PrefixedName

    /// <summary>
    ///   <para>icon:isCompliantWithIconographicalRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse of iconographically complies with</para>
    /// labels<para>is compliant with iconographical recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isCompliantWithIconographicalRecognition">https://w3id.org/icon/ontology/isCompliantWithIconographicalRecognition</seealso>
    let isCompliantWithIconographicalRecognition =
        Prefixed_Name(icon, "isCompliantWithIconographicalRecognition") |> PrefixedName

    /// <summary>
    ///   <para>icon:isCompliantWithPreiconographicalRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse of pre-iconographically complies with</para>
    /// labels<para>is compliant with pre-iconographical recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isCompliantWithPreiconographicalRecognition">https://w3id.org/icon/ontology/isCompliantWithPreiconographicalRecognition</seealso>
    let isCompliantWithPreiconographicalRecognition =
        Prefixed_Name(icon, "isCompliantWithPreiconographicalRecognition") |> PrefixedName

    /// <summary>
    ///   <para>icon:associatedColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This property is used to link an artistic motif or an image to one of the (recognized) colors of the elements recognized in those artistic motifs or images. For instance, expressing "red" in  the artistic motif representing a scarf in a work or art.</para>
    /// labels<para>associated Color</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/associatedColor">https://w3id.org/icon/ontology/associatedColor</seealso>
    let associatedColor = Prefixed_Name(icon, "associatedColor") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasResponsibleAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links the Interpretation Description with all the agents responsible for the recognitions that are part of it</para>
    /// labels<para>has Responsible Agent</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasResponsibleAgent">https://w3id.org/icon/ontology/hasResponsibleAgent</seealso>
    let hasResponsibleAgent = Prefixed_Name(icon, "hasResponsibleAgent") |> PrefixedName
    /// <summary>
    ///   <para>icon:isRecognOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of recognizedInvenzione</para>
    /// labels<para>Is Recogn Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isRecognOf">https://w3id.org/icon/ontology/isRecognOf</seealso>
    let isRecognOf = Prefixed_Name(icon, "isRecognOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasPrototypicalMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation associates to the act of the Recognition of a formal motif to the artistic motif from which the visual pattern derives. It should be used when it is affirmed that a specific feature has as a prototype the same feature of a specific visual item.</para>
    /// labels<para>Has Prototypical Motif</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasPrototypicalMotif">https://w3id.org/icon/ontology/hasPrototypicalMotif</seealso>
    let hasPrototypicalMotif =
        Prefixed_Name(icon, "hasPrototypicalMotif") |> PrefixedName

    /// <summary>
    ///   <para>icon:IconographicalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Iconographical Description is the enumeration of iconographical recognitions of images or invenzioni recognized by one or more agents. It is thus a collection of triples. It is the summary of what would be called in Panofsky's term the second level of interpretation.</para>
    /// labels<para>Iconographical Description</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/IconographicalDescription">https://w3id.org/icon/ontology/IconographicalDescription</seealso>
    let IconographicalDescription =
        Prefixed_Name(icon, "IconographicalDescription") |> PrefixedName

    /// <summary>
    ///   <para>icon:IconographicalRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Iconographical Recognition is a n-ary relationship class that links the artwork described (and, if available, the Artistic Motifs recognized at the previous level along with their compositions) to the Images recognized, or directly to the Invenzione that results from the grouping of the subject depicted by each single image. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed.</para>
    /// labels<para>Iconographical Recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/IconographicalRecognition">https://w3id.org/icon/ontology/IconographicalRecognition</seealso>
    let IconographicalRecognition =
        Prefixed_Name(icon, "IconographicalRecognition") |> PrefixedName

    /// <summary>
    ///   <para>icon:InterpretationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Interpretation Description is a class collecting all the triples describing each recognition in each level that shares a unique interpretative perspective. For example, it allows to collect claims agreeing each other or to describe the situation in which an art historian attributes to other art historians some details of the general interpretation he claims. Recognitions in disagree with each other should be documented in different descriptions. For example, the interpretation made in 1699 recognising Regnaudin's statuette as depicting "Time carrying off the Truth" is listed in a different description form the interpretation recognising "The rape of Cybele" as its subject (Wittkower).</para>
    /// labels<para>Interpretation Description</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/InterpretationDescription">https://w3id.org/icon/ontology/InterpretationDescription</seealso>
    let InterpretationDescription =
        Prefixed_Name(icon, "InterpretationDescription") |> PrefixedName

    /// <summary>
    ///   <para>icon:recognizedInvenzione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation associates the Invenzione to the Iconographical Recognition that recognizes it at the second level of interpretation.</para>
    /// labels<para>Recognized Invenzione</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/recognizedInvenzione">https://w3id.org/icon/ontology/recognizedInvenzione</seealso>
    let recognizedInvenzione =
        Prefixed_Name(icon, "recognizedInvenzione") |> PrefixedName

    /// <summary>
    ///   <para>icon:PureForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A pure form represents the physical portion of the work of art in which artistic motifs are found. It has been introduced as a way to include the results of analysis performed by computational agents, that are able to classify images and give image coordinates for specific recognition. It is not recommended to be used by manual annotators or in any case in which the coordinates of the image of the work of art are not considered. If available, the Pure form can represent the region of an image identified by IIIF Image API.</para>
    ///   <para>Change the definition to the formal representation that can be enclosed in a certain coordinate.</para>
    /// labels<para>Pure Form</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/PureForm">https://w3id.org/icon/ontology/PureForm</seealso>
    let PureForm = Prefixed_Name(icon, "PureForm") |> PrefixedName
    /// <summary>
    ///   <para>icon:visuallyRepresents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link a Visual Subject (the subject visually represented in the specific artwork) with the general subject entity (for instance the controlled vocabulary entry). Example: the image of Hercules in the Farnese Hercules linked to the general Hercules subject expressed in Iconclass (94L) or the URI of the "general" Hercules in the KG. For specific interpretation-level relationships, see and use one of this property's subproperties.</para>
    /// labels<para>Visually Represents</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/visuallyRepresents">https://w3id.org/icon/ontology/visuallyRepresents</seealso>
    let visuallyRepresents = Prefixed_Name(icon, "visuallyRepresents") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasIconologicalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link an intrinstic meaning to the iconological subject it represents. It is useful in the cases where it is difficult to identify the type of the iconological subject (cultural phenomenon, abstract concept...) especially in cases of automatic conversions of data to the ICON ontology structure</para>
    /// labels<para>has Iconological Subject</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasIconologicalSubject">https://w3id.org/icon/ontology/hasIconologicalSubject</seealso>
    let hasIconologicalSubject =
        Prefixed_Name(icon, "hasIconologicalSubject") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasInvenzione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links an Intrinsic Meaning to the Invenzione recognized at the second level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this invenzione, and not only to the general artwork.</para>
    /// labels<para>Has Invenzione</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasInvenzione">https://w3id.org/icon/ontology/hasInvenzione</seealso>
    let hasInvenzione = Prefixed_Name(icon, "hasInvenzione") |> PrefixedName
    /// <summary>
    ///   <para>icon:isInvenzioneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasInvenzione</para>
    /// labels<para>Is Invenzione Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isInvenzioneOf">https://w3id.org/icon/ontology/isInvenzioneOf</seealso>
    let isInvenzioneOf = Prefixed_Name(icon, "isInvenzioneOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasPart</para>
    /// labels<para>Part Of (ICON)</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/partOf">https://w3id.org/icon/ontology/partOf</seealso>
    let partOf = Prefixed_Name(icon, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:isPlaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasPlace</para>
    /// labels<para>Is Place Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isPlaceOf">https://w3id.org/icon/ontology/isPlaceOf</seealso>
    let isPlaceOf = Prefixed_Name(icon, "isPlaceOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:regionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This data property can be used to link an artistic motif or a composition with their coordinates in the image of the artwork in which they are recognized. These coordinates could indicate the bounding boxes of the detections of a computer vision algorithms or could also be the IIIF URI that selects the part of the image of the painting in which the artistic motif or the composition are found</para>
    /// labels<para>Region Description</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/regionDescription">https://w3id.org/icon/ontology/regionDescription</seealso>
    let regionDescription = Prefixed_Name(icon, "regionDescription") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasCopiedMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This relation associates to the act of Formal Motif Recognition the Artistic Motif representing the copied visual pattern. To be used when it is affirmed that a specific feature has as a prototype the same feature of a specific visual item.</para>
    /// labels<para>Has Copied Motif</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasCopiedMotif">https://w3id.org/icon/ontology/hasCopiedMotif</seealso>
    let hasCopiedMotif = Prefixed_Name(icon, "hasCopiedMotif") |> PrefixedName
    /// <summary>
    ///   <para>icon:Recognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A recognition, in the context of this ontology, is an interpretation act made by an agent (biological or electronic being) that links works of arts to something related to their content. More specific recognitions are available as subclasses for specific types of recognition according to the level of interpretation.</para>
    /// labels<para>Recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Recognition">https://w3id.org/icon/ontology/Recognition</seealso>
    let Recognition = Prefixed_Name(icon, "Recognition") |> PrefixedName
    /// <summary>
    ///   <para>icon:IconologicalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>This class represents all the iconological subjects of an artwork recognized through an intrinstic meaning</para><para>Iconological Subject</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/IconologicalSubject">https://w3id.org/icon/ontology/IconologicalSubject</seealso>
    let IconologicalSubject = Prefixed_Name(icon, "IconologicalSubject") |> PrefixedName
    /// <summary>
    ///   <para>icon:VisualSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A visual subject is the representation of the subject in specific artwork, in contrast with the arco:Subject which is used to define a general subject which can be shared by multiple artworks. For example, the image representing Christ in the Last Supper is a visual Subject because it is intended as only that representation for that specific artwork. The character referred by that image (Christ) would be an arco:Subject, and it can shared by all the artworks that have a specific image that refers to Christ.</para>
    /// labels<para>Visual Subject</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/VisualSubject">https://w3id.org/icon/ontology/VisualSubject</seealso>
    let VisualSubject = Prefixed_Name(icon, "VisualSubject") |> PrefixedName
    /// <summary>
    ///   <para>icon:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The ICON ontology deals with high granularity art interpretation. It was developed by conceptualizing Panofsky's theory of levels of interpretation, therefore artworks can be described according to Pre-iconographical, Iconographical and Iconological information.</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/icon/ontology/">https://w3id.org/icon/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(icon, "") |> PrefixedName
    /// <summary>
    ///   <para>icon:2.2.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/2.2.0/">https://w3id.org/icon/ontology/2.2.0/</seealso>
    let ``_2.2.0/`` = Prefixed_Name(icon, "2.2.0/") |> PrefixedName
    /// <summary>
    ///   <para>icon:ICONOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/icon/ontology/ICONOntology">https://w3id.org/icon/ontology/ICONOntology</seealso>
    let ICONOntology = Prefixed_Name(icon, "ICONOntology") |> PrefixedName

    /// <summary>
    ///   <para>icon:PreiconographicalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to represent all the preiconographical subjects that can be recognized in an artistic motif</para>
    /// labels<para>Pre-iconographical Subject</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/PreiconographicalSubject">https://w3id.org/icon/ontology/PreiconographicalSubject</seealso>
    let PreiconographicalSubject =
        Prefixed_Name(icon, "PreiconographicalSubject") |> PrefixedName

    /// <summary>
    ///   <para>icon:Allegory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An Allegory is a cohese combination of images that represent either symbols of personifications. Allegories are recognized in the context of iconographical recognition; their recognition can be included in an Iconographical Description. This definition of Allegory has been taken from Panofsky's Studies in Iconology (1939). Nevertheless, also a story can have a symbolical meaning. In this case, it is suggested to associate a Story to the images describing its content, an allegory  to the images describing the story and the symbolical meaning associated to it. E.g.: the fall of Phaeton was generally considered as an allegory of the fate of every temerarius (Panofsky 1939, p. 218). Therefore, the image identifying Phaeton is linked both to the Allegory and to the Story.</para>
    /// labels<para>Allegory</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Allegory">https://w3id.org/icon/ontology/Allegory</seealso>
    let Allegory = Prefixed_Name(icon, "Allegory") |> PrefixedName
    /// <summary>
    ///   <para>icon:Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A Symbol is the class representing the unity of a symbol and its symbolic meaning that can be expressed by an Image. The represented object (Simulacrum) and the symbolical meaning expressed (Reality Counterpart) along with the type of relation linking them if further represented by the Simulation Ontology.</para>
    /// labels<para>Symbol</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Symbol">https://w3id.org/icon/ontology/Symbol</seealso>
    let Symbol = Prefixed_Name(icon, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>icon:Invenzione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An Invenzione, term taken from Panofsky's Studies in Iconology (1939), is the subject matter represented by the combination of the single images recognized. The recognition of an Invenzione happens in the context of the iconographical recognition and it is included in the Iconographical Description. This definition slightly differs from the Panofsky's one: while he describes an invenzione as a form expressing the subject, we consider it as an individual belonging to the "sphere of secondary or conventional subject matter, viz., the world of specific themes or concepts manifested in images [...]". This new definition has been introduced to allow to formalize and recognize subjects represented in different artworks. Nevertheless, the identity of form and subject is already included in the definition of the class Artwork. Story and Allegory are subclasses of Invenzione.</para>
    /// labels<para>Invenzione</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Invenzione">https://w3id.org/icon/ontology/Invenzione</seealso>
    let Invenzione = Prefixed_Name(icon, "Invenzione") |> PrefixedName
    /// <summary>
    ///   <para>icon:hasFactualMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation links the Factual Meaning recognized (Actions or Natural Elements) to the Artistic Motif</para>
    /// labels<para>Has Factual Meaning</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasFactualMeaning">https://w3id.org/icon/ontology/hasFactualMeaning</seealso>
    let hasFactualMeaning = Prefixed_Name(icon, "hasFactualMeaning") |> PrefixedName
    /// <summary>
    ///   <para>icon:NaturalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Comprises objects, human beings, natural elements that can be experienced. They are recognized at the first level of interpretation.</para>
    /// labels<para>Natural Element</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/NaturalElement">https://w3id.org/icon/ontology/NaturalElement</seealso>
    let NaturalElement = Prefixed_Name(icon, "NaturalElement") |> PrefixedName

    /// <summary>
    ///   <para>icon:isRecognizedArtisticMotifOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of recognized artistic motif</para>
    /// labels<para>Is Recognized Artistic Motif Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isRecognizedArtisticMotifOf">https://w3id.org/icon/ontology/isRecognizedArtisticMotifOf</seealso>
    let isRecognizedArtisticMotifOf =
        Prefixed_Name(icon, "isRecognizedArtisticMotifOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:PreiconographicalRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Pre-iconographical recognition is a n-ary relationship class that links the artwork described (and optionally the Pure Forms composing it) to the Artistic Motifs recognized as carrier of meaning at the first level of analysis. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed.</para>
    /// labels<para>Preiconographical Recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/PreiconographicalRecognition">https://w3id.org/icon/ontology/PreiconographicalRecognition</seealso>
    let PreiconographicalRecognition =
        Prefixed_Name(icon, "PreiconographicalRecognition") |> PrefixedName

    /// <summary>
    ///   <para>icon:Artwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The artwork is a visual representation that may be relevant from an iconographical or an iconological point of view, carried by a physical cultural object (dul:InformationRealization) usually created by a person.</para>
    /// labels<para>Artwork</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Artwork">https://w3id.org/icon/ontology/Artwork</seealso>
    let Artwork = Prefixed_Name(icon, "Artwork") |> PrefixedName
    /// <summary>
    ///   <para>icon:Attitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered an Attitude</para>
    /// labels<para>Attitude</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Attitude">https://w3id.org/icon/ontology/Attitude</seealso>
    let Attitude = Prefixed_Name(icon, "Attitude") |> PrefixedName
    /// <summary>
    ///   <para>icon:Color</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class representing the color of an entity represented in an Artistic Motif or Image</para>
    /// labels<para>Color</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Color">https://w3id.org/icon/ontology/Color</seealso>
    let Color = Prefixed_Name(icon, "Color") |> PrefixedName
    /// <summary>
    ///   <para>icon:Composition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A Composition is a jointly of ArtisticMotif having a meaning. It can be recognized as corresponding to the same image at the second level or interpretation, or can explicit groupings of level 1 elements that the descriptor considers significant. Its is suggested to express the level 1 elements involved every time that there is an action (e.g. the action "lifting" in the context of "man lifting a woman" should be grouped in a composition including the artistic motifs corresponding respectively to "man", "woman, "lifting")</para>
    /// labels<para>Composition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Composition">https://w3id.org/icon/ontology/Composition</seealso>
    let Composition = Prefixed_Name(icon, "Composition") |> PrefixedName

    /// <summary>
    ///   <para>icon:CompositionalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The compositional structure identifies relevant structures that can be recognized in the layout of Artistic Motifs in a Composition, e.g. pyramidal, symmetrical.</para>
    /// labels<para>Compositional Structure</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/CompositionalStructure">https://w3id.org/icon/ontology/CompositionalStructure</seealso>
    let CompositionalStructure =
        Prefixed_Name(icon, "CompositionalStructure") |> PrefixedName

    /// <summary>
    ///   <para>icon:CulturalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a CulturalValue</para>
    /// labels<para>Cultural Value</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/CulturalValue">https://w3id.org/icon/ontology/CulturalValue</seealso>
    let CulturalValue = Prefixed_Name(icon, "CulturalValue") |> PrefixedName
    /// <summary>
    ///   <para>icon:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An Event is an action that is depicted as subject by an artwork. It differs from the first level Action since it requires deeper interpretation to be identified. For example, the act of hurling the Trident (Action) held by Neptune in some iconographies is interpreted as the act of calming the storm (Event) provoked by Juno in Virgil's Aeneid book 1. Furthermore, an Event is linked to a icon:Image, and not to a icon:Artistic Motif. This class includes also events having a proper identity, such as historical events (e.g. the Battle of Cascina).</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/Event">https://w3id.org/icon/ontology/Event</seealso>
    let Event = Prefixed_Name(icon, "Event") |> PrefixedName

    /// <summary>
    ///   <para>icon:FormalMotifRecognition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The act of recognizing that subjects depicted by different artworks has the same formal motifs although the content represented may be different. The need of the usage of this class emerged from a bottom-up approach, rather than Panofsky's theory. It describes that certain subjects are prototypes of others, including preliminary drawings, but also cases in which another artist copied only the composition or gestures from another artwork. This recognition can link every specific part of a representation to the specific prototypes. The relation is between level 1 objects, i.e. Artistic Motifs and Composition, since it describes a formal aspect. Example of usage: if Hercules carrying the Boar is the prototype for a Christ carrying a deer, symbol of the human souls, it's possible to relate directly the boar represented in the former artwork to the deer represented in the latter.</para>
    /// labels<para>Formal Motif Recognition</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/FormalMotifRecognition">https://w3id.org/icon/ontology/FormalMotifRecognition</seealso>
    let FormalMotifRecognition =
        Prefixed_Name(icon, "FormalMotifRecognition") |> PrefixedName

    /// <summary>
    ///   <para>icon:isCopiedMotifOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasCopiedMotif</para>
    /// labels<para>Is Copied Motif Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isCopiedMotifOf">https://w3id.org/icon/ontology/isCopiedMotifOf</seealso>
    let isCopiedMotifOf = Prefixed_Name(icon, "isCopiedMotifOf") |> PrefixedName
    /// <summary>
    ///   <para>icon:isEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasEvent</para>
    /// labels<para>Is Event Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isEventOf">https://w3id.org/icon/ontology/isEventOf</seealso>
    let isEventOf = Prefixed_Name(icon, "isEventOf") |> PrefixedName

    /// <summary>
    ///   <para>icon:hasPreiconographicalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links an artistic motif with a pre-iconographical subject represented by it, it is used when it is difficult to distinguish between the different types of pre-iconographical subjects (for example in situations where the conversion from interpretation to ICON is made automatically)</para>
    /// labels<para>has Pre-iconographical Subject</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/hasPreiconographicalSubject">https://w3id.org/icon/ontology/hasPreiconographicalSubject</seealso>
    let hasPreiconographicalSubject =
        Prefixed_Name(icon, "hasPreiconographicalSubject") |> PrefixedName

    /// <summary>
    ///   <para>icon:isExpressionalMeaningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of hasExpressionalMeaning</para>
    /// labels<para>Is Expressional Meaning Of</para></remarks>
    /// <seealso href="https://w3id.org/icon/ontology/isExpressionalMeaningOf">https://w3id.org/icon/ontology/isExpressionalMeaningOf</seealso>
    let isExpressionalMeaningOf =
        Prefixed_Name(icon, "isExpressionalMeaningOf") |> PrefixedName
