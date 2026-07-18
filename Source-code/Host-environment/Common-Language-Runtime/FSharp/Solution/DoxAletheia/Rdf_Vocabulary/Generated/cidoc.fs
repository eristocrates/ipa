namespace http.www.cidoc_crm.org.cidoc_crm.slash

open DoxAletheia.Rdf_Vocabulary

module cidoc =
    let _namespace_name = "http://www.cidoc-crm.org/cidoc-crm/"

    /// <summary>
    /// This class comprises transfers of physical custody of objects between instances of E39 Actor.
    /// The recording of the donor and/or recipient is optional. It is possible that in an instance of E10 Transfer of Custody there is either no donor or no recipient. Depending on the circumstances it may describe:
    /// 1.	the beginning of custody
    /// 2.	the end of custody
    /// 3.	the transfer of custody
    /// 4.	the receipt of custody from an unknown source
    /// 5.	the declared loss of an object
    /// The distinction between the legal responsibility for custody and the actual physical possession of the object should be expressed using the property P2 has type (is type of). A specific case of transfer of custody is theft.
    /// The interpretation of the museum notion of "accession" differs between institutions. The CRM therefore models legal ownership and physical custody separately. Institutions will then model their specific notions of accession and deaccession as combinations of these.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E10_Transfer_of_Custody"></see></summary>
    let E10_Transfer_of_Custody =
        Namespaced_IRI.parse _namespace_name "E10_Transfer_of_Custody" |> NamespacedName

    /// <summary>
    /// This class comprises actions intentionally carried out by instances of E39 Actor that result in changes of state in the cultural, social, or physical systems documented.
    /// This notion includes complex, composite and long-lasting actions such as the building of a settlement or a war, as well as simple, short-lived actions such as the opening of a door.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E7_Activity"></see></summary>
    let E7_Activity =
        Namespaced_IRI.parse _namespace_name "E7_Activity" |> NamespacedName

    /// <summary>
    /// This class comprises all instances of E7 Activity that create, alter or change E24 Physical Man-Made Thing.
    /// This class includes the production of an item from raw materials, and other so far undocumented objects, and the preventive treatment or restoration of an object for conservation.
    /// Since the distinction between modification and production is not always clear, modification is regarded as the more generally applicable concept. This implies that some items may be consumed or destroyed in a Modification, and that others may be produced as a result of it. An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the originals. In this case, the new items have separate identities.
    /// If the instance of the E29 Design or Procedure utilized for the modification prescribes the use of specific materials, they should be documented using property P68 foresees use of (use foreseen by): E57 Material of E29 Design or Procedure, rather than via P126 employed (was employed in): E57 Material.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E11_Modification"></see></summary>
    let E11_Modification =
        Namespaced_IRI.parse _namespace_name "E11_Modification" |> NamespacedName

    /// <summary>
    /// This class comprises activities that are designed to, and succeed in, creating one or more new items.
    /// It specializes the notion of modification into production. The decision as to whether or not an object is regarded as new is context sensitive. Normally, items are considered “new” if there is no obvious overall similarity between them and the consumed items and material used in their production. In other cases, an item is considered “new” because it becomes relevant to documentation by a modification. For example, the scribbling of a name on a potsherd may make it a voting token. The original potsherd may not be worth documenting, in contrast to the inscribed one.
    /// This entity can be collective: the printing of a thousand books, for example, would normally be considered a single event.
    /// An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the originals. In this case, the new items have separate identities and matter is preserved, but identity is not.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E12_Production"></see></summary>
    let E12_Production =
        Namespaced_IRI.parse _namespace_name "E12_Production" |> NamespacedName

    /// <summary>
    /// This class comprises events that bring into existence any E77 Persistent Item.
    /// It may be used for temporal reasoning about things (intellectual products, physical items, groups of people, living beings) beginning to exist; it serves as a hook for determination of a terminus post quem and ante quem.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E63_Beginning_of_Existence"></see></summary>
    let E63_Beginning_of_Existence =
        Namespaced_IRI.parse _namespace_name "E63_Beginning_of_Existence" |> NamespacedName

    /// <summary>
    /// This class comprises the actions of making assertions about properties of an object or any relation between two items or concepts.
    /// This class allows the documentation of how the respective assignment came about, and whose opinion it was. All the attributes or properties assigned in such an action can also be seen as directly attached to the respective item or concept, possibly as a collection of contradictory values. All cases of properties in this model that are also described indirectly through an action are characterised as "short cuts" of this action. This redundant modelling of two alternative views is preferred because many implementations may have good reasons to model either the action or the short cut, and the relation between both alternatives can be captured by simple rules.
    /// In particular, the class describes the actions of people making propositions and statements during certain museum procedures, e.g. the person and date when a condition statement was made, an identifier was assigned, the museum object was measured, etc. Which kinds of such assignments and statements need to be documented explicitly in structures of a schema rather than free text, depends on if this information should be accessible by structured queries.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E13_Attribute_Assignment"></see></summary>
    let E13_Attribute_Assignment =
        Namespaced_IRI.parse _namespace_name "E13_Attribute_Assignment" |> NamespacedName

    /// <summary>
    /// This class describes the act of assessing the state of preservation of an object during a particular period.
    /// The condition assessment may be carried out by inspection, measurement or through historical research. This class is used to document circumstances of the respective assessment that may be relevant to interpret its quality at a later stage, or to continue research on related documents.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E14_Condition_Assessment"></see></summary>
    let E14_Condition_Assessment =
        Namespaced_IRI.parse _namespace_name "E14_Condition_Assessment" |> NamespacedName

    /// <summary>
    /// This class comprises activities that result in the allocation of an identifier to an instance of E1 CRM Entity. An E15 Identifier Assignment may include the creation of the identifier from multiple constituents, which themselves may be instances of E41 Appellation. The syntax and kinds of constituents to be used may be declared in a rule constituting an instance of E29 Design or Procedure.
    /// Examples of such identifiers include Find Numbers, Inventory Numbers, uniform titles in the sense of librarianship and Digital Object Identifiers (DOI). Documenting the act of identifier assignment and deassignment is especially useful when objects change custody or the identification system of an organization is changed. In order to keep track of the identity of things in such cases, it is important to document by whom, when and for what purpose an identifier is assigned to an item.
    /// The fact that an identifier is a preferred one for an organisation can be expressed by using the property E1 CRM Entity. P48 has preferred identifier (is preferred identifier of): E42 Identifier. It can better be expressed in a context independent form by assigning a suitable E55 Type, such as “preferred identifier assignment”, to the respective instance of E15 Identifier Assignment via the P2 has type property.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E15_Identifier_Assignment"></see></summary>
    let E15_Identifier_Assignment =
        Namespaced_IRI.parse _namespace_name "E15_Identifier_Assignment" |> NamespacedName

    /// <summary>
    /// This class comprises actions measuring physical properties and other values that can be determined by a systematic procedure.
    /// Examples include measuring the monetary value of a collection of coins or the running time of a specific video cassette.
    /// The E16 Measurement may use simple counting or tools, such as yardsticks or radiation detection devices. The interest is in the method and care applied, so that the reliability of the result may be judged at a later stage, or research continued on the associated documents. The date of the event is important for dimensions, which may change value over time, such as the length of an object subject to shrinkage. Details of methods and devices are best handled as free text, whereas basic techniques such as "carbon 14 dating" should be encoded using P2 has type (is type of:) E55 Type.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E16_Measurement"></see></summary>
    let E16_Measurement =
        Namespaced_IRI.parse _namespace_name "E16_Measurement" |> NamespacedName

    /// <summary>
    /// This class comprises the actions of classifying items of whatever kind. Such items include objects, specimens, people, actions and concepts.
    /// This class allows for the documentation of the context of classification acts in cases where the value of the classification depends on the personal opinion of the classifier, and the date that the classification was made. This class also encompasses the notion of "determination," i.e. the systematic and molecular identification of a specimen in biology.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E17_Type_Assignment"></see></summary>
    let E17_Type_Assignment =
        Namespaced_IRI.parse _namespace_name "E17_Type_Assignment" |> NamespacedName

    /// <summary>
    /// This class comprises all persistent physical items with a relatively stable form, man-made or natural.
    /// Depending on the existence of natural boundaries of such things, the CRM distinguishes the instances of E19 Physical Object from instances of E26 Physical Feature, such as holes, rivers, pieces of land etc. Most instances of E19 Physical Object can be moved (if not too heavy), whereas features are integral to the surrounding matter.
    /// The CRM is generally not concerned with amounts of matter in fluid or gaseous states.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E18_Physical_Thing"></see></summary>
    let E18_Physical_Thing =
        Namespaced_IRI.parse _namespace_name "E18_Physical_Thing" |> NamespacedName

    /// <summary>
    /// This class comprises those material or immaterial items to which instances of E30 Right, such as the right of ownership or use, can be applied.
    /// This is true for all E18 Physical Thing. In the case of instances of E28 Conceptual Object, however, the identity of the E28 Conceptual Object or the method of its use may be too ambiguous to reliably establish instances of E30 Right, as in the case of taxa and inspirations. Ownership of corporations is currently regarded as out of scope of the CRM.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E72_Legal_Object"></see></summary>
    let E72_Legal_Object =
        Namespaced_IRI.parse _namespace_name "E72_Legal_Object" |> NamespacedName

    /// <summary>
    /// This class comprises items of a material nature that are units for documentation and have physical boundaries that separate them completely in an objective way from other objects.
    /// The class also includes all aggregates of objects made for functional purposes of whatever kind, independent of physical coherence, such as a set of chessmen. Typically, instances of E19 Physical Object can be moved (if not too heavy).
    /// In some contexts, such objects, except for aggregates, are also called “bona fide objects” (Smith &amp; Varzi, 2000, pp.401-420), i.e. naturally defined objects.
    /// The decision as to what is documented as a complete item, rather than by its parts or components, may be a purely administrative decision or may be a result of the order in which the item was acquired.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E19_Physical_Object"></see></summary>
    let E19_Physical_Object =
        Namespaced_IRI.parse _namespace_name "E19_Physical_Object" |> NamespacedName

    /// <summary>
    /// This class comprises all things in the universe of discourse of the CIDOC Conceptual Reference Model.
    /// It is an abstract concept providing for three general properties:
    /// 1.	Identification by name or appellation, and in particular by a preferred identifier
    /// 2.	Classification by type, allowing further refinement of the specific subclass an instance belongs to
    /// 3.	Attachment of free text for the expression of anything not captured by formal properties
    /// With the exception of E59 Primitive Value, all other classes within the CRM are directly or indirectly specialisations of E1 CRM Entity.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E1_CRM_Entity"></see></summary>
    let E1_CRM_Entity =
        Namespaced_IRI.parse _namespace_name "E1_CRM_Entity" |> NamespacedName

    /// <summary>
    /// This class comprises individual items of a material nature, which live, have lived or are natural products of or from living organisms.
    /// Artificial objects that incorporate biological elements, such as Victorian butterfly frames, can be documented as both instances of E20 Biological Object and E22 Man-Made Object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E20_Biological_Object"></see></summary>
    let E20_Biological_Object =
        Namespaced_IRI.parse _namespace_name "E20_Biological_Object" |> NamespacedName

    /// <summary>
    /// This class comprises real persons who live or are assumed to have lived.
    /// Legendary figures that may have existed, such as Ulysses and King Arthur, fall into this class if the documentation refers to them as historical figures. In cases where doubt exists as to whether several persons are in fact identical, multiple instances can be created and linked to indicate their relationship. The CRM does not propose a specific form to support reasoning about possible identity.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E21_Person"></see></summary>
    let E21_Person = Namespaced_IRI.parse _namespace_name "E21_Person" |> NamespacedName
    /// <summary>
    /// This class comprises people, either individually or in groups, who have the potential to perform intentional actions for which they can be held responsible.
    /// The CRM does not attempt to model the inadvertent actions of such actors. Individual people should be documented as instances of E21 Person, whereas groups should be documented as instances of either E74 Group or its subclass E40 Legal Body.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E39_Actor"></see></summary>
    let E39_Actor = Namespaced_IRI.parse _namespace_name "E39_Actor" |> NamespacedName

    /// <summary>
    /// This class comprises physical objects purposely created by human activity.
    /// No assumptions are made as to the extent of modification required to justify regarding an object as man-made. For example, an inscribed piece of rock or a preserved butterfly are both regarded as instances of E22 Man-Made Object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E22_Man-Made_Object"></see></summary>
    let ``E22_Man-Made_Object`` =
        Namespaced_IRI.parse _namespace_name "E22_Man-Made_Object" |> NamespacedName

    /// <summary>
    /// This class comprises all persistent physical items that are purposely created by human activity.
    /// This class comprises man-made objects, such as a swords, and man-made features, such as rock art. No assumptions are made as to the extent of modification required to justify regarding an object as man-made. For example, a “cup and ring” carving on bedrock is regarded as instance of E24 Physical Man-Made Thing.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E24_Physical_Man-Made_Thing"></see></summary>
    let ``E24_Physical_Man-Made_Thing`` =
        Namespaced_IRI.parse _namespace_name "E24_Physical_Man-Made_Thing" |> NamespacedName

    /// <summary>
    /// This class comprises discrete, identifiable man-made items that are documented as single units.
    /// These items are either intellectual products or man-made physical things, and are characterized by relative stability. They may for instance have a solid physical form, an electronic encoding, or they may be logical concepts or structures.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E71_Man-Made_Thing"></see></summary>
    let ``E71_Man-Made_Thing`` =
        Namespaced_IRI.parse _namespace_name "E71_Man-Made_Thing" |> NamespacedName

    /// <summary>
    /// This class comprises physical features that are purposely created by human activity, such as scratches, artificial caves, artificial water channels, etc.
    /// No assumptions are made as to the extent of modification required to justify regarding a feature as man-made. For example, rock art or even “cup and ring” carvings on bedrock a regarded as types of E25 Man-Made Feature.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E25_Man-Made_Feature"></see></summary>
    let ``E25_Man-Made_Feature`` =
        Namespaced_IRI.parse _namespace_name "E25_Man-Made_Feature" |> NamespacedName

    /// <summary>
    /// This class comprises identifiable features that are physically attached in an integral way to particular physical objects.
    /// Instances of E26 Physical Feature share many of the attributes of instances of E19 Physical Object. They may have a one-, two- or three-dimensional geometric extent, but there are no natural borders that separate them completely in an objective way from the carrier objects. For example, a doorway is a feature but the door itself, being attached by hinges, is not.
    /// Instances of E26 Physical Feature can be features in a narrower sense, such as scratches, holes, reliefs, surface colours, reflection zones in an opal crystal or a density change in a piece of wood. In the wider sense, they are portions of particular objects with partially imaginary borders, such as the core of the Earth, an area of property on the surface of the Earth, a landscape or the head of a contiguous marble statue. They can be measured and dated, and it is sometimes possible to state who or what is or was responsible for them. They cannot be separated from the carrier object, but a segment of the carrier object may be identified (or sometimes removed) carrying the complete feature.
    /// This definition coincides with the definition of "fiat objects" (Smith &amp; Varzi, 2000, pp.401-420), with the exception of aggregates of “bona fide objects”.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E26_Physical_Feature"></see></summary>
    let E26_Physical_Feature =
        Namespaced_IRI.parse _namespace_name "E26_Physical_Feature" |> NamespacedName

    /// <summary>
    /// This class comprises pieces of land or sea floor.
    /// In contrast to the purely geometric notion of E53 Place, this class describes constellations of matter on the surface of the Earth or other celestial body, which can be represented by photographs, paintings and maps.
    ///  Instances of E27 Site are composed of relatively immobile material items and features in a particular configuration at a particular location
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E27_Site"></see></summary>
    let E27_Site = Namespaced_IRI.parse _namespace_name "E27_Site" |> NamespacedName

    /// <summary>
    /// This class comprises non-material products of our minds and other human produced data that 		have become objects of a discourse about their identity, circumstances of creation or historical 		implication. The production of such information may have been supported by the use of    		technical devices such as cameras or computers.
    /// Characteristically, instances of this class are created, invented or thought by someone, and then may be documented or communicated between persons. Instances of E28 Conceptual Object have the ability to exist on more than one particular carrier at the same time, such as paper, electronic signals, marks, audio media, paintings, photos, human memories, etc.
    /// They cannot be destroyed. They exist as long as they can be found on at least one carrier or in at least one human memory. Their existence ends when the last carrier and the last memory are lost.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E28_Conceptual_Object"></see></summary>
    let E28_Conceptual_Object =
        Namespaced_IRI.parse _namespace_name "E28_Conceptual_Object" |> NamespacedName

    /// <summary>
    /// This class comprises documented plans for the execution of actions in order to achieve a result of a specific quality, form or contents. In particular it comprises plans for deliberate human activities that may result in the modification or production of instances of E24 Physical Thing.
    /// Instances of E29 Design or Procedure can be structured in parts and sequences or depend on others. This is modelled using P69 is associated with.
    /// Designs or procedures can be seen as one of the following:
    /// 1.	A schema for the activities it describes
    /// 2.	A schema of the products that result from their application.
    /// 3.	An independent intellectual product that may have never been applied, such as Leonardo da Vinci’s famous plans for flying machines.
    /// Because designs or procedures may never be applied or only partially executed, the CRM models a loose relationship between the plan and the respective product.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E29_Design_or_Procedure"></see></summary>
    let E29_Design_or_Procedure =
        Namespaced_IRI.parse _namespace_name "E29_Design_or_Procedure" |> NamespacedName

    /// <summary>
    /// This class comprises identifiable immaterial items, such as a poems, jokes, data sets, images, texts, multimedia objects, procedural prescriptions, computer program code, algorithm or mathematical formulae, that have an objectively recognizable structure and are documented as single units.
    /// An E73 Information Object does not depend on a specific physical carrier, which can include human memory, and it can exist on one or more carriers simultaneously.
    /// Instances of E73 Information Object of a linguistic nature should be declared as instances of the E33 Linguistic Object subclass. Instances of E73 Information Object of a documentary nature should be declared as instances of the E31 Document subclass. Conceptual items such as types and classes are not instances of E73 Information Object, nor are ideas without a reproducible expression.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E73_Information_Object"></see></summary>
    let E73_Information_Object =
        Namespaced_IRI.parse _namespace_name "E73_Information_Object" |> NamespacedName

    /// <summary>
    /// This class comprises all phenomena, such as the instances of E4 Periods, E5 Events and states, which happen over a limited extent in time.
    /// 	In some contexts, these are also called perdurants. This class is disjoint from E77 Persistent Item. This is an abstract class and has no direct instances. E2 Temporal Entity is specialized into E4 Period, which applies to a particular geographic area (defined with a greater or lesser degree of precision), and E3 Condition State, which applies to instances of E18 Physical Thing.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E2_Temporal_Entity"></see></summary>
    let E2_Temporal_Entity =
        Namespaced_IRI.parse _namespace_name "E2_Temporal_Entity" |> NamespacedName

    /// <summary>
    /// This class comprises legal privileges concerning material and immaterial things or their derivatives.
    /// These include reproduction and property rights
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E30_Right"></see></summary>
    let E30_Right = Namespaced_IRI.parse _namespace_name "E30_Right" |> NamespacedName

    /// <summary>
    /// This class comprises immaterial items, including but not limited to stories, plots, procedural prescriptions, algorithms, laws of physics or images that are, or represent in some sense, sets of propositions about real or imaginary things and that are documented as single units or serve as topics of discourse.
    ///
    /// This class also comprises items that are “about” something in the sense of a subject. In the wider sense, this class includes expressions of psychological value such as non-figural art and musical themes. However, conceptual items such as types and classes are not instances of E89 Propositional Object. This should not be confused with the definition of a type, which is indeed an instance of E89 Propositional Object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E89_Propositional_Object"></see></summary>
    let E89_Propositional_Object =
        Namespaced_IRI.parse _namespace_name "E89_Propositional_Object" |> NamespacedName

    /// <summary>
    /// This class comprises identifiable immaterial items that make propositions about reality.
    /// These propositions may be expressed in text, graphics, images, audiograms, videograms or by other similar means. Documentation databases are regarded as a special case of E31 Document. This class should not be confused with the term “document” in Information Technology, which is compatible with E73 Information Object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E31_Document"></see></summary>
    let E31_Document =
        Namespaced_IRI.parse _namespace_name "E31_Document" |> NamespacedName

    /// <summary>
    /// This class comprises encyclopaedia, thesauri, authority lists and other documents that define terminology or conceptual systems for consistent use.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E32_Authority_Document"></see></summary>
    let E32_Authority_Document =
        Namespaced_IRI.parse _namespace_name "E32_Authority_Document" |> NamespacedName

    /// <summary>
    /// This class comprises identifiable expressions in natural language or languages.
    /// Instances of E33 Linguistic Object can be expressed in many ways: e.g. as written texts, recorded speech or sign language. However, the CRM treats instances of E33 Linguistic Object independently from the medium or method by which they are expressed. Expressions in formal languages, such as computer code or mathematical formulae, are not treated as instances of E33 Linguistic Object by the CRM. These should be modelled as instances of E73 Information Object.
    /// The text of an instance of E33 Linguistic Object can be documented in a note by P3 has note: E62 String
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E33_Linguistic_Object"></see></summary>
    let E33_Linguistic_Object =
        Namespaced_IRI.parse _namespace_name "E33_Linguistic_Object" |> NamespacedName

    /// <summary>
    /// This class comprises recognisable, short texts attached to instances of E24 Physical Man-Made Thing.
    /// The transcription of the text can be documented in a note by P3 has note: E62 String. The alphabet used can be documented by P2 has type: E55 Type. This class does not intend to describe the idiosyncratic characteristics of an individual physical embodiment of an inscription, but the underlying prototype. The physical embodiment is modelled in the CRM as E24 Physical Man-Made Thing.
    /// The relationship of a physical copy of a book to the text it contains is modelled using E84 Information Carrier. P128 carries (is carried by): E33 Linguistic Object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E34_Inscription"></see></summary>
    let E34_Inscription =
        Namespaced_IRI.parse _namespace_name "E34_Inscription" |> NamespacedName

    /// <summary>
    /// This class comprises symbols, signs, signatures or short texts applied to instances of E24 Physical Man-Made Thing by arbitrary techniques in order to indicate the creator, owner, dedications, purpose, etc.
    /// This class specifically excludes features that have no semantic significance, such as scratches or tool marks. These should be documented as instances of E25 Man-Made Feature.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E37_Mark"></see></summary>
    let E37_Mark = Namespaced_IRI.parse _namespace_name "E37_Mark" |> NamespacedName
    /// <summary>
    /// This class comprises the names assigned to works, such as texts, artworks or pieces of music.
    /// Titles are proper noun phrases or verbal phrases, and should not be confused with generic object names such as “chair”, “painting” or “book” (the latter are common nouns that stand for instances of E55 Type). Titles may be assigned by the creator of the work itself, or by a social group.
    /// This class also comprises the translations of titles that are used as surrogates for the original titles in different social contexts.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E35_Title"></see></summary>
    let E35_Title = Namespaced_IRI.parse _namespace_name "E35_Title" |> NamespacedName

    /// <summary>
    /// This class comprises all sequences of signs of any nature, either meaningful or not, that are used or can be used to refer to and identify a specific instance of some class within a certain context.
    /// Instances of E41 Appellation do not identify things by their meaning, even if they happen to have one, but by convention, tradition, or agreement. Instances of E41 Appellation are cultural constructs; as such, they have a context, a history, and a use in time and space by some group of users. A given instance of E41 Appellation can have alternative forms, i.e., other instances of E41 Appellation that are always regarded as equivalent independent from the thing it denotes.
    /// Specific subclasses of E41 Appellation should be used when instances of E41 Appellation of a characteristic form are used for particular objects. Instances of E49 Time Appellation, for example, which take the form of instances of E50 Date, can be easily recognised.
    /// E41 Appellation should not be confused with the act of naming something. Cf. E15 Identifier Assignment
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E41_Appellation"></see></summary>
    let E41_Appellation =
        Namespaced_IRI.parse _namespace_name "E41_Appellation" |> NamespacedName

    /// <summary>
    /// This class comprises the intellectual or conceptual aspects of recognisable marks and images.
    /// This class does not intend to describe the idiosyncratic characteristics of an individual physical embodiment of a visual item, but the underlying prototype. For example, a mark such as the ICOM logo is generally considered to be the same logo when used on any number of publications. The size, orientation and colour may change, but the logo remains uniquely identifiable. The same is true of images that are reproduced many times. This means that visual items are independent of their physical support.
    /// The class E36 Visual Item provides a means of identifying and linking together instances of E24 Physical Man-Made Thing that carry the same visual symbols, marks or images etc. The property P62 depicts (is depicted by) between E24 Physical Man-Made Thing and depicted subjects (E1 CRM Entity) can be regarded as a short-cut of the more fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1CRM Entity, which in addition captures the optical features of the depiction.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E36_Visual_Item"></see></summary>
    let E36_Visual_Item =
        Namespaced_IRI.parse _namespace_name "E36_Visual_Item" |> NamespacedName

    /// <summary>
    /// This class comprises distributions of form, tone and colour that may be found on surfaces such as photos, paintings, prints and sculptures or directly on electronic media.
    /// The degree to which variations in the distribution of form and colour affect the identity of an instance of E38 Image depends on a given purpose. The original painting of the Mona Lisa in the Louvre may be said to bear the same instance of E38 Image as reproductions in the form of transparencies, postcards, posters or T-shirts, even though they may differ in size and carrier and may vary in tone and colour. The images in a “spot the difference” competition are not the same with respect to their context, however similar they may at first appear.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E38_Image"></see></summary>
    let E38_Image = Namespaced_IRI.parse _namespace_name "E38_Image" |> NamespacedName

    /// <summary>
    /// This class comprises items that have a persistent identity, sometimes known as “endurants” in philosophy.
    /// They can be repeatedly recognized within the duration of their existence by identity criteria rather than by continuity or observation. Persistent Items can be either physical entities, such as people, animals or things, or conceptual entities such as ideas, concepts, products of the imagination or common names.
    /// The criteria that determine the identity of an item are often difficult to establish -; the decision depends largely on the judgement of the observer. For example, a building is regarded as no longer existing if it is dismantled and the materials reused in a different configuration. On the other hand, human beings go through radical and profound changes during their life-span, affecting both material composition and form, yet preserve their identity by other criteria. Similarly, inanimate objects may be subject to exchange of parts and matter. The class E77 Persistent Item does not take any position about the nature of the applicable identity criteria and if actual knowledge about identity of an instance of this class exists. There may be cases, where the identity of an E77 Persistent Item is not decidable by a certain state of knowledge.
    /// The main classes of objects that fall outside the scope the E77 Persistent Item class are temporal objects such as periods, events and acts, and descriptive properties.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E77_Persistent_Item"></see></summary>
    let E77_Persistent_Item =
        Namespaced_IRI.parse _namespace_name "E77_Persistent_Item" |> NamespacedName

    /// <summary>
    /// This class comprises the states of objects characterised by a certain condition over a time-span.
    /// An instance of this class describes the prevailing physical condition of any material object or feature during a specific E52 Time Span. In general, the time-span for which a certain condition can be asserted may be shorter than the real time-span, for which this condition held.
    ///  The nature of that condition can be described using P2 has type. For example, the E3 Condition State “condition of the SS Great Britain between 22 September 1846 and 27 August 1847” can be characterized as E55 Type “wrecked”.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E3_Condition_State"></see></summary>
    let E3_Condition_State =
        Namespaced_IRI.parse _namespace_name "E3_Condition_State" |> NamespacedName

    /// <summary>
    /// This class comprises institutions or groups of people that have obtained a legal recognition as a group and can act collectively as agents.
    /// This means that they can perform actions, own property, create or destroy things and can be held collectively responsible for their actions like individual people. The term 'personne morale' is often used for this in French.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E40_Legal_Body"></see></summary>
    let E40_Legal_Body =
        Namespaced_IRI.parse _namespace_name "E40_Legal_Body" |> NamespacedName

    /// <summary>
    /// This class comprises any gatherings or organizations of two or more people that act collectively or in a similar way due to any form of unifying relationship. In the wider sense this class also comprises official positions which used to be regarded in certain contexts as one actor, independent of the current holder of the office, such as the president of a country.
    /// A gathering of people becomes an E74 Group when it exhibits organizational characteristics usually typified by a set of ideas or beliefs held in common, or actions performed together. These might be communication, creating some common artifact, a common purpose such as study, worship, business, sports, etc. Nationality can be modeled as membership in an E74 Group (cf. HumanML markup). Married couples and other concepts of family are regarded as particular examples of E74 Group.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E74_Group"></see></summary>
    let E74_Group = Namespaced_IRI.parse _namespace_name "E74_Group" |> NamespacedName

    /// <summary>
    /// This class comprises identifiable symbols and any aggregation of symbols, such as characters, identifiers, traffic signs, emblems, texts, data sets, images, musical scores, multimedia objects, computer program code or mathematical formulae that have an objectively recognizable structure and that are documented as single units.
    /// It includes sets of signs of any nature, which may serve to designate something, or to communicate some propositional content.
    /// An instance of E90 Symbolic Object does not depend on a specific physical carrier, which can include human memory, and it can exist on one or more carriers simultaneously. An instance of E90 Symbolic Object may or may not have a specific meaning, for example an arbitrary character string.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E90_Symbolic_Object"></see></summary>
    let E90_Symbolic_Object =
        Namespaced_IRI.parse _namespace_name "E90_Symbolic_Object" |> NamespacedName

    /// <summary>
    /// This class comprises strings or codes assigned to instances of E1 CRM Entity in order to identify them uniquely and permanently within the context of one or more organisations. Such codes are often known as inventory numbers, registration codes, etc. and are typically composed of alphanumeric sequences. The class E42 Identifier is not normally used for machine-generated identifiers used for automated processing unless these are also used by human agents.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E42_Identifier"></see></summary>
    let E42_Identifier =
        Namespaced_IRI.parse _namespace_name "E42_Identifier" |> NamespacedName

    /// <summary>
    /// This class comprises any sort of identifier characteristically used to refer to an E53 Place.
    /// Instances of E44 Place Appellation may vary in their degree of precision and their meaning may vary over time - the same instance of E44 Place Appellation may be used to refer to several places, either because of cultural shifts, or because objects used as reference points have moved around. Instances of E44 Place Appellation can be extremely varied in form: postal addresses, instances of E47 Spatial Coordinate, and parts of buildings can all be considered as instances of E44 Place Appellation.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E44_Place_Appellation"></see></summary>
    let E44_Place_Appellation =
        Namespaced_IRI.parse _namespace_name "E44_Place_Appellation" |> NamespacedName

    /// <summary>
    /// This class comprises identifiers expressed in coding systems for places, such as postal addresses used for mailing.
    /// An E45 Address can be considered both as the name of an E53 Place and as an E51 Contact Point for an E39 Actor. This dual aspect is reflected in the multiple inheritance. However, some forms of mailing addresses, such as a postal box, are only instances of E51 Contact Point, since they do not identify any particular Place. These should not be documented as instances of E45 Address.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E45_Address"></see></summary>
    let E45_Address =
        Namespaced_IRI.parse _namespace_name "E45_Address" |> NamespacedName

    /// <summary>
    /// This class comprises identifiers employed, or understood, by communication services to direct communications to an instance of E39 Actor. These include E-mail addresses, telephone numbers, post office boxes, Fax numbers, URLs etc. Most postal addresses can be considered both as instances of E44 Place Appellation and E51 Contact Point. In such cases the subclass E45 Address should be used.
    /// URLs are addresses used by machines to access another machine through an http request. Since the accessed machine acts on behalf of the E39 Actor providing the machine, URLs are considered as instances of E51 Contact Point to that E39 Actor.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E51_Contact_Point"></see></summary>
    let E51_Contact_Point =
        Namespaced_IRI.parse _namespace_name "E51_Contact_Point" |> NamespacedName

    /// <summary>
    /// This class comprises areas of objects referred to in terms specific to the general geometry or structure of its kind.
    /// The 'prow' of the boat, the 'frame' of the picture, the 'front' of the building are all instances of E46 Section Definition. The class highlights the fact that parts of objects can be treated as locations. This holds in particular for features without natural boundaries, such as the “head” of a marble statue made out of one block (cf. E53 Place). In answer to the question 'where is the signature?' one might reply 'on the lower left corner'. (Section Definition is closely related to the term “segment” in Gerstl, P.&amp; Pribbenow, S, 1996 “ A conceptual theory of part – whole relations and its applications”, Data &amp; Knowledge 	Engineering 20 305-322, North Holland- Elsevier ).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E46_Section_Definition"></see></summary>
    let E46_Section_Definition =
        Namespaced_IRI.parse _namespace_name "E46_Section_Definition" |> NamespacedName

    /// <summary>
    /// This class comprises the textual or numeric information required to locate specific instances of E53 Place within schemes of spatial identification.
    ///
    /// Coordinates are a specific form of E44 Place Appellation, that is, a means of referring to a particular E53 Place. Coordinates are not restricted to longitude, latitude and altitude. Any regular system of reference that maps onto an E19 Physical Object can be used to generate coordinates.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E47_Spatial_Coordinates"></see></summary>
    let E47_Spatial_Coordinates =
        Namespaced_IRI.parse _namespace_name "E47_Spatial_Coordinates" |> NamespacedName

    /// <summary>
    /// This class comprises particular and common forms of E44 Place Appellation.
    /// Place Names may change their application over time: the name of an E53 Place may change, and a name may be reused for a different E53 Place. Instances of E48 Place Name are typically subject to place name gazetteers.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E48_Place_Name"></see></summary>
    let E48_Place_Name =
        Namespaced_IRI.parse _namespace_name "E48_Place_Name" |> NamespacedName

    /// <summary>
    /// This class comprises all forms of names or codes, such as historical periods, and dates, which are characteristically used to refer to a specific E52 Time-Span.
    /// The instances of E49 Time Appellation may vary in their degree of precision, and they may be relative to other time frames, “Before Christ” for example. Instances of E52 Time-Span are often defined by reference to a cultural period or an event e.g. ‘the duration of the Ming Dynasty’.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E49_Time_Appellation"></see></summary>
    let E49_Time_Appellation =
        Namespaced_IRI.parse _namespace_name "E49_Time_Appellation" |> NamespacedName

    /// <summary>
    /// 	This class comprises sets of coherent phenomena or cultural manifestations bounded in time and space.
    /// It is the social or physical coherence of these phenomena that identify an E4 Period and not the associated spatio-temporal bounds. These bounds are a mere approximation of the actual process of growth, spread and retreat. Consequently, different periods can overlap and coexist in time and space, such as when a nomadic culture exists in the same area as a sedentary culture.
    /// Typically this class is used to describe prehistoric or historic periods such as the “Neolithic Period”, the “Ming Dynasty” or the “McCarthy Era”. There are however no assumptions about the scale of the associated phenomena. In particular all events are seen as synthetic processes consisting of coherent phenomena. Therefore E4 Period is a superclass of E5 Event. For example, a modern clinical E67 Birth can be seen as both an atomic E5 Event and as an E4 Period that consists of multiple activities performed by multiple instances of E39 Actor.
    /// There are two different conceptualisations of ‘artistic style’, defined either by physical features or by historical context. For example, “Impressionism” can be viewed as a period lasting from approximately 1870 to 1905 during which paintings with particular characteristics were produced by a group of artists that included (among others) Monet, Renoir, Pissarro, Sisley and Degas. Alternatively, it can be regarded as a style applicable to all paintings sharing the characteristics of the works produced by the Impressionist painters, regardless of historical context. The first interpretation is an E4 Period, and the second defines morphological object types that fall under E55 Type.
    /// Another specific case of an E4 Period is the set of activities and phenomena associated with a settlement, such as the populated period of Nineveh.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E4_Period"></see></summary>
    let E4_Period = Namespaced_IRI.parse _namespace_name "E4_Period" |> NamespacedName
    /// <summary>
    /// This class comprises specific forms of E49 Time Appellation.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E50_Date"></see></summary>
    let E50_Date = Namespaced_IRI.parse _namespace_name "E50_Date" |> NamespacedName

    /// <summary>
    /// This class comprises abstract temporal extents, in the sense of Galilean physics, having a beginning, an end and a duration.
    /// Time Span has no other semantic connotations. Time-Spans are used to define the temporal extent of instances of E4 Period, E5 Event and any other phenomena valid for a certain time. An E52 Time-Span may be identified by one or more instances of E49 Time Appellation.
    /// Since our knowledge of history is imperfect, instances of E52 Time-Span can best be considered as approximations of the actual Time-Spans of temporal entities. The properties of E52 Time-Span are intended to allow these approximations to be expressed precisely.  An extreme case of approximation, might, for example, define an E52 Time-Span having unknown beginning, end and duration. Used as a common E52 Time-Span for two events, it would nevertheless define them as being simultaneous, even if nothing else was known.
    /// 	Automatic processing and querying of instances of E52 Time-Span is facilitated if data can be parsed into an E61 Time Primitive.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E52_Time-Span"></see></summary>
    let ``E52_Time-Span`` =
        Namespaced_IRI.parse _namespace_name "E52_Time-Span" |> NamespacedName

    /// <summary>
    /// This class comprises extents in space, in particular on the surface of the earth, in the pure sense of physics: independent from temporal phenomena and matter.
    /// The instances of E53 Place are usually determined by reference to the position of “immobile” objects such as buildings, cities, mountains, rivers, or dedicated geodetic marks. A Place can be determined by combining a frame of reference and a location with respect to this frame. It may be identified by one or more instances of E44 Place Appellation.
    ///  It is sometimes argued that instances of E53 Place are best identified by global coordinates or absolute reference systems. However, relative references are often more relevant in the context of cultural documentation and tend to be more precise. In particular, we are often interested in position in relation to large, mobile objects, such as ships. For example, the Place at which Nelson died is known with reference to a large mobile object – H.M.S Victory. A resolution of this Place in terms of absolute coordinates would require knowledge of the movements of the vessel and the precise time of death, either of which may be revised, and the result would lack historical and cultural relevance.
    /// Any object can serve as a frame of reference for E53 Place determination. The model foresees the notion of a "section" of an E19 Physical Object as a valid E53 Place determination.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E53_Place"></see></summary>
    let E53_Place = Namespaced_IRI.parse _namespace_name "E53_Place" |> NamespacedName

    /// <summary>
    /// This class comprises quantifiable properties that can be measured by some calibrated means and can be approximated by values, i.e. points or regions in a mathematical or conceptual space, such as natural or real numbers, RGB values etc.
    /// An instance of E54 Dimension represents the true quantity, independent from its numerical approximation, e.g. in inches or in cm. The properties of the class E54 Dimension allow for expressing the numerical approximation of the values of an instance of E54 Dimension. If the true values belong to a non-discrete space, such as spatial distances, it is recommended to record them as approximations by intervals or regions of indeterminacy enclosing the assumed true values. For instance, a length of 5 cm may be recorded as 4.5-5.5 cm, according to the precision of the respective observation. Note, that interoperability of values described in different units depends critically on the representation as value regions.
    /// Numerical approximations in archaic instances of E58 Measurement Unit used in historical records should be preserved. Equivalents corresponding to current knowledge should be recorded as additional instances of E54 Dimension as appropriate.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E54_Dimension"></see></summary>
    let E54_Dimension =
        Namespaced_IRI.parse _namespace_name "E54_Dimension" |> NamespacedName

    /// <summary>
    /// This class comprises concepts denoted by terms from thesauri and controlled vocabularies used to characterize and classify instances of CRM classes. Instances of E55 Type represent concepts  in contrast to instances of E41 Appellation which are used to name instances of CRM classes.
    /// E55 Type is the CRM’s interface to domain specific ontologies and thesauri. These can be represented in the CRM as subclasses of E55 Type, forming hierarchies of terms, i.e. instances of E55 Type linked via P127 has broader  term (has narrower term). Such hierarchies may be extended with additional properties.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E55_Type"></see></summary>
    let E55_Type = Namespaced_IRI.parse _namespace_name "E55_Type" |> NamespacedName

    /// <summary>
    /// This class is a specialization of E55 Type and comprises the natural languages in the sense of concepts.
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E56 Language, e.g.: “instances of  Mandarin Chinese”.
    /// It is recommended that internationally or nationally agreed codes and terminology are used to denote instances of E56 Language, such as those defined in ISO 639:1988.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E56_Language"></see></summary>
    let E56_Language =
        Namespaced_IRI.parse _namespace_name "E56_Language" |> NamespacedName

    /// <summary>
    /// This class is a specialization of E55 Type and comprises the concepts of materials.
    /// Instances of E57 Material may denote properties of matter before its use, during its use, and as incorporated in an object, such as ultramarine powder, tempera paste, reinforced concrete. Discrete pieces of raw-materials kept in museums, such as bricks, sheets of fabric, pieces of metal, should be modelled individually in the same way as other objects. Discrete used or processed pieces, such as the stones from Nefer Titi's temple, should be modelled as parts (cf. P46 is composed of).
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E57 Material, e.g.: “instances of  gold”.
    /// It is recommended that internationally or nationally agreed codes and terminology are used.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E57_Material"></see></summary>
    let E57_Material =
        Namespaced_IRI.parse _namespace_name "E57_Material" |> NamespacedName

    /// <summary>
    /// This class is a specialization of E55 Type and comprises the types of measurement units: feet, inches, centimetres, litres, lumens, etc.
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E58 Measurement Unit, e.g.: “instances of cm”.
    /// Syst?me International (SI) units or internationally recognized non-SI terms should be used whenever possible. (ISO 1000:1992). Archaic Measurement Units used in historical records should be preserved.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E58_Measurement_Unit"></see></summary>
    let E58_Measurement_Unit =
        Namespaced_IRI.parse _namespace_name "E58_Measurement_Unit" |> NamespacedName

    /// <summary>
    /// This class comprises changes of states in cultural, social or physical systems, regardless of scale, brought about by a series or group of coherent physical, cultural, technological or legal phenomena. Such changes of state will affect instances of E77 Persistent Item or its subclasses.
    /// The distinction between an E5 Event and an E4 Period is partly a question of the scale of observation. Viewed at a coarse level of detail, an E5 Event is an ‘instantaneous’ change of state. At a fine level, the E5 Event can be analysed into its component phenomena within a space and time frame, and as such can be seen as an E4 Period. The reverse is not necessarily the case: not all instances of E4 Period give rise to a noteworthy change of state.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E5_Event"></see></summary>
    let E5_Event = Namespaced_IRI.parse _namespace_name "E5_Event" |> NamespacedName

    /// <summary>
    /// This class comprises events that end the existence of any E77 Persistent Item.
    /// It may be used for temporal reasoning about things (physical items, groups of people, living beings) ceasing to exist; it serves as a hook for determination of a terminus postquem and antequem. In cases where substance from a Persistent Item continues to exist in a new form, the process would be documented by E81 Transformation.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E64_End_of_Existence"></see></summary>
    let E64_End_of_Existence =
        Namespaced_IRI.parse _namespace_name "E64_End_of_Existence" |> NamespacedName

    /// <summary>
    /// This class comprises events that result in the creation of conceptual items or immaterial products, such as legends, poems, texts, music, images, movies, laws, types etc.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E65_Creation"></see></summary>
    let E65_Creation =
        Namespaced_IRI.parse _namespace_name "E65_Creation" |> NamespacedName

    /// <summary>
    /// This class comprises events that result in the formation of a formal or informal E74 Group of people, such as a club, society, association, corporation or nation.
    /// E66 Formation does not include the arbitrary aggregation of people who do not act as a collective.
    /// The formation of an instance of E74 Group does not mean that the group is populated with members at the time of formation. In order to express the joining of members at the time of formation, the respective activity should be simultaneously an instance of both E66 Formation and E85 Joining.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E66_Formation"></see></summary>
    let E66_Formation =
        Namespaced_IRI.parse _namespace_name "E66_Formation" |> NamespacedName

    /// <summary>
    /// This class comprises the births of human beings. E67 Birth is a biological event focussing on the context of people coming into life. (E63 Beginning of Existence comprises the coming into life of any living beings).
    /// Twins, triplets etc. are brought into life by the same E67 Birth event. The introduction of the E67 Birth event as a documentation element allows the description of a range of family relationships in a simple model. Suitable extensions may describe more details and the complexity of motherhood with the intervention of modern medicine. In this model, the biological father is not seen as a necessary participant in the E67 Birth event.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E67_Birth"></see></summary>
    let E67_Birth = Namespaced_IRI.parse _namespace_name "E67_Birth" |> NamespacedName

    /// <summary>
    /// This class comprises the events that result in the formal or informal termination of an E74 Group of people.
    /// If the dissolution was deliberate, the Dissolution event should also be instantiated as an E7 Activity.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E68_Dissolution"></see></summary>
    let E68_Dissolution =
        Namespaced_IRI.parse _namespace_name "E68_Dissolution" |> NamespacedName

    /// <summary>
    /// This class comprises the deaths of human beings.
    /// If a person is killed, their death should be instantiated as E69 Death and as E7 Activity. The death or perishing of other living beings should be documented using E64 End of Existence.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E69_Death"></see></summary>
    let E69_Death = Namespaced_IRI.parse _namespace_name "E69_Death" |> NamespacedName

    /// <summary>
    /// This class comprises events that destroy one or more instances of E18 Physical Thing such that they lose their identity as the subjects of documentation.
    /// Some destruction events are intentional, while others are independent of human activity. Intentional destruction may be documented by classifying the event as both an E6 Destruction and E7 Activity.
    /// The decision to document an object as destroyed, transformed or modified is context sensitive:
    /// 1.  If the matter remaining from the destruction is not documented, the event is modelled solely as E6 Destruction.
    /// 2. An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the original. In this case, the new items have separate identities. Matter is preserved, but identity is not.
    /// 3. When the initial identity of the changed instance of E18 Physical Thing is preserved, the event should be documented as E11 Modification.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E6_Destruction"></see></summary>
    let E6_Destruction =
        Namespaced_IRI.parse _namespace_name "E6_Destruction" |> NamespacedName

    /// <summary>
    /// This general class comprises usable discrete, identifiable, instances of E77 Persistent Item that are documented as single units.
    ///
    /// They can be either intellectual products or physical things, and are characterized by relative stability. They may for instance either have a solid physical form, an electronic encoding, or they may be logical concept or structure.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E70_Thing"></see></summary>
    let E70_Thing = Namespaced_IRI.parse _namespace_name "E70_Thing" |> NamespacedName

    /// <summary>
    /// This class comprises all appellations specific to intellectual products or standardized patterns.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E75_Conceptual_Object_Appellation"></see></summary>
    let E75_Conceptual_Object_Appellation =
        Namespaced_IRI.parse _namespace_name "E75_Conceptual_Object_Appellation" |> NamespacedName

    /// <summary>
    /// This class comprises aggregations of instances of E18 Physical Thing that are assembled and maintained (“curated” and “preserved,” in museological terminology) by one or more instances of E39 Actor over time for a specific purpose and audience, and according to a particular collection development plan.
    /// Items may be added or removed from an E78 Collection in pursuit of this plan. This class should not be confused with the E39 Actor maintaining the E78 Collection often referred to with the name of the E78 Collection (e.g. “The Wallace Collection decided…”).
    /// Collective objects in the general sense, like a tomb full of gifts, a folder with stamps or a set of chessmen, should be documented as instances of E19 Physical Object, and not as instances of E78 Collection. This is because they form wholes either because they are physically bound together or because they are kept together for their functionality.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E78_Collection"></see></summary>
    let E78_Collection =
        Namespaced_IRI.parse _namespace_name "E78_Collection" |> NamespacedName

    /// <summary>
    /// This class comprises activities that result in an instance of E24 Physical Man-Made Thing being increased, enlarged or augmented by the addition of a part.
    /// Typical scenarios include the attachment of an accessory, the integration of a component, the addition of an element to an aggregate object, or the accessioning of an object into a curated E78 Collection. Objects to which parts are added are, by definition, man-made, since the addition of a part implies a human activity. Following the addition of parts, the resulting man-made assemblages are treated objectively as single identifiable wholes, made up of constituent or component parts bound together either physically (for example the engine becoming a part of the car), or by sharing a common purpose (such as the 32 chess pieces that make up a chess set). This class of activities forms a basis for reasoning about the history and continuity of identity of objects that are integrated into other objects over time, such as precious gemstones being repeatedly incorporated into different items of jewellery, or cultural artifacts being added to different museum instances of E78 Collection over their lifespan.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E79_Part_Addition"></see></summary>
    let E79_Part_Addition =
        Namespaced_IRI.parse _namespace_name "E79_Part_Addition" |> NamespacedName

    /// <summary>
    /// This class comprises the activities that result in an instance of E18 Physical Thing being decreased by the removal of a part.
    /// Typical scenarios include the detachment of an accessory, the removal of a component or part of a composite object, or the deaccessioning of an object from a curated E78 Collection. If the E80 Part Removal results in the total decomposition of the original object into pieces, such that the whole ceases to exist, the activity should instead be modelled as an E81 Transformation, i.e. a simultaneous destruction and production. In cases where the part removed has no discernible identity prior to its removal but does have an identity subsequent to its removal, the activity should be regarded as both E80 Part Removal and E12 Production. This class of activities forms a basis for reasoning about the history, and continuity of identity over time, of objects that are removed from other objects, such as precious gemstones being extracted from different items of jewelry, or cultural artifacts being deaccessioned from different museum collections over their lifespan.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E80_Part_Removal"></see></summary>
    let E80_Part_Removal =
        Namespaced_IRI.parse _namespace_name "E80_Part_Removal" |> NamespacedName

    /// <summary>
    /// This class comprises the events that result in the simultaneous destruction of one or more than one E77 Persistent Item and the creation of one or more than one E77 Persistent Item that preserves recognizable substance from the first one(s) but has fundamentally different nature and identity.
    /// Although the old and the new instances of E77 Persistent Item are treated as discrete entities having separate, unique identities, they are causally connected through the E81 Transformation; the destruction of the old E77 Persistent Item(s) directly causes the creation of the new one(s) using or preserving some relevant substance. Instances of E81 Transformation are therefore distinct from re-classifications (documented using E17 Type Assignment) or modifications (documented using E11 Modification) of objects that do not fundamentally change their nature or identity. Characteristic cases are reconstructions and repurposing of historical buildings or ruins, fires leaving buildings in ruins, taxidermy of specimen in natural history and the reorganization of a corporate body into a new one.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E81_Transformation"></see></summary>
    let E81_Transformation =
        Namespaced_IRI.parse _namespace_name "E81_Transformation" |> NamespacedName

    /// <summary>
    /// This class comprises any sort of name, number, code or symbol characteristically used to identify an E39 Actor.
    /// An E39 Actor will typically have more than one E82 Actor Appellation, and instances of E82 Actor Appellation in turn may have alternative representations. The distinction between corporate and personal names, which is particularly important in library applications, should be made by explicitly linking the E82 Actor Appellation to an instance of either E21 Person or E74 Group/E40 Legal Body. If this is not possible, the distinction can be made through the use of the P2 has type mechanism.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E82_Actor_Appellation"></see></summary>
    let E82_Actor_Appellation =
        Namespaced_IRI.parse _namespace_name "E82_Actor_Appellation" |> NamespacedName

    /// <summary>
    /// This class comprises activities formally defining new types of items.
    /// It is typically a rigorous scholarly or scientific process that ensures a type is exhaustively described and appropriately named. In some cases, particularly in archaeology and the life sciences, E83 Type Creation requires the identification of an exemplary specimen and the publication of the type definition in an appropriate scholarly forum. The activity of E83 Type Creation is central to research in the life sciences, where a type would be referred to as a “taxon,” the type description as a “protologue,” and the exemplary specimens as “orgininal element” or “holotype”.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E83_Type_Creation"></see></summary>
    let E83_Type_Creation =
        Namespaced_IRI.parse _namespace_name "E83_Type_Creation" |> NamespacedName

    /// <summary>
    /// This class comprises all instances of E22 Man-Made Object that are explicitly designed to act as persistent physical carriers for instances of E73 Information Object.
    /// This allows a relationship to be asserted between an E19 Physical Object and its immaterial information contents. An E84 Information Carrier may or may not contain information, e.g., a diskette. Note that any E18 Physical Thing may carry information, such as an E34 Inscription. However, unless it was specifically designed for this purpose, it is not an Information Carrier. Therefore the property P128 carries (is carried by) applies to E18 Physical Thing in general.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E84_Information_Carrier"></see></summary>
    let E84_Information_Carrier =
        Namespaced_IRI.parse _namespace_name "E84_Information_Carrier" |> NamespacedName

    /// <summary>
    /// This class comprises the activities that result in an instance of E39 Actor becoming a member of an instance of E74 Group. This class does not imply initiative by either party.
    /// Typical scenarios include becoming a member of a social organisation, becoming employee of a company, marriage, the adoption of a child by a family and the inauguration of somebody into an official position.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E85_Joining"></see></summary>
    let E85_Joining =
        Namespaced_IRI.parse _namespace_name "E85_Joining" |> NamespacedName

    /// <summary>
    /// This class comprises the activities that result in an instance of E39 Actor to be disassociated from an instance of E74 Group. This class does not imply initiative by either party.
    /// Typical scenarios include the termination of membership in a social organisation, ending the employment at a company, divorce, and the end of tenure of somebody in an official position.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E86_Leaving"></see></summary>
    let E86_Leaving =
        Namespaced_IRI.parse _namespace_name "E86_Leaving" |> NamespacedName

    /// <summary>
    /// This class comprises the activities that result in the continuity of management and the preservation and evolution of instances of E78 Collection, following an implicit or explicit curation plan.
    /// It specializes the notion of activity into the curation of a collection and allows the history of curation to be recorded.
    /// Items are accumulated and organized following criteria like subject, chronological period, material type, style of art etc. and can be added or removed from an E78 Collection for a specific purpose and/or audience. The initial aggregation of items of a collection is regarded as an instance of E12 Production Event while the activity of evolving, preserving and promoting a collection is regarded as an instance of E87 Curation Activity.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E87_Curation_Activity"></see></summary>
    let E87_Curation_Activity =
        Namespaced_IRI.parse _namespace_name "E87_Curation_Activity" |> NamespacedName

    /// <summary>
    /// This class comprises transfers of legal ownership from one or more instances of E39 Actor to one or more other instances of E39 Actor.
    /// The class also applies to the establishment or loss of ownership of instances of E18 Physical Thing. It does not, however, imply changes of any other kinds of right. The recording of the donor and/or recipient is optional. It is possible that in an instance of E8 Acquisition there is either no donor or no recipient. Depending on the circumstances, it may describe:
    /// 1.	the beginning of ownership
    /// 2.	the end of ownership
    /// 3.	the transfer of ownership
    /// 4.	the acquisition from an unknown source
    /// 5.	the loss of title due to destruction of the item
    /// It may also describe events where a collector appropriates legal title, for example by annexation or field collection. The interpretation of the museum notion of "accession" differs between institutions. The CRM therefore models legal ownership (E8 Acquisition) and physical custody (E10 Transfer of Custody) separately. Institutions will then model their specific notions of accession and deaccession as combinations of these.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E8_Acquisition"></see></summary>
    let E8_Acquisition =
        Namespaced_IRI.parse _namespace_name "E8_Acquisition" |> NamespacedName

    /// <summary>
    /// This class comprises changes of the physical location of the instances of E19 Physical Object.
    /// Note, that the class E9 Move inherits the property P7 took place at (witnessed): E53 Place. This property should be used to describe the trajectory or a larger area within which a move takes place, whereas the properties P26 moved to (was destination of), P27 moved from (was origin of) describe the start and end points only. Moves may also be documented to consist of other moves (via P9 consists of (forms part of)), in order to describe intermediate stages on a trajectory. In that case, start and end points of the partial moves should match appropriately between each other and with the overall event.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/E9_Move"></see></summary>
    let E9_Move = Namespaced_IRI.parse _namespace_name "E9_Move" |> NamespacedName

    /// <summary>
    /// This property property links an E69 Death event to the E21 Person that died.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P100_was_death_of"></see></summary>
    let P100_was_death_of =
        Namespaced_IRI.parse _namespace_name "P100_was_death_of" |> NamespacedName

    /// <summary>
    /// This property allows an E64 End of Existence event to be linked to the E77 Persistent Item taken out of existence by it.
    /// In the case of immaterial things, the E64 End of Existence is considered to take place with the destruction of the last physical carrier.
    /// This allows an “end” to be attached to any Persistent Item being documented i.e. E70 Thing, E72 Legal Object, E39 Actor, E41 Appellation, E51 Contact Point and E55 Type. For many Persistent Items we know the maximum life-span and can infer, that they must have ended to exist. We assume in that case an End of Existence, which may be as unnoticeable as forgetting the secret knowledge by the last representative of some indigenous nation.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P93_took_out_of_existence"></see></summary>
    let P93_took_out_of_existence =
        Namespaced_IRI.parse _namespace_name "P93_took_out_of_existence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P100i_died_in"></see>
    /// </summary>
    let P100i_died_in =
        Namespaced_IRI.parse _namespace_name "P100i_died_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P93i_was_taken_out_of_existence_by"></see>
    /// </summary>
    let P93i_was_taken_out_of_existence_by =
        Namespaced_IRI.parse _namespace_name "P93i_was_taken_out_of_existence_by" |> NamespacedName

    /// <summary>
    /// This property links an instance of E70 Thing to an E55 Type of usage.
    /// It allows the relationship between particular things, both physical and immaterial, and general methods and techniques of use to be documented. Thus it can be asserted that a baseball bat had a general use for sport and a specific use for threatening people during the Great Train Robbery.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P101_had_as_general_use"></see></summary>
    let P101_had_as_general_use =
        Namespaced_IRI.parse _namespace_name "P101_had_as_general_use" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P101i_was_use_of"></see>
    /// </summary>
    let P101i_was_use_of =
        Namespaced_IRI.parse _namespace_name "P101i_was_use_of" |> NamespacedName

    /// <summary>
    /// This property describes the E35 Title applied to an instance of E71 Man-Made Thing. The E55 Type of Title is assigned in a sub property.
    /// The P102.1 has type property of the P102 has title (is title of) property enables the relationship between the Title and the thing to be further clarified, for example, if the Title was a given Title, a supplied Title etc.
    /// It allows any man-made material or immaterial thing to be given a Title. It is possible to imagine a Title being created without a specific object in mind.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P102_has_title"></see></summary>
    let P102_has_title =
        Namespaced_IRI.parse _namespace_name "P102_has_title" |> NamespacedName

    /// <summary>
    /// This property describes the naming or identification of any real world item by a name or any other identifier.
    /// This property is intended for identifiers in general use, which form part of the world the model intends to describe, and not merely for internal database identifiers which are specific to a technical system, unless these latter also have a more general use outside the technical context. This property includes in particular identification by mathematical expressions such as coordinate systems used for the identification of instances of E53 Place. The property does not reveal anything about when, where and by whom this identifier was used. A more detailed representation can be made using the fully developed (i.e. indirect) path through E15 Identifier Assignment.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P1_is_identified_by"></see></summary>
    let P1_is_identified_by =
        Namespaced_IRI.parse _namespace_name "P1_is_identified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P102i_is_title_of"></see>
    /// </summary>
    let P102i_is_title_of =
        Namespaced_IRI.parse _namespace_name "P102i_is_title_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P1i_identifies"></see>
    /// </summary>
    let P1i_identifies =
        Namespaced_IRI.parse _namespace_name "P1i_identifies" |> NamespacedName

    /// <summary>
    /// This property links an instance of E71 Man-Made Thing to an E55 Type of usage.
    /// It creates a property between specific man-made things, both physical and immaterial, to Types of intended methods and techniques of use. Note: A link between specific man-made things and a specific use activity should be expressed using P19 was intended use of (was made for).
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P103_was_intended_for"></see></summary>
    let P103_was_intended_for =
        Namespaced_IRI.parse _namespace_name "P103_was_intended_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P103i_was_intention_of"></see>
    /// </summary>
    let P103i_was_intention_of =
        Namespaced_IRI.parse _namespace_name "P103i_was_intention_of" |> NamespacedName

    /// <summary>
    /// This property links a particular E72 Legal Object to the instances of E30 Right to which it is subject.
    /// The Right is held by an E39 Actor as described by P75 possesses (is possessed by).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P104_is_subject_to"></see></summary>
    let P104_is_subject_to =
        Namespaced_IRI.parse _namespace_name "P104_is_subject_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P104i_applies_to"></see>
    /// </summary>
    let P104i_applies_to =
        Namespaced_IRI.parse _namespace_name "P104i_applies_to" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor who holds the instances of E30 Right to an E72 Legal Object.
    /// 	It is a superproperty of P52 has current owner (is current owner of) because ownership is a right that is held on the owned object.
    /// P105 right held by (has right on) is a shortcut of the fully developed path from E72 Legal Object through P104 is subject to (applies to), E30 Right, P75 possesses (is possessed by) to E39 Actor.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P105_right_held_by"></see></summary>
    let P105_right_held_by =
        Namespaced_IRI.parse _namespace_name "P105_right_held_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P105i_has_right_on"></see>
    /// </summary>
    let P105i_has_right_on =
        Namespaced_IRI.parse _namespace_name "P105i_has_right_on" |> NamespacedName

    /// <summary>
    /// This property associates an instance of E90 Symbolic Object with a part of it that is by itself an instance of E90 Symbolic Object, such as fragments of texts or clippings from an image.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P106_is_composed_of"></see></summary>
    let P106_is_composed_of =
        Namespaced_IRI.parse _namespace_name "P106_is_composed_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P106i_forms_part_of"></see>
    /// </summary>
    let P106i_forms_part_of =
        Namespaced_IRI.parse _namespace_name "P106i_forms_part_of" |> NamespacedName

    /// <summary>
    /// This property relates an E39 Actor to the E74 Group of which that E39 Actor is a member.
    /// Groups, Legal Bodies and Persons, may all be members of Groups. A Group necessarily consists of more than one member.
    /// This property is a shortcut of the more fully developed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor
    /// The property P107.1 kind of member can be used to specify the type of membership or the role the member has in the group.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P107_has_current_or_former_member"></see></summary>
    let P107_has_current_or_former_member =
        Namespaced_IRI.parse _namespace_name "P107_has_current_or_former_member" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P107i_is_current_or_former_member_of"></see>
    /// </summary>
    let P107i_is_current_or_former_member_of =
        Namespaced_IRI.parse _namespace_name "P107i_is_current_or_former_member_of" |> NamespacedName

    /// <summary>
    /// This property identifies the E24 Physical Man-Made Thing that came into existence as a result of an E12 Production.
    /// The identity of an instance of E24 Physical Man-Made Thing is not defined by its matter, but by its existence as a subject of documentation. An E12 Production can result in the creation of multiple instances of E24 Physical Man-Made Thing.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P108_has_produced"></see></summary>
    let P108_has_produced =
        Namespaced_IRI.parse _namespace_name "P108_has_produced" |> NamespacedName

    /// <summary>
    /// This property identifies the E24 Physical Man-Made Thing modified in an E11 Modification.
    /// If a modification is applied to a non-man-made object, it is regarded as an E22 Man-Made Object from that time onwards.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P31_has_modified"></see></summary>
    let P31_has_modified =
        Namespaced_IRI.parse _namespace_name "P31_has_modified" |> NamespacedName

    /// <summary>
    /// This property allows an E63 Beginning of Existence event to be linked to the E77 Persistent Item brought into existence by it.
    /// It allows a “start” to be attached to any Persistent Item being documented i.e. E70 Thing, E72 Legal Object, E39 Actor, E41 Appellation, E51 Contact Point and E55 Type
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P92_brought_into_existence"></see></summary>
    let P92_brought_into_existence =
        Namespaced_IRI.parse _namespace_name "P92_brought_into_existence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P108i_was_produced_by"></see>
    /// </summary>
    let P108i_was_produced_by =
        Namespaced_IRI.parse _namespace_name "P108i_was_produced_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P31i_was_modified_by"></see>
    /// </summary>
    let P31i_was_modified_by =
        Namespaced_IRI.parse _namespace_name "P31i_was_modified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P92i_was_brought_into_existence_by"></see>
    /// </summary>
    let P92i_was_brought_into_existence_by =
        Namespaced_IRI.parse _namespace_name "P92i_was_brought_into_existence_by" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor or Actors who assume or have assumed overall curatorial responsibility for an E78 Collection.
    /// This property is effectively a short-cut. It does not allow a history of curation to be recorded. This would require use of an Event assigning responsibility for a Collection to a curator.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P109_has_current_or_former_curator"></see></summary>
    let P109_has_current_or_former_curator =
        Namespaced_IRI.parse _namespace_name "P109_has_current_or_former_curator" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor or Actors who have or have had custody of an instance of E18 Physical Thing at some time.
    /// The distinction with P50 has current keeper (is current keeper of) is that P49 has former or current keeper (is former or current keeper of) leaves open the question as to whether the specified keepers are current.
    /// P49 has former or current keeper (is former or current keeper of) is a shortcut for the more detailed path from E18 Physical Thing through P30 transferred custody of (custody transferred through), E10 Transfer of Custody, P28 custody surrendered by (surrendered custody through) or P29 custody received by (received custody through) to E39 Actor.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P49_has_former_or_current_keeper"></see></summary>
    let P49_has_former_or_current_keeper =
        Namespaced_IRI.parse _namespace_name "P49_has_former_or_current_keeper" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P109i_is_current_or_former_curator_of"></see>
    /// </summary>
    let P109i_is_current_or_former_curator_of =
        Namespaced_IRI.parse _namespace_name "P109i_is_current_or_former_curator_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P49i_is_former_or_current_keeper_of"></see>
    /// </summary>
    let P49i_is_former_or_current_keeper_of =
        Namespaced_IRI.parse _namespace_name "P49i_is_former_or_current_keeper_of" |> NamespacedName

    /// <summary>
    /// This property describes an instance of E4 Period, which falls within the E53 Place and E52 Time-Span of another.
    /// The difference with P9 consists of (forms part of) is subtle. Unlike P9 consists of (forms part of), P10 falls within (contains) does not imply any logical connection between the two periods and it may refer to a period of a completely different type.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P10_falls_within"></see></summary>
    let P10_falls_within =
        Namespaced_IRI.parse _namespace_name "P10_falls_within" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P10i_contains"></see>
    /// </summary>
    let P10i_contains =
        Namespaced_IRI.parse _namespace_name "P10i_contains" |> NamespacedName

    /// <summary>
    /// This property identifies the E24 Physical Man-Made Thing that is added to (augmented) in an E79 Part Addition.
    /// Although a Part Addition event normally concerns only one item of Physical Man-Made Thing, it is possible to imagine circumstances under which more than one item might be added to (augmented). For example, the artist Jackson Pollock trailing paint onto multiple canvasses.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P110_augmented"></see></summary>
    let P110_augmented =
        Namespaced_IRI.parse _namespace_name "P110_augmented" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P110i_was_augmented_by"></see>
    /// </summary>
    let P110i_was_augmented_by =
        Namespaced_IRI.parse _namespace_name "P110i_was_augmented_by" |> NamespacedName

    /// <summary>
    /// This property identifies the E18 Physical Thing that is added during an E79 Part Addition activity
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P111_added"></see></summary>
    let P111_added = Namespaced_IRI.parse _namespace_name "P111_added" |> NamespacedName

    /// <summary>
    /// This property describes the use of material or immaterial things in a way essential to the performance or the outcome of an E7 Activity.
    /// This property typically applies to tools, instruments, moulds, raw materials and items embedded in a product. It implies that the presence of the object in question was a necessary condition for the action. For example, the activity of writing this text required the use of a computer. An immaterial thing can be used if at least one of its carriers is present. For example, the software tools on a computer.
    /// Another example is the use of a particular name by a particular group of people over some span to identify a thing, such as a settlement. In this case, the physical carriers of this name are at least the people understanding its use.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P16_used_specific_object"></see></summary>
    let P16_used_specific_object =
        Namespaced_IRI.parse _namespace_name "P16_used_specific_object" |> NamespacedName

    /// <summary>
    /// This property describes the active or passive presence of an E77 Persistent Item in an E5 Event without implying any specific role.
    /// It connects the history of a thing with the E53 Place and E50 Date of an event. For example, an object may be the desk, now in a museum on which a treaty was signed. The presence of an immaterial thing implies the presence of at least one of its carriers.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P12_occurred_in_the_presence_of"></see></summary>
    let P12_occurred_in_the_presence_of =
        Namespaced_IRI.parse _namespace_name "P12_occurred_in_the_presence_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P111i_was_added_by"></see>
    /// </summary>
    let P111i_was_added_by =
        Namespaced_IRI.parse _namespace_name "P111i_was_added_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P16i_was_used_for"></see>
    /// </summary>
    let P16i_was_used_for =
        Namespaced_IRI.parse _namespace_name "P16i_was_used_for" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P12i_was_present_at"></see>
    /// </summary>
    let P12i_was_present_at =
        Namespaced_IRI.parse _namespace_name "P12i_was_present_at" |> NamespacedName

    /// <summary>
    /// This property identifies the E24 Physical Man-Made Thing that was diminished by E80 Part Removal.
    /// Although a Part removal activity normally concerns only one item of Physical Man-Made Thing, it is possible to imagine circumstances under which more than one item might be diminished by a single Part Removal activity.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P112_diminished"></see></summary>
    let P112_diminished =
        Namespaced_IRI.parse _namespace_name "P112_diminished" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P112i_was_diminished_by"></see>
    /// </summary>
    let P112i_was_diminished_by =
        Namespaced_IRI.parse _namespace_name "P112i_was_diminished_by" |> NamespacedName

    /// <summary>
    /// This property identifies the E18 Physical Thing that is removed during an E80 Part Removal activity.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P113_removed"></see></summary>
    let P113_removed =
        Namespaced_IRI.parse _namespace_name "P113_removed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P113i_was_removed_by"></see>
    /// </summary>
    let P113i_was_removed_by =
        Namespaced_IRI.parse _namespace_name "P113i_was_removed_by" |> NamespacedName

    /// <summary>
    /// This symmetric property allows the instances of E2 Temporal Entity with the same E52 Time-Span to be equated.
    /// This property is only necessary if the time span is unknown (otherwise the equivalence can be calculated).
    /// This property is the same as the "equal" relationship of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P114_is_equal_in_time_to"></see></summary>
    let P114_is_equal_in_time_to =
        Namespaced_IRI.parse _namespace_name "P114_is_equal_in_time_to" |> NamespacedName

    /// <summary>
    /// This property allows the ending point for a E2 Temporal Entity to be situated by reference to the ending point of another temporal entity of longer duration.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "finishes / finished-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P115_finishes"></see></summary>
    let P115_finishes =
        Namespaced_IRI.parse _namespace_name "P115_finishes" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P115i_is_finished_by"></see>
    /// </summary>
    let P115i_is_finished_by =
        Namespaced_IRI.parse _namespace_name "P115i_is_finished_by" |> NamespacedName

    /// <summary>
    /// This property allows the starting point for a E2 Temporal Entity to be situated by reference to the starting point of another temporal entity of longer duration.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "starts / started-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P116_starts"></see></summary>
    let P116_starts =
        Namespaced_IRI.parse _namespace_name "P116_starts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P116i_is_started_by"></see>
    /// </summary>
    let P116i_is_started_by =
        Namespaced_IRI.parse _namespace_name "P116i_is_started_by" |> NamespacedName

    /// <summary>
    /// This property allows the entire E52 Time-Span of an E2 Temporal Entity to be situated within the Time-Span of another temporal entity that starts before and ends after the included temporal entity.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "during / includes" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P117_occurs_during"></see></summary>
    let P117_occurs_during =
        Namespaced_IRI.parse _namespace_name "P117_occurs_during" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P117i_includes"></see>
    /// </summary>
    let P117i_includes =
        Namespaced_IRI.parse _namespace_name "P117i_includes" |> NamespacedName

    /// <summary>
    /// This property identifies an overlap between the instances of E52 Time-Span of two instances of E2 Temporal Entity.
    /// It implies a temporal order between the two entities: if A overlaps in time B, then A must start before B, and B must end after A. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "overlaps / overlapped-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P118_overlaps_in_time_with"></see></summary>
    let P118_overlaps_in_time_with =
        Namespaced_IRI.parse _namespace_name "P118_overlaps_in_time_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P118i_is_overlapped_in_time_by"></see>
    /// </summary>
    let P118i_is_overlapped_in_time_by =
        Namespaced_IRI.parse _namespace_name "P118i_is_overlapped_in_time_by" |> NamespacedName

    /// <summary>
    /// This property indicates that one E2 Temporal Entity immediately follows another.
    /// It implies a particular order between the two entities: if A meets in time with B, then A must precede B. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "meets / met-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P119_meets_in_time_with"></see></summary>
    let P119_meets_in_time_with =
        Namespaced_IRI.parse _namespace_name "P119_meets_in_time_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P119i_is_met_in_time_by"></see>
    /// </summary>
    let P119i_is_met_in_time_by =
        Namespaced_IRI.parse _namespace_name "P119i_is_met_in_time_by" |> NamespacedName

    /// <summary>
    /// This property describes the active or passive participation of instances of E39 Actors in an E5 Event.
    /// It connects the life-line of the related E39 Actor with the E53 Place and E50 Date of the event. The property implies that the Actor was involved in the event but does not imply any causal relationship. The subject of a portrait can be said to have participated in the creation of the portrait.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P11_had_participant"></see></summary>
    let P11_had_participant =
        Namespaced_IRI.parse _namespace_name "P11_had_participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P11i_participated_in"></see>
    /// </summary>
    let P11i_participated_in =
        Namespaced_IRI.parse _namespace_name "P11i_participated_in" |> NamespacedName

    /// <summary>
    /// This property identifies the relative chronological sequence of two temporal entities.
    /// It implies that a temporal gap exists between the end of A and the start of B. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "before / after" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P120_occurs_before"></see></summary>
    let P120_occurs_before =
        Namespaced_IRI.parse _namespace_name "P120_occurs_before" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P120i_occurs_after"></see>
    /// </summary>
    let P120i_occurs_after =
        Namespaced_IRI.parse _namespace_name "P120i_occurs_after" |> NamespacedName

    /// <summary>
    /// This symmetric property allows the instances of E53 Place with overlapping geometric extents to be associated with each other.
    /// It does not specify anything about the shared area. This property is purely spatial, in contrast to Allen operators, which are purely temporal.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P121_overlaps_with"></see></summary>
    let P121_overlaps_with =
        Namespaced_IRI.parse _namespace_name "P121_overlaps_with" |> NamespacedName

    /// <summary>
    /// This symmetric property allows the instances of E53 Place which share common borders to be related as such.
    /// This property is purely spatial, in contrast to Allen operators, which are purely temporal.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P122_borders_with"></see></summary>
    let P122_borders_with =
        Namespaced_IRI.parse _namespace_name "P122_borders_with" |> NamespacedName

    /// <summary>
    /// This property identifies the E77 Persistent Item or items that are the result of an E81 Transformation.
    /// New items replace the transformed item or items, which cease to exist as units of documentation. The physical continuity between the old and the new is expressed by the link to the common Transformation.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P123_resulted_in"></see></summary>
    let P123_resulted_in =
        Namespaced_IRI.parse _namespace_name "P123_resulted_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P123i_resulted_from"></see>
    /// </summary>
    let P123i_resulted_from =
        Namespaced_IRI.parse _namespace_name "P123i_resulted_from" |> NamespacedName

    /// <summary>
    /// This property identifies the E77 Persistent Item or items that cease to exist due to a E81 Transformation.
    /// It is replaced by the result of the Transformation, which becomes a new unit of documentation. The continuity between both items, the new and the old, is expressed by the link to the common Transformation.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P124_transformed"></see></summary>
    let P124_transformed =
        Namespaced_IRI.parse _namespace_name "P124_transformed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P124i_was_transformed_by"></see>
    /// </summary>
    let P124i_was_transformed_by =
        Namespaced_IRI.parse _namespace_name "P124i_was_transformed_by" |> NamespacedName

    /// <summary>
    /// This property defines the kind of objects used in an E7 Activity, when the specific instance is either unknown or not of interest, such as use of "a hammer".
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P125_used_object_of_type"></see></summary>
    let P125_used_object_of_type =
        Namespaced_IRI.parse _namespace_name "P125_used_object_of_type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P125i_was_type_of_object_used_in"></see>
    /// </summary>
    let P125i_was_type_of_object_used_in =
        Namespaced_IRI.parse _namespace_name "P125i_was_type_of_object_used_in" |> NamespacedName

    /// <summary>
    /// This property identifies E57 Material employed in an E11 Modification.
    /// The E57 Material used during the E11 Modification does not necessarily become incorporated into the E24 Physical Man-Made Thing that forms the subject of the E11 Modification.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P126_employed"></see></summary>
    let P126_employed =
        Namespaced_IRI.parse _namespace_name "P126_employed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P126i_was_employed_in"></see>
    /// </summary>
    let P126i_was_employed_in =
        Namespaced_IRI.parse _namespace_name "P126i_was_employed_in" |> NamespacedName

    /// <summary>
    /// This property identifies a super-Type to which an E55 Type is related.
    /// 		It allows Types to be organised into hierarchies. This is the sense of "broader term generic  		(BTG)" as defined in ISO 2788
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P127_has_broader_term"></see></summary>
    let P127_has_broader_term =
        Namespaced_IRI.parse _namespace_name "P127_has_broader_term" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P127i_has_narrower_term"></see>
    /// </summary>
    let P127i_has_narrower_term =
        Namespaced_IRI.parse _namespace_name "P127i_has_narrower_term" |> NamespacedName

    /// <summary>
    /// This property identifies an E73 Information Object carried by an instance of E24 Physical Man-Made Thing.
    /// In general this would be an E84 Information Carrier P65 shows visual item (is shown by) is a specialisation of P128 carries (is carried by) which should be used for carrying visual items.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P128_carries"></see></summary>
    let P128_carries =
        Namespaced_IRI.parse _namespace_name "P128_carries" |> NamespacedName

    /// <summary>
    /// This property generalises the notions of  "copy of" and "similar to" into a dynamic, asymmetric relationship, where the domain expresses the derivative, if such a direction can be established.
    /// Otherwise, the relationship is symmetric. It is a short-cut of P15 was influenced by (influenced) in a creation or production, if such a reason for the similarity can be verified. Moreover it expresses similarity in cases that can be stated between two objects only, without historical knowledge about its reasons.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P130_shows_features_of"></see></summary>
    let P130_shows_features_of =
        Namespaced_IRI.parse _namespace_name "P130_shows_features_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P128i_is_carried_by"></see>
    /// </summary>
    let P128i_is_carried_by =
        Namespaced_IRI.parse _namespace_name "P128i_is_carried_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P130i_features_are_also_found_on"></see>
    /// </summary>
    let P130i_features_are_also_found_on =
        Namespaced_IRI.parse _namespace_name "P130i_features_are_also_found_on" |> NamespacedName

    /// <summary>
    /// This property documents that an E89 Propositional Object has as subject an instance of E1 CRM Entity.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P129_is_about"></see></summary>
    let P129_is_about =
        Namespaced_IRI.parse _namespace_name "P129_is_about" |> NamespacedName

    /// <summary>
    /// This property documents that an E89 Propositional Object makes a statement about an instance of E1 CRM Entity. P67 refers to (is referred to by) has the P67.1 has type link to an instance of E55 Type. This is intended to allow a more detailed description of the type of reference. This differs from P129 is about (is subject of), which describes the primary subject or subjects of the E89 Propositional Object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P67_refers_to"></see></summary>
    let P67_refers_to =
        Namespaced_IRI.parse _namespace_name "P67_refers_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P129i_is_subject_of"></see>
    /// </summary>
    let P129i_is_subject_of =
        Namespaced_IRI.parse _namespace_name "P129i_is_subject_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P67i_is_referred_to_by"></see>
    /// </summary>
    let P67i_is_referred_to_by =
        Namespaced_IRI.parse _namespace_name "P67i_is_referred_to_by" |> NamespacedName

    /// <summary>
    /// This property identifies a name used specifically to identify an E39 Actor.
    /// This property is a specialisation of P1 is identified by (identifies) is identified by.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P131_is_identified_by"></see></summary>
    let P131_is_identified_by =
        Namespaced_IRI.parse _namespace_name "P131_is_identified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P131i_identifies"></see>
    /// </summary>
    let P131i_identifies =
        Namespaced_IRI.parse _namespace_name "P131i_identifies" |> NamespacedName

    /// <summary>
    /// This symmetric property allows instances of E4 Period that overlap both temporally and spatially to be related, i,e. they share some spatio-temporal extent.
    /// This property does not imply any ordering or sequence between the two periods, either spatial or temporal.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P132_overlaps_with"></see></summary>
    let P132_overlaps_with =
        Namespaced_IRI.parse _namespace_name "P132_overlaps_with" |> NamespacedName

    /// <summary>
    /// This symmetric property allows instances of E4 Period that do not overlap both temporally and spatially, to be related i,e. they do not share any spatio-temporal extent.
    /// This property does not imply any ordering or sequence between the two periods either spatial or temporal.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P133_is_separated_from"></see></summary>
    let P133_is_separated_from =
        Namespaced_IRI.parse _namespace_name "P133_is_separated_from" |> NamespacedName

    /// <summary>
    /// This property allows two activities to be related where the domain is considered as an intentional continuation of the range.
    /// Used multiple times, this allows a chain of related activities to be created which follow each other in sequence.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P134_continued"></see></summary>
    let P134_continued =
        Namespaced_IRI.parse _namespace_name "P134_continued" |> NamespacedName

    /// <summary>
    /// This is a high level property, which captures the relationship between an E7 Activity and anything that may have had some bearing upon it.
    /// The property has more specific sub properties.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P15_was_influenced_by"></see></summary>
    let P15_was_influenced_by =
        Namespaced_IRI.parse _namespace_name "P15_was_influenced_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P134i_was_continued_by"></see>
    /// </summary>
    let P134i_was_continued_by =
        Namespaced_IRI.parse _namespace_name "P134i_was_continued_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P15i_influenced"></see>
    /// </summary>
    let P15i_influenced =
        Namespaced_IRI.parse _namespace_name "P15i_influenced" |> NamespacedName

    /// <summary>
    /// This property identifies the E55 Type, which is created in an E83Type Creation activity.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P135_created_type"></see></summary>
    let P135_created_type =
        Namespaced_IRI.parse _namespace_name "P135_created_type" |> NamespacedName

    /// <summary>
    /// This property allows a conceptual E65 Creation to be linked to the E28 Conceptual Object created by it.
    /// It represents the act of conceiving the intellectual content of the E28 Conceptual Object. It does not represent the act of creating the first physical carrier of the E28 Conceptual Object. As an example, this is the composition of a poem, not its commitment to paper.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P94_has_created"></see></summary>
    let P94_has_created =
        Namespaced_IRI.parse _namespace_name "P94_has_created" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P135i_was_created_by"></see>
    /// </summary>
    let P135i_was_created_by =
        Namespaced_IRI.parse _namespace_name "P135i_was_created_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P94i_was_created_by"></see>
    /// </summary>
    let P94i_was_created_by =
        Namespaced_IRI.parse _namespace_name "P94i_was_created_by" |> NamespacedName

    /// <summary>
    /// This property identifies one or more items that were used as evidence to declare a new E55 Type.
    /// The examination of these items is often the only objective way to understand the precise characteristics of a new Type. Such items should be deposited in a museum or similar institution for that reason. The taxonomic role renders the specific relationship of each item to the Type, such as "holotype" or "original element".
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P136_was_based_on"></see></summary>
    let P136_was_based_on =
        Namespaced_IRI.parse _namespace_name "P136_was_based_on" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P136i_supported_type_creation"></see>
    /// </summary>
    let P136i_supported_type_creation =
        Namespaced_IRI.parse _namespace_name "P136i_supported_type_creation" |> NamespacedName

    /// <summary>
    /// This property allows an item to be declared as a particular example of an E55 Type or taxon
    /// 	The P137.1 in the taxonomic role property of P137 exemplifies (is exemplified by) allows differentiation of taxonomic roles. The taxonomic role renders the specific relationship of this example to the Type, such as "prototypical", "archetypical", "lectotype", etc. The taxonomic role "lectotype" is not associated with the Type Creation (E83) itself, but selected in a later phase.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P137_exemplifies"></see></summary>
    let P137_exemplifies =
        Namespaced_IRI.parse _namespace_name "P137_exemplifies" |> NamespacedName

    /// <summary>
    /// This property allows sub typing of CRM entities - a form of specialisation – through the use of a terminological hierarchy, or thesaurus.
    /// The CRM is intended to focus on the high-level entities and relationships needed to describe data structures. Consequently, it does not specialise entities any further than is required for this immediate purpose. However, entities in the isA hierarchy of the CRM may by specialised into any number of sub entities, which can be defined in the E55 Type hierarchy. E51 Contact Point, for example, may be specialised into “e-mail address”, “telephone number”, “post office box”, “URL” etc. none of which figures explicitly in the CRM hierarchy. Sub typing obviously requires consistency between the meaning of the terms assigned and the more general intent of the CRM entity in question.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P2_has_type"></see></summary>
    let P2_has_type =
        Namespaced_IRI.parse _namespace_name "P2_has_type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P137i_is_exemplified_by"></see>
    /// </summary>
    let P137i_is_exemplified_by =
        Namespaced_IRI.parse _namespace_name "P137i_is_exemplified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P2i_is_type_of"></see>
    /// </summary>
    let P2i_is_type_of =
        Namespaced_IRI.parse _namespace_name "P2i_is_type_of" |> NamespacedName

    /// <summary>
    /// This property establishes the relationship between an E36 Visual Item and the entity that it visually represents.
    /// Any entity may be represented visually. This property is part of the fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1 CRM Entity, which is shortcut by P62depicts (is depicted by). P138.1 mode of representation allows the nature of the representation to be refined.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P138_represents"></see></summary>
    let P138_represents =
        Namespaced_IRI.parse _namespace_name "P138_represents" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P138i_has_representation"></see>
    /// </summary>
    let P138i_has_representation =
        Namespaced_IRI.parse _namespace_name "P138i_has_representation" |> NamespacedName

    /// <summary>
    /// This property establishes a relationship of equivalence between two instances of E41 Appellation independent from any item identified by them. It is a dynamic asymmetric relationship, where the range expresses the derivative, if such a direction can be established. Otherwise, the relationship is symmetric. The relationship is not transitive.
    /// The equivalence applies to all cases of use of an instance of E41 Appellation. Multiple names assigned to an object, which are not equivalent for all things identified with a specific instance of E41 Appellation, should be modelled as repeated values of P1 is identified by (identifies).
    /// P139.1 has type allows the type of derivation, such as “transliteration from Latin 1 to ASCII” be refined..
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P139_has_alternative_form"></see></summary>
    let P139_has_alternative_form =
        Namespaced_IRI.parse _namespace_name "P139_has_alternative_form" |> NamespacedName

    /// <summary>
    /// This property allows specific instances of E18 Physical Thing that have been destroyed to be related to a destruction event.
    /// Destruction implies the end of an item’s life as a subject of cultural documentation – the physical matter of which the item was composed may in fact continue to exist. A destruction event may be contiguous with a Production that brings into existence a derived object composed partly of matter from the destroyed object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P13_destroyed"></see></summary>
    let P13_destroyed =
        Namespaced_IRI.parse _namespace_name "P13_destroyed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P13i_was_destroyed_by"></see>
    /// </summary>
    let P13i_was_destroyed_by =
        Namespaced_IRI.parse _namespace_name "P13i_was_destroyed_by" |> NamespacedName

    /// <summary>
    /// This property indicates the item to which an attribute or relation is assigned.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P140_assigned_attribute_to"></see></summary>
    let P140_assigned_attribute_to =
        Namespaced_IRI.parse _namespace_name "P140_assigned_attribute_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P140i_was_attributed_by"></see>
    /// </summary>
    let P140i_was_attributed_by =
        Namespaced_IRI.parse _namespace_name "P140i_was_attributed_by" |> NamespacedName

    /// <summary>
    /// This property indicates the attribute that was assigned or the item that was related to the item denoted by a property P140 assigned attribute to in an Attribute assignment action.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P141_assigned"></see></summary>
    let P141_assigned =
        Namespaced_IRI.parse _namespace_name "P141_assigned" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P141i_was_assigned_by"></see>
    /// </summary>
    let P141i_was_assigned_by =
        Namespaced_IRI.parse _namespace_name "P141i_was_assigned_by" |> NamespacedName

    /// <summary>
    /// This property associates the event of assigning an instance of E42 Identifier to an entity, with  the instances of E41 Appellation that were used as elements of the identifier.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P142_used_constituent"></see></summary>
    let P142_used_constituent =
        Namespaced_IRI.parse _namespace_name "P142_used_constituent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P142i_was_used_in"></see>
    /// </summary>
    let P142i_was_used_in =
        Namespaced_IRI.parse _namespace_name "P142i_was_used_in" |> NamespacedName

    /// <summary>
    /// This property identifies the instance of E39 Actor that becomes member of a E74 Group in an E85 Joining.
    ///  	Joining events allow for describing people becoming members of a group with a more detailed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor, compared to the shortcut offered by P107 has current or former member (is current or former member of).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P143_joined"></see></summary>
    let P143_joined =
        Namespaced_IRI.parse _namespace_name "P143_joined" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P143i_was_joined_by"></see>
    /// </summary>
    let P143i_was_joined_by =
        Namespaced_IRI.parse _namespace_name "P143i_was_joined_by" |> NamespacedName

    /// <summary>
    /// This property identifies the instance of E74 Group of which an instance of E39 Actor becomes a member through an instance of E85 Joining.
    /// Although a Joining activity normally concerns only one instance of E74 Group, it is possible to imagine circumstances under which becoming member of one Group implies becoming member of another Group as well.
    /// Joining events allow for describing people becoming members of a group with a more detailed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor, compared to the shortcut offered by P107 has current or former member (is current or former member of).
    /// The property P144.1 kind of member can be used to specify the type of membership or the role the member has in the group.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P144_joined_with"></see></summary>
    let P144_joined_with =
        Namespaced_IRI.parse _namespace_name "P144_joined_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P144i_gained_member_by"></see>
    /// </summary>
    let P144i_gained_member_by =
        Namespaced_IRI.parse _namespace_name "P144i_gained_member_by" |> NamespacedName

    /// <summary>
    /// This property identifies the instance of E39 Actor that leaves an instance of E74 Group through an instance of E86 Leaving.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P145_separated"></see></summary>
    let P145_separated =
        Namespaced_IRI.parse _namespace_name "P145_separated" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P145i_left_by"></see>
    /// </summary>
    let P145i_left_by =
        Namespaced_IRI.parse _namespace_name "P145i_left_by" |> NamespacedName

    /// <summary>
    /// This property identifies the instance of E74 Group an instance of E39 Actor leaves through an instance of E86 Leaving.
    /// Although a Leaving activity normally concerns only one instance of E74 Group, it is possible to imagine circumstances under which leaving one E74 Group implies leaving another E74 Group as well.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P146_separated_from"></see></summary>
    let P146_separated_from =
        Namespaced_IRI.parse _namespace_name "P146_separated_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P146i_lost_member_by"></see>
    /// </summary>
    let P146i_lost_member_by =
        Namespaced_IRI.parse _namespace_name "P146i_lost_member_by" |> NamespacedName

    /// <summary>
    /// This property associates an instance of E78 Collection or collections with  subject of a curation activity following some implicit or explicit curation plan.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P147_curated"></see></summary>
    let P147_curated =
        Namespaced_IRI.parse _namespace_name "P147_curated" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P147i_was_curated_by"></see>
    /// </summary>
    let P147i_was_curated_by =
        Namespaced_IRI.parse _namespace_name "P147i_was_curated_by" |> NamespacedName

    /// <summary>
    /// This property associates an instance of E89 Propositional Object with a structural part of it that is by itself an instance of E89 Propositional Object.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P148_has_component"></see></summary>
    let P148_has_component =
        Namespaced_IRI.parse _namespace_name "P148_has_component" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P148i_is_component_of"></see>
    /// </summary>
    let P148i_is_component_of =
        Namespaced_IRI.parse _namespace_name "P148i_is_component_of" |> NamespacedName

    /// <summary>
    /// This property identifies an instance of E28 Conceptual Object using an instance of E75 Conceptual Object Appellation.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P149_is_identified_by"></see></summary>
    let P149_is_identified_by =
        Namespaced_IRI.parse _namespace_name "P149_is_identified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P149i_identifies"></see>
    /// </summary>
    let P149i_identifies =
        Namespaced_IRI.parse _namespace_name "P149i_identifies" |> NamespacedName

    /// <summary>
    /// This property describes the active participation of an E39 Actor in an E7 Activity.
    /// It implies causal or legal responsibility. The P14.1 in the role of property of the property allows the nature of an Actor’s participation to be specified.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P14_carried_out_by"></see></summary>
    let P14_carried_out_by =
        Namespaced_IRI.parse _namespace_name "P14_carried_out_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P14i_performed"></see>
    /// </summary>
    let P14i_performed =
        Namespaced_IRI.parse _namespace_name "P14i_performed" |> NamespacedName

    /// <summary>
    /// This property describes an item or items that are regarded as a reason for carrying out the E7 Activity.
    /// For example, the discovery of a large hoard of treasure may call for a celebration, an order from head quarters can start a military manoeuvre.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P17_was_motivated_by"></see></summary>
    let P17_was_motivated_by =
        Namespaced_IRI.parse _namespace_name "P17_was_motivated_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P17i_motivated"></see>
    /// </summary>
    let P17i_motivated =
        Namespaced_IRI.parse _namespace_name "P17i_motivated" |> NamespacedName

    /// <summary>
    /// This property relates an E7 Activity with objects created specifically for use in the activity.
    /// This is distinct from the intended use of an item in some general type of activity such as the book of common prayer which was intended for use in Church of England services (see P101 had as general use (was use of)).
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P19_was_intended_use_of"></see></summary>
    let P19_was_intended_use_of =
        Namespaced_IRI.parse _namespace_name "P19_was_intended_use_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P19i_was_made_for"></see>
    /// </summary>
    let P19i_was_made_for =
        Namespaced_IRI.parse _namespace_name "P19i_was_made_for" |> NamespacedName

    /// <summary>
    /// This property identifies the relationship between a preparatory activity and the event it is intended to be preparation for.
    /// This includes activities, orders and other organisational actions, taken in preparation for other activities or events.
    /// P20 had specific purpose (was purpose of) implies that an activity succeeded in achieving its aim. If it does not succeed, such as the setting of a trap that did not catch anything, one may document the unrealized intention using P21 had general purpose (was purpose of):E55 Type and/or  P33 used specific technique (was used by): E29 Design or Procedure.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P20_had_specific_purpose"></see></summary>
    let P20_had_specific_purpose =
        Namespaced_IRI.parse _namespace_name "P20_had_specific_purpose" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P20i_was_purpose_of"></see>
    /// </summary>
    let P20i_was_purpose_of =
        Namespaced_IRI.parse _namespace_name "P20i_was_purpose_of" |> NamespacedName

    /// <summary>
    /// This property describes an intentional relationship between an E7 Activity and some general goal or purpose.
    /// This may involve activities intended as preparation for some type of activity or event. P21had general purpose (was purpose of) differs from P20 had specific purpose (was purpose of) in that no occurrence of an event is implied as the purpose.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P21_had_general_purpose"></see></summary>
    let P21_had_general_purpose =
        Namespaced_IRI.parse _namespace_name "P21_had_general_purpose" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P21i_was_purpose_of"></see>
    /// </summary>
    let P21i_was_purpose_of =
        Namespaced_IRI.parse _namespace_name "P21i_was_purpose_of" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor that acquires the legal ownership of an object as a result of an E8 Acquisition.
    /// The property will typically describe an Actor purchasing or otherwise acquiring an object from another Actor. However, title may also be acquired, without any corresponding loss of title by another Actor, through legal fieldwork such as hunting, shooting or fishing.
    /// In reality the title is either transferred to or from someone, or both.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P22_transferred_title_to"></see></summary>
    let P22_transferred_title_to =
        Namespaced_IRI.parse _namespace_name "P22_transferred_title_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P22i_acquired_title_through"></see>
    /// </summary>
    let P22i_acquired_title_through =
        Namespaced_IRI.parse _namespace_name "P22i_acquired_title_through" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor or Actors who relinquish legal ownership as the result of an E8 Acquisition.
    /// The property will typically be used to describe a person donating or selling an object to a museum. In reality title is either transferred to or from someone, or both.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P23_transferred_title_from"></see></summary>
    let P23_transferred_title_from =
        Namespaced_IRI.parse _namespace_name "P23_transferred_title_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P23i_surrendered_title_through"></see>
    /// </summary>
    let P23i_surrendered_title_through =
        Namespaced_IRI.parse _namespace_name "P23i_surrendered_title_through" |> NamespacedName

    /// <summary>
    /// This property identifies the E18 Physical Thing or things involved in an E8 Acquisition.
    /// In reality, an acquisition must refer to at least one transferred item.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P24_transferred_title_of"></see></summary>
    let P24_transferred_title_of =
        Namespaced_IRI.parse _namespace_name "P24_transferred_title_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P24i_changed_ownership_through"></see>
    /// </summary>
    let P24i_changed_ownership_through =
        Namespaced_IRI.parse _namespace_name "P24i_changed_ownership_through" |> NamespacedName

    /// <summary>
    /// This property identifies the E19 Physical Object that is moved during a move event.
    /// The property implies the object’s passive participation. For example, Monet’s painting “Impression sunrise” was moved for the first Impressionist exhibition in 1874.
    /// In reality, a move must concern at least one object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P25_moved"></see></summary>
    let P25_moved = Namespaced_IRI.parse _namespace_name "P25_moved" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P25i_moved_by"></see>
    /// </summary>
    let P25i_moved_by =
        Namespaced_IRI.parse _namespace_name "P25i_moved_by" |> NamespacedName

    /// <summary>
    /// This property identifies the destination of a E9 Move.
    /// A move will be linked to a destination, such as the move of an artefact from storage to display. A move may be linked to many terminal instances of E53 Places. In this case the move describes a distribution of a set of objects. The area of the move includes the origin, route and destination.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P26_moved_to"></see></summary>
    let P26_moved_to =
        Namespaced_IRI.parse _namespace_name "P26_moved_to" |> NamespacedName

    /// <summary>
    /// This property describes the spatial location of an instance of E4 Period.
    /// The related E53 Place should be seen as an approximation of the geographical area within which the phenomena that characterise the period in question occurred. P7took place at (witnessed) does not convey any meaning other than spatial positioning (generally on the surface of the earth).  For example, the period “R?volution fran?aise” can be said to have taken place in “France”, the “Victorian” period, may be said to have taken place in “Britain” and its colonies, as well as other parts of Europe and north America.
    /// A period can take place at multiple locations.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P7_took_place_at"></see></summary>
    let P7_took_place_at =
        Namespaced_IRI.parse _namespace_name "P7_took_place_at" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P26i_was_destination_of"></see>
    /// </summary>
    let P26i_was_destination_of =
        Namespaced_IRI.parse _namespace_name "P26i_was_destination_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P7i_witnessed"></see>
    /// </summary>
    let P7i_witnessed =
        Namespaced_IRI.parse _namespace_name "P7i_witnessed" |> NamespacedName

    /// <summary>
    /// This property identifies the starting E53 Place of an E9 Move.
    /// A move will be linked to an origin, such as the move of an artefact from storage to display. A move may be linked to many origins. In this case the move describes the picking up of a set of objects. The area of the move includes the origin, route and destination.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P27_moved_from"></see></summary>
    let P27_moved_from =
        Namespaced_IRI.parse _namespace_name "P27_moved_from" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P27i_was_origin_of"></see>
    /// </summary>
    let P27i_was_origin_of =
        Namespaced_IRI.parse _namespace_name "P27i_was_origin_of" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor or Actors who surrender custody of an instance of E18 Physical Thing in an E10 Transfer of Custody activity.
    /// The property will typically describe an Actor surrendering custody of an object when it is handed over to someone else’s care. On occasion, physical custody may be surrendered involuntarily – through accident, loss or theft.
    /// In reality, custody is either transferred to someone or from someone, or both.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P28_custody_surrendered_by"></see></summary>
    let P28_custody_surrendered_by =
        Namespaced_IRI.parse _namespace_name "P28_custody_surrendered_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P28i_surrendered_custody_through"></see>
    /// </summary>
    let P28i_surrendered_custody_through =
        Namespaced_IRI.parse _namespace_name "P28i_surrendered_custody_through" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor or Actors who receive custody of an instance of E18 Physical Thing in an E10 Transfer of Custody activity.
    /// The property will typically describe Actors receiving custody of an object when it is handed over from another Actor’s care. On occasion, physical custody may be received involuntarily or illegally – through accident, unsolicited donation, or theft.
    /// In reality, custody is either transferred to someone or from someone, or both.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P29_custody_received_by"></see></summary>
    let P29_custody_received_by =
        Namespaced_IRI.parse _namespace_name "P29_custody_received_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P29i_received_custody_through"></see>
    /// </summary>
    let P29i_received_custody_through =
        Namespaced_IRI.parse _namespace_name "P29i_received_custody_through" |> NamespacedName

    /// <summary>
    /// This property identifies an item or items of E18 Physical Thing concerned in an E10 Transfer of Custody activity.
    /// The property will typically describe the object that is handed over by an E39 Actor to another Actor’s custody. On occasion, physical custody may be transferred involuntarily or illegally – through accident, unsolicited donation, or theft.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P30_transferred_custody_of"></see></summary>
    let P30_transferred_custody_of =
        Namespaced_IRI.parse _namespace_name "P30_transferred_custody_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P30i_custody_transferred_through"></see>
    /// </summary>
    let P30i_custody_transferred_through =
        Namespaced_IRI.parse _namespace_name "P30i_custody_transferred_through" |> NamespacedName

    /// <summary>
    /// This property identifies the technique that was employed in an act of modification.
    /// These techniques should be drawn from an external E55 Type hierarchy of consistent terminology of general techniques such as embroidery, oil-painting, etc. Specific techniques may be further described as instances of E29 Design or Procedure.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P32_used_general_technique"></see></summary>
    let P32_used_general_technique =
        Namespaced_IRI.parse _namespace_name "P32_used_general_technique" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P32i_was_technique_of"></see>
    /// </summary>
    let P32i_was_technique_of =
        Namespaced_IRI.parse _namespace_name "P32i_was_technique_of" |> NamespacedName

    /// <summary>
    /// This property identifies a specific instance of E29 Design or Procedure in order to carry out an instance of E7 Activity or parts of it.
    /// The property differs from P32 used general technique (was technique of) in that P33 refers to an instance of E29 Design or Procedure, which is a concrete information object in its own right rather than simply being a term or a method known by tradition.
    /// Typical examples would include intervention plans for conservation or the construction plans of a building.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P33_used_specific_technique"></see></summary>
    let P33_used_specific_technique =
        Namespaced_IRI.parse _namespace_name "P33_used_specific_technique" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P33i_was_used_by"></see>
    /// </summary>
    let P33i_was_used_by =
        Namespaced_IRI.parse _namespace_name "P33i_was_used_by" |> NamespacedName

    /// <summary>
    /// This property identifies the E18 Physical Thing that was assessed during an E14 Condition Assessment activity.
    /// Conditions may be assessed either by direct observation or using recorded evidence. In the latter case the E18 Physical Thing does not need to be present or extant.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P34_concerned"></see></summary>
    let P34_concerned =
        Namespaced_IRI.parse _namespace_name "P34_concerned" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P34i_was_assessed_by"></see>
    /// </summary>
    let P34i_was_assessed_by =
        Namespaced_IRI.parse _namespace_name "P34i_was_assessed_by" |> NamespacedName

    /// <summary>
    /// This property identifies the E3 Condition State that was observed in an E14 Condition Assessment activity.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P35_has_identified"></see></summary>
    let P35_has_identified =
        Namespaced_IRI.parse _namespace_name "P35_has_identified" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P35i_was_identified_by"></see>
    /// </summary>
    let P35i_was_identified_by =
        Namespaced_IRI.parse _namespace_name "P35i_was_identified_by" |> NamespacedName

    /// <summary>
    /// This property records the identifier that was assigned to an item in an Identifier Assignment activity.
    /// The same identifier may be assigned on more than one occasion.
    /// An Identifier might be created prior to an assignment.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P37_assigned"></see></summary>
    let P37_assigned =
        Namespaced_IRI.parse _namespace_name "P37_assigned" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P37i_was_assigned_by"></see>
    /// </summary>
    let P37i_was_assigned_by =
        Namespaced_IRI.parse _namespace_name "P37i_was_assigned_by" |> NamespacedName

    /// <summary>
    /// This property records the identifier that was deassigned from an instance of E1 CRM Entity.
    /// Deassignment of an identifier may be necessary when an item is taken out of an inventory, a new numbering system is introduced or items are merged or split up.
    /// The same identifier may be deassigned on more than one occasion.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P38_deassigned"></see></summary>
    let P38_deassigned =
        Namespaced_IRI.parse _namespace_name "P38_deassigned" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P38i_was_deassigned_by"></see>
    /// </summary>
    let P38i_was_deassigned_by =
        Namespaced_IRI.parse _namespace_name "P38i_was_deassigned_by" |> NamespacedName

    /// <summary>
    /// This property associates an instance of E16 Measurement with the instance of E1 CRM Entity to which it applied. An instance of E1 CRM Entity may be measured more than once. Material and immaterial things and processes may be measured, e.g. the number of words in a text, or the duration of an event.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P39_measured"></see></summary>
    let P39_measured =
        Namespaced_IRI.parse _namespace_name "P39_measured" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P39i_was_measured_by"></see>
    /// </summary>
    let P39i_was_measured_by =
        Namespaced_IRI.parse _namespace_name "P39i_was_measured_by" |> NamespacedName

    /// <summary>
    /// This property is a container for all informal descriptions about an object that have not been expressed in terms of CRM constructs.
    /// In particular it captures the characterisation of the item itself, its internal structures, appearance etc.
    /// Like property P2 has type (is type of), this property is a consequence of the restricted focus of the CRM. The aim is not to capture, in a structured form, everything that can be said about an item; indeed, the CRM formalism is not regarded as sufficient to express everything that can be said. Good practice requires use of distinct note fields for different aspects of a characterisation. The P3.1 has type property of P3 has note allows differentiation of specific notes, e.g. “construction”, “decoration” etc.
    /// An item may have many notes, but a note is attached to a specific item.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P3_has_note"></see></summary>
    let P3_has_note =
        Namespaced_IRI.parse _namespace_name "P3_has_note" |> NamespacedName

    /// <summary>
    /// This property records the dimension that was observed in an E16 Measurement Event.
    /// E54 Dimension can be any quantifiable aspect of E70 Thing. Weight, image colour depth and monetary value are dimensions in this sense. One measurement activity may determine more than one dimension of one object.
    /// Dimensions may be determined either by direct observation or using recorded evidence. In the latter case the measured Thing does not need to be present or extant.
    /// Even though knowledge of the value of a dimension requires measurement, the dimension may be an object of discourse prior to, or even without, any measurement being made.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P40_observed_dimension"></see></summary>
    let P40_observed_dimension =
        Namespaced_IRI.parse _namespace_name "P40_observed_dimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P40i_was_observed_in"></see>
    /// </summary>
    let P40i_was_observed_in =
        Namespaced_IRI.parse _namespace_name "P40i_was_observed_in" |> NamespacedName

    /// <summary>
    /// This property records the item to which a type was assigned in an E17 Type Assignment activity.
    /// Any instance of a CRM entity may be assigned a type through type assignment. Type assignment events allow a more detailed path from E1 CRM Entity through P41 classified (was classified), E17 Type Assignment, P42 assigned (was assigned by) to E55 Type for assigning types to objects compared to the shortcut offered by P2 has type (is type of).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P41_classified"></see></summary>
    let P41_classified =
        Namespaced_IRI.parse _namespace_name "P41_classified" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P41i_was_classified_by"></see>
    /// </summary>
    let P41i_was_classified_by =
        Namespaced_IRI.parse _namespace_name "P41i_was_classified_by" |> NamespacedName

    /// <summary>
    /// This property records the type that was assigned to an entity by an E17 Type Assignment activity.
    /// Type assignment events allow a more detailed path from E1 CRM Entity through P41 classified (was classified by), E17 Type Assignment, P42 assigned (was assigned by) to E55 Type for assigning types to objects compared to the shortcut offered by P2 has type (is type of).
    /// For example, a fragment of an antique vessel could be assigned the type “attic red figured belly handled amphora” by expert A. The same fragment could be assigned the type “shoulder handled amphora” by expert B.
    /// A Type may be intellectually constructed independent from assigning an instance of it.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P42_assigned"></see></summary>
    let P42_assigned =
        Namespaced_IRI.parse _namespace_name "P42_assigned" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P42i_was_assigned_by"></see>
    /// </summary>
    let P42i_was_assigned_by =
        Namespaced_IRI.parse _namespace_name "P42i_was_assigned_by" |> NamespacedName

    /// <summary>
    /// This property records a E54 Dimension of some E70 Thing.
    /// It is a shortcut of the more fully developed path from E70 Thing through P39 measured (was measured by), E16 Measurement P40 observed dimension (was observed in) to E54 Dimension. It offers no information about how and when an E54 Dimension was established, nor by whom.
    /// An instance of E54 Dimension is specific to an instance of E70 Thing.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P43_has_dimension"></see></summary>
    let P43_has_dimension =
        Namespaced_IRI.parse _namespace_name "P43_has_dimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P43i_is_dimension_of"></see>
    /// </summary>
    let P43i_is_dimension_of =
        Namespaced_IRI.parse _namespace_name "P43i_is_dimension_of" |> NamespacedName

    /// <summary>
    /// This property records an E3 Condition State for some E18 Physical Thing.
    /// It is a shortcut of the more fully developed path from E18 Physical Thing through P34 concerned (was assessed by), E14 Condition Assessment P35 has identified (was identified by) to E3 Condition State. It offers no information about how and when the E3 Condition State was established, nor by whom.
    /// An instance of Condition State is specific to an instance of Physical Thing.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P44_has_condition"></see></summary>
    let P44_has_condition =
        Namespaced_IRI.parse _namespace_name "P44_has_condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P44i_is_condition_of"></see>
    /// </summary>
    let P44i_is_condition_of =
        Namespaced_IRI.parse _namespace_name "P44i_is_condition_of" |> NamespacedName

    /// <summary>
    /// This property identifies the instances of E57 Materials of which an instance of E18 Physical Thing is composed.
    /// All physical things consist of physical materials. P45 consists of (is incorporated in) allows the different Materials to be recorded. P45 consists of (is incorporated in) refers here to observed Material as opposed to the consumed raw material.
    /// A Material, such as a theoretical alloy, may not have any physical instances
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P45_consists_of"></see></summary>
    let P45_consists_of =
        Namespaced_IRI.parse _namespace_name "P45_consists_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P45i_is_incorporated_in"></see>
    /// </summary>
    let P45i_is_incorporated_in =
        Namespaced_IRI.parse _namespace_name "P45i_is_incorporated_in" |> NamespacedName

    /// <summary>
    /// This property allows instances of E18 Physical Thing to be analysed into component elements.
    /// Component elements, since they are themselves instances of E18 Physical Thing, may be further analysed into sub-components, thereby creating a hierarchy of part decomposition. An instance of E18 Physical Thing may be shared between multiple wholes, for example two buildings may share a common wall.
    /// This property is intended to describe specific components that are individually documented, rather than general aspects. Overall descriptions of the structure of an instance of E18 Physical Thing are captured by the P3 has note property.
    /// The instances of E57 Materials of which an item of E18 Physical Thing is composed should be documented using P45 consists of (is incorporated in).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P46_is_composed_of"></see></summary>
    let P46_is_composed_of =
        Namespaced_IRI.parse _namespace_name "P46_is_composed_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P46i_forms_part_of"></see>
    /// </summary>
    let P46i_forms_part_of =
        Namespaced_IRI.parse _namespace_name "P46i_forms_part_of" |> NamespacedName

    /// <summary>
    /// This property records the preferred E42 Identifier that was used to identify an instance of E1 CRM Entity at the time this property was recorded.
    /// More than one preferred identifier may have been assigned to an item over time.
    /// Use of this property requires an external mechanism for assigning temporal validity to the respective CRM instance.
    /// P48 has preferred identifier (is preferred identifier of), is a shortcut for the path from E1 CRM Entity through P140 assigned attribute to (was attributed by), E15 Identifier Assignment, P37 assigned (was assigned by) to E42 Identifier. The fact that an identifier is a preferred one for an organisation can be better expressed in a context independent form by assigning a suitable E55 Type to the respective instance of E15 Identifier Assignment using the P2 has type property.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P48_has_preferred_identifier"></see></summary>
    let P48_has_preferred_identifier =
        Namespaced_IRI.parse _namespace_name "P48_has_preferred_identifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P48i_is_preferred_identifier_of"></see>
    /// </summary>
    let P48i_is_preferred_identifier_of =
        Namespaced_IRI.parse _namespace_name "P48i_is_preferred_identifier_of" |> NamespacedName

    /// <summary>
    /// This property describes the temporal confinement of an instance of an E2 Temporal Entity.
    /// The related E52 Time-Span is understood as the real Time-Span during which the phenomena were active, which make up the temporal entity instance. It does not convey any other meaning than a positioning on the “time-line” of chronology. The Time-Span in turn is approximated by a set of dates (E61 Time Primitive). A temporal entity can have in reality only one Time-Span, but there may exist alternative opinions about it, which we would express by assigning multiple Time-Spans. Related temporal entities may share a Time-Span. Time-Spans may have completely unknown dates but other descriptions by which we can infer knowledge.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P4_has_time-span"></see></summary>
    let ``P4_has_time-span`` =
        Namespaced_IRI.parse _namespace_name "P4_has_time-span" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P4i_is_time-span_of"></see>
    /// </summary>
    let ``P4i_is_time-span_of`` =
        Namespaced_IRI.parse _namespace_name "P4i_is_time-span_of" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor or Actors who had custody of an instance of E18 Physical Thing at the time this property was recorded.
    /// P50 has current keeper (is current keeper of) is a shortcut for the more detailed path from E18 Physical Thing through P30 transferred custody of (custody transferred through), E10 Transfer of Custody, P29 custody received by (received custody through) to E39 Actor.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P50_has_current_keeper"></see></summary>
    let P50_has_current_keeper =
        Namespaced_IRI.parse _namespace_name "P50_has_current_keeper" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P50i_is_current_keeper_of"></see>
    /// </summary>
    let P50i_is_current_keeper_of =
        Namespaced_IRI.parse _namespace_name "P50i_is_current_keeper_of" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor that is or has been the legal owner (i.e. title holder) of an instance of E18 Physical Thing at some time.
    /// The distinction with P52 has current owner (is current owner of) is that P51 has former or current owner (is former or current owner of) does not indicate whether the specified owners are current. P51 has former or current owner (is former or current owner of) is a shortcut for the more detailed path from E18 Physical Thing through P24 transferred title of (changed ownership through), E8 Acquisition, P23 transferred title from (surrendered title through), or P22 transferred title to (acquired title through) to E39 Actor.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P51_has_former_or_current_owner"></see></summary>
    let P51_has_former_or_current_owner =
        Namespaced_IRI.parse _namespace_name "P51_has_former_or_current_owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P51i_is_former_or_current_owner_of"></see>
    /// </summary>
    let P51i_is_former_or_current_owner_of =
        Namespaced_IRI.parse _namespace_name "P51i_is_former_or_current_owner_of" |> NamespacedName

    /// <summary>
    /// This property identifies the E21 Person, E74 Group or E40 Legal Body that was the owner of an instance of E18 Physical Thing at the time this property was recorded.
    /// P52 has current owner (is current owner of) is a shortcut for the more detailed path from E18 Physical Thing through P24 transferred title of (changed ownership through), E8 Acquisition, P22 transferred title to (acquired title through) to E39 Actor, if and only if this acquisition event is the most recent.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P52_has_current_owner"></see></summary>
    let P52_has_current_owner =
        Namespaced_IRI.parse _namespace_name "P52_has_current_owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P52i_is_current_owner_of"></see>
    /// </summary>
    let P52i_is_current_owner_of =
        Namespaced_IRI.parse _namespace_name "P52i_is_current_owner_of" |> NamespacedName

    /// <summary>
    /// This property allows an instance of E53 Place to be associated as the former or current location of an instance of E18 Physical Thing.
    /// In the case of E19 Physical Objects, the property does not allow any indication of the Time-Span during which the Physical Object was located at this Place, nor if this is the current location.
    /// In the case of immobile objects, the Place would normally correspond to the Place of creation.
    /// P53 has former or current location (is former or current location of) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P25 moved (moved by), E9 Move, P26 moved to (was destination of) or P27 moved from (was origin of) to E53 Place.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P53_has_former_or_current_location"></see></summary>
    let P53_has_former_or_current_location =
        Namespaced_IRI.parse _namespace_name "P53_has_former_or_current_location" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P53i_is_former_or_current_location_of"></see>
    /// </summary>
    let P53i_is_former_or_current_location_of =
        Namespaced_IRI.parse _namespace_name "P53i_is_former_or_current_location_of" |> NamespacedName

    /// <summary>
    /// This property records the foreseen permanent location of an instance of E19 Physical Object at the time this property was recorded.
    /// P54 has current permanent location (is current permanent location of) is similar to P55 has current location (currently holds). However, it indicates the E53 Place currently reserved for an object, such as the permanent storage location or a permanent exhibit location. The object may be temporarily removed from the permanent location, for example when used in temporary exhibitions or loaned to another institution. The object may never actually be located at its permanent location.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P54_has_current_permanent_location"></see></summary>
    let P54_has_current_permanent_location =
        Namespaced_IRI.parse _namespace_name "P54_has_current_permanent_location" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P54i_is_current_permanent_location_of"></see>
    /// </summary>
    let P54i_is_current_permanent_location_of =
        Namespaced_IRI.parse _namespace_name "P54i_is_current_permanent_location_of" |> NamespacedName

    /// <summary>
    /// This property records the location of an E19 Physical Object at the time the property was recorded.
    /// This property is a specialisation of P53 has former or current location (is former or current location of). It indicates that the E53 Place associated with the E19 Physical Object is the current location of the object. The property does not allow any indication of how long the Object has been at the current location.
    /// P55 has current location (currently holds) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P25 moved (moved by), E9 Move P26 moved to (was destination of) to E53 Place if and only if this Move is the most recent.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P55_has_current_location"></see></summary>
    let P55_has_current_location =
        Namespaced_IRI.parse _namespace_name "P55_has_current_location" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P55i_currently_holds"></see>
    /// </summary>
    let P55i_currently_holds =
        Namespaced_IRI.parse _namespace_name "P55i_currently_holds" |> NamespacedName

    /// <summary>
    /// This property describes a E26 Physical Feature found on a E19 Physical Object It does not specify the location of the feature on the object.
    /// P56 bears feature (is found on) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P59 has section (is located on or within), E53 Place, P53 has former or current location (is former or current location of) to E26 Physical Feature.
    /// A Physical Feature can only exist on one object. One object may bear more than one Physical Feature. An E27 Site should be considered as an E26 Physical Feature on the surface of the Earth.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P56_bears_feature"></see></summary>
    let P56_bears_feature =
        Namespaced_IRI.parse _namespace_name "P56_bears_feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P56i_is_found_on"></see>
    /// </summary>
    let P56i_is_found_on =
        Namespaced_IRI.parse _namespace_name "P56i_is_found_on" |> NamespacedName

    /// <summary>
    /// This property documents the E60 Number of parts of which an instance of E19 Physical Object is composed.
    /// This may be used as a method of checking inventory counts with regard to aggregate or collective objects. What constitutes a part or component depends on the context and requirements of the documentation. Normally, the parts documented in this way would not be considered as worthy of individual attention.
    /// For a more complete description, objects may be decomposed into their components and constituents using P46 is composed of (forms parts of) and P45 consists of (is incorporated in). This allows each element to be described individually.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P57_has_number_of_parts"></see></summary>
    let P57_has_number_of_parts =
        Namespaced_IRI.parse _namespace_name "P57_has_number_of_parts" |> NamespacedName

    /// <summary>
    /// This property links an area (section) named by a E46 Section Definition to the instance of E18 Physical Thing upon which it is found.
    /// The CRM handles sections as locations (instances of E53 Place) within or on E18 Physical Thing that are identified by E46 Section Definitions. Sections need not be discrete and separable components or parts of an object.
    /// This is part of a more developed path from E18 Physical Thing through P58, E46 Section Definition, P87 is identified by (identifies) that allows a more precise definition of a location found on an object than the shortcut P59 has section (is located on or within).
    /// A particular instance of a Section Definition only applies to one instance of Physical Thing.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P58_has_section_definition"></see></summary>
    let P58_has_section_definition =
        Namespaced_IRI.parse _namespace_name "P58_has_section_definition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P58i_defines_section"></see>
    /// </summary>
    let P58i_defines_section =
        Namespaced_IRI.parse _namespace_name "P58i_defines_section" |> NamespacedName

    /// <summary>
    /// This property links an area to the instance of E18 Physical Thing upon which it is found.
    /// It is typically used when a named E46 Section Definition is not appropriate.
    /// E18 Physical Thing may be subdivided into arbitrary regions.
    /// P59 has section (is located on or within) is a shortcut. If the E53 Place is identified by a Section Definition, a more detailed representation can make use of the fully developed (i.e. indirect) path from E18 Physical Thing through P58 has section definition (defines section), E46 Section Definition, P87 is identified by (identifies) to E53 Place. A Place can only be located on or within one Physical Object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P59_has_section"></see></summary>
    let P59_has_section =
        Namespaced_IRI.parse _namespace_name "P59_has_section" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P59i_is_located_on_or_within"></see>
    /// </summary>
    let P59i_is_located_on_or_within =
        Namespaced_IRI.parse _namespace_name "P59i_is_located_on_or_within" |> NamespacedName

    /// <summary>
    /// This property describes the decomposition of an E3 Condition State into discrete, subsidiary states.
    /// It is assumed that the sub-states into which the condition state is analysed form a logical whole - although the entire story may not be completely known – and that the sub-states are in fact constitutive of the general condition state. For example, a general condition state of “in ruins” may be decomposed into the individual stages of decay
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P5_consists_of"></see></summary>
    let P5_consists_of =
        Namespaced_IRI.parse _namespace_name "P5_consists_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P5i_forms_part_of"></see>
    /// </summary>
    let P5i_forms_part_of =
        Namespaced_IRI.parse _namespace_name "P5i_forms_part_of" |> NamespacedName

    /// <summary>
    /// This property identifies something that is depicted by an instance of E24 Physical Man-Made Thing.
    /// This property is a shortcut of the more fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1CRM Entity. P62.1 mode of depiction allows the nature of the depiction to be refined.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P62_depicts"></see></summary>
    let P62_depicts =
        Namespaced_IRI.parse _namespace_name "P62_depicts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P62i_is_depicted_by"></see>
    /// </summary>
    let P62i_is_depicted_by =
        Namespaced_IRI.parse _namespace_name "P62i_is_depicted_by" |> NamespacedName

    /// <summary>
    /// This property documents an E36 Visual Item shown by an instance of E24 Physical Man-Made Thing.
    /// This property is similar to P62 depicts (is depicted by) in that it associates an item of E24 Physical Man-Made Thing with a visual representation. However, P65 shows visual item (is shown by) differs from the P62 depicts (is depicted by) property in that it makes no claims about what the E36 Visual Item is deemed to represent. E36 Visual Item identifies a recognisable image or visual symbol, regardless of what this image may or may not represent.
    /// For example, all recent British coins bear a portrait of Queen Elizabeth II, a fact that is correctly documented using P62 depicts (is depicted by). Different portraits have been used at different periods, however. P65 shows visual item (is shown by) can be used to refer to a particular portrait.
    /// P65 shows visual item (is shown by) may also be used for Visual Items such as signs, marks and symbols, for example the 'Maltese Cross' or the 'copyright symbol’ that have no particular representational content.
    /// This property is part of the fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1 CRM Entity which is shortcut by, P62 depicts (is depicted by).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P65_shows_visual_item"></see></summary>
    let P65_shows_visual_item =
        Namespaced_IRI.parse _namespace_name "P65_shows_visual_item" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P65i_is_shown_by"></see>
    /// </summary>
    let P65i_is_shown_by =
        Namespaced_IRI.parse _namespace_name "P65i_is_shown_by" |> NamespacedName

    /// <summary>
    /// This property identifies an E57 Material foreseeen to be used by an E29 Design or Procedure.
    /// E29 Designs and procedures commonly foresee the use of particular E57 Materials. The fabrication of adobe bricks, for example, requires straw, clay and water. This property enables this to be documented.
    /// This property is not intended for the documentation of E57 Materials that were used on a particular occasion when an instance of E29 Design or Procedure was executed.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P68_foresees_use_of"></see></summary>
    let P68_foresees_use_of =
        Namespaced_IRI.parse _namespace_name "P68_foresees_use_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P68i_use_foreseen_by"></see>
    /// </summary>
    let P68i_use_foreseen_by =
        Namespaced_IRI.parse _namespace_name "P68i_use_foreseen_by" |> NamespacedName

    /// <summary>
    /// This symmetric property describes the association of an E29 Design or Procedure with other Designs or Procedures.
    /// Any instance of E29 Design or Procedure may be associated with other designs or procedures. The P69.1 has type property of P69 is associated with allows the nature of the association to be specified; examples of types of association between instances of E29 Design or Procedure include: whole-part, sequence, prerequisite, etc.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P69_is_associated_with"></see></summary>
    let P69_is_associated_with =
        Namespaced_IRI.parse _namespace_name "P69_is_associated_with" |> NamespacedName

    /// <summary>
    /// This property describes the CRM Entities documented by instances of E31 Document.
    /// Documents may describe any conceivable entity, hence the link to the highest-level entity in the CRM hierarchy. This property is intended for cases where a reference is regarded as being of a documentary character, in the scholarly or scientific sense.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P70_documents"></see></summary>
    let P70_documents =
        Namespaced_IRI.parse _namespace_name "P70_documents" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P70i_is_documented_in"></see>
    /// </summary>
    let P70i_is_documented_in =
        Namespaced_IRI.parse _namespace_name "P70i_is_documented_in" |> NamespacedName

    /// <summary>
    /// This property documents a source E32 Authority Document for an instance of an E1 CRM Entity.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P71_lists"></see></summary>
    let P71_lists = Namespaced_IRI.parse _namespace_name "P71_lists" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P71i_is_listed_in"></see>
    /// </summary>
    let P71i_is_listed_in =
        Namespaced_IRI.parse _namespace_name "P71i_is_listed_in" |> NamespacedName

    /// <summary>
    /// This property describes the E56 Language of an E33 Linguistic Object.
    /// Linguistic Objects are composed in one or more human Languages. This property allows these languages to be documented.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P72_has_language"></see></summary>
    let P72_has_language =
        Namespaced_IRI.parse _namespace_name "P72_has_language" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P72i_is_language_of"></see>
    /// </summary>
    let P72i_is_language_of =
        Namespaced_IRI.parse _namespace_name "P72i_is_language_of" |> NamespacedName

    /// <summary>
    /// This property describes the source and target of instances of E33Linguistic Object involved in a translation.
    /// When a Linguistic Object is translated into a new language it becomes a new Linguistic Object, despite being conceptually similar to the source object.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P73_has_translation"></see></summary>
    let P73_has_translation =
        Namespaced_IRI.parse _namespace_name "P73_has_translation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P73i_is_translation_of"></see>
    /// </summary>
    let P73i_is_translation_of =
        Namespaced_IRI.parse _namespace_name "P73i_is_translation_of" |> NamespacedName

    /// <summary>
    /// This property describes the current or former E53 Place of residence of an E39 Actor.
    /// The residence may be either the Place where the Actor resides, or a legally registered address of any kind.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P74_has_current_or_former_residence"></see></summary>
    let P74_has_current_or_former_residence =
        Namespaced_IRI.parse _namespace_name "P74_has_current_or_former_residence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P74i_is_current_or_former_residence_of"></see>
    /// </summary>
    let P74i_is_current_or_former_residence_of =
        Namespaced_IRI.parse _namespace_name "P74i_is_current_or_former_residence_of" |> NamespacedName

    /// <summary>
    /// This property identifies former or current instances of E30 Rights held by an E39 Actor.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P75_possesses"></see></summary>
    let P75_possesses =
        Namespaced_IRI.parse _namespace_name "P75_possesses" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P75i_is_possessed_by"></see>
    /// </summary>
    let P75i_is_possessed_by =
        Namespaced_IRI.parse _namespace_name "P75i_is_possessed_by" |> NamespacedName

    /// <summary>
    /// This property identifies an E51 Contact Point of any type that provides access to an E39 Actor by any communication method, such as e-mail or fax.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P76_has_contact_point"></see></summary>
    let P76_has_contact_point =
        Namespaced_IRI.parse _namespace_name "P76_has_contact_point" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P76i_provides_access_to"></see>
    /// </summary>
    let P76i_provides_access_to =
        Namespaced_IRI.parse _namespace_name "P76i_provides_access_to" |> NamespacedName

    /// <summary>
    /// This property identifies an E52 Time-Span using an E49Time Appellation.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P78_is_identified_by"></see></summary>
    let P78_is_identified_by =
        Namespaced_IRI.parse _namespace_name "P78_is_identified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P78i_identifies"></see>
    /// </summary>
    let P78i_identifies =
        Namespaced_IRI.parse _namespace_name "P78i_identifies" |> NamespacedName

    /// <summary>
    /// This property qualifies the beginning of an E52 Time-Span in some way.
    /// The nature of the qualification may be certainty, precision, source etc.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P79_beginning_is_qualified_by"></see></summary>
    let P79_beginning_is_qualified_by =
        Namespaced_IRI.parse _namespace_name "P79_beginning_is_qualified_by" |> NamespacedName

    /// <summary>
    /// This property qualifies the end of an E52 Time-Span in some way.
    /// The nature of the qualification may be certainty, precision, source etc.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P80_end_is_qualified_by"></see></summary>
    let P80_end_is_qualified_by =
        Namespaced_IRI.parse _namespace_name "P80_end_is_qualified_by" |> NamespacedName

    /// <summary>
    /// This property describes the minimum period of time covered by an E52 Time-Span.
    /// Since Time-Spans may not have precisely known temporal extents, the CRM supports statements about the minimum and maximum temporal extents of Time-Spans. This property allows a Time-Span’s minimum temporal extent (i.e. its inner boundary) to be assigned an E61 Time Primitive value. Time Primitives are treated by the CRM as application or system specific date intervals, and are not further analysed.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P81_ongoing_throughout"></see></summary>
    let P81_ongoing_throughout =
        Namespaced_IRI.parse _namespace_name "P81_ongoing_throughout" |> NamespacedName

    /// <summary>
    /// This property describes the maximum period of time within which an E52 Time-Span falls.
    /// Since Time-Spans may not have precisely known temporal extents, the CRM supports statements about the minimum and maximum temporal extents of Time-Spans. This property allows a Time-Span’s maximum temporal extent (i.e. its outer boundary) to be assigned an E61 Time Primitive value. Time Primitives are treated by the CRM as application or system specific date intervals, and are not further analysed.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P82_at_some_time_within"></see></summary>
    let P82_at_some_time_within =
        Namespaced_IRI.parse _namespace_name "P82_at_some_time_within" |> NamespacedName

    /// <summary>
    /// This property describes the minimum length of time covered by an E52 Time-Span.
    /// It allows an E52 Time-Span to be associated with an E54 Dimension representing it’s minimum duration (i.e. it’s inner boundary) independent from the actual beginning and end.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P83_had_at_least_duration"></see></summary>
    let P83_had_at_least_duration =
        Namespaced_IRI.parse _namespace_name "P83_had_at_least_duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P83i_was_minimum_duration_of"></see>
    /// </summary>
    let P83i_was_minimum_duration_of =
        Namespaced_IRI.parse _namespace_name "P83i_was_minimum_duration_of" |> NamespacedName

    /// <summary>
    /// This property describes the maximum length of time covered by an E52 Time-Span.
    /// It allows an E52 Time-Span to be associated with an E54 Dimension representing it’s maximum duration (i.e. it’s outer boundary) independent from the actual beginning and end.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P84_had_at_most_duration"></see></summary>
    let P84_had_at_most_duration =
        Namespaced_IRI.parse _namespace_name "P84_had_at_most_duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P84i_was_maximum_duration_of"></see>
    /// </summary>
    let P84i_was_maximum_duration_of =
        Namespaced_IRI.parse _namespace_name "P84i_was_maximum_duration_of" |> NamespacedName

    /// <summary>
    /// This property describes the inclusion relationship between two instances of E52 Time-Span.
    /// This property supports the notion that a Time-Span’s temporal extent falls within the temporal extent of another Time-Span. It addresses temporal containment only, and no contextual link between the two instances of Time-Span is implied.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P86_falls_within"></see></summary>
    let P86_falls_within =
        Namespaced_IRI.parse _namespace_name "P86_falls_within" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P86i_contains"></see>
    /// </summary>
    let P86i_contains =
        Namespaced_IRI.parse _namespace_name "P86i_contains" |> NamespacedName

    /// <summary>
    /// This property identifies an E53 Place using an E44 Place Appellation.
    /// Examples of Place Appellations used to identify Places include instances of E48 Place Name, addresses, E47 Spatial Coordinates etc.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P87_is_identified_by"></see></summary>
    let P87_is_identified_by =
        Namespaced_IRI.parse _namespace_name "P87_is_identified_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P87i_identifies"></see>
    /// </summary>
    let P87i_identifies =
        Namespaced_IRI.parse _namespace_name "P87i_identifies" |> NamespacedName

    /// <summary>
    /// This property identifies an E53 Place that forms part of another Place.
    /// It supports the notion that a Place can be subdivided into one or more constituent parts. It implies both spatial and contextual containment relationships between the two Places.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P88_consists_of"></see></summary>
    let P88_consists_of =
        Namespaced_IRI.parse _namespace_name "P88_consists_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P88i_forms_part_of"></see>
    /// </summary>
    let P88i_forms_part_of =
        Namespaced_IRI.parse _namespace_name "P88i_forms_part_of" |> NamespacedName

    /// <summary>
    /// This property identifies the instances of E53 Places that fall within the area covered by another Place.
    /// It addresses spatial containment only, and no ‘whole-part’ relationship between the two places is implied.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P89_falls_within"></see></summary>
    let P89_falls_within =
        Namespaced_IRI.parse _namespace_name "P89_falls_within" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P89i_contains"></see>
    /// </summary>
    let P89i_contains =
        Namespaced_IRI.parse _namespace_name "P89i_contains" |> NamespacedName

    /// <summary>
    /// This property describes the location of an instance of E4 Period with respect to an E19 Physical Object.
    /// P8 took place on or within (witnessed) is a short-cut of a path defining a E53 Place with respect to the geometry of an object. cf. E46 Section Definition.
    /// This property is in effect a special case of P7 took place at. It describes a period that can be located with respect to the space defined by an E19 Physical Object such as a ship or a building. The precise geographical location of the object during the period in question may be unknown or unimportant.
    /// For example, the French and German armistice of 22 June 1940 was signed in the same railway carriage as the armistice of 11 November 1918.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P8_took_place_on_or_within"></see></summary>
    let P8_took_place_on_or_within =
        Namespaced_IRI.parse _namespace_name "P8_took_place_on_or_within" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P8i_witnessed"></see>
    /// </summary>
    let P8i_witnessed =
        Namespaced_IRI.parse _namespace_name "P8i_witnessed" |> NamespacedName

    /// <summary>
    /// This property allows an E54 Dimension to be approximated by an E60 Number primitive.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P90_has_value"></see></summary>
    let P90_has_value =
        Namespaced_IRI.parse _namespace_name "P90_has_value" |> NamespacedName

    /// <summary>
    /// This property shows the type of unit an E54 Dimension was expressed in.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P91_has_unit"></see></summary>
    let P91_has_unit =
        Namespaced_IRI.parse _namespace_name "P91_has_unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P91i_is_unit_of"></see>
    /// </summary>
    let P91i_is_unit_of =
        Namespaced_IRI.parse _namespace_name "P91i_is_unit_of" |> NamespacedName

    /// <summary>
    /// This property links the founding or E66 Formation for an E74 Group with the Group itself.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P95_has_formed"></see></summary>
    let P95_has_formed =
        Namespaced_IRI.parse _namespace_name "P95_has_formed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P95i_was_formed_by"></see>
    /// </summary>
    let P95i_was_formed_by =
        Namespaced_IRI.parse _namespace_name "P95i_was_formed_by" |> NamespacedName

    /// <summary>
    /// This property links an E67 Birth event to an E21 Person as a participant in the role of birth-giving mother.
    ///
    /// Note that biological fathers are not necessarily participants in the Birth (see P97 from father (was father for)). The Person being born is linked to the Birth with the property P98 brought into life (was born). This is not intended for use with general natural history material, only people. There is no explicit method for modelling conception and gestation except by using extensions. This is a sub-property of P11 had participant (participated in).
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P96_by_mother"></see></summary>
    let P96_by_mother =
        Namespaced_IRI.parse _namespace_name "P96_by_mother" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P96i_gave_birth"></see>
    /// </summary>
    let P96i_gave_birth =
        Namespaced_IRI.parse _namespace_name "P96i_gave_birth" |> NamespacedName

    /// <summary>
    /// This property links an E67 Birth event to an E21 Person in the role of biological father.
    /// Note that biological fathers are not seen as necessary participants in the Birth, whereas birth-giving mothers are (see P96 by mother (gave birth)). The Person being born is linked to the Birth with the property P98 brought into life (was born).
    /// This is not intended for use with general natural history material, only people. There is no explicit method for modelling conception and gestation except by using extensions.
    /// A Birth event is normally (but not always) associated with one biological father.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P97_from_father"></see></summary>
    let P97_from_father =
        Namespaced_IRI.parse _namespace_name "P97_from_father" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P97i_was_father_for"></see>
    /// </summary>
    let P97i_was_father_for =
        Namespaced_IRI.parse _namespace_name "P97i_was_father_for" |> NamespacedName

    /// <summary>
    /// This property links an E67Birth event to an E21 Person in the role of offspring.
    /// Twins, triplets etc. are brought into life by the same Birth event. This is not intended for use with general Natural History material, only people. There is no explicit method for modelling conception and gestation except by using extensions.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P98_brought_into_life"></see></summary>
    let P98_brought_into_life =
        Namespaced_IRI.parse _namespace_name "P98_brought_into_life" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P98i_was_born"></see>
    /// </summary>
    let P98i_was_born =
        Namespaced_IRI.parse _namespace_name "P98i_was_born" |> NamespacedName

    /// <summary>
    /// This property links the disbanding or E68 Dissolution of an E74 Group to the Group itself.
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P99_dissolved"></see></summary>
    let P99_dissolved =
        Namespaced_IRI.parse _namespace_name "P99_dissolved" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P99i_was_dissolved_by"></see>
    /// </summary>
    let P99i_was_dissolved_by =
        Namespaced_IRI.parse _namespace_name "P99i_was_dissolved_by" |> NamespacedName

    /// <summary>
    /// This property describes the decomposition of an instance of E4 Period into discrete, subsidiary periods.
    /// The sub-periods into which the period is decomposed form a logical whole - although the entire picture may not be completely known - and the sub-periods are constitutive of the general period.
    ///
    /// <see href="http://www.cidoc-crm.org/cidoc-crm/P9_consists_of"></see></summary>
    let P9_consists_of =
        Namespaced_IRI.parse _namespace_name "P9_consists_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.cidoc-crm.org/cidoc-crm/P9i_forms_part_of"></see>
    /// </summary>
    let P9i_forms_part_of =
        Namespaced_IRI.parse _namespace_name "P9i_forms_part_of" |> NamespacedName
