namespace https.w3id.org.lso.intro.beta202408.hash

open DoxAletheia

module intro =
    let _namespace_name = "https://w3id.org/lso/intro/beta202408#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class comprises subclasses for every formal aspect of a text or image. It is divided into the subclasses INT Part and INT Composition, the former containing elements possibly structured according to the latter. Instances or subclasses of these two classes are likely also instances / subclasses of other subclasses of INT4 Feature: An INT Part can at the same time be an INT Object (formal and semantic) or an INT Dramatic Entity (formal and rhetorical); questions of perspective and vanishing point can be considered in a formal as well as a rhetorical respect. As a consequence of the ontology's origin, INT Part is currently dominated by literary terms which makes the addition of custom subclasses for pictorial features necessary.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT10_FormalFeature"></see></summary>
    let INT10_FormalFeature = _prefix "INT10_FormalFeature"
    /// <summary>
    /// This class comprises features that 'are in' or 'can be found in' or 'can be read out of' a text or an image. INT2 Actualizations of these features are the results of a receptive process that identifies the specific form the INT4 Feature – a distinct abstract concept, itself separate from the text or image – takes in the text or image. This class therefore has a wide scope. Its domain could be divided into subclasses following any number of different ratios; to avoid the resulting restrictions and/or complex hierarchies, the actual subclasses of the INT4 Feature represent diverse approaches to its subject matter, covering medial aspects as well as aspect of form and semantics. They can be populated resp. extended with custom subclasses based e.g. on relevant reference works: The class INT8 Rhetorical Feature could contain concepts based on classical rhetoric like allegory or personification, but would of course also include the pictorial pendants of these tropes. Lemmata from handbooks of poetic terms as well as concepts of pictorial composition could populate the INT10 Formal Feature resp. its (sub-)subclasses. Subclasses of INT9 Semantic Feature could be extended using art thesauri as well as handbooks on literary motives.
    /// 			For external thesauri and vocabularies see, e. g., ICONCLASS, the Getty Art and Architecture Thesaurus, the Getty Cultural Objects Name Authority, the Getty Union List of Artist Names, the Literary Theme Ontology (LTO), the Document Components Ontology, the OntoPoetry Ontology, the Taxonomy of Themes and Motifs (TTM2) ...
    /// <see href="https://w3id.org/lso/intro/beta202408#INT4_Feature"></see></summary>
    let INT4_Feature = _prefix "INT4_Feature"
    /// <summary>
    /// This class comprises (as subclasses) the many classifications of interrelations between instances of texts of images (on any ontological level) that are identified, for example, in research literature, but also in greek rhetoric, in genre theory and so on.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT11_TypeOfInterrelation"></see></summary>
    let INT11_TypeOfInterrelation = _prefix "INT11_TypeOfInterrelation"
    /// <summary>
    /// This class comprises common concepts of interrelations such as 'citation', 'plagiarism', 'allusion' and so on; no further definition is necessary.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT12_CommonInterrelationTypes"></see></summary>
    let INT12_CommonInterrelationTypes = _prefix "INT12_CommonInterrelationTypes"
    /// <summary>
    /// This class comprises types of interrelations that are defined or applied in genre theory.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT13_InterrelationInGenreTheory"></see></summary>
    let INT13_InterrelationInGenreTheory = _prefix "INT13_InterrelationInGenreTheory"
    /// <summary>
    /// This class comprises interrelations (likely: mostly intertextual relations) that are defined in works on rhetoric.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT14_InterrelationInRhetoric"></see></summary>
    let INT14_InterrelationInRhetoric = _prefix "INT14_InterrelationInRhetoric"

    /// <summary>
    /// This class comprises intertextual relationships that are defined or applied in research literature dedicated to intertextuality theory.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT15_IntertextualityInIntTheories"></see></summary>
    let INT15_IntertextualityInIntTheories =
        _prefix "INT15_IntertextualityInIntTheories"

    /// <summary>
    /// This class comprises expressions (e.g. texts represented as F2 Expressions) or parts thereof as they are represented in F3 Manifestations. INT16 Segments can be located inside the F3 Manifestation by means of page numbers etc. and are thus identifiable (and citable). They are not identical to/subclasses of F3 Manifestations, since they only make a part of it; they are not identical to F2 Expressions, since they have distinct metadata linking them to, e. g., a certain edition of a work. The INT16 Segment can be linked to an F2 Expression (resp. a E36 Visual Item) or an INT1 Passage through R16 incorporates. It can be linked to a physical carrier (like LRMs "F5_Item") through P128 is carried by.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT16_Segment"></see></summary>
    let INT16_Segment = _prefix "INT16_Segment"
    /// <summary>
    /// This class comprises types of interrelations between a text or an image on any ontological level and an architext that have merely classificatory or typological function, including a text/an image being a part of an architext (an epoch, a movement etc.), its initial or final text/image, etc.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT17_FunctionalRelation"></see></summary>
    let INT17_FunctionalRelation = _prefix "INT17_FunctionalRelation"
    /// <summary>
    /// This class comprises references to – usually: real – identifiable objects of any kind. It is not restricted to non-fictional texts resp. images depicting real life objects or events, but can be most easily applied there. The CIDOC CRM property P67 refers to is recommended to establish the link to the entity referred to. However, there are two options: P67 can link this INT18 Reference (or any other feature) to the external entity, but it can also link the corresponding actualization of said feature to the external entity. This depends on the respective theoretical framework and is not specified in the context of this ontology.
    /// 			(The scope of this class also includes references to other images/texts, if one wants to model an interrelation this way.)
    /// <see href="https://w3id.org/lso/intro/beta202408#INT18_Reference"></see></summary>
    let INT18_Reference = _prefix "INT18_Reference"
    /// <summary>
    /// This class comprises every semantic aspect of a text or image, like the common notions of 'plot', 'sujet', or 'character'. While most subclasses are still object to refinement and addition – to indicate their provisional status they are not yet numbered in this version of INTRO –, INT18 Reference has been numbered to indicate its consolidated status.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT9_SemanticFeature"></see></summary>
    let INT9_SemanticFeature = _prefix "INT9_SemanticFeature"
    /// <summary>
    /// The class includes all features that can be attributed to a text or image with regard to the role that these works play in a plot, for example in a social, political or religious context. These characteristics take account of the fact that the works in question pursue a specific purpose that goes beyond content and form and that is apparent 'on the surface‘ or by application of certain conventions or handed-down standards. While INTRO-subclasses of this class are limited to those close to the functionality of INTRO and which are to be applied to the relation between primary and secondary (textual) sources, subclasses can of course also include concepts from visual art. A pragmatic feature of a painting might be a donor portrait expressing gratitude, the portrait of a ruler serving propaganda purposes, a bible scene serving as guide for pious action. Pragmatic features of texts include bibliographic references, acknowledgments, and the like.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT_PragmaticFeature"></see></summary>
    let INT_PragmaticFeature = _prefix "INT_PragmaticFeature"
    /// <summary>
    /// The INT1 Passage is a means of modelling an identifiable part of an E73 Information Object or its subclasses – without that part being removed from its source Information Object.
    /// 			For examples, see subclass comments.
    /// 			The skos:broadMatch states that the INT1 Passage can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT1 Passage's location.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT1_Passage"></see></summary>
    let INT1_Passage = _prefix "INT1_Passage"
    /// <summary>
    /// The INT21 TextPassage is a means of modelling an identifiable part of an E73 Information Object or its subclasses – without that part being removed from its source Information Object.
    /// 			Examples:
    /// 			- The words 'Abandon all hope ye who enter here' from Canto III of Dante's Inferno.
    /// 			- The first four lines of Rilke's poem "Archaischer Torso Apollos"
    /// 			- The last item on a shopping list.
    /// 			The skos:broadMatch states that the INT21 TextPassage can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT21 TextPassage's location.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT21_TextPassage"></see></summary>
    let INT21_TextPassage = _prefix "INT21_TextPassage"
    /// <summary>
    /// The INT22 ImageArea is a means of modelling an identifiable part of an image (itself modelled as an E73 Information Object or one of its subclasses) – without that part being removed from its source Information Object.
    /// 			Examples:
    /// 			- The part of Leonardo's Mona Lisa showing Mona Lisa's smile.
    /// 			- The bottom 3/5 of Rothko's Painting "Orange And Yellow" (1956), dominated by the fuzzy orange rectangle.
    /// 			- The part of the "Smiley Face" originally invented by Harvey Ball that shows the Smiley's left eye.
    /// 			- The part of Piranesi's The Drawbridge, 2nd version, showing a drawbridge.
    ///
    /// 			The skos:broadMatch states that the INT22 ImageArea can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT22 ImageArea's location.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT22_ImageArea"></see></summary>
    let INT22_ImageArea = _prefix "INT22_ImageArea"
    /// <summary>
    /// This class contains visual features of images - but possibly also of texts. Its subclasses are rudimentary, it is very likely that instances of other INT4 Feature subclasses can be classified as visual features at the same time. This might be the case for, e.g., INT Composition (although for these instances classification as an INT26 Shape should also be considered).
    /// <see href="https://w3id.org/lso/intro/beta202408#INT23_VisualFeature"></see></summary>
    let INT23_VisualFeature = _prefix "INT23_VisualFeature"
    /// <summary>
    /// This class contains textual features, usually found on texts - but possibly also on images. It is very likely that instances of other INT4 Feature subclasses can be classified as textual features at the same time.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT24_TextualFeature"></see></summary>
    let INT24_TextualFeature = _prefix "INT24_TextualFeature"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT25_Color"></see>
    /// </summary>
    let INT25_Color = _prefix "INT25_Color"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT26_Shape"></see>
    /// </summary>
    let INT26_Shape = _prefix "INT26_Shape"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT27_Texture"></see>
    /// </summary>
    let INT27_Texture = _prefix "INT27_Texture"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT28_Ratio"></see>
    /// </summary>
    let INT28_Ratio = _prefix "INT28_Ratio"
    /// <summary>
    /// The fact that a text or an image shows - in its own specific way - a certain feature (which itself is an abstract concept and takes form in many texts/images), e.g. a motif, an atmosphere, a theme, a figure of speech.
    /// 			Examples:
    /// 			- the specific actualization of the motif of patricide in Sophokles' 'Ödipus Rex'.
    /// 			- the specific actualization of the Faust-subject in Goethe's 'Faust'.
    /// 			- the specific actualization of the iambic pentameter in Rilke's 'Archaischer Torso Apollos".
    /// 			- the specific actualization of the Ophelia-character in John Everett Millais' painting "Ophelia" (1852).
    ///
    /// <see href="https://w3id.org/lso/intro/beta202408#INT2_ActualizationOfFeature"></see></summary>
    let INT2_ActualizationOfFeature = _prefix "INT2_ActualizationOfFeature"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT31_IntertextualRelation"></see>
    /// </summary>
    let INT31_IntertextualRelation = _prefix "INT31_IntertextualRelation"
    /// <summary>
    /// This class comprises the abstract notion of a relationship between texts and/or images resp. their parts as it is identified by a recipient (which is not the same as the rhetorical entity 'quotation'). Every INT3 Interrelation has at least 2 related entities, which are texts/images (on any ontological level) or INT2 Actualizations of Features. An INT3 Interrelation is possibly identified in an INT Interpretation and further defined by an INT11 TypeOfInterrelation.
    /// 			The skos:broadMatch to oa:Annotation indicates that stating the existence of an intertextual relation can be seen as a kind of annotation made to resources, in this case: at least two, the related entities (texts and/or images).
    /// <see href="https://w3id.org/lso/intro/beta202408#INT3_Interrelation"></see></summary>
    let INT3_Interrelation = _prefix "INT3_Interrelation"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT32_InterpictorialRelation"></see>
    /// </summary>
    let INT32_InterpictorialRelation = _prefix "INT32_InterpictorialRelation"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT33_IntermedialRelation"></see>
    /// </summary>
    let INT33_IntermedialRelation = _prefix "INT33_IntermedialRelation"

    /// <summary>
    /// This class comprises intermedial relations that can be found in research literature dedicated to intermediality theory.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT34_IntermedialityInIntermedialityTheories"></see></summary>
    let INT34_IntermedialityInIntermedialityTheories =
        _prefix "INT34_IntermedialityInIntermedialityTheories"

    /// <summary>
    /// This class comprises interpictorial relations that can be found in research literature dedicated to interpictoriality theory.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT35_InterpictorialityInInterpictorialityTheories"></see></summary>
    let INT35_InterpictorialityInInterpictorialityTheories =
        _prefix "INT35_InterpictorialityInInterpictorialityTheories"

    /// <summary>
    /// An INT6 Architextual Entity consists in a number of texts/images which in some way give reason to see them as connected, related, sharing a common feature.
    /// 			Examples for INT6 Architextual Entities can be
    /// 			- discourses (members sharing a discoursive element, a topic etc.)
    /// 			- genres (members sharing genre conventions)
    /// 			- a discipline (members deriving from the same disciplinary background)
    /// 			- an oeuvre (members created by the same person)
    /// 			- national literatures/arts (members whose creators share a nationality) etc.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT6_Architext"></see></summary>
    let INT6_Architext = _prefix "INT6_Architext"
    /// <summary>
    /// This class comprises every aspect of a text or an image that can be described in terms of rhetorics - ranging from the occurrence of rhetorical tropes to parts of an e.g. research paper like 'introduction' or 'quotation' (pragmatic entities) to aspects of the narrative act such as 'voice' or 'narrating time' (narratological entities). Questions of composition in visual arts can often also be classified as a rhetorical feature.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT8_RhetoricalFeature"></see></summary>
    let INT8_RhetoricalFeature = _prefix "INT8_RhetoricalFeature"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Act"></see>
    /// </summary>
    let INT_Act = _prefix "INT_Act"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Part"></see>
    /// </summary>
    let INT_Part = _prefix "INT_Part"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Atmosphere"></see>
    /// </summary>
    let INT_Atmosphere = _prefix "INT_Atmosphere"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Chapter"></see>
    /// </summary>
    let INT_Chapter = _prefix "INT_Chapter"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Character"></see>
    /// </summary>
    let INT_Character = _prefix "INT_Character"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Composition"></see>
    /// </summary>
    let INT_Composition = _prefix "INT_Composition"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Constellation"></see>
    /// </summary>
    let INT_Constellation = _prefix "INT_Constellation"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Definition"></see>
    /// </summary>
    let INT_Definition = _prefix "INT_Definition"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Description"></see>
    /// </summary>
    let INT_Description = _prefix "INT_Description"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Discipline"></see>
    /// </summary>
    let INT_Discipline = _prefix "INT_Discipline"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Discourse"></see>
    /// </summary>
    let INT_Discourse = _prefix "INT_Discourse"
    /// <summary>
    /// This class comprises concepts from drama theory.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT_DramaticEntity"></see></summary>
    let INT_DramaticEntity = _prefix "INT_DramaticEntity"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_TextualGenreSpecifics"></see>
    /// </summary>
    let INT_TextualGenreSpecifics = _prefix "INT_TextualGenreSpecifics"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Epoch"></see>
    /// </summary>
    let INT_Epoch = _prefix "INT_Epoch"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Event"></see>
    /// </summary>
    let INT_Event = _prefix "INT_Event"
    /// <summary>
    /// The class comprises figures of speech. Since there are countless classification systems (the most common dividing figures into tropoi - metaphor, metonymy ... - and schemata/figurae, further dividing the latter into figures of thougth and figures of word, further dividing the latter into grammatical and rhetorical figures of word), no subclasses will be provided.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT_FigurativeFeature"></see></summary>
    let INT_FigurativeFeature = _prefix "INT_FigurativeFeature"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_FigurativeMeaning"></see>
    /// </summary>
    let INT_FigurativeMeaning = _prefix "INT_FigurativeMeaning"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Genre"></see>
    /// </summary>
    let INT_Genre = _prefix "INT_Genre"
    /// <summary>
    /// INT Genre Specifics comprises all features that are used to assign a certain genre - whether textual or visual -, are typical of such a genre, or occur frequently in it. Instances might often be also instances of the other subclasses of INT4 Feature. INT Genre Specifics' two subclasses – INT Visual Genre Specifics and INT Textual Genre Specifics – do not imply that each feature must be either–or, in some cases features will be assignable to both classes.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT_GenreSpecifics"></see></summary>
    let INT_GenreSpecifics = _prefix "INT_GenreSpecifics"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Identification"></see>
    /// </summary>
    let INT_Identification = _prefix "INT_Identification"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_IndividualCharacter"></see>
    /// </summary>
    let INT_IndividualCharacter = _prefix "INT_IndividualCharacter"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_IndividualObject"></see>
    /// </summary>
    let INT_IndividualObject = _prefix "INT_IndividualObject"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Object"></see>
    /// </summary>
    let INT_Object = _prefix "INT_Object"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_IndividualPlace"></see>
    /// </summary>
    let INT_IndividualPlace = _prefix "INT_IndividualPlace"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Place"></see>
    /// </summary>
    let INT_Place = _prefix "INT_Place"
    /// <summary>
    /// The result of a interpretative act, possibly: as perceived in research literature. An interpretation can identify references or actualizations or the like. A number of interpretations can together recreate the structure of, e.g., a research paper. Accordingly, apart from linking INT Interpretations to the subjects of the interpretation, like intertextual relations or textual features, they can be linked to each other via R9 has subsequent feature resp. R9i has preceding feature.
    /// 			Examples:
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' features a detective character.
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' contains references to Arthur Conan Doyle's 'Sherlock Holmes'.
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' is set in the 14th century.
    /// 			- the conclusion that Umberto Eco's 'The Name of the Rose' belongs to the genre 'postmodern crime novel'.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT_Interpretation"></see></summary>
    let INT_Interpretation = _prefix "INT_Interpretation"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Line"></see>
    /// </summary>
    let INT_Line = _prefix "INT_Line"
    /// <summary>
    /// This class comprises rhetorical concepts from lyric theory.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT_LyricalEntity"></see></summary>
    let INT_LyricalEntity = _prefix "INT_LyricalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Mood"></see>
    /// </summary>
    let INT_Mood = _prefix "INT_Mood"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Motif"></see>
    /// </summary>
    let INT_Motif = _prefix "INT_Motif"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Movement"></see>
    /// </summary>
    let INT_Movement = _prefix "INT_Movement"
    /// <summary>
    /// This class comprises narratological concepts insofar as they correlate with rhetorical concepts (like 'speech', 'distance', 'perspective' etc.). Due to the plurality of narratological frameworks, no subclasses will be provided at this point.
    /// <see href="https://w3id.org/lso/intro/beta202408#INT_NarratologicalEntity"></see></summary>
    let INT_NarratologicalEntity = _prefix "INT_NarratologicalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Oeuvre"></see>
    /// </summary>
    let INT_Oeuvre = _prefix "INT_Oeuvre"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Opinion"></see>
    /// </summary>
    let INT_Opinion = _prefix "INT_Opinion"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Paragraph"></see>
    /// </summary>
    let INT_Paragraph = _prefix "INT_Paragraph"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Plot"></see>
    /// </summary>
    let INT_Plot = _prefix "INT_Plot"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Scene"></see>
    /// </summary>
    let INT_Scene = _prefix "INT_Scene"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_School"></see>
    /// </summary>
    let INT_School = _prefix "INT_School"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Situation"></see>
    /// </summary>
    let INT_Situation = _prefix "INT_Situation"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_SpaciallyDefinedArchitext"></see>
    /// </summary>
    let INT_SpaciallyDefinedArchitext = _prefix "INT_SpaciallyDefinedArchitext"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_State"></see>
    /// </summary>
    let INT_State = _prefix "INT_State"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Subject"></see>
    /// </summary>
    let INT_Subject = _prefix "INT_Subject"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Subtext"></see>
    /// </summary>
    let INT_Subtext = _prefix "INT_Subtext"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Tableau"></see>
    /// </summary>
    let INT_Tableau = _prefix "INT_Tableau"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_TemporallyDefinedArchitext"></see>
    /// </summary>
    let INT_TemporallyDefinedArchitext = _prefix "INT_TemporallyDefinedArchitext"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_TextType"></see>
    /// </summary>
    let INT_TextType = _prefix "INT_TextType"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Theme"></see>
    /// </summary>
    let INT_Theme = _prefix "INT_Theme"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Theory"></see>
    /// </summary>
    let INT_Theory = _prefix "INT_Theory"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_TimeSpan"></see>
    /// </summary>
    let INT_TimeSpan = _prefix "INT_TimeSpan"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Topic"></see>
    /// </summary>
    let INT_Topic = _prefix "INT_Topic"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Topos"></see>
    /// </summary>
    let INT_Topos = _prefix "INT_Topos"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_TypeOfCharacter"></see>
    /// </summary>
    let INT_TypeOfCharacter = _prefix "INT_TypeOfCharacter"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_TypeOfPlace"></see>
    /// </summary>
    let INT_TypeOfPlace = _prefix "INT_TypeOfPlace"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_TypicalObject"></see>
    /// </summary>
    let INT_TypicalObject = _prefix "INT_TypicalObject"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_VarietyOfText"></see>
    /// </summary>
    let INT_VarietyOfText = _prefix "INT_VarietyOfText"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_Verse"></see>
    /// </summary>
    let INT_Verse = _prefix "INT_Verse"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#INT_VisualGenreSpecifics"></see>
    /// </summary>
    let INT_VisualGenreSpecifics = _prefix "INT_VisualGenreSpecifics"
    /// <summary>
    /// Links a text or an image – usually: a work or an expression – to an INT1 Passage from that text or image, e.g. a book to a passage on page three of this book, or a painting to an area on this paining.
    /// <see href="https://w3id.org/lso/intro/beta202408#R10_hasPassage"></see></summary>
    let R10_hasPassage = _prefix "R10_hasPassage"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R10i_isPassageOf"></see>
    /// </summary>
    let R10i_isPassageOf = _prefix "R10i_isPassageOf"
    /// <summary>
    /// Links an INT3 Interrelation to the entity referred to in the relationship (a text or image on any ontological level or a feature actualized in the text resp. image in question).
    /// <see href="https://w3id.org/lso/intro/beta202408#R12_hasReferredToEntity"></see></summary>
    let R12_hasReferredToEntity = _prefix "R12_hasReferredToEntity"
    /// <summary>
    /// Links any INT3 Interrelation to a text or image (on any ontological level) or INT2 Actualization of Feature that is part of the INT3 Interrelation. The skos:broadMatch states that this property is a more specific version of oa:hasTarget in the sense that the INT3 Interrelation can be seen as an annotation, the texts/images linked by this relationship as their targets.
    /// <see href="https://w3id.org/lso/intro/beta202408#R24_hasRelatedEntity"></see></summary>
    let R24_hasRelatedEntity = _prefix "R24_hasRelatedEntity"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R12i_isReferredToEntity"></see>
    /// </summary>
    let R12i_isReferredToEntity = _prefix "R12i_isReferredToEntity"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R24i_isRelatedEntity"></see>
    /// </summary>
    let R24i_isRelatedEntity = _prefix "R24i_isRelatedEntity"
    /// <summary>
    /// Links an INT3 Interrelation to a referring entity (a text or image on any ontological level or a feature actualized in the text resp. image in question).
    /// <see href="https://w3id.org/lso/intro/beta202408#R13_hasReferringEntity"></see></summary>
    let R13_hasReferringEntity = _prefix "R13_hasReferringEntity"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R13i_isReferringEntity"></see>
    /// </summary>
    let R13i_isReferringEntity = _prefix "R13i_isReferringEntity"
    /// <summary>
    /// Links an INT16 Segment to the text or image on any ontological level (passage, expression, work) it incorporates.
    /// <see href="https://w3id.org/lso/intro/beta202408#R16_incorporates"></see></summary>
    let R16_incorporates = _prefix "R16_incorporates"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R16i_isIncorporatedIn"></see>
    /// </summary>
    let R16i_isIncorporatedIn = _prefix "R16i_isIncorporatedIn"
    /// <summary>
    /// Links the specific INT2 Actualization of Feature to the (abstract concept of the) feature it actualizes, an INT4 Feature.
    /// <see href="https://w3id.org/lso/intro/beta202408#R17_actualizesFeature"></see></summary>
    let R17_actualizesFeature = _prefix "R17_actualizesFeature"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R17i_featureActualizedIn"></see>
    /// </summary>
    let R17i_featureActualizedIn = _prefix "R17i_featureActualizedIn"
    /// <summary>
    /// Links a text or an image (on any ontological level) or an INT2 Actualization of Feature to an INT2 Actualization of Feature found on it. (Actualizations found on actualizations - this occurs in cases where, e.g., the actualization of the feature INT Individual Character can be read as the actualization of the feature INT Character Type or INT18 Reference.)
    /// <see href="https://w3id.org/lso/intro/beta202408#R18_showsActualization"></see></summary>
    let R18_showsActualization = _prefix "R18_showsActualization"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R18i_actualizationFoundOn"></see>
    /// </summary>
    let R18i_actualizationFoundOn = _prefix "R18i_actualizationFoundOn"
    /// <summary>
    /// Links an INT3 Interrelation to its INT11 Type of Interrelation.
    /// <see href="https://w3id.org/lso/intro/beta202408#R19_hasType"></see></summary>
    let R19_hasType = _prefix "R19_hasType"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R19i_isTypeOf"></see>
    /// </summary>
    let R19i_isTypeOf = _prefix "R19i_isTypeOf"
    /// <summary>
    /// Links an INT Interpretation to the instance of text or image (on any ontological level) it discusses.
    /// <see href="https://w3id.org/lso/intro/beta202408#R20_discusses"></see></summary>
    let R20_discusses = _prefix "R20_discusses"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R20i_isDiscussedIn"></see>
    /// </summary>
    let R20i_isDiscussedIn = _prefix "R20i_isDiscussedIn"
    /// <summary>
    /// Links an INT Identification or INT Interpretation to the INT3 Interrelation or the INT2 Actualization of Feature it identifies.
    /// <see href="https://w3id.org/lso/intro/beta202408#R21_identifies"></see></summary>
    let R21_identifies = _prefix "R21_identifies"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R21i_isIdentifiedBy"></see>
    /// </summary>
    let R21i_isIdentifiedBy = _prefix "R21i_isIdentifiedBy"
    /// <summary>
    /// Links an INT4 Feature to an INT3 Interrelation it provides the similarity for, the similarity being necessary for the detection of the INT3 Interrelation. States that an INT3 Interrelation is based on a similarity, i.e. the actualization of the same INT4 Feature in two different texts/images.
    /// <see href="https://w3id.org/lso/intro/beta202408#R22_providesSimilarityForRelation"></see></summary>
    let R22_providesSimilarityForRelation = _prefix "R22_providesSimilarityForRelation"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R22i_relationIsBasedOnSimilarity"></see>
    /// </summary>
    let R22i_relationIsBasedOnSimilarity = _prefix "R22i_relationIsBasedOnSimilarity"
    /// <summary>
    /// Relates a source (a text on any ontological level or an actualization of a feature on said source) to the outcome of a receptional or interpretative act (an INT2 Actualization of Feature, an INT4 Feature like an INT Interpretation, an INT3 Interrelation) to support it.
    /// <see href="https://w3id.org/lso/intro/beta202408#R23_providesSupportFor"></see></summary>
    let R23_providesSupportFor = _prefix "R23_providesSupportFor"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R23i_supportProvidedBy"></see>
    /// </summary>
    let R23i_supportProvidedBy = _prefix "R23i_supportProvidedBy"
    /// <summary>
    /// Links a F3 Manifestation to an INT16 Segment it contains (the segment in turn R16 incorporates an INT1 Passage or an F2 Expression).
    /// <see href="https://w3id.org/lso/intro/beta202408#R25_hasSegment"></see></summary>
    let R25_hasSegment = _prefix "R25_hasSegment"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R25i_isSegmentOf"></see>
    /// </summary>
    let R25i_isSegmentOf = _prefix "R25i_isSegmentOf"
    /// <summary>
    /// Links (usually, exceptions are easily conceivable) a text, like a work or an expression, to an INT21 Text Passage from that text, e.g. a book to a passage on page three of this book.
    /// <see href="https://w3id.org/lso/intro/beta202408#R30_hasTextPassage"></see></summary>
    let R30_hasTextPassage = _prefix "R30_hasTextPassage"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R30i_isTextPassageOf"></see>
    /// </summary>
    let R30i_isTextPassageOf = _prefix "R30i_isTextPassageOf"
    /// <summary>
    /// Links (usually, eceptions are easily conceivable) an image, like a work or an expression, to an INT22 Image Area from that image, e.g. a painting to an area on this paining.
    /// <see href="https://w3id.org/lso/intro/beta202408#R31_hasImageArea"></see></summary>
    let R31_hasImageArea = _prefix "R31_hasImageArea"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R31i_isImageAreaOf"></see>
    /// </summary>
    let R31i_isImageAreaOf = _prefix "R31i_isImageAreaOf"
    /// <summary>
    /// Links an INT Constellation to the elements (INT2 Actualizations of Feature) that together form that INT Constellation.
    /// <see href="https://w3id.org/lso/intro/beta202408#R3_constellates"></see></summary>
    let R3_constellates = _prefix "R3_constellates"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R3i_isConstellatedBy"></see>
    /// </summary>
    let R3i_isConstellatedBy = _prefix "R3i_isConstellatedBy"
    /// <summary>
    /// Links a text or image (work, expression, ...) to its bibliographical data, represented as a data string. (A shortcut for the actual modelling of bibliographical data.)
    /// <see href="https://w3id.org/lso/intro/beta202408#R40_hasBibliographicalData"></see></summary>
    let R40_hasBibliographicalData = _prefix "R40_hasBibliographicalData"
    /// <summary>
    /// Defines the location of an INT16 Segment in e.g. a F3 Manifestation, e.g. by giving page or paragraph numbers. Can be replaced by oa:hasSelector to specify the location utilizing the multiple options provided by the Web Annotation Ontology
    /// 			(https://www.w3.org/TR/annotation-vocab/#web-annotation-ontology).
    /// <see href="https://w3id.org/lso/intro/beta202408#R41_hasLocation"></see></summary>
    let R41_hasLocation = _prefix "R41_hasLocation"
    /// <summary>
    /// Links pretty much everything to a data string providing a definition for it. (A shortcut for modelling the definition as an INT2 Actualization of Feature.)
    /// <see href="https://w3id.org/lso/intro/beta202408#R42_hasParaphraseOrDefinition"></see></summary>
    let R42_hasParaphraseOrDefinition = _prefix "R42_hasParaphraseOrDefinition"
    /// <summary>
    /// Links a feature to a data string defining or describing it more closely.
    /// <see href="https://w3id.org/lso/intro/beta202408#R43_hasSpecification"></see></summary>
    let R43_hasSpecification = _prefix "R43_hasSpecification"
    /// <summary>
    /// Links an INT21 Text Passage or an INT16 Segment to a data string providing its exact wording.
    /// <see href="https://w3id.org/lso/intro/beta202408#R44_hasWording"></see></summary>
    let R44_hasWording = _prefix "R44_hasWording"
    /// <summary>
    /// Relates an actualization (usually: of the semantic feature 'INT Definition') to an INT11 Type of Interrelation, to INT4 Features, or to INT6 Architexts and thereby links e.g. a feature of text passage – e.g. a definition in Foucault's writings – to a concept - e.g. 'discourse'.
    /// <see href="https://w3id.org/lso/intro/beta202408#R4_defines"></see></summary>
    let R4_defines = _prefix "R4_defines"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R4i_isDefinedIn"></see>
    /// </summary>
    let R4i_isDefinedIn = _prefix "R4i_isDefinedIn"
    /// <summary>
    /// Links an INT Opinion to its object - for example an opinion with the theme fashion (to make it an opinion about fashion).
    /// <see href="https://w3id.org/lso/intro/beta202408#R8_hasOpinionObject"></see></summary>
    let R8_hasOpinionObject = _prefix "R8_hasOpinionObject"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R8i_isOpinionObjectOf"></see>
    /// </summary>
    let R8i_isOpinionObjectOf = _prefix "R8i_isOpinionObjectOf"
    /// <summary>
    /// Links an INT2 Actualization of Feature to another INT4 following it (logically or chronologically); this object property was mostly designed for the representation of the structure of research papers, where one definition, interpretation, etc., follows another.
    /// <see href="https://w3id.org/lso/intro/beta202408#R9_hasSubsequentActualization"></see></summary>
    let R9_hasSubsequentActualization = _prefix "R9_hasSubsequentActualization"
    /// <summary>
    ///   <see href="https://w3id.org/lso/intro/beta202408#R9i_hasPrecedingActualization"></see>
    /// </summary>
    let R9i_hasPrecedingActualization = _prefix "R9i_hasPrecedingActualization"
