#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module crm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.cidoc-crm.org/cidoc-crm/" "crm"

    /// <summary>
    ///   <para>rdfs:label : Changement de détenteurrdfs:label : Transfer of Custodyrdfs:label : Übertragung des Gewahrsamsrdfs:label : Μεταβίβαση  Κατοχήςrdfs:label : Передача Опекиrdfs:label : Transferência de Custódia</para>
    ///   <para>rdfs:comment : This class comprises transfers of physical custody of objects between instances of E39 Actor.
    /// The recording of the donor and/or recipient is optional. It is possible that in an instance of E10 Transfer of Custody there is either no donor or no recipient. Depending on the circumstances it may describe:
    /// 1.	the beginning of custody
    /// 2.	the end of custody
    /// 3.	the transfer of custody
    /// 4.	the receipt of custody from an unknown source
    /// 5.	the declared loss of an object
    /// The distinction between the legal responsibility for custody and the actual physical possession of the object should be expressed using the property P2 has type (is type of). A specific case of transfer of custody is theft.
    /// The interpretation of the museum notion of "accession" differs between institutions. The CRM therefore models legal ownership and physical custody separately. Institutions will then model their specific notions of accession and deaccession as combinations of these.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E10_Transfer_of_Custody">crm:E10_Transfer_of_Custody</a>
    /// </summary>
    let E10_Transfer_of_Custody = _prefixId.prefix "E10_Transfer_of_Custody"
    /// <summary>
    ///   <para>rdfs:label : Событие Измененияrdfs:label : Modificationrdfs:label : Τροποποίησηrdfs:label : Modificationrdfs:label : Bearbeitungrdfs:label : Modificação</para>
    ///   <para>rdfs:comment : This class comprises all instances of E7 Activity that create, alter or change E24 Physical Man-Made Thing.
    /// This class includes the production of an item from raw materials, and other so far undocumented objects, and the preventive treatment or restoration of an object for conservation.
    /// Since the distinction between modification and production is not always clear, modification is regarded as the more generally applicable concept. This implies that some items may be consumed or destroyed in a Modification, and that others may be produced as a result of it. An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the originals. In this case, the new items have separate identities.
    /// If the instance of the E29 Design or Procedure utilized for the modification prescribes the use of specific materials, they should be documented using property P68 foresees use of (use foreseen by): E57 Material of E29 Design or Procedure, rather than via P126 employed (was employed in): E57 Material.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E11_Modification">crm:E11_Modification</a>
    /// </summary>
    let E11_Modification = _prefixId.prefix "E11_Modification"
    /// <summary>
    ///   <para>rdfs:label : Productionrdfs:label : Herstellungrdfs:label : Παραγωγήrdfs:label : Produçãordfs:label : Событие Производстваrdfs:label : Production</para>
    ///   <para>rdfs:comment : This class comprises activities that are designed to, and succeed in, creating one or more new items.
    /// It specializes the notion of modification into production. The decision as to whether or not an object is regarded as new is context sensitive. Normally, items are considered “new” if there is no obvious overall similarity between them and the consumed items and material used in their production. In other cases, an item is considered “new” because it becomes relevant to documentation by a modification. For example, the scribbling of a name on a potsherd may make it a voting token. The original potsherd may not be worth documenting, in contrast to the inscribed one.
    /// This entity can be collective: the printing of a thousand books, for example, would normally be considered a single event.
    /// An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the originals. In this case, the new items have separate identities and matter is preserved, but identity is not.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E12_Production">crm:E12_Production</a>
    /// </summary>
    let E12_Production = _prefixId.prefix "E12_Production"
    /// <summary>
    ///   <para>rdfs:label : Присвоение Атрибутаrdfs:label : Affectation d'attributrdfs:label : Merkmalszuweisungrdfs:label : Attribute Assignmentrdfs:label : Απόδοση Ιδιοτήτωνrdfs:label : Atribuição de Característica</para>
    ///   <para>rdfs:comment : This class comprises the actions of making assertions about properties of an object or any relation between two items or concepts.
    /// This class allows the documentation of how the respective assignment came about, and whose opinion it was. All the attributes or properties assigned in such an action can also be seen as directly attached to the respective item or concept, possibly as a collection of contradictory values. All cases of properties in this model that are also described indirectly through an action are characterised as "short cuts" of this action. This redundant modelling of two alternative views is preferred because many implementations may have good reasons to model either the action or the short cut, and the relation between both alternatives can be captured by simple rules.
    /// In particular, the class describes the actions of people making propositions and statements during certain museum procedures, e.g. the person and date when a condition statement was made, an identifier was assigned, the museum object was measured, etc. Which kinds of such assignments and statements need to be documented explicitly in structures of a schema rather than free text, depends on if this information should be accessible by structured queries.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E13_Attribute_Assignment">crm:E13_Attribute_Assignment</a>
    /// </summary>
    let E13_Attribute_Assignment = _prefixId.prefix "E13_Attribute_Assignment"
    /// <summary>
    ///   <para>rdfs:label : Εκτίμηση Κατάστασηςrdfs:label : Оценка Состоянияrdfs:label : Expertise de l'état matérielrdfs:label : Zustandsfeststellungrdfs:label : Condition Assessmentrdfs:label : Avaliação do Estado Material</para>
    ///   <para>rdfs:comment : This class describes the act of assessing the state of preservation of an object during a particular period.
    /// The condition assessment may be carried out by inspection, measurement or through historical research. This class is used to document circumstances of the respective assessment that may be relevant to interpret its quality at a later stage, or to continue research on related documents.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E14_Condition_Assessment">crm:E14_Condition_Assessment</a>
    /// </summary>
    let E14_Condition_Assessment = _prefixId.prefix "E14_Condition_Assessment"
    /// <summary>
    ///   <para>rdfs:label : Απόδοση Αναγνωριστικούrdfs:label : Назначение Идентификатораrdfs:label : Identifier Assignmentrdfs:label : Kennzeichenzuweisungrdfs:label : Attribution d’identificateurrdfs:label : Atribuição de Identificador</para>
    ///   <para>rdfs:comment : This class comprises activities that result in the allocation of an identifier to an instance of E1 CRM Entity. An E15 Identifier Assignment may include the creation of the identifier from multiple constituents, which themselves may be instances of E41 Appellation. The syntax and kinds of constituents to be used may be declared in a rule constituting an instance of E29 Design or Procedure.
    /// Examples of such identifiers include Find Numbers, Inventory Numbers, uniform titles in the sense of librarianship and Digital Object Identifiers (DOI). Documenting the act of identifier assignment and deassignment is especially useful when objects change custody or the identification system of an organization is changed. In order to keep track of the identity of things in such cases, it is important to document by whom, when and for what purpose an identifier is assigned to an item.
    /// The fact that an identifier is a preferred one for an organisation can be expressed by using the property E1 CRM Entity. P48 has preferred identifier (is preferred identifier of): E42 Identifier. It can better be expressed in a context independent form by assigning a suitable E55 Type, such as “preferred identifier assignment”, to the respective instance of E15 Identifier Assignment via the P2 has type property.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E15_Identifier_Assignment">crm:E15_Identifier_Assignment</a>
    /// </summary>
    let E15_Identifier_Assignment = _prefixId.prefix "E15_Identifier_Assignment"
    /// <summary>
    ///   <para>rdfs:label : Событие Измеренияrdfs:label : Μέτρησηrdfs:label : Messungrdfs:label : Mesuragerdfs:label : Measurementrdfs:label : Medição</para>
    ///   <para>rdfs:comment : This class comprises actions measuring physical properties and other values that can be determined by a systematic procedure.
    /// Examples include measuring the monetary value of a collection of coins or the running time of a specific video cassette.
    /// The E16 Measurement may use simple counting or tools, such as yardsticks or radiation detection devices. The interest is in the method and care applied, so that the reliability of the result may be judged at a later stage, or research continued on the associated documents. The date of the event is important for dimensions, which may change value over time, such as the length of an object subject to shrinkage. Details of methods and devices are best handled as free text, whereas basic techniques such as "carbon 14 dating" should be encoded using P2 has type (is type of:) E55 Type.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E16_Measurement">crm:E16_Measurement</a>
    /// </summary>
    let E16_Measurement = _prefixId.prefix "E16_Measurement"
    /// <summary>
    ///   <para>rdfs:label : Typuszuweisungrdfs:label : Присвоение Типаrdfs:label : Attribution de typerdfs:label : Type Assignmentrdfs:label : Απόδοση Τύπουrdfs:label : Atribuição de Tipo</para>
    ///   <para>rdfs:comment : This class comprises the actions of classifying items of whatever kind. Such items include objects, specimens, people, actions and concepts.
    /// This class allows for the documentation of the context of classification acts in cases where the value of the classification depends on the personal opinion of the classifier, and the date that the classification was made. This class also encompasses the notion of "determination," i.e. the systematic and molecular identification of a specimen in biology.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E17_Type_Assignment">crm:E17_Type_Assignment</a>
    /// </summary>
    let E17_Type_Assignment = _prefixId.prefix "E17_Type_Assignment"
    /// <summary>
    ///   <para>rdfs:label : Materiellesrdfs:label : Υλικό Πράγμαrdfs:label : Physical Thingrdfs:label : Chose matériellerdfs:label : Физическая Вещьrdfs:label : Coisa Material</para>
    ///   <para>rdfs:comment : This class comprises all persistent physical items with a relatively stable form, man-made or natural.
    /// Depending on the existence of natural boundaries of such things, the CRM distinguishes the instances of E19 Physical Object from instances of E26 Physical Feature, such as holes, rivers, pieces of land etc. Most instances of E19 Physical Object can be moved (if not too heavy), whereas features are integral to the surrounding matter.
    /// The CRM is generally not concerned with amounts of matter in fluid or gaseous states.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E18_Physical_Thing">crm:E18_Physical_Thing</a>
    /// </summary>
    let E18_Physical_Thing = _prefixId.prefix "E18_Physical_Thing"
    /// <summary>
    ///   <para>rdfs:label : Физический Объектrdfs:label : Objet matérielrdfs:label : Physical Objectrdfs:label : Υλικό Αντικείμενοrdfs:label : Materieller Gegenstandrdfs:label : Objeto Material</para>
    ///   <para>rdfs:comment : This class comprises items of a material nature that are units for documentation and have physical boundaries that separate them completely in an objective way from other objects.
    /// The class also includes all aggregates of objects made for functional purposes of whatever kind, independent of physical coherence, such as a set of chessmen. Typically, instances of E19 Physical Object can be moved (if not too heavy).
    /// In some contexts, such objects, except for aggregates, are also called “bona fide objects” (Smith &amp; Varzi, 2000, pp.401-420), i.e. naturally defined objects.
    /// The decision as to what is documented as a complete item, rather than by its parts or components, may be a purely administrative decision or may be a result of the order in which the item was acquired.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E19_Physical_Object">crm:E19_Physical_Object</a>
    /// </summary>
    let E19_Physical_Object = _prefixId.prefix "E19_Physical_Object"
    /// <summary>
    ///   <para>rdfs:label : Οντότητα CIDOC CRMrdfs:label : CRM Entityrdfs:label : CRM Entitätrdfs:label : CRM Сущностьrdfs:label : Entité CRMrdfs:label : Entidade CRM</para>
    ///   <para>rdfs:comment : This class comprises all things in the universe of discourse of the CIDOC Conceptual Reference Model.
    /// It is an abstract concept providing for three general properties:
    /// 1.	Identification by name or appellation, and in particular by a preferred identifier
    /// 2.	Classification by type, allowing further refinement of the specific subclass an instance belongs to
    /// 3.	Attachment of free text for the expression of anything not captured by formal properties
    /// With the exception of E59 Primitive Value, all other classes within the CRM are directly or indirectly specialisations of E1 CRM Entity.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E1_CRM_Entity">crm:E1_CRM_Entity</a>
    /// </summary>
    let E1_CRM_Entity = _prefixId.prefix "E1_CRM_Entity"
    /// <summary>
    ///   <para>rdfs:label : Биологический Объектrdfs:label : Biological Objectrdfs:label : Βιολογικό Ακτικείμενοrdfs:label : Objet biologiquerdfs:label : Biologischer Gegenstandrdfs:label : Objeto Biológico</para>
    ///   <para>rdfs:comment : This class comprises individual items of a material nature, which live, have lived or are natural products of or from living organisms.
    /// Artificial objects that incorporate biological elements, such as Victorian butterfly frames, can be documented as both instances of E20 Biological Object and E22 Man-Made Object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E20_Biological_Object">crm:E20_Biological_Object</a>
    /// </summary>
    let E20_Biological_Object = _prefixId.prefix "E20_Biological_Object"
    /// <summary>
    ///   <para>rdfs:label : Pessoardfs:label : Πρόσωποrdfs:label : Личностьrdfs:label : Personnerdfs:label : Personrdfs:label : Person</para>
    ///   <para>rdfs:comment : This class comprises real persons who live or are assumed to have lived.
    /// Legendary figures that may have existed, such as Ulysses and King Arthur, fall into this class if the documentation refers to them as historical figures. In cases where doubt exists as to whether several persons are in fact identical, multiple instances can be created and linked to indicate their relationship. The CRM does not propose a specific form to support reasoning about possible identity.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E21_Person">crm:E21_Person</a>
    /// </summary>
    let E21_Person = _prefixId.prefix "E21_Person"
    /// <summary>
    ///   <para>rdfs:label : Künstlicher Gegenstandrdfs:label : Man-Made Objectrdfs:label : Objeto Fabricadordfs:label : Ανθρωπογενές Αντικείμενοrdfs:label : Рукотворный Объектrdfs:label : Objet fabriqué</para>
    ///   <para>rdfs:comment : This class comprises physical objects purposely created by human activity.
    /// No assumptions are made as to the extent of modification required to justify regarding an object as man-made. For example, an inscribed piece of rock or a preserved butterfly are both regarded as instances of E22 Man-Made Object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E22_Man-Made_Object">crm:E22_Man-Made_Object</a>
    /// </summary>
    let E22_Man_Made_Object = _prefixId.prefix "E22_Man-Made_Object"
    /// <summary>
    ///   <para>rdfs:label : Hergestelltesrdfs:label : Chose matérielle fabriquéerdfs:label : Coisa Material Fabricadardfs:label : Physical Man-Made Thingrdfs:label : Ανθρωπογενές Υλικό Πράγμαrdfs:label : Физическая Рукотворная Вещь</para>
    ///   <para>rdfs:comment : This class comprises all persistent physical items that are purposely created by human activity.
    /// This class comprises man-made objects, such as a swords, and man-made features, such as rock art. No assumptions are made as to the extent of modification required to justify regarding an object as man-made. For example, a “cup and ring” carving on bedrock is regarded as instance of E24 Physical Man-Made Thing.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E24_Physical_Man-Made_Thing">crm:E24_Physical_Man-Made_Thing</a>
    /// </summary>
    let E24_Physical_Man_Made_Thing = _prefixId.prefix "E24_Physical_Man-Made_Thing"
    /// <summary>
    ///   <para>rdfs:label : Caractéristique fabriquéerdfs:label : Hergestelltes Merkmalrdfs:label : Искусственный Признакrdfs:label : Man-Made Featurerdfs:label : Característica Fabricadardfs:label : Ανθρωπογενές Μόρφωμα</para>
    ///   <para>rdfs:comment : This class comprises physical features that are purposely created by human activity, such as scratches, artificial caves, artificial water channels, etc.
    /// No assumptions are made as to the extent of modification required to justify regarding a feature as man-made. For example, rock art or even “cup and ring” carvings on bedrock a regarded as types of E25 Man-Made Feature.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E25_Man-Made_Feature">crm:E25_Man-Made_Feature</a>
    /// </summary>
    let E25_Man_Made_Feature = _prefixId.prefix "E25_Man-Made_Feature"
    /// <summary>
    ///   <para>rdfs:label : Υλικό Μόρφωμαrdfs:label : Physical Featurerdfs:label : Физический Признакrdfs:label : Materielles Merkmalrdfs:label : Caractéristique matériellerdfs:label : Característica Material</para>
    ///   <para>rdfs:comment : This class comprises identifiable features that are physically attached in an integral way to particular physical objects.
    /// Instances of E26 Physical Feature share many of the attributes of instances of E19 Physical Object. They may have a one-, two- or three-dimensional geometric extent, but there are no natural borders that separate them completely in an objective way from the carrier objects. For example, a doorway is a feature but the door itself, being attached by hinges, is not.
    /// Instances of E26 Physical Feature can be features in a narrower sense, such as scratches, holes, reliefs, surface colours, reflection zones in an opal crystal or a density change in a piece of wood. In the wider sense, they are portions of particular objects with partially imaginary borders, such as the core of the Earth, an area of property on the surface of the Earth, a landscape or the head of a contiguous marble statue. They can be measured and dated, and it is sometimes possible to state who or what is or was responsible for them. They cannot be separated from the carrier object, but a segment of the carrier object may be identified (or sometimes removed) carrying the complete feature.
    /// This definition coincides with the definition of "fiat objects" (Smith &amp; Varzi, 2000, pp.401-420), with the exception of aggregates of “bona fide objects”.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E26_Physical_Feature">crm:E26_Physical_Feature</a>
    /// </summary>
    let E26_Physical_Feature = _prefixId.prefix "E26_Physical_Feature"
    /// <summary>
    ///   <para>rdfs:label : Φυσικός Χώροςrdfs:label : Siterdfs:label : Siterdfs:label : Участокrdfs:label : Geländerdfs:label : Lugar</para>
    ///   <para>rdfs:comment : This class comprises pieces of land or sea floor.
    /// In contrast to the purely geometric notion of E53 Place, this class describes constellations of matter on the surface of the Earth or other celestial body, which can be represented by photographs, paintings and maps.
    ///  Instances of E27 Site are composed of relatively immobile material items and features in a particular configuration at a particular location</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E27_Site">crm:E27_Site</a>
    /// </summary>
    let E27_Site = _prefixId.prefix "E27_Site"
    /// <summary>
    ///   <para>rdfs:label : Objet conceptuelrdfs:label : Begrifflicher Gegenstandrdfs:label : Концептуальный Объектrdfs:label : Conceptual Objectrdfs:label : Νοητικό Αντικείμενοrdfs:label : Objeto Conceitual</para>
    ///   <para>rdfs:comment : This class comprises non-material products of our minds and other human produced data that 		have become objects of a discourse about their identity, circumstances of creation or historical 		implication. The production of such information may have been supported by the use of    		technical devices such as cameras or computers.
    /// Characteristically, instances of this class are created, invented or thought by someone, and then may be documented or communicated between persons. Instances of E28 Conceptual Object have the ability to exist on more than one particular carrier at the same time, such as paper, electronic signals, marks, audio media, paintings, photos, human memories, etc.
    /// They cannot be destroyed. They exist as long as they can be found on at least one carrier or in at least one human memory. Their existence ends when the last carrier and the last memory are lost.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E28_Conceptual_Object">crm:E28_Conceptual_Object</a>
    /// </summary>
    let E28_Conceptual_Object = _prefixId.prefix "E28_Conceptual_Object"
    /// <summary>
    ///   <para>rdfs:label : Σχέδιοrdfs:label : Entwurf oder Verfahrenrdfs:label : Conception ou procédurerdfs:label : Проект или Процедураrdfs:label : Design or Procedurerdfs:label : Projeto ou Procedimento</para>
    ///   <para>rdfs:comment : This class comprises documented plans for the execution of actions in order to achieve a result of a specific quality, form or contents. In particular it comprises plans for deliberate human activities that may result in the modification or production of instances of E24 Physical Thing.
    /// Instances of E29 Design or Procedure can be structured in parts and sequences or depend on others. This is modelled using P69 is associated with.
    /// Designs or procedures can be seen as one of the following:
    /// 1.	A schema for the activities it describes
    /// 2.	A schema of the products that result from their application.
    /// 3.	An independent intellectual product that may have never been applied, such as Leonardo da Vinci’s famous plans for flying machines.
    /// Because designs or procedures may never be applied or only partially executed, the CRM models a loose relationship between the plan and the respective product.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E29_Design_or_Procedure">crm:E29_Design_or_Procedure</a>
    /// </summary>
    let E29_Design_or_Procedure = _prefixId.prefix "E29_Design_or_Procedure"
    /// <summary>
    ///   <para>rdfs:label : Entité temporellerdfs:label : Temporal Entityrdfs:label : Временная Сущностьrdfs:label : Έγχρονη  Οντότηταrdfs:label : Geschehendesrdfs:label : Entidade Temporal</para>
    ///   <para>rdfs:comment : This class comprises all phenomena, such as the instances of E4 Periods, E5 Events and states, which happen over a limited extent in time.
    /// 	In some contexts, these are also called perdurants. This class is disjoint from E77 Persistent Item. This is an abstract class and has no direct instances. E2 Temporal Entity is specialized into E4 Period, which applies to a particular geographic area (defined with a greater or lesser degree of precision), and E3 Condition State, which applies to instances of E18 Physical Thing.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E2_Temporal_Entity">crm:E2_Temporal_Entity</a>
    /// </summary>
    let E2_Temporal_Entity = _prefixId.prefix "E2_Temporal_Entity"
    /// <summary>
    ///   <para>rdfs:label : Правоrdfs:label : Δικαίωμαrdfs:label : Droitrdfs:label : Rightrdfs:label : Rechtrdfs:label : Direitos</para>
    ///   <para>rdfs:comment : This class comprises legal privileges concerning material and immaterial things or their derivatives.
    /// These include reproduction and property rights</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E30_Right">crm:E30_Right</a>
    /// </summary>
    let E30_Right = _prefixId.prefix "E30_Right"
    /// <summary>
    ///   <para>rdfs:label : Documentrdfs:label : Documentrdfs:label : Dokumentrdfs:label : Документrdfs:label : Τεκμήριοrdfs:label : Documento</para>
    ///   <para>rdfs:comment : This class comprises identifiable immaterial items that make propositions about reality.
    /// These propositions may be expressed in text, graphics, images, audiograms, videograms or by other similar means. Documentation databases are regarded as a special case of E31 Document. This class should not be confused with the term “document” in Information Technology, which is compatible with E73 Information Object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E31_Document">crm:E31_Document</a>
    /// </summary>
    let E31_Document = _prefixId.prefix "E31_Document"
    /// <summary>
    ///   <para>rdfs:label : Referenzdokumentrdfs:label : Официальный Документrdfs:label : Document de référencerdfs:label : Πηγή Καθιερωμένων Όρωνrdfs:label : Authority Documentrdfs:label : Documento de Referência</para>
    ///   <para>rdfs:comment : This class comprises encyclopaedia, thesauri, authority lists and other documents that define terminology or conceptual systems for consistent use.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E32_Authority_Document">crm:E32_Authority_Document</a>
    /// </summary>
    let E32_Authority_Document = _prefixId.prefix "E32_Authority_Document"
    /// <summary>
    ///   <para>rdfs:label : Линвистический Объектrdfs:label : Linguistic Objectrdfs:label : Γλωσσικό Αντικείμενοrdfs:label : Objet linguistiquerdfs:label : Sprachlicher Gegenstandrdfs:label : Objeto Lingüístico</para>
    ///   <para>rdfs:comment : This class comprises identifiable expressions in natural language or languages.
    /// Instances of E33 Linguistic Object can be expressed in many ways: e.g. as written texts, recorded speech or sign language. However, the CRM treats instances of E33 Linguistic Object independently from the medium or method by which they are expressed. Expressions in formal languages, such as computer code or mathematical formulae, are not treated as instances of E33 Linguistic Object by the CRM. These should be modelled as instances of E73 Information Object.
    /// The text of an instance of E33 Linguistic Object can be documented in a note by P3 has note: E62 String
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E33_Linguistic_Object">crm:E33_Linguistic_Object</a>
    /// </summary>
    let E33_Linguistic_Object = _prefixId.prefix "E33_Linguistic_Object"
    /// <summary>
    ///   <para>rdfs:label : Inscriptionrdfs:label : Inscriptionrdfs:label : Επιγραφήrdfs:label : Надписьrdfs:label : Inscriçãordfs:label : Inschrift</para>
    ///   <para>rdfs:comment : This class comprises recognisable, short texts attached to instances of E24 Physical Man-Made Thing.
    /// The transcription of the text can be documented in a note by P3 has note: E62 String. The alphabet used can be documented by P2 has type: E55 Type. This class does not intend to describe the idiosyncratic characteristics of an individual physical embodiment of an inscription, but the underlying prototype. The physical embodiment is modelled in the CRM as E24 Physical Man-Made Thing.
    /// The relationship of a physical copy of a book to the text it contains is modelled using E84 Information Carrier. P128 carries (is carried by): E33 Linguistic Object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E34_Inscription">crm:E34_Inscription</a>
    /// </summary>
    let E34_Inscription = _prefixId.prefix "E34_Inscription"
    /// <summary>
    ///   <para>rdfs:label : Titrerdfs:label : Titelrdfs:label : Títulordfs:label : Titlerdfs:label : Заголовокrdfs:label :  Τίτλος</para>
    ///   <para>rdfs:comment : This class comprises the names assigned to works, such as texts, artworks or pieces of music.
    /// Titles are proper noun phrases or verbal phrases, and should not be confused with generic object names such as “chair”, “painting” or “book” (the latter are common nouns that stand for instances of E55 Type). Titles may be assigned by the creator of the work itself, or by a social group.
    /// This class also comprises the translations of titles that are used as surrogates for the original titles in different social contexts.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E35_Title">crm:E35_Title</a>
    /// </summary>
    let E35_Title = _prefixId.prefix "E35_Title"
    /// <summary>
    ///   <para>rdfs:label : Визуальный Предметrdfs:label : Item visuelrdfs:label : Οπτικό Στοιχείοrdfs:label : Visual Itemrdfs:label : Bildlichesrdfs:label : Item Visual</para>
    ///   <para>rdfs:comment : This class comprises the intellectual or conceptual aspects of recognisable marks and images.
    /// This class does not intend to describe the idiosyncratic characteristics of an individual physical embodiment of a visual item, but the underlying prototype. For example, a mark such as the ICOM logo is generally considered to be the same logo when used on any number of publications. The size, orientation and colour may change, but the logo remains uniquely identifiable. The same is true of images that are reproduced many times. This means that visual items are independent of their physical support.
    /// The class E36 Visual Item provides a means of identifying and linking together instances of E24 Physical Man-Made Thing that carry the same visual symbols, marks or images etc. The property P62 depicts (is depicted by) between E24 Physical Man-Made Thing and depicted subjects (E1 CRM Entity) can be regarded as a short-cut of the more fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1CRM Entity, which in addition captures the optical features of the depiction.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E36_Visual_Item">crm:E36_Visual_Item</a>
    /// </summary>
    let E36_Visual_Item = _prefixId.prefix "E36_Visual_Item"
    /// <summary>
    ///   <para>rdfs:label : Пометкаrdfs:label : Marquerdfs:label : Σήμανσηrdfs:label : Markrdfs:label : Markerdfs:label : Marca</para>
    ///   <para>rdfs:comment : This class comprises symbols, signs, signatures or short texts applied to instances of E24 Physical Man-Made Thing by arbitrary techniques in order to indicate the creator, owner, dedications, purpose, etc.
    /// This class specifically excludes features that have no semantic significance, such as scratches or tool marks. These should be documented as instances of E25 Man-Made Feature.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E37_Mark">crm:E37_Mark</a>
    /// </summary>
    let E37_Mark = _prefixId.prefix "E37_Mark"
    /// <summary>
    ///   <para>rdfs:label : Изображениеrdfs:label : Εικόναrdfs:label : Bildrdfs:label : Imagerdfs:label : Imagerdfs:label : Imagem</para>
    ///   <para>rdfs:comment : This class comprises distributions of form, tone and colour that may be found on surfaces such as photos, paintings, prints and sculptures or directly on electronic media.
    /// The degree to which variations in the distribution of form and colour affect the identity of an instance of E38 Image depends on a given purpose. The original painting of the Mona Lisa in the Louvre may be said to bear the same instance of E38 Image as reproductions in the form of transparencies, postcards, posters or T-shirts, even though they may differ in size and carrier and may vary in tone and colour. The images in a “spot the difference” competition are not the same with respect to their context, however similar they may at first appear.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E38_Image">crm:E38_Image</a>
    /// </summary>
    let E38_Image = _prefixId.prefix "E38_Image"
    /// <summary>
    ///   <para>rdfs:label : Akteurrdfs:label : Агентrdfs:label : Agentrdfs:label : Δράστηςrdfs:label : Actorrdfs:label : Agente</para>
    ///   <para>rdfs:comment : This class comprises people, either individually or in groups, who have the potential to perform intentional actions for which they can be held responsible.
    /// The CRM does not attempt to model the inadvertent actions of such actors. Individual people should be documented as instances of E21 Person, whereas groups should be documented as instances of either E74 Group or its subclass E40 Legal Body.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E39_Actor">crm:E39_Actor</a>
    /// </summary>
    let E39_Actor = _prefixId.prefix "E39_Actor"
    /// <summary>
    ///   <para>rdfs:label : Состояниеrdfs:label : Condition Staterdfs:label : Zustandsphaserdfs:label : État matérielrdfs:label : Κατάστασηrdfs:label : Estado Material</para>
    ///   <para>rdfs:comment : This class comprises the states of objects characterised by a certain condition over a time-span.
    /// An instance of this class describes the prevailing physical condition of any material object or feature during a specific E52 Time Span. In general, the time-span for which a certain condition can be asserted may be shorter than the real time-span, for which this condition held.
    ///  The nature of that condition can be described using P2 has type. For example, the E3 Condition State “condition of the SS Great Britain between 22 September 1846 and 27 August 1847” can be characterized as E55 Type “wrecked”.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E3_Condition_State">crm:E3_Condition_State</a>
    /// </summary>
    let E3_Condition_State = _prefixId.prefix "E3_Condition_State"
    /// <summary>
    ///   <para>rdfs:label : Collectivitérdfs:label : Juristische Personrdfs:label : Νομικό Πρόσωποrdfs:label : Юридическое Лицоrdfs:label : Legal Bodyrdfs:label : Pessoa Jurídica</para>
    ///   <para>rdfs:comment : This class comprises institutions or groups of people that have obtained a legal recognition as a group and can act collectively as agents.
    /// This means that they can perform actions, own property, create or destroy things and can be held collectively responsible for their actions like individual people. The term 'personne morale' is often used for this in French.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E40_Legal_Body">crm:E40_Legal_Body</a>
    /// </summary>
    let E40_Legal_Body = _prefixId.prefix "E40_Legal_Body"
    /// <summary>
    ///   <para>rdfs:label : Benennungrdfs:label : Обозначениеrdfs:label : Appellationrdfs:label : Appellationrdfs:label : Ονομασίαrdfs:label : Designação</para>
    ///   <para>rdfs:comment : This class comprises all sequences of signs of any nature, either meaningful or not, that are used or can be used to refer to and identify a specific instance of some class within a certain context.
    /// Instances of E41 Appellation do not identify things by their meaning, even if they happen to have one, but by convention, tradition, or agreement. Instances of E41 Appellation are cultural constructs; as such, they have a context, a history, and a use in time and space by some group of users. A given instance of E41 Appellation can have alternative forms, i.e., other instances of E41 Appellation that are always regarded as equivalent independent from the thing it denotes.
    /// Specific subclasses of E41 Appellation should be used when instances of E41 Appellation of a characteristic form are used for particular objects. Instances of E49 Time Appellation, for example, which take the form of instances of E50 Date, can be easily recognised.
    /// E41 Appellation should not be confused with the act of naming something. Cf. E15 Identifier Assignment
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E41_Appellation">crm:E41_Appellation</a>
    /// </summary>
    let E41_Appellation = _prefixId.prefix "E41_Appellation"
    /// <summary>
    ///   <para>rdfs:label : Identificateur d'objetrdfs:label : Κωδικός Αναγνώρισηςrdfs:label : Идентификатор Объектаrdfs:label : Kennungrdfs:label : Identifierrdfs:label : Identificador de Objeto</para>
    ///   <para>rdfs:comment : This class comprises strings or codes assigned to instances of E1 CRM Entity in order to identify them uniquely and permanently within the context of one or more organisations. Such codes are often known as inventory numbers, registration codes, etc. and are typically composed of alphanumeric sequences. The class E42 Identifier is not normally used for machine-generated identifiers used for automated processing unless these are also used by human agents.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E42_Identifier">crm:E42_Identifier</a>
    /// </summary>
    let E42_Identifier = _prefixId.prefix "E42_Identifier"
    /// <summary>
    ///   <para>rdfs:label : Обозначение Местаrdfs:label : Place Appellationrdfs:label : Appellation de lieurdfs:label : Ortsbenennungrdfs:label : Ονομασία Τόπουrdfs:label : Designação de Local</para>
    ///   <para>rdfs:comment : This class comprises any sort of identifier characteristically used to refer to an E53 Place.
    /// Instances of E44 Place Appellation may vary in their degree of precision and their meaning may vary over time - the same instance of E44 Place Appellation may be used to refer to several places, either because of cultural shifts, or because objects used as reference points have moved around. Instances of E44 Place Appellation can be extremely varied in form: postal addresses, instances of E47 Spatial Coordinate, and parts of buildings can all be considered as instances of E44 Place Appellation.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E44_Place_Appellation">crm:E44_Place_Appellation</a>
    /// </summary>
    let E44_Place_Appellation = _prefixId.prefix "E44_Place_Appellation"
    /// <summary>
    ///   <para>rdfs:label : Διεύθυνσηrdfs:label : Adresserdfs:label : Adresserdfs:label : Addressrdfs:label : Адресrdfs:label : Endereço</para>
    ///   <para>rdfs:comment : This class comprises identifiers expressed in coding systems for places, such as postal addresses used for mailing.
    /// An E45 Address can be considered both as the name of an E53 Place and as an E51 Contact Point for an E39 Actor. This dual aspect is reflected in the multiple inheritance. However, some forms of mailing addresses, such as a postal box, are only instances of E51 Contact Point, since they do not identify any particular Place. These should not be documented as instances of E45 Address.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E45_Address">crm:E45_Address</a>
    /// </summary>
    let E45_Address = _prefixId.prefix "E45_Address"
    /// <summary>
    ///   <para>rdfs:label : Désignation de sectionrdfs:label : Определение Районаrdfs:label : Section Definitionrdfs:label : Abschnittsdefinitionrdfs:label : Ονομασία Τμήματοςrdfs:label : Designação de Seção</para>
    ///   <para>rdfs:comment : This class comprises areas of objects referred to in terms specific to the general geometry or structure of its kind.
    /// The 'prow' of the boat, the 'frame' of the picture, the 'front' of the building are all instances of E46 Section Definition. The class highlights the fact that parts of objects can be treated as locations. This holds in particular for features without natural boundaries, such as the “head” of a marble statue made out of one block (cf. E53 Place). In answer to the question 'where is the signature?' one might reply 'on the lower left corner'. (Section Definition is closely related to the term “segment” in Gerstl, P.&amp; Pribbenow, S, 1996 “ A conceptual theory of part – whole relations and its applications”, Data &amp; Knowledge 	Engineering 20 305-322, North Holland- Elsevier ).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E46_Section_Definition">crm:E46_Section_Definition</a>
    /// </summary>
    let E46_Section_Definition = _prefixId.prefix "E46_Section_Definition"
    /// <summary>
    ///   <para>rdfs:label : Coordonnées spatialesrdfs:label : Пространственные Координатыrdfs:label : Χωρικές Συντεταγμένεςrdfs:label : Raumkoordinatenrdfs:label : Spatial Coordinatesrdfs:label : Coordenadas Espaciais</para>
    ///   <para>rdfs:comment : This class comprises the textual or numeric information required to locate specific instances of E53 Place within schemes of spatial identification.
    ///
    /// Coordinates are a specific form of E44 Place Appellation, that is, a means of referring to a particular E53 Place. Coordinates are not restricted to longitude, latitude and altitude. Any regular system of reference that maps onto an E19 Physical Object can be used to generate coordinates.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E47_Spatial_Coordinates">crm:E47_Spatial_Coordinates</a>
    /// </summary>
    let E47_Spatial_Coordinates = _prefixId.prefix "E47_Spatial_Coordinates"
    /// <summary>
    ///   <para>rdfs:label : Название Местаrdfs:label : Toponymerdfs:label : Τοπωνύμιοrdfs:label : Place Namerdfs:label : Orts- oder Flurnamerdfs:label : Nome de Local</para>
    ///   <para>rdfs:comment : This class comprises particular and common forms of E44 Place Appellation.
    /// Place Names may change their application over time: the name of an E53 Place may change, and a name may be reused for a different E53 Place. Instances of E48 Place Name are typically subject to place name gazetteers.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E48_Place_Name">crm:E48_Place_Name</a>
    /// </summary>
    let E48_Place_Name = _prefixId.prefix "E48_Place_Name"
    /// <summary>
    ///   <para>rdfs:label : Обозначение Времениrdfs:label : Ονομασία Χρόνουrdfs:label : Zeitbenennungrdfs:label : Time Appellationrdfs:label : Appellation temporellerdfs:label : Designação de Tempo</para>
    ///   <para>rdfs:comment : This class comprises all forms of names or codes, such as historical periods, and dates, which are characteristically used to refer to a specific E52 Time-Span.
    /// The instances of E49 Time Appellation may vary in their degree of precision, and they may be relative to other time frames, “Before Christ” for example. Instances of E52 Time-Span are often defined by reference to a cultural period or an event e.g. ‘the duration of the Ming Dynasty’.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E49_Time_Appellation">crm:E49_Time_Appellation</a>
    /// </summary>
    let E49_Time_Appellation = _prefixId.prefix "E49_Time_Appellation"
    /// <summary>
    ///   <para>rdfs:label : Phaserdfs:label : Periodrdfs:label : Périoderdfs:label : Периодrdfs:label : Περίοδοςrdfs:label : Período</para>
    ///   <para>rdfs:comment : 	This class comprises sets of coherent phenomena or cultural manifestations bounded in time and space.
    /// It is the social or physical coherence of these phenomena that identify an E4 Period and not the associated spatio-temporal bounds. These bounds are a mere approximation of the actual process of growth, spread and retreat. Consequently, different periods can overlap and coexist in time and space, such as when a nomadic culture exists in the same area as a sedentary culture.
    /// Typically this class is used to describe prehistoric or historic periods such as the “Neolithic Period”, the “Ming Dynasty” or the “McCarthy Era”. There are however no assumptions about the scale of the associated phenomena. In particular all events are seen as synthetic processes consisting of coherent phenomena. Therefore E4 Period is a superclass of E5 Event. For example, a modern clinical E67 Birth can be seen as both an atomic E5 Event and as an E4 Period that consists of multiple activities performed by multiple instances of E39 Actor.
    /// There are two different conceptualisations of ‘artistic style’, defined either by physical features or by historical context. For example, “Impressionism” can be viewed as a period lasting from approximately 1870 to 1905 during which paintings with particular characteristics were produced by a group of artists that included (among others) Monet, Renoir, Pissarro, Sisley and Degas. Alternatively, it can be regarded as a style applicable to all paintings sharing the characteristics of the works produced by the Impressionist painters, regardless of historical context. The first interpretation is an E4 Period, and the second defines morphological object types that fall under E55 Type.
    /// Another specific case of an E4 Period is the set of activities and phenomena associated with a settlement, such as the populated period of Nineveh.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E4_Period">crm:E4_Period</a>
    /// </summary>
    let E4_Period = _prefixId.prefix "E4_Period"
    /// <summary>
    ///   <para>rdfs:label : Datumrdfs:label : Ημερομηνίαrdfs:label : Датаrdfs:label : Daterdfs:label : Daterdfs:label : Data</para>
    ///   <para>rdfs:comment : This class comprises specific forms of E49 Time Appellation.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E50_Date">crm:E50_Date</a>
    /// </summary>
    let E50_Date = _prefixId.prefix "E50_Date"
    /// <summary>
    ///   <para>rdfs:label : Kontaktpunktrdfs:label : Στοιχείο Επικοινωνίαςrdfs:label : Coordonnées individuellesrdfs:label : Contact Pointrdfs:label : Контактrdfs:label : Ponto de Contato</para>
    ///   <para>rdfs:comment : This class comprises identifiers employed, or understood, by communication services to direct communications to an instance of E39 Actor. These include E-mail addresses, telephone numbers, post office boxes, Fax numbers, URLs etc. Most postal addresses can be considered both as instances of E44 Place Appellation and E51 Contact Point. In such cases the subclass E45 Address should be used.
    /// URLs are addresses used by machines to access another machine through an http request. Since the accessed machine acts on behalf of the E39 Actor providing the machine, URLs are considered as instances of E51 Contact Point to that E39 Actor.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E51_Contact_Point">crm:E51_Contact_Point</a>
    /// </summary>
    let E51_Contact_Point = _prefixId.prefix "E51_Contact_Point"
    /// <summary>
    ///   <para>rdfs:label : Duréerdfs:label : Zeitspannerdfs:label : Интервал Времениrdfs:label : Χρονικό Διάστημαrdfs:label : Time-Spanrdfs:label : Período de Tempo</para>
    ///   <para>rdfs:comment : This class comprises abstract temporal extents, in the sense of Galilean physics, having a beginning, an end and a duration.
    /// Time Span has no other semantic connotations. Time-Spans are used to define the temporal extent of instances of E4 Period, E5 Event and any other phenomena valid for a certain time. An E52 Time-Span may be identified by one or more instances of E49 Time Appellation.
    /// Since our knowledge of history is imperfect, instances of E52 Time-Span can best be considered as approximations of the actual Time-Spans of temporal entities. The properties of E52 Time-Span are intended to allow these approximations to be expressed precisely.  An extreme case of approximation, might, for example, define an E52 Time-Span having unknown beginning, end and duration. Used as a common E52 Time-Span for two events, it would nevertheless define them as being simultaneous, even if nothing else was known.
    /// 	Automatic processing and querying of instances of E52 Time-Span is facilitated if data can be parsed into an E61 Time Primitive.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E52_Time-Span">crm:E52_Time-Span</a>
    /// </summary>
    let E52_Time_Span = _prefixId.prefix "E52_Time-Span"
    /// <summary>
    ///   <para>rdfs:label : Lieurdfs:label : Placerdfs:label : Τόποςrdfs:label : Местоrdfs:label : Ortrdfs:label : Local</para>
    ///   <para>rdfs:comment : This class comprises extents in space, in particular on the surface of the earth, in the pure sense of physics: independent from temporal phenomena and matter.
    /// The instances of E53 Place are usually determined by reference to the position of “immobile” objects such as buildings, cities, mountains, rivers, or dedicated geodetic marks. A Place can be determined by combining a frame of reference and a location with respect to this frame. It may be identified by one or more instances of E44 Place Appellation.
    ///  It is sometimes argued that instances of E53 Place are best identified by global coordinates or absolute reference systems. However, relative references are often more relevant in the context of cultural documentation and tend to be more precise. In particular, we are often interested in position in relation to large, mobile objects, such as ships. For example, the Place at which Nelson died is known with reference to a large mobile object – H.M.S Victory. A resolution of this Place in terms of absolute coordinates would require knowledge of the movements of the vessel and the precise time of death, either of which may be revised, and the result would lack historical and cultural relevance.
    /// Any object can serve as a frame of reference for E53 Place determination. The model foresees the notion of a "section" of an E19 Physical Object as a valid E53 Place determination.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E53_Place">crm:E53_Place</a>
    /// </summary>
    let E53_Place = _prefixId.prefix "E53_Place"
    /// <summary>
    ///   <para>rdfs:label : Dimensionrdfs:label : Dimensionsrdfs:label : Μέγεθοςrdfs:label : Величинаrdfs:label : Maßrdfs:label : Dimensão</para>
    ///   <para>rdfs:comment : This class comprises quantifiable properties that can be measured by some calibrated means and can be approximated by values, i.e. points or regions in a mathematical or conceptual space, such as natural or real numbers, RGB values etc.
    /// An instance of E54 Dimension represents the true quantity, independent from its numerical approximation, e.g. in inches or in cm. The properties of the class E54 Dimension allow for expressing the numerical approximation of the values of an instance of E54 Dimension. If the true values belong to a non-discrete space, such as spatial distances, it is recommended to record them as approximations by intervals or regions of indeterminacy enclosing the assumed true values. For instance, a length of 5 cm may be recorded as 4.5-5.5 cm, according to the precision of the respective observation. Note, that interoperability of values described in different units depends critically on the representation as value regions.
    /// Numerical approximations in archaic instances of E58 Measurement Unit used in historical records should be preserved. Equivalents corresponding to current knowledge should be recorded as additional instances of E54 Dimension as appropriate.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E54_Dimension">crm:E54_Dimension</a>
    /// </summary>
    let E54_Dimension = _prefixId.prefix "E54_Dimension"
    /// <summary>
    ///   <para>rdfs:label : Τύποςrdfs:label : Typerdfs:label : Typerdfs:label : Типrdfs:label : Typusrdfs:label : Tipo</para>
    ///   <para>rdfs:comment : This class comprises concepts denoted by terms from thesauri and controlled vocabularies used to characterize and classify instances of CRM classes. Instances of E55 Type represent concepts  in contrast to instances of E41 Appellation which are used to name instances of CRM classes.
    /// E55 Type is the CRM’s interface to domain specific ontologies and thesauri. These can be represented in the CRM as subclasses of E55 Type, forming hierarchies of terms, i.e. instances of E55 Type linked via P127 has broader  term (has narrower term). Such hierarchies may be extended with additional properties.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E55_Type">crm:E55_Type</a>
    /// </summary>
    let E55_Type = _prefixId.prefix "E55_Type"
    /// <summary>
    ///   <para>rdfs:label : Languerdfs:label : Языкrdfs:label : Languagerdfs:label : Γλώσσαrdfs:label : Spracherdfs:label : Língua</para>
    ///   <para>rdfs:comment : This class is a specialization of E55 Type and comprises the natural languages in the sense of concepts.
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E56 Language, e.g.: “instances of  Mandarin Chinese”.
    /// It is recommended that internationally or nationally agreed codes and terminology are used to denote instances of E56 Language, such as those defined in ISO 639:1988.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E56_Language">crm:E56_Language</a>
    /// </summary>
    let E56_Language = _prefixId.prefix "E56_Language"
    /// <summary>
    ///   <para>rdfs:label : Matériaurdfs:label : Υλικόrdfs:label : Материалrdfs:label : Materialrdfs:label : Materialrdfs:label : Material</para>
    ///   <para>rdfs:comment : This class is a specialization of E55 Type and comprises the concepts of materials.
    /// Instances of E57 Material may denote properties of matter before its use, during its use, and as incorporated in an object, such as ultramarine powder, tempera paste, reinforced concrete. Discrete pieces of raw-materials kept in museums, such as bricks, sheets of fabric, pieces of metal, should be modelled individually in the same way as other objects. Discrete used or processed pieces, such as the stones from Nefer Titi's temple, should be modelled as parts (cf. P46 is composed of).
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E57 Material, e.g.: “instances of  gold”.
    /// It is recommended that internationally or nationally agreed codes and terminology are used.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E57_Material">crm:E57_Material</a>
    /// </summary>
    let E57_Material = _prefixId.prefix "E57_Material"
    /// <summary>
    ///   <para>rdfs:label : Unité de mesurerdfs:label : Measurement Unitrdfs:label : Μονάδα Μέτρησηςrdfs:label : Maßeinheitrdfs:label : Единица Измеренияrdfs:label : Unidade de Medida</para>
    ///   <para>rdfs:comment : This class is a specialization of E55 Type and comprises the types of measurement units: feet, inches, centimetres, litres, lumens, etc.
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E58 Measurement Unit, e.g.: “instances of cm”.
    /// Syst?me International (SI) units or internationally recognized non-SI terms should be used whenever possible. (ISO 1000:1992). Archaic Measurement Units used in historical records should be preserved.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E58_Measurement_Unit">crm:E58_Measurement_Unit</a>
    /// </summary>
    let E58_Measurement_Unit = _prefixId.prefix "E58_Measurement_Unit"
    /// <summary>
    ///   <para>rdfs:label : Συμβάνrdfs:label : Événementrdfs:label : Событиеrdfs:label : Eventrdfs:label : Ereignisrdfs:label : Evento</para>
    ///   <para>rdfs:comment : This class comprises changes of states in cultural, social or physical systems, regardless of scale, brought about by a series or group of coherent physical, cultural, technological or legal phenomena. Such changes of state will affect instances of E77 Persistent Item or its subclasses.
    /// The distinction between an E5 Event and an E4 Period is partly a question of the scale of observation. Viewed at a coarse level of detail, an E5 Event is an ‘instantaneous’ change of state. At a fine level, the E5 Event can be analysed into its component phenomena within a space and time frame, and as such can be seen as an E4 Period. The reverse is not necessarily the case: not all instances of E4 Period give rise to a noteworthy change of state.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E5_Event">crm:E5_Event</a>
    /// </summary>
    let E5_Event = _prefixId.prefix "E5_Event"
    /// <summary>
    ///   <para>rdfs:label : Début d'existencerdfs:label : Beginning of Existencerdfs:label : Daseinsbeginnrdfs:label : Αρχή Ύπαρξηςrdfs:label : Начало Существованияrdfs:label : Início da Existência</para>
    ///   <para>rdfs:comment : This class comprises events that bring into existence any E77 Persistent Item.
    /// It may be used for temporal reasoning about things (intellectual products, physical items, groups of people, living beings) beginning to exist; it serves as a hook for determination of a terminus post quem and ante quem. </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E63_Beginning_of_Existence">crm:E63_Beginning_of_Existence</a>
    /// </summary>
    let E63_Beginning_of_Existence = _prefixId.prefix "E63_Beginning_of_Existence"
    /// <summary>
    ///   <para>rdfs:label : Daseinsenderdfs:label : Конец Существованияrdfs:label : Τέλος Ύπαρξηςrdfs:label : Fin d'existencerdfs:label : End of Existencerdfs:label : Fim da Existência</para>
    ///   <para>rdfs:comment : This class comprises events that end the existence of any E77 Persistent Item.
    /// It may be used for temporal reasoning about things (physical items, groups of people, living beings) ceasing to exist; it serves as a hook for determination of a terminus postquem and antequem. In cases where substance from a Persistent Item continues to exist in a new form, the process would be documented by E81 Transformation.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E64_End_of_Existence">crm:E64_End_of_Existence</a>
    /// </summary>
    let E64_End_of_Existence = _prefixId.prefix "E64_End_of_Existence"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises events that result in the creation of conceptual items or immaterial products, such as legends, poems, texts, music, images, movies, laws, types etc.
    /// </para>
    ///   <para>rdfs:label : Creationrdfs:label : Créationrdfs:label : Событие Творенияrdfs:label : Δημιουργίαrdfs:label : Criaçãordfs:label : Begriffliche Schöpfung</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E65_Creation">crm:E65_Creation</a>
    /// </summary>
    let E65_Creation = _prefixId.prefix "E65_Creation"
    /// <summary>
    ///   <para>rdfs:label : Gruppenbildungrdfs:label : Formationrdfs:label : Formationrdfs:label : Formaçãordfs:label : Событие Формированияrdfs:label : Συγκρότηση Ομάδας</para>
    ///   <para>rdfs:comment : This class comprises events that result in the formation of a formal or informal E74 Group of people, such as a club, society, association, corporation or nation.
    /// E66 Formation does not include the arbitrary aggregation of people who do not act as a collective.
    /// The formation of an instance of E74 Group does not mean that the group is populated with members at the time of formation. In order to express the joining of members at the time of formation, the respective activity should be simultaneously an instance of both E66 Formation and E85 Joining.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E66_Formation">crm:E66_Formation</a>
    /// </summary>
    let E66_Formation = _prefixId.prefix "E66_Formation"
    /// <summary>
    ///   <para>rdfs:label : Birthrdfs:label : Рождениеrdfs:label : Naissancerdfs:label : Geburtrdfs:label : Γέννησηrdfs:label : Nascimento</para>
    ///   <para>rdfs:comment : This class comprises the births of human beings. E67 Birth is a biological event focussing on the context of people coming into life. (E63 Beginning of Existence comprises the coming into life of any living beings).
    /// Twins, triplets etc. are brought into life by the same E67 Birth event. The introduction of the E67 Birth event as a documentation element allows the description of a range of family relationships in a simple model. Suitable extensions may describe more details and the complexity of motherhood with the intervention of modern medicine. In this model, the biological father is not seen as a necessary participant in the E67 Birth event.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E67_Birth">crm:E67_Birth</a>
    /// </summary>
    let E67_Birth = _prefixId.prefix "E67_Birth"
    /// <summary>
    ///   <para>rdfs:label : Роспускrdfs:label : Gruppenauflösungrdfs:label : Διάλυση Ομάδαςrdfs:label : Dissolutionrdfs:label : Dissolutionrdfs:label : Dissolução</para>
    ///   <para>rdfs:comment : This class comprises the events that result in the formal or informal termination of an E74 Group of people.
    /// If the dissolution was deliberate, the Dissolution event should also be instantiated as an E7 Activity.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E68_Dissolution">crm:E68_Dissolution</a>
    /// </summary>
    let E68_Dissolution = _prefixId.prefix "E68_Dissolution"
    /// <summary>
    ///   <para>rdfs:label : Смертьrdfs:label : Deathrdfs:label : Todrdfs:label : Mortrdfs:label : Θάνατοςrdfs:label : Morte</para>
    ///   <para>rdfs:comment : This class comprises the deaths of human beings.
    /// If a person is killed, their death should be instantiated as E69 Death and as E7 Activity. The death or perishing of other living beings should be documented using E64 End of Existence.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E69_Death">crm:E69_Death</a>
    /// </summary>
    let E69_Death = _prefixId.prefix "E69_Death"
    /// <summary>
    ///   <para>rdfs:label : Разрушениеrdfs:label : Destructionrdfs:label : Destructionrdfs:label : Zerstörungrdfs:label : Καταστροφήrdfs:label : Destruição</para>
    ///   <para>rdfs:comment : This class comprises events that destroy one or more instances of E18 Physical Thing such that they lose their identity as the subjects of documentation.
    /// Some destruction events are intentional, while others are independent of human activity. Intentional destruction may be documented by classifying the event as both an E6 Destruction and E7 Activity.
    /// The decision to document an object as destroyed, transformed or modified is context sensitive:
    /// 1.  If the matter remaining from the destruction is not documented, the event is modelled solely as E6 Destruction.
    /// 2. An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the original. In this case, the new items have separate identities. Matter is preserved, but identity is not.
    /// 3. When the initial identity of the changed instance of E18 Physical Thing is preserved, the event should be documented as E11 Modification.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E6_Destruction">crm:E6_Destruction</a>
    /// </summary>
    let E6_Destruction = _prefixId.prefix "E6_Destruction"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : Choserdfs:label : Thingrdfs:label : Πράγμαrdfs:label : Sacherdfs:label : Coisa</para>
    ///   <para>rdfs:comment : This general class comprises usable discrete, identifiable, instances of E77 Persistent Item that are documented as single units.
    ///
    /// They can be either intellectual products or physical things, and are characterized by relative stability. They may for instance either have a solid physical form, an electronic encoding, or they may be logical concept or structure.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E70_Thing">crm:E70_Thing</a>
    /// </summary>
    let E70_Thing = _prefixId.prefix "E70_Thing"
    /// <summary>
    ///   <para>rdfs:label : Künstlichesrdfs:label : Chose fabriquéerdfs:label : Рукотворная Вещьrdfs:label : Man-Made Thingrdfs:label : Ανθρώπινο Δημιούργημαrdfs:label : Coisa Fabricada</para>
    ///   <para>rdfs:comment : This class comprises discrete, identifiable man-made items that are documented as single units.
    /// These items are either intellectual products or man-made physical things, and are characterized by relative stability. They may for instance have a solid physical form, an electronic encoding, or they may be logical concepts or structures.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E71_Man-Made_Thing">crm:E71_Man-Made_Thing</a>
    /// </summary>
    let E71_Man_Made_Thing = _prefixId.prefix "E71_Man-Made_Thing"
    /// <summary>
    ///   <para>rdfs:label : Objet juridiquerdfs:label : Объект Праваrdfs:label : Νομικό Αντικείμενοrdfs:label : Legal Objectrdfs:label : Rechtsobjektrdfs:label : Objeto Jurídico</para>
    ///   <para>rdfs:comment : This class comprises those material or immaterial items to which instances of E30 Right, such as the right of ownership or use, can be applied.
    /// This is true for all E18 Physical Thing. In the case of instances of E28 Conceptual Object, however, the identity of the E28 Conceptual Object or the method of its use may be too ambiguous to reliably establish instances of E30 Right, as in the case of taxa and inspirations. Ownership of corporations is currently regarded as out of scope of the CRM.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E72_Legal_Object">crm:E72_Legal_Object</a>
    /// </summary>
    let E72_Legal_Object = _prefixId.prefix "E72_Legal_Object"
    /// <summary>
    ///   <para>rdfs:label : Informationsgegenstandrdfs:label : Information Objectrdfs:label : Objeto de Informaçãordfs:label : Информационный Объектrdfs:label : Πληροφοριακό Αντικείμενοrdfs:label : Objet d'information</para>
    ///   <para>rdfs:comment : This class comprises identifiable immaterial items, such as a poems, jokes, data sets, images, texts, multimedia objects, procedural prescriptions, computer program code, algorithm or mathematical formulae, that have an objectively recognizable structure and are documented as single units.
    /// An E73 Information Object does not depend on a specific physical carrier, which can include human memory, and it can exist on one or more carriers simultaneously.
    /// Instances of E73 Information Object of a linguistic nature should be declared as instances of the E33 Linguistic Object subclass. Instances of E73 Information Object of a documentary nature should be declared as instances of the E31 Document subclass. Conceptual items such as types and classes are not instances of E73 Information Object, nor are ideas without a reproducible expression.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E73_Information_Object">crm:E73_Information_Object</a>
    /// </summary>
    let E73_Information_Object = _prefixId.prefix "E73_Information_Object"
    /// <summary>
    ///   <para>rdfs:label : Группаrdfs:label : Grouprdfs:label : Ομάδαrdfs:label : Menschliche Grupperdfs:label : Grouperdfs:label : Grupo</para>
    ///   <para>rdfs:comment : This class comprises any gatherings or organizations of two or more people that act collectively or in a similar way due to any form of unifying relationship. In the wider sense this class also comprises official positions which used to be regarded in certain contexts as one actor, independent of the current holder of the office, such as the president of a country.
    /// A gathering of people becomes an E74 Group when it exhibits organizational characteristics usually typified by a set of ideas or beliefs held in common, or actions performed together. These might be communication, creating some common artifact, a common purpose such as study, worship, business, sports, etc. Nationality can be modeled as membership in an E74 Group (cf. HumanML markup). Married couples and other concepts of family are regarded as particular examples of E74 Group.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E74_Group">crm:E74_Group</a>
    /// </summary>
    let E74_Group = _prefixId.prefix "E74_Group"

    /// <summary>
    ///   <para>rdfs:label : Appellation d'objet conceptuelrdfs:label : Обозначение Концептуального Объектаrdfs:label : Begriff- oder Konzeptbenennung rdfs:label : Conceptual Object Appellationrdfs:label : Ονομασία Νοητικού Αντικειμένουrdfs:label : Designação de Objeto Conceitual</para>
    ///   <para>rdfs:comment : This class comprises all appellations specific to intellectual products or standardized patterns.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E75_Conceptual_Object_Appellation">crm:E75_Conceptual_Object_Appellation</a>
    /// </summary>
    let E75_Conceptual_Object_Appellation =
        _prefixId.prefix "E75_Conceptual_Object_Appellation"

    /// <summary>
    ///   <para>rdfs:label : Persistent Itemrdfs:label : Постоянная Сущностьrdfs:label : Seiendesrdfs:label : Ονrdfs:label : Entité persistanterdfs:label : Entidade Persistente</para>
    ///   <para>rdfs:comment : This class comprises items that have a persistent identity, sometimes known as “endurants” in philosophy.
    /// They can be repeatedly recognized within the duration of their existence by identity criteria rather than by continuity or observation. Persistent Items can be either physical entities, such as people, animals or things, or conceptual entities such as ideas, concepts, products of the imagination or common names.
    /// The criteria that determine the identity of an item are often difficult to establish -; the decision depends largely on the judgement of the observer. For example, a building is regarded as no longer existing if it is dismantled and the materials reused in a different configuration. On the other hand, human beings go through radical and profound changes during their life-span, affecting both material composition and form, yet preserve their identity by other criteria. Similarly, inanimate objects may be subject to exchange of parts and matter. The class E77 Persistent Item does not take any position about the nature of the applicable identity criteria and if actual knowledge about identity of an instance of this class exists. There may be cases, where the identity of an E77 Persistent Item is not decidable by a certain state of knowledge.
    /// The main classes of objects that fall outside the scope the E77 Persistent Item class are temporal objects such as periods, events and acts, and descriptive properties. </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E77_Persistent_Item">crm:E77_Persistent_Item</a>
    /// </summary>
    let E77_Persistent_Item = _prefixId.prefix "E77_Persistent_Item"
    /// <summary>
    ///   <para>rdfs:label : Коллекцияrdfs:label : Συλλογήrdfs:label : Collectionrdfs:label : Collectionrdfs:label : Sammlungrdfs:label : Coleção</para>
    ///   <para>rdfs:comment : This class comprises aggregations of instances of E18 Physical Thing that are assembled and maintained (“curated” and “preserved,” in museological terminology) by one or more instances of E39 Actor over time for a specific purpose and audience, and according to a particular collection development plan.
    /// Items may be added or removed from an E78 Collection in pursuit of this plan. This class should not be confused with the E39 Actor maintaining the E78 Collection often referred to with the name of the E78 Collection (e.g. “The Wallace Collection decided…”).
    /// Collective objects in the general sense, like a tomb full of gifts, a folder with stamps or a set of chessmen, should be documented as instances of E19 Physical Object, and not as instances of E78 Collection. This is because they form wholes either because they are physically bound together or because they are kept together for their functionality.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E78_Collection">crm:E78_Collection</a>
    /// </summary>
    let E78_Collection = _prefixId.prefix "E78_Collection"
    /// <summary>
    ///   <para>rdfs:label : Addition d'élémentrdfs:label : Part Additionrdfs:label : Teilhinzufügungrdfs:label : Добавление Частиrdfs:label : Προσθήκη Μερώνrdfs:label : Adição de Parte</para>
    ///   <para>rdfs:comment : This class comprises activities that result in an instance of E24 Physical Man-Made Thing being increased, enlarged or augmented by the addition of a part.
    /// Typical scenarios include the attachment of an accessory, the integration of a component, the addition of an element to an aggregate object, or the accessioning of an object into a curated E78 Collection. Objects to which parts are added are, by definition, man-made, since the addition of a part implies a human activity. Following the addition of parts, the resulting man-made assemblages are treated objectively as single identifiable wholes, made up of constituent or component parts bound together either physically (for example the engine becoming a part of the car), or by sharing a common purpose (such as the 32 chess pieces that make up a chess set). This class of activities forms a basis for reasoning about the history and continuity of identity of objects that are integrated into other objects over time, such as precious gemstones being repeatedly incorporated into different items of jewellery, or cultural artifacts being added to different museum instances of E78 Collection over their lifespan.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E79_Part_Addition">crm:E79_Part_Addition</a>
    /// </summary>
    let E79_Part_Addition = _prefixId.prefix "E79_Part_Addition"
    /// <summary>
    ///   <para>rdfs:label : Activityrdfs:label : Activitérdfs:label : Handlungrdfs:label : Деятельностьrdfs:label : Δράσηrdfs:label : Atividade</para>
    ///   <para>rdfs:comment : This class comprises actions intentionally carried out by instances of E39 Actor that result in changes of state in the cultural, social, or physical systems documented.
    /// This notion includes complex, composite and long-lasting actions such as the building of a settlement or a war, as well as simple, short-lived actions such as the opening of a door.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E7_Activity">crm:E7_Activity</a>
    /// </summary>
    let E7_Activity = _prefixId.prefix "E7_Activity"
    /// <summary>
    ///   <para>rdfs:label : Teilentfernungrdfs:label : Soustraction d'élémentrdfs:label : Part Removalrdfs:label : Удаление Частиrdfs:label : Αφαίρεση Μερώνrdfs:label : Remoção de Parte</para>
    ///   <para>rdfs:comment : This class comprises the activities that result in an instance of E18 Physical Thing being decreased by the removal of a part.
    /// Typical scenarios include the detachment of an accessory, the removal of a component or part of a composite object, or the deaccessioning of an object from a curated E78 Collection. If the E80 Part Removal results in the total decomposition of the original object into pieces, such that the whole ceases to exist, the activity should instead be modelled as an E81 Transformation, i.e. a simultaneous destruction and production. In cases where the part removed has no discernible identity prior to its removal but does have an identity subsequent to its removal, the activity should be regarded as both E80 Part Removal and E12 Production. This class of activities forms a basis for reasoning about the history, and continuity of identity over time, of objects that are removed from other objects, such as precious gemstones being extracted from different items of jewelry, or cultural artifacts being deaccessioned from different museum collections over their lifespan.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E80_Part_Removal">crm:E80_Part_Removal</a>
    /// </summary>
    let E80_Part_Removal = _prefixId.prefix "E80_Part_Removal"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises the events that result in the simultaneous destruction of one or more than one E77 Persistent Item and the creation of one or more than one E77 Persistent Item that preserves recognizable substance from the first one(s) but has fundamentally different nature and identity.
    /// Although the old and the new instances of E77 Persistent Item are treated as discrete entities having separate, unique identities, they are causally connected through the E81 Transformation; the destruction of the old E77 Persistent Item(s) directly causes the creation of the new one(s) using or preserving some relevant substance. Instances of E81 Transformation are therefore distinct from re-classifications (documented using E17 Type Assignment) or modifications (documented using E11 Modification) of objects that do not fundamentally change their nature or identity. Characteristic cases are reconstructions and repurposing of historical buildings or ruins, fires leaving buildings in ruins, taxidermy of specimen in natural history and the reorganization of a corporate body into a new one.
    /// </para>
    ///   <para>rdfs:label : Umwandlungrdfs:label : Трансформацияrdfs:label : Transformationrdfs:label : Transformationrdfs:label : Transformaçãordfs:label : Μετατροπή</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E81_Transformation">crm:E81_Transformation</a>
    /// </summary>
    let E81_Transformation = _prefixId.prefix "E81_Transformation"
    /// <summary>
    ///   <para>rdfs:label : Actor Appellationrdfs:label : Обозначение Агентаrdfs:label : Ονομασία Δράστηrdfs:label : Appellation d'agentrdfs:label : Akteurbenennungrdfs:label : Designação de Agente</para>
    ///   <para>rdfs:comment : This class comprises any sort of name, number, code or symbol characteristically used to identify an E39 Actor.
    /// An E39 Actor will typically have more than one E82 Actor Appellation, and instances of E82 Actor Appellation in turn may have alternative representations. The distinction between corporate and personal names, which is particularly important in library applications, should be made by explicitly linking the E82 Actor Appellation to an instance of either E21 Person or E74 Group/E40 Legal Body. If this is not possible, the distinction can be made through the use of the P2 has type mechanism.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E82_Actor_Appellation">crm:E82_Actor_Appellation</a>
    /// </summary>
    let E82_Actor_Appellation = _prefixId.prefix "E82_Actor_Appellation"
    /// <summary>
    ///   <para>rdfs:label : Typuserfindungrdfs:label : Создание Типаrdfs:label : Type Creationrdfs:label : Création de typerdfs:label : Δημιουργία Τύπουrdfs:label : Criação de Tipo</para>
    ///   <para>rdfs:comment : This class comprises activities formally defining new types of items.
    /// It is typically a rigorous scholarly or scientific process that ensures a type is exhaustively described and appropriately named. In some cases, particularly in archaeology and the life sciences, E83 Type Creation requires the identification of an exemplary specimen and the publication of the type definition in an appropriate scholarly forum. The activity of E83 Type Creation is central to research in the life sciences, where a type would be referred to as a “taxon,” the type description as a “protologue,” and the exemplary specimens as “orgininal element” or “holotype”.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E83_Type_Creation">crm:E83_Type_Creation</a>
    /// </summary>
    let E83_Type_Creation = _prefixId.prefix "E83_Type_Creation"
    /// <summary>
    ///   <para>rdfs:label : Φορέας Πληροφορίαςrdfs:label : Information Carrierrdfs:label : Носитель Информацииrdfs:label : Support d'informationrdfs:label : Informationsträgerrdfs:label : Suporte de Informação</para>
    ///   <para>rdfs:comment : This class comprises all instances of E22 Man-Made Object that are explicitly designed to act as persistent physical carriers for instances of E73 Information Object.
    /// This allows a relationship to be asserted between an E19 Physical Object and its immaterial information contents. An E84 Information Carrier may or may not contain information, e.g., a diskette. Note that any E18 Physical Thing may carry information, such as an E34 Inscription. However, unless it was specifically designed for this purpose, it is not an Information Carrier. Therefore the property P128 carries (is carried by) applies to E18 Physical Thing in general.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E84_Information_Carrier">crm:E84_Information_Carrier</a>
    /// </summary>
    let E84_Information_Carrier = _prefixId.prefix "E84_Information_Carrier"
    /// <summary>
    ///   <para>rdfs:label : Beitrittrdfs:label : Joining</para>
    ///   <para>rdfs:comment : This class comprises the activities that result in an instance of E39 Actor becoming a member of an instance of E74 Group. This class does not imply initiative by either party.
    /// Typical scenarios include becoming a member of a social organisation, becoming employee of a company, marriage, the adoption of a child by a family and the inauguration of somebody into an official position.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E85_Joining">crm:E85_Joining</a>
    /// </summary>
    let E85_Joining = _prefixId.prefix "E85_Joining"
    /// <summary>
    ///   <para>rdfs:label : Austrittrdfs:label : Leaving</para>
    ///   <para>rdfs:comment : This class comprises the activities that result in an instance of E39 Actor to be disassociated from an instance of E74 Group. This class does not imply initiative by either party.
    /// Typical scenarios include the termination of membership in a social organisation, ending the employment at a company, divorce, and the end of tenure of somebody in an official position.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E86_Leaving">crm:E86_Leaving</a>
    /// </summary>
    let E86_Leaving = _prefixId.prefix "E86_Leaving"
    /// <summary>
    ///   <para>rdfs:label : Kuratorische Tätigkeitrdfs:label : Curation Activity</para>
    ///   <para>rdfs:comment : This class comprises the activities that result in the continuity of management and the preservation and evolution of instances of E78 Collection, following an implicit or explicit curation plan.
    /// It specializes the notion of activity into the curation of a collection and allows the history of curation to be recorded.
    /// Items are accumulated and organized following criteria like subject, chronological period, material type, style of art etc. and can be added or removed from an E78 Collection for a specific purpose and/or audience. The initial aggregation of items of a collection is regarded as an instance of E12 Production Event while the activity of evolving, preserving and promoting a collection is regarded as an instance of E87 Curation Activity.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E87_Curation_Activity">crm:E87_Curation_Activity</a>
    /// </summary>
    let E87_Curation_Activity = _prefixId.prefix "E87_Curation_Activity"
    /// <summary>
    ///   <para>rdfs:label : Aussagenobjektrdfs:label : Propositional Object</para>
    ///   <para>rdfs:comment : This class comprises immaterial items, including but not limited to stories, plots, procedural prescriptions, algorithms, laws of physics or images that are, or represent in some sense, sets of propositions about real or imaginary things and that are documented as single units or serve as topics of discourse.
    ///
    /// This class also comprises items that are “about” something in the sense of a subject. In the wider sense, this class includes expressions of psychological value such as non-figural art and musical themes. However, conceptual items such as types and classes are not instances of E89 Propositional Object. This should not be confused with the definition of a type, which is indeed an instance of E89 Propositional Object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E89_Propositional_Object">crm:E89_Propositional_Object</a>
    /// </summary>
    let E89_Propositional_Object = _prefixId.prefix "E89_Propositional_Object"
    /// <summary>
    ///   <para>rdfs:label : Acquisitionrdfs:label : Απόκτησηrdfs:label : Событие Приобретенияrdfs:label : Acquisitionrdfs:label : Erwerbrdfs:label : Aquisição</para>
    ///   <para>rdfs:comment : This class comprises transfers of legal ownership from one or more instances of E39 Actor to one or more other instances of E39 Actor.
    /// The class also applies to the establishment or loss of ownership of instances of E18 Physical Thing. It does not, however, imply changes of any other kinds of right. The recording of the donor and/or recipient is optional. It is possible that in an instance of E8 Acquisition there is either no donor or no recipient. Depending on the circumstances, it may describe:
    /// 1.	the beginning of ownership
    /// 2.	the end of ownership
    /// 3.	the transfer of ownership
    /// 4.	the acquisition from an unknown source
    /// 5.	the loss of title due to destruction of the item
    /// It may also describe events where a collector appropriates legal title, for example by annexation or field collection. The interpretation of the museum notion of "accession" differs between institutions. The CRM therefore models legal ownership (E8 Acquisition) and physical custody (E10 Transfer of Custody) separately. Institutions will then model their specific notions of accession and deaccession as combinations of these.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E8_Acquisition">crm:E8_Acquisition</a>
    /// </summary>
    let E8_Acquisition = _prefixId.prefix "E8_Acquisition"
    /// <summary>
    ///   <para>rdfs:label : Symbolisches Objektrdfs:label : Symbolic Object</para>
    ///   <para>rdfs:comment : This class comprises identifiable symbols and any aggregation of symbols, such as characters, identifiers, traffic signs, emblems, texts, data sets, images, musical scores, multimedia objects, computer program code or mathematical formulae that have an objectively recognizable structure and that are documented as single units.
    /// It includes sets of signs of any nature, which may serve to designate something, or to communicate some propositional content.
    /// An instance of E90 Symbolic Object does not depend on a specific physical carrier, which can include human memory, and it can exist on one or more carriers simultaneously. An instance of E90 Symbolic Object may or may not have a specific meaning, for example an arbitrary character string.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E90_Symbolic_Object">crm:E90_Symbolic_Object</a>
    /// </summary>
    let E90_Symbolic_Object = _prefixId.prefix "E90_Symbolic_Object"
    /// <summary>
    ///   <para>rdfs:label : Moverdfs:label : Μετακίνησηrdfs:label : Objektbewegungrdfs:label : Перемещениеrdfs:label : Déplacementrdfs:label : Locomoção</para>
    ///   <para>rdfs:comment : This class comprises changes of the physical location of the instances of E19 Physical Object.
    /// Note, that the class E9 Move inherits the property P7 took place at (witnessed): E53 Place. This property should be used to describe the trajectory or a larger area within which a move takes place, whereas the properties P26 moved to (was destination of), P27 moved from (was origin of) describe the start and end points only. Moves may also be documented to consist of other moves (via P9 consists of (forms part of)), in order to describe intermediate stages on a trajectory. In that case, start and end points of the partial moves should match appropriately between each other and with the overall event.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/E9_Move">crm:E9_Move</a>
    /// </summary>
    let E9_Move = _prefixId.prefix "E9_Move"
    /// <summary>
    ///   <para>rdfs:label : был смертью дляrdfs:label : was death ofrdfs:label : ήταν θάνατος του/τηςrdfs:label : Tod vonrdfs:label : foi a morte para rdfs:label : a été la mort de</para>
    ///   <para>rdfs:comment : This property property links an E69 Death event to the E21 Person that died.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P100_was_death_of">crm:P100_was_death_of</a>
    /// </summary>
    let P100_was_death_of = _prefixId.prefix "P100_was_death_of"
    let P100i_died_in = _prefixId.prefix "P100i_died_in"
    /// <summary>
    ///   <para>rdfs:label : had as general userdfs:label : tem como uso geralrdfs:label : είχε ως γενική χρήσηrdfs:label : имел основное применениеrdfs:label : hatte die allgemeine Verwendungrdfs:label : avait comme utilisation générale</para>
    ///   <para>rdfs:comment : This property links an instance of E70 Thing to an E55 Type of usage.
    /// It allows the relationship between particular things, both physical and immaterial, and general methods and techniques of use to be documented. Thus it can be asserted that a baseball bat had a general use for sport and a specific use for threatening people during the Great Train Robbery.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P101_had_as_general_use">crm:P101_had_as_general_use</a>
    /// </summary>
    let P101_had_as_general_use = _prefixId.prefix "P101_had_as_general_use"
    /// <summary>
    ///   <para>rdfs:label : war die Verwendung vonrdfs:label : was use ofrdfs:label : était l’utilisation derdfs:label : был применением дляrdfs:label : ήταν χρήση του/τηςrdfs:label : foi uso de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P101i_was_use_of">crm:P101i_was_use_of</a>
    /// </summary>
    let P101i_was_use_of = _prefixId.prefix "P101i_was_use_of"
    /// <summary>
    ///   <para>rdfs:label : έχει τίτλοrdfs:label : a pour titrerdfs:label : trägt den Titelrdfs:label : has titlerdfs:label : имеет заголовокrdfs:label : tem título</para>
    ///   <para>rdfs:comment : This property describes the E35 Title applied to an instance of E71 Man-Made Thing. The E55 Type of Title is assigned in a sub property.
    /// The P102.1 has type property of the P102 has title (is title of) property enables the relationship between the Title and the thing to be further clarified, for example, if the Title was a given Title, a supplied Title etc.
    /// It allows any man-made material or immaterial thing to be given a Title. It is possible to imagine a Title being created without a specific object in mind.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P102_has_title">crm:P102_has_title</a>
    /// </summary>
    let P102_has_title = _prefixId.prefix "P102_has_title"
    /// <summary>
    ///   <para>rdfs:label : is title ofrdfs:label : είναι τίτλος του/τηςrdfs:label : est le titre derdfs:label : ist der Titel vonrdfs:label : является заголовком дляrdfs:label : é título de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P102i_is_title_of">crm:P102i_is_title_of</a>
    /// </summary>
    let P102i_is_title_of = _prefixId.prefix "P102i_is_title_of"
    /// <summary>
    ///   <para>rdfs:label : был задуман дляrdfs:label : bestimmt fürrdfs:label : προοριζόταν γιαrdfs:label : était destiné àrdfs:label : was intended forrdfs:label : era destinado à</para>
    ///   <para>rdfs:comment : This property links an instance of E71 Man-Made Thing to an E55 Type of usage.
    /// It creates a property between specific man-made things, both physical and immaterial, to Types of intended methods and techniques of use. Note: A link between specific man-made things and a specific use activity should be expressed using P19 was intended use of (was made for).</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P103_was_intended_for">crm:P103_was_intended_for</a>
    /// </summary>
    let P103_was_intended_for = _prefixId.prefix "P103_was_intended_for"
    /// <summary>
    ///   <para>rdfs:label : war Bestimmung vonrdfs:label : was intention ofrdfs:label : был интенцией дляrdfs:label : ήταν προορισμός τουrdfs:label : était la raison d'être derdfs:label : era a destinação de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P103i_was_intention_of">crm:P103i_was_intention_of</a>
    /// </summary>
    let P103i_was_intention_of = _prefixId.prefix "P103i_was_intention_of"
    /// <summary>
    ///   <para>rdfs:label : υπόκειται σεrdfs:label : является объектом дляrdfs:label : Gegenstand vonrdfs:label : est sujet àrdfs:label : is subject tordfs:label : está sujeito à</para>
    ///   <para>rdfs:comment : This property links a particular E72 Legal Object to the instances of E30 Right to which it is subject.
    /// The Right is held by an E39 Actor as described by P75 possesses (is possessed by).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P104_is_subject_to">crm:P104_is_subject_to</a>
    /// </summary>
    let P104_is_subject_to = _prefixId.prefix "P104_is_subject_to"
    /// <summary>
    ///   <para>rdfs:label : ισχύει γιαrdfs:label : s’applique àrdfs:label : findet Anwendung aufrdfs:label : применяется кrdfs:label : applies tordfs:label : se aplicam à</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P104i_applies_to">crm:P104i_applies_to</a>
    /// </summary>
    let P104i_applies_to = _prefixId.prefix "P104i_applies_to"
    /// <summary>
    ///   <para>rdfs:label : right held byrdfs:label : são direitos de rdfs:label : droit détenu parrdfs:label : Rechte stehen zurdfs:label : право принадлежитrdfs:label : δικαίωμα κατέχεται από</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor who holds the instances of E30 Right to an E72 Legal Object.
    /// 	It is a superproperty of P52 has current owner (is current owner of) because ownership is a right that is held on the owned object.
    /// P105 right held by (has right on) is a shortcut of the fully developed path from E72 Legal Object through P104 is subject to (applies to), E30 Right, P75 possesses (is possessed by) to E39 Actor.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P105_right_held_by">crm:P105_right_held_by</a>
    /// </summary>
    let P105_right_held_by = _prefixId.prefix "P105_right_held_by"
    /// <summary>
    ///   <para>rdfs:label : hat Rechte anrdfs:label : владеет правом наrdfs:label : has right onrdfs:label : détient un droit surrdfs:label : έχει δικαίωμα σεrdfs:label : possui direitos sobre</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P105i_has_right_on">crm:P105i_has_right_on</a>
    /// </summary>
    let P105i_has_right_on = _prefixId.prefix "P105i_has_right_on"
    /// <summary>
    ///   <para>rdfs:label :  ist zusammengesetzt ausrdfs:label : αποτελείται απόrdfs:label : est composé derdfs:label : é composto derdfs:label : составлен изrdfs:label : is composed of</para>
    ///   <para>rdfs:comment : This property associates an instance of E90 Symbolic Object with a part of it that is by itself an instance of E90 Symbolic Object, such as fragments of texts or clippings from an image.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P106_is_composed_of">crm:P106_is_composed_of</a>
    /// </summary>
    let P106_is_composed_of = _prefixId.prefix "P106_is_composed_of"
    /// <summary>
    ///   <para>rdfs:label : формирует частьrdfs:label : αποτελεί μέρος του/τηςrdfs:label : bildet Teil vonrdfs:label : fait partie derdfs:label : forms part ofrdfs:label : faz parte de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P106i_forms_part_of">crm:P106i_forms_part_of</a>
    /// </summary>
    let P106i_forms_part_of = _prefixId.prefix "P106i_forms_part_of"

    /// <summary>
    ///   <para>rdfs:label : имеет действующего или бывшего членаrdfs:label : a pour membre actuel ou ancienrdfs:label : tem ou teve membrordfs:label : has current or former memberrdfs:label : έχει ή είχε μέλοςrdfs:label : hat derzeitiges oder früheres Mitglied</para>
    ///   <para>rdfs:comment : This property relates an E39 Actor to the E74 Group of which that E39 Actor is a member.
    /// Groups, Legal Bodies and Persons, may all be members of Groups. A Group necessarily consists of more than one member.
    /// This property is a shortcut of the more fully developed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor
    /// The property P107.1 kind of member can be used to specify the type of membership or the role the member has in the group.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P107_has_current_or_former_member">crm:P107_has_current_or_former_member</a>
    /// </summary>
    let P107_has_current_or_former_member =
        _prefixId.prefix "P107_has_current_or_former_member"

    /// <summary>
    ///   <para>rdfs:label : είναι ή ήταν μέλος του/τηςrdfs:label : is current or former member ofrdfs:label : ist derzeitiges oder früheres Mitglied vonrdfs:label : является действующим или бывшим членомrdfs:label : est actuel ou ancien membre derdfs:label : é ou foi membro de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P107i_is_current_or_former_member_of">crm:P107i_is_current_or_former_member_of</a>
    /// </summary>
    let P107i_is_current_or_former_member_of =
        _prefixId.prefix "P107i_is_current_or_former_member_of"

    /// <summary>
    ///   <para>rdfs:comment : This property identifies the E24 Physical Man-Made Thing that came into existence as a result of an E12 Production.
    /// The identity of an instance of E24 Physical Man-Made Thing is not defined by its matter, but by its existence as a subject of documentation. An E12 Production can result in the creation of multiple instances of E24 Physical Man-Made Thing.
    /// </para>
    ///   <para>rdfs:label : has producedrdfs:label : παρήγαγεrdfs:label : produziurdfs:label : a produitrdfs:label : hat hergestelltrdfs:label : произвел</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P108_has_produced">crm:P108_has_produced</a>
    /// </summary>
    let P108_has_produced = _prefixId.prefix "P108_has_produced"
    /// <summary>
    ///   <para>rdfs:label : был произведен посредствомrdfs:label : a été produit parrdfs:label : wurde hergestellt durchrdfs:label : παρήχθη απόrdfs:label : was produced byrdfs:label : foi produzido por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P108i_was_produced_by">crm:P108i_was_produced_by</a>
    /// </summary>
    let P108i_was_produced_by = _prefixId.prefix "P108i_was_produced_by"

    /// <summary>
    ///   <para>rdfs:comment : This property identifies the E39 Actor or Actors who assume or have assumed overall curatorial responsibility for an E78 Collection.
    /// This property is effectively a short-cut. It does not allow a history of curation to be recorded. This would require use of an Event assigning responsibility for a Collection to a curator.
    /// </para>
    ///   <para>rdfs:label : имеет действующего или бывшего хранителяrdfs:label : hat derzeitigen oder früheren Kuratorrdfs:label : έχει ή είχε επιμελητήrdfs:label : tem ou teve curadorrdfs:label : a pour conservateur actuel ou ancienrdfs:label : has current or former curator</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P109_has_current_or_former_curator">crm:P109_has_current_or_former_curator</a>
    /// </summary>
    let P109_has_current_or_former_curator =
        _prefixId.prefix "P109_has_current_or_former_curator"

    /// <summary>
    ///   <para>rdfs:label : ist derzeitiger oder früherer Kurator vonrdfs:label : είναι ή ήταν επιμελητής του/τηςrdfs:label : est ou a été le conservateur derdfs:label : é ou foi curador derdfs:label : is current or former curator ofrdfs:label : является действующим или бывшим хранителем</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P109i_is_current_or_former_curator_of">crm:P109i_is_current_or_former_curator_of</a>
    /// </summary>
    let P109i_is_current_or_former_curator_of =
        _prefixId.prefix "P109i_is_current_or_former_curator_of"

    /// <summary>
    ///   <para>rdfs:label : находится в пределахrdfs:label : fällt inrdfs:label : falls withinrdfs:label : εμπίπτειrdfs:label : s’insère dans le cours derdfs:label : está contido em</para>
    ///   <para>rdfs:comment : This property describes an instance of E4 Period, which falls within the E53 Place and E52 Time-Span of another.
    /// The difference with P9 consists of (forms part of) is subtle. Unlike P9 consists of (forms part of), P10 falls within (contains) does not imply any logical connection between the two periods and it may refer to a period of a completely different type.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P10_falls_within">crm:P10_falls_within</a>
    /// </summary>
    let P10_falls_within = _prefixId.prefix "P10_falls_within"
    /// <summary>
    ///   <para>rdfs:label : περιλαμβάνειrdfs:label : содержитrdfs:label : containsrdfs:label : contientrdfs:label : enthältrdfs:label : contém</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P10i_contains">crm:P10i_contains</a>
    /// </summary>
    let P10i_contains = _prefixId.prefix "P10i_contains"
    /// <summary>
    ///   <para>rdfs:comment : This property identifies the E24 Physical Man-Made Thing that is added to (augmented) in an E79 Part Addition.
    /// Although a Part Addition event normally concerns only one item of Physical Man-Made Thing, it is possible to imagine circumstances under which more than one item might be added to (augmented). For example, the artist Jackson Pollock trailing paint onto multiple canvasses.
    /// </para>
    ///   <para>rdfs:label : увеличилrdfs:label : επαύξησεrdfs:label : erweiterterdfs:label : a augmentérdfs:label : aumentourdfs:label : augmented</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P110_augmented">crm:P110_augmented</a>
    /// </summary>
    let P110_augmented = _prefixId.prefix "P110_augmented"
    /// <summary>
    ///   <para>rdfs:label : was augmented byrdfs:label : a été augmenté parrdfs:label : foi aumentada porrdfs:label : wurde erweitert durchrdfs:label : επαυξήθηκε απόrdfs:label : был увеличен посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P110i_was_augmented_by">crm:P110i_was_augmented_by</a>
    /// </summary>
    let P110i_was_augmented_by = _prefixId.prefix "P110i_was_augmented_by"
    /// <summary>
    ///   <para>rdfs:label : a ajoutérdfs:label : addedrdfs:label : добавилrdfs:label : fügte hinzurdfs:label : προσέθεσεrdfs:label : adicionou</para>
    ///   <para>rdfs:comment : This property identifies the E18 Physical Thing that is added during an E79 Part Addition activity
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P111_added">crm:P111_added</a>
    /// </summary>
    let P111_added = _prefixId.prefix "P111_added"
    /// <summary>
    ///   <para>rdfs:label : был добавлен посредствомrdfs:label : προστέθηκε απόrdfs:label : was added byrdfs:label : a été ajouté parrdfs:label : foi adicionado porrdfs:label : wurde hinzugefügt durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P111i_was_added_by">crm:P111i_was_added_by</a>
    /// </summary>
    let P111i_was_added_by = _prefixId.prefix "P111i_was_added_by"
    /// <summary>
    ///   <para>rdfs:label : verminderterdfs:label : εξάλειψεrdfs:label : diminishedrdfs:label : a diminuérdfs:label : diminuiurdfs:label : уменьшил</para>
    ///   <para>rdfs:comment : This property identifies the E24 Physical Man-Made Thing that was diminished by E80 Part Removal.
    /// Although a Part removal activity normally concerns only one item of Physical Man-Made Thing, it is possible to imagine circumstances under which more than one item might be diminished by a single Part Removal activity.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P112_diminished">crm:P112_diminished</a>
    /// </summary>
    let P112_diminished = _prefixId.prefix "P112_diminished"
    /// <summary>
    ///   <para>rdfs:label : wurde vermindert durchrdfs:label : a été diminué parrdfs:label : foi diminuído porrdfs:label : was diminished byrdfs:label : εξαλείφθηκε απόrdfs:label : был уменьшен посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P112i_was_diminished_by">crm:P112i_was_diminished_by</a>
    /// </summary>
    let P112i_was_diminished_by = _prefixId.prefix "P112i_was_diminished_by"
    /// <summary>
    ///   <para>rdfs:label : удаленrdfs:label : entfernterdfs:label : a enlevérdfs:label : αφαίρεσεrdfs:label : removedrdfs:label : removeu</para>
    ///   <para>rdfs:comment : This property identifies the E18 Physical Thing that is removed during an E80 Part Removal activity.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P113_removed">crm:P113_removed</a>
    /// </summary>
    let P113_removed = _prefixId.prefix "P113_removed"
    /// <summary>
    ///   <para>rdfs:label : foi removido porrdfs:label : a été enlevée parrdfs:label : wurde entfernt durchrdfs:label : αφαιρέθηκε απόrdfs:label : was removed byrdfs:label : был удален посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P113i_was_removed_by">crm:P113i_was_removed_by</a>
    /// </summary>
    let P113i_was_removed_by = _prefixId.prefix "P113i_was_removed_by"
    /// <summary>
    ///   <para>rdfs:label : равен по времениrdfs:label : zeitgleich zurdfs:label : is equal in time tordfs:label : é temporalmente igual ardfs:label : est temporellement égale àrdfs:label : συμπίπτει χρονικά με</para>
    ///   <para>rdfs:comment : This symmetric property allows the instances of E2 Temporal Entity with the same E52 Time-Span to be equated.
    /// This property is only necessary if the time span is unknown (otherwise the equivalence can be calculated).
    /// This property is the same as the "equal" relationship of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P114_is_equal_in_time_to">crm:P114_is_equal_in_time_to</a>
    /// </summary>
    let P114_is_equal_in_time_to = _prefixId.prefix "P114_is_equal_in_time_to"
    /// <summary>
    ///   <para>rdfs:label : terminerdfs:label : finishesrdfs:label : заканчиваетrdfs:label : περατώνειrdfs:label : finalizardfs:label : beendet</para>
    ///   <para>rdfs:comment : This property allows the ending point for a E2 Temporal Entity to be situated by reference to the ending point of another temporal entity of longer duration.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "finishes / finished-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P115_finishes">crm:P115_finishes</a>
    /// </summary>
    let P115_finishes = _prefixId.prefix "P115_finishes"
    /// <summary>
    ///   <para>rdfs:label : est terminée parrdfs:label : заканчиваетсяrdfs:label : περατώνεται μεrdfs:label : wurde beendet mitrdfs:label : is finished byrdfs:label : é finalizada por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P115i_is_finished_by">crm:P115i_is_finished_by</a>
    /// </summary>
    let P115i_is_finished_by = _prefixId.prefix "P115i_is_finished_by"
    /// <summary>
    ///   <para>rdfs:label : начинаетrdfs:label : iniciardfs:label : αρχίζειrdfs:label : beginntrdfs:label : startsrdfs:label : commence</para>
    ///   <para>rdfs:comment : This property allows the starting point for a E2 Temporal Entity to be situated by reference to the starting point of another temporal entity of longer duration.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "starts / started-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P116_starts">crm:P116_starts</a>
    /// </summary>
    let P116_starts = _prefixId.prefix "P116_starts"
    /// <summary>
    ///   <para>rdfs:label : est commencée parrdfs:label : wurde begonnen mitrdfs:label : αρχίζει μεrdfs:label : начинаетсяrdfs:label : is started byrdfs:label : é iniciada por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P116i_is_started_by">crm:P116i_is_started_by</a>
    /// </summary>
    let P116i_is_started_by = _prefixId.prefix "P116i_is_started_by"
    /// <summary>
    ///   <para>rdfs:label : εμφανίζεται κατά τη διάρκειαrdfs:label : ocorre duranterdfs:label : occurs duringrdfs:label : a lieu pendantrdfs:label : появляется во течениеrdfs:label : fällt in</para>
    ///   <para>rdfs:comment : This property allows the entire E52 Time-Span of an E2 Temporal Entity to be situated within the Time-Span of another temporal entity that starts before and ends after the included temporal entity.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "during / includes" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P117_occurs_during">crm:P117_occurs_during</a>
    /// </summary>
    let P117_occurs_during = _prefixId.prefix "P117_occurs_during"
    /// <summary>
    ///   <para>rdfs:label : περιλαμβάνειrdfs:label : включаетrdfs:label : comporterdfs:label : includesrdfs:label : beinhaltetrdfs:label : inclui</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P117i_includes">crm:P117i_includes</a>
    /// </summary>
    let P117i_includes = _prefixId.prefix "P117i_includes"
    /// <summary>
    ///   <para>rdfs:label : overlaps in time withrdfs:label : est partiellement recouverte dans le temps parrdfs:label : überlappt zeitlich mitrdfs:label : sobrepõe temporalmenterdfs:label : προηγείται μερικώς επικαλύπτονταςrdfs:label : перекрывает во времени</para>
    ///   <para>rdfs:comment : This property identifies an overlap between the instances of E52 Time-Span of two instances of E2 Temporal Entity.
    /// It implies a temporal order between the two entities: if A overlaps in time B, then A must start before B, and B must end after A. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "overlaps / overlapped-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P118_overlaps_in_time_with">crm:P118_overlaps_in_time_with</a>
    /// </summary>
    let P118_overlaps_in_time_with = _prefixId.prefix "P118_overlaps_in_time_with"

    /// <summary>
    ///   <para>rdfs:label : wird zeitlich überlappt vonrdfs:label : перекрывается во времениrdfs:label : recouvre partiellement dans le tempsrdfs:label : is overlapped in time byrdfs:label : έπεται μερικώς επικαλυπτόμενοrdfs:label : é sobreposto temporalmente por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P118i_is_overlapped_in_time_by">crm:P118i_is_overlapped_in_time_by</a>
    /// </summary>
    let P118i_is_overlapped_in_time_by =
        _prefixId.prefix "P118i_is_overlapped_in_time_by"

    /// <summary>
    ///   <para>rdfs:label : é temporalmente contíguo comrdfs:label : προηγείταιrdfs:label : trifft zeitlich aufrdfs:label : meets in time withrdfs:label : следует во времени заrdfs:label : est temporellement contiguë avec</para>
    ///   <para>rdfs:comment : This property indicates that one E2 Temporal Entity immediately follows another.
    /// It implies a particular order between the two entities: if A meets in time with B, then A must precede B. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "meets / met-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P119_meets_in_time_with">crm:P119_meets_in_time_with</a>
    /// </summary>
    let P119_meets_in_time_with = _prefixId.prefix "P119_meets_in_time_with"
    /// <summary>
    ///   <para>rdfs:label : est immédiatement précédé parrdfs:label : έπεταιrdfs:label : is met in time byrdfs:label : wird zeitlich getroffen vonrdfs:label : предшествует во времениrdfs:label : é imediatamente precedido por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P119i_is_met_in_time_by">crm:P119i_is_met_in_time_by</a>
    /// </summary>
    let P119i_is_met_in_time_by = _prefixId.prefix "P119i_is_met_in_time_by"
    /// <summary>
    ///   <para>rdfs:label : had participantrdfs:label : tem participanterdfs:label : имел участникаrdfs:label : a eu pour participantrdfs:label : hatte Teilnehmerrdfs:label : είχε συμμέτοχο</para>
    ///   <para>rdfs:comment : This property describes the active or passive participation of instances of E39 Actors in an E5 Event.
    /// It connects the life-line of the related E39 Actor with the E53 Place and E50 Date of the event. The property implies that the Actor was involved in the event but does not imply any causal relationship. The subject of a portrait can be said to have participated in the creation of the portrait.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P11_had_participant">crm:P11_had_participant</a>
    /// </summary>
    let P11_had_participant = _prefixId.prefix "P11_had_participant"
    /// <summary>
    ///   <para>rdfs:label : участвовал вrdfs:label : συμμετείχε σεrdfs:label : participated inrdfs:label : nahm Teil anrdfs:label : participa emrdfs:label : a participé à</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P11i_participated_in">crm:P11i_participated_in</a>
    /// </summary>
    let P11i_participated_in = _prefixId.prefix "P11i_participated_in"
    /// <summary>
    ///   <para>rdfs:label : kommt vorrdfs:label : εμφανίζεται πρινrdfs:label : a lieu avantrdfs:label : ocorre antesrdfs:label : появляется доrdfs:label : occurs before</para>
    ///   <para>rdfs:comment : This property identifies the relative chronological sequence of two temporal entities.
    /// It implies that a temporal gap exists between the end of A and the start of B. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "before / after" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P120_occurs_before">crm:P120_occurs_before</a>
    /// </summary>
    let P120_occurs_before = _prefixId.prefix "P120_occurs_before"
    /// <summary>
    ///   <para>rdfs:label : a lieu aprèsrdfs:label : εμφανίζεται μετάrdfs:label : появляется послеrdfs:label : kommt nachrdfs:label : occurs afterrdfs:label : ocorre depois</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P120i_occurs_after">crm:P120i_occurs_after</a>
    /// </summary>
    let P120i_occurs_after = _prefixId.prefix "P120i_occurs_after"
    /// <summary>
    ///   <para>rdfs:comment : This symmetric property allows the instances of E53 Place with overlapping geometric extents to be associated with each other.
    /// It does not specify anything about the shared area. This property is purely spatial, in contrast to Allen operators, which are purely temporal.
    /// </para>
    ///   <para>rdfs:label : пересекается сrdfs:label : overlaps withrdfs:label : chevaucherdfs:label : überlappt mitrdfs:label : επικαλύπτεται μεrdfs:label : sobrepõe com</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P121_overlaps_with">crm:P121_overlaps_with</a>
    /// </summary>
    let P121_overlaps_with = _prefixId.prefix "P121_overlaps_with"
    /// <summary>
    ///   <para>rdfs:label : borders withrdfs:label : συνορεύει μεrdfs:label : граничит сrdfs:label : jouxterdfs:label : fronteira comrdfs:label : grenzt an</para>
    ///   <para>rdfs:comment : This symmetric property allows the instances of E53 Place which share common borders to be related as such.
    /// This property is purely spatial, in contrast to Allen operators, which are purely temporal.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P122_borders_with">crm:P122_borders_with</a>
    /// </summary>
    let P122_borders_with = _prefixId.prefix "P122_borders_with"
    /// <summary>
    ///   <para>rdfs:label : resultou emrdfs:label : resulted inrdfs:label : a eu pour résultatrdfs:label : είχε ως αποτέλεσμαrdfs:label : ergabrdfs:label : повлек появление</para>
    ///   <para>rdfs:comment : This property identifies the E77 Persistent Item or items that are the result of an E81 Transformation.
    /// New items replace the transformed item or items, which cease to exist as units of documentation. The physical continuity between the old and the new is expressed by the link to the common Transformation.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P123_resulted_in">crm:P123_resulted_in</a>
    /// </summary>
    let P123_resulted_in = _prefixId.prefix "P123_resulted_in"
    /// <summary>
    ///   <para>rdfs:label : προέκυψε απόrdfs:label : resultado derdfs:label : ergab sich ausrdfs:label : resulted fromrdfs:label : est le résultat derdfs:label : был результатом</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P123i_resulted_from">crm:P123i_resulted_from</a>
    /// </summary>
    let P123i_resulted_from = _prefixId.prefix "P123i_resulted_from"
    /// <summary>
    ///   <para>rdfs:label : a transformérdfs:label : transformourdfs:label : μετέτρεψεrdfs:label : трансформировалrdfs:label : wandelte umrdfs:label : transformed</para>
    ///   <para>rdfs:comment : This property identifies the E77 Persistent Item or items that cease to exist due to a E81 Transformation.
    /// It is replaced by the result of the Transformation, which becomes a new unit of documentation. The continuity between both items, the new and the old, is expressed by the link to the common Transformation.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P124_transformed">crm:P124_transformed</a>
    /// </summary>
    let P124_transformed = _prefixId.prefix "P124_transformed"
    /// <summary>
    ///   <para>rdfs:label : wurde umgewandelt durchrdfs:label : foi transformado porrdfs:label : μετατράπηκε απόrdfs:label : был трансформирован посредствомrdfs:label : was transformed byrdfs:label : a été transformé par</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P124i_was_transformed_by">crm:P124i_was_transformed_by</a>
    /// </summary>
    let P124i_was_transformed_by = _prefixId.prefix "P124i_was_transformed_by"
    /// <summary>
    ///   <para>rdfs:label : a employé un objet du typerdfs:label : used object of typerdfs:label : использовал объект типаrdfs:label : benutzte Objekt des Typusrdfs:label : usou objeto do tipordfs:label : χρησιμοποίησε αντικείμενο τύπου</para>
    ///   <para>rdfs:comment : This property defines the kind of objects used in an E7 Activity, when the specific instance is either unknown or not of interest, such as use of "a hammer".
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P125_used_object_of_type">crm:P125_used_object_of_type</a>
    /// </summary>
    let P125_used_object_of_type = _prefixId.prefix "P125_used_object_of_type"

    /// <summary>
    ///   <para>rdfs:label : был типом объекта использованного вrdfs:label : was type of object used inrdfs:label : Objekt des Typus ... wurde benutzt inrdfs:label : était le type d’objet employé parrdfs:label : ήταν o τύπος αντικείμενου που χρησιμοποιήθηκε σεrdfs:label : foi tipo do objeto usado em</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P125i_was_type_of_object_used_in">crm:P125i_was_type_of_object_used_in</a>
    /// </summary>
    let P125i_was_type_of_object_used_in =
        _prefixId.prefix "P125i_was_type_of_object_used_in"

    /// <summary>
    ///   <para>rdfs:label : χρησιμοποίησεrdfs:label : verwendeterdfs:label : a employérdfs:label : employedrdfs:label : empregourdfs:label : использовал</para>
    ///   <para>rdfs:comment : This property identifies E57 Material employed in an E11 Modification.
    /// The E57 Material used during the E11 Modification does not necessarily become incorporated into the E24 Physical Man-Made Thing that forms the subject of the E11 Modification.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P126_employed">crm:P126_employed</a>
    /// </summary>
    let P126_employed = _prefixId.prefix "P126_employed"
    /// <summary>
    ///   <para>rdfs:label : was employed inrdfs:label : wurde verwendet beirdfs:label : использовался вrdfs:label : χρησιμοποιήθηκε σεrdfs:label : a été employé dansrdfs:label : foi empregado em</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P126i_was_employed_in">crm:P126i_was_employed_in</a>
    /// </summary>
    let P126i_was_employed_in = _prefixId.prefix "P126i_was_employed_in"
    /// <summary>
    ///   <para>rdfs:label : a pour terme génériquerdfs:label : tem termo genéricordfs:label : hat den Oberbegriffrdfs:label : έχει ευρύτερο όροrdfs:label : has broader termrdfs:label : имеет вышестоящий термин</para>
    ///   <para>rdfs:comment : This property identifies a super-Type to which an E55 Type is related.
    /// 		It allows Types to be organised into hierarchies. This is the sense of "broader term generic  		(BTG)" as defined in ISO 2788
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P127_has_broader_term">crm:P127_has_broader_term</a>
    /// </summary>
    let P127_has_broader_term = _prefixId.prefix "P127_has_broader_term"
    /// <summary>
    ///   <para>rdfs:label : a pour terme spécifiquerdfs:label : hat den Unterbegriffrdfs:label : has narrower termrdfs:label : έχει στενότερο όροrdfs:label : tem termo específico</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P127i_has_narrower_term">crm:P127i_has_narrower_term</a>
    /// </summary>
    let P127i_has_narrower_term = _prefixId.prefix "P127i_has_narrower_term"
    /// <summary>
    ///   <para>rdfs:comment : This property identifies an E73 Information Object carried by an instance of E24 Physical Man-Made Thing.
    /// In general this would be an E84 Information Carrier P65 shows visual item (is shown by) is a specialisation of P128 carries (is carried by) which should be used for carrying visual items.
    /// </para>
    ///   <para>rdfs:label : несетrdfs:label : trägtrdfs:label : est le support derdfs:label : φέρειrdfs:label : é o suporte derdfs:label : carries</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P128_carries">crm:P128_carries</a>
    /// </summary>
    let P128_carries = _prefixId.prefix "P128_carries"
    /// <summary>
    ///   <para>rdfs:label : wird getragen vonrdfs:label : is carried byrdfs:label : a pour supportrdfs:label : переносится посредствомrdfs:label : φέρεται απόrdfs:label : é suportado por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P128i_is_carried_by">crm:P128i_is_carried_by</a>
    /// </summary>
    let P128i_is_carried_by = _prefixId.prefix "P128i_is_carried_by"
    /// <summary>
    ///   <para>rdfs:label : handelt überrdfs:label : est au sujet derdfs:label : é sobrerdfs:label : касаетсяrdfs:label : έχει ως θέμαrdfs:label : is about</para>
    ///   <para>rdfs:comment : This property documents that an E89 Propositional Object has as subject an instance of E1 CRM Entity.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P129_is_about">crm:P129_is_about</a>
    /// </summary>
    let P129_is_about = _prefixId.prefix "P129_is_about"
    /// <summary>
    ///   <para>rdfs:label : wird behandelt inrdfs:label : é assunto derdfs:label : είναι θέμα  του/τηςrdfs:label : is subject ofrdfs:label : est le sujet derdfs:label : является предметом для</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P129i_is_subject_of">crm:P129i_is_subject_of</a>
    /// </summary>
    let P129i_is_subject_of = _prefixId.prefix "P129i_is_subject_of"

    /// <summary>
    ///   <para>rdfs:label : συνέβη παρουσία του/τηςrdfs:label : est arrivé en présence derdfs:label : появился в присутствииrdfs:label : occurred in the presence ofrdfs:label : ocorreu na presença derdfs:label : fand statt im Beisein von</para>
    ///   <para>rdfs:comment : This property describes the active or passive presence of an E77 Persistent Item in an E5 Event without implying any specific role.
    /// It connects the history of a thing with the E53 Place and E50 Date of an event. For example, an object may be the desk, now in a museum on which a treaty was signed. The presence of an immaterial thing implies the presence of at least one of its carriers.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P12_occurred_in_the_presence_of">crm:P12_occurred_in_the_presence_of</a>
    /// </summary>
    let P12_occurred_in_the_presence_of =
        _prefixId.prefix "P12_occurred_in_the_presence_of"

    /// <summary>
    ///   <para>rdfs:label : was present atrdfs:label : ήταν παρών/παρούσα/παρόν σεrdfs:label : war anwesend beirdfs:label : était présent àrdfs:label : присутствовал приrdfs:label : estava presente no</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P12i_was_present_at">crm:P12i_was_present_at</a>
    /// </summary>
    let P12i_was_present_at = _prefixId.prefix "P12i_was_present_at"
    /// <summary>
    ///   <para>rdfs:label : présente des caractéristiques derdfs:label : zeigt Merkmale vonrdfs:label : παρουσιάζει χαρακτηριστικά του/τηςrdfs:label : демонстрирует признакиrdfs:label : apresenta características derdfs:label : shows features of</para>
    ///   <para>rdfs:comment : This property generalises the notions of  "copy of" and "similar to" into a dynamic, asymmetric relationship, where the domain expresses the derivative, if such a direction can be established.
    /// Otherwise, the relationship is symmetric. It is a short-cut of P15 was influenced by (influenced) in a creation or production, if such a reason for the similarity can be verified. Moreover it expresses similarity in cases that can be stated between two objects only, without historical knowledge about its reasons.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P130_shows_features_of">crm:P130_shows_features_of</a>
    /// </summary>
    let P130_shows_features_of = _prefixId.prefix "P130_shows_features_of"

    /// <summary>
    ///   <para>rdfs:label : χαρακτηριστικά του βρίσκονται επίσης σεrdfs:label : a des caractéristiques se trouvant aussi surrdfs:label : Merkmale auch aufrdfs:label : признаки также найдены наrdfs:label : features are also found onrdfs:label : características são também encontradas em</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P130i_features_are_also_found_on">crm:P130i_features_are_also_found_on</a>
    /// </summary>
    let P130i_features_are_also_found_on =
        _prefixId.prefix "P130i_features_are_also_found_on"

    /// <summary>
    ///   <para>rdfs:label : is identified byrdfs:label : идентифицируется посредствомrdfs:label : est identifié parrdfs:label : αναγνωρίζεται ωςrdfs:label : wird identifziert durchrdfs:label : é identificado por</para>
    ///   <para>rdfs:comment : This property identifies a name used specifically to identify an E39 Actor.
    /// This property is a specialisation of P1 is identified by (identifies) is identified by.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P131_is_identified_by">crm:P131_is_identified_by</a>
    /// </summary>
    let P131_is_identified_by = _prefixId.prefix "P131_is_identified_by"
    /// <summary>
    ///   <para>rdfs:label : identifiesrdfs:label : identifiziertrdfs:label : идентифицируетrdfs:label : identificardfs:label : identifierdfs:label : είναι αναγνωριστικό</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P131i_identifies">crm:P131i_identifies</a>
    /// </summary>
    let P131i_identifies = _prefixId.prefix "P131i_identifies"
    /// <summary>
    ///   <para>rdfs:label : überlappt mitrdfs:label : overlaps withrdfs:label : пересекается сrdfs:label : sobrepõerdfs:label : chevaucherdfs:label : επικαλύπτεται με</para>
    ///   <para>rdfs:comment : This symmetric property allows instances of E4 Period that overlap both temporally and spatially to be related, i,e. they share some spatio-temporal extent.
    /// This property does not imply any ordering or sequence between the two periods, either spatial or temporal.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P132_overlaps_with">crm:P132_overlaps_with</a>
    /// </summary>
    let P132_overlaps_with = _prefixId.prefix "P132_overlaps_with"
    /// <summary>
    ///   <para>rdfs:label : διαχωρίζεται απόrdfs:label : est séparée derdfs:label : é separado derdfs:label : отделен отrdfs:label : getrennt vonrdfs:label : is separated from</para>
    ///   <para>rdfs:comment : This symmetric property allows instances of E4 Period that do not overlap both temporally and spatially, to be related i,e. they do not share any spatio-temporal extent.
    /// This property does not imply any ordering or sequence between the two periods either spatial or temporal.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P133_is_separated_from">crm:P133_is_separated_from</a>
    /// </summary>
    let P133_is_separated_from = _prefixId.prefix "P133_is_separated_from"
    /// <summary>
    ///   <para>rdfs:label : continuourdfs:label : συνέχισεrdfs:label : setzte sich fort inrdfs:label : продолжилrdfs:label : continuedrdfs:label : est la suite de</para>
    ///   <para>rdfs:comment : This property allows two activities to be related where the domain is considered as an intentional continuation of the range.
    /// Used multiple times, this allows a chain of related activities to be created which follow each other in sequence.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P134_continued">crm:P134_continued</a>
    /// </summary>
    let P134_continued = _prefixId.prefix "P134_continued"
    /// <summary>
    ///   <para>rdfs:label : a été continuée parrdfs:label : foi continuada porrdfs:label : wurde fortgesetzt durchrdfs:label : was continued byrdfs:label : συνεχίστηκε απόrdfs:label : был продолжен</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P134i_was_continued_by">crm:P134i_was_continued_by</a>
    /// </summary>
    let P134i_was_continued_by = _prefixId.prefix "P134i_was_continued_by"
    /// <summary>
    ///   <para>rdfs:label : created typerdfs:label : δημιούργησε τύποrdfs:label : erschuf Typusrdfs:label : a créé le typerdfs:label : criou tipordfs:label : создал тип</para>
    ///   <para>rdfs:comment : This property identifies the E55 Type, which is created in an E83Type Creation activity.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P135_created_type">crm:P135_created_type</a>
    /// </summary>
    let P135_created_type = _prefixId.prefix "P135_created_type"
    /// <summary>
    ///   <para>rdfs:label : wurde geschaffen durchrdfs:label : был создан посредствомrdfs:label : δημιουργήθηκε απόrdfs:label : was created byrdfs:label : foi criado porrdfs:label : a été créé par</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P135i_was_created_by">crm:P135i_was_created_by</a>
    /// </summary>
    let P135i_was_created_by = _prefixId.prefix "P135i_was_created_by"
    /// <summary>
    ///   <para>rdfs:label : foi baseado emrdfs:label : stützte sich aufrdfs:label : βασίστηκε σεrdfs:label : был основан наrdfs:label : s’est fondée surrdfs:label : was based on</para>
    ///   <para>rdfs:comment : This property identifies one or more items that were used as evidence to declare a new E55 Type.
    /// The examination of these items is often the only objective way to understand the precise characteristics of a new Type. Such items should be deposited in a museum or similar institution for that reason. The taxonomic role renders the specific relationship of each item to the Type, such as "holotype" or "original element".
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P136_was_based_on">crm:P136_was_based_on</a>
    /// </summary>
    let P136_was_based_on = _prefixId.prefix "P136_was_based_on"
    /// <summary>
    ///   <para>rdfs:label : υποστήριξε τη δημιουργία τύπουrdfs:label : belegterdfs:label : supported type creationrdfs:label : поддержал создание типаrdfs:label : suportou a criação de tipordfs:label : a justifié la création de type</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P136i_supported_type_creation">crm:P136i_supported_type_creation</a>
    /// </summary>
    let P136i_supported_type_creation = _prefixId.prefix "P136i_supported_type_creation"
    /// <summary>
    ///   <para>rdfs:label : é exemplificado porrdfs:label : erläutertrdfs:label : поясняетrdfs:label : exemplifierdfs:label : exemplifiesrdfs:label : δειγματίζει</para>
    ///   <para>rdfs:comment : This property allows an item to be declared as a particular example of an E55 Type or taxon
    /// 	The P137.1 in the taxonomic role property of P137 exemplifies (is exemplified by) allows differentiation of taxonomic roles. The taxonomic role renders the specific relationship of this example to the Type, such as "prototypical", "archetypical", "lectotype", etc. The taxonomic role "lectotype" is not associated with the Type Creation (E83) itself, but selected in a later phase.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P137_exemplifies">crm:P137_exemplifies</a>
    /// </summary>
    let P137_exemplifies = _prefixId.prefix "P137_exemplifies"
    /// <summary>
    ///   <para>rdfs:label : δειγματίζεται απόrdfs:label : est exemplifié parrdfs:label : is exemplified byrdfs:label : exemplificardfs:label : erläutert durch Beispielrdfs:label : поясняется посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P137i_is_exemplified_by">crm:P137i_is_exemplified_by</a>
    /// </summary>
    let P137i_is_exemplified_by = _prefixId.prefix "P137i_is_exemplified_by"
    /// <summary>
    ///   <para>rdfs:label : representsrdfs:label : representardfs:label : représenterdfs:label : παριστάνειrdfs:label : stellt darrdfs:label : представляет</para>
    ///   <para>rdfs:comment : This property establishes the relationship between an E36 Visual Item and the entity that it visually represents.
    /// Any entity may be represented visually. This property is part of the fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1 CRM Entity, which is shortcut by P62depicts (is depicted by). P138.1 mode of representation allows the nature of the representation to be refined.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P138_represents">crm:P138_represents</a>
    /// </summary>
    let P138_represents = _prefixId.prefix "P138_represents"
    /// <summary>
    ///   <para>rdfs:label : wird dargestellt durchrdfs:label : παριστάνεται απόrdfs:label : has representationrdfs:label : имеет представлениеrdfs:label : est représentée parrdfs:label : tem representação</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P138i_has_representation">crm:P138i_has_representation</a>
    /// </summary>
    let P138i_has_representation = _prefixId.prefix "P138i_has_representation"
    /// <summary>
    ///   <para>rdfs:comment : This property establishes a relationship of equivalence between two instances of E41 Appellation independent from any item identified by them. It is a dynamic asymmetric relationship, where the range expresses the derivative, if such a direction can be established. Otherwise, the relationship is symmetric. The relationship is not transitive.
    /// The equivalence applies to all cases of use of an instance of E41 Appellation. Multiple names assigned to an object, which are not equivalent for all things identified with a specific instance of E41 Appellation, should be modelled as repeated values of P1 is identified by (identifies).
    /// P139.1 has type allows the type of derivation, such as “transliteration from Latin 1 to ASCII” be refined..
    /// </para>
    ///   <para>rdfs:label : имеет альтернативную формуrdfs:label : has alternative formrdfs:label : hat alternative Formrdfs:label : a pour autre formerdfs:label : tem forma alternativardfs:label : έχει εναλλακτική μορφή</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P139_has_alternative_form">crm:P139_has_alternative_form</a>
    /// </summary>
    let P139_has_alternative_form = _prefixId.prefix "P139_has_alternative_form"
    /// <summary>
    ///   <para>rdfs:label : zerstörterdfs:label : уничтожилrdfs:label : destroyedrdfs:label : destruiurdfs:label : a détruitrdfs:label : κατέστρεψε</para>
    ///   <para>rdfs:comment : This property allows specific instances of E18 Physical Thing that have been destroyed to be related to a destruction event.
    /// Destruction implies the end of an item’s life as a subject of cultural documentation – the physical matter of which the item was composed may in fact continue to exist. A destruction event may be contiguous with a Production that brings into existence a derived object composed partly of matter from the destroyed object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P13_destroyed">crm:P13_destroyed</a>
    /// </summary>
    let P13_destroyed = _prefixId.prefix "P13_destroyed"
    /// <summary>
    ///   <para>rdfs:label : был уничтожен посредствомrdfs:label : καταστράφηκε απόrdfs:label : foi destruído porrdfs:label : a été détruite parrdfs:label : wurde zerstört durchrdfs:label : was destroyed by</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P13i_was_destroyed_by">crm:P13i_was_destroyed_by</a>
    /// </summary>
    let P13i_was_destroyed_by = _prefixId.prefix "P13i_was_destroyed_by"
    /// <summary>
    ///   <para>rdfs:label : a affecté un attribut àrdfs:label : atribuiu atributo parardfs:label : απέδωσε ιδιότητα σεrdfs:label : assigned attribute tordfs:label : wies Merkmal zurdfs:label : присвоил атрибут для</para>
    ///   <para>rdfs:comment : This property indicates the item to which an attribute or relation is assigned. </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P140_assigned_attribute_to">crm:P140_assigned_attribute_to</a>
    /// </summary>
    let P140_assigned_attribute_to = _prefixId.prefix "P140_assigned_attribute_to"
    /// <summary>
    ///   <para>rdfs:label : was attributed byrdfs:label : a reçu un attribut parrdfs:label : получил атрибут посредствомrdfs:label : bekam Merkmal zugewiesen durchrdfs:label : χαρακτηρίστηκε απόrdfs:label : foi atribuído por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P140i_was_attributed_by">crm:P140i_was_attributed_by</a>
    /// </summary>
    let P140i_was_attributed_by = _prefixId.prefix "P140i_was_attributed_by"
    /// <summary>
    ///   <para>rdfs:label : απέδωσεrdfs:label : a attribuérdfs:label : wies zurdfs:label : atribuiurdfs:label : присвоилrdfs:label : assigned</para>
    ///   <para>rdfs:comment : This property indicates the attribute that was assigned or the item that was related to the item denoted by a property P140 assigned attribute to in an Attribute assignment action.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P141_assigned">crm:P141_assigned</a>
    /// </summary>
    let P141_assigned = _prefixId.prefix "P141_assigned"
    /// <summary>
    ///   <para>rdfs:label : был присвоен посредствомrdfs:label : wurde zugewiesen durchrdfs:label : a été attribué parrdfs:label : was assigned byrdfs:label : αποδόθηκε απόrdfs:label : foi atribuído por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P141i_was_assigned_by">crm:P141i_was_assigned_by</a>
    /// </summary>
    let P141i_was_assigned_by = _prefixId.prefix "P141i_was_assigned_by"
    /// <summary>
    ///   <para>rdfs:label : used constituentrdfs:label : benutzte Bestandteil</para>
    ///   <para>rdfs:comment : This property associates the event of assigning an instance of E42 Identifier to an entity, with  the instances of E41 Appellation that were used as elements of the identifier.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P142_used_constituent">crm:P142_used_constituent</a>
    /// </summary>
    let P142_used_constituent = _prefixId.prefix "P142_used_constituent"
    /// <summary>
    ///   <para>rdfs:label : wurde benutzt inrdfs:label : was used in</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P142i_was_used_in">crm:P142i_was_used_in</a>
    /// </summary>
    let P142i_was_used_in = _prefixId.prefix "P142i_was_used_in"
    /// <summary>
    ///   <para>rdfs:label : joinedrdfs:label : verband</para>
    ///   <para>rdfs:comment : This property identifies the instance of E39 Actor that becomes member of a E74 Group in an E85 Joining.
    ///  	Joining events allow for describing people becoming members of a group with a more detailed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor, compared to the shortcut offered by P107 has current or former member (is current or former member of).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P143_joined">crm:P143_joined</a>
    /// </summary>
    let P143_joined = _prefixId.prefix "P143_joined"
    /// <summary>
    ///   <para>rdfs:label : was joined byrdfs:label : wurde verbunden durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P143i_was_joined_by">crm:P143i_was_joined_by</a>
    /// </summary>
    let P143i_was_joined_by = _prefixId.prefix "P143i_was_joined_by"
    /// <summary>
    ///   <para>rdfs:label : joined withrdfs:label : verband mit</para>
    ///   <para>rdfs:comment : This property identifies the instance of E74 Group of which an instance of E39 Actor becomes a member through an instance of E85 Joining.
    /// Although a Joining activity normally concerns only one instance of E74 Group, it is possible to imagine circumstances under which becoming member of one Group implies becoming member of another Group as well.
    /// Joining events allow for describing people becoming members of a group with a more detailed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor, compared to the shortcut offered by P107 has current or former member (is current or former member of).
    /// The property P144.1 kind of member can be used to specify the type of membership or the role the member has in the group.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P144_joined_with">crm:P144_joined_with</a>
    /// </summary>
    let P144_joined_with = _prefixId.prefix "P144_joined_with"
    /// <summary>
    ///   <para>rdfs:label : gained member byrdfs:label : erwarb Mitglied durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P144i_gained_member_by">crm:P144i_gained_member_by</a>
    /// </summary>
    let P144i_gained_member_by = _prefixId.prefix "P144i_gained_member_by"
    /// <summary>
    ///   <para>rdfs:label : separatedrdfs:label : entließ</para>
    ///   <para>rdfs:comment : This property identifies the instance of E39 Actor that leaves an instance of E74 Group through an instance of E86 Leaving.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P145_separated">crm:P145_separated</a>
    /// </summary>
    let P145_separated = _prefixId.prefix "P145_separated"
    /// <summary>
    ///   <para>rdfs:label : left byrdfs:label : wurde entlassen durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P145i_left_by">crm:P145i_left_by</a>
    /// </summary>
    let P145i_left_by = _prefixId.prefix "P145i_left_by"
    /// <summary>
    ///   <para>rdfs:label : separated fromrdfs:label : entließ von</para>
    ///   <para>rdfs:comment : This property identifies the instance of E74 Group an instance of E39 Actor leaves through an instance of E86 Leaving.
    /// Although a Leaving activity normally concerns only one instance of E74 Group, it is possible to imagine circumstances under which leaving one E74 Group implies leaving another E74 Group as well.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P146_separated_from">crm:P146_separated_from</a>
    /// </summary>
    let P146_separated_from = _prefixId.prefix "P146_separated_from"
    /// <summary>
    ///   <para>rdfs:label : lost member byrdfs:label : verlor Mitglied durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P146i_lost_member_by">crm:P146i_lost_member_by</a>
    /// </summary>
    let P146i_lost_member_by = _prefixId.prefix "P146i_lost_member_by"
    /// <summary>
    ///   <para>rdfs:label : curatedrdfs:label : betreute kuratorisch</para>
    ///   <para>rdfs:comment : This property associates an instance of E78 Collection or collections with  subject of a curation activity following some implicit or explicit curation plan.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P147_curated">crm:P147_curated</a>
    /// </summary>
    let P147_curated = _prefixId.prefix "P147_curated"
    /// <summary>
    ///   <para>rdfs:label : was curated byrdfs:label : wurde kuratorisch betreut durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P147i_was_curated_by">crm:P147i_was_curated_by</a>
    /// </summary>
    let P147i_was_curated_by = _prefixId.prefix "P147i_was_curated_by"
    /// <summary>
    ///   <para>rdfs:label : has componentrdfs:label : hat Bestandteil</para>
    ///   <para>rdfs:comment : This property associates an instance of E89 Propositional Object with a structural part of it that is by itself an instance of E89 Propositional Object.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P148_has_component">crm:P148_has_component</a>
    /// </summary>
    let P148_has_component = _prefixId.prefix "P148_has_component"
    /// <summary>
    ///   <para>rdfs:label : is component ofrdfs:label : ist Bestandteil von</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P148i_is_component_of">crm:P148i_is_component_of</a>
    /// </summary>
    let P148i_is_component_of = _prefixId.prefix "P148i_is_component_of"
    /// <summary>
    ///   <para>rdfs:label : is identified by</para>
    ///   <para>rdfs:comment : This property identifies an instance of E28 Conceptual Object using an instance of E75 Conceptual Object Appellation.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P149_is_identified_by">crm:P149_is_identified_by</a>
    /// </summary>
    let P149_is_identified_by = _prefixId.prefix "P149_is_identified_by"
    /// <summary>
    ///   <para>rdfs:label : identifies</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P149i_identifies">crm:P149i_identifies</a>
    /// </summary>
    let P149i_identifies = _prefixId.prefix "P149i_identifies"
    /// <summary>
    ///   <para>rdfs:label : réalisée parrdfs:label : carried out byrdfs:label : πραγματοποιήθηκε απόrdfs:label : wurde ausgeführt vonrdfs:label : выполнялсяrdfs:label : realizada por</para>
    ///   <para>rdfs:comment : This property describes the active participation of an E39 Actor in an E7 Activity.
    /// It implies causal or legal responsibility. The P14.1 in the role of property of the property allows the nature of an Actor’s participation to be specified.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P14_carried_out_by">crm:P14_carried_out_by</a>
    /// </summary>
    let P14_carried_out_by = _prefixId.prefix "P14_carried_out_by"
    /// <summary>
    ///   <para>rdfs:label : führte ausrdfs:label : выполнялrdfs:label : executourdfs:label : performedrdfs:label : a exécutérdfs:label : πραγματοποίησε</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P14i_performed">crm:P14i_performed</a>
    /// </summary>
    let P14i_performed = _prefixId.prefix "P14i_performed"
    /// <summary>
    ///   <para>rdfs:label : находился под влияниемrdfs:label : επηρεάστηκε απόrdfs:label : a été influencée parrdfs:label : foi influenciado por rdfs:label : wurde beeinflußt durchrdfs:label : was influenced by</para>
    ///   <para>rdfs:comment : This is a high level property, which captures the relationship between an E7 Activity and anything that may have had some bearing upon it.
    /// The property has more specific sub properties.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P15_was_influenced_by">crm:P15_was_influenced_by</a>
    /// </summary>
    let P15_was_influenced_by = _prefixId.prefix "P15_was_influenced_by"
    /// <summary>
    ///   <para>rdfs:label : оказал влияние наrdfs:label : επηρέασεrdfs:label : a influencérdfs:label : beeinflußterdfs:label : influencedrdfs:label : influenciou</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P15i_influenced">crm:P15i_influenced</a>
    /// </summary>
    let P15i_influenced = _prefixId.prefix "P15i_influenced"
    /// <summary>
    ///   <para>rdfs:label : usou objeto específicordfs:label : a utilisé l'objet spécifiquerdfs:label : χρησιμοποίησε αντικείμενοrdfs:label : used specific objectrdfs:label : benutzte das bestimmte Objektrdfs:label : использовал особый объект</para>
    ///   <para>rdfs:comment : This property describes the use of material or immaterial things in a way essential to the performance or the outcome of an E7 Activity.
    /// This property typically applies to tools, instruments, moulds, raw materials and items embedded in a product. It implies that the presence of the object in question was a necessary condition for the action. For example, the activity of writing this text required the use of a computer. An immaterial thing can be used if at least one of its carriers is present. For example, the software tools on a computer.
    /// Another example is the use of a particular name by a particular group of people over some span to identify a thing, such as a settlement. In this case, the physical carriers of this name are at least the people understanding its use.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P16_used_specific_object">crm:P16_used_specific_object</a>
    /// </summary>
    let P16_used_specific_object = _prefixId.prefix "P16_used_specific_object"
    /// <summary>
    ///   <para>rdfs:label : wurde benutzt fürrdfs:label : был использован дляrdfs:label : foi usado porrdfs:label : a été utilisé pourrdfs:label : was used forrdfs:label : χρησιμοποιήθηκε για</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P16i_was_used_for">crm:P16i_was_used_for</a>
    /// </summary>
    let P16i_was_used_for = _prefixId.prefix "P16i_was_used_for"
    /// <summary>
    ///   <para>rdfs:label : был обусловлен посредствомrdfs:label : wurde angeregt durchrdfs:label : a été motivée parrdfs:label : είχε ως αφορμήrdfs:label : foi motivado porrdfs:label : was motivated by</para>
    ///   <para>rdfs:comment : This property describes an item or items that are regarded as a reason for carrying out the E7 Activity.
    /// For example, the discovery of a large hoard of treasure may call for a celebration, an order from head quarters can start a military manoeuvre.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P17_was_motivated_by">crm:P17_was_motivated_by</a>
    /// </summary>
    let P17_was_motivated_by = _prefixId.prefix "P17_was_motivated_by"
    /// <summary>
    ///   <para>rdfs:label : ήταν αφορμήrdfs:label : regte anrdfs:label : обусловилrdfs:label : motivatedrdfs:label : motivourdfs:label : a motivé</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P17i_motivated">crm:P17i_motivated</a>
    /// </summary>
    let P17i_motivated = _prefixId.prefix "P17i_motivated"
    /// <summary>
    ///   <para>rdfs:label : was intended use ofrdfs:label : ήταν προορισμένη χρήση τουrdfs:label : était l'utilisation prévue derdfs:label : era prevista a utilização derdfs:label : war beabsichtigteter Gebrauch von rdfs:label : был предполагаемым использованием для</para>
    ///   <para>rdfs:comment : This property relates an E7 Activity with objects created specifically for use in the activity.
    /// This is distinct from the intended use of an item in some general type of activity such as the book of common prayer which was intended for use in Church of England services (see P101 had as general use (was use of)).</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P19_was_intended_use_of">crm:P19_was_intended_use_of</a>
    /// </summary>
    let P19_was_intended_use_of = _prefixId.prefix "P19_was_intended_use_of"
    /// <summary>
    ///   <para>rdfs:label : a été fabriquée pourrdfs:label : έγινε γιαrdfs:label : был создан дляrdfs:label : wurde hergestellt fürrdfs:label : was made forrdfs:label : foi feito para</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P19i_was_made_for">crm:P19i_was_made_for</a>
    /// </summary>
    let P19i_was_made_for = _prefixId.prefix "P19i_was_made_for"
    /// <summary>
    ///   <para>rdfs:label : αναγνωρίζεται ωςrdfs:label : est identifiée parrdfs:label : is identified byrdfs:label : идентифицируется посредствомrdfs:label : é identificado porrdfs:label : wird bezeichnet als</para>
    ///   <para>rdfs:comment : This property describes the naming or identification of any real world item by a name or any other identifier.
    /// This property is intended for identifiers in general use, which form part of the world the model intends to describe, and not merely for internal database identifiers which are specific to a technical system, unless these latter also have a more general use outside the technical context. This property includes in particular identification by mathematical expressions such as coordinate systems used for the identification of instances of E53 Place. The property does not reveal anything about when, where and by whom this identifier was used. A more detailed representation can be made using the fully developed (i.e. indirect) path through E15 Identifier Assignment.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P1_is_identified_by">crm:P1_is_identified_by</a>
    /// </summary>
    let P1_is_identified_by = _prefixId.prefix "P1_is_identified_by"
    /// <summary>
    ///   <para>rdfs:label : bezeichnetrdfs:label : идентифицируетrdfs:label : identifierdfs:label : είναι αναγνωριστικόrdfs:label : identifiesrdfs:label : identifica</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P1i_identifies">crm:P1i_identifies</a>
    /// </summary>
    let P1i_identifies = _prefixId.prefix "P1i_identifies"
    /// <summary>
    ///   <para>rdfs:label : avait pour but spécifiquerdfs:label : hatte den bestimmten Zweckrdfs:label : had specific purposerdfs:label : имел конкретную цельrdfs:label : είχε συγκεκριμένο σκοπόrdfs:label : tinha propósito específico</para>
    ///   <para>rdfs:comment : This property identifies the relationship between a preparatory activity and the event it is intended to be preparation for.
    /// This includes activities, orders and other organisational actions, taken in preparation for other activities or events.
    /// P20 had specific purpose (was purpose of) implies that an activity succeeded in achieving its aim. If it does not succeed, such as the setting of a trap that did not catch anything, one may document the unrealized intention using P21 had general purpose (was purpose of):E55 Type and/or  P33 used specific technique (was used by): E29 Design or Procedure.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P20_had_specific_purpose">crm:P20_had_specific_purpose</a>
    /// </summary>
    let P20_had_specific_purpose = _prefixId.prefix "P20_had_specific_purpose"
    /// <summary>
    ///   <para>rdfs:label : war Zweck vonrdfs:label : был целью дляrdfs:label : ήταν σκοπός του/τηςrdfs:label : était le but derdfs:label : was purpose ofrdfs:label : era o propósito de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P20i_was_purpose_of">crm:P20i_was_purpose_of</a>
    /// </summary>
    let P20i_was_purpose_of = _prefixId.prefix "P20i_was_purpose_of"
    /// <summary>
    ///   <para>rdfs:label : tinha propósito geralrdfs:label : имел общую цельrdfs:label : avait pour but généralrdfs:label : had general purposerdfs:label : είχε γενικό σκοπόrdfs:label : hatte den allgemeinen Zweck</para>
    ///   <para>rdfs:comment : This property describes an intentional relationship between an E7 Activity and some general goal or purpose.
    /// This may involve activities intended as preparation for some type of activity or event. P21had general purpose (was purpose of) differs from P20 had specific purpose (was purpose of) in that no occurrence of an event is implied as the purpose.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P21_had_general_purpose">crm:P21_had_general_purpose</a>
    /// </summary>
    let P21_had_general_purpose = _prefixId.prefix "P21_had_general_purpose"
    /// <summary>
    ///   <para>rdfs:label : был целью дляrdfs:label : était le but derdfs:label : ήταν σκοπός του/τηςrdfs:label : war Zweck vonrdfs:label : was purpose ofrdfs:label : era o propósito de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P21i_was_purpose_of">crm:P21i_was_purpose_of</a>
    /// </summary>
    let P21i_was_purpose_of = _prefixId.prefix "P21i_was_purpose_of"
    /// <summary>
    ///   <para>rdfs:label : a fait passer le droit de propriété àrdfs:label : transferred title tordfs:label : übertrug Besitztitel aufrdfs:label : μετεβίβασε τον τίτλο σεrdfs:label : передал право собственностиrdfs:label : transferiu os direitos de propriedade para</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor that acquires the legal ownership of an object as a result of an E8 Acquisition.
    /// The property will typically describe an Actor purchasing or otherwise acquiring an object from another Actor. However, title may also be acquired, without any corresponding loss of title by another Actor, through legal fieldwork such as hunting, shooting or fishing.
    /// In reality the title is either transferred to or from someone, or both.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P22_transferred_title_to">crm:P22_transferred_title_to</a>
    /// </summary>
    let P22_transferred_title_to = _prefixId.prefix "P22_transferred_title_to"
    /// <summary>
    ///   <para>rdfs:label : adquiriu os direitos de propriedade por meio dardfs:label : erwarb Besitztitel durchrdfs:label : получил право собственности черезrdfs:label : απέκτησε τον τίτλο μέσωrdfs:label : a acquis le droit de propriété du fait derdfs:label : acquired title through</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P22i_acquired_title_through">crm:P22i_acquired_title_through</a>
    /// </summary>
    let P22i_acquired_title_through = _prefixId.prefix "P22i_acquired_title_through"
    /// <summary>
    ///   <para>rdfs:label : μετεβίβασε τον τίτλο απόrdfs:label : transferiu os direitos de propriedade derdfs:label : übertrug Besitztitel vonrdfs:label : a fait passer le droit de propriété derdfs:label : передал право собственности отrdfs:label : transferred title from</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor or Actors who relinquish legal ownership as the result of an E8 Acquisition.
    /// The property will typically be used to describe a person donating or selling an object to a museum. In reality title is either transferred to or from someone, or both.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P23_transferred_title_from">crm:P23_transferred_title_from</a>
    /// </summary>
    let P23_transferred_title_from = _prefixId.prefix "P23_transferred_title_from"

    /// <summary>
    ///   <para>rdfs:label : a perdu le droit de propriété du fait derdfs:label : право собственности отдано черезrdfs:label : surrendered title throughrdfs:label : παρέδωσε τον τίτλο μέσωrdfs:label : perdeu os direitos de propriedade por meio dardfs:label : trat Besitztitel ab in</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P23i_surrendered_title_through">crm:P23i_surrendered_title_through</a>
    /// </summary>
    let P23i_surrendered_title_through =
        _prefixId.prefix "P23i_surrendered_title_through"

    /// <summary>
    ///   <para>rdfs:comment : This property identifies the E18 Physical Thing or things involved in an E8 Acquisition.
    /// In reality, an acquisition must refer to at least one transferred item.
    /// </para>
    ///   <para>rdfs:label : a fait passer le droit de propriété surrdfs:label : transferiu os direitos de propriedade sobre ordfs:label : übertrug Besitz überrdfs:label : передал право собственности наrdfs:label : μετεβίβασε τον τίτλο του/τηςrdfs:label : transferred title of</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P24_transferred_title_of">crm:P24_transferred_title_of</a>
    /// </summary>
    let P24_transferred_title_of = _prefixId.prefix "P24_transferred_title_of"

    /// <summary>
    ///   <para>rdfs:label : сменил владельца черезrdfs:label : changed ownership throughrdfs:label : ging über in Besitz durchrdfs:label : άλλαξε ιδιοκτησία μέσωrdfs:label : a changé de mains du fait derdfs:label : mudou de proprietário por meio de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P24i_changed_ownership_through">crm:P24i_changed_ownership_through</a>
    /// </summary>
    let P24i_changed_ownership_through =
        _prefixId.prefix "P24i_changed_ownership_through"

    /// <summary>
    ///   <para>rdfs:label : μετεκίνησεrdfs:label : locomoveurdfs:label : movedrdfs:label : переместилrdfs:label : a déplacérdfs:label : bewegte</para>
    ///   <para>rdfs:comment : This property identifies the E19 Physical Object that is moved during a move event.
    /// The property implies the object’s passive participation. For example, Monet’s painting “Impression sunrise” was moved for the first Impressionist exhibition in 1874.
    /// In reality, a move must concern at least one object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P25_moved">crm:P25_moved</a>
    /// </summary>
    let P25_moved = _prefixId.prefix "P25_moved"
    /// <summary>
    ///   <para>rdfs:label : μετακινήθηκε απόrdfs:label : a été déplacé parrdfs:label : wurde bewegt durchrdfs:label : moved byrdfs:label : перемещен посредствомrdfs:label : foi locomovido por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P25i_moved_by">crm:P25i_moved_by</a>
    /// </summary>
    let P25i_moved_by = _prefixId.prefix "P25i_moved_by"
    /// <summary>
    ///   <para>rdfs:label : moved tordfs:label : locomoveu parardfs:label : перемещен вrdfs:label : μετακινήθηκε προςrdfs:label : bewegte bis zurdfs:label : a déplacé vers</para>
    ///   <para>rdfs:comment : This property identifies the destination of a E9 Move.
    /// A move will be linked to a destination, such as the move of an artefact from storage to display. A move may be linked to many terminal instances of E53 Places. In this case the move describes a distribution of a set of objects. The area of the move includes the origin, route and destination.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P26_moved_to">crm:P26_moved_to</a>
    /// </summary>
    let P26_moved_to = _prefixId.prefix "P26_moved_to"
    /// <summary>
    ///   <para>rdfs:label : era destinação derdfs:label : war Zielort vonrdfs:label : was destination ofrdfs:label : был пунктом назначения дляrdfs:label : a été la destination derdfs:label : ήταν προορισμός του/της</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P26i_was_destination_of">crm:P26i_was_destination_of</a>
    /// </summary>
    let P26i_was_destination_of = _prefixId.prefix "P26i_was_destination_of"
    /// <summary>
    ///   <para>rdfs:label : μετακινήθηκε απόrdfs:label : locomoveu derdfs:label : a retiré derdfs:label : moved fromrdfs:label : bewegte weg vonrdfs:label : перемещен из</para>
    ///   <para>rdfs:comment : This property identifies the starting E53 Place of an E9 Move.
    /// A move will be linked to an origin, such as the move of an artefact from storage to display. A move may be linked to many origins. In this case the move describes the picking up of a set of objects. The area of the move includes the origin, route and destination.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P27_moved_from">crm:P27_moved_from</a>
    /// </summary>
    let P27_moved_from = _prefixId.prefix "P27_moved_from"
    /// <summary>
    ///   <para>rdfs:label : era origem derdfs:label : war Ausgangsort vonrdfs:label : a été l'origine derdfs:label : was origin ofrdfs:label : был исходной точкой дляrdfs:label : ήταν αφετηρία του/της</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P27i_was_origin_of">crm:P27i_was_origin_of</a>
    /// </summary>
    let P27i_was_origin_of = _prefixId.prefix "P27i_was_origin_of"
    /// <summary>
    ///   <para>rdfs:label : übergab Gewahrsam anrdfs:label : custody surrendered byrdfs:label : опека отданаrdfs:label : μετεβίβασε κατοχή απόrdfs:label : changement de détenteur au détriment derdfs:label : custódia concedida por</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor or Actors who surrender custody of an instance of E18 Physical Thing in an E10 Transfer of Custody activity.
    /// The property will typically describe an Actor surrendering custody of an object when it is handed over to someone else’s care. On occasion, physical custody may be surrendered involuntarily – through accident, loss or theft.
    /// In reality, custody is either transferred to someone or from someone, or both.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P28_custody_surrendered_by">crm:P28_custody_surrendered_by</a>
    /// </summary>
    let P28_custody_surrendered_by = _prefixId.prefix "P28_custody_surrendered_by"

    /// <summary>
    ///   <para>rdfs:label : a cessé d’être détenteur à cause derdfs:label : final da custódia por meio derdfs:label : wurde Gewahrsam übergeben durchrdfs:label : παρέδωσε κατοχή μέσωrdfs:label : surrendered custody throughrdfs:label : опека отдана через</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P28i_surrendered_custody_through">crm:P28i_surrendered_custody_through</a>
    /// </summary>
    let P28i_surrendered_custody_through =
        _prefixId.prefix "P28i_surrendered_custody_through"

    /// <summary>
    ///   <para>rdfs:label : changement de détenteur au profit derdfs:label : custódia recebida porrdfs:label : custody received byrdfs:label : übertrug Gewahrsam aufrdfs:label : опека полученаrdfs:label : μετεβίβασε κατοχή σε</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor or Actors who receive custody of an instance of E18 Physical Thing in an E10 Transfer of Custody activity.
    /// The property will typically describe Actors receiving custody of an object when it is handed over from another Actor’s care. On occasion, physical custody may be received involuntarily or illegally – through accident, unsolicited donation, or theft.
    /// In reality, custody is either transferred to someone or from someone, or both.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P29_custody_received_by">crm:P29_custody_received_by</a>
    /// </summary>
    let P29_custody_received_by = _prefixId.prefix "P29_custody_received_by"
    /// <summary>
    ///   <para>rdfs:label : received custody throughrdfs:label : erhielt Gewahrsam durchrdfs:label : est devenu détenteur grâce àrdfs:label : получил опеку черезrdfs:label : παρέλαβε κατοχή μέσωrdfs:label : início da custódia por meio de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P29i_received_custody_through">crm:P29i_received_custody_through</a>
    /// </summary>
    let P29i_received_custody_through = _prefixId.prefix "P29i_received_custody_through"
    /// <summary>
    ///   <para>rdfs:label : έχει τύποrdfs:label : имеет типrdfs:label : est de typerdfs:label : has typerdfs:label : hat den Typusrdfs:label : é do tipo</para>
    ///   <para>rdfs:comment : This property allows sub typing of CRM entities - a form of specialisation – through the use of a terminological hierarchy, or thesaurus.
    /// The CRM is intended to focus on the high-level entities and relationships needed to describe data structures. Consequently, it does not specialise entities any further than is required for this immediate purpose. However, entities in the isA hierarchy of the CRM may by specialised into any number of sub entities, which can be defined in the E55 Type hierarchy. E51 Contact Point, for example, may be specialised into “e-mail address”, “telephone number”, “post office box”, “URL” etc. none of which figures explicitly in the CRM hierarchy. Sub typing obviously requires consistency between the meaning of the terms assigned and the more general intent of the CRM entity in question.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P2_has_type">crm:P2_has_type</a>
    /// </summary>
    let P2_has_type = _prefixId.prefix "P2_has_type"
    /// <summary>
    ///   <para>rdfs:label : является типом дляrdfs:label : est le type derdfs:label : είναι ο τύπος του/τηςrdfs:label : ist Typus vonrdfs:label : is type ofrdfs:label : é o tipo de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P2i_is_type_of">crm:P2i_is_type_of</a>
    /// </summary>
    let P2i_is_type_of = _prefixId.prefix "P2i_is_type_of"
    /// <summary>
    ///   <para>rdfs:label : changement de détenteur concernantrdfs:label : transferred custody ofrdfs:label : μετεβίβασε κατοχή του/της/τωνrdfs:label : transferida custódia derdfs:label : передало опеку наrdfs:label : übertrug Gewahrsam über</para>
    ///   <para>rdfs:comment : This property identifies an item or items of E18 Physical Thing concerned in an E10 Transfer of Custody activity.
    /// The property will typically describe the object that is handed over by an E39 Actor to another Actor’s custody. On occasion, physical custody may be transferred involuntarily or illegally – through accident, unsolicited donation, or theft.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P30_transferred_custody_of">crm:P30_transferred_custody_of</a>
    /// </summary>
    let P30_transferred_custody_of = _prefixId.prefix "P30_transferred_custody_of"

    /// <summary>
    ///   <para>rdfs:label : custody transferred throughrdfs:label : άλλαξε κατοχή μέσωrdfs:label : a changé de détenteur du fait derdfs:label : wechselte Gewahrsam durchrdfs:label : опека передана черезrdfs:label : custódia transferida por meio de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P30i_custody_transferred_through">crm:P30i_custody_transferred_through</a>
    /// </summary>
    let P30i_custody_transferred_through =
        _prefixId.prefix "P30i_custody_transferred_through"

    /// <summary>
    ///   <para>rdfs:label : has modifiedrdfs:label : veränderterdfs:label : a modifiérdfs:label : modificourdfs:label : изменилrdfs:label : τροποποίησε</para>
    ///   <para>rdfs:comment : This property identifies the E24 Physical Man-Made Thing modified in an E11 Modification.
    /// If a modification is applied to a non-man-made object, it is regarded as an E22 Man-Made Object from that time onwards.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P31_has_modified">crm:P31_has_modified</a>
    /// </summary>
    let P31_has_modified = _prefixId.prefix "P31_has_modified"
    /// <summary>
    ///   <para>rdfs:label : wurde verändert durchrdfs:label : τροποποιήθηκε απόrdfs:label : was modified byrdfs:label : a été modifié parrdfs:label : foi modificada porrdfs:label : был изменен посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P31i_was_modified_by">crm:P31i_was_modified_by</a>
    /// </summary>
    let P31i_was_modified_by = _prefixId.prefix "P31i_was_modified_by"
    /// <summary>
    ///   <para>rdfs:label : χρησιμοποίησε γενική τεχνικήrdfs:label : benutzte das allgemeine Verfahrenrdfs:label : использовал общую техникуrdfs:label : usou técnica geralrdfs:label : used general techniquerdfs:label : a employé comme technique générique</para>
    ///   <para>rdfs:comment : This property identifies the technique that was employed in an act of modification.
    /// These techniques should be drawn from an external E55 Type hierarchy of consistent terminology of general techniques such as embroidery, oil-painting, etc. Specific techniques may be further described as instances of E29 Design or Procedure.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P32_used_general_technique">crm:P32_used_general_technique</a>
    /// </summary>
    let P32_used_general_technique = _prefixId.prefix "P32_used_general_technique"
    /// <summary>
    ///   <para>rdfs:label : ήταν τεχνική του/τηςrdfs:label : was technique ofrdfs:label : war Verfahren vonrdfs:label : a été la technique mise en œuvre dansrdfs:label : был техникой дляrdfs:label : foi técnica da</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P32i_was_technique_of">crm:P32i_was_technique_of</a>
    /// </summary>
    let P32i_was_technique_of = _prefixId.prefix "P32i_was_technique_of"
    /// <summary>
    ///   <para>rdfs:label : usou técnica específicardfs:label : benutzte das bestimmte Verfahrenrdfs:label : использовал особую техникуrdfs:label : χρησιμοποίησε συγκεκριμένη τεχνικήrdfs:label : a employé comme technique spécifiquerdfs:label : used specific technique</para>
    ///   <para>rdfs:comment : This property identifies a specific instance of E29 Design or Procedure in order to carry out an instance of E7 Activity or parts of it.
    /// The property differs from P32 used general technique (was technique of) in that P33 refers to an instance of E29 Design or Procedure, which is a concrete information object in its own right rather than simply being a term or a method known by tradition.
    /// Typical examples would include intervention plans for conservation or the construction plans of a building.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P33_used_specific_technique">crm:P33_used_specific_technique</a>
    /// </summary>
    let P33_used_specific_technique = _prefixId.prefix "P33_used_specific_technique"
    /// <summary>
    ///   <para>rdfs:label : a été employée parrdfs:label : wurde benutzt vonrdfs:label : was used byrdfs:label : χρησιμοποιήθηκε γιαrdfs:label : foi usada porrdfs:label : был использован посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P33i_was_used_by">crm:P33i_was_used_by</a>
    /// </summary>
    let P33i_was_used_by = _prefixId.prefix "P33i_was_used_by"
    /// <summary>
    ///   <para>rdfs:label : αφορούσε σεrdfs:label : betrafrdfs:label : a concernérdfs:label : interessadardfs:label : имел дело сrdfs:label : concerned</para>
    ///   <para>rdfs:comment : This property identifies the E18 Physical Thing that was assessed during an E14 Condition Assessment activity.
    /// Conditions may be assessed either by direct observation or using recorded evidence. In the latter case the E18 Physical Thing does not need to be present or extant.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P34_concerned">crm:P34_concerned</a>
    /// </summary>
    let P34_concerned = _prefixId.prefix "P34_concerned"
    /// <summary>
    ///   <para>rdfs:label : wurde beurteilt durchrdfs:label : εκτιμήθηκε απόrdfs:label : was assessed byrdfs:label : expertisé par le biais derdfs:label : foi avaliada porrdfs:label : был оценен посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P34i_was_assessed_by">crm:P34i_was_assessed_by</a>
    /// </summary>
    let P34i_was_assessed_by = _prefixId.prefix "P34i_was_assessed_by"
    /// <summary>
    ///   <para>rdfs:label : identificourdfs:label : a identifiérdfs:label : идентифицировалrdfs:label : έχει διαπιστώσειrdfs:label : hat identifiziertrdfs:label : has identified</para>
    ///   <para>rdfs:comment : This property identifies the E3 Condition State that was observed in an E14 Condition Assessment activity.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P35_has_identified">crm:P35_has_identified</a>
    /// </summary>
    let P35_has_identified = _prefixId.prefix "P35_has_identified"
    /// <summary>
    ///   <para>rdfs:label : was identified byrdfs:label : foi identificado porrdfs:label : идентифицирован посредствомrdfs:label : wurde identifiziert durchrdfs:label : έχει διαπιστωθεί απόrdfs:label : est identifié par</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P35i_was_identified_by">crm:P35i_was_identified_by</a>
    /// </summary>
    let P35i_was_identified_by = _prefixId.prefix "P35i_was_identified_by"
    /// <summary>
    ///   <para>rdfs:label : a attribuérdfs:label : απέδωσεrdfs:label : wies zurdfs:label : atribuiurdfs:label : назначилrdfs:label : assigned</para>
    ///   <para>rdfs:comment : This property records the identifier that was assigned to an item in an Identifier Assignment activity.
    /// The same identifier may be assigned on more than one occasion.
    /// An Identifier might be created prior to an assignment.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P37_assigned">crm:P37_assigned</a>
    /// </summary>
    let P37_assigned = _prefixId.prefix "P37_assigned"
    /// <summary>
    ///   <para>rdfs:label : was assigned byrdfs:label : был присвоен посредствомrdfs:label : wurde zugewiesen durchrdfs:label : αποδόθηκε ως ιδιότητα απόrdfs:label : a été attribuée parrdfs:label : foi atribuído por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P37i_was_assigned_by">crm:P37i_was_assigned_by</a>
    /// </summary>
    let P37i_was_assigned_by = _prefixId.prefix "P37i_was_assigned_by"
    /// <summary>
    ///   <para>rdfs:comment : This property records the identifier that was deassigned from an instance of E1 CRM Entity.
    /// Deassignment of an identifier may be necessary when an item is taken out of an inventory, a new numbering system is introduced or items are merged or split up.
    /// The same identifier may be deassigned on more than one occasion.
    /// </para>
    ///   <para>rdfs:label : a désattribuérdfs:label :  hob Zuweisung auf vonrdfs:label : deassignedrdfs:label : retirou a atribuição dordfs:label : отменил назначениеrdfs:label : ακύρωσε</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P38_deassigned">crm:P38_deassigned</a>
    /// </summary>
    let P38_deassigned = _prefixId.prefix "P38_deassigned"
    /// <summary>
    ///   <para>rdfs:label : was deassigned byrdfs:label : ακυρώθηκε απόrdfs:label : wurde aufgehoben durchrdfs:label : был отменен посредствомrdfs:label : foi retirada a atribuição porrdfs:label : a été désattribué par</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P38i_was_deassigned_by">crm:P38i_was_deassigned_by</a>
    /// </summary>
    let P38i_was_deassigned_by = _prefixId.prefix "P38i_was_deassigned_by"
    /// <summary>
    ///   <para>rdfs:label : vermaßrdfs:label : измерилrdfs:label : mediurdfs:label : a mesurérdfs:label : measuredrdfs:label : μέτρησε</para>
    ///   <para>rdfs:comment : This property associates an instance of E16 Measurement with the instance of E1 CRM Entity to which it applied. An instance of E1 CRM Entity may be measured more than once. Material and immaterial things and processes may be measured, e.g. the number of words in a text, or the duration of an event.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P39_measured">crm:P39_measured</a>
    /// </summary>
    let P39_measured = _prefixId.prefix "P39_measured"
    /// <summary>
    ///   <para>rdfs:label : was measured byrdfs:label : wurde vermessen durchrdfs:label : μετρήθηκε απόrdfs:label : был измерен посредствомrdfs:label : foi medida porrdfs:label : a été mesuré par</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P39i_was_measured_by">crm:P39i_was_measured_by</a>
    /// </summary>
    let P39i_was_measured_by = _prefixId.prefix "P39i_was_measured_by"
    /// <summary>
    ///   <para>rdfs:label : has noterdfs:label : έχει επεξήγησηrdfs:label : a pour noterdfs:label : имеет примечаниеrdfs:label : hat Anmerkungrdfs:label : tem nota</para>
    ///   <para>rdfs:comment : This property is a container for all informal descriptions about an object that have not been expressed in terms of CRM constructs.
    /// In particular it captures the characterisation of the item itself, its internal structures, appearance etc.
    /// Like property P2 has type (is type of), this property is a consequence of the restricted focus of the CRM. The aim is not to capture, in a structured form, everything that can be said about an item; indeed, the CRM formalism is not regarded as sufficient to express everything that can be said. Good practice requires use of distinct note fields for different aspects of a characterisation. The P3.1 has type property of P3 has note allows differentiation of specific notes, e.g. “construction”, “decoration” etc.
    /// An item may have many notes, but a note is attached to a specific item.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P3_has_note">crm:P3_has_note</a>
    /// </summary>
    let P3_has_note = _prefixId.prefix "P3_has_note"
    /// <summary>
    ///   <para>rdfs:label : observed dimensionrdfs:label : παρατήρησεrdfs:label : определил величинуrdfs:label : verificou a dimensãordfs:label : beobachtete Dimensionrdfs:label : a relevé comme dimension</para>
    ///   <para>rdfs:comment : This property records the dimension that was observed in an E16 Measurement Event.
    /// E54 Dimension can be any quantifiable aspect of E70 Thing. Weight, image colour depth and monetary value are dimensions in this sense. One measurement activity may determine more than one dimension of one object.
    /// Dimensions may be determined either by direct observation or using recorded evidence. In the latter case the measured Thing does not need to be present or extant.
    /// Even though knowledge of the value of a dimension requires measurement, the dimension may be an object of discourse prior to, or even without, any measurement being made.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P40_observed_dimension">crm:P40_observed_dimension</a>
    /// </summary>
    let P40_observed_dimension = _prefixId.prefix "P40_observed_dimension"
    /// <summary>
    ///   <para>rdfs:label : παρατηρήθηκε απόrdfs:label : foi verificada duranterdfs:label : wurde beobachtet inrdfs:label : a été relevée au cours derdfs:label : наблюдался вrdfs:label : was observed in</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P40i_was_observed_in">crm:P40i_was_observed_in</a>
    /// </summary>
    let P40i_was_observed_in = _prefixId.prefix "P40i_was_observed_in"
    /// <summary>
    ///   <para>rdfs:label : classifiedrdfs:label : a classifiérdfs:label : klassifizierterdfs:label : classificourdfs:label : классифицировалrdfs:label : χαρακτήρισε</para>
    ///   <para>rdfs:comment : This property records the item to which a type was assigned in an E17 Type Assignment activity.
    /// Any instance of a CRM entity may be assigned a type through type assignment. Type assignment events allow a more detailed path from E1 CRM Entity through P41 classified (was classified), E17 Type Assignment, P42 assigned (was assigned by) to E55 Type for assigning types to objects compared to the shortcut offered by P2 has type (is type of).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P41_classified">crm:P41_classified</a>
    /// </summary>
    let P41_classified = _prefixId.prefix "P41_classified"
    /// <summary>
    ///   <para>rdfs:label : был классифицирован посредствомrdfs:label : a été classifiée par le biais derdfs:label : was classified byrdfs:label : χαρακτηρίσθηκε απόrdfs:label : foi classificada porrdfs:label : wurde klassifiziert durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P41i_was_classified_by">crm:P41i_was_classified_by</a>
    /// </summary>
    let P41i_was_classified_by = _prefixId.prefix "P41i_was_classified_by"
    /// <summary>
    ///   <para>rdfs:label : a attribuérdfs:label : atribuiurdfs:label : wies zurdfs:label : assignedrdfs:label : απέδωσε ως ιδιότηταrdfs:label : назначил</para>
    ///   <para>rdfs:comment : This property records the type that was assigned to an entity by an E17 Type Assignment activity.
    /// Type assignment events allow a more detailed path from E1 CRM Entity through P41 classified (was classified by), E17 Type Assignment, P42 assigned (was assigned by) to E55 Type for assigning types to objects compared to the shortcut offered by P2 has type (is type of).
    /// For example, a fragment of an antique vessel could be assigned the type “attic red figured belly handled amphora” by expert A. The same fragment could be assigned the type “shoulder handled amphora” by expert B.
    /// A Type may be intellectually constructed independent from assigning an instance of it.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P42_assigned">crm:P42_assigned</a>
    /// </summary>
    let P42_assigned = _prefixId.prefix "P42_assigned"
    /// <summary>
    ///   <para>rdfs:label : был присвоен посредствомrdfs:label : wurde zugewiesen durchrdfs:label : foi atribuído porrdfs:label : was assigned byrdfs:label : a été attribué parrdfs:label : αποδόθηκε από</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P42i_was_assigned_by">crm:P42i_was_assigned_by</a>
    /// </summary>
    let P42i_was_assigned_by = _prefixId.prefix "P42i_was_assigned_by"
    /// <summary>
    ///   <para>rdfs:label : tem dimensãordfs:label : έχει μέγεθοςrdfs:label : has dimensionrdfs:label : a pour dimensionrdfs:label : имеет величинуrdfs:label : hat Dimension</para>
    ///   <para>rdfs:comment : This property records a E54 Dimension of some E70 Thing.
    /// It is a shortcut of the more fully developed path from E70 Thing through P39 measured (was measured by), E16 Measurement P40 observed dimension (was observed in) to E54 Dimension. It offers no information about how and when an E54 Dimension was established, nor by whom.
    /// An instance of E54 Dimension is specific to an instance of E70 Thing.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P43_has_dimension">crm:P43_has_dimension</a>
    /// </summary>
    let P43_has_dimension = _prefixId.prefix "P43_has_dimension"
    /// <summary>
    ///   <para>rdfs:label : ist Dimension vonrdfs:label : is dimension ofrdfs:label : является величиной дляrdfs:label : est dimension derdfs:label : είναι μέγεθος τουrdfs:label : é dimensão de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P43i_is_dimension_of">crm:P43i_is_dimension_of</a>
    /// </summary>
    let P43i_is_dimension_of = _prefixId.prefix "P43i_is_dimension_of"
    /// <summary>
    ///   <para>rdfs:label : имеет условиеrdfs:label : has conditionrdfs:label : hat Zustandrdfs:label : έχει κατάστασηrdfs:label : tem estado material rdfs:label : a pour état matériel</para>
    ///   <para>rdfs:comment : This property records an E3 Condition State for some E18 Physical Thing.
    /// It is a shortcut of the more fully developed path from E18 Physical Thing through P34 concerned (was assessed by), E14 Condition Assessment P35 has identified (was identified by) to E3 Condition State. It offers no information about how and when the E3 Condition State was established, nor by whom.
    /// An instance of Condition State is specific to an instance of Physical Thing.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P44_has_condition">crm:P44_has_condition</a>
    /// </summary>
    let P44_has_condition = _prefixId.prefix "P44_has_condition"
    /// <summary>
    ///   <para>rdfs:label : ist Zustand vonrdfs:label : état matériel derdfs:label : είναι κατάσταση τουrdfs:label : является условием дляrdfs:label : is condition ofrdfs:label : estado material de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P44i_is_condition_of">crm:P44i_is_condition_of</a>
    /// </summary>
    let P44i_is_condition_of = _prefixId.prefix "P44i_is_condition_of"
    /// <summary>
    ///   <para>rdfs:label : consiste enrdfs:label : consists ofrdfs:label : αποτελείται απόrdfs:label : consiste derdfs:label : besteht ausrdfs:label : составлен из</para>
    ///   <para>rdfs:comment : This property identifies the instances of E57 Materials of which an instance of E18 Physical Thing is composed.
    /// All physical things consist of physical materials. P45 consists of (is incorporated in) allows the different Materials to be recorded. P45 consists of (is incorporated in) refers here to observed Material as opposed to the consumed raw material.
    /// A Material, such as a theoretical alloy, may not have any physical instances</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P45_consists_of">crm:P45_consists_of</a>
    /// </summary>
    let P45_consists_of = _prefixId.prefix "P45_consists_of"
    /// <summary>
    ///   <para>rdfs:label : ist enthalten inrdfs:label : είναι ενσωματωμένος/η/ο σεrdfs:label : is incorporated inrdfs:label : входит в составrdfs:label : est présent dansrdfs:label : está presente em</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P45i_is_incorporated_in">crm:P45i_is_incorporated_in</a>
    /// </summary>
    let P45i_is_incorporated_in = _prefixId.prefix "P45i_is_incorporated_in"
    /// <summary>
    ///   <para>rdfs:label : αποτελείται απόrdfs:label : is composed ofrdfs:label : é composto derdfs:label : составлен изrdfs:label : est composée derdfs:label : ist zusammengesetzt aus</para>
    ///   <para>rdfs:comment : This property allows instances of E18 Physical Thing to be analysed into component elements.
    /// Component elements, since they are themselves instances of E18 Physical Thing, may be further analysed into sub-components, thereby creating a hierarchy of part decomposition. An instance of E18 Physical Thing may be shared between multiple wholes, for example two buildings may share a common wall.
    /// This property is intended to describe specific components that are individually documented, rather than general aspects. Overall descriptions of the structure of an instance of E18 Physical Thing are captured by the P3 has note property.
    /// The instances of E57 Materials of which an item of E18 Physical Thing is composed should be documented using P45 consists of (is incorporated in).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P46_is_composed_of">crm:P46_is_composed_of</a>
    /// </summary>
    let P46_is_composed_of = _prefixId.prefix "P46_is_composed_of"
    /// <summary>
    ///   <para>rdfs:label : формирует частьrdfs:label : fait partie derdfs:label : αποτελεί μέρος του/τηςrdfs:label : bildet Teil vonrdfs:label : forms part ofrdfs:label : faz parte de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P46i_forms_part_of">crm:P46i_forms_part_of</a>
    /// </summary>
    let P46i_forms_part_of = _prefixId.prefix "P46i_forms_part_of"
    /// <summary>
    ///   <para>rdfs:label : hat bevorzugtes Kennzeichenrdfs:label : tem identificador preferidordfs:label : имеет предпочтительный идентификаторrdfs:label : a pour identificateur retenurdfs:label : has preferred identifierrdfs:label : έχει προτιμώμενο αναγνωριστικό</para>
    ///   <para>rdfs:comment : This property records the preferred E42 Identifier that was used to identify an instance of E1 CRM Entity at the time this property was recorded.
    /// More than one preferred identifier may have been assigned to an item over time.
    /// Use of this property requires an external mechanism for assigning temporal validity to the respective CRM instance.
    /// P48 has preferred identifier (is preferred identifier of), is a shortcut for the path from E1 CRM Entity through P140 assigned attribute to (was attributed by), E15 Identifier Assignment, P37 assigned (was assigned by) to E42 Identifier. The fact that an identifier is a preferred one for an organisation can be better expressed in a context independent form by assigning a suitable E55 Type to the respective instance of E15 Identifier Assignment using the P2 has type property.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P48_has_preferred_identifier">crm:P48_has_preferred_identifier</a>
    /// </summary>
    let P48_has_preferred_identifier = _prefixId.prefix "P48_has_preferred_identifier"

    /// <summary>
    ///   <para>rdfs:label : est l’identificateur retenu derdfs:label : είναι προτιμώμενο αναγνωριστικόrdfs:label : is preferred identifier ofrdfs:label : ist bevorzugtes Kennzeichen fürrdfs:label : является предпочтительным идентификатором дляrdfs:label : é o identificador preferido de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P48i_is_preferred_identifier_of">crm:P48i_is_preferred_identifier_of</a>
    /// </summary>
    let P48i_is_preferred_identifier_of =
        _prefixId.prefix "P48i_is_preferred_identifier_of"

    /// <summary>
    ///   <para>rdfs:label : имеет бывшего или текущего смотрителяrdfs:label : est ou a été détenu parrdfs:label : είναι ή ήταν στην κατοχή τουrdfs:label : hat früheren oder derzeitigen Betreuerrdfs:label : é ou foi guardada porrdfs:label : has former or current keeper</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor or Actors who have or have had custody of an instance of E18 Physical Thing at some time.
    /// The distinction with P50 has current keeper (is current keeper of) is that P49 has former or current keeper (is former or current keeper of) leaves open the question as to whether the specified keepers are current.
    /// P49 has former or current keeper (is former or current keeper of) is a shortcut for the more detailed path from E18 Physical Thing through P30 transferred custody of (custody transferred through), E10 Transfer of Custody, P28 custody surrendered by (surrendered custody through) or P29 custody received by (received custody through) to E39 Actor.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P49_has_former_or_current_keeper">crm:P49_has_former_or_current_keeper</a>
    /// </summary>
    let P49_has_former_or_current_keeper =
        _prefixId.prefix "P49_has_former_or_current_keeper"

    /// <summary>
    ///   <para>rdfs:label : is former or current keeper ofrdfs:label : κατέχει ή κατείχεrdfs:label : est ou a été détenteur derdfs:label : ist früherer oder derzeitiger Betreuer vonrdfs:label : является бывшим или текущим смотрителем дляrdfs:label : é ou foi guardador de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P49i_is_former_or_current_keeper_of">crm:P49i_is_former_or_current_keeper_of</a>
    /// </summary>
    let P49i_is_former_or_current_keeper_of =
        _prefixId.prefix "P49i_is_former_or_current_keeper_of"

    /// <summary>
    ///   <para>rdfs:label : a pour duréerdfs:label : tem período de tempordfs:label : имеет временной отрезокrdfs:label : has time-spanrdfs:label : hat Zeitspannerdfs:label : βρισκόταν σε εξέλιξη</para>
    ///   <para>rdfs:comment : This property describes the temporal confinement of an instance of an E2 Temporal Entity.
    /// The related E52 Time-Span is understood as the real Time-Span during which the phenomena were active, which make up the temporal entity instance. It does not convey any other meaning than a positioning on the “time-line” of chronology. The Time-Span in turn is approximated by a set of dates (E61 Time Primitive). A temporal entity can have in reality only one Time-Span, but there may exist alternative opinions about it, which we would express by assigning multiple Time-Spans. Related temporal entities may share a Time-Span. Time-Spans may have completely unknown dates but other descriptions by which we can infer knowledge.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P4_has_time-span">crm:P4_has_time-span</a>
    /// </summary>
    let P4_has_time_span = _prefixId.prefix "P4_has_time-span"
    /// <summary>
    ///   <para>rdfs:label : is time-span ofrdfs:label : είναι χρονικό διάστημα του/τηςrdfs:label : est la durée derdfs:label : является временным отрезком дляrdfs:label : ist Zeitspanne vonrdfs:label : é o período de tempo de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P4i_is_time-span_of">crm:P4i_is_time-span_of</a>
    /// </summary>
    let P4i_is_time_span_of = _prefixId.prefix "P4i_is_time-span_of"
    /// <summary>
    ///   <para>rdfs:label : είναι στην κατοχή τουrdfs:label : hat derzeitigen Betreuerrdfs:label : имеет текущего смотрителяrdfs:label : est actuellement détenu parrdfs:label : é guardada porrdfs:label : has current keeper</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor or Actors who had custody of an instance of E18 Physical Thing at the time this property was recorded.
    /// P50 has current keeper (is current keeper of) is a shortcut for the more detailed path from E18 Physical Thing through P30 transferred custody of (custody transferred through), E10 Transfer of Custody, P29 custody received by (received custody through) to E39 Actor.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P50_has_current_keeper">crm:P50_has_current_keeper</a>
    /// </summary>
    let P50_has_current_keeper = _prefixId.prefix "P50_has_current_keeper"
    /// <summary>
    ///   <para>rdfs:label : является текущим смотрителем дляrdfs:label : é guardador derdfs:label : ist derzeitiger Betreuer vonrdfs:label : κατέχειrdfs:label : is current keeper ofrdfs:label : est actuel détenteur de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P50i_is_current_keeper_of">crm:P50i_is_current_keeper_of</a>
    /// </summary>
    let P50i_is_current_keeper_of = _prefixId.prefix "P50i_is_current_keeper_of"

    /// <summary>
    ///   <para>rdfs:label : est ou a été possédée parrdfs:label : é ou foi propriedade derdfs:label : has former or current ownerrdfs:label : hat früheren oder derzeitigen Besitzer rdfs:label : έχει ή είχε ιδιοκτήτηrdfs:label : имеет бывшего или текущего владельца</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor that is or has been the legal owner (i.e. title holder) of an instance of E18 Physical Thing at some time.
    /// The distinction with P52 has current owner (is current owner of) is that P51 has former or current owner (is former or current owner of) does not indicate whether the specified owners are current. P51 has former or current owner (is former or current owner of) is a shortcut for the more detailed path from E18 Physical Thing through P24 transferred title of (changed ownership through), E8 Acquisition, P23 transferred title from (surrendered title through), or P22 transferred title to (acquired title through) to E39 Actor.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P51_has_former_or_current_owner">crm:P51_has_former_or_current_owner</a>
    /// </summary>
    let P51_has_former_or_current_owner =
        _prefixId.prefix "P51_has_former_or_current_owner"

    /// <summary>
    ///   <para>rdfs:label : является бывшим или текущим владельцем дляrdfs:label : είναι ή ήταν ιδιοκτήτης του/τηςrdfs:label : est ou a été propriétaire derdfs:label : is former or current owner ofrdfs:label : ist früherer oder derzeitiger Besitzer vonrdfs:label : é ou foi proprietário de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P51i_is_former_or_current_owner_of">crm:P51i_is_former_or_current_owner_of</a>
    /// </summary>
    let P51i_is_former_or_current_owner_of =
        _prefixId.prefix "P51i_is_former_or_current_owner_of"

    /// <summary>
    ///   <para>rdfs:label : hat derzeitigen Besitzerrdfs:label : έχει ιδιοκτήτηrdfs:label : has current ownerrdfs:label : имеет текущего владельцаrdfs:label : é propriedade derdfs:label : est actuellement possédée par</para>
    ///   <para>rdfs:comment : This property identifies the E21 Person, E74 Group or E40 Legal Body that was the owner of an instance of E18 Physical Thing at the time this property was recorded.
    /// P52 has current owner (is current owner of) is a shortcut for the more detailed path from E18 Physical Thing through P24 transferred title of (changed ownership through), E8 Acquisition, P22 transferred title to (acquired title through) to E39 Actor, if and only if this acquisition event is the most recent.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P52_has_current_owner">crm:P52_has_current_owner</a>
    /// </summary>
    let P52_has_current_owner = _prefixId.prefix "P52_has_current_owner"
    /// <summary>
    ///   <para>rdfs:label : είναι ιδιοκτήτης τουrdfs:label : is current owner ofrdfs:label : ist derzeitiger Besitzer vonrdfs:label : est le propriétaire actuel derdfs:label : является текущим владельцем дляrdfs:label : é proprietário de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P52i_is_current_owner_of">crm:P52i_is_current_owner_of</a>
    /// </summary>
    let P52i_is_current_owner_of = _prefixId.prefix "P52i_is_current_owner_of"

    /// <summary>
    ///   <para>rdfs:label : hat früheren oder derzeitigen Standortrdfs:label : имеет текущее или бывшее местоположениеrdfs:label : has former or current locationrdfs:label : βρίσκεται ή βρισκόταν σεrdfs:label : é ou foi localizada emrdfs:label : a ou a eu pour localisation</para>
    ///   <para>rdfs:comment : This property allows an instance of E53 Place to be associated as the former or current location of an instance of E18 Physical Thing.
    /// In the case of E19 Physical Objects, the property does not allow any indication of the Time-Span during which the Physical Object was located at this Place, nor if this is the current location.
    /// In the case of immobile objects, the Place would normally correspond to the Place of creation.
    /// P53 has former or current location (is former or current location of) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P25 moved (moved by), E9 Move, P26 moved to (was destination of) or P27 moved from (was origin of) to E53 Place.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P53_has_former_or_current_location">crm:P53_has_former_or_current_location</a>
    /// </summary>
    let P53_has_former_or_current_location =
        _prefixId.prefix "P53_has_former_or_current_location"

    /// <summary>
    ///   <para>rdfs:label : является текущим или бывшим местоположением дляrdfs:label : is former or current location ofrdfs:label : είναι ή ήταν θέση τουrdfs:label : ist früherer oder derzeitiger Standort vonrdfs:label : est ou a été localisation derdfs:label : é ou foi localização de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P53i_is_former_or_current_location_of">crm:P53i_is_former_or_current_location_of</a>
    /// </summary>
    let P53i_is_former_or_current_location_of =
        _prefixId.prefix "P53i_is_former_or_current_location_of"

    /// <summary>
    ///   <para>rdfs:label : a actuellement pour localisation à demeurerdfs:label : hat derzeitigen permanenten Standortrdfs:label : é localizado permanentemente emrdfs:label : έχει μόνιμη θέσηrdfs:label : имеет текущее постоянное местоположениеrdfs:label : has current permanent location</para>
    ///   <para>rdfs:comment : This property records the foreseen permanent location of an instance of E19 Physical Object at the time this property was recorded.
    /// P54 has current permanent location (is current permanent location of) is similar to P55 has current location (currently holds). However, it indicates the E53 Place currently reserved for an object, such as the permanent storage location or a permanent exhibit location. The object may be temporarily removed from the permanent location, for example when used in temporary exhibitions or loaned to another institution. The object may never actually be located at its permanent location.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P54_has_current_permanent_location">crm:P54_has_current_permanent_location</a>
    /// </summary>
    let P54_has_current_permanent_location =
        _prefixId.prefix "P54_has_current_permanent_location"

    /// <summary>
    ///   <para>rdfs:label : είναι μόνιμη θέση του/τηςrdfs:label : ist derzeitiger permanenter Standort vonrdfs:label : est actuellement localisation à demeure derdfs:label : is current permanent location ofrdfs:label : является текущим постоянным местоположением дляrdfs:label : é localização permanente de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P54i_is_current_permanent_location_of">crm:P54i_is_current_permanent_location_of</a>
    /// </summary>
    let P54i_is_current_permanent_location_of =
        _prefixId.prefix "P54i_is_current_permanent_location_of"

    /// <summary>
    ///   <para>rdfs:label : hat derzeitigen Standortrdfs:label : в данный момент находится вrdfs:label : é localizado emrdfs:label : a pour localisation actuellerdfs:label : βρίσκεται σεrdfs:label : has current location</para>
    ///   <para>rdfs:comment : This property records the location of an E19 Physical Object at the time the property was recorded.
    /// This property is a specialisation of P53 has former or current location (is former or current location of). It indicates that the E53 Place associated with the E19 Physical Object is the current location of the object. The property does not allow any indication of how long the Object has been at the current location.
    /// P55 has current location (currently holds) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P25 moved (moved by), E9 Move P26 moved to (was destination of) to E53 Place if and only if this Move is the most recent.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P55_has_current_location">crm:P55_has_current_location</a>
    /// </summary>
    let P55_has_current_location = _prefixId.prefix "P55_has_current_location"
    /// <summary>
    ///   <para>rdfs:label : в данный момент содержитrdfs:label : hält derzeitigrdfs:label : é localização atual derdfs:label : currently holdsrdfs:label : είναι θέση τουrdfs:label : est localisation actuelle de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P55i_currently_holds">crm:P55i_currently_holds</a>
    /// </summary>
    let P55i_currently_holds = _prefixId.prefix "P55i_currently_holds"
    /// <summary>
    ///   <para>rdfs:label : несет признакrdfs:label : possui característicardfs:label : trägt Merkmalrdfs:label : φέρει μόρφωμαrdfs:label : présente pour caractéristiquerdfs:label : bears feature</para>
    ///   <para>rdfs:comment : This property describes a E26 Physical Feature found on a E19 Physical Object It does not specify the location of the feature on the object.
    /// P56 bears feature (is found on) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P59 has section (is located on or within), E53 Place, P53 has former or current location (is former or current location of) to E26 Physical Feature.
    /// A Physical Feature can only exist on one object. One object may bear more than one Physical Feature. An E27 Site should be considered as an E26 Physical Feature on the surface of the Earth.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P56_bears_feature">crm:P56_bears_feature</a>
    /// </summary>
    let P56_bears_feature = _prefixId.prefix "P56_bears_feature"
    /// <summary>
    ///   <para>rdfs:label : βρίσκεται σεrdfs:label : se trouve surrdfs:label : é encontrada emrdfs:label : is found onrdfs:label : найден наrdfs:label : wird gefunden auf</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P56i_is_found_on">crm:P56i_is_found_on</a>
    /// </summary>
    let P56i_is_found_on = _prefixId.prefix "P56i_is_found_on"
    /// <summary>
    ///   <para>rdfs:label : имеет число частейrdfs:label : hat Anzahl Teilerdfs:label : tem número de partesrdfs:label : has number of partsrdfs:label : a pour nombre de partiesrdfs:label : έχει αριθμό μερών</para>
    ///   <para>rdfs:comment : This property documents the E60 Number of parts of which an instance of E19 Physical Object is composed.
    /// This may be used as a method of checking inventory counts with regard to aggregate or collective objects. What constitutes a part or component depends on the context and requirements of the documentation. Normally, the parts documented in this way would not be considered as worthy of individual attention.
    /// For a more complete description, objects may be decomposed into their components and constituents using P46 is composed of (forms parts of) and P45 consists of (is incorporated in). This allows each element to be described individually.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P57_has_number_of_parts">crm:P57_has_number_of_parts</a>
    /// </summary>
    let P57_has_number_of_parts = _prefixId.prefix "P57_has_number_of_parts"
    /// <summary>
    ///   <para>rdfs:label : has section definitionrdfs:label : tem designação de seçãordfs:label : имеет определение районаrdfs:label : a pour désignation de sectionrdfs:label : hat Abschittsdefinitionrdfs:label : έχει ορισμό τμήματος</para>
    ///   <para>rdfs:comment : This property links an area (section) named by a E46 Section Definition to the instance of E18 Physical Thing upon which it is found.
    /// The CRM handles sections as locations (instances of E53 Place) within or on E18 Physical Thing that are identified by E46 Section Definitions. Sections need not be discrete and separable components or parts of an object.
    /// This is part of a more developed path from E18 Physical Thing through P58, E46 Section Definition, P87 is identified by (identifies) that allows a more precise definition of a location found on an object than the shortcut P59 has section (is located on or within).
    /// A particular instance of a Section Definition only applies to one instance of Physical Thing.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P58_has_section_definition">crm:P58_has_section_definition</a>
    /// </summary>
    let P58_has_section_definition = _prefixId.prefix "P58_has_section_definition"
    /// <summary>
    ///   <para>rdfs:label : определяет районrdfs:label : defines sectionrdfs:label : definiert Abschitt auf oder vonrdfs:label : définit une section derdfs:label : ορίζει τμήμα σεrdfs:label : define uma seção de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P58i_defines_section">crm:P58i_defines_section</a>
    /// </summary>
    let P58i_defines_section = _prefixId.prefix "P58i_defines_section"
    /// <summary>
    ///   <para>rdfs:label : has sectionrdfs:label : tem seçãordfs:label : έχει τομέαrdfs:label : имеет районrdfs:label : hat Bereichrdfs:label : a pour section</para>
    ///   <para>rdfs:comment : This property links an area to the instance of E18 Physical Thing upon which it is found.
    /// It is typically used when a named E46 Section Definition is not appropriate.
    /// E18 Physical Thing may be subdivided into arbitrary regions.
    /// P59 has section (is located on or within) is a shortcut. If the E53 Place is identified by a Section Definition, a more detailed representation can make use of the fully developed (i.e. indirect) path from E18 Physical Thing through P58 has section definition (defines section), E46 Section Definition, P87 is identified by (identifies) to E53 Place. A Place can only be located on or within one Physical Object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P59_has_section">crm:P59_has_section</a>
    /// </summary>
    let P59_has_section = _prefixId.prefix "P59_has_section"
    /// <summary>
    ///   <para>rdfs:label : находится на или внутриrdfs:label : befindet sich auf oder inrdfs:label : βρίσκεται σε ή εντόςrdfs:label : se situe sur ou dansrdfs:label : is located on or withinrdfs:label : está localizada sobre ou dentro de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P59i_is_located_on_or_within">crm:P59i_is_located_on_or_within</a>
    /// </summary>
    let P59i_is_located_on_or_within = _prefixId.prefix "P59i_is_located_on_or_within"
    /// <summary>
    ///   <para>rdfs:label : consiste enrdfs:label : состоит изrdfs:label : αποτελείται απόrdfs:label : besteht ausrdfs:label : consists ofrdfs:label : consiste de</para>
    ///   <para>rdfs:comment : This property describes the decomposition of an E3 Condition State into discrete, subsidiary states.
    /// It is assumed that the sub-states into which the condition state is analysed form a logical whole - although the entire story may not be completely known – and that the sub-states are in fact constitutive of the general condition state. For example, a general condition state of “in ruins” may be decomposed into the individual stages of decay</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P5_consists_of">crm:P5_consists_of</a>
    /// </summary>
    let P5_consists_of = _prefixId.prefix "P5_consists_of"
    /// <summary>
    ///   <para>rdfs:label : bildet Teil vonrdfs:label : fait partie derdfs:label : формирует частьrdfs:label : forms part ofrdfs:label : αποτελεί μέρος του/τηςrdfs:label : faz parte de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P5i_forms_part_of">crm:P5i_forms_part_of</a>
    /// </summary>
    let P5i_forms_part_of = _prefixId.prefix "P5i_forms_part_of"
    /// <summary>
    ///   <para>rdfs:label : απεικονίζειrdfs:label : depictsrdfs:label : figurerdfs:label : retratardfs:label : bildet abrdfs:label : описывает</para>
    ///   <para>rdfs:comment : This property identifies something that is depicted by an instance of E24 Physical Man-Made Thing.
    /// This property is a shortcut of the more fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1CRM Entity. P62.1 mode of depiction allows the nature of the depiction to be refined.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P62_depicts">crm:P62_depicts</a>
    /// </summary>
    let P62_depicts = _prefixId.prefix "P62_depicts"
    /// <summary>
    ///   <para>rdfs:label : απεικονίζεται σεrdfs:label : wird abgebildet durchrdfs:label : is depicted byrdfs:label : описан посредствомrdfs:label : est figurée surrdfs:label : é retratada por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P62i_is_depicted_by">crm:P62i_is_depicted_by</a>
    /// </summary>
    let P62i_is_depicted_by = _prefixId.prefix "P62i_is_depicted_by"
    /// <summary>
    ///   <para>rdfs:label : εμφανίζει οπτικό στοιχείοrdfs:label : apresenta item visualrdfs:label : zeigt Bildlichesrdfs:label : показывает визуальный предметrdfs:label : shows visual itemrdfs:label : présente l'item visuel</para>
    ///   <para>rdfs:comment : This property documents an E36 Visual Item shown by an instance of E24 Physical Man-Made Thing.
    /// This property is similar to P62 depicts (is depicted by) in that it associates an item of E24 Physical Man-Made Thing with a visual representation. However, P65 shows visual item (is shown by) differs from the P62 depicts (is depicted by) property in that it makes no claims about what the E36 Visual Item is deemed to represent. E36 Visual Item identifies a recognisable image or visual symbol, regardless of what this image may or may not represent.
    /// For example, all recent British coins bear a portrait of Queen Elizabeth II, a fact that is correctly documented using P62 depicts (is depicted by). Different portraits have been used at different periods, however. P65 shows visual item (is shown by) can be used to refer to a particular portrait.
    /// P65 shows visual item (is shown by) may also be used for Visual Items such as signs, marks and symbols, for example the 'Maltese Cross' or the 'copyright symbol’ that have no particular representational content.
    /// This property is part of the fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1 CRM Entity which is shortcut by, P62 depicts (is depicted by).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P65_shows_visual_item">crm:P65_shows_visual_item</a>
    /// </summary>
    let P65_shows_visual_item = _prefixId.prefix "P65_shows_visual_item"
    /// <summary>
    ///   <para>rdfs:label : wird gezeigt durchrdfs:label : εμφανίζεται σεrdfs:label : est présenté parrdfs:label : is shown byrdfs:label : é apresentado porrdfs:label : показан посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P65i_is_shown_by">crm:P65i_is_shown_by</a>
    /// </summary>
    let P65i_is_shown_by = _prefixId.prefix "P65i_is_shown_by"
    /// <summary>
    ///   <para>rdfs:label : verweist aufrdfs:label : ссылается наrdfs:label : αναφέρεται σεrdfs:label : fait référence àrdfs:label : referenciardfs:label : refers to</para>
    ///   <para>rdfs:comment : This property documents that an E89 Propositional Object makes a statement about an instance of E1 CRM Entity. P67 refers to (is referred to by) has the P67.1 has type link to an instance of E55 Type. This is intended to allow a more detailed description of the type of reference. This differs from P129 is about (is subject of), which describes the primary subject or subjects of the E89 Propositional Object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P67_refers_to">crm:P67_refers_to</a>
    /// </summary>
    let P67_refers_to = _prefixId.prefix "P67_refers_to"
    /// <summary>
    ///   <para>rdfs:label : est référencé parrdfs:label : αναφέρεται απόrdfs:label : wird angeführt vonrdfs:label : is referred to byrdfs:label : имеет ссылку на себя отrdfs:label : é referenciado por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P67i_is_referred_to_by">crm:P67i_is_referred_to_by</a>
    /// </summary>
    let P67i_is_referred_to_by = _prefixId.prefix "P67i_is_referred_to_by"
    /// <summary>
    ///   <para>rdfs:label : συνήθως χρησιμοποιείrdfs:label : normalmente empregardfs:label :  sieht den Gebrauch vor vonrdfs:label : foresees use ofrdfs:label : utilise habituellementrdfs:label : обычно применяет</para>
    ///   <para>rdfs:comment : This property identifies an E57 Material foreseeen to be used by an E29 Design or Procedure.
    /// E29 Designs and procedures commonly foresee the use of particular E57 Materials. The fabrication of adobe bricks, for example, requires straw, clay and water. This property enables this to be documented.
    /// This property is not intended for the documentation of E57 Materials that were used on a particular occasion when an instance of E29 Design or Procedure was executed.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P68_foresees_use_of">crm:P68_foresees_use_of</a>
    /// </summary>
    let P68_foresees_use_of = _prefixId.prefix "P68_foresees_use_of"
    /// <summary>
    ///   <para>rdfs:label : est habituellement utilisé parrdfs:label : vorgesehen für Gebrauch durch definedrdfs:label : use foreseen byrdfs:label : é empregado porrdfs:label : συνήθως χρησιμοποιείται απόrdfs:label : обычно используется посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P68i_use_foreseen_by">crm:P68i_use_foreseen_by</a>
    /// </summary>
    let P68i_use_foreseen_by = _prefixId.prefix "P68i_use_foreseen_by"
    /// <summary>
    ///   <para>rdfs:label : ist verbunden mitrdfs:label : est associée àrdfs:label : é associado comrdfs:label : is associated withrdfs:label : ассоциирован сrdfs:label : σχετίζεται με</para>
    ///   <para>rdfs:comment : This symmetric property describes the association of an E29 Design or Procedure with other Designs or Procedures.
    /// Any instance of E29 Design or Procedure may be associated with other designs or procedures. The P69.1 has type property of P69 is associated with allows the nature of the association to be specified; examples of types of association between instances of E29 Design or Procedure include: whole-part, sequence, prerequisite, etc.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P69_is_associated_with">crm:P69_is_associated_with</a>
    /// </summary>
    let P69_is_associated_with = _prefixId.prefix "P69_is_associated_with"
    /// <summary>
    ///   <para>rdfs:label : mentionnerdfs:label : belegtrdfs:label : документируетrdfs:label : documentardfs:label : documentsrdfs:label : τεκμηριώνει</para>
    ///   <para>rdfs:comment : This property describes the CRM Entities documented by instances of E31 Document.
    /// Documents may describe any conceivable entity, hence the link to the highest-level entity in the CRM hierarchy. This property is intended for cases where a reference is regarded as being of a documentary character, in the scholarly or scientific sense.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P70_documents">crm:P70_documents</a>
    /// </summary>
    let P70_documents = _prefixId.prefix "P70_documents"
    /// <summary>
    ///   <para>rdfs:label : τεκμηριώνεται σεrdfs:label : est mentionnée dansrdfs:label : документирован вrdfs:label : wird belegt inrdfs:label : is documented inrdfs:label : é documentado em</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P70i_is_documented_in">crm:P70i_is_documented_in</a>
    /// </summary>
    let P70i_is_documented_in = _prefixId.prefix "P70i_is_documented_in"
    /// <summary>
    ///   <para>rdfs:label : περιλαμβάνειrdfs:label : definerdfs:label : définitrdfs:label : listsrdfs:label : listetrdfs:label : перечисляет</para>
    ///   <para>rdfs:comment : This property documents a source E32 Authority Document for an instance of an E1 CRM Entity.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P71_lists">crm:P71_lists</a>
    /// </summary>
    let P71_lists = _prefixId.prefix "P71_lists"
    /// <summary>
    ///   <para>rdfs:label : é definido porrdfs:label : περιλαμβάνεται σεrdfs:label : est défini parrdfs:label : перечислен вrdfs:label : wird aufgelistet inrdfs:label : is listed in</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P71i_is_listed_in">crm:P71i_is_listed_in</a>
    /// </summary>
    let P71i_is_listed_in = _prefixId.prefix "P71i_is_listed_in"
    /// <summary>
    ///   <para>rdfs:label : has languagerdfs:label : é da língua rdfs:label : hat Spracherdfs:label : est en languerdfs:label : έχει γλώσσαrdfs:label : имеет язык</para>
    ///   <para>rdfs:comment : This property describes the E56 Language of an E33 Linguistic Object.
    /// Linguistic Objects are composed in one or more human Languages. This property allows these languages to be documented.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P72_has_language">crm:P72_has_language</a>
    /// </summary>
    let P72_has_language = _prefixId.prefix "P72_has_language"
    /// <summary>
    ///   <para>rdfs:label : ist Sprache vonrdfs:label : είναι γλώσσα του/τηςrdfs:label : est la langue derdfs:label : является языком дляrdfs:label : is language ofrdfs:label : é a língua de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P72i_is_language_of">crm:P72i_is_language_of</a>
    /// </summary>
    let P72i_is_language_of = _prefixId.prefix "P72i_is_language_of"
    /// <summary>
    ///   <para>rdfs:label : hat Übersetzungrdfs:label : has translationrdfs:label : έχει μετάφρασηrdfs:label : tem traduçãordfs:label : a pour traductionrdfs:label : имеет перевод</para>
    ///   <para>rdfs:comment : This property describes the source and target of instances of E33Linguistic Object involved in a translation.
    /// When a Linguistic Object is translated into a new language it becomes a new Linguistic Object, despite being conceptually similar to the source object.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P73_has_translation">crm:P73_has_translation</a>
    /// </summary>
    let P73_has_translation = _prefixId.prefix "P73_has_translation"
    /// <summary>
    ///   <para>rdfs:label : est la traduction derdfs:label : is translation ofrdfs:label : είναι μετάφραση του/τηςrdfs:label : ist Übersetzung vonrdfs:label : é tradução derdfs:label : является переводом</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P73i_is_translation_of">crm:P73i_is_translation_of</a>
    /// </summary>
    let P73i_is_translation_of = _prefixId.prefix "P73i_is_translation_of"

    /// <summary>
    ///   <para>rdfs:label : έχει ή είχε κατοικίαrdfs:label : hat derzeitigen oder früheren Sitzrdfs:label : имеет текущее или бывшее местожительстваrdfs:label : reside ou residiu emrdfs:label : has current or former residencerdfs:label : réside ou a résidé à</para>
    ///   <para>rdfs:comment : This property describes the current or former E53 Place of residence of an E39 Actor.
    /// The residence may be either the Place where the Actor resides, or a legally registered address of any kind.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P74_has_current_or_former_residence">crm:P74_has_current_or_former_residence</a>
    /// </summary>
    let P74_has_current_or_former_residence =
        _prefixId.prefix "P74_has_current_or_former_residence"

    /// <summary>
    ///   <para>rdfs:label : είναι ή ήταν κατοικία του/τηςrdfs:label : ist derzeitiger oder früherer Sitz vonrdfs:label : est ou a été la résidence derdfs:label : является текущим или бывшим местом жительства дляrdfs:label : is current or former residence ofrdfs:label : é ou foi residência de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P74i_is_current_or_former_residence_of">crm:P74i_is_current_or_former_residence_of</a>
    /// </summary>
    let P74i_is_current_or_former_residence_of =
        _prefixId.prefix "P74i_is_current_or_former_residence_of"

    /// <summary>
    ///   <para>rdfs:label : κατέχειrdfs:label : possessesrdfs:label : владеетrdfs:label : é detentor derdfs:label : est détenteur derdfs:label : besitzt</para>
    ///   <para>rdfs:comment : This property identifies former or current instances of E30 Rights held by an E39 Actor.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P75_possesses">crm:P75_possesses</a>
    /// </summary>
    let P75_possesses = _prefixId.prefix "P75_possesses"
    /// <summary>
    ///   <para>rdfs:label : κατέχεται απόrdfs:label : принадлежитrdfs:label : sind im Besitz vonrdfs:label : est détenu parrdfs:label : is possessed byrdfs:label : são detidos por</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P75i_is_possessed_by">crm:P75i_is_possessed_by</a>
    /// </summary>
    let P75i_is_possessed_by = _prefixId.prefix "P75i_is_possessed_by"
    /// <summary>
    ///   <para>rdfs:label : έχει σημείο επικοινωνίαςrdfs:label : has contact pointrdfs:label : a pour coordonnées individuellesrdfs:label : hat Kontaktpunktrdfs:label : имеет контактrdfs:label : possui ponto de contato</para>
    ///   <para>rdfs:comment : This property identifies an E51 Contact Point of any type that provides access to an E39 Actor by any communication method, such as e-mail or fax.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P76_has_contact_point">crm:P76_has_contact_point</a>
    /// </summary>
    let P76_has_contact_point = _prefixId.prefix "P76_has_contact_point"
    /// <summary>
    ///   <para>rdfs:label : permettent de contacterrdfs:label : bietet Zugang zurdfs:label : provides access tordfs:label : παρέχει πρόσβαση σεrdfs:label : предоставляет доступ кrdfs:label : é ponto de contado de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P76i_provides_access_to">crm:P76i_provides_access_to</a>
    /// </summary>
    let P76i_provides_access_to = _prefixId.prefix "P76i_provides_access_to"
    /// <summary>
    ///   <para>rdfs:label : αναγνωρίζεται ωςrdfs:label : est identifiée parrdfs:label : é identificado por rdfs:label : wird bezeichnet alsrdfs:label : is identified byrdfs:label : идентифицируется посредством</para>
    ///   <para>rdfs:comment : This property identifies an E52 Time-Span using an E49Time Appellation.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P78_is_identified_by">crm:P78_is_identified_by</a>
    /// </summary>
    let P78_is_identified_by = _prefixId.prefix "P78_is_identified_by"
    /// <summary>
    ///   <para>rdfs:label : είναι αναγνωριστικόrdfs:label : идентифицируетrdfs:label : bezeichnetrdfs:label : identifiesrdfs:label : identificardfs:label : identifie</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P78i_identifies">crm:P78i_identifies</a>
    /// </summary>
    let P78i_identifies = _prefixId.prefix "P78i_identifies"
    /// <summary>
    ///   <para>rdfs:label : beginning is qualified byrdfs:label : início é qualificado porrdfs:label : начало ограниченоrdfs:label : début est qualifié parrdfs:label : αρχή προσδιορίζεται απόrdfs:label : hat Anfangsbegründung</para>
    ///   <para>rdfs:comment : This property qualifies the beginning of an E52 Time-Span in some way.
    /// The nature of the qualification may be certainty, precision, source etc.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P79_beginning_is_qualified_by">crm:P79_beginning_is_qualified_by</a>
    /// </summary>
    let P79_beginning_is_qualified_by = _prefixId.prefix "P79_beginning_is_qualified_by"
    /// <summary>
    ///   <para>rdfs:label : fand statt inrdfs:label : совершался наrdfs:label : a eu lieu dansrdfs:label : ocorreu emrdfs:label : έλαβε χώρα σεrdfs:label : took place at</para>
    ///   <para>rdfs:comment : This property describes the spatial location of an instance of E4 Period.
    /// The related E53 Place should be seen as an approximation of the geographical area within which the phenomena that characterise the period in question occurred. P7took place at (witnessed) does not convey any meaning other than spatial positioning (generally on the surface of the earth).  For example, the period “R?volution fran?aise” can be said to have taken place in “France”, the “Victorian” period, may be said to have taken place in “Britain” and its colonies, as well as other parts of Europe and north America.
    /// A period can take place at multiple locations.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P7_took_place_at">crm:P7_took_place_at</a>
    /// </summary>
    let P7_took_place_at = _prefixId.prefix "P7_took_place_at"
    /// <summary>
    ///   <para>rdfs:label : a été témoin derdfs:label : witnessedrdfs:label : bezeugterdfs:label : был местом совершенияrdfs:label : υπήρξε τόπος τουrdfs:label : testemunhou</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P7i_witnessed">crm:P7i_witnessed</a>
    /// </summary>
    let P7i_witnessed = _prefixId.prefix "P7i_witnessed"
    /// <summary>
    ///   <para>rdfs:label : hat Begründung des Endesrdfs:label : final é qualificado porrdfs:label : fin est qualifiée parrdfs:label : конец ограниченrdfs:label : end is qualified byrdfs:label : τέλος προσδιορίζεται από</para>
    ///   <para>rdfs:comment : This property qualifies the end of an E52 Time-Span in some way.
    /// The nature of the qualification may be certainty, precision, source etc.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P80_end_is_qualified_by">crm:P80_end_is_qualified_by</a>
    /// </summary>
    let P80_end_is_qualified_by = _prefixId.prefix "P80_end_is_qualified_by"
    /// <summary>
    ///   <para>rdfs:label : abrange no mínimordfs:label : ongoing throughoutrdfs:label : καθόλη τη διάρκεια του/τηςrdfs:label : длится в течениеrdfs:label : andauernd währendrdfs:label : couvre au moins</para>
    ///   <para>rdfs:comment : This property describes the minimum period of time covered by an E52 Time-Span.
    /// Since Time-Spans may not have precisely known temporal extents, the CRM supports statements about the minimum and maximum temporal extents of Time-Spans. This property allows a Time-Span’s minimum temporal extent (i.e. its inner boundary) to be assigned an E61 Time Primitive value. Time Primitives are treated by the CRM as application or system specific date intervals, and are not further analysed.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P81_ongoing_throughout">crm:P81_ongoing_throughout</a>
    /// </summary>
    let P81_ongoing_throughout = _prefixId.prefix "P81_ongoing_throughout"
    /// <summary>
    ///   <para>rdfs:label : irgendwann innerhalb vonrdfs:label : at some time withinrdfs:label : couvre au plusrdfs:label : некоторое время в течениеrdfs:label : abrange no máximordfs:label : κάποτε εντός</para>
    ///   <para>rdfs:comment : This property describes the maximum period of time within which an E52 Time-Span falls.
    /// Since Time-Spans may not have precisely known temporal extents, the CRM supports statements about the minimum and maximum temporal extents of Time-Spans. This property allows a Time-Span’s maximum temporal extent (i.e. its outer boundary) to be assigned an E61 Time Primitive value. Time Primitives are treated by the CRM as application or system specific date intervals, and are not further analysed.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P82_at_some_time_within">crm:P82_at_some_time_within</a>
    /// </summary>
    let P82_at_some_time_within = _prefixId.prefix "P82_at_some_time_within"
    /// <summary>
    ///   <para>rdfs:label : durou no mínimordfs:label : hatte Mindestdauerrdfs:label : a duré au moinsrdfs:label : είχε ελάχιστη διάρκειαrdfs:label : имеет длительность по крайней мере больше чемrdfs:label : had at least duration</para>
    ///   <para>rdfs:comment : This property describes the minimum length of time covered by an E52 Time-Span.
    /// It allows an E52 Time-Span to be associated with an E54 Dimension representing it’s minimum duration (i.e. it’s inner boundary) independent from the actual beginning and end.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P83_had_at_least_duration">crm:P83_had_at_least_duration</a>
    /// </summary>
    let P83_had_at_least_duration = _prefixId.prefix "P83_had_at_least_duration"
    /// <summary>
    ///   <para>rdfs:label : είναι ελάχιστη διάρκεια του/τηςrdfs:label : a été la durée minimum derdfs:label : был минимальной длительностью дляrdfs:label : was minimum duration ofrdfs:label : war Mindestdauer vonrdfs:label : foi a duração mínima de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P83i_was_minimum_duration_of">crm:P83i_was_minimum_duration_of</a>
    /// </summary>
    let P83i_was_minimum_duration_of = _prefixId.prefix "P83i_was_minimum_duration_of"
    /// <summary>
    ///   <para>rdfs:label : hatte Höchstdauerrdfs:label : had at most durationrdfs:label : είχε μέγιστη διάρκειαrdfs:label : имеет длительность меньше чемrdfs:label : durou no máximordfs:label : a duré au plus</para>
    ///   <para>rdfs:comment : This property describes the maximum length of time covered by an E52 Time-Span.
    /// It allows an E52 Time-Span to be associated with an E54 Dimension representing it’s maximum duration (i.e. it’s outer boundary) independent from the actual beginning and end.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P84_had_at_most_duration">crm:P84_had_at_most_duration</a>
    /// </summary>
    let P84_had_at_most_duration = _prefixId.prefix "P84_had_at_most_duration"
    /// <summary>
    ///   <para>rdfs:label : был максимальной длительностью дляrdfs:label : war längste Dauer vonrdfs:label : was maximum duration ofrdfs:label : είναι μέγιστη διάρκεια του/τηςrdfs:label : a été la durée maximum derdfs:label : foi a duração máxima de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P84i_was_maximum_duration_of">crm:P84i_was_maximum_duration_of</a>
    /// </summary>
    let P84i_was_maximum_duration_of = _prefixId.prefix "P84i_was_maximum_duration_of"
    /// <summary>
    ///   <para>rdfs:label : s’insère dansrdfs:label : falls withinrdfs:label : está contido emrdfs:label : περιέχεται σεrdfs:label : fällt inrdfs:label : содержится в</para>
    ///   <para>rdfs:comment : This property describes the inclusion relationship between two instances of E52 Time-Span.
    /// This property supports the notion that a Time-Span’s temporal extent falls within the temporal extent of another Time-Span. It addresses temporal containment only, and no contextual link between the two instances of Time-Span is implied.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P86_falls_within">crm:P86_falls_within</a>
    /// </summary>
    let P86_falls_within = _prefixId.prefix "P86_falls_within"
    /// <summary>
    ///   <para>rdfs:label : inclutrdfs:label : enthältrdfs:label : containsrdfs:label : περιέχειrdfs:label : содержитrdfs:label : contém</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P86i_contains">crm:P86i_contains</a>
    /// </summary>
    let P86i_contains = _prefixId.prefix "P86i_contains"
    /// <summary>
    ///   <para>rdfs:label : идентифицируется посредствомrdfs:label : αναγνωρίζεται ωςrdfs:label : é identificado porrdfs:label : est identifié parrdfs:label : is identified byrdfs:label : wird bezeichnet als</para>
    ///   <para>rdfs:comment : This property identifies an E53 Place using an E44 Place Appellation.
    /// Examples of Place Appellations used to identify Places include instances of E48 Place Name, addresses, E47 Spatial Coordinates etc.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P87_is_identified_by">crm:P87_is_identified_by</a>
    /// </summary>
    let P87_is_identified_by = _prefixId.prefix "P87_is_identified_by"
    /// <summary>
    ///   <para>rdfs:label : идентифицируетrdfs:label : bezeichnetrdfs:label : identifiesrdfs:label : identificardfs:label : identifierdfs:label : είναι αναγνωριστικό</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P87i_identifies">crm:P87i_identifies</a>
    /// </summary>
    let P87i_identifies = _prefixId.prefix "P87i_identifies"
    /// <summary>
    ///   <para>rdfs:comment : This property identifies an E53 Place that forms part of another Place.
    /// It supports the notion that a Place can be subdivided into one or more constituent parts. It implies both spatial and contextual containment relationships between the two Places.
    /// </para>
    ///   <para>rdfs:label : besteht ausrdfs:label : αποτελείται απόrdfs:label : consists ofrdfs:label : est enrdfs:label : сделан изrdfs:label : consiste de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P88_consists_of">crm:P88_consists_of</a>
    /// </summary>
    let P88_consists_of = _prefixId.prefix "P88_consists_of"
    /// <summary>
    ///   <para>rdfs:label : fait partie derdfs:label : формирует частьrdfs:label : forms part ofrdfs:label : bildet Teil vonrdfs:label : είναι τμήμα τουrdfs:label : faz parte de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P88i_forms_part_of">crm:P88i_forms_part_of</a>
    /// </summary>
    let P88i_forms_part_of = _prefixId.prefix "P88i_forms_part_of"
    /// <summary>
    ///   <para>rdfs:label : περιέχεται σεrdfs:label : está contido emrdfs:label : содержится вrdfs:label : fällt inrdfs:label : falls withinrdfs:label : s’insère dans</para>
    ///   <para>rdfs:comment : This property identifies the instances of E53 Places that fall within the area covered by another Place.
    /// It addresses spatial containment only, and no ‘whole-part’ relationship between the two places is implied.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P89_falls_within">crm:P89_falls_within</a>
    /// </summary>
    let P89_falls_within = _prefixId.prefix "P89_falls_within"
    /// <summary>
    ///   <para>rdfs:label : inclutrdfs:label : содержитrdfs:label : περιέχειrdfs:label : enthältrdfs:label : containsrdfs:label : contém</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P89i_contains">crm:P89i_contains</a>
    /// </summary>
    let P89i_contains = _prefixId.prefix "P89i_contains"
    /// <summary>
    ///   <para>rdfs:label : took place on or withinrdfs:label : a eu lieu sur ou dansrdfs:label : fand statt auf oder innerhalb von rdfs:label : ocorreu em ou dentrordfs:label : имел место на или вrdfs:label : έλαβε χώρα σε ή εντός</para>
    ///   <para>rdfs:comment : This property describes the location of an instance of E4 Period with respect to an E19 Physical Object.
    /// P8 took place on or within (witnessed) is a short-cut of a path defining a E53 Place with respect to the geometry of an object. cf. E46 Section Definition.
    /// This property is in effect a special case of P7 took place at. It describes a period that can be located with respect to the space defined by an E19 Physical Object such as a ship or a building. The precise geographical location of the object during the period in question may be unknown or unimportant.
    /// For example, the French and German armistice of 22 June 1940 was signed in the same railway carriage as the armistice of 11 November 1918.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P8_took_place_on_or_within">crm:P8_took_place_on_or_within</a>
    /// </summary>
    let P8_took_place_on_or_within = _prefixId.prefix "P8_took_place_on_or_within"
    /// <summary>
    ///   <para>rdfs:label : являлся местом дляrdfs:label : bezeugterdfs:label : witnessedrdfs:label : a été témoin derdfs:label : υπήρξε τόπος τουrdfs:label : testemunhou</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P8i_witnessed">crm:P8i_witnessed</a>
    /// </summary>
    let P8i_witnessed = _prefixId.prefix "P8i_witnessed"
    /// <summary>
    ///   <para>rdfs:comment : This property allows an E54 Dimension to be approximated by an E60 Number primitive.</para>
    ///   <para>rdfs:label : a la valeurrdfs:label : имеет значениеrdfs:label : hat Wertrdfs:label : tem valorrdfs:label : has valuerdfs:label : έχει τιμή</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P90_has_value">crm:P90_has_value</a>
    /// </summary>
    let P90_has_value = _prefixId.prefix "P90_has_value"
    /// <summary>
    ///   <para>rdfs:label : имеет единицуrdfs:label : hat Einheitrdfs:label : έχει μονάδα μέτρησηςrdfs:label : tem unidaderdfs:label : has unitrdfs:label : a pour unité</para>
    ///   <para>rdfs:comment : This property shows the type of unit an E54 Dimension was expressed in.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P91_has_unit">crm:P91_has_unit</a>
    /// </summary>
    let P91_has_unit = _prefixId.prefix "P91_has_unit"
    /// <summary>
    ///   <para>rdfs:label : является единицей дляrdfs:label : est l'unité derdfs:label : ist Einheit vonrdfs:label : αποτελεί μονάδα μέτρησης του/τηςrdfs:label : is unit ofrdfs:label : é unidade de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P91i_is_unit_of">crm:P91i_is_unit_of</a>
    /// </summary>
    let P91i_is_unit_of = _prefixId.prefix "P91i_is_unit_of"
    /// <summary>
    ///   <para>rdfs:label : a fait existerrdfs:label : brachte in Existenzrdfs:label : trouxe à existênciardfs:label : создалrdfs:label : brought into existencerdfs:label : γέννησε</para>
    ///   <para>rdfs:comment : This property allows an E63 Beginning of Existence event to be linked to the E77 Persistent Item brought into existence by it.
    /// It allows a “start” to be attached to any Persistent Item being documented i.e. E70 Thing, E72 Legal Object, E39 Actor, E41 Appellation, E51 Contact Point and E55 Type</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P92_brought_into_existence">crm:P92_brought_into_existence</a>
    /// </summary>
    let P92_brought_into_existence = _prefixId.prefix "P92_brought_into_existence"

    /// <summary>
    ///   <para>rdfs:label : was brought into existence byrdfs:label : γεννήθηκε απόrdfs:label : a commencé à exister du fait derdfs:label : был создан посредствомrdfs:label : passou a existir porrdfs:label : wurde in Existenz gebracht durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P92i_was_brought_into_existence_by">crm:P92i_was_brought_into_existence_by</a>
    /// </summary>
    let P92i_was_brought_into_existence_by =
        _prefixId.prefix "P92i_was_brought_into_existence_by"

    /// <summary>
    ///   <para>rdfs:comment : This property allows an E64 End of Existence event to be linked to the E77 Persistent Item taken out of existence by it.
    /// In the case of immaterial things, the E64 End of Existence is considered to take place with the destruction of the last physical carrier.
    /// This allows an “end” to be attached to any Persistent Item being documented i.e. E70 Thing, E72 Legal Object, E39 Actor, E41 Appellation, E51 Contact Point and E55 Type. For many Persistent Items we know the maximum life-span and can infer, that they must have ended to exist. We assume in that case an End of Existence, which may be as unnoticeable as forgetting the secret knowledge by the last representative of some indigenous nation.
    /// </para>
    ///   <para>rdfs:label : a fait cesser d’existerrdfs:label : cessou a existência derdfs:label : положил конец существованиюrdfs:label : took out of existencerdfs:label : beendete die Existenz vonrdfs:label : αναίρεσε</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P93_took_out_of_existence">crm:P93_took_out_of_existence</a>
    /// </summary>
    let P93_took_out_of_existence = _prefixId.prefix "P93_took_out_of_existence"

    /// <summary>
    ///   <para>rdfs:label : прекратил существование посредствомrdfs:label : a cessé d’exister du fait derdfs:label : was taken out of existence byrdfs:label : αναιρέθηκε απόrdfs:label : deixou de existirrdfs:label : wurde seiner Existenz beraubt durch</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P93i_was_taken_out_of_existence_by">crm:P93i_was_taken_out_of_existence_by</a>
    /// </summary>
    let P93i_was_taken_out_of_existence_by =
        _prefixId.prefix "P93i_was_taken_out_of_existence_by"

    /// <summary>
    ///   <para>rdfs:label : criourdfs:label : has createdrdfs:label : a créérdfs:label : hat erschaffenrdfs:label : создалrdfs:label : δημιούργησε</para>
    ///   <para>rdfs:comment : This property allows a conceptual E65 Creation to be linked to the E28 Conceptual Object created by it.
    /// It represents the act of conceiving the intellectual content of the E28 Conceptual Object. It does not represent the act of creating the first physical carrier of the E28 Conceptual Object. As an example, this is the composition of a poem, not its commitment to paper.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P94_has_created">crm:P94_has_created</a>
    /// </summary>
    let P94_has_created = _prefixId.prefix "P94_has_created"
    /// <summary>
    ///   <para>rdfs:label : foi criado porrdfs:label : wurde erschaffen durchrdfs:label : δημιουργήθηκε απόrdfs:label : a été créé parrdfs:label : was created byrdfs:label : был создан посредством</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P94i_was_created_by">crm:P94i_was_created_by</a>
    /// </summary>
    let P94i_was_created_by = _prefixId.prefix "P94i_was_created_by"
    /// <summary>
    ///   <para>rdfs:label : a fondérdfs:label : formourdfs:label : has formedrdfs:label : сформировалrdfs:label : σχημάτισεrdfs:label : hat gebildet</para>
    ///   <para>rdfs:comment : This property links the founding or E66 Formation for an E74 Group with the Group itself.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P95_has_formed">crm:P95_has_formed</a>
    /// </summary>
    let P95_has_formed = _prefixId.prefix "P95_has_formed"
    /// <summary>
    ///   <para>rdfs:label : was formed byrdfs:label : a été fondé parrdfs:label : foi formado porrdfs:label : σχηματίστηκε απόrdfs:label : была сформирована посредствомrdfs:label : wurde gebildet von</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P95i_was_formed_by">crm:P95i_was_formed_by</a>
    /// </summary>
    let P95i_was_formed_by = _prefixId.prefix "P95i_was_formed_by"
    /// <summary>
    ///   <para>rdfs:label : de mèrerdfs:label : είχε μητέραrdfs:label : посредством материrdfs:label : pela mãerdfs:label : durch Mutterrdfs:label : by mother</para>
    ///   <para>rdfs:comment : This property links an E67 Birth event to an E21 Person as a participant in the role of birth-giving mother.
    ///
    /// Note that biological fathers are not necessarily participants in the Birth (see P97 from father (was father for)). The Person being born is linked to the Birth with the property P98 brought into life (was born). This is not intended for use with general natural history material, only people. There is no explicit method for modelling conception and gestation except by using extensions. This is a sub-property of P11 had participant (participated in).
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P96_by_mother">crm:P96_by_mother</a>
    /// </summary>
    let P96_by_mother = _prefixId.prefix "P96_by_mother"
    /// <summary>
    ///   <para>rdfs:label : gave birthrdfs:label : a donné naissance àrdfs:label : дал рождениеrdfs:label : gebarrdfs:label : ήταν μητέρα του/τηςrdfs:label : deu nascimento</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P96i_gave_birth">crm:P96i_gave_birth</a>
    /// </summary>
    let P96i_gave_birth = _prefixId.prefix "P96i_gave_birth"
    /// <summary>
    ///   <para>rdfs:label : είχε πατέραrdfs:label : gab Vaterschaftrdfs:label : от отцаrdfs:label : from fatherrdfs:label : de pèrerdfs:label : pelo pai</para>
    ///   <para>rdfs:comment : This property links an E67 Birth event to an E21 Person in the role of biological father.
    /// Note that biological fathers are not seen as necessary participants in the Birth, whereas birth-giving mothers are (see P96 by mother (gave birth)). The Person being born is linked to the Birth with the property P98 brought into life (was born).
    /// This is not intended for use with general natural history material, only people. There is no explicit method for modelling conception and gestation except by using extensions.
    /// A Birth event is normally (but not always) associated with one biological father.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P97_from_father">crm:P97_from_father</a>
    /// </summary>
    let P97_from_father = _prefixId.prefix "P97_from_father"
    /// <summary>
    ///   <para>rdfs:label : was father forrdfs:label : ήταν πατέρας του/τηςrdfs:label : a été père dansrdfs:label : war Vater fürrdfs:label : был отцом дляrdfs:label : foi pai para</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P97i_was_father_for">crm:P97i_was_father_for</a>
    /// </summary>
    let P97i_was_father_for = _prefixId.prefix "P97i_was_father_for"
    /// <summary>
    ///   <para>rdfs:label : brachte zur Weltrdfs:label : a donné vie àrdfs:label : породилrdfs:label : έφερε στη ζωήrdfs:label : brought into liferdfs:label : trouxe à vida</para>
    ///   <para>rdfs:comment : This property links an E67Birth event to an E21 Person in the role of offspring.
    /// Twins, triplets etc. are brought into life by the same Birth event. This is not intended for use with general Natural History material, only people. There is no explicit method for modelling conception and gestation except by using extensions.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P98_brought_into_life">crm:P98_brought_into_life</a>
    /// </summary>
    let P98_brought_into_life = _prefixId.prefix "P98_brought_into_life"
    /// <summary>
    ///   <para>rdfs:label : был рожденrdfs:label : was bornrdfs:label : wurde geboren durchrdfs:label : veio à vida pelordfs:label : est nérdfs:label : γεννήθηκε</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P98i_was_born">crm:P98i_was_born</a>
    /// </summary>
    let P98i_was_born = _prefixId.prefix "P98i_was_born"
    /// <summary>
    ///   <para>rdfs:label : löste aufrdfs:label : dissolvedrdfs:label : распустилrdfs:label : διέλυσεrdfs:label : a dissousrdfs:label : dissolveu</para>
    ///   <para>rdfs:comment : This property links the disbanding or E68 Dissolution of an E74 Group to the Group itself.</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P99_dissolved">crm:P99_dissolved</a>
    /// </summary>
    let P99_dissolved = _prefixId.prefix "P99_dissolved"
    /// <summary>
    ///   <para>rdfs:label : foi dissolvido porrdfs:label : a été dissous parrdfs:label : wurde aufgelöst durchrdfs:label : был распущен посредствомrdfs:label : was dissolved byrdfs:label : διαλύθηκε από</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P99i_was_dissolved_by">crm:P99i_was_dissolved_by</a>
    /// </summary>
    let P99i_was_dissolved_by = _prefixId.prefix "P99i_was_dissolved_by"
    /// <summary>
    ///   <para>rdfs:label : setzt sich zusammen ausrdfs:label : consiste derdfs:label : αποτελείται απόrdfs:label : consists ofrdfs:label : состоит изrdfs:label : consiste en</para>
    ///   <para>rdfs:comment : This property describes the decomposition of an instance of E4 Period into discrete, subsidiary periods.
    /// The sub-periods into which the period is decomposed form a logical whole - although the entire picture may not be completely known - and the sub-periods are constitutive of the general period.
    /// </para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P9_consists_of">crm:P9_consists_of</a>
    /// </summary>
    let P9_consists_of = _prefixId.prefix "P9_consists_of"
    /// <summary>
    ///   <para>rdfs:label : αποτελεί μέρος του/τηςrdfs:label : формирует частьrdfs:label : bildet Teil vonrdfs:label : fait partie derdfs:label : forms part ofrdfs:label : faz parte de</para>
    ///   <a href="http://www.cidoc-crm.org/cidoc-crm/P9i_forms_part_of">crm:P9i_forms_part_of</a>
    /// </summary>
    let P9i_forms_part_of = _prefixId.prefix "P9i_forms_part_of"
