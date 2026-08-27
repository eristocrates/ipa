namespace https.w3id.org.lso.intro.beta202408.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module intro =
    let _namespace_iri = Namespace_Iri intro |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT10_FormalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises subclasses for every formal aspect of a text or image. It is divided into the subclasses INT Part and INT Composition, the former containing elements possibly structured according to the latter. Instances or subclasses of these two classes are likely also instances / subclasses of other subclasses of INT4 Feature: An INT Part can at the same time be an INT Object (formal and semantic) or an INT Dramatic Entity (formal and rhetorical); questions of perspective and vanishing point can be considered in a formal as well as a rhetorical respect. As a consequence of the ontology's origin, INT Part is currently dominated by literary terms which makes the addition of custom subclasses for pictorial features necessary."</para>
    /// labels<para>"INT10 Formal Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT10_FormalFeature">https://w3id.org/lso/intro/beta202408#INT10_FormalFeature</seealso>
    let INT10_FormalFeature =
        Prefixed_Name(intro, "INT10_FormalFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT11_TypeOfInterrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises (as subclasses) the many classifications of interrelations between instances of texts of images (on any ontological level) that are identified, for example, in research literature, but also in greek rhetoric, in genre theory and so on."</para>
    /// labels<para>"INT11 Type of Interrelation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT11_TypeOfInterrelation">https://w3id.org/lso/intro/beta202408#INT11_TypeOfInterrelation</seealso>
    let INT11_TypeOfInterrelation =
        Prefixed_Name(intro, "INT11_TypeOfInterrelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT12_CommonInterrelationTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises common concepts of interrelations such as 'citation', 'plagiarism', 'allusion' and so on; no further definition is necessary."</para>
    /// labels<para>"INT12 Common Interrelation Types"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT12_CommonInterrelationTypes">https://w3id.org/lso/intro/beta202408#INT12_CommonInterrelationTypes</seealso>
    let INT12_CommonInterrelationTypes =
        Prefixed_Name(intro, "INT12_CommonInterrelationTypes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT13_InterrelationInGenreTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises types of interrelations that are defined or applied in genre theory."</para>
    /// labels<para>"INT13 Interrelation in Genre Theory"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT13_InterrelationInGenreTheory">https://w3id.org/lso/intro/beta202408#INT13_InterrelationInGenreTheory</seealso>
    let INT13_InterrelationInGenreTheory =
        Prefixed_Name(intro, "INT13_InterrelationInGenreTheory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT14_InterrelationInRhetoric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises interrelations (likely: mostly intertextual relations) that are defined in works on rhetoric."</para>
    /// labels<para>"INT14 Interrelation in Rhetoric"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT14_InterrelationInRhetoric">https://w3id.org/lso/intro/beta202408#INT14_InterrelationInRhetoric</seealso>
    let INT14_InterrelationInRhetoric =
        Prefixed_Name(intro, "INT14_InterrelationInRhetoric") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT15_IntertextualityInIntTheories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises intertextual relationships that are defined or applied in research literature dedicated to intertextuality theory."</para>
    /// labels<para>"INT15 Intertextuality in Intertextuality Theories"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT15_IntertextualityInIntTheories">https://w3id.org/lso/intro/beta202408#INT15_IntertextualityInIntTheories</seealso>
    let INT15_IntertextualityInIntTheories =
        Prefixed_Name(intro, "INT15_IntertextualityInIntTheories") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT16_Segment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises expressions (e.g. texts represented as F2 Expressions) or parts thereof as they are represented in F3 Manifestations. INT16 Segments can be located inside the F3 Manifestation by means of page numbers etc. and are thus identifiable (and citable). They are not identical to/subclasses of F3 Manifestations, since they only make a part of it; they are not identical to F2 Expressions, since they have distinct metadata linking them to, e. g., a certain edition of a work. The INT16 Segment can be linked to an F2 Expression (resp. a E36 Visual Item) or an INT1 Passage through R16 incorporates. It can be linked to a physical carrier (like LRMs "F5_Item") through P128 is carried by."</para>
    /// labels<para>"INT16 Segment"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT16_Segment">https://w3id.org/lso/intro/beta202408#INT16_Segment</seealso>
    let INT16_Segment = Prefixed_Name(intro, "INT16_Segment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT17_FunctionalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises types of interrelations between a text or an image on any ontological level and an architext that have merely classificatory or typological function, including a text/an image being a part of an architext (an epoch, a movement etc.), its initial or final text/image, etc."</para>
    /// labels<para>"INT17 Functional Relation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT17_FunctionalRelation">https://w3id.org/lso/intro/beta202408#INT17_FunctionalRelation</seealso>
    let INT17_FunctionalRelation =
        Prefixed_Name(intro, "INT17_FunctionalRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT18_Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises references to – usually: real – identifiable objects of any kind. It is not restricted to non-fictional texts resp. images depicting real life objects or events, but can be most easily applied there. The CIDOC CRM property P67 refers to is recommended to establish the link to the entity referred to. However, there are two options: P67 can link this INT18 Reference (or any other feature) to the external entity, but it can also link the corresponding actualization of said feature to the external entity. This depends on the respective theoretical framework and is not specified in the context of this ontology.
    /// 			(The scope of this class also includes references to other images/texts, if one wants to model an interrelation this way.)"</para>
    /// labels<para>"INT18 Reference"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT18_Reference">https://w3id.org/lso/intro/beta202408#INT18_Reference</seealso>
    let INT18_Reference = Prefixed_Name(intro, "INT18_Reference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT1_Passage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The INT1 Passage is a means of modelling an identifiable part of an E73 Information Object or its subclasses – without that part being removed from its source Information Object.
    /// 			For examples, see subclass comments.
    /// 			The skos:broadMatch states that the INT1 Passage can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT1 Passage's location."</para>
    /// labels<para>"INT1 Passage"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT1_Passage">https://w3id.org/lso/intro/beta202408#INT1_Passage</seealso>
    let INT1_Passage = Prefixed_Name(intro, "INT1_Passage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT21_TextPassage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The INT21 TextPassage is a means of modelling an identifiable part of an E73 Information Object or its subclasses – without that part being removed from its source Information Object.
    /// 			Examples:
    /// 			- The words 'Abandon all hope ye who enter here' from Canto III of Dante's Inferno.
    /// 			- The first four lines of Rilke's poem "Archaischer Torso Apollos"
    /// 			- The last item on a shopping list.
    /// 			The skos:broadMatch states that the INT21 TextPassage can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT21 TextPassage's location."</para>
    /// labels<para>"INT21 Text Passage"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT21_TextPassage">https://w3id.org/lso/intro/beta202408#INT21_TextPassage</seealso>
    let INT21_TextPassage = Prefixed_Name(intro, "INT21_TextPassage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT22_ImageArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The INT22 ImageArea is a means of modelling an identifiable part of an image (itself modelled as an E73 Information Object or one of its subclasses) – without that part being removed from its source Information Object.
    /// 			Examples:
    /// 			- The part of Leonardo's Mona Lisa showing Mona Lisa's smile.
    /// 			- The bottom 3/5 of Rothko's Painting "Orange And Yellow" (1956), dominated by the fuzzy orange rectangle.
    /// 			- The part of the "Smiley Face" originally invented by Harvey Ball that shows the Smiley's left eye.
    /// 			- The part of Piranesi's The Drawbridge, 2nd version, showing a drawbridge.
    ///
    /// 			The skos:broadMatch states that the INT22 ImageArea can be regarded as an oa:SpecificResource in the sense that it is a section of a resource.
    /// 			The skos:broadMatch between R41 hasLocation and oa:hasSelector indicates that by replacing R41 hasLocation with oa:hasSelector, multiple selector options from the Web Annotation Ontology can be utilized to specify the INT22 ImageArea's location."</para>
    /// labels<para>"INT22 Image Area"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT22_ImageArea">https://w3id.org/lso/intro/beta202408#INT22_ImageArea</seealso>
    let INT22_ImageArea = Prefixed_Name(intro, "INT22_ImageArea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT23_VisualFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class contains visual features of images - but possibly also of texts. Its subclasses are rudimentary, it is very likely that instances of other INT4 Feature subclasses can be classified as visual features at the same time. This might be the case for, e.g., INT Composition (although for these instances classification as an INT26 Shape should also be considered)."</para>
    /// labels<para>"INT23 Visual Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT23_VisualFeature">https://w3id.org/lso/intro/beta202408#INT23_VisualFeature</seealso>
    let INT23_VisualFeature =
        Prefixed_Name(intro, "INT23_VisualFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT24_TextualFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class contains textual features, usually found on texts - but possibly also on images. It is very likely that instances of other INT4 Feature subclasses can be classified as textual features at the same time."</para>
    /// labels<para>"INT24 Textual Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT24_TextualFeature">https://w3id.org/lso/intro/beta202408#INT24_TextualFeature</seealso>
    let INT24_TextualFeature =
        Prefixed_Name(intro, "INT24_TextualFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT25_Color</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT25 Color"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT25_Color">https://w3id.org/lso/intro/beta202408#INT25_Color</seealso>
    let INT25_Color = Prefixed_Name(intro, "INT25_Color") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT26_Shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT26 Shape"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT26_Shape">https://w3id.org/lso/intro/beta202408#INT26_Shape</seealso>
    let INT26_Shape = Prefixed_Name(intro, "INT26_Shape") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT27_Texture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT27 Texture"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT27_Texture">https://w3id.org/lso/intro/beta202408#INT27_Texture</seealso>
    let INT27_Texture = Prefixed_Name(intro, "INT27_Texture") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT28_Ratio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT28 Ratio"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT28_Ratio">https://w3id.org/lso/intro/beta202408#INT28_Ratio</seealso>
    let INT28_Ratio = Prefixed_Name(intro, "INT28_Ratio") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT2_ActualizationOfFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The fact that a text or an image shows - in its own specific way - a certain feature (which itself is an abstract concept and takes form in many texts/images), e.g. a motif, an atmosphere, a theme, a figure of speech.
    /// 			Examples:
    /// 			- the specific actualization of the motif of patricide in Sophokles' 'Ödipus Rex'.
    /// 			- the specific actualization of the Faust-subject in Goethe's 'Faust'.
    /// 			- the specific actualization of the iambic pentameter in Rilke's 'Archaischer Torso Apollos".
    /// 			- the specific actualization of the Ophelia-character in John Everett Millais' painting "Ophelia" (1852).
    /// 		"</para>
    /// labels<para>"INT2 Actualization of Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT2_ActualizationOfFeature">https://w3id.org/lso/intro/beta202408#INT2_ActualizationOfFeature</seealso>
    let INT2_ActualizationOfFeature =
        Prefixed_Name(intro, "INT2_ActualizationOfFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT31_IntertextualRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT31 Intertextual Relation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT31_IntertextualRelation">https://w3id.org/lso/intro/beta202408#INT31_IntertextualRelation</seealso>
    let INT31_IntertextualRelation =
        Prefixed_Name(intro, "INT31_IntertextualRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT32_InterpictorialRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT32 Interpictorial Relation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT32_InterpictorialRelation">https://w3id.org/lso/intro/beta202408#INT32_InterpictorialRelation</seealso>
    let INT32_InterpictorialRelation =
        Prefixed_Name(intro, "INT32_InterpictorialRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT33_IntermedialRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT33 Intermedial Relation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT33_IntermedialRelation">https://w3id.org/lso/intro/beta202408#INT33_IntermedialRelation</seealso>
    let INT33_IntermedialRelation =
        Prefixed_Name(intro, "INT33_IntermedialRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT34_IntermedialityInIntermedialityTheories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises intermedial relations that can be found in research literature dedicated to intermediality theory."</para>
    /// labels<para>"INT34 Intermediality in Intermediality Theories"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT34_IntermedialityInIntermedialityTheories">https://w3id.org/lso/intro/beta202408#INT34_IntermedialityInIntermedialityTheories</seealso>
    let INT34_IntermedialityInIntermedialityTheories =
        Prefixed_Name(intro, "INT34_IntermedialityInIntermedialityTheories") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT35_InterpictorialityInInterpictorialityTheories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises interpictorial relations that can be found in research literature dedicated to interpictoriality theory."</para>
    /// labels<para>"INT35 Interpictoriality in Interpictoriality Theories"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT35_InterpictorialityInInterpictorialityTheories">https://w3id.org/lso/intro/beta202408#INT35_InterpictorialityInInterpictorialityTheories</seealso>
    let INT35_InterpictorialityInInterpictorialityTheories =
        Prefixed_Name(intro, "INT35_InterpictorialityInInterpictorialityTheories") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT3_Interrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises the abstract notion of a relationship between texts and/or images resp. their parts as it is identified by a recipient (which is not the same as the rhetorical entity 'quotation'). Every INT3 Interrelation has at least 2 related entities, which are texts/images (on any ontological level) or INT2 Actualizations of Features. An INT3 Interrelation is possibly identified in an INT Interpretation and further defined by an INT11 TypeOfInterrelation.
    /// 			The skos:broadMatch to oa:Annotation indicates that stating the existence of an intertextual relation can be seen as a kind of annotation made to resources, in this case: at least two, the related entities (texts and/or images)."</para>
    /// labels<para>"INT3 Interrelation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT3_Interrelation">https://w3id.org/lso/intro/beta202408#INT3_Interrelation</seealso>
    let INT3_Interrelation = Prefixed_Name(intro, "INT3_Interrelation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT4_Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises features that 'are in' or 'can be found in' or 'can be read out of' a text or an image. INT2 Actualizations of these features are the results of a receptive process that identifies the specific form the INT4 Feature – a distinct abstract concept, itself separate from the text or image – takes in the text or image. This class therefore has a wide scope. Its domain could be divided into subclasses following any number of different ratios; to avoid the resulting restrictions and/or complex hierarchies, the actual subclasses of the INT4 Feature represent diverse approaches to its subject matter, covering medial aspects as well as aspect of form and semantics. They can be populated resp. extended with custom subclasses based e.g. on relevant reference works: The class INT8 Rhetorical Feature could contain concepts based on classical rhetoric like allegory or personification, but would of course also include the pictorial pendants of these tropes. Lemmata from handbooks of poetic terms as well as concepts of pictorial composition could populate the INT10 Formal Feature resp. its (sub-)subclasses. Subclasses of INT9 Semantic Feature could be extended using art thesauri as well as handbooks on literary motives.
    /// 			For external thesauri and vocabularies see, e. g., ICONCLASS, the Getty Art and Architecture Thesaurus, the Getty Cultural Objects Name Authority, the Getty Union List of Artist Names, the Literary Theme Ontology (LTO), the Document Components Ontology, the OntoPoetry Ontology, the Taxonomy of Themes and Motifs (TTM2) ..."</para>
    /// labels<para>"INT4 Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT4_Feature">https://w3id.org/lso/intro/beta202408#INT4_Feature</seealso>
    let INT4_Feature = Prefixed_Name(intro, "INT4_Feature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT6_Architext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An INT6 Architextual Entity consists in a number of texts/images which in some way give reason to see them as connected, related, sharing a common feature.
    /// 			Examples for INT6 Architextual Entities can be
    /// 			- discourses (members sharing a discoursive element, a topic etc.)
    /// 			- genres (members sharing genre conventions)
    /// 			- a discipline (members deriving from the same disciplinary background)
    /// 			- an oeuvre (members created by the same person)
    /// 			- national literatures/arts (members whose creators share a nationality) etc."</para>
    /// labels<para>"INT6 Architext"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT6_Architext">https://w3id.org/lso/intro/beta202408#INT6_Architext</seealso>
    let INT6_Architext = Prefixed_Name(intro, "INT6_Architext") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT8_RhetoricalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises every aspect of a text or an image that can be described in terms of rhetorics - ranging from the occurrence of rhetorical tropes to parts of an e.g. research paper like 'introduction' or 'quotation' (pragmatic entities) to aspects of the narrative act such as 'voice' or 'narrating time' (narratological entities). Questions of composition in visual arts can often also be classified as a rhetorical feature."</para>
    /// labels<para>"INT8 Rhetorical Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT8_RhetoricalFeature">https://w3id.org/lso/intro/beta202408#INT8_RhetoricalFeature</seealso>
    let INT8_RhetoricalFeature =
        Prefixed_Name(intro, "INT8_RhetoricalFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT9_SemanticFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises every semantic aspect of a text or image, like the common notions of 'plot', 'sujet', or 'character'. While most subclasses are still object to refinement and addition – to indicate their provisional status they are not yet numbered in this version of INTRO –, INT18 Reference has been numbered to indicate its consolidated status."</para>
    /// labels<para>"INT9 Semantic Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT9_SemanticFeature">https://w3id.org/lso/intro/beta202408#INT9_SemanticFeature</seealso>
    let INT9_SemanticFeature =
        Prefixed_Name(intro, "INT9_SemanticFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Act</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Act (Drama)"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Act">https://w3id.org/lso/intro/beta202408#INT_Act</seealso>
    let INT_Act = Prefixed_Name(intro, "INT_Act") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Atmosphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Atmosphere"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Atmosphere">https://w3id.org/lso/intro/beta202408#INT_Atmosphere</seealso>
    let INT_Atmosphere = Prefixed_Name(intro, "INT_Atmosphere") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Chapter (Prose)"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Chapter">https://w3id.org/lso/intro/beta202408#INT_Chapter</seealso>
    let INT_Chapter = Prefixed_Name(intro, "INT_Chapter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Character"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Character">https://w3id.org/lso/intro/beta202408#INT_Character</seealso>
    let INT_Character = Prefixed_Name(intro, "INT_Character") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Composition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Composition"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Composition">https://w3id.org/lso/intro/beta202408#INT_Composition</seealso>
    let INT_Composition = Prefixed_Name(intro, "INT_Composition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Constellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Constellation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Constellation">https://w3id.org/lso/intro/beta202408#INT_Constellation</seealso>
    let INT_Constellation = Prefixed_Name(intro, "INT_Constellation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Definition"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Definition">https://w3id.org/lso/intro/beta202408#INT_Definition</seealso>
    let INT_Definition = Prefixed_Name(intro, "INT_Definition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Description"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Description">https://w3id.org/lso/intro/beta202408#INT_Description</seealso>
    let INT_Description = Prefixed_Name(intro, "INT_Description") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Discipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Discipline"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Discipline">https://w3id.org/lso/intro/beta202408#INT_Discipline</seealso>
    let INT_Discipline = Prefixed_Name(intro, "INT_Discipline") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Discourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Discourse"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Discourse">https://w3id.org/lso/intro/beta202408#INT_Discourse</seealso>
    let INT_Discourse = Prefixed_Name(intro, "INT_Discourse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_DramaticEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises concepts from drama theory."</para>
    /// labels<para>"INT Dramatic Entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_DramaticEntity">https://w3id.org/lso/intro/beta202408#INT_DramaticEntity</seealso>
    let INT_DramaticEntity = Prefixed_Name(intro, "INT_DramaticEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Epoch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Epoch"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Epoch">https://w3id.org/lso/intro/beta202408#INT_Epoch</seealso>
    let INT_Epoch = Prefixed_Name(intro, "INT_Epoch") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Event"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Event">https://w3id.org/lso/intro/beta202408#INT_Event</seealso>
    let INT_Event = Prefixed_Name(intro, "INT_Event") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_FigurativeFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class comprises figures of speech. Since there are countless classification systems (the most common dividing figures into tropoi - metaphor, metonymy ... - and schemata/figurae, further dividing the latter into figures of thougth and figures of word, further dividing the latter into grammatical and rhetorical figures of word), no subclasses will be provided."</para>
    /// labels<para>"INT Figurative Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_FigurativeFeature">https://w3id.org/lso/intro/beta202408#INT_FigurativeFeature</seealso>
    let INT_FigurativeFeature =
        Prefixed_Name(intro, "INT_FigurativeFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_FigurativeMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Figurative Meaning"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_FigurativeMeaning">https://w3id.org/lso/intro/beta202408#INT_FigurativeMeaning</seealso>
    let INT_FigurativeMeaning =
        Prefixed_Name(intro, "INT_FigurativeMeaning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Genre"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Genre">https://w3id.org/lso/intro/beta202408#INT_Genre</seealso>
    let INT_Genre = Prefixed_Name(intro, "INT_Genre") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_GenreSpecifics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"INT Genre Specifics comprises all features that are used to assign a certain genre - whether textual or visual -, are typical of such a genre, or occur frequently in it. Instances might often be also instances of the other subclasses of INT4 Feature. INT Genre Specifics' two subclasses – INT Visual Genre Specifics and INT Textual Genre Specifics – do not imply that each feature must be either–or, in some cases features will be assignable to both classes."</para>
    /// labels<para>"INT Genre Specifics"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_GenreSpecifics">https://w3id.org/lso/intro/beta202408#INT_GenreSpecifics</seealso>
    let INT_GenreSpecifics = Prefixed_Name(intro, "INT_GenreSpecifics") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Identification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Identification"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Identification">https://w3id.org/lso/intro/beta202408#INT_Identification</seealso>
    let INT_Identification = Prefixed_Name(intro, "INT_Identification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_IndividualCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Individual Character"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_IndividualCharacter">https://w3id.org/lso/intro/beta202408#INT_IndividualCharacter</seealso>
    let INT_IndividualCharacter =
        Prefixed_Name(intro, "INT_IndividualCharacter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_IndividualObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Individual Object"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_IndividualObject">https://w3id.org/lso/intro/beta202408#INT_IndividualObject</seealso>
    let INT_IndividualObject =
        Prefixed_Name(intro, "INT_IndividualObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_IndividualPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Individual Place"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_IndividualPlace">https://w3id.org/lso/intro/beta202408#INT_IndividualPlace</seealso>
    let INT_IndividualPlace =
        Prefixed_Name(intro, "INT_IndividualPlace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Interpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The result of a interpretative act, possibly: as perceived in research literature. An interpretation can identify references or actualizations or the like. A number of interpretations can together recreate the structure of, e.g., a research paper. Accordingly, apart from linking INT Interpretations to the subjects of the interpretation, like intertextual relations or textual features, they can be linked to each other via R9 has subsequent feature resp. R9i has preceding feature.
    /// 			Examples:
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' features a detective character.
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' contains references to Arthur Conan Doyle's 'Sherlock Holmes'.
    /// 			- the statement that Umberto Eco's 'The Name of the Rose' is set in the 14th century.
    /// 			- the conclusion that Umberto Eco's 'The Name of the Rose' belongs to the genre 'postmodern crime novel'."</para>
    /// labels<para>"INT Interpretation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Interpretation">https://w3id.org/lso/intro/beta202408#INT_Interpretation</seealso>
    let INT_Interpretation = Prefixed_Name(intro, "INT_Interpretation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Line</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Line (Poetry)"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Line">https://w3id.org/lso/intro/beta202408#INT_Line</seealso>
    let INT_Line = Prefixed_Name(intro, "INT_Line") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_LyricalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises rhetorical concepts from lyric theory."</para>
    /// labels<para>"INT Lyrical Entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_LyricalEntity">https://w3id.org/lso/intro/beta202408#INT_LyricalEntity</seealso>
    let INT_LyricalEntity = Prefixed_Name(intro, "INT_LyricalEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Mood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Mood"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Mood">https://w3id.org/lso/intro/beta202408#INT_Mood</seealso>
    let INT_Mood = Prefixed_Name(intro, "INT_Mood") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Motif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Motif"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Motif">https://w3id.org/lso/intro/beta202408#INT_Motif</seealso>
    let INT_Motif = Prefixed_Name(intro, "INT_Motif") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Movement"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Movement">https://w3id.org/lso/intro/beta202408#INT_Movement</seealso>
    let INT_Movement = Prefixed_Name(intro, "INT_Movement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_NarratologicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises narratological concepts insofar as they correlate with rhetorical concepts (like 'speech', 'distance', 'perspective' etc.). Due to the plurality of narratological frameworks, no subclasses will be provided at this point."</para>
    /// labels<para>"INT Narratological Entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_NarratologicalEntity">https://w3id.org/lso/intro/beta202408#INT_NarratologicalEntity</seealso>
    let INT_NarratologicalEntity =
        Prefixed_Name(intro, "INT_NarratologicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Object"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Object">https://w3id.org/lso/intro/beta202408#INT_Object</seealso>
    let INT_Object = Prefixed_Name(intro, "INT_Object") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Oeuvre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Oeuvre"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Oeuvre">https://w3id.org/lso/intro/beta202408#INT_Oeuvre</seealso>
    let INT_Oeuvre = Prefixed_Name(intro, "INT_Oeuvre") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Opinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Opinion"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Opinion">https://w3id.org/lso/intro/beta202408#INT_Opinion</seealso>
    let INT_Opinion = Prefixed_Name(intro, "INT_Opinion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Paragraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Paragraph (Prose)"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Paragraph">https://w3id.org/lso/intro/beta202408#INT_Paragraph</seealso>
    let INT_Paragraph = Prefixed_Name(intro, "INT_Paragraph") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Part"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Part">https://w3id.org/lso/intro/beta202408#INT_Part</seealso>
    let INT_Part = Prefixed_Name(intro, "INT_Part") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Place"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Place">https://w3id.org/lso/intro/beta202408#INT_Place</seealso>
    let INT_Place = Prefixed_Name(intro, "INT_Place") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Plot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Plot"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Plot">https://w3id.org/lso/intro/beta202408#INT_Plot</seealso>
    let INT_Plot = Prefixed_Name(intro, "INT_Plot") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_PragmaticFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class includes all features that can be attributed to a text or image with regard to the role that these works play in a plot, for example in a social, political or religious context. These characteristics take account of the fact that the works in question pursue a specific purpose that goes beyond content and form and that is apparent 'on the surface‘ or by application of certain conventions or handed-down standards. While INTRO-subclasses of this class are limited to those close to the functionality of INTRO and which are to be applied to the relation between primary and secondary (textual) sources, subclasses can of course also include concepts from visual art. A pragmatic feature of a painting might be a donor portrait expressing gratitude, the portrait of a ruler serving propaganda purposes, a bible scene serving as guide for pious action. Pragmatic features of texts include bibliographic references, acknowledgments, and the like."</para>
    /// labels<para>"INT Pragmatic Feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_PragmaticFeature">https://w3id.org/lso/intro/beta202408#INT_PragmaticFeature</seealso>
    let INT_PragmaticFeature =
        Prefixed_Name(intro, "INT_PragmaticFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Scene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Scene (Drama)"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Scene">https://w3id.org/lso/intro/beta202408#INT_Scene</seealso>
    let INT_Scene = Prefixed_Name(intro, "INT_Scene") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_School</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT School"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_School">https://w3id.org/lso/intro/beta202408#INT_School</seealso>
    let INT_School = Prefixed_Name(intro, "INT_School") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Situation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Situation">https://w3id.org/lso/intro/beta202408#INT_Situation</seealso>
    let INT_Situation = Prefixed_Name(intro, "INT_Situation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_SpaciallyDefinedArchitext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Geographically Defined Architext"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_SpaciallyDefinedArchitext">https://w3id.org/lso/intro/beta202408#INT_SpaciallyDefinedArchitext</seealso>
    let INT_SpaciallyDefinedArchitext =
        Prefixed_Name(intro, "INT_SpaciallyDefinedArchitext") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT State"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_State">https://w3id.org/lso/intro/beta202408#INT_State</seealso>
    let INT_State = Prefixed_Name(intro, "INT_State") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Subject"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Subject">https://w3id.org/lso/intro/beta202408#INT_Subject</seealso>
    let INT_Subject = Prefixed_Name(intro, "INT_Subject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Subtext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Subtext"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Subtext">https://w3id.org/lso/intro/beta202408#INT_Subtext</seealso>
    let INT_Subtext = Prefixed_Name(intro, "INT_Subtext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Tableau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Tableau (Drama)"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Tableau">https://w3id.org/lso/intro/beta202408#INT_Tableau</seealso>
    let INT_Tableau = Prefixed_Name(intro, "INT_Tableau") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_TemporallyDefinedArchitext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Temporally Defined Architext"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_TemporallyDefinedArchitext">https://w3id.org/lso/intro/beta202408#INT_TemporallyDefinedArchitext</seealso>
    let INT_TemporallyDefinedArchitext =
        Prefixed_Name(intro, "INT_TemporallyDefinedArchitext") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_TextType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Text Type"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_TextType">https://w3id.org/lso/intro/beta202408#INT_TextType</seealso>
    let INT_TextType = Prefixed_Name(intro, "INT_TextType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_TextualGenreSpecifics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Textual Genre Specifics"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_TextualGenreSpecifics">https://w3id.org/lso/intro/beta202408#INT_TextualGenreSpecifics</seealso>
    let INT_TextualGenreSpecifics =
        Prefixed_Name(intro, "INT_TextualGenreSpecifics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Theme"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Theme">https://w3id.org/lso/intro/beta202408#INT_Theme</seealso>
    let INT_Theme = Prefixed_Name(intro, "INT_Theme") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Theory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Theory"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Theory">https://w3id.org/lso/intro/beta202408#INT_Theory</seealso>
    let INT_Theory = Prefixed_Name(intro, "INT_Theory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_TimeSpan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Timespan"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_TimeSpan">https://w3id.org/lso/intro/beta202408#INT_TimeSpan</seealso>
    let INT_TimeSpan = Prefixed_Name(intro, "INT_TimeSpan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Topic"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Topic">https://w3id.org/lso/intro/beta202408#INT_Topic</seealso>
    let INT_Topic = Prefixed_Name(intro, "INT_Topic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Topos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Topos"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Topos">https://w3id.org/lso/intro/beta202408#INT_Topos</seealso>
    let INT_Topos = Prefixed_Name(intro, "INT_Topos") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_TypeOfCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Type of Character"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_TypeOfCharacter">https://w3id.org/lso/intro/beta202408#INT_TypeOfCharacter</seealso>
    let INT_TypeOfCharacter =
        Prefixed_Name(intro, "INT_TypeOfCharacter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_TypeOfPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Type of Place"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_TypeOfPlace">https://w3id.org/lso/intro/beta202408#INT_TypeOfPlace</seealso>
    let INT_TypeOfPlace = Prefixed_Name(intro, "INT_TypeOfPlace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_TypicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Typical Object"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_TypicalObject">https://w3id.org/lso/intro/beta202408#INT_TypicalObject</seealso>
    let INT_TypicalObject = Prefixed_Name(intro, "INT_TypicalObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_VarietyOfText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Variety of Text"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_VarietyOfText">https://w3id.org/lso/intro/beta202408#INT_VarietyOfText</seealso>
    let INT_VarietyOfText = Prefixed_Name(intro, "INT_VarietyOfText") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_Verse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Verse (Poetry)"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_Verse">https://w3id.org/lso/intro/beta202408#INT_Verse</seealso>
    let INT_Verse = Prefixed_Name(intro, "INT_Verse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#INT_VisualGenreSpecifics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"INT Visual Genre Specifics"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#INT_VisualGenreSpecifics">https://w3id.org/lso/intro/beta202408#INT_VisualGenreSpecifics</seealso>
    let INT_VisualGenreSpecifics =
        Prefixed_Name(intro, "INT_VisualGenreSpecifics") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R10_hasPassage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a text or an image – usually: a work or an expression – to an INT1 Passage from that text or image, e.g. a book to a passage on page three of this book, or a painting to an area on this paining."</para>
    /// labels<para>"R10 has passage"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R10_hasPassage">https://w3id.org/lso/intro/beta202408#R10_hasPassage</seealso>
    let R10_hasPassage = Prefixed_Name(intro, "R10_hasPassage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R10i_isPassageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"R10i is passage of"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R10i_isPassageOf">https://w3id.org/lso/intro/beta202408#R10i_isPassageOf</seealso>
    let R10i_isPassageOf = Prefixed_Name(intro, "R10i_isPassageOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R12_hasReferredToEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an INT3 Interrelation to the entity referred to in the relationship (a text or image on any ontological level or a feature actualized in the text resp. image in question)."</para>
    /// labels<para>"R12 has referred to entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R12_hasReferredToEntity">https://w3id.org/lso/intro/beta202408#R12_hasReferredToEntity</seealso>
    let R12_hasReferredToEntity =
        Prefixed_Name(intro, "R12_hasReferredToEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R12i_isReferredToEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"R12i is referred to entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R12i_isReferredToEntity">https://w3id.org/lso/intro/beta202408#R12i_isReferredToEntity</seealso>
    let R12i_isReferredToEntity =
        Prefixed_Name(intro, "R12i_isReferredToEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R13_hasReferringEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Links an INT3 Interrelation to a referring entity (a text or image on any ontological level or a feature actualized in the text resp. image in question)."</para>
    /// labels<para>"R13 has referring entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R13_hasReferringEntity">https://w3id.org/lso/intro/beta202408#R13_hasReferringEntity</seealso>
    let R13_hasReferringEntity =
        Prefixed_Name(intro, "R13_hasReferringEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R13i_isReferringEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"R13i is referring entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R13i_isReferringEntity">https://w3id.org/lso/intro/beta202408#R13i_isReferringEntity</seealso>
    let R13i_isReferringEntity =
        Prefixed_Name(intro, "R13i_isReferringEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R16_incorporates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an INT16 Segment to the text or image on any ontological level (passage, expression, work) it incorporates."</para>
    /// labels<para>"R16 incorporates"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R16_incorporates">https://w3id.org/lso/intro/beta202408#R16_incorporates</seealso>
    let R16_incorporates = Prefixed_Name(intro, "R16_incorporates") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R16i_isIncorporatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"R16i is incorporated in"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R16i_isIncorporatedIn">https://w3id.org/lso/intro/beta202408#R16i_isIncorporatedIn</seealso>
    let R16i_isIncorporatedIn =
        Prefixed_Name(intro, "R16i_isIncorporatedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R17_actualizesFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links the specific INT2 Actualization of Feature to the (abstract concept of the) feature it actualizes, an INT4 Feature."</para>
    /// labels<para>"R17 actualizes feature"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R17_actualizesFeature">https://w3id.org/lso/intro/beta202408#R17_actualizesFeature</seealso>
    let R17_actualizesFeature =
        Prefixed_Name(intro, "R17_actualizesFeature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R17i_featureActualizedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R17i feature actualized in"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R17i_featureActualizedIn">https://w3id.org/lso/intro/beta202408#R17i_featureActualizedIn</seealso>
    let R17i_featureActualizedIn =
        Prefixed_Name(intro, "R17i_featureActualizedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R18_showsActualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a text or an image (on any ontological level) or an INT2 Actualization of Feature to an INT2 Actualization of Feature found on it. (Actualizations found on actualizations - this occurs in cases where, e.g., the actualization of the feature INT Individual Character can be read as the actualization of the feature INT Character Type or INT18 Reference.)"</para>
    /// labels<para>"R18 shows actualization"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R18_showsActualization">https://w3id.org/lso/intro/beta202408#R18_showsActualization</seealso>
    let R18_showsActualization =
        Prefixed_Name(intro, "R18_showsActualization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R18i_actualizationFoundOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R18i actualization found on"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R18i_actualizationFoundOn">https://w3id.org/lso/intro/beta202408#R18i_actualizationFoundOn</seealso>
    let R18i_actualizationFoundOn =
        Prefixed_Name(intro, "R18i_actualizationFoundOn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R19_hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an INT3 Interrelation to its INT11 Type of Interrelation."</para>
    /// labels<para>"R19 has type"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R19_hasType">https://w3id.org/lso/intro/beta202408#R19_hasType</seealso>
    let R19_hasType = Prefixed_Name(intro, "R19_hasType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R19i_isTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R19i is type of"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R19i_isTypeOf">https://w3id.org/lso/intro/beta202408#R19i_isTypeOf</seealso>
    let R19i_isTypeOf = Prefixed_Name(intro, "R19i_isTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R20_discusses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Links an INT Interpretation to the instance of text or image (on any ontological level) it discusses."</para>
    /// labels<para>"R20 discusses"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R20_discusses">https://w3id.org/lso/intro/beta202408#R20_discusses</seealso>
    let R20_discusses = Prefixed_Name(intro, "R20_discusses") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R20i_isDiscussedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"R20i is discussed in"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R20i_isDiscussedIn">https://w3id.org/lso/intro/beta202408#R20i_isDiscussedIn</seealso>
    let R20i_isDiscussedIn = Prefixed_Name(intro, "R20i_isDiscussedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R21_identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an INT Identification or INT Interpretation to the INT3 Interrelation or the INT2 Actualization of Feature it identifies."</para>
    /// labels<para>"R21 identifies"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R21_identifies">https://w3id.org/lso/intro/beta202408#R21_identifies</seealso>
    let R21_identifies = Prefixed_Name(intro, "R21_identifies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R21i_isIdentifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"R21i is identified by"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R21i_isIdentifiedBy">https://w3id.org/lso/intro/beta202408#R21i_isIdentifiedBy</seealso>
    let R21i_isIdentifiedBy =
        Prefixed_Name(intro, "R21i_isIdentifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R22_providesSimilarityForRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an INT4 Feature to an INT3 Interrelation it provides the similarity for, the similarity being necessary for the detection of the INT3 Interrelation. States that an INT3 Interrelation is based on a similarity, i.e. the actualization of the same INT4 Feature in two different texts/images."</para>
    /// labels<para>"R22 provides similarity for relation"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R22_providesSimilarityForRelation">https://w3id.org/lso/intro/beta202408#R22_providesSimilarityForRelation</seealso>
    let R22_providesSimilarityForRelation =
        Prefixed_Name(intro, "R22_providesSimilarityForRelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R22i_relationIsBasedOnSimilarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R22i relation is based on similarity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R22i_relationIsBasedOnSimilarity">https://w3id.org/lso/intro/beta202408#R22i_relationIsBasedOnSimilarity</seealso>
    let R22i_relationIsBasedOnSimilarity =
        Prefixed_Name(intro, "R22i_relationIsBasedOnSimilarity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R23_providesSupportFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a source (a text on any ontological level or an actualization of a feature on said source) to the outcome of a receptional or interpretative act (an INT2 Actualization of Feature, an INT4 Feature like an INT Interpretation, an INT3 Interrelation) to support it."</para>
    /// labels<para>"R23 provides support for"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R23_providesSupportFor">https://w3id.org/lso/intro/beta202408#R23_providesSupportFor</seealso>
    let R23_providesSupportFor =
        Prefixed_Name(intro, "R23_providesSupportFor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R23i_supportProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"R23i support provided by"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R23i_supportProvidedBy">https://w3id.org/lso/intro/beta202408#R23i_supportProvidedBy</seealso>
    let R23i_supportProvidedBy =
        Prefixed_Name(intro, "R23i_supportProvidedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R24_hasRelatedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links any INT3 Interrelation to a text or image (on any ontological level) or INT2 Actualization of Feature that is part of the INT3 Interrelation. The skos:broadMatch states that this property is a more specific version of oa:hasTarget in the sense that the INT3 Interrelation can be seen as an annotation, the texts/images linked by this relationship as their targets."</para>
    /// labels<para>"R24 has related entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R24_hasRelatedEntity">https://w3id.org/lso/intro/beta202408#R24_hasRelatedEntity</seealso>
    let R24_hasRelatedEntity =
        Prefixed_Name(intro, "R24_hasRelatedEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R24i_isRelatedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R24i is related entity"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R24i_isRelatedEntity">https://w3id.org/lso/intro/beta202408#R24i_isRelatedEntity</seealso>
    let R24i_isRelatedEntity =
        Prefixed_Name(intro, "R24i_isRelatedEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R25_hasSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a F3 Manifestation to an INT16 Segment it contains (the segment in turn R16 incorporates an INT1 Passage or an F2 Expression)."</para>
    /// labels<para>"R25 has segment"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R25_hasSegment">https://w3id.org/lso/intro/beta202408#R25_hasSegment</seealso>
    let R25_hasSegment = Prefixed_Name(intro, "R25_hasSegment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R25i_isSegmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R25i is segment of"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R25i_isSegmentOf">https://w3id.org/lso/intro/beta202408#R25i_isSegmentOf</seealso>
    let R25i_isSegmentOf = Prefixed_Name(intro, "R25i_isSegmentOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R30_hasTextPassage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Links (usually, exceptions are easily conceivable) a text, like a work or an expression, to an INT21 Text Passage from that text, e.g. a book to a passage on page three of this book."</para>
    /// labels<para>"R30 has text passage"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R30_hasTextPassage">https://w3id.org/lso/intro/beta202408#R30_hasTextPassage</seealso>
    let R30_hasTextPassage = Prefixed_Name(intro, "R30_hasTextPassage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R30i_isTextPassageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R30i is text passage of"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R30i_isTextPassageOf">https://w3id.org/lso/intro/beta202408#R30i_isTextPassageOf</seealso>
    let R30i_isTextPassageOf =
        Prefixed_Name(intro, "R30i_isTextPassageOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R31_hasImageArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Links (usually, eceptions are easily conceivable) an image, like a work or an expression, to an INT22 Image Area from that image, e.g. a painting to an area on this paining."</para>
    /// labels<para>"R31 has image area"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R31_hasImageArea">https://w3id.org/lso/intro/beta202408#R31_hasImageArea</seealso>
    let R31_hasImageArea = Prefixed_Name(intro, "R31_hasImageArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R31i_isImageAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"R31i is image area of"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R31i_isImageAreaOf">https://w3id.org/lso/intro/beta202408#R31i_isImageAreaOf</seealso>
    let R31i_isImageAreaOf = Prefixed_Name(intro, "R31i_isImageAreaOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R3_constellates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an INT Constellation to the elements (INT2 Actualizations of Feature) that together form that INT Constellation."</para>
    /// labels<para>"R3 constellates"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R3_constellates">https://w3id.org/lso/intro/beta202408#R3_constellates</seealso>
    let R3_constellates = Prefixed_Name(intro, "R3_constellates") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R3i_isConstellatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R3i is constellated by"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R3i_isConstellatedBy">https://w3id.org/lso/intro/beta202408#R3i_isConstellatedBy</seealso>
    let R3i_isConstellatedBy =
        Prefixed_Name(intro, "R3i_isConstellatedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R40_hasBibliographicalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Links a text or image (work, expression, ...) to its bibliographical data, represented as a data string. (A shortcut for the actual modelling of bibliographical data.)"</para>
    /// labels<para>"R40 has bibliographical data"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R40_hasBibliographicalData">https://w3id.org/lso/intro/beta202408#R40_hasBibliographicalData</seealso>
    let R40_hasBibliographicalData =
        Prefixed_Name(intro, "R40_hasBibliographicalData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R41_hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Defines the location of an INT16 Segment in e.g. a F3 Manifestation, e.g. by giving page or paragraph numbers. Can be replaced by oa:hasSelector to specify the location utilizing the multiple options provided by the Web Annotation Ontology
    /// 			(https://www.w3.org/TR/annotation-vocab/#web-annotation-ontology)."</para>
    /// labels<para>"R41 has location"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R41_hasLocation">https://w3id.org/lso/intro/beta202408#R41_hasLocation</seealso>
    let R41_hasLocation = Prefixed_Name(intro, "R41_hasLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R42_hasParaphraseOrDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Links pretty much everything to a data string providing a definition for it. (A shortcut for modelling the definition as an INT2 Actualization of Feature.)"</para>
    /// labels<para>"R42 has paraphrase or definition"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R42_hasParaphraseOrDefinition">https://w3id.org/lso/intro/beta202408#R42_hasParaphraseOrDefinition</seealso>
    let R42_hasParaphraseOrDefinition =
        Prefixed_Name(intro, "R42_hasParaphraseOrDefinition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R43_hasSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Links a feature to a data string defining or describing it more closely."</para>
    /// labels<para>"R43 has specification"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R43_hasSpecification">https://w3id.org/lso/intro/beta202408#R43_hasSpecification</seealso>
    let R43_hasSpecification =
        Prefixed_Name(intro, "R43_hasSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R44_hasWording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Links an INT21 Text Passage or an INT16 Segment to a data string providing its exact wording."</para>
    /// labels<para>"R44 has wording"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R44_hasWording">https://w3id.org/lso/intro/beta202408#R44_hasWording</seealso>
    let R44_hasWording = Prefixed_Name(intro, "R44_hasWording") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R4_defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Relates an actualization (usually: of the semantic feature 'INT Definition') to an INT11 Type of Interrelation, to INT4 Features, or to INT6 Architexts and thereby links e.g. a feature of text passage – e.g. a definition in Foucault's writings – to a concept - e.g. 'discourse'."</para>
    /// labels<para>"R4 defines"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R4_defines">https://w3id.org/lso/intro/beta202408#R4_defines</seealso>
    let R4_defines = Prefixed_Name(intro, "R4_defines") |> PrefixedName
    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R4i_isDefinedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"R4i is defined in"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R4i_isDefinedIn">https://w3id.org/lso/intro/beta202408#R4i_isDefinedIn</seealso>
    let R4i_isDefinedIn = Prefixed_Name(intro, "R4i_isDefinedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R8_hasOpinionObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an INT Opinion to its object - for example an opinion with the theme fashion (to make it an opinion about fashion)."</para>
    /// labels<para>"R8 has opinion object"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R8_hasOpinionObject">https://w3id.org/lso/intro/beta202408#R8_hasOpinionObject</seealso>
    let R8_hasOpinionObject =
        Prefixed_Name(intro, "R8_hasOpinionObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R8i_isOpinionObjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"R8i is opinion object of"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R8i_isOpinionObjectOf">https://w3id.org/lso/intro/beta202408#R8i_isOpinionObjectOf</seealso>
    let R8i_isOpinionObjectOf =
        Prefixed_Name(intro, "R8i_isOpinionObjectOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R9_hasSubsequentActualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Links an INT2 Actualization of Feature to another INT4 following it (logically or chronologically); this object property was mostly designed for the representation of the structure of research papers, where one definition, interpretation, etc., follows another."</para>
    /// labels<para>"R9 has subsequent actualization"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R9_hasSubsequentActualization">https://w3id.org/lso/intro/beta202408#R9_hasSubsequentActualization</seealso>
    let R9_hasSubsequentActualization =
        Prefixed_Name(intro, "R9_hasSubsequentActualization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:lso/intro/beta202408#R9i_hasPrecedingActualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"R9i has preceding actualization"</para></remarks>
    /// <seealso href="https://w3id.org/lso/intro/beta202408#R9i_hasPrecedingActualization">https://w3id.org/lso/intro/beta202408#R9i_hasPrecedingActualization</seealso>
    let R9i_hasPrecedingActualization =
        Prefixed_Name(intro, "R9i_hasPrecedingActualization") |> PrefixedName
