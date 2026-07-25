namespace http.www.cidoc_crm.org.cidoc_crm.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cidoc =
    let _namespace_iri = Namespace_Iri cidoc |> NamespaceIRI
    /// <summary>
    ///   <para>cidoc:E11_Modification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all instances of E7 Activity that create, alter or change E24 Physical Man-Made Thing.
    /// This class includes the production of an item from raw materials, and other so far undocumented objects, and the preventive treatment or restoration of an object for conservation.
    /// Since the distinction between modification and production is not always clear, modification is regarded as the more generally applicable concept. This implies that some items may be consumed or destroyed in a Modification, and that others may be produced as a result of it. An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the originals. In this case, the new items have separate identities.
    /// If the instance of the E29 Design or Procedure utilized for the modification prescribes the use of specific materials, they should be documented using property P68 foresees use of (use foreseen by): E57 Material of E29 Design or Procedure, rather than via P126 employed (was employed in): E57 Material.
    /// </para>
    /// labels<para>Событие Изменения</para><para>Modification</para><para>Modification</para><para>Τροποποίηση</para><para>Modificação</para><para>Bearbeitung</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E11_Modification">http://www.cidoc-crm.org/cidoc-crm/E11_Modification</seealso>
    let E11_Modification = Prefixed_Name(cidoc, "E11_Modification") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E19_Physical_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises items of a material nature that are units for documentation and have physical boundaries that separate them completely in an objective way from other objects.
    /// The class also includes all aggregates of objects made for functional purposes of whatever kind, independent of physical coherence, such as a set of chessmen. Typically, instances of E19 Physical Object can be moved (if not too heavy).
    /// In some contexts, such objects, except for aggregates, are also called “bona fide objects” (Smith &amp; Varzi, 2000, pp.401-420), i.e. naturally defined objects.
    /// The decision as to what is documented as a complete item, rather than by its parts or components, may be a purely administrative decision or may be a result of the order in which the item was acquired.
    /// </para>
    /// labels<para>Materieller Gegenstand</para><para>Υλικό Αντικείμενο</para><para>Физический Объект</para><para>Physical Object</para><para>Objeto Material</para><para>Objet matériel</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E19_Physical_Object">http://www.cidoc-crm.org/cidoc-crm/E19_Physical_Object</seealso>
    let E19_Physical_Object =
        Prefixed_Name(cidoc, "E19_Physical_Object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E21_Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises real persons who live or are assumed to have lived.
    /// Legendary figures that may have existed, such as Ulysses and King Arthur, fall into this class if the documentation refers to them as historical figures. In cases where doubt exists as to whether several persons are in fact identical, multiple instances can be created and linked to indicate their relationship. The CRM does not propose a specific form to support reasoning about possible identity.
    /// </para>
    /// labels<para>Личность</para><para>Personne</para><para>Πρόσωπο</para><para>Pessoa</para><para>Person</para><para>Person</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E21_Person">http://www.cidoc-crm.org/cidoc-crm/E21_Person</seealso>
    let E21_Person = Prefixed_Name(cidoc, "E21_Person") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E39_Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises people, either individually or in groups, who have the potential to perform intentional actions for which they can be held responsible.
    /// The CRM does not attempt to model the inadvertent actions of such actors. Individual people should be documented as instances of E21 Person, whereas groups should be documented as instances of either E74 Group or its subclass E40 Legal Body.
    /// </para>
    /// labels<para>Δράστης</para><para>Akteur</para><para>Agente</para><para>Agent</para><para>Агент</para><para>Actor</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E39_Actor">http://www.cidoc-crm.org/cidoc-crm/E39_Actor</seealso>
    let E39_Actor = Prefixed_Name(cidoc, "E39_Actor") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E22_Man-Made_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises physical objects purposely created by human activity.
    /// No assumptions are made as to the extent of modification required to justify regarding an object as man-made. For example, an inscribed piece of rock or a preserved butterfly are both regarded as instances of E22 Man-Made Object.
    /// </para>
    /// labels<para>Ανθρωπογενές Αντικείμενο</para><para>Künstlicher Gegenstand</para><para>Рукотворный Объект</para><para>Objeto Fabricado</para><para>Man-Made Object</para><para>Objet fabriqué</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E22_Man-Made_Object">http://www.cidoc-crm.org/cidoc-crm/E22_Man-Made_Object</seealso>
    let E22_Man_Made_Object =
        Prefixed_Name(cidoc, "E22_Man-Made_Object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E52_Time-Span</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises abstract temporal extents, in the sense of Galilean physics, having a beginning, an end and a duration.
    /// Time Span has no other semantic connotations. Time-Spans are used to define the temporal extent of instances of E4 Period, E5 Event and any other phenomena valid for a certain time. An E52 Time-Span may be identified by one or more instances of E49 Time Appellation.
    /// Since our knowledge of history is imperfect, instances of E52 Time-Span can best be considered as approximations of the actual Time-Spans of temporal entities. The properties of E52 Time-Span are intended to allow these approximations to be expressed precisely.  An extreme case of approximation, might, for example, define an E52 Time-Span having unknown beginning, end and duration. Used as a common E52 Time-Span for two events, it would nevertheless define them as being simultaneous, even if nothing else was known.
    /// 	Automatic processing and querying of instances of E52 Time-Span is facilitated if data can be parsed into an E61 Time Primitive.
    /// </para>
    /// labels<para>Χρονικό Διάστημα</para><para>Período de Tempo</para><para>Интервал Времени</para><para>Zeitspanne</para><para>Time-Span</para><para>Durée</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E52_Time-Span">http://www.cidoc-crm.org/cidoc-crm/E52_Time-Span</seealso>
    let E52_Time_Span = Prefixed_Name(cidoc, "E52_Time-Span") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P16i_was_used_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>χρησιμοποιήθηκε για</para><para>был использован для</para><para>a été utilisé pour</para><para>wurde benutzt für</para><para>foi usado por</para><para>was used for</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P16i_was_used_for">http://www.cidoc-crm.org/cidoc-crm/P16i_was_used_for</seealso>
    let P16i_was_used_for = Prefixed_Name(cidoc, "P16i_was_used_for") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P12i_was_present_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ήταν παρών/παρούσα/παρόν σε</para><para>estava presente no</para><para>присутствовал при</para><para>war anwesend bei</para><para>était présent à</para><para>was present at</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P12i_was_present_at">http://www.cidoc-crm.org/cidoc-crm/P12i_was_present_at</seealso>
    let P12i_was_present_at =
        Prefixed_Name(cidoc, "P12i_was_present_at") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P112_diminished</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E24 Physical Man-Made Thing that was diminished by E80 Part Removal.
    /// Although a Part removal activity normally concerns only one item of Physical Man-Made Thing, it is possible to imagine circumstances under which more than one item might be diminished by a single Part Removal activity.
    /// </para>
    /// labels<para>verminderte</para><para>diminished</para><para>a diminué</para><para>уменьшил</para><para>εξάλειψε</para><para>diminuiu</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P112_diminished">http://www.cidoc-crm.org/cidoc-crm/P112_diminished</seealso>
    let P112_diminished = Prefixed_Name(cidoc, "P112_diminished") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P38i_was_deassigned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>foi retirada a atribuição por</para><para>был отменен посредством</para><para>wurde aufgehoben durch</para><para>a été désattribué par</para><para>was deassigned by</para><para>ακυρώθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P38i_was_deassigned_by">http://www.cidoc-crm.org/cidoc-crm/P38i_was_deassigned_by</seealso>
    let P38i_was_deassigned_by =
        Prefixed_Name(cidoc, "P38i_was_deassigned_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E7_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises actions intentionally carried out by instances of E39 Actor that result in changes of state in the cultural, social, or physical systems documented.
    /// This notion includes complex, composite and long-lasting actions such as the building of a settlement or a war, as well as simple, short-lived actions such as the opening of a door.
    /// </para>
    /// labels<para>Деятельность</para><para>Atividade</para><para>Handlung</para><para>Activity</para><para>Activité</para><para>Δράση</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E7_Activity">http://www.cidoc-crm.org/cidoc-crm/E7_Activity</seealso>
    let E7_Activity = Prefixed_Name(cidoc, "E7_Activity") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E63_Beginning_of_Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises events that bring into existence any E77 Persistent Item.
    /// It may be used for temporal reasoning about things (intellectual products, physical items, groups of people, living beings) beginning to exist; it serves as a hook for determination of a terminus post quem and ante quem. </para>
    /// labels<para>Beginning of Existence</para><para>Начало Существования</para><para>Início da Existência</para><para>Début d'existence</para><para>Daseinsbeginn</para><para>Αρχή Ύπαρξης</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E63_Beginning_of_Existence">http://www.cidoc-crm.org/cidoc-crm/E63_Beginning_of_Existence</seealso>
    let E63_Beginning_of_Existence =
        Prefixed_Name(cidoc, "E63_Beginning_of_Existence") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P11i_participated_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>participated in</para><para>συμμετείχε σε</para><para>a participé à</para><para>nahm Teil an</para><para>участвовал в</para><para>participa em</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P11i_participated_in">http://www.cidoc-crm.org/cidoc-crm/P11i_participated_in</seealso>
    let P11i_participated_in =
        Prefixed_Name(cidoc, "P11i_participated_in") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P40i_was_observed_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a été relevée au cours de</para><para>foi verificada durante</para><para>wurde beobachtet in</para><para>παρατηρήθηκε από</para><para>was observed in</para><para>наблюдался в</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P40i_was_observed_in">http://www.cidoc-crm.org/cidoc-crm/P40i_was_observed_in</seealso>
    let P40i_was_observed_in =
        Prefixed_Name(cidoc, "P40i_was_observed_in") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E12_Production</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises activities that are designed to, and succeed in, creating one or more new items.
    /// It specializes the notion of modification into production. The decision as to whether or not an object is regarded as new is context sensitive. Normally, items are considered “new” if there is no obvious overall similarity between them and the consumed items and material used in their production. In other cases, an item is considered “new” because it becomes relevant to documentation by a modification. For example, the scribbling of a name on a potsherd may make it a voting token. The original potsherd may not be worth documenting, in contrast to the inscribed one.
    /// This entity can be collective: the printing of a thousand books, for example, would normally be considered a single event.
    /// An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the originals. In this case, the new items have separate identities and matter is preserved, but identity is not.
    /// </para>
    /// labels<para>Событие Производства</para><para>Herstellung</para><para>Production</para><para>Production</para><para>Produção</para><para>Παραγωγή</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E12_Production">http://www.cidoc-crm.org/cidoc-crm/E12_Production</seealso>
    let E12_Production = Prefixed_Name(cidoc, "E12_Production") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E13_Attribute_Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the actions of making assertions about properties of an object or any relation between two items or concepts.
    /// This class allows the documentation of how the respective assignment came about, and whose opinion it was. All the attributes or properties assigned in such an action can also be seen as directly attached to the respective item or concept, possibly as a collection of contradictory values. All cases of properties in this model that are also described indirectly through an action are characterised as "short cuts" of this action. This redundant modelling of two alternative views is preferred because many implementations may have good reasons to model either the action or the short cut, and the relation between both alternatives can be captured by simple rules.
    /// In particular, the class describes the actions of people making propositions and statements during certain museum procedures, e.g. the person and date when a condition statement was made, an identifier was assigned, the museum object was measured, etc. Which kinds of such assignments and statements need to be documented explicitly in structures of a schema rather than free text, depends on if this information should be accessible by structured queries.
    /// </para>
    /// labels<para>Atribuição de Característica</para><para>Affectation d'attribut</para><para>Attribute Assignment</para><para>Присвоение Атрибута</para><para>Merkmalszuweisung</para><para>Απόδοση Ιδιοτήτων</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E13_Attribute_Assignment">http://www.cidoc-crm.org/cidoc-crm/E13_Attribute_Assignment</seealso>
    let E13_Attribute_Assignment =
        Prefixed_Name(cidoc, "E13_Attribute_Assignment") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E14_Condition_Assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class describes the act of assessing the state of preservation of an object during a particular period.
    /// The condition assessment may be carried out by inspection, measurement or through historical research. This class is used to document circumstances of the respective assessment that may be relevant to interpret its quality at a later stage, or to continue research on related documents.
    /// </para>
    /// labels<para>Avaliação do Estado Material</para><para>Expertise de l'état matériel</para><para>Condition Assessment</para><para>Zustandsfeststellung</para><para>Εκτίμηση Κατάστασης</para><para>Оценка Состояния</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E14_Condition_Assessment">http://www.cidoc-crm.org/cidoc-crm/E14_Condition_Assessment</seealso>
    let E14_Condition_Assessment =
        Prefixed_Name(cidoc, "E14_Condition_Assessment") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E16_Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises actions measuring physical properties and other values that can be determined by a systematic procedure.
    /// Examples include measuring the monetary value of a collection of coins or the running time of a specific video cassette.
    /// The E16 Measurement may use simple counting or tools, such as yardsticks or radiation detection devices. The interest is in the method and care applied, so that the reliability of the result may be judged at a later stage, or research continued on the associated documents. The date of the event is important for dimensions, which may change value over time, such as the length of an object subject to shrinkage. Details of methods and devices are best handled as free text, whereas basic techniques such as "carbon 14 dating" should be encoded using P2 has type (is type of:) E55 Type.
    /// </para>
    /// labels<para>Событие Измерения</para><para>Measurement</para><para>Mesurage</para><para>Messung</para><para>Μέτρηση</para><para>Medição</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E16_Measurement">http://www.cidoc-crm.org/cidoc-crm/E16_Measurement</seealso>
    let E16_Measurement = Prefixed_Name(cidoc, "E16_Measurement") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E17_Type_Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the actions of classifying items of whatever kind. Such items include objects, specimens, people, actions and concepts.
    /// This class allows for the documentation of the context of classification acts in cases where the value of the classification depends on the personal opinion of the classifier, and the date that the classification was made. This class also encompasses the notion of "determination," i.e. the systematic and molecular identification of a specimen in biology.
    /// </para>
    /// labels<para>Attribution de type</para><para>Atribuição de Tipo</para><para>Type Assignment</para><para>Присвоение Типа</para><para>Typuszuweisung</para><para>Απόδοση Τύπου</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E17_Type_Assignment">http://www.cidoc-crm.org/cidoc-crm/E17_Type_Assignment</seealso>
    let E17_Type_Assignment =
        Prefixed_Name(cidoc, "E17_Type_Assignment") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E18_Physical_Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all persistent physical items with a relatively stable form, man-made or natural.
    /// Depending on the existence of natural boundaries of such things, the CRM distinguishes the instances of E19 Physical Object from instances of E26 Physical Feature, such as holes, rivers, pieces of land etc. Most instances of E19 Physical Object can be moved (if not too heavy), whereas features are integral to the surrounding matter.
    /// The CRM is generally not concerned with amounts of matter in fluid or gaseous states.
    /// </para>
    /// labels<para>Chose matérielle</para><para>Физическая Вещь</para><para>Coisa Material</para><para>Physical Thing</para><para>Υλικό Πράγμα</para><para>Materielles</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E18_Physical_Thing">http://www.cidoc-crm.org/cidoc-crm/E18_Physical_Thing</seealso>
    let E18_Physical_Thing = Prefixed_Name(cidoc, "E18_Physical_Thing") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E55_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises concepts denoted by terms from thesauri and controlled vocabularies used to characterize and classify instances of CRM classes. Instances of E55 Type represent concepts  in contrast to instances of E41 Appellation which are used to name instances of CRM classes.
    /// E55 Type is the CRM’s interface to domain specific ontologies and thesauri. These can be represented in the CRM as subclasses of E55 Type, forming hierarchies of terms, i.e. instances of E55 Type linked via P127 has broader  term (has narrower term). Such hierarchies may be extended with additional properties.
    /// </para>
    /// labels<para>Τύπος</para><para>Typus</para><para>Type</para><para>Type</para><para>Tipo</para><para>Тип</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E55_Type">http://www.cidoc-crm.org/cidoc-crm/E55_Type</seealso>
    let E55_Type = Prefixed_Name(cidoc, "E55_Type") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E57_Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class is a specialization of E55 Type and comprises the concepts of materials.
    /// Instances of E57 Material may denote properties of matter before its use, during its use, and as incorporated in an object, such as ultramarine powder, tempera paste, reinforced concrete. Discrete pieces of raw-materials kept in museums, such as bricks, sheets of fabric, pieces of metal, should be modelled individually in the same way as other objects. Discrete used or processed pieces, such as the stones from Nefer Titi's temple, should be modelled as parts (cf. P46 is composed of).
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E57 Material, e.g.: “instances of  gold”.
    /// It is recommended that internationally or nationally agreed codes and terminology are used.</para>
    /// labels<para>Material</para><para>Material</para><para>Material</para><para>Matériau</para><para>Материал</para><para>Υλικό</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E57_Material">http://www.cidoc-crm.org/cidoc-crm/E57_Material</seealso>
    let E57_Material = Prefixed_Name(cidoc, "E57_Material") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E58_Measurement_Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class is a specialization of E55 Type and comprises the types of measurement units: feet, inches, centimetres, litres, lumens, etc.
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E58 Measurement Unit, e.g.: “instances of cm”.
    /// Syst?me International (SI) units or internationally recognized non-SI terms should be used whenever possible. (ISO 1000:1992). Archaic Measurement Units used in historical records should be preserved.
    /// </para>
    /// labels<para>Unidade de Medida</para><para>Единица Измерения</para><para>Measurement Unit</para><para>Μονάδα Μέτρησης</para><para>Unité de mesure</para><para>Maßeinheit</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E58_Measurement_Unit">http://www.cidoc-crm.org/cidoc-crm/E58_Measurement_Unit</seealso>
    let E58_Measurement_Unit =
        Prefixed_Name(cidoc, "E58_Measurement_Unit") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E5_Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises changes of states in cultural, social or physical systems, regardless of scale, brought about by a series or group of coherent physical, cultural, technological or legal phenomena. Such changes of state will affect instances of E77 Persistent Item or its subclasses.
    /// The distinction between an E5 Event and an E4 Period is partly a question of the scale of observation. Viewed at a coarse level of detail, an E5 Event is an ‘instantaneous’ change of state. At a fine level, the E5 Event can be analysed into its component phenomena within a space and time frame, and as such can be seen as an E4 Period. The reverse is not necessarily the case: not all instances of E4 Period give rise to a noteworthy change of state.
    /// </para>
    /// labels<para>Événement</para><para>Ereignis</para><para>Событие</para><para>Συμβάν</para><para>Evento</para><para>Event</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E5_Event">http://www.cidoc-crm.org/cidoc-crm/E5_Event</seealso>
    let E5_Event = Prefixed_Name(cidoc, "E5_Event") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E64_End_of_Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises events that end the existence of any E77 Persistent Item.
    /// It may be used for temporal reasoning about things (physical items, groups of people, living beings) ceasing to exist; it serves as a hook for determination of a terminus postquem and antequem. In cases where substance from a Persistent Item continues to exist in a new form, the process would be documented by E81 Transformation.
    /// </para>
    /// labels<para>Конец Существования</para><para>Fim da Existência</para><para>End of Existence</para><para>Fin d'existence</para><para>Τέλος Ύπαρξης</para><para>Daseinsende</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E64_End_of_Existence">http://www.cidoc-crm.org/cidoc-crm/E64_End_of_Existence</seealso>
    let E64_End_of_Existence =
        Prefixed_Name(cidoc, "E64_End_of_Existence") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E65_Creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises events that result in the creation of conceptual items or immaterial products, such as legends, poems, texts, music, images, movies, laws, types etc.
    /// </para>
    /// labels<para>Begriffliche Schöpfung</para><para>Событие Творения</para><para>Δημιουργία</para><para>Creation</para><para>Création</para><para>Criação</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E65_Creation">http://www.cidoc-crm.org/cidoc-crm/E65_Creation</seealso>
    let E65_Creation = Prefixed_Name(cidoc, "E65_Creation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P125_used_object_of_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the kind of objects used in an E7 Activity, when the specific instance is either unknown or not of interest, such as use of "a hammer".
    /// </para>
    /// labels<para>χρησιμοποίησε αντικείμενο τύπου</para><para>a employé un objet du type</para><para>benutzte Objekt des Typus</para><para>использовал объект типа</para><para>usou objeto do tipo</para><para>used object of type</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P125_used_object_of_type">http://www.cidoc-crm.org/cidoc-crm/P125_used_object_of_type</seealso>
    let P125_used_object_of_type =
        Prefixed_Name(cidoc, "P125_used_object_of_type") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E15_Identifier_Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises activities that result in the allocation of an identifier to an instance of E1 CRM Entity. An E15 Identifier Assignment may include the creation of the identifier from multiple constituents, which themselves may be instances of E41 Appellation. The syntax and kinds of constituents to be used may be declared in a rule constituting an instance of E29 Design or Procedure.
    /// Examples of such identifiers include Find Numbers, Inventory Numbers, uniform titles in the sense of librarianship and Digital Object Identifiers (DOI). Documenting the act of identifier assignment and deassignment is especially useful when objects change custody or the identification system of an organization is changed. In order to keep track of the identity of things in such cases, it is important to document by whom, when and for what purpose an identifier is assigned to an item.
    /// The fact that an identifier is a preferred one for an organisation can be expressed by using the property E1 CRM Entity. P48 has preferred identifier (is preferred identifier of): E42 Identifier. It can better be expressed in a context independent form by assigning a suitable E55 Type, such as “preferred identifier assignment”, to the respective instance of E15 Identifier Assignment via the P2 has type property.
    /// </para>
    /// labels<para>Attribution d’identificateur</para><para>Atribuição de Identificador</para><para>Назначение Идентификатора</para><para>Απόδοση Αναγνωριστικού</para><para>Identifier Assignment</para><para>Kennzeichenzuweisung</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E15_Identifier_Assignment">http://www.cidoc-crm.org/cidoc-crm/E15_Identifier_Assignment</seealso>
    let E15_Identifier_Assignment =
        Prefixed_Name(cidoc, "E15_Identifier_Assignment") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E81_Transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the events that result in the simultaneous destruction of one or more than one E77 Persistent Item and the creation of one or more than one E77 Persistent Item that preserves recognizable substance from the first one(s) but has fundamentally different nature and identity.
    /// Although the old and the new instances of E77 Persistent Item are treated as discrete entities having separate, unique identities, they are causally connected through the E81 Transformation; the destruction of the old E77 Persistent Item(s) directly causes the creation of the new one(s) using or preserving some relevant substance. Instances of E81 Transformation are therefore distinct from re-classifications (documented using E17 Type Assignment) or modifications (documented using E11 Modification) of objects that do not fundamentally change their nature or identity. Characteristic cases are reconstructions and repurposing of historical buildings or ruins, fires leaving buildings in ruins, taxidermy of specimen in natural history and the reorganization of a corporate body into a new one.
    /// </para>
    /// labels<para>Transformation</para><para>Transformation</para><para>Transformação</para><para>Трансформация</para><para>Umwandlung</para><para>Μετατροπή</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E81_Transformation">http://www.cidoc-crm.org/cidoc-crm/E81_Transformation</seealso>
    let E81_Transformation = Prefixed_Name(cidoc, "E81_Transformation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E82_Actor_Appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises any sort of name, number, code or symbol characteristically used to identify an E39 Actor.
    /// An E39 Actor will typically have more than one E82 Actor Appellation, and instances of E82 Actor Appellation in turn may have alternative representations. The distinction between corporate and personal names, which is particularly important in library applications, should be made by explicitly linking the E82 Actor Appellation to an instance of either E21 Person or E74 Group/E40 Legal Body. If this is not possible, the distinction can be made through the use of the P2 has type mechanism.
    /// </para>
    /// labels<para>Designação de Agente</para><para>Appellation d'agent</para><para>Обозначение Агента</para><para>Actor Appellation</para><para>Akteurbenennung</para><para>Ονομασία Δράστη</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E82_Actor_Appellation">http://www.cidoc-crm.org/cidoc-crm/E82_Actor_Appellation</seealso>
    let E82_Actor_Appellation =
        Prefixed_Name(cidoc, "E82_Actor_Appellation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E84_Information_Carrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all instances of E22 Man-Made Object that are explicitly designed to act as persistent physical carriers for instances of E73 Information Object.
    /// This allows a relationship to be asserted between an E19 Physical Object and its immaterial information contents. An E84 Information Carrier may or may not contain information, e.g., a diskette. Note that any E18 Physical Thing may carry information, such as an E34 Inscription. However, unless it was specifically designed for this purpose, it is not an Information Carrier. Therefore the property P128 carries (is carried by) applies to E18 Physical Thing in general.</para>
    /// labels<para>Support d'information</para><para>Suporte de Informação</para><para>Information Carrier</para><para>Носитель Информации</para><para>Informationsträger</para><para>Φορέας Πληροφορίας</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E84_Information_Carrier">http://www.cidoc-crm.org/cidoc-crm/E84_Information_Carrier</seealso>
    let E84_Information_Carrier =
        Prefixed_Name(cidoc, "E84_Information_Carrier") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E86_Leaving</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the activities that result in an instance of E39 Actor to be disassociated from an instance of E74 Group. This class does not imply initiative by either party.
    /// Typical scenarios include the termination of membership in a social organisation, ending the employment at a company, divorce, and the end of tenure of somebody in an official position.</para>
    /// labels<para>Austritt</para><para>Leaving</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E86_Leaving">http://www.cidoc-crm.org/cidoc-crm/E86_Leaving</seealso>
    let E86_Leaving = Prefixed_Name(cidoc, "E86_Leaving") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E8_Acquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises transfers of legal ownership from one or more instances of E39 Actor to one or more other instances of E39 Actor.
    /// The class also applies to the establishment or loss of ownership of instances of E18 Physical Thing. It does not, however, imply changes of any other kinds of right. The recording of the donor and/or recipient is optional. It is possible that in an instance of E8 Acquisition there is either no donor or no recipient. Depending on the circumstances, it may describe:
    /// 1.	the beginning of ownership
    /// 2.	the end of ownership
    /// 3.	the transfer of ownership
    /// 4.	the acquisition from an unknown source
    /// 5.	the loss of title due to destruction of the item
    /// It may also describe events where a collector appropriates legal title, for example by annexation or field collection. The interpretation of the museum notion of "accession" differs between institutions. The CRM therefore models legal ownership (E8 Acquisition) and physical custody (E10 Transfer of Custody) separately. Institutions will then model their specific notions of accession and deaccession as combinations of these.
    /// </para>
    /// labels<para>Событие Приобретения</para><para>Acquisition</para><para>Acquisition</para><para>Aquisição</para><para>Απόκτηση</para><para>Erwerb</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E8_Acquisition">http://www.cidoc-crm.org/cidoc-crm/E8_Acquisition</seealso>
    let E8_Acquisition = Prefixed_Name(cidoc, "E8_Acquisition") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P100_was_death_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property property links an E69 Death event to the E21 Person that died.</para>
    /// labels<para>ήταν θάνατος του/της</para><para>foi a morte para </para><para>a été la mort de</para><para>был смертью для</para><para>was death of</para><para>Tod von</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P100_was_death_of">http://www.cidoc-crm.org/cidoc-crm/P100_was_death_of</seealso>
    let P100_was_death_of = Prefixed_Name(cidoc, "P100_was_death_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P93_took_out_of_existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an E64 End of Existence event to be linked to the E77 Persistent Item taken out of existence by it.
    /// In the case of immaterial things, the E64 End of Existence is considered to take place with the destruction of the last physical carrier.
    /// This allows an “end” to be attached to any Persistent Item being documented i.e. E70 Thing, E72 Legal Object, E39 Actor, E41 Appellation, E51 Contact Point and E55 Type. For many Persistent Items we know the maximum life-span and can infer, that they must have ended to exist. We assume in that case an End of Existence, which may be as unnoticeable as forgetting the secret knowledge by the last representative of some indigenous nation.
    /// </para>
    /// labels<para>положил конец существованию</para><para>beendete die Existenz von</para><para>a fait cesser d’exister</para><para>cessou a existência de</para><para>took out of existence</para><para>αναίρεσε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P93_took_out_of_existence">http://www.cidoc-crm.org/cidoc-crm/P93_took_out_of_existence</seealso>
    let P93_took_out_of_existence =
        Prefixed_Name(cidoc, "P93_took_out_of_existence") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P100i_died_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P100i_died_in">http://www.cidoc-crm.org/cidoc-crm/P100i_died_in</seealso>
    let P100i_died_in = Prefixed_Name(cidoc, "P100i_died_in") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P101i_was_use_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>était l’utilisation de</para><para>war die Verwendung von</para><para>был применением для</para><para>ήταν χρήση του/της</para><para>was use of</para><para>foi uso de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P101i_was_use_of">http://www.cidoc-crm.org/cidoc-crm/P101i_was_use_of</seealso>
    let P101i_was_use_of = Prefixed_Name(cidoc, "P101i_was_use_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P20_had_specific_purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the relationship between a preparatory activity and the event it is intended to be preparation for.
    /// This includes activities, orders and other organisational actions, taken in preparation for other activities or events.
    /// P20 had specific purpose (was purpose of) implies that an activity succeeded in achieving its aim. If it does not succeed, such as the setting of a trap that did not catch anything, one may document the unrealized intention using P21 had general purpose (was purpose of):E55 Type and/or  P33 used specific technique (was used by): E29 Design or Procedure.</para>
    /// labels<para>hatte den bestimmten Zweck</para><para>tinha propósito específico</para><para>avait pour but spécifique</para><para>είχε συγκεκριμένο σκοπό</para><para>had specific purpose</para><para>имел конкретную цель</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P20_had_specific_purpose">http://www.cidoc-crm.org/cidoc-crm/P20_had_specific_purpose</seealso>
    let P20_had_specific_purpose =
        Prefixed_Name(cidoc, "P20_had_specific_purpose") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P21_had_general_purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes an intentional relationship between an E7 Activity and some general goal or purpose.
    /// This may involve activities intended as preparation for some type of activity or event. P21had general purpose (was purpose of) differs from P20 had specific purpose (was purpose of) in that no occurrence of an event is implied as the purpose.
    /// </para>
    /// labels<para>hatte den allgemeinen Zweck</para><para>avait pour but général</para><para>tinha propósito geral</para><para>had general purpose</para><para>είχε γενικό σκοπό</para><para>имел общую цель</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P21_had_general_purpose">http://www.cidoc-crm.org/cidoc-crm/P21_had_general_purpose</seealso>
    let P21_had_general_purpose =
        Prefixed_Name(cidoc, "P21_had_general_purpose") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P80_end_is_qualified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property qualifies the end of an E52 Time-Span in some way.
    /// The nature of the qualification may be certainty, precision, source etc.
    /// </para>
    /// labels<para>τέλος προσδιορίζεται από</para><para>hat Begründung des Endes</para><para>final é qualificado por</para><para>fin est qualifiée par</para><para>end is qualified by</para><para>конец ограничен</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P80_end_is_qualified_by">http://www.cidoc-crm.org/cidoc-crm/P80_end_is_qualified_by</seealso>
    let P80_end_is_qualified_by =
        Prefixed_Name(cidoc, "P80_end_is_qualified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P81_ongoing_throughout</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the minimum period of time covered by an E52 Time-Span.
    /// Since Time-Spans may not have precisely known temporal extents, the CRM supports statements about the minimum and maximum temporal extents of Time-Spans. This property allows a Time-Span’s minimum temporal extent (i.e. its inner boundary) to be assigned an E61 Time Primitive value. Time Primitives are treated by the CRM as application or system specific date intervals, and are not further analysed.
    /// </para>
    /// labels<para>καθόλη τη διάρκεια του/της</para><para>ongoing throughout</para><para>abrange no mínimo</para><para>andauernd während</para><para>длится в течение</para><para>couvre au moins</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P81_ongoing_throughout">http://www.cidoc-crm.org/cidoc-crm/P81_ongoing_throughout</seealso>
    let P81_ongoing_throughout =
        Prefixed_Name(cidoc, "P81_ongoing_throughout") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E73_Information_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises identifiable immaterial items, such as a poems, jokes, data sets, images, texts, multimedia objects, procedural prescriptions, computer program code, algorithm or mathematical formulae, that have an objectively recognizable structure and are documented as single units.
    /// An E73 Information Object does not depend on a specific physical carrier, which can include human memory, and it can exist on one or more carriers simultaneously.
    /// Instances of E73 Information Object of a linguistic nature should be declared as instances of the E33 Linguistic Object subclass. Instances of E73 Information Object of a documentary nature should be declared as instances of the E31 Document subclass. Conceptual items such as types and classes are not instances of E73 Information Object, nor are ideas without a reproducible expression.
    /// </para>
    /// labels<para>Πληροφοριακό Αντικείμενο</para><para>Informationsgegenstand</para><para>Информационный Объект</para><para>Objeto de Informação</para><para>Objet d'information</para><para>Information Object</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E73_Information_Object">http://www.cidoc-crm.org/cidoc-crm/E73_Information_Object</seealso>
    let E73_Information_Object =
        Prefixed_Name(cidoc, "E73_Information_Object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E32_Authority_Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises encyclopaedia, thesauri, authority lists and other documents that define terminology or conceptual systems for consistent use.
    /// </para>
    /// labels<para>Documento de Referência</para><para>Πηγή Καθιερωμένων Όρων</para><para>Document de référence</para><para>Официальный Документ</para><para>Authority Document</para><para>Referenzdokument</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E32_Authority_Document">http://www.cidoc-crm.org/cidoc-crm/E32_Authority_Document</seealso>
    let E32_Authority_Document =
        Prefixed_Name(cidoc, "E32_Authority_Document") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P141_assigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property indicates the attribute that was assigned or the item that was related to the item denoted by a property P140 assigned attribute to in an Attribute assignment action.
    /// </para>
    /// labels<para>a attribué</para><para>присвоил</para><para>atribuiu</para><para>assigned</para><para>wies zu</para><para>απέδωσε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P141_assigned">http://www.cidoc-crm.org/cidoc-crm/P141_assigned</seealso>
    let P141_assigned = Prefixed_Name(cidoc, "P141_assigned") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P59_has_section</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links an area to the instance of E18 Physical Thing upon which it is found.
    /// It is typically used when a named E46 Section Definition is not appropriate.
    /// E18 Physical Thing may be subdivided into arbitrary regions.
    /// P59 has section (is located on or within) is a shortcut. If the E53 Place is identified by a Section Definition, a more detailed representation can make use of the fully developed (i.e. indirect) path from E18 Physical Thing through P58 has section definition (defines section), E46 Section Definition, P87 is identified by (identifies) to E53 Place. A Place can only be located on or within one Physical Object.
    /// </para>
    /// labels<para>a pour section</para><para>hat Bereich</para><para>имеет район</para><para>has section</para><para>έχει τομέα</para><para>tem seção</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P59_has_section">http://www.cidoc-crm.org/cidoc-crm/P59_has_section</seealso>
    let P59_has_section = Prefixed_Name(cidoc, "P59_has_section") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E28_Conceptual_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises non-material products of our minds and other human produced data that 		have become objects of a discourse about their identity, circumstances of creation or historical 		implication. The production of such information may have been supported by the use of    		technical devices such as cameras or computers.
    /// Characteristically, instances of this class are created, invented or thought by someone, and then may be documented or communicated between persons. Instances of E28 Conceptual Object have the ability to exist on more than one particular carrier at the same time, such as paper, electronic signals, marks, audio media, paintings, photos, human memories, etc.
    /// They cannot be destroyed. They exist as long as they can be found on at least one carrier or in at least one human memory. Their existence ends when the last carrier and the last memory are lost.
    /// </para>
    /// labels<para>Begrifflicher Gegenstand</para><para>Концептуальный Объект</para><para>Νοητικό Αντικείμενο</para><para>Objeto Conceitual</para><para>Conceptual Object</para><para>Objet conceptuel</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E28_Conceptual_Object">http://www.cidoc-crm.org/cidoc-crm/E28_Conceptual_Object</seealso>
    let E28_Conceptual_Object =
        Prefixed_Name(cidoc, "E28_Conceptual_Object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E2_Temporal_Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all phenomena, such as the instances of E4 Periods, E5 Events and states, which happen over a limited extent in time.
    /// 	In some contexts, these are also called perdurants. This class is disjoint from E77 Persistent Item. This is an abstract class and has no direct instances. E2 Temporal Entity is specialized into E4 Period, which applies to a particular geographic area (defined with a greater or lesser degree of precision), and E3 Condition State, which applies to instances of E18 Physical Thing.
    /// </para>
    /// labels<para>Временная Сущность</para><para>Έγχρονη  Οντότητα</para><para>Entidade Temporal</para><para>Entité temporelle</para><para>Temporal Entity</para><para>Geschehendes</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E2_Temporal_Entity">http://www.cidoc-crm.org/cidoc-crm/E2_Temporal_Entity</seealso>
    let E2_Temporal_Entity = Prefixed_Name(cidoc, "E2_Temporal_Entity") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E79_Part_Addition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises activities that result in an instance of E24 Physical Man-Made Thing being increased, enlarged or augmented by the addition of a part.
    /// Typical scenarios include the attachment of an accessory, the integration of a component, the addition of an element to an aggregate object, or the accessioning of an object into a curated E78 Collection. Objects to which parts are added are, by definition, man-made, since the addition of a part implies a human activity. Following the addition of parts, the resulting man-made assemblages are treated objectively as single identifiable wholes, made up of constituent or component parts bound together either physically (for example the engine becoming a part of the car), or by sharing a common purpose (such as the 32 chess pieces that make up a chess set). This class of activities forms a basis for reasoning about the history and continuity of identity of objects that are integrated into other objects over time, such as precious gemstones being repeatedly incorporated into different items of jewellery, or cultural artifacts being added to different museum instances of E78 Collection over their lifespan.
    /// </para>
    /// labels<para>Addition d'élément</para><para>Добавление Части</para><para>Adição de Parte</para><para>Teilhinzufügung</para><para>Προσθήκη Μερών</para><para>Part Addition</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E79_Part_Addition">http://www.cidoc-crm.org/cidoc-crm/E79_Part_Addition</seealso>
    let E79_Part_Addition = Prefixed_Name(cidoc, "E79_Part_Addition") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P137_exemplifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an item to be declared as a particular example of an E55 Type or taxon
    /// 	The P137.1 in the taxonomic role property of P137 exemplifies (is exemplified by) allows differentiation of taxonomic roles. The taxonomic role renders the specific relationship of this example to the Type, such as "prototypical", "archetypical", "lectotype", etc. The taxonomic role "lectotype" is not associated with the Type Creation (E83) itself, but selected in a later phase.
    /// </para>
    /// labels<para>é exemplificado por</para><para>δειγματίζει</para><para>exemplifies</para><para>exemplifie</para><para>erläutert</para><para>поясняет</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P137_exemplifies">http://www.cidoc-crm.org/cidoc-crm/P137_exemplifies</seealso>
    let P137_exemplifies = Prefixed_Name(cidoc, "P137_exemplifies") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P14_carried_out_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the active participation of an E39 Actor in an E7 Activity.
    /// It implies causal or legal responsibility. The P14.1 in the role of property of the property allows the nature of an Actor’s participation to be specified.
    /// </para>
    /// labels<para>πραγματοποιήθηκε από</para><para>wurde ausgeführt von</para><para>carried out by</para><para>realizada por</para><para>réalisée par</para><para>выполнялся</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P14_carried_out_by">http://www.cidoc-crm.org/cidoc-crm/P14_carried_out_by</seealso>
    let P14_carried_out_by = Prefixed_Name(cidoc, "P14_carried_out_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P69_is_associated_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This symmetric property describes the association of an E29 Design or Procedure with other Designs or Procedures.
    /// Any instance of E29 Design or Procedure may be associated with other designs or procedures. The P69.1 has type property of P69 is associated with allows the nature of the association to be specified; examples of types of association between instances of E29 Design or Procedure include: whole-part, sequence, prerequisite, etc.
    /// </para>
    /// labels<para>is associated with</para><para>ist verbunden mit</para><para>é associado com</para><para>est associée à</para><para>ассоциирован с</para><para>σχετίζεται με</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P69_is_associated_with">http://www.cidoc-crm.org/cidoc-crm/P69_is_associated_with</seealso>
    let P69_is_associated_with =
        Prefixed_Name(cidoc, "P69_is_associated_with") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E72_Legal_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises those material or immaterial items to which instances of E30 Right, such as the right of ownership or use, can be applied.
    /// This is true for all E18 Physical Thing. In the case of instances of E28 Conceptual Object, however, the identity of the E28 Conceptual Object or the method of its use may be too ambiguous to reliably establish instances of E30 Right, as in the case of taxa and inspirations. Ownership of corporations is currently regarded as out of scope of the CRM.
    /// </para>
    /// labels<para>Νομικό Αντικείμενο</para><para>Objet juridique</para><para>Objeto Jurídico</para><para>Legal Object</para><para>Объект Права</para><para>Rechtsobjekt</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E72_Legal_Object">http://www.cidoc-crm.org/cidoc-crm/E72_Legal_Object</seealso>
    let E72_Legal_Object = Prefixed_Name(cidoc, "E72_Legal_Object") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E40_Legal_Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises institutions or groups of people that have obtained a legal recognition as a group and can act collectively as agents.
    /// This means that they can perform actions, own property, create or destroy things and can be held collectively responsible for their actions like individual people. The term 'personne morale' is often used for this in French.
    /// </para>
    /// labels<para>Juristische Person</para><para>Юридическое Лицо</para><para>Pessoa Jurídica</para><para>Νομικό Πρόσωπο</para><para>Collectivité</para><para>Legal Body</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E40_Legal_Body">http://www.cidoc-crm.org/cidoc-crm/E40_Legal_Body</seealso>
    let E40_Legal_Body = Prefixed_Name(cidoc, "E40_Legal_Body") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E90_Symbolic_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises identifiable symbols and any aggregation of symbols, such as characters, identifiers, traffic signs, emblems, texts, data sets, images, musical scores, multimedia objects, computer program code or mathematical formulae that have an objectively recognizable structure and that are documented as single units.
    /// It includes sets of signs of any nature, which may serve to designate something, or to communicate some propositional content.
    /// An instance of E90 Symbolic Object does not depend on a specific physical carrier, which can include human memory, and it can exist on one or more carriers simultaneously. An instance of E90 Symbolic Object may or may not have a specific meaning, for example an arbitrary character string.
    /// </para>
    /// labels<para>Symbolisches Objekt</para><para>Symbolic Object</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E90_Symbolic_Object">http://www.cidoc-crm.org/cidoc-crm/E90_Symbolic_Object</seealso>
    let E90_Symbolic_Object =
        Prefixed_Name(cidoc, "E90_Symbolic_Object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E45_Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises identifiers expressed in coding systems for places, such as postal addresses used for mailing.
    /// An E45 Address can be considered both as the name of an E53 Place and as an E51 Contact Point for an E39 Actor. This dual aspect is reflected in the multiple inheritance. However, some forms of mailing addresses, such as a postal box, are only instances of E51 Contact Point, since they do not identify any particular Place. These should not be documented as instances of E45 Address.
    /// </para>
    /// labels<para>Διεύθυνση</para><para>Endereço</para><para>Adresse</para><para>Adresse</para><para>Address</para><para>Адрес</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E45_Address">http://www.cidoc-crm.org/cidoc-crm/E45_Address</seealso>
    let E45_Address = Prefixed_Name(cidoc, "E45_Address") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E51_Contact_Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises identifiers employed, or understood, by communication services to direct communications to an instance of E39 Actor. These include E-mail addresses, telephone numbers, post office boxes, Fax numbers, URLs etc. Most postal addresses can be considered both as instances of E44 Place Appellation and E51 Contact Point. In such cases the subclass E45 Address should be used.
    /// URLs are addresses used by machines to access another machine through an http request. Since the accessed machine acts on behalf of the E39 Actor providing the machine, URLs are considered as instances of E51 Contact Point to that E39 Actor.
    /// </para>
    /// labels<para>Coordonnées individuelles</para><para>Στοιχείο Επικοινωνίας</para><para>Ponto de Contato</para><para>Contact Point</para><para>Kontaktpunkt</para><para>Контакт</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E51_Contact_Point">http://www.cidoc-crm.org/cidoc-crm/E51_Contact_Point</seealso>
    let E51_Contact_Point = Prefixed_Name(cidoc, "E51_Contact_Point") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E46_Section_Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises areas of objects referred to in terms specific to the general geometry or structure of its kind.
    /// The 'prow' of the boat, the 'frame' of the picture, the 'front' of the building are all instances of E46 Section Definition. The class highlights the fact that parts of objects can be treated as locations. This holds in particular for features without natural boundaries, such as the “head” of a marble statue made out of one block (cf. E53 Place). In answer to the question 'where is the signature?' one might reply 'on the lower left corner'. (Section Definition is closely related to the term “segment” in Gerstl, P.&amp; Pribbenow, S, 1996 “ A conceptual theory of part – whole relations and its applications”, Data &amp; Knowledge 	Engineering 20 305-322, North Holland- Elsevier ).
    /// </para>
    /// labels<para>Désignation de section</para><para>Abschnittsdefinition</para><para>Designação de Seção</para><para>Section Definition</para><para>Определение Района</para><para>Ονομασία Τμήματος</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E46_Section_Definition">http://www.cidoc-crm.org/cidoc-crm/E46_Section_Definition</seealso>
    let E46_Section_Definition =
        Prefixed_Name(cidoc, "E46_Section_Definition") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E47_Spatial_Coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the textual or numeric information required to locate specific instances of E53 Place within schemes of spatial identification.
    ///
    /// Coordinates are a specific form of E44 Place Appellation, that is, a means of referring to a particular E53 Place. Coordinates are not restricted to longitude, latitude and altitude. Any regular system of reference that maps onto an E19 Physical Object can be used to generate coordinates.
    /// </para>
    /// labels<para>Пространственные Координаты</para><para>Coordenadas Espaciais</para><para>Coordonnées spatiales</para><para>Χωρικές Συντεταγμένες</para><para>Spatial Coordinates</para><para>Raumkoordinaten</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E47_Spatial_Coordinates">http://www.cidoc-crm.org/cidoc-crm/E47_Spatial_Coordinates</seealso>
    let E47_Spatial_Coordinates =
        Prefixed_Name(cidoc, "E47_Spatial_Coordinates") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E48_Place_Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises particular and common forms of E44 Place Appellation.
    /// Place Names may change their application over time: the name of an E53 Place may change, and a name may be reused for a different E53 Place. Instances of E48 Place Name are typically subject to place name gazetteers.</para>
    /// labels<para>Orts- oder Flurname</para><para>Название Места</para><para>Nome de Local</para><para>Place Name</para><para>Τοπωνύμιο</para><para>Toponyme</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E48_Place_Name">http://www.cidoc-crm.org/cidoc-crm/E48_Place_Name</seealso>
    let E48_Place_Name = Prefixed_Name(cidoc, "E48_Place_Name") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E49_Time_Appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all forms of names or codes, such as historical periods, and dates, which are characteristically used to refer to a specific E52 Time-Span.
    /// The instances of E49 Time Appellation may vary in their degree of precision, and they may be relative to other time frames, “Before Christ” for example. Instances of E52 Time-Span are often defined by reference to a cultural period or an event e.g. ‘the duration of the Ming Dynasty’.</para>
    /// labels<para>Appellation temporelle</para><para>Обозначение Времени</para><para>Designação de Tempo</para><para>Time Appellation</para><para>Ονομασία Χρόνου</para><para>Zeitbenennung</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E49_Time_Appellation">http://www.cidoc-crm.org/cidoc-crm/E49_Time_Appellation</seealso>
    let E49_Time_Appellation =
        Prefixed_Name(cidoc, "E49_Time_Appellation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E4_Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>	This class comprises sets of coherent phenomena or cultural manifestations bounded in time and space.
    /// It is the social or physical coherence of these phenomena that identify an E4 Period and not the associated spatio-temporal bounds. These bounds are a mere approximation of the actual process of growth, spread and retreat. Consequently, different periods can overlap and coexist in time and space, such as when a nomadic culture exists in the same area as a sedentary culture.
    /// Typically this class is used to describe prehistoric or historic periods such as the “Neolithic Period”, the “Ming Dynasty” or the “McCarthy Era”. There are however no assumptions about the scale of the associated phenomena. In particular all events are seen as synthetic processes consisting of coherent phenomena. Therefore E4 Period is a superclass of E5 Event. For example, a modern clinical E67 Birth can be seen as both an atomic E5 Event and as an E4 Period that consists of multiple activities performed by multiple instances of E39 Actor.
    /// There are two different conceptualisations of ‘artistic style’, defined either by physical features or by historical context. For example, “Impressionism” can be viewed as a period lasting from approximately 1870 to 1905 during which paintings with particular characteristics were produced by a group of artists that included (among others) Monet, Renoir, Pissarro, Sisley and Degas. Alternatively, it can be regarded as a style applicable to all paintings sharing the characteristics of the works produced by the Impressionist painters, regardless of historical context. The first interpretation is an E4 Period, and the second defines morphological object types that fall under E55 Type.
    /// Another specific case of an E4 Period is the set of activities and phenomena associated with a settlement, such as the populated period of Nineveh.
    /// </para>
    /// labels<para>Περίοδος</para><para>Período</para><para>Période</para><para>Период</para><para>Period</para><para>Phase</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E4_Period">http://www.cidoc-crm.org/cidoc-crm/E4_Period</seealso>
    let E4_Period = Prefixed_Name(cidoc, "E4_Period") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E50_Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises specific forms of E49 Time Appellation.</para>
    /// labels<para>Ημερομηνία</para><para>Datum</para><para>Дата</para><para>Data</para><para>Date</para><para>Date</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E50_Date">http://www.cidoc-crm.org/cidoc-crm/E50_Date</seealso>
    let E50_Date = Prefixed_Name(cidoc, "E50_Date") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P49i_is_former_or_current_keeper_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является бывшим или текущим смотрителем для</para><para>ist früherer oder derzeitiger Betreuer von</para><para>is former or current keeper of</para><para>est ou a été détenteur de</para><para>é ou foi guardador de</para><para>κατέχει ή κατείχε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P49i_is_former_or_current_keeper_of">http://www.cidoc-crm.org/cidoc-crm/P49i_is_former_or_current_keeper_of</seealso>
    let P49i_is_former_or_current_keeper_of =
        Prefixed_Name(cidoc, "P49i_is_former_or_current_keeper_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P10_falls_within</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes an instance of E4 Period, which falls within the E53 Place and E52 Time-Span of another.
    /// The difference with P9 consists of (forms part of) is subtle. Unlike P9 consists of (forms part of), P10 falls within (contains) does not imply any logical connection between the two periods and it may refer to a period of a completely different type.
    /// </para>
    /// labels<para>s’insère dans le cours de</para><para>находится в пределах</para><para>está contido em</para><para>falls within</para><para>εμπίπτει</para><para>fällt in</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P10_falls_within">http://www.cidoc-crm.org/cidoc-crm/P10_falls_within</seealso>
    let P10_falls_within = Prefixed_Name(cidoc, "P10_falls_within") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P110i_was_augmented_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был увеличен посредством</para><para>wurde erweitert durch</para><para>a été augmenté par</para><para>foi aumentada por</para><para>was augmented by</para><para>επαυξήθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P110i_was_augmented_by">http://www.cidoc-crm.org/cidoc-crm/P110i_was_augmented_by</seealso>
    let P110i_was_augmented_by =
        Prefixed_Name(cidoc, "P110i_was_augmented_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P30i_custody_transferred_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a changé de détenteur du fait de</para><para>custódia transferida por meio de</para><para>custody transferred through</para><para>wechselte Gewahrsam durch</para><para>опека передана через</para><para>άλλαξε κατοχή μέσω</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P30i_custody_transferred_through">http://www.cidoc-crm.org/cidoc-crm/P30i_custody_transferred_through</seealso>
    let P30i_custody_transferred_through =
        Prefixed_Name(cidoc, "P30i_custody_transferred_through") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P14i_performed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>πραγματοποίησε</para><para>führte aus</para><para>a exécuté</para><para>performed</para><para>executou</para><para>выполнял</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P14i_performed">http://www.cidoc-crm.org/cidoc-crm/P14i_performed</seealso>
    let P14i_performed = Prefixed_Name(cidoc, "P14i_performed") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P74_has_current_or_former_residence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the current or former E53 Place of residence of an E39 Actor.
    /// The residence may be either the Place where the Actor resides, or a legally registered address of any kind.
    /// </para>
    /// labels<para>имеет текущее или бывшее местожительства</para><para>hat derzeitigen oder früheren Sitz</para><para>has current or former residence</para><para>réside ou a résidé à</para><para>reside ou residiu em</para><para>έχει ή είχε κατοικία</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P74_has_current_or_former_residence">http://www.cidoc-crm.org/cidoc-crm/P74_has_current_or_former_residence</seealso>
    let P74_has_current_or_former_residence =
        Prefixed_Name(cidoc, "P74_has_current_or_former_residence") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E1_CRM_Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all things in the universe of discourse of the CIDOC Conceptual Reference Model.
    /// It is an abstract concept providing for three general properties:
    /// 1.	Identification by name or appellation, and in particular by a preferred identifier
    /// 2.	Classification by type, allowing further refinement of the specific subclass an instance belongs to
    /// 3.	Attachment of free text for the expression of anything not captured by formal properties
    /// With the exception of E59 Primitive Value, all other classes within the CRM are directly or indirectly specialisations of E1 CRM Entity.
    /// </para>
    /// labels<para>Οντότητα CIDOC CRM</para><para>CRM Сущность</para><para>Entidade CRM</para><para>CRM Entität</para><para>CRM Entity</para><para>Entité CRM</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E1_CRM_Entity">http://www.cidoc-crm.org/cidoc-crm/E1_CRM_Entity</seealso>
    let E1_CRM_Entity = Prefixed_Name(cidoc, "E1_CRM_Entity") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P8i_witnessed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>являлся местом для</para><para>υπήρξε τόπος του</para><para>a été témoin de</para><para>testemunhou</para><para>witnessed</para><para>bezeugte</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P8i_witnessed">http://www.cidoc-crm.org/cidoc-crm/P8i_witnessed</seealso>
    let P8i_witnessed = Prefixed_Name(cidoc, "P8i_witnessed") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E42_Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises strings or codes assigned to instances of E1 CRM Entity in order to identify them uniquely and permanently within the context of one or more organisations. Such codes are often known as inventory numbers, registration codes, etc. and are typically composed of alphanumeric sequences. The class E42 Identifier is not normally used for machine-generated identifiers used for automated processing unless these are also used by human agents.</para>
    /// labels<para>Identificador de Objeto</para><para>Identificateur d'objet</para><para>Идентификатор Объекта</para><para>Κωδικός Αναγνώρισης</para><para>Identifier</para><para>Kennung</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E42_Identifier">http://www.cidoc-crm.org/cidoc-crm/E42_Identifier</seealso>
    let E42_Identifier = Prefixed_Name(cidoc, "E42_Identifier") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E44_Place_Appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises any sort of identifier characteristically used to refer to an E53 Place.
    /// Instances of E44 Place Appellation may vary in their degree of precision and their meaning may vary over time - the same instance of E44 Place Appellation may be used to refer to several places, either because of cultural shifts, or because objects used as reference points have moved around. Instances of E44 Place Appellation can be extremely varied in form: postal addresses, instances of E47 Spatial Coordinate, and parts of buildings can all be considered as instances of E44 Place Appellation.
    /// </para>
    /// labels<para>Designação de Local</para><para>Appellation de lieu</para><para>Обозначение Места</para><para>Place Appellation</para><para>Ονομασία Τόπου</para><para>Ortsbenennung</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E44_Place_Appellation">http://www.cidoc-crm.org/cidoc-crm/E44_Place_Appellation</seealso>
    let E44_Place_Appellation =
        Prefixed_Name(cidoc, "E44_Place_Appellation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P90_has_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an E54 Dimension to be approximated by an E60 Number primitive.</para>
    /// labels<para>имеет значение</para><para>a la valeur</para><para>έχει τιμή</para><para>tem valor</para><para>has value</para><para>hat Wert</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P90_has_value">http://www.cidoc-crm.org/cidoc-crm/P90_has_value</seealso>
    let P90_has_value = Prefixed_Name(cidoc, "P90_has_value") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P91_has_unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property shows the type of unit an E54 Dimension was expressed in.</para>
    /// labels<para>έχει μονάδα μέτρησης</para><para>имеет единицу</para><para>a pour unité</para><para>hat Einheit</para><para>tem unidade</para><para>has unit</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P91_has_unit">http://www.cidoc-crm.org/cidoc-crm/P91_has_unit</seealso>
    let P91_has_unit = Prefixed_Name(cidoc, "P91_has_unit") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P106i_forms_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>αποτελεί μέρος του/της</para><para>bildet Teil von</para><para>формирует часть</para><para>fait partie de</para><para>forms part of</para><para>faz parte de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P106i_forms_part_of">http://www.cidoc-crm.org/cidoc-crm/P106i_forms_part_of</seealso>
    let P106i_forms_part_of =
        Prefixed_Name(cidoc, "P106i_forms_part_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E20_Biological_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises individual items of a material nature, which live, have lived or are natural products of or from living organisms.
    /// Artificial objects that incorporate biological elements, such as Victorian butterfly frames, can be documented as both instances of E20 Biological Object and E22 Man-Made Object.
    /// </para>
    /// labels<para>Biologischer Gegenstand</para><para>Βιολογικό Ακτικείμενο</para><para>Биологический Объект</para><para>Biological Object</para><para>Objet biologique</para><para>Objeto Biológico</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E20_Biological_Object">http://www.cidoc-crm.org/cidoc-crm/E20_Biological_Object</seealso>
    let E20_Biological_Object =
        Prefixed_Name(cidoc, "E20_Biological_Object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P29_custody_received_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor or Actors who receive custody of an instance of E18 Physical Thing in an E10 Transfer of Custody activity.
    /// The property will typically describe Actors receiving custody of an object when it is handed over from another Actor’s care. On occasion, physical custody may be received involuntarily or illegally – through accident, unsolicited donation, or theft.
    /// In reality, custody is either transferred to someone or from someone, or both.
    /// </para>
    /// labels<para>changement de détenteur au profit de</para><para>übertrug Gewahrsam auf</para><para>custódia recebida por</para><para>μετεβίβασε κατοχή σε</para><para>custody received by</para><para>опека получена</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P29_custody_received_by">http://www.cidoc-crm.org/cidoc-crm/P29_custody_received_by</seealso>
    let P29_custody_received_by =
        Prefixed_Name(cidoc, "P29_custody_received_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P108_has_produced</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E24 Physical Man-Made Thing that came into existence as a result of an E12 Production.
    /// The identity of an instance of E24 Physical Man-Made Thing is not defined by its matter, but by its existence as a subject of documentation. An E12 Production can result in the creation of multiple instances of E24 Physical Man-Made Thing.
    /// </para>
    /// labels<para>hat hergestellt</para><para>has produced</para><para>a produit</para><para>произвел</para><para>produziu</para><para>παρήγαγε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P108_has_produced">http://www.cidoc-crm.org/cidoc-crm/P108_has_produced</seealso>
    let P108_has_produced = Prefixed_Name(cidoc, "P108_has_produced") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P31i_was_modified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был изменен посредством</para><para>wurde verändert durch</para><para>foi modificada por</para><para>τροποποιήθηκε από</para><para>a été modifié par</para><para>was modified by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P31i_was_modified_by">http://www.cidoc-crm.org/cidoc-crm/P31i_was_modified_by</seealso>
    let P31i_was_modified_by =
        Prefixed_Name(cidoc, "P31i_was_modified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E53_Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises extents in space, in particular on the surface of the earth, in the pure sense of physics: independent from temporal phenomena and matter.
    /// The instances of E53 Place are usually determined by reference to the position of “immobile” objects such as buildings, cities, mountains, rivers, or dedicated geodetic marks. A Place can be determined by combining a frame of reference and a location with respect to this frame. It may be identified by one or more instances of E44 Place Appellation.
    ///  It is sometimes argued that instances of E53 Place are best identified by global coordinates or absolute reference systems. However, relative references are often more relevant in the context of cultural documentation and tend to be more precise. In particular, we are often interested in position in relation to large, mobile objects, such as ships. For example, the Place at which Nelson died is known with reference to a large mobile object – H.M.S Victory. A resolution of this Place in terms of absolute coordinates would require knowledge of the movements of the vessel and the precise time of death, either of which may be revised, and the result would lack historical and cultural relevance.
    /// Any object can serve as a frame of reference for E53 Place determination. The model foresees the notion of a "section" of an E19 Physical Object as a valid E53 Place determination.</para>
    /// labels<para>Τόπος</para><para>Local</para><para>Место</para><para>Place</para><para>Lieu</para><para>Ort</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E53_Place">http://www.cidoc-crm.org/cidoc-crm/E53_Place</seealso>
    let E53_Place = Prefixed_Name(cidoc, "E53_Place") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E54_Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises quantifiable properties that can be measured by some calibrated means and can be approximated by values, i.e. points or regions in a mathematical or conceptual space, such as natural or real numbers, RGB values etc.
    /// An instance of E54 Dimension represents the true quantity, independent from its numerical approximation, e.g. in inches or in cm. The properties of the class E54 Dimension allow for expressing the numerical approximation of the values of an instance of E54 Dimension. If the true values belong to a non-discrete space, such as spatial distances, it is recommended to record them as approximations by intervals or regions of indeterminacy enclosing the assumed true values. For instance, a length of 5 cm may be recorded as 4.5-5.5 cm, according to the precision of the respective observation. Note, that interoperability of values described in different units depends critically on the representation as value regions.
    /// Numerical approximations in archaic instances of E58 Measurement Unit used in historical records should be preserved. Equivalents corresponding to current knowledge should be recorded as additional instances of E54 Dimension as appropriate.
    /// </para>
    /// labels<para>Dimensions</para><para>Dimension</para><para>Величина</para><para>Dimensão</para><para>Μέγεθος</para><para>Maß</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E54_Dimension">http://www.cidoc-crm.org/cidoc-crm/E54_Dimension</seealso>
    let E54_Dimension = Prefixed_Name(cidoc, "E54_Dimension") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E56_Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class is a specialization of E55 Type and comprises the natural languages in the sense of concepts.
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E56 Language, e.g.: “instances of  Mandarin Chinese”.
    /// It is recommended that internationally or nationally agreed codes and terminology are used to denote instances of E56 Language, such as those defined in ISO 639:1988.
    /// </para>
    /// labels<para>Language</para><para>Sprache</para><para>Γλώσσα</para><para>Langue</para><para>Língua</para><para>Язык</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E56_Language">http://www.cidoc-crm.org/cidoc-crm/E56_Language</seealso>
    let E56_Language = Prefixed_Name(cidoc, "E56_Language") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E24_Physical_Man-Made_Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all persistent physical items that are purposely created by human activity.
    /// This class comprises man-made objects, such as a swords, and man-made features, such as rock art. No assumptions are made as to the extent of modification required to justify regarding an object as man-made. For example, a “cup and ring” carving on bedrock is regarded as instance of E24 Physical Man-Made Thing.
    /// </para>
    /// labels<para>Физическая Рукотворная Вещь</para><para>Chose matérielle fabriquée</para><para>Ανθρωπογενές Υλικό Πράγμα</para><para>Coisa Material Fabricada</para><para>Physical Man-Made Thing</para><para>Hergestelltes</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E24_Physical_Man-Made_Thing">http://www.cidoc-crm.org/cidoc-crm/E24_Physical_Man-Made_Thing</seealso>
    let E24_Physical_Man_Made_Thing =
        Prefixed_Name(cidoc, "E24_Physical_Man-Made_Thing") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E71_Man-Made_Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises discrete, identifiable man-made items that are documented as single units.
    /// These items are either intellectual products or man-made physical things, and are characterized by relative stability. They may for instance have a solid physical form, an electronic encoding, or they may be logical concepts or structures.
    /// </para>
    /// labels<para>Ανθρώπινο Δημιούργημα</para><para>Рукотворная Вещь</para><para>Coisa Fabricada</para><para>Chose fabriquée</para><para>Man-Made Thing</para><para>Künstliches</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E71_Man-Made_Thing">http://www.cidoc-crm.org/cidoc-crm/E71_Man-Made_Thing</seealso>
    let E71_Man_Made_Thing = Prefixed_Name(cidoc, "E71_Man-Made_Thing") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E26_Physical_Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises identifiable features that are physically attached in an integral way to particular physical objects.
    /// Instances of E26 Physical Feature share many of the attributes of instances of E19 Physical Object. They may have a one-, two- or three-dimensional geometric extent, but there are no natural borders that separate them completely in an objective way from the carrier objects. For example, a doorway is a feature but the door itself, being attached by hinges, is not.
    /// Instances of E26 Physical Feature can be features in a narrower sense, such as scratches, holes, reliefs, surface colours, reflection zones in an opal crystal or a density change in a piece of wood. In the wider sense, they are portions of particular objects with partially imaginary borders, such as the core of the Earth, an area of property on the surface of the Earth, a landscape or the head of a contiguous marble statue. They can be measured and dated, and it is sometimes possible to state who or what is or was responsible for them. They cannot be separated from the carrier object, but a segment of the carrier object may be identified (or sometimes removed) carrying the complete feature.
    /// This definition coincides with the definition of "fiat objects" (Smith &amp; Varzi, 2000, pp.401-420), with the exception of aggregates of “bona fide objects”.
    /// </para>
    /// labels<para>Caractéristique matérielle</para><para>Característica Material</para><para>Materielles Merkmal</para><para>Физический Признак</para><para>Physical Feature</para><para>Υλικό Μόρφωμα</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E26_Physical_Feature">http://www.cidoc-crm.org/cidoc-crm/E26_Physical_Feature</seealso>
    let E26_Physical_Feature =
        Prefixed_Name(cidoc, "E26_Physical_Feature") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P43i_is_dimension_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является величиной для</para><para>είναι μέγεθος του</para><para>ist Dimension von</para><para>est dimension de</para><para>is dimension of</para><para>é dimensão de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P43i_is_dimension_of">http://www.cidoc-crm.org/cidoc-crm/P43i_is_dimension_of</seealso>
    let P43i_is_dimension_of =
        Prefixed_Name(cidoc, "P43i_is_dimension_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E25_Man-Made_Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises physical features that are purposely created by human activity, such as scratches, artificial caves, artificial water channels, etc.
    /// No assumptions are made as to the extent of modification required to justify regarding a feature as man-made. For example, rock art or even “cup and ring” carvings on bedrock a regarded as types of E25 Man-Made Feature.
    /// </para>
    /// labels<para>Caractéristique fabriquée</para><para>Característica Fabricada</para><para>Искусственный Признак</para><para>Hergestelltes Merkmal</para><para>Ανθρωπογενές Μόρφωμα</para><para>Man-Made Feature</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E25_Man-Made_Feature">http://www.cidoc-crm.org/cidoc-crm/E25_Man-Made_Feature</seealso>
    let E25_Man_Made_Feature =
        Prefixed_Name(cidoc, "E25_Man-Made_Feature") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E66_Formation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises events that result in the formation of a formal or informal E74 Group of people, such as a club, society, association, corporation or nation.
    /// E66 Formation does not include the arbitrary aggregation of people who do not act as a collective.
    /// The formation of an instance of E74 Group does not mean that the group is populated with members at the time of formation. In order to express the joining of members at the time of formation, the respective activity should be simultaneously an instance of both E66 Formation and E85 Joining.
    /// </para>
    /// labels<para>Событие Формирования</para><para>Συγκρότηση Ομάδας</para><para>Gruppenbildung</para><para>Formation</para><para>Formation</para><para>Formação</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E66_Formation">http://www.cidoc-crm.org/cidoc-crm/E66_Formation</seealso>
    let E66_Formation = Prefixed_Name(cidoc, "E66_Formation") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E68_Dissolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the events that result in the formal or informal termination of an E74 Group of people.
    /// If the dissolution was deliberate, the Dissolution event should also be instantiated as an E7 Activity.
    /// </para>
    /// labels<para>Gruppenauflösung</para><para>Διάλυση Ομάδας</para><para>Dissolution</para><para>Dissolution</para><para>Dissolução</para><para>Роспуск</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E68_Dissolution">http://www.cidoc-crm.org/cidoc-crm/E68_Dissolution</seealso>
    let E68_Dissolution = Prefixed_Name(cidoc, "E68_Dissolution") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E6_Destruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises events that destroy one or more instances of E18 Physical Thing such that they lose their identity as the subjects of documentation.
    /// Some destruction events are intentional, while others are independent of human activity. Intentional destruction may be documented by classifying the event as both an E6 Destruction and E7 Activity.
    /// The decision to document an object as destroyed, transformed or modified is context sensitive:
    /// 1.  If the matter remaining from the destruction is not documented, the event is modelled solely as E6 Destruction.
    /// 2. An event should also be documented using E81 Transformation if it results in the destruction of one or more objects and the simultaneous production of others using parts or material from the original. In this case, the new items have separate identities. Matter is preserved, but identity is not.
    /// 3. When the initial identity of the changed instance of E18 Physical Thing is preserved, the event should be documented as E11 Modification.
    /// </para>
    /// labels<para>Destruction</para><para>Destruction</para><para>Zerstörung</para><para>Καταστροφή</para><para>Разрушение</para><para>Destruição</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E6_Destruction">http://www.cidoc-crm.org/cidoc-crm/E6_Destruction</seealso>
    let E6_Destruction = Prefixed_Name(cidoc, "E6_Destruction") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P67_refers_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property documents that an E89 Propositional Object makes a statement about an instance of E1 CRM Entity. P67 refers to (is referred to by) has the P67.1 has type link to an instance of E55 Type. This is intended to allow a more detailed description of the type of reference. This differs from P129 is about (is subject of), which describes the primary subject or subjects of the E89 Propositional Object.
    /// </para>
    /// labels<para>fait référence à</para><para>αναφέρεται σε</para><para>ссылается на</para><para>verweist auf</para><para>referencia</para><para>refers to</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P67_refers_to">http://www.cidoc-crm.org/cidoc-crm/P67_refers_to</seealso>
    let P67_refers_to = Prefixed_Name(cidoc, "P67_refers_to") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P129i_is_subject_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является предметом для</para><para>είναι θέμα  του/της</para><para>wird behandelt in</para><para>est le sujet de</para><para>is subject of</para><para>é assunto de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P129i_is_subject_of">http://www.cidoc-crm.org/cidoc-crm/P129i_is_subject_of</seealso>
    let P129i_is_subject_of =
        Prefixed_Name(cidoc, "P129i_is_subject_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P4_has_time-span</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the temporal confinement of an instance of an E2 Temporal Entity.
    /// The related E52 Time-Span is understood as the real Time-Span during which the phenomena were active, which make up the temporal entity instance. It does not convey any other meaning than a positioning on the “time-line” of chronology. The Time-Span in turn is approximated by a set of dates (E61 Time Primitive). A temporal entity can have in reality only one Time-Span, but there may exist alternative opinions about it, which we would express by assigning multiple Time-Spans. Related temporal entities may share a Time-Span. Time-Spans may have completely unknown dates but other descriptions by which we can infer knowledge.
    /// </para>
    /// labels<para>имеет временной отрезок</para><para>βρισκόταν σε εξέλιξη</para><para>tem período de tempo</para><para>hat Zeitspanne</para><para>has time-span</para><para>a pour durée</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P4_has_time-span">http://www.cidoc-crm.org/cidoc-crm/P4_has_time-span</seealso>
    let P4_has_time_span = Prefixed_Name(cidoc, "P4_has_time-span") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E67_Birth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the births of human beings. E67 Birth is a biological event focussing on the context of people coming into life. (E63 Beginning of Existence comprises the coming into life of any living beings).
    /// Twins, triplets etc. are brought into life by the same E67 Birth event. The introduction of the E67 Birth event as a documentation element allows the description of a range of family relationships in a simple model. Suitable extensions may describe more details and the complexity of motherhood with the intervention of modern medicine. In this model, the biological father is not seen as a necessary participant in the E67 Birth event.
    /// </para>
    /// labels<para>Nascimento</para><para>Naissance</para><para>Рождение</para><para>Γέννηση</para><para>Geburt</para><para>Birth</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E67_Birth">http://www.cidoc-crm.org/cidoc-crm/E67_Birth</seealso>
    let E67_Birth = Prefixed_Name(cidoc, "E67_Birth") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E69_Death</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the deaths of human beings.
    /// If a person is killed, their death should be instantiated as E69 Death and as E7 Activity. The death or perishing of other living beings should be documented using E64 End of Existence.
    /// </para>
    /// labels<para>Θάνατος</para><para>Смерть</para><para>Morte</para><para>Death</para><para>Mort</para><para>Tod</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E69_Death">http://www.cidoc-crm.org/cidoc-crm/E69_Death</seealso>
    let E69_Death = Prefixed_Name(cidoc, "E69_Death") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E70_Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This general class comprises usable discrete, identifiable, instances of E77 Persistent Item that are documented as single units.
    ///
    /// They can be either intellectual products or physical things, and are characterized by relative stability. They may for instance either have a solid physical form, an electronic encoding, or they may be logical concept or structure.
    /// </para>
    /// labels<para>Πράγμα</para><para>Thing</para><para>Chose</para><para>Coisa</para><para>Sache</para><para></para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E70_Thing">http://www.cidoc-crm.org/cidoc-crm/E70_Thing</seealso>
    let E70_Thing = Prefixed_Name(cidoc, "E70_Thing") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E75_Conceptual_Object_Appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all appellations specific to intellectual products or standardized patterns.</para>
    /// labels<para>Обозначение Концептуального Объекта</para><para>Designação de Objeto Conceitual</para><para>Begriff- oder Konzeptbenennung </para><para>Appellation d'objet conceptuel</para><para>Ονομασία Νοητικού Αντικειμένου</para><para>Conceptual Object Appellation</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E75_Conceptual_Object_Appellation">http://www.cidoc-crm.org/cidoc-crm/E75_Conceptual_Object_Appellation</seealso>
    let E75_Conceptual_Object_Appellation =
        Prefixed_Name(cidoc, "E75_Conceptual_Object_Appellation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E78_Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises aggregations of instances of E18 Physical Thing that are assembled and maintained (“curated” and “preserved,” in museological terminology) by one or more instances of E39 Actor over time for a specific purpose and audience, and according to a particular collection development plan.
    /// Items may be added or removed from an E78 Collection in pursuit of this plan. This class should not be confused with the E39 Actor maintaining the E78 Collection often referred to with the name of the E78 Collection (e.g. “The Wallace Collection decided…”).
    /// Collective objects in the general sense, like a tomb full of gifts, a folder with stamps or a set of chessmen, should be documented as instances of E19 Physical Object, and not as instances of E78 Collection. This is because they form wholes either because they are physically bound together or because they are kept together for their functionality.
    /// </para>
    /// labels<para>Collection</para><para>Collection</para><para>Коллекция</para><para>Sammlung</para><para>Coleção</para><para>Συλλογή</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E78_Collection">http://www.cidoc-crm.org/cidoc-crm/E78_Collection</seealso>
    let E78_Collection = Prefixed_Name(cidoc, "E78_Collection") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P136i_supported_type_creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a justifié la création de type</para><para>υποστήριξε τη δημιουργία τύπου</para><para>suportou a criação de tipo</para><para>поддержал создание типа</para><para>supported type creation</para><para>belegte</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P136i_supported_type_creation">http://www.cidoc-crm.org/cidoc-crm/P136i_supported_type_creation</seealso>
    let P136i_supported_type_creation =
        Prefixed_Name(cidoc, "P136i_supported_type_creation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P54_has_current_permanent_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the foreseen permanent location of an instance of E19 Physical Object at the time this property was recorded.
    /// P54 has current permanent location (is current permanent location of) is similar to P55 has current location (currently holds). However, it indicates the E53 Place currently reserved for an object, such as the permanent storage location or a permanent exhibit location. The object may be temporarily removed from the permanent location, for example when used in temporary exhibitions or loaned to another institution. The object may never actually be located at its permanent location.
    /// </para>
    /// labels<para>a actuellement pour localisation à demeure</para><para>имеет текущее постоянное местоположение</para><para>hat derzeitigen permanenten Standort</para><para>é localizado permanentemente em</para><para>has current permanent location</para><para>έχει μόνιμη θέση</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P54_has_current_permanent_location">http://www.cidoc-crm.org/cidoc-crm/P54_has_current_permanent_location</seealso>
    let P54_has_current_permanent_location =
        Prefixed_Name(cidoc, "P54_has_current_permanent_location") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E27_Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises pieces of land or sea floor.
    /// In contrast to the purely geometric notion of E53 Place, this class describes constellations of matter on the surface of the Earth or other celestial body, which can be represented by photographs, paintings and maps.
    ///  Instances of E27 Site are composed of relatively immobile material items and features in a particular configuration at a particular location</para>
    /// labels<para>Φυσικός Χώρος</para><para>Участок</para><para>Gelände</para><para>Lugar</para><para>Site</para><para>Site</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E27_Site">http://www.cidoc-crm.org/cidoc-crm/E27_Site</seealso>
    let E27_Site = Prefixed_Name(cidoc, "E27_Site") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E29_Design_or_Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises documented plans for the execution of actions in order to achieve a result of a specific quality, form or contents. In particular it comprises plans for deliberate human activities that may result in the modification or production of instances of E24 Physical Thing.
    /// Instances of E29 Design or Procedure can be structured in parts and sequences or depend on others. This is modelled using P69 is associated with.
    /// Designs or procedures can be seen as one of the following:
    /// 1.	A schema for the activities it describes
    /// 2.	A schema of the products that result from their application.
    /// 3.	An independent intellectual product that may have never been applied, such as Leonardo da Vinci’s famous plans for flying machines.
    /// Because designs or procedures may never be applied or only partially executed, the CRM models a loose relationship between the plan and the respective product.
    /// </para>
    /// labels<para>Conception ou procédure</para><para>Projeto ou Procedimento</para><para>Entwurf oder Verfahren</para><para>Проект или Процедура</para><para>Design or Procedure</para><para>Σχέδιο</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E29_Design_or_Procedure">http://www.cidoc-crm.org/cidoc-crm/E29_Design_or_Procedure</seealso>
    let E29_Design_or_Procedure =
        Prefixed_Name(cidoc, "E29_Design_or_Procedure") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E30_Right</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises legal privileges concerning material and immaterial things or their derivatives.
    /// These include reproduction and property rights</para>
    /// labels<para>Δικαίωμα</para><para>Direitos</para><para>Право</para><para>Droit</para><para>Recht</para><para>Right</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E30_Right">http://www.cidoc-crm.org/cidoc-crm/E30_Right</seealso>
    let E30_Right = Prefixed_Name(cidoc, "E30_Right") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E89_Propositional_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises immaterial items, including but not limited to stories, plots, procedural prescriptions, algorithms, laws of physics or images that are, or represent in some sense, sets of propositions about real or imaginary things and that are documented as single units or serve as topics of discourse.
    ///
    /// This class also comprises items that are “about” something in the sense of a subject. In the wider sense, this class includes expressions of psychological value such as non-figural art and musical themes. However, conceptual items such as types and classes are not instances of E89 Propositional Object. This should not be confused with the definition of a type, which is indeed an instance of E89 Propositional Object.
    /// </para>
    /// labels<para>Propositional Object</para><para>Aussagenobjekt</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E89_Propositional_Object">http://www.cidoc-crm.org/cidoc-crm/E89_Propositional_Object</seealso>
    let E89_Propositional_Object =
        Prefixed_Name(cidoc, "E89_Propositional_Object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E31_Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises identifiable immaterial items that make propositions about reality.
    /// These propositions may be expressed in text, graphics, images, audiograms, videograms or by other similar means. Documentation databases are regarded as a special case of E31 Document. This class should not be confused with the term “document” in Information Technology, which is compatible with E73 Information Object.
    /// </para>
    /// labels<para>Documento</para><para>Dokument</para><para>Document</para><para>Document</para><para>Документ</para><para>Τεκμήριο</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E31_Document">http://www.cidoc-crm.org/cidoc-crm/E31_Document</seealso>
    let E31_Document = Prefixed_Name(cidoc, "E31_Document") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E34_Inscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises recognisable, short texts attached to instances of E24 Physical Man-Made Thing.
    /// The transcription of the text can be documented in a note by P3 has note: E62 String. The alphabet used can be documented by P2 has type: E55 Type. This class does not intend to describe the idiosyncratic characteristics of an individual physical embodiment of an inscription, but the underlying prototype. The physical embodiment is modelled in the CRM as E24 Physical Man-Made Thing.
    /// The relationship of a physical copy of a book to the text it contains is modelled using E84 Information Carrier. P128 carries (is carried by): E33 Linguistic Object.
    /// </para>
    /// labels<para>Inscription</para><para>Inscription</para><para>Inscrição</para><para>Inschrift</para><para>Επιγραφή</para><para>Надпись</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E34_Inscription">http://www.cidoc-crm.org/cidoc-crm/E34_Inscription</seealso>
    let E34_Inscription = Prefixed_Name(cidoc, "E34_Inscription") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E37_Mark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises symbols, signs, signatures or short texts applied to instances of E24 Physical Man-Made Thing by arbitrary techniques in order to indicate the creator, owner, dedications, purpose, etc.
    /// This class specifically excludes features that have no semantic significance, such as scratches or tool marks. These should be documented as instances of E25 Man-Made Feature.
    /// </para>
    /// labels<para>Σήμανση</para><para>Пометка</para><para>Marque</para><para>Marke</para><para>Marca</para><para>Mark</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E37_Mark">http://www.cidoc-crm.org/cidoc-crm/E37_Mark</seealso>
    let E37_Mark = Prefixed_Name(cidoc, "E37_Mark") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E35_Title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the names assigned to works, such as texts, artworks or pieces of music.
    /// Titles are proper noun phrases or verbal phrases, and should not be confused with generic object names such as “chair”, “painting” or “book” (the latter are common nouns that stand for instances of E55 Type). Titles may be assigned by the creator of the work itself, or by a social group.
    /// This class also comprises the translations of titles that are used as surrogates for the original titles in different social contexts.
    /// </para>
    /// labels<para>Заголовок</para><para> Τίτλος</para><para>Título</para><para>Titel</para><para>Titre</para><para>Title</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E35_Title">http://www.cidoc-crm.org/cidoc-crm/E35_Title</seealso>
    let E35_Title = Prefixed_Name(cidoc, "E35_Title") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E41_Appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises all sequences of signs of any nature, either meaningful or not, that are used or can be used to refer to and identify a specific instance of some class within a certain context.
    /// Instances of E41 Appellation do not identify things by their meaning, even if they happen to have one, but by convention, tradition, or agreement. Instances of E41 Appellation are cultural constructs; as such, they have a context, a history, and a use in time and space by some group of users. A given instance of E41 Appellation can have alternative forms, i.e., other instances of E41 Appellation that are always regarded as equivalent independent from the thing it denotes.
    /// Specific subclasses of E41 Appellation should be used when instances of E41 Appellation of a characteristic form are used for particular objects. Instances of E49 Time Appellation, for example, which take the form of instances of E50 Date, can be easily recognised.
    /// E41 Appellation should not be confused with the act of naming something. Cf. E15 Identifier Assignment
    /// </para>
    /// labels<para>Обозначение</para><para>Appellation</para><para>Appellation</para><para>Designação</para><para>Benennung</para><para>Ονομασία</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E41_Appellation">http://www.cidoc-crm.org/cidoc-crm/E41_Appellation</seealso>
    let E41_Appellation = Prefixed_Name(cidoc, "E41_Appellation") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E36_Visual_Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the intellectual or conceptual aspects of recognisable marks and images.
    /// This class does not intend to describe the idiosyncratic characteristics of an individual physical embodiment of a visual item, but the underlying prototype. For example, a mark such as the ICOM logo is generally considered to be the same logo when used on any number of publications. The size, orientation and colour may change, but the logo remains uniquely identifiable. The same is true of images that are reproduced many times. This means that visual items are independent of their physical support.
    /// The class E36 Visual Item provides a means of identifying and linking together instances of E24 Physical Man-Made Thing that carry the same visual symbols, marks or images etc. The property P62 depicts (is depicted by) between E24 Physical Man-Made Thing and depicted subjects (E1 CRM Entity) can be regarded as a short-cut of the more fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1CRM Entity, which in addition captures the optical features of the depiction.
    /// </para>
    /// labels<para>Визуальный Предмет</para><para>Οπτικό Στοιχείο</para><para>Visual Item</para><para>Item visuel</para><para>Item Visual</para><para>Bildliches</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E36_Visual_Item">http://www.cidoc-crm.org/cidoc-crm/E36_Visual_Item</seealso>
    let E36_Visual_Item = Prefixed_Name(cidoc, "E36_Visual_Item") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E38_Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises distributions of form, tone and colour that may be found on surfaces such as photos, paintings, prints and sculptures or directly on electronic media.
    /// The degree to which variations in the distribution of form and colour affect the identity of an instance of E38 Image depends on a given purpose. The original painting of the Mona Lisa in the Louvre may be said to bear the same instance of E38 Image as reproductions in the form of transparencies, postcards, posters or T-shirts, even though they may differ in size and carrier and may vary in tone and colour. The images in a “spot the difference” competition are not the same with respect to their context, however similar they may at first appear.
    /// </para>
    /// labels<para>Изображение</para><para>Imagem</para><para>Εικόνα</para><para>Image</para><para>Image</para><para>Bild</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E38_Image">http://www.cidoc-crm.org/cidoc-crm/E38_Image</seealso>
    let E38_Image = Prefixed_Name(cidoc, "E38_Image") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E77_Persistent_Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises items that have a persistent identity, sometimes known as “endurants” in philosophy.
    /// They can be repeatedly recognized within the duration of their existence by identity criteria rather than by continuity or observation. Persistent Items can be either physical entities, such as people, animals or things, or conceptual entities such as ideas, concepts, products of the imagination or common names.
    /// The criteria that determine the identity of an item are often difficult to establish -; the decision depends largely on the judgement of the observer. For example, a building is regarded as no longer existing if it is dismantled and the materials reused in a different configuration. On the other hand, human beings go through radical and profound changes during their life-span, affecting both material composition and form, yet preserve their identity by other criteria. Similarly, inanimate objects may be subject to exchange of parts and matter. The class E77 Persistent Item does not take any position about the nature of the applicable identity criteria and if actual knowledge about identity of an instance of this class exists. There may be cases, where the identity of an E77 Persistent Item is not decidable by a certain state of knowledge.
    /// The main classes of objects that fall outside the scope the E77 Persistent Item class are temporal objects such as periods, events and acts, and descriptive properties. </para>
    /// labels<para>Entidade Persistente</para><para>Постоянная Сущность</para><para>Entité persistante</para><para>Persistent Item</para><para>Seiendes</para><para>Ον</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E77_Persistent_Item">http://www.cidoc-crm.org/cidoc-crm/E77_Persistent_Item</seealso>
    let E77_Persistent_Item =
        Prefixed_Name(cidoc, "E77_Persistent_Item") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E3_Condition_State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the states of objects characterised by a certain condition over a time-span.
    /// An instance of this class describes the prevailing physical condition of any material object or feature during a specific E52 Time Span. In general, the time-span for which a certain condition can be asserted may be shorter than the real time-span, for which this condition held.
    ///  The nature of that condition can be described using P2 has type. For example, the E3 Condition State “condition of the SS Great Britain between 22 September 1846 and 27 August 1847” can be characterized as E55 Type “wrecked”.
    /// </para>
    /// labels<para>Estado Material</para><para>Condition State</para><para>État matériel</para><para>Zustandsphase</para><para>Κατάσταση</para><para>Состояние</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E3_Condition_State">http://www.cidoc-crm.org/cidoc-crm/E3_Condition_State</seealso>
    let E3_Condition_State = Prefixed_Name(cidoc, "E3_Condition_State") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E74_Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises any gatherings or organizations of two or more people that act collectively or in a similar way due to any form of unifying relationship. In the wider sense this class also comprises official positions which used to be regarded in certain contexts as one actor, independent of the current holder of the office, such as the president of a country.
    /// A gathering of people becomes an E74 Group when it exhibits organizational characteristics usually typified by a set of ideas or beliefs held in common, or actions performed together. These might be communication, creating some common artifact, a common purpose such as study, worship, business, sports, etc. Nationality can be modeled as membership in an E74 Group (cf. HumanML markup). Married couples and other concepts of family are regarded as particular examples of E74 Group.
    /// </para>
    /// labels<para>Menschliche Gruppe</para><para>Группа</para><para>Groupe</para><para>Ομάδα</para><para>Group</para><para>Grupo</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E74_Group">http://www.cidoc-crm.org/cidoc-crm/E74_Group</seealso>
    let E74_Group = Prefixed_Name(cidoc, "E74_Group") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P103i_was_intention_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>était la raison d'être de</para><para>ήταν προορισμός του</para><para>era a destinação de</para><para>war Bestimmung von</para><para>был интенцией для</para><para>was intention of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P103i_was_intention_of">http://www.cidoc-crm.org/cidoc-crm/P103i_was_intention_of</seealso>
    let P103i_was_intention_of =
        Prefixed_Name(cidoc, "P103i_was_intention_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P104_is_subject_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links a particular E72 Legal Object to the instances of E30 Right to which it is subject.
    /// The Right is held by an E39 Actor as described by P75 possesses (is possessed by).
    /// </para>
    /// labels<para>является объектом для</para><para>está sujeito à</para><para>Gegenstand von</para><para>is subject to</para><para>υπόκειται σε</para><para>est sujet à</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P104_is_subject_to">http://www.cidoc-crm.org/cidoc-crm/P104_is_subject_to</seealso>
    let P104_is_subject_to = Prefixed_Name(cidoc, "P104_is_subject_to") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P104i_applies_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>findet Anwendung auf</para><para>применяется к</para><para>se aplicam à</para><para>s’applique à</para><para>applies to</para><para>ισχύει για</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P104i_applies_to">http://www.cidoc-crm.org/cidoc-crm/P104i_applies_to</seealso>
    let P104i_applies_to = Prefixed_Name(cidoc, "P104i_applies_to") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P105_right_held_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor who holds the instances of E30 Right to an E72 Legal Object.
    /// 	It is a superproperty of P52 has current owner (is current owner of) because ownership is a right that is held on the owned object.
    /// P105 right held by (has right on) is a shortcut of the fully developed path from E72 Legal Object through P104 is subject to (applies to), E30 Right, P75 possesses (is possessed by) to E39 Actor.
    /// </para>
    /// labels<para>δικαίωμα κατέχεται από</para><para>право принадлежит</para><para>Rechte stehen zu</para><para>droit détenu par</para><para>são direitos de </para><para>right held by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P105_right_held_by">http://www.cidoc-crm.org/cidoc-crm/P105_right_held_by</seealso>
    let P105_right_held_by = Prefixed_Name(cidoc, "P105_right_held_by") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P105i_has_right_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>possui direitos sobre</para><para>détient un droit sur</para><para>владеет правом на</para><para>έχει δικαίωμα σε</para><para>hat Rechte an</para><para>has right on</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P105i_has_right_on">http://www.cidoc-crm.org/cidoc-crm/P105i_has_right_on</seealso>
    let P105i_has_right_on = Prefixed_Name(cidoc, "P105i_has_right_on") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P106_is_composed_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of E90 Symbolic Object with a part of it that is by itself an instance of E90 Symbolic Object, such as fragments of texts or clippings from an image.
    /// </para>
    /// labels<para> ist zusammengesetzt aus</para><para>αποτελείται από</para><para>est composé de</para><para>is composed of</para><para>é composto de</para><para>составлен из</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P106_is_composed_of">http://www.cidoc-crm.org/cidoc-crm/P106_is_composed_of</seealso>
    let P106_is_composed_of =
        Prefixed_Name(cidoc, "P106_is_composed_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P107_has_current_or_former_member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property relates an E39 Actor to the E74 Group of which that E39 Actor is a member.
    /// Groups, Legal Bodies and Persons, may all be members of Groups. A Group necessarily consists of more than one member.
    /// This property is a shortcut of the more fully developed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor
    /// The property P107.1 kind of member can be used to specify the type of membership or the role the member has in the group.
    /// </para>
    /// labels<para>hat derzeitiges oder früheres Mitglied</para><para>имеет действующего или бывшего члена</para><para>a pour membre actuel ou ancien</para><para>has current or former member</para><para>tem ou teve membro</para><para>έχει ή είχε μέλος</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P107_has_current_or_former_member">http://www.cidoc-crm.org/cidoc-crm/P107_has_current_or_former_member</seealso>
    let P107_has_current_or_former_member =
        Prefixed_Name(cidoc, "P107_has_current_or_former_member") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P107i_is_current_or_former_member_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ist derzeitiges oder früheres Mitglied von</para><para>является действующим или бывшим членом</para><para>est actuel ou ancien membre de</para><para>is current or former member of</para><para>είναι ή ήταν μέλος του/της</para><para>é ou foi membro de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P107i_is_current_or_former_member_of">http://www.cidoc-crm.org/cidoc-crm/P107i_is_current_or_former_member_of</seealso>
    let P107i_is_current_or_former_member_of =
        Prefixed_Name(cidoc, "P107i_is_current_or_former_member_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P31_has_modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E24 Physical Man-Made Thing modified in an E11 Modification.
    /// If a modification is applied to a non-man-made object, it is regarded as an E22 Man-Made Object from that time onwards.
    /// </para>
    /// labels<para>has modified</para><para>τροποποίησε</para><para>veränderte</para><para>modificou</para><para>a modifié</para><para>изменил</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P31_has_modified">http://www.cidoc-crm.org/cidoc-crm/P31_has_modified</seealso>
    let P31_has_modified = Prefixed_Name(cidoc, "P31_has_modified") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P92_brought_into_existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an E63 Beginning of Existence event to be linked to the E77 Persistent Item brought into existence by it.
    /// It allows a “start” to be attached to any Persistent Item being documented i.e. E70 Thing, E72 Legal Object, E39 Actor, E41 Appellation, E51 Contact Point and E55 Type</para>
    /// labels<para>brought into existence</para><para>trouxe à existência</para><para>brachte in Existenz</para><para>a fait exister</para><para>γέννησε</para><para>создал</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P92_brought_into_existence">http://www.cidoc-crm.org/cidoc-crm/P92_brought_into_existence</seealso>
    let P92_brought_into_existence =
        Prefixed_Name(cidoc, "P92_brought_into_existence") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P108i_was_produced_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был произведен посредством</para><para>wurde hergestellt durch</para><para>foi produzido por</para><para>a été produit par</para><para>was produced by</para><para>παρήχθη από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P108i_was_produced_by">http://www.cidoc-crm.org/cidoc-crm/P108i_was_produced_by</seealso>
    let P108i_was_produced_by =
        Prefixed_Name(cidoc, "P108i_was_produced_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P92i_was_brought_into_existence_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde in Existenz gebracht durch</para><para>a commencé à exister du fait de</para><para>was brought into existence by</para><para>был создан посредством</para><para>passou a existir por</para><para>γεννήθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P92i_was_brought_into_existence_by">http://www.cidoc-crm.org/cidoc-crm/P92i_was_brought_into_existence_by</seealso>
    let P92i_was_brought_into_existence_by =
        Prefixed_Name(cidoc, "P92i_was_brought_into_existence_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P109_has_current_or_former_curator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor or Actors who assume or have assumed overall curatorial responsibility for an E78 Collection.
    /// This property is effectively a short-cut. It does not allow a history of curation to be recorded. This would require use of an Event assigning responsibility for a Collection to a curator.
    /// </para>
    /// labels<para>имеет действующего или бывшего хранителя</para><para>hat derzeitigen oder früheren Kurator</para><para>a pour conservateur actuel ou ancien</para><para>has current or former curator</para><para>έχει ή είχε επιμελητή</para><para>tem ou teve curador</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P109_has_current_or_former_curator">http://www.cidoc-crm.org/cidoc-crm/P109_has_current_or_former_curator</seealso>
    let P109_has_current_or_former_curator =
        Prefixed_Name(cidoc, "P109_has_current_or_former_curator") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P49_has_former_or_current_keeper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor or Actors who have or have had custody of an instance of E18 Physical Thing at some time.
    /// The distinction with P50 has current keeper (is current keeper of) is that P49 has former or current keeper (is former or current keeper of) leaves open the question as to whether the specified keepers are current.
    /// P49 has former or current keeper (is former or current keeper of) is a shortcut for the more detailed path from E18 Physical Thing through P30 transferred custody of (custody transferred through), E10 Transfer of Custody, P28 custody surrendered by (surrendered custody through) or P29 custody received by (received custody through) to E39 Actor.
    /// </para>
    /// labels<para>hat früheren oder derzeitigen Betreuer</para><para>имеет бывшего или текущего смотрителя</para><para>είναι ή ήταν στην κατοχή του</para><para>has former or current keeper</para><para>est ou a été détenu par</para><para>é ou foi guardada por</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P49_has_former_or_current_keeper">http://www.cidoc-crm.org/cidoc-crm/P49_has_former_or_current_keeper</seealso>
    let P49_has_former_or_current_keeper =
        Prefixed_Name(cidoc, "P49_has_former_or_current_keeper") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P109i_is_current_or_former_curator_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является действующим или бывшим хранителем</para><para>ist derzeitiger oder früherer Kurator von</para><para>is current or former curator of</para><para>είναι ή ήταν επιμελητής του/της</para><para>est ou a été le conservateur de</para><para>é ou foi curador de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P109i_is_current_or_former_curator_of">http://www.cidoc-crm.org/cidoc-crm/P109i_is_current_or_former_curator_of</seealso>
    let P109i_is_current_or_former_curator_of =
        Prefixed_Name(cidoc, "P109i_is_current_or_former_curator_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P10i_contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>περιλαμβάνει</para><para>contains</para><para>contient</para><para>содержит</para><para>enthält</para><para>contém</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P10i_contains">http://www.cidoc-crm.org/cidoc-crm/P10i_contains</seealso>
    let P10i_contains = Prefixed_Name(cidoc, "P10i_contains") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P110_augmented</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E24 Physical Man-Made Thing that is added to (augmented) in an E79 Part Addition.
    /// Although a Part Addition event normally concerns only one item of Physical Man-Made Thing, it is possible to imagine circumstances under which more than one item might be added to (augmented). For example, the artist Jackson Pollock trailing paint onto multiple canvasses.
    /// </para>
    /// labels<para>erweiterte</para><para>a augmenté</para><para>augmented</para><para>aumentou</para><para>επαύξησε</para><para>увеличил</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P110_augmented">http://www.cidoc-crm.org/cidoc-crm/P110_augmented</seealso>
    let P110_augmented = Prefixed_Name(cidoc, "P110_augmented") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P111_added</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E18 Physical Thing that is added during an E79 Part Addition activity
    /// </para>
    /// labels<para>fügte hinzu</para><para>προσέθεσε</para><para>adicionou</para><para>a ajouté</para><para>добавил</para><para>added</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P111_added">http://www.cidoc-crm.org/cidoc-crm/P111_added</seealso>
    let P111_added = Prefixed_Name(cidoc, "P111_added") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P16_used_specific_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the use of material or immaterial things in a way essential to the performance or the outcome of an E7 Activity.
    /// This property typically applies to tools, instruments, moulds, raw materials and items embedded in a product. It implies that the presence of the object in question was a necessary condition for the action. For example, the activity of writing this text required the use of a computer. An immaterial thing can be used if at least one of its carriers is present. For example, the software tools on a computer.
    /// Another example is the use of a particular name by a particular group of people over some span to identify a thing, such as a settlement. In this case, the physical carriers of this name are at least the people understanding its use.
    /// </para>
    /// labels<para>benutzte das bestimmte Objekt</para><para>a utilisé l'objet spécifique</para><para>использовал особый объект</para><para>χρησιμοποίησε αντικείμενο</para><para>usou objeto específico</para><para>used specific object</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P16_used_specific_object">http://www.cidoc-crm.org/cidoc-crm/P16_used_specific_object</seealso>
    let P16_used_specific_object =
        Prefixed_Name(cidoc, "P16_used_specific_object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P12_occurred_in_the_presence_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the active or passive presence of an E77 Persistent Item in an E5 Event without implying any specific role.
    /// It connects the history of a thing with the E53 Place and E50 Date of an event. For example, an object may be the desk, now in a museum on which a treaty was signed. The presence of an immaterial thing implies the presence of at least one of its carriers.
    /// </para>
    /// labels<para>occurred in the presence of</para><para>est arrivé en présence de</para><para>fand statt im Beisein von</para><para>συνέβη παρουσία του/της</para><para>ocorreu na presença de</para><para>появился в присутствии</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P12_occurred_in_the_presence_of">http://www.cidoc-crm.org/cidoc-crm/P12_occurred_in_the_presence_of</seealso>
    let P12_occurred_in_the_presence_of =
        Prefixed_Name(cidoc, "P12_occurred_in_the_presence_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P111i_was_added_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был добавлен посредством</para><para>wurde hinzugefügt durch</para><para>foi adicionado por</para><para>a été ajouté par</para><para>προστέθηκε από</para><para>was added by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P111i_was_added_by">http://www.cidoc-crm.org/cidoc-crm/P111i_was_added_by</seealso>
    let P111i_was_added_by = Prefixed_Name(cidoc, "P111i_was_added_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P112i_was_diminished_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был уменьшен посредством</para><para>wurde vermindert durch</para><para>was diminished by</para><para>foi diminuído por</para><para>a été diminué par</para><para>εξαλείφθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P112i_was_diminished_by">http://www.cidoc-crm.org/cidoc-crm/P112i_was_diminished_by</seealso>
    let P112i_was_diminished_by =
        Prefixed_Name(cidoc, "P112i_was_diminished_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P113_removed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E18 Physical Thing that is removed during an E80 Part Removal activity.</para>
    /// labels<para>entfernte</para><para>αφαίρεσε</para><para>a enlevé</para><para>removed</para><para>removeu</para><para>удален</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P113_removed">http://www.cidoc-crm.org/cidoc-crm/P113_removed</seealso>
    let P113_removed = Prefixed_Name(cidoc, "P113_removed") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P113i_was_removed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был удален посредством</para><para>wurde entfernt durch</para><para>a été enlevée par</para><para>foi removido por</para><para>αφαιρέθηκε από</para><para>was removed by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P113i_was_removed_by">http://www.cidoc-crm.org/cidoc-crm/P113i_was_removed_by</seealso>
    let P113i_was_removed_by =
        Prefixed_Name(cidoc, "P113i_was_removed_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P114_is_equal_in_time_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This symmetric property allows the instances of E2 Temporal Entity with the same E52 Time-Span to be equated.
    /// This property is only necessary if the time span is unknown (otherwise the equivalence can be calculated).
    /// This property is the same as the "equal" relationship of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    /// labels<para>est temporellement égale à</para><para>é temporalmente igual a</para><para>συμπίπτει χρονικά με</para><para>is equal in time to</para><para>равен по времени</para><para>zeitgleich zu</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P114_is_equal_in_time_to">http://www.cidoc-crm.org/cidoc-crm/P114_is_equal_in_time_to</seealso>
    let P114_is_equal_in_time_to =
        Prefixed_Name(cidoc, "P114_is_equal_in_time_to") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P115_finishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows the ending point for a E2 Temporal Entity to be situated by reference to the ending point of another temporal entity of longer duration.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "finishes / finished-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    /// labels<para>заканчивает</para><para>περατώνει</para><para>finishes</para><para>finaliza</para><para>termine</para><para>beendet</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P115_finishes">http://www.cidoc-crm.org/cidoc-crm/P115_finishes</seealso>
    let P115_finishes = Prefixed_Name(cidoc, "P115_finishes") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P115i_is_finished_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde beendet mit</para><para>est terminée par</para><para>é finalizada por</para><para>is finished by</para><para>περατώνεται με</para><para>заканчивается</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P115i_is_finished_by">http://www.cidoc-crm.org/cidoc-crm/P115i_is_finished_by</seealso>
    let P115i_is_finished_by =
        Prefixed_Name(cidoc, "P115i_is_finished_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P116_starts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows the starting point for a E2 Temporal Entity to be situated by reference to the starting point of another temporal entity of longer duration.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "starts / started-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    /// labels<para>начинает</para><para>commence</para><para>αρχίζει</para><para>beginnt</para><para>inicia</para><para>starts</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P116_starts">http://www.cidoc-crm.org/cidoc-crm/P116_starts</seealso>
    let P116_starts = Prefixed_Name(cidoc, "P116_starts") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P116i_is_started_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde begonnen mit</para><para>est commencée par</para><para>é iniciada por</para><para>is started by</para><para>начинается</para><para>αρχίζει με</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P116i_is_started_by">http://www.cidoc-crm.org/cidoc-crm/P116i_is_started_by</seealso>
    let P116i_is_started_by =
        Prefixed_Name(cidoc, "P116i_is_started_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P117_occurs_during</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows the entire E52 Time-Span of an E2 Temporal Entity to be situated within the Time-Span of another temporal entity that starts before and ends after the included temporal entity.
    /// This property is only necessary if the time span is unknown (otherwise the relationship can be calculated). This property is the same as the "during / includes" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    /// labels<para>εμφανίζεται κατά τη διάρκεια</para><para>появляется во течение</para><para>a lieu pendant</para><para>ocorre durante</para><para>occurs during</para><para>fällt in</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P117_occurs_during">http://www.cidoc-crm.org/cidoc-crm/P117_occurs_during</seealso>
    let P117_occurs_during = Prefixed_Name(cidoc, "P117_occurs_during") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P117i_includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>περιλαμβάνει</para><para>beinhaltet</para><para>includes</para><para>comporte</para><para>включает</para><para>inclui</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P117i_includes">http://www.cidoc-crm.org/cidoc-crm/P117i_includes</seealso>
    let P117i_includes = Prefixed_Name(cidoc, "P117i_includes") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P118_overlaps_in_time_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an overlap between the instances of E52 Time-Span of two instances of E2 Temporal Entity.
    /// It implies a temporal order between the two entities: if A overlaps in time B, then A must start before B, and B must end after A. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "overlaps / overlapped-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    /// labels<para>est partiellement recouverte dans le temps par</para><para>προηγείται μερικώς επικαλύπτοντας</para><para>sobrepõe temporalmente</para><para>перекрывает во времени</para><para>überlappt zeitlich mit</para><para>overlaps in time with</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P118_overlaps_in_time_with">http://www.cidoc-crm.org/cidoc-crm/P118_overlaps_in_time_with</seealso>
    let P118_overlaps_in_time_with =
        Prefixed_Name(cidoc, "P118_overlaps_in_time_with") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P118i_is_overlapped_in_time_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>recouvre partiellement dans le temps</para><para>é sobreposto temporalmente por</para><para>έπεται μερικώς επικαλυπτόμενο</para><para>wird zeitlich überlappt von</para><para>is overlapped in time by</para><para>перекрывается во времени</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P118i_is_overlapped_in_time_by">http://www.cidoc-crm.org/cidoc-crm/P118i_is_overlapped_in_time_by</seealso>
    let P118i_is_overlapped_in_time_by =
        Prefixed_Name(cidoc, "P118i_is_overlapped_in_time_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P119_meets_in_time_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property indicates that one E2 Temporal Entity immediately follows another.
    /// It implies a particular order between the two entities: if A meets in time with B, then A must precede B. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "meets / met-by" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    /// labels<para>est temporellement contiguë avec</para><para>é temporalmente contíguo com</para><para>следует во времени за</para><para>trifft zeitlich auf</para><para>meets in time with</para><para>προηγείται</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P119_meets_in_time_with">http://www.cidoc-crm.org/cidoc-crm/P119_meets_in_time_with</seealso>
    let P119_meets_in_time_with =
        Prefixed_Name(cidoc, "P119_meets_in_time_with") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P119i_is_met_in_time_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>est immédiatement précédé par</para><para>é imediatamente precedido por</para><para>wird zeitlich getroffen von</para><para>предшествует во времени</para><para>is met in time by</para><para>έπεται</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P119i_is_met_in_time_by">http://www.cidoc-crm.org/cidoc-crm/P119i_is_met_in_time_by</seealso>
    let P119i_is_met_in_time_by =
        Prefixed_Name(cidoc, "P119i_is_met_in_time_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P11_had_participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the active or passive participation of instances of E39 Actors in an E5 Event.
    /// It connects the life-line of the related E39 Actor with the E53 Place and E50 Date of the event. The property implies that the Actor was involved in the event but does not imply any causal relationship. The subject of a portrait can be said to have participated in the creation of the portrait.
    /// </para>
    /// labels<para>a eu pour participant</para><para>tem participante</para><para>hatte Teilnehmer</para><para>had participant</para><para>имел участника</para><para>είχε συμμέτοχο</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P11_had_participant">http://www.cidoc-crm.org/cidoc-crm/P11_had_participant</seealso>
    let P11_had_participant =
        Prefixed_Name(cidoc, "P11_had_participant") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P120_occurs_before</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the relative chronological sequence of two temporal entities.
    /// It implies that a temporal gap exists between the end of A and the start of B. This property is only necessary if the relevant time spans are unknown (otherwise the relationship can be calculated).
    /// This property is the same as the "before / after" relationships of Allen’s temporal logic (Allen, 1983, pp. 832-843).
    /// </para>
    /// labels<para>εμφανίζεται πριν</para><para>occurs before</para><para>появляется до</para><para>a lieu avant</para><para>ocorre antes</para><para>kommt vor</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P120_occurs_before">http://www.cidoc-crm.org/cidoc-crm/P120_occurs_before</seealso>
    let P120_occurs_before = Prefixed_Name(cidoc, "P120_occurs_before") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P120i_occurs_after</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>εμφανίζεται μετά</para><para>появляется после</para><para>ocorre depois</para><para>a lieu après</para><para>occurs after</para><para>kommt nach</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P120i_occurs_after">http://www.cidoc-crm.org/cidoc-crm/P120i_occurs_after</seealso>
    let P120i_occurs_after = Prefixed_Name(cidoc, "P120i_occurs_after") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P121_overlaps_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This symmetric property allows the instances of E53 Place with overlapping geometric extents to be associated with each other.
    /// It does not specify anything about the shared area. This property is purely spatial, in contrast to Allen operators, which are purely temporal.
    /// </para>
    /// labels<para>επικαλύπτεται με</para><para>пересекается с</para><para>überlappt mit</para><para>overlaps with</para><para>sobrepõe com</para><para>chevauche</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P121_overlaps_with">http://www.cidoc-crm.org/cidoc-crm/P121_overlaps_with</seealso>
    let P121_overlaps_with = Prefixed_Name(cidoc, "P121_overlaps_with") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P122_borders_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This symmetric property allows the instances of E53 Place which share common borders to be related as such.
    /// This property is purely spatial, in contrast to Allen operators, which are purely temporal.
    /// </para>
    /// labels<para>fronteira com</para><para>συνορεύει με</para><para>borders with</para><para>граничит с</para><para>grenzt an</para><para>jouxte</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P122_borders_with">http://www.cidoc-crm.org/cidoc-crm/P122_borders_with</seealso>
    let P122_borders_with = Prefixed_Name(cidoc, "P122_borders_with") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P123_resulted_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E77 Persistent Item or items that are the result of an E81 Transformation.
    /// New items replace the transformed item or items, which cease to exist as units of documentation. The physical continuity between the old and the new is expressed by the link to the common Transformation.
    /// </para>
    /// labels<para>είχε ως αποτέλεσμα</para><para>a eu pour résultat</para><para>повлек появление</para><para>resultou em</para><para>resulted in</para><para>ergab</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P123_resulted_in">http://www.cidoc-crm.org/cidoc-crm/P123_resulted_in</seealso>
    let P123_resulted_in = Prefixed_Name(cidoc, "P123_resulted_in") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P123i_resulted_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>est le résultat de</para><para>был результатом</para><para>ergab sich aus</para><para>resulted from</para><para>resultado de</para><para>προέκυψε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P123i_resulted_from">http://www.cidoc-crm.org/cidoc-crm/P123i_resulted_from</seealso>
    let P123i_resulted_from =
        Prefixed_Name(cidoc, "P123i_resulted_from") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P124_transformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E77 Persistent Item or items that cease to exist due to a E81 Transformation.
    /// It is replaced by the result of the Transformation, which becomes a new unit of documentation. The continuity between both items, the new and the old, is expressed by the link to the common Transformation.
    /// </para>
    /// labels<para>трансформировал</para><para>a transformé</para><para>wandelte um</para><para>transformed</para><para>transformou</para><para>μετέτρεψε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P124_transformed">http://www.cidoc-crm.org/cidoc-crm/P124_transformed</seealso>
    let P124_transformed = Prefixed_Name(cidoc, "P124_transformed") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P124i_was_transformed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был трансформирован посредством</para><para>wurde umgewandelt durch</para><para>a été transformé par</para><para>foi transformado por</para><para>was transformed by</para><para>μετατράπηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P124i_was_transformed_by">http://www.cidoc-crm.org/cidoc-crm/P124i_was_transformed_by</seealso>
    let P124i_was_transformed_by =
        Prefixed_Name(cidoc, "P124i_was_transformed_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P125i_was_type_of_object_used_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ήταν o τύπος αντικείμενου που χρησιμοποιήθηκε σε</para><para>Objekt des Typus ... wurde benutzt in</para><para>был типом объекта использованного в</para><para>était le type d’objet employé par</para><para>foi tipo do objeto usado em</para><para>was type of object used in</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P125i_was_type_of_object_used_in">http://www.cidoc-crm.org/cidoc-crm/P125i_was_type_of_object_used_in</seealso>
    let P125i_was_type_of_object_used_in =
        Prefixed_Name(cidoc, "P125i_was_type_of_object_used_in") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P126_employed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies E57 Material employed in an E11 Modification.
    /// The E57 Material used during the E11 Modification does not necessarily become incorporated into the E24 Physical Man-Made Thing that forms the subject of the E11 Modification.
    /// </para>
    /// labels<para>χρησιμοποίησε</para><para>использовал</para><para>verwendete</para><para>a employé</para><para>empregou</para><para>employed</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P126_employed">http://www.cidoc-crm.org/cidoc-crm/P126_employed</seealso>
    let P126_employed = Prefixed_Name(cidoc, "P126_employed") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P126i_was_employed_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde verwendet bei</para><para>χρησιμοποιήθηκε σε</para><para>a été employé dans</para><para>foi empregado em</para><para>was employed in</para><para>использовался в</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P126i_was_employed_in">http://www.cidoc-crm.org/cidoc-crm/P126i_was_employed_in</seealso>
    let P126i_was_employed_in =
        Prefixed_Name(cidoc, "P126i_was_employed_in") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P127_has_broader_term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies a super-Type to which an E55 Type is related.
    /// 		It allows Types to be organised into hierarchies. This is the sense of "broader term generic  		(BTG)" as defined in ISO 2788
    /// </para>
    /// labels<para>имеет вышестоящий термин</para><para>a pour terme générique</para><para>hat den Oberbegriff</para><para>tem termo genérico</para><para>έχει ευρύτερο όρο</para><para>has broader term</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P127_has_broader_term">http://www.cidoc-crm.org/cidoc-crm/P127_has_broader_term</seealso>
    let P127_has_broader_term =
        Prefixed_Name(cidoc, "P127_has_broader_term") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P127i_has_narrower_term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a pour terme spécifique</para><para>tem termo específico</para><para>hat den Unterbegriff</para><para>έχει στενότερο όρο</para><para>has narrower term</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P127i_has_narrower_term">http://www.cidoc-crm.org/cidoc-crm/P127i_has_narrower_term</seealso>
    let P127i_has_narrower_term =
        Prefixed_Name(cidoc, "P127i_has_narrower_term") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P128_carries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an E73 Information Object carried by an instance of E24 Physical Man-Made Thing.
    /// In general this would be an E84 Information Carrier P65 shows visual item (is shown by) is a specialisation of P128 carries (is carried by) which should be used for carrying visual items.
    /// </para>
    /// labels<para>est le support de</para><para>é o suporte de</para><para>carries</para><para>несет</para><para>trägt</para><para>φέρει</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P128_carries">http://www.cidoc-crm.org/cidoc-crm/P128_carries</seealso>
    let P128_carries = Prefixed_Name(cidoc, "P128_carries") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P130_shows_features_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property generalises the notions of  "copy of" and "similar to" into a dynamic, asymmetric relationship, where the domain expresses the derivative, if such a direction can be established.
    /// Otherwise, the relationship is symmetric. It is a short-cut of P15 was influenced by (influenced) in a creation or production, if such a reason for the similarity can be verified. Moreover it expresses similarity in cases that can be stated between two objects only, without historical knowledge about its reasons.
    /// </para>
    /// labels<para>παρουσιάζει χαρακτηριστικά του/της</para><para>présente des caractéristiques de</para><para>apresenta características de</para><para>демонстрирует признаки</para><para>zeigt Merkmale von</para><para>shows features of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P130_shows_features_of">http://www.cidoc-crm.org/cidoc-crm/P130_shows_features_of</seealso>
    let P130_shows_features_of =
        Prefixed_Name(cidoc, "P130_shows_features_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P128i_is_carried_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>переносится посредством</para><para>wird getragen von</para><para>é suportado por</para><para>a pour support</para><para>is carried by</para><para>φέρεται από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P128i_is_carried_by">http://www.cidoc-crm.org/cidoc-crm/P128i_is_carried_by</seealso>
    let P128i_is_carried_by =
        Prefixed_Name(cidoc, "P128i_is_carried_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P130i_features_are_also_found_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a des caractéristiques se trouvant aussi sur</para><para>características são também encontradas em</para><para>χαρακτηριστικά του βρίσκονται επίσης σε</para><para>features are also found on</para><para>признаки также найдены на</para><para>Merkmale auch auf</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P130i_features_are_also_found_on">http://www.cidoc-crm.org/cidoc-crm/P130i_features_are_also_found_on</seealso>
    let P130i_features_are_also_found_on =
        Prefixed_Name(cidoc, "P130i_features_are_also_found_on") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P129_is_about</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property documents that an E89 Propositional Object has as subject an instance of E1 CRM Entity.
    /// </para>
    /// labels<para>est au sujet de</para><para>έχει ως θέμα</para><para>handelt über</para><para>касается</para><para>is about</para><para>é sobre</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P129_is_about">http://www.cidoc-crm.org/cidoc-crm/P129_is_about</seealso>
    let P129_is_about = Prefixed_Name(cidoc, "P129_is_about") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P67i_is_referred_to_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>имеет ссылку на себя от</para><para>é referenciado por</para><para>wird angeführt von</para><para>est référencé par</para><para>is referred to by</para><para>αναφέρεται από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P67i_is_referred_to_by">http://www.cidoc-crm.org/cidoc-crm/P67i_is_referred_to_by</seealso>
    let P67i_is_referred_to_by =
        Prefixed_Name(cidoc, "P67i_is_referred_to_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P131_is_identified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies a name used specifically to identify an E39 Actor.
    /// This property is a specialisation of P1 is identified by (identifies) is identified by.
    /// </para>
    /// labels<para>идентифицируется посредством</para><para>wird identifziert durch</para><para>é identificado por</para><para>est identifié par</para><para>is identified by</para><para>αναγνωρίζεται ως</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P131_is_identified_by">http://www.cidoc-crm.org/cidoc-crm/P131_is_identified_by</seealso>
    let P131_is_identified_by =
        Prefixed_Name(cidoc, "P131_is_identified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P131i_identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>είναι αναγνωριστικό</para><para>идентифицирует</para><para>identifiziert</para><para>identifies</para><para>identifica</para><para>identifie</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P131i_identifies">http://www.cidoc-crm.org/cidoc-crm/P131i_identifies</seealso>
    let P131i_identifies = Prefixed_Name(cidoc, "P131i_identifies") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P132_overlaps_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This symmetric property allows instances of E4 Period that overlap both temporally and spatially to be related, i,e. they share some spatio-temporal extent.
    /// This property does not imply any ordering or sequence between the two periods, either spatial or temporal.
    /// </para>
    /// labels<para>επικαλύπτεται με</para><para>пересекается с</para><para>overlaps with</para><para>überlappt mit</para><para>chevauche</para><para>sobrepõe</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P132_overlaps_with">http://www.cidoc-crm.org/cidoc-crm/P132_overlaps_with</seealso>
    let P132_overlaps_with = Prefixed_Name(cidoc, "P132_overlaps_with") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P133_is_separated_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This symmetric property allows instances of E4 Period that do not overlap both temporally and spatially, to be related i,e. they do not share any spatio-temporal extent.
    /// This property does not imply any ordering or sequence between the two periods either spatial or temporal.
    /// </para>
    /// labels<para>is separated from</para><para>διαχωρίζεται από</para><para>est séparée de</para><para>é separado de</para><para>getrennt von</para><para>отделен от</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P133_is_separated_from">http://www.cidoc-crm.org/cidoc-crm/P133_is_separated_from</seealso>
    let P133_is_separated_from =
        Prefixed_Name(cidoc, "P133_is_separated_from") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P134_continued</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows two activities to be related where the domain is considered as an intentional continuation of the range.
    /// Used multiple times, this allows a chain of related activities to be created which follow each other in sequence.
    /// </para>
    /// labels<para>setzte sich fort in</para><para>est la suite de</para><para>continuou</para><para>continued</para><para>продолжил</para><para>συνέχισε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P134_continued">http://www.cidoc-crm.org/cidoc-crm/P134_continued</seealso>
    let P134_continued = Prefixed_Name(cidoc, "P134_continued") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P15_was_influenced_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This is a high level property, which captures the relationship between an E7 Activity and anything that may have had some bearing upon it.
    /// The property has more specific sub properties.
    /// </para>
    /// labels<para>wurde beeinflußt durch</para><para>находился под влиянием</para><para>foi influenciado por </para><para>a été influencée par</para><para>was influenced by</para><para>επηρεάστηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P15_was_influenced_by">http://www.cidoc-crm.org/cidoc-crm/P15_was_influenced_by</seealso>
    let P15_was_influenced_by =
        Prefixed_Name(cidoc, "P15_was_influenced_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P134i_was_continued_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde fortgesetzt durch</para><para>a été continuée par</para><para>foi continuada por</para><para>was continued by</para><para>συνεχίστηκε από</para><para>был продолжен</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P134i_was_continued_by">http://www.cidoc-crm.org/cidoc-crm/P134i_was_continued_by</seealso>
    let P134i_was_continued_by =
        Prefixed_Name(cidoc, "P134i_was_continued_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P15i_influenced</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>оказал влияние на</para><para>influenciou</para><para>a influencé</para><para>beeinflußte</para><para>influenced</para><para>επηρέασε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P15i_influenced">http://www.cidoc-crm.org/cidoc-crm/P15i_influenced</seealso>
    let P15i_influenced = Prefixed_Name(cidoc, "P15i_influenced") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P135_created_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E55 Type, which is created in an E83Type Creation activity.</para>
    /// labels<para>δημιούργησε τύπο</para><para>a créé le type</para><para>erschuf Typus</para><para>created type</para><para>создал тип</para><para>criou tipo</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P135_created_type">http://www.cidoc-crm.org/cidoc-crm/P135_created_type</seealso>
    let P135_created_type = Prefixed_Name(cidoc, "P135_created_type") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P94_has_created</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows a conceptual E65 Creation to be linked to the E28 Conceptual Object created by it.
    /// It represents the act of conceiving the intellectual content of the E28 Conceptual Object. It does not represent the act of creating the first physical carrier of the E28 Conceptual Object. As an example, this is the composition of a poem, not its commitment to paper.
    /// </para>
    /// labels<para>hat erschaffen</para><para>δημιούργησε</para><para>has created</para><para>создал</para><para>a créé</para><para>criou</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P94_has_created">http://www.cidoc-crm.org/cidoc-crm/P94_has_created</seealso>
    let P94_has_created = Prefixed_Name(cidoc, "P94_has_created") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P135i_was_created_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde geschaffen durch</para><para>был создан посредством</para><para>δημιουργήθηκε από</para><para>was created by</para><para>a été créé par</para><para>foi criado por</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P135i_was_created_by">http://www.cidoc-crm.org/cidoc-crm/P135i_was_created_by</seealso>
    let P135i_was_created_by =
        Prefixed_Name(cidoc, "P135i_was_created_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P94i_was_created_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был создан посредством</para><para>wurde erschaffen durch</para><para>δημιουργήθηκε από</para><para>a été créé par</para><para>foi criado por</para><para>was created by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P94i_was_created_by">http://www.cidoc-crm.org/cidoc-crm/P94i_was_created_by</seealso>
    let P94i_was_created_by =
        Prefixed_Name(cidoc, "P94i_was_created_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P136_was_based_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies one or more items that were used as evidence to declare a new E55 Type.
    /// The examination of these items is often the only objective way to understand the precise characteristics of a new Type. Such items should be deposited in a museum or similar institution for that reason. The taxonomic role renders the specific relationship of each item to the Type, such as "holotype" or "original element".
    /// </para>
    /// labels<para>stützte sich auf</para><para>s’est fondée sur</para><para>был основан на</para><para>foi baseado em</para><para>βασίστηκε σε</para><para>was based on</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P136_was_based_on">http://www.cidoc-crm.org/cidoc-crm/P136_was_based_on</seealso>
    let P136_was_based_on = Prefixed_Name(cidoc, "P136_was_based_on") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P2_has_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows sub typing of CRM entities - a form of specialisation – through the use of a terminological hierarchy, or thesaurus.
    /// The CRM is intended to focus on the high-level entities and relationships needed to describe data structures. Consequently, it does not specialise entities any further than is required for this immediate purpose. However, entities in the isA hierarchy of the CRM may by specialised into any number of sub entities, which can be defined in the E55 Type hierarchy. E51 Contact Point, for example, may be specialised into “e-mail address”, “telephone number”, “post office box”, “URL” etc. none of which figures explicitly in the CRM hierarchy. Sub typing obviously requires consistency between the meaning of the terms assigned and the more general intent of the CRM entity in question.
    /// </para>
    /// labels<para>hat den Typus</para><para>est de type</para><para>имеет тип</para><para>é do tipo</para><para>έχει τύπο</para><para>has type</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P2_has_type">http://www.cidoc-crm.org/cidoc-crm/P2_has_type</seealso>
    let P2_has_type = Prefixed_Name(cidoc, "P2_has_type") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P137i_is_exemplified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>erläutert durch Beispiel</para><para>поясняется посредством</para><para>est exemplifié par</para><para>is exemplified by</para><para>δειγματίζεται από</para><para>exemplifica</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P137i_is_exemplified_by">http://www.cidoc-crm.org/cidoc-crm/P137i_is_exemplified_by</seealso>
    let P137i_is_exemplified_by =
        Prefixed_Name(cidoc, "P137i_is_exemplified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P2i_is_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>είναι ο τύπος του/της</para><para>является типом для</para><para>est le type de</para><para>ist Typus von</para><para>é o tipo de</para><para>is type of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P2i_is_type_of">http://www.cidoc-crm.org/cidoc-crm/P2i_is_type_of</seealso>
    let P2i_is_type_of = Prefixed_Name(cidoc, "P2i_is_type_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P138_represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property establishes the relationship between an E36 Visual Item and the entity that it visually represents.
    /// Any entity may be represented visually. This property is part of the fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1 CRM Entity, which is shortcut by P62depicts (is depicted by). P138.1 mode of representation allows the nature of the representation to be refined.
    /// </para>
    /// labels<para>представляет</para><para>stellt dar</para><para>représente</para><para>representa</para><para>represents</para><para>παριστάνει</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P138_represents">http://www.cidoc-crm.org/cidoc-crm/P138_represents</seealso>
    let P138_represents = Prefixed_Name(cidoc, "P138_represents") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P138i_has_representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wird dargestellt durch</para><para>est représentée par</para><para>имеет представление</para><para>has representation</para><para>tem representação</para><para>παριστάνεται από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P138i_has_representation">http://www.cidoc-crm.org/cidoc-crm/P138i_has_representation</seealso>
    let P138i_has_representation =
        Prefixed_Name(cidoc, "P138i_has_representation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P139_has_alternative_form</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property establishes a relationship of equivalence between two instances of E41 Appellation independent from any item identified by them. It is a dynamic asymmetric relationship, where the range expresses the derivative, if such a direction can be established. Otherwise, the relationship is symmetric. The relationship is not transitive.
    /// The equivalence applies to all cases of use of an instance of E41 Appellation. Multiple names assigned to an object, which are not equivalent for all things identified with a specific instance of E41 Appellation, should be modelled as repeated values of P1 is identified by (identifies).
    /// P139.1 has type allows the type of derivation, such as “transliteration from Latin 1 to ASCII” be refined..
    /// </para>
    /// labels<para>имеет альтернативную форму</para><para>έχει εναλλακτική μορφή</para><para>tem forma alternativa</para><para>has alternative form</para><para>hat alternative Form</para><para>a pour autre forme</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P139_has_alternative_form">http://www.cidoc-crm.org/cidoc-crm/P139_has_alternative_form</seealso>
    let P139_has_alternative_form =
        Prefixed_Name(cidoc, "P139_has_alternative_form") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P13_destroyed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows specific instances of E18 Physical Thing that have been destroyed to be related to a destruction event.
    /// Destruction implies the end of an item’s life as a subject of cultural documentation – the physical matter of which the item was composed may in fact continue to exist. A destruction event may be contiguous with a Production that brings into existence a derived object composed partly of matter from the destroyed object.
    /// </para>
    /// labels<para>κατέστρεψε</para><para>уничтожил</para><para>a détruit</para><para>destroyed</para><para>zerstörte</para><para>destruiu</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P13_destroyed">http://www.cidoc-crm.org/cidoc-crm/P13_destroyed</seealso>
    let P13_destroyed = Prefixed_Name(cidoc, "P13_destroyed") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P13i_was_destroyed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был уничтожен посредством</para><para>wurde zerstört durch</para><para>a été détruite par</para><para>foi destruído por</para><para>was destroyed by</para><para>καταστράφηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P13i_was_destroyed_by">http://www.cidoc-crm.org/cidoc-crm/P13i_was_destroyed_by</seealso>
    let P13i_was_destroyed_by =
        Prefixed_Name(cidoc, "P13i_was_destroyed_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P140_assigned_attribute_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property indicates the item to which an attribute or relation is assigned. </para>
    /// labels<para>a affecté un attribut à</para><para>atribuiu atributo para</para><para>assigned attribute to</para><para>присвоил атрибут для</para><para>απέδωσε ιδιότητα σε</para><para>wies Merkmal zu</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P140_assigned_attribute_to">http://www.cidoc-crm.org/cidoc-crm/P140_assigned_attribute_to</seealso>
    let P140_assigned_attribute_to =
        Prefixed_Name(cidoc, "P140_assigned_attribute_to") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P140i_was_attributed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>bekam Merkmal zugewiesen durch</para><para>получил атрибут посредством</para><para>a reçu un attribut par</para><para>χαρακτηρίστηκε από</para><para>foi atribuído por</para><para>was attributed by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P140i_was_attributed_by">http://www.cidoc-crm.org/cidoc-crm/P140i_was_attributed_by</seealso>
    let P140i_was_attributed_by =
        Prefixed_Name(cidoc, "P140i_was_attributed_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P141i_was_assigned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был присвоен посредством</para><para>wurde zugewiesen durch</para><para>a été attribué par</para><para>foi atribuído por</para><para>was assigned by</para><para>αποδόθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P141i_was_assigned_by">http://www.cidoc-crm.org/cidoc-crm/P141i_was_assigned_by</seealso>
    let P141i_was_assigned_by =
        Prefixed_Name(cidoc, "P141i_was_assigned_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P142_used_constituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates the event of assigning an instance of E42 Identifier to an entity, with  the instances of E41 Appellation that were used as elements of the identifier.
    /// </para>
    /// labels<para>benutzte Bestandteil</para><para>used constituent</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P142_used_constituent">http://www.cidoc-crm.org/cidoc-crm/P142_used_constituent</seealso>
    let P142_used_constituent =
        Prefixed_Name(cidoc, "P142_used_constituent") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P142i_was_used_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde benutzt in</para><para>was used in</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P142i_was_used_in">http://www.cidoc-crm.org/cidoc-crm/P142i_was_used_in</seealso>
    let P142i_was_used_in = Prefixed_Name(cidoc, "P142i_was_used_in") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P143_joined</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the instance of E39 Actor that becomes member of a E74 Group in an E85 Joining.
    ///  	Joining events allow for describing people becoming members of a group with a more detailed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor, compared to the shortcut offered by P107 has current or former member (is current or former member of).
    /// </para>
    /// labels<para>verband</para><para>joined</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P143_joined">http://www.cidoc-crm.org/cidoc-crm/P143_joined</seealso>
    let P143_joined = Prefixed_Name(cidoc, "P143_joined") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P143i_was_joined_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde verbunden durch</para><para>was joined by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P143i_was_joined_by">http://www.cidoc-crm.org/cidoc-crm/P143i_was_joined_by</seealso>
    let P143i_was_joined_by =
        Prefixed_Name(cidoc, "P143i_was_joined_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P144_joined_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the instance of E74 Group of which an instance of E39 Actor becomes a member through an instance of E85 Joining.
    /// Although a Joining activity normally concerns only one instance of E74 Group, it is possible to imagine circumstances under which becoming member of one Group implies becoming member of another Group as well.
    /// Joining events allow for describing people becoming members of a group with a more detailed path from E74 Group through P144 joined with (gained member by), E85 Joining, P143 joined (was joined by) to E39 Actor, compared to the shortcut offered by P107 has current or former member (is current or former member of).
    /// The property P144.1 kind of member can be used to specify the type of membership or the role the member has in the group.
    /// </para>
    /// labels<para>joined with</para><para>verband mit</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P144_joined_with">http://www.cidoc-crm.org/cidoc-crm/P144_joined_with</seealso>
    let P144_joined_with = Prefixed_Name(cidoc, "P144_joined_with") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P144i_gained_member_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>erwarb Mitglied durch</para><para>gained member by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P144i_gained_member_by">http://www.cidoc-crm.org/cidoc-crm/P144i_gained_member_by</seealso>
    let P144i_gained_member_by =
        Prefixed_Name(cidoc, "P144i_gained_member_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P145_separated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the instance of E39 Actor that leaves an instance of E74 Group through an instance of E86 Leaving.</para>
    /// labels<para>separated</para><para>entließ</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P145_separated">http://www.cidoc-crm.org/cidoc-crm/P145_separated</seealso>
    let P145_separated = Prefixed_Name(cidoc, "P145_separated") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P145i_left_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde entlassen durch</para><para>left by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P145i_left_by">http://www.cidoc-crm.org/cidoc-crm/P145i_left_by</seealso>
    let P145i_left_by = Prefixed_Name(cidoc, "P145i_left_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P146_separated_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the instance of E74 Group an instance of E39 Actor leaves through an instance of E86 Leaving.
    /// Although a Leaving activity normally concerns only one instance of E74 Group, it is possible to imagine circumstances under which leaving one E74 Group implies leaving another E74 Group as well.
    /// </para>
    /// labels<para>separated from</para><para>entließ von</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P146_separated_from">http://www.cidoc-crm.org/cidoc-crm/P146_separated_from</seealso>
    let P146_separated_from =
        Prefixed_Name(cidoc, "P146_separated_from") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P146i_lost_member_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>verlor Mitglied durch</para><para>lost member by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P146i_lost_member_by">http://www.cidoc-crm.org/cidoc-crm/P146i_lost_member_by</seealso>
    let P146i_lost_member_by =
        Prefixed_Name(cidoc, "P146i_lost_member_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P147_curated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of E78 Collection or collections with  subject of a curation activity following some implicit or explicit curation plan.
    /// </para>
    /// labels<para>betreute kuratorisch</para><para>curated</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P147_curated">http://www.cidoc-crm.org/cidoc-crm/P147_curated</seealso>
    let P147_curated = Prefixed_Name(cidoc, "P147_curated") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P147i_was_curated_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde kuratorisch betreut durch</para><para>was curated by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P147i_was_curated_by">http://www.cidoc-crm.org/cidoc-crm/P147i_was_curated_by</seealso>
    let P147i_was_curated_by =
        Prefixed_Name(cidoc, "P147i_was_curated_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P148_has_component</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of E89 Propositional Object with a structural part of it that is by itself an instance of E89 Propositional Object.</para>
    /// labels<para>hat Bestandteil</para><para>has component</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P148_has_component">http://www.cidoc-crm.org/cidoc-crm/P148_has_component</seealso>
    let P148_has_component = Prefixed_Name(cidoc, "P148_has_component") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P148i_is_component_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ist Bestandteil von</para><para>is component of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P148i_is_component_of">http://www.cidoc-crm.org/cidoc-crm/P148i_is_component_of</seealso>
    let P148i_is_component_of =
        Prefixed_Name(cidoc, "P148i_is_component_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P149_is_identified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an instance of E28 Conceptual Object using an instance of E75 Conceptual Object Appellation.</para>
    /// labels<para>is identified by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P149_is_identified_by">http://www.cidoc-crm.org/cidoc-crm/P149_is_identified_by</seealso>
    let P149_is_identified_by =
        Prefixed_Name(cidoc, "P149_is_identified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P149i_identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>identifies</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P149i_identifies">http://www.cidoc-crm.org/cidoc-crm/P149i_identifies</seealso>
    let P149i_identifies = Prefixed_Name(cidoc, "P149i_identifies") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P17_was_motivated_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes an item or items that are regarded as a reason for carrying out the E7 Activity.
    /// For example, the discovery of a large hoard of treasure may call for a celebration, an order from head quarters can start a military manoeuvre.
    /// </para>
    /// labels<para>был обусловлен посредством</para><para>wurde angeregt durch</para><para>a été motivée par</para><para>foi motivado por</para><para>was motivated by</para><para>είχε ως αφορμή</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P17_was_motivated_by">http://www.cidoc-crm.org/cidoc-crm/P17_was_motivated_by</seealso>
    let P17_was_motivated_by =
        Prefixed_Name(cidoc, "P17_was_motivated_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P17i_motivated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ήταν αφορμή</para><para>обусловил</para><para>motivated</para><para>regte an</para><para>a motivé</para><para>motivou</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P17i_motivated">http://www.cidoc-crm.org/cidoc-crm/P17i_motivated</seealso>
    let P17i_motivated = Prefixed_Name(cidoc, "P17i_motivated") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P19_was_intended_use_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property relates an E7 Activity with objects created specifically for use in the activity.
    /// This is distinct from the intended use of an item in some general type of activity such as the book of common prayer which was intended for use in Church of England services (see P101 had as general use (was use of)).</para>
    /// labels<para>был предполагаемым использованием для</para><para>war beabsichtigteter Gebrauch von </para><para>était l'utilisation prévue de</para><para>era prevista a utilização de</para><para>ήταν προορισμένη χρήση του</para><para>was intended use of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P19_was_intended_use_of">http://www.cidoc-crm.org/cidoc-crm/P19_was_intended_use_of</seealso>
    let P19_was_intended_use_of =
        Prefixed_Name(cidoc, "P19_was_intended_use_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P19i_was_made_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde hergestellt für</para><para>a été fabriquée pour</para><para>foi feito para</para><para>был создан для</para><para>was made for</para><para>έγινε για</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P19i_was_made_for">http://www.cidoc-crm.org/cidoc-crm/P19i_was_made_for</seealso>
    let P19i_was_made_for = Prefixed_Name(cidoc, "P19i_was_made_for") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P74i_is_current_or_former_residence_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является текущим или бывшим местом жительства для</para><para>ist derzeitiger oder früherer Sitz von</para><para>is current or former residence of</para><para>είναι ή ήταν κατοικία του/της</para><para>est ou a été la résidence de</para><para>é ou foi residência de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P74i_is_current_or_former_residence_of">http://www.cidoc-crm.org/cidoc-crm/P74i_is_current_or_former_residence_of</seealso>
    let P74i_is_current_or_former_residence_of =
        Prefixed_Name(cidoc, "P74i_is_current_or_former_residence_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P75_possesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies former or current instances of E30 Rights held by an E39 Actor.</para>
    /// labels<para>est détenteur de</para><para>é detentor de</para><para>possesses</para><para>κατέχει</para><para>besitzt</para><para>владеет</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P75_possesses">http://www.cidoc-crm.org/cidoc-crm/P75_possesses</seealso>
    let P75_possesses = Prefixed_Name(cidoc, "P75_possesses") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P75i_is_possessed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>sind im Besitz von</para><para>são detidos por</para><para>is possessed by</para><para>est détenu par</para><para>κατέχεται από</para><para>принадлежит</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P75i_is_possessed_by">http://www.cidoc-crm.org/cidoc-crm/P75i_is_possessed_by</seealso>
    let P75i_is_possessed_by =
        Prefixed_Name(cidoc, "P75i_is_possessed_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P76_has_contact_point</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an E51 Contact Point of any type that provides access to an E39 Actor by any communication method, such as e-mail or fax.
    /// </para>
    /// labels<para>a pour coordonnées individuelles</para><para>έχει σημείο επικοινωνίας</para><para>possui ponto de contato</para><para>has contact point</para><para>hat Kontaktpunkt</para><para>имеет контакт</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P76_has_contact_point">http://www.cidoc-crm.org/cidoc-crm/P76_has_contact_point</seealso>
    let P76_has_contact_point =
        Prefixed_Name(cidoc, "P76_has_contact_point") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P76i_provides_access_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>permettent de contacter</para><para>предоставляет доступ к</para><para>é ponto de contado de</para><para>παρέχει πρόσβαση σε</para><para>provides access to</para><para>bietet Zugang zu</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P76i_provides_access_to">http://www.cidoc-crm.org/cidoc-crm/P76i_provides_access_to</seealso>
    let P76i_provides_access_to =
        Prefixed_Name(cidoc, "P76i_provides_access_to") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P78_is_identified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an E52 Time-Span using an E49Time Appellation.</para>
    /// labels<para>идентифицируется посредством</para><para>wird bezeichnet als</para><para>é identificado por </para><para>est identifiée par</para><para>αναγνωρίζεται ως</para><para>is identified by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P78_is_identified_by">http://www.cidoc-crm.org/cidoc-crm/P78_is_identified_by</seealso>
    let P78_is_identified_by =
        Prefixed_Name(cidoc, "P78_is_identified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P78i_identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>είναι αναγνωριστικό</para><para>идентифицирует</para><para>identifies</para><para>identifica</para><para>bezeichnet</para><para>identifie</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P78i_identifies">http://www.cidoc-crm.org/cidoc-crm/P78i_identifies</seealso>
    let P78i_identifies = Prefixed_Name(cidoc, "P78i_identifies") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P79_beginning_is_qualified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property qualifies the beginning of an E52 Time-Span in some way.
    /// The nature of the qualification may be certainty, precision, source etc.
    /// </para>
    /// labels<para>beginning is qualified by</para><para>início é qualificado por</para><para>αρχή προσδιορίζεται από</para><para>début est qualifié par</para><para>hat Anfangsbegründung</para><para>начало ограничено</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P79_beginning_is_qualified_by">http://www.cidoc-crm.org/cidoc-crm/P79_beginning_is_qualified_by</seealso>
    let P79_beginning_is_qualified_by =
        Prefixed_Name(cidoc, "P79_beginning_is_qualified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P82_at_some_time_within</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the maximum period of time within which an E52 Time-Span falls.
    /// Since Time-Spans may not have precisely known temporal extents, the CRM supports statements about the minimum and maximum temporal extents of Time-Spans. This property allows a Time-Span’s maximum temporal extent (i.e. its outer boundary) to be assigned an E61 Time Primitive value. Time Primitives are treated by the CRM as application or system specific date intervals, and are not further analysed.
    /// </para>
    /// labels<para>некоторое время в течение</para><para>irgendwann innerhalb von</para><para>at some time within</para><para>abrange no máximo</para><para>couvre au plus</para><para>κάποτε εντός</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P82_at_some_time_within">http://www.cidoc-crm.org/cidoc-crm/P82_at_some_time_within</seealso>
    let P82_at_some_time_within =
        Prefixed_Name(cidoc, "P82_at_some_time_within") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P83_had_at_least_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the minimum length of time covered by an E52 Time-Span.
    /// It allows an E52 Time-Span to be associated with an E54 Dimension representing it’s minimum duration (i.e. it’s inner boundary) independent from the actual beginning and end.
    /// </para>
    /// labels<para>имеет длительность по крайней мере больше чем</para><para>είχε ελάχιστη διάρκεια</para><para>had at least duration</para><para>hatte Mindestdauer</para><para>durou no mínimo</para><para>a duré au moins</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P83_had_at_least_duration">http://www.cidoc-crm.org/cidoc-crm/P83_had_at_least_duration</seealso>
    let P83_had_at_least_duration =
        Prefixed_Name(cidoc, "P83_had_at_least_duration") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P83i_was_minimum_duration_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был минимальной длительностью для</para><para>είναι ελάχιστη διάρκεια του/της</para><para>a été la durée minimum de</para><para>was minimum duration of</para><para>foi a duração mínima de</para><para>war Mindestdauer von</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P83i_was_minimum_duration_of">http://www.cidoc-crm.org/cidoc-crm/P83i_was_minimum_duration_of</seealso>
    let P83i_was_minimum_duration_of =
        Prefixed_Name(cidoc, "P83i_was_minimum_duration_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P84_had_at_most_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the maximum length of time covered by an E52 Time-Span.
    /// It allows an E52 Time-Span to be associated with an E54 Dimension representing it’s maximum duration (i.e. it’s outer boundary) independent from the actual beginning and end.
    /// </para>
    /// labels<para>имеет длительность меньше чем</para><para>είχε μέγιστη διάρκεια</para><para>had at most duration</para><para>hatte Höchstdauer</para><para>durou no máximo</para><para>a duré au plus</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P84_had_at_most_duration">http://www.cidoc-crm.org/cidoc-crm/P84_had_at_most_duration</seealso>
    let P84_had_at_most_duration =
        Prefixed_Name(cidoc, "P84_had_at_most_duration") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P84i_was_maximum_duration_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был максимальной длительностью для</para><para>είναι μέγιστη διάρκεια του/της</para><para>a été la durée maximum de</para><para>was maximum duration of</para><para>foi a duração máxima de</para><para>war längste Dauer von</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P84i_was_maximum_duration_of">http://www.cidoc-crm.org/cidoc-crm/P84i_was_maximum_duration_of</seealso>
    let P84i_was_maximum_duration_of =
        Prefixed_Name(cidoc, "P84i_was_maximum_duration_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P86_falls_within</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the inclusion relationship between two instances of E52 Time-Span.
    /// This property supports the notion that a Time-Span’s temporal extent falls within the temporal extent of another Time-Span. It addresses temporal containment only, and no contextual link between the two instances of Time-Span is implied.
    /// </para>
    /// labels<para>está contido em</para><para>περιέχεται σε</para><para>s’insère dans</para><para>содержится в</para><para>falls within</para><para>fällt in</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P86_falls_within">http://www.cidoc-crm.org/cidoc-crm/P86_falls_within</seealso>
    let P86_falls_within = Prefixed_Name(cidoc, "P86_falls_within") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P86i_contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>содержит</para><para>contains</para><para>περιέχει</para><para>enthält</para><para>inclut</para><para>contém</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P86i_contains">http://www.cidoc-crm.org/cidoc-crm/P86i_contains</seealso>
    let P86i_contains = Prefixed_Name(cidoc, "P86i_contains") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P87_is_identified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an E53 Place using an E44 Place Appellation.
    /// Examples of Place Appellations used to identify Places include instances of E48 Place Name, addresses, E47 Spatial Coordinates etc.
    /// </para>
    /// labels<para>идентифицируется посредством</para><para>wird bezeichnet als</para><para>é identificado por</para><para>est identifié par</para><para>is identified by</para><para>αναγνωρίζεται ως</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P87_is_identified_by">http://www.cidoc-crm.org/cidoc-crm/P87_is_identified_by</seealso>
    let P87_is_identified_by =
        Prefixed_Name(cidoc, "P87_is_identified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P87i_identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>είναι αναγνωριστικό</para><para>идентифицирует</para><para>bezeichnet</para><para>identifies</para><para>identifica</para><para>identifie</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P87i_identifies">http://www.cidoc-crm.org/cidoc-crm/P87i_identifies</seealso>
    let P87i_identifies = Prefixed_Name(cidoc, "P87i_identifies") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P88_consists_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an E53 Place that forms part of another Place.
    /// It supports the notion that a Place can be subdivided into one or more constituent parts. It implies both spatial and contextual containment relationships between the two Places.
    /// </para>
    /// labels<para>αποτελείται από</para><para>consiste de</para><para>besteht aus</para><para>consists of</para><para>сделан из</para><para>est en</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P88_consists_of">http://www.cidoc-crm.org/cidoc-crm/P88_consists_of</seealso>
    let P88_consists_of = Prefixed_Name(cidoc, "P88_consists_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P88i_forms_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>формирует часть</para><para>είναι τμήμα του</para><para>bildet Teil von</para><para>fait partie de</para><para>forms part of</para><para>faz parte de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P88i_forms_part_of">http://www.cidoc-crm.org/cidoc-crm/P88i_forms_part_of</seealso>
    let P88i_forms_part_of = Prefixed_Name(cidoc, "P88i_forms_part_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P89_falls_within</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the instances of E53 Places that fall within the area covered by another Place.
    /// It addresses spatial containment only, and no ‘whole-part’ relationship between the two places is implied.
    /// </para>
    /// labels<para>está contido em</para><para>s’insère dans</para><para>περιέχεται σε</para><para>содержится в</para><para>falls within</para><para>fällt in</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P89_falls_within">http://www.cidoc-crm.org/cidoc-crm/P89_falls_within</seealso>
    let P89_falls_within = Prefixed_Name(cidoc, "P89_falls_within") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P89i_contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>содержит</para><para>contains</para><para>περιέχει</para><para>enthält</para><para>inclut</para><para>contém</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P89i_contains">http://www.cidoc-crm.org/cidoc-crm/P89i_contains</seealso>
    let P89i_contains = Prefixed_Name(cidoc, "P89i_contains") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P8_took_place_on_or_within</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the location of an instance of E4 Period with respect to an E19 Physical Object.
    /// P8 took place on or within (witnessed) is a short-cut of a path defining a E53 Place with respect to the geometry of an object. cf. E46 Section Definition.
    /// This property is in effect a special case of P7 took place at. It describes a period that can be located with respect to the space defined by an E19 Physical Object such as a ship or a building. The precise geographical location of the object during the period in question may be unknown or unimportant.
    /// For example, the French and German armistice of 22 June 1940 was signed in the same railway carriage as the armistice of 11 November 1918.
    /// </para>
    /// labels<para>fand statt auf oder innerhalb von </para><para>took place on or within</para><para>έλαβε χώρα σε ή εντός</para><para>a eu lieu sur ou dans</para><para>ocorreu em ou dentro</para><para>имел место на или в</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P8_took_place_on_or_within">http://www.cidoc-crm.org/cidoc-crm/P8_took_place_on_or_within</seealso>
    let P8_took_place_on_or_within =
        Prefixed_Name(cidoc, "P8_took_place_on_or_within") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P91i_is_unit_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>αποτελεί μονάδα μέτρησης του/της</para><para>является единицей для</para><para>ist Einheit von</para><para>est l'unité de</para><para>é unidade de</para><para>is unit of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P91i_is_unit_of">http://www.cidoc-crm.org/cidoc-crm/P91i_is_unit_of</seealso>
    let P91i_is_unit_of = Prefixed_Name(cidoc, "P91i_is_unit_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P95_has_formed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links the founding or E66 Formation for an E74 Group with the Group itself.</para>
    /// labels<para>hat gebildet</para><para>сформировал</para><para>has formed</para><para>σχημάτισε</para><para>a fondé</para><para>formou</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P95_has_formed">http://www.cidoc-crm.org/cidoc-crm/P95_has_formed</seealso>
    let P95_has_formed = Prefixed_Name(cidoc, "P95_has_formed") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P95i_was_formed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>была сформирована посредством</para><para>wurde gebildet von</para><para>σχηματίστηκε από</para><para>a été fondé par</para><para>foi formado por</para><para>was formed by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P95i_was_formed_by">http://www.cidoc-crm.org/cidoc-crm/P95i_was_formed_by</seealso>
    let P95i_was_formed_by = Prefixed_Name(cidoc, "P95i_was_formed_by") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P96_by_mother</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links an E67 Birth event to an E21 Person as a participant in the role of birth-giving mother.
    ///
    /// Note that biological fathers are not necessarily participants in the Birth (see P97 from father (was father for)). The Person being born is linked to the Birth with the property P98 brought into life (was born). This is not intended for use with general natural history material, only people. There is no explicit method for modelling conception and gestation except by using extensions. This is a sub-property of P11 had participant (participated in).
    /// </para>
    /// labels<para>посредством матери</para><para>durch Mutter</para><para>είχε μητέρα</para><para>by mother</para><para>pela mãe</para><para>de mère</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P96_by_mother">http://www.cidoc-crm.org/cidoc-crm/P96_by_mother</seealso>
    let P96_by_mother = Prefixed_Name(cidoc, "P96_by_mother") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P96i_gave_birth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ήταν μητέρα του/της</para><para>a donné naissance à</para><para>deu nascimento</para><para>дал рождение</para><para>gave birth</para><para>gebar</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P96i_gave_birth">http://www.cidoc-crm.org/cidoc-crm/P96i_gave_birth</seealso>
    let P96i_gave_birth = Prefixed_Name(cidoc, "P96i_gave_birth") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P97_from_father</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links an E67 Birth event to an E21 Person in the role of biological father.
    /// Note that biological fathers are not seen as necessary participants in the Birth, whereas birth-giving mothers are (see P96 by mother (gave birth)). The Person being born is linked to the Birth with the property P98 brought into life (was born).
    /// This is not intended for use with general natural history material, only people. There is no explicit method for modelling conception and gestation except by using extensions.
    /// A Birth event is normally (but not always) associated with one biological father.
    /// </para>
    /// labels<para>gab Vaterschaft</para><para>from father</para><para>είχε πατέρα</para><para>pelo pai</para><para>de père</para><para>от отца</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P97_from_father">http://www.cidoc-crm.org/cidoc-crm/P97_from_father</seealso>
    let P97_from_father = Prefixed_Name(cidoc, "P97_from_father") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P97i_was_father_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ήταν πατέρας του/της</para><para>a été père dans</para><para>was father for</para><para>war Vater für</para><para>был отцом для</para><para>foi pai para</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P97i_was_father_for">http://www.cidoc-crm.org/cidoc-crm/P97i_was_father_for</seealso>
    let P97i_was_father_for =
        Prefixed_Name(cidoc, "P97i_was_father_for") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P98_brought_into_life</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links an E67Birth event to an E21 Person in the role of offspring.
    /// Twins, triplets etc. are brought into life by the same Birth event. This is not intended for use with general Natural History material, only people. There is no explicit method for modelling conception and gestation except by using extensions.
    /// </para>
    /// labels<para>brought into life</para><para>brachte zur Welt</para><para>a donné vie à</para><para>έφερε στη ζωή</para><para>trouxe à vida</para><para>породил</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P98_brought_into_life">http://www.cidoc-crm.org/cidoc-crm/P98_brought_into_life</seealso>
    let P98_brought_into_life =
        Prefixed_Name(cidoc, "P98_brought_into_life") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P98i_was_born</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wurde geboren durch</para><para>veio à vida pelo</para><para>был рожден</para><para>γεννήθηκε</para><para>was born</para><para>est né</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P98i_was_born">http://www.cidoc-crm.org/cidoc-crm/P98i_was_born</seealso>
    let P98i_was_born = Prefixed_Name(cidoc, "P98i_was_born") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P99_dissolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links the disbanding or E68 Dissolution of an E74 Group to the Group itself.</para>
    /// labels<para>dissolved</para><para>распустил</para><para>a dissous</para><para>dissolveu</para><para>löste auf</para><para>διέλυσε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P99_dissolved">http://www.cidoc-crm.org/cidoc-crm/P99_dissolved</seealso>
    let P99_dissolved = Prefixed_Name(cidoc, "P99_dissolved") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P99i_was_dissolved_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был распущен посредством</para><para>wurde aufgelöst durch</para><para>foi dissolvido por</para><para>a été dissous par</para><para>was dissolved by</para><para>διαλύθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P99i_was_dissolved_by">http://www.cidoc-crm.org/cidoc-crm/P99i_was_dissolved_by</seealso>
    let P99i_was_dissolved_by =
        Prefixed_Name(cidoc, "P99i_was_dissolved_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P9_consists_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the decomposition of an instance of E4 Period into discrete, subsidiary periods.
    /// The sub-periods into which the period is decomposed form a logical whole - although the entire picture may not be completely known - and the sub-periods are constitutive of the general period.
    /// </para>
    /// labels<para>setzt sich zusammen aus</para><para>αποτελείται από</para><para>consists of</para><para>consiste de</para><para>consiste en</para><para>состоит из</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P9_consists_of">http://www.cidoc-crm.org/cidoc-crm/P9_consists_of</seealso>
    let P9_consists_of = Prefixed_Name(cidoc, "P9_consists_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P9i_forms_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>αποτελεί μέρος του/της</para><para>формирует часть</para><para>bildet Teil von</para><para>fait partie de</para><para>forms part of</para><para>faz parte de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P9i_forms_part_of">http://www.cidoc-crm.org/cidoc-crm/P9i_forms_part_of</seealso>
    let P9i_forms_part_of = Prefixed_Name(cidoc, "P9i_forms_part_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P46_is_composed_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows instances of E18 Physical Thing to be analysed into component elements.
    /// Component elements, since they are themselves instances of E18 Physical Thing, may be further analysed into sub-components, thereby creating a hierarchy of part decomposition. An instance of E18 Physical Thing may be shared between multiple wholes, for example two buildings may share a common wall.
    /// This property is intended to describe specific components that are individually documented, rather than general aspects. Overall descriptions of the structure of an instance of E18 Physical Thing are captured by the P3 has note property.
    /// The instances of E57 Materials of which an item of E18 Physical Thing is composed should be documented using P45 consists of (is incorporated in).
    /// </para>
    /// labels<para>ist zusammengesetzt aus</para><para>αποτελείται από</para><para>est composée de</para><para>is composed of</para><para>é composto de</para><para>составлен из</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P46_is_composed_of">http://www.cidoc-crm.org/cidoc-crm/P46_is_composed_of</seealso>
    let P46_is_composed_of = Prefixed_Name(cidoc, "P46_is_composed_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E80_Part_Removal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the activities that result in an instance of E18 Physical Thing being decreased by the removal of a part.
    /// Typical scenarios include the detachment of an accessory, the removal of a component or part of a composite object, or the deaccessioning of an object from a curated E78 Collection. If the E80 Part Removal results in the total decomposition of the original object into pieces, such that the whole ceases to exist, the activity should instead be modelled as an E81 Transformation, i.e. a simultaneous destruction and production. In cases where the part removed has no discernible identity prior to its removal but does have an identity subsequent to its removal, the activity should be regarded as both E80 Part Removal and E12 Production. This class of activities forms a basis for reasoning about the history, and continuity of identity over time, of objects that are removed from other objects, such as precious gemstones being extracted from different items of jewelry, or cultural artifacts being deaccessioned from different museum collections over their lifespan.
    /// </para>
    /// labels<para>Soustraction d'élément</para><para>Remoção de Parte</para><para>Удаление Части</para><para>Αφαίρεση Μερών</para><para>Teilentfernung</para><para>Part Removal</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E80_Part_Removal">http://www.cidoc-crm.org/cidoc-crm/E80_Part_Removal</seealso>
    let E80_Part_Removal = Prefixed_Name(cidoc, "E80_Part_Removal") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E83_Type_Creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises activities formally defining new types of items.
    /// It is typically a rigorous scholarly or scientific process that ensures a type is exhaustively described and appropriately named. In some cases, particularly in archaeology and the life sciences, E83 Type Creation requires the identification of an exemplary specimen and the publication of the type definition in an appropriate scholarly forum. The activity of E83 Type Creation is central to research in the life sciences, where a type would be referred to as a “taxon,” the type description as a “protologue,” and the exemplary specimens as “orgininal element” or “holotype”.
    /// </para>
    /// labels<para>Création de type</para><para>Δημιουργία Τύπου</para><para>Criação de Tipo</para><para>Typuserfindung</para><para>Создание Типа</para><para>Type Creation</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E83_Type_Creation">http://www.cidoc-crm.org/cidoc-crm/E83_Type_Creation</seealso>
    let E83_Type_Creation = Prefixed_Name(cidoc, "E83_Type_Creation") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:E85_Joining</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the activities that result in an instance of E39 Actor becoming a member of an instance of E74 Group. This class does not imply initiative by either party.
    /// Typical scenarios include becoming a member of a social organisation, becoming employee of a company, marriage, the adoption of a child by a family and the inauguration of somebody into an official position.
    /// </para>
    /// labels<para>Beitritt</para><para>Joining</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E85_Joining">http://www.cidoc-crm.org/cidoc-crm/E85_Joining</seealso>
    let E85_Joining = Prefixed_Name(cidoc, "E85_Joining") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E87_Curation_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the activities that result in the continuity of management and the preservation and evolution of instances of E78 Collection, following an implicit or explicit curation plan.
    /// It specializes the notion of activity into the curation of a collection and allows the history of curation to be recorded.
    /// Items are accumulated and organized following criteria like subject, chronological period, material type, style of art etc. and can be added or removed from an E78 Collection for a specific purpose and/or audience. The initial aggregation of items of a collection is regarded as an instance of E12 Production Event while the activity of evolving, preserving and promoting a collection is regarded as an instance of E87 Curation Activity.
    /// </para>
    /// labels<para>Kuratorische Tätigkeit</para><para>Curation Activity</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E87_Curation_Activity">http://www.cidoc-crm.org/cidoc-crm/E87_Curation_Activity</seealso>
    let E87_Curation_Activity =
        Prefixed_Name(cidoc, "E87_Curation_Activity") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E9_Move</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises changes of the physical location of the instances of E19 Physical Object.
    /// Note, that the class E9 Move inherits the property P7 took place at (witnessed): E53 Place. This property should be used to describe the trajectory or a larger area within which a move takes place, whereas the properties P26 moved to (was destination of), P27 moved from (was origin of) describe the start and end points only. Moves may also be documented to consist of other moves (via P9 consists of (forms part of)), in order to describe intermediate stages on a trajectory. In that case, start and end points of the partial moves should match appropriately between each other and with the overall event.
    /// </para>
    /// labels<para>Objektbewegung</para><para>Déplacement</para><para>Перемещение</para><para>Μετακίνηση</para><para>Locomoção</para><para>Move</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E9_Move">http://www.cidoc-crm.org/cidoc-crm/E9_Move</seealso>
    let E9_Move = Prefixed_Name(cidoc, "E9_Move") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P93i_was_taken_out_of_existence_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>прекратил существование посредством</para><para>wurde seiner Existenz beraubt durch</para><para>was taken out of existence by</para><para>a cessé d’exister du fait de</para><para>deixou de existir</para><para>αναιρέθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P93i_was_taken_out_of_existence_by">http://www.cidoc-crm.org/cidoc-crm/P93i_was_taken_out_of_existence_by</seealso>
    let P93i_was_taken_out_of_existence_by =
        Prefixed_Name(cidoc, "P93i_was_taken_out_of_existence_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P101_had_as_general_use</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links an instance of E70 Thing to an E55 Type of usage.
    /// It allows the relationship between particular things, both physical and immaterial, and general methods and techniques of use to be documented. Thus it can be asserted that a baseball bat had a general use for sport and a specific use for threatening people during the Great Train Robbery.
    /// </para>
    /// labels<para>avait comme utilisation générale</para><para>hatte die allgemeine Verwendung</para><para>имел основное применение</para><para>είχε ως γενική χρήση</para><para>had as general use</para><para>tem como uso geral</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P101_had_as_general_use">http://www.cidoc-crm.org/cidoc-crm/P101_had_as_general_use</seealso>
    let P101_had_as_general_use =
        Prefixed_Name(cidoc, "P101_had_as_general_use") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P102_has_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the E35 Title applied to an instance of E71 Man-Made Thing. The E55 Type of Title is assigned in a sub property.
    /// The P102.1 has type property of the P102 has title (is title of) property enables the relationship between the Title and the thing to be further clarified, for example, if the Title was a given Title, a supplied Title etc.
    /// It allows any man-made material or immaterial thing to be given a Title. It is possible to imagine a Title being created without a specific object in mind.
    /// </para>
    /// labels<para>имеет заголовок</para><para>trägt den Titel</para><para>a pour titre</para><para>tem título</para><para>έχει τίτλο</para><para>has title</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P102_has_title">http://www.cidoc-crm.org/cidoc-crm/P102_has_title</seealso>
    let P102_has_title = Prefixed_Name(cidoc, "P102_has_title") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P1_is_identified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the naming or identification of any real world item by a name or any other identifier.
    /// This property is intended for identifiers in general use, which form part of the world the model intends to describe, and not merely for internal database identifiers which are specific to a technical system, unless these latter also have a more general use outside the technical context. This property includes in particular identification by mathematical expressions such as coordinate systems used for the identification of instances of E53 Place. The property does not reveal anything about when, where and by whom this identifier was used. A more detailed representation can be made using the fully developed (i.e. indirect) path through E15 Identifier Assignment.
    /// </para>
    /// labels<para>идентифицируется посредством</para><para>wird bezeichnet als</para><para>é identificado por</para><para>est identifiée par</para><para>is identified by</para><para>αναγνωρίζεται ως</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P1_is_identified_by">http://www.cidoc-crm.org/cidoc-crm/P1_is_identified_by</seealso>
    let P1_is_identified_by =
        Prefixed_Name(cidoc, "P1_is_identified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P102i_is_title_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является заголовком для</para><para>είναι τίτλος του/της</para><para>ist der Titel von</para><para>est le titre de</para><para>é título de</para><para>is title of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P102i_is_title_of">http://www.cidoc-crm.org/cidoc-crm/P102i_is_title_of</seealso>
    let P102i_is_title_of = Prefixed_Name(cidoc, "P102i_is_title_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P1i_identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>είναι αναγνωριστικό</para><para>идентифицирует</para><para>identifica</para><para>identifies</para><para>bezeichnet</para><para>identifie</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P1i_identifies">http://www.cidoc-crm.org/cidoc-crm/P1i_identifies</seealso>
    let P1i_identifies = Prefixed_Name(cidoc, "P1i_identifies") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P103_was_intended_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links an instance of E71 Man-Made Thing to an E55 Type of usage.
    /// It creates a property between specific man-made things, both physical and immaterial, to Types of intended methods and techniques of use. Note: A link between specific man-made things and a specific use activity should be expressed using P19 was intended use of (was made for).</para>
    /// labels<para>was intended for</para><para>era destinado à</para><para>был задуман для</para><para>était destiné à</para><para>προοριζόταν για</para><para>bestimmt für</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P103_was_intended_for">http://www.cidoc-crm.org/cidoc-crm/P103_was_intended_for</seealso>
    let P103_was_intended_for =
        Prefixed_Name(cidoc, "P103_was_intended_for") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P20i_was_purpose_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ήταν σκοπός του/της</para><para>era o propósito de</para><para>était le but de</para><para>was purpose of</para><para>war Zweck von</para><para>был целью для</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P20i_was_purpose_of">http://www.cidoc-crm.org/cidoc-crm/P20i_was_purpose_of</seealso>
    let P20i_was_purpose_of =
        Prefixed_Name(cidoc, "P20i_was_purpose_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P21i_was_purpose_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ήταν σκοπός του/της</para><para>era o propósito de</para><para>était le but de</para><para>was purpose of</para><para>был целью для</para><para>war Zweck von</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P21i_was_purpose_of">http://www.cidoc-crm.org/cidoc-crm/P21i_was_purpose_of</seealso>
    let P21i_was_purpose_of =
        Prefixed_Name(cidoc, "P21i_was_purpose_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P22_transferred_title_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor that acquires the legal ownership of an object as a result of an E8 Acquisition.
    /// The property will typically describe an Actor purchasing or otherwise acquiring an object from another Actor. However, title may also be acquired, without any corresponding loss of title by another Actor, through legal fieldwork such as hunting, shooting or fishing.
    /// In reality the title is either transferred to or from someone, or both.
    /// </para>
    /// labels<para>transferiu os direitos de propriedade para</para><para>a fait passer le droit de propriété à</para><para>передал право собственности</para><para>übertrug Besitztitel auf</para><para>μετεβίβασε τον τίτλο σε</para><para>transferred title to</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P22_transferred_title_to">http://www.cidoc-crm.org/cidoc-crm/P22_transferred_title_to</seealso>
    let P22_transferred_title_to =
        Prefixed_Name(cidoc, "P22_transferred_title_to") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P22i_acquired_title_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>adquiriu os direitos de propriedade por meio da</para><para>a acquis le droit de propriété du fait de</para><para>получил право собственности через</para><para>erwarb Besitztitel durch</para><para>απέκτησε τον τίτλο μέσω</para><para>acquired title through</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P22i_acquired_title_through">http://www.cidoc-crm.org/cidoc-crm/P22i_acquired_title_through</seealso>
    let P22i_acquired_title_through =
        Prefixed_Name(cidoc, "P22i_acquired_title_through") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P23_transferred_title_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor or Actors who relinquish legal ownership as the result of an E8 Acquisition.
    /// The property will typically be used to describe a person donating or selling an object to a museum. In reality title is either transferred to or from someone, or both.
    /// </para>
    /// labels<para>transferiu os direitos de propriedade de</para><para>a fait passer le droit de propriété de</para><para>передал право собственности от</para><para>μετεβίβασε τον τίτλο από</para><para>übertrug Besitztitel von</para><para>transferred title from</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P23_transferred_title_from">http://www.cidoc-crm.org/cidoc-crm/P23_transferred_title_from</seealso>
    let P23_transferred_title_from =
        Prefixed_Name(cidoc, "P23_transferred_title_from") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P23i_surrendered_title_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>perdeu os direitos de propriedade por meio da</para><para>a perdu le droit de propriété du fait de</para><para>право собственности отдано через</para><para>surrendered title through</para><para>παρέδωσε τον τίτλο μέσω</para><para>trat Besitztitel ab in</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P23i_surrendered_title_through">http://www.cidoc-crm.org/cidoc-crm/P23i_surrendered_title_through</seealso>
    let P23i_surrendered_title_through =
        Prefixed_Name(cidoc, "P23i_surrendered_title_through") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P24_transferred_title_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E18 Physical Thing or things involved in an E8 Acquisition.
    /// In reality, an acquisition must refer to at least one transferred item.
    /// </para>
    /// labels<para>transferiu os direitos de propriedade sobre o</para><para>a fait passer le droit de propriété sur</para><para>передал право собственности на</para><para>μετεβίβασε τον τίτλο του/της</para><para>übertrug Besitz über</para><para>transferred title of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P24_transferred_title_of">http://www.cidoc-crm.org/cidoc-crm/P24_transferred_title_of</seealso>
    let P24_transferred_title_of =
        Prefixed_Name(cidoc, "P24_transferred_title_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P24i_changed_ownership_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>mudou de proprietário por meio de</para><para>a changé de mains du fait de</para><para>ging über in Besitz durch</para><para>changed ownership through</para><para>сменил владельца через</para><para>άλλαξε ιδιοκτησία μέσω</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P24i_changed_ownership_through">http://www.cidoc-crm.org/cidoc-crm/P24i_changed_ownership_through</seealso>
    let P24i_changed_ownership_through =
        Prefixed_Name(cidoc, "P24i_changed_ownership_through") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P25_moved</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E19 Physical Object that is moved during a move event.
    /// The property implies the object’s passive participation. For example, Monet’s painting “Impression sunrise” was moved for the first Impressionist exhibition in 1874.
    /// In reality, a move must concern at least one object.
    /// </para>
    /// labels<para>μετεκίνησε</para><para>переместил</para><para>locomoveu</para><para>a déplacé</para><para>bewegte</para><para>moved</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P25_moved">http://www.cidoc-crm.org/cidoc-crm/P25_moved</seealso>
    let P25_moved = Prefixed_Name(cidoc, "P25_moved") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P25i_moved_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>перемещен посредством</para><para>foi locomovido por</para><para>wurde bewegt durch</para><para>a été déplacé par</para><para>μετακινήθηκε από</para><para>moved by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P25i_moved_by">http://www.cidoc-crm.org/cidoc-crm/P25i_moved_by</seealso>
    let P25i_moved_by = Prefixed_Name(cidoc, "P25i_moved_by") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P26_moved_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the destination of a E9 Move.
    /// A move will be linked to a destination, such as the move of an artefact from storage to display. A move may be linked to many terminal instances of E53 Places. In this case the move describes a distribution of a set of objects. The area of the move includes the origin, route and destination.
    /// </para>
    /// labels<para>μετακινήθηκε προς</para><para>locomoveu para</para><para>a déplacé vers</para><para>bewegte bis zu</para><para>перемещен в</para><para>moved to</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P26_moved_to">http://www.cidoc-crm.org/cidoc-crm/P26_moved_to</seealso>
    let P26_moved_to = Prefixed_Name(cidoc, "P26_moved_to") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P7_took_place_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the spatial location of an instance of E4 Period.
    /// The related E53 Place should be seen as an approximation of the geographical area within which the phenomena that characterise the period in question occurred. P7took place at (witnessed) does not convey any meaning other than spatial positioning (generally on the surface of the earth).  For example, the period “R?volution fran?aise” can be said to have taken place in “France”, the “Victorian” period, may be said to have taken place in “Britain” and its colonies, as well as other parts of Europe and north America.
    /// A period can take place at multiple locations.
    /// </para>
    /// labels<para>a eu lieu dans</para><para>fand statt in</para><para>совершался на</para><para>took place at</para><para>έλαβε χώρα σε</para><para>ocorreu em</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P7_took_place_at">http://www.cidoc-crm.org/cidoc-crm/P7_took_place_at</seealso>
    let P7_took_place_at = Prefixed_Name(cidoc, "P7_took_place_at") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P26i_was_destination_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был пунктом назначения для</para><para>a été la destination de</para><para>ήταν προορισμός του/της</para><para>was destination of</para><para>era destinação de</para><para>war Zielort von</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P26i_was_destination_of">http://www.cidoc-crm.org/cidoc-crm/P26i_was_destination_of</seealso>
    let P26i_was_destination_of =
        Prefixed_Name(cidoc, "P26i_was_destination_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P7i_witnessed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был местом совершения</para><para>υπήρξε τόπος του</para><para>a été témoin de</para><para>testemunhou</para><para>witnessed</para><para>bezeugte</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P7i_witnessed">http://www.cidoc-crm.org/cidoc-crm/P7i_witnessed</seealso>
    let P7i_witnessed = Prefixed_Name(cidoc, "P7i_witnessed") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P27_moved_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the starting E53 Place of an E9 Move.
    /// A move will be linked to an origin, such as the move of an artefact from storage to display. A move may be linked to many origins. In this case the move describes the picking up of a set of objects. The area of the move includes the origin, route and destination.
    /// </para>
    /// labels<para>μετακινήθηκε από</para><para>bewegte weg von</para><para>перемещен из</para><para>locomoveu de</para><para>a retiré de</para><para>moved from</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P27_moved_from">http://www.cidoc-crm.org/cidoc-crm/P27_moved_from</seealso>
    let P27_moved_from = Prefixed_Name(cidoc, "P27_moved_from") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P27i_was_origin_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был исходной точкой для</para><para>ήταν αφετηρία του/της</para><para>war Ausgangsort von</para><para>a été l'origine de</para><para>was origin of</para><para>era origem de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P27i_was_origin_of">http://www.cidoc-crm.org/cidoc-crm/P27i_was_origin_of</seealso>
    let P27i_was_origin_of = Prefixed_Name(cidoc, "P27i_was_origin_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P28_custody_surrendered_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor or Actors who surrender custody of an instance of E18 Physical Thing in an E10 Transfer of Custody activity.
    /// The property will typically describe an Actor surrendering custody of an object when it is handed over to someone else’s care. On occasion, physical custody may be surrendered involuntarily – through accident, loss or theft.
    /// In reality, custody is either transferred to someone or from someone, or both.
    /// </para>
    /// labels<para>changement de détenteur au détriment de</para><para>custódia concedida por</para><para>custody surrendered by</para><para>μετεβίβασε κατοχή από</para><para>übergab Gewahrsam an</para><para>опека отдана</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P28_custody_surrendered_by">http://www.cidoc-crm.org/cidoc-crm/P28_custody_surrendered_by</seealso>
    let P28_custody_surrendered_by =
        Prefixed_Name(cidoc, "P28_custody_surrendered_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P28i_surrendered_custody_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a cessé d’être détenteur à cause de</para><para>wurde Gewahrsam übergeben durch</para><para>final da custódia por meio de</para><para>surrendered custody through</para><para>παρέδωσε κατοχή μέσω</para><para>опека отдана через</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P28i_surrendered_custody_through">http://www.cidoc-crm.org/cidoc-crm/P28i_surrendered_custody_through</seealso>
    let P28i_surrendered_custody_through =
        Prefixed_Name(cidoc, "P28i_surrendered_custody_through") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P29i_received_custody_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>início da custódia por meio de</para><para>est devenu détenteur grâce à</para><para>received custody through</para><para>erhielt Gewahrsam durch</para><para>παρέλαβε κατοχή μέσω</para><para>получил опеку через</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P29i_received_custody_through">http://www.cidoc-crm.org/cidoc-crm/P29i_received_custody_through</seealso>
    let P29i_received_custody_through =
        Prefixed_Name(cidoc, "P29i_received_custody_through") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P30_transferred_custody_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an item or items of E18 Physical Thing concerned in an E10 Transfer of Custody activity.
    /// The property will typically describe the object that is handed over by an E39 Actor to another Actor’s custody. On occasion, physical custody may be transferred involuntarily or illegally – through accident, unsolicited donation, or theft.
    /// </para>
    /// labels<para>changement de détenteur concernant</para><para>μετεβίβασε κατοχή του/της/των</para><para>übertrug Gewahrsam über</para><para>transferida custódia de</para><para>transferred custody of</para><para>передало опеку на</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P30_transferred_custody_of">http://www.cidoc-crm.org/cidoc-crm/P30_transferred_custody_of</seealso>
    let P30_transferred_custody_of =
        Prefixed_Name(cidoc, "P30_transferred_custody_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P32_used_general_technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the technique that was employed in an act of modification.
    /// These techniques should be drawn from an external E55 Type hierarchy of consistent terminology of general techniques such as embroidery, oil-painting, etc. Specific techniques may be further described as instances of E29 Design or Procedure.
    /// </para>
    /// labels<para>a employé comme technique générique</para><para>benutzte das allgemeine Verfahren</para><para>χρησιμοποίησε γενική τεχνική</para><para>использовал общую технику</para><para>used general technique</para><para>usou técnica geral</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P32_used_general_technique">http://www.cidoc-crm.org/cidoc-crm/P32_used_general_technique</seealso>
    let P32_used_general_technique =
        Prefixed_Name(cidoc, "P32_used_general_technique") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P32i_was_technique_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a été la technique mise en œuvre dans</para><para>ήταν τεχνική του/της</para><para>war Verfahren von</para><para>was technique of</para><para>был техникой для</para><para>foi técnica da</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P32i_was_technique_of">http://www.cidoc-crm.org/cidoc-crm/P32i_was_technique_of</seealso>
    let P32i_was_technique_of =
        Prefixed_Name(cidoc, "P32i_was_technique_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P33_used_specific_technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies a specific instance of E29 Design or Procedure in order to carry out an instance of E7 Activity or parts of it.
    /// The property differs from P32 used general technique (was technique of) in that P33 refers to an instance of E29 Design or Procedure, which is a concrete information object in its own right rather than simply being a term or a method known by tradition.
    /// Typical examples would include intervention plans for conservation or the construction plans of a building.
    /// </para>
    /// labels<para>a employé comme technique spécifique</para><para>χρησιμοποίησε συγκεκριμένη τεχνική</para><para>benutzte das bestimmte Verfahren</para><para>использовал особую технику</para><para>usou técnica específica</para><para>used specific technique</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P33_used_specific_technique">http://www.cidoc-crm.org/cidoc-crm/P33_used_specific_technique</seealso>
    let P33_used_specific_technique =
        Prefixed_Name(cidoc, "P33_used_specific_technique") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P33i_was_used_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был использован посредством</para><para>χρησιμοποιήθηκε για</para><para>a été employée par</para><para>wurde benutzt von</para><para>foi usada por</para><para>was used by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P33i_was_used_by">http://www.cidoc-crm.org/cidoc-crm/P33i_was_used_by</seealso>
    let P33i_was_used_by = Prefixed_Name(cidoc, "P33i_was_used_by") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P34_concerned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E18 Physical Thing that was assessed during an E14 Condition Assessment activity.
    /// Conditions may be assessed either by direct observation or using recorded evidence. In the latter case the E18 Physical Thing does not need to be present or extant.
    /// </para>
    /// labels<para>interessada</para><para>αφορούσε σε</para><para>имел дело с</para><para>a concerné</para><para>concerned</para><para>betraf</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P34_concerned">http://www.cidoc-crm.org/cidoc-crm/P34_concerned</seealso>
    let P34_concerned = Prefixed_Name(cidoc, "P34_concerned") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P34i_was_assessed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>expertisé par le biais de</para><para>был оценен посредством</para><para>wurde beurteilt durch</para><para>foi avaliada por</para><para>was assessed by</para><para>εκτιμήθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P34i_was_assessed_by">http://www.cidoc-crm.org/cidoc-crm/P34i_was_assessed_by</seealso>
    let P34i_was_assessed_by =
        Prefixed_Name(cidoc, "P34i_was_assessed_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P35_has_identified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E3 Condition State that was observed in an E14 Condition Assessment activity.</para>
    /// labels<para>hat identifiziert</para><para>έχει διαπιστώσει</para><para>идентифицировал</para><para>has identified</para><para>a identifié</para><para>identificou</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P35_has_identified">http://www.cidoc-crm.org/cidoc-crm/P35_has_identified</seealso>
    let P35_has_identified = Prefixed_Name(cidoc, "P35_has_identified") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P35i_was_identified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>идентифицирован посредством</para><para>wurde identifiziert durch</para><para>έχει διαπιστωθεί από</para><para>foi identificado por</para><para>was identified by</para><para>est identifié par</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P35i_was_identified_by">http://www.cidoc-crm.org/cidoc-crm/P35i_was_identified_by</seealso>
    let P35i_was_identified_by =
        Prefixed_Name(cidoc, "P35i_was_identified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P37_assigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the identifier that was assigned to an item in an Identifier Assignment activity.
    /// The same identifier may be assigned on more than one occasion.
    /// An Identifier might be created prior to an assignment.
    /// </para>
    /// labels<para>a attribué</para><para>назначил</para><para>atribuiu</para><para>assigned</para><para>απέδωσε</para><para>wies zu</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P37_assigned">http://www.cidoc-crm.org/cidoc-crm/P37_assigned</seealso>
    let P37_assigned = Prefixed_Name(cidoc, "P37_assigned") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P37i_was_assigned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>αποδόθηκε ως ιδιότητα από</para><para>был присвоен посредством</para><para>wurde zugewiesen durch</para><para>a été attribuée par</para><para>foi atribuído por</para><para>was assigned by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P37i_was_assigned_by">http://www.cidoc-crm.org/cidoc-crm/P37i_was_assigned_by</seealso>
    let P37i_was_assigned_by =
        Prefixed_Name(cidoc, "P37i_was_assigned_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P38_deassigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the identifier that was deassigned from an instance of E1 CRM Entity.
    /// Deassignment of an identifier may be necessary when an item is taken out of an inventory, a new numbering system is introduced or items are merged or split up.
    /// The same identifier may be deassigned on more than one occasion.
    /// </para>
    /// labels<para>retirou a atribuição do</para><para> hob Zuweisung auf von</para><para>отменил назначение</para><para>a désattribué</para><para>deassigned</para><para>ακύρωσε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P38_deassigned">http://www.cidoc-crm.org/cidoc-crm/P38_deassigned</seealso>
    let P38_deassigned = Prefixed_Name(cidoc, "P38_deassigned") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P39_measured</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of E16 Measurement with the instance of E1 CRM Entity to which it applied. An instance of E1 CRM Entity may be measured more than once. Material and immaterial things and processes may be measured, e.g. the number of words in a text, or the duration of an event.
    /// </para>
    /// labels<para>measured</para><para>a mesuré</para><para>измерил</para><para>μέτρησε</para><para>vermaß</para><para>mediu</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P39_measured">http://www.cidoc-crm.org/cidoc-crm/P39_measured</seealso>
    let P39_measured = Prefixed_Name(cidoc, "P39_measured") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P39i_was_measured_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был измерен посредством</para><para>wurde vermessen durch</para><para>a été mesuré par</para><para>was measured by</para><para>foi medida por</para><para>μετρήθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P39i_was_measured_by">http://www.cidoc-crm.org/cidoc-crm/P39i_was_measured_by</seealso>
    let P39i_was_measured_by =
        Prefixed_Name(cidoc, "P39i_was_measured_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P3_has_note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property is a container for all informal descriptions about an object that have not been expressed in terms of CRM constructs.
    /// In particular it captures the characterisation of the item itself, its internal structures, appearance etc.
    /// Like property P2 has type (is type of), this property is a consequence of the restricted focus of the CRM. The aim is not to capture, in a structured form, everything that can be said about an item; indeed, the CRM formalism is not regarded as sufficient to express everything that can be said. Good practice requires use of distinct note fields for different aspects of a characterisation. The P3.1 has type property of P3 has note allows differentiation of specific notes, e.g. “construction”, “decoration” etc.
    /// An item may have many notes, but a note is attached to a specific item.
    /// </para>
    /// labels<para>имеет примечание</para><para>έχει επεξήγηση</para><para>hat Anmerkung</para><para>a pour note</para><para>tem nota</para><para>has note</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P3_has_note">http://www.cidoc-crm.org/cidoc-crm/P3_has_note</seealso>
    let P3_has_note = Prefixed_Name(cidoc, "P3_has_note") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P40_observed_dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the dimension that was observed in an E16 Measurement Event.
    /// E54 Dimension can be any quantifiable aspect of E70 Thing. Weight, image colour depth and monetary value are dimensions in this sense. One measurement activity may determine more than one dimension of one object.
    /// Dimensions may be determined either by direct observation or using recorded evidence. In the latter case the measured Thing does not need to be present or extant.
    /// Even though knowledge of the value of a dimension requires measurement, the dimension may be an object of discourse prior to, or even without, any measurement being made.
    /// </para>
    /// labels<para>a relevé comme dimension</para><para>beobachtete Dimension</para><para>verificou a dimensão</para><para>observed dimension</para><para>определил величину</para><para>παρατήρησε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P40_observed_dimension">http://www.cidoc-crm.org/cidoc-crm/P40_observed_dimension</seealso>
    let P40_observed_dimension =
        Prefixed_Name(cidoc, "P40_observed_dimension") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P41_classified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the item to which a type was assigned in an E17 Type Assignment activity.
    /// Any instance of a CRM entity may be assigned a type through type assignment. Type assignment events allow a more detailed path from E1 CRM Entity through P41 classified (was classified), E17 Type Assignment, P42 assigned (was assigned by) to E55 Type for assigning types to objects compared to the shortcut offered by P2 has type (is type of).
    /// </para>
    /// labels<para>классифицировал</para><para>klassifizierte</para><para>classificou</para><para>χαρακτήρισε</para><para>a classifié</para><para>classified</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P41_classified">http://www.cidoc-crm.org/cidoc-crm/P41_classified</seealso>
    let P41_classified = Prefixed_Name(cidoc, "P41_classified") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P41i_was_classified_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a été classifiée par le biais de</para><para>был классифицирован посредством</para><para>wurde klassifiziert durch</para><para>foi classificada por</para><para>χαρακτηρίσθηκε από</para><para>was classified by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P41i_was_classified_by">http://www.cidoc-crm.org/cidoc-crm/P41i_was_classified_by</seealso>
    let P41i_was_classified_by =
        Prefixed_Name(cidoc, "P41i_was_classified_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P42_assigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the type that was assigned to an entity by an E17 Type Assignment activity.
    /// Type assignment events allow a more detailed path from E1 CRM Entity through P41 classified (was classified by), E17 Type Assignment, P42 assigned (was assigned by) to E55 Type for assigning types to objects compared to the shortcut offered by P2 has type (is type of).
    /// For example, a fragment of an antique vessel could be assigned the type “attic red figured belly handled amphora” by expert A. The same fragment could be assigned the type “shoulder handled amphora” by expert B.
    /// A Type may be intellectually constructed independent from assigning an instance of it.
    /// </para>
    /// labels<para>απέδωσε ως ιδιότητα</para><para>a attribué</para><para>atribuiu</para><para>назначил</para><para>assigned</para><para>wies zu</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P42_assigned">http://www.cidoc-crm.org/cidoc-crm/P42_assigned</seealso>
    let P42_assigned = Prefixed_Name(cidoc, "P42_assigned") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P42i_was_assigned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>был присвоен посредством</para><para>wurde zugewiesen durch</para><para>a été attribué par</para><para>foi atribuído por</para><para>was assigned by</para><para>αποδόθηκε από</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P42i_was_assigned_by">http://www.cidoc-crm.org/cidoc-crm/P42i_was_assigned_by</seealso>
    let P42i_was_assigned_by =
        Prefixed_Name(cidoc, "P42i_was_assigned_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P43_has_dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records a E54 Dimension of some E70 Thing.
    /// It is a shortcut of the more fully developed path from E70 Thing through P39 measured (was measured by), E16 Measurement P40 observed dimension (was observed in) to E54 Dimension. It offers no information about how and when an E54 Dimension was established, nor by whom.
    /// An instance of E54 Dimension is specific to an instance of E70 Thing.
    /// </para>
    /// labels<para>a pour dimension</para><para>имеет величину</para><para>has dimension</para><para>hat Dimension</para><para>έχει μέγεθος</para><para>tem dimensão</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P43_has_dimension">http://www.cidoc-crm.org/cidoc-crm/P43_has_dimension</seealso>
    let P43_has_dimension = Prefixed_Name(cidoc, "P43_has_dimension") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P44_has_condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records an E3 Condition State for some E18 Physical Thing.
    /// It is a shortcut of the more fully developed path from E18 Physical Thing through P34 concerned (was assessed by), E14 Condition Assessment P35 has identified (was identified by) to E3 Condition State. It offers no information about how and when the E3 Condition State was established, nor by whom.
    /// An instance of Condition State is specific to an instance of Physical Thing.
    /// </para>
    /// labels<para>tem estado material </para><para>a pour état matériel</para><para>έχει κατάσταση</para><para>имеет условие</para><para>has condition</para><para>hat Zustand</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P44_has_condition">http://www.cidoc-crm.org/cidoc-crm/P44_has_condition</seealso>
    let P44_has_condition = Prefixed_Name(cidoc, "P44_has_condition") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P44i_is_condition_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является условием для</para><para>είναι κατάσταση του</para><para>estado material de</para><para>état matériel de</para><para>ist Zustand von</para><para>is condition of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P44i_is_condition_of">http://www.cidoc-crm.org/cidoc-crm/P44i_is_condition_of</seealso>
    let P44i_is_condition_of =
        Prefixed_Name(cidoc, "P44i_is_condition_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P45_consists_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the instances of E57 Materials of which an instance of E18 Physical Thing is composed.
    /// All physical things consist of physical materials. P45 consists of (is incorporated in) allows the different Materials to be recorded. P45 consists of (is incorporated in) refers here to observed Material as opposed to the consumed raw material.
    /// A Material, such as a theoretical alloy, may not have any physical instances</para>
    /// labels<para>αποτελείται από</para><para>составлен из</para><para>consiste de</para><para>consiste en</para><para>consists of</para><para>besteht aus</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P45_consists_of">http://www.cidoc-crm.org/cidoc-crm/P45_consists_of</seealso>
    let P45_consists_of = Prefixed_Name(cidoc, "P45_consists_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P45i_is_incorporated_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>είναι ενσωματωμένος/η/ο σε</para><para>is incorporated in</para><para>está presente em</para><para>ist enthalten in</para><para>est présent dans</para><para>входит в состав</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P45i_is_incorporated_in">http://www.cidoc-crm.org/cidoc-crm/P45i_is_incorporated_in</seealso>
    let P45i_is_incorporated_in =
        Prefixed_Name(cidoc, "P45i_is_incorporated_in") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P46i_forms_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>αποτελεί μέρος του/της</para><para>формирует часть</para><para>bildet Teil von</para><para>fait partie de</para><para>forms part of</para><para>faz parte de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P46i_forms_part_of">http://www.cidoc-crm.org/cidoc-crm/P46i_forms_part_of</seealso>
    let P46i_forms_part_of = Prefixed_Name(cidoc, "P46i_forms_part_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P48_has_preferred_identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the preferred E42 Identifier that was used to identify an instance of E1 CRM Entity at the time this property was recorded.
    /// More than one preferred identifier may have been assigned to an item over time.
    /// Use of this property requires an external mechanism for assigning temporal validity to the respective CRM instance.
    /// P48 has preferred identifier (is preferred identifier of), is a shortcut for the path from E1 CRM Entity through P140 assigned attribute to (was attributed by), E15 Identifier Assignment, P37 assigned (was assigned by) to E42 Identifier. The fact that an identifier is a preferred one for an organisation can be better expressed in a context independent form by assigning a suitable E55 Type to the respective instance of E15 Identifier Assignment using the P2 has type property.
    /// </para>
    /// labels<para>имеет предпочтительный идентификатор</para><para>έχει προτιμώμενο αναγνωριστικό</para><para>a pour identificateur retenu</para><para>tem identificador preferido</para><para>hat bevorzugtes Kennzeichen</para><para>has preferred identifier</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P48_has_preferred_identifier">http://www.cidoc-crm.org/cidoc-crm/P48_has_preferred_identifier</seealso>
    let P48_has_preferred_identifier =
        Prefixed_Name(cidoc, "P48_has_preferred_identifier") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P48i_is_preferred_identifier_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является предпочтительным идентификатором для</para><para>είναι προτιμώμενο αναγνωριστικό</para><para>ist bevorzugtes Kennzeichen für</para><para>é o identificador preferido de</para><para>est l’identificateur retenu de</para><para>is preferred identifier of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P48i_is_preferred_identifier_of">http://www.cidoc-crm.org/cidoc-crm/P48i_is_preferred_identifier_of</seealso>
    let P48i_is_preferred_identifier_of =
        Prefixed_Name(cidoc, "P48i_is_preferred_identifier_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P4i_is_time-span_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является временным отрезком для</para><para>είναι χρονικό διάστημα του/της</para><para>é o período de tempo de</para><para>ist Zeitspanne von</para><para>is time-span of</para><para>est la durée de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P4i_is_time-span_of">http://www.cidoc-crm.org/cidoc-crm/P4i_is_time-span_of</seealso>
    let P4i_is_time_span_of =
        Prefixed_Name(cidoc, "P4i_is_time-span_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P50_has_current_keeper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor or Actors who had custody of an instance of E18 Physical Thing at the time this property was recorded.
    /// P50 has current keeper (is current keeper of) is a shortcut for the more detailed path from E18 Physical Thing through P30 transferred custody of (custody transferred through), E10 Transfer of Custody, P29 custody received by (received custody through) to E39 Actor.
    /// </para>
    /// labels<para>est actuellement détenu par</para><para>имеет текущего смотрителя</para><para>hat derzeitigen Betreuer</para><para>είναι στην κατοχή του</para><para>has current keeper</para><para>é guardada por</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P50_has_current_keeper">http://www.cidoc-crm.org/cidoc-crm/P50_has_current_keeper</seealso>
    let P50_has_current_keeper =
        Prefixed_Name(cidoc, "P50_has_current_keeper") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P50i_is_current_keeper_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является текущим смотрителем для</para><para>ist derzeitiger Betreuer von</para><para>est actuel détenteur de</para><para>is current keeper of</para><para>é guardador de</para><para>κατέχει</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P50i_is_current_keeper_of">http://www.cidoc-crm.org/cidoc-crm/P50i_is_current_keeper_of</seealso>
    let P50i_is_current_keeper_of =
        Prefixed_Name(cidoc, "P50i_is_current_keeper_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P51_has_former_or_current_owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor that is or has been the legal owner (i.e. title holder) of an instance of E18 Physical Thing at some time.
    /// The distinction with P52 has current owner (is current owner of) is that P51 has former or current owner (is former or current owner of) does not indicate whether the specified owners are current. P51 has former or current owner (is former or current owner of) is a shortcut for the more detailed path from E18 Physical Thing through P24 transferred title of (changed ownership through), E8 Acquisition, P23 transferred title from (surrendered title through), or P22 transferred title to (acquired title through) to E39 Actor.
    /// </para>
    /// labels<para>hat früheren oder derzeitigen Besitzer </para><para>имеет бывшего или текущего владельца</para><para>has former or current owner</para><para>est ou a été possédée par</para><para>é ou foi propriedade de</para><para>έχει ή είχε ιδιοκτήτη</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P51_has_former_or_current_owner">http://www.cidoc-crm.org/cidoc-crm/P51_has_former_or_current_owner</seealso>
    let P51_has_former_or_current_owner =
        Prefixed_Name(cidoc, "P51_has_former_or_current_owner") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P51i_is_former_or_current_owner_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ist früherer oder derzeitiger Besitzer von</para><para>является бывшим или текущим владельцем для</para><para>είναι ή ήταν ιδιοκτήτης του/της</para><para>is former or current owner of</para><para>est ou a été propriétaire de</para><para>é ou foi proprietário de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P51i_is_former_or_current_owner_of">http://www.cidoc-crm.org/cidoc-crm/P51i_is_former_or_current_owner_of</seealso>
    let P51i_is_former_or_current_owner_of =
        Prefixed_Name(cidoc, "P51i_is_former_or_current_owner_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P52_has_current_owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E21 Person, E74 Group or E40 Legal Body that was the owner of an instance of E18 Physical Thing at the time this property was recorded.
    /// P52 has current owner (is current owner of) is a shortcut for the more detailed path from E18 Physical Thing through P24 transferred title of (changed ownership through), E8 Acquisition, P22 transferred title to (acquired title through) to E39 Actor, if and only if this acquisition event is the most recent.
    /// </para>
    /// labels<para>est actuellement possédée par</para><para>hat derzeitigen Besitzer</para><para>имеет текущего владельца</para><para>has current owner</para><para>é propriedade de</para><para>έχει ιδιοκτήτη</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P52_has_current_owner">http://www.cidoc-crm.org/cidoc-crm/P52_has_current_owner</seealso>
    let P52_has_current_owner =
        Prefixed_Name(cidoc, "P52_has_current_owner") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P52i_is_current_owner_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является текущим владельцем для</para><para>est le propriétaire actuel de</para><para>ist derzeitiger Besitzer von</para><para>είναι ιδιοκτήτης του</para><para>is current owner of</para><para>é proprietário de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P52i_is_current_owner_of">http://www.cidoc-crm.org/cidoc-crm/P52i_is_current_owner_of</seealso>
    let P52i_is_current_owner_of =
        Prefixed_Name(cidoc, "P52i_is_current_owner_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P53_has_former_or_current_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an instance of E53 Place to be associated as the former or current location of an instance of E18 Physical Thing.
    /// In the case of E19 Physical Objects, the property does not allow any indication of the Time-Span during which the Physical Object was located at this Place, nor if this is the current location.
    /// In the case of immobile objects, the Place would normally correspond to the Place of creation.
    /// P53 has former or current location (is former or current location of) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P25 moved (moved by), E9 Move, P26 moved to (was destination of) or P27 moved from (was origin of) to E53 Place.
    /// </para>
    /// labels<para>имеет текущее или бывшее местоположение</para><para>hat früheren oder derzeitigen Standort</para><para>has former or current location</para><para>a ou a eu pour localisation</para><para>βρίσκεται ή βρισκόταν σε</para><para>é ou foi localizada em</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P53_has_former_or_current_location">http://www.cidoc-crm.org/cidoc-crm/P53_has_former_or_current_location</seealso>
    let P53_has_former_or_current_location =
        Prefixed_Name(cidoc, "P53_has_former_or_current_location") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P53i_is_former_or_current_location_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является текущим или бывшим местоположением для</para><para>ist früherer oder derzeitiger Standort von</para><para>is former or current location of</para><para>est ou a été localisation de</para><para>é ou foi localização de</para><para>είναι ή ήταν θέση του</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P53i_is_former_or_current_location_of">http://www.cidoc-crm.org/cidoc-crm/P53i_is_former_or_current_location_of</seealso>
    let P53i_is_former_or_current_location_of =
        Prefixed_Name(cidoc, "P53i_is_former_or_current_location_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P54i_is_current_permanent_location_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>является текущим постоянным местоположением для</para><para>est actuellement localisation à demeure de</para><para>ist derzeitiger permanenter Standort von</para><para>is current permanent location of</para><para>é localização permanente de</para><para>είναι μόνιμη θέση του/της</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P54i_is_current_permanent_location_of">http://www.cidoc-crm.org/cidoc-crm/P54i_is_current_permanent_location_of</seealso>
    let P54i_is_current_permanent_location_of =
        Prefixed_Name(cidoc, "P54i_is_current_permanent_location_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P55_has_current_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the location of an E19 Physical Object at the time the property was recorded.
    /// This property is a specialisation of P53 has former or current location (is former or current location of). It indicates that the E53 Place associated with the E19 Physical Object is the current location of the object. The property does not allow any indication of how long the Object has been at the current location.
    /// P55 has current location (currently holds) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P25 moved (moved by), E9 Move P26 moved to (was destination of) to E53 Place if and only if this Move is the most recent.
    /// </para>
    /// labels<para>a pour localisation actuelle</para><para>в данный момент находится в</para><para>hat derzeitigen Standort</para><para>has current location</para><para>é localizado em</para><para>βρίσκεται σε</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P55_has_current_location">http://www.cidoc-crm.org/cidoc-crm/P55_has_current_location</seealso>
    let P55_has_current_location =
        Prefixed_Name(cidoc, "P55_has_current_location") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P55i_currently_holds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>est localisation actuelle de</para><para>в данный момент содержит</para><para>é localização atual de</para><para>currently holds</para><para>hält derzeitig</para><para>είναι θέση του</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P55i_currently_holds">http://www.cidoc-crm.org/cidoc-crm/P55i_currently_holds</seealso>
    let P55i_currently_holds =
        Prefixed_Name(cidoc, "P55i_currently_holds") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P56_bears_feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes a E26 Physical Feature found on a E19 Physical Object It does not specify the location of the feature on the object.
    /// P56 bears feature (is found on) is a shortcut. A more detailed representation can make use of the fully developed (i.e. indirect) path from E19 Physical Object through P59 has section (is located on or within), E53 Place, P53 has former or current location (is former or current location of) to E26 Physical Feature.
    /// A Physical Feature can only exist on one object. One object may bear more than one Physical Feature. An E27 Site should be considered as an E26 Physical Feature on the surface of the Earth.
    /// </para>
    /// labels<para>présente pour caractéristique</para><para>possui característica</para><para>несет признак</para><para>φέρει μόρφωμα</para><para>bears feature</para><para>trägt Merkmal</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P56_bears_feature">http://www.cidoc-crm.org/cidoc-crm/P56_bears_feature</seealso>
    let P56_bears_feature = Prefixed_Name(cidoc, "P56_bears_feature") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P56i_is_found_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wird gefunden auf</para><para>é encontrada em</para><para>se trouve sur</para><para>βρίσκεται σε</para><para>is found on</para><para>найден на</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P56i_is_found_on">http://www.cidoc-crm.org/cidoc-crm/P56i_is_found_on</seealso>
    let P56i_is_found_on = Prefixed_Name(cidoc, "P56i_is_found_on") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P57_has_number_of_parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property documents the E60 Number of parts of which an instance of E19 Physical Object is composed.
    /// This may be used as a method of checking inventory counts with regard to aggregate or collective objects. What constitutes a part or component depends on the context and requirements of the documentation. Normally, the parts documented in this way would not be considered as worthy of individual attention.
    /// For a more complete description, objects may be decomposed into their components and constituents using P46 is composed of (forms parts of) and P45 consists of (is incorporated in). This allows each element to be described individually.
    /// </para>
    /// labels<para>a pour nombre de parties</para><para>tem número de partes</para><para>has number of parts</para><para>имеет число частей</para><para>έχει αριθμό μερών</para><para>hat Anzahl Teile</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P57_has_number_of_parts">http://www.cidoc-crm.org/cidoc-crm/P57_has_number_of_parts</seealso>
    let P57_has_number_of_parts =
        Prefixed_Name(cidoc, "P57_has_number_of_parts") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P58_has_section_definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links an area (section) named by a E46 Section Definition to the instance of E18 Physical Thing upon which it is found.
    /// The CRM handles sections as locations (instances of E53 Place) within or on E18 Physical Thing that are identified by E46 Section Definitions. Sections need not be discrete and separable components or parts of an object.
    /// This is part of a more developed path from E18 Physical Thing through P58, E46 Section Definition, P87 is identified by (identifies) that allows a more precise definition of a location found on an object than the shortcut P59 has section (is located on or within).
    /// A particular instance of a Section Definition only applies to one instance of Physical Thing.</para>
    /// labels<para>a pour désignation de section</para><para>имеет определение района</para><para>hat Abschittsdefinition</para><para>tem designação de seção</para><para>has section definition</para><para>έχει ορισμό τμήματος</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P58_has_section_definition">http://www.cidoc-crm.org/cidoc-crm/P58_has_section_definition</seealso>
    let P58_has_section_definition =
        Prefixed_Name(cidoc, "P58_has_section_definition") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P58i_defines_section</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>definiert Abschitt auf oder von</para><para>définit une section de</para><para>define uma seção de</para><para>определяет район</para><para>ορίζει τμήμα σε</para><para>defines section</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P58i_defines_section">http://www.cidoc-crm.org/cidoc-crm/P58i_defines_section</seealso>
    let P58i_defines_section =
        Prefixed_Name(cidoc, "P58i_defines_section") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P5_consists_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the decomposition of an E3 Condition State into discrete, subsidiary states.
    /// It is assumed that the sub-states into which the condition state is analysed form a logical whole - although the entire story may not be completely known – and that the sub-states are in fact constitutive of the general condition state. For example, a general condition state of “in ruins” may be decomposed into the individual stages of decay</para>
    /// labels<para>αποτελείται από</para><para>consiste de</para><para>consiste en</para><para>besteht aus</para><para>consists of</para><para>состоит из</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P5_consists_of">http://www.cidoc-crm.org/cidoc-crm/P5_consists_of</seealso>
    let P5_consists_of = Prefixed_Name(cidoc, "P5_consists_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P5i_forms_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>αποτελεί μέρος του/της</para><para>формирует часть</para><para>bildet Teil von</para><para>fait partie de</para><para>forms part of</para><para>faz parte de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P5i_forms_part_of">http://www.cidoc-crm.org/cidoc-crm/P5i_forms_part_of</seealso>
    let P5i_forms_part_of = Prefixed_Name(cidoc, "P5i_forms_part_of") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P62_depicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies something that is depicted by an instance of E24 Physical Man-Made Thing.
    /// This property is a shortcut of the more fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1CRM Entity. P62.1 mode of depiction allows the nature of the depiction to be refined.
    /// </para>
    /// labels<para>απεικονίζει</para><para>описывает</para><para>bildet ab</para><para>retrata</para><para>depicts</para><para>figure</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P62_depicts">http://www.cidoc-crm.org/cidoc-crm/P62_depicts</seealso>
    let P62_depicts = Prefixed_Name(cidoc, "P62_depicts") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P62i_is_depicted_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wird abgebildet durch</para><para>описан посредством</para><para>απεικονίζεται σε</para><para>é retratada por</para><para>est figurée sur</para><para>is depicted by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P62i_is_depicted_by">http://www.cidoc-crm.org/cidoc-crm/P62i_is_depicted_by</seealso>
    let P62i_is_depicted_by =
        Prefixed_Name(cidoc, "P62i_is_depicted_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P65_shows_visual_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property documents an E36 Visual Item shown by an instance of E24 Physical Man-Made Thing.
    /// This property is similar to P62 depicts (is depicted by) in that it associates an item of E24 Physical Man-Made Thing with a visual representation. However, P65 shows visual item (is shown by) differs from the P62 depicts (is depicted by) property in that it makes no claims about what the E36 Visual Item is deemed to represent. E36 Visual Item identifies a recognisable image or visual symbol, regardless of what this image may or may not represent.
    /// For example, all recent British coins bear a portrait of Queen Elizabeth II, a fact that is correctly documented using P62 depicts (is depicted by). Different portraits have been used at different periods, however. P65 shows visual item (is shown by) can be used to refer to a particular portrait.
    /// P65 shows visual item (is shown by) may also be used for Visual Items such as signs, marks and symbols, for example the 'Maltese Cross' or the 'copyright symbol’ that have no particular representational content.
    /// This property is part of the fully developed path from E24 Physical Man-Made Thing through P65 shows visual item (is shown by), E36 Visual Item, P138 represents (has representation) to E1 CRM Entity which is shortcut by, P62 depicts (is depicted by).
    /// </para>
    /// labels<para>показывает визуальный предмет</para><para>εμφανίζει οπτικό στοιχείο</para><para>présente l'item visuel</para><para>apresenta item visual</para><para>shows visual item</para><para>zeigt Bildliches</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P65_shows_visual_item">http://www.cidoc-crm.org/cidoc-crm/P65_shows_visual_item</seealso>
    let P65_shows_visual_item =
        Prefixed_Name(cidoc, "P65_shows_visual_item") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P65i_is_shown_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>показан посредством</para><para>wird gezeigt durch</para><para>é apresentado por</para><para>est présenté par</para><para>εμφανίζεται σε</para><para>is shown by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P65i_is_shown_by">http://www.cidoc-crm.org/cidoc-crm/P65i_is_shown_by</seealso>
    let P65i_is_shown_by = Prefixed_Name(cidoc, "P65i_is_shown_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P68_foresees_use_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies an E57 Material foreseeen to be used by an E29 Design or Procedure.
    /// E29 Designs and procedures commonly foresee the use of particular E57 Materials. The fabrication of adobe bricks, for example, requires straw, clay and water. This property enables this to be documented.
    /// This property is not intended for the documentation of E57 Materials that were used on a particular occasion when an instance of E29 Design or Procedure was executed.
    /// </para>
    /// labels<para> sieht den Gebrauch vor von</para><para>utilise habituellement</para><para>συνήθως χρησιμοποιεί</para><para>normalmente emprega</para><para>обычно применяет</para><para>foresees use of</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P68_foresees_use_of">http://www.cidoc-crm.org/cidoc-crm/P68_foresees_use_of</seealso>
    let P68_foresees_use_of =
        Prefixed_Name(cidoc, "P68_foresees_use_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P68i_use_foreseen_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>vorgesehen für Gebrauch durch defined</para><para>обычно используется посредством</para><para>est habituellement utilisé par</para><para>συνήθως χρησιμοποιείται από</para><para>é empregado por</para><para>use foreseen by</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P68i_use_foreseen_by">http://www.cidoc-crm.org/cidoc-crm/P68i_use_foreseen_by</seealso>
    let P68i_use_foreseen_by =
        Prefixed_Name(cidoc, "P68i_use_foreseen_by") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P70_documents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the CRM Entities documented by instances of E31 Document.
    /// Documents may describe any conceivable entity, hence the link to the highest-level entity in the CRM hierarchy. This property is intended for cases where a reference is regarded as being of a documentary character, in the scholarly or scientific sense.
    /// </para>
    /// labels<para>документирует</para><para>τεκμηριώνει</para><para>documenta</para><para>mentionne</para><para>documents</para><para>belegt</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P70_documents">http://www.cidoc-crm.org/cidoc-crm/P70_documents</seealso>
    let P70_documents = Prefixed_Name(cidoc, "P70_documents") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P70i_is_documented_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>est mentionnée dans</para><para>τεκμηριώνεται σε</para><para>é documentado em</para><para>is documented in</para><para>документирован в</para><para>wird belegt in</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P70i_is_documented_in">http://www.cidoc-crm.org/cidoc-crm/P70i_is_documented_in</seealso>
    let P70i_is_documented_in =
        Prefixed_Name(cidoc, "P70i_is_documented_in") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P71_lists</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property documents a source E32 Authority Document for an instance of an E1 CRM Entity.
    /// </para>
    /// labels<para>περιλαμβάνει</para><para>перечисляет</para><para>définit</para><para>listet</para><para>define</para><para>lists</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P71_lists">http://www.cidoc-crm.org/cidoc-crm/P71_lists</seealso>
    let P71_lists = Prefixed_Name(cidoc, "P71_lists") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P71i_is_listed_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>wird aufgelistet in</para><para>περιλαμβάνεται σε</para><para>é definido por</para><para>est défini par</para><para>is listed in</para><para>перечислен в</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P71i_is_listed_in">http://www.cidoc-crm.org/cidoc-crm/P71i_is_listed_in</seealso>
    let P71i_is_listed_in = Prefixed_Name(cidoc, "P71i_is_listed_in") |> PrefixedName
    /// <summary>
    ///   <para>cidoc:P72_has_language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the E56 Language of an E33 Linguistic Object.
    /// Linguistic Objects are composed in one or more human Languages. This property allows these languages to be documented.
    /// </para>
    /// labels<para>est en langue</para><para>é da língua </para><para>has language</para><para>hat Sprache</para><para>έχει γλώσσα</para><para>имеет язык</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P72_has_language">http://www.cidoc-crm.org/cidoc-crm/P72_has_language</seealso>
    let P72_has_language = Prefixed_Name(cidoc, "P72_has_language") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P72i_is_language_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>είναι γλώσσα του/της</para><para>является языком для</para><para>est la langue de</para><para>ist Sprache von</para><para>is language of</para><para>é a língua de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P72i_is_language_of">http://www.cidoc-crm.org/cidoc-crm/P72i_is_language_of</seealso>
    let P72i_is_language_of =
        Prefixed_Name(cidoc, "P72i_is_language_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P73_has_translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the source and target of instances of E33Linguistic Object involved in a translation.
    /// When a Linguistic Object is translated into a new language it becomes a new Linguistic Object, despite being conceptually similar to the source object.
    /// </para>
    /// labels<para>a pour traduction</para><para>has translation</para><para>hat Übersetzung</para><para>έχει μετάφραση</para><para>имеет перевод</para><para>tem tradução</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P73_has_translation">http://www.cidoc-crm.org/cidoc-crm/P73_has_translation</seealso>
    let P73_has_translation =
        Prefixed_Name(cidoc, "P73_has_translation") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P73i_is_translation_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>είναι μετάφραση του/της</para><para>est la traduction de</para><para>ist Übersetzung von</para><para>является переводом</para><para>is translation of</para><para>é tradução de</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P73i_is_translation_of">http://www.cidoc-crm.org/cidoc-crm/P73i_is_translation_of</seealso>
    let P73i_is_translation_of =
        Prefixed_Name(cidoc, "P73i_is_translation_of") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E10_Transfer_of_Custody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises transfers of physical custody of objects between instances of E39 Actor.
    /// The recording of the donor and/or recipient is optional. It is possible that in an instance of E10 Transfer of Custody there is either no donor or no recipient. Depending on the circumstances it may describe:
    /// 1.	the beginning of custody
    /// 2.	the end of custody
    /// 3.	the transfer of custody
    /// 4.	the receipt of custody from an unknown source
    /// 5.	the declared loss of an object
    /// The distinction between the legal responsibility for custody and the actual physical possession of the object should be expressed using the property P2 has type (is type of). A specific case of transfer of custody is theft.
    /// The interpretation of the museum notion of "accession" differs between institutions. The CRM therefore models legal ownership and physical custody separately. Institutions will then model their specific notions of accession and deaccession as combinations of these.
    /// </para>
    /// labels<para>Übertragung des Gewahrsams</para><para>Transferência de Custódia</para><para>Changement de détenteur</para><para>Transfer of Custody</para><para>Μεταβίβαση  Κατοχής</para><para>Передача Опеки</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E10_Transfer_of_Custody">http://www.cidoc-crm.org/cidoc-crm/E10_Transfer_of_Custody</seealso>
    let E10_Transfer_of_Custody =
        Prefixed_Name(cidoc, "E10_Transfer_of_Custody") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:E33_Linguistic_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises identifiable expressions in natural language or languages.
    /// Instances of E33 Linguistic Object can be expressed in many ways: e.g. as written texts, recorded speech or sign language. However, the CRM treats instances of E33 Linguistic Object independently from the medium or method by which they are expressed. Expressions in formal languages, such as computer code or mathematical formulae, are not treated as instances of E33 Linguistic Object by the CRM. These should be modelled as instances of E73 Information Object.
    /// The text of an instance of E33 Linguistic Object can be documented in a note by P3 has note: E62 String
    /// </para>
    /// labels<para>Sprachlicher Gegenstand</para><para>Линвистический Объект</para><para>Γλωσσικό Αντικείμενο</para><para>Objet linguistique</para><para>Objeto Lingüístico</para><para>Linguistic Object</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/E33_Linguistic_Object">http://www.cidoc-crm.org/cidoc-crm/E33_Linguistic_Object</seealso>
    let E33_Linguistic_Object =
        Prefixed_Name(cidoc, "E33_Linguistic_Object") |> PrefixedName

    /// <summary>
    ///   <para>cidoc:P59i_is_located_on_or_within</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>está localizada sobre ou dentro de</para><para>befindet sich auf oder in</para><para>is located on or within</para><para>находится на или внутри</para><para>se situe sur ou dans</para><para>βρίσκεται σε ή εντός</para></remarks>
    /// <seealso href="http://www.cidoc-crm.org/cidoc-crm/P59i_is_located_on_or_within">http://www.cidoc-crm.org/cidoc-crm/P59i_is_located_on_or_within</seealso>
    let P59i_is_located_on_or_within =
        Prefixed_Name(cidoc, "P59i_is_located_on_or_within") |> PrefixedName
