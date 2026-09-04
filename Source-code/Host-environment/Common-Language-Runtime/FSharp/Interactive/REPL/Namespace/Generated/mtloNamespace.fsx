#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mtlo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#" "mtlo"

    /// <summary>
    ///   <para>rdfs:comment : This class comprises changes of states in cultural, social or physical systems, regardless of scale, brought about by a series or group of coherent physical, cultural, technological or legal phenomena. Such changes of state will affect instances of E77 Persistent Item or its subclasses.
    ///
    /// The distinction between an E5 Event and an E4 Period is partly a question of the scale of observation. Viewed at a coarse level of detail, an E5 Event is an ‘instantaneous’ change of state. At a fine level, the E5 Event can be analysed into its component phenomena within a space and time frame, and as such can be seen as an E4 Period. The reverse is not necessarily the case: not all instances of E4 Period give rise to a noteworthy change of state.
    ///
    /// [Scope Note for E5 Event  CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC10_Event">mtlo:BC10_Event</a>
    /// </summary>
    let BC10_Event = _prefixId.prefix "BC10_Event"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises real persons who live or are assumed to have lived</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC11_Person">mtlo:BC11_Person</a>
    /// </summary>
    let BC11_Person = _prefixId.prefix "BC11_Person"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises specific systems consisting of observable material items, biotic, abiotic elements and interactions, as well as their associated relations and qualities in space time volume. Its coherence can be defined by the types of species and the types and frequency of interactions which can be observed in a space time volume.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC12_Ecosystem">mtlo:BC12_Ecosystem</a>
    /// </summary>
    let BC12_Ecosystem = _prefixId.prefix "BC12_Ecosystem"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises any gatherings or organizations of two or more people that act collectively or in a similar way due to any form of unifying relationship. In the wider sense this class also comprises official positions which used to be regarded in certain contexts as one actor, independent of the current holder of the office, such as the president of a country.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC13_Organization">mtlo:BC13_Organization</a>
    /// </summary>
    let BC13_Organization = _prefixId.prefix "BC13_Organization"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This  class comprises   the physical environment of an ecosystem.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC14_Ecosystem_Environment">mtlo:BC14_Ecosystem_Environment</a>
    /// </summary>
    let BC14_Ecosystem_Environment = _prefixId.prefix "BC14_Ecosystem_Environment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises generic portions of the sea. A water area can be a statistical area, or an economic zone, or a geographic feature.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC15_Water_Area">mtlo:BC15_Water_Area</a>
    /// </summary>
    let BC15_Water_Area = _prefixId.prefix "BC15_Water_Area"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises discrete, identifiable man-made items that are documented as single units.
    ///
    /// These items are either intellectual products or man-made physical things, and are characterized by relative stability. They may for instance have a solid physical form, an electronic encoding, or they may be logical concepts or structures.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC16_Man-Made_thing">mtlo:BC16_Man-Made_thing</a>
    /// </summary>
    let BC16_Man_Made_thing = _prefixId.prefix "BC16_Man-Made_thing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises non-material products of our minds and other human produced data that have become objects of a discourse. The production of such information may have been supported by the use of    technical devices such as cameras or computers.
    ///
    /// Characteristically, instances of this class are created, invented or thought by someone, and then may be documented or communicated between persons. Instances of BC17 Conceptual Object have the ability to exist on more than one particular carrier at the same time, such as paper, book, electronic signals, marks, audio media, paintings, photos, human memories, etc.
    ///
    /// They cannot be destroyed. They exist as long as they can be found on at least one carrier or in at least one human memory. Their existence ends when the last carrier and the last memory are lost.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC17_Conceptual_Object">mtlo:BC17_Conceptual_Object</a>
    /// </summary>
    let BC17_Conceptual_Object = _prefixId.prefix "BC17_Conceptual_Object"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises immaterial items, including but not limited to scientific papers, plots, procedural prescriptions, algorithms, laws of physics or images that are, or represent in some sense, sets of propositions about real or imaginary things and that are documented as single units or serve as topic of discourse. This class also comprises items that are “about” something in the sense of a subject.
    /// Specific subclasses of BC8 Proposition should be used when instances of BC8 Proposition of a characteristic type such as publication, etc are used for particular objects</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC18_Proposition">mtlo:BC18_Proposition</a>
    /// </summary>
    let BC18_Proposition = _prefixId.prefix "BC18_Proposition"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises the names assigned to works, such as texts, artworks or pieces of music.
    ///
    /// Titles are proper noun phrases or verbal phrases, and should not be confused with generic object names such as “chair”, “painting” or “book” (the latter are common nouns that stand for instances of E55 Type). Titles may be assigned by the creator of the work itself, or by a social group.
    ///
    /// This class also comprises the translations of titles that are used as surrogates for the original titles in different social contexts.
    ///
    /// [Scope Note for E35 Title  CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC19_Title">mtlo:BC19_Title</a>
    /// </summary>
    let BC19_Title = _prefixId.prefix "BC19_Title"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises all objects of the MarineTLO discourse. All classes within this level of the TLO are directly or indirectly specialisations of BC1 TLO Entity</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC1_TLO_Entity">mtlo:BC1_TLO_Entity</a>
    /// </summary>
    let BC1_TLO_Entity = _prefixId.prefix "BC1_TLO_Entity"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises instances of BC3  Place  whose extent and position is defined by a BC34   Geometric Place Expression.
    /// Instances of BC20 Declarative Places may be used to approximate instances of BC3 Places or parts of them. They may as well be used to define the location and spatial extent of property rights or national borders. Example:  Coordinate information in FAO like  coordinates &lt;-40,5  -41.0999847,5 -41.9000000,5 -42.200000763,5 -……39.2000000763,5 -40.5&gt;</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC20_Declarative_Place">mtlo:BC20_Declarative_Place</a>
    /// </summary>
    let BC20_Declarative_Place = _prefixId.prefix "BC20_Declarative_Place"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises   contents of a single database table, or a single statistical data matrix, where each column of the table represents a particular variable, and each row corresponds to a given member of the dataset in question. The dataset lists values for each of the variables, such as height and weight of an object, for each member of the dataset. Each value is known as a datum. The dataset may comprise data for one or more members, corresponding to the number of rows.
    /// The term dataset may also be used more loosely, to refer to the data in a collection of closely related tables, corresponding to a particular experiment or event.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC21_Data_Set">mtlo:BC21_Data_Set</a>
    /// </summary>
    let BC21_Data_Set = _prefixId.prefix "BC21_Data_Set"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises activities of BC45 Observation (substance) where a BC8 Actor encounters an instance of BC35 Physical Thing of a kind relevant for the mission of the observation or regarded as potentially relevant for some community (identity). This observation produces knowledge about the existence of the respective thing at a particular place in or on surrounding matter. This knowledge may be new to the group of people the actor belongs to. In that case we would talk about a discovery. The observer may recognize or assign an individual identity of the thing encountered or regard only the type as noteworthy in the associated documentation or report.The encounter event supports the detection of a new  a new biological kind (“taxon”), also additional parameters may be recorded like the kind of ecosystem or what detection or catching devices have been used.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC22_Encounter_Event">mtlo:BC22_Encounter_Event</a>
    /// </summary>
    let BC22_Encounter_Event = _prefixId.prefix "BC22_Encounter_Event"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises identifiable immaterial items that can be represented as sets of bit sequences, such as data sets, e-texts, images, audio or video items, software, etc., and are documented as single units.
    /// Any aggregation of instances of BC23 Digital Object into a whole treated as single unit is also regarded as an instance of BC23 Digital Object.
    /// A BC23 Digital Object does not depend on a specific physical carrier, and it can exist on one or more carriers simultaneously.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC23_Digital_Object">mtlo:BC23_Digital_Object</a>
    /// </summary>
    let BC23_Digital_Object = _prefixId.prefix "BC23_Digital_Object"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises data repositories of a set of integrated objects in computer science sense. These objects are modeled using structures defined in database schemas. Digital store includes not only data repositories like databases, it is a more general concept that includes also flat files that can store data.
    /// A digital store may contain binary datasets: raw data, normalized data, intermediate data of processing steps, scenes composed from several datasets, presentation objects, 3D models, 2D-Images and any kind of digital document (text, multimedia). It comprises a notion of complex objects, having datasets as parts. The content of a digital store  is responsible for holding information about where data-files and their replicas can be found</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC24_Repository_Object">mtlo:BC24_Repository_Object</a>
    /// </summary>
    let BC24_Repository_Object = _prefixId.prefix "BC24_Repository_Object"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises identifiable expressions in natural language or languages.
    /// Instances of BC25 Linguistic Object can be expressed in many ways: e.g. as written texts, recorded speech or sign language.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC25_Linguistic_Object">mtlo:BC25_Linguistic_Object</a>
    /// </summary>
    let BC25_Linguistic_Object = _prefixId.prefix "BC25_Linguistic_Object"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises particular and common forms of E44 Place Appellation.
    ///
    /// Place Names may change their application over time: the name of an E53 Place may change, and a name may be reused for a different E53 Place. Instances of E48 Place Name are typically subject to place name gazetteers.
    /// [Scope Note for E48 Place Name  CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC26_Place_Name">mtlo:BC26_Place_Name</a>
    /// </summary>
    let BC26_Place_Name = _prefixId.prefix "BC26_Place_Name"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises publication work.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC27_Publication">mtlo:BC27_Publication</a>
    /// </summary>
    let BC27_Publication = _prefixId.prefix "BC27_Publication"

    /// <summary>
    ///   <para>rdfs:comment : This class compromises systems that are used to describe locations in a BC3 Place. An instance of BC29 Spatial Coordinate Reference System is composed of two parts: The first is a Coordinate System which is a set of coordinate axes with specified units of measurement and axis directions. The second part is a set of reference features at rest in the real world that relate the Coordinate System to real world locations.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC29_Spatial_Coordinate_Reference_System">mtlo:BC29_Spatial_Coordinate_Reference_System</a>
    /// </summary>
    let BC29_Spatial_Coordinate_Reference_System =
        _prefixId.prefix "BC29_Spatial_Coordinate_Reference_System"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises abstract temporal extents, in the sense of Galilean physics, having a beginning, an end and a duration. Time Span has no other semantic connotations. Time-Spans are used to define the temporal extent of   phenomena valid for a certain time.
    /// [Scope Note for E52 Time Span in CIDOC CRM version 5.1.2]
    /// Instances of BC2 Time-Span can best be considered as approximations of the actual Time-Spans of temporal entities. The properties of BC2 Time-Span are intended to allow these approximations to be expressed precisely.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC2_Time_Span">mtlo:BC2_Time_Span</a>
    /// </summary>
    let BC2_Time_Span = _prefixId.prefix "BC2_Time_Span"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises signs, either meaningful or not, or arrangements of signs following a specific syntax, that are used or can be used to refer to and identify a specific instance of some class or category within a certain context.
    /// [Scope Note for E77 Persistent Item CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC30_Appellation">mtlo:BC30_Appellation</a>
    /// </summary>
    let BC30_Appellation = _prefixId.prefix "BC30_Appellation"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises any sort of identifier characteristically used to refer to an E53 Place.
    ///
    /// Instances of E44 Place Appellation may vary in their degree of precision and their meaning may vary over time - the same instance of E44 Place Appellation may be used to refer to several places, either because of cultural shifts, or because objects used as reference points have moved around. Instances of E44 Place Appellation can be extremely varied in form: postal addresses, instances of E47 Spatial Coordinate, and parts of buildings can all be considered as instances of E44 Place Appellation.
    /// [Scope Note for E44 Place Appellation CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC31_Place_Appellation">mtlo:BC31_Place_Appellation</a>
    /// </summary>
    let BC31_Place_Appellation = _prefixId.prefix "BC31_Place_Appellation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises strings or codes assigned to instances of BC10 Persistent Item in order to identify them uniquely and permanently within the context of one or more organisations. Such codes are often known as inventory numbers, registration codes, etc. and are typically composed of alphanumeric sequences.
    /// Specific subclasses of BC4 Identifier should be used when instances of BC4 Identifier of a characteristic form or format are used for particular objects</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC32_Identifier">mtlo:BC32_Identifier</a>
    /// </summary>
    let BC32_Identifier = _prefixId.prefix "BC32_Identifier"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises the textual or numeric information required to locate specific instances of E53 Place within schemes of spatial identification.
    ///
    /// Coordinates are a specific form of E44 Place Appellation, that is, a means of referring to a particular E53 Place. Coordinates are not restricted to longitude, latitude and altitude. Any regular system of reference that maps onto an E19 Physical Object can be used to generate coordinates.
    /// [Scope Note for E47 Spatial Coordinates CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC33_Spatial_Coordinate">mtlo:BC33_Spatial_Coordinate</a>
    /// </summary>
    let BC33_Spatial_Coordinate = _prefixId.prefix "BC33_Spatial_Coordinate"

    /// <summary>
    ///   <para>rdfs:comment : This class comprises definitions of places by quantitative expressions. An instance of this class can be seen as a prescription of how to find the location meant by this expression in the real world, which is based on measuring where the quantities referred to in the expression lead to, beginning from the reference points of the respective reference system.
    /// A form of expression may be geometries or map elements defined in a  Spatial Coordinate Reference System that unambiguously identify locations in a  real world space. Other forms may refer to areas confined by imaginary lines connecting Phenomenal Places such as trees, islands, cities, mountain tops.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC34_Geometric_Place_Expression">mtlo:BC34_Geometric_Place_Expression</a>
    /// </summary>
    let BC34_Geometric_Place_Expression =
        _prefixId.prefix "BC34_Geometric_Place_Expression"

    /// <summary>
    ///   <para>rdfs:comment : This class comprises constellations of matter with a relative stability of any form sufficient to associate them with a persistent identity, such as being confined to certain extent, which (confinement) can have a relative stability of form or structure, or containing a fixed amount of matter. In particular, it comprises physical things in the narrower sense and fluid bodies. It is an abstraction of physical substance for solid and non-solid things of matter.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC35_Physical_Thing">mtlo:BC35_Physical_Thing</a>
    /// </summary>
    let BC35_Physical_Thing = _prefixId.prefix "BC35_Physical_Thing"
    /// <summary>
    ///   <para>rdfs:comment : This class refers to the abiotic components of an ecosystem. This class comprises nonliving physical components of a system, for example: rocks, soil, etc. in an environment.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC36_Abiotic_Element">mtlo:BC36_Abiotic_Element</a>
    /// </summary>
    let BC36_Abiotic_Element = _prefixId.prefix "BC36_Abiotic_Element"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises individual items of a material nature, which live, have lived or are natural products of or from living organisms.
    ///
    /// Artificial objects that incorporate biological elements, such as Victorian butterfly frames, can be documented as both instances of E20 Biological Object and E22 Man-Made Object.
    /// [Scope Note for E20 Biological Object CIDOC CRM version 5.1.2]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC37_Biological_Object">mtlo:BC37_Biological_Object</a>
    /// </summary>
    let BC37_Biological_Object = _prefixId.prefix "BC37_Biological_Object"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class refers to the biotic components of an ecosystem. This class compromises individual living things that can react to stimuli, reproduce, grow, and maintain homeostasis. It can be a virus, bacterium, protist, fungus, plant, an animal or a human being. [http://www.biology-online.org/]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC38_Biotic_Element">mtlo:BC38_Biotic_Element</a>
    /// </summary>
    let BC38_Biotic_Element = _prefixId.prefix "BC38_Biotic_Element"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises any living thing in a marine environment that can move independently and that has senses for recognizing and reacting to the environment around it.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC39_Marine_Animal">mtlo:BC39_Marine_Animal</a>
    /// </summary>
    let BC39_Marine_Animal = _prefixId.prefix "BC39_Marine_Animal"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises extents in space, in particular on the surface of the earth, in the pure sense of physics: independent from temporal phenomena and matter.
    ///
    /// The instances of E53 Place are usually determined by reference to the position of “immobile” objects such as buildings, cities, mountains, rivers, or dedicated geodetic marks. A Place can be determined by combining a frame of reference and a location with respect to this frame. It may be identified by one or more instances of E44 Place Appellation.
    ///
    ///  It is sometimes argued that instances of E53 Place are best identified by global coordinates or absolute reference systems. However, relative references are often more relevant in the context of cultural documentation and tend to be more precise. In particular, we are often interested in position in relation to large, mobile objects, such as ships. For example, the Place at which Nelson died is known with reference to a large mobile object – H.M.S Victory. A resolution of this Place in terms of absolute coordinates would require knowledge of the movements of the vessel and the precise time of death, either of which may be revised, and the result would lack historical and cultural relevance.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC3_Place">mtlo:BC3_Place</a>
    /// </summary>
    let BC3_Place = _prefixId.prefix "BC3_Place"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises man-made objects, such as a swords, and man-made features, such as rock art. No assumptions are made as to the extent of modification required to justify regarding an object as man-made. For example, a “cup and ring” carving on bedrock is regarded as instance of E24 Physical Man-Made Thing.
    ///
    /// [Scope Note for E24 Physical Man-Made Thing  CIDOC CRM version 5.1.2]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC40_Physical_Man-Made_Thing">mtlo:BC40_Physical_Man-Made_Thing</a>
    /// </summary>
    let BC40_Physical_Man_Made_Thing = _prefixId.prefix "BC40_Physical_Man-Made_Thing"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises physical objects purposely created by human activity.
    ///
    /// No assumptions are made as to the extent of modification required to justify regarding an object as man-made. For example, an inscribed piece of rock or a preserved butterfly are both regarded as instances of E22 Man-Made Object.
    ///
    /// [Scope Note for E22 Man-Made Object  CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC41_Man-Made_Object">mtlo:BC41_Man-Made_Object</a>
    /// </summary>
    let BC41_Man_Made_Object = _prefixId.prefix "BC41_Man-Made_Object"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises aggregations of instances of E18 Physical Thing that are assembled and maintained (“curated” and “preserved,” in museological terminology) by one or more instances of E39 Actor over time for a specific purpose and audience, and according to a particular collection development plan.
    ///
    /// Items may be added or removed from an E78 Collection in pursuit of this plan. This class should not be confused with the E39 Actor maintaining the E78 Collection often referred to with the name of the E78 Collection (e.g. “The Wallace Collection decided…”).
    ///
    /// Collective objects in the general sense, like a tomb full of gifts, a folder with stamps or a set of chessmen, should be documented as instances of E19 Physical Object, and not as instances of E78 Collection. This is because they form wholes either because they are physically bound together or because they are kept together for their functionality.
    ///
    ///
    /// [Scope Note for E78 Collection  CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC42_Collection">mtlo:BC42_Collection</a>
    /// </summary>
    let BC42_Collection = _prefixId.prefix "BC42_Collection"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises actions intentionally carried out by instances of E39 Actor that result in changes of state in the cultural, social, or physical systems documented.
    ///
    /// This notion includes complex, composite and long-lasting actions such as the building of a settlement or a war, as well as simple, short-lived actions such as the opening of a door.
    ///
    /// [Scope Note for E7 Activity  CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC43_Activity">mtlo:BC43_Activity</a>
    /// </summary>
    let BC43_Activity = _prefixId.prefix "BC43_Activity"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises the actions of making assertions about properties of an object or any relation between two items or concepts.
    ///
    /// This class allows the documentation of how the respective assignment came about, and whose opinion it was. All the attributes or properties assigned in such an action can also be seen as directly attached to the respective item or concept, possibly as a collection of contradictory values. All cases of properties in this model that are also described indirectly through an action are characterised as "short cuts" of this action. This redundant modelling of two alternative views is preferred because many implementations may have good reasons to model either the action or the short cut, and the relation between both alternatives can be captured by simple rules.
    ///
    /// In particular, the class describes the actions of people making propositions and statements during certain museum procedures, e.g. the person and date when a condition statement was made, an identifier was assigned, the museum object was measured, etc. Which kinds of such assignments and statements need to be documented explicitly in structures of a schema rather than free text, depends on if this information should be accessible by structured queries.
    ///
    /// [Scope Note for E13 Attribute Assignment  CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC44_Attribute_Assignment">mtlo:BC44_Attribute_Assignment</a>
    /// </summary>
    let BC44_Attribute_Assignment = _prefixId.prefix "BC44_Attribute_Assignment"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises the activity of gaining scientific knowledge about particular states of physical reality gained by empirical evidence, experiments and by measurements. We define observation in the sense of natural sciences, as a kind of human activity: at some Place and within some Time-Span, certain Physical Things and their behavior and interactions are observed, either directly by human sensory impression, or enhanced with tools and measurement devices. The output of the internal processes of measurement devices that do not require additional human interaction are in general regarded as part of the observation and not as additional inference. Manual recordings may serve as additional evidence. Measurements and witnessing of events are special cases of observations. Observations result in a belief about certain propositions. In this model, the degree of confidence in the observed properties is regarded to be “true” per default, but could be described differently by adding a property LC7 is about  to an instance of BC45  Observation, or by reification of the property O16 observed value. Primary data from measurement devices are regarded in this model to be results of observation and can be interpreted as propositions believed to be true within the (known) tolerances and degree of reliability of the device. Observations represent the transition between reality and propositions in the form of instances of a formal ontology, and can be subject to data evaluation from this point on.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC45_Observation">mtlo:BC45_Observation</a>
    /// </summary>
    let BC45_Observation = _prefixId.prefix "BC45_Observation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises activities that result in the allocation of an identifier to an instance of E1 CRM Entity. An E15 Identifier Assignment may include the creation of the identifier from multiple constituents, which themselves may be instances of E41 Appellation. The syntax and kinds of constituents to be used may be declared in a rule constituting an instance of E29 Design or Procedure.
    /// [Scope Note for E15 Identifier Assignment CIDOC CRM version 5.1.2]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC46_Identifier_Assignment">mtlo:BC46_Identifier_Assignment</a>
    /// </summary>
    let BC46_Identifier_Assignment = _prefixId.prefix "BC46_Identifier_Assignment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises distributions of form, tone and colour that may be found on surfaces such as photos, paintings, prints and sculptures or directly on electronic media.
    /// The degree to which variations in the distribution of form and colour affect the identity of an instance of BC5 Image depends on a given purpose.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC47_Image">mtlo:BC47_Image</a>
    /// </summary>
    let BC47_Image = _prefixId.prefix "BC47_Image"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises organized collections of data.   The data are typically organized to model relevant aspects of reality  , in a way that supports processes requiring this information.  This organized collection maybe digitized or not.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC48_Database">mtlo:BC48_Database</a>
    /// </summary>
    let BC48_Database = _prefixId.prefix "BC48_Database"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises all sets of phenomena, such as   Periods, Events and states, Ecosystems,   bounded in time and space.
    /// It is the social or physical coherence of these phenomena that identify a BC4 Temporal Phenomenon and not the associated spatio-temporal bounds. These bounds are   approximations of the actual process of growth, spread and retreat. Consequently, different ecosystems   can overlap and coexist in time and space, such as when a nomadic culture exists in the same area as a sedentary culture.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC4_Temporal_Phenomenon">mtlo:BC4_Temporal_Phenomenon</a>
    /// </summary>
    let BC4_Temporal_Phenomenon = _prefixId.prefix "BC4_Temporal_Phenomenon"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises items of a material nature that are units for documentation and have physical boundaries that separate them completely in an objective way from other objects.
    ///
    /// The class also includes all aggregates of objects made for functional purposes of whatever kind, independent of physical coherence, such as a set of chessmen. Typically, instances of E19 Physical Object can be moved (if not too heavy).
    ///
    /// In some contexts, such objects, except for aggregates, are also called “bona fide objects” (Smith &amp; Varzi, 2000, pp.401-420), i.e. naturally defined objects.
    ///
    /// The decision as to what is documented as a complete item, rather than by its parts or components, may be a purely administrative decision or may be a result of the order in which the item was acquired.
    /// [Scope Note for E15 Identifier Assignment CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC51_Physical_Object">mtlo:BC51_Physical_Object</a>
    /// </summary>
    let BC51_Physical_Object = _prefixId.prefix "BC51_Physical_Object"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises individuals, selected by taxonomist, which typify the described species. Type specimens are placed in museums for study by taxonomists. Often the type specimen does not represent all the variation within a species. The type specimen becomes the name bearer of the species</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC53_Specimen">mtlo:BC53_Specimen</a>
    /// </summary>
    let BC53_Specimen = _prefixId.prefix "BC53_Specimen"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises actions measuring physical properties and other values that can be determined by a systematic procedure.
    ///
    /// Examples include measuring the monetary value of a collection of coins or the running time of a specific video cassette.
    ///
    /// The E16 Measurement may use simple counting or tools, such as yardsticks or radiation detection devices. The interest is in the method and care applied, so that the reliability of the result may be judged at a later stage, or research continued on the associated documents. The date of the event is important for dimensions, which may change value over time, such as the length of an object subject to shrinkage. Details of methods and devices are best handled as free text, whereas basic techniques such as "carbon 14 dating" should be encoded using P2 has type (is type of:) E55 Type.
    /// [Scope Note for E16 Measurement  CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC54_Measurement">mtlo:BC54_Measurement</a>
    /// </summary>
    let BC54_Measurement = _prefixId.prefix "BC54_Measurement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class is a specialization of E55 Type and comprises the types of measurement units: feet, inches, centimetres, litres, lumens, etc.
    ///
    /// This type is used categorically in the model without reference to instances of it, i.e. the Model does not foresee the description of instances of instances of E58 Measurement Unit, e.g.: “instances of cm”.
    ///
    /// Système International (SI) units or internationally recognized non-SI terms should be used whenever possible. (ISO 1000:1992). Archaic Measurement Units used in historical records should be preserved.
    ///  [Scope Note for E58 Measurement Unit CIDOC CRM version 5.1.2]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC55_Measurement_Unit">mtlo:BC55_Measurement_Unit</a>
    /// </summary>
    let BC55_Measurement_Unit = _prefixId.prefix "BC55_Measurement_Unit"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises actions measuring physical properties using a digital device, that are determined by a systematic procedure and creates an instance of BC23 Digital Object.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC56_Digital_Measurement_Event">mtlo:BC56_Digital_Measurement_Event</a>
    /// </summary>
    let BC56_Digital_Measurement_Event =
        _prefixId.prefix "BC56_Digital_Measurement_Event"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class is a specialization of BC42 Collection. As reported in “Hall, M. A. (1996). On bycatches. Reviews in Fish Biology and Fisheries, 6(3), 319-352” a collection of such kind contains everything that is caught and retained in the net (or other type of gear)</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC57_Capture">mtlo:BC57_Capture</a>
    /// </summary>
    let BC57_Capture = _prefixId.prefix "BC57_Capture"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises identifiable material items such as computers, scanners, cameras, etc. that
    /// have the capability to process or produce instances of  BC51 Digital Object.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC58_Digital_Device">mtlo:BC58_Digital_Device</a>
    /// </summary>
    let BC58_Digital_Device = _prefixId.prefix "BC58_Digital_Device"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises software codes, computer programs, procedures, and functions that are used to operate a system of digital objects.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC59_Software">mtlo:BC59_Software</a>
    /// </summary>
    let BC59_Software = _prefixId.prefix "BC59_Software"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises quantifiable properties that can be measured by some calibrated means and can be approximated by values, i.e. points or regions in a mathematical or conceptual space, such as natural or real numbers, RGB values etc.
    ///
    /// An instance of E54 Dimension represents the true quantity, independent from its numerical approximation, e.g. in inches or in cm. The properties of the class E54 Dimension allow for expressing the numerical approximation of the values of an instance of E54 Dimension. If the true values belong to a non-discrete space, such as spatial distances, it is recommended to record them as approximations by intervals or regions of indeterminacy enclosing the assumed true values. For instance, a length of 5 cm may be recorded as 4.5-5.5 cm, according to the precision of the respective observation. Note, that interoperability of values described in different units depends critically on the representation as value regions.
    ///
    /// Numerical approximations in archaic instances of E58 Measurement Unit used in historical records should be preserved. Equivalents corresponding to current knowledge should be recorded as additional instances of E54 Dimension as appropriate.
    /// [Scope Note for E54 Dimension CIDOC CRM version 5.1.2</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC5_Dimension">mtlo:BC5_Dimension</a>
    /// </summary>
    let BC5_Dimension = _prefixId.prefix "BC5_Dimension"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises events by which a digital device runs a software program or a series of computing operations on a digital object as a single task, which is completely determined by its digital input, the software and the generic properties of the device.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC60_Software_Execution">mtlo:BC60_Software_Execution</a>
    /// </summary>
    let BC60_Software_Execution = _prefixId.prefix "BC60_Software_Execution"
    /// <summary>
    ///   <para>rdfs:comment : This class compromises activities of BC45 Observation   where an BC8 Actor encounters an instance of BC35 Physical Thing of a kind relevant for the mission of the observation or a biological activity such as fishing, etc. This observation produces knowledge about the existence of the respective thing at a particular place in or on surrounding matter. This knowledge may be new to the group of people the actor belongs to. In that case we would talk about a discovery. The observer may recognize or assign an individual identity of the thing encountered or regard only the type as noteworthy in the associated documentation or report.
    /// Additional parameters may be recorded like the kind of ecosystem, if the biological individual survives the observation, what detection or catching devices have been used or if the capture activity have been supported the detection of a new biological kind (“taxon”).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC61_Capture_Activity">mtlo:BC61_Capture_Activity</a>
    /// </summary>
    let BC61_Capture_Activity = _prefixId.prefix "BC61_Capture_Activity"
    /// <summary>
    ///   <para>rdfs:comment : this class comprises indicators of a species that have been calculated using a specific procedure, methods, dataset, etc. Examples:
    /// I1 Catches per Species per Ocean,
    /// I2 Catches per Species per Ocean per Fishing Gear type,
    /// I3 Catches per Species per Month per Year per Fishing Gear type,
    /// I4 Catches per Species per Month per Year per Fishing Gear type per Ocean (should be Area),
    /// I5 Catches per Species per Month per Year per Fishing Gear type per Ocean (should be Area), for biodiversity / ecological datasets (IRD+OBIS+GBIF…)</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC62_Statistic_Indicator">mtlo:BC62_Statistic_Indicator</a>
    /// </summary>
    let BC62_Statistic_Indicator = _prefixId.prefix "BC62_Statistic_Indicator"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises the assignment of attributes characterizing  a globally (world wide) amount of a species that has been landed w.r.t the method and countries only.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC63_Global_Statistic_Landing">mtlo:BC63_Global_Statistic_Landing</a>
    /// </summary>
    let BC63_Global_Statistic_Landing = _prefixId.prefix "BC63_Global_Statistic_Landing"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises documented plans for the execution of actions in order to achieve a result of a specific quality, form or contents. In particular it comprises plans for deliberate human activities that may result in the modification or production of instances of E24 Physical Thing.
    ///
    /// Instances of E29 Design or Procedure can be structured in parts and sequences or depend on others. This is modelled using P69 is associated with.
    ///
    /// Designs or procedures can be seen as one of the following:
    ///
    /// 1. schema for the activities it describes
    /// 2. A schema of the products that result from their application.
    /// 3. An independent intellectual product that may have never been applied, such as Leonardo da Vinci's famous plans for flying machines.
    /// 4. Because designs or procedures may never be applied or only partially executed, the CRM models a loose relationship between the plan and the respective product.
    /// [Scope Note for E29 Design or Procedure (CIDOC CRM)]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC64_Design_or_Procedure">mtlo:BC64_Design_or_Procedure</a>
    /// </summary>
    let BC64_Design_or_Procedure = _prefixId.prefix "BC64_Design_or_Procedure"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises items that have a persistent identity, sometimes known as “endurants” in philosophy. They can be repeatedly recognized within the duration of their existence by identity criteria rather than by continuity or observation. Persistent Items can be either physical entities, such as people, animals or things, or conceptual entities such as ideas, concepts, products of the imagination or common names.
    /// The criteria that determine the identity of an item are often difficult to establish -; the decision depends largely on the judgement of the observer. For example, a building is regarded as no longer existing if it is dismantled and the materials reused in a different configuration.
    /// [Scope Note for E77 Persistent Item CIDOC CRM version 5.1.2]
    ///
    /// On the other hand, human beings or elements of ecosystems or water areas  go through radical and profound changes during their life-span, affecting both material composition and form, yet preserve their identity by other criteria. Similarly, inanimate objects may be subject to exchange of parts and matter.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC6_Persistent_Item">mtlo:BC6_Persistent_Item</a>
    /// </summary>
    let BC6_Persistent_Item = _prefixId.prefix "BC6_Persistent_Item"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises any gatherings or organizations of two or more people that actcollectively or in a similar way due to any form of unifying relationship. In the wider sense this class also comprises official positions which used to be regarded in certain contexts as one actor, independent of the current holder of the office, such as the president of a country. A joint pseudonym (i.e., a name that seems indicative of an individual but that is actually used as a persona by two or more people) is a particular case of E74 Group.
    ///
    /// A gathering of people becomes an E74 Group when it exhibits organizational characteristics usually typified by a set of ideas or beliefs held in common, or actions performed together. These might be communication, creating some common artifact, a common purpose such as study, worship, business, sports, etc. Nationality can be modelled as membership in an E74 Group (cf. HumanML markup). Married couples and other concepts of family are regarded as particular examples of E74 Group.
    ///
    ///  [Scope Note for E74 Group (CIDOC CRM)]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC70_Group">mtlo:BC70_Group</a>
    /// </summary>
    let BC70_Group = _prefixId.prefix "BC70_Group"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises periods of continuous use of a specific instance of E41 Appellation for a particular instance of E1 CRM Entity by an E39 Actor. It includes in particular the use of the name by its carrier. Characteristically, actors performing an activity may choose a particular appellation for themselves in the context of this activity. Such cases should be modelled by additionally classifying these activities as instances of F52 Name Use Activity.
    ///
    /// [Scope Note for F52 Name Use Activity (FRBR CRM)]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC71_Name_Use_Activity">mtlo:BC71_Name_Use_Activity</a>
    /// </summary>
    let BC71_Name_Use_Activity = _prefixId.prefix "BC71_Name_Use_Activity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises 4 dimensional point sets (volumes) in physical spacetime regardless its true geometric form. They may derive their identity from being the extent of a material phenomenon or from being the interpretation of an expression defining an extent in spacetime. Intersections of instances of BC72 Spacetime Volume, Place and Timespan are also regarded as instances of BC72 Spacetime Volume.  An instance of BC72 Spacetime Volume is either contiguous or composed of a finite number of contiguous subsets. Its boundaries may be fuzzy due to the properties of the phenomena it derives from or due to the limited precision up to which defining expression can be identified with a real extent in spacetime. The duration of existence of an instance of a spacetime volume is trivially its projection on time.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC72_SpaceTime_Volume">mtlo:BC72_SpaceTime_Volume</a>
    /// </summary>
    let BC72_SpaceTime_Volume = _prefixId.prefix "BC72_SpaceTime_Volume"
    /// <summary>
    ///   <para>rdfs:comment : This general class comprises usable discrete, identifiable, instances of E77 Persistent Item that are documented as single units.
    /// [Scope Note for E70 Thing CIDOC CRM version 5.1.2]
    ///
    /// They can be either intellectual products or physical things which are constellations of matter with a relative stability of any form sufficient to associate them with a persistent identity, such as being confined to certain extent, which (confinement) can have a relative stability of form or structure, or containing a fixed amount of matter.  It is an abstraction of products of intellectual,  physical nature.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC7_Thing">mtlo:BC7_Thing</a>
    /// </summary>
    let BC7_Thing = _prefixId.prefix "BC7_Thing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises people, either individually or in groups, who have the potential to perform intentional actions for which they can be held responsible.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC8_Actor">mtlo:BC8_Actor</a>
    /// </summary>
    let BC8_Actor = _prefixId.prefix "BC8_Actor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises the behaviour and interaction of physical things, being observed through events or activities or state, either directly by human sensory impression, or enhanced with tools and measurement devices.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BC9_Observable_Entity">mtlo:BC9_Observable_Entity</a>
    /// </summary>
    let BC9_Observable_Entity = _prefixId.prefix "BC9_Observable_Entity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This metaclass comprises types of material nature items which live, have lived or are natural products of or from living organisms. Such types of material nature items includes types of plants, types of fauna(animals), types of bacteria, fungi etc.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT10_Biotic_Element_Type">mtlo:BT10_Biotic_Element_Type</a>
    /// </summary>
    let BT10_Biotic_Element_Type = _prefixId.prefix "BT10_Biotic_Element_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises types of physical objects purposely created by human activity.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT11_Equipment_Type">mtlo:BT11_Equipment_Type</a>
    /// </summary>
    let BT11_Equipment_Type = _prefixId.prefix "BT11_Equipment_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises the types of Scientific data which are produced by Scientific Activity.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT12_Scientific_Data_Type">mtlo:BT12_Scientific_Data_Type</a>
    /// </summary>
    let BT12_Scientific_Data_Type = _prefixId.prefix "BT12_Scientific_Data_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises types of file formats, physical medium, or dimensions of the resource of digital objects, corresponds to dc format of Dublin core.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT13_Digital_Object_Type">mtlo:BT13_Digital_Object_Type</a>
    /// </summary>
    let BT13_Digital_Object_Type = _prefixId.prefix "BT13_Digital_Object_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises types of Appellation that are used or can be used to identify a specific instance of some class within a certain context.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT14_Appellation_Type">mtlo:BT14_Appellation_Type</a>
    /// </summary>
    let BT14_Appellation_Type = _prefixId.prefix "BT14_Appellation_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This metaclass comprises types of intellectual or conceptual aspects of recognisable marks and images.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT16_Visual_Type">mtlo:BT16_Visual_Type</a>
    /// </summary>
    let BT16_Visual_Type = _prefixId.prefix "BT16_Visual_Type"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises  types  of actions carried out by humans that result in changes of state in ecological or physical systems.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT17_Human_Activity_Type">mtlo:BT17_Human_Activity_Type</a>
    /// </summary>
    let BT17_Human_Activity_Type = _prefixId.prefix "BT17_Human_Activity_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Kingdom.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT18_Kingdom">mtlo:BT18_Kingdom</a>
    /// </summary>
    let BT18_Kingdom = _prefixId.prefix "BT18_Kingdom"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Phylum.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT19_Phylum">mtlo:BT19_Phylum</a>
    /// </summary>
    let BT19_Phylum = _prefixId.prefix "BT19_Phylum"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises types of things in the universe of discourse of the MarineTLO.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT1_TLO_Entity_Type">mtlo:BT1_TLO_Entity_Type</a>
    /// </summary>
    let BT1_TLO_Entity_Type = _prefixId.prefix "BT1_TLO_Entity_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Subphylum.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT20_SubPhylum">mtlo:BT20_SubPhylum</a>
    /// </summary>
    let BT20_SubPhylum = _prefixId.prefix "BT20_SubPhylum"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Superclass.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT21_SuperClass">mtlo:BT21_SuperClass</a>
    /// </summary>
    let BT21_SuperClass = _prefixId.prefix "BT21_SuperClass"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Class.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT22_Class">mtlo:BT22_Class</a>
    /// </summary>
    let BT22_Class = _prefixId.prefix "BT22_Class"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Subclass.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT23_SubClass">mtlo:BT23_SubClass</a>
    /// </summary>
    let BT23_SubClass = _prefixId.prefix "BT23_SubClass"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Family.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT24_Family">mtlo:BT24_Family</a>
    /// </summary>
    let BT24_Family = _prefixId.prefix "BT24_Family"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Subfamily.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT25_SubFamily">mtlo:BT25_SubFamily</a>
    /// </summary>
    let BT25_SubFamily = _prefixId.prefix "BT25_SubFamily"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Genus.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT26_Genus">mtlo:BT26_Genus</a>
    /// </summary>
    let BT26_Genus = _prefixId.prefix "BT26_Genus"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Species.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT27_Species">mtlo:BT27_Species</a>
    /// </summary>
    let BT27_Species = _prefixId.prefix "BT27_Species"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT28_Scientific_Activity_Type">mtlo:BT28_Scientific_Activity_Type</a>
    /// </summary>
    let BT28_Scientific_Activity_Type = _prefixId.prefix "BT28_Scientific_Activity_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT29_Industrial_Activity_Type">mtlo:BT29_Industrial_Activity_Type</a>
    /// </summary>
    let BT29_Industrial_Activity_Type = _prefixId.prefix "BT29_Industrial_Activity_Type"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises all types of phenomena, such as types of Periods, Events and states, which happen over a limited extent in time.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT2_Temporal_Phenomenon_Type">mtlo:BT2_Temporal_Phenomenon_Type</a>
    /// </summary>
    let BT2_Temporal_Phenomenon_Type = _prefixId.prefix "BT2_Temporal_Phenomenon_Type"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT30_Identifier_Assignment_Type">mtlo:BT30_Identifier_Assignment_Type</a>
    /// </summary>
    let BT30_Identifier_Assignment_Type =
        _prefixId.prefix "BT30_Identifier_Assignment_Type"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This metaclass comprises types of biological parts of a biological object.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT31_Biological_Part_Time">mtlo:BT31_Biological_Part_Time</a>
    /// </summary>
    let BT31_Biological_Part_Time = _prefixId.prefix "BT31_Biological_Part_Time"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises types items that have a persistent identity, sometimes known as “endurants” in philosophy. The items of this type  can be repeatedly recognized within the duration of their existence by identity criteria rather than by continuity or observation. These can be either types of  physical entities, such as people, animals or things, or conceptual entities such as ideas, concepts, products of the imagination or common names.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT32_Persisten_Type">mtlo:BT32_Persisten_Type</a>
    /// </summary>
    let BT32_Persisten_Type = _prefixId.prefix "BT32_Persisten_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises types marine animals that have a persistent identity.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT33_Marine_Animal_Type">mtlo:BT33_Marine_Animal_Type</a>
    /// </summary>
    let BT33_Marine_Animal_Type = _prefixId.prefix "BT33_Marine_Animal_Type"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of organisms (taxa) that are classified as Order.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT34_Order">mtlo:BT34_Order</a>
    /// </summary>
    let BT34_Order = _prefixId.prefix "BT34_Order"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises any property concept that is used in scientific propositions about reality. Typically, instances of BT35 Property Type would be taken from an ontology or terminological system.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT35_Property_Type">mtlo:BT35_Property_Type</a>
    /// </summary>
    let BT35_Property_Type = _prefixId.prefix "BT35_Property_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises the natural languages in the sense of concepts, i.e. the Model does not foresee the description of instances of BT36 Language, e.g.: “instances of French”.
    ///
    /// It is recommended that internationally or nationally agreed codes and terminology are used to denote instances of BT36 Language, such as those defined in ISO 639:1988.  [CIDOC CRM].</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT36_Language">mtlo:BT36_Language</a>
    /// </summary>
    let BT36_Language = _prefixId.prefix "BT36_Language"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises types of constellations of matter with a relative stability of any form sufficient to associate them with a persistent identity, such as being confined to certain extent, having a relative stability of form or structure, or containing a fixed amount of matter. In particular, it comprises physical things in the narrower sense and fluid bodies. It is an abstraction of physical substance for solid and non-solid things of matter.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT3_Physical_Thing_Type">mtlo:BT3_Physical_Thing_Type</a>
    /// </summary>
    let BT3_Physical_Thing_Type = _prefixId.prefix "BT3_Physical_Thing_Type"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of identifiable immaterial items, such as, types of data sets, images, texts, multimedia objects, procedural prescriptions, computer program code, algorithm or mathematical formulae, that have an objectively recognizable structure and are documented as single units.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT4_Conceptual_Object_Type">mtlo:BT4_Conceptual_Object_Type</a>
    /// </summary>
    let BT4_Conceptual_Object_Type = _prefixId.prefix "BT4_Conceptual_Object_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises types of extents in space where real world phenomenon can be observed or measured.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT5_Legislative_Zone_Type">mtlo:BT5_Legislative_Zone_Type</a>
    /// </summary>
    let BT5_Legislative_Zone_Type = _prefixId.prefix "BT5_Legislative_Zone_Type"
    /// <summary>
    ///   <para>rdfs:comment : This class comprises types of actions intentionally carried out by humans that result in changes of state in the scientific, social, or physical systems documented.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT6_Human_Event_Type">mtlo:BT6_Human_Event_Type</a>
    /// </summary>
    let BT6_Human_Event_Type = _prefixId.prefix "BT6_Human_Event_Type"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of  coherent ecological phenomena bounded in time and space. The  coherence of these phenomena is given by the type of interaction characteristic for biological systems. This coherence identifies the ecosystem and not the associated spatio-temporal bounds. These bounds are a mere approximation of the actual process of growth, spread and retreat. Consequently, different ecosystems can overlap and coexist in time and space.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT7_Ecosystem_Type">mtlo:BT7_Ecosystem_Type</a>
    /// </summary>
    let BT7_Ecosystem_Type = _prefixId.prefix "BT7_Ecosystem_Type"
    /// <summary>
    ///   <para>rdfs:comment : This metaclass comprises types of abiotic components of a type of  Ecosystem.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT8_Abiotic_Element_Type">mtlo:BT8_Abiotic_Element_Type</a>
    /// </summary>
    let BT8_Abiotic_Element_Type = _prefixId.prefix "BT8_Abiotic_Element_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This class comprises types of human agents either individually or in groups, who have the potential to perform intentional actions for which they can be held responsible.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#BT9_Actor_Type">mtlo:BT9_Actor_Type</a>
    /// </summary>
    let BT9_Actor_Type = _prefixId.prefix "BT9_Actor_Type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates  a physical thing like biotic or abiotic element with the biotic element or abiotic which is part of or member.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC10_belongs_to">mtlo:LC10_belongs_to</a>
    /// </summary>
    let LC10_belongs_to = _prefixId.prefix "LC10_belongs_to"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC10_has_member">mtlo:LC10_has_member</a>
    /// </summary>
    let LC10_has_member = _prefixId.prefix "LC10_has_member"
    /// <summary>
    ///   <para>rdfs:comment : This property describes the active or passive participation of instances of E39 Actors in an E5 Event.
    ///
    /// It connects the life-line of the related E39 Actor with the E53 Place and E50 Date of the event. The property implies that the Actor was involved in the event but does not imply any causal relationship. The subject of a portrait can be said to have participated in the creation of the portrait.
    /// [Scope Note for P11 had participant (participated in) CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC11_had_participant">mtlo:LC11_had_participant</a>
    /// </summary>
    let LC11_had_participant = _prefixId.prefix "LC11_had_participant"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC11_participated_in">mtlo:LC11_participated_in</a>
    /// </summary>
    let LC11_participated_in = _prefixId.prefix "LC11_participated_in"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates the item to which an attribute or relation is assigned.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC12_assigned_attribute_to">mtlo:LC12_assigned_attribute_to</a>
    /// </summary>
    let LC12_assigned_attribute_to = _prefixId.prefix "LC12_assigned_attribute_to"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC12_was_attributed_by">mtlo:LC12_was_attributed_by</a>
    /// </summary>
    let LC12_was_attributed_by = _prefixId.prefix "LC12_was_attributed_by"
    /// <summary>
    ///   <para>rdfs:comment : This property describes the active participation of a BC8 Actor in an BC43 Activity.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC13_is_carried_out_by">mtlo:LC13_is_carried_out_by</a>
    /// </summary>
    let LC13_is_carried_out_by = _prefixId.prefix "LC13_is_carried_out_by"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC13_performed">mtlo:LC13_performed</a>
    /// </summary>
    let LC13_performed = _prefixId.prefix "LC13_performed"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property describes the spatial location of an instance of a BC4 Temporal Phenomenon.
    ///
    /// The related BC3 Place should be seen as an approximation of the geographical area within which the phenomena that characterize the period in question occurred.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC15_took_place_at">mtlo:LC15_took_place_at</a>
    /// </summary>
    let LC15_took_place_at = _prefixId.prefix "LC15_took_place_at"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC15_witnessed">mtlo:LC15_witnessed</a>
    /// </summary>
    let LC15_witnessed = _prefixId.prefix "LC15_witnessed"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC16_forms_part_of">mtlo:LC16_forms_part_of</a>
    /// </summary>
    let LC16_forms_part_of = _prefixId.prefix "LC16_forms_part_of"
    /// <summary>
    ///   <para>rdfs:comment : This property allows instances of E18 Physical Thing to be analysed into component elements.
    ///
    /// Component elements, since they are themselves instances of E18 Physical Thing, may be further analysed into sub-components, thereby creating a hierarchy of part decomposition. An instance of E18 Physical Thing may be shared between multiple wholes, for example two buildings may share a common wall.
    ///
    /// This property is intended to describe specific components that are individually documented, rather than general aspects. Overall descriptions of the structure of an instance of E18 Physical Thing are captured by the P3 has note property.
    ///
    /// The instances of E57 Materials of which an item of E18 Physical Thing is composed should be documented using P45 consists of (is incorporated in).
    ///
    /// [Scope Note for P46 is composed of (forms part of)CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC16_is_composed_of">mtlo:LC16_is_composed_of</a>
    /// </summary>
    let LC16_is_composed_of = _prefixId.prefix "LC16_is_composed_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property identifies a thing, a feature, a phenomenon or its reaction that is observed by an activity of Observation.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC17_observed">mtlo:LC17_observed</a>
    /// </summary>
    let LC17_observed = _prefixId.prefix "LC17_observed"
    let LC17_was_observed_during = _prefixId.prefix "LC17_was_observed_during"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property records a E54 Dimension of some E70 Thing.
    /// It is a shortcut of the more fully developed path from E70 Thing through P39 measured (was measured by), E16 Measurement P40 observed dimension (was observed in) to E54 Dimension. It offers no information about how and when an E54 Dimension was established, nor by whom.
    ///
    /// An instance of E54 Dimension is specific to an instance of E70 Thing.
    /// [Scope Note for P43 has dimension (is dimension of)CIDOC CRM version 5.1.2]
    /// This property records a E54 Dimension of some E70 Thing.
    /// It is a shortcut of the more fully developed path from E70 Thing through P39 measured (was measured by), E16 Measurement P40 observed dimension (was observed in) to E54 Dimension. It offers no information about how and when an E54 Dimension was established, nor by whom.
    ///
    /// An instance of E54 Dimension is specific to an instance of E70 Thing.
    /// [Scope Note for P43 has dimension (is dimension of)CIDOC CRM version 5.1.2]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC19_has_dimension">mtlo:LC19_has_dimension</a>
    /// </summary>
    let LC19_has_dimension = _prefixId.prefix "LC19_has_dimension"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC19_is_dimension_of">mtlo:LC19_is_dimension_of</a>
    /// </summary>
    let LC19_is_dimension_of = _prefixId.prefix "LC19_is_dimension_of"
    /// <summary>
    ///   <para>rdfs:comment : This property describes the naming or identification of any real world item by a name or any other identifier.
    ///
    /// This property is intended for identifiers in general use, which form part of the world the model intends to describe, and not merely for internal database identifiers which are specific to a technical system, unless these latter also have a more general use outside the technical context. This property includes in particular identification by mathematical expressions such as coordinate systems used for the identification of instances of E53 Place. The property does not reveal anything about when, where and by whom this identifier was used. A more detailed representation can be made using the fully developed (i.e. indirect) path through E15 Identifier Assignment.
    /// [Scope Note for P1 is identified by (identifies). CIDOC CRM version 5.1.2].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC1_is_identified_by">mtlo:LC1_is_identified_by</a>
    /// </summary>
    let LC1_is_identified_by = _prefixId.prefix "LC1_is_identified_by"
    /// <summary>
    ///   <para>rdfs:comment : This property allows a BC5 Dimension to be approximated by Number primitive.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC20_has_value">mtlo:LC20_has_value</a>
    /// </summary>
    let LC20_has_value = _prefixId.prefix "LC20_has_value"
    /// <summary>
    ///   <para>rdfs:comment : This property shows the type of unit a BC5 Dimension was expressed in.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC21_has_unit">mtlo:LC21_has_unit</a>
    /// </summary>
    let LC21_has_unit = _prefixId.prefix "LC21_has_unit"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC21_is_unit_of">mtlo:LC21_is_unit_of</a>
    /// </summary>
    let LC21_is_unit_of = _prefixId.prefix "LC21_is_unit_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property approximates an BC3 Place which is defined in the same reference space. The property does not state the quality or accuracy of the approximation, but states the intention to approximate the place.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC22_approximates">mtlo:LC22_approximates</a>
    /// </summary>
    let LC22_approximates = _prefixId.prefix "LC22_approximates"
    /// <summary>
    ///   <para>rdfs:comment : This property defines the coordinate reference system in terms of which a geometric place expression is formulated.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC23_is_expressed_in_terms_of">mtlo:LC23_is_expressed_in_terms_of</a>
    /// </summary>
    let LC23_is_expressed_in_terms_of = _prefixId.prefix "LC23_is_expressed_in_terms_of"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an instance of BC34 Geometric Place Expression with the instance of BC20 Declarative Place it defines. Syntactic variants or use of different scripts may result in multiple instances of BC34 Geometric Place Expression defining exactly the same place. Transformations between different reference systems in general result in new definitions of places approximating each other.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC24_defines_place">mtlo:LC24_defines_place</a>
    /// </summary>
    let LC24_defines_place = _prefixId.prefix "LC24_defines_place"
    /// <summary>
    ///   <para>rdfs:comment : This property links an area to the instance of E18 Physical Thing upon which it is found.
    ///
    /// [Scope Note for P59 has section (is located on or within)CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC27_has_section">mtlo:LC27_has_section</a>
    /// </summary>
    let LC27_has_section = _prefixId.prefix "LC27_has_section"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC27_is_located_on_or_within">mtlo:LC27_is_located_on_or_within</a>
    /// </summary>
    let LC27_is_located_on_or_within = _prefixId.prefix "LC27_is_located_on_or_within"
    /// <summary>
    ///   <para>rdfs:comment : This property records a BC5 Dimension of a BC9 Observable Entity.
    /// It is a shortcut of the more fully developed path from a BC9 Observable Entity through LC37 measured (was measured by), BC54 Measurement LC34 observed dimension (was observed in) to BC5 Dimension. It offers no information about how and when an E54 Dimension was established.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC28_has_dimension">mtlo:LC28_has_dimension</a>
    /// </summary>
    let LC28_has_dimension = _prefixId.prefix "LC28_has_dimension"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of BC56 Digital Measurement  Event with an instance of BC23 Digital Object which is the output of the activity.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC29_had_output">mtlo:LC29_had_output</a>
    /// </summary>
    let LC29_had_output = _prefixId.prefix "LC29_had_output"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC2_is_referred_by">mtlo:LC2_is_referred_by</a>
    /// </summary>
    let LC2_is_referred_by = _prefixId.prefix "LC2_is_referred_by"
    /// <summary>
    ///   <para>rdfs:comment : This property documents that a BC18 Proposition makes a statement about an instance of BC1 TLO Entity.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC2_refers_to">mtlo:LC2_refers_to</a>
    /// </summary>
    let LC2_refers_to = _prefixId.prefix "LC2_refers_to"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of BC56 Digital Measurement  Event with an instance of BC23 Digital Object which is the input used to specify the machine action.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC30_had_input">mtlo:LC30_had_input</a>
    /// </summary>
    let LC30_had_input = _prefixId.prefix "LC30_had_input"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an instance of BC56 Digital Measurement  Event with the instance of BC59 Software.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC31_used_software">mtlo:LC31_used_software</a>
    /// </summary>
    let LC31_used_software = _prefixId.prefix "LC31_used_software"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an instance of BC56 Digital Measurement  Event with the instance of BC58 Digital Device that had used.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC32_happened_on_device">mtlo:LC32_happened_on_device</a>
    /// </summary>
    let LC32_happened_on_device = _prefixId.prefix "LC32_happened_on_device"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of BC61 Capture Activity with the instance of BC57 Capture.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC33_captures">mtlo:LC33_captures</a>
    /// </summary>
    let LC33_captures = _prefixId.prefix "LC33_captures"
    /// <summary>
    ///   <para>rdfs:comment : This property records the dimension that was observed in an E16 Measurement Event.
    /// E54 Dimension can be any quantifiable aspect of E70 Thing. Weight, image colour depth and monetary value are dimensions in this sense. One measurement activity may determine more than one dimension of one object.
    /// Dimensions may be determined either by direct observation or using recorded evidence. In the latter case the measured Thing does not need to be present or extant. [Scope Note for P40 observed dimension (was observed in)CIDOC CRM version 5.1.2].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC34_observed_dimension">mtlo:LC34_observed_dimension</a>
    /// </summary>
    let LC34_observed_dimension = _prefixId.prefix "LC34_observed_dimension"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an instance of SP4 Spatial Coordinate Reference System with the instance of SP3 Reference Space for which it can be used to describe locations. [Scope Note for Q7 Describes CRMgeo].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC35_describes">mtlo:LC35_describes</a>
    /// </summary>
    let LC35_describes = _prefixId.prefix "LC35_describes"
    /// <summary>
    ///   <para>rdfs:comment : This property defines the physical reference features that ground a spatial coordinate reference system in the real world.  [Scope Note for Q8 is fixed on CRMgeo].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC36_is_fixed_on">mtlo:LC36_is_fixed_on</a>
    /// </summary>
    let LC36_is_fixed_on = _prefixId.prefix "LC36_is_fixed_on"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of E16 Measurement with the instance of E1 CRM Entity to which it applied. An instance of E1 CRM Entity may be measured more than once. Material and immaterial things and processes may be measured, e.g. the number of words in a text, or the duration of an event.
    /// [Scope Note for P39 measured (was measured by)CIDOC CRM version 5.1.2].</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC37_measured">mtlo:LC37_measured</a>
    /// </summary>
    let LC37_measured = _prefixId.prefix "LC37_measured"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC37_was_measured_by">mtlo:LC37_was_measured_by</a>
    /// </summary>
    let LC37_was_measured_by = _prefixId.prefix "LC37_was_measured_by"
    /// <summary>
    ///   <para>rdfs:comment : This property identifies the instances of Places that overlaps or fall within the area covered by another Place.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC38_folls_within_or_overlaps">mtlo:LC38_folls_within_or_overlaps</a>
    /// </summary>
    let LC38_folls_within_or_overlaps = _prefixId.prefix "LC38_folls_within_or_overlaps"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of E4 Period with the real (phenomenal) 4 dimensional point set (volume) in spacetime that it has occupied. The associated instance of E92 Spacetime Volume includes the trajectories of the participating physical things during their participation in the instance of E4 Period, the open spaces via which they have interacted and the spaces by which they had the potential to interact during that period or event in the way defined by the type of the respective period or event, such as the air in a meeting room transferring the voices. Another example are the areas controlled by some military power. In general, instances of E4 Period have fuzzy boundaries in spacetime.
    ///
    ///  [Scope Note P74 has current or former residence (is current or former residence of) CIDOC CRM].</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC43_occupied">mtlo:LC43_occupied</a>
    /// </summary>
    let LC43_occupied = _prefixId.prefix "LC43_occupied"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an instance of E4 Period with the real (phenomenal) 4 dimensional point set (volume) in spacetime that it has occupied. The associated instance of E92 Spacetime Volume includes the trajectories of the participating physical things during their participation in the instance of E4 Period, the open spaces via which they have interacted and the spaces by which they had the potential to interact during that period or event in the way defined by the type of the respective period or event, such as the air in a meeting room transferring the voices. Another example are the areas controlled by some military power. In general, instances of E4 Period have fuzzy boundaries in spacetime.
    ///
    ///  [Scope Note P74 has current or former residence (is current or former residence of) CIDOC CRM].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC44_has_temporal_projection">mtlo:LC44_has_temporal_projection</a>
    /// </summary>
    let LC44_has_temporal_projection = _prefixId.prefix "LC44_has_temporal_projection"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an instance of E4 Period with the real (phenomenal) 4 dimensional point set (volume) in spacetime that it has occupied. The associated instance of E92 Spacetime Volume includes the trajectories of the participating physical things during their participation in the instance of E4 Period, the open spaces via which they have interacted and the spaces by which they had the potential to interact during that period or event in the way defined by the type of the respective period or event, such as the air in a meeting room transferring the voices. Another example are the areas controlled by some military power. In general, instances of E4 Period have fuzzy boundaries in spacetime.
    ///
    /// [Scope Note P74 has current or former residence (is current or former residence of) CIDOC CRM].</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC45_has_spatial_projection">mtlo:LC45_has_spatial_projection</a>
    /// </summary>
    let LC45_has_spatial_projection = _prefixId.prefix "LC45_has_spatial_projection"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of E4 Period with the real (phenomenal) 4 dimensional point set (volume) in spacetime that it has occupied. The associated instance of E92 Spacetime Volume includes the trajectories of the participating physical things during their participation in the instance of E4 Period, the open spaces via which they have interacted and the spaces by which they had the potential to interact during that period or event in the way defined by the type of the respective period or event, such as the air in a meeting room transferring the voices. Another example are the areas controlled by some military power. In general, instances of E4 Period have fuzzy boundaries in spacetime.
    /// [Scope Note P74 has current or former residence (is current or former residence of) CIDOC CRM]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC46_observed_value">mtlo:LC46_observed_value</a>
    /// </summary>
    let LC46_observed_value = _prefixId.prefix "LC46_observed_value"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an instance of BC61 Capture Activity with an instance of BC3 Place at which the capture activity found or captured  things. It identifies the narrower spatial location in which a thing was found at. This maybe known or given in absolute terms or relative to the thing found. It describes a position within the area in which the instance of the encounter event occurred and found something.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC47_took_place_at">mtlo:LC47_took_place_at</a>
    /// </summary>
    let LC47_took_place_at = _prefixId.prefix "LC47_took_place_at"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of BC61 Capture Activity with an instance of BC3 Place at which the capture activity found or captured  things. It identifies the narrower spatial location in which a thing was found at. This maybe known or given in absolute terms or relative to the thing found. It describes a position within the area in which the instance of the encounter event occurred and found something.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC48_assigned_dimension">mtlo:LC48_assigned_dimension</a>
    /// </summary>
    let LC48_assigned_dimension = _prefixId.prefix "LC48_assigned_dimension"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an instance of BC1 TLO Entity with an instance of BC30 Appellation. This property is intended for names in general use. The property does not reveal anything about when, where and by whom this name was used. A more detailed representation can be made using the fully developed (i.e. indirect) path through BC46 Identifier Assignment.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC4_has_appellation">mtlo:LC4_has_appellation</a>
    /// </summary>
    let LC4_has_appellation = _prefixId.prefix "LC4_has_appellation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC4_is_appellation_of">mtlo:LC4_is_appellation_of</a>
    /// </summary>
    let LC4_is_appellation_of = _prefixId.prefix "LC4_is_appellation_of"
    /// <summary>
    ///   <para>rdfs:comment : This property describes the temporal bounds of an instance of an E2 Temporal Phenomenon.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC5_has_time_span">mtlo:LC5_has_time_span</a>
    /// </summary>
    let LC5_has_time_span = _prefixId.prefix "LC5_has_time_span"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC5_is_time_span_of">mtlo:LC5_is_time_span_of</a>
    /// </summary>
    let LC5_is_time_span_of = _prefixId.prefix "LC5_is_time_span_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property establishes a relationship of equivalence between two instances of E41 Appellation independent from any item identified by them. It is a dynamic asymmetric relationship, where the range expresses the derivative, if such a direction can be established. Otherwise, the relationship is symmetric. The relationship is not transitive.
    ///
    /// The equivalence applies to all cases of use of an instance of E41 Appellation. Multiple names assigned to an object, which are not equivalent for all things identified with a specific instance of E41 Appellation, should be modelled as repeated values of P1 is identified by (identifies).
    ///
    /// [Scope Note for P139 has alternative form CIDOC CRM version 5.1.2]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC6_has_alternative_form">mtlo:LC6_has_alternative_form</a>
    /// </summary>
    let LC6_has_alternative_form = _prefixId.prefix "LC6_has_alternative_form"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property documents that an E89 Propositional Object has as subject an instance of E1 CRM Entity.
    ///
    /// This differs from P67 refers to (is referred to by), which refers to an E1 CRM Entity, in that it describes the primary subject or subjects of an E89 Propositional Object.
    /// [Scope Note for P129 is about (is subject of) CIDOC CRM version 5.1.2]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC7_is_about">mtlo:LC7_is_about</a>
    /// </summary>
    let LC7_is_about = _prefixId.prefix "LC7_is_about"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property describes the active or passive presence of an E77 Persistent Item in an E5 Event without implying any specific role.
    ///
    /// It connects the history of a thing with the E53 Place and E50 Date of an event. For example, an object may be the desk, now in a museum on which a treaty was signed. The presence of an immaterial thing implies the presence of at least one of its carriers.
    ///
    /// [Scope Note for P12 occurred in the presence of (was present at) CIDOC CRM version 5.1.2]</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC8_occured_in_the_presence_of">mtlo:LC8_occured_in_the_presence_of</a>
    /// </summary>
    let LC8_occured_in_the_presence_of =
        _prefixId.prefix "LC8_occured_in_the_presence_of"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC8_was_present_at">mtlo:LC8_was_present_at</a>
    /// </summary>
    let LC8_was_present_at = _prefixId.prefix "LC8_was_present_at"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates the attribute that was assigned or the item that was related to the item denoted by a property P140 assigned attribute to in an Attribute assignment action.
    /// [Scope Note for P141 assigned (was assigned by) CIDOC CRM version 5.1.2]</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC9_assigned">mtlo:LC9_assigned</a>
    /// </summary>
    let LC9_assigned = _prefixId.prefix "LC9_assigned"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LC9_was_assigned_by">mtlo:LC9_was_assigned_by</a>
    /// </summary>
    let LC9_was_assigned_by = _prefixId.prefix "LC9_was_assigned_by"
    let LT1_usually_identifies = _prefixId.prefix "LT1_usually_identifies"
    /// <summary>
    ///   <para>rdfs:comment : This property describes the type of appellation of  a TLO entity type.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT1_usually_is_identified_by">mtlo:LT1_usually_is_identified_by</a>
    /// </summary>
    let LT1_usually_is_identified_by = _prefixId.prefix "LT1_usually_is_identified_by"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property describes the types of components   of an Temporal Phenomenon Type.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT2_usually_consists_of">mtlo:LT2_usually_consists_of</a>
    /// </summary>
    let LT2_usually_consists_of = _prefixId.prefix "LT2_usually_consists_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT2_usually_is_component_of">mtlo:LT2_usually_is_component_of</a>
    /// </summary>
    let LT2_usually_is_component_of = _prefixId.prefix "LT2_usually_is_component_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property connects the type of a biotic element with the type of the Ecosystem where it lives.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT3_usaually_is_component_of">mtlo:LT3_usaually_is_component_of</a>
    /// </summary>
    let LT3_usaually_is_component_of = _prefixId.prefix "LT3_usaually_is_component_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT3_usually_has_component">mtlo:LT3_usually_has_component</a>
    /// </summary>
    let LT3_usually_has_component = _prefixId.prefix "LT3_usually_has_component"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT4_usually_appears_to">mtlo:LT4_usually_appears_to</a>
    /// </summary>
    let LT4_usually_appears_to = _prefixId.prefix "LT4_usually_appears_to"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property connects the type of a biotic element with the type of a biotic element where it appears.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT4_usually_use_to_appear">mtlo:LT4_usually_use_to_appear</a>
    /// </summary>
    let LT4_usually_use_to_appear = _prefixId.prefix "LT4_usually_use_to_appear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property connects the types of predators with their prey type.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT5_usually_is_predator_of">mtlo:LT5_usually_is_predator_of</a>
    /// </summary>
    let LT5_usually_is_predator_of = _prefixId.prefix "LT5_usually_is_predator_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT5_usually_is_prey_of">mtlo:LT5_usually_is_prey_of</a>
    /// </summary>
    let LT5_usually_is_prey_of = _prefixId.prefix "LT5_usually_is_prey_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates a type of  a conceptual object such as propositions or appellations with an entity type.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT6_usually_is_about">mtlo:LT6_usually_is_about</a>
    /// </summary>
    let LT6_usually_is_about = _prefixId.prefix "LT6_usually_is_about"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT6_usually_is_subject_of">mtlo:LT6_usually_is_subject_of</a>
    /// </summary>
    let LT6_usually_is_subject_of = _prefixId.prefix "LT6_usually_is_subject_of"
    /// <summary>
    ///   <para>rdfs:comment : This property associates a type of activity with a type of actor.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT7_usually_is_carried_out_by">mtlo:LT7_usually_is_carried_out_by</a>
    /// </summary>
    let LT7_usually_is_carried_out_by = _prefixId.prefix "LT7_usually_is_carried_out_by"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT7_usually_performed">mtlo:LT7_usually_performed</a>
    /// </summary>
    let LT7_usually_performed = _prefixId.prefix "LT7_usually_performed"
    /// <summary>
    ///   <para>rdfs:comment : This property associates a type of biotic element with the type of biotic element which is part of or member.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT8_usually_belongs_to">mtlo:LT8_usually_belongs_to</a>
    /// </summary>
    let LT8_usually_belongs_to = _prefixId.prefix "LT8_usually_belongs_to"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LT8_usually_has_member">mtlo:LT8_usually_has_member</a>
    /// </summary>
    let LT8_usually_has_member = _prefixId.prefix "LT8_usually_has_member"
    /// <summary>
    ///   <para>rdfs:comment : This property describes the types of identifiers, names or labels of any marineTLO item type.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX1_is_identified_by">mtlo:LX1_is_identified_by</a>
    /// </summary>
    let LX1_is_identified_by = _prefixId.prefix "LX1_is_identified_by"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property documents that an instance of BC17 Conceptual Object is a subject of an instance of BT1 TLO Entity Type.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX2_is_about_type">mtlo:LX2_is_about_type</a>
    /// </summary>
    let LX2_is_about_type = _prefixId.prefix "LX2_is_about_type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property allows sub typing of MarineTLO entities - a form of specialisation – through the use of a terminological hierarchy, or thesaurus.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX3_has_type">mtlo:LX3_has_type</a>
    /// </summary>
    let LX3_has_type = _prefixId.prefix "LX3_has_type"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property associates an instance of BT1 TLO Entity Type with an instance of BC7 Appellation.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX4_has_appellation">mtlo:LX4_has_appellation</a>
    /// </summary>
    let LX4_has_appellation = _prefixId.prefix "LX4_has_appellation"

    /// <summary>
    ///   <para>rdfs:comment : This property indicates the type  of item to which an attribute or relation is assigned.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX6_assigned_attribute_to_type">mtlo:LX6_assigned_attribute_to_type</a>
    /// </summary>
    let LX6_assigned_attribute_to_type =
        _prefixId.prefix "LX6_assigned_attribute_to_type"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX6_type_was_attributed_by">mtlo:LX6_type_was_attributed_by</a>
    /// </summary>
    let LX6_type_was_attributed_by = _prefixId.prefix "LX6_type_was_attributed_by"
    /// <summary>
    ///   <para>rdfs:comment : This property identifies the type of Property   that is observed by an activity of BC45 Observation. It describes   assertions about types of properties of things.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX7_observed_propery">mtlo:LX7_observed_propery</a>
    /// </summary>
    let LX7_observed_propery = _prefixId.prefix "LX7_observed_propery"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX7_was_observed_in">mtlo:LX7_was_observed_in</a>
    /// </summary>
    let LX7_was_observed_in = _prefixId.prefix "LX7_was_observed_in"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This property declares the Language of a BC18 Proposition.</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX8_has_language">mtlo:LX8_has_language</a>
    /// </summary>
    let LX8_has_language = _prefixId.prefix "LX8_has_language"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#LX8_is_language_of">mtlo:LX8_is_language_of</a>
    /// </summary>
    let LX8_is_language_of = _prefixId.prefix "LX8_is_language_of"
    /// <summary>
    ///   <para>rdfs:comment : This property associates an entity to MarineTLO Environment with  abstraction levels where it is defined.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#O3_has_note">mtlo:O3_has_note</a>
    /// </summary>
    let O3_has_note = _prefixId.prefix "O3_has_note"
