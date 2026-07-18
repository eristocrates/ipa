namespace https.w3id.org.icon.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module icon =
    let _namespace_name = "https://w3id.org/icon/ontology/"

    /// <summary>
    /// A recognition, in the context of this ontology, is an interpretation act made by an agent (biological or electronic being) that links works of arts to something related to their content. More specific recognitions are available as subclasses for specific types of recognition according to the level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/Recognition"></see></summary>
    let Recognition =
        Namespaced_IRI.parse _namespace_name "Recognition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/icon/ontology/IconologicalSubject"></see>
    /// </summary>
    let IconologicalSubject =
        Namespaced_IRI.parse _namespace_name "IconologicalSubject" |> NamespacedName

    /// <summary>
    /// A visual subject is the representation of the subject in specific artwork, in contrast with the arco:Subject which is used to define a general subject which can be shared by multiple artworks. For example, the image representing Christ in the Last Supper is a visual Subject because it is intended as only that representation for that specific artwork. The character referred by that image (Christ) would be an arco:Subject, and it can shared by all the artworks that have a specific image that refers to Christ.
    /// <see href="https://w3id.org/icon/ontology/VisualSubject"></see></summary>
    let VisualSubject =
        Namespaced_IRI.parse _namespace_name "VisualSubject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/icon/ontology/2.2.0/"></see>
    /// </summary>
    let ``_2.2.0/`` = Namespaced_IRI.parse _namespace_name "2.2.0/" |> NamespacedName
    /// <summary>
    /// An event as recognized at level 1 of interpretation, e.g. a man who lifts one hand or a man riding a horse. Generally, all the actions should be described by this class.  When an action is identified, it is suggested to create a Composition with all the elements involved in this action
    /// <see href="https://w3id.org/icon/ontology/Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/icon/ontology/ICONOntology"></see>
    /// </summary>
    let ICONOntology =
        Namespaced_IRI.parse _namespace_name "ICONOntology" |> NamespacedName

    /// <summary>
    /// This class is used to represent all the preiconographical subjects that can be recognized in an artistic motif
    /// <see href="https://w3id.org/icon/ontology/PreiconographicalSubject"></see></summary>
    let PreiconographicalSubject =
        Namespaced_IRI.parse _namespace_name "PreiconographicalSubject" |> NamespacedName

    /// <summary>
    /// An Allegory is a cohese combination of images that represent either symbols of personifications. Allegories are recognized in the context of iconographical recognition; their recognition can be included in an Iconographical Description. This definition of Allegory has been taken from Panofsky's Studies in Iconology (1939). Nevertheless, also a story can have a symbolical meaning. In this case, it is suggested to associate a Story to the images describing its content, an allegory  to the images describing the story and the symbolical meaning associated to it. E.g.: the fall of Phaeton was generally considered as an allegory of the fate of every temerarius (Panofsky 1939, p. 218). Therefore, the image identifying Phaeton is linked both to the Allegory and to the Story.
    /// <see href="https://w3id.org/icon/ontology/Allegory"></see></summary>
    let Allegory = Namespaced_IRI.parse _namespace_name "Allegory" |> NamespacedName

    /// <summary>
    /// A representation of a concept through a human figure
    /// <see href="https://w3id.org/icon/ontology/Personification"></see></summary>
    let Personification =
        Namespaced_IRI.parse _namespace_name "Personification" |> NamespacedName

    /// <summary>
    /// This Property links an invenzione with its components, which may vary from Characters, Events, Named Objects, Places to Personifications, Symbols according to the kind of Invenzione is being described.
    /// <see href="https://w3id.org/icon/ontology/composedOf"></see></summary>
    let composedOf = Namespaced_IRI.parse _namespace_name "composedOf" |> NamespacedName
    /// <summary>
    /// A Symbol is the class representing the unity of a symbol and its symbolic meaning that can be expressed by an Image. The represented object (Simulacrum) and the symbolical meaning expressed (Reality Counterpart) along with the type of relation linking them if further represented by the Simulation Ontology.
    /// <see href="https://w3id.org/icon/ontology/Symbol"></see></summary>
    let Symbol = Namespaced_IRI.parse _namespace_name "Symbol" |> NamespacedName
    /// <summary>
    /// An Invenzione, term taken from Panofsky's Studies in Iconology (1939), is the subject matter represented by the combination of the single images recognized. The recognition of an Invenzione happens in the context of the iconographical recognition and it is included in the Iconographical Description. This definition slightly differs from the Panofsky's one: while he describes an invenzione as a form expressing the subject, we consider it as an individual belonging to the "sphere of secondary or conventional subject matter, viz., the world of specific themes or concepts manifested in images [...]". This new definition has been introduced to allow to formalize and recognize subjects represented in different artworks. Nevertheless, the identity of form and subject is already included in the definition of the class Artwork. Story and Allegory are subclasses of Invenzione.
    /// <see href="https://w3id.org/icon/ontology/Invenzione"></see></summary>
    let Invenzione = Namespaced_IRI.parse _namespace_name "Invenzione" |> NamespacedName
    /// <summary>
    /// This class is substituted by the the solution adopted by linked.art using crm:P2_has_type as follows: &lt;subject&gt;, crm:P2_has_type, &lt;specific style term&gt;.  &lt;specific style term&gt; crm:P2_has_type, &lt;http://vocab.getty.edu/aat/300015646&gt; # the AAT term indicating the concept of style.
    /// <see href="https://w3id.org/icon/ontology/ArtGenre"></see></summary>
    let ArtGenre = Namespaced_IRI.parse _namespace_name "ArtGenre" |> NamespacedName

    /// <summary>
    /// An ArtisticMotif is the output of a Pre Iconographic Recognition. It is a N-ary relationship class linking the physical unique representation depicted in an artwork to the corresponding real world meaning recognized. Each artistic motif describes exactly one meaning among: Natural Element, Action, Expression Quality. Qualities (e.g. colors) can be expressed.
    /// The N-ary structure allow first of all to maintain the distinction between the particular representation belonging to the artwork considered and the general meaning of which the representation is an expression. Furthermore, it allows to carefully describe in detail what is represented in the visual representation, since it gives the chance to identify uniquely details of objects and iconographies.
    /// <see href="https://w3id.org/icon/ontology/ArtisticMotif"></see></summary>
    let ArtisticMotif =
        Namespaced_IRI.parse _namespace_name "ArtisticMotif" |> NamespacedName

    /// <summary>
    /// This relation links the Expressional Meaning recognized to the Artistic Motif
    /// <see href="https://w3id.org/icon/ontology/hasExpressionalMeaning"></see></summary>
    let hasExpressionalMeaning =
        Namespaced_IRI.parse _namespace_name "hasExpressionalMeaning" |> NamespacedName

    /// <summary>
    /// An Expression Quality corresponds to the "expressional subject matter" described by Panofsky (1939), which belongs, along with the factual ones, to the Primary or natural subject matter of a work of art. Indeed, it individuates, by way of example, emotions, an atmosphere, the character of a person.
    /// <see href="https://w3id.org/icon/ontology/ExpressionalQuality"></see></summary>
    let ExpressionalQuality =
        Namespaced_IRI.parse _namespace_name "ExpressionalQuality" |> NamespacedName

    /// <summary>
    /// This relation links the Factual Meaning recognized (Actions or Natural Elements) to the Artistic Motif
    /// <see href="https://w3id.org/icon/ontology/hasFactualMeaning"></see></summary>
    let hasFactualMeaning =
        Namespaced_IRI.parse _namespace_name "hasFactualMeaning" |> NamespacedName

    /// <summary>
    /// Comprises objects, human beings, natural elements that can be experienced. They are recognized at the first level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/NaturalElement"></see></summary>
    let NaturalElement =
        Namespaced_IRI.parse _namespace_name "NaturalElement" |> NamespacedName

    /// <summary>
    /// Inverse property of recognized artistic motif
    /// <see href="https://w3id.org/icon/ontology/isRecognizedArtisticMotifOf"></see></summary>
    let isRecognizedArtisticMotifOf =
        Namespaced_IRI.parse _namespace_name "isRecognizedArtisticMotifOf" |> NamespacedName

    /// <summary>
    /// A Pre-iconographical recognition is a n-ary relationship class that links the artwork described (and optionally the Pure Forms composing it) to the Artistic Motifs recognized as carrier of meaning at the first level of analysis. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed.
    /// <see href="https://w3id.org/icon/ontology/PreiconographicalRecognition"></see></summary>
    let PreiconographicalRecognition =
        Namespaced_IRI.parse _namespace_name "PreiconographicalRecognition" |> NamespacedName

    /// <summary>
    /// The artwork is a visual representation that may be relevant from an iconographical or an iconological point of view, carried by a physical cultural object (dul:InformationRealization) usually created by a person.
    /// <see href="https://w3id.org/icon/ontology/Artwork"></see></summary>
    let Artwork = Namespaced_IRI.parse _namespace_name "Artwork" |> NamespacedName
    /// <summary>
    /// Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered an Attitude
    /// <see href="https://w3id.org/icon/ontology/Attitude"></see></summary>
    let Attitude = Namespaced_IRI.parse _namespace_name "Attitude" |> NamespacedName

    /// <summary>
    /// The cultural phenomenon entity expresses the cultural, social and historical aspects of which the work of art can be document. The iconographical evolution of subjects can have a cultural meaning as well. Also the personal characteristics of the artist, or of the patron, can be involved (Wittkower, Van Straten). The cultural phenomena are the object of investigation of an iconological interpretation (Van Straten, 2012, p. 12), which is considered, in the current work, a level 3 interpretation.
    /// <see href="https://w3id.org/icon/ontology/CulturalPhenomenon"></see></summary>
    let CulturalPhenomenon =
        Namespaced_IRI.parse _namespace_name "CulturalPhenomenon" |> NamespacedName

    /// <summary>
    /// Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a Belief
    /// <see href="https://w3id.org/icon/ontology/Belief"></see></summary>
    let Belief = Namespaced_IRI.parse _namespace_name "Belief" |> NamespacedName
    /// <summary>
    /// A Character is a real or imaginary being identifiable as a subject in the Iconographical Analysis (level 2 of interpretation)
    /// <see href="https://w3id.org/icon/ontology/Character"></see></summary>
    let Character = Namespaced_IRI.parse _namespace_name "Character" |> NamespacedName

    /// <summary>
    /// This class represents all the iconographical subjects of an artwork recognized in images
    /// <see href="https://w3id.org/icon/ontology/IconographicalSubject"></see></summary>
    let IconographicalSubject =
        Namespaced_IRI.parse _namespace_name "IconographicalSubject" |> NamespacedName

    /// <summary>
    /// Class representing the color of an entity represented in an Artistic Motif or Image
    /// <see href="https://w3id.org/icon/ontology/Color"></see></summary>
    let Color = Namespaced_IRI.parse _namespace_name "Color" |> NamespacedName

    /// <summary>
    /// A Composition is a jointly of ArtisticMotif having a meaning. It can be recognized as corresponding to the same image at the second level or interpretation, or can explicit groupings of level 1 elements that the descriptor considers significant. Its is suggested to express the level 1 elements involved every time that there is an action (e.g. the action "lifting" in the context of "man lifting a woman" should be grouped in a composition including the artistic motifs corresponding respectively to "man", "woman, "lifting")
    /// <see href="https://w3id.org/icon/ontology/Composition"></see></summary>
    let Composition =
        Namespaced_IRI.parse _namespace_name "Composition" |> NamespacedName

    /// <summary>
    /// Inverse property of recognizedComposition
    /// <see href="https://w3id.org/icon/ontology/isRecognizedCompositionOf"></see></summary>
    let isRecognizedCompositionOf =
        Namespaced_IRI.parse _namespace_name "isRecognizedCompositionOf" |> NamespacedName

    /// <summary>
    /// The compositional structure identifies relevant structures that can be recognized in the layout of Artistic Motifs in a Composition, e.g. pyramidal, symmetrical.
    /// <see href="https://w3id.org/icon/ontology/CompositionalStructure"></see></summary>
    let CompositionalStructure =
        Namespaced_IRI.parse _namespace_name "CompositionalStructure" |> NamespacedName

    /// <summary>
    /// Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a CulturalValue
    /// <see href="https://w3id.org/icon/ontology/CulturalValue"></see></summary>
    let CulturalValue =
        Namespaced_IRI.parse _namespace_name "CulturalValue" |> NamespacedName

    /// <summary>
    /// An Event is an action that is depicted as subject by an artwork. It differs from the first level Action since it requires deeper interpretation to be identified. For example, the act of hurling the Trident (Action) held by Neptune in some iconographies is interpreted as the act of calming the storm (Event) provoked by Juno in Virgil's Aeneid book 1. Furthermore, an Event is linked to a icon:Image, and not to a icon:Artistic Motif. This class includes also events having a proper identity, such as historical events (e.g. the Battle of Cascina).
    /// <see href="https://w3id.org/icon/ontology/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// The act of recognizing that subjects depicted by different artworks has the same formal motifs although the content represented may be different. The need of the usage of this class emerged from a bottom-up approach, rather than Panofsky's theory. It describes that certain subjects are prototypes of others, including preliminary drawings, but also cases in which another artist copied only the composition or gestures from another artwork. This recognition can link every specific part of a representation to the specific prototypes. The relation is between level 1 objects, i.e. Artistic Motifs and Composition, since it describes a formal aspect. Example of usage: if Hercules carrying the Boar is the prototype for a Christ carrying a deer, symbol of the human souls, it's possible to relate directly the boar represented in the former artwork to the deer represented in the latter.
    /// <see href="https://w3id.org/icon/ontology/FormalMotifRecognition"></see></summary>
    let FormalMotifRecognition =
        Namespaced_IRI.parse _namespace_name "FormalMotifRecognition" |> NamespacedName

    /// <summary>
    /// This relation associates to the act of Formal Motif Recognition the Artistic Motif representing the copied visual pattern. To be used when it is affirmed that a specific feature has as a prototype the same feature of a specific visual item.
    /// <see href="https://w3id.org/icon/ontology/hasCopiedMotif"></see></summary>
    let hasCopiedMotif =
        Namespaced_IRI.parse _namespace_name "hasCopiedMotif" |> NamespacedName

    /// <summary>
    /// This relation associates to the act of the Recognition of a formal motif to the artistic motif from which the visual pattern derives. It should be used when it is affirmed that a specific feature has as a prototype the same feature of a specific visual item.
    /// <see href="https://w3id.org/icon/ontology/hasPrototypicalMotif"></see></summary>
    let hasPrototypicalMotif =
        Namespaced_IRI.parse _namespace_name "hasPrototypicalMotif" |> NamespacedName

    /// <summary>
    /// An Iconographical Description is the enumeration of iconographical recognitions of images or invenzioni recognized by one or more agents. It is thus a collection of triples. It is the summary of what would be called in Panofsky's term the second level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/IconographicalDescription"></see></summary>
    let IconographicalDescription =
        Namespaced_IRI.parse _namespace_name "IconographicalDescription" |> NamespacedName

    /// <summary>
    /// A Iconographical Recognition is a n-ary relationship class that links the artwork described (and, if available, the Artistic Motifs recognized at the previous level along with their compositions) to the Images recognized, or directly to the Invenzione that results from the grouping of the subject depicted by each single image. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed.
    /// <see href="https://w3id.org/icon/ontology/IconographicalRecognition"></see></summary>
    let IconographicalRecognition =
        Namespaced_IRI.parse _namespace_name "IconographicalRecognition" |> NamespacedName

    /// <summary>
    /// The Interpretation Description is a class collecting all the triples describing each recognition in each level that shares a unique interpretative perspective. For example, it allows to collect claims agreeing each other or to describe the situation in which an art historian attributes to other art historians some details of the general interpretation he claims. Recognitions in disagree with each other should be documented in different descriptions. For example, the interpretation made in 1699 recognising Regnaudin's statuette as depicting "Time carrying off the Truth" is listed in a different description form the interpretation recognising "The rape of Cybele" as its subject (Wittkower).
    /// <see href="https://w3id.org/icon/ontology/InterpretationDescription"></see></summary>
    let InterpretationDescription =
        Namespaced_IRI.parse _namespace_name "InterpretationDescription" |> NamespacedName

    /// <summary>
    /// This relation associates the Image to the Iconographical Recognition that recognizes it at the second level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/recognizedImage"></see></summary>
    let recognizedImage =
        Namespaced_IRI.parse _namespace_name "recognizedImage" |> NamespacedName

    /// <summary>
    /// Image is a reification class linking the identified second level subject (namely: Characters, Events, Places, Named Objects, Symbols and Personifications) to the specific interpretation that recognizes it. It represents the subject depicted as a manifestation in the specific artwork taken into account, in contrast to the second level subjects cited and Invenzione, identifying iconographies from an abstract and general point of view. This distinction between the general subject level and the artwork-specific one is functional to identify the variants of a subject in relation to the specific context.
    /// <see href="https://w3id.org/icon/ontology/Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// This relation associates the Invenzione to the Iconographical Recognition that recognizes it at the second level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/recognizedInvenzione"></see></summary>
    let recognizedInvenzione =
        Namespaced_IRI.parse _namespace_name "recognizedInvenzione" |> NamespacedName

    /// <summary>
    /// An Iconographical Synthesis is the enumeration of iconological recognitions of intrinsic meanings recognized by one or more agents concerning a work of art. It is thus a collection of triples. It is the summary of what would be called in Panofsky's term the third level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/IconographicalSynthesis"></see></summary>
    let IconographicalSynthesis =
        Namespaced_IRI.parse _namespace_name "IconographicalSynthesis" |> NamespacedName

    /// <summary>
    /// An Iconological Recognition is a n-ary relationship class that links the artwork described (and optionally all the subjects represented at the first and second level of interpretation) to the Intrinsic Meanings recognized. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed. This class can represent: (1) the third level act of Interpretation described by Panofsky (1939), without a distinction between a overall artwork symbolic meaning and a societal aspect, (2) the third and second level described by Van Straten, according to the value associated to the intrinsic meaning, (3) the iconic act of interpretation described by Imdahl (2012), when the intrinsic meaning is directly linked to level 1 characteristics of the image.
    /// <see href="https://w3id.org/icon/ontology/IconologicalRecognition"></see></summary>
    let IconologicalRecognition =
        Namespaced_IRI.parse _namespace_name "IconologicalRecognition" |> NamespacedName

    /// <summary>
    /// This relation associates the Intrinsic Meaning to the Iconological Recognition that recognizes it at the third level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/recognizedIntrinsicMeaning"></see></summary>
    let recognizedIntrinsicMeaning =
        Namespaced_IRI.parse _namespace_name "recognizedIntrinsicMeaning" |> NamespacedName

    /// <summary>
    /// N-ary relatioship class linking the identified cultural phenomenon or deeper meaning to the whole artwork or to the specific part of its representation and to the interpretation that identifies it. From a theoretical point of view, it corresponds to the manifestation in the specific artwork of the concepts and cultural phenomena identified by the iconological analysis. The terminology is taken from Panofsky (1939, 1955).
    /// <see href="https://w3id.org/icon/ontology/IntrinsicMeaning"></see></summary>
    let IntrinsicMeaning =
        Namespaced_IRI.parse _namespace_name "IntrinsicMeaning" |> NamespacedName

    /// <summary>
    /// This relation links an image to the Character depicted
    /// <see href="https://w3id.org/icon/ontology/hasCharacter"></see></summary>
    let hasCharacter =
        Namespaced_IRI.parse _namespace_name "hasCharacter" |> NamespacedName

    /// <summary>
    /// This relation links an image to the Event depicted
    /// <see href="https://w3id.org/icon/ontology/hasEvent"></see></summary>
    let hasEvent = Namespaced_IRI.parse _namespace_name "hasEvent" |> NamespacedName

    /// <summary>
    /// This relation links an image to the Named Object depicted
    /// <see href="https://w3id.org/icon/ontology/hasNamedObject"></see></summary>
    let hasNamedObject =
        Namespaced_IRI.parse _namespace_name "hasNamedObject" |> NamespacedName

    /// <summary>
    /// A named object is a non-living unique element that is often used as an attribute for the recognition of specific characters or as the individuals of a more general concept class. (e.g. Bible for the Book class)
    /// <see href="https://w3id.org/icon/ontology/NamedObject"></see></summary>
    let NamedObject =
        Namespaced_IRI.parse _namespace_name "NamedObject" |> NamespacedName

    /// <summary>
    /// This relation links an image to the Personification depicted
    /// <see href="https://w3id.org/icon/ontology/hasPersonification"></see></summary>
    let hasPersonification =
        Namespaced_IRI.parse _namespace_name "hasPersonification" |> NamespacedName

    /// <summary>
    /// This relation links an image to the Place depicted
    /// <see href="https://w3id.org/icon/ontology/hasPlace"></see></summary>
    let hasPlace = Namespaced_IRI.parse _namespace_name "hasPlace" |> NamespacedName
    /// <summary>
    /// An identified setting, e.g. the city of Bologna, which is recognized as a Level 2 subject. The recognition of a generic city is formally represented by the Natural Element class (level 1).
    /// <see href="https://w3id.org/icon/ontology/Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    /// This relation links an image to the Symbol depicted
    /// <see href="https://w3id.org/icon/ontology/hasSymbol"></see></summary>
    let hasSymbol = Namespaced_IRI.parse _namespace_name "hasSymbol" |> NamespacedName

    /// <summary>
    /// Inverse property of recognizedImage
    /// <see href="https://w3id.org/icon/ontology/isIconographicallyRecognizedBy"></see></summary>
    let isIconographicallyRecognizedBy =
        Namespaced_IRI.parse _namespace_name "isIconographicallyRecognizedBy" |> NamespacedName

    /// <summary>
    /// Inverse of iconographically complies with
    /// <see href="https://w3id.org/icon/ontology/isCompliantWithIconographicalRecognition"></see></summary>
    let isCompliantWithIconographicalRecognition =
        Namespaced_IRI.parse _namespace_name "isCompliantWithIconographicalRecognition" |> NamespacedName

    /// <summary>
    /// inverse of iconologically complies with
    /// <see href="https://w3id.org/icon/ontology/isCompliantWithIconologicalRecognition"></see></summary>
    let isCompliantWithIconologicalRecognition =
        Namespaced_IRI.parse _namespace_name "isCompliantWithIconologicalRecognition" |> NamespacedName

    /// <summary>
    /// Inverse of pre-iconographically complies with
    /// <see href="https://w3id.org/icon/ontology/isCompliantWithPreiconographicalRecognition"></see></summary>
    let isCompliantWithPreiconographicalRecognition =
        Namespaced_IRI.parse _namespace_name "isCompliantWithPreiconographicalRecognition" |> NamespacedName

    /// <summary>
    /// This relation expresses the Concept that is related to the Intrinsic Meaning
    /// <see href="https://w3id.org/icon/ontology/recognizedConcept"></see></summary>
    let recognizedConcept =
        Namespaced_IRI.parse _namespace_name "recognizedConcept" |> NamespacedName

    /// <summary>
    /// This relation expresses the Cultural Phenomenon that is related to the Intrinsic Meaning
    /// <see href="https://w3id.org/icon/ontology/recognizedCulturalPhenomenon"></see></summary>
    let recognizedCulturalPhenomenon =
        Namespaced_IRI.parse _namespace_name "recognizedCulturalPhenomenon" |> NamespacedName

    /// <summary>
    /// Inverse property of recognized intrinsic meaning
    /// <see href="https://w3id.org/icon/ontology/isIntrinsicMeaningOf"></see></summary>
    let isIntrinsicMeaningOf =
        Namespaced_IRI.parse _namespace_name "isIntrinsicMeaningOf" |> NamespacedName

    /// <summary>
    /// This class represent the material expressed in an artistic motif or image (referring to the element recognized in them)
    /// <see href="https://w3id.org/icon/ontology/Material"></see></summary>
    let Material = Namespaced_IRI.parse _namespace_name "Material" |> NamespacedName

    /// <summary>
    /// A Pre-iconographical description is the enumeration of the Pre-Iconographical Recognitions of a certain work of art, performed by one or more agents. It is thus a collection of triples constituting the documentation of the interpretation at level 1. The term and its definition is taken from Panofsky's Studies in Iconology (1939).
    /// <see href="https://w3id.org/icon/ontology/PreiconographicalDescription"></see></summary>
    let PreiconographicalDescription =
        Namespaced_IRI.parse _namespace_name "PreiconographicalDescription" |> NamespacedName

    /// <summary>
    /// This relation associates the Artistic Motif to the Pre-iconographical Recognition that recognizes it at the first level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/recognizedArtisticMotif"></see></summary>
    let recognizedArtisticMotif =
        Namespaced_IRI.parse _namespace_name "recognizedArtisticMotif" |> NamespacedName

    /// <summary>
    /// This relation associates the Composition to the Pre-iconographical Recognition that recognizes it at the first level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/recognizedComposition"></see></summary>
    let recognizedComposition =
        Namespaced_IRI.parse _namespace_name "recognizedComposition" |> NamespacedName

    /// <summary>
    /// A pure form represents the physical portion of the work of art in which artistic motifs are found. It has been introduced as a way to include the results of analysis performed by computational agents, that are able to classify images and give image coordinates for specific recognition. It is not recommended to be used by manual annotators or in any case in which the coordinates of the image of the work of art are not considered. If available, the Pure form can represent the region of an image identified by IIIF Image API.
    /// Change the definition to the formal representation that can be enclosed in a certain coordinate.
    /// <see href="https://w3id.org/icon/ontology/PureForm"></see></summary>
    let PureForm = Namespaced_IRI.parse _namespace_name "PureForm" |> NamespacedName

    /// <summary>
    /// This relation associates each Recognition directly to the artwork. In this way, it is possible to retrieve easily all the interpretations about an artwork. Therefore, it a highly recommended good practice to declare it for each interpretation.
    /// <see href="https://w3id.org/icon/ontology/aboutWorkOfArt"></see></summary>
    let aboutWorkOfArt =
        Namespaced_IRI.parse _namespace_name "aboutWorkOfArt" |> NamespacedName

    /// <summary>
    /// This class represents the Role of an element recognized in an artistic motif or an image.
    /// <see href="https://w3id.org/icon/ontology/Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// A story is a cohese combination of images that represent narrative elements such as Characters, Places, Events, Named Objects. The recognition of a story happens in the context of an Iconographical Recognition, and it is included in an Iconographical Description. As the super class Invenzione, it concerns the word of the subject matter. It is not necessary to have multiple images to compose a story.
    /// <see href="https://w3id.org/icon/ontology/Story"></see></summary>
    let Story = Namespaced_IRI.parse _namespace_name "Story" |> NamespacedName
    /// <summary>
    /// Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a tendency
    /// <see href="https://w3id.org/icon/ontology/Tendency"></see></summary>
    let Tendency = Namespaced_IRI.parse _namespace_name "Tendency" |> NamespacedName

    /// <summary>
    /// Inverse property of aboutWorkOfArt
    /// <see href="https://w3id.org/icon/ontology/hasRecognition"></see></summary>
    let hasRecognition =
        Namespaced_IRI.parse _namespace_name "hasRecognition" |> NamespacedName

    /// <summary>
    /// This property is used to link an artistic motif or an image to one of the (recognized) colors of the elements recognized in those artistic motifs or images. For instance, expressing "red" in  the artistic motif representing a scarf in a work or art.
    /// <see href="https://w3id.org/icon/ontology/associatedColor"></see></summary>
    let associatedColor =
        Namespaced_IRI.parse _namespace_name "associatedColor" |> NamespacedName

    /// <summary>
    /// This relation associates a Pure Form to the Pre-iconographical Recognition that describes it at the first level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/associatedForm"></see></summary>
    let associatedForm =
        Namespaced_IRI.parse _namespace_name "associatedForm" |> NamespacedName

    /// <summary>
    /// Inverse property of associatedForm
    /// <see href="https://w3id.org/icon/ontology/isPureFormOf"></see></summary>
    let isPureFormOf =
        Namespaced_IRI.parse _namespace_name "isPureFormOf" |> NamespacedName

    /// <summary>
    /// This property is used to link an artistic motif or an image to one of the (recognized) materials of the element that are recognized in those artistic motifs or images. For instance, expressing that the artistic motif representing a crown in a portrait denotes also that the crown is made of bronze. Or that the image of the Thor's Hammer is denoting that the hammer is made of steel.
    /// <see href="https://w3id.org/icon/ontology/associatedMaterial"></see></summary>
    let associatedMaterial =
        Namespaced_IRI.parse _namespace_name "associatedMaterial" |> NamespacedName

    /// <summary>
    /// Inverse property of composed of
    /// <see href="https://w3id.org/icon/ontology/takesPartIn"></see></summary>
    let takesPartIn =
        Namespaced_IRI.parse _namespace_name "takesPartIn" |> NamespacedName

    /// <summary>
    /// This relation links an Intrinsic Meaning to the Artistic Motif recognized at the first level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Artistic Motif, and not only to the general artwork.
    /// <see href="https://w3id.org/icon/ontology/hasArtisticMotif"></see></summary>
    let hasArtisticMotif =
        Namespaced_IRI.parse _namespace_name "hasArtisticMotif" |> NamespacedName

    /// <summary>
    /// Inverse property of has artistic motif
    /// <see href="https://w3id.org/icon/ontology/isArtisticMotifOf"></see></summary>
    let isArtisticMotifOf =
        Namespaced_IRI.parse _namespace_name "isArtisticMotifOf" |> NamespacedName

    /// <summary>
    /// This property is used to link an image to the iconographical subject it represents, it is used when it is difficult to distinguish between the different iconographical subjects (for instance in the case of an automatic conversion of data into the ICON ontology)
    /// <see href="https://w3id.org/icon/ontology/hasIconographicalSubject"></see></summary>
    let hasIconographicalSubject =
        Namespaced_IRI.parse _namespace_name "hasIconographicalSubject" |> NamespacedName

    /// <summary>
    /// Inverse property of hasCharacter
    /// <see href="https://w3id.org/icon/ontology/isCharacterOf"></see></summary>
    let isCharacterOf =
        Namespaced_IRI.parse _namespace_name "isCharacterOf" |> NamespacedName

    /// <summary>
    /// This relation links an Intrinsic Meaning to the Composition recognized at the first level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Composition, and not only to the general artwork.
    /// <see href="https://w3id.org/icon/ontology/hasComposition"></see></summary>
    let hasComposition =
        Namespaced_IRI.parse _namespace_name "hasComposition" |> NamespacedName

    /// <summary>
    /// Inverse property of has composition
    /// <see href="https://w3id.org/icon/ontology/isCompositionOf"></see></summary>
    let isCompositionOf =
        Namespaced_IRI.parse _namespace_name "isCompositionOf" |> NamespacedName

    /// <summary>
    /// This relation describes the arrangement of the Artistic Motifs composing the Composition. It is suggested to use it only when they are arranged in a relevant observable structure (e.g. pyramidal, oblique)
    /// <see href="https://w3id.org/icon/ontology/hasCompositionalStructure"></see></summary>
    let hasCompositionalStructure =
        Namespaced_IRI.parse _namespace_name "hasCompositionalStructure" |> NamespacedName

    /// <summary>
    /// Inverse property of hasCompositionalStructure
    /// <see href="https://w3id.org/icon/ontology/isCompositionalStructureOf"></see></summary>
    let isCompositionalStructureOf =
        Namespaced_IRI.parse _namespace_name "isCompositionalStructureOf" |> NamespacedName

    /// <summary>
    /// Inverse property of hasCopiedMotif
    /// <see href="https://w3id.org/icon/ontology/isCopiedMotifOf"></see></summary>
    let isCopiedMotifOf =
        Namespaced_IRI.parse _namespace_name "isCopiedMotifOf" |> NamespacedName

    /// <summary>
    /// Inverse property of hasEvent
    /// <see href="https://w3id.org/icon/ontology/isEventOf"></see></summary>
    let isEventOf = Namespaced_IRI.parse _namespace_name "isEventOf" |> NamespacedName

    /// <summary>
    /// This property links an artistic motif with a pre-iconographical subject represented by it, it is used when it is difficult to distinguish between the different types of pre-iconographical subjects (for example in situations where the conversion from interpretation to ICON is made automatically)
    /// <see href="https://w3id.org/icon/ontology/hasPreiconographicalSubject"></see></summary>
    let hasPreiconographicalSubject =
        Namespaced_IRI.parse _namespace_name "hasPreiconographicalSubject" |> NamespacedName

    /// <summary>
    /// Inverse property of hasExpressionalMeaning
    /// <see href="https://w3id.org/icon/ontology/isExpressionalMeaningOf"></see></summary>
    let isExpressionalMeaningOf =
        Namespaced_IRI.parse _namespace_name "isExpressionalMeaningOf" |> NamespacedName

    /// <summary>
    /// Inverse property of hasFactualMeaning
    /// <see href="https://w3id.org/icon/ontology/isFactualMeaningOf"></see></summary>
    let isFactualMeaningOf =
        Namespaced_IRI.parse _namespace_name "isFactualMeaningOf" |> NamespacedName

    /// <summary>
    /// This property is used to link a Visual Subject (the subject visually represented in the specific artwork) with the general subject entity (for instance the controlled vocabulary entry). Example: the image of Hercules in the Farnese Hercules linked to the general Hercules subject expressed in Iconclass (94L) or the URI of the "general" Hercules in the KG. For specific interpretation-level relationships, see and use one of this property's subproperties.
    /// <see href="https://w3id.org/icon/ontology/visuallyRepresents"></see></summary>
    let visuallyRepresents =
        Namespaced_IRI.parse _namespace_name "visuallyRepresents" |> NamespacedName

    /// <summary>
    /// This property is used to link an intrinstic meaning to the iconological subject it represents. It is useful in the cases where it is difficult to identify the type of the iconological subject (cultural phenomenon, abstract concept...) especially in cases of automatic conversions of data to the ICON ontology structure
    /// <see href="https://w3id.org/icon/ontology/hasIconologicalSubject"></see></summary>
    let hasIconologicalSubject =
        Namespaced_IRI.parse _namespace_name "hasIconologicalSubject" |> NamespacedName

    /// <summary>
    /// This relation links an Intrinsic Meaning to the Image recognized at the second level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Image, and not only to the general artwork.
    /// <see href="https://w3id.org/icon/ontology/hasImage"></see></summary>
    let hasImage = Namespaced_IRI.parse _namespace_name "hasImage" |> NamespacedName
    /// <summary>
    /// Inverse property of has image
    /// <see href="https://w3id.org/icon/ontology/isImageOf"></see></summary>
    let isImageOf = Namespaced_IRI.parse _namespace_name "isImageOf" |> NamespacedName

    /// <summary>
    /// This relation links an Intrinsic Meaning to the Invenzione recognized at the second level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this invenzione, and not only to the general artwork.
    /// <see href="https://w3id.org/icon/ontology/hasInvenzione"></see></summary>
    let hasInvenzione =
        Namespaced_IRI.parse _namespace_name "hasInvenzione" |> NamespacedName

    /// <summary>
    /// Inverse property of hasInvenzione
    /// <see href="https://w3id.org/icon/ontology/isInvenzioneOf"></see></summary>
    let isInvenzioneOf =
        Namespaced_IRI.parse _namespace_name "isInvenzioneOf" |> NamespacedName

    /// <summary>
    /// Inverse property of hasNamedObject
    /// <see href="https://w3id.org/icon/ontology/isNamedObjectOf"></see></summary>
    let isNamedObjectOf =
        Namespaced_IRI.parse _namespace_name "isNamedObjectOf" |> NamespacedName

    /// <summary>
    /// This relation links a Composition to the Artistic Motifs of which it consists.
    /// <see href="https://w3id.org/icon/ontology/hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName
    /// <summary>
    /// Inverse property of hasPart
    /// <see href="https://w3id.org/icon/ontology/partOf"></see></summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// Inverse property of hasPersonification
    /// <see href="https://w3id.org/icon/ontology/isPersonificationOf"></see></summary>
    let isPersonificationOf =
        Namespaced_IRI.parse _namespace_name "isPersonificationOf" |> NamespacedName

    /// <summary>
    /// Inverse property of hasPlace
    /// <see href="https://w3id.org/icon/ontology/isPlaceOf"></see></summary>
    let isPlaceOf = Namespaced_IRI.parse _namespace_name "isPlaceOf" |> NamespacedName

    /// <summary>
    /// Inverse property of hasPrototypicalMotif
    /// <see href="https://w3id.org/icon/ontology/isPrototypicalMotifOf"></see></summary>
    let isPrototypicalMotifOf =
        Namespaced_IRI.parse _namespace_name "isPrototypicalMotifOf" |> NamespacedName

    /// <summary>
    /// This relation identifies objects belonging to the level 1 as fundamental for the recognition of a certain subject. It is suggested that the Artistic Motif of the object is included in the Composition corresponding to the subject.
    /// <see href="https://w3id.org/icon/ontology/hasRecAttribute"></see></summary>
    let hasRecAttribute =
        Namespaced_IRI.parse _namespace_name "hasRecAttribute" |> NamespacedName

    /// <summary>
    /// Inverse property of hasRecAttribute
    /// <see href="https://w3id.org/icon/ontology/isRecAttributeOf"></see></summary>
    let isRecAttributeOf =
        Namespaced_IRI.parse _namespace_name "isRecAttributeOf" |> NamespacedName

    /// <summary>
    /// This property links the Interpretation Description with all the agents responsible for the recognitions that are part of it
    /// <see href="https://w3id.org/icon/ontology/hasResponsibleAgent"></see></summary>
    let hasResponsibleAgent =
        Namespaced_IRI.parse _namespace_name "hasResponsibleAgent" |> NamespacedName

    /// <summary>
    /// This property is used to link an artistic motif or an image to one of the (recognized) roles of the elements recognized in those artistic motifs or images. For instance, expressing that the role of the man recognized in a painting is "butcher", "prince", etc...
    /// <see href="https://w3id.org/icon/ontology/hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    /// Inverse property of has symbol
    /// <see href="https://w3id.org/icon/ontology/isSymbolOf"></see></summary>
    let isSymbolOf = Namespaced_IRI.parse _namespace_name "isSymbolOf" |> NamespacedName

    /// <summary>
    /// This property is used to link all the iconographical recognitions that take part in one or more interpretation(s), to that/those interpretation(s)
    /// <see href="https://w3id.org/icon/ontology/iconographicallyCompliesWith"></see></summary>
    let iconographicallyCompliesWith =
        Namespaced_IRI.parse _namespace_name "iconographicallyCompliesWith" |> NamespacedName

    /// <summary>
    /// This property is used to link an artwork to the element of the second level of interpretation (iconographical) which it depicts. This elements can be Characters, Symbols, Personifications, Places, Stories, Allegories (and the element these stories and allegories are composed of).
    ///
    /// Example: There is an IconographicalRecognition of Artwork1 of Image1, which is linked to the character Thor through the hasCharacter property.
    ///
    /// Then Artwork1 iconographicallyDepicts Thor.
    ///
    /// Example2: There is an IconographicalRecognition of Artwork1 of Story1, which is the story of the death of Julius C. This story is composed by the Place Rome and the character Julius C. (and more...)
    ///
    /// Then Artwork1 IconographicallyDepicts the story of the death of Julius C., Julius C., and the city of Rome.
    ///
    /// This link can be created automatically through inference thanks to the super property chain, or it can be written by users who are not planning of including contextual information to the interpretation.
    /// <see href="https://w3id.org/icon/ontology/iconographicallyDepicts"></see></summary>
    let iconographicallyDepicts =
        Namespaced_IRI.parse _namespace_name "iconographicallyDepicts" |> NamespacedName

    /// <summary>
    /// This property is used to link all the iconological recognitions that take part in one or more interpretation(s), to that/those interpretation(s)
    /// <see href="https://w3id.org/icon/ontology/iconologicallyCompliesWith"></see></summary>
    let iconologicallyCompliesWith =
        Namespaced_IRI.parse _namespace_name "iconologicallyCompliesWith" |> NamespacedName

    /// <summary>
    /// This property is used to link an artwork to the element of the third level of interpretation (iconological) which it represents. This elements can be Cultural Phenomena, Social Objects (abstract concepts).
    ///
    /// Example: There is an IconologicalRecognition of Artwork1 of IntrinsicMeaning1, which is linked to the cultural phenomenon of ImitationOfClassics
    /// Then Artwork1 iconologicallyRepresents  ImitationOfClassics.
    ///
    /// Example2: There is an IconologicalRecognition of Artwork1 of IntrinsicMeaning2, which is linked to the social object "Absurdity" (and to other elements from other levels that suppor this claim...)
    ///
    /// Then Artwork1 IconologicallyRepresents Absurdity
    ///
    /// This link can be created automatically through inference thanks to the super property chain, or it can be written by users who are not planning of including contextual information to the interpretation.
    /// <see href="https://w3id.org/icon/ontology/iconologicallyRepresents"></see></summary>
    let iconologicallyRepresents =
        Namespaced_IRI.parse _namespace_name "iconologicallyRepresents" |> NamespacedName

    /// <summary>
    /// This property is used to link all the pre-iconographical and formal motif recognitions recognitions that take part in one or more interpretation(s), to that/those interpretation(s)
    /// <see href="https://w3id.org/icon/ontology/preiconographicallyCompliesWith"></see></summary>
    let preiconographicallyCompliesWith =
        Namespaced_IRI.parse _namespace_name "preiconographicallyCompliesWith" |> NamespacedName

    /// <summary>
    /// Inverse property of recognizedCulturalPhenomenon
    /// <see href="https://w3id.org/icon/ontology/isCulturalPhenomenonOf"></see></summary>
    let isCulturalPhenomenonOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPhenomenonOf" |> NamespacedName

    /// <summary>
    /// Inverse property of refers to artistic motif
    /// <see href="https://w3id.org/icon/ontology/isIconographicallyReferredBy"></see></summary>
    let isIconographicallyReferredBy =
        Namespaced_IRI.parse _namespace_name "isIconographicallyReferredBy" |> NamespacedName

    /// <summary>
    /// This relation associates a Composition or an Artistic Motif to the Iconographical Recognition that describes it at the second level of interpretation.
    /// <see href="https://w3id.org/icon/ontology/refersToArtisticMotif"></see></summary>
    let refersToArtisticMotif =
        Namespaced_IRI.parse _namespace_name "refersToArtisticMotif" |> NamespacedName

    /// <summary>
    /// Inverse property of recognizedInvenzione
    /// <see href="https://w3id.org/icon/ontology/isRecognOf"></see></summary>
    let isRecognOf = Namespaced_IRI.parse _namespace_name "isRecognOf" |> NamespacedName

    /// <summary>
    /// Inverse property of recognizedConcept
    /// <see href="https://w3id.org/icon/ontology/isRecognizedConceptOf"></see></summary>
    let isRecognizedConceptOf =
        Namespaced_IRI.parse _namespace_name "isRecognizedConceptOf" |> NamespacedName

    /// <summary>
    /// This property is used to link an artwork to the element of the first level of interpretation (pre-iconographical) which it depicts. This element can be a Natural Element, an Action, Expression, or an element included in a recognized Composition (again, natural element, action, expression).
    ///
    /// Example: There is a PreiconographicalRecognition of Artwork1 of ArtisticMotif1, which is linked to the natural element bear.
    /// Then Artwork1 preiconographicallyDepicts  bear.
    ///
    /// Example2: There is a PreiconographicalRecognition of Artwork1 of ArtisticMotif2, which is linked to the composition1, composed by a bear and the action of eating.
    /// Then Artwork1 preiconographicallyDepicts bear and eating.
    ///
    /// This link can be created automatically through inference thanks to the super property chain, or it can be written by users who are not planning of including contextual information to the interpretation.
    /// <see href="https://w3id.org/icon/ontology/preiconographicallyDepicts"></see></summary>
    let preiconographicallyDepicts =
        Namespaced_IRI.parse _namespace_name "preiconographicallyDepicts" |> NamespacedName

    /// <summary>
    /// This data property expresses the number or elements represented in an artistic motif, especially when the recognition of each element is not needed
    /// <see href="https://w3id.org/icon/ontology/quantity"></see></summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName

    /// <summary>
    /// This property is used to link a Recognition to the recognized Visual Subject.
    /// <see href="https://w3id.org/icon/ontology/recognizedVisualSubject"></see></summary>
    let recognizedVisualSubject =
        Namespaced_IRI.parse _namespace_name "recognizedVisualSubject" |> NamespacedName

    /// <summary>
    /// This property is substituted by the the solution adopted by linked.art using crm:P2_has_type as follows: &lt;subject&gt;, crm:P2_has_type, &lt;specific style term&gt;.  &lt;specific style term&gt; crm:P2_has_type, &lt;http://vocab.getty.edu/aat/300015646&gt; # the AAT term indicating the concept of style.
    /// <see href="https://w3id.org/icon/ontology/recognizedGenre"></see></summary>
    let recognizedGenre =
        Namespaced_IRI.parse _namespace_name "recognizedGenre" |> NamespacedName

    /// <summary>
    /// This data property can be used to link an artistic motif or a composition with their coordinates in the image of the artwork in which they are recognized. These coordinates could indicate the bounding boxes of the detections of a computer vision algorithms or could also be the IIIF URI that selects the part of the image of the painting in which the artistic motif or the composition are found
    /// <see href="https://w3id.org/icon/ontology/regionDescription"></see></summary>
    let regionDescription =
        Namespaced_IRI.parse _namespace_name "regionDescription" |> NamespacedName
