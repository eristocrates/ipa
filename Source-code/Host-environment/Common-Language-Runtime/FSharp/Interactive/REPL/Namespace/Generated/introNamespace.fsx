#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module intro =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/lso/intro/beta202408#" "intro"

    /// <summary>
    ///   <para>rdfs:label : INT10 Formal Feature</para>
    ///   <para>rdfs:comment : This class comprises subclasses for every formal aspect of a text or image. It is divided into the subclasses INT Part and INT Composition, the former containing elements possibly structured according to the latter. Instances or subclasses of these two classes are likely also instances / subclasses of other subclasses of INT4 Feature: An INT Part can at the same time be an INT Object (formal and semantic) or an INT Dramatic Entity (formal and rhetorical); questions of perspective and vanishing point can be considered in a formal as well as a rhetorical respect. As a consequence of the ontology's origin, INT Part is currently dominated by literary terms which makes the addition of custom subclasses for pictorial features necessary.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT10_FormalFeature">intro:INT10_FormalFeature</a>
    /// </summary>
    let INT10_FormalFeature = _prefixId.prefix "INT10_FormalFeature"
    /// <summary>
    ///   <para>rdfs:label : INT11 Type of Interrelation</para>
    ///   <para>rdfs:comment : This class comprises (as subclasses) the many classifications of interrelations between instances of texts of images (on any ontological level) that are identified, for example, in research literature, but also in greek rhetoric, in genre theory and so on.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT11_TypeOfInterrelation">intro:INT11_TypeOfInterrelation</a>
    /// </summary>
    let INT11_TypeOfInterrelation = _prefixId.prefix "INT11_TypeOfInterrelation"

    /// <summary>
    ///   <para>rdfs:label : INT12 Common Interrelation Types</para>
    ///   <para>rdfs:comment : This class comprises common concepts of interrelations such as 'citation', 'plagiarism', 'allusion' and so on; no further definition is necessary.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT12_CommonInterrelationTypes">intro:INT12_CommonInterrelationTypes</a>
    /// </summary>
    let INT12_CommonInterrelationTypes =
        _prefixId.prefix "INT12_CommonInterrelationTypes"

    /// <summary>
    ///   <para>rdfs:label : INT13 Interrelation in Genre Theory</para>
    ///   <para>rdfs:comment : This class comprises types of interrelations that are defined or applied in genre theory.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT13_InterrelationInGenreTheory">intro:INT13_InterrelationInGenreTheory</a>
    /// </summary>
    let INT13_InterrelationInGenreTheory =
        _prefixId.prefix "INT13_InterrelationInGenreTheory"

    /// <summary>
    ///   <para>rdfs:label : INT14 Interrelation in Rhetoric</para>
    ///   <para>rdfs:comment : This class comprises interrelations (likely: mostly intertextual relations) that are defined in works on rhetoric.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT14_InterrelationInRhetoric">intro:INT14_InterrelationInRhetoric</a>
    /// </summary>
    let INT14_InterrelationInRhetoric = _prefixId.prefix "INT14_InterrelationInRhetoric"

    /// <summary>
    ///   <para>rdfs:label : INT15 Intertextuality in Intertextuality Theories</para>
    ///   <para>rdfs:comment : This class comprises intertextual relationships that are defined or applied in research literature dedicated to intertextuality theory.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT15_IntertextualityInIntTheories">intro:INT15_IntertextualityInIntTheories</a>
    /// </summary>
    let INT15_IntertextualityInIntTheories =
        _prefixId.prefix "INT15_IntertextualityInIntTheories"

    /// <summary>
    ///   <para>rdfs:label : INT16 Segment</para>
    ///   <para>rdfs:comment : This class comprises expressions (e.g. texts represented as F2 Expressions) or parts thereof as they are represented in F3 Manifestations. INT16 Segments can be located inside the F3 Manifestation by means of page numbers etc. and are thus identifiable (and citable). They are not identical to/subclasses of F3 Manifestations, since they only make a part of it; they are not identical to F2 Expressions, since they have distinct metadata linking them to, e. g., a certain edition of a work. The INT16 Segment can be linked to an F2 Expression (resp. a E36 Visual Item) or an INT1 Passage through R16 incorporates. It can be linked to a physical carrier (like LRMs "F5_Item") through P128 is carried by.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT16_Segment">intro:INT16_Segment</a>
    /// </summary>
    let INT16_Segment = _prefixId.prefix "INT16_Segment"
    /// <summary>
    ///   <para>rdfs:label : INT17 Functional Relation</para>
    ///   <para>rdfs:comment : This class comprises types of interrelations between a text or an image on any ontological level and an architext that have merely classificatory or typological function, including a text/an image being a part of an architext (an epoch, a movement etc.), its initial or final text/image, etc.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT17_FunctionalRelation">intro:INT17_FunctionalRelation</a>
    /// </summary>
    let INT17_FunctionalRelation = _prefixId.prefix "INT17_FunctionalRelation"
    /// <summary>
    ///   <para>rdfs:label : INT18 Reference</para>
    ///   <para>rdfs:comment : This class comprises references to – usually: real – identifiable objects of any kind. It is not restricted to non-fictional texts resp. images depicting real life objects or events, but can be most easily applied there. The CIDOC CRM property P67 refers to is recommended to establish the link to the entity referred to. However, there are two options: P67 can link this INT18 Reference (or any other feature) to the external entity, but it can also link the corresponding actualization of said feature to the external entity. This depends on the respective theoretical framework and is not specified in the context of this ontology.
    /// 			(The scope of this class also includes references to other images/texts, if one wants to model an interrelation this way.)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT18_Reference">intro:INT18_Reference</a>
    /// </summary>
    let INT18_Reference = _prefixId.prefix "INT18_Reference"
    /// <summary>
    ///   <para>rdfs:label : INT1 Passage</para>
    ///   <para>rdfs:comment : The INT1 Passage is a means of modelling an identifiable part of an E73 Information Object or its subclasses – without that part being removed from its source Information Object.
    /// 			For examples, see subclass comments.
    /// 			The skos:broadMatch states that the INT1 Passage can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT1 Passage's location.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT1_Passage">intro:INT1_Passage</a>
    /// </summary>
    let INT1_Passage = _prefixId.prefix "INT1_Passage"
    /// <summary>
    ///   <para>rdfs:label : INT21 Text Passage</para>
    ///   <para>rdfs:comment : The INT21 TextPassage is a means of modelling an identifiable part of an E73 Information Object or its subclasses – without that part being removed from its source Information Object.
    /// 			Examples:
    /// 			- The words 'Abandon all hope ye who enter here' from Canto III of Dante's Inferno.
    /// 			- The first four lines of Rilke's poem "Archaischer Torso Apollos"
    /// 			- The last item on a shopping list.
    /// 			The skos:broadMatch states that the INT21 TextPassage can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT21 TextPassage's location.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT21_TextPassage">intro:INT21_TextPassage</a>
    /// </summary>
    let INT21_TextPassage = _prefixId.prefix "INT21_TextPassage"
    /// <summary>
    ///   <para>rdfs:label : INT22 Image Area</para>
    ///   <para>rdfs:comment : The INT22 ImageArea is a means of modelling an identifiable part of an image (itself modelled as an E73 Information Object or one of its subclasses) – without that part being removed from its source Information Object.
    /// 			Examples:
    /// 			- The part of Leonardo's Mona Lisa showing Mona Lisa's smile.
    /// 			- The bottom 3/5 of Rothko's Painting "Orange And Yellow" (1956), dominated by the fuzzy orange rectangle.
    /// 			- The part of the "Smiley Face" originally invented by Harvey Ball that shows the Smiley's left eye.
    /// 			- The part of Piranesi's The Drawbridge, 2nd version, showing a drawbridge.
    ///
    /// 			The skos:broadMatch states that the INT22 ImageArea can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT22 ImageArea's location.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT22_ImageArea">intro:INT22_ImageArea</a>
    /// </summary>
    let INT22_ImageArea = _prefixId.prefix "INT22_ImageArea"
    /// <summary>
    ///   <para>rdfs:label : INT23 Visual Feature</para>
    ///   <para>rdfs:comment : This class contains visual features of images - but possibly also of texts. Its subclasses are rudimentary, it is very likely that instances of other INT4 Feature subclasses can be classified as visual features at the same time. This might be the case for, e.g., INT Composition (although for these instances classification as an INT26 Shape should also be considered).</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT23_VisualFeature">intro:INT23_VisualFeature</a>
    /// </summary>
    let INT23_VisualFeature = _prefixId.prefix "INT23_VisualFeature"
    /// <summary>
    ///   <para>rdfs:label : INT24 Textual Feature</para>
    ///   <para>rdfs:comment : This class contains textual features, usually found on texts - but possibly also on images. It is very likely that instances of other INT4 Feature subclasses can be classified as textual features at the same time.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT24_TextualFeature">intro:INT24_TextualFeature</a>
    /// </summary>
    let INT24_TextualFeature = _prefixId.prefix "INT24_TextualFeature"
    /// <summary>
    ///   <para>rdfs:label : INT25 Color</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT25_Color">intro:INT25_Color</a>
    /// </summary>
    let INT25_Color = _prefixId.prefix "INT25_Color"
    /// <summary>
    ///   <para>rdfs:label : INT26 Shape</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT26_Shape">intro:INT26_Shape</a>
    /// </summary>
    let INT26_Shape = _prefixId.prefix "INT26_Shape"
    /// <summary>
    ///   <para>rdfs:label : INT27 Texture</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT27_Texture">intro:INT27_Texture</a>
    /// </summary>
    let INT27_Texture = _prefixId.prefix "INT27_Texture"
    /// <summary>
    ///   <para>rdfs:label : INT28 Ratio</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT28_Ratio">intro:INT28_Ratio</a>
    /// </summary>
    let INT28_Ratio = _prefixId.prefix "INT28_Ratio"
    /// <summary>
    ///   <para>rdfs:label : INT2 Actualization of Feature</para>
    ///   <para>rdfs:comment : The fact that a text or an image shows - in its own specific way - a certain feature (which itself is an abstract concept and takes form in many texts/images), e.g. a motif, an atmosphere, a theme, a figure of speech.
    /// 			Examples:
    /// 			- the specific actualization of the motif of patricide in Sophokles' 'Ödipus Rex'.
    /// 			- the specific actualization of the Faust-subject in Goethe's 'Faust'.
    /// 			- the specific actualization of the iambic pentameter in Rilke's 'Archaischer Torso Apollos".
    /// 			- the specific actualization of the Ophelia-character in John Everett Millais' painting "Ophelia" (1852).
    /// 		</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT2_ActualizationOfFeature">intro:INT2_ActualizationOfFeature</a>
    /// </summary>
    let INT2_ActualizationOfFeature = _prefixId.prefix "INT2_ActualizationOfFeature"
    /// <summary>
    ///   <para>rdfs:label : INT31 Intertextual Relation</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT31_IntertextualRelation">intro:INT31_IntertextualRelation</a>
    /// </summary>
    let INT31_IntertextualRelation = _prefixId.prefix "INT31_IntertextualRelation"
    /// <summary>
    ///   <para>rdfs:label : INT32 Interpictorial Relation</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT32_InterpictorialRelation">intro:INT32_InterpictorialRelation</a>
    /// </summary>
    let INT32_InterpictorialRelation = _prefixId.prefix "INT32_InterpictorialRelation"
    /// <summary>
    ///   <para>rdfs:label : INT33 Intermedial Relation</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT33_IntermedialRelation">intro:INT33_IntermedialRelation</a>
    /// </summary>
    let INT33_IntermedialRelation = _prefixId.prefix "INT33_IntermedialRelation"

    /// <summary>
    ///   <para>rdfs:label : INT34 Intermediality in Intermediality Theories</para>
    ///   <para>rdfs:comment : This class comprises intermedial relations that can be found in research literature dedicated to intermediality theory.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT34_IntermedialityInIntermedialityTheories">intro:INT34_IntermedialityInIntermedialityTheories</a>
    /// </summary>
    let INT34_IntermedialityInIntermedialityTheories =
        _prefixId.prefix "INT34_IntermedialityInIntermedialityTheories"

    /// <summary>
    ///   <para>rdfs:label : INT35 Interpictoriality in Interpictoriality Theories</para>
    ///   <para>rdfs:comment : This class comprises interpictorial relations that can be found in research literature dedicated to interpictoriality theory.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT35_InterpictorialityInInterpictorialityTheories">intro:INT35_InterpictorialityInInterpictorialityTheories</a>
    /// </summary>
    let INT35_InterpictorialityInInterpictorialityTheories =
        _prefixId.prefix "INT35_InterpictorialityInInterpictorialityTheories"

    /// <summary>
    ///   <para>rdfs:label : INT3 Interrelation</para>
    ///   <para>rdfs:comment : This class comprises the abstract notion of a relationship between texts and/or images resp. their parts as it is identified by a recipient (which is not the same as the rhetorical entity 'quotation'). Every INT3 Interrelation has at least 2 related entities, which are texts/images (on any ontological level) or INT2 Actualizations of Features. An INT3 Interrelation is possibly identified in an INT Interpretation and further defined by an INT11 TypeOfInterrelation.
    /// 			The skos:broadMatch to oa:Annotation indicates that stating the existence of an intertextual relation can be seen as a kind of annotation made to resources, in this case: at least two, the related entities (texts and/or images).</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT3_Interrelation">intro:INT3_Interrelation</a>
    /// </summary>
    let INT3_Interrelation = _prefixId.prefix "INT3_Interrelation"
    /// <summary>
    ///   <para>rdfs:label : INT4 Feature</para>
    ///   <para>rdfs:comment : This class comprises features that 'are in' or 'can be found in' or 'can be read out of' a text or an image. INT2 Actualizations of these features are the results of a receptive process that identifies the specific form the INT4 Feature – a distinct abstract concept, itself separate from the text or image – takes in the text or image. This class therefore has a wide scope. Its domain could be divided into subclasses following any number of different ratios; to avoid the resulting restrictions and/or complex hierarchies, the actual subclasses of the INT4 Feature represent diverse approaches to its subject matter, covering medial aspects as well as aspect of form and semantics. They can be populated resp. extended with custom subclasses based e.g. on relevant reference works: The class INT8 Rhetorical Feature could contain concepts based on classical rhetoric like allegory or personification, but would of course also include the pictorial pendants of these tropes. Lemmata from handbooks of poetic terms as well as concepts of pictorial composition could populate the INT10 Formal Feature resp. its (sub-)subclasses. Subclasses of INT9 Semantic Feature could be extended using art thesauri as well as handbooks on literary motives.
    /// 			For external thesauri and vocabularies see, e. g., ICONCLASS, the Getty Art and Architecture Thesaurus, the Getty Cultural Objects Name Authority, the Getty Union List of Artist Names, the Literary Theme Ontology (LTO), the Document Components Ontology, the OntoPoetry Ontology, the Taxonomy of Themes and Motifs (TTM2) ...</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT4_Feature">intro:INT4_Feature</a>
    /// </summary>
    let INT4_Feature = _prefixId.prefix "INT4_Feature"
    /// <summary>
    ///   <para>rdfs:label : INT6 Architext</para>
    ///   <para>rdfs:comment : An INT6 Architextual Entity consists in a number of texts/images which in some way give reason to see them as connected, related, sharing a common feature.
    /// 			Examples for INT6 Architextual Entities can be
    /// 			- discourses (members sharing a discoursive element, a topic etc.)
    /// 			- genres (members sharing genre conventions)
    /// 			- a discipline (members deriving from the same disciplinary background)
    /// 			- an oeuvre (members created by the same person)
    /// 			- national literatures/arts (members whose creators share a nationality) etc.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT6_Architext">intro:INT6_Architext</a>
    /// </summary>
    let INT6_Architext = _prefixId.prefix "INT6_Architext"
    /// <summary>
    ///   <para>rdfs:label : INT8 Rhetorical Feature</para>
    ///   <para>rdfs:comment : This class comprises every aspect of a text or an image that can be described in terms of rhetorics - ranging from the occurrence of rhetorical tropes to parts of an e.g. research paper like 'introduction' or 'quotation' (pragmatic entities) to aspects of the narrative act such as 'voice' or 'narrating time' (narratological entities). Questions of composition in visual arts can often also be classified as a rhetorical feature.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT8_RhetoricalFeature">intro:INT8_RhetoricalFeature</a>
    /// </summary>
    let INT8_RhetoricalFeature = _prefixId.prefix "INT8_RhetoricalFeature"
    /// <summary>
    ///   <para>rdfs:label : INT9 Semantic Feature</para>
    ///   <para>rdfs:comment : This class comprises every semantic aspect of a text or image, like the common notions of 'plot', 'sujet', or 'character'. While most subclasses are still object to refinement and addition – to indicate their provisional status they are not yet numbered in this version of INTRO –, INT18 Reference has been numbered to indicate its consolidated status.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT9_SemanticFeature">intro:INT9_SemanticFeature</a>
    /// </summary>
    let INT9_SemanticFeature = _prefixId.prefix "INT9_SemanticFeature"
    /// <summary>
    ///   <para>rdfs:label : INT Act (Drama)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Act">intro:INT_Act</a>
    /// </summary>
    let INT_Act = _prefixId.prefix "INT_Act"
    /// <summary>
    ///   <para>rdfs:label : INT Atmosphere</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Atmosphere">intro:INT_Atmosphere</a>
    /// </summary>
    let INT_Atmosphere = _prefixId.prefix "INT_Atmosphere"
    /// <summary>
    ///   <para>rdfs:label : INT Chapter (Prose)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Chapter">intro:INT_Chapter</a>
    /// </summary>
    let INT_Chapter = _prefixId.prefix "INT_Chapter"
    /// <summary>
    ///   <para>rdfs:label : INT Character</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Character">intro:INT_Character</a>
    /// </summary>
    let INT_Character = _prefixId.prefix "INT_Character"
    /// <summary>
    ///   <para>rdfs:label : INT Composition</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Composition">intro:INT_Composition</a>
    /// </summary>
    let INT_Composition = _prefixId.prefix "INT_Composition"
    /// <summary>
    ///   <para>rdfs:label : INT Constellation</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Constellation">intro:INT_Constellation</a>
    /// </summary>
    let INT_Constellation = _prefixId.prefix "INT_Constellation"
    /// <summary>
    ///   <para>rdfs:label : INT Definition</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Definition">intro:INT_Definition</a>
    /// </summary>
    let INT_Definition = _prefixId.prefix "INT_Definition"
    /// <summary>
    ///   <para>rdfs:label : INT Description</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Description">intro:INT_Description</a>
    /// </summary>
    let INT_Description = _prefixId.prefix "INT_Description"
    /// <summary>
    ///   <para>rdfs:label : INT Discipline</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Discipline">intro:INT_Discipline</a>
    /// </summary>
    let INT_Discipline = _prefixId.prefix "INT_Discipline"
    /// <summary>
    ///   <para>rdfs:label : INT Discourse</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Discourse">intro:INT_Discourse</a>
    /// </summary>
    let INT_Discourse = _prefixId.prefix "INT_Discourse"
    /// <summary>
    ///   <para>rdfs:label : INT Dramatic Entity</para>
    ///   <para>rdfs:comment : This class comprises concepts from drama theory.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_DramaticEntity">intro:INT_DramaticEntity</a>
    /// </summary>
    let INT_DramaticEntity = _prefixId.prefix "INT_DramaticEntity"
    /// <summary>
    ///   <para>rdfs:label : INT Epoch</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Epoch">intro:INT_Epoch</a>
    /// </summary>
    let INT_Epoch = _prefixId.prefix "INT_Epoch"
    /// <summary>
    ///   <para>rdfs:label : INT Event</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Event">intro:INT_Event</a>
    /// </summary>
    let INT_Event = _prefixId.prefix "INT_Event"
    /// <summary>
    ///   <para>rdfs:label : INT Figurative Feature</para>
    ///   <para>rdfs:comment : The class comprises figures of speech. Since there are countless classification systems (the most common dividing figures into tropoi - metaphor, metonymy ... - and schemata/figurae, further dividing the latter into figures of thougth and figures of word, further dividing the latter into grammatical and rhetorical figures of word), no subclasses will be provided.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_FigurativeFeature">intro:INT_FigurativeFeature</a>
    /// </summary>
    let INT_FigurativeFeature = _prefixId.prefix "INT_FigurativeFeature"
    /// <summary>
    ///   <para>rdfs:label : INT Figurative Meaning</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_FigurativeMeaning">intro:INT_FigurativeMeaning</a>
    /// </summary>
    let INT_FigurativeMeaning = _prefixId.prefix "INT_FigurativeMeaning"
    /// <summary>
    ///   <para>rdfs:label : INT Genre</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Genre">intro:INT_Genre</a>
    /// </summary>
    let INT_Genre = _prefixId.prefix "INT_Genre"
    /// <summary>
    ///   <para>rdfs:label : INT Genre Specifics</para>
    ///   <para>rdfs:comment : INT Genre Specifics comprises all features that are used to assign a certain genre - whether textual or visual -, are typical of such a genre, or occur frequently in it. Instances might often be also instances of the other subclasses of INT4 Feature. INT Genre Specifics' two subclasses – INT Visual Genre Specifics and INT Textual Genre Specifics – do not imply that each feature must be either–or, in some cases features will be assignable to both classes.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_GenreSpecifics">intro:INT_GenreSpecifics</a>
    /// </summary>
    let INT_GenreSpecifics = _prefixId.prefix "INT_GenreSpecifics"
    /// <summary>
    ///   <para>rdfs:label : INT Identification</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Identification">intro:INT_Identification</a>
    /// </summary>
    let INT_Identification = _prefixId.prefix "INT_Identification"
    /// <summary>
    ///   <para>rdfs:label : INT Individual Character</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_IndividualCharacter">intro:INT_IndividualCharacter</a>
    /// </summary>
    let INT_IndividualCharacter = _prefixId.prefix "INT_IndividualCharacter"
    /// <summary>
    ///   <para>rdfs:label : INT Individual Object</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_IndividualObject">intro:INT_IndividualObject</a>
    /// </summary>
    let INT_IndividualObject = _prefixId.prefix "INT_IndividualObject"
    /// <summary>
    ///   <para>rdfs:label : INT Individual Place</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_IndividualPlace">intro:INT_IndividualPlace</a>
    /// </summary>
    let INT_IndividualPlace = _prefixId.prefix "INT_IndividualPlace"
    /// <summary>
    ///   <para>rdfs:label : INT Interpretation</para>
    ///   <para>rdfs:comment : The result of a interpretative act, possibly: as perceived in research literature. An interpretation can identify references or actualizations or the like. A number of interpretations can together recreate the structure of, e.g., a research paper. Accordingly, apart from linking INT Interpretations to the subjects of the interpretation, like intertextual relations or textual features, they can be linked to each other via R9 has subsequent feature resp. R9i has preceding feature.
    /// 			Examples:
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' features a detective character.
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' contains references to Arthur Conan Doyle's 'Sherlock Holmes'.
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' is set in the 14th century.
    /// 			- the conclusion that Umberto Eco's 'The Name of the Rose' belongs to the genre 'postmodern crime novel'.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Interpretation">intro:INT_Interpretation</a>
    /// </summary>
    let INT_Interpretation = _prefixId.prefix "INT_Interpretation"
    /// <summary>
    ///   <para>rdfs:label : INT Line (Poetry)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Line">intro:INT_Line</a>
    /// </summary>
    let INT_Line = _prefixId.prefix "INT_Line"
    /// <summary>
    ///   <para>rdfs:label : INT Lyrical Entity</para>
    ///   <para>rdfs:comment : This class comprises rhetorical concepts from lyric theory.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_LyricalEntity">intro:INT_LyricalEntity</a>
    /// </summary>
    let INT_LyricalEntity = _prefixId.prefix "INT_LyricalEntity"
    /// <summary>
    ///   <para>rdfs:label : INT Mood</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Mood">intro:INT_Mood</a>
    /// </summary>
    let INT_Mood = _prefixId.prefix "INT_Mood"
    /// <summary>
    ///   <para>rdfs:label : INT Motif</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Motif">intro:INT_Motif</a>
    /// </summary>
    let INT_Motif = _prefixId.prefix "INT_Motif"
    /// <summary>
    ///   <para>rdfs:label : INT Movement</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Movement">intro:INT_Movement</a>
    /// </summary>
    let INT_Movement = _prefixId.prefix "INT_Movement"
    /// <summary>
    ///   <para>rdfs:label : INT Narratological Entity</para>
    ///   <para>rdfs:comment : This class comprises narratological concepts insofar as they correlate with rhetorical concepts (like 'speech', 'distance', 'perspective' etc.). Due to the plurality of narratological frameworks, no subclasses will be provided at this point.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_NarratologicalEntity">intro:INT_NarratologicalEntity</a>
    /// </summary>
    let INT_NarratologicalEntity = _prefixId.prefix "INT_NarratologicalEntity"
    /// <summary>
    ///   <para>rdfs:label : INT Object</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Object">intro:INT_Object</a>
    /// </summary>
    let INT_Object = _prefixId.prefix "INT_Object"
    /// <summary>
    ///   <para>rdfs:label : INT Oeuvre</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Oeuvre">intro:INT_Oeuvre</a>
    /// </summary>
    let INT_Oeuvre = _prefixId.prefix "INT_Oeuvre"
    /// <summary>
    ///   <para>rdfs:label : INT Opinion</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Opinion">intro:INT_Opinion</a>
    /// </summary>
    let INT_Opinion = _prefixId.prefix "INT_Opinion"
    /// <summary>
    ///   <para>rdfs:label : INT Paragraph (Prose)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Paragraph">intro:INT_Paragraph</a>
    /// </summary>
    let INT_Paragraph = _prefixId.prefix "INT_Paragraph"
    /// <summary>
    ///   <para>rdfs:label : INT Part</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Part">intro:INT_Part</a>
    /// </summary>
    let INT_Part = _prefixId.prefix "INT_Part"
    /// <summary>
    ///   <para>rdfs:label : INT Place</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Place">intro:INT_Place</a>
    /// </summary>
    let INT_Place = _prefixId.prefix "INT_Place"
    /// <summary>
    ///   <para>rdfs:label : INT Plot</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Plot">intro:INT_Plot</a>
    /// </summary>
    let INT_Plot = _prefixId.prefix "INT_Plot"
    /// <summary>
    ///   <para>rdfs:label : INT Pragmatic Feature</para>
    ///   <para>rdfs:comment : The class includes all features that can be attributed to a text or image with regard to the role that these works play in a plot, for example in a social, political or religious context. These characteristics take account of the fact that the works in question pursue a specific purpose that goes beyond content and form and that is apparent 'on the surface‘ or by application of certain conventions or handed-down standards. While INTRO-subclasses of this class are limited to those close to the functionality of INTRO and which are to be applied to the relation between primary and secondary (textual) sources, subclasses can of course also include concepts from visual art. A pragmatic feature of a painting might be a donor portrait expressing gratitude, the portrait of a ruler serving propaganda purposes, a bible scene serving as guide for pious action. Pragmatic features of texts include bibliographic references, acknowledgments, and the like.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_PragmaticFeature">intro:INT_PragmaticFeature</a>
    /// </summary>
    let INT_PragmaticFeature = _prefixId.prefix "INT_PragmaticFeature"
    /// <summary>
    ///   <para>rdfs:label : INT Scene (Drama)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Scene">intro:INT_Scene</a>
    /// </summary>
    let INT_Scene = _prefixId.prefix "INT_Scene"
    /// <summary>
    ///   <para>rdfs:label : INT School</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_School">intro:INT_School</a>
    /// </summary>
    let INT_School = _prefixId.prefix "INT_School"
    /// <summary>
    ///   <para>rdfs:label : INT Situation</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Situation">intro:INT_Situation</a>
    /// </summary>
    let INT_Situation = _prefixId.prefix "INT_Situation"
    /// <summary>
    ///   <para>rdfs:label : INT Geographically Defined Architext</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_SpaciallyDefinedArchitext">intro:INT_SpaciallyDefinedArchitext</a>
    /// </summary>
    let INT_SpaciallyDefinedArchitext = _prefixId.prefix "INT_SpaciallyDefinedArchitext"
    /// <summary>
    ///   <para>rdfs:label : INT State</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_State">intro:INT_State</a>
    /// </summary>
    let INT_State = _prefixId.prefix "INT_State"
    /// <summary>
    ///   <para>rdfs:label : INT Subject</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Subject">intro:INT_Subject</a>
    /// </summary>
    let INT_Subject = _prefixId.prefix "INT_Subject"
    /// <summary>
    ///   <para>rdfs:label : INT Subtext</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Subtext">intro:INT_Subtext</a>
    /// </summary>
    let INT_Subtext = _prefixId.prefix "INT_Subtext"
    /// <summary>
    ///   <para>rdfs:label : INT Tableau (Drama)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Tableau">intro:INT_Tableau</a>
    /// </summary>
    let INT_Tableau = _prefixId.prefix "INT_Tableau"

    /// <summary>
    ///   <para>rdfs:label : INT Temporally Defined Architext</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_TemporallyDefinedArchitext">intro:INT_TemporallyDefinedArchitext</a>
    /// </summary>
    let INT_TemporallyDefinedArchitext =
        _prefixId.prefix "INT_TemporallyDefinedArchitext"

    /// <summary>
    ///   <para>rdfs:label : INT Text Type</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_TextType">intro:INT_TextType</a>
    /// </summary>
    let INT_TextType = _prefixId.prefix "INT_TextType"
    /// <summary>
    ///   <para>rdfs:label : INT Textual Genre Specifics</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_TextualGenreSpecifics">intro:INT_TextualGenreSpecifics</a>
    /// </summary>
    let INT_TextualGenreSpecifics = _prefixId.prefix "INT_TextualGenreSpecifics"
    /// <summary>
    ///   <para>rdfs:label : INT Theme</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Theme">intro:INT_Theme</a>
    /// </summary>
    let INT_Theme = _prefixId.prefix "INT_Theme"
    /// <summary>
    ///   <para>rdfs:label : INT Theory</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Theory">intro:INT_Theory</a>
    /// </summary>
    let INT_Theory = _prefixId.prefix "INT_Theory"
    /// <summary>
    ///   <para>rdfs:label : INT Timespan</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_TimeSpan">intro:INT_TimeSpan</a>
    /// </summary>
    let INT_TimeSpan = _prefixId.prefix "INT_TimeSpan"
    /// <summary>
    ///   <para>rdfs:label : INT Topic</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Topic">intro:INT_Topic</a>
    /// </summary>
    let INT_Topic = _prefixId.prefix "INT_Topic"
    /// <summary>
    ///   <para>rdfs:label : INT Topos</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Topos">intro:INT_Topos</a>
    /// </summary>
    let INT_Topos = _prefixId.prefix "INT_Topos"
    /// <summary>
    ///   <para>rdfs:label : INT Type of Character</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_TypeOfCharacter">intro:INT_TypeOfCharacter</a>
    /// </summary>
    let INT_TypeOfCharacter = _prefixId.prefix "INT_TypeOfCharacter"
    /// <summary>
    ///   <para>rdfs:label : INT Type of Place</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_TypeOfPlace">intro:INT_TypeOfPlace</a>
    /// </summary>
    let INT_TypeOfPlace = _prefixId.prefix "INT_TypeOfPlace"
    /// <summary>
    ///   <para>rdfs:label : INT Typical Object</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_TypicalObject">intro:INT_TypicalObject</a>
    /// </summary>
    let INT_TypicalObject = _prefixId.prefix "INT_TypicalObject"
    /// <summary>
    ///   <para>rdfs:label : INT Variety of Text</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_VarietyOfText">intro:INT_VarietyOfText</a>
    /// </summary>
    let INT_VarietyOfText = _prefixId.prefix "INT_VarietyOfText"
    /// <summary>
    ///   <para>rdfs:label : INT Verse (Poetry)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_Verse">intro:INT_Verse</a>
    /// </summary>
    let INT_Verse = _prefixId.prefix "INT_Verse"
    /// <summary>
    ///   <para>rdfs:label : INT Visual Genre Specifics</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#INT_VisualGenreSpecifics">intro:INT_VisualGenreSpecifics</a>
    /// </summary>
    let INT_VisualGenreSpecifics = _prefixId.prefix "INT_VisualGenreSpecifics"
    /// <summary>
    ///   <para>rdfs:label : R10 has passage</para>
    ///   <para>rdfs:comment : Links a text or an image – usually: a work or an expression – to an INT1 Passage from that text or image, e.g. a book to a passage on page three of this book, or a painting to an area on this paining.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R10_hasPassage">intro:R10_hasPassage</a>
    /// </summary>
    let R10_hasPassage = _prefixId.prefix "R10_hasPassage"
    /// <summary>
    ///   <para>rdfs:label : R10i is passage of</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R10i_isPassageOf">intro:R10i_isPassageOf</a>
    /// </summary>
    let R10i_isPassageOf = _prefixId.prefix "R10i_isPassageOf"
    /// <summary>
    ///   <para>rdfs:label : R12 has referred to entity</para>
    ///   <para>rdfs:comment : Links an INT3 Interrelation to the entity referred to in the relationship (a text or image on any ontological level or a feature actualized in the text resp. image in question).</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R12_hasReferredToEntity">intro:R12_hasReferredToEntity</a>
    /// </summary>
    let R12_hasReferredToEntity = _prefixId.prefix "R12_hasReferredToEntity"
    /// <summary>
    ///   <para>rdfs:label : R12i is referred to entity</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R12i_isReferredToEntity">intro:R12i_isReferredToEntity</a>
    /// </summary>
    let R12i_isReferredToEntity = _prefixId.prefix "R12i_isReferredToEntity"
    /// <summary>
    ///   <para>rdfs:label : R13 has referring entity</para>
    ///   <para>rdfs:comment : Links an INT3 Interrelation to a referring entity (a text or image on any ontological level or a feature actualized in the text resp. image in question).</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R13_hasReferringEntity">intro:R13_hasReferringEntity</a>
    /// </summary>
    let R13_hasReferringEntity = _prefixId.prefix "R13_hasReferringEntity"
    /// <summary>
    ///   <para>rdfs:label : R13i is referring entity</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R13i_isReferringEntity">intro:R13i_isReferringEntity</a>
    /// </summary>
    let R13i_isReferringEntity = _prefixId.prefix "R13i_isReferringEntity"
    /// <summary>
    ///   <para>rdfs:label : R16 incorporates</para>
    ///   <para>rdfs:comment : Links an INT16 Segment to the text or image on any ontological level (passage, expression, work) it incorporates.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R16_incorporates">intro:R16_incorporates</a>
    /// </summary>
    let R16_incorporates = _prefixId.prefix "R16_incorporates"
    /// <summary>
    ///   <para>rdfs:label : R16i is incorporated in</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R16i_isIncorporatedIn">intro:R16i_isIncorporatedIn</a>
    /// </summary>
    let R16i_isIncorporatedIn = _prefixId.prefix "R16i_isIncorporatedIn"
    /// <summary>
    ///   <para>rdfs:label : R17 actualizes feature</para>
    ///   <para>rdfs:comment : Links the specific INT2 Actualization of Feature to the (abstract concept of the) feature it actualizes, an INT4 Feature.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R17_actualizesFeature">intro:R17_actualizesFeature</a>
    /// </summary>
    let R17_actualizesFeature = _prefixId.prefix "R17_actualizesFeature"
    /// <summary>
    ///   <para>rdfs:label : R17i feature actualized in</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R17i_featureActualizedIn">intro:R17i_featureActualizedIn</a>
    /// </summary>
    let R17i_featureActualizedIn = _prefixId.prefix "R17i_featureActualizedIn"
    /// <summary>
    ///   <para>rdfs:label : R18 shows actualization</para>
    ///   <para>rdfs:comment : Links a text or an image (on any ontological level) or an INT2 Actualization of Feature to an INT2 Actualization of Feature found on it. (Actualizations found on actualizations - this occurs in cases where, e.g., the actualization of the feature INT Individual Character can be read as the actualization of the feature INT Character Type or INT18 Reference.)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R18_showsActualization">intro:R18_showsActualization</a>
    /// </summary>
    let R18_showsActualization = _prefixId.prefix "R18_showsActualization"
    /// <summary>
    ///   <para>rdfs:label : R18i actualization found on</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R18i_actualizationFoundOn">intro:R18i_actualizationFoundOn</a>
    /// </summary>
    let R18i_actualizationFoundOn = _prefixId.prefix "R18i_actualizationFoundOn"
    /// <summary>
    ///   <para>rdfs:label : R19 has type</para>
    ///   <para>rdfs:comment : Links an INT3 Interrelation to its INT11 Type of Interrelation.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R19_hasType">intro:R19_hasType</a>
    /// </summary>
    let R19_hasType = _prefixId.prefix "R19_hasType"
    /// <summary>
    ///   <para>rdfs:label : R19i is type of</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R19i_isTypeOf">intro:R19i_isTypeOf</a>
    /// </summary>
    let R19i_isTypeOf = _prefixId.prefix "R19i_isTypeOf"
    /// <summary>
    ///   <para>rdfs:label : R20 discusses</para>
    ///   <para>rdfs:comment : Links an INT Interpretation to the instance of text or image (on any ontological level) it discusses.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R20_discusses">intro:R20_discusses</a>
    /// </summary>
    let R20_discusses = _prefixId.prefix "R20_discusses"
    /// <summary>
    ///   <para>rdfs:label : R20i is discussed in</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R20i_isDiscussedIn">intro:R20i_isDiscussedIn</a>
    /// </summary>
    let R20i_isDiscussedIn = _prefixId.prefix "R20i_isDiscussedIn"
    /// <summary>
    ///   <para>rdfs:label : R21 identifies</para>
    ///   <para>rdfs:comment : Links an INT Identification or INT Interpretation to the INT3 Interrelation or the INT2 Actualization of Feature it identifies.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R21_identifies">intro:R21_identifies</a>
    /// </summary>
    let R21_identifies = _prefixId.prefix "R21_identifies"
    /// <summary>
    ///   <para>rdfs:label : R21i is identified by</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R21i_isIdentifiedBy">intro:R21i_isIdentifiedBy</a>
    /// </summary>
    let R21i_isIdentifiedBy = _prefixId.prefix "R21i_isIdentifiedBy"

    /// <summary>
    ///   <para>rdfs:label : R22 provides similarity for relation</para>
    ///   <para>rdfs:comment : Links an INT4 Feature to an INT3 Interrelation it provides the similarity for, the similarity being necessary for the detection of the INT3 Interrelation. States that an INT3 Interrelation is based on a similarity, i.e. the actualization of the same INT4 Feature in two different texts/images.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R22_providesSimilarityForRelation">intro:R22_providesSimilarityForRelation</a>
    /// </summary>
    let R22_providesSimilarityForRelation =
        _prefixId.prefix "R22_providesSimilarityForRelation"

    /// <summary>
    ///   <para>rdfs:label : R22i relation is based on similarity</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R22i_relationIsBasedOnSimilarity">intro:R22i_relationIsBasedOnSimilarity</a>
    /// </summary>
    let R22i_relationIsBasedOnSimilarity =
        _prefixId.prefix "R22i_relationIsBasedOnSimilarity"

    /// <summary>
    ///   <para>rdfs:label : R23 provides support for</para>
    ///   <para>rdfs:comment : Relates a source (a text on any ontological level or an actualization of a feature on said source) to the outcome of a receptional or interpretative act (an INT2 Actualization of Feature, an INT4 Feature like an INT Interpretation, an INT3 Interrelation) to support it.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R23_providesSupportFor">intro:R23_providesSupportFor</a>
    /// </summary>
    let R23_providesSupportFor = _prefixId.prefix "R23_providesSupportFor"
    /// <summary>
    ///   <para>rdfs:label : R23i support provided by</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R23i_supportProvidedBy">intro:R23i_supportProvidedBy</a>
    /// </summary>
    let R23i_supportProvidedBy = _prefixId.prefix "R23i_supportProvidedBy"
    /// <summary>
    ///   <para>rdfs:label : R24 has related entity</para>
    ///   <para>rdfs:comment : Links any INT3 Interrelation to a text or image (on any ontological level) or INT2 Actualization of Feature that is part of the INT3 Interrelation. The skos:broadMatch states that this property is a more specific version of oa:hasTarget in the sense that the INT3 Interrelation can be seen as an annotation, the texts/images linked by this relationship as their targets.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R24_hasRelatedEntity">intro:R24_hasRelatedEntity</a>
    /// </summary>
    let R24_hasRelatedEntity = _prefixId.prefix "R24_hasRelatedEntity"
    /// <summary>
    ///   <para>rdfs:label : R24i is related entity</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R24i_isRelatedEntity">intro:R24i_isRelatedEntity</a>
    /// </summary>
    let R24i_isRelatedEntity = _prefixId.prefix "R24i_isRelatedEntity"
    /// <summary>
    ///   <para>rdfs:label : R25 has segment</para>
    ///   <para>rdfs:comment : Links a F3 Manifestation to an INT16 Segment it contains (the segment in turn R16 incorporates an INT1 Passage or an F2 Expression).</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R25_hasSegment">intro:R25_hasSegment</a>
    /// </summary>
    let R25_hasSegment = _prefixId.prefix "R25_hasSegment"
    /// <summary>
    ///   <para>rdfs:label : R25i is segment of</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R25i_isSegmentOf">intro:R25i_isSegmentOf</a>
    /// </summary>
    let R25i_isSegmentOf = _prefixId.prefix "R25i_isSegmentOf"
    /// <summary>
    ///   <para>rdfs:label : R30 has text passage</para>
    ///   <para>rdfs:comment : Links (usually, exceptions are easily conceivable) a text, like a work or an expression, to an INT21 Text Passage from that text, e.g. a book to a passage on page three of this book.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R30_hasTextPassage">intro:R30_hasTextPassage</a>
    /// </summary>
    let R30_hasTextPassage = _prefixId.prefix "R30_hasTextPassage"
    /// <summary>
    ///   <para>rdfs:label : R30i is text passage of</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R30i_isTextPassageOf">intro:R30i_isTextPassageOf</a>
    /// </summary>
    let R30i_isTextPassageOf = _prefixId.prefix "R30i_isTextPassageOf"
    /// <summary>
    ///   <para>rdfs:label : R31 has image area</para>
    ///   <para>rdfs:comment : Links (usually, eceptions are easily conceivable) an image, like a work or an expression, to an INT22 Image Area from that image, e.g. a painting to an area on this paining.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R31_hasImageArea">intro:R31_hasImageArea</a>
    /// </summary>
    let R31_hasImageArea = _prefixId.prefix "R31_hasImageArea"
    /// <summary>
    ///   <para>rdfs:label : R31i is image area of</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R31i_isImageAreaOf">intro:R31i_isImageAreaOf</a>
    /// </summary>
    let R31i_isImageAreaOf = _prefixId.prefix "R31i_isImageAreaOf"
    /// <summary>
    ///   <para>rdfs:label : R3 constellates</para>
    ///   <para>rdfs:comment : Links an INT Constellation to the elements (INT2 Actualizations of Feature) that together form that INT Constellation.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R3_constellates">intro:R3_constellates</a>
    /// </summary>
    let R3_constellates = _prefixId.prefix "R3_constellates"
    /// <summary>
    ///   <para>rdfs:label : R3i is constellated by</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R3i_isConstellatedBy">intro:R3i_isConstellatedBy</a>
    /// </summary>
    let R3i_isConstellatedBy = _prefixId.prefix "R3i_isConstellatedBy"
    /// <summary>
    ///   <para>rdfs:label : R40 has bibliographical data</para>
    ///   <para>rdfs:comment : Links a text or image (work, expression, ...) to its bibliographical data, represented as a data string. (A shortcut for the actual modelling of bibliographical data.)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R40_hasBibliographicalData">intro:R40_hasBibliographicalData</a>
    /// </summary>
    let R40_hasBibliographicalData = _prefixId.prefix "R40_hasBibliographicalData"
    /// <summary>
    ///   <para>rdfs:label : R41 has location</para>
    ///   <para>rdfs:comment : Defines the location of an INT16 Segment in e.g. a F3 Manifestation, e.g. by giving page or paragraph numbers. Can be replaced by oa:hasSelector to specify the location utilizing the multiple options provided by the Web Annotation Ontology
    /// 			(https://www.w3.org/TR/annotation-vocab/#web-annotation-ontology).</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R41_hasLocation">intro:R41_hasLocation</a>
    /// </summary>
    let R41_hasLocation = _prefixId.prefix "R41_hasLocation"
    /// <summary>
    ///   <para>rdfs:label : R42 has paraphrase or definition</para>
    ///   <para>rdfs:comment : Links pretty much everything to a data string providing a definition for it. (A shortcut for modelling the definition as an INT2 Actualization of Feature.)</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R42_hasParaphraseOrDefinition">intro:R42_hasParaphraseOrDefinition</a>
    /// </summary>
    let R42_hasParaphraseOrDefinition = _prefixId.prefix "R42_hasParaphraseOrDefinition"
    /// <summary>
    ///   <para>rdfs:label : R43 has specification</para>
    ///   <para>rdfs:comment : Links a feature to a data string defining or describing it more closely.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R43_hasSpecification">intro:R43_hasSpecification</a>
    /// </summary>
    let R43_hasSpecification = _prefixId.prefix "R43_hasSpecification"
    /// <summary>
    ///   <para>rdfs:label : R44 has wording</para>
    ///   <para>rdfs:comment : Links an INT21 Text Passage or an INT16 Segment to a data string providing its exact wording.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R44_hasWording">intro:R44_hasWording</a>
    /// </summary>
    let R44_hasWording = _prefixId.prefix "R44_hasWording"
    /// <summary>
    ///   <para>rdfs:label : R4 defines</para>
    ///   <para>rdfs:comment : Relates an actualization (usually: of the semantic feature 'INT Definition') to an INT11 Type of Interrelation, to INT4 Features, or to INT6 Architexts and thereby links e.g. a feature of text passage – e.g. a definition in Foucault's writings – to a concept - e.g. 'discourse'.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R4_defines">intro:R4_defines</a>
    /// </summary>
    let R4_defines = _prefixId.prefix "R4_defines"
    /// <summary>
    ///   <para>rdfs:label : R4i is defined in</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R4i_isDefinedIn">intro:R4i_isDefinedIn</a>
    /// </summary>
    let R4i_isDefinedIn = _prefixId.prefix "R4i_isDefinedIn"
    /// <summary>
    ///   <para>rdfs:label : R8 has opinion object</para>
    ///   <para>rdfs:comment : Links an INT Opinion to its object - for example an opinion with the theme fashion (to make it an opinion about fashion).</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R8_hasOpinionObject">intro:R8_hasOpinionObject</a>
    /// </summary>
    let R8_hasOpinionObject = _prefixId.prefix "R8_hasOpinionObject"
    /// <summary>
    ///   <para>rdfs:label : R8i is opinion object of</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R8i_isOpinionObjectOf">intro:R8i_isOpinionObjectOf</a>
    /// </summary>
    let R8i_isOpinionObjectOf = _prefixId.prefix "R8i_isOpinionObjectOf"
    /// <summary>
    ///   <para>rdfs:label : R9 has subsequent actualization</para>
    ///   <para>rdfs:comment : Links an INT2 Actualization of Feature to another INT4 following it (logically or chronologically); this object property was mostly designed for the representation of the structure of research papers, where one definition, interpretation, etc., follows another.</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R9_hasSubsequentActualization">intro:R9_hasSubsequentActualization</a>
    /// </summary>
    let R9_hasSubsequentActualization = _prefixId.prefix "R9_hasSubsequentActualization"
    /// <summary>
    ///   <para>rdfs:label : R9i has preceding actualization</para>
    ///   <a href="https://w3id.org/lso/intro/beta202408#R9i_hasPrecedingActualization">intro:R9i_hasPrecedingActualization</a>
    /// </summary>
    let R9i_hasPrecedingActualization = _prefixId.prefix "R9i_hasPrecedingActualization"
