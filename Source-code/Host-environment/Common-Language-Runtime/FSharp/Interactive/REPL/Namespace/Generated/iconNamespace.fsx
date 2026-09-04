#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module icon =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/icon/ontology/" "icon"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Action (ICON)</para>
    ///   <para>rdfs:comment : An event as recognized at level 1 of interpretation, e.g. a man who lifts one hand or a man riding a horse. Generally, all the actions should be described by this class.  When an action is identified, it is suggested to create a Composition with all the elements involved in this action</para>
    ///   <a href="https://w3id.org/icon/ontology/Action">icon:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : Allegory</para>
    ///   <para>rdfs:comment : An Allegory is a cohese combination of images that represent either symbols of personifications. Allegories are recognized in the context of iconographical recognition; their recognition can be included in an Iconographical Description. This definition of Allegory has been taken from Panofsky's Studies in Iconology (1939). Nevertheless, also a story can have a symbolical meaning. In this case, it is suggested to associate a Story to the images describing its content, an allegory  to the images describing the story and the symbolical meaning associated to it. E.g.: the fall of Phaeton was generally considered as an allegory of the fate of every temerarius (Panofsky 1939, p. 218). Therefore, the image identifying Phaeton is linked both to the Allegory and to the Story.</para>
    ///   <a href="https://w3id.org/icon/ontology/Allegory">icon:Allegory</a>
    /// </summary>
    let Allegory = _prefixId.prefix "Allegory"
    /// <summary>
    ///   <para>owl:deprecated : since new version 25/03^^xsd:string</para>
    ///   <para>rdfs:label : Art Genre</para>
    ///   <para>rdfs:comment : This class is substituted by the the solution adopted by linked.art using crm:P2_has_type as follows: &lt;subject&gt;, crm:P2_has_type, &lt;specific style term&gt;.  &lt;specific style term&gt; crm:P2_has_type, &lt;http://vocab.getty.edu/aat/300015646&gt; # the AAT term indicating the concept of style.</para>
    ///   <a href="https://w3id.org/icon/ontology/ArtGenre">icon:ArtGenre</a>
    /// </summary>
    let ArtGenre = _prefixId.prefix "ArtGenre"
    /// <summary>
    ///   <para>rdfs:label : Artistic Motif</para>
    ///   <para>rdfs:comment : An ArtisticMotif is the output of a Pre Iconographic Recognition. It is a N-ary relationship class linking the physical unique representation depicted in an artwork to the corresponding real world meaning recognized. Each artistic motif describes exactly one meaning among: Natural Element, Action, Expression Quality. Qualities (e.g. colors) can be expressed.
    /// The N-ary structure allow first of all to maintain the distinction between the particular representation belonging to the artwork considered and the general meaning of which the representation is an expression. Furthermore, it allows to carefully describe in detail what is represented in the visual representation, since it gives the chance to identify uniquely details of objects and iconographies.</para>
    ///   <a href="https://w3id.org/icon/ontology/ArtisticMotif">icon:ArtisticMotif</a>
    /// </summary>
    let ArtisticMotif = _prefixId.prefix "ArtisticMotif"
    /// <summary>
    ///   <para>rdfs:label : Artwork</para>
    ///   <para>rdfs:comment : The artwork is a visual representation that may be relevant from an iconographical or an iconological point of view, carried by a physical cultural object (dul:InformationRealization) usually created by a person.</para>
    ///   <a href="https://w3id.org/icon/ontology/Artwork">icon:Artwork</a>
    /// </summary>
    let Artwork = _prefixId.prefix "Artwork"
    /// <summary>
    ///   <para>rdfs:label : Attitude</para>
    ///   <para>rdfs:comment : Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered an Attitude</para>
    ///   <a href="https://w3id.org/icon/ontology/Attitude">icon:Attitude</a>
    /// </summary>
    let Attitude = _prefixId.prefix "Attitude"
    /// <summary>
    ///   <para>rdfs:label : Belief</para>
    ///   <para>rdfs:comment : Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a Belief</para>
    ///   <a href="https://w3id.org/icon/ontology/Belief">icon:Belief</a>
    /// </summary>
    let Belief = _prefixId.prefix "Belief"
    /// <summary>
    ///   <para>rdfs:label : Character</para>
    ///   <para>rdfs:comment : A Character is a real or imaginary being identifiable as a subject in the Iconographical Analysis (level 2 of interpretation)</para>
    ///   <a href="https://w3id.org/icon/ontology/Character">icon:Character</a>
    /// </summary>
    let Character = _prefixId.prefix "Character"
    /// <summary>
    ///   <para>rdfs:label : Color</para>
    ///   <para>rdfs:comment : Class representing the color of an entity represented in an Artistic Motif or Image</para>
    ///   <a href="https://w3id.org/icon/ontology/Color">icon:Color</a>
    /// </summary>
    let Color = _prefixId.prefix "Color"
    /// <summary>
    ///   <para>rdfs:label : Composition</para>
    ///   <para>rdfs:comment : A Composition is a jointly of ArtisticMotif having a meaning. It can be recognized as corresponding to the same image at the second level or interpretation, or can explicit groupings of level 1 elements that the descriptor considers significant. Its is suggested to express the level 1 elements involved every time that there is an action (e.g. the action "lifting" in the context of "man lifting a woman" should be grouped in a composition including the artistic motifs corresponding respectively to "man", "woman, "lifting")</para>
    ///   <a href="https://w3id.org/icon/ontology/Composition">icon:Composition</a>
    /// </summary>
    let Composition = _prefixId.prefix "Composition"
    /// <summary>
    ///   <para>rdfs:label : Compositional Structure</para>
    ///   <para>rdfs:comment : The compositional structure identifies relevant structures that can be recognized in the layout of Artistic Motifs in a Composition, e.g. pyramidal, symmetrical.</para>
    ///   <a href="https://w3id.org/icon/ontology/CompositionalStructure">icon:CompositionalStructure</a>
    /// </summary>
    let CompositionalStructure = _prefixId.prefix "CompositionalStructure"
    /// <summary>
    ///   <para>rdfs:label : Cultural Phenomenon</para>
    ///   <para>rdfs:comment : The cultural phenomenon entity expresses the cultural, social and historical aspects of which the work of art can be document. The iconographical evolution of subjects can have a cultural meaning as well. Also the personal characteristics of the artist, or of the patron, can be involved (Wittkower, Van Straten). The cultural phenomena are the object of investigation of an iconological interpretation (Van Straten, 2012, p. 12), which is considered, in the current work, a level 3 interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/CulturalPhenomenon">icon:CulturalPhenomenon</a>
    /// </summary>
    let CulturalPhenomenon = _prefixId.prefix "CulturalPhenomenon"
    /// <summary>
    ///   <para>rdfs:label : Cultural Value</para>
    ///   <para>rdfs:comment : Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a CulturalValue</para>
    ///   <a href="https://w3id.org/icon/ontology/CulturalValue">icon:CulturalValue</a>
    /// </summary>
    let CulturalValue = _prefixId.prefix "CulturalValue"
    /// <summary>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : An Event is an action that is depicted as subject by an artwork. It differs from the first level Action since it requires deeper interpretation to be identified. For example, the act of hurling the Trident (Action) held by Neptune in some iconographies is interpreted as the act of calming the storm (Event) provoked by Juno in Virgil's Aeneid book 1. Furthermore, an Event is linked to a icon:Image, and not to a icon:Artistic Motif. This class includes also events having a proper identity, such as historical events (e.g. the Battle of Cascina).</para>
    ///   <a href="https://w3id.org/icon/ontology/Event">icon:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Expressional Quality</para>
    ///   <para>rdfs:comment : An Expression Quality corresponds to the "expressional subject matter" described by Panofsky (1939), which belongs, along with the factual ones, to the Primary or natural subject matter of a work of art. Indeed, it individuates, by way of example, emotions, an atmosphere, the character of a person.</para>
    ///   <a href="https://w3id.org/icon/ontology/ExpressionalQuality">icon:ExpressionalQuality</a>
    /// </summary>
    let ExpressionalQuality = _prefixId.prefix "ExpressionalQuality"
    /// <summary>
    ///   <para>rdfs:label : Formal Motif Recognition</para>
    ///   <para>rdfs:comment : The act of recognizing that subjects depicted by different artworks has the same formal motifs although the content represented may be different. The need of the usage of this class emerged from a bottom-up approach, rather than Panofsky's theory. It describes that certain subjects are prototypes of others, including preliminary drawings, but also cases in which another artist copied only the composition or gestures from another artwork. This recognition can link every specific part of a representation to the specific prototypes. The relation is between level 1 objects, i.e. Artistic Motifs and Composition, since it describes a formal aspect. Example of usage: if Hercules carrying the Boar is the prototype for a Christ carrying a deer, symbol of the human souls, it's possible to relate directly the boar represented in the former artwork to the deer represented in the latter.</para>
    ///   <a href="https://w3id.org/icon/ontology/FormalMotifRecognition">icon:FormalMotifRecognition</a>
    /// </summary>
    let FormalMotifRecognition = _prefixId.prefix "FormalMotifRecognition"
    let ICONOntology = _prefixId.prefix "ICONOntology"
    /// <summary>
    ///   <para>owl:deprecated : from version 1.1^^xsd:string</para>
    ///   <para>rdfs:label : Iconographical Description</para>
    ///   <para>rdfs:comment : An Iconographical Description is the enumeration of iconographical recognitions of images or invenzioni recognized by one or more agents. It is thus a collection of triples. It is the summary of what would be called in Panofsky's term the second level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/IconographicalDescription">icon:IconographicalDescription</a>
    /// </summary>
    let IconographicalDescription = _prefixId.prefix "IconographicalDescription"
    /// <summary>
    ///   <para>rdfs:label : Iconographical Recognition</para>
    ///   <para>rdfs:comment : A Iconographical Recognition is a n-ary relationship class that links the artwork described (and, if available, the Artistic Motifs recognized at the previous level along with their compositions) to the Images recognized, or directly to the Invenzione that results from the grouping of the subject depicted by each single image. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed.</para>
    ///   <a href="https://w3id.org/icon/ontology/IconographicalRecognition">icon:IconographicalRecognition</a>
    /// </summary>
    let IconographicalRecognition = _prefixId.prefix "IconographicalRecognition"
    /// <summary>
    ///   <para>rdfs:label : Iconographical Subject</para>
    ///   <para>rdfs:comment : This class represents all the iconographical subjects of an artwork recognized in images</para>
    ///   <a href="https://w3id.org/icon/ontology/IconographicalSubject">icon:IconographicalSubject</a>
    /// </summary>
    let IconographicalSubject = _prefixId.prefix "IconographicalSubject"
    /// <summary>
    ///   <para>owl:deprecated : from version 1.1^^xsd:string</para>
    ///   <para>rdfs:label : Iconographical Synthesis</para>
    ///   <para>rdfs:comment : An Iconographical Synthesis is the enumeration of iconological recognitions of intrinsic meanings recognized by one or more agents concerning a work of art. It is thus a collection of triples. It is the summary of what would be called in Panofsky's term the third level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/IconographicalSynthesis">icon:IconographicalSynthesis</a>
    /// </summary>
    let IconographicalSynthesis = _prefixId.prefix "IconographicalSynthesis"
    /// <summary>
    ///   <para>rdfs:label : Iconological Recognition</para>
    ///   <para>rdfs:comment : An Iconological Recognition is a n-ary relationship class that links the artwork described (and optionally all the subjects represented at the first and second level of interpretation) to the Intrinsic Meanings recognized. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed. This class can represent: (1) the third level act of Interpretation described by Panofsky (1939), without a distinction between a overall artwork symbolic meaning and a societal aspect, (2) the third and second level described by Van Straten, according to the value associated to the intrinsic meaning, (3) the iconic act of interpretation described by Imdahl (2012), when the intrinsic meaning is directly linked to level 1 characteristics of the image.</para>
    ///   <a href="https://w3id.org/icon/ontology/IconologicalRecognition">icon:IconologicalRecognition</a>
    /// </summary>
    let IconologicalRecognition = _prefixId.prefix "IconologicalRecognition"
    /// <summary>
    ///   <para>rdfs:label : Iconological Subjectrdfs:label : This class represents all the iconological subjects of an artwork recognized through an intrinstic meaning</para>
    ///   <a href="https://w3id.org/icon/ontology/IconologicalSubject">icon:IconologicalSubject</a>
    /// </summary>
    let IconologicalSubject = _prefixId.prefix "IconologicalSubject"
    /// <summary>
    ///   <para>rdfs:label : Image</para>
    ///   <para>rdfs:comment : Image is a reification class linking the identified second level subject (namely: Characters, Events, Places, Named Objects, Symbols and Personifications) to the specific interpretation that recognizes it. It represents the subject depicted as a manifestation in the specific artwork taken into account, in contrast to the second level subjects cited and Invenzione, identifying iconographies from an abstract and general point of view. This distinction between the general subject level and the artwork-specific one is functional to identify the variants of a subject in relation to the specific context.</para>
    ///   <a href="https://w3id.org/icon/ontology/Image">icon:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Interpretation Description</para>
    ///   <para>rdfs:comment : The Interpretation Description is a class collecting all the triples describing each recognition in each level that shares a unique interpretative perspective. For example, it allows to collect claims agreeing each other or to describe the situation in which an art historian attributes to other art historians some details of the general interpretation he claims. Recognitions in disagree with each other should be documented in different descriptions. For example, the interpretation made in 1699 recognising Regnaudin's statuette as depicting "Time carrying off the Truth" is listed in a different description form the interpretation recognising "The rape of Cybele" as its subject (Wittkower).</para>
    ///   <a href="https://w3id.org/icon/ontology/InterpretationDescription">icon:InterpretationDescription</a>
    /// </summary>
    let InterpretationDescription = _prefixId.prefix "InterpretationDescription"
    /// <summary>
    ///   <para>rdfs:label : Intrinsic Meaning</para>
    ///   <para>rdfs:comment : N-ary relatioship class linking the identified cultural phenomenon or deeper meaning to the whole artwork or to the specific part of its representation and to the interpretation that identifies it. From a theoretical point of view, it corresponds to the manifestation in the specific artwork of the concepts and cultural phenomena identified by the iconological analysis. The terminology is taken from Panofsky (1939, 1955).</para>
    ///   <a href="https://w3id.org/icon/ontology/IntrinsicMeaning">icon:IntrinsicMeaning</a>
    /// </summary>
    let IntrinsicMeaning = _prefixId.prefix "IntrinsicMeaning"
    /// <summary>
    ///   <para>rdfs:label : Invenzione</para>
    ///   <para>rdfs:comment : An Invenzione, term taken from Panofsky's Studies in Iconology (1939), is the subject matter represented by the combination of the single images recognized. The recognition of an Invenzione happens in the context of the iconographical recognition and it is included in the Iconographical Description. This definition slightly differs from the Panofsky's one: while he describes an invenzione as a form expressing the subject, we consider it as an individual belonging to the "sphere of secondary or conventional subject matter, viz., the world of specific themes or concepts manifested in images [...]". This new definition has been introduced to allow to formalize and recognize subjects represented in different artworks. Nevertheless, the identity of form and subject is already included in the definition of the class Artwork. Story and Allegory are subclasses of Invenzione.</para>
    ///   <a href="https://w3id.org/icon/ontology/Invenzione">icon:Invenzione</a>
    /// </summary>
    let Invenzione = _prefixId.prefix "Invenzione"
    /// <summary>
    ///   <para>rdfs:label : Material</para>
    ///   <para>rdfs:comment : This class represent the material expressed in an artistic motif or image (referring to the element recognized in them)</para>
    ///   <a href="https://w3id.org/icon/ontology/Material">icon:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:label : Named Object</para>
    ///   <para>rdfs:comment : A named object is a non-living unique element that is often used as an attribute for the recognition of specific characters or as the individuals of a more general concept class. (e.g. Bible for the Book class)</para>
    ///   <a href="https://w3id.org/icon/ontology/NamedObject">icon:NamedObject</a>
    /// </summary>
    let NamedObject = _prefixId.prefix "NamedObject"
    /// <summary>
    ///   <para>rdfs:label : Natural Element</para>
    ///   <para>rdfs:comment : Comprises objects, human beings, natural elements that can be experienced. They are recognized at the first level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/NaturalElement">icon:NaturalElement</a>
    /// </summary>
    let NaturalElement = _prefixId.prefix "NaturalElement"
    /// <summary>
    ///   <para>rdfs:label : Personification (ICON)</para>
    ///   <para>rdfs:comment : A representation of a concept through a human figure</para>
    ///   <a href="https://w3id.org/icon/ontology/Personification">icon:Personification</a>
    /// </summary>
    let Personification = _prefixId.prefix "Personification"
    /// <summary>
    ///   <para>rdfs:label : Place (ICON)</para>
    ///   <para>rdfs:comment : An identified setting, e.g. the city of Bologna, which is recognized as a Level 2 subject. The recognition of a generic city is formally represented by the Natural Element class (level 1).</para>
    ///   <a href="https://w3id.org/icon/ontology/Place">icon:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>owl:deprecated : from version 1.1^^xsd:string</para>
    ///   <para>rdfs:label : Preiconographical Description</para>
    ///   <para>rdfs:comment : A Pre-iconographical description is the enumeration of the Pre-Iconographical Recognitions of a certain work of art, performed by one or more agents. It is thus a collection of triples constituting the documentation of the interpretation at level 1. The term and its definition is taken from Panofsky's Studies in Iconology (1939).</para>
    ///   <a href="https://w3id.org/icon/ontology/PreiconographicalDescription">icon:PreiconographicalDescription</a>
    /// </summary>
    let PreiconographicalDescription = _prefixId.prefix "PreiconographicalDescription"
    /// <summary>
    ///   <para>rdfs:label : Preiconographical Recognition</para>
    ///   <para>rdfs:comment : A Pre-iconographical recognition is a n-ary relationship class that links the artwork described (and optionally the Pure Forms composing it) to the Artistic Motifs recognized as carrier of meaning at the first level of analysis. The N-ary structure is necessary in order to include relevant additional information concerning the visual interpretation claimed.</para>
    ///   <a href="https://w3id.org/icon/ontology/PreiconographicalRecognition">icon:PreiconographicalRecognition</a>
    /// </summary>
    let PreiconographicalRecognition = _prefixId.prefix "PreiconographicalRecognition"
    /// <summary>
    ///   <para>rdfs:label : Pre-iconographical Subject</para>
    ///   <para>rdfs:comment : This class is used to represent all the preiconographical subjects that can be recognized in an artistic motif</para>
    ///   <a href="https://w3id.org/icon/ontology/PreiconographicalSubject">icon:PreiconographicalSubject</a>
    /// </summary>
    let PreiconographicalSubject = _prefixId.prefix "PreiconographicalSubject"
    /// <summary>
    ///   <para>owl:deprecated : from 1.1 version^^xsd:string</para>
    ///   <para>rdfs:label : Pure Form</para>
    ///   <para>rdfs:comment : A pure form represents the physical portion of the work of art in which artistic motifs are found. It has been introduced as a way to include the results of analysis performed by computational agents, that are able to classify images and give image coordinates for specific recognition. It is not recommended to be used by manual annotators or in any case in which the coordinates of the image of the work of art are not considered. If available, the Pure form can represent the region of an image identified by IIIF Image API.rdfs:comment : Change the definition to the formal representation that can be enclosed in a certain coordinate.^^xsd:string</para>
    ///   <a href="https://w3id.org/icon/ontology/PureForm">icon:PureForm</a>
    /// </summary>
    let PureForm = _prefixId.prefix "PureForm"
    /// <summary>
    ///   <para>rdfs:label : Recognition</para>
    ///   <para>rdfs:comment : A recognition, in the context of this ontology, is an interpretation act made by an agent (biological or electronic being) that links works of arts to something related to their content. More specific recognitions are available as subclasses for specific types of recognition according to the level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/Recognition">icon:Recognition</a>
    /// </summary>
    let Recognition = _prefixId.prefix "Recognition"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>rdfs:comment : This class represents the Role of an element recognized in an artistic motif or an image.</para>
    ///   <a href="https://w3id.org/icon/ontology/Role">icon:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Story</para>
    ///   <para>rdfs:comment : A story is a cohese combination of images that represent narrative elements such as Characters, Places, Events, Named Objects. The recognition of a story happens in the context of an Iconographical Recognition, and it is included in an Iconographical Description. As the super class Invenzione, it concerns the word of the subject matter. It is not necessary to have multiple images to compose a story.</para>
    ///   <a href="https://w3id.org/icon/ontology/Story">icon:Story</a>
    /// </summary>
    let Story = _prefixId.prefix "Story"
    /// <summary>
    ///   <para>rdfs:label : Symbol</para>
    ///   <para>rdfs:comment : A Symbol is the class representing the unity of a symbol and its symbolic meaning that can be expressed by an Image. The represented object (Simulacrum) and the symbolical meaning expressed (Reality Counterpart) along with the type of relation linking them if further represented by the Simulation Ontology.</para>
    ///   <a href="https://w3id.org/icon/ontology/Symbol">icon:Symbol</a>
    /// </summary>
    let Symbol = _prefixId.prefix "Symbol"
    /// <summary>
    ///   <para>rdfs:label : Tendency</para>
    ///   <para>rdfs:comment : Example term taken from Panofsky's studies, can be used as a specification of a cultural phenomemon if it can be considered a tendency</para>
    ///   <a href="https://w3id.org/icon/ontology/Tendency">icon:Tendency</a>
    /// </summary>
    let Tendency = _prefixId.prefix "Tendency"
    /// <summary>
    ///   <para>rdfs:label : Visual Subject</para>
    ///   <para>rdfs:comment : A visual subject is the representation of the subject in specific artwork, in contrast with the arco:Subject which is used to define a general subject which can be shared by multiple artworks. For example, the image representing Christ in the Last Supper is a visual Subject because it is intended as only that representation for that specific artwork. The character referred by that image (Christ) would be an arco:Subject, and it can shared by all the artworks that have a specific image that refers to Christ.</para>
    ///   <a href="https://w3id.org/icon/ontology/VisualSubject">icon:VisualSubject</a>
    /// </summary>
    let VisualSubject = _prefixId.prefix "VisualSubject"
    /// <summary>
    ///   <para>rdfs:label : About Work Of Art</para>
    ///   <para>rdfs:comment : This relation associates each Recognition directly to the artwork. In this way, it is possible to retrieve easily all the interpretations about an artwork. Therefore, it a highly recommended good practice to declare it for each interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/aboutWorkOfArt">icon:aboutWorkOfArt</a>
    /// </summary>
    let aboutWorkOfArt = _prefixId.prefix "aboutWorkOfArt"
    /// <summary>
    ///   <para>rdfs:label : associated Color</para>
    ///   <para>rdfs:comment : This property is used to link an artistic motif or an image to one of the (recognized) colors of the elements recognized in those artistic motifs or images. For instance, expressing "red" in  the artistic motif representing a scarf in a work or art.</para>
    ///   <a href="https://w3id.org/icon/ontology/associatedColor">icon:associatedColor</a>
    /// </summary>
    let associatedColor = _prefixId.prefix "associatedColor"
    /// <summary>
    ///   <para>owl:deprecated : Since 1.1 version^^xsd:string</para>
    ///   <para>rdfs:label : Associated Form</para>
    ///   <para>rdfs:comment : This relation associates a Pure Form to the Pre-iconographical Recognition that describes it at the first level of interpretation.^^xsd:string</para>
    ///   <a href="https://w3id.org/icon/ontology/associatedForm">icon:associatedForm</a>
    /// </summary>
    let associatedForm = _prefixId.prefix "associatedForm"
    /// <summary>
    ///   <para>rdfs:label : associated Material</para>
    ///   <para>rdfs:comment : This property is used to link an artistic motif or an image to one of the (recognized) materials of the element that are recognized in those artistic motifs or images. For instance, expressing that the artistic motif representing a crown in a portrait denotes also that the crown is made of bronze. Or that the image of the Thor's Hammer is denoting that the hammer is made of steel.</para>
    ///   <a href="https://w3id.org/icon/ontology/associatedMaterial">icon:associatedMaterial</a>
    /// </summary>
    let associatedMaterial = _prefixId.prefix "associatedMaterial"
    /// <summary>
    ///   <para>rdfs:label : Composed Of</para>
    ///   <para>rdfs:comment : This Property links an invenzione with its components, which may vary from Characters, Events, Named Objects, Places to Personifications, Symbols according to the kind of Invenzione is being described.</para>
    ///   <a href="https://w3id.org/icon/ontology/composedOf">icon:composedOf</a>
    /// </summary>
    let composedOf = _prefixId.prefix "composedOf"
    /// <summary>
    ///   <para>rdfs:label : Has Artistic Motif</para>
    ///   <para>rdfs:comment : This relation links an Intrinsic Meaning to the Artistic Motif recognized at the first level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Artistic Motif, and not only to the general artwork.</para>
    ///   <a href="https://w3id.org/icon/ontology/hasArtisticMotif">icon:hasArtisticMotif</a>
    /// </summary>
    let hasArtisticMotif = _prefixId.prefix "hasArtisticMotif"
    /// <summary>
    ///   <para>rdfs:comment : This relation links an image to the Character depicted</para>
    ///   <para>rdfs:label : Has Character</para>
    ///   <a href="https://w3id.org/icon/ontology/hasCharacter">icon:hasCharacter</a>
    /// </summary>
    let hasCharacter = _prefixId.prefix "hasCharacter"
    /// <summary>
    ///   <para>rdfs:label : Has Composition</para>
    ///   <para>rdfs:comment : This relation links an Intrinsic Meaning to the Composition recognized at the first level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Composition, and not only to the general artwork.</para>
    ///   <a href="https://w3id.org/icon/ontology/hasComposition">icon:hasComposition</a>
    /// </summary>
    let hasComposition = _prefixId.prefix "hasComposition"
    /// <summary>
    ///   <para>rdfs:label : Has Compositional Structure</para>
    ///   <para>rdfs:comment : This relation describes the arrangement of the Artistic Motifs composing the Composition. It is suggested to use it only when they are arranged in a relevant observable structure (e.g. pyramidal, oblique)^^xsd:string</para>
    ///   <a href="https://w3id.org/icon/ontology/hasCompositionalStructure">icon:hasCompositionalStructure</a>
    /// </summary>
    let hasCompositionalStructure = _prefixId.prefix "hasCompositionalStructure"
    /// <summary>
    ///   <para>rdfs:label : Has Copied Motif</para>
    ///   <para>rdfs:comment : This relation associates to the act of Formal Motif Recognition the Artistic Motif representing the copied visual pattern. To be used when it is affirmed that a specific feature has as a prototype the same feature of a specific visual item.</para>
    ///   <a href="https://w3id.org/icon/ontology/hasCopiedMotif">icon:hasCopiedMotif</a>
    /// </summary>
    let hasCopiedMotif = _prefixId.prefix "hasCopiedMotif"
    /// <summary>
    ///   <para>rdfs:label : Has Event</para>
    ///   <para>rdfs:comment : This relation links an image to the Event depicted</para>
    ///   <a href="https://w3id.org/icon/ontology/hasEvent">icon:hasEvent</a>
    /// </summary>
    let hasEvent = _prefixId.prefix "hasEvent"
    /// <summary>
    ///   <para>rdfs:comment : This relation links the Expressional Meaning recognized to the Artistic Motif^^xsd:string</para>
    ///   <para>rdfs:label : Has Expressional Meaning</para>
    ///   <a href="https://w3id.org/icon/ontology/hasExpressionalMeaning">icon:hasExpressionalMeaning</a>
    /// </summary>
    let hasExpressionalMeaning = _prefixId.prefix "hasExpressionalMeaning"
    /// <summary>
    ///   <para>rdfs:label : Has Factual Meaning</para>
    ///   <para>rdfs:comment : This relation links the Factual Meaning recognized (Actions or Natural Elements) to the Artistic Motif^^xsd:string</para>
    ///   <a href="https://w3id.org/icon/ontology/hasFactualMeaning">icon:hasFactualMeaning</a>
    /// </summary>
    let hasFactualMeaning = _prefixId.prefix "hasFactualMeaning"
    /// <summary>
    ///   <para>rdfs:label : has Iconographical Subject</para>
    ///   <para>rdfs:comment : This property is used to link an image to the iconographical subject it represents, it is used when it is difficult to distinguish between the different iconographical subjects (for instance in the case of an automatic conversion of data into the ICON ontology)</para>
    ///   <a href="https://w3id.org/icon/ontology/hasIconographicalSubject">icon:hasIconographicalSubject</a>
    /// </summary>
    let hasIconographicalSubject = _prefixId.prefix "hasIconographicalSubject"
    /// <summary>
    ///   <para>rdfs:label : has Iconological Subject</para>
    ///   <para>rdfs:comment : This property is used to link an intrinstic meaning to the iconological subject it represents. It is useful in the cases where it is difficult to identify the type of the iconological subject (cultural phenomenon, abstract concept...) especially in cases of automatic conversions of data to the ICON ontology structure</para>
    ///   <a href="https://w3id.org/icon/ontology/hasIconologicalSubject">icon:hasIconologicalSubject</a>
    /// </summary>
    let hasIconologicalSubject = _prefixId.prefix "hasIconologicalSubject"
    /// <summary>
    ///   <para>rdfs:label : Has Image</para>
    ///   <para>rdfs:comment : This relation links an Intrinsic Meaning to the Image recognized at the second level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this Image, and not only to the general artwork.</para>
    ///   <a href="https://w3id.org/icon/ontology/hasImage">icon:hasImage</a>
    /// </summary>
    let hasImage = _prefixId.prefix "hasImage"
    /// <summary>
    ///   <para>rdfs:label : Has Invenzione</para>
    ///   <para>rdfs:comment : This relation links an Intrinsic Meaning to the Invenzione recognized at the second level of interpretation. It should be used to express that the third level meaning associated to the Intrinsic Meaning refers specifically to this invenzione, and not only to the general artwork.</para>
    ///   <a href="https://w3id.org/icon/ontology/hasInvenzione">icon:hasInvenzione</a>
    /// </summary>
    let hasInvenzione = _prefixId.prefix "hasInvenzione"
    /// <summary>
    ///   <para>rdfs:label : Has Named Object</para>
    ///   <para>rdfs:comment : This relation links an image to the Named Object depicted</para>
    ///   <a href="https://w3id.org/icon/ontology/hasNamedObject">icon:hasNamedObject</a>
    /// </summary>
    let hasNamedObject = _prefixId.prefix "hasNamedObject"
    /// <summary>
    ///   <para>rdfs:label : Has Part (ICON)</para>
    ///   <para>rdfs:comment : This relation links a Composition to the Artistic Motifs of which it consists.</para>
    ///   <a href="https://w3id.org/icon/ontology/hasPart">icon:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:comment : This relation links an image to the Personification depicted</para>
    ///   <para>rdfs:label : Has Personification</para>
    ///   <a href="https://w3id.org/icon/ontology/hasPersonification">icon:hasPersonification</a>
    /// </summary>
    let hasPersonification = _prefixId.prefix "hasPersonification"
    /// <summary>
    ///   <para>rdfs:label : Has Place</para>
    ///   <para>rdfs:comment : This relation links an image to the Place depicted</para>
    ///   <a href="https://w3id.org/icon/ontology/hasPlace">icon:hasPlace</a>
    /// </summary>
    let hasPlace = _prefixId.prefix "hasPlace"
    /// <summary>
    ///   <para>rdfs:label : has Pre-iconographical Subject</para>
    ///   <para>rdfs:comment : This property links an artistic motif with a pre-iconographical subject represented by it, it is used when it is difficult to distinguish between the different types of pre-iconographical subjects (for example in situations where the conversion from interpretation to ICON is made automatically)</para>
    ///   <a href="https://w3id.org/icon/ontology/hasPreiconographicalSubject">icon:hasPreiconographicalSubject</a>
    /// </summary>
    let hasPreiconographicalSubject = _prefixId.prefix "hasPreiconographicalSubject"
    /// <summary>
    ///   <para>rdfs:label : Has Prototypical Motif</para>
    ///   <para>rdfs:comment : This relation associates to the act of the Recognition of a formal motif to the artistic motif from which the visual pattern derives. It should be used when it is affirmed that a specific feature has as a prototype the same feature of a specific visual item.</para>
    ///   <a href="https://w3id.org/icon/ontology/hasPrototypicalMotif">icon:hasPrototypicalMotif</a>
    /// </summary>
    let hasPrototypicalMotif = _prefixId.prefix "hasPrototypicalMotif"
    /// <summary>
    ///   <para>rdfs:label : Has Rec Attribute</para>
    ///   <para>rdfs:comment : This relation identifies objects belonging to the level 1 as fundamental for the recognition of a certain subject. It is suggested that the Artistic Motif of the object is included in the Composition corresponding to the subject.</para>
    ///   <a href="https://w3id.org/icon/ontology/hasRecAttribute">icon:hasRecAttribute</a>
    /// </summary>
    let hasRecAttribute = _prefixId.prefix "hasRecAttribute"
    /// <summary>
    ///   <para>rdfs:label : Has Recognition</para>
    ///   <para>rdfs:comment : Inverse property of aboutWorkOfArt</para>
    ///   <a href="https://w3id.org/icon/ontology/hasRecognition">icon:hasRecognition</a>
    /// </summary>
    let hasRecognition = _prefixId.prefix "hasRecognition"
    /// <summary>
    ///   <para>rdfs:label : has Responsible Agent</para>
    ///   <para>rdfs:comment : This property links the Interpretation Description with all the agents responsible for the recognitions that are part of it</para>
    ///   <a href="https://w3id.org/icon/ontology/hasResponsibleAgent">icon:hasResponsibleAgent</a>
    /// </summary>
    let hasResponsibleAgent = _prefixId.prefix "hasResponsibleAgent"
    /// <summary>
    ///   <para>rdfs:label : has Role</para>
    ///   <para>rdfs:comment : This property is used to link an artistic motif or an image to one of the (recognized) roles of the elements recognized in those artistic motifs or images. For instance, expressing that the role of the man recognized in a painting is "butcher", "prince", etc...</para>
    ///   <a href="https://w3id.org/icon/ontology/hasRole">icon:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:comment : This relation links an image to the Symbol depicted</para>
    ///   <para>rdfs:label : Has Symbol</para>
    ///   <a href="https://w3id.org/icon/ontology/hasSymbol">icon:hasSymbol</a>
    /// </summary>
    let hasSymbol = _prefixId.prefix "hasSymbol"
    /// <summary>
    ///   <para>rdfs:label : iconographically complies with</para>
    ///   <para>rdfs:comment : This property is used to link all the iconographical recognitions that take part in one or more interpretation(s), to that/those interpretation(s)</para>
    ///   <a href="https://w3id.org/icon/ontology/iconographicallyCompliesWith">icon:iconographicallyCompliesWith</a>
    /// </summary>
    let iconographicallyCompliesWith = _prefixId.prefix "iconographicallyCompliesWith"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to link an artwork to the element of the second level of interpretation (iconographical) which it depicts. This elements can be Characters, Symbols, Personifications, Places, Stories, Allegories (and the element these stories and allegories are composed of).
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
    ///   <para>rdfs:label : Iconographically Depicts</para>
    ///   <a href="https://w3id.org/icon/ontology/iconographicallyDepicts">icon:iconographicallyDepicts</a>
    /// </summary>
    let iconographicallyDepicts = _prefixId.prefix "iconographicallyDepicts"
    /// <summary>
    ///   <para>rdfs:label : iconologically complies with</para>
    ///   <para>rdfs:comment : This property is used to link all the iconological recognitions that take part in one or more interpretation(s), to that/those interpretation(s)</para>
    ///   <a href="https://w3id.org/icon/ontology/iconologicallyCompliesWith">icon:iconologicallyCompliesWith</a>
    /// </summary>
    let iconologicallyCompliesWith = _prefixId.prefix "iconologicallyCompliesWith"
    /// <summary>
    ///   <para>rdfs:label : Iconologically Represents</para>
    ///   <para>rdfs:comment : This property is used to link an artwork to the element of the third level of interpretation (iconological) which it represents. This elements can be Cultural Phenomena, Social Objects (abstract concepts).
    ///
    /// Example: There is an IconologicalRecognition of Artwork1 of IntrinsicMeaning1, which is linked to the cultural phenomenon of ImitationOfClassics
    /// Then Artwork1 iconologicallyRepresents  ImitationOfClassics.
    ///
    /// Example2: There is an IconologicalRecognition of Artwork1 of IntrinsicMeaning2, which is linked to the social object "Absurdity" (and to other elements from other levels that suppor this claim...)
    ///
    /// Then Artwork1 IconologicallyRepresents Absurdity
    ///
    /// This link can be created automatically through inference thanks to the super property chain, or it can be written by users who are not planning of including contextual information to the interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/iconologicallyRepresents">icon:iconologicallyRepresents</a>
    /// </summary>
    let iconologicallyRepresents = _prefixId.prefix "iconologicallyRepresents"
    /// <summary>
    ///   <para>rdfs:label : Is artistic motif of</para>
    ///   <para>rdfs:comment : Inverse property of has artistic motif^^xsd:string</para>
    ///   <a href="https://w3id.org/icon/ontology/isArtisticMotifOf">icon:isArtisticMotifOf</a>
    /// </summary>
    let isArtisticMotifOf = _prefixId.prefix "isArtisticMotifOf"
    /// <summary>
    ///   <para>rdfs:label : Is Character Of</para>
    ///   <para>rdfs:comment : Inverse property of hasCharacter</para>
    ///   <a href="https://w3id.org/icon/ontology/isCharacterOf">icon:isCharacterOf</a>
    /// </summary>
    let isCharacterOf = _prefixId.prefix "isCharacterOf"

    /// <summary>
    ///   <para>rdfs:label : is compliant with iconographical recognition</para>
    ///   <para>rdfs:comment : Inverse of iconographically complies with</para>
    ///   <a href="https://w3id.org/icon/ontology/isCompliantWithIconographicalRecognition">icon:isCompliantWithIconographicalRecognition</a>
    /// </summary>
    let isCompliantWithIconographicalRecognition =
        _prefixId.prefix "isCompliantWithIconographicalRecognition"

    /// <summary>
    ///   <para>rdfs:label : is compliant with iconological recognition</para>
    ///   <para>rdfs:comment : inverse of iconologically complies with</para>
    ///   <a href="https://w3id.org/icon/ontology/isCompliantWithIconologicalRecognition">icon:isCompliantWithIconologicalRecognition</a>
    /// </summary>
    let isCompliantWithIconologicalRecognition =
        _prefixId.prefix "isCompliantWithIconologicalRecognition"

    /// <summary>
    ///   <para>rdfs:label : is compliant with pre-iconographical recognition</para>
    ///   <para>rdfs:comment : Inverse of pre-iconographically complies with</para>
    ///   <a href="https://w3id.org/icon/ontology/isCompliantWithPreiconographicalRecognition">icon:isCompliantWithPreiconographicalRecognition</a>
    /// </summary>
    let isCompliantWithPreiconographicalRecognition =
        _prefixId.prefix "isCompliantWithPreiconographicalRecognition"

    /// <summary>
    ///   <para>rdfs:label : Is composition of</para>
    ///   <para>rdfs:comment : Inverse property of has composition</para>
    ///   <a href="https://w3id.org/icon/ontology/isCompositionOf">icon:isCompositionOf</a>
    /// </summary>
    let isCompositionOf = _prefixId.prefix "isCompositionOf"
    /// <summary>
    ///   <para>rdfs:label : Is Compositional Structure Of</para>
    ///   <para>rdfs:comment : Inverse property of hasCompositionalStructure</para>
    ///   <a href="https://w3id.org/icon/ontology/isCompositionalStructureOf">icon:isCompositionalStructureOf</a>
    /// </summary>
    let isCompositionalStructureOf = _prefixId.prefix "isCompositionalStructureOf"
    /// <summary>
    ///   <para>rdfs:label : Is Copied Motif Of</para>
    ///   <para>rdfs:comment : Inverse property of hasCopiedMotif</para>
    ///   <a href="https://w3id.org/icon/ontology/isCopiedMotifOf">icon:isCopiedMotifOf</a>
    /// </summary>
    let isCopiedMotifOf = _prefixId.prefix "isCopiedMotifOf"
    /// <summary>
    ///   <para>rdfs:label : Is Cultural Phenomenon Of</para>
    ///   <para>rdfs:comment : Inverse property of recognizedCulturalPhenomenon</para>
    ///   <a href="https://w3id.org/icon/ontology/isCulturalPhenomenonOf">icon:isCulturalPhenomenonOf</a>
    /// </summary>
    let isCulturalPhenomenonOf = _prefixId.prefix "isCulturalPhenomenonOf"
    /// <summary>
    ///   <para>rdfs:label : Is Event Of</para>
    ///   <para>rdfs:comment : Inverse property of hasEvent</para>
    ///   <a href="https://w3id.org/icon/ontology/isEventOf">icon:isEventOf</a>
    /// </summary>
    let isEventOf = _prefixId.prefix "isEventOf"
    /// <summary>
    ///   <para>rdfs:label : Is Expressional Meaning Of</para>
    ///   <para>rdfs:comment : Inverse property of hasExpressionalMeaning</para>
    ///   <a href="https://w3id.org/icon/ontology/isExpressionalMeaningOf">icon:isExpressionalMeaningOf</a>
    /// </summary>
    let isExpressionalMeaningOf = _prefixId.prefix "isExpressionalMeaningOf"
    /// <summary>
    ///   <para>rdfs:label : Is Factual Meaning Of</para>
    ///   <para>rdfs:comment : Inverse property of hasFactualMeaning</para>
    ///   <a href="https://w3id.org/icon/ontology/isFactualMeaningOf">icon:isFactualMeaningOf</a>
    /// </summary>
    let isFactualMeaningOf = _prefixId.prefix "isFactualMeaningOf"

    /// <summary>
    ///   <para>rdfs:label : Is Iconographically Recognized By</para>
    ///   <para>rdfs:comment : Inverse property of recognizedImage</para>
    ///   <a href="https://w3id.org/icon/ontology/isIconographicallyRecognizedBy">icon:isIconographicallyRecognizedBy</a>
    /// </summary>
    let isIconographicallyRecognizedBy =
        _prefixId.prefix "isIconographicallyRecognizedBy"

    /// <summary>
    ///   <para>rdfs:label : Is iconographically referred by^^rdfs:Literal</para>
    ///   <para>rdfs:comment : Inverse property of refers to artistic motif^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/icon/ontology/isIconographicallyReferredBy">icon:isIconographicallyReferredBy</a>
    /// </summary>
    let isIconographicallyReferredBy = _prefixId.prefix "isIconographicallyReferredBy"
    /// <summary>
    ///   <para>rdfs:label : Is image of</para>
    ///   <para>rdfs:comment : Inverse property of has image</para>
    ///   <a href="https://w3id.org/icon/ontology/isImageOf">icon:isImageOf</a>
    /// </summary>
    let isImageOf = _prefixId.prefix "isImageOf"
    /// <summary>
    ///   <para>rdfs:label : Is Intrinsic Meaning Of</para>
    ///   <para>rdfs:comment : Inverse property of recognized intrinsic meaning</para>
    ///   <a href="https://w3id.org/icon/ontology/isIntrinsicMeaningOf">icon:isIntrinsicMeaningOf</a>
    /// </summary>
    let isIntrinsicMeaningOf = _prefixId.prefix "isIntrinsicMeaningOf"
    /// <summary>
    ///   <para>rdfs:label : Is Invenzione Of</para>
    ///   <para>rdfs:comment : Inverse property of hasInvenzione</para>
    ///   <a href="https://w3id.org/icon/ontology/isInvenzioneOf">icon:isInvenzioneOf</a>
    /// </summary>
    let isInvenzioneOf = _prefixId.prefix "isInvenzioneOf"
    /// <summary>
    ///   <para>rdfs:label : Is Named Object Of</para>
    ///   <para>rdfs:comment : Inverse property of hasNamedObject</para>
    ///   <a href="https://w3id.org/icon/ontology/isNamedObjectOf">icon:isNamedObjectOf</a>
    /// </summary>
    let isNamedObjectOf = _prefixId.prefix "isNamedObjectOf"
    /// <summary>
    ///   <para>rdfs:label : Is Personification Of</para>
    ///   <para>rdfs:comment : Inverse property of hasPersonification</para>
    ///   <a href="https://w3id.org/icon/ontology/isPersonificationOf">icon:isPersonificationOf</a>
    /// </summary>
    let isPersonificationOf = _prefixId.prefix "isPersonificationOf"
    /// <summary>
    ///   <para>rdfs:label : Is Place Of</para>
    ///   <para>rdfs:comment : Inverse property of hasPlace</para>
    ///   <a href="https://w3id.org/icon/ontology/isPlaceOf">icon:isPlaceOf</a>
    /// </summary>
    let isPlaceOf = _prefixId.prefix "isPlaceOf"
    /// <summary>
    ///   <para>rdfs:label : Is Prototypical Motif Of</para>
    ///   <para>rdfs:comment : Inverse property of hasPrototypicalMotif</para>
    ///   <a href="https://w3id.org/icon/ontology/isPrototypicalMotifOf">icon:isPrototypicalMotifOf</a>
    /// </summary>
    let isPrototypicalMotifOf = _prefixId.prefix "isPrototypicalMotifOf"
    /// <summary>
    ///   <para>owl:deprecated : since 1.1 version^^xsd:string</para>
    ///   <para>rdfs:label : Is Pure Form Of</para>
    ///   <para>rdfs:comment : Inverse property of associatedForm</para>
    ///   <a href="https://w3id.org/icon/ontology/isPureFormOf">icon:isPureFormOf</a>
    /// </summary>
    let isPureFormOf = _prefixId.prefix "isPureFormOf"
    /// <summary>
    ///   <para>rdfs:label : Is Rec Attribute Of</para>
    ///   <para>rdfs:comment : Inverse property of hasRecAttribute</para>
    ///   <a href="https://w3id.org/icon/ontology/isRecAttributeOf">icon:isRecAttributeOf</a>
    /// </summary>
    let isRecAttributeOf = _prefixId.prefix "isRecAttributeOf"
    /// <summary>
    ///   <para>rdfs:label : Is Recogn Of</para>
    ///   <para>rdfs:comment : Inverse property of recognizedInvenzione</para>
    ///   <a href="https://w3id.org/icon/ontology/isRecognOf">icon:isRecognOf</a>
    /// </summary>
    let isRecognOf = _prefixId.prefix "isRecognOf"
    /// <summary>
    ///   <para>rdfs:label : Is Recognized Artistic Motif Of</para>
    ///   <para>rdfs:comment : Inverse property of recognized artistic motif</para>
    ///   <a href="https://w3id.org/icon/ontology/isRecognizedArtisticMotifOf">icon:isRecognizedArtisticMotifOf</a>
    /// </summary>
    let isRecognizedArtisticMotifOf = _prefixId.prefix "isRecognizedArtisticMotifOf"
    /// <summary>
    ///   <para>rdfs:label : Is Recognized Composition Of</para>
    ///   <para>rdfs:comment : Inverse property of recognizedComposition</para>
    ///   <a href="https://w3id.org/icon/ontology/isRecognizedCompositionOf">icon:isRecognizedCompositionOf</a>
    /// </summary>
    let isRecognizedCompositionOf = _prefixId.prefix "isRecognizedCompositionOf"
    /// <summary>
    ///   <para>rdfs:label : Is Recognized Concept Of</para>
    ///   <para>rdfs:comment : Inverse property of recognizedConcept</para>
    ///   <a href="https://w3id.org/icon/ontology/isRecognizedConceptOf">icon:isRecognizedConceptOf</a>
    /// </summary>
    let isRecognizedConceptOf = _prefixId.prefix "isRecognizedConceptOf"
    /// <summary>
    ///   <para>rdfs:label : Is Symbol Of</para>
    ///   <para>rdfs:comment : Inverse property of has symbol</para>
    ///   <a href="https://w3id.org/icon/ontology/isSymbolOf">icon:isSymbolOf</a>
    /// </summary>
    let isSymbolOf = _prefixId.prefix "isSymbolOf"
    /// <summary>
    ///   <para>rdfs:label : Part Of (ICON)</para>
    ///   <para>rdfs:comment : Inverse property of hasPart</para>
    ///   <a href="https://w3id.org/icon/ontology/partOf">icon:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"

    /// <summary>
    ///   <para>rdfs:label : pre-iconographically complies with</para>
    ///   <para>rdfs:comment : This property is used to link all the pre-iconographical and formal motif recognitions recognitions that take part in one or more interpretation(s), to that/those interpretation(s)</para>
    ///   <a href="https://w3id.org/icon/ontology/preiconographicallyCompliesWith">icon:preiconographicallyCompliesWith</a>
    /// </summary>
    let preiconographicallyCompliesWith =
        _prefixId.prefix "preiconographicallyCompliesWith"

    /// <summary>
    ///   <para>rdfs:label : Pre-iconographically Depicts</para>
    ///   <para>rdfs:comment : This property is used to link an artwork to the element of the first level of interpretation (pre-iconographical) which it depicts. This element can be a Natural Element, an Action, Expression, or an element included in a recognized Composition (again, natural element, action, expression).
    ///
    /// Example: There is a PreiconographicalRecognition of Artwork1 of ArtisticMotif1, which is linked to the natural element bear.
    /// Then Artwork1 preiconographicallyDepicts  bear.
    ///
    /// Example2: There is a PreiconographicalRecognition of Artwork1 of ArtisticMotif2, which is linked to the composition1, composed by a bear and the action of eating.
    /// Then Artwork1 preiconographicallyDepicts bear and eating.
    ///
    /// This link can be created automatically through inference thanks to the super property chain, or it can be written by users who are not planning of including contextual information to the interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/preiconographicallyDepicts">icon:preiconographicallyDepicts</a>
    /// </summary>
    let preiconographicallyDepicts = _prefixId.prefix "preiconographicallyDepicts"
    /// <summary>
    ///   <para>rdfs:label : Quantity</para>
    ///   <para>rdfs:comment : This data property expresses the number or elements represented in an artistic motif, especially when the recognition of each element is not needed</para>
    ///   <a href="https://w3id.org/icon/ontology/quantity">icon:quantity</a>
    /// </summary>
    let quantity = _prefixId.prefix "quantity"
    /// <summary>
    ///   <para>rdfs:label : Recognized Artistic Motif</para>
    ///   <para>rdfs:comment : This relation associates the Artistic Motif to the Pre-iconographical Recognition that recognizes it at the first level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedArtisticMotif">icon:recognizedArtisticMotif</a>
    /// </summary>
    let recognizedArtisticMotif = _prefixId.prefix "recognizedArtisticMotif"
    /// <summary>
    ///   <para>rdfs:label : Recognized Composition</para>
    ///   <para>rdfs:comment : This relation associates the Composition to the Pre-iconographical Recognition that recognizes it at the first level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedComposition">icon:recognizedComposition</a>
    /// </summary>
    let recognizedComposition = _prefixId.prefix "recognizedComposition"
    /// <summary>
    ///   <para>rdfs:label : Recognized Concept</para>
    ///   <para>rdfs:comment : This relation expresses the Concept that is related to the Intrinsic Meaning</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedConcept">icon:recognizedConcept</a>
    /// </summary>
    let recognizedConcept = _prefixId.prefix "recognizedConcept"
    /// <summary>
    ///   <para>rdfs:label : Recognized Cultural Phenomenon</para>
    ///   <para>rdfs:comment : This relation expresses the Cultural Phenomenon that is related to the Intrinsic Meaning</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedCulturalPhenomenon">icon:recognizedCulturalPhenomenon</a>
    /// </summary>
    let recognizedCulturalPhenomenon = _prefixId.prefix "recognizedCulturalPhenomenon"
    /// <summary>
    ///   <para>owl:deprecated : since new version 25/03</para>
    ///   <para>rdfs:label : Recognized Genre</para>
    ///   <para>rdfs:comment : This property is substituted by the the solution adopted by linked.art using crm:P2_has_type as follows: &lt;subject&gt;, crm:P2_has_type, &lt;specific style term&gt;.  &lt;specific style term&gt; crm:P2_has_type, &lt;http://vocab.getty.edu/aat/300015646&gt; # the AAT term indicating the concept of style.</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedGenre">icon:recognizedGenre</a>
    /// </summary>
    let recognizedGenre = _prefixId.prefix "recognizedGenre"
    /// <summary>
    ///   <para>rdfs:label : Recognized Image</para>
    ///   <para>rdfs:comment : This relation associates the Image to the Iconographical Recognition that recognizes it at the second level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedImage">icon:recognizedImage</a>
    /// </summary>
    let recognizedImage = _prefixId.prefix "recognizedImage"
    /// <summary>
    ///   <para>rdfs:label : Recognized Intrinsic Meaning</para>
    ///   <para>rdfs:comment : This relation associates the Intrinsic Meaning to the Iconological Recognition that recognizes it at the third level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedIntrinsicMeaning">icon:recognizedIntrinsicMeaning</a>
    /// </summary>
    let recognizedIntrinsicMeaning = _prefixId.prefix "recognizedIntrinsicMeaning"
    /// <summary>
    ///   <para>rdfs:label : Recognized Invenzione</para>
    ///   <para>rdfs:comment : This relation associates the Invenzione to the Iconographical Recognition that recognizes it at the second level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedInvenzione">icon:recognizedInvenzione</a>
    /// </summary>
    let recognizedInvenzione = _prefixId.prefix "recognizedInvenzione"
    /// <summary>
    ///   <para>rdfs:label : Recognized Visual Subject</para>
    ///   <para>rdfs:comment : This property is used to link a Recognition to the recognized Visual Subject.</para>
    ///   <a href="https://w3id.org/icon/ontology/recognizedVisualSubject">icon:recognizedVisualSubject</a>
    /// </summary>
    let recognizedVisualSubject = _prefixId.prefix "recognizedVisualSubject"
    /// <summary>
    ///   <para>rdfs:label : Refers To Artistic Motif</para>
    ///   <para>rdfs:comment : This relation associates a Composition or an Artistic Motif to the Iconographical Recognition that describes it at the second level of interpretation.</para>
    ///   <a href="https://w3id.org/icon/ontology/refersToArtisticMotif">icon:refersToArtisticMotif</a>
    /// </summary>
    let refersToArtisticMotif = _prefixId.prefix "refersToArtisticMotif"
    /// <summary>
    ///   <para>rdfs:label : Region Description</para>
    ///   <para>rdfs:comment : This data property can be used to link an artistic motif or a composition with their coordinates in the image of the artwork in which they are recognized. These coordinates could indicate the bounding boxes of the detections of a computer vision algorithms or could also be the IIIF URI that selects the part of the image of the painting in which the artistic motif or the composition are found</para>
    ///   <a href="https://w3id.org/icon/ontology/regionDescription">icon:regionDescription</a>
    /// </summary>
    let regionDescription = _prefixId.prefix "regionDescription"
    /// <summary>
    ///   <para>rdfs:label : Takes part in</para>
    ///   <para>rdfs:comment : Inverse property of composed of</para>
    ///   <a href="https://w3id.org/icon/ontology/takesPartIn">icon:takesPartIn</a>
    /// </summary>
    let takesPartIn = _prefixId.prefix "takesPartIn"
    /// <summary>
    ///   <para>rdfs:label : Visually Represents</para>
    ///   <para>rdfs:comment : This property is used to link a Visual Subject (the subject visually represented in the specific artwork) with the general subject entity (for instance the controlled vocabulary entry). Example: the image of Hercules in the Farnese Hercules linked to the general Hercules subject expressed in Iconclass (94L) or the URI of the "general" Hercules in the KG. For specific interpretation-level relationships, see and use one of this property's subproperties.</para>
    ///   <a href="https://w3id.org/icon/ontology/visuallyRepresents">icon:visuallyRepresents</a>
    /// </summary>
    let visuallyRepresents = _prefixId.prefix "visuallyRepresents"
